using System;
using VA.Blazor.CleanArchitecture.Domain.Entities;

namespace VA.Blazor.CleanArchitecture.Domain.Contracts
{
    public interface IAuditableEntity : IEntity
    {
        string CreatedBy { get; set; }

        DateTime CreatedOn { get; set; }

        string LastModifiedBy { get; set; }

        DateTime? LastModifiedOn { get; set; }
    }
}