using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalServer.Service.Data
{
  public class CoverageArgs
  {
    public double NumericArgument { get; set; }

    public IFormFile ImageFileArgument { get; set; }
  }
}
