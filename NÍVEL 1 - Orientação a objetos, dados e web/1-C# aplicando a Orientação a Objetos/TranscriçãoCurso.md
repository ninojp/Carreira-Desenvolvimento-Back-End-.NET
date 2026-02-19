# Curso Alura C#: aplicando a Orientação a Objetos

## Aula 1 - Classe e Método no C#

### Aula 1 - Apresentação - Vídeo 1

Transcrição  
Guilherme: Olá! Meu nome é Guilherme Lima e serei um dos instrutores nesse curso de orientação a objetos com C#.

Guilherme é um homem branco, de cabelo curto e barba castanhos, e olhos também castanhos. Usa óculos quadrados de armação preta e está com uma blusa de moletom cinza da Nike.

Daniel: Eu sou o Daniel Portugal, desenvolvedor .NET e acompanharei o Guilherme nesse curso.

Daniel Portugal é um homem branco com cabelo curto e barba pretos, com bigode robusto. Usa óculos quadrados de armação preta e está de camiseta preta com estampa de guitarra em branco.

Por que é importante aprender sobre orientação a objetos com C#? Na maioria dos projetos em que você trabalhar, será necessário compreender os conceitos fundamentais dessa área, como classes, atributos, métodos, construtores e assim por diante. Você conhecerá tudo isso no presente curso.

Guilherme: Desenvolveremos um projeto real utilizando os principais conceitos de orientação a objetos. Porém, não focaremos em todos os conceitos — afinal, é quase impossível colocar todos os conhecimentos de orientação a objetos em um só treinamento. Não falaremos especificamente sobre, por exemplo, herança e interface.

Nosso objetivo, então, é aprofundar nosso conhecimento e construir uma base sólida nesses primeiros passos com orientação a objetos, especialmente com C#, em um projeto real.

Daniel: Continuaremos evoluindo o projeto de músicas que começamos a desenvolver no curso anterior. Agora, focaremos no paradigma orientado a objetos usando o C#.

Guilherme: Vamos lá!

### Aula 1 - Preparando o ambiente

O IDE do Visual Studio é uma plataforma de lançamento criativa que você pode usar para editar, depurar e criar código e, em seguida, publicar um aplicativo. Além do editor e depurador padrão fornecidos pela maioria dos IDEs, o Visual Studio inclui compiladores, ferramentas de conclusão de código, designers gráficos e muitos outros recursos para aprimorar o processo de desenvolvimento de software.

O IDE mais abrangente para desenvolvedores .NET no Windows e Mac para criação de web, nuvem, desktop, aplicativos móveis, serviços e jogos. Sabendo disso, preparamos alguns vídeos para instalar em diferentes sistemas operacionais:

Videos internos da Alura:  

- Visual Studio no Windows
- Visual Studio no Mac
- C# no VSCODE (SDK)

