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

### Aula 1: Manipulação de Strings - Vídeo 3

Transcrição  
No curso em que praticamos variáveis e tipos, vimos que as strings não são tipos primitivos, mas sim tipos referenciados. A vantagem das strings serem tipos referenciados é que elas possuem diversos métodos que nos permitem modificá-las ao longo do tempo.

**Explorando métodos de manipulação de strings**  
Para modificar as strings, utilizamos vários métodos de manipulação. Alguns exemplos são:

- Length(): nos informa o tamanho de uma string;
- ToLower() e ToUpper(): convertem todas as letras de uma palavra para minúsculas e maiúsculas, respectivamente;
- Contains(): verifica se a string contém um texto específico;
- StartsWith() e EndsWith(): verifica se o início e o final da string, respectivamente, possuem um texto determinado;
- IndexOf(): identifica a posição de um caractere específico na string;
- Substring(): extrai uma parte da string desde o início até um tamanho determinado;
- Replace(): substitui um texto antigo por um novo;
- Trim(), TrimStart() e TrimEnd(): removem espaços em branco;
- Split(): separa uma string de acordo com um padrão separador;
- Join(): junta uma string seguindo um padrão.

Esses métodos foram apresentados rapidamente, e para compreendê-los melhor, é necessário praticar. Vamos voltar ao nosso código para entender melhor esses métodos.

**Extraindo partes da string**  
Vamos comentar todo o código anterior para focar na parte de manipulação de strings.

No vídeo anterior, exibimos informações digitadas pela pessoa usuária separadas por vírgulas, como nome, idade e telefone. Suponhamos que estivéssemos trabalhando com linhas de um arquivo CSV, que são separadas por vírgulas, assim como o que estávamos escrevendo.

Na próxima linha, criaremos uma string chamada linhaCsv, que conterá "João", a idade "40" e o telefone "999999999":

```csharp
string linhaCsv = "João, 40, 999999999";
```

Se quisermos extrair apenas o telefone dessa linha do CSV, utilizaremos o método Split(), que separa a string em partes diferentes. Vamos criar uma variável chamada telefone, que armazenará o resultado da separação, pegando apenas o final da string.

```csharp
string telefone = 
```

Para usar o método Split() em uma string, chamamos o nome da variável que contém a string, depois usamos o ponto (.) para acessar os métodos disponíveis. O Visual Studio mostrará uma lista com várias opções, entre as quais escolheremos o Split().

Temos que passar o separador para esse método. No caso do linhaCsv, queremos dividir a string com base na vírgula. Então, usamos:

```csharp
string telefone = linhaCsv.Split(",")
```

O Split() vai dividir a string em várias partes e o resultado será armazenado em um array.

Para acessar uma parte específica do array, usamos o índice. Como os índices começam do 0, o terceiro elemento estará na posição 2:

```csharp
string telefone = linhaCsv.Split(",")[2];
```

Ou seja, dividimos a string em três partes e pegamos a terceira, que está na posição 2 do array.

Após essa operação, teoricamente, extraímos o telefone. Vamos usar Console.WriteLine() para verificar se o método funcionou corretamente:

```csharp
Console.WriteLine(telefone);
```

Ao executar o programa, observamos que o telefone "999999999" de João foi extraído corretamente.

999999999

**Formatando strings**  
Agora, suponhamos que queremos exibir o CSV de forma diferente, separando as palavras com espaços e hifens. Para isso, criaremos uma nova string chamada novaLinha, que será o resultado de uma manipulação de strings usando o método Replace().

Queremos substituir as vírgulas por espaços e hifens. Definiremos a vírgula como padrão para ser substituída. Depois, indicamos o que desejamos colocar no lugar dela, que no caso, é um espaço:

```csharp
string novaLinha = linhaCsv.Replace(",", " - ");
```

Vamos verificar se isso está funcionando usando novamente Console.WriteLine() para exibir a novaLinha:

