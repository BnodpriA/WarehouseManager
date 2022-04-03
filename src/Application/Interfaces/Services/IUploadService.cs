using WarehouseManager.Application.Requests;

namespace WarehouseManager.Application.Interfaces.Services
{
    public interface IUploadService
    {
        string UploadAsync(UploadRequest request);
    }
}