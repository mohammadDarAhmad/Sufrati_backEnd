using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Sufrati.Domain.ApiModels;
using Sufrati.Domain.Entities;
using Sufrati.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sufrati.Data.Repositories
{

    public class LookupRepository : ILookupRepository
    {
        private readonly SufratiContext _context;
        public LookupRepository(SufratiContext context)
        {
            _context = context;
        }

        public async Task<BaseVM> GetLookupInformation(long id, CancellationToken ct)
        {
            var result = await _context.GeneralLookupValue.FindAsync(id);

            return await GeneralMethod.GenerateInfoModel(result, _context);
        }

        public async Task<GeneralLookupValue> AddGeneralLookup(GeneralLookupValue input, CancellationToken ct)
        {
            _context.GeneralLookupValue.Add(input);
            await _context.SaveChangesAsync(ct);
            return input;
        }

        public async Task<List<GeneralLookupType>> GetAllLookupType(CancellationToken ct)
        {
            return await _context.GeneralLookupType.Include(e => e.GeneralLookupValues).ToListAsync(ct);
        }

        public async Task<GeneralLookupType> GetLookupTypeByID(long id, CancellationToken ct)
        {
            return await _context.GeneralLookupType.FindAsync(id);
        }

        public async Task<List<GeneralLookupValue>> GetAllLookupValue(CancellationToken ct)
        {
            return await _context.GeneralLookupValue.Include(e => e.GeneralLookupType).ToListAsync(ct);
        }

        public async Task<GeneralLookupValue> GetLookupValue(long id, CancellationToken ct = default)
        {
            var result = await _context.GeneralLookupValue.Where(a => a.ID == id).Include(e => e.GeneralLookupType).FirstOrDefaultAsync();
            return result;
        }

        public async Task<GeneralLookupValue> UpdateGeneralLookupAsync(GeneralLookupValue input, CancellationToken ct)
        {
            var update = _context.GeneralLookupValue.Update(input);
            update.Property(e => e.CreatedByID).IsModified = false;
            update.Property(e => e.Created_Date).IsModified = false;
            await _context.SaveChangesAsync(ct);
            return input;
        }

        public async Task DeleteGeneralLookupAsync(long id, CancellationToken ct)
        {
            var lookupValue = await _context.GeneralLookupValue.FirstOrDefaultAsync(x => x.ID == id);
            _context.GeneralLookupValue.Remove(lookupValue);
            await _context.SaveChangesAsync(ct);
        }

        //Added by Hania
        public async Task<List<GeneralLookupValue>> GetLookupValueByTypeId(long typeId, CancellationToken ct = default)
        {
            var result = await _context.GeneralLookupValue.Where(a => a.GeneralLookupTypeID == typeId).Include(e => e.GeneralLookupType).ToListAsync();
            return result;
        }

    }
}
