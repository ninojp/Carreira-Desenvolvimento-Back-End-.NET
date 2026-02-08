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

### Aula 1 - Calculando a idade - Desafio 1

Imagine que você está desenvolvendo um sistema para um cadastro de usuários. Uma das funcionalidades desse sistema é calcular a idade do usuário para oferecer conteúdo e serviços adequados à sua faixa etária.

Escreva um programa em C# que, a partir do ano de nascimento de uma pessoa, calcule a idade com base no ano atual.

Exemplo de entrada:

> int anoNascimento = 1997;

Saída esperada:

> Supondo que o ano atual seja 2025.

Sua idade é: 28 anos

Opinião do instrutor

Nessa atividade, exploramos o tipo int (inteiro) e a subtração usando o operador -. O objetivo foi calcular a idade de uma pessoa com base no ano de nascimento e no ano atual. Para isso:

- Declaramos duas variáveis: uma para armazenar o ano de nascimento e outra para armazenar o ano atual.
- Utilizamos o operador de subtração (-) para calcular a diferença entre o ano atual e o ano de nascimento, obtendo assim a idade.
- E por fim, exibimos a resultado através do Console.WriteLine.

```C#
int anoNascimento = 1997; 
int anoAtual = 2025; 

int idade = anoAtual - anoNascimento; 

Console.WriteLine("Sua idade é: " + idade + " anos"); 
```

Agora é sua vez! Teste o programa, compartilhe no fórum e compare sua lógica com outras soluções.

### Aula 1 - Registro de doações - Desafio 2

Você foi contratado por uma empresa beneficente, que recebe doações de pessoas físicas e jurídicas para ajudar comunidades carentes. Algumas dessas doações são anônimas, e outras são registradas com os dados do doador. Além disso, as doações são depositadas em dois tipos de contas: corrente ou poupança. Recentemente, uma doação anônima no valor de R$500 foi feita para a conta poupança da empresa.

Crie um programa que:

- Declare uma variável para armazenar o valor recebido da doação.
- Declare uma variável para indicar se a doação foi anônima (true para anônima, false para não anônima).
- Declare uma variável para indicar o tipo de conta onde o valor foi depositado:
  - Use P para conta poupança.
  - Use C para conta corrente

Saída esperada:

Valor recebido: R$500
Doação anônima: True
Tipo de conta: P

Opinião do instrutor

Nessa atividade, utilizamos variáveis de tipos diferentes (float, bool, char) para representar as informações no sistema de registro de doações.

- valorRecebido para armazenar o valor da doação (em reais).
- doacaoAnonima para indicar se a doação foi feita anonimamente.
- tipoConta para definir se o depósito foi feito em conta corrente ou poupança.

```C#
float valorRecebido = 500.00f; 
bool doacaoAnonima = true; 
char tipoConta = 'P'; 

Console.WriteLine("Valor recebido: R$" + valorRecebido); 
Console.WriteLine("Doação anônima: " + doacaoAnonima); 
Console.WriteLine("Tipo de conta: " + tipoConta); 
```

Uma curiosidade é que em C#, a convenção adotada para nomes de variáveis é o camelCase, onde a primeira palavra começa com letra minúscula e as seguintes com maiúscula, sem espaços. Isso melhora a legibilidade e mantém o código padronizado.

No exemplo, as variáveis já seguem essa convenção (valorRecebido, doacaoAnonima, tipoConta ), o que facilita a manutenção e compreensão do código. Sempre que possível, é recomendado seguir essas boas práticas ao nomear variáveis!

Agora é sua vez! Teste o programa, compartilhe no fórum e compare sua lógica com outras soluções.

### Aula 1 - Convertendo distâncias - Desafio 3

Você trabalha para uma empresa de turismo que organiza passeios e viagens internacionais. Muitos dos destinos oferecidos pela empresa utilizam o sistema imperial de medidas, onde as distâncias são fornecidas em milhas. No entanto, os clientes brasileiros estão mais familiarizados com o sistema métrico, que utiliza quilômetros.

Para facilitar a comunicação com os clientes, sua missão é criar um sistema de conversão de distâncias que transforme milhas em quilômetros, utilizando a fórmula:

> 1 milha = 1.60934 quilômetros.

Crie um programa que:

- Declare uma variável que receba o valor das milhas.
- Calcule a distância em quilômetros e armazene o resultado em uma nova variável.
- Exiba o resultado no console.

