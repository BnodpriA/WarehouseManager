using AutoMapper;
using WarehouseManager.Application.Features.Brands.Commands.AddEdit;
using WarehouseManager.Application.Features.Brands.Queries.GetAll;
using WarehouseManager.Application.Features.Brands.Queries.GetById;
using WarehouseManager.Domain.Entities.Catalog;

namespace WarehouseManager.Application.Mappings
{
    public class BrandProfile : Profile
    {
        public BrandProfile()
        {
            CreateMap<AddEditBrandCommand, Brand>().ReverseMap();
            CreateMap<GetBrandByIdResponse, Brand>().ReverseMap();
            CreateMap<GetAllBrandsResponse, Brand>().ReverseMap();
        }
    }
}