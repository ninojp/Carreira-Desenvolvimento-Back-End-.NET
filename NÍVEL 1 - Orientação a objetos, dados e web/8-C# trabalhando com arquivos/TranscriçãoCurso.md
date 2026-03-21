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

### Aula 3:  - Vídeo 1
### Aula 3:  - Vídeo 1