```csharp
Console.WriteLine(novaLinha);
```

Vamos executar o programa e observar que a linha está formatada da forma desejada, com o espaço e os hifens.

João - 40 - 999999999

**Verificando formatos de arquivos**  
Vamos pensar em um novo exemplo. Ainda na tarefa de trabalhar com arquivos, suponhamos que estejamos lidando com um sistema no qual a pessoa usuária pode enviar imagens. No entanto, essas imagens devem ser apenas no formato JPG.

Assim, toda vez que a pessoa usuária enviar uma imagem, queremos verificar o nome do arquivo para confirmar se realmente é JPG, antes de armazená-la no banco de dados.

Para isso, declararemos uma string imagem, que terá o nome foto.jpg:

```csharp
string imagem = "foto.jpg";
```

Precisamos filtrar essa foto.jpg de alguma forma. Faremos esse filtro usando outro método de manipulação de strings, que nos fornecerá um resultado booliano.

Declararemos um bool chamado valido, que indicará se a imagem é válida ou não, e utilizaremos a string imagem, adicionando um ponto. Para verificar se o formato é JPG, precisamos ver se o final do arquivo contém os caracteres .jpg.

Para verificar se uma string termina com algo específico, podemos usar o método EndsWith() com o trecho ".jpg":

```csharp
bool valido = imagem.EndsWith(".jpg");
```

Assim, descobriremos se a imagem é válida e, então, podemos usar um if(). Se a imagem for válida, exibiremos "carregando para o banco de dados" com Console.WriteLine():

```csharp
if(valido)
{
    Console.WriteLine("Carregando para o banco de dados");
}
```

Caso contrário, exibiremos "formato inválido" com else:

```csharp
else
{
    Console.WriteLine("Formato invalido!");
}
```

Comentaremos as linhas anteriores para evitar saídas confusas e executaremos o programa para verificar se está funcionando.

Observamos que ele exibiu "carregando para o banco de dados" porque temos uma imagem foto.jpg. Se tivéssemos, por exemplo, um arquivo mp4, o resultado seria "formato inválido". É assim que o método EndsWith() funciona.

Existem outros métodos, como Contains() e StartsWith(), que também fornecem resultados boolianos, true ou false.

**Analisando domínios de e-mail**  
Vamos para outro exemplo. Suponhamos que trabalhamos em uma empresa que deseja analisar todas as outras empresas que estão criando contas em seu site. Para realizar essa análise, precisamos verificar o domínio do e-mail das pessoas que estão criando contas.

Suponhamos que criemos a conta "iasmin@alura.com.br" com uma string email:

```csharp
string email = "iasmin@alura.com.br";
```

Queremos saber o domínio do e-mail, que vem após o arroba. Esse domínio nos ajudará a traçar estatísticas e identificar quais empresas estão interessadas na nossa.

Para obter o domínio do e-mail, poderíamos pensar em usar alguns dos métodos mencionados anteriormente, como verificar se o e-mail termina com "alura". No entanto, não é isso que queremos.

Queremos obter o domínio sem saber qual é. Não queremos verificar se "alura" existe, mas descobrir que "alura" existe. Para isso, precisamos usar outras estratégias.

O e-mail sempre contém um arroba. Podemos descobrir a posição desse arroba. Uma vez que sabemos essa posição, trabalhamos com tudo que está após o arroba.

Precisaremos de alguns métodos para isso. O primeiro será IndexOf(). Vamos declarar int posicao, que será a posição do arroba, usando o método IndexOf() para encontrar a posição do caractere @:

```csharp
int posicao = email.IndexOf("@");
```

Dessa forma, já sabemos onde está o arroba. Em seguida, pegaremos tudo que está a partir do arroba.

Declararemos uma string dominio, que é o que queremos descobrir. Esse domínio será email.Substring(posicao):

```csharp
string dominio = email.Substring(posicao);
```

