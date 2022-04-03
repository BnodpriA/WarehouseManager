using AutoMapper;
using WarehouseManager.Infrastructure.Models.Audit;
using WarehouseManager.Application.Responses.Audit;

namespace WarehouseManager.Infrastructure.Mappings
{
    public class AuditProfile : Profile
    {
        public AuditProfile()
        {
            CreateMap<AuditResponse, Audit>().ReverseMap();
        }
    }
}