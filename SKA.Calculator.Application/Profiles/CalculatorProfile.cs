using AutoMapper;
using SKA.Calculator.Application.Models;
using SKA.Calculator.Domain.Aggregates;

namespace SKA.Calculator.Application.Profiles
{
    public class CalculatorProfile : Profile
    {
        public CalculatorProfile()
        {
            base.CreateMap<HistoryCalculations, HistoryCalculationsModel>()
                .ReverseMap();
        }
    }
}
