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

## Aula 1 - Soma das vendas - Desafio 1

Imagine que uma loja de roupas te contratou para criar um sistema simples que ajude a registrar e somar os valores das vendas diárias. A loja não possui um sistema de caixa automatizado, então os funcionários precisam digitar manualmente o valor de cada venda ao final do dia. O desafio é criar um programa que permita a entrada desses valores de forma contínua até que o usuário digite "0", indicando que todas as vendas do dia foram registradas.

Crie um programa que:

- Solicite ao usuário que digite o valor de cada venda (inteiro).
- Enquanto o valor digitado for diferente de “0”, o programa adiciona o valor ao total acumulado. O valor precisa  ser solicitado ao menos uma vez antes de verificar se o loop deve continuar ou não.
- Quando o usuário digita “0”, o programa encerra o loop e exibe o total de vendas do dia.

Exemplo de entrada:

Digite o valor da venda (ou 0 para encerrar): 15
Digite o valor da venda (ou 0 para encerrar): 20
Digite o valor da venda (ou 0 para encerrar): 25
Digite o valor da venda (ou 0 para encerrar): 30
Digite o valor da venda (ou 0 para encerrar): 0

Saída esperada:

Total de vendas do dia: R$90

Opinião do instrutor

Nesta atividade, você teve a oportunidade de trabalhar com o laço do..while, uma estrutura de controle que permite a execução de um bloco de código repetidamente até que uma condição específica seja atendida. A principal característica do do..while é que ele garante a execução do bloco de código pelo menos uma vez, independentemente da condição, como é mostrado no fluxograma abaixo:

Fluxograma ilustrando a estrutura de um laço do..while. O processo começa no início, passando para o bloco 'Do' que executa o comando. Após a execução do comando, a condição do while é verificada. Se a condição for verdadeira, o fluxo retorna ao bloco 'Do'. Se for falsa, o fluxo segue para o final, encerrando o processo.

Neste caso, o laço do..while é útil pois queremos garantir que o usuário insira pelo menos um valor de venda, mesmo que seja o valor "0", que sinaliza o término da entrada de dados.

```C#
int valor, total = 0; 
do
{
    Console.Write("Digite o valor da venda (ou 0 para encerrar): ");
    valor = int.Parse(Console.ReadLine()); 
    total += valor;
} while (valor != 0); 
Console.WriteLine("Total de vendas do dia: R$" + total);
```

Agora é sua vez! Teste o programa, compartilhe no fórum e compare sua lógica com outras soluções.

## Aula 1 - Controle de estoque - Desafio 2

Imagine que você é responsável pelo setor de logística de uma loja de eletrônicos. Seu primeiro desafio é criar um sistema para registrar a entrada de produtos no estoque. Como a loja recebe mercadorias diariamente, você precisa de uma ferramenta que permita adicionar quantidades de forma ágil e que mostre o total acumulado, evitando erros manuais.

Crie um programa que:

- Pergunte ao usuário se ele deseja registrar uma nova entrada.
- Se sim, solicitar a quantidade e atualizar o estoque.
- Repetir o processo até que o usuário decida encerrar.

Exemplo de entrada:

Deseja adicionar um produto ao estoque?  
1 - Sim | 0 - Não  
1

Saída esperada:

Quantidade:  
5  
Estoque atual: 5

Deseja continuar?  
1 - Sim | 0 - Não
1  

Quantidade:  
10  
Estoque atual: 15

Deseja continuar?  
1 - Sim | 0 - Não  
0

Obrigado por usar nosso sistema de estoque!

Opinião do instrutor

Nesta atividade, utilizamos um loop while para manter o programa em execução enquanto o usuário desejar adicionar itens. A variável estoque atua como um acumulador, somando cada nova quantidade inserida.

- O loop continua enquanto resposta for 1.
- estoque += quantidade incrementa o valor atual do estoque.
- Quando o usuário responde algo diferente de "1", o loop é encerrado.

```C#
int estoque = 0;
Console.WriteLine("Deseja adicionar um produto ao estoque?");
Console.WriteLine("1 - Sim | 0 - Não");
int resposta = int.Parse(Console.ReadLine());
while (resposta == 1)
{
    Console.WriteLine("Quantidade:");
    int quantidade = Convert.ToInt32(Console.ReadLine());
    estoque += quantidade;
    Console.WriteLine($"Estoque atual: {estoque}");
    Console.WriteLine("Deseja continuar?");
    Console.WriteLine("1 - Sim | 0 - Não");
    resposta = int.Parse(Console.ReadLine());
}
Console.WriteLine("Obrigado por usar nosso sistema de estoque!");
```

