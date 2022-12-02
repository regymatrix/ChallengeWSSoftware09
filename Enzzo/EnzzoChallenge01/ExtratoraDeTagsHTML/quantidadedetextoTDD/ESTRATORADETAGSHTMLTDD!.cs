using ExtratoraDeTagsHTML.Controllers;
using System;
using Xunit;

namespace quantidadedetextoTDD
{
    public class Teste1
    {
        [Fact]
        public void ExtratoradeletrasTDD()
        {

            ExtratoradetagsHTML2 letra = new ExtratoradetagsHTML2();
            int esperado = 17;
            int resultado = 0;


            resultado = letra.qtdDeLetras("<h1>Meu Site</h1>");

            Assert.Equal(esperado, resultado);










        }
        [Fact]
        public void ExtratoradeletrasTDD2()
        {

            ExtratoradetagsHTML2 letra = new ExtratoradetagsHTML2();
            int esperado = 32;
            int resultado = 0;


            resultado = letra.qtdDeLetras("texto <img src=\"img_girl.jpg\" />");

            Assert.Equal(esperado, resultado);








        }
        [Fact]
        public void quantidadeDeVogais()
        {

            ExtratoradetagsHTML2 vogais = new ExtratoradetagsHTML2();

            int esperado = 5;
            int resultado = 0;


            resultado = vogais.qtdvogais("texto <img src=\"img_girl.jpg\" />");

            Assert.Equal(esperado, resultado);




        }
        [Fact]
        public void quantidadeDeVogais2()
        {

            ExtratoradetagsHTML2 vogais = new ExtratoradetagsHTML2();

            int esperado = 4;
            int resultado = 0;


            resultado = vogais.qtdvogais("<h1>Meu Site</h1>");

            Assert.Equal(esperado, resultado);




        }
      
        






    }

}
