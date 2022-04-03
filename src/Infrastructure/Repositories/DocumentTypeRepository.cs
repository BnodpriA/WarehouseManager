using WarehouseManager.Application.Interfaces.Repositories;
using WarehouseManager.Domain.Entities.Misc;

namespace WarehouseManager.Infrastructure.Repositories
{
    public class DocumentTypeRepository : IDocumentTypeRepository
    {
        private readonly IRepositoryAsync<DocumentType, int> _repository;

        public DocumentTypeRepository(IRepositoryAsync<DocumentType, int> repository)
        {
            _repository = repository;
        }
    }
}