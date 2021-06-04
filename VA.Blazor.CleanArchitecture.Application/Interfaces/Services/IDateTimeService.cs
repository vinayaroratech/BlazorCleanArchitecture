using System;

namespace VA.Blazor.CleanArchitecture.Application.Interfaces.Services
{
    public interface IDateTimeService
    {
        DateTime NowUtc { get; }
    }
}