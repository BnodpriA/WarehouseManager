using WarehouseManager.Application.Responses.Identity;
using WarehouseManager.Shared.Wrapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using WarehouseManager.Application.Interfaces.Chat;
using WarehouseManager.Application.Models.Chat;

namespace WarehouseManager.Application.Interfaces.Services
{
    public interface IChatService
    {
        Task<Result<IEnumerable<ChatUserResponse>>> GetChatUsersAsync(string userId);

        Task<IResult> SaveMessageAsync(ChatHistory<IChatUser> message);

        Task<Result<IEnumerable<ChatHistoryResponse>>> GetChatHistoryAsync(string userId, string contactId);
    }
}