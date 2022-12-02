using System.Linq;

namespace ExtratoraDeTagsHTML.Controllers
{
    public class ExtratoradetagsHTML2
    {
        public int qtdDeLetras(string texto)
        {

            int x = texto.Count();
            return x;


        }
        public int qtdvogais(string texto)
        {

            return texto.Count(x => (x == 'a') || (x == 'e') || (x == 'i') || (x == 'o') || (x == 'u'));


        }
  
        
        
        

    }
}
