using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace calculaJuros.Controllers
{
    [ApiController]
    public class calculaJuros : ControllerBase
    {
        private readonly ILogger<calculaJuros> _logger;

        public calculaJuros(ILogger<calculaJuros> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("[controller]")]
        public async Task<ValorFin> Get(double valorInicial, int meses)
        {
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage resposta = await httpClient.GetAsync("https://localhost:44393/taxaJuros");
            resposta.EnsureSuccessStatusCode(); //garantindo a resposta de sucesso - 200

            var juros = await resposta.Content.ReadAsAsync<taxaJuros>();
            var taxaJuros = Convert.ToDouble(juros.Taxa);
            //var juros = 0.01; //trocar esta variável por uma requisição na API1
            var valorFinal = Math.Round(valorInicial * Math.Pow((1 + taxaJuros), meses), 2);
            ValorFin valor = new ValorFin { ValorFinal = valorFinal };
            return valor;
        }

        [HttpGet]
        [Route("/showmethecode")]
        public string showCode()
        {
            string linkCode = "https://github.com/ycarogb/DesafioSoftplan";
            return linkCode;

        }


    }
}
