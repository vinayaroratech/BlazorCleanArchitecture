namespace VA.Blazor.CleanArchitecture.Application.Requests
{
    public abstract class PagedRequest
    {
        public int PageSize { get; set; }
        public int PageNumber { get; set; }
    }
}