using AutoMapper;
using WarehouseManager.Infrastructure.Models.Identity;
using WarehouseManager.Application.Responses.Identity;

namespace WarehouseManager.Infrastructure.Mappings
{
    public class RoleProfile : Profile
    {
        public RoleProfile()
        {
            CreateMap<RoleResponse, BlazorHeroRole>().ReverseMap();
        }
    }
}