Agora é sua vez! Teste o programa, compartilhe no fórum e compare sua lógica com outras soluções.

## Aula 1 - Número secreto - Desafio 3

Imagine que você está desenvolvendo um jogo onde o jogador deve tentar adivinhar qual é o número secreto. O desafio é criar um programa que continue solicitando tentativas até que o jogador acerte o número, fornecendo feedback a cada tentativa.

Crie um programa que:

- Declare uma variável com um inteiro para ser o número secreto.
- Verifique a cada interação se o número digitado é igual ao número secreto.
- Se o jogador errar, o programa informa que a tentativa está errada e solicita uma nova tentativa.
- Se o jogador acertar o número, o programa exibe uma mensagem de parabéns e encerra o jogo.

Exemplo de entrada:

Tente adivinhar o número entre 1 e 10: 7

Saída esperada:

Parabéns, você acertou!

Opinião do instrutor

Nessa atividade, utilizamos um laço while para criar um jogo interativo de adivinhação. O valor da tentativa do jogador é comparado ao número secreto, e, com base nessa comparação, o programa fornece feedback para guiar o jogador até o acerto.

Dentro do nosso loop, nós temos uma condicional que verifica se o número digitado é igual ao número secreto (if (tentativa == segredo)), e caso seja verdadeiro, a mensagem que o usuário acertou é exibida na tela para então o código ser encerrado com o break logo abaixo.

Na expressão while (tentativa != segredo), o operador != verifica se a tentativa do jogador é diferente do número secreto. Enquanto essa condição for verdadeira, o laço continua executando, solicitando novas tentativas. Quando o jogador acerta o número, a condição se torna falsa, e o laço é encerrado, exibindo a mensagem de parabéns.

```C#
int segredo = 7;
int tentativa;
 
while (true)
{
    Console.Write("Tente adivinhar o número entre 1 e 10: ");
    tentativa = int.Parse(Console.ReadLine());
 
    if (tentativa == segredo)
    {
        Console.WriteLine("Parabéns, você acertou!");
        break;
    }
    Console.WriteLine("Errado! Tente novamente.");
}
```

Agora é sua vez! Teste o programa, compartilhe no fórum e compare sua lógica com outras soluções.

## Aula 1 - Buscando em uma lista - Desafio 4

Imagine que você está desenvolvendo um sistema de chamada escolar para uma instituição de ensino. A pessoa responsável precisa verificar rapidamente se um aluno específico está presente na lista de chamada. Seu programa deve percorrer a lista de nomes e, ao encontrar o aluno procurado, interromper imediatamente.

Crie um programa que:

- Defina uma lista de nomes dos alunos.
- Utilize um loop para percorrer a lista.
- Interrompa a busca quando o nome desejado for encontrado.
- Informe se o nome não for encontrado.

Exemplo de entrada: Para a seguinte lista de nomes: { "Ana", "Carlos", "Bianca", "João", "Marina" }.

Digite o nome do aluno:  
João

Saída esperada (caso encontre):

Aluno encontrado na posição: 3

Saída esperada (caso não encontre):

Aluno não está presente na lista

Opinião do instrutor

Nesta atividade, exploramos o uso do loop while combinado com o comando break. O código utiliza um contador (indice++) para percorrer a lista, oferecendo um controle sobre o fluxo de execução. Quando o nome procurado é encontrado, o break interrompe imediatamente o loop, otimizando o processo de busca.

```C#
List`<string>` alunos = new List`<string>` { "Ana", "Carlos", "Bianca", "João", "Marina" };
 
Console.WriteLine("Digite o nome do aluno:");
string nomeBusca = Console.ReadLine();
int indice = 0;
bool encontrado = false; 
while (indice < alunos.Count)
{
    if (alunos[indice] == nomeBusca)
    {
        encontrado = true;
        break;  
    }
    indice++; 
}
if (encontrado)
{
    Console.WriteLine($"Aluno encontrado na posição: {indice}");
}
else
{
    Console.WriteLine("Aluno não está presente na lista");
}
```

Agora é sua vez! Teste o programa, compartilhe no fórum e compare sua lógica com outras soluções.

## Aula 1 - Senhas de atendimento - Desafio 5

