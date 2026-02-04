# Curso Alura - C#: criando sua primeira aplicação

## Aula 1 - Criando o primeiro programa

### Aula 1 - Apresentação - Video 1

Transcrição  
Guilherme: Olá, meu nome é Guilherme Lima e sou formado em Sistemas de Informação. Já trabalhei com alguns projetos focados em linguagens de alto nível, como JavaScript, Python e Go, e agora vou te acompanhar nessa aventura com o C#!

Guilherme é um homem branco, de cabelo curto castanho, olhos castanhos, e barba curta castanha. Ele usa um óculos de armação preta e quadrada, e veste uma camisa preta com a estampa branca "The Beatles". Ele está sentado à esquerda de uma mesa preta com um computador e um microfone à sua frente, e ao fundo há uma parede iluminada em lilás com o logo da Alura sobre um painel preto.

Daniel: Olá, eu sou o Daniel Portugal, e assim como o Guilherme, sou graduado em Sistemas de Informação. Trabalho com desenvolvimento há 20 anos, especialmente com C# e .NET, mas também outras linguagens, como JavaScript.

Daniel é um homem branco, de cabelo curto preto, olhos pretos e bigode preto. Ele usa óculos de armação preta e quadrada, e veste uma camisa preta com a estampa roxa "Black Sabbath". Ele está sentado à direita da mesa em frente ao instrutor Guilherme, também com um computador e um microfone à sua frente, e com o mesmo cenário lilás ao fundo.

Guilherme: Estamos muito felizes por ter você nesse curso sobre C#!

Daniel: Ao longo do curso, construiremos um projeto do zero, chamado Screen Sound, em que faremos registros e avaliações de bandas, além de visualizar a média de avaliação.

Com esse projeto, conheceremos o C#, sua sintaxe, e também alguns recursos que vão nos ajudar no desenvolvimento do projeto. Correto, Gui?

Guilherme: Isso mesmo! Como pré-requisito para essa formação, é importante que você tenha assistido aos cursos de lógica de programação. A partir desse conhecimento, daremos continuidade ao tema e nos aprofundaremos de fato como funciona o C# e a estrutura do .NET.

Daniel: Estou curioso!

Guilherme: Vamos iniciar nossos estudos e colocar a mão na massa?!

### Aula 1 - IDE e lógica de programação

Olá!  
Antes de você começar a escrever programas em C#, é importante entender conceitos que guiam a forma como esse código é construído. Nesta atividade, vamos te ajudar a fazer essa ponte entre ferramenta e pensamento lógico.

O que é uma IDE (e por que você precisa de uma)?

Uma IDE é um programa, como qualquer outro que você já usa no computador. Assim como você tem um navegador (como Firefox ou Chrome) para acessar a internet, a IDE é o programa que você vai usar para escrever, testar e rodar seus códigos. Mas ela vai além disso. Uma IDE – Integrated Development Environment (ambiente de desenvolvimento integrado) – é mais do que um editor de texto com destaque de sintaxe. Ela combina editor de código, compilador, depurador, terminal integrado e outras ferramentas que tornam o processo de desenvolver software mais fluido, seguro e produtivo.

Em vez de você precisar usar várias ferramentas separadas (um editor para escrever, um terminal para compilar, outro programa para rodar o código), a IDE centraliza tudo em um só lugar.

Além disso, ela oferece:

- Autocompletar inteligente (com base em contexto e tipo dos dados)
- Detecção de erros em tempo real
- Depuração passo a passo, com breakpoints e visualização de variáveis
- Templates e assistentes para começar projetos mais rápido
- Integração com plataformas de nuvem e bancos de dados

Ou seja, a IDE ajuda você a se concentrar na lógica do seu código, em vez de perder tempo com tarefas manuais e repetitivas. Funciona da seguinte forma:

![alt text](image.png)

Visual Studio x Visual Studio Code: qual escolher?

Uma IDE bastante comum para escrever códigos em C# é o Visual Studio, criado pela própria Microsoft. Ele é o ambiente oficial para desenvolvimento com .NET, e é amplamente usado por profissionais que desenvolvem sistemas web, aplicações desktop, APIs, jogos, entre outros.

Mas existe também uma segunda opção, que é o Visual Studio Code, também da Microsoft — e apesar dos nomes parecidos, eles são ferramentas bem diferentes.

