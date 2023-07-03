using MediatR;
using Microsoft.AspNetCore.Mvc;
using SKA.Calculator.Application.Commands.CalculateCommands.Calculate;
using SKA.Calculator.Application.Models;

namespace SKA.Calculator.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculateController : ControllerBase
    {
        private readonly IMediator mediator;

        public CalculateController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpPost("[action]")]
        public async Task<string> Operation(CalculateModel model) 
            => await this.mediator.Send(new CalculateCommand(model));
    }
}
