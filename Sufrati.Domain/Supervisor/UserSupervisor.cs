using Microsoft.AspNetCore.Http;
using Sufrati.Domain.ApiModels;
using Sufrati.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sufrati.Domain.Supervisor
{
    public partial class SufratiSupervisor : ISufratiSupervisor

    {
        public async Task<UserVM> AddUser(UserVM userVM, IHttpContextAccessor accessor, ClaimsPrincipal user, CancellationToken ct = default)
        {
            var userInput = _Mapper.Map<UserVM, User>(userVM);
            GeneralMethod.AddBaseProperties<User>(userInput, accessor, user, true);
            //Encrypt the password..
            userInput.Password = GeneralMethod.PasswordEncryption(userInput.Password);

            var newUser = await _UserRepository.AddUser(userInput, accessor, ct);

            return _Mapper.Map<User, UserVM>(newUser);
        }
        public async Task<GeneralUserVM> GetUsers(CancellationToken ct = default)
        {
            var result = new GeneralUserVM();

            try
            {
                var Users = await _UserRepository.GetUsers(ct);
                var UserTypes = await _UserRepository.GetUserTypes(ct);
                var PasswordPolicies = await _PasswordPolicyRepository.GetPasswordPolicys(ct);

                 result = new GeneralUserVM()
                {
                    Users = _Mapper.Map<List<UserVMForView>>(Users),
                    UserTypes = _Mapper.Map<List<GeneralLookupValueVM>>(UserTypes),
                    PasswordPolicies = _Mapper.Map<List<PasswordPolicyInnerVM>>(PasswordPolicies),
                };
                return result;


            }
            catch
            {

            }
            return result;

        }
        public async Task<UserVM> GetUserById(long id, CancellationToken ct = default)
        {
            var result = await _UserRepository.GetUserById(id, ct);
            return _Mapper.Map<UserVM>(result);
        }

        public async Task<BaseVM> GetUserInformation(long id, CancellationToken ct = default)
        {
            var result = await _UserRepository.GetUserInformation(id, ct);
            return result;
        }

        public async Task<bool> UpdateUser(UserVM userVM, IHttpContextAccessor accessor, ClaimsPrincipal user, CancellationToken ct = default)
        {
            var User = _Mapper.Map<UserVM, User>(userVM);
            GeneralMethod.AddBaseProperties<User>(User, accessor, user, false);
            return await _UserRepository.UpdateUser(User, accessor, ct);
        }
        public async Task<bool> DeleteUser(long id, CancellationToken ct = default)
        {
            return await _UserRepository.DeleteUser(id, ct);
        }
    }
}

