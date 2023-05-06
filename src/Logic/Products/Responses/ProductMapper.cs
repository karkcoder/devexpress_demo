using Domain.Entities;
using Logic.Products.Responses;

namespace Logic.Products.Mapper
{
	public static class ProductMapper
	{
		public static ProductResponse ToResponse(this ProductOrder product)
		{
			var result = new ProductResponse
			{
				OrderId = product.OrderId,
				ProductName = product.ProductName,
				ProductDescription = product.ProductDescription
			};

			return result;
		}
	}
}