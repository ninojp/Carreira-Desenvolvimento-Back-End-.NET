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

```csharp
List<string> listaFuncionarios = new List<string>
    {
        "João", "Maria", "Cláudia", "Oscar"
    };
```

Nesse caso, utilizamos uma List de string. O símbolo <> é chamado de generics. Entre eles, indicamos o tipo que queremos armazenar na lista. Uma vez declarado o tipo string, definimos o nome da variável e instanciamos a lista usando new. Após o new, passamos novamente List`<string>`, e depois inserimos entre chaves os dados que serão armazenados.

Há uma segunda forma de inicializar listas, utilizando o new separadamente, sem definir os registros, adicionando List`<string>`() ao final da declaração. Em seguida, podemos adicionar os elementos desejados ao longo do tempo na lista. No exemplo abaixo, criamos uma listaFuncionarios e adicionamos "João", depois "Maria", depois "Cláudia", e por último o "Oscar".

```csharp
List<string> listaFuncionarios = new List<string>();

listaFuncionarios.Add("João");
listaFuncionarios.Add("Maria");
listaFuncionarios.Add("Cláudia");
listaFuncionarios.Add("Oscar");
```

**Diferença entre listas e arrays**  
Qual é a diferença prática entre uma lista e um array?

A principal diferença é a inserção e remoção de dados de forma dinâmica. Isso está relacionado, principalmente, à implementação em baixo nível.

Em uma lista, é mais fácil inserir e remover elementos, mas a busca por índice, ponto forte dos arrays, não é tão eficiente, sendo mais custosa. Portanto, é interessante trabalhar com listas quando lidamos com dados dinâmicos que exigem operações de inserção e remoção frequentes.

**Declarando e inicializando conjuntos**  
Além das listas, também temos os conjuntos, que são representados por HashSet em C#. A estrutura é semelhante: declaramos um HashSet`<string>` usando generics. Declaramos conforme o exemplo abaixo, com new HashSet`<string>`, passando todos os registros que queremos armazenar, ou criando um conjunto de funcionários e adicionando elementos.

```csharp
HashSet<string> setFuncionarios = new HashSet<string>
{
    "João", "Maria", "Cláudia", "Oscar"
};
```

Também podemos declarar de forma dinâmica. Observe abaixo:

```csharp
HashSet<string> setFuncionarios = new HashSet<string>();

setFuncionarios.Add("João");
setFuncionarios.Add("Maria");
setFuncionarios.Add("Cláudia");
setFuncionarios.Add("Oscar");
```

**Diferença entre conjuntos e listas**  
Qual é a diferença entre um conjunto e uma lista?

No conjunto, não há garantia de que as inserções serão mantidas na ordem em que foram feitas.

Por exemplo: em uma lista, podemos recuperar um elemento na ordem em que foi inserido, como verificar que a segunda posição é "Maria". Já no conjunto, isso não é possível; só podemos buscar pelo elemento, sem saber explicitamente seu índice.

Além disso, não há dados repetidos no conjunto.

Se tentarmos adicionar um novo elemento chamado "Maria", não conseguiremos, pois lidamos com uma estrutura de dados baseada no conceito de conjunto numérico, que não permite repetições de elementos. Assim, no conjunto, teremos elementos únicos.

**Praticando no Visual Studio**  
Agora, chegou o momento de praticar no Visual Studio. Temos uma lista de strings declarada diretamente no arquivo Program.cs. Observe abaixo o código:

Program.cs:

```csharp
List<string> listaFuncionarios = new List<string>
        {
            "João", "Maria", "Cláudia", "Oscar"
        };
```

A primeira coisa que podemos fazer é uma busca pelo índice.

Essa busca é feita de forma idêntica ao que fizemos com o array: usamos Console.WriteLine() para exibir a posição 2 da lista de funcionários (listaFuncionarios).

```csharp
List<string> listaFuncionarios = new List<string>
        {
            "João", "Maria", "Cláudia", "Oscar"
        };
Console.WriteLine(listaFuncionarios[2]);
```

Ao executar a aplicação, é retornado "Cláudia", assim como nos arrays.

A diferença é que, por trás, essa busca é mais custosa. Portanto, sempre priorizamos o array para realizar a busca, mas, caso não seja possível, utilizamos a lista.

Além disso, podemos querer saber o índice específico de um funcionário. Podemos fazer isso como antes, declarando um int indice. Para saber o índice, precisamos usar listaFuncionarios.IndexOf(). Há uma diferença: antes, precisávamos chamar a classe Array; agora, chamamos diretamente o método IndexOf() através da variável listaFuncionarios.

