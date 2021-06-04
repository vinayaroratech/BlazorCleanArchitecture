using VA.Blazor.CleanArchitecture.Application.Enums;

namespace VA.Blazor.CleanArchitecture.Application.Requests
{
    public class UploadRequest
    {
        public string FileName { get; set; }
        public string Extension { get; set; }
        public UploadType UploadType { get; set; }
        public byte[] Data { get; set; }
    }
}