Visual Studio (IDE completa)

- Voltado para desenvolvimento .NET, C#, ASP.NET, Azure, Blazor, entre outros.
- Recomendado para projetos profissionais, corporativos ou complexos.
- Traz suporte nativo a testes automatizados, modelagem visual de dados e interface gráfica.
- É mais pesado e roda oficialmente só em Windows e Mac.

Visual Studio Code (editor leve + extensões)

- É um editor de código leve, rápido e multiplataforma (Linux, Windows e macOS).
- Funciona como um "canivete suíço": com as extensões certas, você transforma ele em um - ambiente poderoso.
- Para C#, você vai precisar instalar a extensão da linguagem + .NET SDK.

Nas próximas aulas iremos ensinar a instalar ambas ferramentas no sistema operacional de sua preferência.

Lógica de programação

É a capacidade de descrever soluções de problemas usando sequências bem definidas de instruções. É ela que conecta o que você quer fazer com o que o computador precisa para entender.

![alt text](image-1.png)

Para programar bem, você precisa pensar de forma estruturada:

- Entrada → processamento → saída: essa é a base de qualquer programa.
- Estruturas de controle: comandos que permitem tomar decisões e repetir tarefas.
- Estrutura de dados: organiza as informações que serão manipuladas no seu código.
- Funções: formas de reutilizar lógica, organizando o código em blocos nomeados, cada um com uma responsabilidade específica.

Pense em lógica de programação como projetar uma receita de bolo. Você precisa dizer exatamente o que fazer, na ordem certa, prevendo todos os cenários possíveis. Quanto mais clara e organizada sua lógica, mais confiável será seu programa. E você deve estar se perguntando: Por que isso importa? Esses conceitos não são apenas "teoria". Eles vão te dar clareza e autonomia na hora de ler erros, organizar seu código, dividir tarefas em etapas menores e buscar ajuda quando precisar. Entender o ambiente (IDE) e o raciocínio lógico é o que vai te tornar uma pessoa desenvolvedora com base sólida, independente da linguagem ou da ferramenta.

> Agora que você estudou alguns conceitos importantes da linguagem, é hora de aplicar tudo na prática! Vamos lá?

### Aula 1 - Preparando o ambiente: Windows - Video 2

Transcrição (o texto era apenas isso)

Se você utiliza o sistema operacional Windows, este vídeo é para você. Caso esteja usando outro sistema (como Linux ou macOS), recomendamos que você pule esta aula e vá diretamente para a que corresponde ao seu sistema operacional. Isso garante que você siga as instruções corretas para a sua máquina.

### Aula 1 - Preparando o ambiente: Linux

Se você está começando a programar em C# e usa Linux, este guia é para você! Antes de escrever seus primeiros códigos, é necessário configurar o ambiente de desenvolvimento corretamente. Mas talvez você se pergunte: C# não é uma linguagem da Microsoft? Será que funciona no Linux? A resposta é sim! Graças ao .NET, que é multiplataforma, você pode desenvolver aplicações C# no Linux com tranquilidade.

Neste passo a passo, vamos instalar o .NET SDK, um conjunto de ferramentas necessário para criar, compilar e testar aplicações em C# no Linux. Com o SDK instalado, você poderá:

- Criar projetos em C#,
- Escrever e editar seu código,
- Executar e testar diretamente pelo terminal.

Vamos focar na instalação em distribuições baseadas no Debian, como Ubuntu, Linux Mint, Pop!OS, entre outras. Siga as instruções abaixo para instalar o .NET SDK. Importante: Alguns comandos utilizam sudo, que requer permissões de administrador. Ao executá-los, o terminal solicitará sua senha. Digite-a e pressione Enter. Por motivos de segurança, é normal que nenhum caractere seja exibido enquanto você digita.

Atualize os pacotes do sistema

Abra o terminal e execute o seguinte comando:

> sudo apt update && sudo apt upgrade -y

Esse comando atualiza a lista de pacotes disponíveis e instala as atualizações mais recentes para seu sistema, garantindo que tudo esteja em dia antes da instalação do .NET.

Janela de terminal exibindo um comando para atualizar e atualizar pacotes em um sistema Linux, solicitando uma senha

Instale o .NET SDK
No terminal, execute o comando abaixo para realizar a instalação:

> sudo apt install -y dotnet-sdk-8.0

