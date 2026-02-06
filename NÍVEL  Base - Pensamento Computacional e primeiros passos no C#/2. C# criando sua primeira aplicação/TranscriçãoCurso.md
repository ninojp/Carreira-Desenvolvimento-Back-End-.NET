# Curso Alura - C#: criando sua primeira aplicação

## Aula 1 - Criando o primeiro programa

### Aula 1 - Apresentação - Vídeo 1

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

### Aula 1 - Preparando o ambiente: Windows - Vídeo 2

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

### Aula 1 - Preparando o ambiente: macOS - Vídeo 3

Transcrição  
Se você utiliza o sistema operacional macOS, este vídeo é para você. Caso esteja usando outro sistema (como Linux ou Windows), recomendamos que você pule esta aula e vá diretamente para a que corresponde ao seu sistema operacional. Isso garante que você siga as instruções corretas para a sua máquina.

### Aula 1 - Preparando o ambiente: Visual Studio Code - Vídeo 4

Transcrição  
Se você já usa o Visual Studio Code e quer utilizá-lo para programar em C#, este vídeo é para você.

### Aula 1 - Primeiro programa - Vídeo 5

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

### Aula 1 - Hello World - Exercício

O "Hello World" é geralmente o primeiro programa que um iniciante em programação escreve em uma nova linguagem de programação. Essa tradição se iniciou em um tutorial que foi desenvolvido pela Bell Labs em 1972 para ensinar a programação em C. O programa em C simplesmente exibia a mensagem "Hello, World!" na tela do computador.

Desde então, a tradição se espalhou e tornou-se uma forma comum de iniciar o aprendizado em programação em várias outras linguagens, incluindo C#, Java, Python e muitas outras.

Sabendo disso, analise as informações abaixo e marque aquela com a finalidade de exibir uma mensagem no console com a mensagem Hello World.

Dica: para testar essa e as demais atividades, você pode usar o Tutorial interativo do C# clicando neste link e clicar no botão entrar no modo de foco.

Resposta:  
Console.WriteLine("Hello World!");

> Isso aí! Escrever um "Hello World" é uma forma simples e rápida de testar se o ambiente de desenvolvimento da linguagem de programação está funcionando corretamente.

### Aula 1 - Bastidores de um programa C# - Vídeo 6

Transcrição  
Olá! Nesse vídeo, Daniel Portugal trouxe um aprofundamento para a dúvida que surge na cabeça de todo estudante: como funciona a mágica entre eu escrever código e o programa rodar, de fato? Para isso, vamos sair um pouco do Visual Studio e entender o que é necessário para executar um código C#!

Estamos com o Visual Studio aberto, utilizando um programa em C#, no caso, o programa Screen Sound. Queremos executar esse programa. Para isso, clicamos no botão com um ícone de triângulo verde, que no nosso caso está associado ao projeto chamado Primeiro Projeto, relacionado ao Screen Sound. Ao clicar, uma tela do terminal aparece com a execução do programa. No entanto, houve um problema: precisamos instalar ou atualizar o .NET para rodar a aplicação.

Processo de Execução Manual no Terminal  
Vamos discutir o que ocorre quando clicamos no botão de execução do Visual Studio até a exibição do programa no terminal. Para isso, deixaremos de utilizar o Visual Studio, mostrando o processo de forma mais didática. Fechamos o Visual Studio e abrimos um novo terminal. É importante fechar o Visual Studio para não interferir no processo, assumindo-o manualmente.

No terminal, navegamos para a pasta onde está o programa C#, usando o comando cd para acessar a pasta "src/repos/alura/CSharp". Dentro dessa pasta, encontramos duas subpastas, "bin" e "obj", além de arquivos como PrimeiroProjeto.csproj e Programa.cs. Vamos limpar a pasta removendo os diretórios "bin" e "obj" com o comando rmdir e listar novamente os arquivos para confirmar a remoção.

Compilação e Execução de Programas .NET  
O processo de execução de um programa .NET ocorre em dois passos: compilação e execução. A compilação transforma o código C# em uma saída utilizável no ambiente de execução do .NET. As pastas "obj" e "bin" são criadas nesse processo. A pasta "obj" contém objetos intermediários, enquanto a "bin" contém os arquivos finais para execução.

Para compilar, usamos o comando dotnet build, que cria as pastas "bin" e "obj". A pasta "obj" acelera o processo de compilação, pois armazena objetos intermediários, evitando recompilar todos os arquivos C#. A pasta "bin" mantém os arquivos finais para execução.

Após a compilação, o segundo passo é a execução, que utiliza o comando dotnet run. No entanto, ao tentar executar, recebemos a mensagem de erro indicando a necessidade de instalar ou atualizar o .NET. Isso ocorre porque o framework de destino não está instalado na máquina.

Ajuste do Projeto para Versão Correta do .NET  
Para resolver, ajustamos o projeto para uma versão do .NET que está instalada. No arquivo de projeto, PrimeiroProjeto.csproj, alteramos a tag TargetFramework para uma versão disponível, como a 8. Após salvar a alteração, recompilamos e executamos novamente com dotnet run. Com o framework correto, o programa é executado com sucesso.

Estrutura de Pastas e Propósitos de Execução  
Uma coisa interessante é que, ao executar um dir, podemos ver o arquivo bin. Se fizermos dir /bin/debug, estaremos listando tudo o que está dentro da parte chamada debug. Vamos explicar o que há dentro dessa pasta. Agora, temos tanto uma pasta .NET 7 quanto .NET 8. Foi necessário recompilar a aplicação, agora apontando para o target framework 8. Quando executamos o dotnet run, o sistema percebeu que precisávamos dos arquivos finais no .NET 8 e fez a compilação para essa versão.

A pasta debug é algo que ainda não discutimos. Observem a estrutura de pastas dentro da pasta bin, que contém os arquivos finais. Temos a pasta bin, e dentro dela, uma pasta chamada debug, que contém os arquivos finais para cada framework de destino. O que significa debug? Refere-se ao objetivo da execução. Queremos executar o programa para depuração, ou seja, para diagnósticos. Se houver algum erro ou dúvida sobre a lógica utilizada, podemos fazer uma depuração. Lembre-se de que ainda não é o arquivo final para publicação ou entrega ao cliente. Quando entregarmos ao cliente, otimizaremos ainda mais o processo, tornando a compilação mais enxuta e a execução final mais rápida. O processo de depuração deixa o arquivo mais completo, permitindo parar a aplicação em um determinado ponto de execução para verificação. Isso requer carregar os símbolos utilizados, e a depuração compila usando mais informações e metadados.

Publicação do Programa  
Para publicar o programa, podemos executar dotnet run com o propósito de fazer uma publicação ou release. Ao fazer isso, uma nova pasta chamada Release é criada dentro da pasta bin. Essa pasta indica que o objetivo agora é entregar ao cliente, tornando os arquivos mais enxutos e a execução mais otimizada. Podemos compilar a aplicação para diferentes propósitos. As duas configurações padrão do .NET são Debug para depuração e Release para publicação. É possível criar configurações próprias, mas isso não será abordado neste vídeo.

Recapitulação do Processo de Compilação e Execução  
Recapitulando, tivemos a compilação com dotnet build, que cria as pastas bin e obj. Depois, executamos o arquivo final na pasta bin, dependendo do propósito e configuração, seja Debug ou Release, em um framework de destino. Encontramos um erro por não ter a versão 7 do framework de destino, mas ao mudar para 8, conseguimos executar o Screen Sound no terminal. A execução de um programa C# ocorre em dois passos: compilação e execução.

Funções da Common Language Runtime (CLR)  
A execução acontece dentro de uma máquina virtual chamada CLR (Common Language Runtime). Vamos falar sobre essa máquina virtual e seus componentes. A CLR gerencia a memória, alocando e desalocando objetos dentro dos limites definidos para o processo em execução. Isso torna os programas C# gerenciados, pois são executados dentro de uma CLR que monitora e limita o acesso à memória. A CLR também garante a segurança do código, impedindo ações maliciosas no computador, como acesso indevido ao processador, memória ou disco.

Outra função da CLR é o tratamento de exceções. Se ocorrer um erro de execução, ela fornece mecanismos para lidar com isso. Aprenderemos a lidar com exceções no código, mas a CLR já oferece esses mecanismos. Além disso, a CLR gerencia threads, permitindo execuções paralelas de tarefas, algo que aprenderemos a fazer.

A função mais importante da CLR é executar o código. Ela pega o código IL (Intermediate Language), que está na pasta bin, e o transforma em código para a máquina específica onde está sendo executado. Isso é feito de forma inteligente pelo Just-In-Time Compiler, que compila apenas o que está sendo executado no momento, tornando o programa mais rápido. No exemplo do Screen Sound, temos vários menus, e o Just-In-Time Compiler compila apenas os métodos chamados pela primeira vez, armazenando-os em cache para uso posterior.

Conclusão e Recursos Adicionais  
Para finalizar, vamos recapitular visualmente no slide tudo o que discutimos. A execução de um programa C# no Visual Studio envolve dois passos: compilação e execução. Na compilação, o código é transformado em linguagem intermediária nas pastas .obj e .bin usando o comando dotnet build. A pasta .obj contém objetos intermediários para acelerar a compilação de projetos com muitos arquivos C#, enquanto a pasta .bin contém o arquivo final para o destino necessário, como .NET 7, .NET 8, Debug ou Release.

O comando dotnet build está disponível ao fazer o download do SDK (Software Development Kit). Ao instalar o Visual Studio, o .NET SDK é instalado, fornecendo o comando para compilar um programa C#. Na execução, o arquivo com extensão csproj indica o projeto a ser executado, e uma runtime de destino ou Target Framework é necessária. Durante a execução, o código intermediário é compilado em código nativo pelo Just-In-Time Compiler. Para executar, basta fazer o download da CLR, sem necessidade do SDK.

Se apenas quisermos executar programas .NET, não precisamos instalar o SDK, que é um download maior. Como pessoas desenvolvedoras, teremos o SDK instalado, mas ao executar o programa em uma máquina de cliente, apenas a CLR é necessária. Para finalizar, vamos abrir uma página da Microsoft com os downloads disponíveis. O link será disponibilizado na transcrição do vídeo. A página de download mostra as distinções discutidas. Na coluna da esquerda, temos os downloads do SDK para todas as plataformas, pois o .NET é multiplataforma desde 2015 com o .NET Core. O SDK permite programar no Linux, macOS e Windows, e inclui suporte para o Visual Studio 2022, além de runtimes para programas de console, web e desktop.

Na coluna da direita, temos os downloads apenas para os runtimes, para executar o código em linguagem intermediária. Há runtimes para ASP.NET, programas web, e recomenda-se instalar o Hosting Bundle no Windows, que inclui o .NET Runtime e suporte para o IIS, um programa da Microsoft para servir sites web. Também há o Desktop Runtime e um runtime genérico para programas de console. O SDK é para pessoas desenvolvedoras, enquanto os runtimes são para execução de programas.

Concluímos a explicação sobre a execução de um programa C#. Esperamos que tenham gostado e nos encontraremos novamente na próxima vez. Até lá!

### Aula 1 - CLI do .NET - Vídeo 7

Transcrição

