using AutoMapper;
using WarehouseManager.Application.Features.DocumentTypes.Commands.AddEdit;
using WarehouseManager.Application.Features.DocumentTypes.Queries.GetAll;
using WarehouseManager.Application.Features.DocumentTypes.Queries.GetById;
using WarehouseManager.Domain.Entities.Misc;

namespace WarehouseManager.Application.Mappings
{
    public class DocumentTypeProfile : Profile
    {
        public DocumentTypeProfile()
        {
            CreateMap<AddEditDocumentTypeCommand, DocumentType>().ReverseMap();
            CreateMap<GetDocumentTypeByIdResponse, DocumentType>().ReverseMap();
            CreateMap<GetAllDocumentTypesResponse, DocumentType>().ReverseMap();
        }
    }
}