using CQRS_Project.DAL.Context;
using CQRS_Project.MediatorDesignPattern.Queries;
using CQRS_Project.MediatorDesignPattern.Results;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CQRS_Project.MediatorDesignPattern.Handlers
{
    public class GetAllCustomerQueryHandler : IRequestHandler<GetAllCustomerQuery, List<GetAllCustomerQueryResult>>
    {
        private readonly SaleContext _context;

        public GetAllCustomerQueryHandler(SaleContext context)
        {
            _context = context;
        }

        public async Task<List<GetAllCustomerQueryResult>> Handle(GetAllCustomerQuery request, CancellationToken cancellationToken)
        {
            return await _context.Customers.Select(x => new GetAllCustomerQueryResult
            {
                CustomerID = x.CustomerID,
                Department = x.Department,
                Name = x.Name,
                Surname = x.Surname
            }).ToListAsync();
        }
    }
}