Imagine que você trabalha em uma agência de atendimento ao cliente, como um banco ou uma loja de serviços. Sua tarefa é criar um sistema de senhas para organizar o atendimento dos clientes. O sistema deve permitir que novas senhas sejam geradas quando um cliente chega e que as senhas sejam chamadas quando um atendente está disponível. O desafio é garantir que o sistema funcione de forma eficiente, mantendo o controle das senhas geradas e das senhas já atendidas, proporcionando uma experiência organizada e justa para todos os clientes.

Crie um programa que:

Exiba um menu com as opções: Gerar nova senha, Chamar próxima senha e Sair.
Para a opção Gerar nova senha, o sistema deve gerar uma nova senha sequencial (por exemplo, 001, 002, 003, etc.).
Para a opção Chamar próxima senha, o sistema deve chamar a próxima senha disponível na fila, seguindo a ordem de chegada.
O menu deve ser exibido repetidamente até que o usuário escolha a opção Sair.
Dica: Você pode utilizar o método ToString("D3") para formatar a saída no formato: 001, 002, 003. Por exemplo:

```C#
Console.WriteLine("Senha gerada: " + senhaGerada.ToString("D3"));
```

Exemplo de entrada:

```C#
1 - Gerar nova senha
2 - Chamar próxima senha
3 - Sair
Escolha uma opção: 1
```

Saída esperada:

```C#
1 - Gerar nova senha
2 - Chamar próxima senha
3 - Sair
Escolha uma opção: 1
Senha gerada: 001
 
1 - Gerar nova senha
2 - Chamar próxima senha
3 - Sair
Escolha uma opção: 1
Senha gerada: 002
 
1 - Gerar nova senha
2 - Chamar próxima senha
3 - Sair
Escolha uma opção: 2
Senha chamada: 001
 
1 - Gerar nova senha
2 - Chamar próxima senha
3 - Sair
Escolha uma opção: 2
Senha chamada: 002


1 - Gerar nova senha
2 - Chamar próxima senha
3 - Sair
Escolha uma opção: 4
Opção inválida.
 
1 - Gerar nova senha
2 - Chamar próxima senha
3 - Sair
Escolha uma opção: 3
Encerrando sistema.
```

Opinião do instrutor

Nessa atividade, utilizamos dois contadores para simular um sistema de senhas de atendimento. O primeiro contador (senhaGerada) é responsável por gerar novas senhas sequenciais, enquanto o segundo contador (senhaAtual) controla qual senha deve ser chamada para atendimento.

A estrutura do menu é controlada por um laço do..while, que mantém o sistema em execução até que o usuário escolha a opção Sair. Dentro do laço, um switch..case é usado para tratar as diferentes escolhas do usuário: gerar uma nova senha, chamar a próxima senha ou encerrar o sistema.

Um ponto importante nesta atividade é o uso do método ToString("D3"). Esse método formata o número da senha para que ele sempre tenha três dígitos, preenchendo com zeros à esquerda, se necessário. Por exemplo, o número 1 é exibido como 001, e o número 12 como 012.

```C#
int senhaGerada = 0;
int senhaAtual = 0;
int opcao;
 
do
{
Console.WriteLine("1 - Gerar nova senha");
Console.WriteLine("2 - Chamar próxima senha");
Console.WriteLine("3 - Sair");
Console.Write("Escolha uma opção: ");
opcao = int.Parse(Console.ReadLine());
 
switch (opcao)
{
    case 1:
        senhaGerada++;
        Console.WriteLine("Senha gerada: " + senhaGerada.ToString("D3"));
        break;
    case 2:
        senhaAtual++;
        Console.WriteLine("Senha chamada: " + senhaAtual.ToString("D3"));
        break;
    case 3:
        Console.WriteLine("Encerrando sistema.");
        break;
    default:
        Console.WriteLine("Opção inválida.");
        break;
}
} while (opcao != 3);
```

## Aula 1 - Conversor de temperatura - Desafio 6

Você está desenvolvendo um conversor de temperatura que permite ao usuário escolher entre duas opções: converter de Celsius para Fahrenheit ou de Fahrenheit para Celsius. O programa deve exibir um menu com essas opções e repetir até que o usuário escolha sair.

Para isso, você precisará de um programa que:

- Exiba um menu com as opções de conversão e saída.
- Permita ao usuário escolher uma das opções.
- Exiba uma mensagem de Operação inválida caso escolhido uma opção que não existe.
- Realize a conversão de temperatura com base na escolha do usuário.
- Repita o menu até que o usuário escolha sair.

Dicas:

> Fórmula para conversão de Celsius para fahrenheit: (celsius * 9 / 5) + 32
> Fórmula para conversão de fahrenheit para Celsius: (fahrenheit - 32) * 5 / 9

