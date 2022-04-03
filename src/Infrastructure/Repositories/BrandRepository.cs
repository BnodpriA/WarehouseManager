using WarehouseManager.Application.Interfaces.Repositories;
using WarehouseManager.Domain.Entities.Catalog;

namespace WarehouseManager.Infrastructure.Repositories
{
    public class BrandRepository : IBrandRepository
    {
        private readonly IRepositoryAsync<Brand, int> _repository;

        public BrandRepository(IRepositoryAsync<Brand, int> repository)
        {
            _repository = repository;
        }
    }
}