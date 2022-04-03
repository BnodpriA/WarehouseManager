using WarehouseManager.Application.Interfaces.Common;

namespace WarehouseManager.Application.Interfaces.Services
{
    public interface ICurrentUserService : IService
    {
        string UserId { get; }
    }
}