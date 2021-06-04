using VA.Blazor.CleanArchitecture.Domain.Contracts;

namespace VA.Blazor.CleanArchitecture.Domain.Entities
{
    public class DocumentFile : AuditableEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsPublic { get; set; } = false;
        public string URL { get; set; }
    }
}