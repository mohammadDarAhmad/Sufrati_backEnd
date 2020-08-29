using System.Threading;
using System.Threading.Tasks;
using Sufrati.Domain.Entities;

namespace Sufrati.Domain.Repositories
{
    public interface IAttachmentRepository
    {
        Task<Attachment> AddAttachmentAsync(Attachment attachment, CancellationToken ct = default(CancellationToken));
        Task<Attachment> GetByIdAttachmentAsync(long id, CancellationToken ct = default(CancellationToken));
        Task<string> DeleteAsync(long id, CancellationToken ct = default(CancellationToken));

    }
}
