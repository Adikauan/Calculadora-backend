using MediatR;

namespace SKA.Calculator.Application.Commands.CalculateCommands.Subtraction
{
    public record class SubtractionCommand(string FirstNumber, string SecondNumber) : IRequest<double>
    {
    }
}
