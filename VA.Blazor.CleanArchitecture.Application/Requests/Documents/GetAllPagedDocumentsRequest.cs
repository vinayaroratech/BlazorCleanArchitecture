namespace VA.Blazor.CleanArchitecture.Application.Requests.Documents
{
    public class GetAllPagedDocumentsRequest : PagedRequest
    {
        public string SearchString { get; set; }
    }
}