Vamos usar Console.WriteLine para exibir o domínio:

```csharp
Console.WriteLine(dominio);
```

Ao usar o IndexOf("@"), pegamos a posição onde está o caractere @. Mas, se queremos apenas o domínio do e-mail (como "alura.com.br"), não queremos incluir o @.

Para isso, somamos 1 à posição encontrada, começando a extração logo após o @.

```csharp
string dominio = email.Substring(posicao+1);
```

Agora sim, ao executar, teremos o e-mail desejado.

alura.com.br

Conseguimos recuperar todos os domínios e traçar as estatísticas conforme desejado.

**Conclusão e próximos passos**  
Exploramos alguns métodos de manipulação de strings. Existem muitos outros, e é interessante explorar a documentação para entender como funcionam.

Temos outras questões a discutir no campo de strings. Na sequência, falaremos um pouco sobre expressões regulares (regex).

### Aula 1: Encontrando palavras-chave - Desafio 1

Imagine que você está desenvolvendo um sistema de pesquisa em que o usuário digita uma consulta e o sistema precisa verificar se uma palavra-chave está presente na consulta. O sistema deverá exibir uma mensagem indicando se a palavra-chave foi encontrada ou não. Para isso, você precisa de um programa que:

- Declare uma variável para servir como palavra-chave.
- Receba um texto do usuário.
- Verifique se a palavra-chave está presente no texto.
- Exiba uma mensagem informando se a palavra foi encontrada ou não.

Exemplo de entrada:

```csharp
Digite um texto:
Aprendendo C# com exemplos práticos
```

Saída esperada: Considerando C# como palavra-chave

```csharp
A palavra-chave foi encontrada na pesquisa.
```

Opinião do instrutor

Nessa atividade, utilizamos o método Contains() para verificar a existência de uma substring em uma string. Esse método retorna um valor booleano (true ou false), que nos permite tomar decisões no código.

- Se Contains() retornar true, significa que a palavra-chave está presente na string, e exibimos a mensagem de confirmação.
- Se retornar false, indicamos que a palavra-chave não foi encontrada.

```csharp
Console.WriteLine("Digite um texto: ");
string pesquisa = Console.ReadLine();
string chave = "C#";
 
if (pesquisa.Contains(chave))
{
    Console.WriteLine("A palavra-chave foi encontrada na pesquisa.");
}
else
{
    Console.WriteLine("A palavra-chave não foi encontrada.");
}
```

Agora é sua vez! Teste o programa, compartilhe no fórum e compare sua lógica com outras soluções.

### Aula 1:  Contando caracteres - Desafio 2

Você está desenvolvendo um sistema de análise de textos para uma plataforma de escrita criativa. Os autores precisam saber o tamanho exato de seus textos para atender aos requisitos de publicação. Seu objetivo é criar uma ferramenta que conte os caracteres de qualquer texto inserido.

Para isso, você precisa de um programa que:

- Solicite ao usuário que digite uma frase.
- Calcule o número total de caracteres (incluindo espaços).
- Exiba o resultado no console.

Exemplo de entrada:

```csharp  
Digite uma frase: Aprendendo a programar
```

Saída esperada:

```csharp
A frase contém 22 caracteres.
```

Opinião do instrutor

Nessa atividade, utilizamos o método Length(). Esse método retorna um número inteiro representando o número total de caracteres na string. Isso inclui todos os caracteres visíveis, espaços em branco e pontuações.

```csharp
Console.Write("Digite uma frase: ");
string frase = Console.ReadLine();
 
Console.WriteLine($"A frase contém {frase.Length} caracteres.");
```

Agora é sua vez! Teste o programa, compartilhe no fórum e compare sua lógica com outras soluções.

### Aula 1: Substituindo palavras em uma frase - Desafio 3

Imagine que você está desenvolvendo um sistema para edição de textos e precisa permitir ao usuário substituir uma palavra por outra. O sistema deve ser *capaz de substituir todas as ocorrências de uma palavra dentro de uma frase.

