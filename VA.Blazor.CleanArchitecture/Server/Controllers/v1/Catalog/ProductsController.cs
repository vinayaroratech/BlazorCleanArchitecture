using VA.Blazor.CleanArchitecture.Application.Features.Products.Commands.AddEdit;
using VA.Blazor.CleanArchitecture.Application.Features.Products.Commands.Delete;
using VA.Blazor.CleanArchitecture.Application.Features.Products.Queries.Export;
using VA.Blazor.CleanArchitecture.Application.Features.Products.Queries.GetAllPaged;
using VA.Blazor.CleanArchitecture.Application.Features.Products.Queries.GetProductImage;
using VA.Blazor.CleanArchitecture.Shared.Constants.Permission;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace VA.Blazor.CleanArchitecture.Server.Controllers.v1.Catalog
{
    public class ProductsController : BaseApiController<ProductsController>
    {
        [Authorize(Policy = Permissions.Products.View)]
        [HttpGet]
        public async Task<IActionResult> GetAll(int pageNumber, int pageSize, string searchString)
        {
            var products = await _mediator.Send(new GetAllProductsQuery(pageNumber, pageSize, searchString));
            return Ok(products);
        }

        [Authorize(Policy = Permissions.Products.View)]
        [HttpGet("image/{id}")]
        public async Task<IActionResult> GetProductImageAsync(int id)
        {
            var result = await _mediator.Send(new GetProductImageQuery(id));
            return Ok(result);
        }

        [Authorize(Policy = Permissions.Products.Create)]
        [HttpPost]
        public async Task<IActionResult> Post(AddEditProductCommand command)
        {
            return Ok(await _mediator.Send(command));
        }

        [Authorize(Policy = Permissions.Products.Delete)]
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await _mediator.Send(new DeleteProductCommand { Id = id }));
        }

        [Authorize(Policy = Permissions.Products.View)]
        [HttpGet("export")]
        public async Task<IActionResult> Export(string searchString = "")
        {
            return Ok(await _mediator.Send(new ExportProductsQuery(searchString)));
        }
    }
}