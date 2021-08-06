using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace taxaJuros.Controllers
{
    [ApiController]
    public class TaxaJurosController : ControllerBase
    {
        private readonly ILogger<TaxaJurosController> _logger;

        public TaxaJurosController(ILogger<TaxaJurosController> logger)
        {
            _logger = logger;
        }

        [Route("/taxaJuros")]
        [HttpGet]
        public TaxaJuros Get()
        {
            TaxaJuros taxa = new TaxaJuros { Taxa = 0.01 }; //instanciando um objeto no modelo taxaJuros que retorna seu valor de taxa
            return taxa;
        }
    }
}
