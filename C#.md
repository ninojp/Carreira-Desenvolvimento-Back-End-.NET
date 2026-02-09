# Dicas, Detalhes e Observações importantes sobre C#

Documentação Official do C#:
https://learn.microsoft.com/pt-br/dotnet/csharp/
https://learn.microsoft.com/pt-br/dotnet/csharp/fundamentals/types/
https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/builtin-types/built-in-types

## declaração de variáveis e métodos em C#

var, é uma palavra reservada do C# que permite a inferência de tipos, ou seja, o compilador determina o tipo da variável com base no valor atribuído a ela.

> var mensagemDeBoasVindas = "Boas vindas ao Screen Sound";

Podemos também declarar explicitamente o tipo da variável, como string, int, bool, etc.

> string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";

## interpolação de strings em C#

A interpolação de strings em C# é feita utilizando o símbolo `$` antes da string. Isso permite incorporar expressões diretamente dentro das chaves `{}` na string.

> string mensagem = $"Boas-Vindas: {nome}, Ao Screen Sound!";

Outra forma de concatenar strings em C# é utilizando o operador `+`.

> string mensagem = "Boas-Vindas: " + nome + ", ao Screen Sound!";

O `@` é conhecido como "verbatim string literal" em C#. Ele permite criar strings que preservam espaços em branco e quebras de linha, facilitando a criação de strings multilinha.

> string mensagem = @"Boas-Vindas,
                    ao Screen Sound!
                    Aproveite!";

## Cores nos textos do console em C#

Em C#, é possível alterar a cor do texto exibido no console utilizando a classe `Console` a propriedade `ForegroundColor` e a propriedade `BackgroundColor`. Para definir a cor, você pode usar os valores do enum `ConsoleColor`.

// Cores disponíveis no enum ConsoleColor:
Black, DarkBlue, DarkGreen, DarkCyan, DarkRed, DarkMagenta, DarkYellow, Gray, DarkGray, Blue, Green, Cyan, Red, Magenta, Yellow, White
