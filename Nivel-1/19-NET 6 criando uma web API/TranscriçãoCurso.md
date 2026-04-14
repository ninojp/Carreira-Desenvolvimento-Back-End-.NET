# Curso Alura: .NET 6 criando uma web API

## Aula 1: Entendendo o conceito

### Aula 1: Apresentação - Vídeo 1

Transcrição  
Boas-vindas! Meu nome é Daniel Artine, serei seu instrutor neste curso de API Rest com .NET 6.

Daniel Artine é uma pessoa de pele clara, olhos castanhos escuros e cabelos pretos curtos. Usa barba e bigode, veste uma camiseta cinza escura e está sentado em uma cadeira preta. Ao fundo, há uma parede com iluminação azul.

O que vamos aprender?  
Ao longo deste treinamento, estudaremos os verbos HTTP e focaremos em responder as seguintes questões:

- Como se constrói uma API?
- O que é uma API?
- Quando e como utilizar uma API?
- Por que utilizar uma API?

Construiremos nosso projeto com base em uma API de filmes, com a qual que conseguiremos cadastrar filmes, além de recuperar informações, atualizar dados de diferentes maneiras (com o verbo PUT e com verbo PATCH) e deletar filmes. Ao final do curso, também estudaremos como documentar APIs utilizando Swagger.

A nível de código, vamos:

- desenvolver nosso construtor
- utilizar DTOs para criar, ler e atualizar filmes
- fazer conexões com banco de dados, usando Entity Framework
- realizar conversões entre diferentes tipos, com o AutoMapper
- Vale ressaltar que seguiremos a nova convenção do .NET 6, tendo um arquivo Program.cs e não dependendo mais de um Startup.cs. Desenvolveremos o projeto de uma maneira bem minimalista.

Espero que aproveitem o curso. Caso tenham dúvidas, não deixem de perguntar. Bons estudos!

### Aula 1: Preparando o ambiente - Vídeo 2

Transcrição  
Nesta aula, vamos preparar nosso ambiente de trabalho, fazendo a instalação de todas as ferramentas necessárias para dar continuidade aos nossos estudos. Como vamos desenvolver o projeto no Windows, mostraremos as instalações e configurações nessa plataforma em específico, mas sempre que possível daremos indicações de como realizar esses processos no Linux, caso você precise trabalhar com esse sistema.

Baixando os instaladores  
A primeira ferramenta necessária é o Visual Studio Community 2022. Ao acessar o site na página de downloads, basta clicar no botão roxo "Download gratuito" referente à versão "Comunidade".

Caso você esteja no Linux, você pode usar o Visual Studio Code, um editor de texto bastante poderoso que, às vezes, se compara a uma IDE.

