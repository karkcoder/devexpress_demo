﻿using Logic.Products.Responses;
using MediatR;
using Shared.Results;

namespace Logic.Products.Queries
{
	public class GetAllProductOrdersQuery : IRequest<IDataResult<List<ProductResponse>>>
	{
	}
}