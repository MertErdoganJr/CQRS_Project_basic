using CQRS_Project.DAL.Context;
using CQRS_Project.MediatorDesignPattern.Queries;
using CQRS_Project.MediatorDesignPattern.Results;
using MediatR;

namespace CQRS_Project.MediatorDesignPattern.Handlers
{
    public class GetCustomerByIdQueryHandler : IRequestHandler<GetCustomerByIdQuery, GetCustomerByIdQueryResult>
    {
        private readonly SaleContext _context;

        public GetCustomerByIdQueryHandler(SaleContext context)
        {
            _context = context;
        }

        public async Task<GetCustomerByIdQueryResult> Handle(GetCustomerByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Customers.FindAsync(request.Id);
            return new GetCustomerByIdQueryResult
            {
                CustomerID = values.CustomerID,
                Department=values.Department,
                Name = values.Name,
                Surname = values.Surname
            };
        }
    }
}
