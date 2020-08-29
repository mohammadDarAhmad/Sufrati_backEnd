using Microsoft.AspNetCore.Http;
using Sufrati.Domain.ApiModels;
using Sufrati.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Claims;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sufrati.Domain.Supervisor
{
    public partial class SufratiSupervisor : ISufratiSupervisor

    {
        public async Task AddAttachmentToUser(long attachmentID, IHttpContextAccessor accessor, ClaimsPrincipal user, CancellationToken ct = default)
        {
            var userId = GeneralMethod.GetUserID(user);
            if (userId == -1)
            {
                throw new Exception();
            }
            else
            {
                var userEntity = await _UserRepository.GetUserById(userId);
                userEntity.UserImageID = attachmentID;
                GeneralMethod.AddBaseProperties(userEntity, accessor, user, false);
                await _UserRepository.UpdateUser(userEntity);
            }
        }

        public async Task AddAttachmentToUser(long userId, long attachmentID, IHttpContextAccessor accessor, ClaimsPrincipal user, CancellationToken ct = default)
        {
            var userEntity = await _UserRepository.GetUserById(userId);
            userEntity.UserImageID = attachmentID;
            GeneralMethod.AddBaseProperties(userEntity, accessor, user, false);
            await _UserRepository.UpdateUser(userEntity);
        }

        public async Task<UserVM> AddUser(UserVM userVM, IHttpContextAccessor accessor, ClaimsPrincipal user, CancellationToken ct = default)
        {
            var userInput = _Mapper.Map<UserVM, User>(userVM);
            GeneralMethod.AddBaseProperties<User>(userInput, accessor, user, true);

            //check loginName
            if (string.IsNullOrEmpty(userInput.LoginName) || userInput.LoginName.Length < 3)
                throw new Exception();


            //check if password match password policy
            GeneralMethod.CheckPassword(userInput.Password, userInput.PasswordPolicyID, _PasswordPolicyRepository);

            userInput.Password = GeneralMethod.PasswordEncryption(userInput.Password, null);

            var newUser = new User();

            newUser = await _UserRepository.AddUser(userInput, ct);

            return _Mapper.Map<User, UserVM>(newUser);


        }
        public async Task<bool> ChangePassword(ChangePassVM changePassVM, IHttpContextAccessor _accessor, ClaimsPrincipal User, CancellationToken ct = default)
        {


            var userId = GeneralMethod.GetUserID(User);
            User user = await _UserRepository.GetPassword(userId, ct);
            if (user == null)
                throw new Exception();

            //check if password match password policy
            GeneralMethod.CheckPassword(changePassVM.NewPassword, user.PasswordPolicyID, _PasswordPolicyRepository);

            if (VerifyPasswordHash(changePassVM.OldPassword, user.Password))
            {
                if (changePassVM.NewPassword.Equals(changePassVM.ReNewPassword))
                {
                    var passwordHash = GeneralMethod.PasswordEncryption(changePassVM.NewPassword, null);

                    var result = await _UserRepository.changePassVM(userId, passwordHash, ct);

                    return result;

                }
                else
                    throw new Exception();

            }
            else
                throw new Exception();

        }
        public async Task<bool> ResetPassword(long userId, string newPassword, IHttpContextAccessor _accessor,
            ClaimsPrincipal user, CancellationToken ct = default)
        {
            var userPolicy = await _UserRepository.GetUserById(userId, ct);

            //check if password match password policy
            GeneralMethod.CheckPassword(newPassword, userPolicy.PasswordPolicyID, _PasswordPolicyRepository);

            var passwordHash = GeneralMethod.PasswordEncryption(newPassword, null);
            var result = await _UserRepository.RsetPassVM(userId, false, passwordHash, ct);
            var policy = await _PasswordPolicyRepository.GetPasswordPolicyById(userPolicy.PasswordPolicyID);
            if (policy.FirstLoginChangePassword)
            {
                var listUser = _UserRepository.GetUsers(ct);
              
            }
            return result;
        }

        public async Task<GeneralUserVM> GetUsers(CancellationToken ct = default)
        {
            var Users = await _UserRepository.GetUsers(ct);
            var UserTypes = await _UserRepository.GetUserTypes(ct);
            var PasswordPolicies = await _PasswordPolicyRepository.GetPasswordPolicys(ct);

            var result = new GeneralUserVM()
            {
                Users = _Mapper.Map<List<UserVMForView>>(Users),
                UserTypes = _Mapper.Map<List<GeneralLookupValueVM>>(UserTypes),
                PasswordPolicies = _Mapper.Map<List<PasswordPolicyVM>>(PasswordPolicies),
            };
            return result;
        }

        public async Task<UserDetailsVM> GetUserById(long id, CancellationToken ct = default)
        {
            var user = await _UserRepository.GetUserById(id, ct);
            var UserTypes = await _UserRepository.GetUserTypes(ct);
            var PasswordPolicies = await _PasswordPolicyRepository.GetPasswordPolicys(ct);

            var result = new UserDetailsVM()
            {
                User = _Mapper.Map<UserVM>(user),
                UserTypes = _Mapper.Map<List<GeneralLookupValueVM>>(UserTypes),
                PasswordPolicies = _Mapper.Map<List<PasswordPolicyVM>>(PasswordPolicies),
            };
            return result;
        }
        public async Task<PasswordPolicyVM> GetPolicy(long id, CancellationToken ct = default)
        {
            var result = await _UserRepository.GetUserById(id, ct);
            var policy = await _PasswordPolicyRepository.GetPasswordPolicyById(result.PasswordPolicyID, ct);
            return _Mapper.Map<PasswordPolicyVM>(policy);
        }
       
        public async Task<BaseVM> GetUserInformation(long id, CancellationToken ct = default)
        {
            var result = await _UserRepository.GetUserInformation(id, ct);
            return result;
        }

        public async Task<bool> UpdateUser(UserForViewVM userVM, IHttpContextAccessor accessor, ClaimsPrincipal user, CancellationToken ct = default)
        {
            var User = _Mapper.Map<UserForViewVM, User>(userVM);
            GeneralMethod.AddBaseProperties<User>(User, accessor, user, false);

            if (string.IsNullOrEmpty(User.LoginName) || User.LoginName.Length < 3)
                throw new Exception();

            return await _UserRepository.UpdateUser(User, ct);
        }

        public async Task<bool> DeleteUser(long id, CancellationToken ct = default)
        {
            return await _UserRepository.DeleteUser(id, ct);

        }
        private static bool VerifyPasswordHash(string password, string storedHash)
        {

            string[] hash = storedHash.Split(':');
            string Salt = hash[0];
            string hashed = hash[1];
            var passwordHash = GeneralMethod.PasswordEncryption(password, Salt);
            if (passwordHash.Equals(storedHash))
                return true;
            else
                return false;
        }
    }
}
