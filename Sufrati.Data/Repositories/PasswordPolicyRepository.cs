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
    public class PasswordPolicyRepository : IPasswordPolicyRepository
    {
        private readonly SufratiContext _context;
        public PasswordPolicyRepository(SufratiContext context)
        {
            _context = context;
        }

        public async Task<PasswordPolicy> AddPasswordPolicy(PasswordPolicy input, IHttpContextAccessor accessor, CancellationToken ct = default)
        {
            _context.PasswordPolicy.Add(input);
            await _context.SaveChangesAsync(ct);
            return input;
        }

        public async Task<bool> DeletePasswordPolicy(long id, CancellationToken ct = default)
        {
            var Obj = await GetPasswordPolicyById(id, ct);
            _context.PasswordPolicy.Remove(Obj);
            await _context.SaveChangesAsync(ct);
            return true;

        }

        public async Task<PasswordPolicy> GetPasswordPolicyById(long id, CancellationToken ct = default)
        {
            var result = await _context.PasswordPolicy.FindAsync(id); ;
            return result;
        }

        public async Task<BaseVM> GetPasswordPolicyInformation(long id, CancellationToken ct)
        {
            var result = await _context.PasswordPolicy.FindAsync(id);
            return await GeneralMethod.GenerateInfoModel(result, _context);
        }

        public async Task<List<PasswordPolicy>> GetPasswordPolicys(CancellationToken ct = default)
        {
            return await _context.PasswordPolicy.ToListAsync(ct);
        }

        public async Task<bool> UpdatePasswordPolicy(PasswordPolicy PasswordPolicy, IHttpContextAccessor accessor, CancellationToken ct = default)
        {
            var update = _context.PasswordPolicy.Update(PasswordPolicy);
            update.Property(e => e.CreatedByID).IsModified = false;
            update.Property(e => e.Created_Date).IsModified = false;
            await _context.SaveChangesAsync(ct);

            return true;
        }
    }
}