Este comando baixa e instala o SDK da versão 8.0 do .NET, que inclui as ferramentas necessárias para compilar e rodar aplicações em C#.

Janela de terminal exibindo comandos do Ubuntu, com comando destacado para instalar o .NET SDK versão 8.0

Verificando a instalação
Você pode executar o seguinte comando para verificar se o SDK foi instalado corretamente:

> dotnet --version

Se tudo estiver certo, o terminal mostrará o número da versão instalada (por exemplo: 8.0.100), confirmando que o SDK está pronto para uso.

Saída do terminal mostrando o processo de instalação do .NET 8.0.116 no Ubuntu, indicando as etapas de preparação e configuração do pacote

Com o .NET SDK instalado, seu ambiente está preparado para começar a desenvolver aplicações em C# no Linux. Agora você pode criar seus primeiros projetos, escrever códigos diretamente no editor de sua preferência e executar tudo pelo terminal. Se ainda não escolheu um editor, recomendamos o Visual Studio Code. Ele é leve, flexível, funciona muito bem no Linux e, com a extensão do C# instalada, oferece recursos como autocompletar, realce de sintaxe e muito mais.

Se quiser começar agora, abra o terminal e experimente criar um novo projeto com:

dotnet new console -n MeuPrimeiroApp
cd MeuPrimeiroApp
> dotnet run

Isso criará e executará um programa em C# que exibe "Hello, World!" no terminal.

Te vejo na próxima atividade!

### Aula 1 - Preparando o ambiente: macOS - Video 3

Transcrição  
Se você utiliza o sistema operacional macOS, este vídeo é para você. Caso esteja usando outro sistema (como Linux ou Windows), recomendamos que você pule esta aula e vá diretamente para a que corresponde ao seu sistema operacional. Isso garante que você siga as instruções corretas para a sua máquina.

### Aula 1 - Preparando o ambiente: Visual Studio Code - Video 4

Transcrição  
Se você já usa o Visual Studio Code e quer utilizá-lo para programar em C#, este vídeo é para você.

### Aula 1 - Primeiro programa - Video 5

Transcrição  
Guilherme: Com o Visual Studio aberto, inicialmente temos o primeiro programa feito com C#: o Hello World (arquivo Program.cs). Ao executá-lo, é aberto apenas o terminal com a seguinte mensagem:

Terminal na máquina do instrutor Guilherme:

```C#
Hello, World!

O C:\Users\guilherme\source\repos\PrimeiroProjeto\PrimeiroProjeto\bin\Debug\net7.0\PrimeiroProjeto.exe (processo 26844) foi encerrado com o código 0.
Pressione qualquer tecla para fechar esta janela…
```

Nosso objetivo é desenvolver uma aplicação back-end para um sistema de músicas. Criaremos então uma aplicação de streaming com diversos artistas, bandas e músicas, mas o foco não será a parte visual, e sim o back-end da aplicação.

Dito isso, aprenderemos a armazenar músicas e a manipular determinados conteúdos, como registrar ou avaliar bandas… Faremos tudo isso com o C#!

Retornando ao Visual Studio, temos o código do programa "Hello, World!". Ele é formado apenas por uma primeira linha de comentário e por uma segunda linha contendo o comando Console.WriteLine(), adicionado quando iniciamos o programa.

Vamos remover ambas as linhas e começar a desenvolver a nossa aplicação.

Daniel: O nome do nosso projeto será Screen Sound, correto?

Guilherme: Exatamente. Começaremos o código com um comentário contendo o nome da aplicação de músicas. Para isso, utilizamos o sinal //.

> // Screen Sound

O primeiro ponto importante que precisamos entender em relação ao C# é que se trata de uma linguagem fortemente tipada. O que isso significa, Daniel?

Daniel: Significa que precisamos sempre declarar o tipo das variáveis criadas. Podemos iniciar declarando uma variável que represente uma mensagem de boas-vindas ao nosso projeto.

Guilherme: Legal! Quando vamos escrever um texto, geralmente usamos aspas duplas.

Em JavaScript e algumas outras linguagens, podemos escolher entre aspas simples ou aspas duplas. Em C#, existe a possibilidade de usar aspas simples, mas não é esse o caso.

Escreveremos a seguinte mensagem entre as aspas:

```C#
// Screen Sound
"Boas vindas ao Screen Sound"
```