Para isso, você precisa criar um programa que:

- Receba uma frase digitada pelo usuário.
- Receba a palavra específica a ser substituída.
- Receba uma palavra nova para substituir a antiga.
- Realize a troca por uma nova palavra em todas as ocorrências.
- Exiba a frase modificada.

Exemplo de entrada:

```csharp  
Digite uma frase:
Eu gosto de programar em Java
 
Qual palavra você quer substituir?
Java
 
Por qual palavra?
C#
```

Saída esperada:

```csharp
Eu gosto de programar em C#
```

Opinião do instrutor

Nessa atividade, utilizamos o método Replace() que substitui todas as ocorrências de uma substring dentro de uma string. A lógica que utilizamos é a seguinte:

Recebemos a frase original e as palavras que queremos substituir.
Usamos o método Replace() para substituir a palavra antiga pela nova: frase.Replace(palavraAntiga, palavraNova).

Exibimos a nova frase.

```csharp
Console.WriteLine("Digite uma frase: ");
string frase = Console.ReadLine();
 
Console.WriteLine("\nQual palavra você quer substituir? ");
string palavraAntiga = Console.ReadLine();
 
Console.WriteLine("\nPor qual palavra? ");
string palavraNova = Console.ReadLine();
 
string novaFrase = frase.Replace(palavraAntiga, palavraNova);
Console.WriteLine(novaFrase);
```

Agora é sua vez! Teste o programa, compartilhe no fórum e compare sua lógica com outras soluções.

### Aula 1: Dividindo uma string - Desafio 4

Imagine que você está desenvolvendo um sistema de monitoramento de erros para uma aplicação web. Cada registro de log contém informações importantes separadas por vírgulas, incluindo data, tipo de erro e mensagem detalhada. Seu objetivo é processar esses logs para facilitar a análise dos problemas. Para isso, você precisa criar um programa que:

- Declare uma string de log no formato "data,tipo,mensagem".
- Separe essa string em partes individuais usando a vírgula como delimitador.
- Exiba cada informação de forma organizada e legível.

Exemplo de entrada:

```csharp  
log = "2025-03-25,Erro,Arquivo não encontrado";
```

Saída esperada:

```csharp
Data: 2025-03-25
Tipo de erro: Erro
Mensagem: Arquivo não encontrado
```

Opinião do instrutor

Nessa atividade, usamos o método Split() que divide uma string em várias partes com base em um delimitador. Como esse método retorna um array, nós acessamos o elemento desejado do array resultante usando os índices [0], [1] e [2].

```csharp
string log = "2025-03-25,Erro,Arquivo não encontrado";
 
Console.WriteLine($"Data: {log.Split(',')[0]}");
Console.WriteLine($"Tipo de erro: {log.Split(',')[1]}");
Console.WriteLine($"Mensagem: {log.Split(',')[2]}");
```

Agora é sua vez! Teste o programa, compartilhe no fórum e compare sua lógica com outras soluções.

### Aula 1:  Padronizando alertas em maiúsculas - Desafio 5

Você está desenvolvendo um sistema de notificações críticas para um ambiente corporativo, onde todos os alertas devem seguir um padrão visual para chamar atenção imediata. Seu programa precisa garantir que mensagens de aviso - como expiração de sessão ou falhas de segurança - sejam exibidas integralmente em letras maiúsculas, independentemente de como foram digitadas ou recebidas.

Crie um programa que:

- Receba uma string contendo um alerta.
- Converta todos os caracteres para maiúsculas.
- Exiba o texto padronizado na tela.

Exemplo de entrada:

```csharp
Digite o alerta:
atenção: seu acesso será expirado em 5 minutos.
```

Saída esperada:

```csharp
ATENÇÃO: SEU ACESSO SERÁ EXPIRADO EM 5 MINUTOS.
```

