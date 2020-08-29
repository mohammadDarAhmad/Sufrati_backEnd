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

        public async Task<User> AddUser(User input, CancellationToken ct = default)
        {

            try
            {

                _context.User.Add(input);

                await _context.SaveChangesAsync(ct);
            }
            catch (DbUpdateException e)
            {
                if (e.Source.Contains("Relational"))
                {
                    if (e.InnerException != null)
                    {
                        if (e.InnerException.Message.Contains("duplicate") && e.InnerException.Message.Contains("Email"))
                        {
                            throw new Exception();
                        }
                        if (e.InnerException.Message.Contains("duplicate") && e.InnerException.Message.Contains("LoginName"))
                        {
                            throw new Exception();
                        }
                    }

                }
            }

            return input;
        }
        public async Task<bool> RsetPassVM(long userId, bool passwordActive, string passwordHash, CancellationToken ct = default)
        {
            User user = _context.User.Find(userId);
            user.Password = passwordHash;
            user.PasswordActive = passwordActive;
            user.IsActive = true;
            await _context.SaveChangesAsync(ct);

            return true;

        }
        public async Task<bool> updateUserStatusLogin(long userId, bool isActive, long NoumberOfLogin, CancellationToken ct = default)
        {
            User user = _context.User.Find(userId);
            user.IsActive = isActive;
            user.NumberOfWrongLogin = NoumberOfLogin;
            await _context.SaveChangesAsync(ct);

            return true;

        }
        public async Task<User> GetPassword(long userId, CancellationToken ct = default)
        {
            var result = await _context.User
                .Where(u => u.ID == userId)
                .SingleOrDefaultAsync(ct);
            return result;
        }
        public async Task<bool> changePassVM(long userId, string passwordHash, CancellationToken ct = default)
        {
            User user = _context.User.Find(userId);
            user.Password = passwordHash;
            await _context.SaveChangesAsync(ct);

            return true;

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
            var result = await _context.User.Include(u => u.UserType).Include(u => u.PasswordPolicy).Include(e => e.Attachment).SingleOrDefaultAsync(b => b.ID == id); ;
            return result;
        }
        public async Task<BaseVM> GetUserInformation(long id, CancellationToken ct)
        {
            var result = await _context.User.FindAsync(id);
            return await GeneralMethod.GenerateInfoModel(result, _context);
        }

        public async Task<List<User>> GetUsers(CancellationToken ct = default)
        {
            return await _context.User.Include(b => b.UserType)
                .Include(e => e.Attachment).ToListAsync(ct);
        }
        public async Task<List<GeneralLookupValue>> GetUserTypes(CancellationToken ct = default)
        {
            return await _context.GeneralLookupValue.Where(glv => glv.GeneralLookupTypeID == 105000000000011).ToListAsync(ct);
        }
        public async Task<bool> UpdateUser(User User, CancellationToken ct = default)
        {
            try
            {
                var update = await _context.User.FirstAsync(g => g.ID == User.ID);
                User.CreatedByID = update.CreatedByID;
                User.CreatedDate = update.CreatedDate;
                User.Password = update.Password;

                _context.Entry(update).CurrentValues.SetValues(User);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException e)
            {
                if (e.Source.Contains("Relational"))
                {
                    if (e.InnerException != null)
                    {
                        if (e.InnerException.Message.Contains("duplicate") && e.InnerException.Message.Contains("Email"))
                        {
                            throw new Exception();
                        }
                        if (e.InnerException.Message.Contains("duplicate") && e.InnerException.Message.Contains("LoginName"))
                        {
                            throw new Exception();
                        }
                    }

                }

            }
            return true;
        }
    }
}
