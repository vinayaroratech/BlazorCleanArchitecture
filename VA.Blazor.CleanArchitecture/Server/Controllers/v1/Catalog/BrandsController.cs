using VA.Blazor.CleanArchitecture.Application.Features.Brands.Queries.GetAll;
using VA.Blazor.CleanArchitecture.Application.Features.Brands.Queries.GetById;
using VA.Blazor.CleanArchitecture.Shared.Constants.Permission;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using VA.Blazor.CleanArchitecture.Application.Features.Brands.Commands.AddEdit;
using VA.Blazor.CleanArchitecture.Application.Features.Brands.Commands.Delete;
using VA.Blazor.CleanArchitecture.Application.Features.Brands.Queries.Export;

namespace VA.Blazor.CleanArchitecture.Server.Controllers.v1.Catalog
{
    public class BrandsController : BaseApiController<BrandsController>
    {
        [Authorize(Policy = Permissions.Brands.View)]
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var brands = await _mediator.Send(new GetAllBrandsQuery());
            return Ok(brands);
        }

        [Authorize(Policy = Permissions.Brands.View)]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var brand = await _mediator.Send(new GetBrandByIdQuery() { Id = id });
            return Ok(brand);
        }

        [Authorize(Policy = Permissions.Brands.Create)]
        [HttpPost]
        public async Task<IActionResult> Post(AddEditBrandCommand command)
        {
            return Ok(await _mediator.Send(command));
        }

        [Authorize(Policy = Permissions.Brands.Delete)]
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await _mediator.Send(new DeleteBrandCommand { Id = id }));
        }

        [Authorize(Policy = Permissions.Brands.View)]
        [HttpGet("export")]
        public async Task<IActionResult> Export(string searchString = "")
        {
            return Ok(await _mediator.Send(new ExportBrandsQuery(searchString)));
        }
    }
}