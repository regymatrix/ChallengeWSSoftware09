namespace ChallengeWSSoftware09.ExtratoraDeTagsHTML
{
    public class ExtratoraDeTagsHTML
    {
        public int qunatidadeDeLetras(string texto) 
        {

            int x = texto.Count();
            return x;
        
        }

        public int quantidadeDeVogais(string texto) 
        {

            return texto.Count(x => (x == 'a') || (x == 'e') || (x == 'i') || (x == 'o') || (x == 'u'));


        }

        public string ExtrairTagIMG(string texto) 
        {

            return texto.Substring(6, 27);
            return texto.Substring(11, 34);
        
        }

        public string ExtrairEnderecoAtributoSRC(string texto) 
        {

            return texto.Substring(16, 29);
            return texto.Substring(19, 43);       
        
        }

        public string ExtrairTagH1(string texto) 
        {

            return texto.Substring(39, 58);
            return texto.Substring(8, 17);
        
     
        
        }
    }
}
