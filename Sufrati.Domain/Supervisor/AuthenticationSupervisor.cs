using Microsoft.AspNetCore.Http;
using Sufrati.Domain.ApiModels;
using Sufrati.Domain.Entities;
using Sufrati.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace Sufrati.Domain.Supervisor
{
    public partial class SufratiSupervisor : ISufratiSupervisor

    {
        public async Task<User> Authentication(UserLoginVM userLogin, IHttpContextAccessor _accessor, CancellationToken ct = default)
        {

            User user = await _AuthenticationRepository.Authenticate(userLogin.LoginName, ct);
            if (user == null)
                throw new Exception();
            else
            {
                if (!user.IsActive)
                    throw new Exception();

                var policypassword = await _PasswordPolicyRepository.GetPasswordPolicyById(user.PasswordPolicyID);
                if (user.NumberOfWrongLogin >= (policypassword.SuspendPasswordAfter - 1))
                {
                    user.IsActive = false;
                    user.NumberOfWrongLogin = 0;
                    await _UserRepository.updateUserStatusLogin(user.ID, user.IsActive, user.NumberOfWrongLogin, ct);
                    throw new Exception();
                }
            }

            if (!VerifyPasswordHash(userLogin.Password, user.Password))
            {
                user.NumberOfWrongLogin++;
                await _UserRepository.updateUserStatusLogin(user.ID, true, user.NumberOfWrongLogin, ct);
                throw new Exception();

            }
            else
            {
                await _UserRepository.updateUserStatusLogin(user.ID, true, 0, ct);

            }
            var listUser = _UserRepository.GetUsers(ct);
            //var checkPassActive = CheckPermission.GetUserDictionary(listUser.Result);
            //if (user.PasswordActive && checkPassActive.ContainsKey(user.ID))
            //    checkPassActive.Remove(user.ID);

            return user;
        }
        //public async Task<List<long>> GetUserPermissionForLogin(long id, IHttpContextAccessor accessor, CancellationToken ct = default)
        //{
        //    var userAction = await _UserRepository.GetUserAction(id, ct);

        //    //var result = _Mapper.Map<Dictionary<long, ActionVM>>(userAction);

        //    return userAction;

        //}
  
    }
}
