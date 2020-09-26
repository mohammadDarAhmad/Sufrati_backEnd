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

    public class AuthenticationRepository : IAuthenticationRepository
    {
        private readonly SufratiContext _context;
        public AuthenticationRepository(SufratiContext context)
        {
            _context = context;
        }
        public async Task<User> Authenticate(string loginName, CancellationToken ct = default)
        {
            var result = await _context.User.Include(e=>e.Attachment).Where(u => u.LoginName == loginName).SingleOrDefaultAsync(ct);
            return result;
        }


    }
}
