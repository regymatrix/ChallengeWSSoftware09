using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.Models
{
    public class ExtratoraDeTagsHTML
    {
        public int qtdDeTexto(string texto)
        {
            int x = texto.Count();
            return x;

        }
        public int qtdDeVogais (string palavra)
        {
            return palavra.Count(x => (x == 'a') || (x == 'e') || (x == 'i') || (x == 'o') || (x == 'u'));
        }
       
        
}   }
