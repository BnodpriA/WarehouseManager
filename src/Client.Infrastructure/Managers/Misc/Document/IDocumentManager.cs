using WarehouseManager.Application.Features.Documents.Commands.AddEdit;
using WarehouseManager.Application.Features.Documents.Queries.GetAll;
using WarehouseManager.Application.Requests.Documents;
using WarehouseManager.Shared.Wrapper;
using System.Threading.Tasks;
using WarehouseManager.Application.Features.Documents.Queries.GetById;

namespace WarehouseManager.Client.Infrastructure.Managers.Misc.Document
{
    public interface IDocumentManager : IManager
    {
        Task<PaginatedResult<GetAllDocumentsResponse>> GetAllAsync(GetAllPagedDocumentsRequest request);

        Task<IResult<GetDocumentByIdResponse>> GetByIdAsync(GetDocumentByIdQuery request);

        Task<IResult<int>> SaveAsync(AddEditDocumentCommand request);

        Task<IResult<int>> DeleteAsync(int id);
    }
}