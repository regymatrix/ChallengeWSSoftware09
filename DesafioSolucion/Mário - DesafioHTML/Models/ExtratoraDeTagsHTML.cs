using System.Xml.Serialization;

namespace Mário___DesafioHTML.Models
{
	public class ExtratoraDeTagsHTML
	{
		public int vozDeLetras(string texto)
		{
			int x = texto.Count();
			return x;
		}

		public int vozDeVogais(string texto)
		{
            return texto.Count(x => (x == 'a') || (x == 'e') || (x == 'i') || (x == 'o') || (x == 'u'));

        }



    }
}
