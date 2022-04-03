using WarehouseManager.Application.Interfaces.Common;
using WarehouseManager.Application.Requests.Identity;
using WarehouseManager.Application.Responses.Identity;
using WarehouseManager.Shared.Wrapper;
using System.Threading.Tasks;

namespace WarehouseManager.Application.Interfaces.Services.Identity
{
    public interface ITokenService : IService
    {
        Task<Result<TokenResponse>> LoginAsync(TokenRequest model);

        Task<Result<TokenResponse>> GetRefreshTokenAsync(RefreshTokenRequest model);
    }
}