using CQRS_Project.CQRSPattern.Commands;
using CQRS_Project.DAL.Context;
using CQRS_Project.MediatorDesignPattern.Commands;
using MediatR;

namespace CQRS_Project.MediatorDesignPattern.Handlers
{
    public class RemoveCustomerCommandHandler : IRequestHandler<RemoveCustomerCommand>
    {
        private readonly SaleContext _context;

        public RemoveCustomerCommandHandler(SaleContext context)
        {
            _context = context;
        }      

        public async Task Handle(RemoveCustomerCommand request, CancellationToken cancellationToken)
        {
            var values = _context.Customers.Find(request.Id);
            _context.Customers.Remove(values);
            await _context.SaveChangesAsync();
        }
    }

}
