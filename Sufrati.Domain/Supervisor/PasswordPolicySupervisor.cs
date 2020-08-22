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
        public async Task<PasswordPolicyVM> AddPasswordPolicy(PasswordPolicyVM passwordPolicyVM, IHttpContextAccessor accessor, ClaimsPrincipal user, CancellationToken ct = default)
        {
            var passwordPolicy = _Mapper.Map<PasswordPolicyVM, PasswordPolicy>(passwordPolicyVM);
            GeneralMethod.AddBaseProperties<PasswordPolicy>(passwordPolicy, accessor, user, true);
            var newPasswordPolicy = await _PasswordPolicyRepository.AddPasswordPolicy(passwordPolicy, accessor, ct);

            return _Mapper.Map<PasswordPolicy, PasswordPolicyVM>(newPasswordPolicy);
        }
        public async Task<List<PasswordPolicyVM>> GetPasswordPolicys(CancellationToken ct = default)
        {
            var passwordPolicys = await _PasswordPolicyRepository.GetPasswordPolicys(ct);
            var result = _Mapper.Map<List<PasswordPolicyVM>>(passwordPolicys);
            return result;
        }
        public async Task<PasswordPolicyVM> GetPasswordPolicyById(long id, CancellationToken ct = default)
        {
            var result = await _PasswordPolicyRepository.GetPasswordPolicyById(id, ct);
            return _Mapper.Map<PasswordPolicy, PasswordPolicyVM>(result);
        }

        public async Task<BaseVM> GetPasswordPolicyInformation(long id, CancellationToken ct = default)
        {
            var result = await _PasswordPolicyRepository.GetPasswordPolicyInformation(id, ct);
            return result;
        }

        public async Task<bool> UpdatePasswordPolicy(PasswordPolicyVM passwordPolicyVM, IHttpContextAccessor accessor, ClaimsPrincipal user, CancellationToken ct = default)
        {
            var passwordPolicy = _Mapper.Map<PasswordPolicyVM, PasswordPolicy>(passwordPolicyVM);
            GeneralMethod.AddBaseProperties<PasswordPolicy>(passwordPolicy, accessor, user, false);
            return await _PasswordPolicyRepository.UpdatePasswordPolicy(passwordPolicy, accessor, ct);
        }
        public async Task<bool> DeletePasswordPolicy(long id, CancellationToken ct = default)
        {
            return await _PasswordPolicyRepository.DeletePasswordPolicy(id, ct);
        }
    }
}
