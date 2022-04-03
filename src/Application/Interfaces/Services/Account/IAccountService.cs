using WarehouseManager.Application.Interfaces.Common;
using WarehouseManager.Application.Requests.Identity;
using WarehouseManager.Shared.Wrapper;
using System.Threading.Tasks;

namespace WarehouseManager.Application.Interfaces.Services.Account
{
    public interface IAccountService : IService
    {
        Task<IResult> UpdateProfileAsync(UpdateProfileRequest model, string userId);

        Task<IResult> ChangePasswordAsync(ChangePasswordRequest model, string userId);

        Task<IResult<string>> GetProfilePictureAsync(string userId);

        Task<IResult<string>> UpdateProfilePictureAsync(UpdateProfilePictureRequest request, string userId);
    }
}