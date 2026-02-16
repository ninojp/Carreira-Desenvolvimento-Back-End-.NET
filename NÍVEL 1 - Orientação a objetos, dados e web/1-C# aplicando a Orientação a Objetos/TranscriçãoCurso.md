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

### Aula 1 -  - Vídeo 8
