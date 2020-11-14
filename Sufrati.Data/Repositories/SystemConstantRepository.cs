using Microsoft.EntityFrameworkCore;
using Sufrati.Domain.ApiModels;
using Sufrati.Domain.Entities;
using Sufrati.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sufrati.Data.Repositories
{
    public class SystemConstantRepository : ISystemConstantRepository
    {
        private readonly SufratiContext _context;
        public SystemConstantRepository(SufratiContext context)
        {
            _context = context;
        }
        public async Task<SystemConstant> GetSystemConstant(CancellationToken ct = default)
        {
            var constant =  await _context.SystemConstant.SingleOrDefaultAsync();
            return constant;
        }
        public async Task<BaseVM> GetSystemConstantInformation(CancellationToken ct = default)
        {

            return await GeneralMethod.GenerateInfoModel(await _context.SystemConstant.SingleOrDefaultAsync(), _context);
        }
        public async Task<bool> UpdateSystemConstant(SystemConstant systemConstant, CancellationToken ct = default)
        {
            var update = await _context.SystemConstant.FirstAsync(g => g.ID == systemConstant.ID);
            systemConstant.CreatedByID = update.CreatedByID;
            systemConstant.CreatedDate = update.CreatedDate;

            _context.Entry(update).CurrentValues.SetValues(systemConstant);
            await _context.SaveChangesAsync();

            return true;
        }

    }
}
