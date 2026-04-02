# Curso Alura Praticando C#: coleções

## Aula 1: Arrays

### Aula 1: Apresentação - Video 1

Transcrição  
Boas-vindas! Meu nome é Iasmin Araújo, faço parte da Escola de Programação da Alura, e irei te acompanhar ao longo dessa jornada de aprendizagem em C#.

Audiodescrição: Iasmin se descreve como uma mulher branca, de cabelo castanho-escuro longo e liso repartido ao meio, e olhos verdes. Ela veste uma blusa vinho, e está sentaeda em frente a um microfone prateado, com uma parede clara ao fundo iluminada em gradiente azul.

**O que vamos aprender?**  
Neste curso, vamos praticar o uso de coleções, explorando diversos tópicos:

- Como representar dados utilizando coleções;
- Em quais situações isso é útil;
- Diferentes tipos de coleções, como:
  - Arrays
  - Listas
  - Conjuntos
  - Dicionários;
- Quais operações podem ser realizadas?
  - Busca por índice
  - Busca por elemento
  - Inserção e remoção de elementos em uma coleção
  - Ordenação e inversão de uma coleção

**Conclusão**  
Os tópicos mencionados são muito relevantes para o seu aprendizado, pois são amplamente utilizados no dia a dia. É essencial compreender o que são coleções e como utilizá-las.

Na sequência, começaremos a praticar todo esse conhecimento!

### Aula 1: O que esperar deste curso

Antes de mergulharmos no código, que tal alinharmos as expectativas?

**O que significa um curso prático?**  
Já se pegou pensando — será que consigo aplicar o que aprendi na prática? Este curso é a sua resposta. Aqui, o foco é colocar a mão no código, resolver problemas e testar seu conhecimento de forma ativa. Você terá:

- Vídeo de revisão do conteúdo
- Material de apoio
- Desafios de código

