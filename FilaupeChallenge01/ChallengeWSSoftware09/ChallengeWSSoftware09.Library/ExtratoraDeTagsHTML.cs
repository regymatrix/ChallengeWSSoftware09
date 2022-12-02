using System.Text.RegularExpressions;

namespace ChallengeWSSoftware09.Library
{
    public class ExtratoraDeTagsHTML
    {
        public int QuantidadeDeLetras(string texto) => texto.Length;

        public int QuantidadeDeVogais(string texto) => texto.Count(t => Regex.IsMatch(t.ToString(), @"[aeiou]"));

        public string ExtrairTagIMG(string texto) => Regex.Split(texto, @"(<img .+?>|/>)").First(t => t.Contains("<img"));

        public string ExtrairEnderecoAtributoSRC(string texto) => Regex.Split(texto, @"src=(.*\.jpg|\.png|\.jpeg|\.gif|\.bmp|\.psd|\.tiff|\.pdf|\.svg)").First(c => c.Contains('"')).Replace("\"", "");

        public string ExtrairTagH1(string texto) => Regex.Split(texto, @"(<h1>.*</h1>)").First(t => t.Contains("h1"));
    }
}