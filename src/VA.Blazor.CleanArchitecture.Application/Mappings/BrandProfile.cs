using AutoMapper;
using VA.Blazor.CleanArchitecture.Application.Features.Brands.Commands.AddEdit;
using VA.Blazor.CleanArchitecture.Application.Features.Brands.Queries.GetAll;
using VA.Blazor.CleanArchitecture.Application.Features.Brands.Queries.GetById;
using VA.Blazor.CleanArchitecture.Domain.Entities.Catalog;

namespace VA.Blazor.CleanArchitecture.Application.Mappings
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