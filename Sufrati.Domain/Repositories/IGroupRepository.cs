
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
    public interface IGroupRepository
    {
        Task<Groups> AddGroup(Groups group, List<User> users, IHttpContextAccessor accessor, CancellationToken ct = default);
        Task<List<Groups>> GetGroups(CancellationToken ct = default);
        Task<Groups> GetGroupById(long id, CancellationToken ct = default);
        Task<BaseVM> GetGroupInformation(long id, CancellationToken ct = default);
        Task<List<User>> GetUsers(CancellationToken ct = default);
        Task<bool> UpdateGroup(Groups group, CancellationToken ct = default);
        Task<bool> DeleteGroup(long id, CancellationToken ct = default);
        Task<bool> RemoveUsersFromGroup(long id, List<long> usersId, CancellationToken ct = default);
        Task<bool> AddUsersForGroup(List<UserGroup> userGroups, CancellationToken ct = default);

    }
}
