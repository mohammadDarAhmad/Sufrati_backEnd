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
    public interface ISystemConstantRepository
    {
        Task<SystemConstant> GetSystemConstant(CancellationToken ct = default);
        Task<BaseVM> GetSystemConstantInformation(CancellationToken ct = default);
        Task<bool> UpdateSystemConstant(SystemConstant systemConstant, CancellationToken ct = default);

    }
}