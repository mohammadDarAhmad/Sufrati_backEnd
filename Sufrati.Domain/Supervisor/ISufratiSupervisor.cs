using Sufrati.Domain.ApiModels;
using Sufrati.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;

namespace Sufrati.Domain.Supervisor
{
    public interface ISufratiSupervisor
    {
        #region User
        Task<UserVM> AddUser(UserVM userVM, IHttpContextAccessor accessor, ClaimsPrincipal user, CancellationToken ct = default);
        Task<GeneralUserVM> GetUsers(CancellationToken ct = default);
        Task<UserVM> GetUserById(long id, CancellationToken ct = default);
        Task<BaseVM> GetUserInformation(long id, CancellationToken ct = default);
        Task<bool> UpdateUser(UserVM userVM, IHttpContextAccessor accessor, ClaimsPrincipal user, CancellationToken ct = default);
        Task<bool> DeleteUser(long id, CancellationToken ct = default);
        #endregion


        #region PasswordPolicy
        Task<PasswordPolicyVM> AddPasswordPolicy(PasswordPolicyVM passwordPolicyVM, IHttpContextAccessor accessor, ClaimsPrincipal user, CancellationToken ct = default);
        Task<List<PasswordPolicyVM>> GetPasswordPolicys(CancellationToken ct = default);
        Task<PasswordPolicyVM> GetPasswordPolicyById(long id, CancellationToken ct = default);
        Task<BaseVM> GetPasswordPolicyInformation(long id, CancellationToken ct = default);
        Task<bool> UpdatePasswordPolicy(PasswordPolicyVM passwordPolicyVM, IHttpContextAccessor accessor, ClaimsPrincipal user, CancellationToken ct = default);
        Task<bool> DeletePasswordPolicy(long id, CancellationToken ct = default);

        #endregion

        #region Group
        Task<GroupVM> AddGroup(GroupVM groupVM, IHttpContextAccessor accessor, ClaimsPrincipal user, CancellationToken ct = default);
        Task<GeneralGroupVM> GetGroups(CancellationToken ct = default);
        Task<GroupVM> GetGroupById(long id, CancellationToken ct = default);
        Task<BaseVM> GetGroupInformation(long id, CancellationToken ct = default);
        Task<bool> UpdateGroup(GroupVM groupVM, IHttpContextAccessor accessor, ClaimsPrincipal user, CancellationToken ct = default);
        Task<bool> DeleteGroup(long id, CancellationToken ct = default);

        #endregion

        #region GeneralLookups
        Task<GeneralLookupValueForView> GetLookupValue(long id, CancellationToken ct = default);
        Task<GeneralLookupsVM> GetGeneralLookupsVM(CancellationToken ct);
        Task<GeneralLookupValueVM> AddGeneralLookup(GeneralLookupValueVM input, IHttpContextAccessor accessor, ClaimsPrincipal user, CancellationToken ct);
        Task<GeneralLookupValueForView> UpdateGeneralLookupAsync(GeneralLookupValueVM input, IHttpContextAccessor accessor, ClaimsPrincipal user, CancellationToken ct);
        Task DeleteGeneralLookupAsync(long id, CancellationToken ct);
        Task<BaseVM> GetLookupInformation(long id, CancellationToken ct = default);
        #endregion

    }
}
