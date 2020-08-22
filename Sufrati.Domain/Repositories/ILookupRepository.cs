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
    public interface ILookupRepository
    {
        Task<GeneralLookupValue> GetLookupValue(long id, CancellationToken ct = default);
        Task<List<GeneralLookupValue>> GetAllLookupValue(CancellationToken ct);
        Task<List<GeneralLookupType>> GetAllLookupType(CancellationToken ct);
        Task<GeneralLookupValue> AddGeneralLookup(GeneralLookupValue input, CancellationToken ct);
        Task<GeneralLookupValue> UpdateGeneralLookupAsync(GeneralLookupValue input, CancellationToken ct);
        Task<GeneralLookupType> GetLookupTypeByID(long id, CancellationToken ct);
        Task DeleteGeneralLookupAsync(long id, CancellationToken ct);
        Task<BaseVM> GetLookupInformation(long id, CancellationToken ct);

        Task<List<GeneralLookupValue>> GetLookupValueByTypeId(long typeId, CancellationToken ct = default);

    }
}
