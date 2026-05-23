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

### Aula 1:  - Vídeo 2

### Aula 1:  - Vídeo 3

### Aula 1:  - Vídeo 4

### Aula 1:  - Vídeo 5

### Aula 1:  - Vídeo 6

### Aula 1:  - Vídeo 7
