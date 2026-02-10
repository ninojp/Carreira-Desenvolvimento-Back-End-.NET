# Curso Alura Praticando C#: condicionais com if/else e switch/case

## Aula 1 - if/else

### Aula 1 - Apresentação - Vídeo 1

Transcrição  
Boas-vindas! Meu nome é Iasmin Araújo, sou instrutora na Escola de Programação da Alura, e irei te acompanhar ao longo dessa jornada de aprendizagem.

Audiodescrição: Iasmin se descreve como uma mulher branca, com cabelo castanho-escuro longo e liso repartido ao meio, sobrancelhas castanho-escuras, e olhos verdes. Ela veste uma blusa azul-marinho, e está sentada em uma cadeira preta e rosa em frente a microfone cinza, com uma parede clara ao fundo iluminada em gradiente azul.

O que vamos aprender?  
O objetivo deste curso é praticar as condicionais. Para isso, abordaremos diversos tópicos:

O que são condicionais e como elas funcionam;

- if e else, palavras-chave utilizadas para trabalhar com condicionais;
- Operadores lógicos e relacionais, utilizados nos blocos if e else;
- Expressões do tipo switch-case e como utilizá-las.

Conclusão

Temos diversos tópicos bastante importantes quando falamos sobre lógica de programação, mas também é interessante praticar todos esses conceitos. Para isso, na sequência, vamos começar a nos aprofundar nos tópicos sobre condicionais mencionados.

Bons estudos e até o próximo vídeo!

### Aula 1 - O que esperar deste curso?

Antes de mergulharmos no código, que tal alinharmos as expectativas?

O que significa um curso prático?

Já se pegou pensando — será que consigo aplicar o que aprendi na prática? Este curso é a sua resposta. Aqui, o foco é colocar a mão no código, resolver problemas e testar seu conhecimento de forma ativa. Você terá:

- Vídeo de revisão do conteúdo
- Material de apoio
- Desafios de código

