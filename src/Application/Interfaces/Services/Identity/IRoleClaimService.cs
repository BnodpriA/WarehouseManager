using System.Collections.Generic;
using System.Threading.Tasks;
using WarehouseManager.Application.Interfaces.Common;
using WarehouseManager.Application.Requests.Identity;
using WarehouseManager.Application.Responses.Identity;
using WarehouseManager.Shared.Wrapper;

namespace WarehouseManager.Application.Interfaces.Services.Identity
{
    public interface IRoleClaimService : IService
    {
        Task<Result<List<RoleClaimResponse>>> GetAllAsync();

        Task<int> GetCountAsync();

        Task<Result<RoleClaimResponse>> GetByIdAsync(int id);

        Task<Result<List<RoleClaimResponse>>> GetAllByRoleIdAsync(string roleId);

        Task<Result<string>> SaveAsync(RoleClaimRequest request);

        Task<Result<string>> DeleteAsync(int id);
    }
}