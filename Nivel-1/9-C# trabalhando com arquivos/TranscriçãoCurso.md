# Curso Alura C#: trabalhando com arquivos

## Aula 1: Lendo arquivos de Texto

### Aula 1: Apresentação - Vídeo 1

Transcrição  
Boas-vindas! Meu nome é Larissa Gabriela, faço parte do time de instrutores da Alura, na Escola de Programação. Acompanharei vocês ao longo deste curso, em que falaremos sobre como manipular arquivos com a linguagem C# e ferramentas do ecossistema .NET.

Larissa Gabriela é uma mulher de pele clara com olhos castanhos escuros. Tem cabelos castanhos, lisos, na altura dos ombros. Veste uma regata amarela e está num ambiente com iluminação azul. Ao fundo, há uma parede lisa. Na lateral esquerda do vídeo, vê-se um microfone com um abafador de ruídos.

**Quais são os pré-requisitos?**  
Espera-se que você já tenha conhecimentos sobre sintaxe e tenha desenvolvido seus primeiros programas em C#, trabalhando os conceitos de variável, laços de repetição e condicionais — ferramentas que utilizaremos nesse curso.

Além disso, é importante que você já tenha estudado programação orientada a objetos em C#, pois usaremos algumas nomenclaturas relativas a esse assunto. Por fim, também é interessante que você saiba como lidar com erros em C#: o que são exceções e como tratá-las.

**O que vamos desenvolver?**  
Nesse treinamento, vamos aprender a lidar com fluxo de arquivos, isto é, como selecionar um arquivo em nosso computador e trazê-lo para dentro do nosso código. Por exemplo, podemos mostrar seu conteúdo no console para o usuário, da forma mais otimizada possível. Ademais, aprenderemos a aproveitar as informações desses arquivos em nosso código, utilizando-as em nosso favor.

Também vamos focar na criação de arquivos, escrevendo comandos no código para criar e adicionar informações dentro dele. Além disso, trabalharemos com arquivos binários, estudando como trabalhar com arquivos grandes e otimizar o uso de memória do nosso computador.

Por fim, falaremos sobre o stream do console e exploremos como trazer informações que o usuário digita no console para dentro de um arquivo, por exemplo, para armazenar esses dados.

Espero que vocês estejam animados para se aventurar nesse enorme ecossistema do .NET. Vamos estudar!

### Aula 1: Projeto inicial do curso

Para começar a estudar, sugerimos que você faça download do projeto inicial do curso.

