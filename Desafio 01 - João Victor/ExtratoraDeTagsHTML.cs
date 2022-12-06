namespace Desafio_01___João_Victor
{
    public class ExtratoraDeTagsHTML
    {
        public ExtratoraDeTagsHTML()
        {

        }

        public int quantidadeDeLetras(string texto)
        {

            int totalLetra = texto.Length - 4;

            return totalLetra;
        }

        public int quantidadeDeVogais(string texto)
        {
            char[] vogais = new char[10] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            char[] palavra = texto.ToCharArray();
            int contadorVogais = 0;

            for (int i = 0; palavra.Length > vogais.Length; i++)
            {
                for(int f = 0; palavra.Length > vogais.Length; f++)
                {
                    if (palavra[f] == vogais[i])
                    {
                        contadorVogais++;
                    }
                }
                
            }
            return contadorVogais;
        }

        public string ExtrairTagIMG(string texto)
        {
            string tag = texto.Substring( texto.IndexOf("<"), texto.LastIndexOf("/>"));

            return tag;
        }

        public string ExtrairEnderecoAtributoSRC(string texto)
        {
            string valueSrc = texto.Substring(texto.IndexOf($"="),texto.LastIndexOf(" "));

            return valueSrc;
        }

        public string ExtrairTagH1(string texto)
        {
            string valueH1 = texto.Substring(texto.IndexOf($"<h1>"), texto.LastIndexOf("</h1>"));

            return valueH1;
        }
    }
}
