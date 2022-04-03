using WarehouseManager.Application.Models.Chat;
using WarehouseManager.Application.Responses.Identity;
using WarehouseManager.Shared.Wrapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using WarehouseManager.Application.Interfaces.Chat;

namespace WarehouseManager.Client.Infrastructure.Managers.Communication
{
    public interface IChatManager : IManager
    {
        Task<IResult<IEnumerable<ChatUserResponse>>> GetChatUsersAsync();

        Task<IResult> SaveMessageAsync(ChatHistory<IChatUser> chatHistory);

        Task<IResult<IEnumerable<ChatHistoryResponse>>> GetChatHistoryAsync(string cId);
    }
}