using Desafio.Models;
using System;
using Xunit;

namespace TesteTDD
{
    public class UnitTest1
    {
        [Fact]
        public void VerificarQuantidadeDeLetras1()
        {
            //Arrange
            int esperado = 8;
            int resultado = 0;

            //Act
            ExtratoraDeTagsHTML qntd = new ExtratoraDeTagsHTML();
            resultado = qntd.qtdDeTexto("Vinicius");

            //Assert
            Assert.Equal(esperado, resultado);

        }

        [Fact]

        public void VerificarQuantidadeDeLetras2()
        
        
         {
            //Arrange
            int esperado = 10;
            int resultado = 0;

            //Act
            ExtratoraDeTagsHTML qntd = new ExtratoraDeTagsHTML();
            resultado = qntd.qtdDeTexto("Evangelion");

            //Assert
            Assert.Equal(esperado, resultado);
        }


        [Fact]

        public void VerificarAQntdDeVogais1 ()
        {

            //Arrange
            int esperado = 4;
            int resultado = 0;

            //Act
            ExtratoraDeTagsHTML qntd = new ExtratoraDeTagsHTML();
            resultado = qntd.qtdDeVogais("Computador");

            //Assert
            Assert.Equal(esperado, resultado);
        }

        [Fact]

        public void VerificarAQntdDeVogais2()
        {

            //Arrange
            int esperado = 2;
            int resultado = 0;

            //Act
            ExtratoraDeTagsHTML qntd = new ExtratoraDeTagsHTML();
            resultado = qntd.qtdDeVogais("Asuka");

            //Assert
            Assert.Equal(esperado, resultado);
        }



        //Mensagem para Reginaldo: Professor, todo mundo aqui tentou fazer a parte de substring. Mas como o senhor pode perceber, não conseguimos :(
        // Tenha misericórida de nós, pobre almas, pobre estudantes do Senai

        

       






    }
}
