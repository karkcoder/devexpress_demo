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
		public async Task<IActionResult> Get()
		{
			var x = new GetAllProductOrdersQuery();
			var result = await Mediator.Send(x);
			if (result.Success)
			{
				return Ok(result.Data);
			}

			return BadRequest(result.Message);
		}
	}
}