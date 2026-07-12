# Curso Alura: C# Trabalhando com Arrays e Coleções

## Aula 1:  Arrays

### Aula 1: Apresentação - Vídeo 1

Transcrição  
Olá, tudo bom? Meu nome é André Bessa, sou um homem negro com barba por fazer, cabelo baixo e rosto arredondado. Serei seu instrutor ao longo deste treinamento de C# que abordará arrays e coleções de objetos.

Este curso é voltado para pessoas que estão se aprofundando na linguagem C# e querem dar um passo a mais na evolução de seu aprendizado. Trabalharemos em um projeto do ByteBank, fazendo implementações na área de atendimento ao cliente, a pedido da gerência de contas do banco.

Definiremos uma classe chamada ByteBankAtendimento que implementa uma lista de objetos. Nesse sistema, teremos uma série de opções para cadastrar, listar, remover, ordenar e pesquisar as contas dessa instituição.

Ao executar o projeto final, teremos uma aplicação console com todas essas funcionalidades. Por exemplo, pressionando 1 e informando os dados necessários (número da agência, saldo inicial, nome do titular, CPF do titular e profissão), conseguiremos cadastrar uma nova conta. Pressionando 2, listaremos todas as contas, e assim por diante.

Desse modo, entenderemos o que são arrays: a sua sintaxe, como criá-los e quais são as classes disponíveis no .NET para criar arrays de objetos (como as classes ArrayList e `List<T>`).

Usando esses conceitos de orientação a objetos na linguagem C#, o resultado deste curso será um programa para manipular um array ou uma coleção de objetos, que simulará nossa fonte de dados do sistema.

Para tirar melhor proveito do conteúdo, recomendamos fortemente que você já tenha estudado conceitos básicos da linguagem C#, como a criação de variáveis e a estrutura de decisão e repetição, além de conceitos de orientação a objetos, como classes, objetos e interfaces.

### Aula 1: Preparando o ambiente: instando do VS Community 2022

Para este curso precisamos fazer a instalação de algumas ferramentas. Vamos iniciar instalando o Visual Studio Community 2022 e o .NET 6. Para isso, será necessário acessar o site oficial da ferramenta: Visual Studio Community.

Na página de download vamos escolher a opção destacada na imagem: “Community”.

alt text: Imagem mostra a página de download do Visual Studio Community 2022.

Será aberta uma janela pop-up para informar o local de download, conforme apresentado na imagem abaixo.

alt text: Imagem mostra a janela de download do arquivo.

Após a conclusão do download, vamos executar o aplicativo VisualStudioSetup.exe que irá abrir uma nova janela para selecionar os componentes do .NET que iremos trabalhar.

alt text: Imagem mostra a janela do Visual Studio Installer.

Na tela que será aberta, vamos deixar habilitado neste momento somente os componentes para desenvolvimento Desktop.

alt text: Imagem mostra a janela do Visual Studio Installer com a opção `Desenvolvimento para Desktop com .NET` selecionada.

Após a conclusão do processo de instalação, podemos executar a ferramenta e começar a desenvolver nossos códigos .NET.

### Aula 1: Para Recordar: variáveis e tipos

Antes de mergulharmos na criação de Arrays e Coleções em C#, é importante relembrar alguns conceitos fundamentais para o curso. Esta atividade ajudará você a revisitar conhecimentos sobre variáveis e tipos, facilitando a absorção dos conceitos que aprenderemos a partir de agora.

Se você já tem grande familiaridade com esses assuntos, pode seguir direto para a próxima atividade e iniciar a aula. Caso precise relembrar algum conceito, sinta-se à vontade para aproveitar a atividade!

O que são variáveis e tipos?  
Variáveis são espaços na memória do computador usados para armazenar dados, como números, textos ou valores lógicos. Elas possuem um nome (identificador), um tipo (define o tipo de dado armazenado) e um valor (conteúdo da variável).

Se eu quero, por exemplo, guardar na memória a idade de um cliente da loja em que trabalho, preciso das seguintes informações:

nome da variável: idade  
tipo da variável: int (representa os números inteiros)  
valor: 25

Como declarar variáveis em C#?

Em C#, a declaração de variável segue a seguinte estrutura:

```csharp
tipo nomeDaVariavel = valor;
```

Sendo assim, para declarar a variável da idade do cliente, teríamos:

```csharp
int idade = 25; // declaração e inicialização da variável
// ou
int idade; // declaração da variável
idade = 25; // inicialização da variável
```

Em C#, você pode declarar tipos de variáveis implicitamente usando a palavra-chave var. Por exemplo:

```csharp
var idade = 25;
```

Com isso, o compilador infere o tipo da variável com base no valor atribuído. No caso acima, temos o tipo inferido int, pois o valor atribuído é um inteiro. Portanto, para realizar esse tipo de declaração, a inicialização é obrigatória e o valor não pode ser nulo (null). Além disso, a declaração implícita é ideal para tipos complexos (como coleções, LINQ, objetos anônimos) e melhora a legibilidade em códigos longos.

Tipos mais comuns

|Tipo|Descrição|Exemplo de Declaração|
|---|---|---|
|int|Números inteiros|int idade = 30;|
|double|Números decimais|double altura = 1.75;|
|float|Números decimais (precisão menor, sufixo f)|float peso = 68.5f;|
|decimal|Valores monetários (precisão alta, sufixo m)|decimal preco = 99.90m;|
|bool|Valores lógicos (true/false)|bool ativo = true;|
|char|Um único caractere (aspas simples)|char letra = 'A';|
|string|Texto (aspas duplas)|string nome = "Maria";|
|byte|Inteiro pequeno (0 a 255)|byte codigo = 100;|
|long|Inteiro grande (sufixo L)|long populacao = 8000000L;|
|short|Inteiro curto|short ano = 2025;|

Agora que você revisou esses assuntos, pode continuar o curso! Se ainda tiver dúvidas sobre algum dos tópicos, recomendamos explorar mais os conceitos antes de avançar. Os conteúdos abaixo podem te ajudar:

