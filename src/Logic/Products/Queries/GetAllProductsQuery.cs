using Logic.Products.Responses;
using MediatR;

namespace Logic.Products.Queries
{
	public class GetAllProductOrdersQuery : IRequest<IQueryable<ProductResponse>>
	{
	}
}