Exemplo de entrada:

1 - Celsius para Fahrenheit  
2 - Fahrenheit para Celsius  
3 - Sair

Escolha uma opção: 1  
Digite a temperatura em Celsius: 25

Saída esperada:

25°C equivalem a 77°F

Opinião do instrutor

Nessa atividade, a estrutura switch é utilizada para tratar as diferentes opções do menu, permitindo que o programa execute a conversão correta com base na escolha do usuário. As fórmulas de conversão são aplicadas diretamente dentro de cada caso do switch, garantindo que o cálculo seja realizado de forma precisa. A repetição do menu é controlada pela condição do do..while, que só é interrompida quando o usuário seleciona a opção de saída.

```C#
int opcao;
do
{
    Console.WriteLine("1 - Celsius para Fahrenheit");
    Console.WriteLine("2 - Fahrenheit para Celsius");
    Console.WriteLine("3 - Sair");
    Console.Write("Escolha uma opção: ");
    opcao = int.Parse(Console.ReadLine());
    switch (opcao)
    {
        case 1:
            Console.Write("Digite a temperatura em Celsius: ");
            double celsius = double.Parse(Console.ReadLine());
            double fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine($"{celsius}°C equivalem a {fahrenheit}°F");
            break;
        case 2:
            Console.Write("Digite a temperatura em Fahrenheit: ");
            double fahr = double.Parse(Console.ReadLine());
            double cel = (fahr - 32) * 5 / 9;
            Console.WriteLine($"{fahr}°F equivalem a {cel}°C");
            break;
        case 3:
            Console.WriteLine("Saindo...");
            break;
        default:
            Console.WriteLine("Opção inválida. Tente novamente.");
            break;
    }
} while (opcao != 3);
```

Agora é sua vez! Teste o programa, compartilhe no fórum e compare sua lógica com outras soluções.

## Aula 2 - Laço for - Vídeo 1

Transcrição  
Conhecemos dois laços bastante comuns na linguagem C#: o while e o do while. Além disso, entendemos que esses laços possuem três elementos fundamentais:

- A inicialização;
- A condição;
- E a atualização.

Em C#, existe um laço que une essas três partes em uma única linha: o for.

Utilizando o laço de repetição for

Entendendo a sintaxe do laço for

Abaixo, podemos observar a sintaxe desse tipo de laço:

```csharp
for (inicialização; condição; atualização)
{
    bloco de código
}
```

Inicialmente, declaramos um for e abrimos parênteses. Entre esses parênteses, teremos três elementos separados por ponto e vírgula. São eles:

A inicialização da variável;  
A condição para o funcionamento do laço, com base na variável inicializada;
E a atualização, definindo como a variável deve ser modificada com o tempo.
Após declarar esses três elementos, podemos abrir chaves e inserir dentro delas o bloco de código que desejamos repetir com o laço for.

Construindo um laço for  
Agora, observaremos na prática como funciona o laço for. No arquivo Program.cs no Visual Studio, temos o exemplo do while feito anteriormente:

Program.cs:

```csharp
int contador = 10;
while (contador >= 1)
{
    Console.WriteLine(contador);
    contador--;
}
Console.WriteLine("A contagem chegou ao fim!");
```

Podemos declarar um for usando como base as condições estabelecidas. Para isso, precisamos declarar inicialmente a inicialização. Nesse caso, a inicialização corresponde à declaração de int contador = 10, então faremos o mesmo.

A condição é que contador seja maior ou igual (>=) a 1. Além disso, queremos atualizar o contador, então adicionaremos contador--. Em seguida, entre chaves, colocaremos o que deve se repitir. Nesse caso, vamos utilizar Console.WriteLine() recebendo contador entre parênteses.

No loop for, não precisamos colocar contador-- no escopo, pois ele está na declaração.

```csharp
// código omitido
for (int contador = 10; contador >= 1; contador--)
{
    Console.WriteLine(contador);
}
```

Nesse momento, o compilador reclama um erro, pois a variável contador já foi declarada. Para solucionar, basta comentar o trecho do laço while acima.

```csharp
/*int contador = 10;
while (contador >= 1)
{
    Console.WriteLine(contador);
    contador--;
}
Console.WriteLine("A contagem chegou ao fim!");*/

// código omitido
```

Uso comum de variáveis em laços for  
Uma prática comum ao usar loops, especialmente o for, é utilizar uma variável chamada i. Podemos declarar int i, e enquanto i for maior ou igual a 1, faremos i--.

