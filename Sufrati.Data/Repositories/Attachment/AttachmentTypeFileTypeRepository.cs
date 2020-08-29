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
    public class AttachmentTypeFileTypeRepository : IAttachmentTypeFileTypeRepository
    {
        private readonly SufratiContext _context;
        public AttachmentTypeFileTypeRepository(SufratiContext context)
        {
            _context = context;
        }

        public async Task<AttachmentTypeFileType> AddAsync(AttachmentTypeFileType input, CancellationToken ct = default)
        {
            var entity = (await _context.AttachmentTypeFileType.AddAsync(input)).Entity;
            await _context.SaveChangesAsync();
            return entity;
        }
        public async Task<List<AttachmentTypeFileType>> AddRangeAsync(List<AttachmentTypeFileType> input, CancellationToken ct = default)
        {
            await _context.AttachmentTypeFileType.AddRangeAsync(input);
            await _context.SaveChangesAsync();
            return input;
        }
        public async Task DeleteAsync(long id, CancellationToken ct = default)
        {
            var result = await _context.AttachmentTypeFileType.FindAsync(id);
            _context.AttachmentTypeFileType.Remove(result);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteRange(List<AttachmentTypeFileType> inputs, CancellationToken ct = default)
        {
            _context.AttachmentTypeFileType.RemoveRange(inputs);
            await _context.SaveChangesAsync();
        }

        public async Task<List<AttachmentTypeFileType>> GetALLAsync(CancellationToken ct = default)
        {
            return await _context.AttachmentTypeFileType
                       .Include(e => e.FileType)
                       .Include(e => e.AttachmentType)
                       .ToListAsync();
        }

        public async Task<List<AttachmentTypeFileType>> GetAllWithFilterAsync(Expression<Func<AttachmentTypeFileType, bool>> filter)
        {
            return await _context.AttachmentTypeFileType                  
                       .Where(filter).AsNoTracking().ToListAsync();
        }

        public async Task<AttachmentTypeFileType> GetByIdAsync(long id, CancellationToken ct = default)
        {
            return await _context.AttachmentTypeFileType
                       .Include(e => e.FileType)
                       .Include(e => e.AttachmentType)
                       .Where(e => e.ID == id).FirstOrDefaultAsync();
        }

        public async Task<AttachmentTypeFileType> UpdateAsync(AttachmentTypeFileType input, CancellationToken ct = default)
        {
            var update = await _context.AttachmentTypeFileType.FirstAsync(g => g.ID == input.ID);
            input.CreatedByID = update.CreatedByID;
            input.CreatedDate = update.CreatedDate;

            _context.Entry(update).CurrentValues.SetValues(input);
            await _context.SaveChangesAsync(ct);
            return update;
        }
    }
}
