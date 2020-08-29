
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
    public interface IAttachmentTypeReository
    {
        Task<AttachmentType> AddAsync(AttachmentType input, CancellationToken ct = default);
        Task<AttachmentType> GetByIdAsync(long id, CancellationToken ct = default);
        Task<BaseVM> GetAttacjmentTypeInformation(long id, CancellationToken ct);
        Task<List<AttachmentType>> GetAllWithFilterAsync(Expression<Func<AttachmentType, bool>> filter);
        Task<List<AttachmentType>> GetALLAsync(CancellationToken ct = default);
        Task<AttachmentType> UpdateAsync(AttachmentType input, CancellationToken ct = default);
        Task DeleteAsync(long id, CancellationToken ct = default);
    }
}
