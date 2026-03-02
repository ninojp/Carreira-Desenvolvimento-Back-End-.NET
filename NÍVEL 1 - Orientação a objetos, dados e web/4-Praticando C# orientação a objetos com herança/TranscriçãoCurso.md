# Curso Alura - Praticando C# orientação a objetos com herança

## Aula 1 - O que é Herança

### Aula 1 - Apresentação - Vídeo 1

Transcrição
Olá! Meu nome é Yasmin Araújo, sou instrutora na Escola de Programação, e irei me autodescrever para fins de acessibilidade.

Audiodescrição: Yasmin é uma mulher branca, com cabelo castanho escuro na altura dos ombros. Ela veste uma blusa bege e, ao fundo, há uma parede iluminada com luz azul.

Objetivos do Curso
Neste curso, vamos trabalhar a coerência, que é um dos pilares da orientação a objetos. Abordaremos diversos tópicos relacionados a isso.

Conteúdo do Curso
Começaremos aprendendo a utilizar a herança, com foco principalmente no uso de herança em C#. Também trabalharemos com classes mães e classes filhas.

Vamos utilizar a herança para definir esses tópicos. Além disso, veremos as classes abstratas e as interfaces, aprendendo a diferenciar essas duas abordagens. Por fim, trabalharemos com o uso de composição e compararemos o uso de composição com o uso de herança.

Importância da Orientação a Objetos
Temos diversos tópicos aqui que são bastante importantes, e todos eles, juntos, nos permitem representar o mundo real e diversas situações complexas do mundo real utilizando a programação. É nesse ponto que reside a magia da orientação a objetos.

Conclusão e Expectativas
Estamos bastante animados para trabalhar com todos esses tópicos e esperamos que vocês nos acompanhem também.

Observações Finais
Infelizmente, não há snippets de código fornecidos para este vídeo, mas a explicação detalhada de Yasmin nos dá uma boa base teórica para entender como a herança, classes abstratas, interfaces e composição são fundamentais na programação orientada a objetos.

### Aula 1 - O que esperar deste curso?

Antes de mergulharmos no código, que tal alinharmos as expectativas?

**O que significa um curso prático?**  
Já se pegou pensando — será que consigo aplicar o que aprendi na prática? Este curso é a sua resposta. Aqui, o foco é colocar a mão no código, resolver problemas e testar seu conhecimento de forma ativa. Você terá:

- Vídeo de revisão do conteúdo
- Material de apoio
- Desafios de código

Pré requisitos

É importante ter concluído o curso C#: criando sua primeira aplicação, pois ele cobre os fundamentos da linguagem, garantindo que você consiga realizar os exercícios deste curso com mais segurança.

**Dicas para potencializar seu aprendizado neste curso**  

- Assista ao vídeo de revisão com atenção. Pause, anote e revise sempre que necessário.
- Baixe o material complementar para ter um apoio nas atividades.
- Faça os desafios na sua IDE favorita.
- Compartilhe o que aprendeu no fórum, pois sua abordagem pode inspirar outras pessoas.

Vamos começar?

### Aula 1 - Preparando o ambiente: instalando o Visual Studio

Olá!  
O IDE do Visual Studio é uma plataforma de lançamento criativa que você pode usar para editar, depurar e criar código e, em seguida, publicar um aplicativo. Além do editor e depurador padrão fornecidos pela maioria dos IDEs, o Visual Studio inclui compiladores, ferramentas de conclusão de código, designers gráficos e muitos outros recursos para aprimorar o processo de desenvolvimento de software.

O IDE mais abrangente para desenvolvedores .NET no Windows e Mac para criação de web, nuvem, desktop, aplicativos móveis, serviços e jogos. Sabendo disso, preparamos alguns vídeos para instalar em diferentes sistemas operacionais. Caso o seu objetivo seja desenvolver em .NET, marque a opção ASP.NET e Desenvolvimento Web no processo de instalação, mas, caso o seu objetivo seja apenas C#, marque a opção Desenvolvimento para Desktop com .NET.

Videos internos da plataforma:

Visual Studio no Windows

Visual Studio no Mac

C# no VSCODE (SDK)