```csharp
// código omitido

for (int i = 10; i >= 1; i--)
{
    Console.WriteLine(i);
}
```

Esse é o padrão geralmente utilizado com o for, por isso usaremos esse nome de variável. Ele é bastante comum, pois trabalharemos com a variável i somente dentro do loop.

Assim, deixamos apenas uma letra para facilitar a indexação.

Verificando o resultado  
Uma vez declarado o laço for, podemos verificar se ele funciona corretamente.

Ao executar, teremos o contador regressivo no terminal. Falta apenas exibir que a contagem chegou ao fim. Nesse caso, basta adicionar a mensagem com WriteLine().

```csharp
// código omitido
for (int i = 10; i >= 1; i--)
{
    Console.WriteLine(i);
}
Console.WriteLine("A contagem chegou ao fim!");
```

Como resultado, temos valores listados de 10 a 1, em ordem decrescente, finalizando com a mensagem "A contagem chegou ao fim!", conforme configurado.

Conclusão  
Assim, entendemos como o paralelo de juntar coisas em uma única linha funciona!

## Aula 2 -  Manipulando laços: break e continue - Vídeo 2

Transcrição  
Anteriormente, conhecemos os três tipos de loops em C#:

- while;
- do while;
- E for.

Estamos em uma situação padrão, que é executar o loop até o fim. No entanto, existem situações em que podemos querer alterar o fluxo de execução de alguma forma. Para isso, manipulamos o laço de repetição utilizando duas palavras-chave específicas: break e continue.

Manipulando laços com break e continue

Analisando um exemplo prático  
Entenderemos melhor a manipulação do laço de repetição no Visual Studio. Com o arquivo Program.cs aberto, trabalharemos em um novo exemplo:

Program.cs:

```csharp
// código omitido

List<string> funcionarios = new List<string>
        {
            "João-Gerente-8500",
            "Maria-Analista de Sistemas-6200",
            "Carlos-Desenvolvedor-5500",
            "Ana-Designer-4800",
            "Pedro-Suporte Técnico-3900",
            "Fernanda-Coordenadora de Projetos-7300",
            "Ricardo-Contador-6000",
            "Juliana-RH-4500"
        };
```

O código acima representa uma lista de funcionários.

Qual é a ideia dessa lista? Suponha que temos uma API ou um arquivo do qual lemos os dados de alguma forma. Isso é bastante comum no dia a dia.

Uma vez que obtemos os dados, eles estão disponíveis na lista.

Buscando um funcionário específico com break  
A ideia é percorrer a lista de funcionários até encontrar, por exemplo, os dados de Fernanda. Temos vários nomes e dados de funcionários, seguindo a estrutura Nome-Cargo-Salário, e queremos pegar especificamente os dados de Fernanda. Essa é uma prática frequente em buscas no cotidiano.

Como fazer isso utilizando estruturas de repetição?

Podemos declarar um laço for, onde a condição é int i = 0. O i deve ser do tamanho da lista. Poderíamos contar quantas pessoas há na lista, mas, em situações em que lidamos com arquivos gigantes ou buscamos dados em uma API, é inviável contar manualmente.

Portanto, é melhor computar isso utilizando funções do C#. Utilizaremos funcionarios.Count para obter o tamanho da lista, evitando a contagem manual. Dessa forma, enquanto i for menor ou igual a funcionarios.Count, incrementamos i e percorremos a lista.

```csharp
// código omitido
for (int i = 0; i < funcionarios.Count; i++)
{

}
```

O objetivo é, para cada linha, pegar a primeira parte da estrutura Nome-Cargo-Salário e verificar se corresponde a "Fernanda". Das três partes disponíveis, usaremos a primeira.

Para fazer isso, usamos a manipulação de strings. No escopo do for, teremos uma variável var nome. O nome será obtido de cada linha da coleção de funcionários. Podemos atribuir funcionarios[i] à variável nome para indexar e pegar a posição i da coleção.

Na sequência, vamos separar a estrutura conforme os hifens usando o método Split(). Entre os parênteses, passaremos a string do hífen (-). O Split() dividirá a linha em três partes: 0, 1 e 2. O nome está na parte 0, então usaremos novamente os colchetes para pegar a posição [0]. Feito isso, vamos conferir se o nome é igual a "Fernanda" com o método Equals().

```csharp
// código omitido
for (int i = 0; i < funcionarios.Count; i++)
{
    var nome = funcionarios[i].Split("-")[0];
    if (nome.Equals("Fernanda"))
    {

    }
}
```

