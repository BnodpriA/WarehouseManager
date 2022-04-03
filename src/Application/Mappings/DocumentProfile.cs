using AutoMapper;
using WarehouseManager.Application.Features.Documents.Commands.AddEdit;
using WarehouseManager.Application.Features.Documents.Queries.GetById;
using WarehouseManager.Domain.Entities.Misc;

namespace WarehouseManager.Application.Mappings
{
    public class DocumentProfile : Profile
    {
        public DocumentProfile()
        {
            CreateMap<AddEditDocumentCommand, Document>().ReverseMap();
            CreateMap<GetDocumentByIdResponse, Document>().ReverseMap();
        }
    }
}