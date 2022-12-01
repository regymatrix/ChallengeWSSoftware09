using ChallengeWSSoftware09.Library;
using NUnit.Framework.Internal;

namespace ChallengeWSSoftware09.Test
{
    [TestClass]
    public class ExtratoraDeTagsHTMLTest
    {
        [TestMethod]
        public void QuantidadeDeLetras_1()
        {
            ExtratoraDeTagsHTML extratoraDeTagsHTML = new ExtratoraDeTagsHTML();

            Assert.AreEqual(
                expected: 32,
                actual: extratoraDeTagsHTML.QuantidadeDeLetras("texto <img src=\"img_girl.jpg\" />"));
        }
        [TestMethod]
        public void QuantidadeDeLetras_2()
        {
            ExtratoraDeTagsHTML extratoraDeTagsHTML = new ExtratoraDeTagsHTML();

            Assert.AreEqual(
                expected: 5,
                actual: extratoraDeTagsHTML.QuantidadeDeVogais("texto <img src=\"img_girl.jpg\" />"));
        }
        [TestMethod]
        public void QuantidadeDeVogais_1()
        {
            ExtratoraDeTagsHTML extratoraDeTagsHTML = new ExtratoraDeTagsHTML();

            Assert.AreEqual(
                expected: 4,
                actual: extratoraDeTagsHTML.QuantidadeDeVogais("<h1>Meu Site</h1>"));
        }
        [TestMethod]
        public void QuantidadeDeVogais_2()
        {
            ExtratoraDeTagsHTML extratoraDeTagsHTML = new ExtratoraDeTagsHTML();

            Assert.AreEqual(
                expected: 17,
                actual: extratoraDeTagsHTML.QuantidadeDeLetras("<h1>Meu Site</h1>"));
        }
        [TestMethod]
        public void ExtrairTagIMG_1()
        {
            ExtratoraDeTagsHTML extratoraDeTagsHTML = new ExtratoraDeTagsHTML();

            Assert.AreEqual(
                expected: "<img src=\"img_girl.jpg\" />",
                actual: extratoraDeTagsHTML.ExtrairTagIMG("texto <img src=\"img_girl.jpg\" />"));
        }
        [TestMethod]
        public void ExtrairTagIMG_2()
        {
            ExtratoraDeTagsHTML extratoraDeTagsHTML = new ExtratoraDeTagsHTML();

            Assert.AreEqual(
                expected: "<img src=\"../../imagemBrasil.jpg\" />",
                actual: extratoraDeTagsHTML.ExtrairTagIMG("texto gota <img src=\"../../imagemBrasil.jpg\" /> continua texto"));
        }
        [TestMethod]
        public void ExtrairEnderecoAtributoSRC_1()
        {
            ExtratoraDeTagsHTML extratoraDeTagsHTML = new ExtratoraDeTagsHTML();

            Assert.AreEqual(
                expected: "img_girl.jpg",
                actual: extratoraDeTagsHTML.ExtrairEnderecoAtributoSRC("texto <img src=\"img_girl.jpg\" />"));
        }
        [TestMethod]
        public void ExtrairEnderecoAtributoSRC_2()
        {
            ExtratoraDeTagsHTML extratoraDeTagsHTML = new ExtratoraDeTagsHTML();

            Assert.AreEqual(
                expected: "../../imagemBrasil.jpg",
                actual: extratoraDeTagsHTML.ExtrairEnderecoAtributoSRC("texto gota <img src=\"../../imagemBrasil.jpg\" /> continua texto"));
        }
        [TestMethod]
        public void ExtrairTagH1_1()
        {
            ExtratoraDeTagsHTML extratoraDeTagsHTML = new ExtratoraDeTagsHTML();

            Assert.AreEqual(
                expected: "<h1> Desafio </h1>",
                actual: extratoraDeTagsHTML.ExtrairTagH1("<body> texto <img src=\"img_girl.jpg\" />  <h1> Desafio </h1> <body>"));
        }
        [TestMethod]
        public void ExtrairTagH1_2()
        {
            ExtratoraDeTagsHTML extratoraDeTagsHTML = new ExtratoraDeTagsHTML();

            Assert.AreEqual(
                expected: "<h1> Desafio </h1>",
                actual: extratoraDeTagsHTML.ExtrairTagH1("<body> <h1> Desafio </h1> texto <img src=\"img_girl.jpg\" />  <body>"));
        }
    }
}