Saída esperada:

> 10 milhas equivalem a 16,0934 quilômetros.

Opinião do instrutor

Nessa atividade, utilizamos variáveis do tipo double para representar valores decimais. A conversão de milhas para quilômetros é um exemplo clássico de aplicação de fórmulas matemáticas em programação. O valor das milhas é multiplicado por 1.60934, que representa quantos quilômetros equivalem a uma milha. Esse cálculo é armazenado na variável quilometros, que guarda o resultado dessa conversão, o valor pode então ser exibido no console, mostrando a distância convertida.

Na expressão quilometros = milhas * 1.60934, o operador * (asterisco) realiza a multiplicação entre os valores, e o resultado é atribuído à variável quilômetros. Esse valor pode então ser exibido no console, mostrando a distância convertida de forma clara e precisa.

```C#
double milhas = 10.0; 

double quilometros = milhas * 1.60934; 

Console.WriteLine(milhas + " milhas equivalem a " + quilometros + " quilômetros."); 
```

Agora é sua vez! Teste o programa, compartilhe no fórum e compare sua lógica com outras soluções.

### Aula 1 - Convertendo horas para minutos - Desafio 4

Imagine que você está desenvolvendo um sistema de gerenciamento de tempo para um aplicativo de produtividade. Esse sistema precisa converter o tempo total de atividades, registrado em minutos, para um formato mais legível (horas e minutos), facilitando a visualização do usuário.

Crie um programa que:

- Declare uma variável com um valor inteiro representando o total de minutos.
- Calcule quantas horas completas existem nesse valor e quantos minutos restam.
- Exiba o resultado no formato X horas e Y minutos.

Exemplo de entrada:

> int minutos = 250;

Saída esperada:

> Tempo: 4 horas e 10 minutos

Opinião do instrutor

Nesta atividade, exploramos operações matemáticas para manipulação de valores temporais. A divisão inteira (/) é usada para extrair as horas completas, enquanto o operador módulo (%) captura o resto da divisão, que representa os minutos excedentes.

```C#
minutos / 60 retorna a parte inteira da divisão (horas).
minutos % 60 retorna o resto da divisão (minutos não convertidos em horas).
int minutos = 250; 
int horas = minutos / 60; 
int restantesMinutos = minutos % 60;

Console.WriteLine("Tempo: " + horas + " horas e " + restantesMinutos + " minutos"); 
```

Agora é sua vez! Teste o programa, compartilhe no fórum e compare sua lógica com outras soluções.

### Aula 1 - Calculando a área de um retângulo - Desafio 5

Você foi contratado por uma empresa de construção civil. A empresa está expandindo os seus projetos e precisa de um sistema para calcular a área de terrenos retangulares. Para isso utilize a fórmula:

> área = largura * comprimento

Para essa atividade, você deve criar um programa que:

- Declare duas variáveis para a largura e comprimento, respectivamente.
- Aplique a fórmula mencionada para calcular a área do terreno.
- Exiba o resultado do cálculo.

Exemplo de entrada:

```C#
double largura = 10.5; 
double comprimento = 20.3; 
```

Saída esperada:

```C#
A área do terreno é: 213,15 metros quadrados. 
```

Opinião do instrutor

Nessa atividade, utilizamos variáveis do tipo double para a altura e a largura, e o operador de multiplicação (*). A fórmula área = largura * comprimento nos permite chegar no resultado desejado e demonstra como conceitos matemáticos podem ser aplicados na programação para resolver problemas reais.

```C#
double largura = 10.5; 
double comprimento = 20.3; 

double area = largura * comprimento; 

Console.WriteLine($"A área do terreno é: {area} metros quadrados."); 
```

Agora é sua vez! Teste o programa, compartilhe no fórum e compare sua lógica com outras soluções.

### Aula 1 - Média de notas - Desafio 6

Imagine que você está desenvolvendo um sistema de boletim escolar para uma escola que deseja modernizar sua forma de acompanhar o desempenho dos alunos. O objetivo é criar um programa capaz de calcular a média das notas, facilitando o trabalho e fornecendo resultados imediatos.

Para essa atividade, você deve criar um programa que:

- Declare três variáveis do tipo float para armazenar as notas dos alunos. Foi fornecido pela escola os seguintes  valores (7.2, 8.3 e 9.1).
- Calcule a média aritmética das três.
- Exiba a média calculada.

