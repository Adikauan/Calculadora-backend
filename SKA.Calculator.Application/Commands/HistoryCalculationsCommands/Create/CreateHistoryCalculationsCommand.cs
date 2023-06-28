using MediatR;

namespace SKA.Calculator.Application.Commands.HistoryCalculationsCommands.Create
{
    public record class CreateHistoryCalculationsCommand(string FirstNumber, string SecondNumber,string Operation, double Result) : IRequest<Unit>
    {
    }
}
