# Curso Alura - Praticando C#: orientação a objetos com polimorfismo

## Aula 1 - Polimorfismo de sobrecarga e sobrescrita

### Aula 1 - Apresentação - Vídeo 1

Transcrição  
Olá! Meu nome é Yasmin Araújo e faço parte do time da Escola de Programação.

Audiodescrição: Yasmin é uma mulher branca, com cabelo castanho escuro na altura dos ombros. Ela veste uma blusa rosa e, ao fundo, há uma parede iluminada com luz azul.

**Introdução ao Curso de Polimorfismo**  
Neste curso, nós vamos trabalhar com polimorfismo, que é o último pilar da orientação a objetos.

**Estrutura do Curso**  
Para começar, vamos explorar o conceito de polimorfismo, tanto pela definição quanto pela prática, e como podemos utilizá-lo em C#. Em seguida, trabalharemos com os diferentes tipos de polimorfismo. Vamos analisar o polimorfismo de sobrecarga, o polimorfismo de sobrescrita e, por fim, o polimorfismo de subtipos.

**Conclusão e Motivação**  
Aqui, temos uma variedade de termos técnicos, mas, ao longo das nossas práticas, veremos que todos esses conceitos são bastante fáceis de aplicar no dia a dia. Portanto, não há motivo para preocupação. Vamos começar?

### Aula 1 - O que esperar deste curso?

Antes de mergulharmos no código, que tal alinharmos as expectativas?

**O que significa um curso prático?**  
Já se pegou pensando — será que consigo aplicar o que aprendi na prática? Este curso é a sua resposta. Aqui, o foco é colocar a mão no código, resolver problemas e testar seu conhecimento de forma ativa. Você terá:

- Vídeo de revisão do conteúdo
- Material de apoio
- Desafios de código

