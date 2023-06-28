using MediatR;
using SKA.Calculator.Application.Commands.HistoryCalculationsCommands.Create;
using SKA.Calculator.Application.Helpers;
using System.Globalization;

namespace SKA.Calculator.Application.Commands.CalculateCommands.Calculate
{
    public class CalculateCommandHandler : IRequestHandler<CalculateCommand, string>
    {
        private readonly IMediator mediator;
        private readonly CultureInfo culture;

        public CalculateCommandHandler(IMediator mediator)
        {
            this.mediator = mediator;
            this.culture = CultureInfoHelper.SetCultureInfo();
        }

        public async Task<string> Handle(CalculateCommand request, CancellationToken cancellationToken)
        {
            double result = CalculateHelper.CalculateValue(Double.Parse(request.Payload.FirstNumber, culture)
                , double.Parse(request.Payload.SecondNumber, culture)
                , request.Payload.Operation);

            await this.mediator.Send(new CreateHistoryCalculationsCommand(request.Payload.FirstNumber
                , request.Payload.SecondNumber
                , request.Payload.Operation
                , result));

            return result.ToString();
        }
    }
}
