using VA.Blazor.CleanArchitecture.Infrastructure.Models.Audit;
using VA.Blazor.CleanArchitecture.Application.Specifications.Base;

namespace VA.Blazor.CleanArchitecture.Infrastructure.Specifications
{
    public class AuditFilterSpecification : HeroSpecification<Audit>
    {
        public AuditFilterSpecification(string userId, string searchString, bool searchInOldValues, bool searchInNewValues)
        {
            if (!string.IsNullOrEmpty(searchString))
            {
                Criteria = p => (p.TableName.Contains(searchString) || searchInOldValues && p.OldValues.Contains(searchString) || searchInNewValues && p.NewValues.Contains(searchString)) && p.UserId == userId;
            }
            else
            {
                Criteria = p => p.UserId == userId;
            }
        }
    }
}