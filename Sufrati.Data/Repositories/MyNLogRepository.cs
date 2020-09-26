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
    public class MyNLogRepository: IMyNLogRepository
    {
        private readonly SufratiContext _context;
        public MyNLogRepository(SufratiContext context)
        {
            _context = context;
        }

        public async Task AddLogoutValue(string token, CancellationToken ct = default)
        {
            var update = await _context.MyNLog.FirstOrDefaultAsync(g => g.Token == token);         
            update.LogoutTime = DateTime.Now;
            _context.Entry(update).CurrentValues.SetValues(update);
            await _context.SaveChangesAsync();
        }

        public async Task<List<MyNLog>> GetBetweentwoDatesAndType(DateTime fromDate, DateTime toDate, long typeID, CancellationToken ct = default)
        {
            return await _context.MyNLog.Include(e=>e.LogType).Include(e=>e.User).Include(e=>e.PasswordChangedByUser).Where(e => e.LogDate >= fromDate && e.LogDate <= toDate && e.LogTypeID == typeID).ToListAsync();
        }

        public async Task<MyNLog> GetByDateAsync(string dateTime, CancellationToken ct = default)
        {
            var result = await _context.MyNLog.ToListAsync();
            var x = result.Where(r => r.LogDate.ToString("M/d/yyyy hh:mm:ss.ss tt").Equals(dateTime)).FirstOrDefault();
            return x;
        }
    }
}
