using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using VA.Blazor.CleanArchitecture.Application.Features.Dashboards.Queries.GetData;
using VA.Blazor.CleanArchitecture.Shared.Constants.Permission;

namespace VA.Blazor.CleanArchitecture.Server.Controllers.v1
{
    [ApiController]
    public class DashboardController : BaseApiController<DashboardController>
    {
        [Authorize(Policy = Permissions.Dashboards.View)]
        [HttpGet]
        public async Task<IActionResult> GetDataAsync()
        {
            var result = await _mediator.Send(new GetDashboardDataQuery());
            return Ok(result);
        }
    }
}