# Curso Alura C#: Praticando C# variáveis e tipos

## Aula 1 - Variaveis e tipos

### Aula 1 - O que esperar deste curso?

Antes de mergulharmos no código, que tal alinharmos as expectativas?

O que significa um curso prático?

Já se pegou pensando — será que consigo aplicar o que aprendi na prática? Este curso é a sua resposta. Aqui, o foco é colocar a mão no código, resolver problemas e testar seu conhecimento de forma ativa. Você terá:

- Vídeo de revisão do conteúdo
- Material de apoio
- Desafios de código

Pré requisitos  
É importante ter concluído o curso C#: [criando sua primeira aplicação](https://cursos.alura.com.br/course/csharp-criando-primeira-aplicacao), pois ele cobre os fundamentos da linguagem, garantindo que você consiga realizar os exercícios deste curso com mais segurança.

Dicas para potencializar seu aprendizado neste curso

- Assista ao vídeo de revisão com atenção. Pause, anote e revise sempre que necessário.
- Baixe o material complementar para ter um apoio nas atividades.
- Faça os desafios na sua IDE favorita.
- Compartilhe o que aprendeu no fórum, pois sua abordagem pode inspirar outras pessoas.

> Vamos começar?

### Aula 1 - Apresentação - Vídeo 1

Transcrição  
Boas-vindas! Meu nome é Iasmin Araújo, sou instrutora na escola de Programação da Alura, e irei te acompanhar ao longo dessa jornada de aprendizagem.

Audiodescrição: Iasmin se descreve como uma mulher branca, de olhos verdes, cabelo castanho-escuro longo e liso, e sobrancelhas castanho-escuras. Ela veste uma blusa bege e está sentada em frenta a uma parede iluminada em gradiente azul.

O que vamos aprender?  
Neste curso, vamos falar sobre variáveis e tipos. Aprenderemos diversos tópicos e conceitos fundamentais relacionados a este tema, entre eles:

O que são variáveis;

- Declaração e inicialização de variáveis;
- A diferença entre cada uma dessas etapas;
- O padrão de nomenclatura específico do C#;
- Os tipos primitivos e referenciados, bem como a diferença entre eles;
- Os diversos operadores aritméticos;
- A palavra-chave var;
- E como trabalhar com a conversão de tipos.

Conclusão

No próximo vídeo, comentaremos detalhadamente esses conceitos, para podermos realizar os exercícios propostos e aprofundar ainda mais esses conhecimentos.

Nos encontramos na sequência!

### Aula 1 - Preparando o ambiente: instalando o Visual Studio

Olá!  
O IDE do Visual Studio é uma plataforma de lançamento criativa que você pode usar para editar, depurar e criar código e, em seguida, publicar um aplicativo. Além do editor e depurador padrão fornecidos pela maioria dos IDEs, o Visual Studio inclui compiladores, ferramentas de conclusão de código, designers gráficos e muitos outros recursos para aprimorar o processo de desenvolvimento de software. O IDE mais abrangente para desenvolvedores .NET no Windows e Mac para criação de web, nuvem, desktop, aplicativos móveis, serviços e jogos.

Sabendo disso, preparamos alguns vídeos para instalar em diferentes sistemas operacionais. Para este curso em específico, marque a opção Desenvolvimento para Desktop com .NET. no processo de instalação.

Videos internos da plataforma: (sem link externo)

Visual Studio no Windows

Visual Studio no Mac

C# no VSCODE (SDK)

C# em distribuições Linux

