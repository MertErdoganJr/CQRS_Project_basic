using MediatR;

namespace CQRS_Project.MediatorDesignPattern.Commands
{
    public class UpdateCustomerCommand : IRequest
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Department { get; set; }
    }
}
