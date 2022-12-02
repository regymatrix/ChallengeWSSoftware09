using ChallengeWSSoftware09.ExtratoraDeTagsHTML;

namespace ChallengeWSSoftware09TDD
{
    public class ChallengeWSSoftware09TDD
    {
        [Fact]
        public void QuantidadeDeLetras()
        {
            //arrage 
            int esperado = 32;
            int resultado = 0;

            //Act
            ExtratoraDeTagsHTML quantidadeDeLetras = new ExtratoraDeTagsHTML();
            resultado = quantidadeDeLetras.qunatidadeDeLetras("texto <img src="+"img_girl.jpg"+" />");


            Assert.Equal(resultado, esperado);  
        }


        [Fact]

        public void QuantidadeDeLetras2()
        {
            //arrage 
            int esperado = 17;
            int resultado = 0;

            //Act
            ExtratoraDeTagsHTML quantidadeDeLetras = new ExtratoraDeTagsHTML();
            resultado = quantidadeDeLetras.qunatidadeDeLetras("<h1>Meu Site</h1>");


            Assert.Equal(resultado, esperado);
        }

        [Fact]

        public void QuantidadeDeVogais()
        {
            //arrage 
            int esperado = 5;
            int resultado = 0;

            //Act
            ExtratoraDeTagsHTML quantidadeVogais = new ExtratoraDeTagsHTML();
            resultado = quantidadeVogais.qunatidadeDeLetras("texto < img src = "+"img_girl.jpg"+" />");


            Assert.Equal(resultado, esperado);
        }

        [Fact]

        public void QuantidadeDeVogais2()
        {
            //arrage 
            int esperado = 4;
            int resultado = 0;

            //Act
            ExtratoraDeTagsHTML quantidadeVogais = new ExtratoraDeTagsHTML();
            resultado = quantidadeVogais.qunatidadeDeLetras("<h1>Meu Site</h1>");


            Assert.Equal(resultado, esperado);
        }

        [Fact]

        public void ExtrairTagIMG() 
        {

            //arrage

            string esperado = "texto <img src=" + "img_girl.jpg" + " />";
            string resultado = "< img src = " + "img_girl.jpg" + " />";

            //Act
            ExtratoraDeTagsHTML ExtrairIMG = new ExtratoraDeTagsHTML();
            resultado = ExtrairIMG.ExtrairTagIMG("< img src = " + "img_girl.jpg" + " />");




        }

        [Fact]

        public void ExtrairTagIMG2()
        {

            //arrage

            string esperado = "texto gota <img src="+".. / .. /" +"imagemBrasil.jpg"+" /> continua texto";
            string resultado = "<img src="+".. / .. / imagemBrasil.jpg"+" />";

            //Act
            ExtratoraDeTagsHTML ExtrairIMG = new ExtratoraDeTagsHTML();
            resultado = ExtrairIMG.ExtrairTagIMG("<img src=" + ".. / .. / imagemBrasil.jpg" + " />");
        }

        [Fact]

        public void ExtrairEnderecoAtributoSRC() 
        {

            //arrage

            string esperado = "texto <img src=" + "img_girl.jpg" + " />";
            string resultado = "img_girl.jpg";

            //Act

            ExtratoraDeTagsHTML ExtrairAtributoSRC = new ExtratoraDeTagsHTML();
            resultado = ExtrairAtributoSRC.ExtrairEnderecoAtributoSRC("img_girl.jpg");


        }

        [Fact]

        public void ExtrairEnderecoAtributoSRC2() 
        {

            //arrage

            string esprado = "texto gota < img src = " + "../../imagemBrasil.jpg" + " /> continua texto";
            string resultado = "../../imagemBrasil.jpg";

            //act

            ExtratoraDeTagsHTML ExtrairAtributoSRC = new ExtratoraDeTagsHTML();
            resultado = ExtrairAtributoSRC.ExtrairEnderecoAtributoSRC("../../imagemBrasil.jpg");

        }

        [Fact]

        public void ExtrairTagH1() 
        {

            //arrgae

            string esperado = "<body> texto <img src=" + "img_girl.jpg" + " />  <h1> Desafio </h1> <body>";
            string resultado = "<h1> Desafio </h1>";



        }

        [Fact]

        public void ExtrairTagH1T2()
        {

            //arrgae

            string esperado = "<body> <h1> Desafio </h1> texto <img src="+"img_girl.jpg"+" />  <body>";
            string resultado = "<h1> Desafio </h1>";



        }
    }
}