Por fim, vamos imprimir a posição com Console.WriteLine().

```csharp
List<string> listaFuncionarios = new List<string>
        {
            "João", "Maria", "Cláudia", "Oscar"
        };

Console.WriteLine(listaFuncionarios[2]);
int indice = listaFuncionarios.IndexOf("Oscar");
Console.WriteLine($"Posição do Oscar = {indice}");
```

Ao executar a aplicação, conseguimos recuperar a posição, assim como nos arrays.

Retorno no terminal:

```csharp
Cláudia
Posição do Oscar = 3
```

**Ordenando e manipulando listas**  
Nosso próximo passo será ordenar a lista. Para ordenar, faremos de forma semelhante ao IndexOf(), mas trabalharemos com listaFuncionarios.Sort().

Com isso, conseguimos ordenar a lista. Vamos imprimir usando um foreach. Para cada string nome in listaFuncionarios, imprimimos o nome no console.

```csharp
// código omitido
Console.WriteLine(listaFuncionarios[2]);
int indice = listaFuncionarios.IndexOf("Oscar");
Console.WriteLine($"Posição do Oscar = {indice}");

listaFuncionarios.Sort();
foreach(string nome in listaFuncionarios)
{
    Console.WriteLine(nome);
}
```

Ao executar, ele imprime os elementos ordenados, mantendo o mesmo comportamento.

Retorno no terminal:

```csharp
Cláudia
Posição do Oscar = 3
Cláudia
João
Maria
Oscar
```

É importante destacar que conseguimos inserir e remover elementos facilmente. Vamos utilizar listaFuncionarios.Add() para adicionar as funcionárias Iasmin e Joana, por exemplo, mas podemos adicionar quantos funcionários quisermos.

Ao final, vamos reaproveitar o foreach utilizado anteriormente, para visualizar se todos os elementos foram inseridos. Para separar, usaremos vários traços.

```csharp
// código omitido
Console.WriteLine("---------------");
listaFuncionarios.Add("Iasmin");
listaFuncionarios.Add("Joana");

foreach (string nome in listaFuncionarios)
{
    Console.WriteLine(nome);
}
```

Ao executar, temos a primeira lista com "Cláudia", "João", "Maria" e "Oscar". Abaixo, temos a mesma lista com os elementos inseridos: "Iasmin" e "Joana".

Da mesma forma, se quisermos remover elementos, podemos usar listaFuncionarios.Remove("Oscar"). Ao executar, teremos apenas a "Iasmin" adicionada, sem o funcionário "Oscar", que foi removido da lista.

```csharp
// código omitido
Console.WriteLine("---------------");
listaFuncionarios.Add("Iasmin");
listaFuncionarios.Remove("Oscar");

foreach (string nome in listaFuncionarios)
{
    Console.WriteLine(nome);
}
```

**Inversão de listas**  
Uma última operação útil com listas é inverter a lista.

Para isso, utilizamos o método Reverse(). Observe abaixo:

```csharp
// código omitido
listaFuncionarios.Reverse();
foreach(string nome in listaFuncionarios)
{
    Console.WriteLine(nome);
}

// código omitido
```

No console, a inserção foi invertida, mostrando "Oscar", "Cláudia", "Maria" e "João".

Dessa forma, a lista foi invertida com base na inserção. Conseguimos preservar a ordem de inserção, o que não ocorreria trabalhando com arrays.

**Conclusão**  
Com isso, concluímos a prática de manipulação de listas e conjuntos em C#!

### Aula 2: Conjuntos - Video 2

Transcrição  
Neste vídeo, falaremos sobre conjuntos.

Trabalhando com conjuntos

**Utilizando o HashSet em C#**  
Começaremos explorando o uso de um HashSet em C#.

Primeiramente, criamos e inicializamos o HashSet de funcionários. Diferente de uma lista, onde podemos declarar e inicializar de uma vez, adicionamos os elementos um a um.

Program.cs:

```csharp
// código omitido
HashSet<string> setFuncionarios = new HashSet<string>();

setFuncionarios.Add("João");
setFuncionarios.Add("Maria");
setFuncionarios.Add("Cláudia");
setFuncionarios.Add("Oscar");
```

**Entendendo as limitações do HashSet**  
Com o HashSet inicializado, podemos testar algumas operações.

Primeiro, vamos tentar buscar um elemento pelo índice. No entanto, como discutido, isso não é possível em um HashSet, porque ele não mantém a ordem de inserção.