C# em distribuições Linux
[Neste link](https://learn.microsoft.com/pt-br/dotnet/core/install/linux), você encontra um passo a passo da própria Microsoft de como instalar em distribuições Linux, como Alpine, CentOS, Debian, entre outras.

Vamos começar?

### Aula 1 - Preparando o ambiente: material de apoio

Após revisar os conceitos sobre herança é hora de colocar o conhecimento em prática com uma série de atividades focadas no tema. Caso queira acessar os slides da revisão, eles estão disponíveis no link abaixo:

[Baixe os slides do curso](https://cdn3.gnarususercontent.com.br/4703-csharp/Praticando%20C%23_orienta%C3%A7%C3%A3o%20a%20objetos%20com%20heran%C3%A7a.pdf)

Após finalizar todos os desafios, não esqueça de compartilhar sua solução no fórum. Será incrível ver como você resolveu! Vamos nessa?

### Aula 1 - Classes mães e filhas - Vídeo 2

Transcrição  
Nós vamos continuar trabalhando neste curso com a classe Produto, para simular um sistema de e-commerce. Ao analisarmos a nossa classe Produto, percebemos que ela contém informações que representam produtos físicos. Por exemplo, um produto só pode ser estocado se for um produto físico. No entanto, queremos representar produtos físicos em nosso site, mas também desejamos vender produtos digitais. Um produto digital não terá estoque, mas, por outro lado, terá um link de download. Assim, um produto digital terá todas as características de um produto físico, exceto o estoque, além de outras informações e métodos que um produto físico não possui.

**Criação das Classes ProdutoFisico e ProdutoDigital**  
Para modelar essa situação, podemos copiar e colar a classe Produto e fazer as alterações necessárias. No gerenciador de soluções, vamos copiar a classe Produto e colar, renomeando a cópia para ProdutoDigital, que será a classe diferente. Na classe Produto original, vamos renomeá-la para ProdutoFisico, para diferenciar bem as duas. O Visual Studio perguntará se desejamos renomear todas as referências, mas não faremos isso, então clicaremos em "não" e renomearemos manualmente. Assim, a classe Produto passará a se chamar ProdutoFisico, e o construtor também será ProdutoFisico.

**Implementação das Classes**  
Vamos começar criando a classe ProdutoFisico:

> class ProdutoFisico

E o seu construtor:

```csharp
public ProdutoFisico(string nome, string descricao,
            decimal preco, string imagem)
```

Na classe ProdutoDigital, a classe e o construtor serão renomeados para ProdutoDigital.

```csharp
class ProdutoDigital
```

```csharp
public ProdutoDigital(string nome, string descricao,
            decimal preco, string imagem)
```

**Ajustes na Classe ProdutoDigital**  
Um produto digital não possui estoque, então podemos remover o estoque da classe, do construtor e do método estaDisponivel.

```csharp
// Deletes the following line from ProdutoDigital.cs
public int Estoque { get; };

// Deletes the following line from the ProdutoDigital constructor
this.Estoque = 0;

// Deletes the following method from ProdutoDigital.cs
public bool EstaDisponivel()
{
    return Estoque > 0;
}
```

Além disso, um produto digital terá um link de download, que será semelhante à imagem, que era um link usado para exibir no site. Esse link precisa ser validado usando a propriedade. Portanto, vamos duplicar a propriedade da imagem e fazer o mesmo código.

```csharp
private string linkDownload;
```

```csharp
// Duplicates the existing Imagem property block
public string Imagem
{
    get
    {
        return imagem;
    }
    set
    {
        if (value.Length > 0)
        {
            this.imagem = value;
        }
    }
}
```

Agora, vamos criar a propriedade LinkDownload:

```csharp
public string LinkDownload
{
    get
    {
        return linkDownload;
    }
    set
    {
        if (value.Length > 0)
        {
            this.linkDownload = value;
        }
    }
}
```

**Problemas de Duplicação de Código**  
Com essas alterações, temos a nossa classe ProdutoDigital e também o nosso ProdutoFisico. No entanto, se observarmos bem, temos vários códigos duplicados. Para visualizar isso melhor, vamos para o nosso slide. Atualmente, temos uma classe ProdutoFisico com um código verde e outro transparente, e uma classe ProdutoDigital com o mesmo código verde, que está duplicado, e abaixo, a parte transparente, onde estão as especificidades do produto digital. Se quisermos construir um novo produto, criaríamos uma nova classe que teria toda essa parte verde, comum a todos, e uma parte específica. A cada nova classe criada, duplicamos mais e mais nossos códigos. Essa duplicação dificulta a manutenção das classes. Não queremos trabalhar com duplicação de código, e é por isso que a orientação a objetos nos propõe o conceito de herança.

**Introdução ao Conceito de Herança**  
Com a herança, vamos separar as informações que aparecem em comum em uma outra classe. Teremos uma classe Produto, onde estará tudo o que é genérico. Faremos com que as outras classes herdem dessa classe. Assim, ProdutoFisico herdará de Produto, e ProdutoDigital também herdará de Produto. Com isso, eles herdarão esses atributos, mas não necessariamente precisaremos escrever esse código dentro dessas classes mais específicas. Dessa forma, evitamos a duplicação de código, erros na manutenção e outros problemas que podem surgir dessa duplicação.

**Implementação da Herança**  
Como vamos modelar a herança dentro das nossas classes no Visual Studio? Vamos voltar para lá. No Visual Studio, precisaremos criar uma nova classe Produto, conforme vimos no slide.

```csharp
class Produto
```

Dentro de "Praticando C Sharp", vamos pegar o ProdutoFisico novamente e usar Ctrl C, Ctrl V para facilitar nosso trabalho. Vamos renomear essa classe de ProdutoFisico para Produto. Entraremos no arquivo e identificaremos o que Produto tem em comum em todas as classes: imagem, nome, descrição e preço. O estoque é específico do ProdutoFisico, então vamos apagá-lo.

```csharp
// Deletes the following line from Produto.cs
public int Estoque { get; };
```

O construtor também pode ser apagado por enquanto.

```csharp
// Deletes the following constructor from Produto.cs
public Produto(string nome, string descricao,
            decimal preco, string imagem)
{
    this.Nome = nome;
    this.Descricao = descricao;
    this.Preco = preco;
    this.Estoque = 0;
    this.Imagem = imagem;
}
```

Alterar preço com desconto é geral, assim como a imagem. Dessa forma, já definimos nossa classe Produto.

**Aplicação da Herança nas Classes Filhas**  
Agora, vamos modelar a herança. Salvamos a classe Produto, vamos para ProdutoDigital e adicionamos dois pontos, Produto. Ao fazer isso, estamos dizendo que ProdutoDigital herda de Produto.

```csharp
class ProdutoDigital : Produto
```

Assim, tudo o que existe dentro de Produto estará dentro de ProdutoDigital também. Podemos apagar o nome, a descrição, o preço e a imagem.

```csharp
// Deletes the following lines from ProdutoDigital.cs
public string Nome { get; };
public string Descricao { get; };
public decimal Preco { get; private set; }
```

Também podemos apagar o método de alterar preço com desconto e a propriedade da imagem.

```csharp
// Deletes the following method and property from ProdutoDigital.cs
public void AlterarPrecoComDesconto(decimal desconto)
{
    Preco = Preco * (1 - desconto/100);
}

public string Imagem
{
    get
    {
        return imagem;
    }
    set
    {
        if (value.Length > 0)
        {
            this.imagem = value;
        }
    }
}
```

Vamos fazer o mesmo para ProdutoFisico.

```csharp
class ProdutoFisico : Produto
```

No ProdutoFisico, apagamos tudo o que está em Produto, que são o nome, a descrição, o preço e a imagem.

```csharp
// Deletes the following lines from ProdutoFisico.cs
public string Nome { get; };
public string Descricao { get; };
public decimal Preco { get; private set; }
```

Podemos apagar também o método de alterar preço com desconto e a imagem.

```csharp
// Deletes the following method and property from ProdutoFisico.cs
public void AlterarPrecoComDesconto(decimal desconto)
{
    Preco = Preco * (1 - desconto/100);
}

public string Imagem
{
    get
    {
        return imagem;
    }
    set
    {
        if (value.Length > 0)
        {
            this.imagem = value;
        }
    }
}
```

**Conclusão e Próximos Passos**  
Dessa forma, temos uma nova classe para ProdutoFisico e uma nova classe para ProdutoDigital. O ProdutoFisico deve herdar a classe de fato, para que possamos utilizar os atributos. Então, adicionamos dois pontos, Produto.

Estamos trabalhando com a herança tanto em ProdutoFisico quanto em ProdutoDigital. Nosso construtor está com alguns problemas associados a propriedades, que vamos comentar por enquanto, e depois entenderemos melhor.

```csharp
// Comments out the constructor in ProdutoFisico.cs
/*public ProdutoFisico(string nome, string descricao,
            decimal preco, string imagem)
{
    this.Nome = nome;
    this.Descricao = descricao;
    this.Preco = preco;
    this.Estoque = 0;
    this.Imagem = imagem;
}*/
```

```csharp
// Comments out the constructor in ProdutoDigital.cs
/*public ProdutoDigital(string nome, string descricao,
            decimal preco, string imagem)
{
    this.Nome = nome;
    this.Descricao = descricao;
    this.Preco = preco;
    this.Imagem = imagem;
}*/
```

Comentando esses códigos dos construtores, nosso código está compilando. Note que ProdutoDigital agora é uma classe muito menor do que estava antes, e o mesmo ocorre com ProdutoFisico. Se quisermos criar um novo tipo de produto, não precisaremos declarar novamente as propriedades nome, descrição, preço e imagem. Basta herdar da classe Produto, evitando toda essa duplicação de código.

Uma nomenclatura formal é que todas as classes que herdam de outras são classes filhas, e as classes das quais herdamos são as classes mães. Nesse caso, Produto é a classe de quem herdamos, então é uma classe mãe, e as classes ProdutoDigital e ProdutoFisico são classes filhas. Na sequência, veremos como resolver o problema do construtor para conseguir executar nosso código de fato, pois ele está com alguns problemas.

continuar lendo

### Aula 1 - Herança - Vídeo 3

Transcrição  
Nós observamos que, ao implementar a herança, o nosso construtor deixou de funcionar, tanto para o caso de produto digital quanto para o caso de produto físico. Vamos descomentar o nosso construtor de produto digital para entender o que ocorreu e quais são os erros. Dentro do nosso construtor, notamos que surgiram erros relacionados a nome, descrição e preço. O erro que aparece é que a propriedade ou indexador não podem ser atribuídos, pois esse indexador é somente leitura.

Para ilustrar, aqui está o construtor original do ProdutoDigital que causou o problema:

```csharp
public ProdutoDigital(string nome, string descricao,
    decimal preco, string imagem)
{
    this.Nome = nome;
    this.Descricao = descricao;
    this.Preco = preco;
    this.Imagem = imagem;
}
```

**Análise dos Erros e Solução com protected set**  
O que isso significa? Se voltarmos ao nosso arquivo produto.cs, veremos que as propriedades nome, descrição e preço possuem vários GETs, e no caso do preço, há um private set. Portanto, não conseguimos alterar a propriedade fora da classe. Se tentarmos utilizar o construtor para acessar atributos dessa classe, não conseguiremos alterá-los, justamente porque não existe um set ou porque o set é privado.

Como podemos resolver isso? Podemos utilizar um modificador de acesso que permita que nossas propriedades sejam acessadas e alteradas dentro das classes filhas. Para isso, usaremos o modificador protected. No lugar do private set do preço, colocaremos um protected set. Faremos o mesmo para a descrição, adicionando um protected set, e novamente para o nome, colocando um protected set.

Aqui estão as alterações nas propriedades:

```csharp
public decimal Preco { get; protected set; }
public string Descricao { get; protected set; }
public string Nome { get; protected set; }
```

Se voltarmos à nossa classe de produto digital e salvarmos, notaremos que agora tudo está compilando corretamente, pois indicamos que em classes filhas conseguimos alterar esses valores. Essa é uma das soluções. Se formos ao produto físico e descomentarmos, ele funcionará normalmente, pois alteramos tudo para todas as classes.

**Considerações sobre Encapsulamento e Alternativa com Construtor Base**  
No entanto, essa solução de usar protected set pode gerar outros problemas. Pode ser que desejemos que nome, descrição e preço sejam realmente alteráveis apenas dentro da classe de produto. Ou seja, se quisermos alterar o preço com desconto em outra classe filha, não conseguiremos, pois toda essa lógica está encapsulada apenas dentro de produto. Essa é uma boa prática.

Em vez de ter um protected set e permitir alterações dentro das outras classes, podemos manter nossa propriedade oculta e permitir que apenas no construtor ela seja alterada. Como faremos isso? Primeiro, apagaremos o protected set. Vamos reverter o código para o estado anterior. Em seguida, podemos criar um construtor com todos os elementos gerais de produto. Copiaremos o construtor de produto digital e colaremos na classe produto, renomeando para produto. Esse construtor contém exatamente o que desejamos: elementos gerais de produto e atribuições conforme criamos anteriormente.

Aqui está o construtor da classe Produto:

```csharp
public Produto(string nome, string descricao,
    decimal preco, string imagem)
{
    this.Nome = nome;
    this.Descricao = descricao;
    this.Preco = preco;
    this.Imagem = imagem;
}
```

**Implementação de Herança de Construtores**  
Uma vez que temos esse construtor, podemos usá-lo nas classes filhas. Como faremos isso? Utilizando uma herança de construtores. No produto digital, logo após a declaração dos parâmetros, podemos usar dois pontos e a palavra-chave base.

Usando essa palavra base, nós vamos abrir e fechar os parênteses e passar todos os atributos de produto digital. Vamos passar nome, descrição, preço e imagem. Ao fazer isso, estamos chamando o construtor da nossa classe base, a classe mãe, que é o construtor de produto. Assim, toda vez que quisermos inicializar um produto digital, faremos primeiro uma inicialização de produto da parte mais genérica e depois a parte mais específica.

Aqui está como o construtor do ProdutoDigital foi modificado:

```csharp
public ProdutoDigital(string nome, string descricao,
    decimal preco, string imagem, string linkDownload)
    : base(nome, descricao, preco, imagem)
{
    this.LinkDownload = linkDownload;
}
```

Nesse caso, toda a inicialização de nome, descrição, preço e imagem já é feita em produto, então podemos apagar essas linhas. Podemos deixar apenas as partes mais específicas de um produto digital, como, por exemplo, o linkDownload. Vamos adicionar no produto digital uma string linkDownload. Podemos dizer que as partes iniciais vão usar o nosso construtor base e a parte específica, que é o this.linkDownload, vai receber o linkDownload do parâmetro.

Podemos fazer exatamente a mesma coisa na nossa classe produto físico. Como faremos isso? Vamos copiar o que está em produto digital e colar. Agora, todas as nossas inicializações gerais não precisam mais ficar no construtor de produto físico; elas ficam no construtor de produto genérico. Podemos apagar essas outras linhas e deixar apenas o this.stock. Dessa forma, reaproveitamos o código do construtor e garantimos melhor o nosso encapsulamento, tanto de produto quanto de produto físico e produto digital.

Aqui está o construtor do ProdutoFisico:

```csharp
public ProdutoFisico(string nome, string descricao,
    decimal preco, string imagem)
    : base(nome, descricao, preco, imagem)
{
    this.Estoque = 0;
}
```

**Criação de Produtos no program.cs**  
Vamos salvar as nossas classes. Podemos utilizar essas classes agora no nosso program.cs. Se formos para o program.cs, estamos criando produtos genéricos, mas podemos criar produtos específicos. Vamos criar um produto físico, que é um new ProdutoFisico. Aqui, o nosso código não altera nada, mas vamos criar também um produto digital. Vamos copiar todo esse código de cima, colar e alterar para produto digital. Então, produtoDigital item2 será um new ProdutoDigital.

Aqui está como criamos os produtos no program.cs:

```csharp
ProdutoFisico item1 = new ProdutoFisico("Teclado", "Modelo compacto e silencioso, " +
    "perfeito para produtividade diária.",
    80.00m, "Imagem");

ProdutoDigital item2 = new ProdutoDigital("Curso", "OO em C#",
    100.00m, "Imagem ilustrativa", "Link");
```

Um produto digital pode ser, por exemplo, um curso. Vamos criar os nossos valores. Ele será um curso e a descrição dele será "OO em C-sharp". O preço será de 100 reais, então colocaremos 100.00m. Além disso, temos também o link de download. Vamos colocar um link. Além disso, temos a imagem também antes. Vamos colocar "imagem ilustrativa", só para ficar diferente. Temos um curso de "OO em C-sharp", que custa 100 reais, uma imagem ilustrativa e um link de download.

**Exibição dos Dados dos Produtos**  
Aqui embaixo, podemos passar também dados do item2, que serão item2.nome, item2.descrição, item2.preço. E ali, ao invés de ser estoque, colocamos link. Colocamos item2.link. Assim, criamos um produto físico e um produto digital. Aparentemente, está tudo compilando. Vamos executar o nosso código para ver se realmente está funcionando. O código está sendo executado e temos os nossos dados. Os dados do item1, assim como estavam antes, e as alterações aqui também. Os dados do item2 também foram construídos com sucesso. Conseguimos criar produtos do tipo produto físico e produto digital, utilizando a herança.

Aqui está o código para exibir os dados do item2:

```csharp
Console.WriteLine(@$"Dados do item 2:
    Nome: {item2.Nome};
    Descrição: {item2.Descricao};
    Preço: {item2.Preco};
    Link: {item2.LinkDownload};
");
```

## Aula 2 - Classes abstratas e interfaces

### Aula 2 - Classes abstratas - Vídeo 1

Transcrição  
Atualmente, em nosso sistema, conseguimos criar produtos de vários tipos. No programa CS, é possível instanciar uma classe do tipo produto físico. Instanciar um produto físico é o mesmo que criar um objeto do tipo produto físico. Vamos ver como isso é feito com o seguinte código:

```csharp
ProdutoFisico item1 = new ProdutoFisico("Teclado", "Modelo compacto e silencioso perfeito para produtividade diária.", 80.00m, "Imagem");
```

Esse trecho de código cria um produto físico chamado item1, que representa um teclado. Podemos exibir suas informações usando o seguinte código:

```csharp
Console.WriteLine(@$"Dados do item 1:
    Nome: {item1.Nome};
    Descricao: {item1.Descricao};
    Preco: {item1.Preco};
    Estoque: {item1.Estoque};
");
```

E para exibir a imagem associada ao produto, usamos:

```csharp
Console.WriteLine($"Imagem: {item1.Imagem}");
```

Se quisermos alterar a imagem do produto, podemos fazer isso da seguinte forma:

```csharp
item1.Imagem = "Nova Imagem";
Console.WriteLine($"Imagem: {item1.Imagem}");
```

**Criação de Produtos Digitais**  
Além de produtos físicos, também conseguimos instanciar um produto digital. Veja o exemplo abaixo:

```csharp
ProdutoDigital item2 = new ProdutoDigital("Curso", "00 em C#", 100.00m, "Imagem ilustrativa", "Link");
```

Podemos exibir as informações do produto digital com o seguinte código:

```csharp
Console.WriteLine(@$"Dados do item 2:
    Nome: {item2.Nome};
    Descricao: {item2.Descricao};
    Preco: {item2.Preco};
    Link: {item2.LinkDownload};
");
```

**Considerações sobre Produtos Genéricos**  
Agora, para comprovar que podemos adaptar a construção de um produto digital para um produto genérico, vamos modificar o código. Vamos apagar a parte referente ao digital, nomear o produto como item3 e definir como um new Produto. Como um produto não possui link, apagaremos a última opção do construtor, que é o link:

```csharp
Produto item3 = new Produto("Curso", "00 em C#", 100.00m, "Imagem ilustrativa");
```

Nosso código está compilando normalmente, permitindo a criação de vários tipos de produto. No entanto, ao considerar nossas regras de negócio, temos produtos físicos e digitais, além do produto genérico. Faz sentido criar esse produto genérico em nosso contexto? Se desejamos adicionar novos produtos ao sistema, eles serão digitais ou físicos. A classe Produto serve apenas para representar tudo que é comum entre os produtos, evitando a duplicação de código. Não é necessariamente utilizada para criar novos produtos.

**Implementação de Classe Abstrata**  
Portanto, a ideia é bloquear a criação de produtos genéricos, mas permitir que a herança ocorra. Não vamos simplesmente apagar a classe Produto.

Como podemos fazer isso? Podemos definir nossa classe Produto como uma classe abstrata, ou seja, ela terá apenas definições de um produto e não poderá ser instanciada. Para que as informações possam ser atribuídas, utilizaremos as especificações, as classes filhas dessa classe, que são ProdutoDigital ou ProdutoFisico.

Para indicar que uma classe é abstrata, utilizamos um modificador chamado abstract. Assim, antes da declaração da classe, inserimos essa palavra-chave, indicando que ela não pode ser instanciada, ou seja, não podemos criar produtos genéricos. Vamos ver como isso é feito:

```csharp
abstract class Produto
{
    private string Imagem;
    public string Nome { get; }
    public string Descricao { get; }
    public decimal Preco { get; private set; }

    public Produto(string nome, string descricao, decimal preco, string imagem)
    {
        this.Nome = nome;
        this.Descricao = descricao;
        this.Preco = preco;
        this.Imagem = imagem;
    }

    public void AlterarPrecoComDesconto(decimal desconto)
    {
        Preco = Preco * (1 - desconto/100);
    }

    public string Imagem
    {
        get
        {
            return Imagem;
        }
        set
        {
            if (value.Length > 0)
            {
                this.Imagem = value;
            }
        }
    }
}
```

**Ajustes no Código e Considerações Finais**  
Após salvarmos a classe Produto, ao verificarmos o arquivo program.cs, no último construtor que criamos, notamos que ele apresenta um erro. O erro indica que não é possível criar uma instância de um tipo abstrato, pois nossa classe agora contém apenas definições. Portanto, podemos apagar esse construtor.

Para sintetizar melhor as informações, vamos analisar o slide. Anteriormente, tínhamos Produto, ProdutoFisico e ProdutoDigital, sendo que ProdutoDigital e ProdutoFisico herdavam de Produto. Todas essas classes podiam ser instanciadas. Agora, a parte comum de Produto não é mais instanciada, e só conseguimos instanciar as informações e atribuir valores utilizando a classe ProdutoFisico ou a classe ProdutoDigital. Dessa forma, conseguimos modelar melhor nosso contexto, evidenciando essas diferenças.

Em alguns casos, desejaremos instanciar as classes mães, pois fará sentido, mas em outros casos, essas classes mães serão apenas conceitos abstratos. Por isso, utilizamos a palavra-chave abstract. Na sequência, veremos a diferença entre trabalhar com classes abstratas e com interfaces.

continuar lendo

### Aula 2 - Interfaces - Vídeo 2

Transcrição  
Para evoluir ainda mais nossa aplicação, criamos uma classe Pedido. A classe Pedido serve para representar os pedidos realizados em nosso e-commerce. Um pedido pode ser pago ou não, e possui um ID, um cliente, uma data e um valor total. A data é do tipo date-time. Por enquanto, não vamos focar muito nesse tipo específico, mas é importante saber que ele serve para representar datas em nosso sistema.

**Definição da Classe Pedido**  
Vamos começar definindo a classe Pedido com suas propriedades e métodos básicos:

```csharp
public class Pedido
{
    private bool pago;
    public int Id { get; }
    public string Cliente { get; }
    public DateTime Data { get; }
    public decimal ValorTotal { get; }

    public Pedido(int id, string cliente, decimal valorTotal)
    {
        Id = id;
        Cliente = cliente;
        Data = DateTime.Now;
        ValorTotal = valorTotal;
        pago = false;
    }

    public void ExibirResumo()
    {
        Console.WriteLine($"Pedido #{Id} - Cliente: {Cliente}");
        Console.WriteLine($"Valor Total: R$ {ValorTotal:F2}");
        Console.WriteLine($"Status: {(EstaExpirado() ? "Expirado" : "Válido")}");
    }

    public bool EstaExpirado()
    {
        return !pago && DateTime.Now > Data.AddMinutes(15);
    }

    public void Pagar()
    {
        pago = true;
    }
}
```

**Lógica de Expiração e Produtos Digitais**  
Além disso, o pedido possui um construtor, um método para exibir um resumo dos dados, um método para verificar se está expirado e um método para efetuar o pagamento, que simplesmente marca o pedido como pago. A lógica do método que verifica se está expirado é verificar se o pedido não foi pago e se já se passaram 15 minutos desde que foi criado. Assim, ao criar um pedido, é atribuída uma data inicial. Se essa data, somada a 15 minutos, já tiver passado e o pedido não tiver sido pago, ele será considerado expirado.

Esse conceito de expiração também faz sentido na classe de produto digital. Produtos digitais podem ser fornecidos ao usuário por um certo tempo, e após esse período, podem expirar, exigindo que o usuário compre novamente o produto. Para isso, criamos um método específico que retorna se o produto digital está expirado ou não. A ideia é que haja uma data de compra, e após dois anos, o produto digital expire, necessitando de uma nova compra.

```csharp
public bool EstaExpirado()
{
    return DateTime.Now > DataCompra.AddYears(2);
}
```

**Introdução ao Uso de Interfaces**  
Observamos que tanto o método de expiração do produto digital quanto o do pedido são semelhantes, resultando em códigos duplicados. Na orientação a objetos, evitamos trabalhar com duplicação de código. Podemos pensar que tanto um produto digital quanto um pedido podem expirar. Assim, ambos são "expiráveis". Poderíamos criar uma classe Expirável para agrupar essas ideias e comportamentos semelhantes. No entanto, isso poderia resultar em uma herança forçada, pois estaríamos agrupando comportamentos distantes entre pedido e produto digital, o que não é desejável.

Para resolver isso, em vez de usar herança, podemos estabelecer uma relação através de interfaces. Em uma interface, produtos podem compartilhar alguns métodos sem necessariamente compartilhar todos os atributos e métodos. Dessa forma, conseguimos selecionar quais comportamentos serão herdados e compartilhados.

**Implementação da Interface IExpiravel**  
Para aplicar o uso das interfaces, vamos ao nosso Visual Studio. No Visual Studio, criaremos uma interface que conterá os métodos em comum do produto digital e do pedido. Essa interface será chamada de Expirável. Em C Sharp, há uma convenção de que todas as interfaces devem começar com a letra "I".

```csharp
// New file: IExpiravel.cs
interface IExpiravel
{
    bool EstaExpirado();
}
```

Qual é a ideia da nossa interface? No caso de expirar, um produto digital terá o método estáExpirado, assim como o pedido. Se voltarmos à interface IExpiravel, podemos declarar um bool estáExpirado. Feito isso, simplesmente fecharemos a declaração do nosso método. A ideia é que a interface apenas declare que algo pode ser feito com ela. Assim, algo que é IExpiravel pode ter o comportamento estáExpirado, e decidiremos como esse comportamento será implementado especificamente dentro das nossas classes.

**Aplicação da Interface em Classes**  
Uma outra coisa importante sobre interfaces é que os métodos já são públicos por padrão. Portanto, não precisamos usar a palavra-chave public ou internal. Por padrão, eles já são públicos. Assim, uma vez que declaramos a nossa interface IExpiravel, podemos fazer com que as outras classes implementem essa interface. Na classe ProdutoDigital, faremos com que ela implemente a interface IExpiravel.

```csharp
// In ProdutoDigital.cs
class ProdutoDigital : Produto, IExpiravel
```

Observe que não temos nenhum erro, justamente porque já existia o método estáExpirado. Na linha 29, ao lado do estáExpirado, há um ícone que é um "i" com uma seta. Ao clicar nesse ícone, ele mostra que há membros implementados de uma interface. Nesse caso, estamos implementando o membro estáExpirado da interface IExpiravel. Além disso, podemos fazer o mesmo em Pedido.

```csharp
// In Pedido.cs
class Pedido : IExpiravel
```

**Testando a Implementação da Interface**  
Para implementar uma interface, usamos, assim como na herança, os dois pontos. Colocamos um IExpiravel ali. Feito isso, como o método já está definido, o compilador entende que estamos fazendo uma definição baseada na interface.

Toda vez que utilizamos os dois pontos IExpiravel, estamos indicando que vamos utilizar a interface IExpiravel. Se não utilizarmos essa interface, o compilador apresentará um erro. Vamos comentar o estáExpirado para testar.

```csharp
/*public bool EstaExpirado()
{
    return !pago && DateTime.Now > Data.AddMinutes(15);
}*/
```

Comentando, se voltarmos, ele começa a dar erro dizendo que a classe Pedido não está implementando os membros da interface IExpiravel. Trabalhar com interfaces é trabalhar com contratos. Toda vez que decidimos implementar a interface, somos obrigados a implementar todos os métodos definidos na interface. O contrato é o seguinte: podemos utilizar o método desde que o implementemos. Vamos descomentar agora. Estávamos comentando apenas por curiosidade.

Dessa forma, temos o uso de interfaces no nosso código. Vamos salvar tudo. Na classe Program.cs, podemos ir ao nosso item 2, por exemplo, que é um produto digital, e adicionar uma informação para estáExpirado.

```csharp
// In Program.cs
Console.WriteLine($"Está expirado: {item2.EstaExpirado()}");
```

Na linha 20, declararemos no formato de string o estáExpirado, para verificar se a nossa interface está  funcionando. Vamos pegar o nosso item 2, ponto, estáExpirado. Fazendo isso, esperamos ver se o item realmente está expirado ou não. Vamos executar o nosso código. Executando, temos o nosso resultado. No item 2, ele indica que não está expirado, então estáExpirado é falso. No pedido, que estava imprimindo as informações, o status é válido. Esse status estava utilizando também o método estáExpirado, então podemos ver que as nossas interfaces estão compilando corretamente.

**Conclusão sobre o Uso de Interfaces**  
Assim, conseguimos representar esses comportamentos em comum sem necessariamente trabalhar com herança. É muito importante entender o conceito de interface, pois ele é bastante aplicado no dia a dia. Na sequência, trabalharemos com outro conceito também importante, que é o uso de composições.

### Aula 2 -  - Vídeo 3
### Aula 2 -  - Vídeo 4
