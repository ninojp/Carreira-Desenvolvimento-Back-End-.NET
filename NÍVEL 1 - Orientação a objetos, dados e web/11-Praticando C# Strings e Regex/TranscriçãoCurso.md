# Curso Alura - Praticando C# Strings e Regex

## Aula 1 - Strings

### Aula 1: O que esperar deste curso?

Antes de mergulharmos no código, que tal alinharmos as expectativas?

**O que significa um curso prático?**  
Já se pegou pensando — será que consigo aplicar o que aprendi na prática? Este curso é a sua resposta. Aqui, o foco é colocar a mão no código, resolver problemas e testar seu conhecimento de forma ativa. Você terá:

- Vídeo de revisão do conteúdo
- Material de apoio
- Desafios de código

Pré requisitos

É importante ter concluído o [curso C#: criando sua primeira aplicação](https://cursos.alura.com.br/course/csharp-criando-primeira-aplicacao), pois ele cobre os fundamentos da linguagem, garantindo que você consiga realizar os exercícios deste curso com mais segurança.

Dicas para potencializar seu aprendizado neste curso

- Assista ao vídeo de revisão com atenção. Pause, anote e revise sempre que necessário.
- Baixe o material complementar para ter um apoio nas atividades.
- Faça os desafios na sua IDE favorita.
- Compartilhe o que aprendeu no fórum, pois sua abordagem pode inspirar outras pessoas.

Vamos começar?

### Aula 1: Apresentação - Vídeo 1

Transcrição  
Olá, meu nome é Iasmin Araújo, sou instrutora na Escola de Programação e irei me autodescrever para fins de acessibilidade.

Audiodescrição: Iasmin se identifica como uma mulher branca. Possui cabelos castanhos-escuros e longos, repartidos ao meio. Veste uma regata azul-escura. Ao fundo, o ambiente é iluminado em tons de azul, e possui uma parede lisa com um interruptor e uma porta à esquerda.

**O que aprenderemos?**  
Neste curso de C#, vamos praticar a habilidade de trabalhar com strings. Vamos aprender a:

- Declarar strings;
- Concatenar strings, criando um único texto;
- Interpolar strings;
- Usar sequências de escape;
- Usar o texto verbatim em strings;
- Transformar strings com métodos de manipulação;
- Escrever padrões de regex (expressões regulares) e como aplicá-los.

Próximos passos

É importante conhecer a teoria, mas também precisamos praticar! Na sequência, iniciaremos essa prática para aprofundar ainda mais nossos conhecimentos.

Bons estudos!

### Aula 1: Preparando o ambiente: instalando o Visual Studio

Olá!  
O IDE do Visual Studio é uma plataforma de lançamento criativa que você pode usar para editar, depurar e criar código e, em seguida, publicar um aplicativo. Além do editor e depurador padrão fornecidos pela maioria dos IDEs, o Visual Studio inclui compiladores, ferramentas de conclusão de código, designers gráficos e muitos outros recursos para aprimorar o processo de desenvolvimento de software. O IDE mais abrangente para desenvolvedores .NET no Windows e Mac para criação de web, nuvem, desktop, aplicativos móveis, serviços e jogos.

Sabendo disso, preparamos alguns vídeos para instalar em diferentes sistemas operacionais. Para este curso em específico, marque a opção Desenvolvimento para Desktop com .NET. no processo de instalação.

Visual Studio no Windows

Visual Studio no Mac

C# no VSCODE (SDK)

C# em distribuições Linux  
[Neste link](https://learn.microsoft.com/pt-br/dotnet/core/install/linux), você encontra um passo a passo da própria Microsoft de como instalar em distribuições Linux, como Alpine, CentOS, Debian, entre outras.

Vamos começar?

### Aula 1: Preparando o ambiente: material de apoio

Após revisar os conceitos variáveis e tipos em C#, é hora de colocar o conhecimento em prática com uma série de atividades focadas no tema. Caso queira acessar os slides da revisão, eles estão disponíveis no link abaixo:

[Baixe os slides do curso](https://cdn3.gnarususercontent.com.br/4570-Praticando%20C%20Strings%20e%20Regex/Praticando%20C%23%20-%20Strings%20e%20Regex.pptx.pdf)

Top-level statements

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

Esse recurso pode te ajudar a deixar os exercícios mais simples e diretos, com foco na lógica e não na estrutura do programa.

[Regex 101:](https://regex101.com/)

Caso prefira testar suas expressões regulares antes de utilizá-las no código, você também pode usar a [ferramenta online Regex 101](https://regex101.com/) para criar e validar seus padrões.

Após finalizar todos os desafios, não esqueça de compartilhar sua solução no fórum. Será incrível ver como você resolveu!

Vamos nessa?

### Aula 1: Strings - Vídeo 2

Transcrição  
Trabalhar com texto é essencial no dia a dia de desenvolvimento. Pensando nisso, as linguagens de programação sempre possuem algum tipo para representar textos. No caso de C#, utilizamos as strings.

**Declarando strings**  
Para declarar uma string, utilizamos a palavra-chave string, seguida do nome da variável, o operador de atribuição e, em seguida, o texto que desejamos armazenar na memória. Esse texto deve estar entre aspas duplas.

Vamos ver como isso é feito na prática:

```csharp
string variavel = "texto";
```

**Concatenando strings**  
Uma vez que temos uma string, podemos juntar várias strings, realizando o que chamamos de concatenação. Para juntar duas strings, por exemplo, podemos ter as variáveis variavel1 e variavel2, e utilizar o operador +. Quando fazemos texto1 + texto2, estamos criando um único texto, que será o resultado dessa junção.

```csharp
string variavel2 = "texto2";
Console.WriteLine("texto" + "texto2");
```

Utilizamos o operador + tanto para operações matemáticas com números inteiros quanto para concatenar strings. O resultado depende do tipo ao qual aplicamos esse operador.

**Capturando e imprimindo dados**  
Para praticar melhor as strings, vamos acessar o Visual Studio, no qual já temos um exemplo parcialmente pronto no arquivo Program.cs.

Suporemos que estamos criando um programa que interage com a pessoa usuária, pedindo para digitar o nome, a idade e o telefone. Vamos começar capturando essas informações:

Program.cs:

```csharp
Console.Write("Olá! Digite seu nome: ");
string nome = Console.ReadLine();

Console.Write("Agora, digite sua idade: ");
string idade = Console.ReadLine();

Console.Write("Agora, digite seu telefone: ");
string telefone = Console.ReadLine();
```

Uma vez que a pessoa usuária digitou todas essas informações, queremos imprimir esses dados na tela. Faremos isso utilizando a concatenação.

Pulando uma linha, utilizaremos o Console.WriteLine() e passaremos entre parênteses toda a informação concatenada. Começaremos com "Nome: ", seguido de um espaço, e concatenaremos com o nome que a pessoa usuária digitou.

```csharp
Console.WriteLine("Nome: " + nome + ", " + "idade: " + idade + ", " + "telefone: " + telefone);
```

Nesse caso, juntamos strings que possuem variáveis com string que não as possuem para compor o resultado.

**Interpolando strings**  
Existe uma forma mais fácil de fazer isso: a interpolação de strings. Na interpolação de strings, colocaremos um $ antes das aspas para indicar que a string será interpolada.

Sempre que quisermos inserir uma variável dentro da string, utilizamos chaves. Colocaremos uma chave antes e outra depois de cada variável adicionada para não precisar separar a string que queremos imprimir da string da variável.

Com isso, podemos remover os +, criando uma única string.

```csharp
Console.WriteLine($"Nome: {nome}, idade: {idade}, telefone: {telefone}");
```

Geralmente, preferimos utilizar a interpolação em relação à concatenação.

**Utilizando sequências de escape em strings**  
Vamos pensar em outro problema. Suponhamos que queiramos criar uma variável do tipo string que será uma mensagem exibida. Essa mensagem será: "Olá, meu e-mail é iasmin@email.com".

```csharp
string mensagem = "Olá! Meu email é iasmin@email.com";
```

Antes de executar, comentaremos todo o código acima dessa linha para não precisar digitar os dados do João. Após executar, a string é exibida corretamente.

Olá! Meu email é iasmin@email.com

Queremos destacar o texto "iasmin@email.com" colocando esse e-mail entre aspas, por exemplo.

```csharp
string mensagem = "Olá! Meu email é "iasmin@email.com"";
```

O Visual Studio apontará um erro, pois entende que as aspas após "é" encerram a string. Tudo que está depois é considerado incorreto.

Para representar "iasmin e-mail" com aspas no meio da frase, diferenciaremos as aspas que declaram o texto das que estão dentro da variável utilizando uma sequência de escape.

As sequências de escape são sempre compostas pela contrabarra (\) e algum caractere. No caso, utilizaremos \" para cada aspa dupla que queremos exibir no texto.

```csharp
string mensagem = "Olá! Meu email é \"iasmin@email.com\"";
```

O resultado é o seguinte:

Olá! Meu email é "iasmin@email.com"

Existem outras sequências de escape, mas estas são as mais utilizadas no dia a dia. Por exemplo, temos:

- \n para nova linha;
- \t para tabulação;
- \\ para representar a barra invertida;
- \' para aspas simples e
- \b, que apaga um caractere anterior.

Um exemplo que podemos utilizar está relacionado aos caminhos de arquivo no Windows. Quando copiamos um caminho de arquivo no Windows, ele vem com contra barras (\).

Vamos criar a string caminho e colar um caminho de arquivo do Windows:

```csharp
string caminho = "C:\Users\adria\Documents\requisicao.txt";
```

É importante lembrar que a contra barra é usada para representar sequências de escape em linguagens de programação. Por isso, se quisermos representar uma contra barra no código, precisamos usar duas (\\).

```csharp
string caminho = "C:\\Users\\adria\\Documents\\requisicao.txt";
```

Assim, conseguimos trabalhar corretamente com caminhos de arquivo. Depois disso, podemos imprimir o caminho para confirmar que está tudo certo.

```csharp
Console.WriteLine(caminho);
```

C:\Users\adria\Documents\requisicao.txt

**Usando strings verbatim**  
Há outra forma de lidar com esse formato de string, chamada verbatim. Com ela, não precisamos utilizar sequências de escape. Podemos colocar a string exatamente como é.

Para usar o verbatim, colocamos um @ antes da string e podemos apagar as barras extra. Entretanto, as aspas continuarão quebrando as strings — para evitar esse problema, temos que usar duas aspas para representar uma.

```csharp
string mensagem = @"Olá! Meu email é ""iasmin@email.com""";
Console.WriteLine(mensagem);

string caminho = @"C:\Users\adria\Documents\requisicao.txt";
Console.WriteLine(caminho);
```

Executaremos para visualizar. No terminal, teremos os mesmos resultados, mas agora utilizando o verbatim.

Olá! Meu email é "iasmin@email.com"

C:\Users\adria\Documents\requisicao.txt

Essa é uma forma de colocar a mensagem exatamente como queremos, sem utilizar sequências de escape.

**Conclusão e próximos passos**  
Estas são algumas considerações sobre strings. Temos vários conceitos para explorar na sequência.

### Aula 1:  - Vídeo 3
### Aula 1:  - Vídeo 4
### Aula 1:  - Vídeo 5
### Aula 1:  - Vídeo 6
### Aula 1:  - Vídeo 7
### Aula 1:  - Vídeo 8

