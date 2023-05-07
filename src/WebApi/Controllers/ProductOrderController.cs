using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Data.ResponseModel;
using Logic.Products.Queries;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductOrderController : BaseApiController
	{
		[Produces("application/json")]
		[ProducesResponseType(StatusCodes.Status200OK, Type = typeof(LoadResult))]
		[ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(string))]
		[HttpGet]
		public async Task<IActionResult> Get()
		{
			var loadOptions = new DataSourceLoadOptions();
			loadOptions.Skip = 10;
			loadOptions.Take = 20;

			loadOptions.RequireTotalCount = true;
			var query = new GetAllProductOrdersQuery();
			var orders = await Mediator.Send(query);
			var result = DataSourceLoader.Load(orders.Data, loadOptions);
			return Ok(result);
		}
	}
}