[Baixe o zip](https://github.com/alura-cursos/CsharpArquivos/archive/refs/heads/main.zip) ou visualize os [arquivos no Github!](https://github.com/alura-cursos/CsharpArquivos)

### Aula 1: Entendendo fluxo de dados - Vídeo 2

Transcrição  
Vamos dar início ao nosso curso em que exploraremos como aplicar os conceitos de fluxo de dados e arquivos de texto, de modo a solucionar problemas e melhorar nossa aplicação, tornando-a mais dinâmica.

Para começar, vamos abrir o projeto inicial do curso no Visual Studio. O projeto ByteBank é um banco em que podemos simular algumas ações, como depósitos e saques. Nele, temos as classes ContaCorrente e Cliente. Trata-se de uma aplicação relativamente simples, pois nosso foco será trabalhar com arquivos de texto.

Até então, para criar uma conta-corrente na nossa aplicação, declaramos uma variável (por exemplo, conta) e instanciamos uma ContaCorrente, fornecendo o número da agência e o número da conta-corrente, em Program.cs:

```csharp
using ByteBankIO;

class Program
{
    static void Main(string[] args)
    {
        var conta = ContaCorrente(524, 4518);
        Console.ReadLine();
    }

    private static object ContaCorrente(int v1, int v2)
    {
        throw new NotImplementedException();
    }
}
```

Se estivéssemos trabalhando com uma pequena quantidade de contas, isso seria o suficiente. No entanto, considerando o cenário de um banco grande em que há diversos funcionários criando inúmeras contas-correntes diariamente, esse sistema seria inconveniente e prejudicial. É preciso encontrar formas mais rápidas de acessar esses dados.

Uma opção é armazenar os dados dos clientes em um arquivo de texto, listando o número da agência, o número da conta, o saldo e o nome do cliente — como no arquivo contas.txt disponibilizado junto do projeto do curso. Veja um pequeno trecho dele, a seguir:

296 5459 3494.67 Davi

433 2341 3257.15 Elza

465 2291 1566.57 Denilson

234 6151 4081.61 Tania

...

A princípio, poderíamos pensar em armazenar esses dados em uma única string e, posteriormente, usar métodos para "quebrá-la" e separar cada item. Essa ideia é possível, porém muito trabalhosa. Além disso, por serem muitas informações, esse processo consumiria bastante memória do computador. Logo, vamos encontrar uma forma melhorar de lidar com esses dados, trazendo esse arquivo .txt para dentro do nosso programa.

**Fluxo de dados**  
Primeiramente, é importante compreendermos como o computador interpreta e trabalha com dados, ou seja, o fluxo de dados.

O arquivo contas.txt é pequeno, tem cerca de 24 kB. Examinando a memória RAM do nosso computador, é comum encontrarmos a memória de 4 GB ou 8 GB, uma quantidade razoável para manter esse documento inteiro carregado na memória RAM.

Quando estamos trabalhando com vídeos (por exemplo, aulas na plataforma Alura, ou filmes em HD ou 4K), esses vídeos de alta qualidade ocupam bastante memória. Geralmente, o computador não os carrega e interpreta de uma só vez, ele realiza esse processo gradualmente.

Em outras palavras, não lidamos com um arquivo completo para exibir um dado para o usuário, mas com um fluxo de dados.

Como os vídeos são um código diferenciado para que o computador consiga interpretá-los, nossa máquina transforma esses dados em vídeo de trechos em trechos, conforme assistimos. E esta é exatamente a ideia de fluxo de dados: selecionar trechos e trabalhar com eles para minimizar o uso de memória e otimizar as ferramentas que estamos utilizando.

Em resumo, para desenvolver nosso projeto em C#, é importante saber que lidamos com fluxo de dados, não com arquivos completos. Para exibir informações aos usuários, ponderamos e lidamos com trechos para facilitar nosso trabalho.

### Aula 1: Criando um FileStream - Vídeo 3

Transcrição  
No vídeo anterior, entendemos como funciona o fluxo de dados. Aprendemos, por exemplo, como o computador exibe o conteúdo de um vídeo, lidando com trechos de arquivos em lugar do arquivo completo, para otimizar o uso de memória. Agora, vamos entender esse conceito na prática, construindo um fluxo de dados na nossa aplicação.

O primeiro passo é mostrar para a aplicação com qual arquivo trabalharemos, seja para abri-lo ou criá-lo. No caso, vamos abrir e manipular o arquivo contas.txt, disponibilizado junto do projeto inicial do curso.

**Endereço do arquivo**  
Em Program.cs, vamos armazenar o endereço do arquivo em uma variável para a aplicação reconhecer onde ele está. Esse endereço varia de acordo com a pasta onde salvamos o contas.txt — por exemplo, se você fez o download pela plataforma da Alura, é possível que ele esteja na pasta "Downloads". Para evitar confusões ao longo do curso, vamos colocar o arquivo contas.txt dentro da mesma pasta do nosso executável.

Para encontrar a pasta do executável, vamos clicar em "Exibir > Gerenciador de Soluções" no menu superior do Visual Studio ou usar o atalho "Ctrl + Alt + L". O gerenciador de soluções será aberto na lateral direita da IDE. Nele, temos as classes e as dependências com as quais estamos trabalhando até agora na nossa aplicação. Com o botão direito, clicaremos na nossa solução "Solução 'ByteBank_IO' (1 de 1 projeto)" e selecionaremos "Abrir Pasta no Gerenciador de Arquivos".

Uma vez aberto o gerenciador de arquivos, vamos navegar até "ByteBank_IO > bin > Debug > net6.0". Entre outros arquivos, encontraremos nessa pasta o nosso executável (o aplicativo da nossa aplicação): o ByteBank_IO. Portanto, vamos arrastar o arquivo contas.txt para dentro dessa pasta.

Agora, voltando ao Program.cs, podemos armazenar o endereço do arquivo em uma variável chamada enderecoDoArquivo. Como ele está na mesma pasta do executável, basta colocar o nome do arquivo:

```csharp
using ByteBankIO;

class Program
{
    static void Main(string[] args)
    {
        var enderecoDoArquivo = "contas.txt";

        Console.ReadLine();
    }
}
```

Assim, evitamos escrever um caminho longo, minimizando problemas que poderiam surgir por conta do endereço do arquivo — por exemplo, caso movêssemos o arquivo da pasta "Downloads" para a pasta "Documentos".

Fluxo de bytes
O próximo passo é criar um fluxo de bytes, que possibilitará nosso acesso ao arquivo contas.txt. Em outras palavras, vamos percorrer os bytes que contêm os dados desse documento.

De início, vamos criar a variável fluxoDoArquivo para guardar esse fluxo de dados. A partir de agora, trabalharemos com uma ferramenta importante para lidar com arquivos: o FileStream. Stream significa "fluxo" em inglês, logo, o FileStream trabalhará com o fluxo de dados de um arquivo:

```csharp
using ByteBankIO;

class Program
{
    static void Main(string[] args)
    {
        var enderecoDoArquivo = "contas.txt";
        var fluxoDoArquivo = new FileStream();

        Console.ReadLine();
    }
}
```

Ao digitar new FileStream() na linha 8, o Visual Studio indicará alguns argumentos que precisamos fornecer para que o FileStream funcione adequadamente. O primeiro argumento é o endereço do arquivo, que guardamos na variável enderecoDoArquivo:

```csharp
using ByteBankIO;

class Program
{
    static void Main(string[] args)
    {
        var enderecoDoArquivo = "contas.txt";
        var fluxoDoArquivo = new FileStream(enderecoDoArquivo);

        Console.ReadLine();
    }
}
```

Visto que existem vários modos de operação do FileStream, também precisamos especificar o que pretendemos fazer com contas.txt: criar, abrir, modificar, concatenar etc. Então, no segundo argumento, vamos indicar que queremos abrir o arquivo, com FileMode.Open:

```csharp
using ByteBankIO;

class Program
{
    static void Main(string[] args)
    {
        var enderecoDoArquivo = "contas.txt";
        var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open);

        Console.ReadLine();
    }
}
```

Assim, a variável está pronta para trabalhar com o fluxo do nosso arquivo. Já informamos o arquivo com o qual trabalharemos e indicamos que vamos abri-lo. Na sequência, o objetivo será recuperar o bytes que estão dentro desse arquivo.

**O método Read**  
O FileStream possui um método chamado Read. A seguir, vamos explorar sua estrutura:

```csharp
public override int Read(byte[] array, int offset, int count);
```

O método Read recebe três argumentos. O primeiro é o byte[] array, onde serão armazenados os bytes lidos pelo método — ou seja, retomando a ideia de fluxo, de trabalhar de parte em parte no código. Esse conceito ficará mais claro, à medida que entendermos como fornecemos esse array.

O segundo argumento é o int offset, que delimita o índice em que o método começará a preencher o array. Por exemplo: para preencher a partir da primeira posição (índice 0), informaremos o número 0 no offset. Caso indiquemos o número 10, começaremos a preencher o array a partir do índice 10 e as dez primeiras posições (índices 0 a 9) ficarão reservadas.

O terceiro argumento é o int count, que informa quantas posições preencher. Por exemplo, se indicarmos o offset como 0 e o count como 10, preencheremos do índice 0 a 9. Vale lembrar que iniciamos a contagem dos índices no 0, por isso, a posição 10 corresponde ao índice 9.

Em resumo: é preciso fornecer o array, o índice em que começaremos a preenchê-lo e quantas posições serão usadas.

O array informado ao FileStream possui um nome bastante comum, com o qual nos deparamos com frequência no meio da programação: buffer. Trata-se de um array que reutilizamos para guardar informações temporárias. Novamente, voltamos ao conceito de fluxo e uso de dados por trechos, sem carregar tudo de uma vez. O buffer armazenará trechos temporários do arquivo.

A seguir, começaremos a construir o Read do nosso FileStream:

```csharp
using ByteBankIO;

class Program
{
    static void Main(string[] args)
    {
        var enderecoDoArquivo = "contas.txt";
        var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open);

                fluxoDoArquivo.Read();

                // public override int Read(byte[] array, int offset, int count)

        Console.ReadLine();
    }
}
```

Antes de informar os argumentos, vamos criar uma variável chamada buffer que receberá o nosso array, um novo byte com 1024 posições, isto é, o tamanho de 1 kB:

```csharp
using ByteBankIO;

class Program
{
    static void Main(string[] args)
    {
        var enderecoDoArquivo = "contas.txt";
        var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open);

        var buffer = new byte[1024]; //1KB

        fluxoDoArquivo.Read();

        // public override int Read(byte[] array, int offset, int count)

        Console.ReadLine();
    }
}
```

O método Read receberá o buffer como primeiro argumento. Quanto aos demais argumentos, nossa intenção é que o FileStream comece a gravar a partir da posição 0 até o fim do array:

```csharp
using ByteBankIO;

class Program
{
    static void Main(string[] args)
    {
        var enderecoDoArquivo = "contas.txt";
        var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open);

        var buffer = new byte[1024]; //1KB

        fluxoDoArquivo.Read(buffer, 0, 1024);

        // public override int Read(byte[] array, int offset, int count)

        Console.ReadLine();
    }
}
```

Assim, iniciamos a implementação do conceito de fluxo. Criamos um byte e vamos preenchê-lo a partir da posição 0 até a 1024, começamos a entender o uso do FileStream, do FileMode.Open para informar ao programa o que fazer com o arquivo, e do método Read.

A partir dos próximos vídeos, nos aprofundaremos em como melhorar nosso código e visualizar o arquivo.

### Aula 1: Para saber mais: enumerador

Estamos modelando uma classe para representar um botão! O botão precisa de um texto, uma cor e uma ação no clique. O texto será uma string, assim poderemos ter valores como "Ok", "Cancelar" e "Clique aqui". A cor pode ser uma string também, então aceitaremos qualquer valor, como "Azul", "Vermelho" e assim por diante.

```csharp
class Botao
{
    public String Texto { get; set; }
    public String Cor { get; set; }
}
```

Há um conjunto limitado de cores que vamos aceitar: Azul, Vermelho e Verde são um bom começo para nosso aplicativo (já bastante colorido). É importante nos assegurarmos que o valor da propriedade Cor esteja correto e dentro do conjunto delimitado!

Será que vamos aceitar o valor "azul"? E quanto à string "AZUL"? Talvez alguém do time fique confuso, então podemos ajudar e criar uma classe com as constantes que aceitaremos neste atributo:

```csharp
static class Cores
{
    public static readonly string Azul = "Azul";
    public static readonly string Vermelho = "Vermelho";
    public static readonly string Verde = "Verde";
}
```

Agora, nosso time de programação pode usar btnCancelar.Cor = Cores.Azul ao invés de se preocupar com a forma correta de se escrever o nome desta cor! Contudo, isto ainda não é seguro. O compilador permite que qualquer string seja usada nesta propriedade, como btnCancelar.Cor = "degradê radial de azul para amarelo" - um erro que queremos evitar. Uma alternativa seria criar uma classe abstrata chamada Cor e então, a partir dela, criar os tipos derivados com os valores que aceitaremos.

Mas vamos criar uma classe sem nenhum atributo ou comportamento só por causa disso? Parece errado. Então, o que nós queremos é enumerar as cores que podem ser usadas e contar com a ajuda do compilador. No C#, podemos criar um enumerador com a sintaxe abaixo:

```csharp
enum CoresBotao
{
    Azul,
    Vermelho,
    Verde
}
```

Muito mais simples que aquela classe estática. Agora, a propriedade Cor na classe Botao não será mais do tipo String e sim do tipo CoresBotao - o nome do enum que criamos:

```csharp
var btnCancelar = new Botao();
btnCancelar.Texto = "Cancelar";
btnCancelar.Cor = CoresBotao.Azul;
```

E enums são fortemente tipados! Em variáveis ou propriedades do tipo CoresBotao só podemos usar valores definidos neste enum:

```csharp
CoresBotao cor1 = "Azul"; // nao compila
CoresBotao cor2 = CoresBotao.Verde; //compila
```

Bacana, não? E se estivermos lendo o valor desta propriedade de um arquivo? Já veremos como recuperar conteúdo de um arquivo como string ou int, por enquanto vamos testar com literais:

```csharp
var linhaDeTextoDoArquivo = "Azul";
CoresBotao cor1 = linhaDeTextoDoArquivo; // nao compila
```

Como vimos, a atribuição que tentamos fazer não funciona. Será que um cast funcionará?

```csharp
var linhaDeTextoDoArquivo = "Azul";
CoresBotao cor1 = (CoresBotao)linhaDeTextoDoArquivo; // nao compila
```

Cast entre string e enums também não funciona. E se tentarmos com inteiros?

```csharp
var numero = 0;
CoresBotao cor1 = (CoresBotao)numero; // Compila!
```

Compila! Isso acontece porque podemos atribuir valores inteiros em nossos valores de enum. O enum CoresBotao, debaixo dos panos, foi criado dessa forma pelo compilador C#:

```csharp
enum CoresBotao
{
    Azul = 0,
    Vermelho = 1,
    Verde = 2
}
```

Mas podemos explicitamente mudar esses valores para o que for mais conveniente em nosso programa:

```csharp
enum CoresBotao
{
    Azul = 128,
    Vermelho = 256,
    Verde = 512
}
```

Podemos testar o exemplo acima:

```csharp
Console.WriteLine(CoresBotao.Azul == (CoresBotao)128); // escreve True
Console.WriteLine(CoresBotao.Vermelho == (CoresBotao)256); // escreve True
Console.WriteLine(CoresBotao.Verde == (CoresBotao)512); // escreve True

Console.WriteLine(CoresBotao.Verde == (CoresBotao)1); // escreve False e não lança exceção
```

Legal, né?

### Aula 1: Para saber mais: FileMode

Logo no primeiro vídeo desta aula foi preciso informar ao FileStream qual modo de operação usaremos no arquivo. Para abrir o documento, escolhemos FileMode.Open. FileMode não é uma classe, tampouco Open é um membro estático. Na verdade, FileMode é um enum e Open é um de seus valores. Se olharmos a definição destes nomes pelo Visual Studio, encontraremos a seguinte construção:

```csharp
public enum FileMode
{
  CreateNew = 1,
  Create = 2,
  Open = 3,
  OpenOrCreate = 4,
  Truncate = 5,
  Append = 6
}
```

O FileMode específica como nosso sistema operacional deve abrir o arquivo. Fazemos da seguinte maneira:

```csharp
FileStream s2 = new FileStream(name, FileMode.Open, FileAccess.Read, FileShare.Read);
```

Bora ver mais ainda na prática?

### Aula 1: Método especializado - Vídeo 4

Transcrição  
Agora que entendemos como trabalhar com FileStream e o conceito de fluxo de dados, passaremos a exibir o nosso array de 1 kB, para esclarecer o que acontece por trás do código que escrevemos.

**Exibindo o buffer**  
Para manter o nosso projeto organizado, vamos criar o método EscreverBuffer, especializado em exibir o buffer na nossa tela, mostrando o que foi coletado do arquivo contas.txt. Como argumento, ele receberá o nosso array:

```csharp
using ByteBankIO;

class Program
{
        static void Main(string[] args)
        {
                var enderecoDoArquivo = "contas.txt";
                var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open);

                var buffer = new byte[1024]; //1KB

                fluxoDoArquivo.Read(buffer, 0, 1024);

                // public override int Read(byte[] array, int offset, int count)

                Console.ReadLine();
        }

        static void EscreverBuffer(byte[] buffer)
        {

        }
}
```

No método EscreverBuffer, usaremos uma estrutura foreach para passar por cada um dos bytes do buffer e exibi-los com um Console.Write:

```csharp
// Código anterior omitido

        static void EscreverBuffer(byte[] buffer)
        {
            foreach(var meuByte in buffer)
            {
                Console.Write(meuByte);
                Console.Write(" ");
            }
        }
```

Em lugar do Console.WriteLine que costumamos usar, optamos pelo Console.Write porque trabalharemos com 1024 posições, então é interessantes que os bytes sejam impressos lado a lado, não linha a linha. Além disso, a cada iteração, acrescentamos um espaço para tornar o resultado mais legível.

Já criamos o nosso fluxo de dados e estamos armazenando cada um dos bytes no nosso array. No método Main, vamos chamar EscreverBuffer para visualizar o resultado na tela, passando buffer como parâmetro:

```csharp
using ByteBankIO;
class Program
{
        static void Main(string[] args)
        {
                var enderecoDoArquivo = "contas.txt";
                var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open);
                var buffer = new byte[1024]; //1KB
                fluxoDoArquivo.Read(buffer, 0, 1024);                
                EscreverBuffer(buffer);
                // public override int Read(byte[] array, int offset, int count)

                Console.ReadLine();
        }

        static void EscreverBuffer(byte[] buffer)
        {
            foreach(var meuByte in buffer)
            {
                Console.Write(meuByte);
                Console.Write(" ");
            }
}
```

Em seguida, vamos executar a nossa aplicação. Basta clicar no play no menu superior do Visual Studio. Como resultado, teremos uma enorme sequência de números, que inicialmente não fazem sentido para nós. Vamos parar a aplicação e, antes de analisar esses números, examinaremos linha a linha o nosso código, em Program.cs.

**Recapitulando**  
Na linha 7, configuramos o endereço do arquivo como "contas.txt" e colocamos esse documento dentro da pasta do executável. Na linha 8, criamos o fluxo de dados para lidar com os dados de pedaço em pedaço.

Na linha 10, criamos nosso byte de 1kB que armazena em um array cada um desses pedaços do arquivo que estamos trabalhando. Um arquivo de texto tem por volta de 20 kB, então não conseguimos armazenar o arquivo inteiro. Em breve, aprenderemos a lidar com trechos desse arquivo.

Na linha 12, usamos o método Read, passando o buffer como parâmetro, para preencher o array da posição 0 até a 1024. Por fim, na linha 14, escrevemos o buffer na tela.

É importante atentarmos ao fato de que estamos lendo 1024 bytes, não o arquivo inteiro, que tem cerca de 20 kB. Não precisamos saber o tamanho exato do arquivo nem criar um array com mais de 20 mil bytes, porque carregaremos o arquivo de trecho em trecho, seguindo o conceito de fluxo de dados.

**O retorno do método Read**  
Ao rodar a aplicação, os números impressos como resultado não fazem muito sentido para nós, parecem números aleatórios. Na verdade, trata-se de uma cadeia de bytes (totalizando 1024) que precisamos transformar em texto.

Na documentação do método Read, descobrimos que ele nos retorna o número total de bytes lidos do buffer. Esse número poderá ser menor que o solicitado, caso essa quantidade de bytes não esteja disponível no momento. Se o final do fluxo for atingido, o retorno será zero.

No caso, estamos trabalhando com 1024 bytes de cada vez, então leremos um valor inferior ao disponível (de cerca de 20 kB). Logo, vamos ler 1024 bytes e exibi-los, depois mais 1024 bytes e assim por diante, até chegar ao final do arquivo. É pouco provável ter uma divisão exata. Supondo que sobrem 10 bytes a serem lidos, eles serão retornados e, na próxima leitura, começaremos a receber o valor 0, pois chegamos ao final do arquivo.

A seguir, vamos desenvolver uma forma de lidar com esse retorno e evitar a exibição de muitos zeros ao terminar o fluxo.

Para tanto, passaremos a armazenar o inteiro retornado pelo Read. No Program.cs, no método Main, criaremos uma variável chamada numeroDeBytesLidos e atribuiremos o valor -1. Como comentamos, o Read retorna apenas valores iguais ou maiores que 0, portanto o -1 não interferirá na nossa sequência de bytes:

```csharp
static void Main(string[] args)
{
        var enderecoDoArquivo = "contas.txt";
        var numeroDeBytesLidos = -1;
        var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open);

        var buffer = new byte[1024]; //1KB

        fluxoDoArquivo.Read(buffer, 0, 1024);

        // Devoluções:
        // 0 número total de bytes lidos do buffer. Isso poderá ser menor que o número de
        // bytes solicitado se esse número de bytes não estiver disponível no momento, ou
        //zero, se o final do fluxo for atingido

        EscreverBuffer(buffer);
        // public override int Read(byte[] array, int offset, int count)

        Console.ReadLine();
}
```

Em seguida, vamos atualizar o número de bytes lidos, conforme o Read. Basta que numeroDeBytesLidos receba o fluxo de arquivo do Read:

```csharp
static void Main(string[] args)
{
        var enderecoDoArquivo = "contas.txt";
        var numeroDeBytesLidos = -1;

        var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open);

        var buffer = new byte[1024]; //1KB

        numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);

        fluxoDoArquivo.Read(buffer, 0, 1024);

        // Devoluções:
        // 0 número total de bytes lidos do buffer. Isso poderá ser menor que o número de
        // bytes solicitado se esse número de bytes não estiver disponível no momento, ou
        //zero, se o final do fluxo for atingido

        EscreverBuffer(buffer);
        // public override int Read(byte[] array, int offset, int count)

        Console.ReadLine();
}
```

Então, vamos ler um arquivo até que ele chegue ao final, ou seja, até que o número de bytes lidos seja igual a 0. Portanto, utilizaremos um laço while. Enquanto o número de bytes for diferente de 0, vamos exibi-los na tela. A partir do momento em que o retorno for 0, não escreveremos mais o buffer:

```csharp
static void Main(string[] args)
{
        var enderecoDoArquivo = "contas.txt";
        var numeroDeBytesLidos = -1;

        var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open);

        var buffer = new byte[1024]; //1KB

        while(numeroDeBytesLidos != 0)
        {
            numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);
            EscreverBuffer(buffer);
        }

        // Devoluções:
        // 0 número total de bytes lidos do buffer. Isso poderá ser menor que o número de
        // bytes solicitado se esse número de bytes não estiver disponível no momento, ou
        //zero, se o final do fluxo for atingido

        // public override int Read(byte[] array, int offset, int count)

        Console.ReadLine();
}
```

Assim, dentro do laço while, temos o fluxo de arquivo e a chamada ao método EscreverBuffer, de modo que apenas exibiremos dados na tela enquanto tivermos bytes a serem mostrados no arquivo.

Ao executar a aplicação, o resultado será a impressão dos bytes até que o final do arquivo. Não teremos o valor 0, porque lemos todo o arquivo dentro do loop.

### Aula 1: Encoding - Vídeo 5

Transcrição  
Por enquanto, quando executamos a nossa aplicação, o resultado no console é uma sequência extensa de números — bytes que representam algum tipo de caractere.

Representado dessa forma, nós não conseguimos ler o conteúdo, não entendemos o que significa a sequência de bytes 50 55 56 32 53 57 55 53 32 52 49 52 49 46 53 53 32, por exemplo. Precisamos decodificar essa cadeia de bytes para obter os caracteres e conseguir ler o arquivo, como uma tradução.

**Tabela ASCII**  
Os bytes possuem um valor que varia de 0 a 255. Como o 0 também é considerado uma possibilidade, então há 256 possibilidades. Será que cada byte representa um caractere? Com 256 opções, será possível representar todos os caracteres que utilizamos, não apenas na língua portuguesa?

Para entender como a decodificação é feita, vamos consultar a tabela ASCII, bastante utilizada no meio da programação. Em linguagens de marcação, como o HTML, é comum referenciarmos tabelas de decodificação.

A tabela ASCII possui o mapeamento de código de 0 a 127, representando vários caracteres do alfabeto latino (como as letras A, B e C — maiúsculas e minúsculas), números e pontuação. A letra A maiúscula, por exemplo, é representada pelo número 65. Isso significa que esse é o valor que será transferido na rede ou armazenado no seu HD para representar a letra A maiúscula. Para o B maiúsculo, temos 66. Para o C, 67.

Por outro lado, há muitos caracteres não representados nessa tabela, como vogais acentuadas e o cedilha da língua portuguesa, ou o N com til da língua espanhola. Ou seja, a tabela ASCII não engloba todos os caracteres possíveis, há diversas outras línguas no mundo que utilizam outros caracteres em seus alfabetos e 256 possibilidades não serão suficientes para cobrir todos eles. Então, como utilizamos os caracteres que não estão presentes na tabela ASCII?

Sabemos que temos 256 possibilidades, então poderíamos pensar em fazer uma combinação de bytes para representar mais caracteres. Entretanto, essa estratégia poderia gerar alguns conflitos no momento da decodificação. Por exemplo, supondo que recebemos 6869, como saberíamos se é uma combinação de bytes ou, respectivamente, as letras D e E da tabela ASCII?

Para evitar esses conflitos, é interessante termos uma tabela de caracteres e que a forma de representação deles, no nosso HD (ou por transferência na rede), use um método diferente do que a mera combinação de bytes. Em outras palavras, o ideal é ter uma equivalência com a tabela ASCII, utilizando um método com o qual o programa entenda o 65 como o A maiúsculo, por exemplo; mas um método diferente do que simplesmente definir um caractere como uma combinação de dois bytes.

**Tabela Unicode**  
É por conta dessa rigidez que não utilizamos somente o ASCII para fazer a decodificação e criou-se a tabela Unicode, que define códigos para mais caracteres. Ela possui mais de 700 possibilidades, o que ainda não contempla todos os códigos existentes, mas certamente abrange mais opções.

Os primeiros 127 caracteres da tabela Unicode respeitam a tabela ASCII, segue-se o mesmo padrão para evitar conflitos. Porém, o Unicode contém mais caracteres. Por exemplo, o 245 representa a letra O com til, um caractere especial que usamos no português.

Trabalhando com ASCII, nós simplesmente armazenamos o 65 para representar o A maiúsculo, por exemplo. No Unicode, o processo é mais complexo. Não basta armazenar o número no HD, ele precisa passar por uma transformação do código Unicode para a forma de representação dentro da aplicação.

Cada um dos códigos da tabela Unicode chama-se code point. Nós representamos os code points e o transformamos com UTF, outro termo bastante comum no meio da programação. O UTF (Unicode Transformation Format) é um protocolo que transforma o caractere de Unicode para a forma de representação na nossa máquina. É o UTF que nos permitirá "traduzir" do Unicode para um texto legível para nós. Vale ressaltar que existem vários formatos: UTF-8, UTF-16, entre outros.

**Decodificando na prática**  
Vamos voltar à nossa aplicação no Visual Studio e começar a implementar essa decodificação, no método EscreverBuffer. O primeiro passo será criar uma variável chamada utf8, em que instanciaremos uma classe UTF8Encoding():

```csharp
// ...

static void EscreverBuffer(byte[] buffer)
{

    var utf8 = new UTF8Encoding();

    foreach (var meuByte in buffer)
    {
        Console.Write(meuByte);
        Console.Write(" ");
    }
}
```

O UTF8Encoding é uma classe abstrata do tipo Encoding que existe no .NET para fazermos essa decodificação. Para utilizá-la, é importante usar a diretiva using System.Text no início do arquivo:

```csharp
using ByteBank_IO;
using System.Text;

class Program
{
    // ...

    static void EscreverBuffer(byte[] buffer)
    {

        var utf8 = new UTF8Encoding();

        foreach (var meuByte in buffer)
        {
            Console.Write(meuByte);
            Console.Write(" ");
        }
    }
}
```

Anteriormente, estávamos imprimindo cada um dos nossos bytes utilizando o foreach. Não precisaremos desse loop por enquanto, então vamos comentá-lo:

```csharp
// ...
static void EscreverBuffer(byte[] buffer)
{
    var utf8 = new UTF8Encoding();
    /*
    foreach (var meuByte in buffer)
    {
        Console.Write(meuByte);
        Console.Write(" ");
    }
    */
}
```

Em seguida, vamos aplicar o UTF no nosso buffer. Assim, em lugar dos bytes, exibiremos a conversão do buffer em um texto. Vamos criar uma variável chamada texto para armazenar o texto do nosso arquivo. Ela trabalhará com o utf8.GetString, que receberá o buffer como parâmetro. Em seguida, exibiremos o resultado com `Console.Write:

```csharp
// ...
static void EscreverBuffer(byte[] buffer)
{
    var utf8 = new UTF8Encoding();
    var texto = utf8.GetString(buffer);
    Console.Write(texto);
    /*
    foreach (var meuByte in buffer)
    {
        Console.Write(meuByte);
        Console.Write(" ");
    }
    */
}
```

Em resumo, o método GetString retorna uma string a partir do UTF, fazendo a conversão. Esse texto será armazenado na variável texto, que exibiremos no console. Ao executar a aplicação, o resultado não será mais aquela longa cadeia de caracteres incompreensíveis. Agora, temos um texto legível, com os dados dos usuários do ByteBank, linha a linha.

Note que usamos o Console.Write e não o Console.WriteLine, que faria a quebra de linha. Apesar disso, o resultado mostra um cliente por linha, porque a quebra de linha também é um caractere! Ou seja, na decodificação, o programa compreende que há quebras de linhas.

Portanto, aprendemos como carregar um documento dentro do nosso programa, como utilizar o fluxo de arquivos para carregar parte por parte do arquivo e como exibir ao usuário o texto decodificado. Na sequência, podemos desenvolver ainda mais o nosso código para trabalhar com esses arquivos.

### Aula 1: Lendo um documento
 Próxima Atividade

Gabriela começou a testar a leitura de arquivos com C# e criou um arquivo “teste.txt”. O conteúdo desse arquivo é "Arquivo para ser lido com código C#". Então, para ler e exibir o documento na tela, criou o código abaixo:

var fs = new FileStream("c:/temp/teste.txt", FileMode.Open);

var buffer = new byte[1024];
var encoding = Encoding.ASCII;

var bytesLidos = fs.Read(buffer, 0, 1024);
var conteudoArquivo = encoding.GetString(buffer, 0, bytesLidos);

```Console.Write(conteudoArquivo);

Contudo, a saída não foi a que ela esperava.

Faça o teste em sua máquina e marque as alternativas corretas quanto ao erro de saída.

Selecione 2 alternativas

Respostas:

Se o arquivo possuísse mais de 1024 bytes, o restante não seria impresso.

> Como não reutilizamos o buffer e nesse caso é feita somente uma chamada ao método Read(), então a saída não traria o final do arquivo!

A saída foi Arquivo para ser lido com c?digo C#.

> O caractere ó não possui representação no encoding ASCII, por isso o resultado da chamada encoding.GetString foi este.

### Aula 1: Faça como eu fiz: abrindo um arquivo de texto

Agora você está preparado para colocar a mão na massa! Entendemos como funcionam os fluxos de dados, o FileStream e o encoding. Vimos o quanto esses assuntos e ferramentas podem nos ajudar a trabalhar com arquivos a ser lidos por uma aplicação, como um arquivo .txt. Vamos colocar isso em prática?

Opinião do instrutor

1 - Você já baixou e abriu o projeto inicial deste curso? Se ainda não o fez, use o [link do repositório](https://github.com/alura-cursos/CsharpArquivos) para começarmos do mesmo ponto!

Nosso objetivo é abrir um arquivo de texto com várias contas e recuperar seu conteúdo em nossa aplicação. Você pode fazer o [download do documento](https://github.com/alura-cursos/CsharpArquivos/archive/refs/heads/main.zip) que estou utilizando no curso.

2 - Crie uma variável para o endereço do arquivo. No curso, escolhemos um diretório relativo ao do executável, ou seja, sem a porção do drive c:\ e os diretórios:

```csharp
var arquivo = "contas.txt";
```

3 - Para criar este fluxo de bytes a partir do nosso arquivo, usaremos um Stream e, mais especificamente, o tipo FileStream! Durante a criação, precisamos indicar o caminho do arquivo e também o modo de operação através do enumerador:

```csharp
var fluxoDoArquivo = new FileStream(arquivo, FileMode.Open);
```

4 - Com a variável fluxoDoArquivo temos uma ponte para o arquivo! Todo Stream lida diretamente com bytes. Não manipulamos os dados diretamente do nosso HD, antes disso é necessário recuperar e armazenar na memória RAM do computador.

Para guardarmos um pequeno trecho do arquivo temporariamente na memória RAM, precisamos criar um buffer - no caso, um array de bytes. No curso, criamos um buffer de 1KB de capacidade:

```csharp
var buffer = new byte[1024];
```

5 - Buffer e stream criados, hora de ler o arquivo! Para isso, usamos o método Stream::Read, passamos o buffer como argumento e dizemos ao Read qual índice ele pode usar para começar a gravar informações e quantos bytes ele pode gravar no máximo.

No caso, queremos que o Stream use nosso buffer a partir do índice 0 e guarde 1024 bytes nele:

```csharp
fluxoDoArquivo.Read(buffer, 0, 1024);
```

6 - Para acompanhar o que foi lido, criamos um método chamado EscreverBuffer():

```csharp
static void EscreverBuffer(byte[] buffer)
{
    foreach(var meuByte in buffer)
    {
        Console.Write(meuByte);
        Console.Write(" ");
    }
}
```

7 - O método Read() retorna um int indicando quantos bytes foram guardados no buffer. Este número está sempre no intervalo de 0 até o número de bytes que pedimos para o stream ler (1024 nesta chamada). Ao atingir o final do arquivo, o retorno do método será 0.

Para ler o documento até o fim, vamos usar um while que verifica quando o Read retornou 0:

```csharp
var quantidadeBytesLidos = -1;
while(quantidadeBytesLidos != 0)
{
    quantidadeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);
    EscreverBuffer(buffer);
}
```

8 - Execute a aplicação. Você notará uma saída com vários números sem muito significado para nós. O objetivo então é interpretar estes bytes como texto. O processo de transformação de uma cadeia de bytes para algo com outro significado é a decodificação.

Para realizar a decodificação e a codificação no .NET, temos a classe Encoding. Vamos alterar o método EscreverBuffer() para utilizar o encoding UTF-8:

```csharp
static void EscreverBuffer(byte[] buffer)
{
    var encoding = new UTF8Encoding();
    var texto = encoding.GetString(buffer);

    Console.Write(texto);
}
```

Executando a aplicação agora teremos a saída que esperamos: o texto contido no documento.

Criamos manualmente uma instância de Encoding com o código new UTF8Encoding(), mas podemos utilizar o membro estático Encoding.UTF8 para isso!

### Aula 1: O que aprendemos?

Nessa aula, você aprendeu:

- Como lidar com arquivos grandes e maiores que a RAM do computador, como filmes e vídeos;
- O que são Streams, classes que nos ajudam a exibir uma sequência de bytes;
- A usar o método Read() e buffers para ler arquivos dessa forma;
- Unicode e encoding UTF entendendo como eles podem nos ajudar nesse processo de decodificação de um arquivo.

## Aula 2: FileStream e leitor StreamReader

### Aula 2: Projeto da aula anterior

Você pode baixar os códigos que desenvolvemos até agora em [zip neste link](https://github.com/alura-cursos/CsharpArquivos/archive/refs/heads/aula-1.zip) ou acessar o repositório da [aula no GitHub!](https://github.com/alura-cursos/CsharpArquivos/tree/aula-1)

### Aula 2: Close e Using - Vídeo 1

Transcrição  
Já estudamos o conceito de fluxo de dados e aprendemos a decodificar um arquivo. Se antes recebíamos apenas uma sequência de números (que descobrimos serem bytes representando caracteres), agora conseguimos exibir uma mensagem compreensível na tela, em texto.

Vamos continuar avançando nos estudos!

**Liberação do arquivo**  
Quando terminamos de usar um arquivo, é interessante informar ao sistema operacional que aquele arquivo está liberado para sofrer modificações. Para esclarecer essa ideia, vamos rodar nossa aplicação.

Ao executá-la, é possível ler os dados de todos os clientes no console. Por exemplo, sabemos que a cliente Fátima tem uma conta de número 2219, na agência 426, com saldo de R$4813,73. Ou seja, conseguimos ler o arquivo.

Vamos minimizar o console, porém não vamos parar a aplicação ainda. Em vez disso, abriremos o gerenciador de soluções — basta usar o atalho "Ctrl + Alt + L" ou selecionar "Exibir > Gerenciador de Soluções" no menu superior do Visual Studio.

O gerenciador será aberto na lateral direita da IDE, então clicaremos com o botão direito do mouse sobre a nossa solução e selecionaremos "Abrir Pasta no Gerenciador de Arquivos", para acessar a pasta do nosso projeto. Em seguida, vamos navegar até "ByteBank_IO > bin > Debug > net6.0". Nessa pasta, encontraremos o executável e o documento contas.txt.

Ao tentar renomear o arquivo contas.txt para contas2.0, surgirá um aviso na tela:

"A ação não pode concluída porque o arquivo está aberto em ByteBank_IO".

Por mais que já tenhamos decodificado e mostrado todo o conteúdo do arquivo para o usuário, o sistema operacional não entendeu que o arquivo já está liberado para outros fins, por exemplo, ser renomeado ou movido. Portanto, vamos cancelar a operação, fechar o gerenciador de arquivos e parar a aplicação. A seguir, aprenderemos como informar ao sistema quando o arquivo está liberado para outros usos.

**O método Close**  
Anteriormente, usamos o Read para ler o nosso buffer. Agora, utilizaremos outro método associado ao fluxo de arquivos: o Close. Após exibir o buffer ao usuário, informaremos ao sistema operacional que o arquivo pode ser fechado, pois já realizamos o que queríamos. Em Main, após a leitura dos dados, vamos inserir fluxoDoArquivo.Close():

```csharp
static void Main(string[] args)
{
    var enderecoDoArquivo = "contas.txt";
    var numeroDeBytesLidos = -1;

    var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open);

    var buffer = new byte[1024]; //1KB      

    while(numeroDeBytesLidos != 0)
    {
        numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);
        EscreverBuffer(buffer);
    }     

    // Devoluções:
    //  O número total de bytes lidos do buffer. Isso poderá ser menor que o número de
    //  bytes solicitado se esse número de bytes não estiver disponível no momento, ou
    //  zero, se o final do fluxo for atingido

    // public override int Read(byte[] array, int offset, int count);
    fluxoDoArquivo.Close();
    Console.ReadLine();
}
```

Com o método Close(), informamos que já fechamos o arquivo e podemos permitir modificações.

Para testar, repetiremos o processo que fizemos há pouco. Vamos executar a aplicação, minimizar o console, mas ainda não parar a execução. No gerenciador de soluções ("Ctrl + Alt + L"), clicaremos com o botão direito sobre a solução e selecionaremos "Abrir Pasta no Gerenciador de Arquivos". Navegaremos até "ByteBank_IO > bin > Debug > net6.0", onde encontraremos o executável e o documento contas.txt. Por fim, vamos renomear contas.txt para contas2.0.

Dessa vez, conseguimos alterar o nome do arquivo! Ou seja, o método Close funcionou, informando ao sistema operacional que o arquivo já foi utilizado e é permitido modificá-lo.

Vamos renomear o documento para contas.txt novamente, para não causar conflitos no nosso projeto. Em seguida, podemos fechar o gerenciador de arquivos e parar a aplicação.

**Exceções e o método using**  
Quando trabalhamos com arquivos, o método Close é obrigatório, pois precisamos informar ao sistema que o arquivo já foi utilizado e pode ser liberado. Contudo, é essencial atentarmos às exceções.

Caso ocorra uma exceção e ela não seja tratada, isso pode afetar a chamada do método Close, de modo que o arquivo não será liberado. A seguir, vamos pensar em soluções para tratar possíveis exceções.

Estudamos exceções e como tratá-las no curso "C#: entendendo exceções". Caso você não tenha familiaridade com o assunto, recomendamos assistir ao curso mencionado ou acessar o material complementar disponibilizado na plataforma.

Ter o fluxoDoArquivo nulo seria um exemplo de exceção. Para tratá-la, poderíamos usar um bloco try/catch/finally junto de algumas estruturas if/else para verificar se o fluxo é nulo ou não, porém esse processo seria um tanto complexo.

Para tratar exceções complexas, uma boa opção é usar o padrão do using. Vale lembrar que o using tem uma condição para ser aplicado: ele funciona com objetos que implementam uma interface IDisposable. Ao examinar o FileStream, reparamos que ele implementa essa interface, então podemos usar o using nesse caso!

Após a variável enderecoDoArquivo, vamos utilizar o bloco using para verificar se fluxoDoArquivo não é nulo. Em seguida, vamos mover o restante do código de Main para dentro dele:

```csharp
static void Main(string[] args)
{
    var enderecoDoArquivo = "contas.txt";
    using (var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
    {
        var numeroDeBytesLidos = -1;

        var buffer = new byte[1024]; //1KB      

        while (numeroDeBytesLidos != 0)
        {
                numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);
                EscreverBuffer(buffer);
        }

        // Devoluções:
        //  O número total de bytes lidos do buffer. Isso poderá ser menor que o número de
        //  bytes solicitado se esse número de bytes não estiver disponível no momento, ou
        //  zero, se o final do fluxo for atingido


        // public override int Read(byte[] array, int offset, int count);
        fluxoDoArquivo.Close();

        Console.ReadLine();
    }
}
```

Em seguida, repetiremos nossos testes para nos certificar de que tudo está funcionando como esperado. Vamos executar a aplicação e minimizar o console. Sem parar a execução, abriremos o gerenciador de soluções, clicaremos com o botão direito sobre a solução e selecionaremos "Abrir Pasta no Gerenciador de Arquivos". Em seguida, vamos navegar até "ByteBank_IO > bin > Debug > net6.0". Por fim, vamos renomear contas.txt para contas2.0.

Conseguimos renomear, o que significa que o método Close continua funcionando! Vamos renomear o arquivo para contas.txt novamente, para não causar problemas no projeto. Depois, podemos fechar o gerenciador de arquivos e parar a aplicação.

Em suma, o método using criará um try/catch para verificar se o fluxo é nulo. Caso não seja, chamaremos o método Dispose, que internamente chamará o método Close. Assim, conseguimos evitar que futuras exceções ocorram e prejudiquem o andamento do código.

Portanto, informamos ao sistema operacional quando o arquivo pode ser liberado para uso e tratamos exceções que poderiam ocorrer e prejudicar o uso do método Close.

### Aula 2: Trabalhando com Buffers - Vídeo 2

Transcrição  
Agora, vamos comparar o conteúdo do nosso arquivo contas.txt com o que é mostrado no console, para verificar se a aplicação está exibindo os dados corretamente. Para fazer essa comparação, vamos abrir o arquivo contas.txt no Bloco de Notas e deixá-lo na parte direita da nossa tela. Em seguida, rodaremos a aplicação no Visual Studio e posicionaremos o console à esquerda da tela.

Como são muitos clientes, é válido apenas verificar se o início e o fim dessas listas são coerentes uma com o outra. Tanto no console quanto no arquivo contas.txt, os cinco primeiros clientes são:

```Console
375 4644 2483.13 Jonatan
234 4020 2822.52 Debora
316 3254 3350.37 Leonardo
208 7473 2615.14 Angela
348 5296 2686.03 Charles
```

O início das listas corresponde, então vamos checar o final delas. No console, temos:

```Console
240 3705 795.56 Julio
397 8270 907.50 Marcela
408 2132 2294.76 Milt
```

Porém, em contas.txt, temos:

```Console
150 3752 1361.72 Priscila
332 8365 1199.58 Joel
223 1223 1833.99 Josiane
```

As listas não correspondem! Porém, se subirmos na lista do console, encontraremos a sequência de clientes Priscila, Joel e Josiane que temos no final do Bloco de Notas. Parece que alguns dados estão sendo duplicados no console.

Vamos minimizar o arquivo contas.txt e parar a aplicação. A seguir, vamos entender o que aconteceu e como resolver essa questão.

**Por que temos dados duplicados?**  
Em Program.cs, no método Main, criamos o buffer, aplicamos a classe FileStream e o método Read, indicando 0 como índice inicial e o uso de 1024 posições (1 kB). Como comentamos, nem sempre as 1024 serão ocupadas em um fluxo, por isso, definimos os numerosDeBytesLidos — a partir do momento em que não há mais nada a ser lido, o retorno será 0 e saberemos que chegamos ao final do arquivo. Já o método EscreverBuffer é responsável por exibir o nosso buffer no console, utilizando UTF8Encoding.

Ao chegar ao final do arquivo, o fluxo não altera o buffer. Os valores desse array continuam os mesmos depois que chamamos esse método. Quando utilizamos o EscreverBuffer e o fluxo tem menos de 1024 posições para serem ocupadas, as posições necessárias serão ocupadas e as restantes vão manter seus valores anteriores.

Em outras palavras, paramos de preencher o buffer quando chegamos ao final do arquivo e ignoramos que, no resto desse array, há informações que já estavam lá anteriormente. Como essas informações foram mantidas, dados duplicados serão exibidos.

Para esclarecer essa questão, vamos visualizar algumas informações na tela. No laço while, antes de chamar o método EscreverBuffer, vamos inserir um Console.WriteLine para exibir o número de bytes lidos:

```csharp
static void Main(string[] args)
{

    var enderecoDoArquivo = "contas.txt";

    using (var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
    {
        var numeroDeBytesLidos = -1;

        var buffer = new byte[1024]; //1KB      

        while (numeroDeBytesLidos != 0)
        {
                numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);
                Console.WriteLine($"Bytes lidos: {numeroDeBytesLidos}");
                EscreverBuffer(buffer);
        }

        // Devoluções:
        //  O número total de bytes lidos do buffer. Isso poderá ser menor que o número de
        //  bytes solicitado se esse número de bytes não estiver disponível no momento, ou
        //  zero, se o final do fluxo for atingido

        // public override int Read(byte[] array, int offset, int count);
        fluxoDoArquivo.Close();

        Console.ReadLine();
    }
}
```

Toda vez que passarmos por 1024 posições, mostraremos o número de bytes lidos. Assim, entenderemos melhor quais são as posições que não estamos preenchendo. Ao rodar a aplicação e analisar o resultado no console, encontraremos algumas linhas com o texto "Bytes lidos: 1024". Em dado momento, teremos "Bytes lidos: 584" e, depois, "Bytes lidos: 0", porque as informações passaram a ser repetidas.

Em resumo, temos um buffer de 1024 posições e lemos apenas 584 delas. Logo, sobraram 440 posições que mantiveram o valor antigo. Em outras palavras, estamos reescrevendo dados antigos na tela, processando o mesmo valor duas vezes, o que é desnecessário.

Vamos parar a nossa aplicação e, na sequência, pensaremos numa solução.

**Buscando uma solução**  
Além do buffer, seria interessante informar ao método EscreverBuffer a quantidade de bytes lidos, isto é, a quantidade de posições que foram ocupadas. Dessa forma, podemos melhorar o nosso código e exibir o conteúdo real do arquivo, sem elementos duplicados.

No método EscreverBuffer, passaremos um novo argumento: um número inteiro que será os bytesLidos. A partir de agora, o método saberá o momento de começar e de parar o encoding e ele conseguirá distinguir até que posição é seguro ler e "traduzir" os bytes para string.

No caso, delegamos essa tradução ao método GetString, então vamos explorar sua estrutura, a seguir:

```csharp
public virtual string GetString(byte[] bytes, int index, int count);
```

Nessa sobrecarga do método GetString, além do buffer, conseguimos passar informações do índice em que a decodificação deve ser iniciada e a quantidade de bytes que devem ser lidos e exibidos.

Até agora, passamos o buffer de forma completa, mas chega um momento em que informações que já estavam guardadas não são substituídas e acabam sendo impressas novamente. Então, é interessante mudarmos a maneira como estamos usando o GetString. Vamos adicionar esses dois novos argumentos ao GetString, de modo que o método mostre o buffer a partir do início (índice 0) até a posição em que novos bytes foram lidos:

```csharp
static void EscreverBuffer(byte[] buffer, int bytesLidos)
{
    var utf8 = new UTF8Encoding();
    var texto = utf8.GetString(buffer, 0, bytesLidos);
    //public virtual string GetString(byte[] bytes, int index, int count);
    Console.Write(texto);
    /*
    foreach (var meuByte in buffer)
    {
            Console.Write(meuByte);
            Console.Write(" ");
    }
    */
}
```

Ao chamar o EscreverBuffer no método Main, também precisamos passar o numeroDeBytesLidos:

```csharp
static void Main(string[] args)
{
    var enderecoDoArquivo = "contas.txt";
    using (var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
    {
        var numeroDeBytesLidos = -1;
        var buffer = new byte[1024]; //1KB      
        while (numeroDeBytesLidos != 0)
        {
                numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);

                EscreverBuffer(buffer, numeroDeBytesLidos);

                Console.WriteLine($"Bytes lidos: {numeroDeBytesLidos}");

        }

        // Devoluções:
        //  O número total de bytes lidos do buffer. Isso poderá ser menor que o número de
        //  bytes solicitado se esse número de bytes não estiver disponível no momento, ou
        //  zero, se o final do fluxo for atingido

        // public override int Read(byte[] array, int offset, int count);
        fluxoDoArquivo.Close();
        Console.ReadLine();
    }
}
```

Dessa forma, o GetString não decodificará o buffer de 0 até 1024, mas de 0 até a posição de bytes lidos. Por exemplo, tínhamos 584 bytes novos na última leitura, então a decodificação será de 0 a 584, sem informações repetidas.

Para testar, vamos rodar a nossa aplicação e comparar o resultado no console com o nosso arquivo contas.txt, lado a lado. Em ambos, os três últimos clientes são Priscila, Joel e Josiane. Agora, as listas são coerentes entre si. Conseguimos ler os 584 bytes e as 440 posições sobressalentes não são mais impressas, porque informamos ao GetString até que posição mostrar.

Assim, aprimoramos nosso código e estamos exibindo os dados corretamente.

### Aula 2: Organizando nosso código - Vídeo 3

Transcrição  
Nesta aula, focaremos em organizar o nosso projeto. Vamos aprender a separar nosso código em diversos arquivos, para facilitar futuras consultas.

**Novo arquivo de código**  
De início, vamos abrir o gerenciador de soluções — basta usar o atalho "Ctrl + Alt + L" ou acessar "Exibir > Gerenciador de Soluções" no menu superior da IDE. O gerenciador será aberto na lateral direita do Visual Studio. Nele, podemos visualizar nossas classes e dependências. Vamos clicar com o botão direito sobre o projeto "Bytebank_IO" e selecionar "Adicionar > Novo Item...".

Uma nova janela será aberta, com a interface dividida em três colunas. À esquerda, temos as seguintes opções:

```Console
Instalados
Itens do Visual C#
Código
Dados
Geral
Web
AppNetCore
Online
```

Selecionaremos a opção "Instalados > Itens do Visual C# > Código". Na coluna central, temos as seguintes opções:

```Console
Classe
Interface
```

Selecionaremos "Arquivo de Código". Na parte inferior, vamos alterar o nome do arquivo de CodeFile1.cs para 1_LidandoComFileStreamDiretamente.cs. Optamos por esse nome porque ao longo do curso aprendemos a lidar com o fluxo de dados de forma mais direta, trabalhando com buffer, bytes e decodificação de bytes. Colocamos o número 1 no início apenas para manter uma ordem.

Por fim, vamos clicar no botão "Adicionar" no canto direito inferior da janela. Assim, inserimos um novo arquivo de código no nosso projeto.

Inicialmente, ele estará vazio. Vamos copiar todo o código de Program.cs para ele:

```csharp
using ByteBank_IO;
using System.Text;
class Program
{
    static void Main(string[] args)
    {

        var enderecoDoArquivo = "contas.txt";

        using (var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
        {
            var numeroDeBytesLidos = -1;

            var buffer = new byte[1024]; //1KB      

            while (numeroDeBytesLidos != 0)
            {
                numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);

                EscreverBuffer(buffer, numeroDeBytesLidos);

                //Console.WriteLine($"Bytes lidos: {numeroDeBytesLidos}");

            }

            // Devoluções:
            //  O número total de bytes lidos do buffer. Isso poderá ser menor que o número de
            //  bytes solicitado se esse número de bytes não estiver disponível no momento, ou
            //  zero, se o final do fluxo for atingido

            // public override int Read(byte[] array, int offset, int count);
            fluxoDoArquivo.Close();

            Console.ReadLine();
        }
    }

    static void EscreverBuffer(byte[] buffer, int bytesLidos)
    {

        var utf8 = new UTF8Encoding();

        var texto = utf8.GetString(buffer, 0, bytesLidos);

        //public virtual string GetString(byte[] bytes, int index, int count);

        Console.Write(texto);

        /*
        foreach (var meuByte in buffer)
        {
            Console.Write(meuByte);
            Console.Write(" ");
        }
        */
    }

}
```

Em seguida, vamos fazer algumas alterações. O método chamado Main deve ficar no Program.cs, então nesse arquivo vamos renomeá-lo de Main para LidandoComFileStreamDiretamente, porque essa é a descrição do que o método faz:

```csharp
// ...

static void LidandoComFileStreamDiretamente()
{

    var enderecoDoArquivo = "contas.txt";

    using (var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
    {
        var numeroDeBytesLidos = -1;

        var buffer = new byte[1024]; //1KB      

        while (numeroDeBytesLidos != 0)
        {
            numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);

            EscreverBuffer(buffer, numeroDeBytesLidos);

            //Console.WriteLine($"Bytes lidos: {numeroDeBytesLidos}");

        }

        // Devoluções:
        //  O número total de bytes lidos do buffer. Isso poderá ser menor que o número de
        //  bytes solicitado se esse número de bytes não estiver disponível no momento, ou
        //  zero, se o final do fluxo for atingido

        // public override int Read(byte[] array, int offset, int count);
        fluxoDoArquivo.Close();

        Console.ReadLine();
    }
}
// ...
```

Na linha 4, a classe Program está sublinhada em vermelho e o compilador alega que há um problema nesse trecho. Posicionando o cursor sobre a palavra Program, o Visual Studio exibe a mensagem "O namespace já contém uma deifinição para 'Program'". Esse conflito acontece porque já estávamos trabalhando com a classe Program no arquivo Program.cs. Precisamos informar ao compilador que isso é permitido e queremos lidar com essas classes como se fossem um elemento só, elas apenas serão trabalhadas em arquivos diferentes.

De início, vamos remover todo o código de Program.cs, mantendo apenas o método Main com um `Console.ReadLine:

```csharp
using ByteBank_IO;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.ReadLine();
    }
}
```

Em seguida, vamos descobrir como solucionar o problema da classe Program.

O partial  
Na linha 4 do arquivo LidandoComFileStreamDiretamente.cs, passaremos a trabalhar com o partial:

```csharp
partial class Program
```

Faremos o mesmo na linha 4 do arquivo Program.cs:

```csharp
partial class Program
```

Quando compilarmos e executarmos a aplicação, o programa entenderá que a classe Program está em vários arquivos e pode ser trabalhada de uma forma única. Ela está separada apenas por questões de organização.

Desse modo, o partial tornará o código mais simples e mais legível, tanto para nós quanto para outras pessoas programadoras que consultem nosso projeto, pois conseguimos dividir nossa classe para lidar com diferentes métodos em diferentes arquivos.

Agora, podemos desenvolver mais códigos sem que haja excesso de informações na tela. Na sequência, aprenderemos a usar mais ferramentas que o C# nos oferece.

### Aula 2: Para saber mais: quando usar partial?

Neste curso estamos trabalhando sempre na classe Program para criar nossos métodos. Para não termos um arquivo de código gigante em que seja difícil encontrar o que queremos, dividimos a classe em vários arquivos com o modificador partial.

Mas será que essa é uma boa prática? Se trabalhamos com uma classe tão grande a ponto de ser difícil encontrar o que desejamos, esse é sinal de que a classe possui responsabilidades demais! Será que o correto não seria dividi-la e distribuir as responsabilidades?

Com certeza! Então, por que o C# possui o modificador partial, se isso parece uma má prática?

Será comum encontrarmos geradores de código, ou seja, programas que geram código C# para nós. Por exemplo, um programa que abre uma planilha Excel e cria um modelo.

Para o arquivo ContaCorrente.xls abaixo:

```Console
+---------+-----------------+--------+
| Agencia | Número da Conta | Saldo  |
+---------+-----------------+--------+
| 486     | 234552          | 231.50 |
+---------+-----------------+--------+
| 424     | 432425          | 523.23 |
+---------+-----------------+--------+
```

Um gerador de código pode inferir os tipos de cada coluna e gerar a classe abaixo para nós:

```csharp
// Arquivo "ContaCorrente.cs" gerado automaticamente
class ContaCorrente
{
    public int Agencia { get; set; }
    public int NumeroDaConta { get; set; }
    public double Saldo { get; set; }
}
```

Os métodos para sacar, depositar e transferir devem ser escritos por nós! Então a partir do arquivo gerado, adicionamos esses métodos:

```csharp
// Arquivo "ContaCorrente.cs" gerado automaticamente
class ContaCorrente
{
    public int Agencia { get; set; }
    public int NumeroDaConta { get; set; }
    public double Saldo { get; set; }

    public void Sacar(double valor) { ... }
    public void Depositar(double valor) { ... }
    public void Transferir(ContaCorrente destino, double valor) { ... }
}
```

Opa, mas recebemos uma nova planilha e devemos gerar uma nova classe a partir da planilha atualizada:

```Console
+---------+-----------------+--------+-------------------+
| Agencia | Número da Conta | Saldo  | Limite de crédito |
+---------+-----------------+--------+-------------------+
| 486     | 234552          | 231.50 |      1000.00      |
+---------+-----------------+--------+-------------------+
| 424     | 432425          | 523.23 |      1200.00      |
+---------+-----------------+--------+-------------------+
```

E então o gerador irá criar um novo documento ContaCorrente.cs:

```csharp
// Arquivo "ContaCorrente.cs" gerado automaticamente
class ContaCorrente
{
    public int Agencia { get; set; }
    public int NumeroDaConta { get; set; }
    public double Saldo { get; set; }
    public double LimiteDeCredito { get; set; }
}
```

Com isso perdemos o nosso trabalho! Mas se o gerador criar uma classe com o modificador partial, podemos separar nosso código em outro arquivo e atualizá-lo sem medo de perder nosso trabalho:

```csharp
// Arquivo "ContaCorrente.cs" gerado automaticamente
partial class ContaCorrente
{
    public int Agencia { get; set; }
    public int NumeroDaConta { get; set; }
    public double Saldo { get; set; }
    public double LimiteDeCredito { get; set; }
}
```

e

```csharp
// Arquivo "ContaCorrente_metodos.cs" gerado por nós!
partial class ContaCorrente
{
    public void Sacar(double valor) { ... }
    public void Depositar(double valor) { ... }
    public void Transferir(ContaCorrente destino, double valor) { ... }
}
```

### Aula 2: StreamReader - Vídeo 4

Transcrição  
Agora que dividimos a classe Program em arquivos distintos, temos uma estrutura mais organizada para trabalhar o projeto. Nosso próximo objetivo será desenvolver um código sem complicações ao lidar com buffer e suas limitações, nos poupando da necessidade de sempre escrever todo o fluxo de arquivos, como fizemos em aulas passadas.

No momento, o arquivo Program.cs está praticamente vazio:

```csharp
using ByteBank_IO;
using System.Text;

partial class Program
{
    static void Main(string[] args)
    {
        Console.ReadLine();
    }
}
```

Vamos começar com um código parecido com o que fizemos anteriormente. Criaremos uma variável chamada enderecoDoArquivo para guardar o endereço do arquivo:

```csharp
using ByteBank_IO;
using System.Text;

partial class Program
{
    static void Main(string[] args)
    {
        var enderecoDoArquivo = "contas.txt";
        Console.ReadLine();
    }
}
```

Em seguida, trabalharemos com o using para tratar as possíveis exceções que podem ocorrer futuramente, verificando se o fluxo de dados não é nulo:

```csharp
using ByteBank_IO;
using System.Text;

partial class Program
{
    static void Main(string[] args)
    {
        var enderecoDoArquivo = "contas.txt";

        using(var fluxoDeArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
        {

        }
        Console.ReadLine();
    }
}
```

Dentro do bloco using, vamos desenvolver um código para visualizarmos o arquivo. Exploraremos quais ferramentas do C# podemos usar em nosso favor para exibir o conteúdo do arquivo de uma forma mais simples para o usuário.

**O StreamReader**  
O StreamReader é uma classe intermediária que fará toda a manipulação de bytes e a leitura do nosso stream. Ela conta com alguns recursos para ler uma linha específica, fragmentos ou o arquivo inteiro.

O primeiro passo será criar uma variável, que chamaremos de leitor. Essa variável receberá um new StreamReader que, por sua vez, receberá nosso fluxoDeArquivo:

```csharp
using ByteBank_IO;
using System.Text;

partial class Program
{
    static void Main(string[] args)
    {
        var enderecoDoArquivo = "contas.txt";

        using(var fluxoDeArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
        {
            var leitor = new StreamReader(fluxoDeArquivo);
        }
        Console.ReadLine();
    }
}
```

O StreamReader permite usar diversas ferramentas. Por ora, vamos explorar o uso de:

```console
ReadLine
ReadToEnd
Read
EndOfStream
```

**O método ReadLine**  
O ReadLine, como o nome sugere, lerá uma linha do arquivo. Vamos começar criando uma variável chamada linha, que receberá leitor.ReadLine(). Em seguida, usaremos o Console.WriteLine para exibir o que foi lido:

```csharp
using ByteBank_IO;
using System.Text;

partial class Program
{
    static void Main(string[] args)
    {
        var enderecoDoArquivo = "contas.txt";

        using(var fluxoDeArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
        {
            var leitor = new StreamReader(fluxoDeArquivo);

            var linha = leitor.ReadLine();

            Console.WriteLine(linha);
        }
        Console.ReadLine();
    }
}
```

Como não especificamos, o leitor.ReadLine selecionará a primeira linha no nosso arquivo e armazenará essa string na variável linha, que será mostrada no console. Ao executar a aplicação, o resultado será:

375 4644 2483.13 Jonatan

Assim, o ReadLine mostrou a primeira linha de contas.txt sem precisarmos trabalhar com buffer e decodificação de bytes.

**O método ReadToEnd**  
Vamos comentar a variável linha e, na sequência, aprenderemos como mostrar o arquivo completo.

Criaremos uma variável chamada texto, que receberá leitor.ReadToEnd(). Em seguida, vamos alterar o parâmetro passado ao Console.WriteLine de linha para `texto´:

```csharp
using ByteBank_IO;
using System.Text;

partial class Program
{
    static void Main(string[] args)
    {
        var enderecoDoArquivo = "contas.txt";

        using(var fluxoDeArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
        {
            var leitor = new StreamReader(fluxoDeArquivo);

            //var linha = leitor.ReadLine();

            var texto = leitor.ReadToEnd()

            Console.WriteLine(texto);
        }
        Console.ReadLine();
    }
}
```

Ao executar a aplicação, o resultado será todo o conteúdo do documento de texto. Com o método ReadToEnd, conseguimos fazer a leitura do arquivo sem precisar lidar com buffer e decodificação de bytes.

Contudo, há uma ressalva. Anteriormente, quando trabalhamos com buffer de 1024 bytes, a ideia era evitar o carregamento de arquivos grandes de uma única vez, o que pode ser prejudicial em termos de memória. No caso, contas.txt é pequeno, então conseguimos carregá-lo por completo sem muita complexidade, mas poderíamos ter problemas com arquivos maiores.

Portanto, o problema do ReadToEnd é que carregamos o arquivo de uma única vez. Se ele for extenso, essa prática pode não ser a melhor opção. Mas, nesses casos, podemos usar outras estratégias.

**O método Read**  
Vamos comentar a variável texto e, na sequência, explorar o uso do método Read.

Criaremos uma variável chamada numero, que receberá leitor.Read(). Em seguida, vamos alterar o parâmetro passado ao Console.WriteLine de texto para numero:

```csharp
using ByteBank_IO;
using System.Text;

partial class Program
{
    static void Main(string[] args)
    {
        var enderecoDoArquivo = "contas.txt";

        using(var fluxoDeArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
        {
            var leitor = new StreamReader(fluxoDeArquivo);

            //var linha = leitor.ReadLine();

            //var texto = leitor.ReadToEnd()

            var numero = leitor.Read();

            Console.WriteLine(numero);
        }
        Console.ReadLine();
    }
}
```

Então, vamos compilar e executar nosso projeto. No console, o resultado será:

51

O Read traz o primeiro caractere em byte, que depois seria decodificado.

**A propriedade EndOfStream**  
Vamos comentar a variável numero e, na sequência, estudaremos outra ferramenta do C#.

O EndOfStream é um recurso interessante para trabalhar o conceito de fluxo de arquivos, para ler o documento de parte em parte. Ele reconhece onde é o fim de um fluxo e, aliado ao ReadLine, somos capazes de fazer a leitura de um arquivo sem precisar carregá-lo todo de uma vez. Em lugar disso, carregaremos linha a linha. Para esclarecer esse processo, vamos colocar na prática.

Criaremos um laço while com a condição !leitor.EndOfStream:

```csharp
using ByteBank_IO;
using System.Text;

partial class Program
{
    static void Main(string[] args)
    {
        var enderecoDoArquivo = "contas.txt";

        using(var fluxoDeArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
        {
            var leitor = new StreamReader(fluxoDeArquivo);

            //var linha = leitor.ReadLine();

            //var texto = leitor.ReadToEnd()

            //var numero = leitor.Read();

            while (!leitor.EndOfStream)
            {
                var linha = leitor.ReadLine();
                Console.WriteLine(linha)
            }

        }
        Console.ReadLine();
    }
}
```

Em português, a expressão end of stream significa "fim do fluxo". Já o ponto de exclamação é usado para a negação. Ou seja, enquanto não chegarmos ao final do fluxo, vamos ler uma linha e a exibir ao usuário.

Ao executar a aplicação, teremos no console a lista completa do arquivo contas.txt. Apesar de o resultado ser igual ao que obtivemos com ReadToEnd, o processo foi diferente. Dessa vez, os dados não foram decodificados e impressos de uma única vez, mas linha a linha. Assim, retomamos o conceito que estudamos no começo do curso de não trabalhar com um arquivo inteiro de uma vez. Para arquivos grandes que podem consumir bastante memória, essa estratégia é muito útil.

**Recapitulando**  
Nesta aula, exploramos alguns recursos da classe StreamReader:

ReadLine para ler uma linha

- ReadToEnd para ler o arquivo por completo, carregando-o de uma única vex
- Read para ler o primeiro byte do arquivo
- EndOfStream para ler e exibir um arquivo até que o fluxo chegue ao fim

Apesar de utilizarmos esses métodos, vale ressaltar que eles realizam o mesmo processo que fizemos anteriormente — trabalham com buffer, decodificação de bytes e UTF8 —, porém trazem facilidades na hora de programar.

### Aula 2: Para saber mais: exceções

Vamos relembrar e resumir um pouco o que são exceções e como podemos tratá-las.

É interessante sempre ter em mente que as exceções derivam de Exception. Para lançar nossas exceções temos o bloco try-catch. Então, quando encontramos alguma exceção no código contido no bloco try, o fluxo de controle vai para o primeiro manipulador catch, de exceção associada, que está presente em um lugar qualquer da pilha de chamadas.

Caso nenhum manipulador de exceção correspondente seja encontrado no bloco catch, o programa é interrompido devolvendo um erro ao usuário.

É importante detectar uma determinada exceção desde que saibamos trabalhar com ela. Quando capturamos uma Exception no C#, devemos relançá-la usando a palavra reservada throw no fim do bloco catch.

Se o bloco catch define uma variável de exceção, usamos o Message, o StackTrace e o InnerException, por exemplo, para encontrar mais detalhes do erro.

Um bloco finally pode ser utilizado, sendo sempre executado independentemente de uma exceção ser gerada.

Há um termo muito utilizado na computação para se referir especificamente a uma sintaxe para simplificar construções dentro da aplicação. O nome é syntax sugar (açúcar sintático, em português), que vem da ideia de deixar a linguagem “mais doce” de ser estudada.

A syntax sugar existe em diversas linguagens. No C# nós temos o using, palavra reservada que garante a disposição correta de alguns objetos.

### Aula 2: Stream para um arquivo - Execício

Pedro criou o arquivo "nomes.txt" abaixo:

```console
Jonatan Debora Leonardo Angela Charles Rosane Marcio
Samara Joao Joana Jorge Nair Danilo Celia Mauro
Isabel Valdir Jaqueline Rodrigo Tereza Marcio Nair
Israel Luana Nilson Aline Michel Vitoria Paulo
Neusa Edivaldo Marli Manuel Michele
```

Com isso, o objetivo dele é recuperar todos os nomes e adicioná-los em uma lista. Para tal, ele usou o código abaixo:

```csharp
using(var fs = new FileStream("c:/temp/nomes.txt", FileMode.Open))
{
    var buffer = new byte[128]; // Buffer de 128 bytes
    var encoding = Encoding.UTF8;

    var bytesLidos = -1;

    while(bytesLidos != 0)
    {
        bytesLidos = fs.Read(buffer, 0, 128);
        var conteudo = encoding.GetString(buffer, 0, 128);
        Console.Write(conteudo);
    }
}
```

Porém, será que o código está correto?

Marque as alternativas corretas quanto ao código de Pedro.

Selecione 3 alternativas

Respostas:

Alternativa correta  
O bloco using faz a chamada para o método Dispose(), que chama o Close().

> Usando este padrão, não será necessário chamar o método Close() manualmente.

Alternativa correta  
O 128 cravado na chamada encoding.GetString deve ser substituído por bytesLidos.

> Nem sempre o método Read() fará a leitura de 128 bytes. Se usarmos sempre 128, é possível que o encoding encontre dados antigos e já processados.

Alternativa correta  
Ao executar a aplicação, haverá duplicação nos nomes impressos na tela.

> Isso é sinal de erro na utilização do buffer.

### Aula 2: Faça como eu fiz

Como podemos lidar com uma exceção lançada durante o processamento de arquivo? Como podemos aplicar o método Close() e usings na nossa solução? Além disso, agora podemos trabalhar com buffers e StreamReader. Vamos solucionar essas questões?

Opinião do instrutor

1) Quando criamos um FileStream o sistema operacional nos dá acesso ao arquivo e mantém esse recurso conosco até a notificação de que terminamos nosso trabalho. Para notificar o sistema operacional de que liberamos este recurso, é necessário chamar o método Close():

> fluxoDoArquivo.Close();

2) E se durante o processamento do arquivo uma exceção for lançada e o método Close() não for executado? Para nos assegurarmos que esse método é chamado, devemos usar a construção try/finally ou, melhor ainda, usar um bloco using - afinal, o Stream implementa a interface IDisposable:

```csharp
using (var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
{
    var buffer = new byte[1024]; // 1 kb
    var numeroDeBytesLidos = -1;

    while (numeroDeBytesLidos != 0)
    {
        numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);
        EscreverBuffer(buffer);
    }
}
```

Teste a aplicação! Enquanto a console estiver aberta, agora podemos renomear ou excluir o arquivo “contas.txt”!

3) Percebemos que o conteúdo de nosso arquivo está sendo duplicado na console. Isso acontece porque o Read só escreve em nosso buffer os bytes lidos. Ao chegar no final do arquivo, nosso Stream recupera menos de 1024 bytes e então ficamos com dados antigos no buffer. Para resolver esse problema, precisamos indicar ao método EscreverBuffer() quantos bytes de nosso buffer devem ser processados:

```csharp
static void EscreverBuffer(byte[] buffer, int bytesLidos) { … }
```

Ainda no EscreverBuffer, vamos dizer ao Encoding o intervalo de bytes que devem ser usados na transformação:

```csharp
var texto = utf8.GetString(buffer, 0, bytesLidos);
```

Execute o programa! Perceba que agora não temos mais uma duplicação do conteúdo no final.

4) Ficou evidente, então, que quando trabalhamos com buffers é necessário bastante cuidado com os intervalos utilizados. Ao invés de lidar diretamente com o FileStream e bytes de Stream, podemos usar uma classe que encapsula esta lógica, o StreamReader:

```csharp
using (var fluxoDeArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
using (var leitor = new StreamReader(fluxoDeArquivo))
{

}
```

Usamos o ReadLine para a leitura de uma linha do arquivo e a propriedade EndOfStream para verificar se chegamos ao fim do stream:

```csharp
using (var fluxoDeArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
using (var leitor = new StreamReader(fluxoDeArquivo))
{
    while (!leitor.EndOfStream)
    {
        var linha = leitor.ReadLine();
        Console.WriteLine(linha);
    }
}
```

Verifique também os métodos ReadToEnd() e Read() da classe StreamReader. Enquanto o ReadToEnd() retorna o arquivo completo, o Read() retorna apenas um byte.

Perceba que apesar do retorno de Read() ser um char do arquivo, seu tipo de retorno é int e não byte ou char. Isto é porque o método retorna -1 quando o fim do stream foi atingido.

## Aula 3: Fazendo Parse e StreamWriter

### Aula 3: Projeto da aula anterior

Você pode baixar os códigos que desenvolvemos até agora em [zip neste link](https://github.com/alura-cursos/CsharpArquivos/archive/refs/heads/aula-2.zip) ou acessar o repositório da [aula no GitHub!](https://github.com/alura-cursos/CsharpArquivos/tree/aula-2)

### Aula 3: Convertendo o texto para conta - Vídeo 1

Transcrição  
Agora que já exploramos algumas ferramentas para facilitar nosso trabalho ao lidar com arquivos, começaremos a entender como usar as informações desse arquivo para criar uma conta-corrente no ByteBank. Temos um conjunto de strings, mas como podemos utilizá-las? Vamos ler linha a linha, talvez?

No arquivo Program.cs, após o método Main, vamos inserir o método ConverterStringParaContaCorrente, que receberá uma string linha :

```csharp
// ...
static ContaCorrente ConverterStringParaContaCorrente(string linha)
{
    // 375 4644 2483.13 Jonatan

    var resultado = new ContaCorrente(agencia, numero);
    resultado.Depositar(saldoComDouble);
    resultado.Titular = titular;

    return resultado;
}
```

Por enquanto, o compilador está alegando alguns erros nesse método, sublinhando-os em vermelho. Na sequência, vamos solucionar esses problemas e desenvolver esse método, de modo a criar contas-correntes com os números da agência e da conta, o saldo e o nome do titular, utilizando informações do nosso arquivo. Assim, não precisaremos declarar uma variável específica, como fizemos em cursos anteriores.

**Fragmentando o texto**  
Repare que deixamos como comentário um exemplo da estrutura de uma linha do documento contas.txt:

375 4644 2483.13 Jonatan

O primeiro elemento refere-se à agência (375); o segundo, ao número da conta (4644); o terceiro, ao saldo do cliente (R$2.483,13); e, por fim, temos o nome do titular (Jonatan). Trata-se de uma única string com informações de quatro campos diferentes, separados por um espaço.

Vamos utilizar esse espaço para fragmentar a string e separar esses quatro campos, invocando o método Split. Ele receberá como parâmetro o caractere de espaço, para delimitar essas quatro subcadeias de caracteres.

No método ConverterStringParaContaCorrente, criaremos a variável campos para armazenar o retorno dessa chamada:

```csharp
static ContaCorrente ConverterStringParaContaCorrente(string linha)
{
    // 375 4644 2483.13 Jonatan
    var campos = linha.Split(' ');

    var resultado = new ContaCorrente(agencia, numero);
    resultado.Depositar(saldoComDouble);
    resultado.Titular = titular;

    return resultado;
}
```

Em seguida, guardaremos cada um desses fragmentos em uma variável distinta, conforme seus índices. Na primeira posição (índice 0), temos o número da agência, por exemplo:

```csharp
static ContaCorrente ConverterStringParaContaCorrente(string linha)
{
    // 375 4644 2483.13 Jonatan
    var campos = linha.Split(' ');

    var agencia = campos[0];
    var numero = campos[1];
    var saldo = campos[2];
    var nomeTitular = campos [3];

    var resultado = new ContaCorrente(agencia, numero);
    resultado.Depositar(saldoComDouble);
    resultado.Titular = titular;

    return resultado;
}
```

**Convertendo tipos**  
Assim, separamos cada um dos campos, mas ainda não conseguimos usá-los como argumentos na instanciação de uma nova ContaCorrente — o compilador continua alegando erros na linha em que declaramos a variável resultado.

Esse problema ocorre porque originalmente tínhamos uma string e, através do método Split, a fragmentamos em quatro strings menores. Ou seja, não estamos interpretando os números da agência e da conta como números, mas como strings! Então, precisamos convertê-los para um int ou double.

Utilizaremos o método estático Parse, que transformará a string em um número inteiro. Vale ressaltar que futuramente podemos usá-lo para converter uma string em um tipo double, por exemplo.

No método ConverterStringParaContaCorrente, vamos criar as variáveis agenciaComInt e numeroComInt para armazenar os números da agência e da conta, respectivamente, convertidos em inteiros:

```csharp
static ContaCorrente ConverterStringParaContaCorrente(string linha)
{
    // 375 4644 2483.13 Jonatan
    var campos = linha.Split(' ');

    var agencia = campos[0];
    var numero = campos[1];
    var saldo = campos[2];
    var nomeTitular = campos [3];

    var agenciaComInt = int.Parse(agencia);
    var numeroComInt = int.Parse(numero);

    var resultado = new ContaCorrente(agencia, numero);
    resultado.Depositar(saldoComDouble);
    resultado.Titular = titular;

    return resultado;
}
```

Também precisamos converter o nosso saldo. No caso, usaremos o Parse para convertê-lo para um tipo double:

```csharp
static ContaCorrente ConverterStringParaContaCorrente(string linha)
{
    // 375 4644 2483.13 Jonatan
    var campos = linha.Split(' ');

    var agencia = campos[0];
    var numero = campos[1];
    var saldo = campos[2];
    var nomeTitular = campos [3];

    var agenciaComInt = int.Parse(agencia);
    var numeroComInt = int.Parse(numero);
    var saldoComDouble = double.Parse(saldo);

    var resultado = new ContaCorrente(agencia, numero);
    resultado.Depositar(saldoComDouble);
    resultado.Titular = titular;

    return resultado;
}
```

O compilador continuará acusando os erros na linha em que declaramos resultado, porque os nomes das variáveis não correspondem. Guardamos os valores nas variáveis agenciaComInt e numeroComInt, contudo, na instanciação da nova ContaCorrente, informamos agencia e numero. Vamos corrigir:

```csharp
static ContaCorrente ConverterStringParaContaCorrente(string linha)
{
    // 375 4644 2483.13 Jonatan
    var campos = linha.Split(' ');

    var agencia = campos[0];
    var numero = campos[1];
    var saldo = campos[2];
    var nomeTitular = campos [3];

    var agenciaComInt = int.Parse(agencia);
    var numeroComInt = int.Parse(numero);
    var saldoComDouble = double.Parse(saldo);

    var resultado = new ContaCorrente(agenciaComInt, numeroComInt);
    resultado.Depositar(saldoComDouble);
    resultado.Titular = titular;

    return resultado;
}
```

Desse modo, os erros dessa linha serão resolvidos.

A seguir, vamos instanciar um novo Cliente e atribuir seu nome como nomeTitular. Vale lembrar que não precisamos converter a variável nomeTitular, visto que é uma string e continuaremos trabalhando com esse tipo:

```csharp
static ContaCorrente ConverterStringParaContaCorrente(string linha)
{
    // 375 4644 2483.13 Jonatan
    var campos = linha.Split(' ');

    var agencia = campos[0];
    var numero = campos[1];
    var saldo = campos[2];
    var nomeTitular = campos [3];

    var agenciaComInt = int.Parse(agencia);
    var numeroComInt = int.Parse(numero);
    var saldoComDouble = double.Parse(saldo);

    var titular = new Cliente();
    titular.Nome = nomeTitular;

    var resultado = new ContaCorrente(agenciaComInt, numeroComInt);
    resultado.Depositar(saldoComDouble);
    resultado.Titular = titular;

    return resultado;
}
```

Assim, conseguimos desenvolver o método ConverterStringParaContaCorrente para criar uma conta-corrente e um cliente, bem como fazer um depósito.

Aplicando o método ConverterStringParaContaCorrente
Agora, vamos aplicar nosso método, em Main. Dentro do laço while, após declarar a variável linha, chamaremos ConverterStringParaContaCorrente. Passaremos linha como parâmetro e armazenaremos o retorno na variável contaCorrente:

```csharp
static void Main(string[] args)
{
    var enderecoDoArquivo = "contas.txt";

    using(var fluxoDeArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
    {
        var leitor = new StreamReader(fluxoDeArquivo);

        while (!leitor.EndOfStream)
        {
            var linha  = leitor.ReadLine();
            var contaCorrente = ConverterStringParaContaCorrente(linha);
            Console.WriteLine(linha);
        }
    }
    Console.ReadLine();
}
```

Em seguida, mostraremos uma mensagem na tela, informando o número da conta, o número da agência e o saldo do cliente. Vamos criar uma variável chamada msg e exibi-la no Console.WriteLine, em lugar de linha:

```csharp
static void Main(string[] args)
{
    var enderecoDoArquivo = "contas.txt";

    using(var fluxoDeArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
    {
        var leitor = new StreamReader(fluxoDeArquivo);
        while (!leitor.EndOfStream)
        {
            var linha  = leitor.ReadLine();
            var contaCorrente = ConverterStringParaContaCorrente(linha);
            var msg = $"Conta número {contaCorrente.Numero}, ag {contaCorrente.Agencia}, Saldo {contaCorrente.Saldo}";
            Console.WriteLine(msg);
        }
    }
    Console.ReadLine();
}
```

Ao compilar e executar nosso código, o resultado no console será uma lista em que cada linha contém os dados de um cliente. Por exemplo, na primeira linha, temos:

Conta número 4644, ag 375, Saldo 248313

Trata-se do cliente Jonatan, com o qual trabalhamos há pouco. O número da conta-corrente está correto (4644), o número da agência também (375), contudo saldo não confere. Anteriormente, anotamos que o saldo de Jonatan é R$2483,13, porém no console temos 248313 — está faltando um ponto para separar os centavos.

Para solucionar esse problema, utilizaremos o método Replace para substituir o ponto por uma vírgula. No método ConverteStringParaContaCorrente, na linha em que declaramos a variável saldo, vamos acrescentar o método Replace:

```csharp
static ContaCorrente ConverterStringParaContaCorrente(string linha)
    {
        // 375 4644 2483.13 Jonatan
        var campos = linha.Split(' ');

        var agencia = campos[0];
        var numero = campos[1];
        var saldo = campos[2].Replace('.', ',');
        var nomeTitular = campos[3];

        var agenciaComInt = int.Parse(agencia);
        var numeroComInt = int.Parse(numero);
        var saldoComDouble = double.Parse(saldo);

        var titular = new Cliente();
        titular.Nome = nomeTitular;

        var resultado = new ContaCorrente(agenciaComInt, numeroComInt);
        resultado.Depositar(saldoComDouble);
        resultado.Titular = titular;

        return resultado;
    }
```

Esse método selecionará a string e fará a troca do caractere de ponto pelo caractere de vírgula. Agora, ao executar nosso programa, o resultado mostrará o saldo com a vírgula no local correto, por exemplo:

Conta número 4644, ag 375, Saldo 2483,13

Assim, o número da conta, o número da agência e o saldo estão de acordo com o documento contas.txt, alcançamos nosso objetivo!

Se antes precisávamos criar conta a conta manualmente, agora conseguimos usar os dados do arquivo dentro da nossa aplicação ByteBank para criar diversas contas rapidamente, de uma única vez.

### Aula 3: Lendo arquivo csv - Vídeo 2

Transcrição  
Já aprendemos como utilizar os dados de um arquivo para criar uma conta-corrente na nossa aplicação ByteBank, agora vamos estudar como deixar essas informações mais claras.

**Exibindo o titular**  
Atualmente, mostramos no console uma mensagem que indica a conta, a agência e o saldo, porém não exibimos o cliente a que esses dados estão associados. Então, vamos modificar a variável msg para incluir essa informação:

```csharp
static void Main(string[] args)
{
    var enderecoDoArquivo = "contas.txt";

    using(var fluxoDeArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
    {
        var leitor = new StreamReader(fluxoDeArquivo);

        while (!leitor.EndOfStream)
        {
            var linha  = leitor.ReadLine();
            var contaCorrente = ConverterStringParaContaCorrente(linha);

            var msg = $"{contaCorrente.Titular.Nome} : Conta número {contaCorrente.Numero}, ag {contaCorrente.Agencia}, Saldo {contaCorrente.Saldo}";

            Console.WriteLine(msg);
        }
    }
    Console.ReadLine();
}
```

Agora, ao executar a aplicação, os dados ficarão mais claros, pois cada conta estará associada a um titular. Por exemplo, na última linha:

Josiane : Conta número 1223, ag 223, Saldo 1833,99

**Incluindo o nome completo**  
Vamos abrir o arquivo contas.txt no Bloco de Notas e alterar a primeira linha, adicionando um sobrenome ao cliente Jonatan:

375 4644 2483.13 Jonatan Silva

Em seguida, vamos salvar a modificação e executar novamente a aplicação ByteBank. Na primeira linha do console, notaremos que Jonatan continuará aparecendo sem o sobrenome. Por que essa informação foi suprimida?

No método ConverterStringParaContaCorrente, usamos o método Split para fragmentar a string e delimitar os quatro campos, usando o caractere de espaço como critério de separação. Em seguida, atribuímos o quarto campo à variável nomeTitular. Como o sobrenome "Silva" está separado do nome "Jonatan" por um espaço também, o programa interpreta que "Silva" é outro campo. Ou seja, não faz parte do quarto campo.

Talvez usar um caractere de espaço como separador não seja uma boa escolha, pois podemos perder algumas informações, por exemplo, relativas ao nome do titular. Uma alternativa seria criar outra variável chamada sobrenome e atribuir o valor campos[4] a ela. Mas e se quisermos usar o nome completo e o usuário tiver mais de um sobrenome? Nem todos os clientes terão a mesma quantidade de sobrenomes.

Em vez do espaço, usaremos vírgulas para separar os valores. Vamos abrir o arquivo contas.txt no Bloco de Notas e desfazer a última modificação, retirando o sobrenome "Silva":

375 4644 2483.13 Jonatan

No menu superior do Bloco de Notas, vamos selecionar "Editar > Substituir" (ou usar o atalho "Ctrl + H") para substituir os caracteres de espaço por vírgulas em todo o arquivo. Basta digitar um espaço no primeiro campo, uma vírgula no segundo campo e pressionar o botão "Substituir tudo".

Agora, podemos inserir o sobrenome de Jonatan novamente, na primeira linha de contas.txt:

375 4644 2483.13 Jonatan Silva

Vamos salvar a alteração e voltar ao Visual Studio. Agora, no método Split, em vez do caractere de espaço, usaremos uma vírgula como separador:

```csharp
static ContaCorrente ConverterStringParaContaCorrente(string linha)
{
    // 375 4644 2483.13 Jonatan
    var campos = linha.Split(',');

    var agencia = campos[0];
    var numero = campos[1];
    var saldo = campos[2].Replace('.', ',');
    var nomeTitular = campos[3];

    var agenciaComInt = int.Parse(agencia);
    var numeroComInt = int.Parse(numero);
    var saldoComDouble = double.Parse(saldo);

    var titular = new Cliente();
    titular.Nome = nomeTitular;

    var resultado = new ContaCorrente(agenciaComInt, numeroComInt);
    resultado.Depositar(saldoComDouble);
    resultado.Titular = titular;

    return resultado;
}
```

Vamos compilar e executar nossa aplicação. Na primeira linha do console, o resultado terá o nome completo do cliente:

Jonatan Silva : Conta número 4644, ag 375, Saldo 2486,13

A estratégia que utilizamos é um formato de arquivo bastante comum chamado CSV (comma-separated values). Em português, arquivo de valores separados por vírgulas. Até então, estávamos utilizando o espaço como separador, porém é comum encontrar arquivos cujos valores são separados por vírgulas. Trata-se de uma ótima solução para problemas como o que tivemos, em que perderíamos informações relacionadas ao nome do titular.

### Aula 3: Criando arquivo csv - Vídeo 3

Transcrição  
Anteriormente, estudamos como informações de um arquivo TXT ou CSV podem ser trazidas para dentro do nosso código, por exemplo, para criar contas-correntes na aplicação do Bytebank. Agora, em vez de trabalhar com arquivos prontos, vamos desenvolver um código responsável pela criação de um arquivo, que receberá dados de uma conta, por exemplo.

Para essa aula, organizamos nosso projeto. Guardamos o código referente ao StreamReader em um arquivo chamado 2_UsandoStreamReader.cs. Em seguida, criamos outro arquivo, chamado 3_CriandoArquivo, no qual trabalharemos a seguir. A base dele é a seguinte:

```csharp
using ByteBank_IO;
using System.Text;

partial class Program
{
    static void CriarArquivo()
    {

    }
}
```

De início, temos as diretivas para o ByteBank_IO e o System.Text. Continuaremos usando a classe Program com o partial, para que o compilador compreenda que dividimos essa classe em vários arquivos. Também criamos o método CriarArquivo.

**Criando um arquivo**  
Nosso primeiro passo será estipular o nome do novo arquivo CSV. Vamos declarar uma variável chamada caminhoNovoArquivo, que receberá o local onde guardaremos o novo documento. Assim como contas.txt que usamos em aulas passadas, escolheremos a mesma pasta do executável, para facilitar nosso acesso durante o curso:

```csharp
using ByteBank_IO;
using System.Text;

partial class Program
{
    static void CriarArquivo()
    {
        var caminhoNovoArquivo = "contasExportadas.csv";
    }
}
```

Note que colocamos a extensão .csv. Para o C#, esse detalhe não é relevante no momento, porém ele é importante para o nosso sistema operacional entender com que tipo de arquivo estamos lidando. Na sequência, criaremos o fluxo de arquivo, que permitirá colocar os bytes desse novo arquivo e os utilizar dentro de um fluxo — um processo semelhante ao que fazíamos na leitura.

Utilizaremos o using para fazer o tratamento de possíveis exceções. Nele, declararemos o fluxoDeArquivo, em que vamos instanciar um novo FileStream. Este receberá dois argumentos: o caminho do arquivo e o FileMode. Anteriormente, usamos o FileMode.Open para abrir o documento; agora, aplicaremos o FileMode.Create para criá-lo:

```csharp
using ByteBank_IO;
using System.Text;

partial class Program
{
    static void CriarArquivo()
    {
        var caminhoNovoArquivo = "contasExportadas.csv";

        using(var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
        {

        }

    }
}
```

Em seguida, trabalharemos com o buffer e os bytes. A princípio, criaremos uma variável chamada contaComoString, que receberá a string que pretendemos escrever no arquivo contasExportadas.csv:

```csharp
using ByteBank_IO;
using System.Text;

partial class Program
{
    static void CriarArquivo()
    {
        var caminhoNovoArquivo = "contasExportadas.csv";
        using(var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
        {
            var contaComoString = "456, 7895, 4785.40, Gustavo Santos";
        }

    }
}
```

Anteriormente, selecionávamos os bytes e os transformávamos em caracteres conforme o encoding. Nesse caso, faremos o oposto. Então, criaremos uma variável encoding para guardar o encoding UTF8:

```csharp
using ByteBank_IO;
using System.Text;

partial class Program
{
    static void CriarArquivo()
    {
        var caminhoNovoArquivo = "contasExportadas.csv";

        using(var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
        {
            var contaComoString = "456, 7895, 4785.40, Gustavo Santos";

            var encoding = Encoding.UTF8;

        }

    }
}
```

Se antes usamos o GetString para obter uma string a partir dos bytes, agora utilizaremos o GetBytes para obter os bytes da string. Vamos criar uma variável chamada bytes para armazenar o resultado dessa transformação:

```csharp
using ByteBank_IO;
using System.Text;

partial class Program
{
    static void CriarArquivo()
    {
        var caminhoNovoArquivo = "contasExportadas.csv";

        using(var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
        {
            var contaComoString = "456, 7895, 4785.40, Gustavo Santos";

            var encoding = Encoding.UTF8;

            var bytes = encoding.GetBytes(contaComoString);

        }

    }
}
```

Na sequência, usaremos o conceito de fluxo de arquivo. Assim como tínhamos o método Read para ler, também temos o Write para escrever. Ele receberá os mesmos argumentos, isto é, o buffer, o índice onde iniciar a escrita e quantas posições deve ocupar:

```csharp
using ByteBank_IO;
using System.Text;

partial class Program
{
    static void CriarArquivo()
    {
        var caminhoNovoArquivo = "contasExportadas.csv";

        using(var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
        {
            var contaComoString = "456, 7895, 4785.40, Gustavo Santos";

            var encoding = Encoding.UTF8;

            var bytes = encoding.GetBytes(contaComoString);

            fluxoDeArquivo.Write(bytes, 0, bytes.Length);

        }

    }
}
```

Como não sabemos a quantidade de bytes e queremos escrever a informação completa, utilizamos o bytes.Length para usar o tamanho exato. Por fim, vamos chamar o método EscreverArquivo no arquivo Program.cs:

```csharp
using ByteBank_IO;
using System.Text;

partial class Program
{
    static void Main(string[] args)
    {
        CriarArquivo();

        Console.ReadLine();
    }
}
```

Após salvar as alterações, podemos executar a aplicação. No console, não teremos nenhuma mensagem sendo exibida, pois não utilizamos nenhum Console.WriteLine.

O resultado esperado é um novo arquivo na pasta do executável. Então, vamos abrir o Gerenciador de Soluções, usando o atalho "Ctrl + Alt + L" ou acessando "Exibir > Gerenciador de Soluções" no menu superior do Visual Studio. Na lateral direita, clicaremos com o botão direito sobre a solução e selecionaremos "Abrir Pasta no Gerenciador de Arquivos". Em seguida, navegaremos até "ByteBank_IO > bin > Debug > net6.0", onde encontraremos o arquivo contasExportadas.csv! Vamos clicar sobre ele com o botão direito do mouse e selecionar "Abrir com > Bloco de Notas". O seu conteúdo é a seguinte linha:

456, 7895, 4785.40, Gustavo Santos

É exatamente a string que guardamos na variável contaComoString! Ou seja, conseguimos criar um arquivo a partir de uma string com dados de um cliente.

### Aula 3: Usando StreamWriter e CreateNew - Vídeo 4

Transcrição  
Em aulas anteriores, aprendemos a ler um arquivo de texto aplicando conceitos de buffer e bytes, e descobrimos formas menos complexas de lidar com esses processos, por exemplo, usando recursos como ReadLine, ReadToEnd, Read e EndOfStream. Depois, usamos os conceitos de buffer e bytes para escrever um novo arquivo CSV.

A seguir, exploraremos ferramentas que facilitam nosso trabalho ao gravar arquivos. Mais especificamente, estudaremos a classe StreamWriter e seus recursos.

**StreamWriter**  
Ao final do arquivo 3_CriandoArquivo.cs, vamos desenvolver o método CriarArquivoComWriter():

```csharp
static void CriarArquivoComWriter()
{
    var caminhoNovoArquivo = "contasExportadas.csv";

    using(var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
}
```

De início, temos a variável caminhoNovoArquivo com o caminho do novo arquivo e a estrutura using para verificar o fluxo, utilizando o FileStream com o caminho e o FileMode.Create. Na sequência, usaremos o StreamWriter em nosso favor, para simplificar a gravação de arquivos.

Após o using, utilizaremos outro using para verificar o escritor, em que instanciaremos um new StreamWriter que receberá o fluxoDeArquivo:

```csharp
static void CriarArquivoComWriter()
{
    var caminhoNovoArquivo = "contasExportadas.csv";

    using(var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
    using(var escritor = new StreamWriter(fluxoDeArquivo))
}
```

Note que estamos usando duas estruturas using. Uma opção seria abrir chaves e posicionar o segundo using dentro do primeiro, mas optamos por uma sintaxe mais simples e que também funciona.

Em seguida, utilizaremos o método Write do escritor:

```csharp
static void CriarArquivoComWriter()
{
    var caminhoNovoArquivo = "contasExportadas.csv";

    using(var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
    using(var escritor = new StreamWriter(fluxoDeArquivo))
    {
        escritor.Write("456,65465,456.0,Pedro");
    }
}
```

Em vez de Gustavo, agora informamos ao método Write os dados da conta do cliente Pedro, assim conseguiremos notar a diferença no novo arquivo. Desse modo, preencheremos nosso documento com dados da agência, conta, saldo e nome do cliente, sem a necessidade de trabalhar com conceitos de buffer e bytes.

Vamos chamar o método CriarArquivoComWriter no arquivo Program.cs:

```csharp
using ByteBank_IO;
using System.Text;

partial class Program
{
    static void Main(string[] args)
    {
        CriarArquivoComWriter();

        Console.ReadLine();
    }
}
```

Após salvar todas as alterações, vamos executar a aplicação. Novamente, não exibimos nada no console. Basta acessarmos a pasta do executável no gerenciador de arquivos e abrir contasExportadas.csv com o Bloco de Notas. O seu conteúdo será a seguinte linha:

456,65465,456.0,Pedro

Ou seja, exatamente a string que informamos ao método Write, com o número da agência, a conta, o saldo e o nome do usuário. Assim, simplificamos a criação de um arquivo, utilizando o StreamWriter.

**FileMode.Create e FileMode.CreateNew**  
No método CriarArquivoComWriter, usamos o FileMode.Create e averiguamos que o código funciona corretamente. Agora, vamos utilizar o FileMode.CreateNew para descobrir a diferença entre eles:

```csharp
static void CriarArquivoComWriter()
{
    var caminhoNovoArquivo = "contasExportadas.csv";

    using(var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.CreateNew))
    using(var escritor = new StreamWriter(fluxoDeArquivo))
    {
        escritor.Write("456,65465,456.0,Pedro");
    }
}
```

Ao rodar o projeto, uma exceção será lançada, porque o CreateNew é responsável por criar um arquivo somente se não houver nenhum outro arquivo com o mesmo nome dentro do diretório em questão. No caso, já tínhamos o arquivo contasExportadas.csv na pasta, então o CreateNew lança uma exceção.

Em outras palavras, o CreateNew deve ser usado para criar arquivo que ainda não existem. Se ele já existe e a intenção é substituí-lo, optaremos pelo Create:

```csharp
static void CriarArquivoComWriter()
{
    var caminhoNovoArquivo = "contasExportadas.csv";

    using(var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
    using(var escritor = new StreamWriter(fluxoDeArquivo))
    {
        escritor.Write("456,65465,456.0,Pedro");
    }
}
```

Podemos rodar a aplicação mais uma vez para nos certificar de que ela continua funcionando. Com o Create, nenhuma exceção será lançada.

### Aula 3: Copiando um arquivo - Exercício

Carlos criou um código para gerar manualmente a cópia de um arquivo. A estratégia dele foi um stream para a leitura do arquivo original e outro stream para a escrita do novo arquivo:

```csharp
var arquivoOriginal = new FileStream("c:/temp/teste.txt", FileMode.Open);
var arquivoNovo = new FileStream("c:/temp/teste_copia.txt", FileMode.Create);
var buffer = new byte[1024];

using(arquivoOriginal)
using(arquivoNovo)
{
    var bytesLidos = -1;
    while(bytesLidos != 0)
    {
        bytesLidos = arquivoOriginal.Read(buffer, 0, 1024);
        arquivoNovo.Write(buffer, 0, bytesLidos);
    }
}

var rodape = Encoding.UTF8.GetBytes("Este documento é uma cópia do original");
arquivoNovo.Write(rodape, 0, rodape.Length);
```

Note que o código realiza uma cópia, byte a byte, dentro de um laço while corretamente. Ao fim, escreve a nota "Este documento é uma cópia do original" no arquivo novo.

Selecione a opção que corresponde ao comportamento da aplicação ao executar.

Resposta:  
A tentativa de escrever o rodapé lançará uma exceção, pois o arquivo foi fechado.

> O bloco using será o responsável por chamar o método Dispose() em nossos streams, o que fechará o arquivo.

### Aula 3: Faça como eu fiz

Agora sabemos converter a linha de texto do nosso arquivo para uma instância de conta corrente. Além disso, sabemos criar e ler um arquivo csv.

Então, vamos colocar em prática escrevendo o código responsável por converter a linha de texto do nosso arquivo para uma instância de ContaCorrente?

Opinião do instrutor

1) Vamos escrever o código responsável por converter a linha de texto do nosso arquivo para uma instância de ContaCorrente:

```csharp
static ContaCorrente ConverterStringParaContaCorrente(string linha)
{
}
```

2) Em nosso documento, temos os campos separados por um espaço ' '. Então usamos o método Split com o nosso caractere separador para dividir a linha original em um array:

```csharp
string[] campos = linha.Split(' ');
```

Conforme o layout de nosso arquivo, em cada linha temos o formato <agencia> <numero> <saldo> <titular>. Seguindo este padrão, vamos criar uma variável para cada campo:

```csharp
var agencia = campos[0];
var numero = campos[1];
var saldo = campos[2];
var nomeTitular = campos[3];
```

3) Note que nossas variáveis são todas do tipo string! Precisamos realizar a conversão, o Parse(), dos números de agência, conta e saldo:

```csharp
var agenciaComoInt = int.Parse(agencia);
var numeroComoInt = int.Parse(numero);
var saldoComoDouble = double.Parse(saldo);
```

Se realizarmos o Parse() de double usando o ponto como separador da casa decimal do saldo, não teremos o retorno esperado. Então, vamos dar um Replace do caractere '.' por ',', para o Parse() realizar a conversão que esperamos: var saldo = campos[2].Replace('.', ',');. Agora, basta construir nosso objeto e retornar:

```csharp
var titular = new Cliente();
titular.Nome = nomeTitular;

var resultado = new ContaCorrente(agenciaComoInt, numeroComoInt);
resultado.Depositar(saldoComoDouble);
resultado.Titular = titular;

return resultado;
```

4) Para testar nosso código, altere o código do bloco using do StreamReader:

```csharp
while (!leitor.EndOfStream)
{
    var linha = leitor.ReadLine();
    var contaCorrente = ConverterStringParaContaCorrente(linha);
    var msg = $"{contaCorrente.Titular.Nome} : Conta número {contaCorrente.Numero}, ag. {contaCorrente.Agencia}. Saldo: {contaCorrente.Saldo}";
    Console.WriteLine(msg);
}
```

Verifique a saída na console. O resultado deverá ser o que esperamos conforme os dados no arquivo de texto!

5) Usar o espaço como caractere separador nos traz um problema: como tratar os nomes? Eles possuem espaço entre as palavras e a chamada do método Split() separa o nome em várias strings diferentes. Para lidar com isso, vamos alterar o arquivo e usar como caractere separador a vírgula ,.

Assim, abra o arquivo com seu editor de texto preferido e substitua o espaço em branco pela vírgula. No curso, eu abri o bloco de notas do Windows, posicionei o cursor antes do primeiro caractere, usei o atalho “CTRL + H”, preenchi o campo “Localizar” com um espaço em branco e o campo “Substituir por” com uma vírgula. Feito isso, cliquei em “Substituir tudo”.

Feita a mudança no documento, vamos alterar a chamada linha.Split(' '); para linha.Split(',');.

Esse arquivo com valores separados por vírgula é chamado de CSV e é bastante utilizado np mercado.