```csharp
// código omitido

HashSet<string> setFuncionarios = new HashSet<string>();

setFuncionarios.Add("João");
setFuncionarios.Add("Maria");
setFuncionarios.Add("Cláudia");
setFuncionarios.Add("Oscar");

Console.WriteLine(setFuncionarios[2]);
```

Assim, o compilador informa que não é possível aplicar a indexação a uma expressão do tipo HashSet, confirmando que não podemos acessar elementos por índice.

**Percorrendo o HashSet com foreach**  
No entanto, podemos tentar percorrer o HashSet utilizando um loop foreach para imprimir seus elementos. Entre os parênteses do laço foreach, usaremos string nome in setFuncionarios, adicionando ao escopo do bloco um Console.WriteLine() recebendo a variável nome.

```csharp
// código omitido
HashSet<string> setFuncionarios = new HashSet<string>();

setFuncionarios.Add("João");
setFuncionarios.Add("Maria");
setFuncionarios.Add("Cláudia");
setFuncionarios.Add("Oscar");

foreach (string nome in setFuncionarios)
{
    Console.WriteLine(nome);
}
```

Ao executar, visualizamos os elementos impressos na ordem que inserimos:

Retorno no terminal:

```csharp
João
Maria
Cláudia
Oscar
```

Observação: o cenário anterior é possível, mas a ordem pode não ser a mesma da inserção, devido à forma como o HashSet armazena os dados na memória.

**Adicionando e removendo elementos**  
Agora, vamos testar adicionar um novo elemento ao HashSet:

```csharp
// código omitido
HashSet<string> setFuncionarios = new HashSet<string>();

setFuncionarios.Add("João");
setFuncionarios.Add("Maria");
setFuncionarios.Add("Cláudia");
setFuncionarios.Add("Oscar");

setFuncionarios.Add("Joana");

foreach (string nome in setFuncionarios)
{
    Console.WriteLine(nome);
}
```

Ao executar, observamos que "Joana" foi adicionada ao conjunto.

Retorno no terminal:

```csharp
João
Maria
Cláudia
Oscar
Joana
```

Da mesma forma, é possível remover elementos. Vamos remover "João":

```csharp
// código omitido
setFuncionarios.Remove("João");

foreach (string nome in setFuncionarios)
{
    Console.WriteLine(nome);
}
```

Após a remoção, "João" não estará mais presente no conjunto.

Retorno no terminal:

```csharp
Maria
Cláudia
Oscar
```

Se tentarmos adicionar "João" novamente, o HashSet não permitirá duplicatas, então ele simplesmente não fará nada se "João" já estiver presente.

```csharp
// código omitido
setFuncionarios.Add("João");
setFuncionarios.Add("Maria");
setFuncionarios.Add("Cláudia");
setFuncionarios.Add("Oscar");

setFuncionarios.Add("João");

foreach (string nome in setFuncionarios)
{
    Console.WriteLine(nome);
}
```

Retorno no terminal:

```csharp
João
Maria
Cláudia
Oscar
```

Isso demonstra a lógica dos conjuntos, onde duplicatas não são permitidas.

**Conclusão**  
Discutimos a importância de escolher a estrutura de dados correta para o problema que deve ser resolvido. O HashSet é útil para verificar a existência de um elemento rapidamente, sem se preocupar com a ordem ou duplicatas. Na sequência, abordaremos outra estrutura de dados que também é útil para buscas de dados. Aguardamos você no próximo vídeo!

### Aula 2: Organizando elementos únicos - Desafio 1

Imagine que você está desenvolvendo um placar online para um torneio de games, onde milhares de jogadores competem em tempo real. Para evitar poluição visual e garantir uma experiência limpa aos espectadores, o sistema deve exibir apenas as pontuações únicas, sem repetições, e em ordem crescente.

Crie um programa que:

- Escolha a melhor estrutura para armazenar os scores.
- Garanta que os dados estejam ordenados.
- Exiba os valores no console.

Exemplo de entrada:

```csharp
scores.Add(150);
scores.Add(90);
scores.Add(200);
scores.Add(120);
scores.Add(150);
scores.Add(80);
scores.Add(180);
scores.Add(200);
```

Saída esperada:

Scores únicos em ordem crescente:

```csharp
80
90
120
150
180
200
```

Opinião do instrutor

Nesta atividade, exploramos como o HashSet`<int>` assegura a unicidade dos scores ao descartar automaticamente valores repetidos durante a inserção com Add(). Como o HashSet não mantém ordem interna, foi necessário convertê-lo para uma List`<int>` usando new List`<int>`(scores), permitindo a aplicação do método Sort().

