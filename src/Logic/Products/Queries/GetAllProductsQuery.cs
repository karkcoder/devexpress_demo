using Domain.Entities;
using MediatR;
using Shared.Results;

namespace Logic.Products.Queries
{
	public sealed class GetAllProductOrdersQuery : IRequest<IDataResult<IQueryable<ProductOrder>>>
	{
	}
}