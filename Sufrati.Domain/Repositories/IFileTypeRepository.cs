
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
    public interface IFileTypeRepository
    {
        Task<FileType> AddAsync(FileType input, CancellationToken ct = default);
        Task<FileType> GetByIdAsync(long id, CancellationToken ct = default);
        Task<BaseVM> GetFileTypeInformation(long id, CancellationToken ct);
        Task<List<FileType>> GetAllWithFilterAsync(Expression<Func<FileType, bool>> filter);
        Task<List<FileType>> GetALLAsync(CancellationToken ct = default);
        Task<FileType> UpdateAsync(FileType input, CancellationToken ct = default);
        Task DeleteAsync(long id, CancellationToken ct = default);
    }
}