6) Agora que conseguimos ler um arquivo e interpretar seus valores, é o momento de criar nosso próprio arquivo! Crie o método CriarArquivo():

```csharp
static void CriarArquivo()
{
}
```

7) Vamos precisar definir o nome do arquivo e criar um fluxo de arquivo com modo de operação FileMode.Create!

```csharp
var caminhoNovoArquivo = "contasExportadas.csv";
using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
{
}
```

Vamos escrever neste arquivo a string abaixo:

```csharp
var contaComoString = "456,78945,4785.50,Gustavo Santos";
```

8) É necessário transformar a string contaComoString em uma cadeia de bytes. Para tal, precisamos do encoding! No curso, usamos o UTF-8:

```csharp
var contaComoString = "456,78945,4785.50,Gustavo Santos";
var encoding = Encoding.UTF8;
var bytes = encoding.GetBytes(contaComoString);
```

Com nosso array de bytes criado, basta usar o método Write para escrever no stream:

```csharp
fluxoDeArquivo.Write(bytes, 0, bytes.Length);
```

Execute a aplicação e verifique o conteúdo do arquivo!

9) Aprendemos como usar esse método, lidando com bytes diretamente, agora podemos usar uma abstração que torna isso mais fácil e simples para nós, o StreamWriter:

```csharp
using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
using (var escritor = new StreamWriter(fluxoDeArquivo, Encoding.UTF8))
{
    escritor.Write("456,65465,456.0,Pedro");
}
```