```csharp
HashSet<int> scores = new HashSet<int>();
 
scores.Add(150);
scores.Add(90);
scores.Add(200);
scores.Add(120);
scores.Add(150);
scores.Add(80);
scores.Add(180);
scores.Add(200);
 
List<int> scoresOrdenados = new List<int>(scores);
scoresOrdenados.Sort();
 
Console.WriteLine("Scores únicos em ordem crescente:");
foreach (int score in scoresOrdenados)
{
    Console.WriteLine(score);
}
```

E aí, conseguiu resolver? Compartilhe seu código no fórum e conte como foi sua experiência!

### Aula 2: Revelando mensagens - Desafio 2

Você está desenvolvendo um sistema de recompensas para uma plataforma de ensino. Quando alunos completam desafios difíceis, eles recebem mensagens secretas que só podem ser lidas quando decifradas. Para decifrar uma mensagem, é preciso invertê-la.

A mensagem atual é:

'o', 'd', 'n', 'u', 'm', ' ', 'á', 'l', 'o'.

Crie um programa que:

- Inicialize uma lista com os caracteres descritos acima
- Decifre a mensagem dada pelos caracteres descritos
- Exiba o resultado

Saída esperada:

```csharp
o
l
á
 
m
u
n
d
o
```

Opinião do instrutor

Nesta atividade, exploramos a manipulação de listas com foco na inversão de elementos. O método Reverse() foi utilizado para reorganizar a ordem dos caracteres, transformando uma sequência aparentemente sem sentido em uma mensagem legível quando exibida de trás para frente.

Observe que cada caractere (incluindo espaços e acentuações) foi tratado como um elemento independente na lista. Ao percorrermos a lista invertida com um loop simples, cada elemento é impresso em uma linha separada, revelando progressivamente a mensagem oculta.

```csharp
List<char> caracteres = new List<char>
        {
            'o', 'd', 'n', 'u', 'm', ' ', 'á', 'l', 'o'
        };
 
 
caracteres.Reverse();
 
foreach (char caracter in caracteres)
{
    Console.WriteLine(caracter);
}
```

E aí, curtiu o efeito de espelho? Compartilhe no fórum a frase que você criou e como ficou depois de invertida!

### Aula 2: Manipulando listas - Desafio 3

Imagine que você está desenvolvendo um sistema de sorteio para um evento beneficente. Cada participante cadastrou seu nome, e agora você precisa manipular a lista de forma aleatória para que os nomes fiquem embaralhados.

Crie um programa que:

- Declare uma lista de nomes.
- Organize a lista em ordem alfabética.
- Inverta a ordem da lista.
- Remova o primeiro elemento e o adicione novamente na lista.
- Agora verifique quem está no índice 3 da lista e exiba o nome no console.

Exemplo de entrada:

```csharp
List<string> nomes = new List<string> { "Ana", "Carlos", "Mariana", "João", "Lúcia" };
```

Saída esperada:

```csharp
Lista original:
Ana, Carlos, Mariana, João, Lúcia
 
Após Sort (ordem alfabética):
Ana, Carlos, João, Lúcia, Mariana
 
Após Reverse (ordem invertida):
Mariana, Lúcia, João, Carlos, Ana
 
Após remover o primeiro e adicioná-lo no fim:
Lúcia, João, Carlos, Ana, Mariana
 
A pessoa sorteada foi: Ana
```

Opinião do instrutor

Nesta atividade, exploramos métodos para manipulação de listas em C#:

Sort() reorganiza os elementos em ordem alfabética. Reverse() inverte a ordem da lista. Remove() para remover um dos elementos. Add() reinsere o nome removido ao final da lista.

```csharp
List<string> nomes = new List<string> { "Ana", "Carlos", "Mariana", "João", "Lúcia" };
 
Console.WriteLine("Lista original:");
Console.WriteLine(string.Join(", ", nomes));
 
nomes.Sort();
Console.WriteLine("\nApós Sort (ordem alfabética):");
Console.WriteLine(string.Join(", ", nomes));
 
nomes.Reverse();
Console.WriteLine("\nApós Reverse (ordem invertida):");
Console.WriteLine(string.Join(", ", nomes));
 
string primeiroNome = nomes[0];
nomes.Remove(primeiroNome);
nomes.Add(primeiroNome);
Console.WriteLine("\nApós remover o primeiro e adicioná-lo no fim:");
Console.WriteLine(string.Join(", ", nomes));
 
Console.WriteLine($"\nA pessoa sorteada foi: {nomes[3]}");
```

