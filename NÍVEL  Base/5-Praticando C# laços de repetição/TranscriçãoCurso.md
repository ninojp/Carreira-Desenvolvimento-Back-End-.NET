# Curso Alura Praticando C# laços de repetição

## Aula 1 - O que esperar deste curso?

Antes de mergulharmos no código, que tal alinharmos as expectativas?

O que significa um curso prático?  
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

## Aula 1 - Apresentação - Vídeo 1

Transcrição  
Boas-vindas! Meu nome é Iasmin Araújo, sou instrutora na Escola de Programação da Alura, e irei te acompanhar ao longo dessa jornada de aprendizagem.

Audiodescrição: Iasmin se descreve como uma mulher branca, com cabelo castanho-escuro longo e liso repartido ao meio, sobrancelhas castanho-escuras, e olhos verdes. Ela veste uma blusa bege, e está sentada em uma cadeira preta com detalhes em rosa-claro, em frente a um microfone cinza, com uma parede clara ao fundo iluminada em gradiente azul.

O que vamos aprender?  
Neste curso, vamos praticar os laços de repetição. Para isso, abordaremos diversos tópicos:

- Como funcionam os laços de repetição;
- Quais são os laços de repetição em C#;
- Aprenderemos a usar while, do while, for e foreach;
- Entenderemos o que leva à ocorrência de loops infinitos;
- Conheceremos as palavras-chave break e continue.

Conclusão  
Essa diversidade de tópicos nos permitirá praticar e aprofundar bastante nossos conhecimentos. No próximo vídeo, daremos início à prática. Esperamos você na sequência!

## Aula 1 - Preparando o ambiente: instalando o Visual Studio

Olá!  
O IDE do Visual Studio é uma plataforma de lançamento criativa que você pode usar para editar, depurar e criar código e, em seguida, publicar um aplicativo. Além do editor e depurador padrão fornecidos pela maioria dos IDEs, o Visual Studio inclui compiladores, ferramentas de conclusão de código, designers gráficos e muitos outros recursos para aprimorar o processo de desenvolvimento de software. O IDE mais abrangente para desenvolvedores .NET no Windows e Mac para criação de web, nuvem, desktop, aplicativos móveis, serviços e jogos.

Sabendo disso, preparamos alguns vídeos para instalar em diferentes sistemas operacionais. Para este curso em específico, marque a opção Desenvolvimento para Desktop com .NET. no processo de instalação.

(videos internos da plataforma, sem links externos)

- Visual Studio no Windows
- Visual Studio no Mac
- C# no VSCODE (SDK)

