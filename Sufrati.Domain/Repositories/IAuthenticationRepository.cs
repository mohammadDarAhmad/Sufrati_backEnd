
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;
using Sufrati.Domain.Entities;
using Sufrati.Domain.ApiModels;
using System.Linq.Expressions;

namespace Sufrati.Domain.Repositories
{
    public interface IAuthenticationRepository
    {
        Task<User> Authenticate(string loginName, CancellationToken ct = default);

    }
}
