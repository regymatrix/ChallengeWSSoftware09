using ChallengeWSSoftware09.Library;

var teste = new ExtratoraDeTagsHTML();

Console.WriteLine("Método 1");
Console.WriteLine(teste.QuantidadeDeLetras("texto <img src=\"img_girl.jpg\" />"));
Console.WriteLine(teste.QuantidadeDeLetras("<h1>Meu Site</h1>"));

Console.WriteLine("Método 2");
Console.WriteLine(teste.QuantidadeDeVogais("texto <img src=\"img_girl.jpg\" />"));
Console.WriteLine(teste.QuantidadeDeVogais("<h1>Meu Site</h1>"));

Console.WriteLine("Método 3");
Console.WriteLine(teste.ExtrairTagIMG("texto <img src=\"img_girl.jpg\" />"));
Console.WriteLine(teste.ExtrairTagIMG("texto gota <img src=\"../../imagemBrasil.jpg\" /> continua texto"));

Console.WriteLine("Método 4");
Console.WriteLine(teste.ExtrairEnderecoAtributoSRC("texto <img src=\"img_girl.jpg\" />"));
Console.WriteLine(teste.ExtrairEnderecoAtributoSRC("texto gota <img src=\"../../imagemBrasil.jpg\" /> continua texto"));

Console.WriteLine("Método 5");
Console.WriteLine(teste.ExtrairTagH1("<body> texto <img src=\"img_girl.jpg\" />  <h1> Desafio </h1> <body>"));
Console.WriteLine(teste.ExtrairTagH1("<body> <h1> Desafio </h1> texto <img src=\"img_girl.jpg\" />  <body>"));