Saída esperada:

```C#
A média das notas é: 8,2 
```

Opinião do instrutor

Nessa atividade, trabalhamos com o tipo float, que é um dos tipos utilizados para representar números com casas decimais. Utilizamos operadores matemáticos como a soma (+) para somar as notas e a divisão (/) para calcular a médias.

Uso do f na declaração de valores do tipo float:

Quando declaramos valores do tipo float em C#, é necessário adicionar o sufixo f ao número para indicar ao compilador que se trata do tipo float e não de um double (que é o tipo padrão para números com casas decimais)

```C#
float nota1 = 7.2f; 
float nota2 = 8.3f; 
float nota3 = 9.1f; 

float media = (nota1 + nota2 + nota3) / 3; 

Console.WriteLine("A média das notas é: " + media); 
```

Agora é sua vez! Teste o programa, compartilhe no fórum e compare sua lógica com outras soluções.

### Aula 1 - Convertendo tipos - Desafio 7

Imagine que você está desenvolvendo um sistema de gerenciamento de carga para um grande centro de distribuição. Para otimizar o transporte, a empresa estabeleceu que cada veículo deve transportar exatamente 1 tonelada. Seu sistema precisa converter o peso total dos containers para um número inteiro de veículos necessários, descartando qualquer fração decimal (já que um veículo não pode ser alocado para transportar apenas parte da carga).

Seu programa deve:

- Receber o peso total em toneladas (decimal)
- Converter para inteiro descartando a parte decimal
- Exibir a quantidade mínima de veículos necessários

Exemplo de entrada:

> decimal pesoContainer = 18.75m;

Saída esperada:

> Veículos necessários: 18

Opinião do instrutor

Nesta atividade, utilizamos o conceito de conversão explícita entre tipos numéricos. O comando (int)pesoContainer realiza o que chamamos de "truncamento" - ele simplesmente descarta a parte decimal sem qualquer tipo de arredondamento. É como se estivéssemos pegando apenas a parte inteira do número e ignorando tudo após a vírgula.

```C#
decimal pesoContainer = 18.75m; 
int veiculosNecessarios = (int)pesoContainer; 

Console.WriteLine("Veículos necessários: " + veiculosNecessarios); 
```

Agora é sua vez! Teste o programa, compartilhe no fórum e compare sua lógica com outras soluções.

### Aula 1 - Controle de vidas em um jogo - Desafio 8

Você está desenvolvendo um sistema de controle de vidas para um jogo. Nesse jogo, o jogador começa com um número inicial de vidas e, a cada erro, perde uma vida. Por outro lado, ao acertar, ele ganha uma vida.

Seu desafio é criar um programa que simule essa mecânica utilizando os operadores de incremento e decremento. Para isso, o programa deve:

- Declarar uma variável com o número inicial de vidas.
- Simular uma situação em que o jogador erra.
- Simular que o jogador acerta duas vezes.
- Armazene o valor final das vidas em uma nova variável.

Saída esperada:

Se o jogador começa com 5 vidas, o programa deve exibir:

> Vidas finais: 6

Opinião do instrutor

Nessa atividade, trabalhamos com os operadores de incremento (++) e decremento (--), que são usados para aumentar ou diminuir o valor de uma variável em 1. Além de sua simplicidade, o uso desses operadores permite que o código se torne mais legível e conciso. Em vez de escrever expressões mais longas para incrementar ou decrementar uma variável, podemos utilizar os operadores de forma direta, o que facilita a compreensão do fluxo do programa.

```C#
int vidas = 5; 
vidas--;  
vidas++; 
vidas++; 
int vidasFinais = vidas; 

Console.WriteLine("Vidas finais: " + vidasFinais); 
```

Agora é sua vez! Teste o programa, compartilhe no fórum e compare sua lógica com outras soluções.

### Aula 1 - Aumento de salário - Desafio 9

Você trabalha desenvolvendo um sistema de recursos humanos para uma empresa. Uma das funcionalidades desse sistema é calcular o aumento salarial dos funcionários com base em percentual definido pela empresa. Seu desafio é criar um programa que facilite esse cálculo.

Crie um programa que:

- Defina uma variável para o salário atual (decimal).
- Defina uma variável para o percentual de aumento (decimal).
- Calcule o novo salário e o salve em uma nova variável (decimal).
- Por fim, exiba o novo salário.

