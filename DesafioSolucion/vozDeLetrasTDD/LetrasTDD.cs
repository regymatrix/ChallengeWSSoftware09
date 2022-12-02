using Mário___DesafioHTML.Models;

namespace vozDeLetrasTDD
{
	public class Testes
	{
		[Fact]
		public void vozDeLetrasTDD()
		{
			ExtratoraDeTagsHTML letras = new ExtratoraDeTagsHTML();
			int esperado = 32;
			int resultado = letras.vozDeLetras("texto <img src= " + "'img_girl.jpg'" + "/>");

			Assert.Equal(esperado, resultado);

		}

		[Fact]
		public void vozDeLetras2TDD()
		{
            ExtratoraDeTagsHTML letras = new ExtratoraDeTagsHTML();
            int esperado = 17;
            int resultado = letras.vozDeLetras("<h1>Meu Site</h1>");
            Assert.Equal(esperado, resultado);
        }
		
		

		[Fact]
		public void vozDeVogaisTDD()
		{
			ExtratoraDeTagsHTML vogais = new ExtratoraDeTagsHTML();
			int esperado = 5;
			int resultado = vogais.vozDeVogais("texto <img src=" + "img_girl.jpg" + "/>");

            Assert.Equal(esperado, resultado);
		}

		[Fact]
		public void vozDeVogais2TDD()
		{
            ExtratoraDeTagsHTML vogais = new ExtratoraDeTagsHTML();
            int esperado = 4;
            int resultado = vogais.vozDeVogais("<h1>Meu Site</h1>");

            Assert.Equal(esperado, resultado);
			
        }
	}
}