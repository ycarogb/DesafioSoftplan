using System;
using Xunit;
using taxaJuros;
using taxaJuros.Controllers;

namespace taxaJurosTeste
{
    public class taxaJurosTeste
    {
        TaxaJurosController _controllerTest;

        public taxaJurosTeste()
        {
            _controllerTest = new TaxaJurosController();
        }

        [Fact]
        public void GetTest()
        {
            var resultado = _controllerTest.Get();
            var resultadoTeste = resultado.Taxa == 0.01 ? true : false;
            Assert.True(resultadoTeste);

        }
    }
}