A fórmula para o cálculo é:

> salarioAtual + (salarioAtual * percentualAumento / 100) 

Saída esperada:

Você pode usar o método .ToString("F2") para formatar a saída dos valores no console, por exemplo: novoSalario.ToString("F2").

Se o salário atual for de 1500.00 e o percentual de aumento for de 10%, o programa deve exibir:

> O novo salário é de R$1650,00

Opinião do instrutor

Nessa atividade, utilizamos variáveis do tipo decimal, garantindo precisão no cálculo. O uso do sufixo m é necessário, para indicar ao compilador que o valor se trata de um decimal e não de um double (que é o tipo padrão para números com casas decimais).

```C#
decimal salarioAtual = 1500.0m; 
decimal percentualAumento = 10.0m; 
decimal novoSalario = salarioAtual + (salarioAtual * percentualAumento / 100); 

Console.WriteLine("O novo salário é de R$" + novoSalario.ToString("F2")); 
```

Agora é sua vez! Teste o programa, compartilhe no fórum e compare sua lógica com outras soluções.

### Aula 1 - Calculando a área e o perímetro - Desafio 10

Você trabalha para uma empresa de engenharia que desenvolve soluções para cálculos geométricos utilizados em projetos de construção e design. Um dos clientes da empresa solicitou um sistema para calcular a área e o perímetro (também conhecido como circunferência) de círculos, informações essenciais para o planejamento de estruturas circulares, como tanques, pisos e jardins.

Sua missão é criar um programa que, a partir do raio de um círculo, calcule sua área e perímetro utilizando as fórmulas matemáticas adequadas.

Crie um programa que:

- Declare uma variável que receba o valor de PI (considere PI como sendo igual a 3.14159).
- Declare uma variável que receba o valor do raio do círculo.
- Calcule e armazene em uma variável a área do círculo utilizando a fórmula: área = pi x raio x raio.
- Calcule e armazene em uma variável o perímetro do círculo utilizando a fórmula: 2 * pi * raio.
- Exiba os resultados no console.

Exemplo de entrada:

> double raio = 5.0; 

Saída esperada:

Você pode usar o método .ToString("F2") para formatar a saída dos valores no console, por exemplo: raio.ToString("F2")

```C#
Raio: 5,00 
Área do círculo: 78,54 
Perímetro do círculo: 31,42 
```

Opinião do instrutor

Nessa atividade, utilizamos o valor 3.14159 para representar PI e formatamos a saída com .ToString("F2"), o que garante que os resultados sejam exibidos com duas casas decimais. Essa formatação facilita a leitura e a interpretação dos valores, tornando o programa mais amigável para o usuário.

```C#
double raio = 5.0;  
double pi = 3.14159; 

double area = pi * raio * raio;  
double perimetro = 2 * pi * raio; 

Console.WriteLine("Raio: " + raio.ToString("F2"));  
Console.WriteLine("Área do círculo: " + area.ToString("F2"));  
Console.WriteLine("Perímetro do círculo: " + perimetro.ToString("F2")); 
```

Agora é sua vez! Teste o programa, compartilhe no fórum e compare sua lógica com outras soluções.

### Aula 1 - Conclusão

Parabéns por concluir este curso! Ao longo desta jornada, você adquiriu conhecimento prático e aplicou conceitos de programação em C#, com foco no uso de variáveis e tipos de dados e operações. Agora, você pode:

- Desenvolver programas em C#, utilizando variáveis e operações matemáticas.
- Realizar conversões de tipos e manipular dados.
- Criar soluções para problemas do cotidiano, aplicando lógica de programação e boas práticas de codificação.

Quer continuar explorando a programação em C#? Recomendamos os seguintes conteúdos:

- Artigo - [C#: Conhecendo a linguagem orientada a objetos mais popular da Microsoft](https://www.alura.com.br/artigos/csharp-linguagem-programacao-dotnet)
- Podcast - [Guia de Carreira C# (C SHARP)](https://www.youtube.com/watch?v=RtwvUNvabPA&ab_channel=Alura) | #HipstersPontoTube
- Curso - [C#: aplicando a Orientação a Objetos](https://cursos.alura.com.br/course/csharp-aplicando-orientacao-objetos)

Nos vemos nos próximos cursos práticos!
