using Domain.Entities;
using Infrastructure.Persistence;
using Logic.Products.Queries;
using MediatR;
using Shared.Results;

namespace Logic.Products.Handlers
{
	public sealed class GetAllProductOrdersHandler : IRequestHandler<GetAllProductOrdersQuery, IDataResult<IQueryable<ProductOrder>>>
	{
		private readonly ApplicationDbContext _dbContext;

		public GetAllProductOrdersHandler(ApplicationDbContext dbContext)
		{
			_dbContext = dbContext;
		}

		public async Task<IDataResult<IQueryable<ProductOrder>>> Handle(GetAllProductOrdersQuery request, CancellationToken cancellationToken)
		{
			var entities = _dbContext.ProductOrders.AsQueryable();
			return new SuccessResult<IQueryable<ProductOrder>>(entities);
		}
	}
}