Pré-requisitos  
É importante ter concluído o [curso C#: criando sua primeira aplicação](https://cursos.alura.com.br/course/csharp-criando-primeira-aplicacao), pois ele cobre os fundamentos da linguagem, garantindo que você consiga realizar os exercícios deste curso com mais segurança.

Dicas para potencializar seu aprendizado neste curso

- Assista ao vídeo de revisão com atenção. Pause, anote e revise sempre que necessário.
- Baixe o material complementar para ter um apoio nas atividades.
- Faça os desafios na sua IDE favorita.
- Compartilhe o que aprendeu no fórum, pois sua abordagem pode inspirar outras pessoas.

Vamos começar?

### Aula 1 - Preparando o ambiente: instalando o Visual Studio

Olá!  
O IDE do Visual Studio é uma plataforma de lançamento criativa que você pode usar para editar, depurar e criar código e, em seguida, publicar um aplicativo. Além do editor e depurador padrão fornecidos pela maioria dos IDEs, o Visual Studio inclui compiladores, ferramentas de conclusão de código, designers gráficos e muitos outros recursos para aprimorar o processo de desenvolvimento de software. O IDE mais abrangente para desenvolvedores .NET no Windows e Mac para criação de web, nuvem, desktop, aplicativos móveis, serviços e jogos.

Sabendo disso, preparamos alguns vídeos para instalar em diferentes sistemas operacionais. Para este curso em específico, marque a opção Desenvolvimento para Desktop com .NET. no processo de instalação.

(videos internos da plataforma, sem links externos)

Visual Studio no Windows  
Visual Studio no Mac  
C# no VSCODE (SDK)

C# em distribuições Linux

Neste link, você encontra um passo a passo da própria [Microsoft de como instalar em distribuições Linux](https://learn.microsoft.com/pt-br/dotnet/core/install/linux), como Alpine, CentOS, Debian, entre outras.

Vamos começar?

### Aula 1 - Preparando o ambiente: material de apoio

Após revisar os conceitos de condicionais em C#, é hora de colocar o conhecimento em prática com uma série de atividades focadas no tema. Caso queira acessar os slides da revisão, eles estão disponíveis no link abaixo:

[Baixe os slides do curso](https://cdn3.gnarususercontent.com.br/4568-praticando-csharp-condicionais-if-else-switch-case/Praticando%20C%23_%20%20Condicionais.pdf)

Top-level statements

A partir da versão 9.0 do C#, não é mais necessário escrever using System; ou criar uma classe Program com o método Main. Isso acontece graças ao recurso chamado top-level statements (ou instruções de nível superior), que permite eliminar a estrutura tradicional usada como ponto de entrada do programa. Antes, um aplicativo de console típico era escrito assim:

```C#
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

> Console.WriteLine("Hello, World!");

Esse recurso pode te ajudar a deixar os exercícios mais simples e diretos, com foco na lógica e não na estrutura do programa. Após finalizar todos os desafios, não esqueça de compartilhar sua solução no fórum. Será incrível ver como você resolveu!

Vamos nessa?

### Aula 1 - If/else - Vídeo 2

Transcrição  
Neste vídeo, entenderemos o que são expressões condicionais e como aplicá-las.

Expressões condicionais

O que são expressões condicionais?  
Pelo próprio nome, conseguimos entender o que significam expressões condicionais: são expressões que dependem de certas condições para serem executadas.

Suponha que estamos desenvolvendo um jogo online, e só conseguimos fazer com que a pessoa usuária acesse e visualize esse jogo se a conexão estiver ativa. Se a conexão estiver inativa, o jogo não carrega. Dessa forma, o programa depende de uma condição para ser executado.

Conhecendo a estrutura condicional em C#  
Podemos representar essas condições utilizando os blocos if e else.

Na linguagem C#, a estrutura condicional possui a seguinte sintaxe:

```C#
if (expressão) 
{
    vá por esse caminho
} 
else 
{
    vá por esse outro caminho
}
```

Utilizamos a palavra-chave if, abrimos parênteses e, entre eles, colocamos uma expressão. Essa expressão pode retornar true ou false, que são valores booleanos. Se a expressão resultar em verdadeiro (true), entramos no bloco if e executamos o caminho determinado entre chaves.

Se a expressão resultar em falso (false), podemos seguir outro caminho, caso não haja nada após o bloco if. Além disso, podemos definir o que queremos fazer se a expressão for falsa.

Dessa forma, se for verdadeira, fazemos uma coisa específica; caso contrário, fazemos outra coisa diferente. O "caso contrário" é representado pelo bloco else. Teremos a palavra-chave else e, entre chaves, outro bloco que indica seguir por outro caminho.

Importante! Em expressões condicionais, ou executamos o bloco if ou executamos o bloco else. Não é possível executar ambas as coisas ao mesmo tempo.

O que são operadores relacionais?  
Quando falamos sobre expressões condicionais, que resultam em true ou false, existem vários operadores que podem nos ajudar a trabalhar com elas. Temos os operadores de comparação, que são os operadores relacionais, e dentro deles, há diversos tipos de comparação.

Observe a tabela abaixo:

| Operador | Significado | Exemplo |
|----------|-------------|---------|
| >        | Maior que   | x > 10  |
| <        | Menor que   | x < 10  |
| ==       | Igual a     | x == 10 |
| !=       | Diferente de | x != 10 |
| >=       | Maior ou igual a | x >= 10 |
| <=       | Menor ou igual a | x <= 10 |

Podemos, por exemplo, querer saber se uma variável tem um valor maior que outro. Suponha que queremos comparar se a variável x é maior do que 10. Nesse caso específico, utilizamos o operador de comparação representado por >. Da mesma forma, podemos comparar se uma variável é menor que outra, se é igual, se é diferente, maior ou igual, ou menor ou igual.

Atenção! O operador de igualdade é representado por dois símbolos de igual (==). Se usarmos apenas um símbolo (=), temos uma atribuição, que são coisas diferentes.

O que são operadores lógicos?  
Os operadores apresentados tratam de comparação de valores, mas podemos querer juntar as condições. Para isso, utilizamos os operadores lógicos.

Dentro dos operadores lógicos, temos o operador AND, que indica se uma condição e outra são verdadeiras. Observe a tabela-verdade abaixo:

Operador AND

| Condição 1 | Condição 2  | Resultado  |
|------------|-------------|------------|
| Verdadeiro | Verdadeiro  | Verdadeiro |
| Verdadeiro | Falso       | Falso      |
| Falso      | Verdadeiro  | Falso      |
| Falso      | Falso       | Falso      |

Se temos verdadeiro e verdadeiro, retornamos verdadeiro, mas se temos qualquer outra combinação, o resultado será falso. A condição 1 não pode ser verdadeira e a 2 ser falsa, por exemplo, se queremos que a combinação delas seja verdadeira.

Já no caso do operador OR, queremos que uma condição ou outra sejam verdadeiras. Abaixo, temos outra tabela-verdade exemplificando o seu uso:

Operador OR

| Condição 1 | Condição 2 |  Resultado |
|------------|------------|------------|
| Verdadeiro | Verdadeiro | Verdadeiro |
| Verdadeiro | Falso      | Verdadeiro |
| Falso      | Verdadeiro | Verdadeiro |
| Falso      | Falso      | Falso      |

Se temos verdadeiro e verdadeiro, retornamos verdadeiro, mas se temos qualquer outra combinação, o resultado será falso. A condição 1 não pode ser verdadeira e a 2 ser falsa, por exemplo, se queremos que a combinação delas seja verdadeira.

Já no caso do operador OR, queremos que uma condição ou outra sejam verdadeiras. Abaixo, temos outra tabela-verdade exemplificando o seu uso:

Operador OR

| Condição 1 | Condição 2 | Resultado  |
|------------|------------|------------|
| Expressão  | Negação    | Resultado  |
| Verdadeiro | Falso      | Verdadeiro |
| Falso      | Verdadeiro | Verdadeiro |
| Falso      | Falso      | Falso      |

Para a combinação das condições ser verdadeira, apenas uma precisa verdadeira. Podemos ter verdadeiro e verdadeiro, que resultará em verdadeiro; verdadeiro e falso resultando em verdadeiro; e falso com falso, resultando em falso, pois pelo menos uma condição deve ser verdadeira.

Além disso, temos o operador NOT, que será o contrário do valor: se temos uma expressão verdadeira, a negação dela é falso; e se temos uma expressão falsa, a negação dela será verdadeira.

Abaixo, a representação do operador em tabela:

Operador NOT

| Expressão  | Negação      | Resultado  |
|------------|----------    |------------|
| Verdadeiro | Falso        | Verdadeiro |
| Falso      | Verdadeiro   | Verdadeiro |

Exemplo prático no Visual Studio  
Uma vez que conhecemos esses diversos operadores, bem como os blocos if e else, podemos verificar em código como isso funciona na prática.

Com o Visual Studio aberto, começaremos com o exemplo da conexão ativa. No arquivo Program.cs, criaremos uma variável booleana bool conexaoAtiva e definiremos a conexão como válida (true).

Em seguida, se a conexão estiver ativa (if (conexaoAtiva)), vamos iniciar o jogo com Console.WriteLine() exibindo a mensagem "Iniciando o jogo!".

Por outro lado, se a conexão não estiver ativa (else), queremos mostrar outra mensagem para a pessoa usuária. Utilizando Console.WriteLine(), definiremos que, caso a conexão esteja inativa, a mensagem exibida para a pessoa usuária será "Você perdeu sua conexão!".

Program.cs:

```C#
bool conexaoAtiva = true;

if (conexaoAtiva)
{
    Console.WriteLine("Iniciando o jogo!");
}
else
{
    Console.WriteLine("Você perdeu sua conexão!");
}
```

Dessa forma, ou executamos o primeiro bloco, ou o segundo. Com isso, receberemos a mensagem "Iniciando o jogo!", pois a variável conexaoAtiva era true. Alterando conexaoAtiva para false, entraremos no bloco else. Ao executar, teremos "Você perdeu sua conexão!".

Conclusão  
Assim, conhecemos o funcionamento básico das estruturas if e else!

### Aula 1 - Mais exemplos de if/else - Vídeo 3

Transcrição  
Neste vídeo, apresentaremos outros exemplos de expressões condicionais.

Mais exemplos de expressões condicionais

Vamos pensar em um exemplo mais avançado? Suponha que trabalhamos em um e-commerce. Nesse e-commerce, se uma compra for a partir de 300 reais, o cliente ganha 10% de desconto.

Nesse caso, precisaremos trabalhar novamente com condições.

Definindo variáveis e condições iniciais  
Primeiramente, no arquivo Program.cs no Visual Studio, vamos criar uma variável double chamada valorCompra e atribuir a ela o valor de 545 reais.

Program.cs:

> double valorCompra = 545.00;

Agora, queremos verificar se o valor da compra é maior do que 300. Portanto, se (if) valorCompra for maior que (>) 300, usaremos um operador relacional de comparação.

Nesse caso, vamos informar que o cliente teve um desconto. Para calcular o valor do desconto, criaremos a variável double desconto no bloco if, que será valorCompra multiplicado por 0.1. Podemos usar interpolação para exibir $"Você ganhou {desconto} reais em desconto!".

```C#
// código omitido
double valorCompra = 545.00;

if (valorCompra > 300.00)
{
    double desconto = valorCompra * 0.1;
    Console.WriteLine($"Você ganhou {desconto} reais em desconto!");
}
```

Com isso, temos nossa condição inicial.

Configurando o caminho alternativo  
Agora, vamos pensar no caminho alternativo (else). Se o valor da compra for menor que 300 reais, precisamos saber quanto falta para atingir os 300 reais. Para isso, criaremos uma variável do tipo double chamada diferenca, que será igual a 300.00 menos (-) valorCompra.

Por que conseguimos fazer isso? Porque, no caso do bloco else, vamos considerar todos os casos em que o valor da compra é menor que 300 reais.

Por fim, vamos imprimir com Console.WriteLine() a mensagem $"Faltam {diferenca} reais para você ganhar desconto na sua compra!", utilizando interpolação.

```C#
// código omitido
    if (valorCompra > 300.00)
{
    double desconto = valorCompra * 0.1;
    Console.WriteLine($"Você ganhou {desconto} reais em desconto!");
}
else
{
    double diferenca = 300.00 - valorCompra;
    Console.WriteLine($"Faltam {diferenca} reais para você ganhar desconto na sua compra!");
}
```

Após isso, executaremos o código. Se o valor da compra for 545 reais, a saída será "Você ganhou 54,5 reais em desconto!". Por outro lado, se o valor da compra for 245 reais, por exemplo, a saída será "Faltam 55 reais para você ganhar desconto na sua compra!".

Utilizando o operador AND  
Agora, vamos pensar em combinar condições.

Suponha que o cliente só consegue 10% de desconto se comprar mais de 300 reais e for um cliente VIP. Vamos declarar uma variável bool clienteVip e defini-la como true por enquanto.

```C#
// código omitido

double valorCompra = 245.00;
bool clienteVip = true;

// código omitido
```

Agora, o bloco if será verdadeiro apenas se duas condições forem verdadeiras: se o valor da compra for maior do que 300 reais; e se o cliente for VIP.

Para isso, utilizaremos o operador AND, representado por &&.

```C#
// código omitido
if (valorCompra > 300.00 && clienteVip)
{
    double desconto = valorCompra * 0.1;
    Console.WriteLine($"Você ganhou {desconto} reais em desconto!");
}
// código omitido
```

Se ambas as condições forem verdadeiras, exibiremos a mensagem $"Você ganhou {desconto} reais em desconto!". Caso contrário, cairemos na outra condição. Ao executar o código, observamos que faltam 55 reais para ganhar desconto, pois o valor da compra está em 245 reais. Assim, a primeira condição é falsa. Logo, a combinação das duas será falsa, pois utilizamos o operador AND.

Utilizando o operador OR  
Se quiséssemos usar o operador OR, representado por ||, entraríamos no primeiro if, pois teríamos uma condição falsa ou uma condição verdadeira.

Observação: se uma das condições for verdadeira, entramos no bloco if.

```C#
// código omitido
if (valorCompra > 300.00 || clienteVip)
{
    double desconto = valorCompra * 0.1;
    Console.WriteLine($"Você ganhou {desconto} reais em desconto!");
}
// código omitido
```

Ao executar, visualizamos que o cliente ganhou 24,5 reais em desconto.

Utilizando a estrutura else if
No exemplo anterior, temos uma expressão condicional bem estruturada, pois a condição é verdadeira ou falsa, resultando em apenas dois caminhos possíveis.

Entretanto, podemos ter vários caminhos nos blocos if e else. Para isso, utilizamos else if, seguido de uma nova condição que desejamos aplicar.

Podemos verificar se o valor da compra é maior que 300 reais. Suponha que a pessoa não atingiu 300 reais, mas atingiu 200 reais. Nesse caso, enviaremos uma amostra grátis ou um brinde. Portanto, exibiremos a mensagem "Parabéns! Você ganhou um brinde!".

```C#

if (valorCompra > 300.00 || clienteVip)
{
    double desconto = valorCompra * 0.1;
    Console.WriteLine($"Você ganhou {desconto} reais em desconto!");
}
else if (valorCompra > 200.00)
{
    Console.WriteLine("Parabéns! Você ganhou um brinde!");
}
else
{
    double diferenca = 300.00 - valorCompra;
    Console.WriteLine($"Faltam {diferenca} reais para você ganhar desconto na sua compra!");
}
```

Queremos saber primeiro se o cliente pagou mais de 300 reais ou se é um cliente VIP. Se nenhuma dessas condições for verdadeira, mas o valor da compra for maior que 200 reais, ele se enquadra no caso que criamos. Ele não está entre os que gastaram mais de 300 reais, mas está entre os que gastaram entre 200 e 300 reais.

Depois, temos o else, que se aplica a quem fez uma compra menor que 200 reais. Para essas pessoas, imprimimos o que falta para alcançar o desconto, pois, no marketing, as empresas focam em clientes que fazem compras com valores mais altos. Assim, temos três casos:

- Quem gastou mais de 300 reais;
- Quem gastou entre 200 e 300 reais;
- Quem gastou menos de 200 reais.

Cada vez que encadeamos if e else if, criamos mais um caminho possível para a execução do programa. Para testar, podemos alcançar a condição de "Parabéns! Você ganhou um brinde!" se o valor da compra for 245 reais e clienteVip for false.

Conclusão  
Com isso, entendemos como funcionam as condicionais, sendo if e else as principais na lógica de programação. No entanto, também temos a opção de trabalhar com switch e case.

Na sequência, vamos explorar melhor esse tipo de expressão!

### Aula 1 - Verificando o saldo da conta - Desafio 1

Imagine que você está desenvolvendo um sistema de análise financeira para um banco digital. Como parte das funcionalidades, você precisa criar um programa que avalie o estado de um saldo bancário.

Crie um programa que:

- Receba um valor representando o saldo.
- Verifique se esse valor é positivo, negativo ou zero.
- Exiba uma mensagem indicando a situação do saldo.

Exemplo de entrada:

Digite o saldo:
-26.75

Saída esperada:

> O saldo está negativo.

Opinião do instrutor

Nessa atividade, utilizamos estruturas condicionais para tomar decisões baseadas no valor do saldo. Primeiro, lemos o valor digitado pelo usuário com o método ReadLine, e o convertemos para decimal, e em seguida as comparações são realizadas:

- Se o valor for maior que zero, mostramos que o saldo é positivo.
- Se for menor que zero, mostramos que é negativo.
- Se não for nenhum dos dois, mostramos que o saldo é zero.

```C#
Console.WriteLine("Digite o saldo:");
decimal saldo = decimal.Parse(Console.ReadLine());
 
if (saldo > 0)
{
    Console.WriteLine("O saldo está positivo.");
}
else if (saldo < 0)
{
    Console.WriteLine("O saldo está negativo.");
}
else
{
    Console.WriteLine("O saldo é zero.");
}
```

Agora é sua vez! Teste o programa, compartilhe no fórum e compare sua lógica com outras soluções.

### Aula 1 - Classificação de produtos - Desafio 2

Imagine que você está desenvolvendo um sistema de gestão de estoque para um centro de distribuição de alimentos. Seu desafio é criar um programa que classifique os produtos conforme seu tipo, para otimizar o armazenamento em áreas específicas do armazém.

Crie um programa que:

- Receba um código numérico (1 ou 2) representando o tipo de produto.
- Classifique o produto como:
- “Perecível” para código 1.
- “Não perecível” para código 2.
- Alerte o usuário caso o código seja inválido.

Exemplo de entrada:

Digite o código do produto (1 ou 2): 1

Saída esperada:

Perecível

Opinião do instrutor

Nessa atividade, exploramos a tomada de decisão usando condicionais. A lógica implementada no programa é a seguinte: primeiro, ele verifica se o código inserido é exatamente igual a 1 (codigo == 1). Se essa condição não for atendida, o programa avança para a próxima verificação, que checa se o código é igual a 2 (codigo == 2). Caso nenhuma das condições anteriores seja verdadeira, o bloco else é executado, indicando que o código não corresponde a nenhuma das opções válidas.

```C#
Console.Write("Digite o código do produto (1 ou 2): ");
int codigo = int.Parse(Console.ReadLine());
 
if (codigo == 1)
{
    Console.WriteLine("Perecível");
}
else if (codigo == 2)
{
    Console.WriteLine("Não perecível");
}
else
{
    Console.WriteLine("Código inválido");
}
```

Agora é sua vez! Teste o programa, compartilhe no fórum e compare sua lógica com outras soluções.

### Aula 1 -  - Desafio 3
### Aula 1 -  - Desafio 4
### Aula 1 -  - Desafio 5
### Aula 1 -  - Desafio 6
### Aula 1 -  - Desafio 7
