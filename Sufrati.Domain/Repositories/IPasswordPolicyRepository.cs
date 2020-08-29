
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;
using Sufrati.Domain.Entities;
using Sufrati.Domain.ApiModels;

namespace Sufrati.Domain.Repositories
{
    public interface IPasswordPolicyRepository
    {
        Task<PasswordPolicy> AddPasswordPolicy(PasswordPolicy passwordPolicy, IHttpContextAccessor accessor, CancellationToken ct = default);
        Task<List<PasswordPolicy>> GetPasswordPolicys(CancellationToken ct = default);
        Task<PasswordPolicy> GetPasswordPolicyById(long id, CancellationToken ct = default);
        Task<BaseVM> GetPasswordPolicyInformation(long id, CancellationToken ct = default);
        Task<bool> UpdatePasswordPolicy(PasswordPolicy passwordPolicy, CancellationToken ct = default);
        Task<bool> DeletePasswordPolicy(long id, CancellationToken ct = default);

    }
}
