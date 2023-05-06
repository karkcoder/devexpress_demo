using DevExtreme.AspNet.Data;
using Logic.Products.Queries;
using Logic.Products.Responses;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductOrderController : BaseApiController
	{
		[Produces("application/json")]
		[ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<ProductResponse>))]
		[ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(string))]
		[HttpGet]
		public async Task<IActionResult> Get(DataSourceLoadOptions loadOptions)
		{
			var x = new GetAllProductOrdersQuery();
			var result = await Mediator.Send(x);
			return Ok(DataSourceLoader.Load(result, loadOptions));
		}
	}
}