### Aula 3: O que aprendemos?

Nessa aula, você aprendeu:

- Os métodos int.Parse() e double.Parse() e como podemos convertê-los em ponto flutuante de dupla precisão;
- O formato de arquivo .csv, usado para armazenar dados, de forma similar a uma tabela;
- Como escrever diretamente no stream;
- Diferença entre FileMode.Create e FileMode.CreateNew referentes a classe FileMode, que nos ajudam a especificar como o sistema deve abrir o arquivo;
- Como usar o StreamWriter para gravar caracteres em um fluxo com uma codificação específica.

## Aula 4: O Flush e os arquivos Binários

### Aula 4: Projeto da aula anterior

Você pode baixar os códigos que desenvolvemos até agora em [zip neste link](https://github.com/alura-cursos/CsharpArquivos/archive/refs/heads/aula-3.zip) ou acessar o repositório da [aula no GitHub!](https://github.com/alura-cursos/CsharpArquivos/tree/aula-3)

### Aula 4: Método Flush - Vídeo 1

Transcrição  
Na aula anterior, conhecemos o StreamWriter, útil para não precisarmos lidar com bytes, a chamada de Encoding e os limites e intervalos do nosso array.

No arquivo 3_CriandoArquivo.cs, temos a chamada do método Write, com o qual colocamos os dados do usuário Pedro em um arquivo CSV. Será que o arquivo é atualizado imediatamente, quando chamamos esse método? A seguir, vamos fazer esse teste para ter certeza do momento em que uma informação aparece dentro do arquivo.

**Verificando o tempo de latência**  
Ao final do arquivo 3_CriandoArquivo.cs, vamos criar um método estático chamado TestaEscrita:

```csharp
static void TestaEscrita()
{
}
```

Esse método será bastante parecido com o que fizemos anteriormente, utilizando recursos como StreamWriter e o fluxo de arquivo, bem com FileStream e FileMode:

```csharp
static void TestaEscrita()
{
    var caminhoNovoArquivo = "teste.txt";

    using(var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.CreateNew))
    using(var escritor = new StreamWriter(fluxoDeArquivo))
    {

    }
}
```

Note que mudamos o nome do arquivo de contasExportadas.csv para teste.txt e não trabalharemos mais com o escritor.Write.

Em seguida, vamos testar quanto tempo uma mensagem demora para ser gravada no nosso arquivo. A ideia é fazer várias chamadas ao método WriteLine e abrir o arquivo enquanto a aplicação está sendo executada:

```csharp
static void TestaEscrita()
{
    var caminhoNovoArquivo = "teste.txt";

    using(var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.CreateNew))
    using(var escritor = new StreamWriter(fluxoDeArquivo))
    {
        escritor.WriteLine("Linha 0");
        escritor.WriteLine("Linha 0");
        escritor.WriteLine("Linha 0");
        escritor.WriteLine("Linha 0");
        escritor.WriteLine("Linha 0");
        escritor.WriteLine("Linha 0");
        escritor.WriteLine("Linha 0");
        escritor.WriteLine("Linha 0");
    }
}
```

Contudo, há um problema: o método WriteLine será executado muito rapidamente e, antes de abrirmos o arquivo no diretório, a aplicação já terá finalizado a tarefa. Então, entre uma chamada e outra, vamos gerar algo que "trave" nossa aplicação, assim conseguiremos acompanhar a escrita das mensagens no arquivo e averiguar quando a informação é gravada, de fato, no documento.

```csharp
Para realizar esse "travamento", podemos usar o Console.ReadLine entre as chamadas. Para evitar o uso repetitivo de WriteLine e ReadLine, vamos desenvolver um laço for com um número alto de iterações:

static void TestaEscrita()
{
    var caminhoNovoArquivo = "teste.txt";
    using(var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.CreateNew))
    using(var escritor = new StreamWriter(fluxoDeArquivo))
    {
        for(int i = 0; i < 1000000; i++)
        {
            escritor.WriteLine("Linha 0");
            Console.ReadLine();
        }
    }
}
```

Além disso, em vez de repetir "Linha 0", podemos modificar a mensagem a cada iteração, usando interpolação de strings com a variável i:

```csharp
static void TestaEscrita()
{
    var caminhoNovoArquivo = "teste.txt";
    using(var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.CreateNew))
    using(var escritor = new StreamWriter(fluxoDeArquivo))
    {
        for(int i = 0; i < 1000000; i++)
        {
            escritor.WriteLine($"Linha {i}");
            Console.ReadLine();
        }
    }
}
```

Antes do Console.ReadLine, exibiremos uma mensagem explicativa no console, para esclarecer ao usuário sobre os processos que ocorreram:

```csharp
static void TestaEscrita()
{
    var caminhoNovoArquivo = "teste.txt";

    using(var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.CreateNew))
    using(var escritor = new StreamWriter(fluxoDeArquivo))
    {
        for(int i = 0; i < 1000000; i++)
        {
            escritor.WriteLine($"Linha {i}");
            Console.WriteLine($"Linha {i} foi escrita no arquivo. Tecle enter...");
            Console.ReadLine();
        }
    }
}
```

Para testar, no arquivo Program.cs, vamos substituir a chamada de CriarArquivoComWriter pelo método TestaEscrita:

```csharp
using ByteBank_IO;
using System.Text;

partial class Program
{
    static void Main(string[] args)
    {
        TestaEscrita();

        Console.ReadLine();
    }
}
```

Vamos salvar todas as alterações e executar a aplicação. No console, aparecerá a seguinte mensagem:

Linha 0 foi escrita no arquivo. Tecle enter...

Ao pressionar a tecla "Enter", teremos:

Linha 0 foi escrita no arquivo. Tecle enter...

Linha 1 foi escrita no arquivo. Tecle enter...

Para verificar se, de fato, essa escrita está acontecendo, abriremos o arquivo teste.txt no Bloco de Notas. Sem encerrar a aplicação, vamos acessar o Gerenciador de Soluções ("Ctrl + Alt + L"), clicar com o botão direito sobre a solução, selecionar "Abrir Pasta no Gerenciador de Arquivos" e navegar até "ByteBank_IO > bin > Debug > net6.0".

Ao abrir o arquivo teste.txt, vamos reparar que ele está vazio! Não estamos escrevendo essa mensagem tão rapidamente quanto gostaríamos. Apesar de lermos a mensagem "Linha 0 foi escrita no arquivo", constatamos que a informação ainda não foi gravada.

Vamos fechar o Bloco de Notas, minimizar o gerenciador de arquivos, parar a aplicação e procurar entender o que está acontecendo.

**Entendendo e resolvendo o problema**  
Em que momento, de fato, nossa informação é passada para o HD? Quando estamos escrevendo em um arquivo, o que acontece internamente entre a nossa aplicação, nosso sistema e o nosso dispositivo externo?

Ao escrever algo no HD, paramos a nossa aplicação e uma mensagem é enviada ao sistema operacional para que ele escreva o número de bytes nos HD. Esse tempo de envio e recebimento tem uma alta latência, ou seja, é um pouco demorado.

Até agora, estamos acostumados a trabalhar com variáveis, buffer, arrays e listas. Nesses casos, sempre usamos memória RAM, que é bastante rápida — diferentemente do HD. Para escrevermos no HD (ou no SSD, que funciona da mesma forma), o processo é mais lento, principalmente quando perdemos tempo notificando o sistema operacional dessa ação que queremos executar.

Sempre que utilizamos o WriteLine para escrever no arquivo, perdemos bastante tempo. O StreamWriter possui um buffer. No caso do WriteLine, não estamos escrevendo no arquivo, de fato. Na verdade, enviamos determinada informação para o buffer do StreamWriter. Enquanto não encerramos o buffer interno do StreaamWriter, a informação não é despejada no FilStream, tornando o processo mais demorado. Para economizar tempo, temos algumas ferramentas à disposição.

No contexto desse treinamento, se a escrita for demorada, não é um problema. Contudo, haverá situações em que precisaremos que a escrita no arquivo seja mais rápida e imediatamente no HD — por exemplo, um log que dita os processos de uma aplicação. Nesses casos, a demora pode ser prejudicial, já que acompanhamos o log para resolver possíveis quebras no programa. Se a informação demora para chegar até nós, isso é problemático.

É necessário saber lidar com esses obstáculos e trabalhar de maneira rápida com informações que precisamos colocar em um arquivo.

Em resumo, há cenários em que é interessante evitar o uso do buffer para não ocorrer essa demora na escrita. Nesses casos, podemos usar o método Flush, responsável por despejar o buffer para a stream. Ou seja, ele evita o processo de guardar o buffer para, depois, mandar para o FileStream.

Em TestaEscrita, após o WriteLine, vamos aplicar o método Flush:

```csharp
static void TestaEscrita()
{
    var caminhoNovoArquivo = "teste.txt";

    using(var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.CreateNew))
    using(var escritor = new StreamWriter(fluxoDeArquivo))
    {
        for(int i = 0; i < 1000000; i++)
        {
            escritor.WriteLine($"Linha {i}");
            escritor.Flush(); //Despeja o buffer para o Stream

            Console.WriteLine($"Linha {i} foi escrita no arquivo. Tecle enter...");
            Console.ReadLine();
        }
    }
}
```

Assim, toda vez que colocarmos uma linha dentro do arquivo, vamos despejar o buffer no stream logo em seguida. Será um processo mais rápido. Para testar, vamos executar a aplicação. No console, teremos o seguinte resultado:

Linha 0 foi escrita no arquivo. Tecle enter...

Ao pressionar a tecla "Enter", teremos:

Linha 0 foi escrita no arquivo. Tecle enter...

Linha 1 foi escrita no arquivo. Tecle enter...

Ao pressionar "Enter" mais uma vez, teremos:

Linha 0 foi escrita no arquivo. Tecle enter...

Linha 1 foi escrita no arquivo. Tecle enter...

Linha 2 foi escrita no arquivo. Tecle enter...

Sem parar a aplicação, vamos ao gerenciador de arquivos para abrir contasExportadas.txt. Dessa vez, o arquivo não está vazio:

Linha 0

Linha 1

Linha 2

As linhas foram escritas, de fato, no nosso documento. Agora, o processo foi bem rápido, quase instantâneo. Assim, usamos o método Flush para solucionar a demora, despejando o buffer para o stream.

### Aula 4: Escrita binária - Vídeo 2

Transcrição  
No arquivo 3_CriandoArquivo.cs, desenvolvemos o código responsável por criar arquivos na pasta do executável. Nele, utilizamos a classe StreamWriter, que conta com métodos para auxiliar nosso trabalho, de modo que não precisemos lidar diretamente com buffer e bytes.

Um desses métodos é o StreamWriter.WriteLine, bastante semelhante ao Console.WriteLine que usamos com frequência em nossos cursos. Ambos possuem sobrecargas para string, char, long, números inteiros, valores booleanos, entre outros tipos definidos no .NET. A seguir, vamos realizar testes com esses diferentes valores, no arquivo Program.cs.

**Valores booleanos e números longos**  
Primeiramente vamos remover a chamada ao TestaEscrita, em Program.cs:

```csharp
using ByteBank_IO;
using System.Text;

partial class Program
{
    static void Main(string[] args)
    {
        Console.ReadLine();

    }
}
```

No arquivo 3_CriandoArquivo.cs, copiaremos o conteúdo do método CriarArquivoComWriter. Vamos colá-lo dentro do método Main, em Program.cs:

```csharp
using ByteBank_IO;
using System.Text;

partial class Program
{
    static void Main(string[] args)
    {
        var caminhoNovoArquivo = "contasExportadas.csv";

        using(var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
        using(var escritor = new StreamWriter(fluxoDeArquivo))
        {
            escritor.Write("456,65465,456.0,Pedro");
        }

        Console.ReadLine();

    }
}
```

Em seguida, vamos adaptar esse trecho que colamos. Em vez de escrever uma string no nosso arquivo, gravaremos valores booleanos — testaremos tanto com true quanto com false. Além disso, também escreveremos um número inteiro grande:

```csharp
using ByteBank_IO;
using System.Text;

partial class Program
{
    static void Main(string[] args)
    {
        var caminhoNovoArquivo = "contasExportadas.csv";

        using(var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
        using(var escritor = new StreamWriter(fluxoDeArquivo))
        {
            escritor.WriteLine(true);
            escritor.WriteLine(false);
            escritor.WriteLine(454545454545);
        }

        Console.ReadLine();

    }
}
```

De resto, vamos modificar o nome do nosso arquivo de contasExportadas.csv para TestaEscrita.txt:

```csharp
using ByteBank_IO;
using System.Text;

partial class Program
{
    static void Main(string[] args)
    {
        var caminhoNovoArquivo = "TestaEscrita.txt";

        using(var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
        using(var escritor = new StreamWriter(fluxoDeArquivo))
        {
            escritor.WriteLine(true);
            escritor.WriteLine(false);
            escritor.WriteLine(454545454545);
        }

        Console.ReadLine();

    }
}
```

Assim, estamos usando o escritor para escrever esses dados no arquivo TestaEscrita.txt. Após as estruturas using, adicionaremos a exibição de uma mensagem no console para informar quando a aplicação for finalizada:

```csharp
using ByteBank_IO;
using System.Text;

partial class Program
{
    static void Main(string[] args)
    {
        var caminhoNovoArquivo = "TestaEscrita.txt";

        using(var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
        using(var escritor = new StreamWriter(fluxoDeArquivo))
        {
            escritor.WriteLine(true);
            escritor.WriteLine(false);
            escritor.WriteLine(454545454545);
        }

        Console.WriteLine("Aplicação Finalizada...");

        Console.ReadLine();

    }
}
```

Vamos executar a aplicação e analisar os resultados do uso do StreamWriter.WriteLine para escrever outros tipos de variáveis. No console, temos a seguinte mensagem:

Aplicação Finalizada...

Podemos pressionar "Enter". Em seguida, abriremos o arquivo TestaEscrita.txt, na pasta do executável. Dentro dele, temos as seguintes informações gravadas:

True

False

454545454545

Nesse arquivo, temos três informações: os valores literais (true e false) e um número inteiro.

Na memória do nosso computador, o true e o false ocupam espaços pequenos — apenas 1 byte, pois trabalhamos com 0 ou 1. Já o número inteiro ocupa 4 bytes. Logo, atualmente estamos usando muito mais espaço que o necessário, já que representamos as informações com texto puro, por exemplo, optando pelo texto "True" em vez de apenas 1.

Nas próximas aulas, aprenderemos a usar a forma binária para otimizar nossos arquivos, especialmente os mais extensos. Faremos alguns testes, explorando métodos e classes disponíveis no .NET para representar informações de forma binária. Assim, economizaremos espaço e otimizaremos a quantidade de memória utilizada no hardware.

### Aula 4: BinaryWriter e BinaryReader - Vídeo 3

Transcrição  
Nosso próximo objetivo é testar e descobrir como armazenar conteúdo em um arquivo de forma binária, de modo que ainda consigamos lê-lo no console. Assim, utilizaremos menos memória da nossa máquina.

**Escrita binária**  
De início, vamos adicionar um novo arquivo de código chamado 4_StreamBinario.cs e inserir o seguinte código nele:

```csharp
using ByteBank_IO;
using System.Text;

partial class Program
{
    static void EscritaBinaria()
    {
        using (var fs = new FileStream("contaCorrente.txt", FileMode.Create))
        using (var escritor = new BinaryWriter(fs))
        {
            escritor.Write(456);           //número da Agência
            escritor.Write(546544);   //número da conta
            escritor.Write(4000.50); //Saldo
            escritor.Write("Gustavo Braga");
        }
    }
}
```

Este código é bem parecido com que fizemos anteriormente, a diferença é que agora entenderemos como armazenar uma escrita binária, em lugar de um texto puro. Vamos examinar o conteúdo desse arquivo, a seguir.

Criamos um método estático chamado EscritaBinaria. A variável fs armazenará um FileStream que recebe dois argumentos: o endereço "contaCorrente.txt" e o FileMode.Create para gerar o arquivo. Depois, temos a variável escritor, que não lidará mais com StreamWriter, responsável por gravar um texto puro. Agora, utilizaremos a classe BinaryWriter, que produz uma representação do nosso stream de maneira binária. Passaremos fs como argumento e esse método escreverá nosso fluxo de arquivo de forma binária.

A classe BinaryWriter não conta com o método WriteLine, já que o conceito de linha é referente a um texto e não a representações binárias. Então, trabalharemos com o Write para armazenar os dados do cliente.

Para testar, vamos chamar o método EscritaBinaria no arquivo Program.cs:

```csharp
using ByteBank_IO;
using System.Text;

partial class Program
{
    static void Main(string[] args)
    {
        EscritaBinaria();
        
        Console.ReadLine();
    }
}
```

Após salvar as alterações, vamos executar o projeto. No console, não haverá nenhuma mensagem, pois não colocamos nenhum comando nesse sentido. Sem parar a aplicação, vamos acessar a pasta do executável e abrir o arquivo contaCorrente.txt.

O conteúdo do arquivo está com um formato estranho, parte dele é ininteligível para nós. Entendemos apenas a segunda linha, que contém o nome do cliente:

È⍰ ðV⍰ A¯@

Gustavo Braga

O formato está estranho porque não estamos escrevendo numa codificação do tipo UTF-8, por exemplo. Trata-se de uma representação binária. O Bloco de Notas tenta transformar os bytes em um texto, ele consegue representar a string, mas é incapaz de decodificar os números.

Então, precisamos desenvolver um leitor para interpretar esse arquivo, que está em formato binário. Apesar de não conseguirmos entender as informações no Bloco de Notas, podemos ler e exibi-las no console da nossa aplicação.

Vamos fechar o Bloco de Notas, para que ele possa sofrer modificações e nada interfirá nele. Podemos fechar o gerenciador de arquivos e parar a aplicação.

**Leitura binária**  
No arquivo 4_StreamBinario.cs, vamos criar um método estático para ler o arquivo binário. Ele será bem parecido com a estrutura do método EscritaBinaria:

```csharp
static void LeituraBinaria()
{
    using (var fs = new FileStream("contaCorrente.txt", FileMode.Open))
    using (var leitor = new BinaryReader(fs))
    {
        
    }
}
```

Anteriormente, no método EscritaBinaria, aplicamos o BinaryWriter. Agora, no método LeituraBinaria, usaremos o BinaryReaderpara ler o arquivo que já escrevemos. Isto é, substituiremos a escrita pela leitura, assim como quando trocamos o StreamWriter pelo StreamReader.

Assim, temos o FileStream para fazer a leitura do documento contaCorrente.txt. Utilizamos o FileMode.Open em lugar de FileMode.Create, uma vez que a intenção é abrir o arquivo. Por fim, aplicamos o BinaryReader para realizar a leitura.

Relembrando: o conteúdo do nosso arquivo são dois números inteiros, um double e uma string. A seguir, vamos criar as variáveis para receber o que será lido pelo leitor.

No método EscritaBinaria, ao posicionar o mouse sobre o número 456 no comando escritor.Write(456), reparamos que esse valor é representado com 32 bits. Portanto, em LeituraBinaria, usaremos o ReadInt32 ao declarar a variável agencia:

```csharp
static void LeituraBinaria()
{
    using (var fs = new FileStream("contaCorrente.txt", FileMode.Open))
    using (var leitor = new BinaryReader(fs))
    {
        var agencia = leitor.ReadInt32();
    }
}
```

Vale ressaltar que existem outras opções para representação de números inteiros, a depender da especificação da variável, como Int16.

Na sequência, criaremos a variável numeroConta para receber o número da conta, também representado por 32 bits. Depois, vamos declarar saldo, que lerá um número do tipo double, e titular que lerá uma string:

```csharp
static void LeituraBinaria()
{
    using (var fs = new FileStream("contaCorrente.txt", FileMode.Open))
    using (var leitor = new BinaryReader(fs))
    {
        var agencia = leitor.ReadInt32();
        var numeroConta = leitor.ReadInt32();
        var saldo = leitor.ReadDouble();
        var titular = leitor.ReadString();
    }
}
```

Criamos as variáveis que passarão pelo leitor e decodificarão as informações do arquivo, apesar de estarem escritas de forma binária. Como não estamos lidando com texto, não há necessidade de usar o Parse, como fizemos anteriormente. No caso, estamos trabalhando diretamente com uma representação binária, então podemos usar métodos especializados para cada tipo.

A seguir, vamos exibir os dados no console com Console.WriteLine:

```csharp
static void LeituraBinaria()
{
    using (var fs = new FileStream("contaCorrente.txt", FileMode.Open))
    using (var leitor = new BinaryReader(fs))
    {
        var agencia = leitor.ReadInt32();
        var numeroConta = leitor.ReadInt32();
        var saldo = leitor.ReadDouble();
        var titular = leitor.ReadString();
        
        Console.WriteLine($"{agencia}/{numeroConta} {titular} {saldo}");
    }
}
```

Vamos chamar o método LeituraBinaria no arquivo Program.cs:

```csharp
using ByteBank_IO;
using System.Text;

partial class Program
{
    static void Main(string[] args)
    {
        EscritaBinaria();
        LeituraBinaria();
        
        Console.ReadLine();
    }
}
```

Após a leitura, vamos mostrar uma mensagem para nos avisar quando a aplicação for finalizada:

```csharp
using ByteBank_IO;
using System.Text;

partial class Program
{
    static void Main(string[] args)
    {
        EscritaBinaria();
        LeituraBinaria();
        
        Console.WriteLine("Aplicação Finalizada ...");
        
        Console.ReadLine();
    }
}
```

Antes de executar a aplicação, é importante que o arquivo contaCorrente.txt não esteja aberto, para nos certificarmos de que não haverá interferências. Depois, vamos rodar o projeto. No console, o resultado será o seguinte:

456/546544 Gustavo Braga 4000,5

Aplicação Finalizada ...

Apesar de termos armazenado as informações de forma binária no nosso arquivo, conseguimos lê-las claramente no console, através do método que desenvolvemos com o BinaryReader e seus recursos.

Ao abrir o arquivo contaCorrente.txt no Bloco de Notas, ainda temos as informações em um formato estranho e pouco claro, pois as armazenamos de forma binária e o Bloco de Notas é incapaz de realizar a decodificação perfeitamente. Todavia, com nosso método de leitura binária, conseguimos decodificar e exibir os dados no console.

Vale lembrar que o armazenamento de informações de forma binária emprega bem menos memória que guardar texto puro, como fazíamos antes.

### Aula 4: Trabalhando com arquivos binários

Giovana quis testar a diferença entre o BinaryWriter e o StreamWriter. O código abaixo escreve o inteiro 691693903 usando os dois writers:

```csharp
var numero = 691693903;

using(var fs = new FileStream("c:/temp/BinaryWriter.txt", FileMode.Create))
using(var writer = new BinaryWriter(fs))
{
    writer.Write(numero);
}

using(var fs = new FileStream("c:/temp/StreamWriter.txt", FileMode.Create))
using(var writer = new StreamWriter(fs))
{
    writer.Write(numero);
}
```

Selecione a opção que responde se haverá diferença na saída dos arquivos.

Resposta:  
Sim! O BinaryWriter usará o formato binário de números inteiros e seu arquivo possuirá 4 bytes de tamanho.

> Boa! O BinaryWriter grava tipos primitivos em binário em um fluxo e com isso irá usar o formato binário de números inteiros e nesse caso, seu arquivo possuirá 4 bytes de tamanho.

### Aula 4: Faça como eu fiz

Vimos que para liberar buffers e sinalizar o sistema operacional que desejamos atualizar um arquivo com o conteúdo do buffer interno, usamos o método Flush(). Vamos aplicar esse método na nossa solução?

Opinião do instrutor

1) Para descobrir mais detalhes sobre o funcionamento do StreamWriter e Stream, escrevemos o código abaixo:

```csharp
static void TestaEscrita()
{
    var caminhoArquivo = "teste.txt";

    using (var fluxoDeArquivo = new FileStream(caminhoArquivo, FileMode.Create))
    using (var escritor = new StreamWriter(fluxoDeArquivo))
    {
        for (int i = 0; i < 100000000; i++)
        {
            escritor.WriteLine($"Linha {i}");
            Console.WriteLine($"Linha {i} foi escrita no arquivo. Tecle enter p adicionar mais uma!");
            Console.ReadLine();
        }
    }
}
```

Execute o código acima! Nele, criamos o arquivo "teste.txt'' no mesmo diretório do executável. A cada linha escrita, a aplicação aguarda no Console.ReadLine que o usuário dê um enter para a escrita da linha seguinte. Veja que não é imediatamente após a chamada do método escritor.WriteLine() que o conteúdo é despejado no disco do computador!

2) Existe um buffer interno no StreamWriter e no Stream. Para liberarmos esses buffers e sinalizar o sistema operacional que desejamos atualizar o arquivo com o conteúdo do buffer interno, usamos o método Flush():

```csharp
escritor.WriteLine($"Linha {i}");
escritor.Flush();
```

Faça o mesmo teste agora e verifique que o arquivo será atualizado a cada enter.

3) Note que o StreamWriter sempre usa a representação de texto para qualquer valor: booleanos, inteiros ou qualquer outro tipo. Se não é necessário mantermos um arquivo com texto legível, podemos criar este documento escrevendo os valores em formato binário! Para tal, começamos com o stream de arquivo e um Writer diferente, o BinaryWriter:

```csharp
using (var fs = new FileStream("contaCorrente.txt", FileMode.Create))
using (var escritor = new BinaryWriter(fs))
{

}
```

O BinaryWriter possui construtores com argumentos de encoding, mas o encoding é utilizado apenas no momento da escrita dechar e string. Os outros tipos, como int, double, bool, etc. são representados no formato binário.

Crie uma conta corrente com este formato:

```csharp
escritor.Write(456); // Número da Agência
escritor.Write(546544); // Número da conta
escritor.Write(4000.50); // Saldo
escritor.Write("Gustavo Braga");
```

4) Ao executar a aplicação e verificarmos o conteúdo do arquivo com um editor de texto, como o Notepad++, encontramos vários caracteres estranhos até o texto Gustavo Braga. Isso acontece pois o editor de texto não espera um documento em formato binário, e tenta converter a sequência de bytes dos números inteiros e do double em um texto. Para recuperarmos o conteúdo deste arquivo, vamos usar o BinaryReader:

```csharp
static void LeituraBinaria()
{
    using (var fs = new FileStream("contaCorrente.txt", FileMode.Open))
    using (var leitor = new BinaryReader(fs))
    {
        var agencia = leitor.ReadInt32();
        var numeroConta = leitor.ReadInt32();
        var saldo = leitor.ReadDouble();
        var titular = leitor.ReadString();

        Console.WriteLine($"{agencia}/{numeroConta} {titular} {saldo}");
    }
}
```

### Aula 4:  O que aprendemos?

Nessa aula, você aprendeu:

- O método Flush limpa os buffers do fluxo fazendo com que os dados armazenados nele sejam gravados no arquivo;
- BinaryReader e BinaryWriter leem e escrevem dados primitivos, como binários, em uma determinada codificação.

## Aula 5: Streams da Console

### Aula 5: Projeto da aula anterior

