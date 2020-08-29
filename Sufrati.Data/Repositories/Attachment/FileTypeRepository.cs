using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Sufrati.Data;
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
    public class FileTypeRepository : IFileTypeRepository
    {
        private readonly SufratiContext _context;
        public FileTypeRepository(SufratiContext context)
        {
            _context = context;
        }

        public async Task<FileType> AddAsync(FileType input, CancellationToken ct = default)
        {
            var entity = (await _context.FileType.AddAsync(input)).Entity;
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(long id, CancellationToken ct = default)
        {
            var result = await _context.FileType.FindAsync(id);
            _context.FileType.Remove(result);
            await _context.SaveChangesAsync();
        }

        public async Task<List<FileType>> GetALLAsync(CancellationToken ct = default)
        {
            return await _context.FileType.ToListAsync();
        }

        public async Task<List<FileType>> GetAllWithFilterAsync(Expression<Func<FileType, bool>> filter)
        {
            return await _context.FileType.Where(filter).ToListAsync();
        }

        public async Task<FileType> GetByIdAsync(long id, CancellationToken ct = default)
        {
            return await _context.FileType.Where(e => e.ID == id).FirstOrDefaultAsync();
        }
        public async Task<BaseVM> GetFileTypeInformation(long id, CancellationToken ct)
        {
            var result = await _context.FileType.FindAsync(id);
            return await GeneralMethod.GenerateInfoModel(result, _context);
        }
        public async Task<FileType> UpdateAsync(FileType input, CancellationToken ct = default)
        {
            var update = await _context.FileType.FirstAsync(g => g.ID == input.ID);
            input.CreatedByID = update.CreatedByID;
            input.CreatedDate = update.CreatedDate;
            _context.Entry(update).CurrentValues.SetValues(input);
            await _context.SaveChangesAsync(ct);
            return update;
        }
    }
}
