using MediatR;
using SKA.Calculator.Application.Commands.HistoryCalculationsCommands.Create;
using SKA.Calculator.Application.Helpers;

namespace SKA.Calculator.Application.Commands.CalculateCommands.Subtraction
{
    public class SubtractionCommandHandler : IRequestHandler<SubtractionCommand, double>
    {
        private readonly IMediator mediator;

        public SubtractionCommandHandler(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public async Task<double> Handle(SubtractionCommand request, CancellationToken cancellationToken)
        {
            double result = CalculateHelper.CalculateValue(Double.Parse(request.FirstNumber)
                , double.Parse(request.SecondNumber)
                , "-");

            await this.mediator.Send(new CreateHistoryCalculationsCommand(request.FirstNumber
                , request.SecondNumber
                , "-"
                , result));

            return result;
        }
    }
}
