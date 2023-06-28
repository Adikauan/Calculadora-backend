using MediatR;
using SKA.Calculator.Application.Models;

namespace SKA.Calculator.Application.Commands.CalculateCommands.Calculate
{
    public record class CalculateCommand(CalculateModel Payload) : IRequest<string>
    {
    }
}
