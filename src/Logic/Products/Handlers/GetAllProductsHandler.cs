using Infrastructure.Persistence;
using Logic.Products.Mapper;
using Logic.Products.Queries;
using Logic.Products.Responses;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Shared.Results;

namespace Logic.Products.Handlers
{
	public class GetAllProductOrdersHandler : IRequestHandler<GetAllProductOrdersQuery, IDataResult<List<ProductResponse>>>
	{
		private readonly ApplicationDbContext _dbContext;

		public GetAllProductOrdersHandler(ApplicationDbContext dbContext)
		{
			_dbContext = dbContext;
		}

		public async Task<IDataResult<List<ProductResponse>>> Handle(GetAllProductOrdersQuery request, CancellationToken cancellationToken)
		{
			var entities = await _dbContext.ProductOrders.ToListAsync(cancellationToken: cancellationToken);
			var responses = entities.Select(x => x.ToResponse()).ToList();
			return new SuccessResult<List<ProductResponse>>(responses);
		}
	}
}