[Neste link](https://learn.microsoft.com/pt-br/dotnet/core/install/linux), você encontra um passo a passo da própria Microsoft de como instalar em distribuições Linux, como Alpine, CentOS, Debian, entre outras.

Vamos começar?

### Aula 1 - Preparando o ambiente: material de apoio

Após revisar os conceitos variáveis e tipos em C#, é hora de colocar o conhecimento em prática com uma série de atividades focadas no tema. Caso queira acessar os slides da revisão, eles estão disponíveis no link abaixo:

[Baixe os slides do curso](https://cdn3.gnarususercontent.com.br/4567-Praticando%20CVari%C3%A1veis%20e%20tipos/Praticando%20C%23%20-%20Vari%C3%A1veis%20e%20tipos.pptx.pdf)

Após finalizar todos os desafios, não esqueça de compartilhar sua solução no fórum. Será incrível ver como você resolveu!

Vamos nessa?

### Aula 1 - Variáveis e tipos - Vídeo 1

Transcrição  
Neste vídeo, falaremos sobre variáveis e tipos.

Variáveis e tipos

O que são variáveis?  
Para começarmos a discutir sobre variáveis e tipos, é essencial entender o que são variáveis.

As variáveis são uma forma de indicarmos à linguagem de programação utilizada que desejamos armazenar algum dado na memória.

Por exemplo: trabalhando em um sistema de estoques de produtos, queremos um programa que armazene o valor do estoque, ou seja, a quantidade de produtos. Essa quantidade será atualizada ao longo do tempo, pois podemos retirar ou repor produtos. Portanto, ao armazenar essas informações, é útil trabalhar com variáveis.

Exemplo de uso de variáveis  
Abaixo, temos um exemplo de como poderíamos utilizar uma variável para representar a quantidade de produtos. Nesse caso, definimos um int quantidadeDeProdutos que recebe o valor 42, indicando que o estoque possui 42 produtos.

> int quantidadeProdutos = 42;

Quais são as vantagens das variáveis?  
A vantagem de trabalharmos com variáveis é a seguinte: o computador entende apenas números, então podemos instruí-lo a armazenar um dado na memória. Com isso, ele nos fornecerá um endereço, como 934587, por exemplo, para armazenar esse dado.

No entanto, para nós, seres humanos, é difícil memorizar endereços numéricos. É mais fácil trabalharmos com nomes. A linguagem de programação faz a ponte entre nós e o computador, permitindo nomear variáveis e endereços de memória.

Representação de memória  
A tabela abaixo representa uma memória com vários endereços. No endereço 121, temos a quantidadeDeProdutos, que armazena o tipo int e o valor 42.

Memória:

| Endereço | Variável | Conteúdo |
|----------|----------|----------|
| 119 | - | - |
| 120 | - | - |
| 121 | int QuantidadeProdutos | 42 |
| 122 | - | - |
| 123 | - | - |

Essa ponte é feita pela linguagem de programação, que, no nosso caso, é o C♯.

Sintaxe de declaração de variáveis
Para trabalhar com variáveis em C♯, seguimos um padrão, ou sintaxe, para declarar essas variáveis. Nessa sintaxe, sempre temos um tipo de variável no começo, seguido pelo nome da variável, o operador de atribuição = e, por fim, o dado que queremos armazenar na memória.

> tipo nomeVariavel = dado;

Conhecendo os tipos de dados

Existem dois grupos de tipos de dados:

> Os tipos primitivos;
> E os tipos referenciados.

Os tipos primitivos são disponibilizados por padrão na linguagem. Se quisermos escrever nosso primeiro programa, por exemplo, podemos utilizar tipos primitivos.

Já os tipos referenciados são aqueles que criamos, geralmente usando classes. Vamos entender melhor os tipos referenciados ao trabalharmos com orientação a objetos.

Por enquanto, vamos focar nos tipos primitivos.

Tipos primitivos  
Quando falamos em tipos primitivos, existem vários disponíveis. Abaixo, trouxemos uma tabela contendo alguns desses tipos e exemplos:

| Tipo | Valores possíveis | Exemplo |
|------|-------------------|---------|
| bool | true ou false | bool ativo = true; |
| char | caracteres unicode | char inicial = 'A'; |
| byte | 0 a 255 | byte idade = 25; |
| sbyte | -128 a 127 | sbyte temperatura = -5; |
| short | -32.768 a 32.767 | short numeroCurto = 1000; |
| ushort | 0 a 65.535 | ushort codigoProduto = 500; |
| int | -2.147.483.648 a 2.147.483.647 | int contador = 100; |
| uint | 0 a 4.294.967.295 | uint populacao = 50000; |
| long | -9.223.372.036.854.775.808 a 9.223.372.036.854.775.807 | long distancia = 1000000000; |
| ulong | 0 a 18.446.744.073.709.551.615 | ulong estrelas = 9999999999; |
| float | ±1,5 × 10⁻⁴⁵ a ±3,4 × 10³⁸ | float altura = 1.75f; |
| double | ±5,0 × 10⁻³²⁴ a ±1,7 × 10³⁰⁸ | double peso = 72.5; |
| decimal | ±1,0 × 10⁻²⁸ a ±7,9 × 10²⁸ | decimal preco = 199.99m; |

Podemos ter o bool, para valores booleanos (true ou false). Também temos o tipo char, para tratar caracteres. Se quisermos armazenar um único caractere unicode, podemos usar o tipo char.

Além disso, existem vários tipos numéricos. Para números inteiros, temos byte, sbyte, short, ushort, int, uint, long e ulong. A diferença entre eles está nos intervalos que armazenam.

Por exemplo: o byte armazena valores de 0 a 255, enquanto o long armazena um número extremamente grande. Cada tipo pode ter intervalos diferentes.

Quanto maior o intervalo que um tipo pode representar, maior é o espaço alocado na memória. Portanto, é importante escolher bem o tipo que será usado.

Alocar uma variável do tipo long para representar, por exemplo, o número 10, que poderia ser facilmente representado por um byte, não é eficiente.

É essencial sempre conhecer o nosso problema para propor uma solução que consuma menos memória, evitando problemas desse tipo.

Além dos tipos inteiros, também temos os tipos de ponto flutuante float, double e decimal. Pontos flutuantes são números com vírgula, ou seja, números com casas decimais.

A diferença entre esses tipos está na precisão. O float é o tipo com menor precisão, enquanto o decimal é o tipo com a maior precisão possível ao representar números. Já o tipo decimal é frequentemente utilizado em cálculos financeiros para maior precisão, evitando prejuízo. É importante conhecer cada caso para escolher o tipo mais adequado.

Strings e tipos referenciados  
Uma observação interessante sobre os tipos primitivos é que as strings não estão incluídas entre eles. Embora utilizemos string desde os programas mais básicos, elas são um tipo referenciado. Vamos explorar mais sobre strings em outro curso; o foco agora serão os tipos primitivos.

Praticando no Visual Studio  
Agora, vamos praticar no Visual Studio. Podemos começar declarando no arquivo Program.cs a variável mencionada como exemplo anteriormente.

Nesse caso, precisamos declarar um int quantidadeProdutos recebendo 42.

Program.cs:

> int quantidadeProdutos = 42;

Note que a variável quantidadeProdutos está escrita em camel case, onde a primeira palavra é iniciada em minúsculo e a segunda em maiúsculo. Esse padrão é utilizado quando temos várias palavras compondo o nome das variáveis.

Declaração e inicialização de variáveis  
Ao falarmos sobre declaração de variáveis, é importante entender a diferença entre declaração e inicialização. No exemplo acima, temos a declaração e a inicialização juntas, mas elas podem ser separadas. Para isso, basta declarar uma variável int chamada quantidade, por exemplo.

int quantidadeProdutos = 42;

int quantidade;

Isso indica ao compilador que deve reservar um espaço na memória, mas esse espaço não está preenchido até fazermos uma atribuição, como quantidade = 42.

// código omitido

int quantidade;
quantidade = 42;

Inferência de tipos com var  
Conhecer a diferença entre inicialização e atribuição é essencial. Precisamos sempre de um tipo, o nome e o dado. O C# tem como recurso a palavra-chave var, que não é um tipo, mas indica ao C# que ele deve inferir o tipo da variável.

Por exemplo: ao declarar var letra = 'A', o compilador infere que letra é do tipo char, pois a variável foi declarada e inicializada na mesma linha.

```C#
// código omitido

int quantidade;
quantidade = 42;

var letra = 'A';
```

Observação: se removêssemos a atribuição, isto é, o trecho = 'A', o compilador reclamaria um erro no código, pois precisa dela para entender o tipo.

Operadores aritméticos  
Vamos discutir outros aspectos dos tipos primitivos? Em relação aos tipos numéricos, é importante conhecer os operadores aritméticos, como adição, subtração, multiplicação, divisão e módulo.

| Operador | Significado | Exemplo | Resultado |
| --- | --- | --- | --- |
| + | Adição | 5 + 3 | 8 |
| - | Subtração | 10 - 4 | 6 |
| * | Multiplicação | 6 * 2 | 12 |
| / | Divisão | 10 / 2 | 5 |
| % | Módulo (resto da divisão) | 10 % 3 | 1 |
| ++ | Incremento (+1) | int x = 5; x++; | x = 6 |
| -- | Decremento (-1) | int y =8; y--; | y = 7 |

Por exemplo, 10 % 3 resulta em 1. Esse operador aritmético é útil para determinar se um número é par ou ímpar. Além disso, temos o incremento (++) e o decremento (--). O incremento adiciona 1 à variável, enquanto o decremento subtrai 1.

Simulando no código  
Com os operadores aritméticos em mente, podemos simular no código.

No momento, temos a variável quantidadeProdutos recebendo o valor 42. Podemos imprimir essa variável com Console.WriteLine() para verificar o que acontece.

```C#
// código omitido
var letra = 'A';

Console.WriteLine(quantidadeProdutos);
```

Feito isso, logo abaixo, chamaremos a variável quantidadeProdutos seguida do operador aritmético ++, para incremento. Por fim, vamos imprimi-la novamente.

```C#
// código omitido
Console.WriteLine(quantidadeProdutos);
quantidadeProdutos++;
Console.WriteLine(quantidadeProdutos);
```

Ao executar o código, o resultado inicial no terminal é 42, e após o incremento, 43. Assim, aprendemos como funciona o operador de incremento.

Conclusão
Nos encontramos no próximo vídeo, onde falaremos sobre conversão de tipos!

### Aula 1 - Conversão de tipos - Vídeo 2

Transcrição  
Neste vídeo, trabalharemos com a conversão de tipos.

Conversão de tipos

Conversão de tipos numéricos  
Uma questão interessante ao trabalhar com tipos numéricos é a conversão de tipos. Em Program.cs, temos a declaração da variável int quantidade, que pode ser convertida em tipos maiores.

Program.cs:

```C#
int quantidadeProdutos = 42;

int quantidade;
quantidade = 42;

var letra = 'A';

Console.WriteLine(quantidadeProdutos);
quantidadeProdutos++;
Console.WriteLine(quantidadeProdutos);
```

Se quisermos criar um tipo long, por exemplo, ao final do código, podemos adicionar long quantidade2, recebendo a variável anterior quantidade.

```C#
// código omitido

long quantidade2 = quantidade;
```

Conversão explícita para tipos menores  
A atribuição anterior pode ser realizada normalmente, mas se quisermos criar um tipo menor do que int quantidade, como um byte quantidade3, por exemplo, o compilador não permitirá, pois estamos tentando fazer um tipo maior caber em um tipo menor.

```C#
// código omitido

long quantidade2 = quantidade;
byte quantidade3 = quantidade;
```

Para resolver isso, precisamos realizar uma conversão explícita. Para fazer essa conversão, declaramos byte entre parênteses logo após a atribuição:

```C#
// código omitido

long quantidade2 = quantidade;
byte quantidade3 = (byte) quantidade;
```

Assim, temos dois tipos de conversões:

- A conversão **implícita**, de um tipo menor para um tipo maior;
- E a conversão **explícita**, de um tipo maior para um tipo menor. Nessa conversão, é necessário colocar o tipo entre parênteses antes da atribuição.

Truncamento em divisões inteiras  
Outra questão interessante ao trabalharmos com conversões é o truncamento.

Suponha que um cliente fez uma compra de 4 produtos no valor de R$ 28,00. Temos o valor total de R$ 28,00, mas queremos saber o valor unitário. Para isso, vamos declarar ao final do código int valorUnitario, que será 28 dividido por 4, quantidade total dividida pelo número de produtos.

```C#
// código omitido

long quantidade2 = quantidade;
byte quantidade3 = (byte) quantidade;

int valorUnitario = 28 / 4;
```

Se executarmos Console.WriteLine(valorUnitario), tudo ocorrerá normalmente. Ao executar o programa, teremos os retornos de 42 e 43, do teste anterior, e o 7, que é o valor de cada produto.

```C#
// código omitido

int valorUnitario = 28 / 4;
Console.WriteLine(valorUnitario);
```

Problemas com divisão de inteiros  
Por outro lado, se trabalharmos com R$ 30,00 no cálculo de valorUnitario, ao dividir por 4, obtemos R$ 7,50. Assim, temos um valor decimal.

Armazenando esse valor em uma variável do tipo int, não haverá alteração, pois fizemos uma divisão entre inteiros e atribuímos o resultado a um inteiro.

```C#
// código omitido
int valorUnitario = 30 / 4;
Console.WriteLine(valorUnitario);
```

Nesse caso, a variável resultante da divisão deve ser do tipo double ou float. Vamos declarar um double e executar novamente para verificar o resultado:

```C#
// código omitido
double valorUnitario = 30 / 4;
Console.WriteLine(valorUnitario);
```

Assim como antes, obtivemos 42, 43 e 7. Vamos verificar o que aconteceu?

Divisão correta com decimais  
Mesmo declarando o tipo double para valorUnitario, o compilador interpreta a operação como uma divisão entre inteiros, resultando em um inteiro. Portanto, o compilador interfere na execução. Nesse cenário, precisamos indicar que realizamos uma divisão entre variáveis double. Para isso, um dos números, 30 ou 4, deve ser declarado como decimal, utilizando .0.

```C#
// código omitido
double valorUnitario = 30.0 / 4;
Console.WriteLine(valorUnitario);
```

Assim, ao dividir 30.0 por 4, obtemos 42, 43 e 7,5. Conseguimos atribuir um valor double após a divisão apenas quando os números envolvidos também são double.

Se dividirmos 30 por 4.0, o resultado também será correto:

```C#
// código omitido
double valorUnitario = 30 / 4.0;
Console.WriteLine(valorUnitario);
```

Pelo menos um número deve ser decimal para que as conversões sejam possíveis.

Conclusão  
Neste vídeo, discutimos as conversões entre tipos inteiros e decimais, abordando conceitos importantes sobre variáveis e tipos. Lembre-se que devemos ter atenção às conversões implícitas.

Para fixar o conteúdo abordado nos vídeos, é essencial praticar. Disponibilizamos uma série de exercícios para que você possa reforçar os aprendizados adquiridos. Bons estudos!

### Aula 1 -  - Vídeo 1
### Aula 1 -  - Vídeo 1
