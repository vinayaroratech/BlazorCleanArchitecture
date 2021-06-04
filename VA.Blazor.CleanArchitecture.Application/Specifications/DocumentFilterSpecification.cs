using VA.Blazor.CleanArchitecture.Application.Specifications.Base;
using VA.Blazor.CleanArchitecture.Domain.Entities;

namespace VA.Blazor.CleanArchitecture.Application.Specifications
{
    public class DocumentFilterSpecification : HeroSpecification<DocumentFile>
    {
        public DocumentFilterSpecification(string searchString, string userId)
        {
            if (!string.IsNullOrEmpty(searchString))
            {
                Criteria = p => (p.Title.Contains(searchString) || p.Description.Contains(searchString)) && (p.IsPublic == true || (p.IsPublic == false && p.CreatedBy == userId));
            }
            else
            {
                Criteria = p => (p.IsPublic == true || (p.IsPublic == false && p.CreatedBy == userId));
            }
        }
    }
}