Descreva no fórum seu experimento e os resultados que encontrou!

### Aula 2: Consolidando listas de produtos - Desafio 4

Imagine que você é responsável por organizar o inventário de uma loja de eletrônicos. Durante uma atualização de estoque, surgiu a necessidade de unir duas listas de produtos em uma única lista para facilitar a gestão. Seu objetivo é criar um programa que adicione os itens de uma lista secundária à lista principal.

Crie um programa que:

- Declare duas listas distintas de produtos.
- Adicione todos os elementos da lista secundária na lista principal.
- Exiba a lista principal com todos os produtos.

Exemplo de entrada:

```csharp
List<string> produtosPrincipal = new List<string> { "Mouse", "Teclado", "Monitor", “Joystick”};  
List<string> produtosSecundaria = new List<string> { "Headset", "Webcam", "Smartphone", “Mousepad” };  
```

Saída esperada:

```csharp
Lista consolidada:
Mouse
Teclado
Monitor
Joystick
Headset
Webcam
Smartphone
Mousepad
```

Opinião do instrutor

Nesta atividade, exploramos a manipulação de listas utilizando o método Add em conjunto com um loop foreach. O objetivo foi transferir elementos de uma lista para outra, garantindo que todos os itens fossem incluídos.

foreach permite percorrer cada elemento da lista secundária individualmente.
Add insere o item atual da iteração na lista principal.

```csharp
List<string> produtosPrincipal = new List<string> { "Mouse", "Teclado", "Monitor", "Joystick" };
 
List<string> produtosSecundaria = new List<string> { "Headset", "Webcam", "Smartphone", "Mousepad" };
 
foreach (string produto in produtosSecundaria)
{
    produtosPrincipal.Add(produto);
}
 
Console.WriteLine("Lista consolidada:");
foreach (string produto in produtosPrincipal)
{
    Console.WriteLine(produto);
}
```

Conte no fórum como resolveu esse exercício, vamos adorar acompanhar sua jornada!

## Aula 3: Dicionários

### Aula 3: Dicionários - Video 1

Transcrição  
Neste vídeo, começaremos a conversar sobre dicionários.

Trabalhando com dicionários

Para começar a discussão, vamos pensar em um exemplo. Imagine que trabalhamos em uma loja de eletrônicos. Nessa loja, há vários produtos, e cada um deles possui um ID e um nome.

Observe a tabela de produtos abaixo:

|ID|Nome|
|---|---|
|0|Teclado|
|1|Cadeira gamer|
|2|Notebook|
|3|Teclado|
|4|Mouse|

O ID é único. No exemplo acima, temos IDs que vão de 0 em diante.

Já o nome pode se repetir a depender da situação. Por exemplo: temos o produto 0, que é um teclado, e o produto 3, que também é um teclado. As informações se repetem.

**Representando dados com listas e dicionários**
Para representar os dados e trabalhar com eles futuramente, podemos inseri-los em uma lista e usar os índices de forma paralela. Na lista, o índice começa em 0 e vai até o limite desejado. Da mesma forma, na loja de eletrônicos, o ID começa em 0 e vai até 4, permitindo traçar um paralelo.

No entanto, se tivermos IDs aleatórios, não conseguiremos mais traçar o paralelo. Não faz sentido criar um array com tantas posições para buscar pela posição 4.587.000, por exemplo.

|ID|Nome|
|---|---|
|4587963|Teclado|
|3374561|Cadeira gamer|
|2456987|Notebook|
|6356984|Teclado|
|8647921|Mouse|

Para representar os dados de modo que seja possível buscar através do ID sem perder a informação do produto, podemos usar dicionários, onde teremos duas informações relevantes:

A chave;  
E o valor.

A chave é única e, no nosso exemplo, será o ID. Já o valor pode se repetir e, neste caso, será o nome. Em um dicionário, geralmente, fazemos buscas através do ID, que é único, permitindo pegar exatamente o valor associado a uma chave.

**Entendendo a estrutura de dicionários**  
Para representar um dicionário em C♯, utilizamos a seguinte estrutura:

```csharp
Dictionary<int, string> produtos = new Dictionary<int, string>
    {
        { 4587963, "Teclado" },
        { 3374561, "Cadeira gamer" },
        { 2456987, "Notebook" },
        { 6356984, "Teclado" },
        { 8647921, "Mouse" },
    };
```