>[Documentação do .NET CLI](https://learn.microsoft.com/pt-br/dotnet/core/tools/)

No vídeo anterior, discutimos os bastidores da execução de um programa em C#. Demonstramos como, ao entrar no terminal, digitamos dois comandos: dotnet e build. Mas do que se trata isso? Trata-se do .NET CLI, que significa Command Line Interface (Interface de Linha de Comando). Essa ferramenta permite que digitemos comandos diretamente no terminal.

Funções e Ciclo de Vida do .NET CLI  
O .NET CLI é uma ferramenta que apoia o ciclo de vida do desenvolvimento de aplicações .NET, utilizando comandos no terminal. Quando falamos de ciclo de vida, referimo-nos a todo o processo, desde a criação de projetos e artefatos, passando por tarefas rotineiras como compilação, teste e limpeza, até tarefas mais específicas. Por exemplo, podemos querer adicionar um segredo de usuário, uma string de conexão de banco de dados ou uma chave de API adquirida por uma empresa, integrando-a a um sistema de criptografia. Essas são ações pontuais, mas fazem parte do ciclo de desenvolvimento de uma aplicação .NET.

Além disso, o .NET CLI oferece ferramentas para a etapa final, onde publicamos nossa aplicação .NET. Embora tenhamos visto isso através da execução, existem outros comandos disponíveis para completar o ciclo de vida, desde o início até a entrega final de uma aplicação .NET.

Histórico e Motivação do .NET CLI  
O .NET CLI foi introduzido juntamente com o .NET Core, a versão multiplataforma do .NET, em 2015. Antes disso, a experiência de desenvolvimento era fragmentada, com diferentes ferramentas e interfaces, algumas visuais e outras baseadas em terminal. Isso tornava o processo complicado, exigindo o aprendizado de várias ferramentas para completar o ciclo de desenvolvimento de uma aplicação .NET. O .NET CLI foi criado para ser utilizado de forma uniforme em várias plataformas, como Windows, Linux e macOS, permitindo que o mesmo comando seja usado em qualquer sistema operacional, proporcionando uma experiência mais fluida para a pessoa desenvolvedora.

Há um artigo interessante de Scott Hanselman, um dos líderes no processo de criação do .NET CLI, que explica a lógica e a motivação histórica por trás de sua criação. O artigo, datado de dezembro de 2015, detalha como ele buscava simplificar o processo, permitindo que comandos como dotnet new, restore e run fossem suficientes para realizar o trabalho. Esse artigo é uma leitura recomendada para quem deseja explorar mais sobre o contexto histórico do .NET CLI.

Estrutura e Funcionamento do .NET CLI  
Por fim, para entender a estrutura e o funcionamento do .NET CLI, é essencial acessar a documentação. Como pessoas desenvolvedoras, frequentemente precisamos aprender sobre bibliotecas, frameworks e paradigmas de desenvolvimento, o que requer a leitura de documentação técnica. Vamos acessar a documentação do CLI, e o link para isso será disponibilizado na transcrição do vídeo.

Não vamos nos estender muito aqui, pois é algo que podemos fazer com calma. Basicamente, precisamos mostrar a estrutura do comando. Existe algo que chamamos de driver. O termo é driver, e a palavra é dotnet. Escrevemos dotnet, entramos nesse executável e executamos a ferramenta .NET CLI. Em seguida, colocamos o comando que desejamos executar.

Comandos Básicos do .NET CLI  
Temos duas opções: podemos executar um programa, como na terceira linha, onde estamos executando um programa. Não há o comando run que aprendemos, mas ele está embutido aqui. Existem outras maneiras de usar o .NET CLI, como indicamos nas duas primeiras linhas: dotnet new e dotnet build, que também são formas de uso. Sempre há o driver, que em português seria "motorista", mas a palavra inicial é dotnet. Após um espaço, fazemos algo usando essa ferramenta de desenvolvimento.

A partir do comando, temos vários argumentos que utilizamos, dependendo do comando que queremos usar. Existem comandos básicos que são entregues com a instalação do .NET CLI. Esses comandos facilitam o ciclo de vida, como criação de artefatos e tarefas rotineiras, como compilação, adição de pacotes e bibliotecas no projeto. Também há tarefas não tão rotineiras, como clean, help, store, watch, que estão disponíveis nos comandos básicos da CLI.

Temos o comando publish, que é usado para a entrega de uma aplicação, colocando todos os artefatos em uma pasta para a entrega da aplicação. Ao clicar em cada link, obtemos informações sobre cada comando especificamente.

Simulação de Criação e Execução de Projeto  
O dotnet new e o dotnet build são comandos que já usamos. Indicamos o projeto e a solução. O run também foi um comando que executamos. Usamos o comando -c para mudar para release. Se não colocássemos nada, ele usaria a configuração padrão debug, que é nosso propósito de execução. Já utilizamos alguns comandos em vídeos anteriores.

Essa ferramenta de desenvolvimento auxilia no processo e no ciclo de vida. Vamos simular rapidamente a criação e execução de um projeto usando apenas o terminal e o .NET CLI. Com o terminal aberto, podemos fazer o mesmo. Clique no botão do Windows, digite "terminal" ou "prompt", e teremos a tela preta. Aumentaremos o zoom para enxergar os comandos que vamos digitar. Vamos simular a criação de uma aplicação até sua execução, sem fazer a publicação, que veremos em outros cursos. Vamos simular o ciclo de vida desde a criação de um projeto até sua execução.

Primeiro, navegamos para uma pasta onde costumamos colocar nossos projetos, como "source" ou "repos" na Alura. Aqui estão todos os projetos desenvolvidos para a Alura. Vamos criar um projeto nesta pasta. O comando que usamos é dotnet, lembrando que o driver é sempre esse, e o comando é new. O comando new cria um novo projeto, mas precisamos especificar o tipo de projeto. Vamos criar um projeto simples do tipo console, chamado "console". Vamos nomear o projeto como "segundo projeto", pois já temos um primeiro. Então, dotnet new console -n "segundo projeto" cria um projeto console, especificando o tipo e o nome do projeto. Ao pressionar enter, ele indica que o modelo de aplicativo de console foi criado com êxito em uma pasta chamada "segundo projeto" e criou um arquivo com extensão .csproj.

Vamos navegar para a pasta "segundo projeto" e listar os arquivos. Estamos familiarizados com os arquivos: uma pasta "obj" que mantém a compilação de objetos intermediários, um arquivo Program.cs e um arquivo de projeto indicando metadados e o framework de destino. Vamos ver o que há dentro do Program.cs usando o notepad. O arquivo contém apenas um "hello world". Vamos alterar para "hello .NET CLI", salvar e fechar.

Agora, queremos executar o programa e exibir na tela nosso "hello .NET CLI". Após criar o projeto, queremos compilar. Já alteramos o nome do programa para "hello .NET CLI" e agora queremos compilar para executar. O comando é dotnet build, que tenta fazer o build do projeto ou do arquivo .csproj dentro da pasta. Podemos indicar o nome do arquivo se houver vários .csproj na mesma pasta. Ele compila o projeto, atualiza os objetos intermediários na pasta "obj" e cria uma pasta "bin" com os arquivos finais na estrutura de destino indicada no projeto. Ao listar, já temos a pasta "bin", que contém nosso debug, o propósito de execução, e dentro da pasta "bin/debug" temos o .NET framework de destino, no caso, a versão mais atual, .NET 9.

Podemos executar com dotnet run. Se não indicarmos nada, ele executa o .csproj na pasta. Ao pressionar, ele exibe a mensagem atualizada que editamos no console. Mostramos rapidamente alguns comandos para trabalhar com o .NET CLI. Não aprofundamos nos outros comandos, mas a documentação está disponível na página da Microsoft para consulta.

Vantagens e Extensibilidade do .NET CLI  
O .NET CLI é uma ferramenta de desenvolvimento moderna. As pessoas desenvolvedoras estão acostumadas a começar o desenvolvimento usando terminais, além das IDEs. A curva de entrada é rápida: entramos no terminal, criamos projetos e começamos a desenvolver. É uma ferramenta moderna e atual em termos de desenvolvimento. Além disso, oferece uma experiência uniforme em todas as plataformas. Os mesmos comandos que explicamos no Windows podem ser executados no Linux e macOS, o que é bastante interessante.

O .NET CLI permite automatizar tarefas, criar scripts para pipelines de distribuição de aplicações, criar imagens em containers e automatizar a criação de ambientes inteiros para execução. Veremos isso em cursos futuros da Alura. Outra característica importante é que é extensível. Podemos criar nossos próprios comandos e instalar comandos de terceiros. Veremos comandos de terceiros em cursos futuros, como quando trabalharmos com acesso a banco de dados usando a biblioteca Entity Framework Core, que possui seus próprios comandos do .NET CLI. Ferramentas de terceiros podem estender o .NET CLI com mais comandos, e nós também podemos fazer isso.

O .NET CLI é uma ferramenta moderna, uniforme, automatizável e flexível, que auxilia bastante no ciclo de vida de desenvolvimento de aplicações .NET.

### Aula 1 - Desafio: hora da prática

A prática é um elemento essencial ao iniciar os estudos em programação, pois é por meio da aplicação prática dos conceitos teóricos que se solidificam os conhecimentos. Ao escrever código, resolver problemas e construir projetos reais, os iniciantes não apenas internalizam a sintaxe das linguagens de programação, mas também desenvolvem a habilidade de pensar logicamente e abordar desafios de maneira eficiente.

Pensando nisso, criamos uma lista de atividades (não obrigatórias) focada em prática para melhorar ainda mais sua experiência de aprendizagem. Bora praticar então?

- Criar uma variável chamada curso, e guarde nela o nome do curso estudado.
- Mostrar o conteúdo da variável curso no console.
- Criar uma variável chamada nome e outra chamada sobrenome e guardar nelas seu nome e sobrenome.
- Mostrar na tela o nome dos instrutores do curso.

Opinião do instrutor

Para te ajudar a verificar seus códigos, disponibilizamos uma lista com as possíveis soluções no Github.

Boa sorte nos estudos!

### Aula 1 - Para saber mais: Documentação da linguagem

É normal, ao decorrer do aprendizado, surgirem dúvidas: como usar determinada função, se existe outra forma de resolver um problema, ou o que exatamente um comando faz. Essa fase faz parte do processo de aprender a programar. Em vez de decorar tudo, o importante é saber onde e como buscar respostas confiáveis e é aí que a documentação oficial entra como uma ferramenta indispensável para qualquer pessoa desenvolvedora.

O que é uma documentação?  
A documentação oficial de uma linguagem de programação é como um manual técnico completo, criado pela equipe que desenvolve a linguagem. No caso do C#, a Microsoft mantém uma documentação robusta, que explica o funcionamento de funções, classes, bibliotecas, estruturas de linguagem, além de fornecer exemplos, observações de uso e boas práticas.

Ela é organizada em seções, muitas vezes com buscas por palavras-chave, tópicos relacionados e links diretos para exemplos de código, tudo pensado para ajudar no dia a dia do desenvolvimento.

Preciso ler tudo?  
Não. Um erro comum é achar que você precisa “estudar a documentação inteira”. Na prática, a consulta à documentação é sob demanda. Isso significa que você a utiliza quando precisa entender um recurso específico. Por exemplo, se estiver em dúvida sobre como criar uma lista (List<T>), você pode procurar esse termo e ler apenas aquela parte.

Com o tempo, conforme vai consultando repetidamente, você começa a se familiarizar com a estrutura e a navegar mais rapidamente entre os tópicos.

Por que usar a documentação?

- Porque é oficial, confiável e está sempre atualizada.
- Porque explica o porquê das coisas.
- Porque ajuda você a escrever códigos mais corretos, limpos e seguros.
- E principalmente, porque desenvolve em você uma autonomia técnica. Você aprende a resolver problemas por conta própria.

Como aproveitar melhor?

- Guarde os links da documentação nos seus favoritos.
- Leia com calma o trecho que responde sua dúvida — sem precisar se aprofundar em tudo de uma vez.
- Teste os exemplos no seu próprio código.
- Reforce sua busca com palavras-chave precisas (ex: "C# string format").

Links de documentações de C#:

- [Documentação do C# (Microsoft Learn)](https://learn.microsoft.com/pt-br/dotnet/csharp/tour-of-csharp/)
- [API .NET – Referência das bibliotecas e classes](https://learn.microsoft.com/pt-br/dotnet/api/)
- [Documentação do Visual Studio](https://learn.microsoft.com/pt-br/visualstudio/)

Desenvolver o hábito de consultar a documentação oficial te torna uma pessoa desenvolvedora muito mais preparada para lidar com desafios reais. Ao invés de decorar tudo, você aprende a navegar pelas ferramentas que já existem. Comece incorporando isso na sua rotina de estudos, e com o tempo, você vai ganhar velocidade e confiança no seu processo de aprendizagem.

Compartilhe no fórum: Qual foi a primeira vez que você consultou a documentação? O que descobriu? Como isso te ajudou?

### Aula 1 - História do C# - Vídeo 8

Transcrição  
O C# está completando 25 anos! Você já se perguntou sobre a história e a origem desta linguagem? Qual é a relação entre C# e .NET? Quais foram as versões lançadas até hoje? Atualmente, estamos na versão 13 do C#! E como o C# está sendo utilizado hoje em dia? Está sendo usado conforme o proposto inicialmente? Vamos explorar um pouco sobre essa história e evolução da linguagem.

Contexto Histórico e Motivação  
Primeiramente, vamos abordar o contexto histórico que motivou a criação do C#. Em seguida, passaremos por uma linha do tempo para conhecer os recursos lançados em cada versão. Também discutiremos a diferença entre C# e .NET, termos que serão frequentemente mencionados ao longo desta história. Finalmente, falaremos sobre o uso atual do C#.

Nos anos 90, a Microsoft dominava o mercado de software, liderando sistemas operacionais com o Windows 95 e 98, além do segmento de softwares para escritório com o pacote Office, que incluía Word e Excel. A Microsoft também tinha uma presença significativa no desenvolvimento de software, com ferramentas como o Visual Studio e o VB, uma linguagem de programação usada para desenvolvimento rápido de aplicações.

Na época, o C++ era amplamente utilizado para construir softwares comerciais da Microsoft, como Windows, Office e Internet Explorer, além de softwares de outras empresas, como Photoshop e MySQL. O C++ também era usado no desenvolvimento de jogos, como o famoso Doom, devido ao seu desempenho em processamento de imagens e computação.

Outro evento importante nos anos 90 foi a explosão da web, com a popularização da rede de computadores e o surgimento de navegadores para acessar a internet. Isso gerou uma demanda por sites mais dinâmicos e informações atualizadas constantemente, levando ao desenvolvimento de software para a web.

Desafios e Oportunidades  
Antes da criação do C#, a Microsoft utilizava três grandes linguagens de programação: C++, VB e ASP/VBScript. O C++ era a principal linguagem para desenvolvimento de softwares comerciais, mas apresentava baixa produtividade e uma curva de aprendizado difícil. O VB era usado para programação rápida e produtiva, mas era limitado e não tão moderno quanto outras linguagens emergentes. O ASP e o VBScript eram utilizados para desenvolvimento web, mas eram limitados a esse ambiente.

Durante esse período, houve a consolidação do paradigma de desenvolvimento Orientado a Objetos (OO), que se tornou uma demanda entre as pessoas desenvolvedoras. A Microsoft estava atenta a essas mudanças, incluindo a explosão da web e a popularidade do paradigma OO.

Surgimento do C#  
Nesse cenário, surgiu o Java, uma linguagem orientada a objetos que rodava na web e era multiplataforma, permitindo independência de sistema operacional. Isso representou uma ameaça ao domínio da Microsoft, que buscava uma solução para manter sua relevância no mercado de desenvolvimento de software.

A Microsoft inicialmente licenciou o Java da Sun, criando o Visual J++, mas acabou enfrentando problemas legais devido a modificações que feriam os princípios multiplataforma do Java. Após um processo judicial, a Microsoft foi obrigada a descartar essa versão modificada do Java.

Apesar do fracasso, o projeto Visual J++ trouxe um entendimento interno sobre o funcionamento do Java. A equipe foi realocada para um novo projeto liderado por Anders Hejlsberg, chamado COOL (C-Like Object Oriented Language). Anders tinha um histórico notável, tendo criado o Turbo Pascal e o Delphi.

Lançamento do C# e .NET Framework  
Em 2000, a Microsoft anunciou o lançamento do C# e do .NET Framework na Professional Development Conference (PDC). O C# foi fortemente inspirado no C++, Java e no paradigma orientado a objetos. Era uma linguagem gerenciada, sem acesso direto à memória e hardware, com execução feita pelo .NET Framework, semelhante ao Java.

O .NET Framework permitia o uso de várias linguagens, oferecia uma biblioteca de classes rica e integração profunda com o Windows. O C# e o .NET Framework foram projetados para unificar as linguagens existentes na Microsoft, atendendo a segmentos como software comercial, sistemas transacionais, desktop, jogos e web.

Evolução do C#  
A mudança do nome de COOL para C# ocorreu porque o nome COOL já estava registrado. O nome C#, inspirado na anotação musical de um semitom acima, simboliza uma evolução, um passo além do que já existia, e representa uma evolução do C++.

O símbolo da tralha pode ser visualmente entendido como quatro símbolos de mais, além dos dois mais do C++. Há uma brincadeira com o nome, e o C# representa uma evolução do C++. Essa é a origem do nome. Nos anos 2000, o C# e o .NET surgem com a promessa de oferecer uma linguagem moderna, robusta, produtiva, orientada a objetos e fortemente integrada ao ecossistema Windows, sem problemas de compatibilidade, pois era uma linguagem completamente nova.

Linha do Tempo das Versões do C#  
Vamos falar sobre a linha do tempo das versões do C#. Em 2002, o C# 1 foi lançado publicamente, após ter sido anunciado em 2000, juntamente com o .NET Framework. Desde o início, o C# 1 já oferecia suporte completo à orientação a objetos e era executado em um ambiente gerenciado pelo .NET Framework. O C# 2 e o C# 3 foram lançados em 2005 e 2007, respectivamente. O C# 2 introduziu suporte a Generics (genéricos), um recurso que será abordado nos cursos da Alura. O C# 3 trouxe uma grande revolução estrutural com o recurso chamado LINQ (Language Integrated Query), além de Lambdas e métodos de extensão, transformando significativamente a estrutura dos programas em C#.

O .NET Framework também evoluiu, com a versão 3.5 sendo lançada junto com o C# 3. Em 2010, a versão 4 foi lançada, buscando interoperabilidade com programas escritos em outras linguagens. O C# 5 introduziu suporte à programação paralela e assíncrona. A partir de 2012, a Microsoft mudou sua estratégia, lançando o .NET Framework 4.5 em vez de um .NET Framework 5. Em 2015, o .NET Framework 4.6 foi lançado junto com o C# 6, que focou em tornar a linguagem mais expressiva e com menos linhas de código, facilitando a adoção por iniciantes.

Em 2017, o .NET Core foi lançado com o C# 7 e o .NET Framework 4.7, permitindo a execução de programas C# em múltiplas plataformas, como Linux, MacOS e Windows. Essa mudança visava tornar o .NET multiplataforma. O C# 8 foi lançado com o .NET Framework 8 e o .NET Core 3. Em 2019, a Microsoft unificou todos os .NETs no .NET 5, eliminando as versões separadas do .NET Framework e do .NET Core. O C# 9 introduziu Records, uma versão melhorada de classes, permitindo escrever menos código para representar estruturas de classe.

Em 2021, o C# 10 trouxe melhorias para tornar a linguagem mais expressiva, introduzindo Global Usings. Em 2022, o C# 11 continuou a melhorar a expressividade da linguagem. Em 2023, o C# 12 foi lançado com Construtores Primários, e em 2024, o C# 13 trouxe melhorias em coleções. Este ano, teremos o C# 14 e o .NET 10, com novos recursos ainda a serem anunciados.

Comparação de Código: C# 3 vs C# 13  
Vamos comparar um programa escrito em C# 3 com sua versão atual no C# 13. O programa cria uma lista de nomes, filtra os que começam com a letra A, ordena alfabeticamente e exibe no console. No C# 3, o código era mais extenso e incluía código cerimonial, como a classe Program e o método void Main. Com o C# 13, o código se tornou mais conciso e expressivo, eliminando a necessidade de using, Program e Main, e utilizando métodos como forEach do LINQ.

Multiparadigma e Aplicações do C#  
O C# é uma linguagem multiparadigma, suportando paradigmas imperativo, orientado a objetos, funcional e reativo. Isso permite que pessoas desenvolvedoras com diferentes mentalidades resolvam problemas de maneiras diversas. Além disso, o C# e o .NET são usados em múltiplos propósitos, como desenvolvimento web com ASP.NET Core, jogos com Unity, aplicativos móveis com Xamarin e Maui, programas desktop com Windows Forms e WPF, serviços na nuvem com Azure, e inteligência artificial com bibliotecas de Machine Learning.

O Ecossistema .NET  
O .NET é um ecossistema completo de desenvolvimento, incluindo uma máquina virtual para executar programas, uma biblioteca de classes, frameworks de aplicação, compiladores e ferramentas de desenvolvimento como Visual Studio e Visual Studio Code. A partir do .NET Core, o gerenciamento de dependências foi facilitado com o NuGet.

O .NET evoluiu para três principais versões: o .NET Framework, exclusivo para Windows; o .NET Core, multiplataforma; e o .NET unificado a partir do .NET 5. Essa simplificação visa facilitar a adoção por iniciantes.

Perspectivas de Carreira  
O mercado do .NET é vasto, permitindo o desenvolvimento em diversas áreas, como web, jogos, mobile, desktop e inteligência artificial. Desejamos a todos uma carreira bem-sucedida utilizando o C# e o .NET, e esperamos encontrá-los nos cursos da Alura. Até lá!

### Aula 1 - O que aprendemos?

Aqui está um resumo dos tópicos ensinados nesta aula:  
Preparamos o ambiente de desenvolvimento (Visual Studio) no Windows, Mac e Linux para criar programas com C# na plataforma .Net;

Configuramos do ambiente para desenvolvimento em C# e uma aplicação baseada no console;

Entendemos o conceito de linguagem fortemente tipada e a importância de declarar o tipo da variável que desejamos trabalhar em uma aplicação;

Utilizamos do comando Console.WriteLine para exibir informações na tela e ver o programa que desenvolvemos sendo executado.

Na próxima aula:  
Vamos seguir as boas práticas de programação evitando código duplicado e aprender de forma prática como trabalhar com variáveis de tipos diferentes!

## Aula 2 - Tipos e Funções em C#

### Aula 2 - Isolando o código com funções - Vídeo 1

Transcrição  
Guilherme: O programa ficou interessante, pois conseguimos alterar o texto do "Hello, World" utilizando uma variável, resultando na seguinte mensagem no console:

Boas vindas ao Screen Sound

Apesar de ser uma aplicação de console que será exibida apenas no terminal, seria interessante melhorar sua aparência. Vamos adicionar asteriscos acima e abaixo da frase para deixá-la mais agradável visualmente.

Na linha 4 do arquivo Program.cs, adicionamos um Console.WriteLine("") contendo vários asteriscos. Vamos copiar e colar essa linha logo abaixo da mensagem de boas-vindas.

Program.cs

```C#
// Screen Sound
string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";
Console.WriteLine("**************************");
Console.WriteLine(mensagemDeBoasVindas);
Console.WriteLine("**************************");
```

Depois clicamos no botão "▶" na parte superior.

No console, obtemos:

```C#
***************************
Boas vindas ao Screen Sound
***************************
```

Agora está mais interessante.

Uma observação relevante é que, ao executarmos o programa com esses asteriscos, ele adquire uma nova aparência. No entanto, essa aparência ainda não é visualmente atraente. Essa mensagem de boas-vindas será exibida em diferentes momentos da nossa aplicação, e um conceito bem conhecido na programação é a capacidade de isolar um código para ser reutilizado em outros momentos, evitando a necessidade de copiá-lo.

Uma abordagem que podemos utilizar para isolar nosso código é criar uma função.

Daniel: A fim de aproveitar o código de forma mais eficiente, é importante notar que vamos mencionar bastante a importância do reuso de código, evitando repetições e tornando o código mais conciso. Isso nos permite utilizá-lo em diferentes momentos, sem a necessidade de recriá-lo constantemente.

Guilherme: Criaremos uma função para reutilizar as três instruções do nosso código. Para começar, precisamos determinar se a função terá ou não um valor de retorno.

Quando a função não tem um valor de retorno, ou seja, realiza ações sem retornar um resultado, usamos a palavra reservada void (em português, "vazio").

Program.cs

```C#
// Screen Sound
string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";
void 
Console.WriteLine("**************************");
Console.WriteLine(mensagemDeBoasVindas);
Console.WriteLine("**************************");
```

Daniel: Apenas um adendo, Gui. É importante observar que, ao mencionarmos a palavra reservada, o compilador nos fornece uma indicação visual por meio da cor azul. Observe que as palavras "string" e "void" estão em azul, o que significa que são palavras reservadas.

Guilherme: Legal, Daniel.

Prosseguindo, utilizamos o void para indicar que a função terá um comportamento específico, mas não esperamos que ela retorne algum valor. Nomearemos essa função como ExibirMensagemDeBoasVindas(). Para encapsular as três linhas de código, utilizamos as chaves de abertura e fechamento: {}.

A formatação utilizada na função ExibirMensagemDeBoasVindas() é um padrão visual amplamente adotado em C#: o nome da função seguido por parênteses vazios na mesma linha e, na linha seguinte, o uso das chaves de abertura e fechamento.

Depois podemos copiar as linhas das nossas instruções e colar dentro da função:

Program.cs

```C#
// Screen Sound
string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";
void ExibirMensagemDeBoasVindas()
{
         Console.WriteLine("**************************");
         Console.WriteLine(mensagemDeBoasVindas);
         Console.WriteLine("**************************");
}
```

Daniel: É importante notarmos que diferente da nomenclatura da variável mensagemDeBoasVindas o nome dessa função ExibirMensagemDeBoasVindas() utiliza outra convenção conhecida como PascalCase, em que a primeira palavra inicia com letra maiúscula.

O padrão PascalCase é adotado na nomenclatura de funções

Guilherme: Existem dois padrões a serem seguidos: o CamelCase para nomear variáveis e o PascalCase para nomear funções. Vamos executar clicando em "▶" e analisando no console nada foi exibido.

Isso ocorre porque declaramos a função, porém, não a chamamos para ser executada.

Daniel: Inclusive, há uma indiciação visual no código. Abaixo da função ExibirMensagemDeBoasVindas() há uma sublinhado na cor verde.

Guilherme: Exatamente, e colocando o mouse por cima da função, temos a seguinte mensagem:

A função local 'ExibirMensagemDeBoasVindas' está declarada, mas nunca é usada.

Para usarmos uma função, depois dela nós a chamamos pelo nome e abrimos e fechamos parênteses.

Program.cs

```C#
// Screen Sound
string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";
void ExibirMensagemDeBoasVindas()
{
         Console.WriteLine("**************************");
         Console.WriteLine(mensagemDeBoasVindas);
         Console.WriteLine("**************************");
}
ExibirMensagemDeBoasVindas();
```

Novamente clicamos em "▶" e analisando no console, obtemos a mensagem:

```C#
***************************
Boas vindas ao Screen Sound
***************************
```

Isso significa que a função está sendo exibida.

Vamos melhorar o visual dessa mensagem no próximo vídeo. Até mais!

Daniel: Até, pessoal!

### Aula 2 - Variáveis do tipo texto - Vídeo 2

Transcrição  
Daniel: Gui, sinceramente, o resultado não está bonito. Sei que você se esforçou, mas precisa melhorar isso.

Guilherme: Amizade é isso, pessoal, é sinceridade.

Eu confesso que tentei, tem aqui os asteriscos de boas-vindas, mas não está bonito. Posso tentar deixar mais bonito?

Vou acessar uma aplicação no [navegador chamada FSymbols](https://fsymbols.com/pt/geradores/) na seção de geradores.

Nela podemos escrever, por exemplo, Screensound, que é o nome da nossa aplicação, e ele vai mostrar diversas formas de exibir esse nome. Nós podemos escolher um desses e copiar.

Lembrando que nem todos vão funcionar. Além disso, se você quiser colocar outro nome no programa que você está desenvolvendo junto conosco, você pode.

Texto "screen sound" desenhado com caracteres especiais.

Nós temos a mensagem de boas-vindas com os asteriscos que o Daniel odiou. Acima dela, criaremos um console.WriteLine() e, dentro dos parênteses, colaremos o conteúdo copiado do FSymbols. Devido ao tamanho do "texto", ele não será exibido corretamente, se uma outra pessoa trabalhar nessa aplicação ela poderá pensar que é um erro.

Entretanto, executando a aplicação, teremos no terminal o Screen Sound sendo exibido corretamente. Acho que os asteriscos até não fazem mais sentido e podemos tirá-los.

Executando mais uma vez, o visual ficou melhor. Ficou bonito pra caramba. É assim que a gente cresce na vida, vem alguém e fala que aquilo que você fez não está bom, você melhora e continua. Momento autoajuda do curso.

Daniel: Gui, pra ajudar a próxima pessoa desenvolvedora que for pegar o código, podemos fazer uma melhoria lá naquela string.

Guilherme: É verdade. Nós melhoramos a parte do console, mas uma pessoa desenvolvedora que chega em um projeto assim provavelmente removeria esse console.Write(), pois está difícil identificar o que ele faz.

Como que nós podemos melhorar a exibição dessa string, que é muito longa, para que a próxima pessoa que for trabalhar nesse projeto saiba o que é?

Daniel: O que precisamos é exibir a string como ela vai ficar. Para isso, vamos usar um símbolo antes de começar as aspas, que é o arroba (@).

Podemos apagar tudo que está dentro da string e colar de novo, porque a partir desse momento ela será exibida literalmente como deveria ficar.

Guilherme: Se queremos exibir a string literal, nós abrimos aspas após o arroba, damos dois "Enter" e colamos a string copiada.

```C#
﻿// Screen Sound
string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";
List`<string>` listaDasBandas = new List`<string>` { "U2", "The Beatles", "Calypso"};  

void ExibirLogo()
{
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine(mensagemDeBoasVindas);
}
```

Agora a pessoa que vai trabalhar sabe que se trata do logo do screen sound. Executando, nós temos o menu. Bem melhor.

Daniel: Lembrando que esse recurso com arroba que começa um texto é chamado de verbatim literal. É basicamente você colocar a string do jeito que você quer que ela apareça na função.

Guilherme: No botão de "menos" à esquerda (-), eu consigo também minimizar esse trecho no Visual Studio, para não precisar ficar exibindo toda aquela string.

Quando nós executamos o programa, ele mostra o screen sound bem bonito.

Seria legal se nós pudéssemos exibir um menu de opções. Vamos criar esse menu?

Acho que, para organizar o nosso código, faz mais sentido criarmos uma função. Será uma função void chamada ExibirOpcoesDoMenu(), seguida de parênteses e chaves.

```C#
void ExibirOpcoesDoMenu()
{

}
```

Podemos colocar essas opções de maneira enumerada. Começaremos com um Console.WriteLine() com a mensagem "Digite 1 para registrar uma banda". Como nós estamos trabalhando com back-end, as pessoas vão registrar e listar bandas na nossa aplicação.

Teremos um segundo Console.WriteLine() com o texto "Digite 2 para mostrar todas as bandas", e um terceiro com "Digite 3 para avaliar uma banda"

Daniel: Também podemos exibir a média de avaliações, "Digite 4 para exibir a média de uma banda". E nós podemos fazer uma opção para sair, por exemplo "Digite -1 para sair".

```C#
void ExibirOpcoesDoMenu()
{
    Console.WriteLine("Digite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");
}
```

Guilherme: Essas opções do menu vamos exibir embaixo do "Boas-vindas". Na linha 28, nós executamos o ExibirMensagemDeBoasVindas() e na linha 29 eu peço para exibir as opções com ExibirOpcoesDoMenu().

```C#
ExibirMensagemDeBoasVindas();
ExibirOpcoesDoMenu();
```

Daniel: Executando, agora temos o nosso projeto definido com as suas funções específicas.

Guilherme: Repara que aqui no "Digite 1", onde de fato nós temos as opções, seria legal se nós tivéssemos um espaç para conseguir visualizar melhor.

Daniel: Para isso, podemos incluir um Console.WriteLine() com uma string vazia, ou usar o \n que inclusive utilizamos anteriormente na outra opção da logo.

Guilherme: No Console.WriteLine() da primeira opção, na linha 20, vou adicionar esse \n e executar novamente.

```C#
void ExibirOpcoesDoMenu()
{
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");
}
```

Assim temos a mensagem de boas-vindas e em seguida as opções. Nosso próximo passo será trabalhar cada uma das opções.

Daniel: Certo, precisamos capturar a opção que a pessoa usuária digitar, esse é o próximo passo.

### Aula 2 - Variáveis do tipo inteiro - Vídeo 3

Transcrição  
Guilherme: Nosso programa está legal em partes. Vamos executá-lo, clicando no botão "Play" da aba do arquivo Program.cs. Com isso, é exibido no terminal o título "SCREEN SOUND" com letras em caixa alta estilizadas, uma mensagem de boas-vindas e as opções do menu.

Mas, se pressionamos qualquer tecla, não acontece mais nada — nosso programa acaba. Mostramos as opções, mas não deixamos a pessoa selecionar a desejada pelas teclas.

Daniel: Portanto, não há opção nenhuma.

Guilherme: Então, de alguma forma, precisamos capturar a opção que a pessoa digitou, certo? Seja para registrar uma banda, mostrar a média e assim por diante.

Daniel: Acho que podemos fazer uma pergunta primeiro, com um texto do tipo "qual é a sua escolha?".

Guilherme: Excelente. Então, na linha 26 do código, dentro da função ExibirOpcoesDoMenu() vamos escrever essa mensagem com o Console.WriteLine, pulando uma linha no programa usando \n e inserindo um espaço ao final do texto para a pessoa digitar:

Program.cs

> Console.WriteLine("\nDigite a sua opção: ");

Esse código vai exibir a mensagem "Digite a sua opção", mas, teoricamente, só isso vai acontecer. Precisamos, de alguma forma, pegar o valor que a pessoa vai digitar nesse menu. Como fazemos isso?

Capturando o comando da pessoa usuária  
Daniel: Usamos o método Console.WriteLine() para escrever mensagens, e usaremos o Console.ReadLine() para ler esse valor. Usando o ReadLine(), esperamos que a pessoa usuária digite a opção e aperte "Enter" também.

Guilherme: Escrevendo Console.Read, recebemos algumas opções diferentes, como apenas Read e ReadKey. Vamos selecionar ReadLine():

```C#
Console.WriteLine("\nDigite a sua opção: ");
Console.ReadLine();
```

Mas, precisamos armazenar em algum lugar o que a pessoa digitar. Vamos executar o programa agora em seu estado atual, pressionando "Ctrl + F5", para entender o que está acontecendo.

No terminal aberto com o programa, podemos notar que a mensagem "Digite a sua opção: " está sendo exibida abaixo do menu, e o cursor para digitar está posicionado abaixo da frase. Queríamos que o cursor estivesse na mesma linha da frase, afinal, deixamos um espaço para isso depois dos dois pontos.

Daniel: Nesse caso, ao invés de usar o WriteLine(), podemos usar apenas o Write(). Assim, o programa escreverá o texto que está no argumento da função sem pular linha depois.

Guilherme: Certo, então vamos apagar o Line da linha 26:

```C#
Console.Write("\nDigite a sua opção: ");
Console.ReadLine();
```

Vamos executar mais uma vez para conferir. No programa, o cursor para digitar a opção está sendo exibido ao lado da frase "Digite a sua opção: ".

Vamos digitar "1" no programa, para registrar uma banda, e pressionar "Enter". Novamente, o programa é encerrado porque não criamos mais nada em relação a isso.

Daniel: Vamos armazenar essa opção digitada pela pessoa em uma variável.

Guilherme: Certo. Para isso, vamos criar uma string chamada opcaoEscolhida que receberá o Console.ReadLine():

```C#
Console.Write("\nDigite a sua opção: ");
string opcaoEscolhida = Console.ReadLine();
```

Com isso, notaremos um sublinhado em verde no Console.ReadLine() que nos avisa que esse método pode retornar um valor nulo. Não queremos trabalhar com valor nulo no nosso programa, porque é necessário que esse valor seja uma string.

Para resolver isso, podemos inserir um sinal de exclamação ao final do método: Console.ReadLine()!. Ao fazer isso, o sublinhado verde some.

```C#
Console.Write("\nDigite a sua opção: ");
string opcaoEscolhida = Console.ReadLine()!;
```

Agora temos esse valor armazenado em uma variável. Em seguida, precisamos verificar qual foi a opção digitada: se foi a opção 1, se foi a opção 2, e assim por diante.

Condição para retorno  
Daniel: Então, entra agora uma condição: se a pessoa digitou "1", realizamos determinada ação; se digitou "2", outra ação, e assim vai.

Guilherme: Sim. Para isso, temos um if similar ao dos cursos de lógica de programação. Escrevemos if e, entre parênteses, inserimos a nossa condição. O VSCode até sugere a condição opcaoEscolhida == null, mas não é isso que queremos.

Na verdade, queremos dizer o seguinte: "se a opção escolhida for igual a 1, por exemplo, realizaremos a seguinte ação entre chaves". Então trocamos o null para 1 e adicionamos as chaves em seguida.

Essa ação pode ser, por exemplo, escrever a mensagem "Você digitou a opção x": ConsoleWriteLine("Você digitou a opção x"). No lugar desse x, queremos colocar o valor da variável opcaoEscolhida. Como fazer isso?

No JavaScript, colocamos um espaço entre a última palavra da frase e as aspas e depois inserimos o sinal de adição e o nome da variável, por exemplo: + opcaoEscolhida. Aqui funciona assim também:

```C#
// código omitido
if (opcaoEscolhida == 1)
{
        ConsoleWriteLine("Você digitou a opção " + opcaoEscolhida)
}
```

Mas, temos um problema na própria variável opcaoEscolhida que, sublinhada em vermelho, nos indica que seu valor não é nulo dentro desse if. Estamos usando o operador == para comparar uma string, que é tudo o que digitamos e recebemos com o ReadLine(), com o valor 1 que é um inteiro e não uma string. Não é possível fazer isso.

Daniel: Algum desses valores precisa ser convertido.

Guilherme: Exatamente: ou convertemos o 1 para string, o que não faz muito sentido; ou convertemos o opcaoEscolhida que digitamos, uma string, para um valor inteiro. O que você acha melhor?

Daniel: Acho melhor converter a opcaoEscolhida em uma nova variável de tipo inteiro. Em vez de colocar a palavra reservada string antes da declaração da variável, usaremos o int — outra palavra reservada que indica o tipo inteiro.

Convertendo string em inteiro  
Guilherme: Abaixo da variável opcaoEscolhida e antes do if, vamos criar uma nova variável de tipo int. Vamos chamá-la de opcaoEscolhidaNumerica, por exemplo, para explicitar a conversão em número. Ela receberá a variável opcaoEscolhida convertida para inteiro.

Daniel: Há algumas funções para realizar essa conversão. Podemos usar primeiro uma função que fica dentro de um tipo chamado int, chamada Parse(), que pega um texto e tenta converter para valor inteiro. Então, escrevemos int.Parse() e passamos opcaoEscolhida como parâmetro. Nossa variável nova fica assim:

```C#
int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);
```

Guilherme: Sendo assim, precisamos mudar a variável que passamos no if. Repare que ainda temos uma marcação em vermelho nele por estar usando o valor da variável opcaoEscolhida, que é uma string. O que queremos fazer agora é usar a variável de tipo inteiro, opcaoEscolhidaNumerica:

```C#
// código omitido
if (opcaoEscolhidaNumerica == 1)
{
        ConsoleWriteLine("Você digitou a opção " + opcaoEscolhida)
}
```

Não temos mais nenhuma marcação de erro, parece que funcionou! Vamos executar o programa novamente e testar a opção 1, a única que criamos até agora, digitando "1" no terminal e pressionando "Enter". O retorno surge logo abaixo:

Você digitou a opção 1

### Aula 2 - Uso de if/else e switch/case - Vídeo 4

Transcrição  
Daniel: Vamos continuar trabalhando nas opções escolhidas.

Guilherme: Como a opção 2 terá praticamente o mesmo código da opção 1, podemos copiá-lo (da linha 29 até a linha 32) e colar logo depois do fechamento do if, com um else antes para indicar "senão".

Se a opção escolhida for a 2 (opcaoEscolhidaNumerica == 2), exibimos a mensagem "Você digitou a opção 2":

Program.cs

```C#
// código omitido
if (opcaoEscolhidaNumerica == 1)
{
    ConsoleWriteLine("Você digitou a opção " + opcaoEscolhida)
} else if (opcaoEscolhidaNumerica == 2)
{
    ConsoleWriteLine("Você digitou a opção " + opcaoEscolhida)
}
```

Vamos executar o programa novamente para testar as duas opções. Com o programa aberto no terminal, digitamos a opção "1", que nós já testamos, ao lado da frase "Digite a sua opção" e pressionamos "Enter". Recebemos o retorno "Você digitou a opção 1". Tudo certo.

Vamos fechar o terminal e rodar o programa mais uma vez. Agora vamos digitar a opção "2" e pressionar "Enter". Recebemos o retorno correto: "Você digitou a opção 2".

Então o programa está, de fato, capturando essas opções!

Agora, fazemos o mesmo para a opção 3, 4 e -1?

Daniel: Na verdade, podemos usar outro recurso. Quando temos vários condicionais associados, relacionados logicamente, nós usamos o switch.

Guilherme: Então podemos remover os ifs?

Daniel: Podemos.

Switch  
Guilherme: Vamos apagar os ifs (da linha 30 até a linha 36) e, no lugar, escrever aqui switch. Ao lado, entre parênteses, colocamos o que queremos verificar — no caso, a variável opcaoEscolhidaNumerica. Abrimos e fechamos chaves em seguida e, dentro delas, vamos começar as opções.

Caso a opção escolhida seja 1, então nós colocamos um case 1 e, depois dos dois pontos (:), a mensagem de retorno com o Console.WriteLine(). Podemos inserir a mesma mensagem de antes: "Você escolheu a opção " + opcaoEscolhidaNumerica. Ao fim dessa linha, colocamos um ponto e vírgula (;).

Daniel: Também precisamos colocar a palavra reservada break na linha de baixo para finalizar esse caso, seguido de um ponto e vírgula novamente.

Guilherme: Certo. Pulando para a linha de baixo, o Visual Studio sugere o case 2 para a segunda opção. Vamos repetir o que fizemos acima para todas as outras opções — 3, 4 e -1 — copiando o mesmo método e texto:

```C#
switch (opcaoEscolhidaNumerica) 
{
    case 1:
        Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
        break;
    case 2:
        Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
        break;
    case 3:
        Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
        break;
    case 4:
        Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
        break;
    case -1:
        Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
        break;
}
```

Temos todas as opções, de 1 a 4, e também a opção -1. Trabalhamos com case e break para cada opção.

Por enquanto estamos usando a mensagem, mas adiante vamos criar uma função que vai, de fato, executar cada opção: salvar uma nova banda, registrar a banda, exibir a média da banda e assim por diante.

Daniel: Há uma última possibilidade a adicionar dentro do switch: se o usuário não digitar nenhuma dessas opções, é necessário exibir uma mensagem de opção inválida. Para isso, usamos uma palavra reservada chamada default. Ou seja: se nenhum desses casos aconteceu, caímos nesse default.

Guilherme: Então, por exemplo, a mensagem do default pode ser "Opção inválida!". O default também leva o break:

```C#
switch (opcaoEscolhidaNumerica) 
{
// código omitido
    default:
        Console.WriteLine("Opção inválida");
        break;
}
```

Vamos testar todas essas opções agora. Para isso, executaremos nosso programa algumas vezes.

Começando, na primeira execução, vamos testar a opção 1 digitando "1" ao lado de "Digite a sua opção:" e pressionando "Enter". O retorno recebido é: "Você escolheu a opção 1". Deu certo.

Vamos fechar, executar o programa novamente e escolher a opção "2" no terminal. Retorno: "Você escolheu a opção 2". Certo novamente.

Repetindo esse processo para as opções 3 e 4, recebemos as mensagens de retorno corretas de cada um: "Você escolheu a opção 3" e "Você escolheu a opção 4", respectivamente.

A opção "-1" serve para encerrar o programa, o que teoricamente já está acontecendo. Não precisamos mudar nada nessa função, a não ser a mensagem de retorno — algo como "Obrigado. Tchau.". Vamos fazer isso daqui a pouco também.

Por fim, testamos uma opção inválida, como o "99". Com isso, recebemos a mensagem "Opção inválida" e o programa encerra também.

Então, vamos alterar a mensagem do -1, quando encerramos o programa. Queremos uma mensagem bem bonita. Pode ser um "Tchau tchau" com um emoji feliz ":)".

```C#
switch (opcaoEscolhidaNumerica) 
{
// código omitido
    case -1:
        Console.WriteLine("Tchau tchau :)");
        break;
}
// código omitido
```

Vamos testar, executando novamente o programa. Vamos digitar a opção "-1" e pressionar "Enter". Recebemos a mensagem: "Tchau tchau :)". Fechou! Ficou lindo!

Daniel: Concluindo: nós conhecemos a opção condicional, o if e o if else. Em seguida aprendemos que, quando temos um cenário com muitos casos, podemos usar também o recurso switch, com a construção switch case que aplicamos.

### Aula 2 - Hello world personalizado - Exercício

Uma pessoa desenvolveu um programa que solicita o nome e exibe uma mensagem de saudação dizendo Olá seguido do nome digitado pela pessoa, como mostra o código abaixo:

```C#
Console.WriteLine("Qual é o seu nome?");
string nome = Console.ReadLine();
Console.WriteLine("Olá, " + nome + "!");
```

Sabendo disso, analise as afirmações e selecione a alternativa na qual a saída do console será a mesma:

Respostas corretas:

> Console.WriteLine($"Olá, {nome}!");

Isso aí! Neste caso usamos a sintaxe de interpolação de string que nos permite incluir variáveis diretamente em uma string usando chaves {}. Ao colocar o sinal $ antes da string, indicamos ao compilador que ela deve ser interpolação de string.

> Console.WriteLine("Olá, {0}!", nome);

Isso aí! Neste caso, usamos um formato de string que nos permite substituir marcadores de posição {0}, {1}, etc. por valores específicos. Ao passar a variável nome como segundo argumento para o método Console.WriteLine, ela será substituída no marcador de posição {0}.

### Aula 2 - Comparando tipos - Exercício

Uma pessoa que estava estudando C# desenvolveu o seguinte código:

```C#
int nota = 6;
string musica = "Yesterday";
if (nota <= "6")
{
    Console.WriteLine(musica + " -> essa música não é tão boa");
}
else
{
    Console.WriteLine(musica + " -> essa música é ótima");
}
```

Com base no código acima, analise as afirmações abaixo e selecione apenas a verdadeira:

Resposta correta:  
Ao executar esse programa, um erro será exibido no console.

> Isso aí! O erro informará que não podemos aplicar operador <= em tipos diferentes como int para nota e a string "6". Para corrigir esse erro, podemos remover as aspas da instrução if, como ilustra o código abaixo:
> if (nota <= 6)

### Aula 2 - Desafio: hora da prática

A prática é um elemento essencial ao iniciar os estudos em programação, pois é por meio da aplicação prática dos conceitos teóricos que se solidificam os conhecimentos. Ao escrever código, resolver problemas e construir projetos reais, os iniciantes não apenas internalizam a sintaxe das linguagens de programação, mas também desenvolvem a habilidade de pensar logicamente e abordar desafios de maneira eficiente.

Pensando nisso, criamos uma lista de atividades (não obrigatórias) focada em prática para melhorar ainda mais sua experiência de aprendizagem. Bora praticar então?

1. Criar uma variável chamada notaMedia e atribua um valor inteiro a ela. Caso seu valor seja maior ou igual a 5, escreva na tela "Nota suficiente para aprovação".
2. Criar uma lista de linguagens de programação, com as linguagens C#, Java e JavaScript.
3. Exibir o valor "C#" no console, utilizando a lista criada no exercício anterior.
4. Criar um programa que, dado a entrada de dados de um número n inteiro, a partir do teclado, exibir a n-ésima posição de uma lista.

Dica: Em caso de dúvidas para resolver os exercícios, recorra a Luri (Inteligência Artificial da Alura) ou a nossa comunidade no Fórum.

Resolução dos desafios:

Desafio 1:

```C#
int media = 5;
if(media >= 5)
{
    Console.WriteLine("Nota suficiente para aprovação");
}
```

Desafio 2:

```C#
List`<string>` linguagens = new List`<string>` { "C#", "Java", "JavaScript" };
```

Desafio 3:

```C#
Console.WriteLine(linguagens[0]);
```

Desafio 4:

```C#
Console.WriteLine("Digite a posição desejada: ");
int posicao = int.Parse(Console.ReadLine());

Console.WriteLine(linguagens[posicao]);
```

### Aula 2 - O que aprendemos?

Nesta aula:

- Criamos variáveis de tipos diferentes como string e int para armazenar diferentes tipos de dados;

- Desenvolvemos o menu personalizado exibindo as opções da nossa aplicação e criamos uma forma na qual o usuário pode escolher a ação que deseja;

- Aprendemos como utilizar de forma prática estruturas condicionais no C#, o que possibilita que nosso programa execute diferentes comandos de acordo com as condições estabelecidas pelas entradas de usuários.

Na próxima aula:  
Vamos aplicar em nosso projeto uma estrutura de dados muito usada no dia a dia de quem trabalha com desenvolvimento de software!

## Aula 3 - Listas e Loops no C#

### Aula 3 - Projeto da aula anterior

Aqui você pode [baixar o zip da aula 02](https://github.com/alura-cursos/csharp-01/archive/refs/heads/aula_2.zip) ou acessar os [arquivos no Github](https://github.com/alura-cursos/csharp-01/tree/aula_2)!

### Aula 3 - Criando a lista de músicas - Vídeo 1

Transcrição  
Guilherme: Chegamos a um momento incrível da nossa aplicação, vamos trabalhar de fato em cada uma dessas opções!

Case 1 - Registro de bandas  
A primeira opção é o registro de bandas. No case 1 colocamos só uma mensagem de teste. Mas agora removeremos essa mensagem para chamar uma determinada função. Podemos chamar, por exemplo, a função RegistrarBanda().

```C#
case1: RegistrarBanda();
```

O editor informou que essa função ainda não existe no contexto atual. Vamos criar a função RegistrarBanda() agora.

Na linha 47, criaremos uma função void.

```C#
void RegistrarBanda()
{

}
```

Lembre-se que a linguagem do C# é case sensitive, sensível a letras maiúsculas e minúsculas. Precisamos nos atentar a isso.

Guilherme: Então, o caso 1 vai executar a função RegistrarBanda().

O que queremos fazer? Primeiro, assim que rodamos a aplicação podíamos limpar o nosso console. Uma forma de limpar o console é com o Console.Clear(). Dessa forma, não teremos nenhum texto sendo exibido no console.

```C#
void RegistrarBanda()
{
   Console.Clear();
     
}
```

Em seguida, podemos exibir no console o texto "Registro de bandas", por exemplo, usando um Console.WriteLine().

```C#
void RegistrarBanda()
{
   Console.Clear();
     Console.WriteLine("Registro de bandas");
     
}
```

Podemos começar dando uma mensagem como "Digite o nome da banda que você deseja registrar". Mas não usaremos o Console.WriteLine() porque queremos que fique na mesma linha da mensagem que estamos passando e não embaixo. Usaremos o Console.Write().

```C#
void RegistrarBanda()
{
   Console.Clear();
     Console.WriteLine("Registro de bandas");
     Console.Write("Digite o nome da banda que deseja registrar: ")
}
```

Daniel: Legal que estamos aproveitando os conceitos que vimos anteriormente. Criamos função, agora escrevemos na tela e depois vamos capturar isso em uma variável.

Guilherme: Agora, precisamos pegar o nome da banda. Colocaremos uma string nomeDaBanda igual a Console.ReadLine()!. A exclamação depois dos parênteses é para indicar que não queremos trabalhar com valor nulo.

```C#
void RegistrarBanda()
{
   Console.Clear();
     Console.WriteLine("Registro de bandas");
     Console.Write("Digite o nome da banda que deseja registrar: ")
     string nomeDaBanda = Console.ReadLine()!;
}
```

Interpolação de strings  
Agora, Daniel, eu quero criar uma mensagem assim, digamos que eu digitei "Pink Floyd", quero uma mensagem que diga: "A banda Pink Floyd foi registrada com sucesso".

Como colocar esse valor "Pink Floyd" no meio do texto que está sendo exibido? Quero colocar a variável nomeDaBanda no meio da frase "A banda foi registrada com sucesso!".

Daniel: Poderíamos usar a concatenação com sinal de +, porém ficaria um pouco confuso com muitos sinais de +. Vamos usar outro recurso do C# que é a interpolação de string. Inicia a string com cifrão e envolve a variável que queremos referenciar com chaves.

```C#
Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
```

Até agora nosso código está assim:

```C#
void RegistrarBanda()
{
   Console.Clear();
     Console.WriteLine("Registro de bandas");
     Console.Write("Digite o nome da banda que deseja registrar: ")
     string nomeDaBanda = Console.ReadLine()!;
     Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
}
```

Guilherme: Legal, até muda a cor da variável quando ela está entre chaves.

Depois disso, queremos esperar um pouco para dar aquele suspense na aplicação. Colocaremos um Thread.Sleep(), essa função espera em milissegundos, vamos colocar 2000 milissegundos. Depois, queremos voltar ao menu principal.

Em seguida, vamos limpar o console e inserir um ExibirOpcoesDoMenu() para voltarmos ao menu principal.

```C#
void RegistrarBanda()
{
   Console.Clear();
     Console.WriteLine("Registro de bandas");
     Console.Write("Digite o nome da banda que deseja registrar: ");
     string nomeDaBanda = Console.ReadLine()!;
     Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");	 
     Thread.Sleep(2000);
     Console.Clear();
     ExibirOpcoesDoMenu();
}
```

Vamos testar a opção 1! Queremos digitar o nome da banda e visualizar a mensagem informando que ela foi registrada. Podemos executar o projeto.

Escolhemos a opção 1, pressionei "Enter".

Registro de bandas

Digite o nome da banda que deseja registrar:

Vamos inserir a banda "Pink Floyd" e pressionar "Enter". Ele exibiu a mensagem:

A banda Pink Floyd foi registrada com sucesso!

E volta ao menu principal.

Daniel: Faltou exibir logo do projeto.

Guilherme: De volta ao código, vamos refatorar o código e renomear a função ExibirMensagemDeBoasVindas() para ExibirLogo(). Esse ExibirLogo() vai ficar dentro do ExibirOpcoesDoMenu(). O menu sempre terá o logo.

```C#
void ExibirOpcoesDoMenu()
{
    ExibirLogo();

// código omitido
```

Podemos executar o programa para testar novamente a opção 1. Agora está funcionando como esperado e voltando para o menu principal com o logo sendo exibido acima dele.

Daniel: Está legal. Mas e se tentarmos registrar uma nova banda? Aquela primeira banda que registramos sumiu, não está mais sendo exibida. Porque estamos usando uma única variável que só está existindo dentro do corpo da função RegistrarBanda(). No próximo vídeo vamos resolver isso.

### Aula 3 - Adicionando músicas na lista - Vídeo 2

Transcrição  
Daniel: Agora precisamos guardar as bandas que estamos registrando em algum recurso, alguma estrutura, para que consigamos fazer a opção 2, que é mostrar as bandas cadastradas.

Guilherme: E esse recurso não pode existir apenas no RegistrarBanda(), deve estar em um escopo global da nossa aplicação. O que você sugere?

Daniel: Acho que a melhor opção é uma coleção onde o nome da cada banda fique registrado. Uma lista.

Lista  
Guilherme: Pensando até no mundo real. Se alguém perguntar quais as cinco bandas que você mais gosta de ouvir, você já imagina uma lista com essas cinco bandas. No nosso projeto teremos algo muito parecido com isso.

E, se no C# tudo é fortemente tipado, uma lista não é exceção. Precisaremos definir também essa lista.

Para criar uma lista no C# vamos escrever List<>. Note que temos o sinal de maior que e o sinal de menor que. Isso significa que dentro desses sinais indicaremos o tipo dessa lista, se é uma lista de inteiros, de números decimais, de string, etc.

No nosso caso, como queremos guardar o nome de diversas bandas, queremos uma lista de strings.

> List`<string>`

E já apareceu um autocomplete de código para lista de strings. Vamos pressionar "Tab" para aceitar essa sugestão.

> List`<string>` strings = new List`<string>`();

Vamos fazer a alteração do nome da lista, será listaDasBandas.

> List`<string>` listaDasBandas = new List`<string>`();

Daniel: Sim, precisamos dar nomes significativos para o negócio que estamos desenvolvendo. Não podem ser nomes muito genéricos. Com nomes mais específicos, como listaDasBandas, fica mais fácil para qualquer pessoa que ler esse código saber o que está acontecendo.

Mais adiante falaremos mais sobre essa sintaxe gerada para listas, o que importa agora é que criamos uma lista vazia e poderemos colocar bandas dentro dessa lista.

Guilherme: Agora, no RegistrarBanda(), a partir do momento que temos o nome da banda que a pessoa digitou, queremos adicionar esse nome na listaDasBandas. Para isso, usaremos o .Add(nomeDaBanda).

listaDasBandas.Add(nomeDaBanda);

a função RegistrarBanda() ficou assim:

```C#
void RegistrarBanda()
{
   Console.Clear();
     Console.WriteLine("Registro de bandas");
     Console.Write("Digite o nome da banda que deseja registrar: ")
     string nomeDaBanda = Console.ReadLine()!;
     listaDasBandas.Add(nomeDaBanda);
     Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
     Console.Clear();
     Thread.Sleep(2000);
     ExibirOpcoesDoMenu();
}
```

Vamos executar o programa, selecionar a opção 1 e adicionar duas bandas "Black Sabbath" e "Beatles".

Conseguimos adicionar a duas bandas, não apareceu erro. Mas o que colocaria à prova essa nossa lista, para verificar se ela está realmente funcionando, é a execução da opção 2 que exibe todas as bandas.

Então, no próximo vídeo vamos implementar o código para a opção 2 funcionar.

### Aula 3 - Estrutura de repetição for - Vídeo 3

Transcrição  
Guilherme: Já temos uma lista chamada listaDasBandas e registramos as bandas com a função RegistraBanda(). Porém, ainda não exibimos as bandas. Inclusive, temos a segunda opção dedicada a mostrar todas as bandas na função ExibirOpcoesDoMenu().

Mostrar bandas registradas  
Guilherme: No switch(), vamos tirar o Console.WriteLine() que está após o case 2 na linha 36. No lugar, vamos digitar MostrarBandasRegistradas() que será a função do registro das bandas que vamos criar.

Program.cs:

```C#
void Exibir OpcoesDoMenu()
{

// código omitido…

    switch (opcaoEscolhidaNumerica)
    {
        case 1: RegistrarBanda();
            break;
        case 2: MostrarBandasRegistradas();
            break;
        case 3: Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
            break;
        case 4: Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
            break;
        case -1: Console.WriteLine("Tchau tchau :)");
            break;
        default: Console.WriteLine("Opção inválida");
            break;
    }
}
```

Agora, vamos desenvolver a função MostrarBandasRegistradas() com essa responsabilidade. Vamos criar uma nova função na linha 61, após RegistrarBanda().

Também será uma função void responsável apenas por MostrarBandasRegistradas(). O Visual Studio sugeriu um Console.Clear(). Faz sentido, queremos limpar o console e ter um comportamento parecido com RegistrarBanda().

```C#
void MostrarBandasRegistradas()
{
    Console.Clear();
}
```

Inclusive, o Daniel comentou sobre os asteriscos anteriormente. Vamos colocar uma linha de asteriscos com Console.Write() após Console.Clear() na função RegistrarBanda()? Vai ficar visualmente mais bonito. Também vamos adicionar outra linha de asteriscos após Console.Write("Registro de bandas").

```C#
void RegistrarBanda()
{
    Console.Clear();
    Console.WriteLine("**********************");
    Console.WriteLine("Registro de bandas");
    Console.WriteLine("**********************");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;

// código omitido…

}
```

Queremos esse mesmo comportamento para a função que vai exibir as bandas. Por isso, adicionamos em MostrarBandasRegistradas() um Console.WriteLine() de asteriscos, outro com a string Exibindo todas as bandas registradas e mais um Console.WriteLine() com a linha de asteriscos do mesmo comprimento da frase.

```C#
void MostrarBandasRegistradas()
{
    Console.Clear();
    Console.WriteLine("************************************");
    Console.WriteLine("Exibindo todas as bandas registradas");
    Console.WriteLine("************************************");
}
```

Agora, o desafio é o seguinte: precisamos pegar a listaDasBandas e exibir na tela cada banda que temos dentro dessa lista.

Daniel: Isto é, precisamos percorrer a lista.

Estrutura de repetição for

Guilherme: Para isso, podemos usar o for. Assim, para cada banda que temos dentro da listaDasBandas, vamos exibi-las no console.

Daniel: Vamos fazer um loop, certo?

Guilherme: Exatamente. Em MostrarBandasRegistradas(), vamos escrever o for após o Console.WriteLine() de asteriscos. Esse for é muito simular ao for do JavaScript e Java. Entre parênteses, vamos declarar uma variável int chamada i que vai ser igual à 0.

Vamos percorrer toda a lista, ou seja, deve-se continuar a executar as instruções enquanto tiver bandas. Para isso, após a inicialização, colocamos a condição i menor que listaDasBandas.Count. Assim, vamos contar todas as bandas e enquanto tiver bandas, vamos continuar a executar o for.

A cada repetição que executamos, vamos incrementar 1 na variável i. Ou seja, a expressão de iteração do for será i++.

No corpo do for, vamos colocar um Console.WriteLine() com a interpolação de string. Para isso, digitamos cifrão e abrimos e fechamos aspas. Entre as aspas, escrevemos Banda: seguido do nome da banda.

Mas, vamos precisar pegar o nome de banda por banda. Por isso, entre chaves, colocamos listaDasBandas[] no índice i.

```C#
void MostrarBandasRegistradas()
{

// código omitido…

    for (int i = 0; i < listaDasBandas.Count; i++)
    {
        Console.WriteLine($"Banda: {listaDasBandas[i]}");
    }
}
```

Essa forma de escrita de chaves para acessar uma determinada variável seguido dos colchetes é parecido a outras linguagens.

Daniel: Inclusive, o incremento da variável i com i++ também é similar.

Voltando ao menu principal  
Guilherme: Depois que exibimos as bandas, esperamos que a pessoa digite algo para voltar ao menu principal. Para isso, após o for, vamos escrever a mensagem Digite uma tecla para voltar ao menu principal com Console.WriteLine().

Em seguida, podemos usar um conceito diferente com o Console.ReadKey().

Daniel: Assim, qualquer tecla que for digitada levará ao menu principal. Depois, vamos exibir todas as opções novamente.

Guilherme: Certo. Após a pessoa digitar, vamos limpar o console com Console.Clear() e chamar o ExibirOpcoesDoMenu().

```C#
void MostrarBandasRegistradas()
{

// código omitido…

    Console.WriteLine("Digite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}
```

Daniel: Para não ter que registrar uma banda toda hora, você já pode colocar alguns valores na lista inicial.

Guilherme: O que você acha de fazer dois testes? Vamos registrar duas bandas com a lista vazia e, logo em seguida, criar alguns elementos na lista. Conforme desenvolvemos, vamos querer testar funcionalidades com algumas bandas. Por isso, é interessante já começar com uma lista com alguns valores.

Executamos o Program.cs para abrir o Screen Sound no terminal com a mensagem de boas-vindas e as opções do menu. Como queremos registrar duas bandas, escolhemos a opção 1.

Digite a sua opção: 1

Ficou muito legal os asteriscos entre o título "Registro de bandas". Primeiro, digitamos o nome da banda U2

```C#
**********************
Registro de bandas
**********************
Digite o nome da banda que deseja registrar: U2
```

Após pressionar o "Enter", recebemos o aviso que a banda foi registrada com sucesso.

A banda U2 foi registrada com sucesso!

O programa volta ao menu principal. E digitamos 1 novamente para registrar mais uma banda.

Digite a sua opção: 1

Daniel: Podemos registrar os Beatles.

```C#
**********************
Registro de bandas
**********************
Digite o nome da banda que deseja registrar: Beatles
```

A banda Beatles foi registrada com sucesso!

Guilherme: Agora, vamos para a parte crucial do teste da aplicação. No menu principal, vamos digitar o 2 para escolher a opção de mostrar todas as bandas.

Digite a sua opção: 2

Após apertar "Enter", são listadas todas as bandas que registramos, U2 e Beatles.

```C#
**********************
Exibindo todas as bandas registradas
**********************
Banda: U2
Banda: Beatles
Digite uma tecla para voltar ao menu principal
```

Pressionamos a tecla "Enter" para voltar ao menu principal.

Acho que podemos ter um espaço entre o asterisco e as bandas e também entre as bandas e o Console.WriteLine() da frase "Digite uma tecla para voltar ao menu principal".

Daniel: Mas, já confirmamos que a listaDasBandas está armazenando como deveria. Pois, havíamos criado a lista, mas não conseguíamos ver o conteúdo da lista. Agora, conseguimos mostrar esse conteúdo.

Pular linhas

Guilherme: Vamos fazer esses pequenos ajustes na função MostrarBandasRegistradas(). Assim que o loop for acaba, vamos pular uma linha. Para isso, acrescentamos um \n antes da frase "Digite uma tecla para voltar ao menu principal" dentro do Console.WriteLine().

Além disso, vamos acrescentar o \n após os asteriscos do terceiro Console.WriteLine(). Assim, temos o cabeçalho e pulamos uma linha.

```C#
void MostrarBandasRegistradas()
{
    Console.Clear();
    Console.WriteLine("************************************");
    Console.WriteLine("Exibindo todas as bandas registradas");
    Console.WriteLine("************************************\n");

    for (int i = 0; i < listaDasBandas.Count; i++)
    {
        Console.WriteLine($"Banda: {listaDasBandas[i]}");
    }

    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();

}
```

Vamos fazer essa mesma alteração para a função de cima, RegistrarBanda(). Colocamos um \n após os asteriscos do terceiro Console.WriteLine().

```C#
void RegistrarBanda()
{
    Console.Clear();
    Console.WriteLine("**********************");
    Console.WriteLine("Registro de bandas");
    Console.WriteLine("**********************\n");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    listaDasBandas.Add(nomeDaBanda);
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}
```

Executar com bandas já registradas  
Guilherme: Inclusive, já podemos rodar com o segundo teste. Se sempre executamos o programa com a lista vazia, não vamos ter nenhuma banda registrada e vamos sempre ter que registrar uma banda para testar.

Daniel: Para fins de testes, já podemos começar com bandas já registradas.

Guilherme: No começo do arquivo onde instanciamos listaDasBandas, vamos apagar os parênteses após new List<string>. No lugar, vamos colocar os sinais de abre e fecha chaves. Entre as chaves, colocamos o nome de cada banda entre aspas e separadas por vírgula. Colocamos U2, The Beatles e Calypso, a banda preferida do Daniel.

```C#
// Screen Sound
string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";
List<string> listaDasBandas = new List<string> { "U2", "The Beatles", "Calypso"}; 
```

Executamos a aplicação para abrir o Screen Sound no terminal. No menu principal, colocamos a opção 2 para visualizar as bandas que temos já registradas.

Digite a sua opção: 2

Após dar "Enter", temos as bandas U2, The Beatles e Calypso.

```C#
**********************
Exibindo todas as bandas registradas
**********************

Banda: U2
Banda: The Beatles
Banda: Calypso

Digite uma tecla para voltar ao menu principal
```

Digitamos qualquer tecla e voltamos ao menu principal, onde vamos registrar uma nova banda com a opção 1. Registramos a banda Iron Maiden com sucesso. No menu principal, escolhemos a opção 2 para mostrar todas as bandas e a lista foi atualizada!

Daniel: Nesse vídeo, aprendemos fazer um loop no C# com o for tradicional. No próximo, vamos conhecer outro recurso de loop.

### Aula 3 - Foreach para cada música - Vídeo 4

Transcrição  
Daniel: Agora vamos conhecer uma maneira diferente de escrever o for.

Guilherme: É outra função do C# não tão verbosa, sem precisar declarar um inteiro para fazer um loop como fizemos no for tradicional.

Primeiro, vamos comentar o trecho do for na função MostrarBandasRegistradas() para mantê-lo como referência. Para isso, colocamos o // antes de toda linha da instrução for.

E como fazemos essa outra manipulação, Daniel?

Daniel: O recurso se chama for each ("para cada"). Assim, conseguimos passar por cada elemento da lista. O foreach é uma palavra reserva escrita toda junta e em minúsculas.

Loop foreach  
Guilherme: Após o trecho comentado do for, escrevemos foreach() em uma nova linha para começar a verificação.

Daniel: Dentro dos parênteses, vamos declarar uma variável que vai representar o elemento da lista.

Guilherme: Por exemplo, podemos escrever uma string de banda. Já que vamos verificar banda por banda.

Daniel: Após benda, colocamos a palavra reserva in seguido da variável que representa a coleção, ou seja, a lista chamada listaDasBandas.

Guilherme: Até a leitura fica mais clara: string banda in listaDasBandas seria "para cada banda na lista de bandas". Também fica mais claro visualmente para entender do que o for tradicional com sua inicialização, condição e expressão de iteração.

Queremos exibir o mesmo console no corpo do foreach. Por isso, entre colchetes, escrevemos Console.WriteLine() passando cifrão e a string Banda: seguido da {banda}. Não usamos mais a listaDasBandas, porque para cada banda vamos ter um Console.WriteLine().

Program.cs:

```C#
void MostrarBandasRegistradas()
{
    Console.Clear();
    Console.WriteLine("************************************");
    Console.WriteLine("Exibindo todas as bandas registradas");
    Console.WriteLine("************************************\n");
    
    //for (int i = 0; i < listaDasBandas.Count; i++)
    //{
        //Console.WriteLine($"Banda: {listaDasBandas[i]}");
    //}

    foreach (string banda in listaDasBandas)
    {
        Console.WriteLine($"Banda: {banda}");
    }

    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
    
}
```

Já podemos testar. Executamos o programa que se abre no terminal. No menu principal do Screen Sound, vamos colocar o número 2 para exibir todas as bandas com o foreach.

Digite a sua opção: 2

Após pressionar "Enter", temos o mesmo resultado anterior. Isto é, as bandas U2, The Beatles e Calypso.

```C#
**********************
Exibindo todas as bandas registradas
**********************

Banda: U2
Banda: Beatles
Banda: Calypso

Digite uma tecla para voltar ao menu principal
```

Podemos digitar qualquer tecla para voltar ao menu principal.

Para garantir que o código funciona, vamos registrar mais uma banda. Digitamos o número 1 para entrar na opção de registro de bandas, onde cadastramos a banda Ira.

A banda Ira foi registrada com sucesso!

Novamente no menu principal, escolhemos a opção 2 para exibir as bandas registradas.

```C#
**********************
Exibindo todas as bandas registradas
**********************

Banda: U2
Banda: Beatles
Banda: Calypso
Banda: Ira

Digite uma tecla para voltar ao menu principal
```

Temos a banda Ira na cartela de bandas registradas.

Daniel: Conhecemos mais um recurso muito utilizado: o foreach. Com ele, guardamos o valor do elemento em uma variável para conseguir percorrer a lista. A desvantagem é que não temos o índice do for tradicional, caso seja preciso usá-lo.

Por isso, você precisa considerar o que você quer fazer com o loop.

Guilherme: Visualmente, o comprimento da linha de asteriscos está maior do que a frase "Exibindo todas as bandas registradas". Podemos arrumá-lo na função MostrarBandasRegistradas(), caso queiramos.

### Aula 3 - AC/DC, Metallica, for e foreach - Exercício

Durante os estudos de C#, uma pessoa decidiu criar um programa que armazena as bandas que mais gosta. Confira abaixo:

> List`<string>` bandas = new List`<string>` { "Metallica", "AC/DC", "Iron Maiden", "Guns N' Roses", "Led Zeppelin" };

Para exibir as bandas no console, ele utilizou o seguinte código:

```C#
foreach (string banda in bandas)
{
    Console.WriteLine(banda);
}
```

Ao executar esse código a saída no console seria, na sequência:

Metallica
AC/DC
Iron Maiden
Guns N' Roses
Led Zeppelin

O for e o foreach são dois tipos de laços de repetição em C# que podem ser utilizados para percorrer e manipular coleções de elementos, tais como arrays (listas por exemplo), como ilustra o código acima. Sabendo disso, analise as informações abaixo e selecione apenas aquela onde a saída no console usa a estrutura for será igual ao foreach.

Resposta:

```C#
for (int i = 0; i < bandas.Count; i++) { Console.WriteLine(bandas[i]); }
```

> Isso aí! Com esse código, a saída no console será a mesma do foreach mostrado acima. A variável de controle foi definida como int e iniciado com o valor 0 para exibir o primeiro elemento da lista. Em seguida, o controle do fluxo para quando i for menor que o valor de elementos da lista e a cada repetição, incrementamos 1 ao valor de i.

### Aula 3 - Desafio: hora da prática
 Próxima Atividade

A prática é um elemento essencial ao iniciar os estudos em programação, pois é por meio da aplicação prática dos conceitos teóricos que se solidificam os conhecimentos. Ao escrever código, resolver problemas e construir projetos reais, os iniciantes não apenas internalizam a sintaxe das linguagens de programação, mas também desenvolvem a habilidade de pensar logicamente e abordar desafios de maneira eficiente.

Pensando nisso, criamos uma lista de atividades (não obrigatórias) focada em prática para melhorar ainda mais sua experiência de aprendizagem. Bora praticar, então?

1. Escrever uma função que a partir de dois números de ponto flutuante a e b exiba no console o resultado de suas quatro operações básicas (adição, subtração, divisão e multiplicação), utilizando interpolação de strings.
2. Criar uma lista de bandas vazia e adicionar suas bandas prediletas em seguida.
3. Utilizar a estrutura 'for' para mostrar todas as suas bandas preferidas, listadas na lista do exercício anterior, no console.
4. Criar um programa que calcula a soma de todos os elementos inteiros em uma lista.

Opinião do instrutor

Para te ajudar a verificar seus códigos, disponibilizamos uma [lista com as possíveis soluções no Github](https://github.com/ArthurOcFernandes/Exerc-cios-C-/tree/curso-1-aula-3).

Boa sorte nos estudos!

### Aula 3 - Faça como eu fiz

Crie uma lista de inteiros utilizando o List``<int>`` e utilize o for e o foreach para iterar sobre essa lista e exibir apenas os números pares.

No for, comece o índice em 0 e incremente a cada iteração. Defina a condição de continuação do loop como i < numeros.Count, ou seja, o loop continuará enquanto o valor de i for menor do que o número de elementos na lista. Acesse o valor de cada elemento utilizando a sintaxe numeros[i].

Já no foreach, ao invés de utilizar um loop for com um contador i e acessar os elementos da lista através do índice i, é utilizado o foreach para percorrer a lista e acessar diretamente cada elemento com a variável número. Em seguida, é verificado se o número é par utilizando o operador de módulo (%) e, caso seja, o número é impresso no console.

Opinião do instrutor

for

Criando a lista de números:

> List`<int>` numeros = new List`<int>` { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

Agora com a lista criada, vamos verificar se o número é par antes de imprimi-lo. Podemos fazer isso usando o operador módulo % para verificar se o número é divisível por 2. Se o resultado for 0, significa que é par e pode ser impresso.

```C#
for (int i = 0; i < numeros.Count; i++)
{
    if (numeros[i] % 2 == 0) // Verifica se o número é par
    {
        Console.WriteLine(numeros[i]);
    }
> }
```

foreach

Vamos verificar se o número é par, também utilizando o operador de módulo (%) e, caso seja, o número é impresso no console.

```C#
foreach (int numero in numeros)
{
    if (numero % 2 == 0) {
        Console.WriteLine(numero);
    }
> }
```

Qual usar? for ou foreach?

Geralmente, é recomendado utilizar o foreach quando se deseja apenas iterar sobre os elementos de uma coleção, sem a necessidade de acessar um índice numérico específico. Isso torna o código mais legível e menos propenso a erros, além de ser mais simples de implementar.

Já o for é recomendado quando é necessário acessar elementos em posições específicas da coleção ou quando se deseja iterar utilizando um índice numérico específico.

### Aula 3 - O que aprendemos?

Desafio proposto pela Luri, a IA da Alura.

Explique com suas próprias palavras os principais conceitos que você aprendeu nesta aula.

Resposta:  
Nesta aula aprendemos como criar e percorer uma lista de determinado tipo de dado. Para leitura e listagem dos elementos da lista usamos o laço de repetição (loop) FOR () {};, onde obtemos o indice e o elemento e o FOREACH () {}.

> Parabéns pela dedicação aos estudos! Você mencionou que aprendeu a criar e percorrer uma lista de determinado tipo de dado, o que é fundamental para trabalhar com estruturas de dados. Além disso, você destacou o uso dos laços de repetição `for` e `foreach`, que são essenciais para iterar sobre os elementos da lista. No entanto, também vimos como instanciar e adicionar elementos à lista utilizando o método `.Add`, que é uma parte importante do processo de manipulação de listas. Esse método permite que você acrescente novos itens à sua lista, como as músicas que você mencionou. Além disso, é interessante notar que o uso do `foreach` é especialmente útil quando você não precisa do índice dos elementos, tornando o código mais limpo e fácil de entender. Continue estudando e praticando!

## Aula 4 - Dicionários e avaliação das bandas

### Aula 4 -  - Vídeo 1
### Aula 4 -  - Vídeo 2
### Aula 4 -  - Vídeo 3
### Aula 4 -  - Vídeo 4
### Aula 4 -  - Vídeo 5
### Aula 4 -  - Vídeo 6
### Aula 4 -  - Vídeo 7
### Aula 4 -  - Vídeo 8
### Aula 4 -  - Vídeo 9
