using VA.Blazor.CleanArchitecture.Application.Requests;

namespace VA.Blazor.CleanArchitecture.Application.Interfaces.Services
{
    public interface IUploadService
    {
        string UploadAsync(UploadRequest request);
    }
}