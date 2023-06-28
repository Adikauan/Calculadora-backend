using AutoMapper;
using MediatR;
using SKA.Calculator.Application.Models;
using SKA.Calculator.Domain.Interfaces;

namespace SKA.Calculator.Application.Queries.Getall
{
    public class GetAllCalculatorControllerQueryHandler : IRequestHandler<GetAllCalculatorControllerQuery, IEnumerable<HistoryCalculationsModel>>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public GetAllCalculatorControllerQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<HistoryCalculationsModel>> Handle(GetAllCalculatorControllerQuery request, CancellationToken cancellationToken)
        {
            IEnumerable<HistoryCalculationsModel> historyCalculations = this.mapper.Map<IEnumerable<HistoryCalculationsModel>>
                (await unitOfWork.CalculatorRepository.GetAllAsync());

            return historyCalculations.OrderBy(x=> x.DateTime);

        }
    }
}