- [Praticando C#: variáveis e tipos](https://cursos.alura.com.br/course/praticando-csharp-variaveis-tipos)  
- [Apostila de C# e orientação a objetos: variáveis e tipos primitivos](https://www.alura.com.br/apostila-csharp-orientacao-objetos/variaveis-e-tipos-primitivos)

### Aula 1: Projeto inicial do curso

Você pode [baixar o zip do projeto](https://github.com/alura-cursos/Array_Collections_C/archive/refs/heads/CodigoInicial.zip) da aula ou acessar o link do repositório no GitHub!

### Aula 1: Criando um Array - Exercício

Esther está iniciando na posição de pessoa desenvolvedora estagiária e precisa declarar um array de strings para armazenar os dias da semana e que possua um tamanho suficiente. E ela precisa iniciar todas as posições do array na sequência, com os respectivos dias da semana.

Selecione a alternativa que melhor representa a melhor escolha para Esther.

Resposta:

```csharp
string [] _diasDaSemana= new string[7];
_diasDaSemana[0]=”segunda”;
_diasDaSemana[1]=”terça”;
_diasDaSemana[2]=”quarta”;
_diasDaSemana[3]=”quinta”;
_diasDaSemana[4]=”sexta”;
_diasDaSemana[5]=”sábado”;
_diasDaSemana[6]=”domingo”;
```

> A sintaxe de declaração e a forma de inicialização está correta.

### Aula 1: Para saber mais: outras formas de inicialização de um Array

Como vimos, os arrays, ou vetores, são um agrupamento de elementos que armazenamos em uma sequência, sendo o primeiro elemento do array o índice zero. Normalmente, quando criamos uma estrutura deste tipo, temos que definir sua dimensão, que pode ser única ou multidimensional. Vamos a um exemplo de um array de uma dimensão:

```csharp
int[] numeros = new int[10]; 
```

Podemos ter ainda um array com mais de uma dimensão, como por exemplo:

```csharp
int[,] numeros = new int[3,3];
```

Depois de entender como criar arrays, é importante entender que eles são tipos por referência, daí a palavra reservada new na sua declaração. Mas afinal, quais as formas que temos para iniciar esse tipo de estrutura? Primeiramente temos que lembrar que para manipular os arrays, vamos utilizar seus índices, e que todo array em C# inicia no 0.

Na forma mais básica de se declarar e inicializar um array temos:string[] palavras = new string[10] e para inserir valores recorremos à: palavras[0]="André.". Neste exemplo primeiro é declarado o array e depois inserimos os elementos em cada índice. Mas também podemos declará-lo e iniciá-lo por exemplo:

```csharp
string [] palavras= new string[5] {"André","Jose","Andressa","Neia","Sarah"}`;
```

Podemos também omitir o número de elementos como no exemplo:

```csharp
  double[] valores={2.6,9.7,7.5,1.8};
```

Estas são algumas das formas que temos para definir um array usando o C#. Para saber ainda mais vamos deixar aqui o [link da documentação oficial da Microsoft Matrizes](https://docs.microsoft.com/pt-br/dotnet/csharp/programming-guide/arrays/) Guia de Programação em C#.

### Aula 1: Percorrendo um Array - Vídeo 2

Transcrição  
Já vimos como criar um array e como percorrê-lo com o laço de repetição for. Neste vídeo, faremos mais testes com vetores, dessa vez com um array de strings.

Abaixo de TestaArrayInt, vamos criar um método TestaBuscarPalavra() que solicitará ao usuário que digite 5 palavras e, depois, que escolha uma delas para buscar no array. Ou seja, é como se cadastrássemos as strings em um banco de dados e, mais tarde, fizéssemos uma consulta nessa base.

Em TestaBuscarPalavras(), começaremos declarando o vetor arrayDePalavras:

```csharp
// código anterior omitido

void TestaBuscarPalavra()
{
    string[] arrayDePalavras = new string[5];
}
```

Em seguida, com o laço for, criaremos uma estrutura que solicitará ao usuário que informe uma palavra para cada posição do array. Lembre-se que podemos digitar for e pressionar a tecla "Tab" duas vezes para gerar um modelo.

Dentro do laço de iteração, não usaremos o Console.WriteLine(). Vamos optar pelo Console.Write(), pois não queremos pular uma linha. Em seguida, faremos com que o array receba o valor digitado pelo usuário por meio do Console.ReadLine():

```csharp
// código anterior omitido

void TestaBuscarPalavra()
{
    string[] arrayDePalavras = new string[5];

    for (int i = 0; i < arrayDePalavras.Length; i++)
    {
        Console.Write($"Digite {i + 1}ª Palavra: ");
        arrayDePalavras[i]=Console.ReadLine();
    }
}
```

Note que usamos {i + 1}, porque o índice 0 corresponderá à primeira palavra. Ou seja, quando i for igual a 0, o programa solicitará "Digite 1ª Palavra".

Além disso, é importante lembrar que nosso array recebe apenas strings e o Console.ReadLine() é um método que retorna uma string, por isso nosso código continua funcionando.

Após obter as 5 palavras, a aplicação pedirá ao usuário que especifique a string que deseja encontrar. Vamos armazenar o valor digitado numa variável chamada busca:

```csharp
// código anterior omitido

void TestaBuscarPalavra()
{
    string[] arrayDePalavras = new string[5];

    for (int i = 0; i < arrayDePalavras.Length; i++)
    {
        Console.Write($"Digite {i + 1}ª Palavra: ");
        arrayDePalavras[i]=Console.ReadLine();
    }
}

Console.Write("Digite palavra a ser encontrada: ");
var busca = Console.ReadLine();
```

Note que definimos busca como um var — em tempo de execução, o compilador .NET interpretará que o termo antes da igualdade retornará uma string, então definirá o busca como tipo string.

Recapitulando o que fizemos até agora: vamos percorrer um vetor utilizando o for e recorrendo aos índices para inserir 5 valores informados pelo usuário. Depois, vamos pedir que digite a palavra que deseja encontrar e armazenaremos essa informação na variável busca.

Agora, precisamos percorrer o array novamente, comparando cada posição do vetor com o valor de busca, para verificar se encontramos a palavra desejada ou não. Dessa vez, usaremos a estrutura foreach — em inglês, "for each" significa "para cada".

Assim como o for, podemos digitar foreach e pressionar a tecla "Tab" duas vezes para gerar um modelo automaticamente.

A estrutura foreach é mais simples em relação ao for e nos permite percorrer um array ou uma coleção (que estudaremos mais adiante neste curso). Ela é interessante principalmente quando não precisamos especificar os índices:

```csharp
// código anterior omitido

foreach (string palavra in arrayDePalavras)
{

}
```

Então, para cada palavra no arrayDePalavras, rodaremos o bloco de código contido no foreach:

```csharp
// código anterior omitido

foreach (string palavra in arrayDePalavras)
{
    if (palavra.Equals(busca))
    {
        Console.WriteLine($"Palavra encontrada = {busca}.");
    }
    else
    {
        Console.WriteLine($"Palavra não encontrada.");
    }
}
```

O método .Equals() nos permite verificar se uma string é igual a outra. Assim, se palavra for igual a busca, vamos exibir no console a frase "Palavra encontrada" seguida da palavra. Do contrário, exibiremos "Palavra não encontrada".

Em outras palavras, o foreach é outra estrutura de repetição para iterar um array.

É hora de testar. Vamos comentar a chamada de TestaArrayInt() na linha 3 e criar uma chamada de TestaBuscaPalavra() na linha 4:

Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");

```csharp
//TestaArrayInt();
TestaBuscarPalavra();

// código posterior omitido
```

Em seguida, vamos salvar e executar o projeto. O programa pedirá para digitarmos 5 palavras, vamos informar: "Andre", "Jose", "Pedro", "Maria" e "Ulisses". Depois, será solicitada a palavra para ser encontrada, digitaremos "Jose". O retorno será o seguinte:

```csharp
Palavra não encontrada.
Palavra encontrada = Jose.
Palavra não encontrada.
Palavra não encontrada.
Palavra não encontrada.
```

Não obtivemos o resultado esperado. Para cada iteração, o programa está imprimindo um aviso. O nosso objetivo era que a aplicação apenas retornasse uma mensagem caso a palavra digitada fosse encontrada. Vamos voltar à nossa estrutura foreach e corrigi-la.

Primeiramente, vamos remover o bloco else, pois não esperamos nenhum comportamento do programa se a palavra não for encontrada. Além disso, vamos inserir um break após o Console.WriteLine():

```csharp
// código anterior omitido

foreach (string palavra in arrayDePalavras)
{
    if (palavra.Equals(busca))
    {
        Console.WriteLine($"Palavra encontrada = {busca}.");
        break;
    }
}
```

Assim, uma vez que a palavra deseja for encontrada, o break interromperá o laço de repetição. Outra opção seria usar um return.

Vamos salvar e rodar o projeto novamente. Informaremos as mesmas 5 palavras e buscaremos por "Jose" mais uma vez. Dessa vez, nosso programa funcionará como o esperado!

Portanto, neste vídeo, criamos um método que trabalha com um array de strings. Digitamos 5 palavras e o programa fará a busca por um termo específico, analisando cada índice do vetor. Em vez do laço for, optamos pela estrutura foreach, que nos permite iterar por arrays e coleções (que veremos mais adiante neste curso).

Na sequência, descobriremos mais formas de trabalhar com arrays no .NET.

### Aula 1: Para Recordar: loops

Chegou o momento de relembrar mais alguns conceitos importantes para este curso.

Vale ressaltar que, caso já tenha grande familiaridade com esse assunto, você pode pular diretamente para a próxima seção. Vamos lá?

O que são loops?  
Loops (laços de repetição) permitem executar um bloco de código várias vezes até que uma condição seja atendida. Em C#, as principais são:

1. for  
Usado quando sabemos quantas vezes queremos repetir a execução de um bloco de código. Por exemplo:

```csharp
for (int i = 0; i < 5; i++) 
{
    Console.WriteLine($"Iteração {i}");
}
```

No código acima, temos:

- Inicialização (int i = 0): Define o contador.
- Condição (i < 5): Enquanto ela for verdadeira, a execução se repete.
- Incremento (i++): Atualiza o contador após cada ciclo (ou “iteração”)

Ou seja, enquanto i for menor que 5, incrementamos o contador em mais um. Quando chegamos ao número 5, o loop é encerrado. No console, teríamos a seguinte saída:

```csharp
Iteração 0
Iteração 1
Iteração 2
Iteração 3
Iteração 4
```

A contagem começa em 0 (padrão em programação), então o loop executa 5 vezes (para i = 0, 1, 2, 3, 4). O programa não imprime "Iteração 5" porque quando i vale 5, a condição i < 5 já é falsa.

2. while  
Repete enquanto uma condição for verdadeira, verificando-a antes de executar o código. Por exemplo:

```csharp
int tentativas = 0;
while (tentativas < 3)
{
    Console.WriteLine($"Tentativa {tentativas + 1}");
    tentativas++;
}
//Saída:
//Tentativa 1
//Tentativa 2
//Tentativa 3
```

3. do-while  
Similar ao while, mas executa o código pelo menos uma vez, pois verifica a condição após a execução. Por exemplo:

```csharp
int tentativas = 0;
do 
{
    Console.WriteLine($"Tentativa {tentativas + 1}");
    tentativas++;
} while (tentativas < 3);
//Saída:
//Tentativa 1
//Tentativa 2
//Tentativa 3
```

Observações:

- No while: se tentativas começar com valor ≥ 3, o bloco nunca será executado.
- No do-while: mesmo se tentativas começar com 3, o bloco executará uma vez antes de verificar a condição.

4. foreach  
Percorre todos os itens de uma coleção (arrays, listas, etc.). Por exemplo:

```csharp
string[] frutas = { "Maçã", "Banana", "Laranja" };
foreach (string fruta in frutas) 
{
    Console.WriteLine(fruta);
}
// Saída:
// Maçã
// Banana
// Laranja
```

Ou seja, em cada iteração, a variável fruta assume o valor do elemento atual, e esse valor é impresso no console conforme o bloco de código pede, até que o array termine.

Quando usar cada um?

|Estrutura|Quando Usar?|Exemplo Típico|
|---|---|---|
|for|Quando você sabe o número exato de iterações|Contagens, processamento de intervalos|
|while|Para loops com condições complexas/indefinidas|Validação de entrada, jogos em loop|
|do-while|Quando o bloco deve executar pelo menos 1 vez|Menus interativos, tentativas de login|
|foreach|Para percorrer todos os itens de uma coleção|Listas, arrays, dicionários|

Relembrou?  
Agora que você revisou esses assuntos, pode continuar o curso! Se ainda tiver dúvidas sobre algum dos tópicos, recomendamos explorar mais os conceitos antes de avançar. Os conteúdos abaixo podem te ajudar:

- [Apostila de C# e orientação a objetos: estruturas de repetição](https://www.alura.com.br/apostila-csharp-orientacao-objetos/estruturas-de-repeticao)

### Aula 1: Usando o For -Exercício

Esther, como pessoa desenvolvedora iniciante na linguagem C#, precisa percorrer um array de booleanos que armazena as opções de escolha de um determinado formulário de pesquisa. Dado o array de booleanos definido abaixo:

> bool[] opcoes = {true,false,true,true,true,false};

Qual é a melhor forma de Esther percorrer e apresentar os elementos do array opcoes? Marque a opção correta selecionando a alternativa que representa a melhor escolha para Esther.

Resposta:

```csharp
bool[] opcoes = { true, false, true, true, true, false };

for (int i = 0; i < opcoes.Length; i++)
{
    Console.WriteLine($"Opção {i} = {opcoes[i]} ");
}
```

> A sintaxe de declaração e a forma de inicialização está correta e usando a estrutura de repetição for, Esther consegue iterar sobre o array e exibir seu conteúdo com a função Console.WriteLine().

### Aula 1: Faça como eu fiz: buscando um elemento do Array

Nesta aula aprendemos como percorrer um array em busca de determinado elemento, então que tal praticar um pouco? Vamos criar uma função que pesquise uma palavra dentro de um array de strings.

Opinião do instrutor

Com a IDE do Visual Studio Community 2022, no arquivo program.cs vamos criar um novo método que irá possuir internamente um array de strings string[] arrayDePalavras = new string[5]; agora vamos definir nosso código que espera que um usuário informa 5 palavras para posterior busca:

```csharp
for (int i = 0; i < arrayDePalavras.Length; i++)
{
    Console.Write($"Digite {i+1}ª palavra:");
    arrayDePalavras[i] = Console.ReadLine();
}
```

Pronto, agora precisamos emular uma forma de buscar a palavra desejada e percorrer todo o array, para isso usaremos a estrutura foreach:

```csharp
  Console.Write("Digite palavra a ser encontrada:");
    var busca = Console.ReadLine();

    foreach (string str in arrayDePalavras)
    {
        if (str.Equals(busca))
        {
            Console.WriteLine($"Palavra encontrada = {str}");
        }
        else
        {
            Console.WriteLine($"Palavra {busca} não encontrada");
        }
    }
```

Abaixo a definição do método:

```csharp
void TestaBuscarPalavra()
{

    string[] arrayDePalavras = new string[5];

    for (int i = 0; i < arrayDePalavras.Length; i++)
    {
        Console.Write($"Digite {i+1}ª palavra:");
        arrayDePalavras[i] = Console.ReadLine();
    }

    Console.Write("Digite palavra a ser encontrada:");
    var busca = Console.ReadLine();

    foreach (string str in arrayDePalavras)
    {
        if (str.Equals(busca))
        {
            Console.WriteLine($"Palavra encontrada = {str}");
        }
        else
        {
            Console.WriteLine($"Palavra {busca} não encontrada");
        }
    }
}
```

Lembre-se de continuar praticando bastante e se desafiando sempre.

### Aula 1: A classe Array - Vídeo 3

Transcrição  
Agora que já compreendemos como fazer arrays de inteiros e de strings, partiremos para outro desafio. Faremos um cálculo estatístico: vamos calcular a mediana de uma amostra, utilizando a classe Array.

No arquivo Program.cs, abaixo de TestaBuscarPalavra(), definiremos um array chamado amostra utilizando a classe Array, disponível na biblioteca de classes do .NET:

```csharp
// código anterior omitido

Array amostra = Array.CreateInstance();
```

Em .CreateInstance(), precisamos informar dois parâmetros — o tipo dos valores do array e o tamanho dele. No caso, teremos o tipo double e um vetor com 5 posições:

```csharp
// código anterior omitido

Array amostra = Array.CreateInstance(typeof(double), 5);
```

Vale ressaltar que todos os arrays que criamos até agora (de inteiros e de strings) herdam dessa classe Array. Em outras palavras, a classe Array possui métodos e propriedades comuns, compartilhados por todos os arrays que criamos no C#.

A título de exemplo, na linha seguinte vamos digitar amostra. e pressionar "Ctrl + Barra de Espaço" para exibir métodos e propriedades disponíveis do nosso array. Temos uma lista de opções, entre elas Clone e Length (que usamos anteriormente para saber o tamanho do vetor). Em resumo, a classe Array é a classe base, da qual todos os outros arrays herdam suas propriedades e seus métodos.

Agora que já criamos o array amostra, vamos setar valores para ele por meio da função SetValue(), que requer dois parâmetros — o valor e o índice desse valor:

```csharp
// código anterior omitido

Array amostra = Array.CreateInstance(typeof(double), 5);
amostra.SetValue(5.9, 0);
amostra.SetValue(1.8, 1);
amostra.SetValue(7.1, 2);
amostra.SetValue(10, 3);
amostra.SetValue(6.9, 4);
```

Na sequência, vamos criar uma função que receba amostra como parâmetro e calcule a mediana. Para entendermos como esse cálculo será feito, vamos considerar nossos valores no formato de um array:

```csharp
//[5,9][1,8][7,1][10][6,9]
```

Na primeira posição, temos 5.9. Na segunda posição, temos 1.8. Na terceira, 7.1, e assim por diante. A mediana será o valor que está no meio desse vetor. Porém, para fazer esse cálculo, é necessário que os valores estejam ordenados. Vamos implementar isso no método a seguir. Criaremos um método do tipo void (pois não haverá retorno) chamado TestaMediana(). Ele receberá um array como parâmetro:

```csharp
// código anterior omitido

Array amostra = Array.CreateInstance(typeof(double), 5);
amostra.SetValue(5.9, 0);
amostra.SetValue(1.8, 1);
amostra.SetValue(7.1, 2);
amostra.SetValue(10, 3);
amostra.SetValue(6.9, 4);

//[5,9][1,8][7,1][10][6,9]

void TestaMediana(Array array)
{

}
```

Primeiramente, vamos verificar se o parâmetro recebido não é nulo:

```csharp
// código anterior omitido

void TestaMediana(Array array)
{
    if((array == null) || (array.Length == 0))
    {
        Console.WriteLine("Array para cálculo da mediana está vazio ou nulo.");
    }
}
```

Desse modo, caso array seja nulo ou seu tamanho seja igual a 0, veremos uma mensagem no console. Do contrário, faremos o cálculo da mediana.

Agora, nosso objetivo é ordenar o array. Vamos começar criando um array reserva chamado numerosOrdenados que será uma cópia de array:

```csharp
// código anterior omitido

void TestaMediana(Array array)
{
    if((array == null) || (array.Length == 0))
    {
        Console.WriteLine("Array para cálculo da mediana está vazio ou nulo.");
    }

    double[] numerosOrdenados = array.Clone();
}
```

Surgirá um aviso de erro em array.Clone(), na linha 69. Colocando o cursor sobre o método .Clone(), veremos uma breve descrição dele e constataremos que seu retorno é um object. Ou seja, estamos declarando um array de double, mas atribuindo um object.

Lembrete: object é a super classe de qual todas as classes do .NET derivam!

Para solucionar esse erro, vamos fazer a conversão, usando o cast. Antes de atribuir um valor para numerosOrdenados, vamos transformar esse object em um array de números do tipo double:

```csharp
// código anterior omitido

void TestaMediana(Array array)
{
    if((array == null) || (array.Length == 0))
    {
        Console.WriteLine("Array para cálculo da mediana está vazio ou nulo.");
    }

    double[] numerosOrdenados = (double [])array.Clone();
}
```

Assim, numerosOrdenados será uma cópia do array que recebemos como parâmetro em TestaMediana(). Em seguida, vamos ordená-lo com o método .Sort() da classe Array. Basta passarmos o array como parâmetro:

```csharp
// código anterior omitido

void TestaMediana(Array array)
{
    if((array == null) || (array.Length == 0))
    {
        Console.WriteLine("Array para cálculo da mediana está vazio ou nulo.");
    }

    double[] numerosOrdenados = (double [])array.Clone();
    Array.Sort(numerosOrdenados);
}
```

Dessa forma, ao passar pelo Array.Sort() na linha 70, o array numerosOrdenados passará a ser `[1,8][5,9][6,9][7,1][10]`. Vamos deixar essa informação comentada no nosso código a título de referência:

```csharp
// código anterior omitido

void TestaMediana(Array array)
{
    if((array == null) || (array.Length == 0))
    {
        Console.WriteLine("Array para cálculo da mediana está vazio ou nulo.");
    }

    double[] numerosOrdenados = (double [])array.Clone();
    Array.Sort(numerosOrdenados);
    //[1,8][5,9][6,9][7,1][10]
}
```

Já temos nosso array ordenado. Com o intuito calcular a mediana, precisamos saber onde é o meio desse array. Para obter essa informação, dividiremos o tamanho do array por 2. Então, vamos declarar uma variável que conterá o tamanho de numerosOrdenados e outra cujo valor será o tamanho dividido por dois (meio):

```csharp
// código anterior omitido

void TestaMediana(Array array)
{
    if((array == null) || (array.Length == 0))
    {
        Console.WriteLine("Array para cálculo da mediana está vazio ou nulo.");
    }

    double[] numerosOrdenados = (double [])array.Clone();
    Array.Sort(numerosOrdenados);
    //[1,8][5,9][6,9][7,1][10]

    int tamanho = numerosOrdenados.Length;
    int meio = tamanho / 2;
}
```

Na sequência, vamos declarar uma variável para efetivamente calcular a mediana. Com o operador de módulo, verificaremos se o resto da divisão de tamanho por 2 é diferente de 0. Se for diferente de 0, seguiremos por um caminho; do contrário, seguiremos por outro. Para fazer esse teste booleano, usaremos um operador ternário:

```csharp
// código anterior omitido

void TestaMediana(Array array)
{
    if((array == null) || (array.Length == 0))
    {
        Console.WriteLine("Array para cálculo da mediana está vazio ou nulo.");
    }

    double[] numerosOrdenados = (double [])array.Clone();
    Array.Sort(numerosOrdenados);
    //[1,8][5,9][6,9][7,1][10]

    int tamanho = numerosOrdenados.Length;
    int meio = tamanho / 2;
    double mediana = (tamanho % 2 != 0) ? numerosOrdenados[meio] :(numerosOrdenados[meio] + numerosOrdenados[meio - 1]) / 2;
}
```

No operador ternário, temos a condição tamanho % 2 != 0 a ser verificada e que retornará true ou false. Depois do ponto de interrogação, vemos as instruções do que deve ser feito se o retorno for true (antes do símbolo de dois pontos) ou se for false (depois do símbolo de dois pontos).

Se tamanho % 2 != 0 retornar true, quer dizer que o tamanho do vetor é um valor ímpar, portanto a variável meio é o índice do elemento que está exatamente no meio do array. Nesse caso, a mediana terá o valor de numerosOrdenados[meio].

Se tamanho % 2 != 0 retornar false, quer dizer que o tamanho do vetor é um valor par, portanto a variável meio é o índice do elemento que está uma posição além do meio do vetor. Nesse caso, a mediana será a média entre numerosOrdenados[meio] e numerosOrdenados[meio - 1].

O meio de um vetor com número par de elementos está entre dois valores. Por exemplo, o meio de [1,2,3,4] é entre 2 e 3. Nesse caso, a mediana é a média entre 2 e 3.

Dessa forma, encontraremos a mediana do vetor independentemente do seu tamanho ser um número par ou um número ímpar.

A seguir, vamos exibir a mediana no console. Usaremos um code snippet: basta digitar CW e pressionar a tecla "Tab" duas vezes:

```csharp
// código anterior omitido

void TestaMediana(Array array)
{
    if((array == null) || (array.Length == 0))
    {
        Console.WriteLine("Array para cálculo da mediana está vazio ou nulo.");
    }

    double[] numerosOrdenados = (double [])array.Clone();
    Array.Sort(numerosOrdenados);
    //[1,8][5,9][6,9][7,1][10]

    int tamanho = numerosOrdenados.Length;
    int meio = tamanho / 2;
    double mediana = (tamanho % 2 != 0) ? numerosOrdenados[meio] :(numerosOrdenados[meio] + numerosOrdenados[meio - 1]) / 2;
    Console.WriteLine($"Com base na amostra a mediana = {mediana}");
}
```

Por fim, vamos fazer uma chamada ao método TestaMediana() na linha 63, passando amostra como parâmetro:

```csharp
// código anterior omitido

Array amostra = Array.CreateInstance(typeof(double), 5);
amostra.SetValue(5.9, 0);
amostra.SetValue(1.8, 1);
amostra.SetValue(7.1, 2);
amostra.SetValue(10, 3);
amostra.SetValue(6.9, 4);

//[5,9][1,8][7,1][10][6,9]
TestaMediana(amostra);

void TestaMediana(Array array)
{
    if ((array == null) || (array.Length == 0))
    {
        Console.WriteLine("Array para cálculo da mediana está vazio ou nulo.");
    }

    double[] numerosOrdenados = (double[])array.Clone();
    Array.Sort(numerosOrdenados);
    //[1,8][5,9][6,9][7,1][10]

    int tamanho = numerosOrdenados.Length;
    int meio = tamanho / 2;
    double mediana = (tamanho % 2 != 0) ? numerosOrdenados[meio] :
                                                             (numerosOrdenados[meio] + numerosOrdenados[meio - 1]) / 2;
    Console.WriteLine($"Com base na amostra a mediana = {mediana}");
}
```

Salvando e executando o projeto, vamos obter exatamente o resultado esperado: "Com base na amostra a mediana = 6,9".

Então, neste vídeo, vimos outra forma de utilizar a super classe Array que define todos os arrays da linguagem C#, trazendo uma série de propriedades e métodos. Conseguimos, por exemplo, identificar o tamanho de um vetor, cloná-lo e ordená-lo. Assim, temos muito mais flexibilidade ao trabalhar com arrays.

Na linha 53, ao criar um array usando a classe Array, utilizamos o método .CreateInstance() em que passamos o tipo e o tamanho do array, porém vale ressaltar que a estrutura Array amostra = Array.CreateInstance(typeof(double), 5) é equivalente a Array amostra = new double[5]. Podemos trocá-las no nosso código e ele continuará funcionando normalmente.

### Aula 1: Para Recordar: condicionais

Chegou o momento de relembrar mais alguns conceitos importantes para este curso.

Vale ressaltar que, caso já tenha grande familiaridade com esse assunto, você pode pular diretamente para a próxima seção. Vamos lá?

O que são condicionais?  
Condicionais permitem que um programa tome decisões com base em expressões lógicas. Em C#, as estruturas mais comuns são:

1. if/else  
Essa expressão executa um bloco de código se uma condição for verdadeira. Confira um exemplo de sua sintaxe:

```csharp
int idade = 18;

if (idade >= 18) 
{
    Console.WriteLine("Maior de idade.");
}
else 
{
    Console.WriteLine("Menor de idade.");
}
```

Ou seja: se (if) uma dada condição (colocada entre parênteses, utilizando operadores relacionais ou lógicos) for verdadeira, então executamos um determinado bloco de código inserido dentro das primeiras chaves. Do contrário (else), executamos o segundo bloco de código.

No exemplo acima, imprimimos no console a frase “Maior de idade” se a variável idade tiver um valor maior ou igual a 18. Do contrário, imprimimos a frase “Menor de idade”.

2. else if  
Essa expressão testa múltiplas condições em sequência, ideal para quando temos mais de dois casos. Por exemplo:

```csharp
int nota = 75;

if (nota >= 90) 
{
    Console.WriteLine("A");
}
else if (nota >= 70) 
{
    Console.WriteLine("B");
}
else 
{
    Console.WriteLine("C");
}
```

No exemplo acima, primeiro testamos se o valor da variável nota é maior ou igual a 90. Se sim, imprimimos “A” no console. Depois, testamos se é maior ou igual a 70, mas menor que 90; se sim, imprimimos “B”. De resto, imprimimos “C”.

Ou seja: notas de 0 a 70 equivalem a C, pontos de 70 a 90 equivalem a B e pontos de 90 a 100 equivalem a A. No exemplo acima, como nota é igual a 75, imprimiríamos “B” no console!

3. switch-case  
O switch-case é uma estrutura condicional que compara um valor com várias opções pré-definidas, tornando o código mais organizado quando há múltiplas condições fixas.

Para funcionar, ela: i) avalia uma expressão, ii) compara com os casos (case) até encontrar um que corresponda, iii) executa o bloco do caso correspondente e sai da estrutura (break), iv) se nenhum caso for válido, executa o default (opcional).

Por exemplo:

```csharp
string dia = "Segunda";

switch (dia) 
{
    case "Segunda":
        Console.WriteLine("Início da semana.");
        break;
    case "Sexta":
        Console.WriteLine("Quase fim de semana!");
        break;
    default:
        Console.WriteLine("Dia comum.");
        break;
}
```

Temos três cenários: Início da semana, dia comum e quase fim de semana. O cenário de “dia comum” é o padrão, então o definimos como caminho default. Ou seja: se o dia for qualquer um exceto Segunda ou Sexta, temos um dia comum. Se for Segunda, estamos em início de semana, e se for Sexta, estamos quase no fim de semana.

Podemos optar por uma sintaxe simplificada dessa estrutura condicional, por exemplo:

```csharp
string dia = "Segunda";

string mensagem = dia switch
{
    "Segunda" => "Início da semana.",
    "Sexta"   => "Quase fim de semana!",
     _ => "Dia comum." // Caso padrão (equivalente ao default)
};

Console.WriteLine(mensagem);
```

Observações:

Sempre use break para encerrar um caso (exceto em casos vazios).
default é opcional e age como o "senão" (else) do switch.

Quando usar cada um?

|Estrutura|Quando Usar|Exemplo|
|---|---|---|
|if|Condição única e simples|if (idade > 18) { ... }|
|if-else|Escolha entre dois caminhos excludentes|if (logado) { ... } else { ... }|
|else-if|Múltiplas condições mutuamente excludentes|if (nota >= 9) { ... } else if (nota >= 7) { ... }|
|switch|Comparação de um valor contra múltiplos casos|switch (opcao) { case 1: ... break; }|

Relembrou?  
Agora que você revisou esses assuntos, pode continuar o curso! Se ainda tiver dúvidas sobre algum dos tópicos, recomendamos explorar mais os conceitos antes de avançar. Os conteúdos abaixo podem te ajudar:

- [Praticando C#: condicionais com if/else e switch/case](https://cursos.alura.com.br/course/praticando-csharp-condicionais-if-else-switch-case)  
- [Apostila de C# e orientação a objetos: estruturas de controle](https://www.alura.com.br/apostila-csharp-orientacao-objetos/estruturas-de-controle)

Bons estudos!

### Aula 1: Posição não existe - Vídeo 4

Transcrição  
Neste vídeo, vamos nos atentar a um erro bastante comum quando estamos percorrendo vetores. De início, vamos declarar um array de números inteiros. Aproveitaremos esse momento para aprender mais uma forma de inicializar um vetor:

```csharp
int[] valores = { 10, 58, 36, 47 };
```

Assim, temos um array com 4 posições. Seus índices vão de 0 a 3. A seguir, vamos percorrer esse vetor com um laço for e exibir seus valores no console:

```csharp
int[] valores = { 10, 58, 36, 47 };
for (int i = 0; i < 4; i++)
{
    Console.WriteLine(valores[i]);
}
```

Note que colocamos i < 4 em vez de i < valores.Length, como de costume. Visto que o tamanho de valores é 4, essa opção não faz diferença no nosso código, por enquanto. Podemos salvar e executar o programa e veremos os 4 valores impressos no console, tudo estará funcionando normalmente.

Agora, vamos supor que estamos fazendo a manutenção de um código e decidimos inserir os números manualmente para fazer alguns testes. Nesse processo, colocamos um número maior que o tamanho do array:

```csharp
int[] valores = { 10, 58, 36, 47 };
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(valores[i]);
}
```

Salvando e executando o projeto, nosso programa não será compilado. Teremos uma mensagem de exceção sem tratamento: System.IndexOutOfRangeException — índice fora dos limites. Ou seja, temos um array com 4 posições, porém o laço está programado para iterar 5 vezes. Estamos tentando acessar uma posição que não existe no vetor.

Este erro é bastante comum quando manipulamos um array, por isso é importante atentarmos ao tamanho dos vetores para evitar exceções como essa.

### Aula 1: Outra forma de criar um Array - Exercício

Esther continua sua saga de entender todas as possibilidade de criação de um Array usando C# e em sua pesquisa se deparou com a classe de biblioteca Array, da qual todos os arrays instanciados no C# herdam, entendendo que a classe possui uma série de propriedades e métodos disponíveis.

Marque as opções válidas que cria um array de 6 posições para um objeto da classe Array:

Selecione 2 alternativas

Respostas:

```csharp
Array pesquisa = new double [6];
pesquisa.SetValue(8.3,0);
pesquisa.SetValue(9.1,1);
pesquisa.SetValue(9.9,2);
pesquisa.SetValue(8.9,3);
pesquisa.SetValue(8.8,4);
pesquisa.SetValue(10.0,5);
```

> A sintaxe de definição do array usando a classe Array está correta, a construção é válida, pois todo array em C# herda da classe Array.

Alternativa correta:  

```csharp
Array pesquisa = Array.CreateInstance(typeof(double),6);
pesquisa.SetValue(8.3,0);
pesquisa.SetValue(9.1,1);
pesquisa.SetValue(9.9,2);
pesquisa.SetValue(8.9,3);
pesquisa.SetValue(8.8,4);
pesquisa.SetValue(10.0,5);
```

> A sintaxe de definição do array usando a classe Array está correta, criando uma nova instância e definindo seu tamanho.

### Aula 1: Desafio: método que calcula a média de um Array passado por parâmetro

Contrataram você como o novo desenvolvedor da equipe da Esther, e você ficou responsável de iniciar a codificação do módulo de estatística da aplicação, iniciando o desenvolvimento da função que irá calcular a média de uma amostra. Essa amostra será um vetor de doubles que será o parâmetro de entrada do seu método.

Este é um exercício opcional e te desafiamos a criar um método que receba como parâmetro um array de double e retorne a média simples calculada.

Opinião do instrutor

Agora apresentamos uma possível solução para o desafio proposto:

```csharp
double MediaDaAmostra(double[] amostra)
{
    double media = 0;
    double acumulador=0;

    if ((amostra == null)||(amostra.Length==0))
    {
        Console.WriteLine("Amostra de dados nula ou vazia.");
        return 0;
    }
    else
    {
        for (int i = 0; i < amostra.Length; i++)
        {
            acumulador = acumulador + amostra[i];
        }
        media = acumulador/ amostra.Length;
    }

    return media;
}
```

### Aula 1: Para saber mais: classe Array

A classe Array é a superclasse de onde todas as instâncias de array do C# herdam seus atributos e métodos. Dentre as características desta classe temos:

- Pode possuir uma ou mais dimensões.
- Tem um tamanho fixo.
- Suporta acesso por índices.

Como vimos, podemos criar uma instância da classe usando a sintaxe mais simplificada int[] valores = new int[10] ou usar o método CreateInstance por exemplo: Array pesquisa = Array.CreateInstance(typeof(double), 6);

Para adicionar elementos ao vetor podemos usar o método SetValue que recebe dois parâmetros: o elemento e o índice, onde o elemento será “setado”. Temos um exemplo: pesquisa.SetValue(9.1,1);

As principais propriedades e métodos disponibilizados pela classe Array apresentamos na tabela abaixo:

|Propriedade/Método|Descrição|
|---|---|
|GetValue|retorna o conteúdo/valor de um elemento pelo índice.|
|GetLength|retorna o números de elementos do array.|
|Rank|retorna o número de dimensões de um array.|
|CopyTo|cria uma cópia de todos os valores de um array.|
|Sort|ordena os valores de um array de forma ascendente.|
|Reverse|inverte a ordem de elementos de um array.|
|Clone|cria uma cópia do array.|
|Length|retorna o número de elementos de um array.|
|IndexOf|encontra a primeira ocorrência de um elemento no array.|
|LastIndexOf|encontra a última ocorrência de um elemento no array.|
|Clear|limpa todas as posições de um array.|
|Exists|verifica se existe ou não um elemento no array.|

Apresentamos aqui somente algumas das propriedades e métodos disponíveis para instâncias de array, para saber mais recomendamos a leitura da [documentação oficial da Microsoft Array Classe](https://docs.microsoft.com/pt-br/dotnet/api/system.array?view=net-6.0).

### Aula 1: O que aprendemos?

Nessa aula, você aprendeu:

- O que são arrays e como esta estrutura de dados é útil para agruparmos em uma única referência vários valores de determinado tipo;
- As sintaxes básicas de definição e inicialização de um array usando C#, entendendo as formas mais utilizadas e simples, que podem conferir dinamismo ao se trabalhar com arrays;
- A percorrer um array a fim de manipulá-lo para inserção de valores em seus índices e também para recuperar uma informação armazenada em determinada posição do array;
- Sobre a classe Array, que é a superclasse da qual todos os arrays de C# herdam seus atributos e propriedades.

## Aula 2: Array de contas correntes

### Aula 2: Array de contas - Vídeo 1

Transcrição  
Nas aulas anteriores, criamos alguns métodos e aprendemos conceitos interessantes relativos aos arrays. Testamos vetores de números inteiros e vetores de strings, fizemos um método para calcular a mediana, usamos diferentes laços de repetição e estudamos o uso da classe Array disponível na biblioteca de classes do .NET. Agora, continuaremos nossos estudos trabalhando com array de objetos.

Antes de começar, no arquivo Program.cs, vamos nos certificar de que comentamos as chamadas aos métodos TestaArrayInt(), TestaBuscarPalavra() e TestaMediana() criados anteriormente, para que não rodem toda vez que executarmos nosso projeto. Além disso, podemos retrair alguns trechos de código clicando no símbolo de "-" que aparece à direita do número da linha.

No Gerenciador de Soluções, no nosso pacote bytebank.Modelos, temos a pasta Conta que contém a classe ContaCorrente.cs. A partir da linha 85 de Program.cs, vamos criar um método de teste para definir um array de objetos — será um array de ContaCorrente:

```csharp
// código anterior omitido
void TestaArrayDeContasCorrentes()
{
    ContaCorrente[] listaDeContas = new ContaCorrente[]
    {
        new ContaCorrente(874, "5679787-A"),
        new ContaCorrente(874, "4456668-B"),
        new ContaCorrente(874, "7781438-C")
    }
}
```

Nesse processo, precisamos importar o namespace. Com o cursor em ContaCorrente[] na linha 89, pressionaremos "Ctrl + ." e selecionaremos "using bytebank.Modelos.Conta".

Além disso, note que usamos uma construção diferente: criamos o array listaDeContas e já o inicializamos com três contas-correntes, informando o número da agência e o número da conta.

Para demonstrar essa nova construção, poderíamos criar um array de números inteiros chamado valores com a seguinte linha de código: int[] valores = new int[] {1, 2, 3, 5}. Assim, já criamos um vetor e o inicializamos.

Voltando ao nosso código, já temos um array de objetos. A seguir, vamos iterar sobre esse vetor e exibir os valores das contas no console:

```csharp
// código anterior omitido

void TestaArrayDeContasCorrentes()
{
    ContaCorrente[] listaDeContas = new ContaCorrente[]
    {
        new ContaCorrente(874, "5679787-A"),
        new ContaCorrente(874, "4456668-B"),
        new ContaCorrente(874, "7781438-C")
    }
    for(int i = 0; i < listaDeContas.Length; i++)
    {
        ContaCorrente contaAtual = listaDeContas[i];
        Console.WriteLine($"Índice{i} - Conta:{contaAtual.Conta}");
    }
}
```

Dentro do laço for, criamos uma conta auxiliar chamada contaAtual. A cada iteração, ela será a cópia de um dos elementos do array, de acordo com o índice. Em seguida, com Console.WriteLine(), exibiremos informações dessa variável.

Vamos fazer a chamada dessa função na linha 105:

```csharp
// código anterior omitido

void TestaArrayDeContasCorrentes()
{
    ContaCorrente[] listaDeContas = new ContaCorrente[]
    {
        new ContaCorrente(874, "5679787-A"),
        new ContaCorrente(874, "4456668-B"),
        new ContaCorrente(874, "7781438-C")
    }

    for(int i = 0; i < listaDeContas.Length; i++)
    {
        ContaCorrente contaAtual = listaDeContas[i];
        Console.WriteLine($"Índice{i} - Conta:{contaAtual.Conta}");
    }
}

TestaArrayDeContasCorrentes();
```

Em seguida, vamos salvar as alterações e clicar no play na parte superior do Visual Studio. Após compilar o projeto e renderizar o console, veremos como resultado uma lista dos índices e os números das contas correspondentes — exatamente como o esperado.

Neste vídeo, vimos que para criar um array de objetos usamos a mesma sintaxe que utilizamos anteriormente e também temos as mesmas propriedades e os mesmos métodos inerentes a arrays, como .Length e .Clone. Na sequência, continuaremos focando nesse tópico, encapsulando conceitos de array dentro de uma classe.

### Aula 2: Array de Objetos - Exercício

No momento, Esther está alocada no desenvolvimento do projeto do bytebank_ATENDIMENTO, e surgiu a necessidade da criação de uma lista de objetos que devem ser exibidos. Dada a codificação abaixo feita por Esther, qual a saída correta?

```csharp
var   listaDeContas = new ContaCorrente[]
{
            new ContaCorrente(874, "5679787-A"),
            new ContaCorrente(884, "4456668-B"),
            new ContaCorrente(894, "7781438-C")
};

for(int i=0; i < listaDeContas.Length; i++)
{
    Console.WriteLine($”{listaDeContas[i].Numero_agencia}”);
}
```

Marque a opção correta:

Alternativa incorreta

Resposta:  
874,884,894.

> Alternativa Correta. A execução do loop for exibe os números da agência nesta sequência.

### Aula 2: Para Recordar: Orientação a Objetos

Chegou o momento de relembrar mais alguns conceitos importantes para este curso.

Vale ressaltar que, caso já tenha grande familiaridade com esse assunto, você pode pular diretamente para a próxima seção. Vamos lá?

O que é orientação a objetos?  
A Programação Orientada a Objetos (POO) é um paradigma de programação que estrutura o software em torno de objetos, ou seja, entidades que combinam dados (atributos) e comportamentos (métodos). Seu objetivo é modelar problemas do mundo real de forma modular, tornando o código mais organizado, reutilizável e fácil de manter.

Relembre alguns conceitos importantes da POO:

Classes  
Definem atributos (dados) e métodos (ações) que os objetos terão. Por exemplo, a classe Carro pode ter atributos como cor e modelo, e métodos como acelerar().

```csharp
public class Carro
{
    // Atributos 
    public string Cor;
    public string Modelo;

    // Método
    public void Acelerar()
    {
        Console.WriteLine($"O carro {Modelo} está acelerando!");
    }
}
```

Objetos  
São instâncias concretas de uma classe, ou seja, representações físicas (na memória) de entidades do mundo real ou abstratas. Cada objeto tem seus próprios valores para os atributos definidos na classe e executa métodos independentemente de outros objetos.

Por exemplo: podemos instanciar um objeto meuCarro da classe Carro com o modelo “Fusca” na cor vermelha, além de executar o método acelerar por meio dele:

```csharp
// Criando e inicializando o objeto em uma única linha
Carro meuCarro = new Carro { 
    Cor = "Vermelho", 
    Modelo = "Fusca" 
};

// Usando o método do objeto
meuCarro.Acelerar();  // Saída: "O carro Fusca está acelerando!"
```

É importante lembrar que objetos possuem identidade única: mesmo que tenham os mesmos valores, são entidades distintas em memória. Por exemplo:

```csharp
Carro a = new Carro { Cor = "Preto" };
Carro b = new Carro { Cor = "Preto" };
Console.WriteLine(a == b);  // False (objetos diferentes!)
```

Herança  
Classes derivadas (ou “filhas”) podem herdar atributos e métodos da classe base (ou “mãe”), evitando repetição de código. Por exemplo:

```csharp
// Classe base
public class Veiculo {
    public string Modelo { get; set; }
    public void Frear() => Console.WriteLine($"{Modelo} freando...");
}

// Classes derivadas
public class Carro : Veiculo { 
    public int Portas { get; set; } // Atributo específico de Carro
}

public class Bicicleta : Veiculo {
    public int Aro { get; set; }  // Atributo específico de Bicicleta
}
```

Ao instanciar as classes Carro e Bicicleta, poderemos utilizar os atributos e métodos de Veiculo:

```csharp
// Criando objetos
var carro = new Carro() { 
    Modelo = "Fusca",  // Herdado de Veiculo
    Portas = 4         // Exclusivo de Carro
};

var bike = new Bicicleta() {
    Modelo = "Caloi",  // Herdado de Veiculo
    Aro = 29           // Exclusivo de Bicicleta
};

// Usando métodos e atributos
carro.Frear();  // Saída: "Fusca ligando..." (herdado)
bike.Frear();   // "Caloi ligando..." (herdado)

Console.WriteLine($"Portas: {carro.Portas}");  // Saída: “Portas: 4”
Console.WriteLine($"Aro: {bike.Aro}");  // “Saída: Aro: 29”
```

Interfaces  
Contratos que definem o que uma classe deve fazer (métodos), sem implementar como deve fazer, garantindo que diferentes classes sigam o mesmo padrão.

Por exemplo: a interface Veiculo pode exigir o método frear():

```csharp
public interface IVeiculo
{
    // Método obrigatório (sem implementação)
    void Frear();
}
```

Assim, as classes Carro e Bicicleta, representando veículos, podem implementar a interface Veiculo para garantir que ambas terão o método Frear():

```csharp
public class Carro : IVeiculo
{
    public void Frear()
    {
        Console.WriteLine($"Carro freando...");
    }
}

public class Bicicleta : IVeiculo
{
    public void Frear()
    {
        Console.WriteLine($"Bicicleta freando...");
    }
}
```

Então, ao usar essas classes para instanciar novos objetos, poderemos utilizar o método Frear() em ambas as instâncias, tendo resultados distintos (polimorfismo, lembra?!):

```csharp
class Program
{
    static void Main()
    {
        // Lista de veículos (tipados pela interface)
        List<IVeiculo> veiculos = new List<IVeiculo>
        {
            new Carro(),
            new Bicicleta() 
        };

        // Todos freiam, cada um do seu jeito
        foreach (var veiculo in veiculos)
        {
            veiculo.Frear();
        }
    }
}
// Saída:
// Carro freando... 
// Bicicleta freando... 
```

Em resumo, a POO facilita a reutilização de código, organização e manutenção através dos conceitos de classes, objetos e interfaces!

Relembrou?  
Agora que você revisou esses assuntos, pode continuar o curso! Se ainda tiver dúvidas sobre algum dos tópicos, recomendamos explorar mais os conceitos antes de avançar. Os conteúdos abaixo podem te ajudar:

- [Apostila de C# e orientação a objetos: Organizando o código com objetos](https://www.alura.com.br/apostila-csharp-orientacao-objetos/classes-e-objetos#organizando-o-codigo-com-objetos)
- [Programação orientada a objetos e programação estruturada](https://www.alura.com.br/artigos/poo-programacao-orientada-a-objetos)
- [Podcast Hipsters #129: Práticas de Orientação a Objetos](https://cursos.alura.com.br/extra/hipsterstech/praticas-de-orientacao-a-objetos-hipsters-129-a453)
- [Podcast Hipsters Ponto Tech #350: TechGuide - Orientação a Objetos](https://cursos.alura.com.br/extra/hipsterstech/techguide-orientacao-a-objetos-hipsters-ponto-tech-350-a2013)

### Aula 2: Classe lista de contas - Vídeo 2

Transcrição  
Agora vamos criar uma classe chamada ListaDeContasCorrentes.cs que encapsulará os comportamentos de um array de objetos. No Gerenciador de Solução à direita, clicaremos com o botão direito do mouse sobre o diretório bytebank.Util e selecionaremos "Adicionar > Classe...".

Na parte inferior da nova janela que se abriu, nomearemos essa classe "ListaDeContasCorrentes.cs". Em seguida, clicaremos no botão "Adicionar", na parte direita inferior. Assim, criamos a classe ListaDeContasCorrentes no namespace bytebank_ATENDIMENTO.bytebank.Util.

A primeira mudança, na linha 9 de ListaDeContasCorrentes.cs, será alterar de intern para public:

```csharp
public class ListaDeContasCorrentes
{

}
```

Essa classe terá um campo privado chamado _itens, que será um array de ContaCorrentes. De início o definimos como nulo:

```csharp
public class ListaDeContasCorrentes
{
    private ContaCorrente[] _itens = null;
}
```

Precisaremos importar um namespace. Basta colocarmos o cursor sobre ContaCorrente[] na linha 11, pressionar "Ctrl + ." e selecionar "using bytebank.Modelos.Conta".

Criaremos uma instância do array _itens no momento em que criarmos um objeto ListaDeContasCorrentes com o construtor. Para gerar um modelo do construtor, podemos utilizar um code snippet — bastar digitar ctor e pressionar a tecla "Tab" duas vezes:

```csharp
public class ListaDeContasCorrentes
{
    private ContaCorrente[] _itens = null;

    public ListaDeContasCorrentes()
    {

    }
} 
```

No momento em que invocarmos o construtor, _itens receberá um novo vetor de ContaCorrentes. O tamanho desse vetor será informado pelo parâmetro tamanhoInicial, que definiremos como 5 por padrão:

```csharp
public class ListaDeContasCorrentes
{
    private ContaCorrente[] _itens = null;

    public ListaDeContasCorrentes(int tamanhoInicial = 5)
    {
        _itens = new ContaCorrente[tamanhoInicial];
    }
}
```

Desse modo, caso não passemos nenhum valor ao invocar o construtor, a variável tamanhoInicial terá o tamanho padrão de 5. Do contrário, tamanhoInicial assumirá o valor informado.

A seguir, montaremos uma função chamada Adicionar() para inserir elementos nesse vetor:

```csharp
public class ListaDeContasCorrentes
{
    private ContaCorrente[] _itens = null;

    public ListaDeContasCorrentes(int tamanhoInicial = 5)
    {
        _itens = new ContaCorrente[tamanhoInicial];
    }

    public void Adicionar(ContaCorrente item)
    {

    }
}
```

O método Adicionar() receberá uma ContaCorrente que chamaremos item. Dentro dele, poderíamos usar _itens[0] = item para adicionar um item ao vetor, porém essa estrutura só funcionaria para a primeira posição do array. Então, vamos criar uma variável chamada _proximaPosicao para fazer o controle do índice em que vamos adicionar cada item.

Na linha 13, criaremos _proximaPosicao. Em seguida, usaremos essa variável dentro de Adicionar():

```csharp
public class ListaDeContasCorrentes
{
    private ContaCorrente[] _itens = null;
    private int _proximaPosicao=0;
    public ListaDeContasCorrentes(int tamanhoInicial = 5)
    {
        _itens = new ContaCorrente[tamanhoInicial];
    }

    public void Adicionar(ContaCorrente item)
    {
        _itens[_proximaPosicao] = item;
    }
}
```

Inicializamos _proximaPosicao com o valor 0. Após adicionar um item no array _itens, temos que incrementar essa variável, para que a próxima adição seja no índice seguinte:

```csharp
public class ListaDeContasCorrentes
{
    private ContaCorrente[] _itens = null;
    private int _proximaPosicao=0;
    public ListaDeContasCorrentes(int tamanhoInicial = 5)
    {
        _itens = new ContaCorrente[tamanhoInicial];
    }
    public void Adicionar(ContaCorrente item)
    {
        _itens[_proximaPosicao] = item;
        _proximaPosicao++;
    }
}
```

Para nos certificar de que os itens estão sendo inseridos no vetor, vamos exibir uma mensagem no console:

```csharp
public class ListaDeContasCorrentes
{
    private ContaCorrente[] _itens = null;
    private int _proximaPosicao=0;
    public ListaDeContasCorrentes(int tamanhoInicial = 5)
    {
        _itens = new ContaCorrente[tamanhoInicial];
    }

    public void Adicionar(ContaCorrente item)
    {
            Console.WriteLine($"Adicionando item na posição {_proximaPosicao}");
        _itens[_proximaPosicao] = item;
        _proximaPosicao++;
    }
}
```

Vamos salvar o arquivo ListaDeContasCorrentes.cs. Em seguida, abriremos Program.cs — basta dar um clique duplo sobre ele no Gerenciador de Soluções à direita.

Nosso objetivo é definir uma nova instância de ListaDeContasCorrentes, então vamos reescrever alguns trecho do método TestaArrayContasCorrentes() para reaproveitá-lo:

```csharp
void TestaArrayDeContasCorrentes()
{

    ListaDeContasCorrentes listaDeContas = new ListaDeContasCorrentes();
    listaDeContas.Adicionar(new ContaCorrente(874, "5679787-A"));
    listaDeContas.Adicionar(new ContaCorrente(874, "4456668-B"));
    listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C"));

}
```

Precisaremos importar um namespace. Com o cursor sobre ListaDeContasCorrentes, pressionaremos "Ctrl + ." e selecionaremos "using bytebank_ATENDIMENTO.bytebank.Util".

Com o código ajustado, o método TestaArrayContasCorrentes() criará uma instância de ListaDeContasCorrentes e invocará o método Adicionar() para inserir três contas ao vetor.

Vamos salvar e executar a aplicação. Como resultado, veremos as seguintes mensagens:

```csharp
Boas Vindas ao ByteBank, Atendimento.
Adicionando item na posição 0
Adicionando item na posição 1
Adicionando item na posição 2
```

Ou seja, conseguimos adicionar as três contas com sucesso.

No construtor de ListaDeContasCorrentes, passamos um tamanho inicial padrão de 5. Em TestaArrayContasCorrentes, vamos tentar adicionar mais de 5 elementos ao array para descobrir o que acontece:

```csharp
void TestaArrayDeContasCorrentes()
{

    ListaDeContasCorrentes listaDeContas = new ListaDeContasCorrentes();
    listaDeContas.Adicionar(new ContaCorrente(874, "5679787-A"));
    listaDeContas.Adicionar(new ContaCorrente(874, "4456668-B"));
    listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C"));
    listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C"));
    listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C"));
    listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C"));

}
```

Ao salvar e tentar executar o projeto, ocorrerá o erro System.IndexOutOfRangeException, porque estamos tentando adicionar um item em uma posição que não existe. O vetor tem apenas 5 posições e estamos adicionando 6 elementos.

Portanto, precisamos verificar o tamanho do nosso vetor interno da classe ListaDeContasCorrentes antes de chamar a próxima adição. Caso o número de elementos extrapole o tamanho do vetor, aumentaremos sua capacidade.

Esse método será privado, pois não deve ser invocado de fora da classe ListaDeContasCorrentes. Passaremos como parâmetro o tamanho necessário para não dar erro e, por meio de uma estrutura if/else, vamos determinar o que fazer quando o array tiver e quando não tiver capacidade suficiente:

```csharp
public class ListaDeContasCorrentes
{
    private ContaCorrente[] _itens = null;
    private int _proximaPosicao=0;
    public ListaDeContasCorrentes(int tamanhoInicial = 5)
    {
        _itens = new ContaCorrente[tamanhoInicial];
    }

    public void Adicionar(ContaCorrente item)
    {
        Console.WriteLine($"Adicionando item na posição {_proximaPosicao}");
        _itens[_proximaPosicao] = item;
        _proximaPosicao++;
    }

    private void VerificarCapacidade(int tamanhoNecessario)
    {
        if (_itens.Length>= tamanhoNecessario)
        {
            return;
        }
        else
        {

        }
    }
}
```

Algumas variáveis possuem nomes longos (como tamanhoNecessario), mas tornam nosso código mais intuitivo, pois sabemos de imediato que informação esta variável representa.

Assim, se o tamanho do array for igual ou maior ao tamanho necessário para não dar erro, não precisamos fazer nada. Vamos simplesmente parar de executar o VerificarCapacidade com o return.

Já se o tamanho do array for menor que o tamanho necessário, exibiremos uma mensagem no console e criar um array com o tamanho necessário:

```csharp
// código anterior omitido

    private void VerificarCapacidade(int tamanhoNecessario)
    {
        if (_itens.Length>= tamanhoNecessario)
        {
            return;
        }
        else
        {
            Console.WriteLine("Aumentando a capacidade da lista!");
            ContaCorrente[] novoArray = new ContaCorrente[tamanhoNecessario];
        }
    }
}
```

Em seguida, com uma estrutura for, vamos percorrer o array antigo e passar todos os valores para novoArray

```csharp
// código anterior omitido

private void VerificarCapacidade(int tamanhoNecessario)
{
    if (_itens.Length>= tamanhoNecessario)
    {
        return;
    }
    Console.WriteLine("Aumentando a capacidade da lista!");
    ContaCorrente[] novoArray = new ContaCorrente[tamanhoNecessario];

    for (int i = 0; i < _itens.Length; i++)
    {
        novoArray[i] = _itens[i];
    }
        _itens = novoArray;
}
```

Ou seja, enquanto i for menor que o tamanho de itens, continuaremos rodando esse loop. Os índices serão definidos por i e, a cada iteração, novoArray receberá um novo elemento de _itens. Esse processo é semelhante a uma clonagem. Por fim, vamos definir _itens como novoArray e o método VerificarCapacidade() estará pronto.

Como precisamos verificar a capacidade antes de adicionar uma nova conta no array, colocaremos a chamada a VerificarCapacidade() antes da adição, em Adicionar():

```csharp
// código anterior omitido

    public void Adicionar(ContaCorrente item)
    {
        Console.WriteLine($"Adicionando item na posição {_proximaPosicao}");
        VerificarCapacidade();
        _itens[_proximaPosicao] = item;
        _proximaPosicao++;
    }

private void VerificarCapacidade(int tamanhoNecessario)
{
    if (_itens.Length>= tamanhoNecessario)
    {
        return;
    }
    Console.WriteLine("Aumentando a capacidade da lista!");
    ContaCorrente[] novoArray = new ContaCorrente[tamanhoNecessario];

    for (int i = 0; i < _itens.Length; i++)
    {
        novoArray[i] = _itens[i];
    }
        _itens = novoArray;
}
```

Na chamada de VerificarCapacidade(), precisamos informar um valor inteiro correspondente ao tamanho necessário. No caso, este valor sempre será a _proximaPosicao + 1 — vamos acrescentá-lo na linha 22:

```csharp
// código anterior omitido
    public void Adicionar(ContaCorrente item)
    {
        Console.WriteLine($"Adicionando item na posição {_proximaPosicao}");
        VerificarCapacidade(_proximaPosicao + 1);
        _itens[_proximaPosicao] = item;
        _proximaPosicao++;
    }

private void VerificarCapacidade(int tamanhoNecessario)
{
    if (_itens.Length>= tamanhoNecessario)
    {
        return;
    }
    Console.WriteLine("Aumentando a capacidade da lista!");
    ContaCorrente[] novoArray = new ContaCorrente[tamanhoNecessario];

    for (int i = 0; i < _itens.Length; i++)
    {
        novoArray[i] = _itens[i];
    }
        _itens = novoArray;
}
```

Vamos salvar e executar o projeto, lembrando que em TestaArrayContasCorrentes continuamos com mais de 5 elementos sendo adicionados ao vetor! Como retorno, veremos que a capacidade da lista foi aumentada. Nosso código está funcionando como esperado: conseguimos adicionar itens no array, verificar a capacidade do vetor e aumentá-la durante a execução, caso necessário.

Nas próximas aulas, continuaremos aprimorando nosso projeto. Agora, já temos uma classe que encapsula a manipulação de um array de objetos do tipo ContaCorrente, ou seja, começamos a separar responsabilidades, a deixar nosso código mais orientado a objetos e mais flexível a mudanças. Na sequência, adicionaremos um método para remover itens do array.

### Aula 2: Desafio: método que retorna a conta com maior saldo

Agora que você está trabalhando com Esther na manutenção e evolução do sistema de contas correntes do ByteBank na classe que encapsula as operações sobre uma lista de contas correntes, foi solicitado que você desenvolva um método que retorne a conta corrente com o maior saldo da lista.

Este é um exercício opcional e te desafiamos a criar um método essa nova funcionalidade na classe ListaDeContaCorrente.

Opinião do instrutor

Agora apresentamos uma possível solução para o desafio proposto:

```csharp
public ContaCorrente MaiorSaldo()
{
    ContaCorrente conta=null;
    double maiorValor = 0;
    for (int i = 0; i < _itens.Length; i++)
    {
        if (_itens[i] != null)
        {
            if (maiorValor < _itens[i].Saldo)
            {
                maiorValor = _itens[i].Saldo;
                conta = _itens[i];
            }
        }

    }

    return conta;
}
```

### Aula 2: Removendo itens - Vídeo 3

Anteriormente, criamos o método Adicionar() que insere um item no nosso array. A estrutura desse método recebe como parâmetro uma ContaCorrente, então vamos usar a mesma lógica ao criar um método para remoção de contas, a seguir.

No arquivo ListaDeContasCorrentes.cs, depois do VerificarCapacidade(), criaremos Remover():

```csharp
// código anterior omitido

public void Remover(ContaCorrente conta)
{
    int indiceItem = -1;
    for (int i = 0; i < _proximaPosicao; i++)
    {
        ContaCorrente contaAtual = _itens[i];
        if (contaAtual == conta)
        {
                indiceItem = i;
                break;
            }
    }
    // 0         1       2
    //[conta1][conta2][conta4][conta5][null]
    for (int i = indiceItem; i < _proximaPosicao-1; i++)
    {
            _itens[i] = _itens[i + 1];
    }
    _proximaPosicao--;
    _itens[_proximaPosicao] = null;
}
```

Primeiramente, definimos e inicializamos indiceItem, que receberá o índice do item que queremos remover do array. Em seguida, vamos percorrer o vetor usando i < _proximaPosicao como método de verificação para a continuidade do loop. Dentro do laço, criaremos uma variável chamada contaAtual que, a cada iteração, receberá um elemento de uma posição do array. Com o if, verificaremos se contaAtual é igual à conta que recebemos como parâmetro.

Caso seja igual, quer dizer que encontramos o item a ser removido e já sabemos seu índice no array. Portanto, definiremos indiceItem com o valor de i e interromperemos o loop com o break.

Para tornar mais claro, vamos imaginar que temos o seguinte array com 5 contas:

```csharp
[conta1][conta2][conta3][conta4][conta5]
E desejamos remover a conta3, isto é, a conta no índice 2:
```

```csharp
0       1       2       3       4
[conta1][conta2][conta3][conta4][conta5]
```

Nesse caso, ao passar pelo laço de repetição, indiceItem assumirá o valor 2. O próximo passo é executar o segundo laço for, a partir do índice 2 que encontramos. Verificaremos se i é menor que _proximaPosicao-1 e incrementaremos i.

Dessa forma, a primeira iteração fará com que o índice 2 (_itens[2]) receba o valor do atual índice 3 (_itens[2 + 1]). Em resumo, a conta4 assumirá a posição da conta3:

```csharp
0          1        2        3     4
[conta1][conta2][conta4][conta4][conta5]
```

O laço continuará sendo executado, a conta5 assumirá a posição da conta4:

```csharp
0          1        2        3     4
[conta1][conta2][conta4][conta4][conta5]
```

O laço será encerrado. Na sequência, faremos _proximaPosicao-- e deixaremos a última posição com null:

```csharp
0          1        2        3    4
[conta1][conta2][conta4][conta4][null]
```

Essa é uma abstração que será feita durante o processamento. Movemos os índices para substituir o item que removemos, reordenando o vetor.

Vamos salvar as alterações.

No Program.cs, em TestaArrayDeContasCorrentes, vamos criar uma ContaCorrente chamada contaDoAndre e adicioná-la ao array. O número da agência será 963 e o número da conta, 123456-X:

```csharp
void TestaArrayDeContasCorrentes()
{

    ListaDeContasCorrentes listaDeContas = new ListaDeContasCorrentes();
    listaDeContas.Adicionar(new ContaCorrente(874, "5679787-A"));
    listaDeContas.Adicionar(new ContaCorrente(874, "4456668-B"));
    listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C"));
    listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C"));
    listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C"));
    listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C"));
    var contaDoAndre = new ContaCorrente(963, "123456-X");
    listaDeContas.Adicionar(contaDoAndre);

}
```

Seria interessante ter um método para listar, que percorra o array e exiba algumas informações. No arquivo ListaDeContasCorrentes.cs, definiremos um novo método ExibeLista() a partir da linha 65 (abaixo de Remover():

```csharp
// código anterior omitido

public void ExibeLista()
{
    for (int i = 0; i < _itens.Length; i++)
    {
        if (_itens[i] != null)
        {
            var conta = _itens[i];
            Console.WriteLine($" Indice[{i}] = " +
                $"Conta:{conta.Conta} - " +
                $"N° da Agência: {conta.Numero_agencia}");
        }
    }
}
```

Trata-se de uma simples iteração sobre nosso array que exibirá o índice, o número da conta e o número da agência no console.

Voltando a TestaArrayDeContasCorrentes(), após adicionar a contaDoAndre, chamaremos o método ExibeLista():

```csharp
void TestaArrayDeContasCorrentes()
{

    ListaDeContasCorrentes listaDeContas = new ListaDeContasCorrentes();
    listaDeContas.Adicionar(new ContaCorrente(874, "5679787-A"));
    listaDeContas.Adicionar(new ContaCorrente(874, "4456668-B"));
    listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C"));
    listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C"));
    listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C"));
    listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C"));
    var contaDoAndre = new ContaCorrente(963, "123456-X");
    listaDeContas.Adicionar(contaDoAndre);
    listaDeContas.ExibeLista();

}
```

Após exibir a lista, vamos remover a contaDoAndre e listar as contas novamente para nos certificar de que a remoção foi realizada com sucesso. Antes disso, usaremos um Console.WriteLine() para imprimir uma divisória:

```csharp
void TestaArrayDeContasCorrentes()
{

    ListaDeContasCorrentes listaDeContas = new ListaDeContasCorrentes();
    listaDeContas.Adicionar(new ContaCorrente(874, "5679787-A"));
    listaDeContas.Adicionar(new ContaCorrente(874, "4456668-B"));
    listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C"));
    listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C"));
    listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C"));
    listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C"));
    var contaDoAndre = new ContaCorrente(963, "123456-X");
    listaDeContas.Adicionar(contaDoAndre);
    listaDeContas.ExibeLista();
    Console.WriteLine("============");
    listaDeContas.Remover(contaDoAndre);
    listaDeContas.ExibeLista();
}
```

Vamos salvar e executar a aplicação, clicando no play na parte superior do Visual Studio. No console, veremos duas listagens: uma após a adição da contaDoAndre e outra depois de sua remoção. Nosso código está funcionando como o esperado.

Assim, neste vídeo, criamos um método para remover uma conta-corrente de um array, aprimorando a classe ListaDeContasCorrentes que encapsula a manipulação de arrays de ContaCorrentes.

Na sequência, aprenderemos a transformar a classe ListaDeContasCorrentes em uma classe indexável, para podermos acessar os elementos da classe ListaDeContasCorrentes como se fosse um array, através do índice.

### Aula 2: Faça como eu fiz: implementando a exibição da lista

Até este momento do curso, já entendemos como definir e inicializar arrays de tipos mais primitivos como int, double e evoluímos para criação de um array de objetos que carrega todos os atributos e métodos de um array. No desenvolvimento de uma classe que encapsula as operações e manipulação de um array é necessário existir um método que possa listar todos os seus elementos, então por que não praticamos um pouco? Crie um método que permita listar todos os elementos do array privado da classe ListaDeContaCorrente.

Opinião do instrutor

Como já temos nossa classe definida, vamos criar um método publico que percorra os elementos deste campo privado e exiba seus valores.

```csharp
public void ExibeLista()
{
    for (int i = 0; i < _itens.Length; i++)
    {
        if (_itens[i] != null)
        {
            var conta = _itens[i];
            Console.WriteLine($" Indice[{i}] = Conta:{conta.Conta} - N° da Agência: {conta.Numero_agencia}");
        }
    }
}
```

### Aula 2: Indexadores - Vídeo 4

No vídeo anterior, criamos um método para remover uma conta-corrente do nosso array. Também implementamos o método ExibeLista() que percorre o vetor e exibe informações sobre as contas no console:

```csharp
public void ExibeLista()
{
    for (int i = 0; i < _itens.Length; i++)
    {
        if (_itens[i] != null)
        {
            var conta = _itens[i];
            Console.WriteLine($" Indice[{i}] = " +
                $"Conta:{conta.Conta} - " +
                $"N° da Agência: {conta.Numero_agencia}");
        }
    }
}
```

Optamos por uma concatenação, pois assim conseguimos fazer as quebras de linhas para melhorar a visualização sem afetar o funcionamento do código.

Neste vídeo, nosso objetivo será tornar a classe ListaDeContasCorrentes indexável. Em outras palavras, queremos acessar os elementos do nosso vetor a partir de ListaDeContasCorrentes usando um índice.

Para ilustrar qual será o resultado, vamos modificar o método TestaArrayDeContasCorrentes(). Comentaremos as linhas 100 a 103 (basta selecioná-las e pressionar "Ctrl + K + C") e inserir uma estrutura for:

```csharp
void TestaArrayDeContasCorrentes()
{

    ListaDeContasCorrentes listaDeContas = new ListaDeContasCorrentes();
    listaDeContas.Adicionar(new ContaCorrente(874, "5679787-A"));
    listaDeContas.Adicionar(new ContaCorrente(874, "4456668-B"));
    listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C"));
    listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C"));
    listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C"));
    listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C"));
    var contaDoAndre = new ContaCorrente(963, "123456-X");
    listaDeContas.Adicionar(contaDoAndre);
    //listaDeContas.ExibeLista();
    //Console.WriteLine("============");
    //listaDeContas.Remover(contaDoAndre);
    //listaDeContas.ExibeLista();

    for (int = 0; i < listaDeContas.Tamanho; i++)
    {
        ContaCorrente conta = listaDeContas[i];
    }
}
```

Com esse laço, percorremos a listaDeContas enquanto i for menor que o tamanho do array — a propriedade .Tamanho ainda não existe, vamos implementá-la nesta aula. Na variável conta, vamos recuperar uma conta do array dentro da classe ListaDeContasCorrentes através de um índice! Ou seja, a ListaDeContasCorrentes será indexável.

Antes de continuarmos, vamos apagar as modificações que fizemos, pois eram apenas uma demonstração do resultado:

```csharp
void TestaArrayDeContasCorrentes()
{

    ListaDeContasCorrentes listaDeContas = new ListaDeContasCorrentes();
    listaDeContas.Adicionar(new ContaCorrente(874, "5679787-A"));
    listaDeContas.Adicionar(new ContaCorrente(874, "4456668-B"));
    listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C"));
    listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C"));
    listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C"));
    listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C"));
    var contaDoAndre = new ContaCorrente(963, "123456-X");
    listaDeContas.Adicionar(contaDoAndre);
    //listaDeContas.ExibeLista();
    //Console.WriteLine("============");
    //listaDeContas.Remover(contaDoAndre);
    //listaDeContas.ExibeLista();

}
Vamos abrir o arquivo ListaDeContasCorrentes.cs. A partir da linha 79, após ExibeLista(), criaremos um método para recuperar um elemento específico do nosso array de contas pelo índice:


```csharp
// código anterior omitido

public ContaCorrente RecuperarContaNoIndice(int indice)
{
    if (indice<0 || indice >=_proximaPosicao)
    {
        throw new ArgumentOutOfRangeException(nameof(indice));
    }

        return _itens[indice];
}
```

Este método será público e passaremos como parâmetro o índice do elemento que desejamos recuperar. Com o if, verificaremos se indice não é menor que 0 ou maior que o tamanho do array. Caso seja, vamos disparar a exceção ArgumentOutOfRangeException, informando o nameof(indice). Do contrário, retornaremos a conta cujo índice corresponde ao parâmetro passado.

A seguir, criaremos uma propriedade que define o tamanho do array. Na linha 89, vamos digitar prop e pressionar a tecla "Tab" duas vezes para montar uma base e modificá-la conforme a necessidade:

```csharp
// código anterior omitido

public ContaCorrente RecuperarContaNoIndice(int indice)
{
    if (indice<0 || indice >=_proximaPosicao)
    {
        throw new ArgumentOutOfRangeException(nameof(indice));
    }

    return _itens[indice];
}

public int Tamanho {
    get
    {
        return _proximaPosicao;
    }
}
```

A propriedade Tamanho será somente de leitura, então apagaremos o set para que não seja possível alterá-la fora da classe ListaDeContasCorrentes. O get retornará _proximaPosicao.

Já temos a propriedade Tamanho e um método para acessar uma conta específica por meio do seu índice. Vamos voltar ao Program´cs para testar. Em TestaArrayDeContasCorrentes(), incluiremos o for:

```csharp
void TestaArrayDeContasCorrentes()
{

    ListaDeContasCorrentes listaDeContas = new ListaDeContasCorrentes();
    listaDeContas.Adicionar(new ContaCorrente(874, "5679787-A"));
    listaDeContas.Adicionar(new ContaCorrente(874, "4456668-B"));
    listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C"));
    listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C"));
    listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C"));
    listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C"));
    var contaDoAndre = new ContaCorrente(963, "123456-X");
    listaDeContas.Adicionar(contaDoAndre);
    //listaDeContas.ExibeLista();
    //Console.WriteLine("============");
    //listaDeContas.Remover(contaDoAndre);
    //listaDeContas.ExibeLista();

    for (int = 0; i < listaDeContas.Tamanho; i++)
    {
        ContaCorrente conta = listaDeContas.RecuperarContaNoIndice(i);
        Console.WriteLine($"Indice [{i}] = {conta.Conta}/{conta.Numero_agencia);
    }
}
```

No laço for, recuperamos uma conta usando o método RecuperarContaNoIndice() e exibimos informações no console. Ao salvar e executar, nosso código está funcionando como esperado, porém ainda não atingimos nosso objetivo — a classe ListaDeContasCorrentes ainda não é indexável.

Queremos usar a estrutura ListaDeContasCorrentes[i]:

```csharp
void TestaArrayDeContasCorrentes()
{

    ListaDeContasCorrentes listaDeContas = new ListaDeContasCorrentes();
    listaDeContas.Adicionar(new ContaCorrente(874, "5679787-A"));
    listaDeContas.Adicionar(new ContaCorrente(874, "4456668-B"));
    listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C"));
    listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C"));
    listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C"));
    listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C"));
    var contaDoAndre = new ContaCorrente(963, "123456-X");
    listaDeContas.Adicionar(contaDoAndre);
    //listaDeContas.ExibeLista();
    //Console.WriteLine("============");
    //listaDeContas.Remover(contaDoAndre);
    //listaDeContas.ExibeLista();

    for (int = 0; i < listaDeContas.Tamanho; i++)
    {
        ContaCorrente conta = listaDeContas[i];
        Console.WriteLine($"Indice [{i}] = {conta.Conta}/{conta.Numero_agencia);
    }
}
```

Por enquanto, a estrutura ListaDeContasCorrentes[i] (na linha 107) causa um erro na aplicação. Então, vamos criar um indexador, que é um misto de propriedade com método. No arquivo ListaDeContasCorrentes, abaixo da propriedade Tamanho, adicionaremos o seguinte código:

```csharp
public ContaCorrente this[int indice]
{

}
```

Note que utilizamos a palavra reservada this, que já estudamos anteriormente nessa formação de C# e orientação a objetos. Em vez de usarmos os parênteses, como de costume, optamos pelos colchetes e informamos o índice.

Para retornar um item na posição indicada pelo indice, poderíamos incluir um get com _itens[indice]:

```csharp
public ContaCorrente this[int indice]
{
    get
    {
        return _itens[indice];
    }
}
```

Contudo, vamos aproveitar o método RecuperarContaNoIndice() que preparamos exatamente para esse propósito:

```csharp
public ContaCorrente this[int indice]
{
    get
    {
        return RecuperarContaNoIndice(indice);
    }
}
```

Dessa maneira, criamos um indexador. Note que ele tem o mesmo tipo que o array da classe de ListaDeContasCorrentes. Vamos salvar as alterações.

Voltando ao Program.cs, veremos que não há mais um erro na linha 107, em que definimos ListaDeContasCorrentes como uma classe indexável. Vamos executar a aplicação, clicando no play na parte superior do Visual Studio. Nosso programa continua funcionando como esperado, listando informações de todas as contas em nosso vetor. Tornamos ListaDeContasCorrentes uma classe indexável e agora podemos acessar elementos do array com um índice, como em listaDeContas[i].

Na sequência, veremos outras funcionalidades relacionadas a bibliotecas do .NET para criação e manipuilação de listas de objetos.

### Aula 2: Classe indexada - Exercício

Cleber e Esther desenvolveram uma classe que encapsula as operações sobre arrays de objetos do tipo ContaCorrente, contudo, eles querem deixar a utilização desta ainda mais dinâmica. Para isso, Cleber sugeriu tornar a classe indexável, pois caso outro desenvolvedor deseje usá-la no projeto, ao criar uma nova instância, essa poderia se comportar como um array. Abaixo a codificação da classe:

```csharp
 public class ListaDeContasCorrentes
{
    private ContaCorrente[] _itens = null;
    private int _proximaPosicao=0;

    public ListaDeContasCorrentes(int tamanhoInicial=5)
    {
        _itens = new ContaCorrente[tamanhoInicial];
    }

    public void Adicionar(ContaCorrente item)
    {
        …
    }

    private void VerificarCapacidade(int tamanhoNecessario)
    {
        …
    }

    public void Remover( ContaCorrente conta)
    {
        …
    }

    public void ExibeLista()
    {
        …
    }

    public ContaCorrente RecuperarContaNoIndice(int indice)
    {
        ….
    }

    public int Tamanho {
        get
        {
            return _proximaPosicao;
        }        
    }    
    //INDEXADOR
}
```

Escolha a opção correta para a definição do indexador da classe ListaDeContasCorrentes:

Resposta correta:  

```csharp
public ContaCorrente this[int indice]
{
    get
    {
        return RecuperarContaNoIndice(indice);
    }
}
```

> Para criar um indexador, precisamos usar a palavra reservada this com um índice inteiro em uma estrutura bem parecida a uma propriedade e definir a forma de recuperar um elemento do vetor interno da classe.

### Aula 2: ArrayList - Vídeo 5

Usando C#, entendemos como criar uma classe que encapsula e manipula uma lista de contas-correntes e compreendemos o funcionamento dos arrays. A partir de agora, focaremos em uma demanda da diretoria do ByteBank. Desenvolveremos uma aplicação para o gerente de contas realizar seus atendimentos no seu dia a dia: ele precisa criar e consultas contas para clientes, por exemplo. Pensando nessas necessidades, começaremos a implementar funções ao nosso sistema, trabalhando com os conceitos de listas e coleções de objetos.

Nas aulas anteriores, usamos o arquivo Program.cs para realizar uma série de testes. Para deixar o projeto mais organizado sem precisar apagar nada, comentaremos as chamadas aos métodos e utilizaremos as regions, um recurso interessante do Visual Studio. Basta incluirmos #region antes do trecho que desejamos envolver (no caso, na linha 6) e #endregion depois dele (na linha 114):

```csharp
using bytebank.Modelos.Conta;
using bytebank_ATENDIMENTO.bytebank.Util;

Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");

#region
//TestaArrayInt();
//TestaBuscarPalavra();

// trecho de código omitido

//TestaArrayDeContasCorrentes();
#endregion
```

Agora, temos a opção de elipsar a region, clicando no símbolo de "-" no canto esquerdo da linha 6. Assim, nosso código fica mais organizado. No final do projeto, podemos remover essa parte, mas a princípio vamos manter no Program.cs para consultas. Vamos nomeá-la "Exemplos Arrays em C#":

```csharp
#region Exemplos Arrays C#

// trecho de código omitido

#endregion
```

Em seguida, começaremos a desenvolver um sistema em console que permita que o usuário cadastre, liste, remova, ordene, pesquise contas e saia do sistema. De início, montaremos um menu com as seguintes opções:

- Cadastrar Contas
- Listas Contas
- Remover Contas
- Ordenar Contas
- Pesquisar Contas
- Sair do sistema

No Program.cs, na linha 116, criaremos um método chamado AtendimentoCliente() que contém toda a lógica para montar esse menu e chamar cada método responsável por cada uma dessas 6 funcionalidades.

Para simular um menu console, utilizaremos a estrutura while e uma variável de controle chamada opcao, inicializada com o caractere 0. Enquanto opcao for diferente do caractere 6, vamos limpar a tela (Console.Clear()) e exibir o menu (que montaremos a seguir):

```csharp
void AtendimentoCliente()
{
    char opcao = '0';
    while (opcao != '6')
    {
        Console.Clear();
    }
}
```

O código do menu console ficará assim:

```csharp
void AtendimentoCliente()
{
    char opcao = '0';
    while (opcao != '6')
    {
        Console.Clear();
        Console.WriteLine("===============================");
        Console.WriteLine("===       Atendimento       ===");
        Console.WriteLine("===1 - Cadastrar Conta      ===");
        Console.WriteLine("===2 - Listar Contas        ===");
        Console.WriteLine("===3 - Remover Conta        ===");
        Console.WriteLine("===4 - Ordenar Contas       ===");
        Console.WriteLine("===5 - Pesquisar Conta      ===");
        Console.WriteLine("===6 - Sair do Sistema      ===");
        Console.WriteLine("===============================");
        Console.WriteLine("\n\n");
        Console.Write("Digite a opção desejada: ");
        opcao = Console.ReadLine()[0];
        switch (opcao)
        {
            case '1':
                CadastrarConta();
                break;
            default:
                Console.WriteLine("Opcao não implementada.");
                break;
        }
    }
}
```

Dessa forma, o usuário verá uma lista de todas as funcionalidades disponíveis e poderá digitar qual deseja usar, de 1 a 6. O Console.ReadLine() retorna uma string e, como uma string nada mais é que um array de caracteres, vamos atribuir a primeira posição desse retorno à variável opcao.

Em seguida, trabalharemos com o switch para chamar o método responsável pela opção selecionada. Por enquanto, temos apenas o case 1 para cadastrar conta. Qualquer outra tecla resultará na mensagem "Opção não implementada" e, ao pressionar 6, sairemos do switch.

Nas bibliotecas de classe do .NET, temos algumas classes disponíveis para vincular coleções de objetos. A primeira que veremos chama-se ArrayList. Logo acima do método AtendimentoCliente(), na linha 116, definiremos uma lista do tipo ArrayList:

```csharp
ArrayList _listaDeContas = new ArrayList();
```

Teremos um erro na linha 116, porque precisamos importar o namespace que contém a classe ArrayList. Vamos colocar cursor sobre ArrayList, pressionar "Ctrl + ." e selecionar "using System.Collections".

A vantagem de usar um ArrayList é que já temos implementados métodos para adicionar e remover da lista, bem com consultá-la, por exemplo. Ou seja, ao trabalhar com coleções, não precisamos criar uma classe para manipular uma lista, o que traz muitas facilidades.

Na linha 139, no case 1, temos um erro, pois o método CadastrarConta() ainda não existe. Vamos colocar o cursor sobre CadastrarConta(), pressionar "Ctrl + ." e selecionar "Gerar método 'CadastrarConta'". A partir da linha 147, será definido um escopo básico desse método, que podemos adaptar para fazer o cadastro de uma conta:

```csharp
void CadastrarConta()
{
    Console.Clear();
    Console.WriteLine("===============================");
    Console.WriteLine("===   CADASTRO DE CONTAS    ===");
    Console.WriteLine("===============================");
    Console.WriteLine("\n");
    Console.WriteLine("=== Informe dados da conta ===");
    Console.Write("Número da conta: ");
    string numeroConta = Console.ReadLine();

    Console.Write("Número da Agência: ");
    int numeroAgencia = int.Parse(Console.ReadLine());

    ContaCorrente conta = new ContaCorrente(numeroAgencia, numeroConta);

    Console.Write("Informe o saldo inicial: ");
    conta.Saldo = double.Parse(Console.ReadLine());

    Console.Write("Infome nome do Titular: ");
    conta.Titular.Nome = Console.ReadLine();

    Console.Write("Infome CPF do Titular: ");
    conta.Titular.Cpf = Console.ReadLine();

    Console.Write("Infome Profissão do Titular: ");
    conta.Titular.Profissao = Console.ReadLine();

    _listaDeContas.Add(conta);
    Console.WriteLine("... Conta cadastrada com sucesso! ...");
    Console.ReadKey();
}
```

Assim, quando invocarmos a primeira opção do switch, rodaremos o CadastrarConta(). Esse método inicialmente executada o Console.Clear() para limpar a tela do console e exibirá o cabeçalho "CADASTRO DE CONTAS". Em seguida, será solicitado que o usuário informe o número da agência. Uma nova instância de ContaCorrente será criada e preencheremos mais informações. Por fim, adicionaremos a conta ao nosso ArrayList chamado _listaDeContas, por meio do método .Add(), e exibiremos uma mensagem de sucesso.

Vamos fazer a chamada de AtendimentoCliente() na linha 119, logo antes da definição do mesmo. Então, podemos salvar e executar nosso projeto, clicando no play na parte superior do Visual Studio.

No console, veremos as opções do menu. Digitaremos 1 e pressionaremos a tecla "Enter". Vamos preencher os dados: o número da conta será 741, o número da agência será 1, o saldo inicial será 50, o nome do titular será André.

Ao informar o titular, ocorrerá um erro! Na linha 168 do nosso código, temos uma exceção de referência nula. A classe ConrtaCorrente tem uma propriedade chamada Titular, que é um Cliente. Porém, quando criamos o objeto na linha 162, não instanciamos o Cliente e não o passamos como referência para a conta-corrente.

Vamos ao arquivo ContaCorrente.cs solucionar essa questão, instanciando o titular no momento que criamos o objeto. No construtor (linhas 114 a 120), adicionaremos o Titular:

```csharp
public ContaCorrente(int numero_agencia,string conta)
{
    Numero_agencia = numero_agencia;
    Conta = conta;
    Titular = new Cliente();
    TotalDeContasCriadas += 1;

}
```

Vamos salvar as alterações e executar nosso projeto novamente. No console, digitaremos 1 para cadastrar uma conta e informaremos seguintes dados:

```csharp
Número da conta: 741
Número da agência: 1
Saldo inicial: 50
Titular: André
CPF: 1111222333
Profissão: Dev
```

A conta será cadastrada com sucesso. Adicionamos nosso objeto preenchido ao ArrayList. Podemos pressionar "Enter" para voltar ao menu, contudo não temos nenhuma outra opção implementada ainda, então vamos encerrar a aplicação e voltar ao código.

O próximo passo será implementar a opção 2 do menu: listar as contas. Dentro do switch, entre as linhas 141 e 144, vamos criar o case 2:

```csharp
// código anterior omitido

switch (opcao)
{
    case '1':
        CadastrarConta();
        break;
    case '2':
        ListarContas();
        break;
    default:
        Console.WriteLine("Opcao não implementada.");
        break;

// código posterior omitido
```

Em seguida, vamos clicar sobre ListarContas(), pressionar "Ctrl + .", selecionar "Gerar método 'ListarContas()'" e adaptá-lo a partir da linha 150. Inicialmente, limparemos o console e exibiremos um cabeçalho:

```csharp
void ListarContas()
{
    Console.Clear();
    Console.WriteLine("===============================");
    Console.WriteLine("===     LISTA DE CONTAS     ===");
    Console.WriteLine("===============================");
    Console.WriteLine("\n");

}
```

Em seguida, usaremos a estrutura if para verificar se há contas cadastradas. Caso a lista esteja vazia, vamos exibir uma mensagem informativa ao usuário, que poderá voltar ao menu:

```csharp
void ListarContas()
{
    Console.Clear();
    Console.WriteLine("===============================");
    Console.WriteLine("===     LISTA DE CONTAS     ===");
    Console.WriteLine("===============================");
    Console.WriteLine("\n");
    if (_listaDeContas.Count <= 0)
    {
        Console.WriteLine("... Não há contas cadastradas! ...");
        Console.ReadKey();
        return;
    }

}
```

Caso o código não entre no if, vamos percorrer a lista com foreach e exibir os dados das contas:

```csharp
void ListarContas()
{
    Console.Clear();
    Console.WriteLine("===============================");
    Console.WriteLine("===     LISTA DE CONTAS     ===");
    Console.WriteLine("===============================");
    Console.WriteLine("\n");
    if (_listaDeContas.Count <= 0)
    {
        Console.WriteLine("... Não há contas cadastradas! ...");
        Console.ReadKey();
        return;
    }
    foreach (ContaCorrente item in _listaDeContas)
    {
        Console.WriteLine("===  Dados da Conta  ===");
        Console.WriteLine("Número da Conta : " + item.Conta);
        Console.WriteLine("Saldo da Conta : " + item.Saldo);
        Console.WriteLine("Titular da Conta: " + item.Titular.Nome);
        Console.WriteLine("CPF do Titular  : " + item.Titular.Cpf);
        Console.WriteLine("Profissão do Titular : " + item.Titular.Profissao);
        Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
        Console.ReadKey();
    }

}
```

Ou seja, para cada item do tipo ContaCorrente na coleção _listaDeContas, exibiremos o número e saldo da conta, bem como o nome, CPF e profissão do titular.

Vamos salvar e executar a aplicação. Primeiro, pressionaremos 1 para cadastrar uma conta:

```csharp
Número da conta: 852
Número da agência: 2
Saldo inicial: 63
Titular: José
CPF: 8888888
Profissão: Dev
```

Após o cadastro, vamos retornar ao menu e pressionar 2 para listar as contas. Veremos a conta do José, o programa está funcionando como o esperado.

Assim, elaboramos um sistema para preencher o cadastro de contas e listá-las. Utilizamos a biblioteca ArrayList que encapsula a manipulação da lista e reduz nosso trabalho, visto que possui uma série de métodos prontos para, por exemplo, cadastrar, listar e remover itens.

Na sequência, continuaremos implementando mais funcionalidades e detalhes ao projeto em C#.

### Aula 2: Para saber mais: Collection ArrayList

A classe de biblioteca do .NET ArrayList é uma implementação evoluída de um array, a classe ArrayList faz parte do namespace System.Collections, e dentre as características desta classe temos:

- A possibilidade de expandir seus limites por meio da propriedade Capacity.
- A classe Array já disponibiliza operações de adição, inserção e exclusão de elementos.
- Como os arrays também tem disponível os métodos de ordenação de elementos Sort e de inversão da ordem por meio do Reverse.

Uma característica importante da classe ArrayList é a possibilidade de se adicionar qualquer tipo de elemento, uma vez que ela trabalha com tipo da superclasse object da qual todos os tipos do C# derivam.

Para saber mais sobre as possibilidade de utilização e métodos da classe ArrayList deixamos a recomendação de [acesso a documentação da Microsoft ArrayList Classe](https://docs.microsoft.com/pt-br/dotnet/api/system.collections.arraylist?view=net-6.0).

### Aula 2: O que aprendemos?

Nessa aula, você aprendeu:

- A utilizar a encapsular a manipulação de um array de objetos em um classe a fim de facilitar a manutenção de uma estrutura de objetos;
- Como utilizar um indexador, que permite que uma classe desenvolvida por você possa ser indexada como um array;
- A utilizar a collection ArrayList, uma classe que permite trabalhar com coleções de objetos e já implementa uma série de métodos para manipulação de um array de objetos.

## Aula 3: List`<T>`

### Aula 3: Projeto da aula anterior

Você pode [baixar o zip do projeto da aula](https://github.com/alura-cursos/Array_Collections_C/archive/refs/heads/aula02.zip) ou acessar o link do [repositório no GitHub](https://github.com/alura-cursos/Array_Collections_C/tree/aula02)!

### Aula 3: Generic e List - Vídeo 1

Anteriormente, definimos _listaDeContas do tipo ArrayList, que é uma classe que pertence ao namespace System.Collections. A vantagem do ArrayList é que ela engloba uma série de métodos e propriedades comuns a arrays'. Como estamos trabalhando com um array de objetos, então com ArrayList conseguimos adicionar as contas-correntes.

Na implementação do nosso sistema, desenvolvemos métodos CadastrarConta() e ListarContas(), que correspondem às opções 1 e 2 no menu da nossa aplicação.

Para melhorar a visualização do código, podemos clicar no símbolo "-" ou "+" à direita do número da linha para retrair ou expandir alguns métodos.

Na aula anterior, para verificar a listagem de contas, primeiro tivemos que criar uma conta. Para evitar esse retrabalho de cadastrar contas todas as vezes que precisarmos testar a aplicação, vamos definir uma lista padrão. Ao criar o ArrayList na linha 117, já passaremos 3 elementos:

```csharp
ArrayList _listaDeContas = new ArrayList() {
    new ContaCorrente(95, "123456-X") {Saldo=100},
    new ContaCorrente(95, "951258-X") {Saldo=200},
    new ContaCorrente(94, "987321-W") {Saldo=60}
};
```

Assim, invocamos o construtor e passamos, entre chaves, os saldos de cada conta. Vamos salvar e executar a aplicação para testar. Digitaremos 2 para listar as contas. Pressionando "Enter", veremos cada uma das 3 contas. O código está funcionando.

A seguir, vamos focar no método CadastrarConta(). Após informar todos os dados, o comando _listaDeContas.Add(conta) na linha 210 adicionará a nova conta ao ArrayList. Para fazer um teste, na linha seguinte adicionaremos uma string a _listaDeContas:

```csharp
void CadastrarConta()
{

// trecho de código omitido

    _listaDeContas.Add(conta);
    _listaDeContas.Add("Olá Mundo");

    Console.WriteLine("... Conta cadastrada com sucesso! ...");
    Console.ReadKey();
}
```

Vamos salvar as alterações e rodar a aplicação, clicando no play na parte superior do Visual Studio. Digitaremos 1 para cadastrar uma conta e passaremos os seguintes dados:

```csharp
Número da conta: 96
Número da Agência: 96
Saldo inicial: 100
Titular: André
CPF: 111111
Profissão: Dev
```

Veremos a mensagem de que o cadastro foi realizado com sucesso. Não vamos encerrar a aplicação ainda! Sabemos que, na linha 210, adicionamos a conta ao ArrayList; na linha 211, adicionamos a string "Olá Mundo" ao ArrayList; e, na linha 213, retornamos a mensagem de sucesso. Vamos voltar ao menu da aplicação e digitar 2 para listar as contas.

Veremos a primeira conta e pressionaremos "Enter" para ver as contas seguintes. Após a quarta conta, ao apertar "Enter", ocorrerá um erro. Podemos examiná-lo no foreach, na linha 168 de Program.cs. Nesse laço, estamos extraindo itens do tipo ContaCorrente de _listaDeContas, porém encontramos uma string e não foi possível fazer a conversão para ContaCorrente, então nos deparamos com essa exceção.

Em outras palavras, ao listar as contas-correntes, o programa não sabe lidar com itens que não são do tipo ContaCorrente, porém nada nos impede de adicionar itens que não são do tipo ContaCorrente à lista, como uma string. Precisamos corrigir isso.

Em CadastrarConta(), vamos posicionar o mouse sobre o método .Add(), na linha 210, e verificaremos que ele recebe um parâmetro do tipo object. Sabemos que object é uma superclasse do C# da qual todas classes herdam — uma string é um object, um int é object, as classes ContaCorrente e Cliente também são objects!

Disponibilizaremos um material extra na plataforma sobre a classe object do C#, nessa formação.

Então, é interessante usarmos um mecanismo que nos permita adicionar apenas objetos do tipo ContaCorrente na nossa lista. Felizmente, o .NET já conta com esse recurso.

Na definicação da nossa _listaDeContas, a partir da linha 117, utilizaremos a classe List<>, que é uma classe genérica. Sendo assim, ao criá-la, nós especificaremos o seu tipo:

```csharp
List<ContaCorrente> _listaDeContas = new List<ContaCorrente>() {
    new ContaCorrente(95, "123456-X") {Saldo=100},
    new ContaCorrente(95, "951258-X") {Saldo=200},
    new ContaCorrente(94, "987321-W") {Saldo=60}
};
```

A classe List<> também é uma coleção de objetos, a diferença é que ela é genérica. Então, utilizamos o recurso Generics, que é o uso do símbolo de menor (<), seguido do tipo e do símbolo de maior (>).

Também teremos material extra especificamente sobre o Generics.

Note que, com o Generics, conseguimos parametrizar a definição em relação ao objeto ou definir uma classe. Veremos que, na linha 211 onde adicionamos uma string à _listaDeContas, passamos a ter um erro, pois agora só conseguimos adicionar objetos do tipo ContaCorrente. Se posicionarmos o mouse sobre .Add nessa linha, podemos verificar que o método só recebe parâmetros do tipo ContaCorrente.

Como não queremos adicionar a string "Olá Mundo", vamos remover a linha 211 do nosso código e salvar o projeto.

Portanto, estamos usando uma classe genérica da própria biblioteca de classes do .NET. Essa classe nos permite trabalhar com outros tipos de objetos. No caso, definimos que a _listaDeContas recebe somente objetos do tipo ContaCorrente. Essa prática também é interessante por uma questão de segurança, pois sabemos que nossa lista receberá somente contas-correntes.

Para testar, vamos rodar o projeto, clicando no play na parte superior do Visual Studio. Digitaremos 2 para listar as contas e, pressionando "Enter" algumas vezes, não teremos problemas para visualizar a lista. Voltando ao menu, digitaremos 1 para cadastrar uma conta e informaremos os seguintes dados:

```csharp
Número da conta: 147
Número da Agência: 258
Saldo inicial: 96
Titular: André
CPF: 11111
Profissão: Dev
```

Veremos a mensagem de cadastro realizado com sucesso. Voltando ao menu, digitaremos 2 para ver a listagem novamente, dessa vez com uma conta a mais. Nosso código está funcionando como esperado.

Desse modo, usamos a classe List<> para restringir a adição de objetos à lista. As coleções das bibliotecas do .NET contêm recursos, por exemplo, de adição e remoção de itens da lista, bem como uma série de propriedades úteis para manipular um array de objetos. Essas facilidades tornam as coleções mais vantajosas do que uma maneira mais tradicional de criar uma lista de objetos, como um array.

Na utilização da classe List<>, estamos trabalhando com Generics, um recurso que permite trabalhar com classes e métodos sem definir explicitamente o tipo de retorno ou o tipo daquela determinada classe.

Ao final do arquivo Program.cs, a partir da linha 216, vamos criar uma classe genérica:

```csharp
public class Generica<T>
{
    public void MostrarMensagem (T t)
    {
        Console.WriteLine ($"Exibindo (t)");
    }
}
```

Em Generica`<T>`, usamos o `<T>` como padrão. Nessa classe, temos um método que recebe T e exibimos uma mensagem no console de acordo com esse elemento genérico. Antes da definição da classe, vamos criar um objeto, passando o tipo que queremos trabalhar, no caso, int:

```csharp
Generica<int> teste1 = new Generica<int>();

public class Generica<T>
{
    public void MostrarMensagem (T t)
    {
        Console.WriteLine ($"Exibindo (t)");
    }
}
```

Em seguida, podemos usar o método MostrarMensagem() de teste1, passando como parâmetro o valor 10, que será o T:

```csharp
Generica<int> teste1 = new Generica<int>();
teste1.MostrarMensagem(10);

public class Generica<T>
{
    public void MostrarMensagem (T t)
    {
        Console.WriteLine ($"Exibindo (t)");
    }
}
```

Ao posicionar o mouse sobre .MostrarMensagem(), é possível verificar que esse método recebe um inteiro, ou seja, o tipo da classe que definimos ao criar o objeto.

A título de testes, vamos criar outro objeto genérico, dessa vez do tipo string:

```csharp
Generica<int> teste1 = new Generica<int>();
teste1.MostrarMensagem(10);

Generica<string> teste2 = new Generica<string>();
teste2.MostrarMensagem("Olá mundo!");

public class Generica<T>
{
    public void MostrarMensagem (T t)
    {
        Console.WriteLine ($"Exibindo {t}");
    }
}
```

Vamos comentar a chamada a AtendimentoCliente() na linha 123, para realizar nossos testes sem percorrer o código que não nos interessa no momento. Vamos salvar e executar o projeto. Como resultado, veremos "Exibindo 10" e "Exibindo Olá mundo!".

Assim, criamos uma classe genérica de exemplo para compreender o dinamismo que obtemos ao utilizar o Generics, que é um recurso bastante interessante, pois permite que reaproveitemos código ao utilizar o C#.

Na sequência, testaremos outros métodos e propriedades da classe List<>.

### Aula 3: Usando o List - Exercício

Neste momento, Esther e Cleber estão fazendo programação em par para a manutenção do sistema bytebank_ATENDIMENTO, e iniciaram uma conversa sobre a opção de mudar o tipo da lista de conta corrente de ArrayList para List. Com relação às vantagens desta mudança, o que podemos afirmar. Marque as opções corretas:

Selecione 3 alternativas:

Resposta correta:  
Com a utilização de generics problemas relacionados à conversão de objetos inseridos ou recuperados da lista são reduzidos, pois especificamos o tipo da lista.

> Com a utilização do generics temos maior segurança pois diminuímos a probabilidade de conversões de tipos em tempo de execução.

Resposta correta:  
Podemos iterar sobre a lista (List) da mesma forma que percorremos um array de um tipo primitivo.

> A classe ListT possibilita iterar sobre seus elementos como um array usando estruturas como for, while e foreach.

Resposta correta:  
Utilizando a classe List com generics, temos a disposição todos os comportamentos e propriedades de ArrayList e ainda conseguimos ter uma lista tipada para aceitar somente elementos do tipo definido entre <> na definição da lista de objetos.

> A classe ListT é uma versão genérica da classe ArrayList e disponibiliza os comportamentos e propriedades comuns a uma lista de objetos.

### Aula 3: Para saber mais: Generics

O Generics é um recurso da linguagem que permite que possamos personalizar métodos, classes, interfaces e estruturas, podendo inclusive diminuir retrabalho e maximizar o desempenho de uma aplicação proporcionando uma segurança de tipos.

Desde a versão 2.0 do .NET Framework a plataforma traz esta feature, usando generics conseguimos deixar a definição do tipo para o momento que precisamos de determinado elemento no nosso código, o que em resumo é dizer que a classe ou método possa trabalhar com qualquer tipo. Ok, mas como é isso na prática? Vamos a um exemplo:

```csharp
  public class MinhaClasseGenerica<T>
    {
        public T PropriedadeGenerica { get; set; }
        public void ExibirDados(T t)
        {
            Console.WriteLine($"Dado Informado = {t.ToString()}");
            Console.WriteLine($"Tipo = {t.GetType()}");
        }  

    }
```

Note que a classe possui um parâmetro `<T>` que será substituído pela tipo de quando criamos um objeto desta classe, veja:

```csharp
MinhaClasseGenerica<string> objGenerico = new MinhaClasseGenerica<string>();
objGenerico.ExibirDados("Olá mundo!");

MinhaClasseGenerica<int> objGenerico2 = new MinhaClasseGenerica<int>();
objGenerico2.ExibirDados(3);

Pessoa andre = new Pessoa() { Idade = 18, Nome = "André" };
MinhaClasseGenerica<Pessoa> objGenerico3 = new MinhaClasseGenerica<Pessoa>();
objGenerico3.ExibirDados(andre);

public class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public override string ToString()
    {
        return $"Nome = {this.Nome} com Idade = {this.Idade}";
    }
}
```

Vamos executar e teremos a seguinte saída no console:

Imagem

Os genéricos oferecem uma série de vantagens como:

- Diminuição de ocorrer erros de conversão de tipos em tempo de execução.
- Melhora no desempenho, os tipos de coleções que usam generics geralmente executam melhor para armazenar e manipular tipos de valor.
- Redução do consumo de memória pois não executam operação de Boxing (converter explicitamente um tipo de valor em um objeto).

Para saber ainda mais sobre os recursos e vantagens na utilização de generics fica a recomendação da [documentação oficial da Microsoft Generics in .NET](https://docs.microsoft.com/pt-br/dotnet/standard/generics/).

### Aula 3: Métodos disponíveis - Vídeo 2

Anteriormente, compreendemos do que trata o Generics e utilizamos a classe genérica List<> da biblioteca do .NET para trabalhar com listas de objetos genéricos. Entre as linhas 117 e 121 de Program.cs, definimos que _listaDeContas receberá somente objetos do tipo ContaCorrente e também fizemos alguns testes, criando uma classe Generica`<T>`, a partir da linha 216 do nosso código. Nesta aula, vamos desvendar outros recursos e métodos disponíveis na classe List<>.

De início, vamos comentar as linhas de código da linha 216 em diante, referentes aos testes com Generics. Basta selecionarmos essas linhas e pressionar "Ctrl + k + C". Podemos também retrair esse trecho, clicando no símbolo de "-" no canto esquerda da linha 216.

Para estudar alguns métodos da classe List<>, vamos criar duas listas genéricas de objetos, a partir da linha 230:

```csharp
List<ContaCorrente> _listaDeContas2 = new List<ContaCorrente>()
{
    new ContaCorrente(874, "5679787-A"),
    new ContaCorrente(874, "4456668-B"),
    new ContaCorrente(874, "7781438-C")
};

List<ContaCorrente> _listaDeContas3 = new List<ContaCorrente>()
{
    new ContaCorrente(951, "5679787-E"),
    new ContaCorrente(321, "4456668-F"),
    new ContaCorrente(719, "7781438-G")
};
```

Assim, temos _listaDeContas2 que contém três objetos do tipo ContaCorrente cujos finais são respectivamente A, B e C. Já a listaDeContas3 contém outros três objetos com finais E, F e G.

Digitando _listaDeContas2 e adicionando um ponto, temos acesso às propriedades e métodos disponíveis dessa classe de objetos, por exemplo: Add, Clear, Remove, Contains, Append, entre outros métodos para consultar a coleção. O primeiro que testaremos é o AddRange, que adiciona uma lista ao final de outra:

```csharp
List<ContaCorrente> _listaDeContas2 = new List<ContaCorrente>()
{
    new ContaCorrente(874, "5679787-A"),
    new ContaCorrente(874, "4456668-B"),
    new ContaCorrente(874, "7781438-C")
};

List<ContaCorrente> _listaDeContas3 = new List<ContaCorrente>()
{
    new ContaCorrente(951, "5679787-E"),
    new ContaCorrente(321, "4456668-F"),
    new ContaCorrente(719, "7781438-G")
};
_listaDeContas2.AddRange(_listaDeContas3);
```

No caso, estamos adicionaremos _listaDeContas3 ao range de listaDeContas2. Em seguida, da linha 246 a 249, acrescentaremos um laço for para percorrer a _listaDeContas2 e exibir todos os seus elementos no console:

```csharp
// código anterior omitido

_listaDeContas2.AddRange(_listaDeContas3);

for (int i = 0; i < _listaDeContas2.Count; i++)
{
    Console.WriteLine($"Indice[{i}] = Conta [{_listaDeContas2[i].Conta}]");
}
```

Com AddRange(), adicionamos 3 itens à _listaDeContas2, portanto o resultado esperado é que sejam exibidos 6 elementos. Ao salvar e executar o projeto, veremos o retorno esperado: 6 contas, com finais de A a G.

Outro método interessante da classe List<> é o GetRange(), para extrair uma lista de outra. Como já vimos em outros cursos na Alura, o prefixo get serve para "pegar" um elemento. Ao final do nosso código, na linha 251, criaremos uma variável chamada range que receberá _listaDeContas3.GetRange(0, 1):

```csharp
var range = _listaDeContas3.GetRange(0, 1);
```

O método GetRange requer dois parâmetros (o index e o count) que representam o início e o fim do trecho que queremos extrair. No caso, do 0 ao 1. Assim, range será a lista resultante dessa extração. Em seguida, vamos percorrer o range com uma estrutura for:

```csharp
var range = _listaDeContas3.GetRange(0, 1);
for (int i = 0; i < range.Count; i++)
{
    Console.WriteLine($"Indice[{i}] = Conta [{range[i].Conta}]");
}
```

Antes de testar, vamos comentar o laço for que percorre _listaDeContas2, pois não queremos que esse trecho seja executado no momento:

```csharp
List<ContaCorrente> _listaDeContas2 = new List<ContaCorrente>()
{
    new ContaCorrente(874, "5679787-A"),
    new ContaCorrente(874, "4456668-B"),
    new ContaCorrente(874, "7781438-C")
};

List<ContaCorrente> _listaDeContas3 = new List<ContaCorrente>()
{
    new ContaCorrente(951, "5679787-E"),
    new ContaCorrente(321, "4456668-F"),
    new ContaCorrente(719, "7781438-G")
};

_listaDeContas2.AddRange(_listaDeContas3);

//for (int i = 0; i < _listaDeContas2.Count; i++)
//{
//    Console.WriteLine($"Indice[{i}] = Conta [{_listaDeContas2[i].Conta}]");
//}

var range = _listaDeContas3.GetRange(0, 1);
for (int i = 0; i < range.Count; i++)
{
    Console.WriteLine($"Indice[{i}] = Conta [{range[i].Conta}]");
}
```

Vamos salvar e executar a aplicação, clicando no play na parte superior do Visual Studio. Como resultado, veremos a conta no índice 0 cujo final é a letra E. Trata-se de uma lista que possui apenas um elemento extraído de _listaDeContas3.

Já aprendemos a usar o AddRange() e o GetRange(). A seguir, aplicaremos um método que inverte a ordem de uma lista, o Reverse(). Após adicionar o range na linha 244, vamos aplicar o Reverse():

```csharp
List<ContaCorrente> _listaDeContas2 = new List<ContaCorrente>()
{
    new ContaCorrente(874, "5679787-A"),
    new ContaCorrente(874, "4456668-B"),
    new ContaCorrente(874, "7781438-C")
};

List<ContaCorrente> _listaDeContas3 = new List<ContaCorrente>()
{
    new ContaCorrente(951, "5679787-E"),
    new ContaCorrente(321, "4456668-F"),
    new ContaCorrente(719, "7781438-G")
};

_listaDeContas2.AddRange(_listaDeContas3);
_listaDeContas2.Reverse();

//for (int i = 0; i < _listaDeContas2.Count; i++)
//{
//    Console.WriteLine($"Indice[{i}] = Conta [{_listaDeContas2[i].Conta}]");
//}

var range = _listaDeContas3.GetRange(0, 1);
for (int i = 0; i < range.Count; i++)
{
    Console.WriteLine($"Indice[{i}] = Conta [{range[i].Conta}]");
}
```

Em seguida, vamos descomentar o laço for para percorrermos a _listaDeContas2 exibindo seus elementos, assim podemos checar se a ordem foi invertida, de fato. Para descomentar um trecho, basta selecioná-lo e pressionar "Ctrl + K + U":

```csharp
List<ContaCorrente> _listaDeContas2 = new List<ContaCorrente>()
{
    new ContaCorrente(874, "5679787-A"),
    new ContaCorrente(874, "4456668-B"),
    new ContaCorrente(874, "7781438-C")
};

List<ContaCorrente> _listaDeContas3 = new List<ContaCorrente>()
{
    new ContaCorrente(951, "5679787-E"),
    new ContaCorrente(321, "4456668-F"),
    new ContaCorrente(719, "7781438-G")
};

_listaDeContas2.AddRange(_listaDeContas3);
_listaDeContas2.Reverse();

for (int i = 0; i < _listaDeContas2.Count; i++)
{
    Console.WriteLine($"Indice[{i}] = Conta [{_listaDeContas2[i].Conta}]");
}

var range = _listaDeContas3.GetRange(0, 1);
for (int i = 0; i < range.Count; i++)
{
    Console.WriteLine($"Indice[{i}] = Conta [{range[i].Conta}]");
}
```

Por fim, comentaremos o laço que percorre range, para que o programa ignore esse trecho por enquanto:

```csharp
List<ContaCorrente> _listaDeContas2 = new List<ContaCorrente>()
{
    new ContaCorrente(874, "5679787-A"),
    new ContaCorrente(874, "4456668-B"),
    new ContaCorrente(874, "7781438-C")
};

List<ContaCorrente> _listaDeContas3 = new List<ContaCorrente>()
{
    new ContaCorrente(951, "5679787-E"),
    new ContaCorrente(321, "4456668-F"),
    new ContaCorrente(719, "7781438-G")
};

_listaDeContas2.AddRange(_listaDeContas3);
_listaDeContas2.Reverse();

for (int i = 0; i < _listaDeContas2.Count; i++)
{
    Console.WriteLine($"Indice[{i}] = Conta [{_listaDeContas2[i].Conta}]");
}

//var range = _listaDeContas3.GetRange(0, 1);
//for (int i = 0; i < range.Count; i++)
//{
//    Console.WriteLine($"Indice[{i}] = Conta [{range[i].Conta}]");
//}
```

Para testar, vamos salvar e pressionar o play na parte superior do Visual Studio. O resultado será uma lista de 6 contas, de G a A — ou seja, na ordem invertida da lista original.

Feito esse teste, vamos descomentar novamente o laço que percorre range. Para separar algumas informações e deixar nosso código mais organizado, incluiremos um Console.WriteLine("\n\n") para fazer uma quebra de duas linhas, após o laço for que exibe os itens da _listaDeContas2:

```csharp
List<ContaCorrente> _listaDeContas2 = new List<ContaCorrente>()
{
    new ContaCorrente(874, "5679787-A"),
    new ContaCorrente(874, "4456668-B"),
    new ContaCorrente(874, "7781438-C")
};

List<ContaCorrente> _listaDeContas3 = new List<ContaCorrente>()
{
    new ContaCorrente(951, "5679787-E"),
    new ContaCorrente(321, "4456668-F"),
    new ContaCorrente(719, "7781438-G")
};

_listaDeContas2.AddRange(_listaDeContas3);
_listaDeContas2.Reverse();

for (int i = 0; i < _listaDeContas2.Count; i++)
{
    Console.WriteLine($"Indice[{i}] = Conta [{_listaDeContas2[i].Conta}]");
}

Console.WriteLine("\n\n");

var range = _listaDeContas3.GetRange(0, 1);
for (int i = 0; i < range.Count; i++)
{
    Console.WriteLine($"Indice[{i}] = Conta [{range[i].Conta}]");
}
```

A seguir, veremos como funciona o método Clear(), responsável por "limpar" uma lista. Pularemos mais duas linhas com Console.WriteLine("\n\n") e utilizaremos o Clear()na _listaDeContas3:

```csharp
// código anterior omitido

_listaDeContas2.AddRange(_listaDeContas3);
_listaDeContas2.Reverse();

for (int i = 0; i < _listaDeContas2.Count; i++)
{
    Console.WriteLine($"Indice[{i}] = Conta [{_listaDeContas2[i].Conta}]");
}

Console.WriteLine("\n\n");

var range = _listaDeContas3.GetRange(0, 1);
for (int i = 0; i < range.Count; i++)
{
    Console.WriteLine($"Indice[{i}] = Conta [{range[i].Conta}]");
}

Console.WriteLine("\n\n");

_listaDeContas3.Clear();
for (int i = 0; i < _listaDeContas3.Count; i++)
{
    Console.WriteLine($"Indice[{i}] = Conta [{_listaDeContas3[i].Conta}]");
}
```

Assim, a partir da linha 262, esvaziamos a _listaDeContas3 com o método Clear() e, na sequência, percorremos essa lista. Ou seja, como se trata de uma lista vazia, espera-se que nada seja exibido no console. Ao salvar e rodar o projeto, veremos o resultado do primeiro for (uma lista de 6 elementos, de G a A); o resultado do segundo for, exibindo o range; e depois não temos mais nada, visto que usamos o Clear() na _listaDeContas3.

Então, neste vídeo, aprendemos que a classe List<> tem uma série de métodos compartilhados com outras classes de coleções ( como o AddRange, o GetRange e o Clear) que são muitos úteis para manipular listas de objetos.

Na sequência, daremos prosseguimento ao desenvolvimento da nossa aplicação, criando mais recursos e trabalhando com exceções.

### Aula 3: Desafio: o elemento existe?

Agora que você já viu algumas das vantagens da utilização da classe genérica List, te propomos um desafio, imagine o seguinte cenário: Seu sistema recebe diariamente uma lista de nomes e você precisa verificar se existe um nome específico, por exemplo “Anakin Wayne”. Use para testes a seguinte lista:

```csharp
List<string> nomesDosEscolhidos = new List<string>()
{
    "Bruce Wayne",
    "Carlos Vilagran",
    "Richard Grayson",
    "Bob Kane",
    "Will Farrel",
    "Lois Lane",
    "General Welling",
    "Perla Letícia",
    "Uxas",
    "Diana Prince",
    "Elisabeth Romanova",
    "Anakin Wayne"
};
```

Este é um exercício opcional e te desafiamos a criar um método que recebe uma lista de nomes e o nome de verificação e retorne se foi encontrado ou não.

Opinião do instrutor

Opções  
Agora apresentamos uma possível solução para o desafio proposto:

```charp
bool VerificaNomes(List<string> nomesDosEscolhidos,string escolhido)
{
    return nomesDosEscolhidos.Contains(escolhido);
}
```

### Aula 3: Alternativa: List - Exercício

Após a refatoração do código mudando de ArrayList para List Cleber e Esther tem a necessidade de implementar uma função que implemente a exclusão da lista do array de objetos, para isso eles implementaram o seguinte método definido como LimpaLista(). Qual das implementações abaixo realmente limpam a lista de objetos. Marque a opção correta:

Selecione uma alternativa:

Resposta correta:  

```csharp
void LimparLista()
{
    _listaDeContas.Clear();
}
```

> Para remoção de todos os itens de uma coleção List o método a ser usado é o Clear().

### Aula 3: Para saber mais: outras Coleções

Na biblioteca de classes do .NET para trabalharmos com coleções além das já mencionadas Array, ArrayList e List temos uma série de collection igualmente interessante para usarmos no desenvolvimento de nossas aplicações. Abaixo vamos listar mais algumas:

SortedList, nesta coleção trabalhamos com itens ordenados por um conjunto de chave-valor. Algumas características:

- Utilizada para ordenarmos itens sem muito esforço.
- Podemos procurar por uma chave específica.

A classe SortedList também possui uma versão que aceita generics e fica no namespace System.Collections.Generic. Um exemplo:

```csharp
SortedList<int,string> times = new SortedList<int,string>();
times.Add(0, "Flamengo");
times.Add(1, "Santos");
times.Add(2, "Juventus");

foreach (var item in times.Values)
{
    Console.WriteLine(item);
}
```

**Stack**, esta coleção implementa o conceito de pilha, onde os elementos mais novos são adicionados no topo da pilha, e devem ser retirados nesta ordem. Esta classe também possui uma versão genérica. Exemplo de utilização:

```csharp
Stack<string> minhaPilhaDeLivros = new Stack<string>();
minhaPilhaDeLivros.Push("Harry Porter e a Ordem da Fênix");
minhaPilhaDeLivros.Push("A Guerra do Velho.");
minhaPilhaDeLivros.Push("Protocolo Bluehand");
minhaPilhaDeLivros.Push("Crise nas Infinitas Terras.");
```

Para encontrarmos o livro que está no topo da pilha usando o método Peek, para remove-lo usamos o método Pop:

```csharp
Console.WriteLine(minhaPilhaDeLivros.Peek());// Retorna o elemento do topo.
Console.WriteLine(minhaPilhaDeLivros.Pop()); //Remove o elemento do topo
```

**Queue**, esta coleção por sua vez implementa o conceito de fila, onde os elementos mais antigos são os primeiros a serem removidos. Para adicionar um elemento na fila usamos o método Enqueue:

```csharp
Queue<string> filaAtendimento = new Queue<string>();
filaAtendimento.Enqueue("André Silva");
filaAtendimento.Enqueue("Lou Ferrigno");
filaAtendimento.Enqueue("Gal Gadot");
```

Similar ao método Pop para a fila temos o método Dequeue para remover um objeto da fila. Exemplo:

```csharp
filaAtendimento.Dequeue();//Remove o primeiro elemento da fila.
```

HashSet, focado em alta performance esta coleção não aceita valores duplicados, para adicionar elementos temos também disponível o método Add:

```csharp
HashSet<int> _numeros = new HashSet<int>();
_numeros.Add(0);
_numeros.Add(1);
_numeros.Add(1);
_numeros.Add(1);
```

Para saber quantos elementos a coleção _numeros possui podemos usar a propriedade Count:

```csharp
Console.WriteLine(_numeros.Count);// a saída é 2.
```

Para exibirmos o conteúdo podemos percorrer a coleção usando um foreach:

```csharp
foreach (var item in _numeros)
{
    Console.WriteLine(item);
}
```

Para saber mais sobre as outras coleções do .NET deixamos a recomendação de acesso a documentação da Microsoft Coleções (C#)

### Aula 3: Tratando exceções - Vídeo 3

Já estudamos alguns métodos da classe List<> e o Generics. Antes de voltarmos para o desenvolvimento da nossa aplicação do ByteBank, vamos fazer uma rápida organização do nosso código, pois ele está ficando extenso. Por enquanto, não apagaremos nada, porque podemos usar esses exemplos como referências. Em vez disso, comentaremos as partes que não queremos executar e usaremos as regions para melhorar a visualização.

A partir da linha 216 até o final do arquivo, fizemos nossos testes — começando com a classe Generica e terminando com o método Clear(). Primeiramente, vamos elipsar todos os trechos possíveis desses testes, clicando no símbolo de "-" na parte esquerda das linhas. Em seguida, vamos comentar essa parte do código. Como Generica`<T>`já está comentada, vamos selecionar a partir da linha 230 até o final e usar o atalho "Ctrl + K + C".

Agora, utilizaremos o recurso das regions. Na linha 216, antes de Generica`<int>` teste1, digitaremos #region Exemplos de uso do List. Ao final desse trecho de testes, na linha 268, digitaremos #endregion. Na sequência, podemos minimizar toda essa "região" (da linha 217 a 268), clicando no símbolo de "-" no canto esquerdo da linha 216.

Com essa region retraída, vamos recortar a linha 216 ("Ctrl + X") e colá-la na linha 117 ("Ctrl + V"). Assim, o código fica mais organizado: em Program.cs, temos as regions "Exemplos Arrays em C#" e "Exemplos de uso do List" minimizadas e comentadas no início do arquivo e, na sequência, o código da nossa aplicação do ByteBank. Podemos usar esses exemplos para consultas, mas eles não influenciam na execução do programa. Também será possível removê-los facilmente ao final do projeto, caso nos interesse.

Rearranjado nosso projeto, vamos descomentar a chamada a AtendimentoCliente() na linha 177, salvar as alterações e pressionar play na parte do Visual Studio. Veremos o menu com as 6 opções (já implementamos as duas primeiras). Sem digitar nenhuma opção, vamos apenas pressionar o "Enter".

A aplicação quebrará, ocorrerá uma exceção. Quando trabalhamos com uma interface com interação com o usuário, é essencial atentarmos a como a aplicação reagirá, caso o usuário digite uma opção inválida, por exemplo. Então, a seguir, utilizaremos um recurso que já aprendemos em outros cursos dessa formação: as exceções.

Vamos parar a execução da nossa aplicação, pressionando o quadrado vermelho (stop) na barra superior do Visual Studio, e abrir o Gerenciador de Soluções, clicando nele na aba lateral à direita da IDE. Criaremos algumas classes para tratar exceções.

Clicando com o botão direito sobre a solução bytebank_ATENDIMENTO, selecionaremos "Adicionar > Nova Pasta" e a nomearemos "bytebank.Exceptions". Todas as classes que criarmos para tratar exceções ficarão nesse diretório, assim mantemos a organização e facilitamos futuras manutenções.

Ainda no Gerenciador de Soluções, clicaremos com o botão direito do mouse sobre o diretório bytebank.Exceptions e selecionaremos "Adicionar > Classe...". Na parte inferior da nova janela, chamaremos essa classe de ByteBankException.cs e clicaremos no botão "Adicionar". Abrindo o arquivo ByteBankException.cs, já temos uma estrutura padrão pronta. Vamos apagar o conteúdo da classe:

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ATENDIMENTO.bytebank.Exceptions
{

}
```

Na sequência, dentro do bloco do namespace, digitaremos "Exception" e pressionaremos a tecla "Tab" duas vezes para gerar automaticamente uma classe de exceção que herda de Exception. Esse code snippet é bastante útil para desenvolvedores que utilizam o Visual Studio.

Dentro dessa classe, já existe uma série de construtores. O primeiro não recebe parâmetros; o segundo recebe uma mensagem e a repassa para a classe base; e o terceiro recebe uma mensagem e outra exceção interna, e também as repassa para a classe base. Além disso, também é permitida uma exceção que recebe uma serialização info e context.

De início, vamos mudar o nome dessa classe de MyException para ByteBankException, lembrando de modificar todas as ocorrências desse nome:

```csharp
namespace bytebank_ATENDIMENTO.bytebank.Exceptions
{
    [Serializable]
    public class ByteBankException : Exception
    {
        public ByteBankException() { }
        public ByteBankException(string message) : base(message) { }
        public ByteBankException(string message, Exception inner) : base(message, inner) { }
        protected ByteBankException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
}
```

Assim, criamos uma classe para tratar exceções de maneira genérica, global.

Voltando ao arquivo Program.cs, no método AtendimentoCliente(), precisamos verificar quais trechos de código são passíveis de gerar exceções. Quando o usuário digita uma opção (linha 196), é possível que ocorra uma exceção, bem como quando invocamos algum método dentro do switch. Então, a seguir, faremos um controle de exceções bem genérico.

Para facilitar a visualização, primeiro vamos minimizar o laço while, clicando no símbolo "-" na linha 182. Ao elipsar esse trecho, o método AtendimentoCliente() parecerá ter apenas 2 linhas, porém vale lembrar que minimizamos parte dele:

```csharp
void AtendimentoCliente()
{
    char opcao = '0';
    while(opcao!=6)
}
```

Para não gerar confusão na leitura dos blocos de código transcritos no restante desta aula, utilizaremos a seguinte estrutura para representar o laço while que foi minimizado:

```csharp
while(opcao!=6)
{
  // trecho de código omitido
}
```

Antes da variável opcao, digitaremos try e pressionareos a tecla "Tab" duas vezes para gerar automaticamente uma estrutura básica do try/catch. Vamos mover o char e o while para dentro do bloco try:

```csharp
void AtendimentoCliente()
{
    try
    {
        char opcao = '0';
        while(opcao!=6)
        {
            // trecho de código omitido
        }
    }
    catch (Exception)
    {
        throw;
    };
```

Ou seja, tentaremos executar o código contido no try e, caso ocorra uma exceção, ela será capturada no catch. Quando ocorrer um erro, vamos gerar um ByteBankException, que chamaremos de excecao:

```csharp
void AtendimentoCliente()
{
    try
    {
        char opcao = '0';
        while(opcao!=6)
        {
            // trecho de código omitido
        }
    }
    catch (ByteBankException excecao)
    {
        throw;
    };
```

O Visual Studio alegará um erro na linha 214, pois é preciso importar um namespace. Basta posicionarmos o cursor sobre ByteBankException, pressionar "Ctrl + ." e selecionar "using bytebank_ATENDIMENTO.bytebank.Exceptions".

Na sequência, modificaremos o segundo construtor presente no arquivo ByteBankException.cs. Antes de enviar a mensagem à classe base, vamos fazer uma concatenação:

```csharp
namespace bytebank_ATENDIMENTO.bytebank.Exceptions
{
    [Serializable]
    public class ByteBankException : Exception
    {
        public ByteBankException() { }
        public ByteBankException(string message) : base("Aconteceu uma Exceção -> "+ "message) { }
        public ByteBankException(string message, Exception inner) : base(message, inner) { }
        protected ByteBankException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
}
```

Voltando ao Program.cs, vamos alterar o bloco catch. Em lugar do throw, digitaremos "CW" e pressionamores a tecla "Tab" duas vezes para gerar um estrutura de Console.WriteLine(). Exibiremos uma mensagem por meio de uma interpolação de strings:

```csharp
void AtendimentoCliente()
{
    try
    {
        char opcao = '0';
        while(opcao!=6)
        {
            // trecho de código omitido
        }
    }
    catch (ByteBankException excecao)
    {
        Console.WriteLine($"{excecao.Message}");
    };
```

Ainda não terminamos de tratar as exceções! Vamos expandir o laço while que minimizamos anteriormente e construir uma estrutura try/catch para lidar com o Console.ReadLine(), na linha 199, que também é passível de gerar exceções.

Vamos mover o Console.ReadLine() para dentro do try. Trabalharemos com uma exceção genérica, também chamada excecao e lançaremos um ByteBankException:

```csharp
void AtendimentoCliente()
{
    try
    {
        char opcao = '0';
        while (opcao != '6')
        {
            Console.Clear();
            Console.WriteLine("===============================");
            Console.WriteLine("===       Atendimento       ===");
            Console.WriteLine("===1 - Cadastrar Conta      ===");
            Console.WriteLine("===2 - Listar Contas        ===");
            Console.WriteLine("===3 - Remover Conta        ===");
            Console.WriteLine("===4 - Ordenar Contas       ===");
            Console.WriteLine("===5 - Pesquisar Conta      ===");
            Console.WriteLine("===6 - Sair do Sistema      ===");
            Console.WriteLine("===============================");
            Console.WriteLine("\n\n");
            Console.Write("Digite a opção desejada: ");
            try
            {
                opcao = Console.ReadLine()[0];
            }
            catch (Exception excecao)
            {
                throw new ByteBankException(excecao.Message);
            }

            switch (opcao)
            {
                case '1':
                    CadastrarConta();
                    break;
                case '2':
                    ListarContas();
                    break;
                default:
                    Console.WriteLine("Opcao não implementada.");
                    break;
            }
        }
    }
    catch (ByteBankException excecao)
    {
        Console.WriteLine($"{excecao.Message}");
    }
}
```

Assim, caso uma exceção seja gerada nesse trecho, estaremos passando adiante uma exceção ByteBankException que será capturada pelo catch na linha 222, que então exibirá a mensagem.

Vamos salvar essas alterações e testar a aplicação, clicando no play na parte superior do Visual Studio. Uma vez renderizado o menu, vamos pressionar a tecla "Enter" (sem digitar nenhuma opção) para forçar um erro. A exceção será capturada e veremos a mensagem no console: "Index was outside the sounds of the array".

Então, neste vídeo, começamos a tratar exceções. Essa etapa é imprescindível quando trabalhamos com usuários, para que a aplicação esteja preparada para usos inesperados do programa, como a inserção de uma valor errado. Sabendo de antemão alguns dos problemas possíveis, podemos tratá-los e impedir que a aplicação quebre e pare de funcionar.

Na sequência, implementaremos as funcionalidades de remoção, ordenação e pesquisa de contas no aplicativo do ByteBank.

### Aula 3: Faça como eu fiz: ByteBankException

Estamos desenvolvendo uma aplicação que necessita da interação do usuário e isso pode ocasionar situações excepcionais como por exemplo o gerente de contas apertar enter sem digitar a opção desejada, como ações como essa são possíveis de ser previstas podemos tratá-las para que o sistema não gere algum erro e feche para o usuário.Vamos recorrer ao tratamento de exceções que é suportada pelo C#. Então, colocando a mão na massa vamos praticar criando um classe para as exceções do projeto?

Opinião do instrutor

Para iniciar vamos no gerenciador de soluções vamos criar um novo diretório e adicionar nossa classe de exceção ByteBankException:

Imagem

A classe terá a seguinte codificação:

```csharp
[Serializable]
    public class ByteBankException : Exception
    {
        public ByteBankException() { }
        public ByteBankException(string message) : base("Aconteceu uma Exceção -> " + message) { }
        public ByteBankException(string message, Exception inner) : base("Aconteceu uma Exceção -> "+ message, inner) { }
        protected ByteBankException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
```

Com a classe ByteBankException definida podemos agora identificar os pontos que podem gerar exceções e usando a estrutura try…catch tratarmos os possíveis erros, por exemplo no métodoAtendimentoCliente:

```csharp
void AtendimentoCliente()
{
    try
    {
        char opcao = '0';
        while (opcao != '6')
        {
            Console.Clear();
            Console.WriteLine("===============================");
            Console.WriteLine("===        ATENDIMENTO      ===");
            Console.WriteLine("=== 1 - Cadastrar Contas    ===");
            Console.WriteLine("=== 2 - Listar Contas       ===");
            Console.WriteLine("=== 3 - Remover Contas      ===");
            Console.WriteLine("=== 4 - Ordenar Contas      ===");
            Console.WriteLine("=== 5 - Pesquisar Contas    ===");
            Console.WriteLine("=== 6 - Sair do sistema     ===");
            Console.WriteLine("===============================");
            Console.WriteLine("\n");
            Console.Write("Digite a Opção desejada: ");
            try
            {
                opcao = Console.ReadLine()[0];
            }
            catch (Exception excecao)
            {

               throw new ByteBankException(excecao.Message);
            }
            
            switch (opcao)
            {
                case '1':
                    CadastrarConta();
                    break;
                case '2':
                    ListarConta();
                    break;
                case '6':
                    EncerrarAplicacao();
                    break;
                default:
                    Console.WriteLine("Opção não implementada.");
                    break;
            }
        }
    }
    catch (ByteBankException excecao)
    {

        Console.WriteLine($"{excecao.Message}"); ;
    }    
}
```

Pronto! Lembre-se de continuar praticando bastante e se desafiando sempre.

### Aula 3: O que aprendemos?

Nessa aula, você aprendeu:

- A utilizar uma lista genérica de objetos utilizando a classe List, que permite a tipagem de uma lista de objetos e que permite a redução da probabilidade de erros de conversão para a manipulação da lista;
- Sobre métodos disponíveis pela classe List que dinamiza a manipulação de lista de objetos;
- A criar uma classe para tratar as exceções da aplicação e que se faz necessária uma vez que a aplicação em desenvolvimento tem uma interface de interação com o usuário.

## Aula 4: Manipulando a lista

### Aula 4: Projeto da aula anterior

Você pode [baixar o zip do projeto da aula](https://github.com/alura-cursos/Array_Collections_C/archive/refs/heads/aula03.zip) ou acessar o link do [repositório no GitHub!](https://github.com/alura-cursos/Array_Collections_C/tree/aula03)

### Aula 4: Removendo contas da lista - Vídeo 1

Vamos continuar a manipular nossa lista e a desenvolver novas funcionalidades para nossa aplicação do ByteBank. Já implementamos o CadastrarContas() e o ListarContas(), nosso próximo passo é criar o método de remoção de contas — a opção 3 do nosso menu.

No Program.cs, no método AtendimentoCliente(), criaremos o caso 3 dentro do switch:

```csharp
void AtendimentoCliente()
{
    try
    {
        char opcao = '0';
        while (opcao != '6')
        {
            Console.Clear();
            Console.WriteLine("===============================");
            Console.WriteLine("===       Atendimento       ===");
            Console.WriteLine("===1 - Cadastrar Conta      ===");
            Console.WriteLine("===2 - Listar Contas        ===");
            Console.WriteLine("===3 - Remover Conta        ===");
            Console.WriteLine("===4 - Ordenar Contas       ===");
            Console.WriteLine("===5 - Pesquisar Conta      ===");
            Console.WriteLine("===6 - Sair do Sistema      ===");
            Console.WriteLine("===============================");
            Console.WriteLine("\n\n");
            Console.Write("Digite a opção desejada: ");
            try
            {
                opcao = Console.ReadLine()[0];
            }
            catch (Exception excecao)
            {
                throw new ByteBankException(excecao.Message);
            }

            switch (opcao)
            {
                case '1':
                    CadastrarConta();
                    break;
                case '2':
                    ListarContas();
                    break;
                case '3':
                    RemoverContas();
                    break;
                default:
                    Console.WriteLine("Opcao não implementada.");
                    break;
            }
        }
    }
    catch (ByteBankException excecao)
    {
        Console.WriteLine($"{excecao.Message}");
    }
}
```

No case 3, invocamos o método RemoverContas() que ainda não existe. Vamos clicar sobre RemoverContas() na linha 217, pressionar "Ctrl + ." e selecionar "Gerar método 'RemoverContas'". O Visual Studio gerará uma estrutura base desse método a partir da linha 232, vamos adaptá-lo a seguir:

```csharp
void RemoverContas()
{
    Console.Clear();
    Console.WriteLine("===============================");
    Console.WriteLine("===      REMOVER CONTAS     ===");
    Console.WriteLine("===============================");
    Console.WriteLine("\n");
    Console.Write("Informe o número da Conta: ");
    string numeroConta = Console.ReadLine();
    ContaCorrente conta = null;
    foreach (var item in _listaDeContas)
    {
        if (item.Conta.Equals(numeroConta))
        {
            conta = item;
        }
    }
    if (conta!=null)
    {
        _listaDeContas.Remove(conta);
        Console.WriteLine("... Conta removida da lista! ...");
    }
    else
    {
        Console.WriteLine(" ... Conta para remoção não encontrada ...");
    }
    Console.ReadKey();
}
```

De início, RemoverContas() limpará a tela e exibirá um cabeçalho, informando que estamos na área de remoção de contas. Será solicitado ao usuário que digite o número da conta a ser removida e o valor inserido ficará armazenado em numeroConta. Além disso, a variável conta do tipo ContaCorrente será criada, inicialmente com valor nulo.

Com foreach, vamos percorrer os itens da _listaDeContas. Caso encontremos uma conta-corrente cujo número é igual ao digitado pelo usuário, atribuiremos esse item à variável conta. Caso contrário (se não encontrarmos uma conta com o mesmo número), a variável conta continuará com valor nulo.

Após o foreach, se conta não for nulo, realizaremos a remoção da conta-corrente da _listaDeContas, na linha 251, e exibiremos uma mensagem confirmando a operação. Se conta for nulo, quer dizer que não encontramos a conta-corrente e mostramos um aviso no console.

Por fim, temos o Console.ReadKey(), que aguarda que pressionemos qualquer tecla para continuar o processamento.

Vamos salvar e testar a aplicação. No menu, primeiramente vamos listar as contas-correntes, escolhendo a opção 2. Veremos que existem 3 contas (duas com final X e outra com final W). Voltando ao menu, digitaremos 3 e informaremos o seguinte número de conta: 987321-W. Pressionando "Enter", a operação de remoção será realizada com sucesso.

Na sequência, tentaremos remover uma conta que não existe. No menu, digitaremos 3 novamente e informaremos a seguinte conta: 888. Pressionando "Enter", veremos a mensagem de que a conta não foi encontrada. Nossa aplicação está funcionando como esperado.

Portanto, neste vídeo, implementamos a remoção de contas na nossa aplicação do ByteBank, invocando o método Remove() da _listaDeContas (na linha 251). Assim como aprendemos anteriormente que podemos adicionar elementos com .Add() e .AddRange(), agora temos também a possibilidade de removê-los de listas.

Na sequência, continuaremos implementando as funcionalidades do menu do nosso programa de atendimento. No próximo vídeo, faremos a ordenação da nossa lista.

### Aula 4: Faça como eu fiz: removendo conta

Umas das funcionalidades requeridas pelo sistema de atendimento que estamos desenvolvendo é simular a operação que encerramento de uma conta, para isso desenvolvemos um método que exclui uma determinada conta de nossa lista em memória.Então chegou a hora de praticar, implemente o método que excluirá uma conta com base em seu número.

Opinião do instrutor

Para iniciar vamos definir no menu a opção de remoção da conta, no switch do método AtendimentoCliente:

Imagem

Agora vamos a implementação do método RemoverConta:

```csharp
void RemoverConta()
{
    Console.Clear();
    Console.WriteLine("===============================");
    Console.WriteLine("===      REMOVER CONTAS     ===");
    Console.WriteLine("===============================");
    Console.WriteLine("\n");
    Console.Write("Informe o número da conta: ");
    string numeroConta = Console.ReadLine();
    ContaCorrente conta = null;
    foreach (ContaCorrente item in listaDeContas)
    {
        if (item.Conta.Equals(numeroConta))
        {
            conta = item;
        }
    }
    if(conta != null)
    {
        _listaDeContas.Remove(conta);
        Console.WriteLine("... Conta removida da lista! ...");
    }
    else {
        Console.WriteLine(" ... Conta para remoção não encontrada ...");
    }  
    
    Console.ReadKey();
}
```

Pronto! Lembre-se de continuar praticando bastante e se desafiando sempre a implementar outras funcionalidades a nossa aplicação.

### Aula 4: Ordenando a lista - Vídeo 2

Acabamos de implementar a função de remoção de contas, a opção 3 do método AtendimentoCliente(). Agora, vamos focar na funcionalidade de ordenar contas. Começaremos criando o case 4 no switch. Ele invocará o método OrdenarContas() que ainda não existe, porém o criaremos na sequência:

```csharp
void AtendimentoCliente()
{
    try
    {
        char opcao = '0';
        while (opcao != '6')
        {
            Console.Clear();
            Console.WriteLine("===============================");
            Console.WriteLine("===       Atendimento       ===");
            Console.WriteLine("===1 - Cadastrar Conta      ===");
            Console.WriteLine("===2 - Listar Contas        ===");
            Console.WriteLine("===3 - Remover Conta        ===");
            Console.WriteLine("===4 - Ordenar Contas       ===");
            Console.WriteLine("===5 - Pesquisar Conta      ===");
            Console.WriteLine("===6 - Sair do Sistema      ===");
            Console.WriteLine("===============================");
            Console.WriteLine("\n\n");
            Console.Write("Digite a opção desejada: ");
            try
            {
                opcao = Console.ReadLine()[0];
            }
            catch (Exception excecao)
            {
                throw new ByteBankException(excecao.Message);
            }

            switch (opcao)
            {
                case '1':
                    CadastrarConta();
                    break;
                case '2':
                    ListarContas();
                    break;
                case '3':
                    RemoverContas();
                    break;
                case '4':
                    OrdenarContas();
                    break;
                default:
                    Console.WriteLine("Opcao não implementada.");
                    break;
            }
        }
    }
    catch (ByteBankException excecao)
    {
        Console.WriteLine($"{excecao.Message}");
    }
}
```

Vamos posicionar o cursor do mouse sobre OrdenarContas() na linha 219, pressionar "Ctrl + ." e selecionar "Gerar método 'OrdenarContas'". O Visual Studio gerará automaticamente uma estrutura base entre as linhas 234 e 237. Abaixo dela, temos os métodos RemoverContas(), ListarContas() e CadastrarConta() em que trabalhamos anteriormente. Podemos mantê-los minumizados.

Vamos modificar OrdenarContas(). A classe List<> possui uma série de métodos, inclusive um responsável pela ordenação da lista, chamado Sort():

```csharp
void OrdenarContas()
{
    _listaDeContas.Sort();
    Console.WriteLine("... Lista de Contas ordenadas ...");
    Console.ReadKey();
}
```

Se posicionarmos o mouse sobre o método .Sort(), é possível ler uma breve explicação: ele ordena uma lista por meio de comparações. Ou seja, podemos usar esse método sempre que precisarmos ordenar ou classificar um grupo de elementos. Portanto, em OrdenarContas(), o programa ordenará a lista, exibirá uma mensagem de confirmação e esperará que o usuário pressiona qualquer tecla para voltar ao menu principal.

Vamos salvar e executar o projeto, clicando no play na parte superior do Visual Studio. Primeiro, vamos digitar 2 para listar a contas e veremos 3 contas, na seguinte ordem: a conta do Henrique (123456-X), a conta do Pedro (951258-X) e a conta da Marisa (987321-W).

Voltando ao menu, digitaremos 4 para ordenar a lista e ocorrerá um erro. Veremos que há uma exceção sem tratamento, na linha 236: System.InvalidOperationException. Note que há uma exceção interna que menciona a interface IComparable. Por padrão, o "i" maiúsculo indica uma interface.

Em outras palavras, houve uma falha na comparação de dois elementos da nossa lista de objetos. Esse problema acontece porque _listaDeContas é uma lista tipada (do tipo ContaCorrente) e precisamos que o objeto ContaCorrente possua um método interno que permita ao método .Sort ordenar os elementos do array.

Então, vamos implementar a interface IComparable na linha 3 do arquivo ContaCorrente.cs:

```csharp
public class ContaCorrente:IComparable<ContaCorrente>
```

O trecho IComparable`<ContaCorrente>` ficará sublinhado em vermelho, indicando um erro. Vamos posicionar o cursor sobre ele, pressionar "Ctrl + ." e selecionar "Implementar a interface". Entre as linhas 114 e 118, será criado o método CompareTo(), que recebe ContaCorrente? other. Vamos substituir other por outro.

Note que há uma interrogação ao final de ContaCorrente. Isso quer dizer que esse método pode receber um objeto nulo. A seguir, vamos implementar o método para fazer a comparação:

```csharp
public int CompareTo(ContaCorrente? outro)
{
    if (outro==null)
    {
        return 1;
    }
    else
    {
        return this.Numero_agencia.CompareTo(outro.Numero_agencia);
    }
}
```

Se o argumento recebido for nulo, retornaremos 1 (em breve, entenderemos o porquê). Do contrário, faremos uma comparação. Como o CompareTo() retorna um int, optamos por ordenar segundo os números das agências das contas. Vamos salvar as alterações e voltar ao arquivo Program.cs.

Para testar, clicaremos no play na parte superior o Visual Studio. Digitaremos 2 para listar os elementos: a conta Henrique (123456-X), a conta do Pedro (951258-X) e a conta da Marisa (987321-W). Essas são as 3 contas que definimos e inserimos na _listaDeContas por padrão, entre as linhas 172 e 176 de Program.cs.

Voltando ao menu da aplicação, digitaremos 4 para ordenar a lista e veremos uma mensagem de confirmação da operação. Dessa vez, não ocorreu nenhum problema. Podemos pressionar "Enter" para voltar para o menu e encerrar o programa.

Então, vamos recapitular: implementamos a interface IComparable à classe ContaCorrente e, dessa forma, conseguimos escrever o método CompareTo() para compararmos elementos. Os objetos da classe ContaCorrente serão ordenados a partir do número da agência. Para utilizar o método .Sort() da classe List<>, é necessário que a classe daquele conjunto de objetos tenham a interface IComparable implementada.

Por fim, para entender por que retornamos 1 quando o parâmetro é nulo, vamos abrir a documentação da interface IComparable. No tópico "Retorno", há uma tabela explicando os significados dos retornos:

|Valor|Significado|
|---|---|
|Menor que zero|Esta instância precede obj na ordem de classificação.|
|Zero|Esta instância ocorre na mesma posição que obj na ordem de classificação.|
|Maior que zero|Esta instância segue obj na ordem de classificação.|

Conseguimos implementar a ordenação de contas. Na sequência, vamos desenvolver a opção 5 do menu: pesquisar contas.

### Aula 4: Ordenando o Array de Objetos - Exercício

Vimos que para a utilização do método Sort da classe List é necessário a implementação da interface IComparable, para a classe que define o tipo da lista Sabendo disso, marque as opções verdadeiras com relação a esta interface:

Selecione 2 alternativas:

Alternativa correta.  
Quando é executado o método de ordenação Sort da classe List para uma coleção de objetos, onde a classe que tipifica a lista não implementa a interface IComparable é gerada uma exceção do tipo System.InvalidOperationException: 'Failed to compare two elements in the array.

> A exceção gerada na utilização do método Sort em um tipo que não implementa o IComparable é System.InvalidOperationException.'

Alternativa correta.  
A implementação da interface IComparable, obriga a classe a codificar o método CompareTo para que definir a ordenação ou classificação de objetos quando em uma lista.

> A classe deve implementar o método CompareTo definida na interface IComparable.

### Aula 4: Para saber mais: outras Interfaces para coleções

A biblioteca de classes do .NET é rica em recursos que podemos utilizar em conjunto com as coleções dos namespaces System.Collections e System.Collections.Generic e para isso a plataforma em sua biblioteca traz uma série de interfaces que nos ajudam a manipular essas coleções, abaixo algumas delas:

|Interface|Breve descrição|
|---|---|
|IList|Contrato que define os principais métodos e propriedades de uma lista como por exemplo: Insert,Item,Contains e Remove.|
|ICollection|É a interface que define a enumeração, sincronização e tamanho para todas as coleções.|
|IComparer|Define a forma de como comparar dois objetos.|
|IDictionary|Devolve um conjunto baseado em chave-valor e possibilita a adição e remoção de itens.|

Para saber mais sobre as outras interfaces para manipulação de coleções do .NET deixamos a recomendação de acesso a [documentação da Microsoft Coleções (C#)](https://docs.microsoft.com/pt-br/dotnet/csharp/programming-guide/concepts/collections)

### Aula 4: Criando uma pesquisa - Vídeo 3

Vamos desenvolver mais uma funcionalidade do nosso aplicativo de atendimento. No dia a dia do ByteBank, os clientes vão demandar informações sobre suas contas e o gerente precisará consultá-las por meio desse aplicativo, então implementaremos a seguir a funcionalidade de pesquisa.

Em Program.cs, no método AtendimentoCliente(), criaremos o case 5 para invocar PesquisarContas():

```csharp
void AtendimentoCliente()
{
    try
    {
        char opcao = '0';
        while (opcao != '6')
        {
            Console.Clear();
            Console.WriteLine("===============================");
            Console.WriteLine("===       Atendimento       ===");
            Console.WriteLine("===1 - Cadastrar Conta      ===");
            Console.WriteLine("===2 - Listar Contas        ===");
            Console.WriteLine("===3 - Remover Conta        ===");
            Console.WriteLine("===4 - Ordenar Contas       ===");
            Console.WriteLine("===5 - Pesquisar Conta      ===");
            Console.WriteLine("===6 - Sair do Sistema      ===");
            Console.WriteLine("===============================");
            Console.WriteLine("\n\n");
            Console.Write("Digite a opção desejada: ");
            try
            {
                opcao = Console.ReadLine()[0];
            }
            catch (Exception excecao)
            {
                throw new ByteBankException(excecao.Message);
            }

            switch (opcao)
            {
                case '1':
                    CadastrarConta();
                    break;
                case '2':
                    ListarContas();
                    break;
                case '3':
                    RemoverContas();
                    break;
                case '4':
                    OrdenarContas();
                    break;
                case '5':
                    PesquisarContas();
                    break;
                default:
                    Console.WriteLine("Opcao não implementada.");
                    break;
            }
        }
    }
    catch (ByteBankException excecao)
    {
        Console.WriteLine($"{excecao.Message}");
    }
}
```

Como o método PesquisarContas() ainda não existe, vamos clicar sobre ele na linha 223, pressionar "Ctrl + ." e selecionar "Gerar método 'PesquisarContas'" para gerar automaticamente uma estrutura base, a partir da linha 238. Em seguida, vamos adaptá-lo:

```csharp
void PesquisarContas()
{
    Console.Clear();
    Console.WriteLine("===============================");
    Console.WriteLine("===    PESQUISAR CONTAS     ===");
    Console.WriteLine("===============================");
    Console.WriteLine("\n");
    Console.Write("Deseja pesquisar por (1) NUMERO DA CONTA ou (2)CPF TITULAR ? ");
    switch (int.Parse(Console.ReadLine()))
}
```

De início, temos o cabeçalho indicando a área do programa em que estamos. Para um sistema de pesquisa tanto pelo número da conta quanto pelo CPF, utilizaremos um switch. O primeiro método invocado no switch é o Console.ReadLine(). O retorno dele será uma string, que será encaminhada para o Parse() que, por sua vez, converterá essa string no inteiro que será usado no switch.

Na sequência, vamos implementar os cases:

```csharp
void PesquisarContas()
{
    Console.Clear();
    Console.WriteLine("===============================");
    Console.WriteLine("===    PESQUISAR CONTAS     ===");
    Console.WriteLine("===============================");
    Console.WriteLine("\n");
    Console.Write("Deseja pesquisar por (1) NUMERO DA CONTA ou (2)CPF TITULAR ? ");
    switch (int.Parse(Console.ReadLine()))
    {
        case 1:
                {
                    Console.Write("Informe o número da Conta: ");
                    string _numeroConta = Console.ReadLine();
                    ContaCorrente consultaConta = ConsultaPorNumeroConta(_numeroConta);
                    Console.ReadKey();
                    break;
                }
        case 2:
                {
                    Console.Write("Informe o CPF do Titular: ");
                    string _cpf = Console.ReadLine();
                    ContaCorrente consultaCpf = ConsultaPorCPFTitular(_cpf);
                    Console.ReadKey();
                    break;
                }
        default:
            Console.WriteLine("Opção não implementada.");
            break;
    }
}
```

Note que, no menu principal, usamos os cases com um char. Dessa vez, estamos utilizando um int.

No case1, solicitaremos o número da conta. Armazenaremos o valor digitado na variável _numeroConta, que será informada ao método ConsultaPorNumeroConta().

No case 2, solicitaremos o CPF do usuário. Armazenaremos o valor digitado na variável _cpf, que será informada ao método ConsultaPorCPFTitular().

Os métodos ConsultaPorNumeroConta() e ConsultaPorCPFTitular() ainda não existem. Vamos clicar sobre o primeiro, na linha 252, pressionar "Ctrl + ." e selecionar "Gerar método 'ConsultaPorNumeroConta'". Repetiremos o processo para ConsultaPorCPFTitular(), na linha 260.

Em seguida, modificaremos esses métodos:

```csharp
ContaCorrente ConsultaPorCPFTitular(string? cpf)
{
    ContaCorrente conta = null;
    for (int i = 0; i < _listaDeContas.Count; i++)
    {
        if (_listaDeContas[i].Titular.Cpf.Equals(cpf))
        {
            conta = _listaDeContas[i];
        }
    }
    return conta;
}

ContaCorrente ConsultaPorNumeroConta(string? numeroConta)
{
    ContaCorrente conta = null;
    for (int i = 0; i < _listaDeContas.Count; i++)
    {
        if (_listaDeContas[i].Conta.Equals(numeroConta))
        {
            conta = _listaDeContas[i];
        }
    }

    return conta;
}
```

Em resumo, esses dois métodos percorrerão a lista de contas-correntes em busca de um item que possua o CPF ou número da conta correspondente ao valor informado pelo usuário.

Em ConsultaPorCPFTitular(), criamos uma variável conta inicialmente nula. Com for, percorremos o _listaDeContas, verificando se algum elemento tem CPF igual ao passado como parâmetro. Caso haja correspondência, retornaremos a variável conta com a referência dessa conta-corrente. O código em ConsultaPorNumeroConta()é muito parecido, com exceção da verificação que será feita pelo número da conta, em vez do CPF. Note que ambos métodos utilizam o .Equals(), pois tanto o número da conta quanto o CPF são do tipo string.

Voltando ao trecho entre a linha 172 e 176, notaremos que, ao definir as 3 contas iniciais da nossa lista padrão, não atribuímos CPFs a elas. Vamos consertar esse ponto:

```csharp
List<ContaCorrente> _listaDeContas = new List<ContaCorrente>(){
    new ContaCorrente(95, "123456-X"){Saldo=100,Titular = new Cliente{Cpf="11111",Nome ="Henrique"}},
    new ContaCorrente(95, "951258-X"){Saldo=200,Titular = new Cliente{Cpf="22222",Nome ="Pedro"}},
    new ContaCorrente(94, "987321-W"){Saldo=60,Titular = new Cliente{Cpf="33333",Nome ="Marisa"}}
};
```

Dessa forma, na propriedade Titular de cada uma das contas, criamos um novo Cliente com seu respectivo nome e CPF. Vamos salvar e testar a aplicação, clicando no play na parte superior do Visual Studio.

Após o console ser renderizado, digitaremos 5 para pesquisar uma conta. Em seguida, escolheremos a opção 1, para realizar a consulta partindo do número da conta e informaremos: 123456-X. A pesquisa foi realizada, não ocorreu nenhum erro, porém não recebemos nenhuma mensagem em retorno.

Vamos testar também a consulta por CPF. No menu principal, digitaremos 5. Em seguida, escolheremos 2 e informaremos: 11111. Novamente, a pesquisa será realizada com sucesso, porém nenhum dado será exibido ao usuário.

Voltando ao código, veremos que não colocamos nenhum comando para exibir as informações que foram pesquisadas! Como todas as classes herdam de object, podemos recorrer a um de seus métodos chamado .ToString(). No arquivo ContaCorrente.cs, após a propriedade TotalDeContasCriadas, vamos redefinir o método .ToString():

```csharp
public override string ToString()
{

    return  $" === DADOS DA CONTA === \n" +
                    $"Número da Conta : {this.Conta} \n" +
                    $"Número da Agência : {this.Numero_agencia} \n" +
                    $"Saldo da Conta: {this.Saldo} \n" +
                    $"Titular da Conta: {this.Titular.Nome} \n" +
                    $"CPF do Titular  : {this.Titular.Cpf} \n" +
                    $"Profissão do Titular: { this.Titular.Profissao}\n\n";
}
```

Com override, estamos redefinindo o método ToString() da classe ContaCorrente, de modo que retornaremos os dados da conta em questão. Ademais, note que usamos o \n para gerar quebras de linhas. Vamos salvar essas alterações e voltar ao arquivo Program.cs.

Para exibir os dados pesquisados, usaremos o Console.WriteLine() no case 1 e no case 2 do método PesquisarContas(), invocando ToString() na conta retornada:

```csharp
void PesquisarContas()
{
    Console.Clear();
    Console.WriteLine("===============================");
    Console.WriteLine("===    PESQUISAR CONTAS     ===");
    Console.WriteLine("===============================");
    Console.WriteLine("\n");
    Console.Write("Deseja pesquisar por (1) NUMERO DA CONTA ou (2)CPF TITULAR ? ");
    switch (int.Parse(Console.ReadLine()))
    {
        case 1:
                {
                    Console.Write("Informe o número da Conta: ");
                    string _numeroConta = Console.ReadLine();
                    ContaCorrente consultaConta = ConsultaPorNumeroConta(_numeroConta);
                    Console.WriteLine(consultaConta.ToString());
                    Console.ReadKey();
                    break;
                }
        case 2:
                {
                    Console.Write("Informe o CPF do Titular: ");
                    string _cpf = Console.ReadLine();
                    ContaCorrente consultaCpf = ConsultaPorCPFTitular(_cpf);
                    Console.WriteLine(consultaCpf.ToString());
                    Console.ReadKey();
                    break;
                }
        default:
            Console.WriteLine("Opção não implementada.");
            break;
    }
}
```

Vamos salvar e testar. No menu da aplicação, digitaremos 5. Depois, escolheremos a opção 2 e informaremos o CPF 11111. Dessa vez, veremos os dados da conta com esse CPF! Há apenas um pequeno problema: o nome do titular não está aparecendo, porque deixamos de inserir um valor no campo Nome. No arquivo Cliente.cs, vamos consertar esse deslize:

```csharp
public string Nome
{
        get
        {
            return _nome;
        }
        set
        {
            if (value.Length < 3)
            {
                Console.WriteLine("Nome do titular precisa ter pelo menos 3 caracteres.");
            }
                _nome = value;
        }
}
```

Vamos salvar as alterações e rodar a aplicação novamente. Digitaremos 5 e, em seguida, escolheremos a opção 2. Vamos informar o CPF 11111. Nosso código está funcionando como esperado agora. Conseguimos implementar o método de consulta.

Assim, as funcionalidades básicas de cadastro, listagem, remoção, ordenação e pesquisa de contas estão implementadas. Na sequência, falta apenas desenvolvermos a última função de saída do sistema e melhorarmos o código de maneira geral. Podemos, por exemplo, otimizar as nossas consultas.

### Aula 4: O que aprendemos?

Nessa aula, você aprendeu:

- Sobre a interface IComparable, que deve ser implementada pelo tipo de classe que irá tipificar uma lista genérica para usarmos o método Sort;
- Como utilizar o método Remove da classe lista para remoção de um elemento do array de objetos;
- Como implementar a interface de forma tipada IComparable e o método CompareTo para fazer a ordenação da lista de contas correntes;
- A criar um algoritmo de busca simples para encontrar um objeto no array de contas correntes.

## Aula 5: LINQ

### Aula 5: Projeto da aula anterior

Você pode [baixar o zip do projeto](https://github.com/alura-cursos/Array_Collections_C/archive/refs/heads/aula04.zip) da aula ou acessar o [link do repositório](https://github.com/alura-cursos/Array_Collections_C/tree/aula04) no GitHub!

### Aula 5: Usando Where - Vídeo 1

Anteriormente, criamos duas formas de consultas de contas: por CPF e por número da conta-corrente. Os códigos desses dois métodos são bastante similares. Também redefinimos o método ToString() na classe ContaCorrente para exibirmos as informações da conta após a pesquisa.

Como essa redefinição, podemos repensar o método ListarContas() (linhas 339 a 364) que construímos em aulas passadas, no Program.cs. Nele, há um foreach que exibe os dados de cada conta da lista. Vamos substituir parte dele por uma chamada ao ToString, mantendo a versão atual comentada para referência:

```csharp
void ListarContas()
{
    Console.Clear();
    Console.WriteLine("===============================");
    Console.WriteLine("===     LISTA DE CONTAS     ===");
    Console.WriteLine("===============================");
    Console.WriteLine("\n");
    if (_listaDeContas.Count <= 0)
    {
        Console.WriteLine("... Não há contas cadastradas! ...");
        Console.ReadKey();
        return;
    }
    foreach (ContaCorrente item in _listaDeContas)
    {
    //Console.WriteLine("===  Dados da Conta  ===");
    //Console.WriteLine("Número da Conta : " + item.Conta);
    //Console.WriteLine("Saldo da Conta : " + item.Saldo);
    //Console.WriteLine("Titular da Conta: " + item.Titular.Nome);
    //Console.WriteLine("CPF do Titular  : " + item.Titular.Cpf);
    //Console.WriteLine("Profissão do Titular: " + item.Titular.Profissao);
        Console.WriteLine(item.ToString());
        Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
        Console.ReadKey();
    }
}
```

Dessa forma, utilizamos o método ToString em cada item da _listaDeContas. Essa modificação reduz as linhas de código executadas pela aplicação, melhorando o projeto. Vamos salvar e testar a aplicação, clicando no play na parte superior do Visual Studio. Digitaremos 2 para listar as contas-correntes e veremos que o aplicativo continua a funcionar normalmente.

Vale lembrar que estamos trabalhando com dados em memória, então nossa lista de objetos existe enquanto o programa está rodando. Ao fechá-lo, a lista é descartada.

Agora, vamos voltar à consulta por CPF do titular. Nós já entendemos como encontrar um elemento na lista, percorrendo-a com for, while ou foreach. Na sequência, estudaremos uma maneira mais fácil de realizar esse processo.

De início, vamos comentar o conteúdo do método ConsultaPorCPFTitular():

```csharp
ContaCorrente ConsultaPorCPFTitular(string? cpf)
{
    //ContaCorrente conta = null;
    //for (int i = 0; i < _listaDeContas.Count; i++)
    //{
    //    if (_listaDeContas[i].Titular.Cpf.Equals(cpf))
    //    {
    //        conta = _listaDeContas[i];
    //    }
    //}
    //return conta;
}
```

Atualmente, nossa lista é pequena (apenas 3 elementos), contudo ela pode crescer consideravelmente. Imagine que ela poderia ser alimentada por uma fonte de dados e pode ter milhões de contas! Nesse caso, percorrer item a item não seria interessante, em questão de performance.

Nesses cenários, o C# conta com uma linguagem para consultar uma lista de objetos. Ao final de ConsultaPorCPFTitular(), vamos digitar _listaDeContas seguido de um ponto, para acessar os métodos e as propriedades disponíveis. Entre eles, encontremos o Where(), um método que se estende da classe Linq.

O LINQ (Language Integrated Query) é uma linguagem que permite consultas em uma fonte de dados, como uma lista de objetos (a _listaDeContas, por exemplo), um banco de dados ou um arquivo .xml, por exemplo.

Dentro do Where(), vamos escrever uma expressão lambda:

```csharp
ContaCorrente ConsultaPorCPFTitular(string? cpf)
{
    //ContaCorrente conta = null;
    //for (int i = 0; i < _listaDeContas.Count; i++)
    //{
    //    if (_listaDeContas[i].Titular.Cpf.Equals(cpf))
    //    {
    //        conta = _listaDeContas[i];
    //    }
    //}
    //return conta;
    _listaDeContas.Where(conta => conta.Titular.Cpf == cpf).FirstOrDefault();
}
```

Nessa expressão lambda, primeiramente criamos uma variável chamada conta. Para toda conta, queremos retornar (dentro da nossa lista) uma conta-corrente cujo CPF do titular seja igual ao valor informado como parâmetro (ou seja, cpf). Além disso, .FirstOrDefault() define que o resultado deve ser o primeiro ou o default.

Sendo assim, invocando o Where() na _listaDeContas, o retorno será um objeto do tipo ContaCorrente. Já que ConsultaPorCPFTitular() também retorna uma ContaCorrente, basta acrescentarmos o return na linha 284:

```csharp
ContaCorrente ConsultaPorCPFTitular(string? cpf)
{
    //ContaCorrente conta = null;
    //for (int i = 0; i < _listaDeContas.Count; i++)
    //{
    //    if (_listaDeContas[i].Titular.Cpf.Equals(cpf))
    //    {
    //        conta = _listaDeContas[i];
    //    }
    //}
    //return conta;
    return _listaDeContas.Where(conta => conta.Titular.Cpf == cpf).FirstOrDefault();
}
```

A expressão Where() ficará sublinhada em amarelo, mas não precisamos nos preocupar: trata-se de um aviso, não um erro. Mais adiante, corrigiremos esses alertas.

Vamos salvar e executar o projeto para testar. A aplicação será renderizada e digitaremos 5 para consultar as contas-correntes. Em seguida, vamos optar pela opção 2 e informar o CPF 11111. Veremos o retorno desejado, o programa está funcionando normalmente.

Em resumo, estamos usando a expressão Where() que nos permitirá filtrar elementos de uma lista, de acordo com um expressão lambda. O resultado é um código mais otimizado: sintetizamos 9 linhas em uma só!

A seguir, aplicaremos a mesma lógica para o método ConsultaPorNumeroConta():

```csharp
ContaCorrente ConsultaPorNumeroConta(string? numeroConta)
{
    //ContaCorrente conta = null;
    //for (int i = 0; i < _listaDeContas.Count; i++)
    //{
    //    if (_listaDeContas[i].Conta.Equals(numeroConta))
    //    {
    //        conta = _listaDeContas[i];
    //    }
    //}
    //
    //return conta;
    return _listaDeContas.Where(conta => conta.Conta == numeroConta).FirstOrDefault();
}
```

Desse modo, redefinimos nossos dois tipos de consulta e otimizamos o código, reduzindo o número de linhas executadas pelo programa. Ainda há trabalho por fazer, podemos melhorar o projeto e tratar os alertas que estão aparecendo.

Neste vídeo, refizemos a funcionalidade de pesquisa usando um método genérico Linq, que é uma forma de operar um objeto em uma coleção de dados — seja um array em memória um banco de dados, um arquivo .xml, entre outros. As coleções possuem uma série de métodos de extensão, um deles é o Where() que usamos para filtrar um objeto dentro de uma lista.

Na sequência, nos aprofundaremos no estudo sobre LINQ e escreveremos uma consulta Linq.

### Aula 5: Faça como eu fiz: Where

Nesta aula começamos refatorando o código das nossas consultas por número da conta e cpf do titular e para isso fizemos o uso de métodos LINQ um deles o where que aplica a filtragem dos dados diretamente na coleção usando uma expressão lambda. Com o intuito de praticar refaça a consulta ConsultaPorCPFTitular usando o método Where.

Opinião do instrutor

Retornando ao método ConsultaPorCPFTitular e ConsultaPorNumeroConta, estamos usando um for para percorrer todo o vetor, porém temos a disposição para as listas alguns métodos de consulta, vamos ver o Where:

Vamos reescrever esses métodos de consulta usando o método Where:

```csharp
ContaCorrente ConsultaPorCPFTitular(string? cpf)
{
    ContaCorrente conta = null;
    for (int i = 0; i < _listaDeContas.Count; i++)
    {
       if (_listaDeContas[i].Titular.Cpf.Equals(cpf))
        {
            conta = _listaDeContas[i];
        }
    }

    return conta;   
}
```

Refatorando o método:

```csharp
ContaCorrente ConsultaPorCPFTitular(string? cpf)
{  
    return _listaDeContas.Where(conta=>conta.Titular.Cpf == cpf).FirstOrDefault();
}
```

Note que como parâmetro do método where é passada uma expressão conhecida como Lambda que vai conter o modo de filtragem. No C# toda expressão lambda usa o operador =>.

Poderiamos traduzir este código como: “ Lista retorne qual ´Qual a conta que possui o CPF do titular igual ao passado como parâmetro? E me retorne a primeira ocorrência ou o valor padrão.”

Com essa construção a pesquisa de uma conta com base no cpf ficou mais enxuta e elegante. Além de economizarmos linhas de código.

Legal! Continue praticando bastante e se desafiando como forma de fixar os conceitos aprendidos na aula.

### Aula 5: Uma nova pesquisa - Vídeo 2

Na aula anterior, terminamos de criar as consultas por CPF e por número da conta. Podemos minimizar todas as funções do Program.cs, pois chegou uma nova demanda do diretor do ByteBank: precisamos desenvolver uma consulta pelo número da agência.

Portanto, no método PesquisarContas(), adicionaremos o case 3 ao switch, referente à pesquisa por número da agência:

```csharp
private void PesquisarContas()
{
    Console.Clear();
    Console.WriteLine("===============================");
    Console.WriteLine("===    PESQUISAR CONTAS     ===");
    Console.WriteLine("===============================");
    Console.WriteLine("\n");
    Console.Write("Deseja pesquisar por (1) NÚMERO DA CONTA ou (2)CPF TITULAR ou " +
        " (3) Nº AGÊNCIA : ");
    switch (int.Parse(Console.ReadLine()))
    {
        case 1:
            {
                Console.Write("Informe o número da Conta: ");
                string _numeroConta = Console.ReadLine();
                ContaCorrente consultaConta = ConsultaPorNumeroConta(_numeroConta);
                Console.WriteLine(consultaConta.ToString());
                Console.ReadKey();
                break;
            }
        case 2:
            {
                Console.Write("Informe o CPF do Titular: ");
                string _cpf = Console.ReadLine();
                ContaCorrente consultaCpf = ConsultaPorCPFTitular(_cpf);
                Console.WriteLine(consultaCpf.ToString());
                Console.ReadKey();
                break;
            }
        case 3:
            {
                Console.Write("Informe o Nº da Agência: ");
                int _numeroAgencia = int.Parse(Console.ReadLine());
                var contasPorAgencia = ConsultaPorAgencia(_numeroAgencia);

                Console.ReadKey();
                break;
            }
        default:
            Console.WriteLine("Opção não implementada.");
            break;
    }
```

Note que também incrementamos o Console.WriteLine() na linha 79, para que o usuário saiba que agora há três maneiras de realizar a consulta.

Como o método ConsultaPorAgencia() ainda não existe, posicionaremos o cursor sobre ele na linha 103, pressionaremos "Ctrl + ." e selecionaremos "Gerar método 'ConsultaPorAgencia'". Uma estrutura base será criada a partir da linha 115, o parâmetro recebido será um int e o retorno esperado é um object, pois definimos a variável contasPorAgencia, na linha 103, com var (um retorno implícito). ConsultaPorAgencia() retornará uma lista de contas-correntes.

A seguir, modificaremos esse método. Vamos utilizar outro recurso do LINQ e escreveremos essa consulta manualmente, de modo que perceberemos que a sintaxe é muito parecida com a linguagem SQL. Disponibilizaremos materiais extras sobre SQL na plataforma.

A princípio, vamos declarar uma var chamada consulta que receberá o código da consulta entre parênteses:

```csharp
private List<ContaCorrente> ConsultaPorAgencia(int numeroAgencia)
    {
        var consulta = (

        )
    }
```

Com a cláusula from, indicaremos a origem dos dados. O where será responsável por filtrar apenas as contas cujo número da agência seja igual ao valor digitado pelo usuário. Caso sejam encontradas contas que correspondam a esse filtro, faremos o select para retorná-las. Em seguida, transformaremos esse resultado em uma lista, através do método .ToList(). Por fim, colocamos o return consulta:

```csharp
private List<ContaCorrente> ConsultaPorAgencia(int numeroAgencia)
    {
        var consulta = (
                             from conta in _listaDeContas
                             where conta.Numero_agencia == numeroAgencia
                             select conta).ToList();
        return consulta;
    }
```

Sendo assim, a pesquisa será realizada, porém o resultado ainda não será exibido. Nos cases 1 e 2 de PesquisarContas(), usamos o método ToString() de ContaCorrente para mostrar o resultado no console. Dessa vez, nosso retorno é uma lista de objetos ContaCorrente, então não conseguiremos usar o ToString diretamente nele. Em vez disso, vamos criar um método para percorrer uma lista passada como parâmetro e, dentro dele, poderemos usar o ToString em cada uma das contas.

Primeiramente, vamos incluir o método ExibirListaDeContas() no case 3:

```csharp
private void PesquisarContas()
{
    Console.Clear();
    Console.WriteLine("===============================");
    Console.WriteLine("===    PESQUISAR CONTAS     ===");
    Console.WriteLine("===============================");
    Console.WriteLine("\n");
    Console.Write("Deseja pesquisar por (1) NÚMERO DA CONTA ou (2)CPF TITULAR ou " +
        " (3) Nº AGÊNCIA : ");
    switch (int.Parse(Console.ReadLine()))
    {
        case 1:
            {
                Console.Write("Informe o número da Conta: ");
                string _numeroConta = Console.ReadLine();
                ContaCorrente consultaConta = ConsultaPorNumeroConta(_numeroConta);
                Console.WriteLine(consultaConta.ToString());
                Console.ReadKey();
                break;
            }
        case 2:
            {
                Console.Write("Informe o CPF do Titular: ");
                string _cpf = Console.ReadLine();
                ContaCorrente consultaCpf = ConsultaPorCPFTitular(_cpf);
                Console.WriteLine(consultaCpf.ToString());
                Console.ReadKey();
                break;
            }
        case 3:
            {
                Console.Write("Informe o Nº da Agência: ");
                int _numeroAgencia = int.Parse(Console.ReadLine());
                var contasPorAgencia = ConsultaPorAgencia(_numeroAgencia);
                ExibirListaDeContas(contasPorAgencia);
                Console.ReadKey();
                break;
            }
        default:
            Console.WriteLine("Opção não implementada.");
            break;
    }
```

Em seguida, clicaremos sobre ele, pressionaremos "Ctrl + ." e selecionaremos "Gerar método 'ExibirListaDeContas'". A partir da linha 116, vamos adaptá-lo:

```csharp
private void ExibirListaDeContas(List<ContaCorrente> contasPorAgencia)
{
    if (contasPorAgencia == null)
    {
        Console.WriteLine(" ... A consulta não retornou dados ...");
    }
    else
    {
        foreach (var item in contasPorAgencia)
        {
            Console.WriteLine(item.ToString());
        }
    }
}
```

Assim, ExibirListaDeContas() receberá uma lista de contas-correntes como parâmetro. Se contasPorAgencia for nulo, exibiremos uma mensagem informativa no console. Do contrário, com uma estrutura foreach, vamos percorrer contasPorAgencia. Para cada item da lista (isto é, para cada objeto ContaCorrente), invocaremos o método ToString.

Vamos salvar a aplicação e testar, pressionando o play na parte superior do Visual Studio. Após compilar e renderizar a aplicação, digitaremos 5 para pesquisar contas e, depois, escolheremos a opção 3 para consultar através do número da agência. Em seguida, informaremos o número da agência: 95. Como esperado, veremos duas contas listadas.

No momento, não é exibida a profissão do titular, porque não cadastramos essa informação no array.

Recapitulando: nesta aula, desenvolvemos uma nova consulta, utilizando um recurso do LINQ cuja sintaxe é dividida em três partes principais. O from define a origem dos dados, o where determina o filtro e o select seleciona o objeto daquela coleção. No nosso caso, também usamos o método ToList() para transformar o resultado em uma lista. Esse recurso é bastante interessante para consultarmos coleções de objetos usando C#.

### Aula 5: Encontrando um cliente - Exercício

Esther e Cleber estão fazendo pair programming, para definir uma consulta LINQ a uma coleção de dados de Pessoas. A fonte de dados que eles estão usando é um List`<Pessoa>` em memória. Marque a opção correta que retornará uma Pessoa com base no email informado (que é único por pessoa).

Selecione 2 alternativas:

Alternativa correta.  

```csharp
Pessoa? ConsultaCliente(List<Pessoa> _pessoas, string _email)
{
    return _pessoas.Where(x=>x.Email.Equals(_email)).FirstOrDefault();
}
```

> A sintaxe de consulta LINQ utilizando métodos e expressão lambda está correta.

Alternativa correta.  

```csharp
Pessoa? ConsultaCliente(List<Pessoa> _pessoas, string _email)
{
    return (from pessoa in _pessoas
            where pessoa.Email == _email
            select pessoa).FirstOrDefault();
}
```

> A sintaxe de consulta LINQ está correta, definindo a origem (from), o filtro (where) e a seleção (select), de forma única usando o .FirstOrDefault();.

### Aula 5: Para saber mais: LINQ

O LINQ ( Language Integrated Query), é uma linguagem para manipulação de dados que nos foi apresentado no .NET Framework 3.0 e tem por objetivo possibilitar que os programas desenvolvidos na plataforma .NET consigam selecionar dados a partir de origens diversas desde um array, bancos de dados relacionais e até arquivos XML.

Na utilização do LINQ podemos usar duas formas:

Sintaxe de consulta: muito similar as consultas utilizadas em bancos relacionais como SQL e a operação de consulta é dividida em 3 cláusulas: from define a origem dos dados, o where para aplicação dos filtros e do select para a seleção dos dados, veja o exemplo abaixo:

```csharp
List<Cliente> clientes = new List<Cliente>(){
          new Cliente(){Nome="José",Cpf="10855522299",Profissao="Dev"},
          new Cliente(){Nome="Maria",Cpf="10477722299",Profissao="Enfermeira"},
          new Cliente(){Nome="Rose",Cpf="10966622299",Profissao="Analista"},
          new Cliente(){Nome="Caio",Cpf="10355722299",Profissao="Entregador"},
          new Cliente(){Nome="Elisa",Cpf="10967422299",Profissao="Motorista"},
          new Cliente(){Nome="João",Cpf="10778122299",Profissao="Atleta"}
};

Cliente? ConsultaCliente(List<Cliente> _clientes, string _cpf)
{

    return (from cliente in _clientes
            where cliente.Cpf == _cpf
            select cliente).FirstOrDefault();

}
```

Outra possibilidade é utilizar métodos LINQ , a maioria de extensão, que permite uma instrução mais concisa, veja o exemplo anterior usando método:

```csharp
Cliente? ConsultaCliente2(List<Cliente> _clientes, string _cpf) { 

    return _clientes.Where(x => x.Cpf == _cpf).FirstOrDefault();

}
```

Para saber mais sobre utilização do LINQ deixamos a recomendação de acesso a documentação da Microsoft;

- [Introdução a consultas LINQ (C#)](https://docs.microsoft.com/pt-br/dotnet/csharp/programming-guide/concepts/linq/introduction-to-linq-queries)
- [Curso Entity LinQ parte 1: crie queries poderosas em C#](https://cursos.alura.com.br/course/linq-c-sharp)
- [Curso Entity LinQ parte 2: Store Procedures e consultas com o LinQPad](https://cursos.alura.com.br/course/linq-c-sharp-parte-2)

### Aula 5: Desafio: usando a sintaxe de consulta

Agora que você viu como criar uma consulta usando a sintaxe de consulta do LINQ, te desafiamos a reescrever a consulta ConsultaPorNumeroConta usando essa sintaxe. E ai? aceita o desafio?

Lembre-se este é mais um exercício opcional, mas a prática constante vai lhe ajudar a fixar os conteúdos estudados.

Opinião do instrutor

Agora apresentamos uma possível solução para o desafio proposto:

```csharp
private ContaCorrente ConsultaPorNumeroConta(string? numeroConta)
{
    return (from conta in _listaDeContas
            where conta.Conta.Equals(numeroConta)
            select conta).FirstOrDefault();
}
```

### Aula 5: Melhorando o código #1 - Vídeo 3

Estamos finalizando nossa aplicação. Já implementamos suas principais funcionalidades: cadastro, listagem, remoção, ordenação e pesquisa de contas — como podemos checar no método AtendimentoCliente() no arquivo Program.cs. Falta apenas a função de saída do sistema.

O nosso código está funcionando como esperado, porém o arquivo Program.cs está bastante extenso. Para melhorar nosso projeto e facilitar futuras manutenções, vamos encapsular as funcionalidades de atendimento em uma classe, organizando também um namespace específico. No Gerenciador de Soluções, na lateral direita do Visual Studio, clicaremos com o botão direito do mouse sobre nosso projeto bytebank_ATENDIMENTO e selecionaremos "Adicionar > Nova Pasta". Vamos nomeá-la "bytebank.Atendimento".

Para criar uma classe nesse novo diretório, clicaremos com o botão direito nele e selecionaremos "Adicionar > Classe...". Na parte inferior da nova janela que se abriu, daremos à classe o nome "ByteBankAtendimento.cs".

Em seguida, vamos recortar do Program.cs e colar na classe ByteBankAtendimento todo o código referente ao atendimento, desde a definição da nossa lista com 3 contas padrões (a coleção em memória) até o final do arquivo.

A seguir, precisamos fazer alguns ajustes em ByteBankAtendimento.cs. Primeiro, vamos remover a chamada ao método AtendimentoCliente(), pois ela será feita a partir de Program.cs.

Por ser uma classe nova, é preciso importar novamente os namespaces para que as localizações de ContaCorrente e Cliente, por exemplo, sejam reconhecidas. Basta clicarmos sobre os elementos sublinhados em vermelho, pressionar "Ctrl + ." e fazer a importação.

Além disso, podemos remover quaisquer linhas comentadas, já que não serão executadas pelo programa. Também podemos minimizar os métodos para tornar a visualização mais simples.

Seguindo as boas práticas e outras recomendações relativas a orientações a objetos, é interessante que a _listaDeContas seja um campo privado para ser acessível somente pelos métodos dessa própria classe:

```csharp
// código anterior omitido

private List<ContaCorrente> _listaDeContas = new List<ContaCorrente>(){
    new ContaCorrente(95, "123456-X"){Saldo=100,Titular = new Cliente{Cpf="11111",Nome ="Henrique"}},
    new ContaCorrente(95, "951258-X"){Saldo=200,Titular = new Cliente{Cpf="22222",Nome ="Pedro"}},
    new ContaCorrente(94, "987321-W"){Saldo=60,Titular = new Cliente{Cpf="33333",Nome ="Marisa"}}
};

// código posterior omitido
Deixamos os demais métodos como private também, exceto o AtendimentoCliente(). Ele precisa ser público para podermos acessá-lo pelo Program.cs:


Copiar
// código anterior omitido

public void AtendimentoCliente()
{
    try
    {
        char opcao = '0';
        while (opcao != '6')
        {
            Console.Clear();
            Console.WriteLine("===============================");
            Console.WriteLine("===       Atendimento       ===");
            Console.WriteLine("===1 - Cadastrar Conta      ===");
            Console.WriteLine("===2 - Listar Contas        ===");
            Console.WriteLine("===3 - Remover Conta        ===");
            Console.WriteLine("===4 - Ordenar Contas       ===");
            Console.WriteLine("===5 - Pesquisar Conta      ===");
            Console.WriteLine("===6 - Sair do Sistema      ===");
            Console.WriteLine("===============================");
            Console.WriteLine("\n\n");
            Console.Write("Digite a opção desejada: ");
            try
            {
                opcao = Console.ReadLine()[0];
            }
            catch (Exception excecao)
            {
                throw new ByteBankException(excecao.Message);
            }

            switch (opcao)
            {
                case '1':
                    CadastrarConta();
                    break;
                case '2':
                    ListarContas();
                    break;
                case '3':
                    RemoverContas();
                    break;
                case '4':
                    OrdenarContas();
                    break;
                case '5':
                    PesquisarContas();
                    break;
                default:
                    Console.WriteLine("Opcao não implementada.");
                    break;
            }
        }
    }
    catch (ByteBankException excecao)
    {
        Console.WriteLine($"{excecao.Message}");
    }
}
// código posterior omitido
```

Das linhas 1 a 7, temos as importações. Note que as últimas 5 importações têm o tom esmaecido, meio apagado, o que signifca que não estão sendo utilizadas. Vamos removê-las e manter apenas as necessárias, que são: bytebank.Modelos.Conta e bytebank_ATENDIMENTO.bytebank.Exceptions.

Em seguida, vamos checar os alertas que estão aparecendo no nosso código. Por exemplo, no método AtendimentoCliente(), na linha em que atribuimos um valor a opcao, há em destaque sublinhado em verde. Passando o mouse sobre esse trecho, veremos uma descrição: "CS8602 Desreferência de uma referência possivelmente nula". Trata-se de um recurso relativamente recente do .NET que diz respeito aos nullables. Em resumo, essa operação pode retornar um valor nulo para a variável, que não foi definida como um tipo anulável.

Esse destaque aparece para nós porque, na configuração do projeto, foram habilitadas essas labels, ou seja, esses alertas que nos ajudam como desenvolvedores a encontrar pontos de atenção. Para ver essa configuração, vamos dar um clique duplo no nome do nosso projeto bytebank_ATENDIMENTO, no Gerenciador de Soluções à direita.

Dessa forma, abriremos o arquivo bytebank_ATENDIMENTO.csproj, onde temos a definição do executável, a versão do .NET, a habilitação de importações implícitas e a habilitação do Nullable. Então, caso esses alertas sejam um incômodo, uma solução é fazer a desabilitação deles, usando o termo disable:

```csharp
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>net6.0</TargetFramework>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>disable</Nullable>
  </PropertyGroup>

</Project>
```

No nosso caso, é interessante deixarmos habilitado, pois esses aviso não interferem no código e funcionam como um lembrete de pontos a tratar no futuro. Outra solução é informarmos que queremos ignorar esses alertas nessa classe em específico. Basta inserirmos #nullable disable antes da definição da classe:

```csharp
namespace bytebank_ATENDIMENTO.bytebank.Atendimento
{
#nullable disable
internal  class ByteBankAtendimento
{
    // trecho de código omitido
}
```

Na sequência, vamos implementar a funcionalidade de saída do sistema, a opção 6 do menu. Começaremos incluindo o case '6' ao switch:

```csharp
public void AtendimentoCliente()
{
    try
    {
        char opcao = '0';
        while (opcao != '6')
        {
            Console.Clear();
            Console.WriteLine("===============================");
            Console.WriteLine("===       Atendimento       ===");
            Console.WriteLine("===1 - Cadastrar Conta      ===");
            Console.WriteLine("===2 - Listar Contas        ===");
            Console.WriteLine("===3 - Remover Conta        ===");
            Console.WriteLine("===4 - Ordenar Contas       ===");
            Console.WriteLine("===5 - Pesquisar Conta      ===");
            Console.WriteLine("===6 - Sair do Sistema      ===");
            Console.WriteLine("===============================");
            Console.WriteLine("\n\n");
            Console.Write("Digite a opção desejada: ");
            try
            {
                opcao = Console.ReadLine()[0];
            }
            catch (Exception excecao)
            {
                throw new ByteBankException(excecao.Message);
            }

            switch (opcao)
            {
                case '1':
                    CadastrarConta();
                    break;
                case '2':
                    ListarContas();
                    break;
                case '3':
                    RemoverContas();
                    break;
                case '4':
                    OrdenarContas();
                    break;
                case '5':
                    PesquisarContas();
                    break;
                case '6':
                    EncerrarAplicacao();
                    break;
                default:
                    Console.WriteLine("Opcao não implementada.");
                    break;
            }
        }
    }
    catch (ByteBankException excecao)
    {
        Console.WriteLine($"{excecao.Message}");
    }
}
```

Clicaremos sobre EncerrarAplicacao() na linha 64, pressionaremos "Ctrl + ." e selecionaremos "Gerar método 'EncerrarAplicacao'". Em seguida, vamos modificar a estrutura base que foi gerada automaticamente:

```csharp
private void EncerrarAplicacao()
{
    Console.WriteLine("... Encerrando a aplicação ...");
    Console.ReadKey();
}
```

Trata-se de um método bastante simples: será exibida uma mensagem de que a aplicação será encerrada e esperaremos que o usuário digite qualquer tecla para finalizar o programa.

### Aula 5: Melhorando o código #2 - Vídeo 4

A seguir, vamos nos atentar a um ponto de melhoria no método CadastrarConta(): atualmente, ao iniciar o processo de cadastro, o gerente de contas deve informar o número da nova conta, no entanto, o ideal é que esse valor seja gerado automaticamente. Como o C# conta com ferramentas para automatizar esse processo, vamos implementá-las.

Nosso objetivo é que, ao criar uma instância de ContaCorrente, ela mesma gere automaticamente seu número. Atualmente, nosso construtor (no arquivo ContaCorrente.cs) recebe como parâmetros o número da agência e o número da conta. Então, abaixo dele, vamos definir um novo construtor que recebe somente o número da agência:

```csharp
public ContaCorrente(int numero_agencia)
{
    Numero_agencia = numero_agencia;
    Conta = Guid.NewGuid().ToString().Substring(0, 8);
    Titular = new Cliente();
    TotalDeContasCriadas += 1;
}
```

De início, atribuímos o parâmetro recebido à propriedade Numero_agencia, assim como no construtor anterior.

Em seguida, Conta (a propriedade da classe ContaCorrente) utiliza a estrutura Guid. Ao invocar NewGuid(), criaremos uma sequência alfanumérica aleatória que será transformada numa string da qual extrairemos uma substring, da posição 0 a 8.

No restante do construtor, continuamos fazendo o mesmo do construtor anterior: definimos uma nova instância de Cliente no titular e incrementamos o TotalDeContasCriadas.

Agora, vamos ajustar a classe ByteBankAtendimento. Visto que o número da conta será gerado automaticamente, não precisamos mais solicitar essa informação ao usuário, então vamos remover as linhas 230 e 231. Consequentemente, ao invocar o construtor de ContaCorrente, deixaremos de passar numeroConta:

```csharp
private void CadastrarConta()
{
    Console.Clear();
    Console.WriteLine("===============================");
    Console.WriteLine("===   CADASTRO DE CONTAS    ===");
    Console.WriteLine("===============================");
    Console.WriteLine("\n");
    Console.WriteLine("=== Informe dados da conta ===");
    Console.Write("Número da Agência: ");
    int numeroAgencia = int.Parse(Console.ReadLine());
    ContaCorrente conta = new ContaCorrente(numeroAgencia);

    // trecho de código omitido
}
```

Após instanciarmos uma ContaCorrente, podemos exibir o número gerado para essa nova conta, com uma interpolação de string:

```csharp
private void CadastrarConta()
{
    Console.Clear();
    Console.WriteLine("===============================");
    Console.WriteLine("===   CADASTRO DE CONTAS    ===");
    Console.WriteLine("===============================");
    Console.WriteLine("\n");
    Console.WriteLine("=== Informe dados da conta ===");
    Console.Write("Número da Agência: ");
    int numeroAgencia = int.Parse(Console.ReadLine());
    ContaCorrente conta = new ContaCorrente(numeroAgencia);
    Console.WriteLine($"Número da conta [NOVA] : {conta.Conta}");
    Console.Write("Informe o saldo inicial: ");
    conta.Saldo = double.Parse(Console.ReadLine());

    Console.Write("Infome nome do Titular: ");
    conta.Titular.Nome = Console.ReadLine();

    Console.Write("Infome CPF do Titular: ");
    conta.Titular.Cpf = Console.ReadLine();

    Console.Write("Infome Profissão do Titular: ");
    conta.Titular.Profissao = Console.ReadLine();

    _listaDeContas.Add(conta);

    Console.WriteLine("... Conta cadastrada com sucesso! ...");
    Console.ReadKey();
}
```

Depois, o usuário segue preenchendo os demais dados, como fazia antes. Vamos salvar essas alterações e partir para o arquivo Program.cs, onde precisamos instanciar a classe ByteBankAtendimento e invocar o método AtendimentoCliente(). Vale lembrar que devemos importar o namespace correspondente:

```csharp
using bytebank.Modelos.Conta;
using bytebank_ATENDIMENTO.bytebank.Atendimento;
using bytebank ATENDIMENTO.bytebank.Exceptions;

Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");

new ByteBankAtendimento().AtendimentoCliente();
```

Podemos, inclusive, remover as importações que não estão mais sendo utilizadas, deixando esse arquivo com apenas 3 linhas:

```csharp
using bytebank_ATENDIMENTO.bytebank.Atendimento;
Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");
new ByteBankAtendimento().AtendimentoCliente();
```

Vamos salvar todas as alterações e rodar a aplicação, pressionando play na parte superior do Visual Studio. Como teste, vamos cadastrar uma conta, escolhendo a opção 1 e informando os seguintes dados:

```csharp
Número da Agência: 15
Saldo inicial: 120
Nome do Titular: André Silva
CPF do Titular: 1012236524
Profissão: Dev
```

Note que após informar o número da agência, é exibida a sequência alfanumérica que corresponde ao número da conta gerada! O cadastro será realizado com sucesso. Em seguida, no menu, digitaremos 2 para realizar a listagem e veremos todas as contas do ByteBank, inclusive a que acabamos de cadastrar. O aplicativo está funcionando exatamente como esperado.

Ao longo do desenvolvimento da nossa aplicação, procurando respeitar as boas práticas de programação, dando nomes significativos para nossas variáveis e coleções, o que torna a leitura e interpretação do código mais simples e rápida. Durante a refatoração, organizamos o código e separamos responsabilidades, ações também importantes para facilitar futuras manutenções. Ainda podemos aprimorar o projeto (tratando mais exceções, por exemplo), contudo faremos esse trabalho paulatinamente até chegar ao código que queremos.

Por fim, vale lembrarmos que neste vídeo aprendemos a usar mais um recurso do .NET: a estrutura Guid, que gera uma sequência alfanumérica aleatória.

### Aula 5: Para saber mais: Guid

O Globally Unique Identifier, mais conhecido como GUID, ele representa um identificador global exclusivo ele é utilizado para as situações que precisamos de uma sequência única que não se repita para toda uma aplicação.

O Guid é um número inteiro de 128 bits que pode gerar ao em torno de 5.316.911.983.139.663.491.615.228.241.121.400.000 combinações possíveis, muita coisa não é mesmo?

Uma representação de um guid df0d718c-06f1-4f22-8628-f825fc1d43e5, no C# temos a struct Guid que permite criar e manipular guids, veja um exemplo:

> Console.WriteLine(Guid.NewGuid().ToString());// saída 826890ce-6206-4144-817c-0c3879d77fae

Para saber mais sobre utilização da struct Guid deixamos a recomendação de acesso a [documentação da Microsoft Guid Estrutura (C#)](https://docs.microsoft.com/pt-br/dotnet/api/system.guid?view=net-6.0)

### Aula 5: Projeto final do curso

Você pode [baixar o zip do projeto](https://github.com/alura-cursos/Array_Collections_C/archive/refs/heads/aula05.zip) da aula ou acessar o link do [repositório no GitHub!](https://github.com/alura-cursos/Array_Collections_C/tree/aula05)

### Aula 5: Conclusão - Vídeo

Parabéns por concluir mais um curso na plataforma da Alura! Recomendamos que assista aos vídeos quantas vezes precisar para fixar o conteúdo, realize todas as atividades disponíveis nas aulas e pratique bastante!

Em caso de dúvidas, você pode recorrer ao fórum do curso, onde é possível sanar suas dúvidas, bem com ajudar seus colegas.

Neste treinamento, aprendemos mais sobre o Visual Studio Community, a IDE que usamos ao longo de toda essa formação de C# e orientação a objetos. Estudamos também como utilizar interfaces disponibilizadas pela plataforma .NET. Na classe ContaCorrente, por exemplo, utilizamos a interface IComparable que permite que uma coleção de objetos possa ser ordenada ou classificada.

Nesse projeto, pudemos compreender o que são coleções de objetos, o que são arrays e as similaridades entre esses dois conceitos. Por exemplo, na classe ByteBankAtendimento, definimos _listaDeContas do tipo List<> (uma classe da biblioteca .NET) e, usando o Generics, determinamos que essa lista receberia somente objetos do tipo ContaCorrente. Dessa forma, entendemos que o Generics é uma forma de parametrizarmos uma classe ou um método. Além disso, percebemos que o uso de classes como List<> é muito vantajoso, pois já têm disponibilizados uma série de métodos e funcionalidades (como adição, remoção e consulta) que dão dinamismo e agilidade no desenvolvimento de listas e coleções com C#.

Assim, desenvolvemos uma aplicação console em que é possível cadastrar, listar, remover, ordenar e pesquisar contas-correntes. Executando nosso projeto, podemos digitar 1 para cadastrar uma conta e informar os seguintes dados:

```bash
Número da Agência: 58
Saldo inicial: 96
Titular: André
CPF: 1123536
Profissão: Dev C#
```

Uma vez que o cadastro é realizado com sucesso, voltamos ao menu e podemos listar todas as contas do ByteBank selecionando a opção 2. Vale lembrar que já temos 3 contas padrões cadastradas no nosso sistema. Para fazer uma pesquisa, é possível escolher a opção 5 no menu da aplicação. Em seguida, vamos escolher 3 e consultar contas-correntes cujo número da agência é igual a 94. Como resultado, veremos a lista que corresponde à busca. Tudo está funcionando como esperado.

Por fim, podemos digitar 6 para encerrar a aplicação.

Não se esqueça de avaliar o curso e comentar sobre sua experiência estudando conosco, apontando formas como podemos melhorar. Até a próxima!
