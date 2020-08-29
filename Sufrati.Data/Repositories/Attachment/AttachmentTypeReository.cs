using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Sufrati.Domain.ApiModels;
using Sufrati.Domain.Entities;
using Sufrati.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace Sufrati.Data.Repositories
{
    public class AttachmentTypeReository : IAttachmentTypeReository
    {
        private readonly SufratiContext _context;
        public AttachmentTypeReository(SufratiContext context)
        {
            _context = context;
        }

        public async Task<AttachmentType> AddAsync(AttachmentType input, CancellationToken ct = default)
        {
            var entity = (await _context.AttachmentType.AddAsync(input)).Entity;
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(long id, CancellationToken ct = default)
        {
            var result = await _context.AttachmentType.FindAsync(id);
            _context.AttachmentType.Remove(result);
            await _context.SaveChangesAsync();
        }

        public async Task<List<AttachmentType>> GetALLAsync(CancellationToken ct = default)
        {
            return await _context.AttachmentType.Include(e => e.FileTypes).ThenInclude(e => e.FileType).ToListAsync();
        }

        public async Task<List<AttachmentType>> GetAllWithFilterAsync(Expression<Func<AttachmentType, bool>> filter)
        {
            return await _context.AttachmentType.Where(filter).Include(e => e.FileTypes).ThenInclude(e => e.FileType).ToListAsync();
        }

        public async Task<AttachmentType> GetByIdAsync(long id, CancellationToken ct = default)
        {
            return await _context.AttachmentType.Include(e => e.FileTypes).ThenInclude(e => e.FileType).Where(e => e.ID == id).FirstOrDefaultAsync();
        }
        public async Task<BaseVM> GetAttacjmentTypeInformation(long id, CancellationToken ct)
        {
            var result = await _context.AttachmentType.FindAsync(id);
            return await GeneralMethod.GenerateInfoModel(result, _context);
        }
        public async Task<AttachmentType> UpdateAsync(AttachmentType input, CancellationToken ct = default)
        {
            var update = await _context.AttachmentType.FirstAsync(g => g.ID == input.ID);
            input.CreatedByID = update.CreatedByID;
            input.CreatedDate = update.CreatedDate;
            _context.Entry(update).CurrentValues.SetValues(input);
            await _context.SaveChangesAsync(ct);
            return update;
        }
    }
}
