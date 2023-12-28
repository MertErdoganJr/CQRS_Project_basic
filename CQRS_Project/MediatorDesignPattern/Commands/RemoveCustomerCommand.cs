using MediatR;

namespace CQRS_Project.MediatorDesignPattern.Commands
{
    public class RemoveCustomerCommand : IRequest
    {
        public int Id { get; set; }

        public RemoveCustomerCommand(int id)
        {
            Id = id;
        }
    }

}