Opinião do instrutor

Nesta atividade, o método ToUpper() é utilizado para transformar toda a string em maiúsculas, incluindo letras acentuadas e caracteres especiais compatíveis (como "ç" → "Ç"). Observe que:

A conversão é aplicada a cada caractere da string original, preservando espaços, números e pontuações.
O método não requer parâmetros adicionais, pois opera diretamente sobre a string.
Console.WriteLine("Digite o alerta: ");

```csharp
string alerta = Console.ReadLine();
 
string resultado = alerta.ToUpper();
 
Console.WriteLine(resultado);
```

Agora é sua vez! Teste o programa, compartilhe no fórum e compare sua lógica com outras soluções.

### Aula 1:  Formatando o relatório - Desafio 6

Imagine que você está desenvolvendo um sistema de formatação de relatórios para uma empresa de logística. Os relatórios precisam exibir informações como endereços, valores e datas em um formato padronizado, utilizando quebras de linha, tabulações e outros caracteres especiais para melhor organização visual.

Crie um programa que:

- Solicite ao usuário:
- Nome do cliente.
- Endereço.
- Valor do frete.
- Data de entrega.
- Exiba os dados formatados em um bloco organizado.

Exemplo de entrada:

```csharp
Digite o nome do cliente:
Arthur Dent
Digite o endereço:
Rua do Chá Inglês, 42
Digite o valor do frete:
42,00
Digite a data de entrega:
15/05/2025
```

Saída esperada:

```csharp
========== RELATÓRIO DE ENTREGA ==========
 
Cliente:         "Arthur Dent"
Endereço:        "Rua do Chá Inglês, 42"
Valor do frete: R$ 42,00
Data:            15/05/2025
 
==========================================
```

Opinião do instrutor

Nesta atividade, exploramos o uso de sequências de escape para controlar a formatação de texto. Sequências como \n (quebra de linha) e \t (tabulação) são essenciais para estruturar saídas de forma legível, enquanto \" permite incluir aspas dentro de strings.

Uma alternativa interessante é o uso de verbatim (@), que ignoram sequências de escape e permitem quebras de linha e caracteres especiais sejam interpretados literalmente.

```csharp
Console.WriteLine("Digite o nome do cliente:");
string nome = Console.ReadLine();
 
Console.WriteLine("Digite o endereço:");
string endereco = Console.ReadLine();
 
Console.WriteLine("Digite o valor do frete:");
double frete = double.Parse(Console.ReadLine());
 
Console.WriteLine("Digite a data de entrega:");
string data = Console.ReadLine();
 
Console.WriteLine("\n========== RELATÓRIO DE ENTREGA ==========\n");
Console.WriteLine($"Cliente:\t \"{nome}\"");
Console.WriteLine($"Endereço:\t \"{endereco}\"");
Console.WriteLine($"Valor do frete: R$ {frete.ToString("0.00")}");
Console.WriteLine($"Data:\t\t {data}\n");
Console.WriteLine("==========================================");
```

Agora é sua vez! Teste o programa, compartilhe no fórum e compare sua lógica com outras soluções.

## Aula 2: Regex

### Aula 2: Expressões regulares - Vídeo 1

Transcrição  
Vamos discutir sobre regex, que é a sigla para regular expressions (expressões regulares). Pelo próprio nome, conseguimos entender algumas características. A expressão regular é aquela que permite identificar padrões e regularidades em um texto.

Por exemplo, suponhamos que estejamos trabalhando em um banco, especificamente no sistema de PIX. Nesse contexto, queremos validar a entrada do usuário. O usuário digitará uma string, ou seja, um texto, e precisamos verificar se esse é um e-mail, telefone ou outro tipo de chave PIX. Caso não seja nenhum desses formatos, consideramos que o formato está inválido.