Porém, não é somente dessa forma que criamos uma variável. Precisaremos adicionar algumas outras informações, certo, Daniel?

Daniel: Sim, a informação com a mensagem de boas-vindas precisa estar armazenada em uma variável. Criaremos a nossa primeira variável do tipo string (que representa um texto) e a chamaremos de mensagemDeBoasVindas. Vamos adicionar então ambos os elementos seguidos de um sinal de =, separando a declaração da variável e a mensagem de fato.

```C#
// Screen Sound
string mensagemDeBoasVindas = "Boas vindas ao Screen Sound"
```

Guilherme: Feito isso, ainda aparenta existir um problema no fechamento das aspas duplas. Ao posicionar o cursor sobre ela, temos a seguinte informação:

CS1002: ; esperado

O que esse último dado significa, Daniel?

Daniel: Significa que toda instrução no C# precisa ser terminada com ponto e vírgula. Essa é a indicação feita pelo computador.

```C#
// Screen Sound
string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";
```

Guilherme: Colocamos o ponto e vírgula e a notificação do erro desapareceu. Porém, a variável mensagemDeBoasVindas também está marcada com um sublinhado. Posicionando o cursor sobre ela, temos a mensagem abaixo:

CS0219: A variável "mensagemDeBoasVindas" é atribuída, mas seu valor nunca é usado

Ou seja, temos um espaço na memória para a variável, mas não usamos o conteúdo.

Daniel: Perceba que no compilador, o Visual Studio dá feedbacks visuais imediatos. No fechamento das aspas, havia um indicador vermelho que representa um erro. No caso acima, o indicador visual (isto é, o sublinhado) é verde, representando que a variável foi declarada, mas não utilizada.

Guilherme: Antes de começar a usar a variável, vamos deixar a nossa tela um pouco mais limpa em relação aos conteúdos, para focar apenas no código.

Podemos, por exemplo, fechar o Gerenciador de Soluções na lateral direita do Visual Studio. Temos a opção de clicar no botão "X" ou de usar o atalho "Shift + Esc". Além disso, podemos fechar a aba inferior "Saída", onde está selecionada a opção "Mostrar saída de: Compilação".

Dessa forma, teremos somente o código exibido na tela.

Daniel:

No caso da aba "Saída", quando executarmos novamente o programa, o processo de compilação também será executado, então pode ser que essa aba volte a aparecer.

Guilherme: Agora vamos usar o comando Console.WriteLine(). Entre parênteses, vamos passar o nome da variável mensagemDeBoasVindas.

```C#
// Screen Sound
string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";
Console.WriteLine(mensagemDeBoasVindas);
```

Lembre-se: não colocamos a variável entre aspas, pois queremos exibir seu próprio conteúdo, e não de fato o texto "mensagemDeBoasVindas".

Note que a variável é composta por 4 palavras, sendo que as 3 últimas são iniciadas com letra maiúscula. Quando trabalhamos com variáveis, seguimos o padrão Camel Case.

Daniel: Nesse padrão, a primeira palavra começa com letra minúscula e o restante com letra maiúscula.

Guilherme: Agora vamos executar o código! Para isso, temos o botão "Iniciar Sem Depurar" (ícone ▶), localizado na barra superior do Visual Studio. Caso prefira, você pode usar o atalho "Ctrl + F5".

Após a execução, é aberta novamente a aba "Saída", exibindo a saída de compilação. Finalizado o processo, o programa será aberto em outra janela chamada "Console de Depuração do Microsoft Visual Studio", onde teremos a mensagem de boas-vindas:

Terminal na máquina do instrutor Guilherme:

Boas vindas ao Screen Sound

```C#
O C:\Users\guilherme\source\repos\PrimeiroProjeto\PrimeiroProjeto\bin\Debug\net7.0\PrimeiroProjeto.exe (processo 22548) foi encerrado com o código 0.
Pressione qualquer tecla para fechar esta janela…
```

Temos um programa melhor, com conceitos que fazem sentido para todo o desenvolvimento a seguir.

Conforme dito anteriormente, a C# é uma linguagem fortemente tipada, então definimos o tipo, o nome da variável com a qual vamos trabalhar, e depois passamos o valor do conteúdo para o comando Console.WriteLine(). Dessa forma, conseguimos utilizar nossas variáveis!

### Aula 1 -  - Video 6
### Aula 1 -  - Video 7
