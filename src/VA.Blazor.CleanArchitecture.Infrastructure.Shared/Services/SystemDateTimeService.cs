using VA.Blazor.CleanArchitecture.Application.Interfaces.Services;
using System;

namespace VA.Blazor.CleanArchitecture.Infrastructure.Shared.Services
{
    public class SystemDateTimeService : IDateTimeService
    {
        public DateTime NowUtc => DateTime.UtcNow;
    }
}