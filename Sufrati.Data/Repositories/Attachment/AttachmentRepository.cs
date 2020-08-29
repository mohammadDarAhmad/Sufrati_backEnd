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
    public class AttachmentRepository : IAttachmentRepository
    {
        private readonly SufratiContext _context;
        public AttachmentRepository(SufratiContext context)
        {
            _context = context;
        }

        public async Task<Attachment> AddAttachmentAsync(Attachment attachment, CancellationToken ct = default)
        {
            _context.Attachment.Add(attachment);
            await _context.SaveChangesAsync(ct);
            return attachment;
        }

        public async Task<string> DeleteAsync(long id, CancellationToken ct = default)
        {
            var toRemove = _context.Attachment.Find(id);

            if (toRemove == null)
                return null;
            var path = toRemove.FilePath;
            _context.Attachment.Remove(toRemove);
            await _context.SaveChangesAsync(ct);
            return path;
        }

        public async Task<Attachment> GetByIdAttachmentAsync(long id, CancellationToken ct = default)
        {
            return await _context.Attachment.FirstOrDefaultAsync(a => a.ID == id);
        }
    }
}