**Pré requisitos**  
É importante ter concluído o [curso C#: criando sua primeira aplicação](https://cursos.alura.com.br/course/csharp-criando-primeira-aplicacao), pois ele cobre os fundamentos da linguagem, garantindo que você consiga realizar os exercícios deste curso com mais segurança.

Dicas para potencializar seu aprendizado neste curso

- Assista ao vídeo de revisão com atenção. Pause, anote e revise sempre que necessário.
- Baixe o material complementar para ter um apoio nas atividades.
- Faça os desafios na sua IDE favorita.
- Compartilhe o que aprendeu no fórum, pois sua abordagem pode inspirar outras pessoas.

Vamos começar?

### Aula 1: Preparando o ambiente: Instalando o Visual Studio

Olá!  
O IDE do Visual Studio é uma plataforma de lançamento criativa que você pode usar para editar, depurar e criar código e, em seguida, publicar um aplicativo. Além do editor e depurador padrão fornecidos pela maioria dos IDEs, o Visual Studio inclui compiladores, ferramentas de conclusão de código, designers gráficos e muitos outros recursos para aprimorar o processo de desenvolvimento de software. O IDE mais abrangente para desenvolvedores .NET no Windows e Mac para criação de web, nuvem, desktop, aplicativos móveis, serviços e jogos.

Sabendo disso, preparamos alguns vídeos para instalar em diferentes sistemas operacionais. Para este curso em específico, marque a opção Desenvolvimento para Desktop com .NET. no processo de instalação.

Visual Studio no Windows

Visual Studio no Mac

C# no VSCODE (SDK)

**C# em distribuições Linux**  
[Neste link](https://learn.microsoft.com/pt-br/dotnet/core/install/linux), você encontra um passo a passo da própria Microsoft de como instalar em distribuições Linux, como Alpine, CentOS, Debian, entre outras.

Vamos começar?

### Aula 1: Preparando o ambiente: material de apoio

Após revisar os conceitos de coleções em C#, é hora de colocar o conhecimento em prática com uma série de atividades focadas no tema. Caso queira acessar os slides da revisão, eles estão disponíveis no link abaixo:

[Baixe os slides do curso](http://cdn3.gnarususercontent.com.br/4571-praticando-csharp-colecoes/Praticando%20C%23%20-%20Cole%C3%A7%C3%B5es.pptx.pdf)

**Top-level statements**  
A partir da versão 9.0 do C#, não é mais necessário escrever using System; ou criar uma classe Program com o método Main. Isso acontece graças ao recurso chamado top-level statements (ou instruções de nível superior), que permite eliminar a estrutura tradicional usada como ponto de entrada do programa. Antes, um aplicativo de console típico era escrito assim:

```csharp
using System;
 
namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
```

Com as instruções de nível superior, você pode simplificar e escrever apenas:

```csharp
Console.WriteLine("Hello, World!");
```

Esse recurso pode te ajudar a deixar os exercícios mais simples e diretos, com foco na lógica e não na estrutura do programa. Após finalizar todos os desafios, não esqueça de compartilhar sua solução no fórum. Será incrível ver como você resolveu!

Vamos nessa?

### Aula 1: Arrays - Video 2

Transcrição  
Neste primeiro vídeo, abordaremos o tópico de arrays.

#### Trabalhando com arrays

Trabalhando com vários funcionários

Para começarmos a falar sobre coleções, vamos imaginar que trabalhamos em um sistema de RH. Nesse sistema, queremos armazenar dados de funcionários. Suponha que temos quatro funcionários. Dessa forma, conseguimos criar quatro variáveis para guardar seus respectivos dados.

Podemos ter, por exemplo, uma string chamada funcionario recebendo o valor "João", uma string funcionario1 para ser a "Maria", funcionario2 para corresponder a "Cláudia", e funcionario3 para ser "Oscar". Dessa forma, temos as quatro variáveis.

```csharp
string funcionario = "João";
string funcionario1 = "Maria";
string funcionario2 = "Cláudia";
string funcionario3 = "Oscar";
```

**Utilizando coleções**  
Com quatro variáveis isso funciona. Conseguimos, por exemplo, saber que a variável funcionario1 está associada à Maria. No entanto, e se tivéssemos 100 funcionários? Ou 1.000 funcionários? Seria possível saber que o funcionário 100, por exemplo, é Yasmin?

Não conseguiríamos gerenciar esse tipo de informação. Para lidar com isso e armazenar diversos dados de forma concentrada, podemos utilizar coleções. As coleções possuem diversos tipos diferentes que iremos conhecer. Começaremos pelo tipo de coleção mais básico: os arrays.

**Declarando e inicializando arrays**  
Como funciona um array? Utilizamos colchetes para indicar um tipo de dado diferente para o compilador, como string[]. Sempre que queremos declarar uma variável do tipo array, declaramos o tipo e depois abrimos colchetes. Assim, criamos uma coleção do tipo array.

```csharp
string[] funcionarios;
```

Acima, temos um exemplo de declaração de array, mas ele não está inicializado. Sendo assim, como podemos inicializar um array? Para isso, podemos passar os dados diretamente usando =, e colocar entre chaves todas as strings que queremos guardar, separadas por vírgula.

Dessa forma, o próprio array saberá que seu tamanho é 4, pois temos quatro strings.

```csharp
string[] funcionarios = {"João", "Maria", "Cláudia", "Oscar"};
```

Outra opção é declarar explicitamente o tamanho do array. Nesse caso, criaremos uma string[] funcionarios, que receberá new string[] com o tamanho do array desejado, ou seja, 4.

Importante! O tamanho é 4, mas só conseguimos acessar as posições do array de 0 até 3, pois a contagem começa a partir do 0. Assim, temos as posições 0, 1, 2 e 3.

```csharp
string[] funcionarios = new string[4];
funcionarios[0] = "João";
funcionarios[1] = "Maria";
…
```

**Acessando e manipulando dados em arrays**  
Para acessar as posições do array, usamos colchetes. Os colchetes servem tanto para declarar e inicializar o array, quanto para acessar elementos específicos. No exemplo anterior, ao acessar funcionarios[0], dizemos que, nessa posição, o array armazena a string "João". Em seguida, podemos definir que funcionarios[1] armazena a string "Maria", e assim por diante.

Uma característica importante dos arrays é que, uma vez definido o tamanho, ele não muda. Portanto, o array funcionarios sempre terá o tamanho 4.

**Operações comuns com arrays**  
Além de armazenar dados, podemos realizar diversas operações com arrays. Vamos acessar o Visual Studio para visualizar melhor essas operações e conhecer as mais comuns?

Program.cs:

```csharp
string[] funcionarios = {"João", "Maria", "Cláudia", "Oscar"};
```

Temos o mesmo exemplo apresentado anteriormente: um array de funcionários com quatro posições. A primeira operação pode ser acessar quem está na posição 2. Utilizamos Console.WriteLine() para imprimir o elemento na posição desejada, com colchetes para especificar essa posição. Neste caso, queremos a posição 2, então passamos 2 entre colchetes.

```csharp
string[] funcionarios = {"João", "Maria", "Cláudia", "Oscar"};

Console.WriteLine(funcionarios[2]);
```

Ao executar o programa, é retornado "Cláudia", que está na posição 2 do array.

Outra operação possível é buscar o índice de um elemento.

Para isso, usamos um método específico da classe Array. Após o Console.WriteLine(), vamos declarar um int indice, que será igual ao resultado do método Array.IndexOf().

Em IndexOf(), passaremos a coleção com a qual queremos trabalhar, ou seja, funcionarios, e o elemento que queremos buscar. Suponha que buscamos o índice do Oscar. Por fim, imprimimos o índice com Console.WriteLine(), fazendo interpolação para exibir a posição.

```csharp
string[] funcionarios = {"João", "Maria", "Cláudia", "Oscar"};

Console.WriteLine(funcionarios[2]);
int indice = Array.IndexOf(funcionarios, "Oscar");
Console.WriteLine($"Posição do Oscar = {indice}");
```

Ao executar, recebemos no retorno "Cláudia" e, em seguida, "Posição do Oscar = 3". Assim, conseguimos realizar busca tanto pela posição do índice quanto do elemento, utilizando o IndexOf(). Essas são operações comuns ao trabalhar com arrays.

**Ordenando e iterando arrays**  
Outra operação que podemos realizar é ordenar a coleção.

Para isso, continuaremos utilizando a classe Array. Nesse caso, usaremos Array.Sort() e passaremos a coleção que desejamos ordenar, isto é, a coleção funcionarios.

Para visualizar se o array foi ordenado, usaremos um foreach para iterar sobre string nome in funcionarios. No escopo do foreach, o Console.WriteLine() exibirá o nome dos funcionários.

```csharp
string[] funcionarios = {"João", "Maria", "Cláudia", "Oscar"};

Console.WriteLine(funcionarios[2]);
int indice = Array.IndexOf(funcionarios, "Oscar");
Console.WriteLine($"Posição do Oscar = {indice}");

Array.Sort(funcionarios);
foreach(string nome in funcionarios)
{
    Console.WriteLine(nome);
}
```

Dessa forma, conseguimos visualizar o array impresso, mostrando "Cláudia", "João", "Maria" e "Oscar" em ordem alfabética, já que estamos lidando com strings.

Observação: se estivéssemos lidando com números, a ordenação seria numérica.

Retorno no terminal:

```csharp
Cláudia
Posição do Oscar = 3
Cláudia
João
Maria
Oscar
```

A classe Array é importante e possui vários métodos que podem ser utilizados ao lidar com muitos dados. É interessante explorar esses métodos para conhecê-los e utilizá-los posteriormente.

**Inserindo e removendo dados de arrays**  
Uma última operação que podemos tentar é inserir novos dados no array.

Suponha que temos nossos funcionários e uma nova pessoa entrou no time. Nesse caso, precisamos inserir um novo registro no array. Como fazemos isso?

Como nosso array tem tamanho fixo, não podemos alterar essa parte específica, então será necessário criar um novo array com tamanho 5 e copiar todos os dados do array funcionarios para esse novo array. O novo array se chamará novoArray e atribuiremos a ele new string[5].

Em seguida, o novoArray receberá a cópia de funcionarios com Array.Copy(), passando entre parênteses a fonte (funcionarios), o destino (novoArray) e o tamanho funcionarios.Length.

```csharp
// código omitido

Array.Sort(funcionarios);
foreach(string nome in funcionarios)
{
    Console.WriteLine(nome);
}

string[] novoArray = new string[5];
Array.Copy(funcionarios, novoArray, funcionarios.Lenght);
```

Dessa forma, copiamos os dados. Para verificar se a cópia foi feita corretamente, vamos trabalhar com foreach (string nome in novoArray) contendo Console.WriteLine(nome). Antes de executar para conferir o resultado, podemos adicionar traços para separar as informações do retorno.

```csharp
// código omitido
Console.WriteLine("--------");
string[] novoArray = new string[5];
Array.Copy(funcionarios, novoArray, funcionarios.Lenght);
foreach (string nome in novoArray)
{
    Console.WriteLine(nome);
}
```

Ao executar, recebemos os nomes de novoArray, que é a cópia.

Retorno no terminal:

```csharp
--------
Cláudia
João
Maria
Oscar
```

Agora, vamos inserir um novo elemento para testar, a funcionária Joana. Para isso, chamamos novoArray na posição 4, que é a última posição, e atribuímos "Joana". Ao final, imprimimos novamente, copiando o traço do Console.WriteLine() e o foreach para visualizar corretamente.

```csharp
// código omitido

Console.WriteLine("--------");
string[] novoArray = new string[5];
Array.Copy(funcionarios, novoArray, funcionarios.Lenght);
foreach (string nome in novoArray)
{
    Console.WriteLine(nome);
}
novoArray[4] = "Joana";
Console.WriteLine("----------");

foreach (string nome in novoArray)
{
    Console.WriteLine(nome);
}
```

Ao executar o programa, visualizamos "Cláudia", "João", "Maria", "Oscar" e "Joana". Assim, conseguimos adicionar um novo elemento ao nosso array.

No entanto, essa operação foi trabalhosa, pois precisamos criar uma cópia e realizar uma série de operações apenas para inserir um elemento. Se precisássemos criar um novo array sempre que um novo funcionário entrasse, seria uma operação ineficiente.

Quando falamos sobre remoção de elementos, enfrentamos um problema semelhante. Ao remover "Maria" do array, precisamos mover todos os elementos para as posições anteriores:

- A posição 1 deverá ser "Cláudia";
- A posição 2 "Oscar";
- A posição 3 "Joana";
- E assim por diante.

São necessárias várias operações apenas para remover um funcionário do array. Por isso, arrays não são tão interessantes para operações de inserção e remoção. Arrays são úteis quando temos um tamanho fixo e queremos trabalhar com busca baseada em índice, pois essa busca é muito rápida. Devemos priorizar o uso de arrays quando esses são nossos objetivos: busca e tamanho fixo.

**Conclusão**  
Para operações de inserção e remoção de elementos, é mais interessante trabalhar com outras estruturas de dados, que conheceremos em breve. Nos encontramos na próxima aula!

### Aula 1: Somando os valores do array - Desafio 1

Imagine que você é responsável por gerenciar doações de uma campanha solidária. Cada contribuição recebida é registrada em um sistema, mas para saber o valor total arrecadado, é necessário somar manualmente todas as entradas.

Seu desafio é criar um programa que automatize esse cálculo, percorrendo uma lista de valores e exibindo o montante final, garantindo que nenhum valor seja deixado de fora.

Crie um programa que:

- Declare um array de números representando doações.
- Utilize um loop para somar todos os valores contidos no array.
- Exiba o total calculado na tela.

Exemplo de entrada:

```csharp
double[] doacoes = {103.54, 259.72, 82.16, 154.87, 364.45, 14.49 };  
```

Saída esperada:

```csharp
Total de doações: 979,23
```

Opinião do instrutor

Nesta atividade, exploramos a iteração em arrays para acumular valores. Inicializamos uma variável total com 0 para servir como acumulador da soma. Em seguida, utilizamos um loop foreach para percorrer cada elemento do array doacoes, adicionando seu valor ao total a cada iteração.

O foreach simplifica o acesso aos elementos sem a necessidade de índices, focando diretamente nos valores armazenados. Por fim, o resultado é formatado e exibido com Console.WriteLine.

```csharp
double[] doacoes = { 103.54, 259.72, 82.16, 154.87, 364.45, 14.49 };
 
double total = 0;
 
foreach (double valor in doacoes)
{
    total += valor;
}
 
Console.WriteLine("Total de doações: " + total);
```

Teste diferentes valores no array, como doações maiores ou com mais casas decimais, e compartilhe sua solução no fórum! Mostre como você adaptou o código para outros cenários.

### Aula 1: Ordenando listas - Desafio 2

Você está desenvolvendo um sistema de gerenciamento para uma conferência de inovação tecnológica. Durante o credenciamento, os participantes precisam ser chamados em ordem alfabética para evitar congestionamentos. Porém, a lista inicial de inscritos foi cadastrada sem organização, e o comitê exige que o terceiro nome da lista ordenada seja destacado para uma cerimônia especial.

Crie um programa que:

- Declare um array com nomes de participantes.
- Ordene esse array alfabeticamente.
- Identifique e exiba o terceiro nome da lista após a ordenação.

Exemplo de entrada:

```csharp
string[] nomes = { "Fernanda", "Eduardo", "Gustavo", "Carolina", "Alice", "Bruno", "Daniel" };  
```

Saída esperada:

```csharp
O terceiro nome da lista após ordenação é: Carolina
```

Opinião do instrutor

Nesta atividade, trabalhamos com a ordenação de arrays. O método Array.Sort aplica uma ordenação reorganizando os elementos diretamente no array original. Após a ordenação, acessamos o terceiro elemento da lista com nomes[2], pois como o array começa na posição 0, o terceiro nome estará no índice 2. Ou seja:

- Primeiro nome - nomes[0]
- Segundo nome - nomes[1]
- Terceiro nome - nomes[2]

```csharp
string[] nomes = { "Fernanda", "Eduardo", "Gustavo", "Carolina", "Alice", "Bruno", "Daniel" };

Array.Sort(nomes);
 
Console.WriteLine($"O terceiro nome da lista após ordenação é: {nomes[2]}");
```

Teste com nomes em maiúsculas e minúsculas para ver o comportamento da ordenação. Poste no fórum seu resultado e compartilhe os testes que fez!

### Aula 1: Desvendando o código - Desafio 3

Você está explorando um cofre cibernético. Ao chegar ao último corredor, você se depara com um cadeado inteligente que protege um artefato tecnológico perdido. O mecanismo de segurança exige que você decifre um código baseado em posições dentro da sequência numérica 5, 42, 8, 11, 23, 1, 14, 30, 19, 27, 36, 2, 50, 7, 18, 9.

O sistema gera uma combinação única a cada acesso, onde:

O primeiro dígito é a posição onde o número 19 está localizado.
O segundo dígito é a posição onde o número 42 está localizado.
O terceiro dígito é a posição onde o número 7 está localizado.
Crie um programa que:

Declare um array de números inteiros.
Localize no array o índice de cada um dos números da combinação.
Exiba a combinação no console.
Exemplo de entrada:

```csharp
int[] numeros = { 5, 42, 8, 11, 23, 1, 14, 30, 19, 27, 36, 2, 50, 7, 18, 9 };
```

Saída esperada:

```csharp
Combinação do cadeado: 8-1-13
```

Opinião do instrutor

Nesta atividade, trabalhamos com o método Array.IndexOf() para localizar posições específicas em um array de números. Usamos três chamadas do método IndexOf() - uma para cada número da combinação (19, 42 e 7). Cada chamada retorna à posição onde aquele valor aparece pela primeira vez no array. É importante lembrar que:

- As posições começam em 0.
- Se um número não existir no array, o método retorna -1.
- O método sempre encontra a primeira ocorrência quando há números repetidos.
- O programa então junta essas três posições no formato "X-Y-Z" para formar o código do cadeado. Neste caso específico o resultado é: 8-1-13.

```csharp
int[] numeros = { 5, 42, 8, 11, 23, 1, 14, 30, 19, 27, 36, 2, 50, 7, 18, 9 };
 
int primeiroDigito = Array.IndexOf(numeros, 19);
int segundoDigito = Array.IndexOf(numeros, 42);
int terceiroDigito = Array.IndexOf(numeros, 7);
 
Console.WriteLine($"\nCombinação do cadeado: {primeiroDigito}-{segundoDigito}-{terceiroDigito}");
```

Poste no fórum seu resultado e compartilhe os testes que fez!

## Aula 2: Listas e Conjuntos

### Aula 2: Listas - Video 1

Transcrição  
Aprendemos que, para representar vários dados, podemos utilizar coleções. Conhecemos os arrays e observamos que eles têm uma limitação: o tamanho fixo. Portanto, não conseguimos inserir ou remover registros de forma dinâmica. Agora, vamos conhecer outras coleções que auxiliam nas operações de inserção e remoção de maneira mais eficiente: as listas e os conjuntos.

Trabalhando com listas e conjuntos
Declarando e inicializando listas
Iniciando pelas listas, elas são representadas na linguagem C# pelo tipo List.

Como declarar uma lista? Observe o exemplo de código abaixo:

List<string> listaFuncionarios = new List<string>
    {
        "João", "Maria", "Cláudia", "Oscar"
    };
Copiar código
Nesse caso, utilizamos uma List de string. O símbolo <> é chamado de generics. Entre eles, indicamos o tipo que queremos armazenar na lista. Uma vez declarado o tipo string, definimos o nome da variável e instanciamos a lista usando new. Após o new, passamos novamente List<string>, e depois inserimos entre chaves os dados que serão armazenados.

Há uma segunda forma de inicializar listas, utilizando o new separadamente, sem definir os registros, adicionando List<string>() ao final da declaração. Em seguida, podemos adicionar os elementos desejados ao longo do tempo na lista. No exemplo abaixo, criamos uma listaFuncionarios e adicionamos "João", depois "Maria", depois "Cláudia", e por último o "Oscar".

List<string> listaFuncionarios = new List<string>();

listaFuncionarios.Add("João");
listaFuncionarios.Add("Maria");
listaFuncionarios.Add("Cláudia");
listaFuncionarios.Add("Oscar");
Copiar código
Diferença entre listas e arrays
Qual é a diferença prática entre uma lista e um array?

A principal diferença é a inserção e remoção de dados de forma dinâmica. Isso está relacionado, principalmente, à implementação em baixo nível.

Em uma lista, é mais fácil inserir e remover elementos, mas a busca por índice, ponto forte dos arrays, não é tão eficiente, sendo mais custosa. Portanto, é interessante trabalhar com listas quando lidamos com dados dinâmicos que exigem operações de inserção e remoção frequentes.

Declarando e inicializando conjuntos
Além das listas, também temos os conjuntos, que são representados por HashSet em C#. A estrutura é semelhante: declaramos um HashSet<string> usando generics. Declaramos conforme o exemplo abaixo, com new HashSet<string>, passando todos os registros que queremos armazenar, ou criando um conjunto de funcionários e adicionando elementos.

HashSet<string> setFuncionarios = new HashSet<string>
{
    "João", "Maria", "Cláudia", "Oscar"
};
Copiar código
Também podemos declarar de forma dinâmica. Observe abaixo:

HashSet<string> setFuncionarios = new HashSet<string>();

setFuncionarios.Add("João");
setFuncionarios.Add("Maria");
setFuncionarios.Add("Cláudia");
setFuncionarios.Add("Oscar");
Copiar código
Diferença entre conjuntos e listas
Qual é a diferença entre um conjunto e uma lista?

No conjunto, não há garantia de que as inserções serão mantidas na ordem em que foram feitas.

Por exemplo: em uma lista, podemos recuperar um elemento na ordem em que foi inserido, como verificar que a segunda posição é "Maria". Já no conjunto, isso não é possível; só podemos buscar pelo elemento, sem saber explicitamente seu índice.

Além disso, não há dados repetidos no conjunto.

Se tentarmos adicionar um novo elemento chamado "Maria", não conseguiremos, pois lidamos com uma estrutura de dados baseada no conceito de conjunto numérico, que não permite repetições de elementos. Assim, no conjunto, teremos elementos únicos.

Praticando no Visual Studio
Agora, chegou o momento de praticar no Visual Studio. Temos uma lista de strings declarada diretamente no arquivo Program.cs. Observe abaixo o código:

Program.cs:

List<string> listaFuncionarios = new List<string>
        {
            "João", "Maria", "Cláudia", "Oscar"
        };
Copiar código
A primeira coisa que podemos fazer é uma busca pelo índice.

Essa busca é feita de forma idêntica ao que fizemos com o array: usamos Console.WriteLine() para exibir a posição 2 da lista de funcionários (listaFuncionarios).

List<string> listaFuncionarios = new List<string>
        {
            "João", "Maria", "Cláudia", "Oscar"
        };

Console.WriteLine(listaFuncionarios[2]);
Copiar código
Ao executar a aplicação, é retornado "Cláudia", assim como nos arrays.

A diferença é que, por trás, essa busca é mais custosa. Portanto, sempre priorizamos o array para realizar a busca, mas, caso não seja possível, utilizamos a lista.

Além disso, podemos querer saber o índice específico de um funcionário. Podemos fazer isso como antes, declarando um int indice. Para saber o índice, precisamos usar listaFuncionarios.IndexOf(). Há uma diferença: antes, precisávamos chamar a classe Array; agora, chamamos diretamente o método IndexOf() através da variável listaFuncionarios.

Por fim, vamos imprimir a posição com Console.WriteLine().

List<string> listaFuncionarios = new List<string>
        {
            "João", "Maria", "Cláudia", "Oscar"
        };

Console.WriteLine(listaFuncionarios[2]);
int indice = listaFuncionarios.IndexOf("Oscar");
Console.WriteLine($"Posição do Oscar = {indice}");
Copiar código
Ao executar a aplicação, conseguimos recuperar a posição, assim como nos arrays.

Retorno no terminal:

Cláudia
Posição do Oscar = 3
Copiar código
Ordenando e manipulando listas
Nosso próximo passo será ordenar a lista. Para ordenar, faremos de forma semelhante ao IndexOf(), mas trabalharemos com listaFuncionarios.Sort().

Com isso, conseguimos ordenar a lista. Vamos imprimir usando um foreach. Para cada string nome in listaFuncionarios, imprimimos o nome no console.

// código omitido

Console.WriteLine(listaFuncionarios[2]);
int indice = listaFuncionarios.IndexOf("Oscar");
Console.WriteLine($"Posição do Oscar = {indice}");

listaFuncionarios.Sort();
foreach(string nome in listaFuncionarios)
{
    Console.WriteLine(nome);
}
Copiar código
Ao executar, ele imprime os elementos ordenados, mantendo o mesmo comportamento.

Retorno no terminal:

Cláudia
Posição do Oscar = 3
Cláudia
João
Maria
Oscar
Copiar código
É importante destacar que conseguimos inserir e remover elementos facilmente. Vamos utilizar listaFuncionarios.Add() para adicionar as funcionárias Iasmin e Joana, por exemplo, mas podemos adicionar quantos funcionários quisermos.

Ao final, vamos reaproveitar o foreach utilizado anteriormente, para visualizar se todos os elementos foram inseridos. Para separar, usaremos vários traços.

// código omitido

Console.WriteLine("---------------");
listaFuncionarios.Add("Iasmin");
listaFuncionarios.Add("Joana");

foreach (string nome in listaFuncionarios)
{
    Console.WriteLine(nome);
}
Copiar código
Ao executar, temos a primeira lista com "Cláudia", "João", "Maria" e "Oscar". Abaixo, temos a mesma lista com os elementos inseridos: "Iasmin" e "Joana".

Da mesma forma, se quisermos remover elementos, podemos usar listaFuncionarios.Remove("Oscar"). Ao executar, teremos apenas a "Iasmin" adicionada, sem o funcionário "Oscar", que foi removido da lista.

// código omitido

Console.WriteLine("---------------");
listaFuncionarios.Add("Iasmin");
listaFuncionarios.Remove("Oscar");

foreach (string nome in listaFuncionarios)
{
    Console.WriteLine(nome);
}
Copiar código
Inversão de listas
Uma última operação útil com listas é inverter a lista.

Para isso, utilizamos o método Reverse(). Observe abaixo:

// código omitido

listaFuncionarios.Reverse();
foreach(string nome in listaFuncionarios)
{
    Console.WriteLine(nome);
}

// código omitido
Copiar código
No console, a inserção foi invertida, mostrando "Oscar", "Cláudia", "Maria" e "João".

Dessa forma, a lista foi invertida com base na inserção. Conseguimos preservar a ordem de inserção, o que não ocorreria trabalhando com arrays.

Conclusão
Com isso, concluímos a prática de manipulação de listas e conjuntos em C#!

### Aula 2:  - Video 2
### Aula 2:  - Video 3
### Aula 2:  - Video 4
### Aula 2:  - Video 5
### Aula 2:  - Video 6
### Aula 2:  - Video 7
### Aula 2:  - Video 8


