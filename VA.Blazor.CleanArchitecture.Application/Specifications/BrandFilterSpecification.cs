using VA.Blazor.CleanArchitecture.Application.Specifications.Base;
using VA.Blazor.CleanArchitecture.Domain.Entities.Catalog;

namespace VA.Blazor.CleanArchitecture.Application.Specifications
{
    public class BrandFilterSpecification : HeroSpecification<Brand>
    {
        public BrandFilterSpecification(string searchString)
        {
            if (!string.IsNullOrEmpty(searchString))
            {
                Criteria = p => p.Name.Contains(searchString) || p.Description.Contains(searchString);
            }
            else
            {
                Criteria = p => true;
            }
        }
    }
}