C# em distribuições Linux
[Neste link](https://learn.microsoft.com/pt-br/dotnet/core/install/linux), você encontra um passo a passo da própria Microsoft de como instalar em distribuições Linux, como Alpine, CentOS, Debian, entre outras.

Com o ambiente instalado, vamos iniciar nossos estudos?

### Aula 1 - Criando uma classe - Vídeo 2

Transcrição  
Daniel: Vamos iniciar o nosso estudo de orientação a objetos. Vamos criar um novo projeto no Visual Studio 2022, clicando em "Criar um projeto" na tela inicial do software, no menu de Introdução. Em seguida, escolhemos novamente a opção "Aplicativo do Console" como modelo de projeto.

Ao clicar em "Próximo" no canto inferior direito da página, daremos um nome para esse projeto. Nós estamos trabalhando com um projeto de músicas e bandas chamado ScreenSound, então escrevemos esse nome.

Clicamos em "Próximo" novamente. Nessa tela, de Informações Adicionais, escolhemos a Estrutura do projeto. Na caixa de seleção, clicamos em ".NET 6.0". Se você escolheu o ".NET 7", não tem problema. Escolhemos essa versão porque o .NET 6 é o de suporte a longo prazo.

Por fim, clicamos em "Criar" no canto inferior direito da tela.

Você já conhece a interface do Visual Studio e a aparência do projeto de tipo console, com o nosso famoso Hello World.

O primeiro passo, então, é pensar nos conceitos do nosso projeto, que é um projeto de músicas e bandas. O que uma música geralmente tem como características comuns?

Guilherme: As músicas têm um artista, duração e nome. Além disso, pensando em um modelo de disponibilização dessas músicas, podemos acrescentar a disponibilidade dessa música; ou seja, se a música está disponível no plano ou não.

Daniel: Certo! Então, vamos escrever isso no nosso projeto. Podemos apagar as linhas padrão do Hello World e, no lugar, anotar essas características como comentários:

Program.cs

// artista  
// duracao  
// nome  
// disponivel

Agora, toda música cadastrada no nosso sistema terá essas quatro características. Como traduzir isso para o C#?

**Tipos de variáveis**
Guilherme: Dados como nome e artista são textos, ou seja, do tipo string. A duração, provavelmente, é um tipo inteiro (int). A disponibilidade da música é um dado do tipo booleano (boolean), verdadeiro ou falso.

Daniel: Então vamos registrar isso no C# Estamos falando de uma linguagem fortemente tipada, ou seja, os objetos têm um tipo definido que precisa ser informado no momento de sua declaração. Por exemplo: o dado nome é do tipo string, que representa um texto, então definimos: string nome. O mesmo vale para o artista.

Já a duração pode ser um inteiro (minutos ou segundos), então escrevemos int duracao. A disponibilidade, por ser uma informação binária de verdadeiro ou falso, é um dado do tipo booleano. Esse é um tipo que ainda não conhecemos, e o que o representa é o bool.

Teremos o seguinte, então:

string nome;  
string artista;  
int duracao;  
bool disponivel;

Guilherme: Utilizamos tipos que, na programação, são conhecidos como tipos primitivos: string, int, bool. Temos um grupo de variáveis tipadas e queremos dizer que elas compõem uma música; ou seja, uma música possui diversas características de tipos diferentes.

Então, o desafio agora é agrupar tudo isso e definir como uma música.

**Agrupamento: criando uma classe**
Daniel: Para conformar isso à convenção que usamos para organizar esse agrupamento (o modelo de música), criaremos um novo arquivo e transferir o código que escrevemos para ele. Nessa convenção, todo modelo que criamos fica no seu próprio arquivo.

Para isso, clicamos com o botão direito no projeto Screensound, na barra superior da área de código, e selecionar a opção "Adicionar > Novo Item". Na caixa de diálogo que se abre, temos uma série de opções listadas. Selecionamos a opção chamada "Arquivo de Código" e nomeamos esse arquivo conforme o conceito que queremos estabelecer: Musica.

O efeito disso é um novo arquivo de extensão .cs (a extensão para C#), vazio, aberto como uma nova aba no Visual Studio.

Então, clicamos na aba Program.cs para retornar ao código que escrevemos e recortar todas as variáveis que criamos. Para isso, as selecionamos, pressionamos "Ctrl + X", clicamos novamente na aba Musica.cs e colamos esse dataframe nesse arquivo, pressionando "Ctrl + V".

O Guilherme falou que queremos agrupar esses conceitos num conceito maior, numa coisa mais complexa. O agrupamento de costume no C# é feito utilizando as chaves ({}), certo? Então vamos abrir e fechar chaves no começo do arquivo e, novamente, recortar e colar nosso código dentro delas.

Com isso já temos um agrupamento. Mas ele precisa ter um nome, que nada mais é do que o nome do conceito: Musica. Diremos que esse conceito é uma classe, então, escrevemos class Musica logo acima do agrupamento, antes da abertura de chaves:

Musica.cs

```csharp
class Musica
{
    string nome;
    string artista;
    int duracao;
    bool disponivel;
}
```

Essa é a estrutura mínima para criar um conceito do mundo real e conferir suas características. No caso da música, as características são Nome, Artista, Duração e Disponível, todas elas com seus tipos específicos.

### Aula 1 - Objetos - Vídeo 3

Transcrição  
Guilherme: Criamos a classe Música, mas ainda não sabemos como utilizá-la. O desafio agora é esse.

Daniel: Vamos retornar ao arquivo Program.cs, clicando em sua aba no Visual Studio. Podemos apagar os comentários feitos anteriormente, selecionando as linhas e pressionando "Delete", esvaziando o arquivo. Agora, vamos aprender como usar essa classe Musica.

**Criando músicas**
Daniel: Já sabemos que o C# é uma linguagem fortemente tipada, por isso vamos criar uma variável cujo tipo é uma música. Para isso, escrevemos o tipo Musica e escrevemos o nome da primeira variável, que pode ser musica1, pois criaremos outras músicas depois. Em seguida, adicionamos um sinal de igual (=). Então: Musica musica 1 =.

Essa variável receberá uma música que criaremos usando a palavra reservada new, que já conhecemos e usamos em outras situações. Mas, agora estamos usando para o tipo música: new Musica(). Nesse momento, criamos um objeto específico para o tipo Musica:

Program.cs

Musica musica1 = new Musica();

Guilherme: É similar, por exemplo, a quando criamos a lista e usamos o new list*. É a mesma ideia. A grande diferença é que, no lugar de utilizar os tipos que o C# já conhece, fizemos um aglomerado de tipos, chamamos de Musica e falamos: "A variável musica1 é do tipo Musica, que possui aqueles valores."

O desafio agora é: como podemos dizer que musica1 tem determinado nome, determinado artista, determinada duração?

Daniel: Vamos pular uma linha e tentar escrever isso. Primeiro, digitamos musica1 para acessar essa variável. Em seguida adicionamos um ponto final, usado para fazer referência a propriedades do tipo da variável. Ao adicionar esse ponto, o próprio Visual Studio entrega as informações dessa variável que podemos usar, como Equals, GetType, etc.

Porém, não está aparecendo nome, artista e nenhuma outra propriedade da nossa classe. Mesmo se escrevermos .nome, resultando em musica1.nome, essa propriedade não é aceita — o que é indicado por um sublinhado vermelho dizendo que não conseguimos acessar a informação nome.

Isso acontece porque, na classe Musica, precisamos inserir uma informação dizendo que essa informação está visível para fora da própria classe. Então, vamos clicar na aba Musica.cs e, na linha 3, à esquerda de string name, colocar mais uma palavra reservada dizendo que essa propriedade é pública — ou seja, é visível para fora. A palavra reservada para isso é, justamente, public. Então, atualizamos para public string name:

Musica.cs

```csharp
class Musica
{
    public string nome;
    string artista;
    int duracao;
    bool disponivel;
} 
```

Podemos salvar esse arquivo. Voltando para a aba Program.cs, já podemos notar que o sublinhado indicando erro em musica1.nome não existe mais. Ou seja, agora conseguimos colocar um nome para essa nova música.

Sabemos que o nome é um texto. Qual valor a variável musica1 receberá como nome? Qual será a nossa primeira música?

Guilherme: Podemos colocar uma música que você gosta!

Daniel: Minha música preferida se chama Roxanne. Então, passamos Roxanne entre aspas duplas (por ser uma string): musica1.nome = "Roxanne". Essa é uma atribuição normal de variável, só que essa variável fica dentro daquele agrupamento de tipo Musica.

Guilherme: Seguindo boas práticas, vamos retornar ao arquivo Música.cs, que contém a classe com o agrupamento de tipos. Nele, se você quiser usar o nome, o artista, a duracao ou o disponivel, você consegue usar livremente, sem ser necessária uma marcação de public ou qualquer outra. Porém, se você tem outro arquivo em que deseja usar aquelas informações, você precisará marcar todas como public.

Então, vamos definir o public para todos os outros valores também:

Musica.cs

```csharp
class Musica
{
    public string nome;
    public string artista;
    public int duracao;
    public bool disponivel;
} 
```

Pronto! Vamos criar duas músicas, então?

Daniel: Vamos! Mas antes, voltando para a aba do arquivo Program.cs, vamos adicionar mais informações na musica1, só para conferir.

Para inserir o artista da primeira música, seguimos o mesmo procedimento: colocamos o nome da variável, um ponto e o nome da propriedade — resultando em musica1.artista =.Em seguida, precisamos definir o valor dessa propriedade. A música Roxanne é da banda The Police, então passamos esse nome entre aspas: "The Police":

Program.cs

```csharp
Musica musica1 = new Musica();
musica1.nome = "Roxanne";
musica1.artista = "The Police";
```

Para criar a outra música, criamos outra variável. Não tem nenhuma diferença no processo: primeiro, criamos mais uma variável do tipo Musica, que podemos chamar de musica2, que receberá a criação dessa nova música. Então: Musica musica2 = new Musica().

Na linha de baixo, o Visual Studio automaticamente sugere a inserção de musica2.nome = para adicionar um nome a essa música. Então, podemos pressionar "Tab" para aceitar a sugestão. Qual será o nome, Gui?

Guilherme: Podemos colocar a música "Vertigo" da banda U2. Para inserir o nome do artista, seguimos os mesmos passos:

```csharp
Musica musica2 = new Musica();
musica2.nome = "Vertigo";
musica2.artista = "U2";
```

**Exibindo as informações das músicas**  
Daniel: Como estamos numa aplicação do tipo console, vamos tentar exibir essas informações. Nós já sabemos como fazer isso: usando o método Console.WriteLine(). Vamos exibir a mensagem "Nome da música:" com a interpolação ($) para puxar o nome dado à musica1, inserindo esse código abaixo da criação da primeira música:

```csharp
Console.WriteLine($"Nome da música: {musica1.nome}");
```

Guilherme: O que acontece se você deixar só o musica1, por exemplo? O que ele vai mostrar?

Daniel: Podemos verrificar. Vamos apagar o .nome, deixando apenas $"Nome da música: {musica1}" e executar o programa. Nós veremos que ele não vai exibir o nome, mas outra coisa. Vamos clicar no botão "Play" verde ao lado de "ScreenSound", na barra superior do Visual Studio. Ao rodar, o terminal se abre exibindo a seguinte mensagem:

Nome da música: Musica

Ou seja, o que aparece é o nome do tipo. Por convenção, quando você não define o valor de variável que você tem dentro da classe (no caso, a classe Musica), ele exibe o tipo dela; ou seja, Musica também.

Guilherme: Então, da mesma forma que atribuímos um valor com musica, um ponto e o nome da propriedade, como nome ou artista, fazemos o mesmo para visualizar esse valor.

Daniel: Vamos fechar o terminal e reescrever o .nome depois de musica1 no código do WriteLine.

Guilherme: Vamos copiar e colar essa linha 5, da exibição do nome da música, para exibir o nome do artista da primeira música também. Vamos mudar a mensagem para "Artista:" e a interpolação para {musica1.artista}. Também podemos mudar a mensagem "Nome da música:" para apenas "Nome", para padronizar de forma mais sucinta:

```csharp
Console.WriteLine($"Nome: {musica1.nome}");
Console.WriteLine($"Artista: {musica1.artista}");
```

Vamos visualizar essas duas características da música 1.

Daniel: Vamos clicar no "Play" novamente. Com a execução, surge o seguinte texto no terminal:

Nome: Roxanne  
Artista: The Police

Podemos fazer o mesmo para a música 2. Vamos copiar e colar essas duas linhas de código e colar embaixo da criação da musica2, substituindo a variável musica1 por musica2:

```csharp
Console.WriteLine($"Nome: {musica2.nome}");
Console.WriteLine($"Artista: {musica2.artista}");
```

Mas isso não é muito legal.

Guilherme: Quantas músicas existem no Spotify, Deezer ou outros streamings de música? Muitas! Se fizermos isso pra cada música que existe, a provavelmente passaríamos uns 200 anos fazendo só isso, o que não faz sentido.

Daniel: O que estamos querendo fazer é exibir a ficha técnica da música. Para isso, poderíamos pegar esse comportamento que escrevemos em Program.cs e levar para esse modelo novo em que estamos criando músicas.

Guilherme: Faremos isso no próximo vídeo!

### Aula 1 - Criando um método - Vídeo 4

Transcrição  
Guilherme: Acredito que o próximo desafio seja muito importante para entendermos melhor o seguinte: além de atributos (como campos, string, int, tipos diferentes), podemos criar comportamentos para uma classe.

Por exemplo: o comportamento desejado é exibir a ficha técnica de uma música, informando o nome, o artista e o tempo de duração. Como criamos esse comportamento para essa classe?

Daniel: A boa notícia é que já fizemos isso nos vídeos anteriores: criamos um método.

O nome que damos para o comportamento de uma classe é o método.

**Criando um método**  
Vamos retornar ao arquivo Musica.cs e pular uma linha ao final da declaração dos objetos, ainda dentro das chaves. Já iniciaremos com a boa prática de marcar como public o que queremos mostrar para outras classes. Esse será um método sem retorno, então, usamos a palavra reservada void. Vamos dar um nome para esse método, usando a convenção PascalCase: ExibirFichaTecnica. Por fim, abrimos e fechamos parênteses na mesma linha e chaves nas linhas de baixo:

Musica.cs

```csharp
public void ExibirFichaTecnica() 
{

}
```

Agora temos um método que representa um comportamento de qualquer objeto da classe Musica. Essa ficha técnica, basicamente, vai escrever no console algumas informações. Eentão, inserimos dentro das chaves: Console.WriteLine(). A primeira informação é o nome da música, então passamos a string "Nome" junto da interpolação com o atributo nome, que já temos na própria classe: $"Nome: {nome}".

No Visual Studio, podemos usar alguns atalhos para acelerar nosso código. Para escrever a próxima informação, vamos pular para a próxima linha, escrever cw e pressionar a tecla "Tab" para criar automaticamente o Console.WriteLine().

O comando "cw" + "Tab" otimiza a escrita do comando Console.WriteLine().

Vamos usar a interpolação novamente, usando o cifrão, abrindo aspas, escrevendo "Artista:", abrindo chaves e inserindo o atributo artista: Console.WriteLine($"Artista: {artista}"). Vamos repetir o processo para exibir a duração:

```csharp
public void ExibirFichaTecnica()
{
    Console.WriteLine($"Nome: {nome}");
    Console.WriteLine($"Artista: {artista}");
    Console.WriteLine($"Duração: {duracao}");
}
```

Guilherme: É legal mostrar os dados de todos os campos que criamos.

Daniel: Falta a informação sobre a disponibilidade da música no plano. Para isso, podemos utilizar um recurso que já utilizamos antes: o condicional. Se (if) a música está disponível, exibimos a mensagem confirmando, como "Disponível no plano". Do contrário (else), exibimos, por exemplo, a mensagem "Adquira o plano Plus+".

Guilherme: Isso é melhor do que exibir "true" ou "false", porque não faz muito sentido para a pessoa usuária do aplicativo.

```csharp
// código omitido

    if (disponivel)
    {
        Console.WriteLine("Disponível no plano.");
    }
    else
    {
        Console.WriteLine("Adquira o plano Plus+");
    }
}
```

Pronto, temos um método que todo objeto da classe Musica possui. Vamos salvar o arquivo com "Ctrl + S" e voltar para a classe Program.cs.

Agora, em vez de escrever Console.WriteLine() para exibir as informações das músicas, vamos simplesmente chamar o método ExibirFichaTecnica(). Então, podemos apagar as linhas 7 e 8 em que escrevemos as mensagens para nome e artista da música 1, assim como as linhas 12 e 13 em que escrevemos o nome e o artista da música 2.

**Chamando o método**  
Guilherme: Antes de chamar e executar o método, vamos colocar todas as informações possíveis de uma música. Por exemplo, temos o nome e o artista; precisamos da duração e da disponibilidade.

Não sabemos quanto tempo dura a música "Roxanne", podemos chutar uns 273 segundos, e dizer que ela está disponível com true. Já para a segunda música, "Vertigo", podemos colocar 367 segundos e dizer que ela não está disponível, com false, para fins de teste do método:

Program.cs

```csharp
Musica musica1 = new Musica();
musica1.nome = "Roxanne";
musica1.artista = "The Police";
musica1.duracao = 273;
musica1.disponivel = true;

Musica musica2 = new Musica();
musica2.nome = "Vertigo";
musica2.artista = "U2";
musica2.duracao = 367;
musica2.disponivel = false;
```

Daniel: Deixamos, então, toda essa parte de inicialização no topo do arquivo. Abaixo dela, vamos escrever musica1.ExibirFichaTecnica(). Repare que é exibido o método disponível por conta do public definido para ele no arquivo Musica.cs. Vamos fazer o mesmo para a música 2:

```csharp
musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
```

Pronto. Podemos clicar no "Play" do programa para executar. Ao fazer isso, conferimos a seguinte mensagem no terminal:

```csharp
Nome: Roxanne
Artista: The Police
Duração: 273
Disponível no plano.
Nome: Vertigo
Artista: U2
Duração: 367
Adquira o plano Plus+
```

Bem melhor! Temos a ficha técnica da música Roxanne e da música Vertigo. A primeira está disponível no plano, então estava como true no seu cadastro, exibindo a mensagem do if. A segunda não está disponível no plano, então apareceu a mensagem do else. Muito legal!

**O que aprendemos?**  
Nós conhecemos a classe, criando um modelo de música que possui quatro informações. Além dessas características, também colocamos um comportamento comum a todos os objetos.

### Aula 1 - Instâncias do Rock - Exercício

Desafio proposto pela Luri, a IA da Alura.

Uma classe no C# é uma estrutura que define o comportamento e as propriedades de um objeto, servindo como um molde para criar instâncias deste objeto. Ela agrupa dados (atributos) e comportamentos (métodos) relacionados em uma única entidade, como ilustra o código abaixo:

```csharp
class EscolaDoRock
{
    public string titulo;
    public int anoLancamento;

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Título: {titulo}");
        Console.WriteLine($"Ano de Lançamento: {anoLancamento}");
    }
}
```

Como podemos representar no código a instância da classe EscolaDoRock e a execução do método que exibe o título e o ano de lançamento?

```csharp
EscolaDoRock EscolaDoRock1 = new EscolaDoRock();
EscolaDoRock1.titulo = "Rock Nacional";
EscolaDoRock1.anoLancamento = 1981;
EscolaDoRock1.ExibirInformacoes();
```

**Você acertou em cheio!**

Edenilson, sua resposta está correta, parabéns! Você entendeu muito bem como criar uma instância da classe EscolaDoRock e como executar o método ExibirInformacoes() para exibir as informações do objeto. Primeiro, você criou uma nova instância da classe EscolaDoRock chamada EscolaDoRock1. Em seguida, você atribuiu valores aos atributos titulo e anoLancamento desse objeto. Por fim, você chamou o método ExibirInformacoes() para imprimir as informações do objeto no console. Essa é exatamente a forma correta de se trabalhar com classes e objetos em C#. Você demonstrou um ótimo entendimento dos conceitos de orientação a objetos. Continue assim, praticando e aprofundando seus conhecimentos em C#. Você está no caminho certo!

### Aula 1 - Desafio: hora da prática

A prática é um elemento essencial ao iniciar os estudos em programação, pois é por meio da aplicação prática dos conceitos teóricos que se solidificam os conhecimentos. Ao escrever código, resolver problemas e construir projetos reais, os iniciantes não apenas internalizam a sintaxe das linguagens de programação, mas também desenvolvem a habilidade de pensar logicamente e abordar desafios de maneira eficiente.

Pensando nisso, criamos uma lista de atividades (não obrigatórias) focada em prática para melhorar ainda mais sua experiência de aprendizagem. Bora praticar, então?

1. Criar uma classe que representa uma conta bancária, com um número indicador, titular, saldo e senha.
2. Criar um objeto do tipo Conta, adicionar dados e mostrar as informações titular e saldo no console, utilizando interpolação de strings.
3. Desenvolver um método da classe Conta que exibe suas informações.
4. Desenvolver uma classe que modele um carro, e que contenha os métodos acelerar, frear e buzinar

### Aula 1 - Faça como eu fiz: a importância das classes

Em C#, um método é um bloco de código que contém um conjunto de instruções que realizam uma determinada tarefa ou operação. Métodos são membros de uma classe e definem o comportamento dos objetos dessa classe.

Um método pode receber zero ou mais parâmetros como entrada, realizar operações com esses parâmetros ou com outros dados internos da classe, e pode retornar um valor ou simplesmente executar ações sem retorno.

Atualmente, nossa classe Música possui apenas um método chamado ExibirFichaTecnica(), como mostra o código abaixo.

```csharp
class Musica
{
    public void ExibirFichaTecnica()
    {
        //código omitido…
    }
}
```

Agora é a sua vez! Crie mais um método que exiba apenas o nome e o artista usando interpolação de String.

Opinião do instrutor

Vamos criar um método chamado ExibirNomeEArtista(). Esse método não possui um valor de retorno, indicado pelo uso do tipo void antes do nome do método.

```csharp
public void ExibirNomeEArtista()
{
}
```

Dentro do corpo do método, vamos definir uma instrução que usa Console.WriteLine para exibir uma mensagem formatada na saída do console. A mensagem exibida segue o padrão Nome/Artista: {nome} - {artista}, onde {nome} e {artista} são substituídos pelos valores das variáveis nome e artista, respectivamente.

```csharp
public void ExibirNomeEArtista()
{
    Console.WriteLine($"Nome/Artista: {nome} - {artista}");
}
```

Em resumo, esse método tem a finalidade de imprimir no console o nome da música e do artista, formatados de acordo com a mensagem definida. É útil para exibir essas informações em algum ponto do programa onde o método ExibirNomeEArtista() seja chamado.

### Aula 1 - O que aprendemos?

**Estes foram os pontos principais abordados nesta aula:**

- Desenvolvemos um modelo de música com os seguintes atributos: nome, artista, gênero, duração e disponibilidade. Utilizamos o conceito de classes e atributos para representar essas informações;

- Criamos um novo tipo de variável chamada Música e repetimos o processo de atribuir valores para seus atributos. Novamente, utilizamos o comando Console.WriteLine para exibir as informações da segunda música no console;

- Atribuímos um método chamado ExibirFichaTecnica() com retorno void. Esse método foi criado para exibir a ficha técnica da música, ou seja, todas as informações sobre a música são exibidas no console quando chamamos esse método.

Na próxima aula:

Vamos seguir as boas práticas de programação e alterar a visibilidade dos atributos, além de aplicar um conceito muito usado no mundo real chamado Properties.

## Aula 2 - Métodos de acesso e Propriedades

### Aula 2 - Atribuindo valores - Vídeo 1

Transcrição  
Daniel: Agora nós criamos nosso próprio tipo pela primeira vez, a classe Musica. Isso nos permite destacar a diferença, uma vez que até o momento estávamos utilizando apenas os tipos disponíveis no .NET, no C#.

Só para mostrar essa diferença, vamos fazer uma mudança visual. Vamos selecionar com o mouse a aba Program.cs e vamos arrastá-la para a região central, ao lado. O efeito vai ser ter os dois códigos, a classe Musica, a aba com o arquivo Música.cs de um lado e a classe Program.cs. Na classe Program.cs estamos usando, e na classe Musica foi o nosso primeiro tipo que criamos.

Guilherme: Legal, Daniel.

No entanto, estou pensando no que desenvolvemos e tem uma vulnerabilidade na nossa aplicação. Se alterarmos a variável musica.disponível para True no arquivo Program.cs, a música fica disponível no plano. Está muito fácil manipular uma parte que teoricamente é sensível na nossa aplicação, é só alterar essa variável, é para ser simples assim?

Program.cs

musica2.disponivel = true;

Daniel: A parte que estamos utilizando a classe está obtendo acesso a informações sensíveis.

Guilherme: E como tornamos essa parte da aplicação mais protegida?

Daniel: Vamos tornar essa parte da aplicação mais protegida. Analisando a classe Música, assim como temos nos atributos nome, artista, duração e disponível, a visibilidade como pública, podemos passar que a visibilidade vai ficar privada (Private).

A palavra reservada "private" é usada para especificar que um membro de uma classe só pode ser acessado dentro dessa mesma classe.

Podemos substituir na linha 6 por private. O que estamos dizendo é que agora o acesso a essa característica disponível só pode ser feito dentro das chaves.

Musica.cs

```csharp
class Musica 
{
    public string nome;
    public string artista;
    public int duracao;
    private bool disponível;
}
// código omitido
```

Ninguém mais fora disso consegue enxergar esse atributo.

Guilherme: Inclusive, no Program.cs, já apareceu um sublinhado vermelho abaixo do atributo disponivel.

Daniel: Exatamente, mas temos um outro problema.

No arquivo Program.cs, após o musical.disponivel = true; adicionamos um Console.WriteLine e vamos tentar usar a variável musica1 e mostrar o atributo disponível. Percebe-se que ele não fica disponível na lista do Visual Studio no menu flutuante exibido após digitarmos. Mesmo tentando escrever o atributo, não conseguimos nem ler a informação.

Program.cs

```csharp
// código omitido
musica1.duracao = 273;
musica1.disponivel = true;
Console.WriteLine(musica1.disponivel);
// código omitido
```

Desse modo, conseguimos resolver um problema, que era não querer que outras classes enxerguem ou alterem essa informação de disponibilidade de plano. Porém, também não conseguimos nem saber se a música está disponível ou não.

Guilherme: Vamos pensar nisso no próximo vídeo?

Daniel: Vamos nessa!

### Aula 2 - Centralizando acesso - Vídeo 2

Transcrição  
Guilherme: O desafio agora é o seguinte: temos um atributo e desejamos que esse atributo fique visível para outras partes, mas ao mesmo tempo não queremos que ele seja facilmente alterado. Como resolvemos isso?

Daniel: Exatamente, temos duas operações que podemos fazer com esse atributo - a leitura e a escrita. Desejamos separar um pouco isso. Queremos que a leitura fique disponível, mas queremos proteger e centralizar a escrita.

Queremos que o atributo disponivel tenha o valor false e só seja alterado para true se determinadas condições forem atendidas. Para garantir isso, vamos separar essas operações. Já conhecemos a solução - iremos criar métodos dentro da classe que desejamos, no caso, a classe Musica.

Vamos criar o nosso primeiro método, que terá a responsabilidade de escrever o atributo disponivel. Utilizaremos a palavra reservada public, pois desejamos que outras classes possam ter acesso. Como esse método não retorna nenhum valor, utilizaremos a palavra reservada void e o nome do método será EscreveDisponivel().

O método receberá um argumento que corresponde ao valor que desejamos atribuir ao atributo disponivel: bool value. Dentro do escopo do método colocamos que o atributo disponivel receberá o valor (value).

Musica.cs

```csharp
// código omitido
public void EscreveDisponivel(bool value)
{
    disponivel = value;
}
// código omitido
```

Agora, vamos criar o método responsável pela leitura do atributo disponível. Novamente, criaremos um método público. Como o valor retornado será do tipo booleano, definimos esse tipo como o tipo de retorno do método: public bool.

O nome do método será LerDisponivel() e não receberá nenhum valor de entrada. Dentro do escopo do método, utilizamos a palavra reservada return seguida do atributo disponivel, pois é esse valor que desejamos retornar.

Musica.cs

```csharp
// código omitido

public bool LerDisponivel()
{
    return disponivel;
}
// código omitido
```

Podemos salvar as alterações feitas até o momento e irmos ao arquivo Program.cs.

Agora precisamos usar esses métodos de leitura e escrita no lugar da atribuição direta que estávamos fazendo anteriormente.

Se desejamos escrever que o atributo disponivel recebe true, não usamos mais a seguinte sintaxe: musica1.disponivel = true;. Usamos: musica1.EscreveDisponivel(true);. No WriteLine, onde estamos lendo, usamos o LerDisponivel(). Aplicamos a mesma lógica para a variável musica2, mas desta vez é false.

Program.cs

```csharp
// código omitido
musica1.EscreveDisponivel(true);
Console.WriteLine(musica1.LerDisponivel());

musica2.EscreveDisponivel(false);
Console.WriteLine(musica2.LerDisponivel());

// código omitido
```

Ainda podemos passar o valor true ou false como argumento de entrada desse método EscreveDisponivel, mas a diferença é que agora temos controle do que podemos fazer ou não com esse atributo.

Guilherme: No futuro, se nossa aplicação crescer, podemos adicionar condições para controlar a atribuição do valor disponível. Por exemplo, somente pessoas com certa permissão podem atribuir esse valor.

Daniel: Isso mesmo.

A ideia é adicionar um if() no método EscreveDisponivel e, se a condição for atendida, conseguimos escrever o valor.

Guilherme: Isso é muito diferente do que tínhamos antes, quando escrevíamos diretamente no atributo disponível.

Daniel: Então, agora precisamos fazer isso para todos os atributos.

No arquivo Musica.cs vamos colocar private para todos atributos. O que vai acontecer é que teremos esses métodos como: escreve nome, lê nome; escreve artista e lê artista. Ou seja, vamos ter uma série de métodos responsáveis apenas por controlar esse acesso de leitura e escrita.

No entanto, há um recurso interessante no C Sharp (C#) que podemos utilizar para tentar simplificar um pouco esse código.

Vamos fazer isso no próximo vídeo.

### Aula 2 - Properties - Vídeo 3

Transcrição  
Daniel: Gui, vamos aprender um recurso do C# que nos ajudará a tornar nosso código mais conciso e sucinto.

Guilherme: Sabe o que eu estava pensando? É que nós colocamos o primeiro método EscreveDisponivel() e em seguida o LerDisponivel(). Se pegarmos um próximo projeto em C#, qual será o desafio? Como iremos acessar esses valores? Será que EscreveDisponivel() e LerDisponivel() são padrões em todos os projetos em C#? Provavelmente não, especialmente devido à preferência pela escrita em inglês.

Daniel: Exatamente isso.

Considerando a questão da economia de código e visando facilitar nesse sentido, foi estabelecido um padrão. O próprio C# nos proporciona isso. E assim, como as palavras reservadas estão em inglês, a palavra "escreve" foi traduzida para set e a palavra "lê" foi traduzida para get.

Escreve: set

Lê: get

Portanto, essas duas palavras se tornarão palavras reservadas para expressar essa operação.

No arquivo Musica.cs, onde está escrito private bool disponivel, faremos uma mudança. Vamos remover o ponto e vírgula, abrir chaves e declarar que esse atributo disponivel possui operações de leitura e escrita.

Utilizaremos get; set; para indicar explicitamente que o atributo disponivel tem tanto uma operação de leitura quanto uma operação de escrita.

Musica.cs

```csharp
class Musica
{
    public string nome;
    public string artista;
    public int duracao;
    private bool disponivel { get; set; }

// código omitido
```

Guilherme: Certo, então não é mais necessário utilizar os métodos public void EscreveDisponivel() e public bool LerDisponível()?

Daniel: Não precisa, podemos remover da linha 8 até a linha 16. Assim, diminuiu bastante a linha de código.

Guilherme: Legal, acredito que podemos aplicar esse padrão para todos os atributos, não é mesmo?

Daniel: Podemos fazer isso, mas há uma modificação adicional que precisamos fazer: o atributo disponivel precisa ser público novamente. Portanto, vamos adicionar a palavra reservada public antes dele, indicando que ele está acessível para classes externas à classe Musica, e também vamos especificar que ele possui operações de leitura e escrita usando get e set.

Musica.cs

```csharp
class Musica
{
    public string nome;
    public string artista;
    public int duracao;
    public bool disponivel { get; set; }

// código omitido
```

Guilherme: Será que conseguimos visualizar isso no arquivo program.cs?

Daniel: Conseguimos fazer isso. Vamos voltar ao arquivo Program.cs. Agora, como removemos aqueles métodos, nas linhas 5 e 6, eles não estão mais presentes. Em vez disso, teremos disponível = true e novamente Console.WriteLine(musica1.disponível).

Program.cs

```csharp
Musica musica1 = new Musica();
musica1.nome = "Roxane";
musica1.artista = "The Police";
musica1.duracao = 273;
musica1.disponivel = true;
Console.WriteLine(musica1.disponivel);

Musica musica2 = new Musica();
musica2.nome = "Vertigo";
musica2.artista = "U2";
musica2.duracao = 367;
musica2.EscreveDisponivel(false);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
```

Guilherme: Mas o que mudou daquele nosso primeiro disponivel para agora, com o get e o set?

Daniel: Parece que não houve mudanças visíveis, certo? No entanto, internamente, de forma transparente para quem está usando a nossa classe Musica (neste caso, é a program.cs), estamos indicando que existe um método que faz a escrita. Assim, podemos realizar exercício do futuro que você mencionou, como adicionar condições para que o valor de disponível seja escrito ou não.

Para as pessoas que estão consumindo, não é perceptível nenhuma diferença aparente. Parece ser apenas um atributo comum, porém temos a capacidade e o recurso de realizar a escrita.

Guilherme: Entendi, então o atributo ainda mantém o mesmo nome, disponivel, mas agora podemos estabelecer restrições para a atribuição de valor no set. Ou seja, só é permitido atribuir um valor se determinadas condições ou regras forem atendidas.

Daniel: Isso, exatamente.

Então, por enquanto, permitiremos que todos possam escrever o atributo disponivel. No entanto, podemos abrir o método de escrita e adicionar as condições necessárias. No momento, ainda não temos nenhuma regra de negócio específica para isso.

Guillherme: Na linha 12, faremos a correção do método EscreveDisponivel() usando o método anterior. Vamos deixar o atributo disponivel como falso. Isso garantirá o funcionamento correto de 100% do código.

Daniel: Vamos alterar, assim ficamos com:

Program.cs

```csharp
Musica musica1 = new Musica();
musica1.nome = "Roxane";
musica1.artista = "The Police";
musica1.duracao = 273;
musica1.disponivel = true;
Console.WriteLine(musica1.disponivel);

Musica musica2 = new Musica();
musica2.nome = "Vertigo";
musica2.artista = "U2";
musica2.duracao = 367;
musica2.disponivel = false;

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
```

Existe uma última tarefa que precisamos realizar, relacionada à convenção de nomenclatura. Já mencionamos o Pascal Case e o Camel Case. A partir deste momento, ao utilizar essa construção e após salvar com "Ctrl + S", retornarei à minha classe Musica. Quando usamos o tipo de recurso { get; set; }, o C# adota um novo nome para ele, que é Propriedade.

No C#, as propriedades devem seguir a convenção Pascal Case.

Guilherme: No Visual Studio, ao passar o cursor sobre o atributo disponivel, aparecem três pontos suspensivos. Isso indica que há mais informações disponíveis. Vamos verificar o que é exibido ao clicar nesses três pontos. O que ele fala, Daniel?

Daniel: Violação da regra de nomenclatura.

Violação da regra de nomenclatura. Essas palavras devem começar com caracteres maiúsculos

Guilherme: E o interessante é que o nosso código está funcionando corretamente, foi executado sem problemas. No entanto, devemos observar que não estamos seguindo as convenções estabelecidas.

Daniel: A questão da convenção é importante para a comunicação dentro de uma equipe e em projetos externos. Ao deparar com um código que utiliza a notação Pascal Case, uma classe, é imediatamente perceptível que se trata de uma propriedade, com os métodos Get e Set associados. Essa padronização facilita a compreensão e interpretação do código.

Para tornar a letra "D" do atributo disponivel maiúscula no arquivo Musica.cs, vamos utilizar um recurso do próprio Visual Studio. Se realizarmos essa alteração diretamente na aba Program.cs, ainda vamos encontrar erros.

Vamos solicitar ao Visual Studio que faça a alteração em todos os locais. Vamos desfazer a alteração anterior com "CTRL + Z". O Visual Studio já está nos indicando uma violação das regras de nomenclatura em disponivel, e ao passarmos o mouse sobre ela, um ícone de lâmpada é exibido ao lado.

Se clicarmos nele, será sugerida essa alteração para deixar o "D" maiúsculo. Além disso, a alteração será feita em todas as referências ao "D" minúsculo. Vamos usar essa opção de alteração "Corrigir violação" e vocês podem ver que ele fez automaticamente.

Musica.cs

```csharp
class Musica
{
    public string nome;
    public string artista;
    public int duracao;
    private bool Disponivel { get; set; }

// código omitido
```

O mesmo ocorreu no arquivo Program.cs, onde usamos o atributo Disponivel agora está com a letra inicial maiúscula.

Então, no C#, temos as propriedades, que são uma forma concisa de escrever as operações de leitura e escrita.

### Aula 2 - Atributos e propriedades - Vídeo 4

Transcrição  
Daniel: O desafio agora é fazermos esse mesmo recurso de propriedades para os outros atributos: nome, artista e duracao.

Guilherme: A questão é que um atributo com a primeira letra maiúscula indica que é uma propriedade, o que é comum para pessoas desenvolvedoras de C#.

Vamos utilizar todas as letras maiúsculas para isso.

Daniel: Primeiro, vamos criar os get e set, depois, usamos o recurso do Visual Studio para alterar

Guilherme: Legal, pois se não teríamos que alterar manualmente em outras partes da aplicação.

Daniel: Na linha 3 no arquivo Musica.cs, vamos apagar o ponto e vírgula e adicionar o get;. Fazendo o mesmo para artista e duracao:

Musica.cs

```csharp
class Musica
{
public string Nome { get; set; }
public string Artista { get; set; }
public int Duracao { get; set; }
public bool Disponivel { get; set; }
// código omitido
```

Agora vamos usar aquele recurso de refatoração para renomear os atributos, colocando a primeira letra em maiúsculo: Nome, Artista, Duracao. Basta passarmos o mouse por cima ou usarmos o atalho "Ctrl + R, Ctrl + R". Assim, no campo exibido na janela flutuante escrevemos "Nome" com a primeira letra maiúscula.

O atalho "Ctrl + R, Ctrl + R" possibilita renomear um item no C#

Guilherme: A renomeação alterou a nomenclatura também no método ExibirFichaTécnica do arquivo Musica.cs e no Program.cs.

Daniel: Se tivesse mais um Program.cs ou referência, teríamos que alterar manualmente.

Guilherme: A vantagem de fazermos isso utilizando o recurso de renomeação do Visual Studio é que ele controla todas as alterações em todos os lugares onde estão sendo utilizados os atributos, facilitando o processo e evitando erros.

Daniel: Com as propriedades do C#, é possível entregarmos informações de uma maneira mais simples para quem vai consumir, mas também mantendo o acesso de leitura e escrita centralizados. Para consolidar essa ideia, vamos criar mais uma propriedade chamada NomeCompleto que vai concatenar o nome do artista e colocar entre parênteses.

Usaremos mais um atalho do Visual Studio para criar a propriedade: escrever "PROP" e apertar TAB. Ele já cria para nós o modelo de propriedade, precisando apenas informar o tipo e o nome. No caso, o tipo será "string" e o nome NomeCompleto:

```csharp
public string Nome { get; set; }
public string Artista { get; set; }
public int Duracao { get; set; }
public bool Disponivel { get; set; }
public string NomeCompleto { get; set }
```

O atalho prop + TAB otimiza a criação de uma propriedade no C#

Assim, vimos como criar e utilizar propriedades no C#, bem como o uso de atalhos do Visual Studio para agilizar o processo e garantir a integridade do código.

Guillherme: Isso é legal porque no dia a dia, quantas propriedades uma pessoa que trabalha com C# cria?

Daniel: Isso vai acontecer muito. Você quer criar uma classe de uma maneira muito rápida, você vai usar bastante esse atalho PROP na sua vida.

Só que essa propriedade, não queremos que quem está consumindo essa classe, criar uma instância de música, coloque valor ali.

Guilherme: Vamos fazer isso no próximo vídeo?

Daniel: Vamos.

Guilherme: Na sequência, vamos criar uma propriedade que é diferente das propriedades.

### Aula 2 - Alterando o GET com lambda - Vídeo 5

Transcrição  
Guilherme: Daniel, quando você colocamos a propriedade public string NomeCompleto, eu não fazia ideia do que você estava querendo fazer. Com o NomeCompleto desejamos realizar uma manipulação de duas propriedades que já temos?

Daniel: Isso, a ideia era fazer uma manipulação de duas propriedades que nós já temos: nome e artista. Desejamos juntá-los para entregar um resumo, algo assim.

Guilherme: Como nós fazemos isso?

Daniel: Esse nome pode continuar sendo "NomeCompleto"?

Guilherme: Serei sincero novamente. Quando colocamos colocou "NomeCompleto", o que imaginei era que nós estaríamos trabalhando com RG, com usuários, mas não é isso, certo?

Daniel: Não. Sugira um nome que altero.

Guilherme: Pode ser "DescriçãoResumida".

Daniel: Vamos alterar direto no arquivo Musica.cs, não vamos utilizar o recurso, porque nós só fizemos referência a ele aqui. Sabemos disso pois o próprio VS Code mostra "0 referências" acima da propriedade.

Musica.cs

```csharp
// código omitido
public string Nome { get; set; }
public string Artista { get; set; }
public int Duracao { get; set; }
public bool Disponivel { get; set; }
public string DescricaoResumida { get; set; }
// código omitido
```

Gui, nós queremos que essa propriedade seja um resumo de outros valores que estão no objeto da classe Musica: Nome e Artista.

Vamos voltar ao arquivo Program.cs. Neste momento, quem usá-la poderá atribuir um valor à "DescriçãoResumida", como musica1.DescriçãoResumida = "Ola" mas isso não é o que queremos. Queremos apenas leitura, sem possibilidade de atribuir valor (set). Isto é, os valores são condicionados a valores já existentes em outras propriedades

Program.cs

```csharp
// código omitido
musica1.Disponivel = true;
musica1.DescriçãoResumida = "Ola"
Console.WriteLine(musica1.DescricaoResumida);
// código omitido
```

Inserimos um valor qualquer. Mas nós como criadores da classe Musica, informamos: Não queremos que alguém consiga escrever valor aqui. Para informar isso, removemos o set de DescricaoResumida. É basicamente isso. Passamos que não existe a operação de escrita nessa classe Musica.

Musica.cs

```csharp
// código omitido
public string Nome { get; set; }
public string Artista { get; set; }
public int Duracao { get; set; }
public bool Disponivel { get; set; }
public string DescricaoResumida { get; }
// código omitido
```

Guilherme: Na linha 6 do program.cs, ele já mostrou para nós que não podemos fazer isso.

Daniel: Exatamente, podemos apagar a linha, porque não tem essa operação de escrita.

Program.cs

```csharp
// código omitido
musica1.Disponivel = true;
Console.WriteLine(musica1.DescricaoResumida);
// código omitido
```

Agora, vamos melhorar nosso método get. Com a leitura disponível, o que vamos informar de valor em DescricaoResumida?

Se tentarmos fazer uma leitura no WriteLine do Program.cs, na DescricaoResumida, o que você acha que vai aparecer?

**Guilherme** Não sei.

Daniel: Vamos testar? Vamos salvar e executar a aplicação clicando no botão de play.

Quando aparece o retorno no console, a DescricaoResumida nem aparece. Isso significa que é um texto vazio que está ali.

Neste vídeo, queremos mostrar como exibir a descrição resumida para a primeira música, "Roxane", do artista The Police. Como podemos fazer isso?

Guilherme: Acredito que agora seja um momento importante para modificar um get, a forma como está sendo exibido. Vamos focar no código no arquivo Musica.cs.

Daniel: Para assumir o controle do código na leitura da propriedade DescricaoResumida, faremos o seguinte:

- Pular a linha das chaves;
- Em vez de ter um ponto e vírgula no get, abrir chaves;
- Retornar um valor usando a palavra-chave return.

Musica.cs

```csharp
// código omitido
public string Nome { get; set; }
public string Artista { get; set; }
public int Duracao { get; set; }
public bool Disponivel { get; set; }
public string DescricaoResumida
{ 

    get
    {
            return
    }

}
// código omitido
```

Agora, queremos fazer uma interpolação de duas propriedades. Podemos adicionar um texto para contextualizar a saída, como: "A música {nome} pertence à banda {Artista}".

Musica.cs

```csharp
// código omitido
public string Nome { get; set; }
public string Artista { get; set; }
public int Duracao { get; set; }
public bool Disponivel { get; set; }
public string DescricaoResumida
{ 
    get
    {
            return $"A música {Nome} pertence à banda {Artista}";
    }
}
// código omitido
```

Vamos executar novamente o código e ver o que acontece. Legal! Apareceu a ficha técnica da música como desejado: "A música Roxanne pertence à banda The Police".

O retorno abaixo foi parcialmente transcrito. Para conferi-lo na íntegra, execute o código na sua máquina.

A música Roxanne pertene à banda The Police

Guilherme: O interessante neste conceito é que, quando colocávamos o GetSet de maneira automática, parecia que não tínhamos poder sobre ele. No entanto, podemos manipular melhor as propriedades usando as chaves e controlar se uma informação pode ou não acontecer.

Daniel: Às vezes, podemos criar métodos que façam essa alteração, como um atributo chamado "saldo" em uma conta, onde os depósitos e saques realizados afetam o saldo No saldo nem permitiríamos a escrita, os métodos que fariam essa alteração para nós.

Para finalizar, é necessário destacar que, em muitos projetos, quando se tem uma propriedade somente leitura, a construção que mostramos pode ser simplificada ainda mais, deixando o código mais conciso.

Basicamente, podemos selecionar o valor do retorno, no caso a interpolação, e teclar "Ctrl + X". Depois removemos da linha 8 até a 13, e no final da propriedade DescricaoResumida adicionamos uma seta (=>) seguida do valor que queremos exibir, criando uma arrow function.

Musica.cs

```csharp
// código omitido
public string Nome { get; set; }
public string Artista { get; set; }
public int Duracao { get; set; }
public bool Disponivel { get; set; }
public string DescricaoResumida => 
    $"A música {Nome} pertence à banda {Artista}";
// código omitido
```

Em C# chamamos a arrow function de Lambda

Guilherme: Essa abordagem é bastante comum e facilita a compreensão de que a propriedade está no modo leitura apenas, com o comportamento que desejamos.

Daniel: Isso.

### Aula 2 - Para saber mais: funções lambda

No C#, lambdas são funções anônimas que podem ser usadas para criar expressões ou blocos de código compactos e concisos. Eles são especialmente úteis quando se trata de trabalhar com coleções de dados, realizar operações em uma sequência de elementos ou lidar com delegados.

Vamos começar com um exemplo simples de um código sem lambda. Suponha que você tenha uma lista de números inteiros e deseje filtrar apenas os números pares. Aqui está um exemplo sem o uso de lambda:

```csharp
List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

List<int> numerosPares = numeros.FindAll(BuscarNumerosQueSaoPares);

bool BuscarNumerosQueSaoPares(int numero)
{
    return numero % 2 == 0;
}

foreach (int numero in numerosPares)
{
    Console.WriteLine(numero);
}
```

Ao executar esse programa, o resultado será:

```csharp
2
4
6
8
10
```

Neste exemplo, definimos um método chamado BuscarNumerosQueSaoPares, que recebe um número inteiro e retorna um valor booleano indicando se o número é par. Em seguida, usamos o método FindAll da classe List`<T>` para filtrar os números da lista com base nessa condição e exibimos os valores no console.

Como seria esse código com funções lambdas?  
Lembrando que a estrutura de código de uma função lambda no C# segue um formato geral. Aqui está a estrutura básica de uma função lambda:

```csharp
(parametros) => expressao
```

Parâmetros: É uma lista opcional de parâmetros, separados por vírgulas, que especifica as entradas da função lambda. Cada parâmetro pode ser tipado explicitamente ou pode ser inferido pelo compilador.

Operador =>: É o operador de seta (=>), que separa a lista de parâmetros da expressão lambda. Ele indica que os parâmetros estão sendo mapeados para a expressão ou bloco de código seguinte.

Expressão ou bloco de código: É a expressão ou o bloco de código que define a lógica da função lambda. Pode ser uma única expressão ou um bloco de código delimitado por chaves ({}). Se a função lambda contiver um único comando, a expressão será automaticamente retornada. Caso contrário, você pode usar a palavra-chave return para retornar explicitamente um valor.

**Mão nas teclas**  
Vamos iniciar substituindo a função BuscarNumerosQueSaoPares por uma função anônima que tem a mesma finalidade:

```csharp
List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
List<int> numerosPares = numeros.FindAll(numero => numero % 2 == 0);
```

A expressão lambda especifica um parâmetro numero seguido por uma seta (=>) e uma expressão que retorna um valor booleano. A função FindAll utiliza essa expressão lambda como critério para filtrar os números da lista.

Em seguida, podemos usar uma função lambda na exibição dos números pares:

```csharp
numerosPares.ForEach(numero => Console.WriteLine(numero));
```

Segue o código completo:

```csharp
List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

List<int> numerosPares = numeros.FindAll(numero => numero % 2 == 0);
numerosPares.ForEach(numero => Console.WriteLine(numero));
```

**Algumas vantagens das lambdas em relação ao código sem lambda**  
Concisão: As lambdas permitem escrever código de forma mais concisa, eliminando a necessidade de definir métodos separados para funções simples.

Legibilidade: As lambdas são mais fáceis de ler e entender, especialmente quando o critério de filtragem ou a lógica do código é curto e direto.

Flexibilidade: As lambdas podem ser usadas em várias situações, como filtrar, ordenar, mapear ou reduzir coleções de dados. Elas permitem que você especifique a lógica do código diretamente no local onde é necessário, sem a necessidade de criar métodos adicionais.

Encerramento de escopo: As lambdas têm acesso às variáveis do escopo em que são definidas, o que permite que você capture e utilize valores externos dentro da expressão lambda. Isso pode ser útil em casos onde você precisa fazer referência a variáveis externas dentro de um loop, por exemplo.

Em resumo, lambdas no C# são funções anônimas que fornecem uma sintaxe concisa para escrever blocos de código em situações onde a criação de um método separado seria inconveniente ou desnecessário. Elas oferecem vantagens em termos de concisão, legibilidade, flexibilidade e encerramento de escopo.

**Quando não é recomendado o uso de código lambda?**  
Complexidade excessiva: Se a lógica da expressão lambda se tornar muito complexa ou difícil de entender, é preferível usar métodos e blocos de código separados para manter a clareza e legibilidade do código.

Reutilização de código: Se você precisa reutilizar a lógica em várias partes do seu código, é mais adequado criar um método separado em vez de usar uma função lambda repetidamente. Isso promove a reutilização do código e torna mais fácil a manutenção.

Aumento da complexidade do código: Em alguns casos, o uso excessivo de funções lambda pode tornar o código mais difícil de entender e dar manutenção, especialmente quando as expressões lambdas são aninhadas. Nesses casos, pode ser melhor dividir o código em partes menores e mais legíveis.

Embora as funções lambda sejam uma ferramenta poderosa e muito usada no mundo de desenvolvimento C#, há situações em que é mais apropriado evitar o seu uso.

### Aula 2 - Propriedade ou atributo? - Exercício

No C#, um atributo é uma variável declarada dentro de uma classe que armazena dados associados a uma instância específica desta classe e uma propriedade é uma abstração que fornece um meio de acessar e modificar os valores dos atributos de uma classe, encapsulando a lógica de leitura e escrita. Veja o exemplo de código abaixo que contém uma classe com um atributo e uma propriedade:

```csharp
class Filme
{
    public string Titulo;

    public int Orcamento { get; set; }
}
```

Um exemplo da instância desta classe seria:

```csharp
Filme matrix = new Filme();
matrix.Titulo = "Matrix";
matrix.Orcamento = 63;
```

Com base no código acima, analise as seguintes afirmações e marque apenas as verdadeiras:

**Alternativa correta**  
A classe Filme possui um atributo público chamado Titulo e uma propriedade chamada Orcamento.

> Isso aí! A propriedade Orcamento fornece um meio de acessar e modificar o valor com os métodos get e set. Já o atributo Titulo pode ser acessado e modificado diretamente, sem a necessidade de métodos específicos.

**Alternativa correta**  
A instância chamada matrix atribui ao Titulo o valor Matrix e à propriedade Orcamento o valor 63, usando o operador de atribuição =.

> Isso aí! Tanto a propriedade como o atributo são atribuídos pelo sinal de =.

**Alternativa correta**  
Embora ambos sejam usados para armazenar e manipular dados em uma classe, eles possuem características distintas.

> Embora haja uma relação entre atributos (fields) e propriedades (properties) em C#, eles são conceitos distintos e oferecem diferentes recursos e funcionalidades para o desenvolvimento de classes e objetos.

### Aula 2 - Desafio: hora da prática- Desafio

A prática é um elemento essencial ao iniciar os estudos em programação, pois é por meio da aplicação prática dos conceitos teóricos que se solidificam os conhecimentos. Ao escrever código, resolver problemas e construir projetos reais, os iniciantes não apenas internalizam a sintaxe das linguagens de programação, mas também desenvolvem a habilidade de pensar logicamente e abordar desafios de maneira eficiente.

Pensando nisso, criamos uma lista de atividades (não obrigatórias) focada em prática para melhorar ainda mais sua experiência de aprendizagem. Bora praticar, então?

1. Reescrever a classe Conta, criada no ultimo desafio, utilizando properties.
2. Reescrever os atributos da classe Carro, de modo que eles sejam properties, e adicionar uma nova propertie DescricaoDetalhada, que mostra o fabricante, modelo e ano do carro.
3. Reescrever a propriedade Ano da classe carro, para que ela apenas aceite valores entre 1960 e 2023.
4. Desenvolver a classe Produto, com os atributos nome, marca, preco e estoque. Além disso, garantir que o preço e o estoque do produto sejam valores positivos e criar uma propriedade que mostra detalhadamente as informações do produto, para que seja usado pela equipe de vendas.

Para te ajudar a verificar seus códigos, disponibilizamos uma lista com as [possíveis soluções no Github.](https://github.com/ArthurOcFernandes/Exerc-cios-C-/tree/curso-2-aula-2)

Boa sorte nos estudos!

### Aula 2 -Faça como eu fiz: refatorando uma função

No C#, uma função lambda pode ser aplicada em atributos, propriedades ou na forma como escrevemos funções. Abaixo, existe uma função que soma 2 valores inteiros e retorna o resultado da soma, como mostra o trecho de código a seguir:

```csharp
public int Somar(int a, int b)
{
    int resultado = a + b;
    return resultado;
}
```

Agora é sua vez! Refaça esse método Somar() usando uma função lambda retornando o resultado da operação.

Opinião do instrutor

Aqui está a mesma função Somar() reescrita utilizando uma expressão lambda em C#:

> public int Somar(int a, int b) => a + b;

Nesta versão, utilizamos a sintaxe de expressão lambda, que é uma forma concisa de definir funções anônimas. No caso, a expressão lambda recebe dois parâmetros a e b do tipo int e retorna a soma dos valores utilizando a expressão a + b.

> Lembrando: Essa forma simplificada de escrever a função é útil quando a função tem apenas uma linha de código e o retorno é direto, permitindo economizar espaço e tornar o código mais conciso.

### Aula 2 - O que aprendemos?

**Estes foram os pontos principais abordados nesta aula:**

- Corrigimos uma vulnerabilidade do sistema que permitia alterar o valor de um atributo, ferindo a regra de negócio da aplicação criando métodos de leitura e escrita (get e set);

- Criamos uma property no C#, que é uma boa prática de programação porque permite encapsular o acesso aos atributos de uma classe, fornecendo controle, validação e a possibilidade de adicionar comportamentos adicionais ao acesso desses atributos;

- Alteramos o método get de uma property no C# para adicionar lógica personalizada antes de retornar o valor do atributo correspondente.

Na próxima aula:

Vamos tornar nosso projeto mais próximo do mundo real criando mais classes e como elas se relacionam entre si!

## Aula 3 - Integrando classes e definindo relacionamentos

### Aula 3 - Projeto da aula anterior

Aqui você pode [baixar o zip da Aula 02](https://github.com/alura-cursos/ScreenSound/archive/refs/heads/aula-2.zip) ou acessar os [arquivos no Github!](https://github.com/alura-cursos/ScreenSound/tree/aula-2)

### Aula 3 - Criando a classe álbum - Vídeo 1

Transcrição  
Daniel: Eu, você e o Gui temos um novo desafio: desenvolver e melhorar nosso sistema de músicas. Nesse vídeo, vamos criar um agrupamento de músicas, um álbum. Então, vamos criar uma nova classe chamada Album no nosso sistema.

**Criando a classe Album**  
Guilherme: Já adicionamos o álbum de uma banda que nós dois gostamos de ouvir. Em casa, você também pode escolher o álbum de uma banda que goste e adicionar ao sistema. Escolhemos a banda Queen, e o álbum é o "A Night at the Opera". Nesse álbum, temos músicas como "Bohemian Rhapsody", "You Are My Best Friend" e "Love of My Life".

No entanto, com base no sistema que criamos, parece que conseguimos criar apenas músicas isoladas. Assim, não temos uma forma de dizer que todas essas músicas pertencem ao álbum do Queen. Então, provavelmente, pela forma como nossa aplicação está sendo desenvolvida, precisamos criar uma nova classe para conter informações relacionadas à banda.

Daniel: Para deixar nosso código mais organizado, vamos fechar as abas Program.cs e a classe de música (Musica.cs) por enquanto. Agora, criaremos uma nova classe, lembrando que estamos colocando cada classe em seu próprio arquivo.

Podemos usar o atalho "Ctrl Shift A" para criar um novo item no nosso projeto. O item escolhido será o "Arquivo de código", e chamaremos o arquivo de Album.cs.

Para criar uma classe, usamos a palavra reservada class com o nome usando PascalCase, seguida de uma abertura e um fechamento de chaves.

```csharp
class Album
{
}
```

O que um álbum vai ter, Gui? Vamos usar propriedades para definir isso.

Guilherme: Primeiro, podemos dizer que um álbum tem um nome. Então, criamos uma propriedade do tipo string chamada Nome.

```csharp
class Album
{
    public string Nome { get; set; }
}
```

Daniel: Além disso, um álbum tem uma coleção de músicas que fazem parte dele. Então, é importante criar um método onde adicionamos a música dentro desse álbum. Criaremos um método público (public) que não retorna nada (void), chamado AdicionarMusica.

Esse método receberá como argumento justamente a música, então digitamos o tipo Musica, damos o nome de musica, e finalizamos com abertura e fechamento de chaves.

```csharp
class Album
{
    public string Nome { get; set; }

    public void AdicionarMusica(Musica musica)
    {
    }
}
```

Para adicionar mais um método, vamos aproveitar a ideia das propriedades somente leitura. Diremos que esse álbum tem uma duração total. Então, na linha 3, vamos pular uma linha e utilizar a propriedade prop para gerar public int. O tipo será inteiro (int).

Nomearemos essa propriedade como DuraçãoTotal, que será igual à soma da duração das músicas que estão no álbum.

```csharp
class Album
{
    public string Nome { get; set; }

    public int DuracaoTotal { get; set; }

    public void AdicionarMusica(Musica musica)
    {
    }
}
```

Agora, o desafio é colocar as músicas dentro desse álbum de fato!

### Aula 3 - Criando a lista de músicas - Vídeo 2

Transcrição  
Daniel: Nesse vídeo, vamos adicionar músicas à classe Album!

**Criando a lista de músicas**  
Para isso, precisamos ter uma lista de músicas, conforme visto em outros vídeos e cursos. Na linha de código 2 do arquivo Album.cs, criaremos um campo de atributo privado, então vamos digitar private seguido do tipo List.

Na notação C#, chamamos o atributo private de campo.

Nós já usamos uma lista de strings (List`<string>`), referente às bandas. Nesse caso, queremos uma lista de músicas, então vamos passar o tipo Musica para a lista e chamá-la de musicas.

```csharp
class Album
{
    
    private List<Musica> musicas;
    
    public string Nome { get; set; }
    
    public int DuracaoTotal { get; set; }
    
    public void AdicionarMusica(Musica musica)
    {
    }
}
```

O campo privado significa que essa variável só está disponível dentro das chaves que compõem a declaração da classe Album. Além disso, iremos inicializar essa lista, deixando-a vazia por enquanto. Antes do ponto e vírgula, vamos atribuí-la à sugestão dada pelo próprio Visual Studio.

Agora precisamos adicionar músicas na lista. No escopo do método AdicionarMusica(), vamos chamar a variável musicas.Add(), adicionando musica à lista interna do álbum. Dessa forma, temos uma relação entre álbum e música.

```csharp
class Album
{
    
    private List<Musica> musicas;
    
    public string Nome { get; set; }
    
    public int DuracaoTotal { get; set; }
    
    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }
}
```

Guilherme: Podemos testar essa primeira parte, e para esse teste faz sentido pensar em um álbum real. Começaremos acessando o arquivo Program.cs para instanciar.

Daniel: Para isso, clicamos no "Gerenciador de Soluções", localizado no canto superior direito da interface. Uma vez aberto, basta dar um duplo clique sobre Program.cs.

Guilherme: Existem algumas músicas diferentes no código nesse momento. Como esse teste já foi realizado e está funcionando corretamente, podemos remover todas as linhas de código e criar um álbum do Queen.

Vamos começar pela instância do álbum (Album). Em seguida, criaremos duas músicas com pelo menos o nome. O Album pode se chamar albumDoQueen, e faremos a instância com new Album().

```csharp
Album albumDoQueen = new Album();
```

Na linha abaixo, daremos um nome para albumdoQueen, que será "A Night at the Opera".

Daniel: Para isso, digitamos albumDoQueen seguido da propriedade Nome, sendo igual ao nome que desejamos para o álbum ("A night at the opera") entre aspas.

```csharp
Album albumDoQueen = new Album();
albumDoQueen.Nome = "A night at the opera";
```

Guilherme: Agora que temos o albumDoQueen instanciado, vamos criar duas músicas. A primeira delas será "Love of My Life". Para isso, vamos criar a classe Musica seguida da variável musica1, sendo iguais a new Musica(), operador que instancia a classe.

Na linha abaixo, chamamos a propriedade Nome após a variável musica1 para definir o nome da música como "Love of my life", passado entre aspas.

```csharp
Album albumDoQueen = new Album();
albumDoQueen.Nome = "A night at the opera";

Musica musica1 = new Musica();
musica1.Nome = "Love of my life";
```

A segunda música será "Bohemian Rhapsody". Faremos o mesmo processo, porém com a variável musica2:

```csharp
Album albumDoQueen = new Album();
albumDoQueen.Nome = "A night at the opera";

Musica musica1 = new Musica();
musica1.Nome = "Love of my life";

Musica musica2 = new Musica();
musica2.Nome = "Bohemian Rhapsody";
```

Nosso próximo desafio é adicionar ambas as músicas ao álbum. Criamos um método para isso, então precisamos apenas chamá-lo, correto?

Daniel: Sim. Chamaremos primeiro a variável albumDoQueen. Se teclarmos ponto (.) após a variável, será disponibilizado o método AdicionarMusica(). Feito isso, chamaremos entre parênteses a variável musica1. Na linha abaixo, repetiremos o mesmo padrão, porém com a variável musica2.

```csharp
Album albumDoQueen = new Album();
albumDoQueen.Nome = "A night at the opera";

Musica musica1 = new Musica();
musica1.Nome = "Love of my life";

Musica musica2 = new Musica();
musica2.Nome = "Bohemian Rhapsody";

albumDoQueen.AdicionarMusica(musica1);
albumDoQueen.AdicionarMusica(musica2);
```

Guilherme: Nosso próximo desafio será visualizar esse álbum. Teoricamente, nós conseguimos adicionar as músicas ao álbum sem nenhum problema, mas ainda não conseguimos visualizá-lo, então não sabemos se funciona de fato.

Na sequência, criaremos uma forma de visualizar todas as músicas do álbum criado!

### Aula 3 - Exibindo as músicas de um álbum - Vídeo 3

Transcrição  
Guilherme: Nós criamos o álbum, mas ainda não conseguimos visualizar as músicas contidas nele. Faremos isso ao longo desse vídeo!

**Exibindo as músicas de um álbum**  
Daniel: Primeiramente, vamos criar um método chamado ExibirMusicasDoAlbum() no arquivo Album.cs. Ele será um public void e não receberá argumentos.

```csharp
// Código suprimido
public void ExibirMusicasDoAlbum()
{
}
```

Feito isso, vamos mostrar o nome da música via Console.WriteLine(), mas ainda não temos a música propriamente dita. Então, precisamos fazer um loop com o recurso foreach, contendo a variável musica em (in) musicas. No escopo de foreach, colocaremos o método Console.WriteLine().

```csharp
public void ExibirMusicasDoAlbum()
{
    foreach (var musica in musicas)
    {
        Console.WriteLine();
    }
}
```

Guilherme: No método ExibirMusicasDoAlbum(), podemos colocar o nome das músicas como argumento de Console.WriteLine().

Daniel: Primeiro fazemos a interpolação utilizando o sinal de cifrão ($) seguido de Música: entre aspas. Após os dois-pontos, podemos adicionar a variável musica seguida da propriedade Nomes entre chaves.

```csharp
public void ExibirMusicasDoAlbum()
{
    foreach (var musica in musicas)
    {
        Console.WriteLine($"Música: {musica.Nome}");
    }
}
```

Em seguida, acima do foreach, vamos adicionar um título. Para isso, usamos novamente o método Console.WriteLine() e passamos como argumento o título entre aspas, que será "Lista de músicas do álbum:".

Antes do dois-pontos, passaremos entre chaves a propriedade Nome, para adicionar o nome do álbum ao título. Para finalizar, vamos adicionar \n antes do fechamento das aspas para pular uma linha após o título.

```csharp
public void ExibirMusicasDoAlbum()
{
    Console.WriteLine($"Lista de músicas do álbum {Nome}:\n");
    foreach (var musica in musicas)
    {
        Console.WriteLine($"Música: {musica.Nome}");
    }
}
```

Feito isso, podemos retornar ao arquivo Program.cs. No final do código, vamos digitar a variável albumDoQueen seguida do método ExibirMusicasDoAlbum(), separados por um ponto.

```csharp
albumDoQueen.ExibirMusicasDoAlbum();
```

Ao pressionar o botão de play do ScreenSound, localizado na barra superior da interface, teremos o seguinte resultado no console:

Lista de músicas do álbum A night at the opera:

```csharp
Música: Love of my life
Música: Bohemian Rhapsody
```

Guilherme: Agora falta solucionar um desafio que definimos anteriormente: exibir o tempo total do álbum. Então vamos aproveitar para atribuir uma duração (propriedade Duracao) a musica1 e a musica2.

musica1: 213 segundos  
musica2: 354 segundos

Faremos essa atribuição na classe Musica respectiva a cada uma das músicas, usando as propriedades musica1.Duracao e musica2.Duracao.

```csharp
// Código suprimido
Musica musica1 = new Musica();
musica1.Nome = "Love of my life";
musica1.Duracao = 213;

Musica musica2 = new Musica();
musica2.Nome = "Bohemian Rhapsody";
musica1.Duracao = 354;

// Código suprimido
```

Daniel: Agora precisamos retornar ao arquivo Álbum.cs e melhorar a propriedade de somente leitura. Para isso, usaremos a construção que tem o lambda (=>) no lugar de { get; set; }.

Como queremos a duração total do álbum, precisamos somar a duração de cada música contida na lista. Existe um método chamado Sum() que vamos usar para formar a expressão musicas.Sum().

Em seguida, precisamos definir que a soma deve ser feita com a propriedade Duracao. No método Sum(), vamos representar cada música como m, adicionar uma arrow function logo depois, e por fim escrever m.Duracao, indicando que para cada música queremos somar a duração.

```csharp
public int DuracaoTotal => musicas.Sum(m => m.Duracao);
```

Dessa forma, a soma desejada será feita e retornada na propriedade de somente leitura.

Guilherme: No final do console, após exibir as músicas, podemos adicionar um novo método Console.WriteLine() dizendo, por exemplo, "Para ouvir este álbum inteiro você precisa de {DuracaoTotal} segundos".

Lembre-se de incluir o símbolo de interpolação ($) antes da abertura de aspas.

```csharp
// Código suprimido
public void ExibirMusicasDoAlbum()
{
    Console.WriteLine($"Lista de músicas do álbum {Nome}:\n");
    foreach (var musica in musicas)
    {
        Console.WriteLine($"Música: {musica.Nome}");
    }
    Console.WriteLine($"\nPara ouvir este álbum inteiro você precisa de {DuracaoTotal}");
}
```

Perceba que foi adicionado o \n para pular uma linha antes da última mensagem.

Daniel: Agora podemos testar! Clicando novamente no botão ScreenSound da barra superior, o terminal exibirá as mesmas músicas e a nova linha adicionada, contendo a duração total.

Lista de músicas do álbum A night at the opera:

```csharp
Música: Love of my life
Música: Bohemian Rhapsody
Para ouvir este álbum inteiro você precisa de 567
```

### Aula 3 - Relacionamento entre classes - Execício

No C#, podemos criar um relacionamento entre classes utilizando a composição, que é uma forma de relacionamento em que uma classe possui uma instância de outra classe como um de seus membros. Isso permite que a classe tenha acesso aos membros e comportamentos da classe relacionada, como ilustra o código abaixo:

```csharp
public class Pessoa
    {
        public string Nome { get; set; }
        public Endereco Endereco { get; set; }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Endereço: {Endereco.Rua}, {Endereco.Cidade}, {Endereco.Estado}");
        }
    }
```

Agora, com base no código acima, marque as alternativas que ilustram como seria a classe Endereco.

Selecione 2 alternativas

Resposta 1

```csharp
class Endereco
    {
        public string Rua { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
    }
```

> Isso mesmo! Há um relacionamento de composição entre as classes Pessoa e Endereco. Isso significa que a classe Pessoa possui uma instância da classe Endereco como um de seus atributos.

Resposta 2  

```csharp
class Endereco
{
    private string rua;
    private string cidade;
    private string estado;
    public string Rua
    {
        get { return rua; }
        set { rua = value; }
    }
    public string Cidade
    {
        get { return cidade; }
        set { cidade = value; }
    }
    public string Estado
    {
        get { return estado; }
        set { estado = value; }
    }
}
```

> Isso aí! Esse código permite maior personalização e lógica adicional. As propriedades Rua, Cidade e Estado têm campos privados correspondentes (rua, cidade e estado) e são definidas utilizando os blocos de código {} para os getters e setters. Isso permite adicionar lógica personalizada dentro desses blocos, se necessário, além de ter controle direto sobre o acesso aos campos privados.

### Aula 3 - Desafio: hora da prática - Desafio

A prática é um elemento essencial ao iniciar os estudos em programação, pois é por meio da aplicação prática dos conceitos teóricos que se solidificam os conhecimentos. Ao escrever código, resolver problemas e construir projetos reais, os iniciantes não apenas internalizam a sintaxe das linguagens de programação, mas também desenvolvem a habilidade de pensar logicamente e abordar desafios de maneira eficiente.

Pensando nisso, criamos uma lista de atividades (não obrigatórias) focada em prática para melhorar ainda mais sua experiência de aprendizagem. Bora praticar, então?

1. Modelar uma classe Conta, que tenha como atributos uma classe Titular, além de informações da conta, como agência, número da conta, saldo e limite, bem como um método que devolva as informações da conta de forma detalhada.
2. Instanciar um objeto do tipo Conta e um do tipo Titular e mostrar as informações de Titular, a partir da Conta.
3. Desenvolver uma classe que represente um estoque de produtos, e que tenha as funcionalidades de adicionar novos produtos, e exibir todos os produtos no estoque.
4. Modelar o sistema de uma escola. Crie classes para Aluno, Professor e Disciplina. A classe Aluno deve ter informações como nome, idade e notas. A classe Professor deve ter informações sobre nome e disciplinas lecionadas. A classe Disciplina deve armazenar o nome da disciplina e a lista de alunos matriculados.
5. Modelar um sistema para um restaurante com classes como Restaurante, Mesa, Pedido e Cardapio. A classe Restaurante deve ter mesas que podem ser reservadas e um cardápio com itens que podem ser pedidos. Os pedidos podem estar associados a uma mesa.

Opinião do instrutor

Para te ajudar a verificar seus códigos, disponibilizamos uma lista com as [possíveis soluções no Github](https://github.com/ArthurOcFernandes/Exerc-cios-C-/tree/curso-2-aula-3).

Boa sorte nos estudos!

### Aula 3 - Faça como eu fiz: mais uma classe

Atualmente, nossa aplicação possui 2 classes: Musica e Album.

| Música   |   Álbum    |
|----------|------------|
|nome      |nome        |
|artista   |duracaoTotal|
|duracao   |            |
|disponível|            |

Agora é sua vez! Crie uma classe chamada Genero, que armazena o nome do gênero musical, e crie um relacionamento desta nova classe em nossa aplicação.

Opinião do instrutor

Essas são as três classes que representam entidades relacionadas à música. A classe Musica contém informações específicas sobre uma música individual, a classe Genero representa os diferentes gêneros musicais e a classe Album representa um álbum musical, que pode conter várias músicas.

|Música    |Álbum       |Gênero|
|----------|------------|------|
|nome      |nome        |nome  |
|artista   |duracaoTotal|      |
|duracao   |            |      |
|disponível|            |      |
|gênero    |            |      |

Vamos criar a classe e definir a propriedade Nome para cada gênero musical, como rock, samba e pop, por exemplo:

```csharp
public class Genero
{
    public string Nome { get; set; }
}
```

Agora vamos criar um relacionamento entre as classes Musica e Genero, indicando que cada música possui um gênero musical:

```csharp
public class Musica
{
    public string Nome { get; set; }
    public string Artista { get; set; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public Genero Genero { get; set; }

    //código omitido…
}
```

Nessa atualização, adicionamos a propriedade Genero à classe Musica, que representa o gênero musical da música. Agora, cada instância da classe Musica pode ter uma referência a um objeto Genero, permitindo a associação entre uma música e seu respectivo gênero.

> Lembrando: As propriedades Genero nas classes Musica e Genero têm diferentes propósitos e funcionalidades. Na classe Musica, a propriedade Genero é utilizada para definir o gênero musical associado à música. Ela possui tanto o acesso de leitura (get) quanto o acesso de gravação (set), o que permite definir e obter o objeto Genero associado à música. Com isso, é possível atribuir um objeto Genero à uma música e também recuperar o gênero musical associado à ela posteriormente.

### Aula 3 - O que aprendemos?

**Estes foram os pontos principais abordados nesta aula:**

- Criamos um modelo para o album como uma classe, reforçando a prática de manter cada classe em seu arquivo, e foram abordados os métodos AdicionarMusica e DuracaoTotal, mostrando como adicionar e listar as músicas.

- Criamos uma lista de músicas como campo privado da classe, modificou-se o método AdicionarMusica utilizando o método "Add" da lista para adicionar músicas, alterou-se o método DuracaoTotal utilizando o método "Sum" da lista para calcular a duração total das músicas e foram feitos testes relacionando músicas ao álbum.

- Exibimos a lista de músicas do álbum, mostrando o nome de cada música, além de exibir a duração total do álbum através do método ExibirMusicasDoAlbum.

## Aula 4 - Construtor de Bandas

### Aula 4 - Projeto da aula anterior

Aqui você pode [baixar o zip da Aula 03](https://github.com/alura-cursos/ScreenSound/archive/refs/heads/aula-3.zip) ou acessar os [arquivos no Github!](https://github.com/alura-cursos/ScreenSound/tree/aula-3)

### Aula 4 - Desenvolvendo a classe banda - Vídeo 1

Transcrição
Daniel: Agora o desafio é criar uma classe para dar mais um passo nessa estrutura. Já fizemos música e álbum, agora vamos fazer a banda.

**Criação classe Banda**  
Guilherme: Vamos criar a classe Banda e pensar em algumas propriedades que essa classe deve ter.

Daniel: Para isso, apertamos novamente "Ctrl + Shift + A" para abrir a janela de adicionar novo item. Já está selecionado o "Arquivo de código", podemos somente mudar o nome para Banda.

No arquivo, digitamos a palavra reservada class, o nome Banda com PascalCase e abre e fecha chaves.

No corpo da classe, colocamos as propriedades ao escrever prop e aceitar a sugestão de public int MyProperty { get; set; } com a tecla "Tab". Como bandas têm nome, substituímos MyProperty por Nome e modificamos o tipo para string.

Banda.cs:

class Banda
{
    public string Nome { get; set; }
}Copiar código
Já podemos colocar os métodos para incluir álbuns. Em uma nova linha, declaramos um método public void que não retorna nada chamado AdicionarAlbum(), recebendo Album album como argumento de entrada.

Para adicionar esse álbum, vamos criar um campo privado antes da propriedade Nome. Desse modo, inicializamos a lista com private List<Album> e apertamos "Tab" para aceitar a sugestão de completar com albums igual à new List<Album>().

No corpo do método AdicionarAlbum(), vamos adicionar na lista albums o objeto album que recebemos como argumento de entrada.

class Banda
{
    private List<Album> albums = new List<Album>();

    public string Nome { get; set; }

    public void AdicionarAlbum(Album album) 
    { 
        albums.Add(album);
    }
}Copiar código
Também podemos colocar a exibição, já que depois queremos testar essa classe no projeto. Para isso, criamos um novo método public void sem retornar nada chamado ExibirDiscografia().

Nele, colocamos um título para informar que estamos exibindo a discografia. Por isso, digitamos Console.WriteLine(), passando o cifrão que é o símbolo da interpolação seguido da string Discografia da banda e a propriedade {Nome} que contém o nome da banda.

Em seguida, fazemos um foreach novamente com a iteração de Album album in albums. Dentro dele, colocamos outro Console.WriteLine() com cifrão e string Álbum: e o {album.Nome}. Também podemos acrescentar na string a duração total do álbum como {album.DuracaoTotal} entre parênteses.

class Banda
{

// código omitido…

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia da banda {Nome}");
        foreach (Album album in albums)
        {
            Console.WriteLine($"Álbum: {album.Nome} ({album.DuracaoTotal})");
        }
    }
}Copiar código
Exibir a discografia do Queen
Daniel: Agora precisamos testar, Gui. Para isso, novamente abrimos a aba com o arquivo Program.cs. Nele, já temos um albumDoQueen com duas músicas. Adicionamos musica1 e musica2 no álbum.

Mas, podemos apagar albumDoQueen.ExibirMusicasDoAlbum(). No lugar, vamos criar uma Banda queen igual à new Banda(). Em uma nova linha, colocamos o nome dela como queen.Nome igual à Queen entre aspas.

Agora, precisamos adicionar o àlbum. Para isso, digitamos queen.AdicionarAlbum(), passando albumDoQueen.

Finalmente, queremos exibir a discografia dessa banda. Ou seja, queen.ExibirDiscografia().

Program.cs:

Album albumDoQueen = new Album();
albumDoQueen.Nome = "A night at the opera";

Musica musica1 = new Musica();
musica1.Nome = "Love of my life";
musica1.Duracao = 231;

Musica musica2 = new Musica();
musica2.Nome = "Bohemian Rhapsody";
musica2.Duracao = 354;

albumDoQueen.AdicionarMusica(musica1);
albumDoQueen.AdicionarMusica(musica2);

Banda queen = new Banda();
queen.Nome = "Queen";
queen.AdicionarAlbum(albumDoQueen);
queen.ExibirDiscografia();Copiar código
Agora podemos testar ao clicar no botão com ícone play "ScreenSound". Com isso, aparece a tela do terminal com a discografia da banda Queen com apenas um álbum chamado A night at the opera e a duração total entre parênteses.

Discografia da banda Queen

Álbum: A night at the opera (567)

Importância da organização do projeto
Guilherme: Qual a grande vantagem que temos como pessoas desenvolvedoras de criar classes pequenas que isolam o comportamento e o método que contêm?

Por que não podemos criar um ou dois arquivos e colocar todas as nossas classes lá dentro? O programa ainda vai funcionar.

No nosso projeto, criamos três classes: Musica, Banda e Album. E começamos a ligar as informações dessas classes. Mas, qual a vantagem de criar diversas classes para isolar a aplicação?

Daniel: Você acabou de se responder: isolar. Temos essa facilidade de que tudo que está relacionado a banda vai estar especificamente na classe Banda, como os conceitos e regras de negócio de banda. Isso também vale para os outros conceitos que temos no projeto.

Guilherme: Em um projeto real, existem muitas classes. Centenas ou até milhares de classes. Teoricamente, ao isolar a classe de Banda, saberemos exatamente qual é o código e em qual arquivo precisamos alterar - seja para alterar um comportamento, criar um método ou adicionar uma regra de negócio.

À medida que criamos essas classes, o nosso projeto aumenta a complexidade.

Daniel: Se tentássemos colocar tudo em um local só e uma classe só, íamos começar a ter dificuldade em saber onde adicionar novas regras de negócio. Onde vamos buscar? Vamos colocar em qual método? Em qual propriedade? O processo de desenvolvimento fica confuso.

Guilherme: Como dito anteriormente, um projeto real tem muitas classes, e o isolamento é fundamental para manter um bom gerenciamento do código.

### Aula 4 -  - Vídeo 2
### Aula 4 -  - Vídeo 3
### Aula 4 -  - Vídeo 4
### Aula 4 -  - Vídeo 5
### Aula 4 -  - Vídeo 6
### Aula 4 -  - Vídeo 7
### Aula 4 -  - Vídeo 8
### Aula 4 -  - Vídeo 9