Novamente, trabalhamos com generics (<>). O dicionário guarda tanto a chave quanto o valor, e precisamos especificar os tipos a serem guardados. No nosso caso, os IDs são inteiros e os valores são strings. Assim, declaramos um dicionário (Dictionary<>) de int e string.

Em seguida, instanciamos o dicionário da mesma forma que fazemos com listas.

Note que declaramos o Dictionary e passamos os pares de dados que queremos guardar. Esses pares são dados por chaves internas entre chaves externas.

Abrimos as primeiras chaves para indicar que vamos guardar dados no dicionário e, para cada linha da tabela, abrimos e fechamos chaves para inserir os dados.

Abaixo, podemos conferir como criar um dicionário e adicionar elementos de maneira dinâmica. Inicializamos o dicionário com new e adicionamos os pares com produtos.Add(). Assim, não precisamos das chaves para representá-los; apenas passamos o ID (chave) e o valor (nome).

```csharp
Dictionary<int, string> produtos = new Dictionary<int, string>();
produtos.Add(4587963, "Teclado");
produtos.Add(3374561, "Cadeira gamer");
produtos.Add(2456987, "Notebook");
produtos.Add(6356984, "Teclado");
produtos.Add(8647921, "Mouse");
```

**Praticando com dicionários no Visual Studio**  
Vamos praticar o uso de dicionários? No Visual Studio, já temos a declaração do Dictionary, conforme exibido acima. Criamos e inicializamos a variável, passando os valores desejados. A grande vantagem do Dictionary é a capacidade de realizar buscas através da chave.

Program.cs:

```csharp
Dictionary<int, string> produtos = new Dictionary<int, string>
    {
        { 4587963, "Teclado" },
        { 3374561, "Cadeira gamer" },
        { 2456987, "Notebook" },
        { 6356984, "Teclado" },
        { 8647921, "Mouse" },
    };
```

As chaves em um dicionário podem ser inteiros, diferenciados ou strings. Portanto, essas chaves podem ser elementos personalizados para realizar buscas.

No exemplo dado, a personalização são números inteiros que não necessariamente estão em ordem. Não conseguimos indexar como em uma lista, por exemplo.

Para realizar a busca pela chave, podemos usar Console.WriteLine(), onde iremos imprimir o nome correspondente à chave 3374561. Ao acessar produtos nessa posição específica, visualizamos o elemento cujo valor está associado a ela.

```csharp
Dictionary<int, string> produtos = new Dictionary<int, string>
    {
        { 4587963, "Teclado" },
        { 3374561, "Cadeira gamer" },
        { 2456987, "Notebook" },
        { 6356984, "Teclado" },
        { 8647921, "Mouse" },
    }

Console.WriteLine(produtos[3374561]);
```

No dicionário, conseguimos fazer uma busca indexada usando a chave, da mesma forma que fazíamos no array e na lista. Ao executar, é exibido "Cadeira gamer".

Se quisermos mostrar o primeiro produto "Teclado", precisamos buscar pelo primeiro elemento do dicionário, ou seja, pelo primeiro índice. Para acessar o quarto elemento, buscamos pelo ID.

**Construindo um dicionário de tradução**  
Agora, vamos pensar em um dicionário de consulta.

Em um dicionário de tradução, por exemplo, teríamos o nome em português e buscaríamos a tradução em inglês, ou vice-versa. Se houver um tradutor de português para inglês, buscamos pela chave, que é o nome em português, enquanto o valor será a tradução em inglês.

Para representar esse dicionário no código, vamos reaproveitar o dicionário anterior. Criaremos um dicionário de string para string, chamado palavras, e inicializaremos esse dicionário também utilizando string e string. Em seguida, criaremos entre chaves os pares. Por exemplo: o nome "olá" terá a tradução "hello". Também teremos "mundo" como "world".

Assim, criamos um breve dicionário de português para inglês.

```csharp
// código omitido
Dictionary<string, string> palavras = new Dictionary<string, string>
{
    { "olá", "hello" },
    { "mundo", "world" }
};
```

Se quisermos saber a tradução de "olá", podemos usar Console.WriteLine() e uma interpolação para informar o seguinte: $"A tradução de olá é {palavras["olá"]}".

```csharp
// código omitido
Dictionary<string, string> palavras = new Dictionary<string, string>
{
    { "olá", "hello" },
    { "mundo", "world" }
};

Console.WriteLine($"A tradução de olá é {palavras["olá"]}");
```

Ao executar, recebemos que a tradução de "olá" é "hello". Dessa forma, conseguimos traçar um paralelo entre o dicionário do mundo real e o dicionário da linguagem de programação.

Retorno no terminal:

