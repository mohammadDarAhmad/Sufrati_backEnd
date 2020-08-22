
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
    public interface IUserRepository
    {
        Task<User> AddUser(User user, IHttpContextAccessor accessor, CancellationToken ct = default);
        Task<List<User>> GetUsers(CancellationToken ct = default);
        Task<List<GeneralLookupValue>> GetUserTypes(CancellationToken ct = default);
        Task<User> GetUserById(long id, CancellationToken ct = default);
        Task<BaseVM> GetUserInformation(long id, CancellationToken ct = default);
        Task<bool> UpdateUser(User user, IHttpContextAccessor accessor, CancellationToken ct = default);
        Task<bool> DeleteUser(long id, CancellationToken ct = default);
    }
}
