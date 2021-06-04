using VA.Blazor.CleanArchitecture.Domain.Contracts;

namespace VA.Blazor.CleanArchitecture.Domain.Entities.Catalog
{
    public class Brand : AuditableEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Tax { get; set; }
    }
}