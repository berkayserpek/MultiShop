﻿using MediatR;
using MultiShop.Order.Application.Features.Mediator.Result.OrderingResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Order.Application.Features.Mediator.Queries.OrderingQueries
{
    public class GetOrderingByIdQuery : IRequest<GetOrderingByIdQueryResult>
    {
        public int ID { get; set; }

        public GetOrderingByIdQuery(int id)
        {
            ID = id;
        }
    }
}