```csharp
Cadeira gamer
A tradução de olá é hello
```

**Conclusão**  
Usamos a estrutura de dicionário para representar dados e realizar buscas de forma personalizada, diferente do padrão de listas. Podemos fazer buscas com inteiros não sequenciais, strings e outros tipos. Além disso, conhecemos coleções diferentes para objetivos distintos.

Agora é o momento de praticar para entender qual delas servirá para o seu problema do dia a dia. Na sequência, teremos uma série de exercícios para evoluir seus conhecimentos!

### Aula 3: Listando os alunos - Desafio 1

Imagine que você é responsável por organizar as notas finais de uma turma em um sistema acadêmico. Cada aluno possui um nome único e uma nota que pode variar em precisão (como 8.5 ou 7.75). Seu desafio é criar uma estrutura que armazene essas informações de forma eficiente e as exiba de maneira clara para futuras consultas.

Crie um programa que:

- Declare um dicionário com as informações de nome e nota de cada aluno
- Use um loop para iterar sobre essas notas
- Exiba as notas na tela

Como iterar um dicionário? Antes de exibir as notas, é importante entender como o dicionário armazena os dados. Um KeyValuePair<tipo 1, tipo 2> representa um par de elementos onde:

- tipo 1 é a chave (no caso, o nome do aluno).
- tipo 2 é o valor associado (a nota).

Quando percorremos o dicionário com foreach, cada iteração retorna um KeyValuePair contendo um nome e sua respectiva nota, que podem ser acessados pelas propriedades Key e Value. Por exemplo, no caso da loja de eletrônicos, visto em vídeo:

```csharp
foreach (KeyValuePair<tipo 1, tipo 2> produto in produtos)  
{  
     Console.WriteLine($"ID: {produto.Key} - Nome: {produto.Value}");
}  
```

Ou, podemos simplificar usando var:

```csharp
foreach (var produto in produtos)  
{  
    Console.WriteLine($"ID: {produto.Key} - Nome: {produto.Value}");
}  
```

Exemplo de entrada:

```csharp
notas.Add("Ana", 8.75m);
notas.Add("Bruno", 6.90m);
notas.Add("Clara", 9.25m);
```

Saída esperada:

```csharp
Aluno: Ana - Nota: 8,75
Aluno: Bruno - Nota: 6,90
Aluno: Clara - Nota: 9,25
```

Opinião do instrutor

Nesta atividade, o dicionário foi escolhido para mapear nomes a notas porque ele permite associar valores únicos (chaves) a dados específicos de forma direta. O tipo decimal garante que operações com as notas mantenham precisão. Durante a exibição, o foreach percorre cada KeyValuePair, extraindo a chave (aluno.Key) e o valor (aluno.Value) para formatar a saída.

```csharp
Dictionary<string, decimal> notas = new Dictionary<string, decimal>();
 
notas.Add("Ana", 8.75m);
notas.Add("Bruno", 6.90m);
notas.Add("Clara", 9.25m);
 
foreach (KeyValuePair<string, decimal> aluno in notas)
{
    Console.WriteLine($"Aluno: {aluno.Key} - Nota: {aluno.Value}");
}
```

Conte no fórum como resolveu esse exercício, vamos adorar acompanhar sua jornada!

### Aula 3: Gerenciando itens no inventário - Desafio 2

Imagine que você está desenvolvendo um sistema de inventário para um jogo. Seu objetivo é gerenciar os itens que o jogador carrega, garantindo que o inventário seja atualizado corretamente quando itens forem removidos ou novos itens forem adquiridos.

Crie um programa que:

- Inicialize um dicionário com itens.
- Remova um item específico do inventário.
- Adicione um novo item ao inventário.
- Exiba a lista atualizada de itens.

Exemplo de entrada:

```csharp
Dictionary<int, string> inventario = new Dictionary<int, string>()
        {
            { 1, "Espada Longa" },
            { 2, "Arco Curto" },
            { 3, "Escudo de Ferro" }
        };
```

Saída esperada:

```csharp
Itens no inventário inicial:
ID: 1 - Espada Longa
ID: 2 - Arco Curto
ID: 3 - Escudo de Ferro
---------------------
Itens no inventário atualizado:
ID: 1 - Espada Longa
ID: 4 - Poção de Vida
ID: 3 - Escudo de Ferro
```

Opinião do instrutor

