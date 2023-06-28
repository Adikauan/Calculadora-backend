using MediatR;
using SKA.Calculator.Domain.Aggregates;
using SKA.Calculator.Domain.Interfaces;

namespace SKA.Calculator.Application.Commands.HistoryCalculationsCommands.Create
{
    public class CreateHistoryCalculationsCommandHandler : IRequestHandler<CreateHistoryCalculationsCommand, Unit>
    {
        private readonly IUnitOfWork unitOfWork;

        public CreateHistoryCalculationsCommandHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(CreateHistoryCalculationsCommand request, CancellationToken cancellationToken)
        {
            string operation = $"{request.FirstNumber} {request.Operation} {request.SecondNumber}";

            unitOfWork.CalculatorRepository.Add(new HistoryCalculations(operation, request.Result));
            bool result = await unitOfWork.Commit();

            if (!result)
                throw new Exception();

            return Unit.Value;
        }
    }
}
