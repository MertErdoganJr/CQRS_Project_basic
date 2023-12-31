﻿using CQRS_Project.CQRSPattern.Queries;
using CQRS_Project.CQRSPattern.Results;
using CQRS_Project.DAL.Context;

namespace CQRS_Project.CQRSPattern.Handlers
{
    public class GetCategoryByIdQueryHandler
    {
        private readonly SaleContext _context;

        public GetCategoryByIdQueryHandler(SaleContext context)
        {
            _context = context;
        }

        public GetCategoryByIdQueryResult Handle(GetCategoryByIdQuery query)
        {
            var values = _context.Categories.Find(query.Id);
            return new GetCategoryByIdQueryResult
            {
                CategoryID = values.CategoryID,
                CategoryName = values.CategoryName
            };
        }
    }
}