Pré requisitos  
É importante ter concluído o [curso C#: criando sua primeira aplicação](https://cursos.alura.com.br/course/csharp-criando-primeira-aplicacao), pois ele cobre os fundamentos da linguagem, garantindo que você consiga realizar os exercícios deste curso com mais segurança.

- Dicas para potencializar seu aprendizado neste curso
- Assista ao vídeo de revisão com atenção. Pause, anote e revise sempre que necessário.
- Baixe o material complementar para ter um apoio nas atividades.
- Faça os desafios na sua IDE favorita.
- Compartilhe o que aprendeu no fórum, pois sua abordagem pode inspirar outras pessoas.

Vamos começar?

### Aula 1 - Polimorfismo de sobrecarga - Vídeo 2

Transcrição  
Para compreendermos o polimorfismo, precisamos primeiro entender o significado dessa palavra. Podemos dividir "polimorfismo" em duas partes: "poli" e "morfismo". "Poli" significa muitos, e "morfismo" está relacionado a formas. Note que temos a mesma grafia, mas a palavra está um pouco alterada. Ao juntarmos as duas partes, obtemos que polimorfismo significa "muitas formas".

**Aplicação do Polimorfismo no Código**  
Como assim, muitas formas? No mundo real, existem várias situações em que podemos realizar uma determinada ação de maneiras diferentes. O polimorfismo nos ajuda a representar essas diferentes formas em nosso código. Mas como isso funciona? Vamos exemplificar no nosso contexto.

Na classe Produto, estamos trabalhando com o desconto no preço desse produto. Utilizamos a porcentagem, ou seja, passamos uma porcentagem como parâmetro do método, e o preço é multiplicado por essa porcentagem para obter um desconto final.

```csharp
Preco = Preco * (1 - desconto/100);
```

No entanto, existe outra forma de aplicar um desconto, que é passando um valor fixo a ser subtraído do preço. Por exemplo, podemos ter R$10 de desconto no produto, realizando a subtração para obter o resultado final. Assim, temos duas formas de fazer a mesma coisa: aplicar o desconto. Queremos representar essa situação no nosso código. Como fazemos isso? Utilizando o polimorfismo.

**Implementação do Polimorfismo de Sobrecarga**  
Para implementar isso, é bastante simples. Criamos um novo método com o mesmo nome, mas com parâmetros diferentes. No Visual Studio, criamos um public void chamado AlterarPrecoComDesconto, passando um valor inteiro, pois geralmente não utilizamos valores fracionados para fornecer esse desconto.

```csharp
public void AlterarPrecoComDesconto(int desconto)
{
    Preco = Preco - desconto;
}
```

Observe que o compilador não apresenta problemas, pois estamos realizando ações diferentes, mesmo que tenham o mesmo nome. A ideia é que o método tenha o mesmo nome dentro da mesma classe, mas com parâmetros diferentes. No primeiro caso, usamos um double, e no segundo, um int. Se tivéssemos, por exemplo, dois métodos com double desconto, o compilador reclamaria, pois não conseguiria diferenciar. Se tivéssemos uma quantidade diferente de parâmetros, ele conseguiria fazer essa distinção. Vamos ver um exemplo disso também.

Portanto, a ideia é ter o mesmo método, com o mesmo nome, mas com parâmetros diferentes dentro da mesma classe. Quando trabalhamos com polimorfismo dessa forma, estamos lidando com polimorfismo de sobrecarga.

**Polimorfismo de Sobrecarga em Construtores**  
O polimorfismo de sobrecarga é amplamente aplicado em construtores, pois desejamos inicializar nossas classes de maneiras diferentes. No exemplo de um produto físico, o estoque é inicialmente definido como zero.

```csharp
public ProdutoFisico(string nome, string descricao,
    decimal preco, string imagem) 
    : base(nome, descricao, preco, imagem)
{
    this.Estoque = 0;
}
```

No entanto, podemos querer inicializar um produto com um valor específico de estoque. Para isso, podemos criar um novo construtor para diferenciar essas duas inicializações.

```csharp
public ProdutoFisico(string nome, string descricao,
    decimal preco, string imagem, int estoque)
    : base(nome, descricao, preco, imagem)
{
    this.Estoque = estoque;
}
```

Dessa forma, o compilador não apresenta mais erros, e estamos utilizando o polimorfismo de sobrecarga.

**Exemplos Práticos de Uso**  
Podemos ver a aplicação dos métodos ao construir um produto físico com estoque zerado. Ao executar, verificamos que o estoque é zero.

```csharp
ProdutoFisico item1 = new ProdutoFisico("Teclado", "Modelo compacto e silencioso" +
    "perfeito para produtividade diária.",
    80.00m, "Imagem");

Console.WriteLine(@$"Dados do item 1:
    Nome: {item1.Nome};
    Descricao: {item1.Descricao};
    Preco: {item1.Preco};
    Estoque: {item1.Estoque};
");
```

Em seguida, copiamos o produto físico item1 e criamos item2, inicializando-o com um estoque de 20.

```csharp
ProdutoFisico item2 = new ProdutoFisico("Teclado", "Modelo compacto e silencioso" +
    "perfeito para produtividade diária.",
    80.00m, "Imagem", 20);

Console.WriteLine(@$"Dados do item 2:
    Nome: {item2.Nome};
    Descricao: {item2.Descricao};
    Preco: {item2.Preco};
    Estoque: {item2.Estoque};
");
```

Além disso, alteramos o preço utilizando duas formas de desconto. Para o item1, aplicamos um desconto de 10% passando 10.0M e, em seguida, imprimimos o preço atualizado.

```csharp
item1.AlterarPrecoComDesconto(10.0m);
Console.WriteLine(item1.Preco);
```

```csharp
Depois, aplicamos um desconto de 10 unidades inteiras e imprimimos novamente.

item1.AlterarPrecoComDesconto(10);
Console.WriteLine(item1.Preco);
```

Ao executar o código, observamos que o estoque do item1 é zero e o do item2 é 20, confirmando as duas inicializações. As duas formas de aplicar desconto também funcionam corretamente: o produto inicialmente custava R$ 80,00, foi para R$ 72,00 com 10% de desconto e, depois, para R$ 62,00 com um desconto de R$ 10,00.

**Conclusão sobre o Polimorfismo de Sobrecarga**  
Dessa forma, vemos o polimorfismo de sobrecarga em ação. Existe ainda outra forma de trabalhar com polimorfismo em métodos, que será abordada na sequência.

### Aula 1 - Polimorfismo de sobrescrita - Vídeo 3

Transcrição  
Para discutirmos sobre outro tipo de polimorfismo em métodos, vamos considerar a seguinte situação: temos nossos produtos físicos, que podem ser entregues. Assim, criaremos dentro de produto físico um método chamado entregar, que receberá um endereço. Teremos um public void entregar e, para entregar, passaremos uma string endereço como parâmetro. A ideia da entrega será apenas imprimir que o produto está sendo entregue. Podemos utilizar Console.WriteLine, calculando a rota com base no endereço e enviando o produto. Utilizaremos interpolação para incluir o nome do nosso produto, resultando na entrega do produto físico. Aqui, estamos apenas utilizando implementações de teste.

Implementação do Método Entregar para Produtos Físicos
Vamos começar definindo o método Entregar na classe de produto físico:

```csharp
public void Entregar(string endereco)
{

}
```

Agora, vamos adicionar a lógica para imprimir a mensagem de entrega, utilizando interpolação de strings para incluir o nome do produto:

```csharp
public void Entregar(string endereco)
{
    Console.WriteLine($"Calculando frete com base no {endereco} e enviando {Nome}");
}
```

**Adaptação do Método Entregar para Produtos Digitais**  
Conseguimos entregar produtos físicos, mas, ao pensarmos em produtos digitais, também é possível realizar entregas. A entrega de um produto digital também requer um endereço, mas, neste caso, será um endereço eletrônico, pois desejamos enviar o produto digital para o e-mail do cliente. Vamos copiar nosso método entregar e aplicá-lo ao produto digital. Logo após o método estáExpirado, colaremos o método copiado e faremos as adaptações necessárias. Teremos uma string endereço e, em vez de calcular uma rota, queremos simplesmente enviar o nome do produto para o e-mail. Colocaremos o endereço de e-mail fornecido pelo usuário. Com isso, conseguimos realizar a entrega de um produto digital.

Para o produto digital, o método Entregar será assim:

```csharp
public void Entregar(string endereco)
{
    Console.WriteLine($"Enviando {Nome} para o email {endereco}");
}
```

**Generalização do Método Entregar na Classe Produto**  
Ao observarmos, notamos que temos um método entregar tanto em produto digital quanto em produto físico. Se esse método está presente nas duas classes, podemos afirmar que nossos produtos sempre serão entregues. Assim, podemos querer incluir esse comportamento na nossa classe produto. Sempre que adicionarmos um novo tipo de produto, desejaremos entregá-lo de alguma forma. Para indicar que esse comportamento é genérico, adicionaremos o método entregar na classe produto. Teremos um public void entregar.

Aqui, notamos uma diferença: ao observarmos os métodos avaliar e alterarPreçoComDesconto, percebemos que eles estão na classe produto e são como cópias para as classes produto físico e produto digital, como se fossem replicados diretamente durante a herança. No caso do entregar, não é isso que desejamos. O método entregar existirá na classe produto, mas as implementações serão diferentes dentro de produto físico e produto digital. Portanto, não queremos implementar de fato o método entregar na classe produto, pois um produto genérico não é entregue; apenas produtos físicos e digitais, que são classes concretas, são entregues.

**Definição de Método Abstrato para Entregar**  
Dessa forma, podemos afirmar que o método entregar na classe produto será abstrato, sendo implementado apenas nas classes concretas. É semelhante ao que fazemos com métodos em interfaces, onde apenas declaramos os métodos e os implementamos posteriormente. Para isso, utilizaremos a palavra-chave abstract no nosso método entregar, passando também o parâmetro string endereço. Assim, todas as classes que herdam de produto serão obrigadas a implementar o método entregar.

```csharp
public abstract void Entregar(string endereco);
```

**Uso da Palavra-Chave Override para Implementação**  
No momento, o produto físico está apresentando erro, indicando que não implementamos o método entregar, mas ele já está implementado.

Por que estamos enfrentando esse erro? Isso ocorre porque precisamos da palavra-chave override. Toda vez que usamos essa palavra, estamos indicando que nosso método está sendo sobrescrito na classe filha. Ao lado da linha 24, há um "O" e uma seta para cima, semelhante ao que tínhamos nas interfaces, indicando que estamos pegando um método herdado e sobrescrevendo-o na classe filha. No caso de produto digital, também precisamos utilizar a palavra-chave override. Assim, conseguimos ter um método genérico, abstrato, chamado entregar, e implementá-lo em cada uma das classes filhas.

```csharp
public override void Entregar(string endereco)
{
    Console.WriteLine($"Calculando frete com base no {endereco} e enviando {Nome}");
}
```

```csharp
public override void Entregar(string endereco)
{
    Console.WriteLine($"Enviando {Nome} para o email {endereco}");
}
```

**Polimorfismo de Sobrescrita**  
Quando utilizamos a palavra override, estamos indicando que o método está sendo sobrescrito. Por isso, esse tipo de polimorfismo é chamado de polimorfismo de sobrescrita. A ideia é ter um método declarado na classe genérica e reimplementá-lo, sobrescrevendo-o nas classes filhas, que são produto digital e produto físico, no nosso caso.

**Implementações Padrão e Uso da Palavra-Chave Virtual**  
Além dos métodos abstratos, podemos querer fornecer implementações padrão para nossos métodos nas classes mães. No caso do método entregar, por exemplo, poderíamos querer definir uma entrega padrão. Poderíamos fazer um console.writeLine para uma entrega genérica, apenas para visualização. Fazendo isso, enfrentamos um problema, pois o método não é mais abstrato. Precisamos remover o abstract, e assim temos uma implementação padrão. No entanto, se voltarmos para produto físico ou produto digital, eles começarão a apresentar erros. Isso ocorre porque não está sinalizado de forma alguma, dentro da classe produto, que o método entregar pode ser sobrescrito. Precisamos usar outra palavra-chave, que é virtual, para indicar que podemos sobrescrever o método nas classes filhas. Uma vez que usamos virtual, podemos usar override nas classes produto físico e produto digital sem problemas.

```csharp
public virtual void Entregar(string endereco)
{
    Console.WriteLine("Entrega genérica");
}
```

**Visualização do Funcionamento no Program.cs**  
Aqui temos uma diferença: podemos sobrescrever nosso método se ele for do tipo abstrato e não tiver nenhuma implementação. É importante lembrar que só conseguimos trabalhar com métodos abstratos dentro de classes abstratas. Se não temos métodos abstratos, mas apenas métodos já implementados, precisamos marcá-los como virtuais para que possam ser sobrescritos.

Para visualizar como isso está funcionando, vamos para a classe Program.cs. Nessa classe, temos um item 1, que é um produto físico, e um item 2, que é um produto digital. Podemos chamar item 1.Entregar e passar um endereço físico. Podemos chamar o mesmo método em item 2, que também será Entregar, mas passaremos um e-mail, como "iasmin.com". Fazendo isso, temos duas entregas. Estamos chamando o método Entregar, mas são os mesmos métodos com o mesmo tipo de parâmetro, ou seja, têm a mesma assinatura, mas pertencem a classes diferentes. No final, a implementação desses métodos será diferente.

```csharp
item1.Entregar("endereço físico");
item2.Entregar("iasmin@gmeil.com");
```

**Execução e Resultados**  
Vamos executar para ver o resultado. A compilação está sendo executada. Ao lado, temos nossos dados. A primeira entrega foi "calculando o frete e enviando o teclado", e agora "enviando o curso para o e-mail iasmin.com". Vamos apenas adicionar um "A" aqui. Feito isso, visualizamos essas duas entregas de formas diferentes, o que é mais um tipo de polimorfismo.

## Aula 2 - Polimorfismo e subtipos

### Aula 2 - Polimorfismo de subtipos - Vídeo 1

Transcrição  
Para evoluirmos ainda mais nossa aplicação, vamos analisar a classe de pedido. Podemos observar que ela possui vários atributos e propriedades diferentes, mas falta um elemento crucial: uma lista de produtos associada a esse pedido. Como podemos armazenar essa lista de produtos? Um pedido pode conter produtos tanto físicos quanto digitais, sem restrições. Como, então, armazenamos esses dois tipos juntos? Podemos utilizar herança para criar uma lista genérica de produtos. Assim, conseguimos armazenar itens específicos dentro dessa lista genérica.

**Implementação da Lista Genérica de Produtos**  
Vamos colocar isso em prática para esclarecer. Primeiro, declaramos uma lista genérica de produtos. Teremos uma List`<Produto>` chamada Produtos, que poderá ser acessada com get e um private set.

```csharp
public List`<Produto>` Produtos { get; private set; }
```

Uma vez que temos nossa lista de produtos, ela pode ser inicializada no construtor do pedido. Faremos com que Produtos seja igual a new List`<Produto>`(), instanciando tudo corretamente.

```csharp
Produtos = new List`<Produto>`();
```

**Adicionando Produtos à Lista**  
Com a lista genérica criada, queremos adicionar produtos à lista de produtos do pedido. Para isso, podemos criar um método public void AdicionarProduto, que receberá um produto genérico como parâmetro.

```csharp
public void AdicionarProduto(Produto produto)
{
}
```

Em seguida, chamamos a propriedade Produtos e utilizamos Produtos.Add, passando o produto do parâmetro. Assim, conseguimos adicionar o produto à lista.

```csharp
public void AdicionarProduto(Produto produto)
{
    Produtos.Add(produto);
}
```

**Testando a Implementação**  
Vamos testar para entender o que está acontecendo. No arquivo program.cs, temos um pedido já instanciado, e podemos adicionar produtos a ele. Utilizamos pedido.AdicionarProduto, passando item1, que é um produto físico, e item2, que é um produto digital.

```csharp
pedido.AdicionarProduto(item1);
pedido.AdicionarProduto(item2);
```

**Exibindo os Produtos do Pedido**  
Após isso, podemos mostrar os detalhes do pedido. No entanto, ao voltarmos ao método ExibirResumo, percebemos que os produtos não estão sendo exibidos. Vamos inserir um for para exibir nossos produtos. Colocaremos um Console.WriteLine com a mensagem "Produtos do pedido:". Em seguida, faremos um for básico para garantir que tudo apareça corretamente.

```csharp
Console.WriteLine("Produtos do pedido:");
foreach(var produto in Produtos)
{
    Console.WriteLine(produto.Nome);
}
```

No resumo, já estamos mostrando todos os produtos. Vamos chamar esse método no arquivo program.cs com pedido.ExibirResumo.

```csharp
pedido.ExibirResumo();
```

**Polimorfismo de Subtipo**  
Ao executar, adicionamos o item 1 e o item 2 à lista, e podemos ver que nosso pedido contém um teclado e um curso, que são os itens com os quais estávamos trabalhando. Note que conseguimos adicionar tanto um produto físico quanto um produto digital em um local onde era esperado um produto genérico. Aqui, temos uma forma de polimorfismo, o polimorfismo de subtipo. Nesse caso, conseguimos passar elementos mais específicos do que um produto, como um produto físico ou um produto genérico, no lugar dele.

Podemos descrever o polimorfismo de subtipo da seguinte maneira: um produto físico pode se comportar de duas maneiras diferentes, baseadas no próprio tipo. Em qualquer lugar onde se espera um parâmetro do tipo produto físico, obviamente, podemos passá-lo. Além disso, ele pode se comportar como seu supertipo, ou seja, como um produto. Lembrando que, na definição de herança, um produto físico é também um produto. O polimorfismo de subtipo utiliza essa definição de herança para permitir que elementos específicos também tenham comportamentos mais genéricos.

Podemos observar esse comportamento mais genérico quando passamos nosso produto como parâmetro de um método, ou quando temos uma lista mais genérica de produtos. Assim, conseguimos adicionar um item mais específico dentro de uma lista genérica. Esse é um dos tipos de polimorfismo mais utilizados no dia a dia, especialmente quando falamos de boas práticas. Ao estudar padrões de projeto e práticas recomendadas, provavelmente encontraremos muito o polimorfismo de subtipo. Na sequência, veremos mais um exemplo associado a esse polimorfismo.

### Aula 2 - Tipos de compilação e execução - Vídeo 2

Transcrição  
Para finalizarmos, vamos analisar a classe que acabamos de criar. Temos uma classe BancoDeDados, cuja finalidade é armazenar dados referentes aos produtos do nosso e-commerce. Para exemplificar, criamos uma lista de produtos que inclui um produto digital e um produto físico. Observamos o polimorfismo aqui, pois temos uma lista de produtos genéricos, mas dentro dela, há produtos específicos, como digital e físico.

```csharp
class BancoDeDados
{
    List<Produto> produtos = new List<Produto>()
    {
        new ProdutoDigital("Curso", "OO em C#", 
            100.00m, "Imagem ilustrativa", "Link"),
        new ProdutoFisico("Teclado", "Modelo compacto e silencioso," +
            " perfeito para produtividade diária.",
            80.00m, "Imagem")
    };
}
```

**Implementação do Método BuscarProdutoPeloNome**  
Outro exemplo de polimorfismo de subtipo que podemos ter é a busca de um produto pelo nome. Nesse caso, teremos um método na classe que será um public Produto buscarProdutoPeloNome. Note que estamos trabalhando com o retorno do método como um retorno genérico, sem especificar se são produtos físicos ou digitais. Esse método receberá como parâmetro uma string chamada nome.

Vamos começar a implementar esse método. Primeiro, definimos a assinatura do método:

```csharp
public Produto BuscarProdutoPeloNome(string nome)
{

}
```

A ideia é percorrer nossa lista de produtos utilizando um for, e para cada variável p na lista de produtos do banco de dados, verificaremos se o nome do produto (p.nome) é igual ao nome passado como parâmetro. Se for igual, retornaremos esse produto, ou seja, retornaremos p.

```csharp
public Produto BuscarProdutoPeloNome(string nome)
{
    foreach(var p in produtos)
    {
        if(p.Nome.Equals(nome))
        {
            return p;
        }
    }
    return null;
}
```

**Testando o Método na Classe Program.cs**  
Assim, temos um método com retorno genérico. Para verificar o funcionamento, vamos para a classe Program.cs. Podemos declarar uma variável var produto, que será igual ao nosso banco de dados. Declaramos também um banco de dados: BancoDeDados banco = new BancoDeDados(). O produto será o resultado do banco de dados ao utilizar o método específico de buscar produto pelo nome, passando um nome, como "Teclado".

```csharp
BancoDeDados banco = new BancoDeDados();
var produto = banco.BuscarProdutoPeloNome("Teclado");
```

Para visualizar os dados, copiamos o Console.WriteLine com os dados do item 1. Substituímos "item 1" por "produto", assim: produto.nome, produto.descricao, produto.preco e produto.stock.

```csharp
Console.WriteLine(@$"Dados do item 1:
Nome: {produto.Nome};
Descrição: {produto.Descricao};
Preço: {produto.Preco};
Estoque: {produto.Estoque};
");
```

**Problema de Compilação e Casting**  
Note que não conseguimos visualizar o estoque, pois ocorre um erro indicando que a classe Produto não possui uma variável ou membro estoque. Isso acontece porque o produto é genérico e, na definição de produto genérico, não há estoque.

Por mais que saibamos que estamos trabalhando com um produto físico, nosso compilador não tem essa informação. Para o compilador, temos apenas produtos genéricos. Aqui, há uma diferença entre o tipo de compilação e o tipo de execução. O tipo de compilação é o que declaramos ao programar. Quando programamos nosso método, indicamos que ele retornaria um produto, algo genérico. No momento da compilação do código, não sabemos que o resultado da busca será um produto físico específico. Portanto, nosso tipo de compilação será o produto genérico.

Para explicitar que o tipo de compilação é igual ao tipo de execução, precisamos fazer isso de forma específica, utilizando um casting. Para trabalhar especificamente com um produto físico, abrimos parênteses, colocamos "produto físico" e fechamos os parênteses. Dessa forma, nossa variável aceitará somente produtos físicos, permitindo compilar o estoque.

```csharp
var produto = (ProdutoFisico)banco.BuscarProdutoPeloNome("Teclado");
```

Nesse caso, o tipo de compilação é igual ao tipo de execução. Ao executar o código, teremos os dados do item 1, que foi o item buscado, e conseguimos imprimir os dados mais específicos do produto físico.

**Polimorfismo com Interfaces**  
Esse tipo de polimorfismo também pode ser aplicado quando falamos de interfaces. Poderíamos, por exemplo, declarar um pedido do tipo pedido como uma interface, como a interface IExpirável.

```csharp
IExpiravel pedido = new Pedido(1, "Iasmin", 100.00m);
```

Ao fazer isso, o código começará a apresentar erros, pois dentro da interface não temos os métodos adicionarProduto nem exibirResumo. No nosso contexto, não há necessidade específica de trabalhar com o pedido como tipo da interface, mas existem casos, principalmente associados às boas práticas, em que faz sentido declarar algo com o tipo da interface, em vez de trabalhar com o tipo do objeto em si.

```csharp
Retorno ao Tipo Pedido Original
Vamos voltar ao tipo pedido original.

Pedido pedido = new Pedido(1, "Iasmin", 100.00m);
```

Em seguida, teremos uma série de atividades para praticar e ver com exemplos como funcionam tanto o polimorfismo de subtipagem quanto a parte associada às interfaces, aos tipos de compilação e de execução.

### Aula 2 - Preparando o ambiente: instalando o Visual Studio

Olá!  
O IDE do Visual Studio é uma plataforma de lançamento criativa que você pode usar para editar, depurar e criar código e, em seguida, publicar um aplicativo. Além do editor e depurador padrão fornecidos pela maioria dos IDEs, o Visual Studio inclui compiladores, ferramentas de conclusão de código, designers gráficos e muitos outros recursos para aprimorar o processo de desenvolvimento de software. O IDE mais abrangente para desenvolvedores .NET no Windows e Mac para criação de web, nuvem, desktop, aplicativos móveis, serviços e jogos.

Sabendo disso, preparamos alguns vídeos para instalar em diferentes sistemas operacionais. Para este curso em específico, marque a opção Desenvolvimento para Desktop com .NET. no processo de instalação.

Visual Studio no Windows

Visual Studio no Mac

C# no VSCODE (SDK)

C# em distribuições Linux
[Neste link](https://learn.microsoft.com/pt-br/dotnet/core/install/linux), você encontra um passo a passo da própria Microsoft de como instalar em distribuições Linux, como Alpine, CentOS, Debian, entre outras.

Vamos começar?

### Aula 2 - Preparando o ambiente: material de apoio

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

Esse recurso pode te ajudar a deixar os exercícios mais simples e diretos, com foco na lógica e não na estrutura do programa. Após finalizar todos os desafios, não esqueça de compartilhar sua solução no fórum. Será incrível ver como você resolveu!

Vamos nessa?

### Aula 2 - Faça como eu fiz, 1: calculadora com sobrecarga de método

Você está desenvolvendo uma calculadora para um sistema de caixa. Para facilitar o uso, o sistema precisa de um método de soma que funcione tanto com dois números inteiros quanto com três, e também com números decimais.

Sua missão é criar uma classe chamada Calculadora que possua um método chamado Somar. Esse método deve ser sobrecarregado para permitir as seguintes versões:

- Somar dois inteiros.
- Somar três inteiros.
- Somar dois números decimais (double).
- Depois, crie uma instância da classe e chame os três métodos, exibindo os resultados.

Exemplo de entrada:

```csharp
Calculadora calc = new Calculadora();
Console.WriteLine(calc.Somar(10, 20));
Console.WriteLine(calc.Somar(5, 10, 15));
Console.WriteLine(calc.Somar(3.5, 2.8));
```

Exemplo de saída:

```csharp
30
30
6,3
```

Opinião do instrutor

Aqui, o que estamos explorando é o conceito de polimorfismo por sobrecarga — ou seja, o mesmo nome de método (Somar), mas com diferentes assinaturas. Isso nos permite criar uma interface mais fluida e intuitiva para quem usa a classe, sem precisar se lembrar de vários nomes de métodos como SomarInt, SomarDouble, etc.

No arquivo Calculadora.cs, temos:

```csharp
public class Calculadora
{
    public int Somar(int a, int b)
    {
        return a + b;
    }

    public int Somar(int a, int b, int c)
    {
        return a + b + c;
    }

    public double Somar(double a, double b)
    {
        return a + b;
    }
}
```

E no programa principal (Program.cs):

```csharp
Calculadora calc = new Calculadora();
Console.WriteLine(calc.Somar(10, 20));
Console.WriteLine(calc.Somar(5, 10, 15));
Console.WriteLine(calc.Somar(3.5, 2.8));
```

A linguagem consegue identificar qual versão do método usar com base nos tipos e quantidade de argumentos. É interessante testar com diferentes tipos, inclusive ver o que acontece se passarmos float, long ou mesmo valores null.

Agora é sua vez! Teste o programa, compartilhe no fórum e compare sua lógica com outras soluções.

### Aula 2 - Faça como eu fiz, 2: relatório de funcionários

Imagine que você está construindo um sistema de RH que gera relatórios personalizados. Você criou uma classe base chamada Funcionario, e duas subclasses: Gerente e Desenvolvedor. Cada tipo de funcionário deve gerar um relatório diferente, sobrescrevendo um método chamado GerarRelatorio().

Crie essas três classes com um método public virtual string GerarRelatorio() na base, e sobrescreva esse método nas classes filhas.

Exemplo de entrada:

```csharp
Funcionario f1 = new Gerente();
Funcionario f2 = new Desenvolvedor();

Console.WriteLine(f1.GerarRelatorio());
Console.WriteLine(f2.GerarRelatorio());
```

Exemplo de saída:

```csharp
Relatório do gerente: supervisiona a equipe.
Relatório do desenvolvedor: escreve código e corrige bugs.
```

Opinião do instrutor

Essa atividade mostra o polimorfismo por sobrescrita — um conceito bem importante quando estamos lidando com herança. Criamos um método na classe base e depois reescrevemos ele nas subclasses usando override.

Arquivo Funcionario.cs:

```csharp
public class Funcionario
{
    public virtual string GerarRelatorio()
    {
        return "Relatório genérico do funcionário.";
    }
}
```

Arquivo Gerente.cs:

```csharp
public class Gerente : Funcionario
{
    public override string GerarRelatorio()
    {
        return "Relatório do gerente: supervisiona a equipe.";
    }
}
```

Arquivo Desenvolvedor.cs:

```csharp
public class Desenvolvedor : Funcionario
{
    public override string GerarRelatorio()
    {
        return "Relatório do desenvolvedor: escreve código e corrige bugs.";
    }
}
```

E o Program.cs:

```csharp
Funcionario f1 = new Gerente();
Funcionario f2 = new Desenvolvedor();

Console.WriteLine(f1.GerarRelatorio());
Console.WriteLine(f2.GerarRelatorio());
```

Mesmo chamando GerarRelatorio() a partir de uma variável do tipo Funcionario, o comportamento em tempo de execução depende da instância real (Gerente ou Desenvolvedor), graças ao polimorfismo. Isso é importante em sistemas que usam listas de objetos com comportamento comum, mas execução específica.

Agora é sua vez! Teste o programa, compartilhe no fórum e compare sua lógica com outras soluções.

### Aula 2 - Faça como eu fiz, 3: notificações de sistema

Você está construindo uma aplicação de alertas corporativos. Para facilitar a expansão do sistema, você decide criar uma estrutura onde cada canal de notificação (e-mail, SMS, push, etc.) implementa uma interface comum chamada INotificacao.

Cada tipo de notificação deve implementar o método EnviarMensagem(string mensagem) de forma específica. Depois, você deverá criar uma lista com diferentes notificadores e percorrê-la chamando o método de envio.

Exemplo de entrada:

```csharp
List<INotificacao> notificacoes = new List<INotificacao>
{
    new EmailNotificacao(),
    new SmsNotificacao(),
    new PushNotificacao()
};

foreach (var notificacao in notificacoes)
{
    notificacao.EnviarMensagem("Sistema fora do ar!");
}
```

Exemplo de saída:

```csharp
Enviando E-MAIL: Sistema fora do ar!
Enviando SMS: Sistema fora do ar!
Enviando PUSH: Sistema fora do ar!
```

Opinião do instrutor

Essa atividade mostra como usamos polimorfismo de subtipos através de interfaces. Aqui, temos um contrato chamado INotificacao que obriga qualquer classe que o implemente a definir o método EnviarMensagem. Isso garante que todas as notificações possam ser tratadas de forma padronizada.

Veja esse diagrama abaixo. Ele mostra exatamente como as classes estão organizadas e conectadas:

Diagrama de classes UML com a interface INotificacao, que define o método EnviarMensagem(string mensagem). Três classes — EmailNotificacao, SmsNotificacao e PushNotificacao — implementam essa interface, cada uma com sua própria versão do método EnviarMensagem.

A interface está no topo, e cada classe a implementa individualmente, criando versões específicas de como enviar a mensagem. Essa estrutura é boa porque:

- Você pode adicionar novas notificações (ex: SlackNotificacao, WhatsAppNotificacao) sem alterar o código que já consome a interface.
- O código que consome a lista (foreach) não precisa saber o tipo real da instância, ele só confia que ela implementa INotificacao.
- O comportamento em tempo de execução depende da instância concreta, mas o código é escrito usando apenas o tipo genérico da interface.

Observe o código abaixo:

Arquivo INotificacao.cs:

```csharp
public interface INotificacao
{
    void EnviarMensagem(string mensagem);
}
```

Arquivo EmailNotificacao.cs:

```csharp
public class EmailNotificacao : INotificacao
{
    public void EnviarMensagem(string mensagem)
    {
        Console.WriteLine("Enviando E-MAIL: " + mensagem);
    }
}
```

Arquivo SmsNotificacao.cs:

```csharp
public class SmsNotificacao : INotificacao
{
    public void EnviarMensagem(string mensagem)
    {
        Console.WriteLine("Enviando SMS: " + mensagem);
    }
}
```

Arquivo PushNotificacao.cs:

```csharp
public class PushNotificacao : INotificacao
{
    public void EnviarMensagem(string mensagem)
    {
        Console.WriteLine("Enviando PUSH: " + mensagem);
    }
}
```

Arquivo Program.cs:

```csharp
List<INotificacao> notificacoes = new List<INotificacao>
{
    new EmailNotificacao(),
    new SmsNotificacao(),
    new PushNotificacao()
};

foreach (var notificacao in notificacoes)
{
    notificacao.EnviarMensagem("Sistema fora do ar!");
}
```

Essa forma de organizar o código é muito comum em sistemas profissionais — APIs, serviços de mensageria, envio de logs e integração com terceiros.

Agora é sua vez! Teste o programa, compartilhe no fórum e compare sua lógica com outras soluções.

### Aula 2 - Faça como eu fiz, 4: execução de tarefas agendadas

Você está criando um sistema de tarefas agendadas. O sistema deve executar diferentes tipos de tarefas, como fazer backup, enviar relatórios e limpar arquivos temporários. Cada tarefa precisa seguir uma estrutura comum com um método chamado Executar().

Crie uma classe abstrata chamada TarefaAgendada com um método abstrato Executar(). Depois, crie três classes que herdam dela: BackupTarefa, RelatorioTarefa e LimpezaTarefa. Cada uma deve sobrescrever o método Executar com uma lógica própria.

Por fim, crie uma lista de TarefaAgendada com diferentes tipos de tarefas e percorra essa lista, executando cada uma.

Exemplo de entrada:

```csharp
List<TarefaAgendada> tarefas = new List<TarefaAgendada>
{
    new BackupTarefa(),
    new RelatorioTarefa(),
    new LimpezaTarefa()
};

foreach (var tarefa in tarefas)
{
    tarefa.Executar();
}
```

Exemplo de saída:

```csharp
Executando tarefa de backup do sistema...
Gerando e enviando relatório diário...
Limpando arquivos temporários do servidor...
```

Opinião do instrutor

Aqui usamos polimorfismo com sobrescrita, mas com uma variação importante: estamos trabalhando com classe abstrata, que é outro tipo de "molde" que não pode ser instanciado diretamente.

A classe abstrata serve como uma definição obrigatória de estrutura. Qualquer classe que herda dela é forçada a implementar o método Executar, e assim conseguimos garantir um comportamento mínimo comum entre todas as tarefas.

Vamos por partes:

Arquivo TarefaAgendada.cs:

```csharp
public abstract class TarefaAgendada
{
    public abstract void Executar();
}
```

Essa classe não possui implementação no método Executar, o que obriga suas filhas a fornecerem uma.

Arquivo BackupTarefa.cs:

```csharp
public class BackupTarefa : TarefaAgendada
{
    public override void Executar()
    {
        Console.WriteLine("Executando tarefa de backup do sistema...");
    }
}
```

Arquivo RelatorioTarefa.cs:

```csharp
public class RelatorioTarefa : TarefaAgendada
{
    public override void Executar()
    {
        Console.WriteLine("Gerando e enviando relatório diário...");
    }
}
```

Arquivo LimpezaTarefa.cs:

```csharp
public class LimpezaTarefa : TarefaAgendada
{
    public override void Executar()
    {
        Console.WriteLine("Limpando arquivos temporários do servidor...");
    }
}
```

No Program.cs:

```csharp
List<TarefaAgendada> tarefas = new List<TarefaAgendada>
{
    new BackupTarefa(),
    new RelatorioTarefa(),
    new LimpezaTarefa()
};

foreach (var tarefa in tarefas)
{
    tarefa.Executar();
}
```

Repare que mesmo que cada tarefa seja diferente, podemos armazená-las em uma única lista e tratá-las de forma genérica — esse é o grande poder do polimorfismo. Isso deixa o sistema preparado para escalabilidade.

Agora é sua vez! Teste o programa, compartilhe no fórum e compare sua lógica com outras soluções.

### Aula 2 - Faça como eu fiz, 5: exibindo mídias

Imagine que você está criando um sistema de galeria online. Nessa galeria, os usuários podem navegar por diferentes tipos de mídias — como imagens e vídeos. Cada tipo de mídia deve ser exibido com uma descrição adequada, contendo informações específicas, como a resolução da imagem ou a duração do vídeo.

Sua missão é:

- Criar a classe base Midia com a propriedade Nome e o método virtual ExibirDetalhes().
- Criar as classes Imagem (com Resolucao) e Video (com Duracao), sobrescrevendo o método ExibirDetalhes().
- Criar uma lista com diferentes mídias e exibir os detalhes de cada uma chamando ExibirDetalhes().

Exemplo de entrada:

```csharp
List<Midia> midias = new List<Midia>
{
    new Imagem("paisagem.jpg", "1920x1080"),
    new Video("filme.mp4", 120)
};

foreach (var midia in midias)
{
    midia.ExibirDetalhes();
}
```

Exemplo de saída:

```csharp
Imagem: paisagem.jpg - Resolução: 1920x1080  
Vídeo: filme.mp4 - Duração: 120 minutos
```

Opinião do instrutor

Nesta atividade a classe base Midia define uma estrutura comum, e cada subtipo implementa o método ExibirDetalhes() com seu próprio comportamento. Assim, conseguimos tratar todos os itens da galeria de forma uniforme — usando uma única lista — mas com comportamentos distintos para cada tipo de mídia.

Essa técnica é comum em aplicações reais que precisam exibir ou processar diferentes tipos de conteúdo, mantendo um código limpo, coeso e pronto para expansão (imagine adicionar futuramente uma classe Gif ou Áudio, por exemplo).

Observe o código abaixo:

Arquivo Midia.cs

```csharp
public class Midia
{
    public string Nome { get; set; }

    public Midia(string nome)
    {
        Nome = nome;
    }

    public virtual void ExibirDetalhes()
    {
        Console.WriteLine("Midia: " + Nome);
    }
}
```

Arquivo Imagem.cs

```csharp
public class Imagem : Midia
{
    public string Resolucao { get; set; }

    public Imagem(string nome, string resolucao) : base(nome)
    {
        Resolucao = resolucao;
    }

    public override void ExibirDetalhes()
    {
        Console.WriteLine($"Imagem: {Nome} - Resolução: {Resolucao}");
    }
}
```

Arquivo Video.cs

```csharp
public class Video : Midia
{
    public int Duracao { get; set; }
    public Video(string nome, int duracao) : base(nome)
    {
        Duracao = duracao;
    }
    public override void ExibirDetalhes()
    {
        Console.WriteLine($"Vídeo: {Nome} - Duração: {Duracao} minutos");
    }
}
```

Arquivo Program.cs

```csharp
List<Midia> midias = new List<Midia>
{
    new Imagem("paisagem.jpg", "1920x1080"),
    new Video("filme.mp4", 120)
};
foreach (var midia in midias)
{
    midia.ExibirDetalhes();
}
```

Agora é sua vez! Teste o programa, experimente adicionar outros tipos de mídias e publique sua solução no fórum. Ver como outras pessoas estruturaram a atividade pode te dar novas ideias!

### Aula 2 - Faça como eu fiz, 6: reservas de experiências

Você está desenvolvendo um sistema de reservas para uma agência de turismo. Os clientes podem reservar passeios presenciais, como trilhas e city tours, ou experiências online, como workshops virtuais de culinária ou fotografia.

O sistema trata todas as reservas como Reserva, mas cada tipo tem um processo diferente ao ser confirmada:

- A reserva presencial deve informar o ponto de encontro.
- A reserva online deve enviar um link de acesso.

Sua missão é:

- Criar a classe base Reserva, com um método virtual Confirmar().
- Criar as classes ReservaPresencial e ReservaOnline, que sobrescrevem esse método.
- Criar uma lista com diferentes tipos de reserva e processá-las em um foreach, chamando Confirmar().

Exemplo de entrada:

```csharp
List<Reserva> reservas = new List<Reserva>
{
    new ReservaPresencial("Trilha na Serra"),
    new ReservaOnline("Workshop de Culinária Italiana")
};

foreach (var reserva in reservas)
{
    reserva.Confirmar();
}
```

Exemplo de saída:

```csharp
Confirmando reserva presencial: Trilha na Serra
Ponto de encontro: Praça Central, às 8h
Confirmando reserva online: Workshop de Culinária Italiana
Link de acesso enviado por e-mail!
```

Opinião do instrutor

Nessa atividade, a classe Reserva funciona como o molde, e cada subtipo (ReservaPresencial, ReservaOnline) implementa o comportamento específico do método Confirmar.

A ideia aqui é que o sistema trate todas as reservas como iguais, mas o comportamento mude automaticamente de acordo com o tipo real da instância em execução.

Arquivo Reserva.cs:

```csharp
public class Reserva
{
    public string Titulo { get; set; }
    public Reserva(string titulo)
    {
        Titulo = titulo;
    }
    public virtual void Confirmar()
    {
        Console.WriteLine("Confirmando reserva genérica: " + Titulo);
    }
}
```

Arquivo ReservaPresencial.cs:

```csharp
public class ReservaPresencial : Reserva
{
    public ReservaPresencial(string titulo) : base(titulo) { }

    public override void Confirmar()
    {
        Console.WriteLine("Confirmando reserva presencial: " + Titulo);
        Console.WriteLine("Ponto de encontro: Praça Central, às 8h");
    }
}
```

Arquivo ReservaOnline.cs:

```csharp
public class ReservaOnline : Reserva
{
    public ReservaOnline(string titulo) : base(titulo) { }

    public override void Confirmar()
    {
        Console.WriteLine("Confirmando reserva online: " + Titulo);
        Console.WriteLine("Link de acesso enviado por e-mail!");
    }
}
```

Arquivo Program.cs:

```csharp
List<Reserva> reservas = new List<Reserva>
{
    new ReservaPresencial("Trilha na Serra"),
    new ReservaOnline("Workshop de Culinária Italiana")
};

foreach (var reserva in reservas)
{
    reserva.Confirmar();
}
```

Esse é um ótimo exemplo de como o polimorfismo reduz a complexidade do código. Mesmo com diferentes comportamentos, o sistema usa uma única lista e um único método (Confirmar()), sem precisar de if, switch ou checagens de tipo.

Agora é sua vez! Teste o programa, compartilhe no fórum e compare sua lógica com outras soluções.

### Aula 2 - Faça como eu fiz, 7: avaliação de conteúdos em uma plataforma

Imagine que você está desenvolvendo uma plataforma de cursos. Nela, os usuários podem avaliar diferentes tipos de conteúdo: aulas gravadas ou materiais complementares.

Essas atividades são tratados como Conteudo, mas cada tipo tem informações específicas:

- A aula gravada possui uma duração em minutos.
- O material complementar possui um número de páginas.

Sua missão é:

- Criar a classe base Conteudo com uma propriedade Titulo e o método virtual ExibirInfo().
- Criar as classes AulaGravada e MaterialComplementar, sobrescrevendo o método ExibirInfo().
- Criar uma lista de Conteudo e, ao percorrê-la, exibir as informações específicas de cada item.

Exemplo de entrada:

```csharp
List<Conteudo> conteudos = new List<Conteudo>
{
    new AulaGravada("POO na prática", 45),
    new MaterialComplementar("Resumo do módulo 2", 12)
};
foreach (var conteudo in conteudos)
{
    conteudo.ExibirInfo();
}
```

Exemplo de saída.

```csharp
Título: POO na prática  
Duração: 45 min  

Título: Resumo do módulo 2  
Páginas: 12
```

Opinião do instrutor

Nesta atividade, cada tipo de conteúdo implementa sua própria lógica no método ExibirInfo(), sem precisar de verificações externas. Isso deixa o código mais coeso, pois cada classe se responsabiliza por seu próprio comportamento. É um padrão muito comum em aplicações com conteúdo dinâmico.

Observe o código abaixo:

Arquivo Conteudo.cs

```csharp
public class Conteudo
{
    public string Titulo { get; set; }

    public Conteudo(string titulo)
    {
        Titulo = titulo;
    }
    public virtual void ExibirInfo()
    {
        Console.WriteLine("Título: " + Titulo);
    }
}
```

Arquivo AulaGravada.cs

```csharp
public class AulaGravada : Conteudo
{
    public int Duracao { get; set; }

    public AulaGravada(string titulo, int duracao) : base(titulo)
    {
        Duracao = duracao;
    }

    public override void ExibirInfo()
    {
        Console.WriteLine("Título: " + Titulo);
        Console.WriteLine("Duração: " + Duracao + " min\n");
    }
}
```

Arquivo MaterialComplementar.cs

```csharp
public class MaterialComplementar : Conteudo
{
    public int Paginas { get; set; }

    public MaterialComplementar(string titulo, int paginas) : base(titulo)
    {
        Paginas = paginas;
    }

    public override void ExibirInfo()
    {
        Console.WriteLine("Título: " + Titulo);
        Console.WriteLine("Páginas: " + Paginas + "\n");
    }
}
```

Arquivo Program.cs

```csharp
List<Conteudo> conteudos = new List<Conteudo>
{
    new AulaGravada("POO na prática", 45),
    new MaterialComplementar("Resumo do módulo 2", 12)
};

foreach (var conteudo in conteudos)
{
    conteudo.ExibirInfo();
}
```

Agora é sua vez! Teste o programa com mais conteúdos, como “Ebook”, “Infográfico”, e poste sua solução no fórum para inspirar outras pessoas.

### Aula 2 - Faça como eu fiz, 8: simulador de transporte urbano

Você está desenvolvendo um simulador para um aplicativo de mobilidade urbana. Os usuários podem escolher diferentes meios de transporte para calcular o tempo estimado de chegada até o destino. O cálculo muda de acordo com o tipo de transporte utilizado:

- Ônibus: tempo estimado = (distância × 2) + 5 minutos
- Metrô: tempo estimado = distância + 5 minutos
- Bicicleta: tempo estimado = distância × 4 minutos

Sua missão é:

- Criar a classe base Transporte, com o método virtual CalcularTempo(int distanciaKm) que retorna um int (minutos).
- Criar as classes Onibus, Metro e Bicicleta, sobrescrevendo esse método com regras diferentes.
- Criar uma lista com diferentes meios de transporte e exibir o tempo estimado de cada um.

Exemplo de entrada:

```csharp
List<Transporte> opcoes = new List<Transporte>
{
    new Onibus(),
    new Metro(),
    new Bicicleta()
};

int distancia = 10;

foreach (var transporte in opcoes)
{
    Console.WriteLine($"{transporte.GetType().Name}: {transporte.CalcularTempo(distancia)} min");
}
```

Exemplo de saída:

```csharp
Onibus: 25 min  
Metro: 15 min  
Bicicleta: 40 min
```

Opinião do instrutor

Essa atividade trabalha com polimorfismo e retorno de valor. Cada tipo de transporte implementa sua própria lógica de cálculo, e o código que consome esses objetos apenas chama o método CalcularTempo(). É um padrão bem útil em sistemas que precisam de simulações, orçamentos, estimativas ou algoritmos com múltiplas estratégias.

Observe o código abaixo:

Arquivo Transporte.cs

```csharp
public class Transporte
{
    public virtual int CalcularTempo(int km)
    {
        return km * 5; // valor genérico
    }
}
```

Arquivo Onibus.cs

```csharp
public class Onibus : Transporte
{
    public override int CalcularTempo(int km)
    {
        return km * 2 + 5;
    }
}
```

Arquivo Metro.cs

```csharp
public class Metro : Transporte
{
    public override int CalcularTempo(int km)
    {
        return km + 5;
    }
}
```

Arquivo Bicicleta.cs

```csharp
public class Bicicleta : Transporte
{
    public override int CalcularTempo(int km)
    {
        return km * 4;
    }
}
```

Arquivo Program.cs

```csharp
List<Transporte> opcoes = new List<Transporte>
{
    new Onibus(),
    new Metro(),
    new Bicicleta()
};
int distancia = 10;
foreach (var transporte in opcoes)
{
    Console.WriteLine($"{transporte.GetType().Name}: {transporte.CalcularTempo(distancia)} min");
}
```

Agora é sua vez! Teste o programa com diferentes distâncias, adicione tipos como “Patinete”, e compartilhe sua solução no fórum.

### Aula 2 - Faça como eu fiz, 9: cálculo de juros para diferentes perfis de empréstimo

Você está desenvolvendo um simulador de empréstimos para uma fintech. O sistema precisa calcular o valor final de um empréstimo baseado em perfis diferentes de clientes, cada um com uma taxa de juros mensal distinta.

O cálculo deve seguir a fórmula de juros simples:

```csharp
ValorFinal = ValorEmprestado + (ValorEmprestado × Taxa × Meses)
```

As taxas são:

- Estudante: 1% ao mês
- Empresário: 2.5% ao mês
- Aposentado: 1.5% ao mês

Sua missão é:

- Criar uma interface IEmprestimo com o método CalcularValorFinal(decimal valor, int meses).
- Criar as classes EmprestimoEstudante, EmprestimoEmpresario e EmprestimoAposentado, que implementam essa interface.
- Simular o valor final de um empréstimo de R$1000 por 12 meses para cada perfil.

Exemplo de entrada:

```csharp
List<IEmprestimo> perfis = new List<IEmprestimo>
{
    new EmprestimoEstudante(),
    new EmprestimoEmpresario(),
    new EmprestimoAposentado()
};

foreach (var perfil in perfis)
{
    decimal total = perfil.CalcularValorFinal(1000m, 12);
    Console.WriteLine($"{perfil.GetType().Name}: R${total:0.00}");
}
```

Exemplo de saída:

```csharp
EmprestimoEstudante: R$1120.00  
EmprestimoEmpresario: R$1300.00  
EmprestimoAposentado: R$1180.00
```

Opinião do instrutor

Aqui exploramos o polimorfismo com retorno de valor e lógica específica por classe. Cada perfil de cliente implementa sua própria regra de juros, encapsulando a lógica sem precisar de condicionais no programa principal.

Esse padrão é ótimo quando precisamos de estratégias de cálculo reutilizáveis e expansíveis, como simulações financeiras, frete, impostos ou descontos dinâmicos.

Observe no código abaixo como podemos resolver:

Arquivo IEmprestimo.cs

```csharp
public interface IEmprestimo
{
    decimal CalcularValorFinal(decimal valor, int meses);
}
```

Arquivo EmprestimoEstudante.cs

```csharp
public class EmprestimoEstudante : IEmprestimo
{
    public decimal CalcularValorFinal(decimal valor, int meses)
    {
        decimal taxa = 0.01m;
        return valor + (valor * taxa * meses);
    }
}
```

Arquivo EmprestimoEmpresario.cs

```csharp
public class EmprestimoEmpresario : IEmprestimo
{
    public decimal CalcularValorFinal(decimal valor, int meses)
    {
        decimal taxa = 0.025m;
        return valor + (valor * taxa * meses);
    }
}
```

Arquivo EmprestimoAposentado.cs

```csharp
public class EmprestimoAposentado : IEmprestimo
{
    public decimal CalcularValorFinal(decimal valor, int meses)
    {
        decimal taxa = 0.015m;
        return valor + (valor * taxa * meses);
    }
}
```

Arquivo Program.cs

```csharp
List<IEmprestimo> perfis = new List<IEmprestimo>
{
    new EmprestimoEstudante(),
    new EmprestimoEmpresario(),
    new EmprestimoAposentado()
};
foreach (var perfil in perfis)
{
    decimal total = perfil.CalcularValorFinal(1000m, 12);
    Console.WriteLine($"{perfil.GetType().Name}: R${total:0.00}");
}
```

Agora é sua vez! Teste o programa com outros valores, implemente novos perfis e compartilhe sua versão no fórum.

### Aula 2 - Faça como eu fiz, 10: ações em botões de interface gráfica

Imagine que você está desenvolvendo o backend de um painel administrativo com vários botões. Cada botão realiza uma ação específica, como salvar, editar ou excluir dados.

Você quer permitir que cada ação tenha sua própria lógica.

Sua missão é:

- Criar a interface IAcaoBotao com o método Executar().
- Criar as classes SalvarAcao, EditarAcao e ExcluirAcao, que implementam essa interface.
- Criar uma lista de ações e executá-las em um foreach.

Exemplo de entrada:

```csharp
List<IAcaoBotao> acoes = new List<IAcaoBotao>
{
    new SalvarAcao(),
    new EditarAcao(),
    new ExcluirAcao()
};

foreach (var acao in acoes)
{
    acao.Executar();
}
```

Exemplo de saída:

```csharp
Salvando dados no banco...  
Editando informações do cadastro...  
Excluindo registro do sistema...
```

Opinião do instrutor

Nessa atividade mostramos como interfaces ajudam a encapsular ações e deixam o código muito mais flexível. Você pode alterar o comportamento de cada botão sem mexer em blocos de decisão ou na estrutura geral do sistema. Veja o código completo:

Arquivo IAcaoBotao.cs

```csharp
public interface IAcaoBotao
{
    void Executar();
}
```

Arquivo SalvarAcao.cs

```csharp
public class SalvarAcao : IAcaoBotao
{
    public void Executar()
    {
        Console.WriteLine("Salvando dados no banco...");
    }
}
```

Arquivo EditarAcao.cs

```csharp
public class EditarAcao : IAcaoBotao
{
    public void Executar()
    {
        Console.WriteLine("Editando informações do cadastro...");
    }
}
```

Arquivo ExcluirAcao.cs

```csharp
public class ExcluirAcao : IAcaoBotao
{
    public void Executar()
    {
        Console.WriteLine("Excluindo registro do sistema...");
    }
}
```

Arquivo Program.cs

```csharp
List<IAcaoBotao> acoes = new List<IAcaoBotao>
{
    new SalvarAcao(),
    new EditarAcao(),
    new ExcluirAcao()
};
foreach (var acao in acoes)
{
    acao.Executar();
}
```

Agora é sua vez! Teste o programa, experimente criar outras ações (como “Exportar”, “Imprimir”) e compartilhe sua solução no fórum.

### Aula 2 - Para saber mais: por que o polimorfismo reduz o uso de if ou switch?

Durante os desafios deste curso, você provavelmente percebeu que quase não usamos estruturas condicionais como if, else ou switch para decidir qual comportamento executar em diferentes tipos de objeto. E isso não foi por acaso, é exatamente aqui que o polimorfismo brilha.

Polimorfismo permite que você tenha várias classes com o mesmo método, mas com comportamentos diferentes, e ainda assim possa tratá-las de forma genérica. Ao invés de perguntar "qual o tipo deste objeto?" para então decidir o que fazer (usando if ou switch), você apenas chama o método e a linguagem já sabe qual versão executar com base na instância real do objeto.

Isso evita um código como este:

```csharp
if (transporte is Onibus)
    Console.WriteLine("Tempo: " + ((Onibus)transporte).CalcularTempo(distancia));
else if (transporte is Metro)
    Console.WriteLine("Tempo: " + ((Metro)transporte).CalcularTempo(distancia));
else if (transporte is Bicicleta)
    Console.WriteLine("Tempo: " + ((Bicicleta)transporte).CalcularTempo(distancia));
```

E permite escrever de forma muito mais simples:

```csharp
Console.WriteLine("Tempo: " + transporte.CalcularTempo(distancia));
```

Essa abordagem torna seu código mais limpo, mais fácil de manter e pronto para crescer. Sempre que precisar adicionar um novo tipo (como “Patinete” ou “Carro”), você não precisa modificar nada do que já está pronto, basta criar uma nova classe com sua própria versão do método.

Em suma, o polimorfismo elimina a necessidade de fazer verificações manuais de tipo, porque cada classe já sabe qual comportamento executar.

No dia a dia de uma pessoa desenvolvedora, esse conceito é importante para construir sistemas que lidam com vários tipos de regras e variações de comportamento. Isso reduz erros, melhora a organização do código e facilita o trabalho em equipe.

### Aula 2 - Conclusão

Parabéns por concluir este curso! Ao longo desta jornada prática, você mergulhou nos principais conceitos de polimorfismo e aprendeu como aplicar diferentes formas de herança, abstração e reutilização de código em sistemas orientados a objetos.

Você agora é capaz de:

- Implementar polimorfismo de sobrecarga e sobrescrita, permitindo que seus métodos se comportem de formas diferentes com base nos parâmetros ou no tipo da instância.

- Utilizar interfaces e classes abstratas para estruturar seu código com flexibilidade e garantir contratos claros entre componentes.

- Trabalhar com listas de objetos polimórficos, percorrendo elementos de tipos distintos, mas que compartilham um comportamento comum.

Quer continuar evoluindo em C#? Recomendamos a formação [C# e Orientação a Objetos: coleções, arquivos e bibliotecas](https://cursos.alura.com.br/formacao-avancando-c-sharp) para dar os próximos passos.

Nos vemos nos próximos cursos práticos!
