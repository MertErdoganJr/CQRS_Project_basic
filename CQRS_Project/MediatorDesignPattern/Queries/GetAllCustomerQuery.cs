using CQRS_Project.MediatorDesignPattern.Results;
using MediatR;

namespace CQRS_Project.MediatorDesignPattern.Queries
{
    public class GetAllCustomerQuery : IRequest<List<GetAllCustomerQueryResult>>
    {

    }
}
