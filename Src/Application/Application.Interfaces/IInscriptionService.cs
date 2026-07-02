using Application.Dtos.Responses;
using Application.Dtos.Request;

namespace Application.Interfaces
{
    public interface IInscriptionService
    {
        Task<InscriptionResponse?> GetById(Guid id);

        Task<InscriptionResult> Inscribe(InscriptionRequest request);
        Task<InscriptionResult> Unsubscribe(Guid userId, Guid classId);
        Task<IEnumerable<MyInscriptionResponse>> GetMyInscriptions(Guid userId);
    }
}