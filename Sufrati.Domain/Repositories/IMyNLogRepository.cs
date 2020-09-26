using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Sufrati.Domain.Entities;

namespace Sufrati.Domain.Repositories
{
    public interface IMyNLogRepository
    {
        Task<List<MyNLog>> GetBetweentwoDatesAndType(DateTime fromDate, DateTime toDate, long typeID, CancellationToken ct = default);
        Task AddLogoutValue(string token, CancellationToken ct = default);
        Task<MyNLog> GetByDateAsync(string dateTime, CancellationToken ct = default);
    }
}