Para identificar esse tipo de informação, é essencial considerar os padrões das chaves PIX. Por exemplo, o CPF segue uma estrutura específica XXX.XXX.XXX-XX, assim como o CNPJ XX.XXX.XXX/XXXX-XX, o telefone (XX)XXXX-XXXX e o e-mail xxxxxx@xxx.xx.

Ao analisar esses padrões como seres humanos, conseguimos identificar qual dado estamos lidando. Para traduzirmos isso para nosso computador, em linguagem de programação, precisaremos usar as expressões regulares, que possuem diversos padrões.

**Padrões reconhecidos**  
Vamos analisar os padrões reconhecidos. Podemos representar diferentes tipos de símbolos.

|Símbolo|Descrição|
|--|--|
|.|Caractere, exceto quebra de linha|
|\d|Dígito (0-9)|
|\D|Caractere que não é um dígito|
|\w|Caractere alfanumérico|
|\W|Caractere não alfanumérico|
|\s|Espaço em branco|
|\S|Caractere que não é espaço em branco|
|^|Início da string|
|$|Fim da string|

Por exemplo, para indicar qualquer dígito de 0 a 9, usamos \d. Para um caractere alfanumérico, utilizamos \w. Já o ponto . representa qualquer caractere. Para definir o início de uma string, usamos o acento circunflexo ^, e para indicar o fim, o símbolo de dólar $. Existem diversos padrões disponíveis em tabelas que ajudam a representar diferentes caracteres.

Nesse caso, estamos lidando com a representação de um único símbolo, mas padrões costumam conter múltiplos elementos. Escrever \d\d\d. repetidamente não é eficiente. Para solucionar isso, utilizamos os chamados quantificadores.

Quantificadores

|Símbolo|Descrição|
|*|0 ou mais ocorrências do padrão anterior|
|+|1 ou mais ocorrências do padrão anterior|
|?|0 ou 1 ocorrência do padrão anterior|
|{n}|Exatamente n ocorrências do padrão anterior|
|{n,}|n ou mais ocorrências do padrão anterior|
|{n,m}|Entre n e m ocorrências do padrão anterior|

Se quisermos representar, por exemplo, três dígitos seguidos, usamos {n}, onde n indica a quantidade de repetições desejadas. No caso de um CPF, que possui três dígitos em determinadas partes, aplicamos \d{3}. Assim, conseguimos estruturar nossos padrões de forma mais clara e eficiente.

**Entendendo a construção de padrões para chaves PIX**  
Vamos pensar em como estruturar as chaves PIX utilizando essa linguagem de padrões. O CPF, como mencionado, é composto apenas por dígitos organizados em um formato específico: três dígitos, ponto, três dígitos, ponto, e assim por diante. Além disso, utilizamos os símbolos que indicam o início (^) e o fim ($) da string.

É importante notar que o ponto (.) tem um significado especial na sintaxe de expressões regulares, representando qualquer caractere. Para usá-lo literalmente, precisamos precedê-lo com uma barra invertida (\.).

```csharp
^\d{3}\.\d{3}\.\d{3}-\d{2}$}
```

O mesmo princípio se aplica ao CNPJ, que segue uma estrutura semelhante ao CPF, mas com um número maior de dígitos e a inclusão de uma barra (/) e um hífen (-).

```csharp
^\d{2}\.\d{3}\.\d{3}/d{4}-\d{2}$
```

Já, para o telefone há uma diferença. O padrão descrito no slide possui 5 dígitos no início do número de telefone. Mas, muitas vezes, temos telefones válidos que possuem apenas quatro dígitos. Para isso, utilizamos um quantificador diferente, do tipo {n} e {m}.

Usamos dois dígitos entre parênteses e, em seguida, utilizamos {4,5} para indicar que qualquer uma dessas quantidades é válida, e depois seguimos normalmente.

```csharp
^\(\d{2}\)\d{4,5}-\d{4}$
```