Como buscamos por Fernanda, se nome for igual a "Fernanda", podemos imprimir os dados. Para isso, usaremos Console.WriteLine() nos dados da Fernanda.

Adicionaremos uma interpolação de string para dizer: $"Dados do funcionário buscado: ". Em seguida, passaremos o conteúdo da lista, que será {funcionarios[i]}, posição desejada.

Ao fazer isso, percorremos a lista de funcionários e, ao encontrar a Fernanda, não precisamos passar pelo Ricardo e pela Juliana, então podemos parar o loop.

Para isso, manipulamos o fluxo de execução utilizando a palavra-chave break.

```csharp
// código omitido

for (int i = 0; i < funcionarios.Count; i++)
{
    var nome = funcionarios[i].Split("-")[0];
    if (nome.Equals("Fernanda"))
    {
        Console.WriteLine($"Dados do funcionário buscado: {funcionarios[i]}");
        break;
    }
}
```

Filtrando funcionários por salário com continue  
Temos também a palavra-chave continue. Para pensar no continue, suponha que queremos exibir todos os funcionários com salário menor do que R$ 5.000.

Isso significa que iremos ignorar funcionários quem têm salários maiores do que R$ 5.000, pois são condições opostas. Para representar isso, usamos o continue.

Podemos copiar o laço for para agilizar o processo, mas agora nosso interesse é o salário dos funcionários. Vamos criar uma variável chamada salario, que está disponível na posição 2 do array gerado pelo Split(), então usamos o índice 2.

```csharp
// código omitido

for (int i = 0; i < funcionarios.Count; i++)
{
    var salario = funcionarios[i].Split("-")[2];
    if (nome.Equals("Fernanda"))
    {
        Console.WriteLine($"Dados do funcionário buscado: {funcionarios[i]}");
        break;
    }
}
```

No entanto, o salario será do tipo string. Precisamos convertê-lo para int, então após a declaração de salario, criaremos var salarioInt, que será igual a int.Parse(salario).

```csharp
// código omitido

for (int i = 0; i < funcionarios.Count; i++)
{
    var salario = funcionarios[i].Split("-")[2];
    var salarioInt = int.Parse(salario);
    if (nome.Equals("Fernanda"))
    {
        Console.WriteLine($"Dados do funcionário buscado: {funcionarios[i]}");
        break;
    }
}
```

Com a variável salarioInt, a ideia é ignorar todos os funcionários com salário maior que R$ 5.000.

Faremos um if para verificar se salarioInt é maior que R$ 5.000. Se for, ignoramos o loop e não executamos o conteúdo. Após apagar o trecho de código do escopo do bloco if, adicionaremos a instrução continue. O continue retorna para o início do for, sem executar o restante do loop. Assim, se o salário for maior que R$ 5.000, continuamos. Se for menor, imprimimos.

```csharp
// código omitido
for (int i = 0; i < funcionarios.Count; i++)
{
    var salario = funcionarios[i].Split("-")[2];
    var salarioInt = int.Parse(salario);
    if (salarioInt > 5000)
    {
        continue;
    }
    Console.WriteLine($"Dados do funcionário buscado: {funcionarios[i]}");
}
```

Ao executar o programa, recebemos os dados corretos. A primeira impressão é do exemplo anterior, em que buscávamos a Fernanda, mas as três últimas linhas mostram os salários menores do que R$ 5.000, que são da Ana, do Pedro e da Juliana.

Retorno no terminal:

```csharp
Dados do funcionário buscado: Fernanda-Coordenadora de Projetos-7300
Dados do funcionário buscado: Ana-Designer-4800
Dados do funcionário buscado: Pedro-Suporte Técnico-3900
Dados do funcionário buscado: Juliana-RH-4500
```

Conclusão

O break nos faz sair imediatamente do loop, evitando instruções e verificações adicionais no laço for, enquanto o continue nos faz voltar para a verificação e executar tudo novamente, ignorando o restante das instruções. Nos encontramos no próximo vídeo, onde falaremos sobre o laço while!

## Aula 2 - Foreach - Vídeo 3


## Aula 2 -  - Vídeo 4
## Aula 2 -  - Vídeo 1
## Aula 2 -  - Desafio 1
## Aula 2 -  - Desafio 2
## Aula 2 -  - Desafio 3
## Aula 2 -  - Desafio 4
## Aula 2 -  - Desafio 5
## Aula 2 -  - Desafio 6
## Aula 2 -  - Desafio 
