using AutoMapper;
using VA.Blazor.CleanArchitecture.Application.Features.Products.Commands.AddEdit;
using VA.Blazor.CleanArchitecture.Domain.Entities.Catalog;

namespace VA.Blazor.CleanArchitecture.Application.Mappings
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<AddEditProductCommand, Product>().ReverseMap();
        }
    }
}