using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1
{
    public class Extratora
    {
 
        public int quantidadeDeLetras(string texto)
        {
            int x = texto.Count();
            return x;
        }

        public int quantidadeDeVogais(string texto)
        {
            return texto.Count(x => (x == 'a') || (x == 'e') || (x == 'i') || (x == 'o') || (x == 'u'));
        }

    }
}
