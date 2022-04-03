using AutoMapper;
using WarehouseManager.Application.Requests.Identity;
using WarehouseManager.Application.Responses.Identity;

namespace WarehouseManager.Client.Infrastructure.Mappings
{
    public class RoleProfile : Profile
    {
        public RoleProfile()
        {
            CreateMap<PermissionResponse, PermissionRequest>().ReverseMap();
            CreateMap<RoleClaimResponse, RoleClaimRequest>().ReverseMap();
        }
    }
}