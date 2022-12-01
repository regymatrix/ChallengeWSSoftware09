### Desafio Técnico com String
LEVEL: Easy

##Cenário

Você deve desenvolver uma solução em  .NET usando a linguagem de programação C# ou de outra preferência a fim de criar sua 
própria biblioteca de extração de conteúdos <tag> de um arquivo HTML conforme especificações a seguir.

Arquivo HTML
Um arquivo HTML é uma página de internet composto de tags para representar o conteúdo.
Exemplo de conteúdo de uma página em HTML.


<HTML>
   <head>
    <title> Desafio <title>
   <head>
   <body>
        <h1>Meu Site</h1>
        <p>
            Exemplo de um texto <img src="img_girl.jpg" alt="Girl in a jacket" width="500" height="600" /> </br>
            Essa linha não tem imagem.
         </p>
   </body>
</HTML>

No exemplo acima, dentro da tag body temos a tag h1, p, e img. Algumas tags são pares <p></p>. Já  a tag img não é solitária.
Não tem tag par. 

Com base nas informações a acima você deve criar sua própria classe extratora de tags HTMl. O nome da classe deve ser 
obrigatoriamente ExtratoraDeTagsHTML e deve conter os métodos a seguir.

Para cada método OBRIGATORIAMENTE deve conter teste UNITÁRIO com no mínimo 2 cenários implementados.

##Método 01 - quantidadeDeLetras

Objetivo => retornar a quantidade de caracteres de um texto informado.
Retorno = > int 
Parâmetors de entrada => string texto

Assinatura do Método final

public int quantidadeDeLetras(string texto)

Cenários de Testes de Exemplos
Teste [01]
  Entrada: ["texto <img src="img_girl.jpg" />"] 
  Saída: 32
Teste [02]
  Entrada: ["<h1>Meu Site</h1>"]
  Saída: 17

#Método 02 - quantidadeDeVogais
Objetivo => retornar a quantidade de vogais em um texto
Retorno = > int 
Parâmetors de entrada => string texto
Teste [01]
  Entrada: ["texto <img src="img_girl.jpg" />"] 
  Saída: 5
Teste [02]
  Entrada: ["<h1>Meu Site</h1>"]
  Saída:4

#Método 03 - ExtrairTagIMG
Objetivo => retornar todo o conteúdo da tag img
Retorno = > string 
Parâmetors de entrada => string texto
Teste [01]
  Entrada: ["texto <img src="img_girl.jpg" />"] 
  Saída: <img src="img_girl.jpg" />
Teste [02]
  Entrada:  ["texto gota <img src="../../imagemBrasil.jpg" /> continua texto"] 
  Saída: <img src="../../imagemBrasil.jpg" />

#Método 04 - ExtrairEnderecoAtributoSRC
Objetivo => retornar o endereço que está dentro da tag img no atributo SRC
Retorno = > string 
Parâmetors de entrada => string texto
Teste [01]
  Entrada: ["texto <img src="img_girl.jpg" />"] 
  Saída: img_girl.jpg
Teste [02]
  Entrada:  ["texto gota <img src="../../imagemBrasil.jpg" /> continua texto"] 
  Saída: ../../imagemBrasil.jpg

#Método 05 - ExtrairTagH1
Objetivo => retornar todo o conteúdo da tag H1
Retorno = > string 
Parâmetors de entrada => string texto
Teste [01]
  Entrada: ["<body> texto <img src="img_girl.jpg" />  <h1> Desafio </h1> <body>"] 
  Saída: <h1> Desafio </h1>
Teste [02]
  Entrada: ["<body> <h1> Desafio </h1> texto <img src="img_girl.jpg" />  <body>"] 
  Saída: <h1> Desafio </h1>


  Entrega

  .NET
  Sua solução deve conter um projeto com a classe ExtratoraDeTagsHTML e seus métodos.
  Também, deverá conter um projeto de teste unitário com cenários para todos os métodos solicitados.
