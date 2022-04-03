using WarehouseManager.Application.Features.Products.Commands.AddEdit;
using WarehouseManager.Application.Features.Products.Queries.GetAllPaged;
using WarehouseManager.Application.Requests.Catalog;
using WarehouseManager.Shared.Wrapper;
using System.Threading.Tasks;

namespace WarehouseManager.Client.Infrastructure.Managers.Catalog.Product
{
    public interface IProductManager : IManager
    {
        Task<PaginatedResult<GetAllPagedProductsResponse>> GetProductsAsync(GetAllPagedProductsRequest request);

        Task<IResult<string>> GetProductImageAsync(int id);

        Task<IResult<int>> SaveAsync(AddEditProductCommand request);

        Task<IResult<int>> DeleteAsync(int id);

        Task<IResult<string>> ExportToExcelAsync(string searchString = "");
    }
}