Nesta atividade, exploramos o uso do Dictionary para gerenciar um conjunto de itens. Primeiro, inicializamos o dicionário com alguns itens, cada um associado a um ID único. Em seguida, removemos um item usando o método Remove, que exclui a entrada com base na chave fornecida. Depois, adicionamos um novo item ao dicionário usando o método Add, garantindo que a chave (ID) seja única para evitar conflitos. Por fim, percorremos o dicionário com um loop foreach para exibir os itens atualizados.

```csharp
Dictionary<int, string> inventario = new Dictionary<int, string>()
        {
            { 1, "Espada Longa" },
            { 2, "Arco Curto" },
            { 3, "Escudo de Ferro" }
        };
 
Console.WriteLine("Itens no inventário inicial:");
foreach (var item in inventario)
{
    Console.WriteLine($"ID: {item.Key} - {item.Value}");
}
 
Console.WriteLine("---------------------");
 
inventario.Remove(2);
 
inventario.Add(4, "Poção de Vida");
 
Console.WriteLine("Itens no inventário atualizado:");
foreach (var item in inventario)
{
    Console.WriteLine($"ID: {item.Key} - {item.Value}");
}
```

Conte no fórum o seu raciocínio. Ver seu caminho até a solução é sempre muito bacana!

### Aula 3: Manipulando dicionários - Desafio 3

Você está desenvolvendo um sistema de gerenciamento de tarefas para uma equipe de desenvolvimento. Os membros do time podem adicionar suas tarefas diárias, mas, ao final do sprint, todas as tarefas concluídas são removidas do quadro, dando espaço para novas atividades.

Você é responsável por implementar essa lógica usando um dicionário para armazenar as tarefas e seus responsáveis. O programa deve limpar o dicionário simulando o fim do sprint, adicionar novas tarefas para o próximo ciclo e, por fim, listar todas as atividades atualizadas para a equipe.

Crie um programa que:

- Inicialize um dicionário com algumas tarefas
- Remova todas as tarefas do dicionário
- Adicione novas tarefas
- Liste as novas tarefas

Dica: O método Clear() esvazia completamente o dicionário, removendo todos os itens de uma só vez. Isso é útil quando precisamos reiniciar uma coleção sem criar uma nova instância.

Exemplo de entrada:

Tarefas antigas:

```csharp
Dictionary<string, string> tarefas = new Dictionary<string, string>()  
{  
{ "Refatorar módulo de login", "Ana" },  
{ "Testar API de pagamentos", "Pedro" }  
};  
```

Novas tarefas:

```csharp
tarefas.Add("Implementar autenticação OAuth", "João");  
tarefas.Add("Otimizar consultas SQL", "Maria");  
tarefas.Add("Atualizar documentação", "Carlos");
```

Saída esperada:

```csharp
Tarefas do próximo sprint:
- Implementar autenticação OAuth: João
- Otimizar consultas SQL: Maria
- Atualizar documentação: Carlos
```

Opinião do instrutor

Nesta atividade, exploramos a manipulação de dicionários, focando em duas operações principais:

Clear() – Remove todos os pares chave-valor, útil para reinicializar estruturas de dados sem realocação.
foreach – Percorre o dicionário de forma ordenada, garantindo que cada entrada seja processada.

```csharp
Dictionary<string, string> tarefas = new Dictionary<string, string>()
        {
            { "Refatorar módulo de login", "Ana" },
            { "Testar API de pagamentos", "Pedro" }
        };
 
tarefas.Clear();
 
tarefas.Add("Implementar autenticação OAuth", "João");
tarefas.Add("Otimizar consultas SQL", "Maria");
tarefas.Add("Atualizar documentação", "Carlos");
 
Console.WriteLine("Tarefas do próximo sprint:");
foreach (var tarefa in tarefas)
{
    Console.WriteLine($"- {tarefa.Key}: {tarefa.Value}");
}
```

Estamos de olho no fórum. Compartilhe sua solução e vamos crescer juntos!

### Aula 3: Conclusão

Parabéns por concluir este curso! Ao longo desta jornada, você adquiriu conhecimento prático e aplicou conceitos de programação em C#, com foco no uso de coleções. Agora, você pode:

- Trabalhar com diferentes tipos de coleções (arrays, listas, dicionários e hashsets) em C#.
- Manipular e transformar coleções usando métodos como Sort(), Reverse(), IndexOf() e Clear().
- Iterar e manipular elementos em coleções usando loops e métodos de busca.

Quer continuar explorando a programação em C#? Recomendamos a [Formação C# e Orientação a Objetos: coleções, arquivos e bibliotecas.](https://cursos.alura.com.br/formacao-avancando-c-sharp)

Nos vemos nos próximos cursos práticos!
