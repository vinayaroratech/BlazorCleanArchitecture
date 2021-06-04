using System.Diagnostics.CodeAnalysis;

namespace VA.Blazor.CleanArchitecture.Application.Interfaces.Services.Storage
{
    [ExcludeFromCodeCoverage]
    public class ChangingEventArgs : ChangedEventArgs
    {
        public bool Cancel { get; set; }
    }
}