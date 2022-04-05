using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SignalServer.Core;
using SignalServer.Service.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalServer.Service.Controllers
{
  [ApiController]
  [Route("coverage")]
  public class RadioPropagationController : ControllerBase
  {
    private readonly ILogger<RadioPropagationController> _logger;
    private readonly RadioCoverageSimulation _simulation = new RadioCoverageSimulation();

    public RadioPropagationController(ILogger<RadioPropagationController> logger)
    {
      _logger = logger;
    }

    [HttpPost("generate")]
    public void GenerateCoverage([FromForm] CoverageArgs args)
    {
      Console.WriteLine($"Message received, argument is {args.NumericArgument}.");

      _simulation.TestMethod(args.NumericArgument);
    }
  }
}
