
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;
using Sufrati.Domain.Entities;
using Sufrati.Domain.ApiModels;
using System.Linq.Expressions;

namespace Sufrati.Domain.Repositories
{
    public interface IAttachmentTypeFileTypeRepository
    {
        Task<AttachmentTypeFileType> AddAsync(AttachmentTypeFileType input, CancellationToken ct = default);
        Task<List<AttachmentTypeFileType>> AddRangeAsync(List<AttachmentTypeFileType> input, CancellationToken ct = default);
        Task<AttachmentTypeFileType> GetByIdAsync(long id, CancellationToken ct = default);
        Task<List<AttachmentTypeFileType>> GetAllWithFilterAsync(Expression<Func<AttachmentTypeFileType, bool>> filter);
        Task<List<AttachmentTypeFileType>> GetALLAsync(CancellationToken ct = default);
        Task<AttachmentTypeFileType> UpdateAsync(AttachmentTypeFileType input, CancellationToken ct = default);
        Task DeleteAsync(long id, CancellationToken ct = default);
        Task DeleteRange(List<AttachmentTypeFileType> inputs, CancellationToken ct = default);
    }
}
