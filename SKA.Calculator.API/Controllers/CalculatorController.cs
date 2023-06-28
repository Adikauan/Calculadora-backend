using MediatR;
using Microsoft.AspNetCore.Mvc;
using SKA.Calculator.Application.Models;
using SKA.Calculator.Application.Queries.Getall;

namespace SKA.Calculator.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        private readonly IMediator mediator;

        public CalculatorController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task<IEnumerable<HistoryCalculationsModel>> GetAll() => await this.mediator.Send(new GetAllCalculatorControllerQuery());
    }
}
