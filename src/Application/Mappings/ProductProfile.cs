using AutoMapper;
using WarehouseManager.Application.Features.Products.Commands.AddEdit;
using WarehouseManager.Domain.Entities.Catalog;

namespace WarehouseManager.Application.Mappings
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<AddEditProductCommand, Product>().ReverseMap();
        }
    }
}