Você pode baixar os códigos que desenvolvemos até agora em [zip neste link](https://github.com/alura-cursos/CsharpArquivos/archive/refs/heads/aula-4.zip) ou acessar o repositório da [aula no GitHub!](https://github.com/alura-cursos/CsharpArquivos/tree/aula-4)

### Aula 5: Stream da Console - Vídeo 1

Transcrição  
Até o momento, desenvolvemos bastante código com o conceito de stream, utilizando métodos Writer e Reader. Mais especificamente, trabalhamos longamente com a classe FileStream. Contudo, existem outras possibilidades de streams no ecossistema .NET. Nesta aula, vamos explorá-los e averiguar se tudo que aprendemos até então pode ser aplicado a eles.

A princípio, vamos executar nossa aplicação para examinar alguns comportamentos do console. Ao rodá-la, temos o seguinte resultado:

456/546544 Gustavo Braga 4000,5

Aplicação Finalizada ...

Apesar da mensagem "Aplicação Finalizada ...", nosso programa não parou. O cursor está posicionado na última linha e podemos digitar o que quisermos, como uma sequência aleatória:

456/546544 Gustavo Braga 4000,5

Aplicação Finalizada ...

Alura ksjkdfskjdnfjdbfjsdbjfsjjjdbsjsj

A aplicação só responderá se pressionarmos "Enter". Depois, podemos pressionar qualquer tecla para encerrar a aplicação.

De alguma forma, o console acompanha o comportamento do usuário e, somente quando um caractere específico do método ReadLine é apresentado como entrada, ele libera a quebra de linha. Isto é, quando pressionamos o "Enter".

Se o console examina a entrada de dados, isso significa que existe uma stream interna. Então, vamos explorá-la e verificar se os métodos que estudamos com o FileStream são os mesmos do console.

**Stream do console**  
Seria interessante trazer para dentro de um arquivo qualquer informação digitada pelo usuário no console. A seguir, vamos aprender como fazer isso. Primeiramente, no arquivo Program.cs, vamos remover as chamadas aos métodos EscritaBinaria e LeituraBinaria:

```csharp
using ByteBank_IO;
using System.Text;

partial class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Aplicação Finalizada ...");

        Console.ReadLine();
    }
}
```

Em seguida, vamos criar outro arquivo de código, chamado 5_UsandoStreamDeEntradaDaConsole.cs. Nele, colocaremos o seguinte código:

```csharp
using ByteBank_IO;
using System.Text;

partial class Program
{
    static void UsarStreamDeEntrada()
    {
        using (var fluxoDeEntrada = Console.OpenStandardInput())
        {
            var buffer = new byte[1024]; //1kb

            var byteslidos = fluxoDeEntrada.Read(buffer, 0, 1024);

            Console.WriteLine($"Bytes lidos na console: {byteslidos}");
        }
    }
}
```

Nesse arquivo, criamos um método estático chamado UsarStreamDeEntrada. Nosso objetivo será desenvolvê-lo para construir uma forma de ler os dados inseridos pelo usuário no console. Por enquanto, a estrutura está bem parecida com o que fizemos anteriormente. Como estamos utilizando uma stream, continuamos empregando o bloco using que recebe o fluxo. A grande diferença desse código é que não usamos mais o FileStream. Em lugar dele, aplicamos o Console.OpenStandardInput, que permitirá a leitura do que for digitado no console.

No bloco using, criamos um buffer para guardar até 1 kB. Além disso, temos a variável byteslidos com o método Read, que receberá o buffer, a indicação de onde começar a preenchê-lo e a quantidade de posições a serem ocupadas. Por fim, incluímos um Console.WriteLine para mostrar a quantidade de bytes lidos no console.

Como comentamos, há outras opções pra trabalharmos com stream, mas vamos focar no console, por enquanto.

Em Program.cs, vamos chamar o método UsarStreamDeEntrada:

```csharp
using ByteBank_IO;
using System.Text;

partial class Program
{
    static void Main(string[] args)
    {
        UsarStreamDeEntrada();

        Console.WriteLine("Aplicação Finalizada ...");

        Console.ReadLine();
    }
}
```

Em seguida, vamos executar a aplicação. Como resultado, o console permanecerá vazio, o que significa que não chegamos ao comando Console.Write com a mensagem "Aplicação Finalizada". O programa está aguardando que o usuário escreva uma informação.

Ao digitar "Alura" e pressionar a tecla "Enter", teremos o seguinte retorno no console:

Alura

Bytes lidos na console: 7

Aplicação Finalizada ...

O cursor continuará piscando na última linha, então vamos tentar escrever mais informações. Ao digitar "Cursos Online" e pressionar a tecla "Enter", constataremos que esse texto não foi armazenado e temos apenas a opção de pressionar qualquer tecla para fechar a aplicação.

Usando o WriteLine, o método Read liberou os 7 bytes lidos, então terminamos de usar o stream e a aplicação foi finalizada. O que podemos fazer para que o usuário possa escrever mais informações? A primeira ideia que vem em mente é usar um loop. No arquivo 5_UsandoStreamDeEntradaDaConsole, vamos desenvolver um laço while e posicionar a variável byteslidos e o Console.WriteLine dentro dele:

```csharp
using ByteBank_IO;
using System.Text;

partial class Program
{
    static void UsarStreamDeEntrada()
    {
        using (var fluxoDeEntrada = Console.OpenStandardInput())
        {
            var buffer = new byte[1024]; //1kb

            while(true)
            {
                var byteslidos = fluxoDeEntrada.Read(buffer, 0, 1024);
                Console.WriteLine($"Bytes lidos na console: {byteslidos}");
            }
        }
    }
}
```

Ao executar a aplicação, o console ficará esperando uma entrada do usuário. Digitaremos "Alura" e o resultado será o seguinte:

Alura

Bytes lidos na console: 7

Em seguida, vamos digitar "Cursos Online". Como retorno, teremos:

Alura

Bytes lidos na console: 7

Cursos Online

Bytes lidos na console: 15

Podemos digitar mais dados e o programa continuará armazenando tudo que escrevermos no buffer. O código está funcionando como esperado, conseguimos guardar mais informações que o usuário escreve no console. Vamos fechar a aplicação.

**Armazenando em um arquivo**
Até agora, esses dados foram guardados no buffer. Vamos passar a armazená-los em um arquivo, com o FileStream. Primeiramente, precisaremos de um novo stream. Usaremos o using novamente para tratar possíveis exceções:

```csharp
using ByteBank_IO;
using System.Text;

partial class Program
{
    static void UsarStreamDeEntrada()
    {
        using (var fluxoDeEntrada = Console.OpenStandardInput())
        using (var fs = new FileStream("entradaConsole.txt", FileMode.Create))
        {
            var buffer = new byte[1024]; //1kb

            while(true)
            {
                var byteslidos = fluxoDeEntrada.Read(buffer, 0, 1024);
                Console.WriteLine($"Bytes lidos na console: {byteslidos}");
            }
        }
    }
}
```

Assim, empregamos o FileMode.Create para criar um arquivo de nome entradaConsole.txt. Para testar, vamos executar a aplicação. No console, digitaremos "Alura" e pressionaremos "Enter". Depois digitaremos "Cursos Online" e pressionaremos "Enter" novamente. O resultado será o seguinte:

Alura

Bytes lidos na console: 7

Cursos Online

Bytes lidos na console: 15

No Visual Studio, vamos parar a aplicação. Em seguida, vamos à pasta do executável para verificar se o arquivo foi criado e se as informações que digitamos no console foram inseridas nele. Basta abrir o Gerenciador de Soluções (Ctrl + Alt + L"), clicar com o botão direito sobre a solução, selecionar "Abrir Pasta no Gerenciador de Arquivos" e navegar até "ByteBank_IO > bin > Debug > net6.0".

Encontraremos o arquivo entradaConsole.txt. Ao abri-lo, notaremos que nada foi salvo nele, está em branco. Vamos voltar ao código para entender o que aconteceu.

No método UsarStreamDeEntrada, criamos um FileStream e, em seguida, ficamos "presos" no laço de repetição. O while(true) sempre será verdadeiro, então continuará esperando novas informações. Ou seja, o bloco using nunca chega ao fim e, consequentemente, o método Close não é chamado. Somente quando fechamos o stream, ele libera o buffer interno e o despeja no destino (o HD do computador).

Anteriormente, ao estudar o StreamWriter, aprendemos sobre a metodologia de despejamento de informação para evitar essa demora, então podemos reutilizá-la agora. Trata-se do método Flush. Dentro do laço while, usaremos o Write para escrever os dados e o Flush para despejá-las no arquivo-destino:

```csharp
using ByteBank_IO;
using System.Text;

partial class Program
{
    static void UsarStreamDeEntrada()
    {
        using (var fluxoDeEntrada = Console.OpenStandardInput())
        using (var fs = new FileStream("entradaConsole.txt", FileMode.Create))
        {
            var buffer = new byte[1024]; //1kb

            while(true)
            {
                var byteslidos = fluxoDeEntrada.Read(buffer, 0, 1024);

                fs.Write(buffer, 0, byteslidos);
                fs.Flush();

                Console.WriteLine($"Bytes lidos na console: {byteslidos}");
            }
        }
    }
}
```

Após salvar, vamos rodar a aplicação. No console, vamos digitar "Alura" e pressionar a tecla "Enter", depois escreveremos "Cursos Online" e apertaremos "Enter" mais uma vez. O retorno será:

Alura

Bytes lidos na console: 7

Cursos Online

Bytes lidos na console: 15

No Visual Studio, vamos parar a execução. Depois, acessaremos o arquivo entradaConsole.txt, na pasta do executável. Ao abri-lo, seu conteúdo será o seguinte:

Alura

Cursos Online

Alcançamos nosso objetivo: todas as informações que digitamos no console foram gravadas nesse documento. Desse modo, aprendemos a usar o stream do console em situações nas quais esperamos alguma interação do usuário, mais especificamente com o Open StandardInput. Agora, conseguimos armazenar em um arquivo informações inseridas pelo usuário no console.

### Aula 5: Auxiliares da classe File - Vídeo 2

Transcrição  
Será que, toda vez que precisarmos de um dado do usuário (como número da agência), teremos que manipular o stream de entrada e usar OpenStandardInput? Ou será necessário construir um bloco using com todos aqueles procedimentos que fizemos anteriormente?

**Descomplicando a entrada de dados**  
Na verdade, já trabalhamos com uma forma simples de obter entradas do usuário: o Console.ReadLine, que nos retorna uma string. Com esse método, aplicamos todos os conceitos de buffer, bytes e decodificação de maneira descomplicada.

Para ilustrar esse processo, vamos inserir o seguinte código no método Main, no arquivo Program.cs:

```csharp
static void Main(string [] args)
{
    Console.WriteLine("Digite seu nome:");
    var nome = Console.ReadLine();

    Console.WriteLine("Aplicação Finalizada ...");

    Console.ReadLine();
}
```

Ao executar a aplicação, teremos a mensagem "Digite seu nome" no console. Ao digitar um nome (por exemplo, "Larissa") e pressionar a tecla "Enter", o retorno será o seguinte:

Digite seu nome":

Larissa

Aplicação Finalizada ...

Assim, armazenamos esse texto em uma variável.

Ou seja, o código que desenvolvemos na aula passada faz o mesmo que o Console.ReadLine. Agora, sabemos que o ReadLine usa a stream de entrada do console, que fica vigilante até o momento em que for pressionado um caractere de quebra de linha (a tecla "Enter"). Então, será realizado o encoding da cadeia de bytes e a string será enviada.

**Descomplicando a leitura de arquivos**  
Descobrimos como lidar de maneira mais simples com entradas do usuário, com o Console.ReadLine. E quantos aos arquivos? Será que existem recursos que facilitam nosso trabalho com eles? Precisaremos sempre usar o stream e o BinaryReader, por exemplo?

No C#, temos uma classe estática chamada File, que possui uma série de métodos que nos ajudarão em tarefas relacionadas a arquivos, por exemplo, ler todas as linhas de um documento. A seguir, vamos explorar a utilização dessa classe e seus métodos, além de apontar em que momentos é importante tomar cuidado, pois existem cenários em que não é ideal empregar a classe File.

No método Main, vamos inserir um código com vários métodos da classe File, inicialmente comentados. Na sequência, vamos estudá-los e testá-los um a um:

```csharp
static void Main(string [] args)
{
    //Console.WriteLine("Digite seu nome:");
    //var nome = Console.ReadLine();

    //var linhas = File.ReadAllLines("contas.txt");
    Console.WriteLine(linhas.Length);

    /*
    foreach (var linha in linhas)
    {
        Console.WriteLine(linha);
    }
    */

    //var bytesArquivo = File.ReadAllBytes("contas.txt");
    //Console.WriteLine($"Arquivo contas.txt possui {bytesArquivo.Length} bytes");

    //File.WriteAllText("escrevendoComClasseFile.txt", "Testando File.WriteAllText");

    Console.WriteLine("Aplicação Finalizada ...");

    Console.ReadLine();
}
```

Para contar o número de linhas de determinado arquivo, criamos uma variável chamada linhas. Ela armazenará o retorno do método ReadAllLines, da classe File. Este método recebe como argumento o caminho do arquivo (no caso, "contas.txt") e retornará um array de strings com todas as linhas desse documento.

Na linha seguinte, empregamos o Console.WriteLine para exibir quantas linhas temos no arquivo contas.txt, usando a propriedade Length. Vamos descomentar essa linha e a anterior:

```csharp
static void Main(string [] args)
{
    //Console.WriteLine("Digite seu nome:");
    //var nome = Console.ReadLine();

    var linhas = File.ReadAllLines("contas.txt");
    Console.WriteLine(linhas.Length);

    /*
    foreach (var linha in linhas)
    {
        Console.WriteLine(linha);
    }
    */

    //var bytesArquivo = File.ReadAllBytes("contas.txt");
    //Console.WriteLine($"Arquivo contas.txt possui {bytesArquivo.Length} bytes");

    //File.WriteAllText("escrevendoComClasseFile.txt", "Testando File.WriteAllText");

    Console.WriteLine("Aplicação Finalizada ...");

    Console.ReadLine();
}
```

Após salvar as alterações, vamos executar a aplicação. No console, teremos o seguinte resultado:

1000

Aplicação Finalizada ...

Ou seja, temos 1000 linhas no arquivo contas.txt. Vamos parar o programa.

Para mostrar o conteúdo desse documento linha a linha, podemos utilizar um loop. Vamos descomentar o bloco foreach:

```csharp
static void Main(string [] args)
{
    //Console.WriteLine("Digite seu nome:");
    //var nome = Console.ReadLine();

    var linhas = File.ReadAllLines("contas.txt");
    Console.WriteLine(linhas.Length);
    foreach (var linha in linhas)
    {
        Console.WriteLine(linha);
    }
    //var bytesArquivo = File.ReadAllBytes("contas.txt");
    //Console.WriteLine($"Arquivo contas.txt possui {bytesArquivo.Length} bytes");

    //File.WriteAllText("escrevendoComClasseFile.txt", "Testando File.WriteAllText");

    Console.WriteLine("Aplicação Finalizada ...");

    Console.ReadLine();
}
```

Executando a aplicação, visualizaremos todo o conteúdo do arquivo no console, isto é, a lista completa dos clientes. Além disso, continuamos exibindo o número 1000 na primeira linha, referente à quantidade de linhas. Vamos parar novamente a aplicação e comentar o loop, assim não exibiremos todo o conteúdo do arquivo nos próximos testes:

```csharp
static void Main(string [] args)
{
    //Console.WriteLine("Digite seu nome:");
    //var nome = Console.ReadLine();

    var linhas = File.ReadAllLines("contas.txt");
    Console.WriteLine(linhas.Length);
    /*
    foreach (var linha in linhas)
    {
        Console.WriteLine(linha);
    }
    */
    //var bytesArquivo = File.ReadAllBytes("contas.txt");
    //Console.WriteLine($"Arquivo contas.txt possui {bytesArquivo.Length} bytes");

    //File.WriteAllText("escrevendoComClasseFile.txt", "Testando File.WriteAllText");

    Console.WriteLine("Aplicação Finalizada ...");

    Console.ReadLine();
}
```

Semelhante ao ReadAllLines, também contamos com o método ReadAllBytes, responsável pela leitura dos bytes do arquivo. Para verificar a quantidade de bytes em contas.txt, vamos descomentar a linha em que declaramos a variável bytesArquivo e o Console.WriteLine que aparece na sequência:

```csharp
static void Main(string [] args)
{
    //Console.WriteLine("Digite seu nome:");
    //var nome = Console.ReadLine();
    var linhas = File.ReadAllLines("contas.txt");
    Console.WriteLine(linhas.Length);
    /*
    foreach (var linha in linhas)
    {
        Console.WriteLine(linha);
    }
    */
    var bytesArquivo = File.ReadAllBytes("contas.txt");
    Console.WriteLine($"Arquivo contas.txt possui {bytesArquivo.Length} bytes");

    //File.WriteAllText("escrevendoComClasseFile.txt", "Testando File.WriteAllText");

    Console.WriteLine("Aplicação Finalizada ...");

    Console.ReadLine();
}
```

Ao compilar e executar a aplicação, o resultado no console será:

1000

Arquivo contas.txt possui 25166 bytes

Aplicação Finalizada ...

Desse modo, constatamos que temos 1000 linhas e 25166 bytes no arquivo contas.txt. Vamos parar a aplicação novamente.

**Descomplicando a gravação em arquivos**  
Por fim, temos o método WriteAllText, que criará um arquivo e gravará informações nele. Vamos descomentar a chamada a esse método:

```csharp
static void Main(string [] args)
{
    //Console.WriteLine("Digite seu nome:");
    //var nome = Console.ReadLine();
    var linhas = File.ReadAllLines("contas.txt");
    Console.WriteLine(linhas.Length);
    /*
    foreach (var linha in linhas)
    {
        Console.WriteLine(linha);
    }
    */
    var bytesArquivo = File.ReadAllBytes("contas.txt");
    Console.WriteLine($"Arquivo contas.txt possui {bytesArquivo.Length} bytes");

    File.WriteAllText("escrevendoComClasseFile.txt", "Testando File.WriteAllText");

    Console.WriteLine("Aplicação Finalizada ...");

    Console.ReadLine();
}
```

Ao rodar a aplicação, o resultado no console será igual ao da última execução. Porém, ao acessar o gerenciador de arquivos na pasta do executável, encontraremos um documento chamado escrevendoComAClasseFile.txt. Ao abri-lo no Bloco de Notas, teremos o seguinte conteúdo:

Testando File.WriteAllText

O WriteAllText cria um arquivo já com uma mensagem, conforme os argumentos que informamos. Para mensagens curtas, esse método é um recurso interessante. Para mensagens longas, já não é tão indicado.

Todos os métodos que estudamos nessa aula facilitam nosso trabalho ao lidar com arquivos, porém é essencial ter certos cuidados. Se quiséssemos ler todo o texto de um documento, por exemplo, uma opção seria o método ReadAllText. Ele retorna uma string com todo o conteúdo de um arquivo, porém essa prática vai contra nosso objetivo de não ler arquivos de uma única vez, especialmente se forem grandes. Para arquivos pequenos, esse método é uma boa opção.

É importante avaliar cada contexto para optar pela melhor estratégia. Haverá casos em que será mais interessante ter um controle mais preciso do buffer e das posições ocupadas nele, por exemplo. Por isso, é importante entendermos o funcionamento dessas classes e desses métodos.

### Aula 5: Lidando com arquivos - Exercício

Carlos quer lidar com arquivos por meio dos métodos auxiliares da classe File:

```csharp
var arquivo = "teste.txt";

string todoDocumento = File. [    ] (arquivo, Encoding.UTF8);
byte[] todosOsBytes = File.ReadAllBytes( [    ] );
string[] todasAsLinhas = File. [    ] (arquivo, Encoding.UTF8);
```

Selecione a alternativa que corresponde a como devemos preencher os espaços [ ] para o código funcionar.

Resposta:  
ReadAllText, arquivo e ReadAllLines.

> Isso mesmo! Ambos os métodos existem na classe File e além disso utilizam o encoding.

### Aula 5: Faça como eu fiz

Uma forma de trabalhar com arquivos pequenos com mais agilidade e facilidade, é por meio dos métodos auxiliares da classe File. Bora utilizar esses métodos na nossa aplicação?

Opinião do instrutor

1) Nesta aula começamos usando um stream diferente do FileStream. O Stream de entrada da Console:

```csharp
using (var fluxoDeEntrada = Console.OpenStandardInput())
{
}
```

Para trabalhar com esse stream, vamos criar um buffer de 1kb:

```csharp
using (var fluxoDeEntrada = Console.OpenStandardInput())
{
    var buffer = new byte[1024]; // 1 kb
```

Agora, em um laço While vamos verificar o que o usuário digita na Console:

```csharp
while(true)
{
    var bytesLidos = fluxoDeEntrada.Read(buffer, 0, 1024);
    Console.WriteLine($"Bytes lidos da console: {bytesLidos}");
}
```

Teste a aplicação. Digite na console, dê enter e observe a saída! Note que estamos trabalhando diretamente com o stream de entrada da Console.

2) Podemos ainda redirecionar a entrada da Console para a saída em um arquivo, basta criarmos um FileStream e reutilizar o buffer:

```csharp
using (var fluxoDeEntrada = Console.OpenStandardInput())
using (var fs = new FileStream("entradaConsole.txt", FileMode.Create))
{
    var buffer = new byte[1024]; // 1 kb

    while (true)
    {
        var bytesLidos = fluxoDeEntrada.Read(buffer, 0, 1024);

        fs.Write(buffer, 0, bytesLidos);

        Console.WriteLine($"Bytes lidos da console: {bytesLidos}");
    }
}
```

Contudo, para nosso arquivo ser atualizado, é preciso liberar o buffer interno da FileStream com o uso do método Flush:

```csharp
fs.Write(buffer, 0, bytesLidos);
fs.Flush();
```

3) Mas para obter informações da Console, raramente utilizamos o Stream. Usamos o retorno do método Console.ReadLine(); - uma string:

```csharp
Console.WriteLine("Digite seu nome:");
string nome = Console.ReadLine();

Console.WriteLine($"Olá, {nome}");
```

4) Uma forma de trabalhar com arquivos pequenos com mais agilidade e facilidade, é por meio dos métodos auxiliares da classe File:

```csharp
File.WriteAllText("escrevendoComAClasseFile.txt", "Testando File.WriteAllText");
Console.WriteLine("Arquivo escrevendoComAClasseFile.txt criado!");

var bytesArquivo = File.ReadAllBytes("contas.txt");
Console.WriteLine($"Arquivo contas.txt possui {bytesArquivo.Length} bytes");

var linhas = File.ReadAllLines("contas.txt");
Console.WriteLine(linhas.Length);
```

### Aula 5: Projeto final do curso

Você pode baixar os códigos que desenvolvemos no curso em [zip neste link](https://github.com/alura-cursos/CsharpArquivos/archive/refs/heads/aula-5.zip) ou acessar o repositório da [aula no GitHub!](https://github.com/alura-cursos/CsharpArquivos/tree/aula-5)

### Aula 5: O que aprendemos?

Nessa aula, você aprendeu:

- Como a console funciona com streams;
- O método Console.OpenStandardInput() e como ele adquire o fluxo de entrada padrão;
- Métodos auxiliares na classe File ajudam na criação, cópia, abertura, dentre outras ações referentes a um arquivo.

### Aula 5: Conclusão - Vídeo

Transcrição  
Parabéns por chegar ao final deste treinamento! Fico muito feliz que você tenha encarado comigo este desafio de lidar com arquivos, utilizando a linguagem C#. A seguir, vamos fazer um resumo do que estudamos neste curso.

Começamos criando um file stream por meio do Open e conseguimos ler nosso arquivo, criando o buffer e o passando ao método Read. Inclusive, tivemos toda a preocupação com os intervalos que esse método pode usar para gravar os dados do buffer.

De início, visualizamos apenas os bytes, o que não era muito útil para nós. Então, partimos para a decodificação desses dados para exibir um texto. Para realizar essa conversão, trabalhamos com a classe Encoding. Conhecemos o Unicode, o conceito de code point e nos aprofundamos nos formatos de transformação, como UTF-8 e UTF-32. Com o método GetString, conseguimos converter a cadeia de bytes para string.

Mais adiante, aprendemos sobre o StreamReader, para que não tenhamos que nos preocupar sempre com o buffer, seus intervalos e o Encoding. Exploramos como ler linhas e mostrar mensagens no console referentes ao conteúdo do arquivo, desenvolvendo um código para converter strings em ContaCorrente. Nesse processo, utilizamos o Parse para transformar strings em números inteiros e double, e também usamos o método Replace. Assim, conseguimos trazer o conteúdo do arquivo para dentro do nosso código e mostrá-lo no console.

Depois, exploramos como criar arquivos e inserir informações neles, utilizando o FileMode.Create. Desenvolvemos o método CriarArquivo empregando o GetBytes, semelhante ao GetString. Também aprendemos sobre o funcionamento de arquivos binários e como eles podem nos ajudar a otimizar o uso de memória do computador. Descobrimos como fazer tanto a escrita quanto a leitura de arquivos binários, com BinaryWriter e BinaryReader. Desse modo, pudemos mostrar as informações do arquivo binário no nosso console de forma legível para nós.

Por fim, exploramos o stream do console. Armazenamos os dados inseridos pelo usuário em arquivos, usando o OpenStandardInput. Ademais, também aprendemos sobre o método Flush, responsável por despejar diretamente no stream.

Trabalhamos diversos conceitos nesse curso! Agora, você é capaz de lidar com arquivos dentro do ecossistema .NET. Espero que você tenha gostado do treinamento, te espero nos próximos cursos.