É importante notar que, quando queremos representar parênteses, eles têm um significado especial, pois servem para agrupar a expressão. Portanto, se desejamos incluir um parêntese específico, precisamos utilizá-los com caracteres escapados. Assim, usamos a contra barra antes de abrir e fechar o parêntese.

Para tipos numéricos, conseguimos tratar dessa forma. Agora, vamos focar nos textos, como o e-mail. Nesse caso, não sabemos exatamente o tamanho de um e-mail. Então, precisamos tratar outro tipo de padrão, reconhecido no regex, que são as classes de caracteres.

Classe de caracteres

|Símbolo|Descrição|
|--|--|
|[abc]|Qualquer caractere dentro dos colchetes ('a', 'b' ou 'c')|
|[^abc]|Qualquer caractere exceto os que não estejam dentro dos colchetes|
|[a-z]|Qualquer caractere minúsculo de 'a' a 'z'|
|[A-Z]|Qualquer caractere maiúsculo de 'A' a 'Z'|
|[0-9]|Qualquer dígito|
|[a-zA-Z]|Qualquer letra maiúscula ou minúscula|

Quando utilizamos colchetes com determinadas letras ou dígitos, conseguimos identificar um padrão sem precisar definir uma quantidade exata, o que é útil quando essa quantidade é variável. Existem diversas classes de caracteres que podemos usar, como letras minúsculas, maiúsculas e dígitos. Podemos aplicar esse conceito ao reconhecimento de e-mails.

Embora o padrão de e-mail possa parecer complexo, podemos dividi-lo em partes.

```csharp
^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$
```

Primeiro, temos o início e o fim da string, delimitando toda a estrutura. O e-mail é composto por duas partes separadas pela arroba @, o que vem antes e o que vem depois.

Na parte anterior à arroba, podemos ter caracteres variados, como letras maiúsculas e minúsculas, dígitos, ponto ., sublinhado _, porcentagem %, além dos sinais de mais + e menos -. Para garantir que essa parte não esteja vazia, utilizamos o quantificador +, que indica pelo menos uma ocorrência.

Após a arroba, encontramos letras, dígitos, pontos e hifens. Essa sequência deve ocorrer pelo menos uma vez. Por exemplo, em gmail.com, há um único domínio antes do ponto, enquanto em alura.com.br há duas partes antes da terminação final.

No final, precisamos garantir pelo menos duas letras, como em .br ou .com. Para isso, utilizamos {2,}, que indica no mínimo dois caracteres. Assim, conseguimos estruturar um padrão eficiente para validar e-mails.

**Métodos de regex no C#**  
Agora que conseguimos expressar em padrões o que queremos identificar, podemos usar essa linguagem de regex. No C#, existe uma classe específica chamada Regex, que possui diversos métodos para trabalhar com esses padrões.

|Método|Descrição|
|---|---|
|IsMatch()|Verifica se um padrão existe na string.|
|Match()|Retorna a primeira correspondência do padrão.|
|Matches()|Retorna todas as correspondências do padrão.|
|Replace()|Substitui ocorrências do padrão por uma nova string.|
|Split()|Divide uma string com base em um padrão.|

Temos o IsMatch(), para verificar se um padrão existe ou não na string. O Match(), que retorna a primeira correspondência do padrão. Se quisermos identificar a primeira ocorrência, usamos o Match(). Para retornar todas as correspondências, usamos o método Matches().

Também temos o Replace() e o Split(). Esses métodos são semelhantes aos que já vimos na classe de strings. A diferença é que, na classe de strings, precisamos passar um padrão exatamente como vemos a ocorrência. Nesse caso, podemos passar um padrão no estilo regex, o que é mais flexível.

Agora que conhecemos esse métodos, podemos passar para o Visual Studio.

### Aula 2:  - Vídeo 2
### Aula 2:  - Vídeo 3
### Aula 2:  - Vídeo 4
### Aula 2:  - Vídeo 5
### Aula 2:  - Vídeo 6