C# em distribuições Linux  
Neste link, você encontra um passo a [passo da própria Microsoft de como instalar em distribuições Linux](https://learn.microsoft.com/pt-br/dotnet/core/install/linux), como Alpine, CentOS, Debian, entre outras.

Vamos começar?

## Aula 1 - Preparando o ambiente: material de apoio

Após revisar os conceitos de laços de repetição em C#, é hora de colocar o conhecimento em prática com uma série de atividades focadas no tema. Caso queira acessar os slides da revisão, eles estão disponíveis no link abaixo:

[Baixe os slides do curso](https://cdn3.gnarususercontent.com.br/4569-Praticando%20C%20Loops%20com%20for%20e%20while/Praticando%20C%23_%20la%C3%A7os.pdf)

Após finalizar todos os desafios, não esqueça de compartilhar sua solução no fórum. Será incrível ver como você resolveu!

Vamos nessa?

## Aula 1 - While - Vídeo 2

Transcrição  
Neste vídeo, trabalharemos com o laço de repetição while.

Utilizando o laço de repetição while  
Para começar, vamos considerar a seguinte tarefa: queremos criar um contador regressivo que imprima os números de 5 até 1, em ordem decrescente, e, ao final, informe que a contagem chegou ao fim. No Visual Studio, já temos uma solução para esse problema, que consiste em imprimir cada número individualmente. Abaixo, temos o código inicial usado para isso:

Program.cs:

```C#
Console.WriteLine(5);
Console.WriteLine(4);
Console.WriteLine(3);
Console.WriteLine(2);
Console.WriteLine(1);

Console.WriteLine("A contagem chegou ao fim!");
```

Vamos executar para conferir se a solução funciona? O resultado esperado aparece no terminal normalmente, com os números em ordem decrescente e a mensagem.

Retorno no terminal:

```C#
5
4
3
2
1
A contagem chegou ao fim!
```

Incrementando o contador regressivo  
Agora, imagine que queremos incrementar essa solução. Dessa forma, em vez de um contador regressivo de 5 até 1, queremos que vá de 10 até 1. Para isso, seguindo o padrão atual, podemos duplicar várias vezes o Console.WriteLine() e atualizar os valores. Teremos um Console.WriteLine() para 10, 9, 8, 7 e 6. Na sequência, continuamos como estava anteriormente.

```C#
Console.WriteLine(10);
Console.WriteLine(9);
Console.WriteLine(8);
Console.WriteLine(7);
Console.WriteLine(6);
Console.WriteLine(5);
Console.WriteLine(4);
Console.WriteLine(3);
Console.WriteLine(2);
Console.WriteLine(1);

Console.WriteLine("A contagem chegou ao fim!");
```

Ao executar a aplicação, ela funcionará conforme esperado.

Entretanto, se quisermos evoluir ainda mais a contagem regressiva, com valores de 30 até 1, será que a melhor forma seria imprimir mais 20 vezes com Console.WriteLine()?

O que são laços de repetição?  
Escrever repetidamente não parece ser a melhor abordagem. Para isso, as linguagens de programação oferecem uma estrutura específica: os laços de repetição.

Vamos analisar como os laços de repetição funcionam? Um laço permite executar comandos se uma condição for verdadeira. Com base nisso, há 3 tipos de laços:

- while;
- do while;
- for.

Todos são disponibilizados pelo C# para realizar repetições.

Entendendo a sintaxe do laço while  
O laço de repetição while possui a seguinte sintaxe:

```C#
while (condição)
{
    bloco de código
}
```

Inicialmente, temos a palavra-chave while, que significa "enquanto" em inglês, seguida de parênteses contendo uma condição. Enquanto essa condição for verdadeira, executaremos repetidamente um bloco de código específico, escrito entre chaves.

Operadores de comparação e operadores lógicos  
Para definir essas condições, utilizamos operadores de comparação, apresentados no curso da Alura sobre condicionais, e operadores lógicos, como AND, OR e NOT.

Esses operadores são usados para verificar condições.

Operadores de comparação:

|Operador |Significado     |Exemplo |
|---------|----------------|--------|
| >       |Maior que       |x > 10  |
| <       |Menor que       |x < 10  |
| ==      |Igual a         |x == 10 |
| !=      |Diferente de    |x != 10 |
| >=      |Maior ou igual a|x >= 10 |
| <=      |Menor ou igual a|x <= 10 |

Construindo um laço while  
Vamos entender na prática como utilizar o while? Comentaremos o código anterior e adaptaremos para obter o mesmo resultado, mas usando o laço while.

Continuaremos com um contador regressivo de 10 até 1. Para isso, precisamos de uma condição: o número a ser impresso deve ser maior ou igual a 1.

A contagem regressiva começa em 10, então podemos criar uma variável chamada contador, que será um int, e essa variável receberá o valor inicial de 10.

```C#
/*Console.WriteLine(10);
Console.WriteLine(9);
Console.WriteLine(8);
Console.WriteLine(7);
Console.WriteLine(6);
Console.WriteLine(5);
Console.WriteLine(4);
Console.WriteLine(3);
Console.WriteLine(2);
Console.WriteLine(1);

Console.WriteLine("A contagem chegou ao fim!");*/

int contador = 10;
```

Feito isso, podemos pensar no laço. Começaremos declarando while; depois, vamos abrir e fechar parênteses, onde passaremos a condição de que a variável contador seja maior ou igual a 1 (>= 1).

No escopo do while, adicionaremos o que deve se repetir. Queremos que o número do contador seja impresso, então utilizamos Console.WriteLine(contador).

A variável contador precisa ser atualizada, ou seja, a ideia é que ela comece com 10, mas diminua com o tempo. Para isso, decrementamos com contador--.

No final da contagem regressiva, após repetir várias vezes a impressão dos números, queremos simplesmente indicar que a contagem acabou. Para isso, usaremos um Console.WriteLine() com a mensagem "A contagem chegou ao fim!".

```C#
// código omitido
int contador = 10;
while (contador >= 1)
{
    Console.WriteLine(contador);
    contador--;
}
Console.WriteLine("A contagem chegou ao fim!");
```

Verificando o resultado  
Vamos executar o programa para verificar o resultado? Assim, podemos explorar melhor como o loop funciona. Ao executar, temos uma contagem de 10 até 1 e a contagem chega ao fim.

Com tudo correto no comportamento do programa, podemos explorar mais a fundo como isso funciona. Primeiro, criamos a variável contador com o valor 10. Como o C# lê essas instruções?

Temos um while, que significa "enquanto", e a condição que precisa ser verificada. A partir disso, ele observa a variável contador no momento atual.

Ao começar, o valor é 10, então verificamos: 10, valor do contador, é maior ou igual a 1? Se sim, imprimimos o contador atual, que é 10. Após imprimir 10, podemos atualizar o contador, que fará um decremento e passará a valer 9.

Quando chegamos ao fechamento das chaves, voltamos para o laço while. Por isso, dizemos que é um laço, pois fazemos voltas, como se andássemos em círculos.

Nesse momento, verificamos se o contador atual, agora igual a 9, é maior ou igual a 1. Se sim, imprimimos e atualizamos novamente; com isso, passa a valer 8.

Depois voltamos e permanecemos nesse loop até chegarmos ao número 1. Quando chegamos ao número 1, ele verifica: o contador, que vale 1, é maior ou igual a 1? Sim, então imprimimos, fazemos o decremento, e o contador passa a valer 0.

Agora, ao final do laço, o contador valerá 0, que não é maior ou igual a 1, por isso, não entramos no loop do while novamente. Na próxima linha, indicamos que a contagem chegou ao fim. Esse é o comportamento de um loop, ou seja, de um laço: ele percorre círculos até chegar ao final.

## Aula 1 - Do while - Vídeo 3

Transcrição  
Além do laço while, temos algumas outras estruturas, como o do while.

Utilizando o laço de repetição do while

Entendendo a sintaxe do laço do while  
O laço do while é semelhante ao while, mas com uma diferença crucial: ele garante que o bloco de código seja executado pelo menos uma vez antes de verificar a condição, pois a condição é testada após a execução do bloco.

Observe abaixo a sintaxe do laço de repetição do while:

```C#
do
{
    bloco de código
}
while (condicao);
```

No laço de repetição do while, utilizamos inicialmente a palavra-chave do e abrimos chaves logo abaixo, onde vamos inserir um bloco de código que será executado. Depois, fazemos a verificação da condição no bloco while.

A diferença entre o while e o do while é que, no do while, executamos a instrução pelo menos uma vez. Já no while, pode ser que a instrução nunca seja executada, pois a condição é testada antes da execução.

Construindo um laço do while  
Se quisermos adaptar o while para do while, podemos copiar o que fizemos anteriormente, comentar o laço while, e colar o trecho abaixo para realizar os ajustes necessários. Em seguida, basta recortar o while com a condição para o final do bloco, e adicionar a palavra-chave do antes da abertura de chaves.

Program.cs:

```C#
// código omitido

int contador = 10;
do
{
    Console.WriteLine(contador);
    contador--;
}
while (contador >= 1);
Console.WriteLine("A contagem chegou ao fim!");
```

A diferença é que o do executa o bloco antes de fazer o teste. Ao executar, teremos o mesmo resultado tanto para o while quanto para o do while.

No entanto, se contador for igual a 0, o do executa. Ele imprime o 0 no retorno e depois diz que a contagem chegou ao fim, pois a tradução de do é "execute", ou seja, faça algo antes de testar. Ele imprime o contador antes de testar se é maior ou igual a 1, enquanto no while isso não acontece.

Utilizando o laço do while em menus  
Uma utilidade interessante ao trabalhar com loops é quando queremos mostrar um menu para a pessoa usuária até que ela escolha sair.

No curso em que abordamos switch case, havia um menu com três opções:

- Visualizar produtos (Opção 1);
- Fazer pedido (Opção 2);
- Sair (Opção 0).

```C#
// código omitido
Console.WriteLine("\nMENU:");
Console.WriteLine("1 - Ver produtos");
Console.WriteLine("2 - Fazer pedido");
Console.WriteLine("0 - Sair");
Console.Write("Escolha uma opção: ");

int opcao = int.Parse(Console.ReadLine());

switch(opcao)
{
    case 1:
        Console.WriteLine("Mostrando produtos…");
        break;
    case 2:
        Console.WriteLine("Pedido realizado!");
        break;
    case 0:
        Console.WriteLine("Saindo…");
        break;
    default:
        Console.WriteLine("Opção inválida!");
        break;
}
```

A pessoa usuária escolheria uma opção com base no que desejava. Se fosse 1, os produtos seriam exibidos; se fosse 2, o pedido seria feito; e assim por diante.

Podemos criar um laço de repetição do while para manter o menu ativo até que a pessoa usuária digite 0 para sair. Vamos entender como isso é feito?

Para começar, vamos declarar um bloco do e mover as instruções para seu escopo. Feito isso, adicionaremos a condição no while após as chaves. Nesse caso, a condição é que a pessoa usuária precisa digitar 0 para sair do menu. Portanto, enquanto a variável opcao for diferente (!=) de 0, continuamos no loop.

Importante! A variável opcao deve ser declarada fora do loop para que possa ser atualizada conforme a pessoa usuária digitar sua escolha.

```C#
// código omitido

int opcao;
do
{
    Console.WriteLine("\nMENU:");
    Console.WriteLine("1 - Ver produtos");
    Console.WriteLine("2 - Fazer pedido");
    Console.WriteLine("0 - Sair");
    Console.Write("Escolha uma opção: ");

    opcao = int.Parse(Console.ReadLine());

    switch(opcao)
    {
        case 1:
            Console.WriteLine("Mostrando produtos…");
            break;
        case 2:
            Console.WriteLine("Pedido realizado!");
            break;
        case 0:
            Console.WriteLine("Saindo…");
            break;
        default:
            Console.WriteLine("Opção inválida!");
            break;
    }
} 
while (opcao != 0);
```

Observação: para tornar a execução mais organizada, podemos limpar a tela após cada escolha da pessoa usuária utilizando o método Console.Clear(). No entanto, optamos por não limpar a tela para manter as opções anteriores visíveis.

Verificando o resultado  
Ao executar a aplicação, temos o menu com as três opções. Quando escolhemos a opção 1, por exemplo, os pedidos são exibidos e o menu surge novamente. Da mesma forma, quando escolhemos a opção 2, é exibido na tela e temos de novo o menu.

Resolvendo o problema de loop infinito  
Por fim, lembre-se que, para um loop funcionar corretamente, precisamos de três elementos: *inicialização; condição; e atualização de uma variável.

Sem atualizar a variável, enfrentamos o problema do loop infinito. Por exemplo: se esquecermos de decrementar o contador, o loop nunca terminará.

Vamos ao Visual Studio para ilustrar melhor?

Sobre o problema do loop infinito, se voltarmos ao while, precisamos da inicialização, como definir o contador igual a 0; da condição, como o contador ser maior ou igual a 1; e da atualização, como contador--.

Sem atualização, teremos um loop infinito.

```C#
// código omitido

int contador = 0;
while (contador >= 1)
{
    Console.WriteLine(contador);
    contador--;
}
Console.WriteLine("A contagem chegou ao fim!");

// código omitido
```

Executar esse código sem a linha de atualização resultará em um loop infinito, pois o contador nunca será decrementado, mantendo a condição sempre verdadeira.

Conclusão  
Com isso, conseguimos entender operadores, loops e laços de repetição em C#. Na sequência, discutiremos outros loops da linguagem C#!

## Aula 1 -  - Desafio 1
Soma das vendas
 Próxima Atividade

Imagine que uma loja de roupas te contratou para criar um sistema simples que ajude a registrar e somar os valores das vendas diárias. A loja não possui um sistema de caixa automatizado, então os funcionários precisam digitar manualmente o valor de cada venda ao final do dia. O desafio é criar um programa que permita a entrada desses valores de forma contínua até que o usuário digite "0", indicando que todas as vendas do dia foram registradas.

Crie um programa que:

Solicite ao usuário que digite o valor de cada venda (inteiro).
Enquanto o valor digitado for diferente de “0”, o programa adiciona o valor ao total acumulado. O valor precisa ser solicitado ao menos uma vez antes de verificar se o loop deve continuar ou não.
Quando o usuário digita “0”, o programa encerra o loop e exibe o total de vendas do dia.
Exemplo de entrada:

Digite o valor da venda (ou 0 para encerrar): 15
Digite o valor da venda (ou 0 para encerrar): 20
Digite o valor da venda (ou 0 para encerrar): 25
Digite o valor da venda (ou 0 para encerrar): 30
Digite o valor da venda (ou 0 para encerrar): 0
Copiar código
Saída esperada:

Total de vendas do dia: R$90
Copiar código
Ver opinião do instrutor
Opinião do instrutor

Nesta atividade, você teve a oportunidade de trabalhar com o laço do..while, uma estrutura de controle que permite a execução de um bloco de código repetidamente até que uma condição específica seja atendida. A principal característica do do..while é que ele garante a execução do bloco de código pelo menos uma vez, independentemente da condição, como é mostrado no fluxograma abaixo:

Fluxograma ilustrando a estrutura de um laço do..while. O processo começa no início, passando para o bloco 'Do' que executa o comando. Após a execução do comando, a condição do while é verificada. Se a condição for verdadeira, o fluxo retorna ao bloco 'Do'. Se for falsa, o fluxo segue para o final, encerrando o processo.

Neste caso, o laço do..while é útil pois queremos garantir que o usuário insira pelo menos um valor de venda, mesmo que seja o valor "0", que sinaliza o término da entrada de dados.

int valor, total = 0;
 
do
{
    Console.Write("Digite o valor da venda (ou 0 para encerrar): ");
    valor = int.Parse(Console.ReadLine());
 
    total += valor;
} while (valor != 0);
 
Console.WriteLine("Total de vendas do dia: R$" + total);
Copiar código
Agora é sua vez! Teste o programa, compartilhe no fórum e compare sua lógica com outras soluções.

## Aula 1 -  - Desafio 2
## Aula 1 -  - Desafio 3
## Aula 1 -  - Desafio 4
## Aula 1 -  - Desafio 5
## Aula 1 -  - Desafio 6
