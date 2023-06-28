using MediatR;
using SKA.Calculator.Application.Models;

namespace SKA.Calculator.Application.Queries.Getall
{
    public class GetAllCalculatorControllerQuery : IRequest<IEnumerable<HistoryCalculationsModel>>
    {
    }
}
