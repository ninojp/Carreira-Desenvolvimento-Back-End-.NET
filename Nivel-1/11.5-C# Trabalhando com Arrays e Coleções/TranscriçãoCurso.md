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

### Aula 3:  - Vídeo 1
### Aula 3:  - Vídeo 2
### Aula 3:  - Vídeo 3
### Aula 3:  - Vídeo 4
### Aula 3:  - Vídeo 5

