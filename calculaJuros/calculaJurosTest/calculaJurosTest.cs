using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using calculaJuros;
using calculaJuros.Controllers;
using Xunit;

namespace calculaJurosTest
{
    public class calculaJurosTest
    {
        calculaJurosController _controllerTest;

        public calculaJurosTest()
        {
            _controllerTest = new calculaJurosController();
        }

        [Fact]
        public void GetTest()
        {
            var resultado = (_controllerTest.Get(100, 5)).Result;
            var resultadoTeste = resultado.ValorFinal == 105.1 ? true : false;
            Assert.True(resultadoTeste);
        }
        


        
                


    }
}
