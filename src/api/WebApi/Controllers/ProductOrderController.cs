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
		[HttpGet("GetOrdersForDevExpress")]
		public async Task<IActionResult> GetOrdersForDevExpress([FromQuery] DataSourceLoadOptions loadOptions)
		{
			var result = await Mediator.Send(new GetAllProductOrdersQuery());
			var gridResult = DataSourceLoader.Load(result.Data, loadOptions);
			if (result.Success)
			{
				return Ok(gridResult);
			}

			return BadRequest(result.Message);
		}
	}
}