using WarehouseManager.Shared.Wrapper;
using System.Threading.Tasks;
using WarehouseManager.Application.Features.Dashboards.Queries.GetData;

namespace WarehouseManager.Client.Infrastructure.Managers.Dashboard
{
    public interface IDashboardManager : IManager
    {
        Task<IResult<DashboardDataResponse>> GetDataAsync();
    }
}