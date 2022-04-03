using AutoMapper;
using WarehouseManager.Application.Interfaces.Chat;
using WarehouseManager.Application.Models.Chat;
using WarehouseManager.Infrastructure.Models.Identity;

namespace WarehouseManager.Infrastructure.Mappings
{
    public class ChatHistoryProfile : Profile
    {
        public ChatHistoryProfile()
        {
            CreateMap<ChatHistory<IChatUser>, ChatHistory<BlazorHeroUser>>().ReverseMap();
        }
    }
}