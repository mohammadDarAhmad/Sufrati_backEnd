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
    public class UserRepository : IUserRepository
    {
        private readonly SufratiContext _context;
        public UserRepository(SufratiContext context)
        {
            _context = context;
        }

        public async Task<User> AddUser(User input, IHttpContextAccessor accessor, CancellationToken ct = default)
        {
            _context.User.Add(input);
            await _context.SaveChangesAsync(ct);
            return input;
        }

        public async Task<bool> DeleteUser(long id, CancellationToken ct = default)
        {
            var Obj = await GetUserById(id, ct);
            _context.User.Remove(Obj);
            await _context.SaveChangesAsync(ct);
            return true;
        }

        public async Task<User> GetUserById(long id, CancellationToken ct = default)
        {
            var result = await _context.User.Include(u => u.UserType).Include(u => u.PasswordPolicy).SingleOrDefaultAsync(b => b.ID == id); ;
            return result;
        }

        public async Task<BaseVM> GetUserInformation(long id, CancellationToken ct)
        {
            var result = await _context.User.FindAsync(id);
           return await GeneralMethod.GenerateInfoModel(result, _context);
        }

        public async Task<List<User>> GetUsers(CancellationToken ct = default)
        {
            return await _context.User.Include(b => b.UserType).ToListAsync(ct);
        }
        public async Task<List<GeneralLookupValue>> GetUserTypes(CancellationToken ct = default)
        {
            return await _context.GeneralLookupValue.Where(glv => glv.GeneralLookupTypeID == 105000000000005).ToListAsync(ct);
        }
        public async Task<bool> UpdateUser(User User, IHttpContextAccessor accessor, CancellationToken ct = default)
        {
            var update = _context.User.Update(User);
            update.Property(e => e.CreatedByID).IsModified = false;
            update.Property(e => e.Created_Date).IsModified = false;
            await _context.SaveChangesAsync(ct);

            return true;
        }

     
    }
}
