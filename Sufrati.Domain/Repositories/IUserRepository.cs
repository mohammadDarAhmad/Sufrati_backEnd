
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
        Task<User> GetUserById(long id, CancellationToken ct = default);
         Task<User> AddUser(User user, CancellationToken ct = default);
        Task<bool> RsetPassVM(long userId, bool passwordActive, string passwordHash, CancellationToken ct = default);
        Task<User> GetPassword(long userId, CancellationToken ct = default);
        Task<bool> updateUserStatusLogin(long userId, bool isActive, long NoumberOfLogin, CancellationToken ct = default);
        Task<bool> changePassVM(long userId, string passwordHash, CancellationToken ct = default);
        Task<List<User>> GetUsers(CancellationToken ct = default);
        Task<List<GeneralLookupValue>> GetUserTypes(CancellationToken ct = default);
        Task<BaseVM> GetUserInformation(long id, CancellationToken ct = default);
        Task<bool> UpdateUser(User user, CancellationToken ct = default);
        Task<bool> DeleteUser(long id, CancellationToken ct = default);
  
    }
}