A próxima ferramenta é o MySQL 8.0.31. Na [https://dev.mysql.com/downloads/windows/installer/8.0.html](página de download), há duas opções. Vamos baixar a segunda: o instalador completo (de 431.7 MB). Ao clicar no botão azul "Download" à direita dessa opção, seremos direcionados a uma janela sugerindo que criemos uma conta Oracle. Não é preciso criar a conta, basta clicar no link "No thanks, just start mu download" no final da página, para simplesmente baixar o instalador.

A seguir, vamos baixar do Postman. Na página de downloads do Postman, basta clicar no botão laranja "Windows 64-bit". Essa ferramenta servirá para fazermos requisições de maneira mais prática, visualizar as respostas, preencher o corpo da requisição etc.

Também precisaremos no .NET 6. Na página de downloads do .NET, faremos o download da versão 6.0.402, conforme nosso sistema (Arm64, x64 ou x86).

Caso você esteja no Linux Ubuntu, a Microsoft tem uma documentação explicando passo a passo como fazer essa instalação. Na lateral esquerda dessa página, há tutoriais de outras distribuições, como: Alpine, CentOS, Debian, Fedora e OpenSUSE.

Instalando as ferramentas  
Agora que centralizamos nossos instaladores, passaremos para os processos de instalação em si. O Postman e o .NET são bem simples, basta clicar no botão "Next" diversas vezes até finalizar, você pode fazer por conta própria. Já o Visual Studio e o MySQL têm algumas peculiaridades, então focaremos neles a seguir.

Visual Studio e cargas de trabalho  
Primeiramente, vamos executar o instalador do Visual Studio Community 2022. Logo de início, será aberta uma caixa de diálogo explicando que algumas atualizações são necessárias, então clicaremos no botão "Continuar" no canto direito inferior.

Em seguida, a janela de instalação será aberta. Na parte esquerda da tela, há um retângulo referente ao Visual Studio Community 2022, em que temos o botão "Instalar" à direita. Caso você já tenha o Visual Studio instalado, você terá o botão "Modificar" no lugar.

Clicando no botão "Instalar" (ou "Modificar"), precisamos definir as cargas de trabalho que queremos instalar. Vamos selecionar a opção "ASP.NET e desenvolvimento Web". No painel à direita, temos os detalhes da instalação — não vamos modificar nada nessa seção.

Para agilizar o processo e ocupar menos memória do computador, recomendamos desmarcar qualquer outra carga de trabalho, já que neste curso usaremos apenas "ASP.NET e desenvolvimento Web".

No canto inferior direito, podemos escolher entre duas opções de instalação:

- Instalar durante o download
- Baixar tudo, depois instalar

Marque a opção que você preferir, de acordo com a velocidade da sua internet. Por fim, clicaremos no botão "Instalar" (ou "Modificar") no canto direito inferior.

MySQL e seus componentes  
Agora, vamos executar o instalador do MySQL. De início, ele pedirá permissão no sistema para continuar e depois fará a extração dos itens necessários. Em seguida, será aberta a janela do instalador.

Na primeira tela, selecionaremos a opção "Custom" para fazer uma instalação customizada e clicaremos no botão "Next" no canto direito inferior.

Na segunda tela, vamos definir os elementos que queremos instalar. No painel à esquerda, selecionaremos "MySQL Servers > MySQL Server > MySQL Server 8.0 > MySQL Server 8.0.31 - X64". Em seguida, pressionaremos a seta para a direita (na tela ou no teclado do computador) para adicionar esse componente à lista à direita.

Ainda no painel à esquerda, selecionaremos "Applications > MySQL Workbench > MySQL Workbench 8.0 > MySQL Workbench 8.0.31 - X64" e pressionaremos a seta para a direita novamente. Assim, o painel à direita terá a seguinte lista de componentes a serem instalados:

- MySQL Server 8.0.31 - X64
- MySQL Workbench 8.0.31 - X64

Vamos clicar no botão "Next" no canto direito inferior para prosseguir. Na próxima tela, podemos indicar o diretório de instalação e clicar em "Next". Caso o diretório já exista, o instalador mostrará um aviso, vamos clicar em "Yes".

Na próxima tela, temos a listagem do que será instalado. Basta clicar no botão "Execute" no canto direito inferior. Essa instalação pode ser um pouco demorada.

Enquanto a instalação é feita, fique à vontade para explorar o projeto no GitHub e saciar sua curiosidade sobre tudo que aprenderemos ao longo do curso.

Nós vamos estudar as novidades do .NET 6, entendendo a questão dos namespaces (file-scoped e block-scoped). Também aprenderemos a criar um controlador, modelos e DTOs.

Finalizado o processo, clicaremos em "Next". Na próxima tela, em "Next" mais uma vez para começar a configuração.

Na próxima tela, vamos manter as configurações padrões:

- Config Type: Development Computer
- Port: 3306
- X Protocol Port: 33060

Pressionando o botão "Next", precisamos definir o método de autenticação. Para não nos preocuparmos com a questão de criptografia de senhas e afins, selecionaremos "Use Legacy Authentication Method" e clicaremos em "Next".

Agora, definiremos a nossa senha. Por ora, podemos deixá-la como "root" e clicar em "Next". Não alteraremos nada nas próximas páginas, basta clicar em "Next", "Next" e "Execute".

Caso você esteja usando o Linux, o MySQL está no repositório padrão. Você pode instalá-lo com o apt no Ubuntu.

Ao final, todas as instalações e configurações de ambientes estarão prontas!

### Aula 1: Faça como eu fiz: configurações iniciais

Nesta atividade você irá preparar o seu ambiente de desenvolvimento para dar continuidade ao curso. Para isso, vamos precisar fazer a criação do nosso projeto na IDE que utilizamos durante as aulas, o Visual Studio 2022.

Você colocou isso em prática? Vamos colocar a mão na massa e verifique se ficou com alguma dúvida. Se sim, você pode clicar na “Opinião do instrutor” e conferir o passo a passo de como isso foi feito.

Opinião do instrutor

Inicialmente, abra o Visual Studio. Em seguida, escolha a opção “Criar um projeto”.

- Tela inicial do Visual Studio

Após isso, utilize a barra de pesquisa e escreva “api”, escolhendo a opção com a linguagem C#.

- Tela de seleção do tipo de projeto no Visual Studio

Dê um nome para seu projeto. Para o curso, utilizamos o nome “FilmesAPI”. Clique em “Próximo”.

- Tela de definição de nome e caminho do projeto do Visual Studio

Certifique-se de utilizar a versão .NET 6.0 e clique em “Criar”.

- Tela final antes de criar o projeto no Visual Studio

Com isso seu projeto está criado e você está pronto para escrever seu código.

### Aula 1: O que é uma API - Vídeo 3

Transcrição  
Antes de começar a desenvolver nosso projeto, vamos entender o que são APIs e para que servem.

Primeiramente, "API" é a sigla para o termo "Application Programming Interface" — em português, interface de programação de aplicações. Mas o que isso significa?

Para entender o conceito de API, pensaremos num exemplo relacionado a filmes, já que nosso projeto terá esse tema. Vamos imaginar que o cliente 1 deseja conferir informações sobre o filme "O senhor dos anéis" pelo computador. Por exemplo, o título, o ano de lançamento, o nome do diretor, o gênero e o tempo de duração.

A máquina do cliente fará uma requisição para o servidor. O servidor, por sua vez, consultará os dados cadastrados no banco de dados e os enviará para o servidor, que mandará a resposta de volta para o cliente.

Diagrama de requisição de dados. No canto esquerdo superior, o cliente 1 é representado pela ilustração de um monitor de computador. Em sua tela, há dados do filme "O senhor do anéis". No centro do diagrama, temos um servidor representado por outro monitor. Em sua tela, temos a letra N maiúscula e vermelha, semelhante ao logotipo da empresa Netflix. À direita do diagrama, temos um banco de dados representado por um cilindro segmentado. Há 4 setas: do cliente 1 ao servidor (requisição); do servidor ao banco de dados; do banco de dados ao servidor; e do servidor ao cliente 1 (resposta)

O cliente 2 está utilizando um aplicativo no smartphone ou o próprio navegador do celular e deseja obter as mesmas informações para outros fins. Será que a resposta enviada ao cliente 1 pode ser o mesmo tipo de resposta dada ao cliente 2?

O mesmo diagrama de requisição de dados, com informações extras. No canto esquerdo inferior, o cliente 2 é representado por um smartphone. Uma seta aponta do cliente 2 ao servidor, outra seta aponta do servidor ao cliente 2. Abaixo dessa segunda seta, há vários pontos de interrogação.

Cada cliente pode estar esperando dados em determinado escopo. O servidor precisa sempre estar atento a que tipo de resposta deve ser enviado. Como podemos solucionar essa questão?

Em vez de um servidor, os clientes podem enviar requisições para uma API. Ela será responsável por resolver esse pedido e dar uma resposta que os clientes consigam utilizar os dados designados.

Mas como a API consulta os dados e os devolve para o usuário? No final das contas, isso não importa! O processo é análogo ao conceito de orientação a objetos: basta que sigamos as regras impostas pela interface para receber a resposta padronizada, que pode ser consumida pelos nossos clientes.

Diagrama do uso de uma API. A disposição dos elementos é semelhante aos diagramas anteriores. No canto esquerdo superior, temos o cliente 1 representado por um monitor. No canto esquerdo inferior, temos o cliente 2 representado por um smartphone. Os clientes estão dentro de uma área retangular denominada "Consumidores". No centro do diagrama, temos a API RESTful representada por um quadrado com a letra N maiúscula e vermelha. Na parte direita do diagrama, temos a ilustração de uma cartola com uma varinha mágica e pequenas estrelas brilhantes. Abaixo dela, está escrito "Não importa!". Há 6 setas: do cliente 1 até a API; do cliente 2 até a API; da API até a cartola; da cartola até a API; da API até o cliente 1; e da API até o cliente 2.

Em outras palavras, podemos imaginar a API como uma "casca" que contém um conjunto de regras. Cada cliente que quiser consumir da API, conseguirá interagir com esse sistema, desde que siga essas regras.

Quando implementamos determinado conjunto de regras arquiteturais, um dos mais difundidos é o REST — Representational State Tranfer. Seguindo esse padrão, sempre saberemos o que vamos receber e o que precisamos enviar nas duas pontas, de modo que a comunicação fica padronizada.

Ao segue o padrão REST, uma API é chamada de API RESTful. Ou seja, REST é o nome do conceito arquitetural e RESTful é quem implementa esse conceito.

Recapitulando: os clientes (consumidores) fazem requisições para a API RESTful e não importa como funciona a lógica por trás da API não importa. Pode ser um banco de dados (relacional ou não) ou estar em memória. Desde que os consumidores sigam as regras impostas pela API, eles receberam os dados.

Assim, a API visa disponibilizar informações para outras aplicações, seja para operações de escrita, leitura, atualização ou remoção.

Para consumir seus recursos, é necessário seguir as regras estabelecidas (que entenderemos ao longo do curso). Como as APIs abstraem detalhes de implementação, não precisamos compreender como o back-end está sendo implementado.

Além disso, APIs controlam o que pode ou deve ser acessado. Se criamos um endpoint para devolver determinada informação para o usuário, conseguimos ter um ótimo controle do que será exposto ou não a quem consome a API.

Tendo esses conceitos fixados, vamos partir para a prática na próxima aula!

### Aula 1: Sobre APIs - Exercício

APIs possuem finalidades específicas e diversas utilizações, seja do lado do usuário, seja de quem está desenvolvendo. Um exemplo é o sistema de filmes apresentado anteriormente, no qual podemos acessar diversas informações de maneira padronizada.

Selecione as alternativas abaixo que demonstram características das APIs.

Respostas:

Abstraem detalhes de implementação para quem for consumi-las.

> Os consumidores não precisam saber detalhes de implementação.

Alternativa correta  
Controlam o que pode/deve ser acessado.

> Os consumidores não conseguirão acessar caminhos que não estão expostos.

### Aula 1: O que aprendemos?

Nessa aula aprendemos:

- APIs trazem vantagens como: facilitar o consumo e disponibilização de dados e padronização.
- REST é um padrão arquitetural que visa padronizar os meios de tráfego de dados.
- APIs abstraem detalhes de implementação.
- Como preparar o ambiente no Windows e Linux.

### Aula 1:  - Vídeo 6
### Aula 1:  - Vídeo 7
