using Microsoft.AspNetCore.Http;
using Sufrati.Domain.ApiModels;
using Sufrati.Domain.Entities;
using Sufrati.Domain.Repositories;
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

        public async Task<BaseVM> GetLookupInformation(long id, CancellationToken ct = default)
        {
            var result = await _LookupRepository.GetLookupInformation(id, ct);

            return result;
        }

        public async Task<GeneralLookupValueForView> GetLookupValue(long id, CancellationToken ct = default)
        {
            return _Mapper.Map<GeneralLookupValueForView>(await _LookupRepository.GetLookupValue(id, ct));
        }


        public async Task<GeneralLookupsVM> GetGeneralLookupsVM(CancellationToken ct)

        {
            var allLookupValue = await _LookupRepository.GetAllLookupValue(ct);
            var allLookupType = await _LookupRepository.GetAllLookupType(ct);
            var result = new GeneralLookupsVM
            {
                GeneralLookupTypesVM = _Mapper.Map<List<GeneralLookupTypeVM>>(allLookupType),
                GeneralLookupValuesVM = _Mapper.Map<List<GeneralLookupValueForView>>(allLookupValue)
            };
            return result;

        }
        public async Task<GeneralLookupValueForView> GetClassificationByCategory(CancellationToken ct)

        {
      
          return _Mapper.Map<GeneralLookupValueForView>(await _LookupRepository.GetLookupValue(105000000000002, ct));


        }
        public async Task<GeneralLookupValueVM> AddGeneralLookup(GeneralLookupValueVM input, IHttpContextAccessor accessor, ClaimsPrincipal user, CancellationToken ct)
        {
            var lookuptype = await _LookupRepository.GetLookupTypeByID(input.GeneralLookupTypeID, ct);

            if (lookuptype == null)
            {
                throw new ArgumentException($"lookuptype with id:{input.GeneralLookupTypeID} not found", nameof(input.GeneralLookupTypeID));
            }
            var lookup = _Mapper.Map<GeneralLookupValue>(input);
            GeneralMethod.AddBaseProperties<GeneralLookupValue>(lookup, accessor, user, true);
            var newLookup = await _LookupRepository.AddGeneralLookup(lookup, ct);

            return _Mapper.Map<GeneralLookupValueVM>(newLookup);

        }

        public async Task<GeneralLookupValueForView> UpdateGeneralLookupAsync(GeneralLookupValueVM input, IHttpContextAccessor accessor, ClaimsPrincipal user, CancellationToken ct)
        {
            var lookuptype = await _LookupRepository.GetLookupTypeByID(input.GeneralLookupTypeID, ct);

            if (lookuptype == null)
            {
                throw new ArgumentException($"lookuptype with id:{input.GeneralLookupTypeID} not found", nameof(input.GeneralLookupTypeID));
            }

            var gLUpdate = _Mapper.Map<GeneralLookupValue>(input);
            GeneralMethod.AddBaseProperties<GeneralLookupValue>(gLUpdate, accessor, user, false);
            return _Mapper.Map<GeneralLookupValueForView>(await _LookupRepository.UpdateGeneralLookupAsync(gLUpdate, ct));
        }


        public async Task DeleteGeneralLookupAsync(long id, CancellationToken ct)
        {
            var lookupvalue = await _LookupRepository.GetLookupValue(id, ct);

            if (lookupvalue == null)
            {
                throw new ArgumentException($"lookup value with id {id} is not found", "id");
            }

            await _LookupRepository.DeleteGeneralLookupAsync(id, ct);
        }



    }
}