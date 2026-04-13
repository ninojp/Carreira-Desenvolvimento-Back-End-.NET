# Curso Alura - Praticando C#: orientação a objetos com encapsulamento

## Aula 1 - Encapsulamento e Modificadores de acesso

### Aula 1 - Apresentação - Vídeo 1

Transcrição  
Olá, meu nome é Yasmin Araújo, sou instrutora na Escola de Programação e, para fins de acessibilidade, vou me autodescrever.

Audiodescrição: Yasmin é uma mulher branca com cabelo castanho escuro, de comprimento médio, aproximadamente na altura dos ombros. Seu cabelo está repartido ao meio e ela está usando uma blusa rosa choque. No ambiente ao fundo, há uma parede iluminada com luz azul.

**Objetivos do Curso**  
Neste curso, nós vamos trabalhar com encapsulamento, que é um dos principais pilares da Programação Orientada a Objetos (P.O.).

**Conteúdo do Curso**  
Vamos explorar diversos tópicos diferentes. O primeiro deles é a importância do encapsulamento. Vamos entender onde é necessário utilizar o encapsulamento e por que ele é importante. Também aprenderemos como usar os modificadores de acesso.

Além disso, veremos quais são os métodos construtores, como eles funcionam, os getters e setters, e também o uso de propriedades. Todos esses tópicos atuarão em conjunto para garantir o encapsulamento das classes. Este é um tópico essencial para praticarmos.

Encerramento  
Iniciaremos essa prática logo na sequência. Até lá!

### Aula 1 - O que esperar deste curso?

Antes de mergulharmos no código, que tal alinharmos as expectativas?

**O que significa um curso prático?**  
Já se pegou pensando — será que consigo aplicar o que aprendi na prática? Este curso é a sua resposta. Aqui, o foco é colocar a mão no código, resolver problemas e testar seu conhecimento de forma ativa. Você terá:

- Vídeo de revisão do conteúdo
- Material de apoio
- Desafios de

**Pré requisitos**  
É importante ter concluído o [curso C#: criando sua primeira aplicação](https://cursos.alura.com.br/course/csharp-criando-primeira-aplicacao), pois ele cobre os fundamentos da linguagem, garantindo que você consiga realizar os exercícios deste curso com mais segurança.

**Dicas para potencializar seu aprendizado neste curso**  

- Assista ao vídeo de revisão com atenção. Pause, anote e revise sempre que necessário.
- Baixe o material complementar para ter um apoio nas atividades.
- Faça os desafios na sua IDE favorita.
- Compartilhe o que aprendeu no fórum, pois sua abordagem pode inspirar outras pessoas.

Vamos começar?

### Aula 1 - Preparando o ambiente: instalando o Visual Studio

Olá!  
O IDE do Visual Studio é uma plataforma de lançamento criativa que você pode usar para editar, depurar e criar código e, em seguida, publicar um aplicativo. Além do editor e depurador padrão fornecidos pela maioria dos IDEs, o Visual Studio inclui compiladores, ferramentas de conclusão de código, designers gráficos e muitos outros recursos para aprimorar o processo de desenvolvimento de software. O IDE mais abrangente para desenvolvedores .NET no Windows e Mac para criação de web, nuvem, desktop, aplicativos móveis, serviços e jogos.

Sabendo disso, preparamos alguns vídeos para instalar em diferentes sistemas operacionais. Para este curso em específico, marque a opção Desenvolvimento para Desktop com .NET. no processo de instalação.

videos internos, sem link externo

- Visual Studio no Windows
- Visual Studio no Mac
- C# no VSCODE (SDK)

C# em distribuições Linux  
[Neste link](https://learn.microsoft.com/pt-br/dotnet/core/install/linux), você encontra um passo a passo da própria Microsoft de como instalar em distribuições Linux, como Alpine, CentOS, Debian, entre outras.

Vamos começar?

### Aula 1 - Preparando o ambiente: material de apoio

Após revisar os conceitos de encapsulamento em C#, é hora de colocar o conhecimento em prática com uma série de atividades focadas no tema. Caso queira acessar os slides da revisão, eles estão disponíveis no link abaixo:

[Baixe os slides do curso](https://cdn3.gnarususercontent.com.br/4702-praticando-csharp/Praticando%20C%23%20_orienta%C3%A7%C3%A3o%20a%20objetos%20com%20encapsulamento.pdf)

**Top-level statements**  

A partir da versão 9.0 do C#, não é mais necessário escrever using System; ou criar uma classe Program com o método Main. Isso acontece graças ao recurso chamado top-level statements (ou instruções de nível superior), que permite eliminar a estrutura tradicional usada como ponto de entrada do programa. Antes, um aplicativo de console típico era escrito assim:

using System;

```csharp
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

### Aula 1 - Encapsulamento - Vídeo 2

Transcrição  
Para discutirmos sobre encapsulamento, vamos relembrar nosso exemplo da classe Produto. Tínhamos um tipo referenciado construído, que era a classe Produto, com vários atributos e métodos. Vamos pensar agora no contexto de um e-commerce, onde há um vendedor tentando vender um produto com determinado desconto para o cliente. Como esse vendedor pode usar nossa classe para realizar essa tarefa?

**Utilização do Método AlterarPrecoComDesconto**  
Ele pode fazer isso utilizando o que está na linha 15, que é chamando o método AlterarPrecoComDesconto. Vamos ver como isso é feito no código:

```csharp
item1.AlterarPrecoComDesconto(0.2m);
```

Acesso Direto ao Atributo preco
No entanto, ele também pode alterar diretamente o atributo preco. Por exemplo, podemos fazer item1.preco ser igual a item1.preco vezes 1 menos 0,2, que é exatamente a implementação do método. Mas será que essa é a melhor prática? Será que o vendedor realmente deveria acessar o preço diretamente na nossa classe?

```csharp
item1.preco = item1.preco * (1 - 0.2m);
```

**Problemas com o Acesso Direto**  
Não é o ideal. Por quê? Imagine que o vendedor se confundiu ao fazer o cálculo para alterar o preço e, por algum motivo, multiplicou o preço por 0,2 ao invés de fazer a subtração completa. Nesse caso, ao invés de dar 20% de desconto, ele estaria dando 80% de desconto para o cliente.

```csharp
item1.preco = item1.preco * (0.2m);
```

O cliente fica satisfeito, obviamente, mas quem está na empresa pode acabar tendo um prejuízo. Não é isso que desejamos. Para evitar esses tipos de engano, o que podemos fazer? Podemos ocultar as informações que contêm dados sensíveis em nossa classe. O ideal é que quem utiliza nossa classe veja apenas as operações que ela pode realizar. As alterações dos dados serão feitas somente por nós, que estamos desenvolvendo a classe.

**Conceito de Encapsulamento**  
Nesse caso específico, o nome, a descrição, o preço e o estoque ficam ocultos, e quem utiliza a classe só consegue visualizar os métodos. A implementação desses métodos será algo que apenas nós, que desenvolvemos, conseguiremos visualizar. Dessa forma, garantimos o chamado encapsulamento, que é um pilar da orientação a objetos que assegura que as informações estejam protegidas.

A lei geral do encapsulamento é a seguinte: teremos os atributos dentro de uma classe, e esses atributos estarão ocultos. Quem está fora da classe não consegue visualizar esses atributos; conseguimos visualizar apenas os métodos. Assim, os métodos ocultam, encapsulam esses atributos.

**Implementação do Encapsulamento com Modificadores de Acesso**  
Como implementamos isso em nosso código? Como colocamos esse encapsulamento em prática? Através de modificadores de acesso. Na sequência, vamos conhecer melhor quais são esses modificadores de acesso e como utilizá-los.

**Exemplo de Implementação da Classe Produto**  
Para ilustrar, aqui está a implementação da classe Produto com seus atributos e métodos:

```csharp
class Produto
{
    public string nome;
    public string descricao;
    public decimal preco;
    public int estoque;

    public bool EstaDisponivel()
    {
        return estoque > 0;
    }

    public void AlterarPrecoComDesconto(decimal desconto)
    {
        preco = preco * (1 - desconto);
    }
}
```

Neste exemplo, os atributos nome, descricao, preco e estoque são públicos, mas para garantir o encapsulamento, poderíamos torná-los privados e fornecer métodos públicos para acessá-los e modificá-los de forma controlada.

### Aula 1 - Modificadores de acesso - Vídeo 3

Transcrição  
Para entender o conceito de encapsulamento em C#, começamos definindo uma regra geral: os atributos devem ser privados e os métodos devem ser públicos. Isso ocorre porque os atributos são encapsulados pelos métodos, que são responsáveis por alterá-los. Para aplicar essa regra, utilizamos modificadores de acesso.

**Modificadores de Acesso**  
Um modificador de acesso é uma palavra-chave que define a visibilidade dos atributos e métodos. No Visual Studio, frequentemente usamos public. O public indica que o atributo ou método pode ser acessado de qualquer outra classe. Por exemplo, se o atributo nome é public, ele pode ser acessado em qualquer outra classe. Vamos ver isso em prática:

```csharp
class Produto
{
    public string nome;
    public string descricao;
    public decimal preco;
    public int estoque;
    public bool EstaDisponivel()
    {
        return estoque > 0;
    }
    public void AlterarPrecoComDesconto(decimal desconto)
    {
        preco = preco * (1 - desconto/100);
    }
}
```

**Atributos Privados e Encapsulamento**  
Agora, vamos entender o que acontece quando removemos o modificador public de um atributo. No C#, quando não utilizamos nenhum modificador de acesso, o atributo ou método é considerado privado por padrão. Para tornar isso explícito, podemos definir os atributos como private:

```csharp
class Produto
{
    private string nome;
    private string descricao;
    private decimal preco;
    public int estoque;

    public bool EstaDisponivel()
    {
        return estoque > 0;
    }

    public void AlterarPrecoComDesconto(decimal desconto)
    {
        preco = preco * (1 - desconto/100);
    }
}
```

Com os atributos nome, descricao e preco definidos como private, eles não podem ser acessados diretamente fora da classe Produto. Isso é o que chamamos de encapsulamento.

**Modificadores de Acesso em Classes**  
Além dos atributos, podemos aplicar modificadores de acesso nas classes. Uma classe pode ser pública ou interna. O padrão de uma classe é ter um modificador internal, o que significa que ela é visível apenas dentro do projeto em que foi criada. Vamos ver como isso funciona:

```csharp
internal class Produto
{
    private string nome;
    private string descricao;
    private decimal preco;
    private int estoque;
    public bool EstaDisponivel()
    {
        return estoque > 0;
    }
    public void AlterarPrecoComDesconto(decimal desconto)
    {
        preco = preco * (1 - desconto/100);
    }
}
```

Se tentarmos acessar a classe Produto de outro projeto, encontraremos um erro, pois ela é interna. Para tornar a classe acessível de outros projetos, precisamos torná-la pública:

```csharp
public class Produto
{
    private string nome;
    private string descricao;
    private decimal preco;
    private int estoque;
    public bool EstaDisponivel()
    {
        return estoque > 0;
    }

    public void AlterarPrecoComDesconto(decimal desconto)
    {
        preco = preco * (1 - desconto/100);
    }
}
```

**Modificadores de Acesso em Métodos**  
Por fim, podemos usar o modificador internal para métodos também. Isso permite que o método seja acessível apenas dentro do mesmo projeto:

```csharp
public class Produto
{
    private string nome;
    private string descricao;
    private decimal preco;
    private int estoque;

    internal bool EstaDisponivel()
    {
        return estoque > 0;
    }

    public void AlterarPrecoComDesconto(decimal desconto)
    {
        preco = preco * (1 - desconto/100);
    }
}
```

Neste caso, o método EstaDisponivel é interno e só pode ser chamado dentro do mesmo projeto.

**Escolha dos Modificadores de Acesso**  
Dessa forma, temos três modificadores de acesso diferentes para usar em C#: private, internal e public. É importante escolher o melhor modificador de acesso para cada elemento que estamos definindo, garantindo a segurança e a integridade do nosso código.

### Aula 1 - Construtores - Vídeo 4

Transcrição  
Conseguimos aplicar o encapsulamento na nossa classe de produto. No entanto, ao verificarmos o arquivo program.cs, observamos vários erros. Isso ocorre porque os atributos nome, descrição, preço e estoque estão privados. Tentamos acessar esses atributos para preencher os dados, mas encontramos um problema: estamos escondendo os atributos de tal forma que é impossível inicializá-los. Não conseguimos nem mesmo definir os valores iniciais do produto, pois os atributos estão privados.

**Solução com Método CriarProduto**  
Para resolver isso, criamos um método responsável por inicializar esses atributos. Já criamos esse método e o deixamos copiado para colar aqui. A ideia desse método, chamado CriarProduto, é receber quatro parâmetros, cada um associado a um dos atributos da classe: nome, descrição, preço e estoque. Utilizamos this.nome para receber nome, this.descrição para receber descrição, e assim por diante. O uso do this refere-se aos atributos dentro da própria classe, enquanto o que vem após o sinal de igual refere-se ao parâmetro passado no método. Note a diferença de cores: o nome após o igual está azul, igual ao parâmetro, e o nome antes do igual, junto com o this, está branco, igual aos atributos. Utilizamos o this para fazer essa diferenciação.

Aqui está o método CriarProduto que criamos:

```csharp
public void CriarProduto(string nome, string descricao, decimal preco, int estoque)
{
    this.nome = nome;
    this.descricao = descricao;
    this.preco = preco;
    this.estoque = estoque;
}
```

**Problemas com o Método CriarProduto**  
Com o método CriarProduto, conseguimos chamá-lo na classe Program.cs. Criamos um produto com new Produto e chamamos o método CriarProduto, passando todos os dados necessários. Atribuímos os valores ao nosso item 1 dessa forma:

```csharp
item1.CriarProduto("Teclado", "Modelo compacto e silencioso, " +
                   " perfeito para produtividade diária.", 80.00m, 15);
```

No entanto, nada impede que copiemos e colemos o método, chamando-o novamente com um valor diferente, como 20, por exemplo. Assim, temos um método público e um atributo privado, mas com um falso encapsulamento, pois é possível chamar o método CriarProduto repetidamente e alterar todos os valores da classe. O ideal seria inicializar esses valores e não alterá-los, a menos que fosse realmente necessário, como no caso de alterar o preço com desconto. Queremos inicializar com certos valores e não chamar mais o método CriarProduto, bloqueando essa parte.

**Implementação do Método Construtor**  
Para isso, utilizamos uma estrutura padrão da própria classe: o método construtor. O método construtor é especial e é chamado no momento em que criamos um objeto na memória. Quando fazemos new Produto na linha 1, estamos chamando um construtor, que é o construtor padrão da classe. É como se na classe houvesse um construtor declarado como public Produto() { }.

Estamos criando um objeto na memória sem nenhum parâmetro, apenas reservando espaço. Este é o nosso construtor padrão. No entanto, desejamos inicializar o produto com valores específicos, utilizando parâmetros. Podemos pegar esses parâmetros usados no método CriarProduto, copiá-los e incorporá-los no nosso próprio construtor, em vez de utilizá-los em um método separado. Assim, utilizamos a estrutura da linguagem para criar o objeto e atribuir os valores iniciais sem alterá-los posteriormente.

Vamos remover o método CriarProduto e manter apenas o construtor. Note que estamos usando this para diferenciar os atributos. Após salvar a classe Produto, o uso de new Produto gera um erro, pois ao escrever um novo construtor, o construtor padrão deixa de existir. Teremos apenas o construtor com parâmetros. Vamos recortar os métodos do CriarProduto e, dessa forma, conseguimos construir um produto passando os valores desejados.

Aqui está o novo construtor que substitui o método CriarProduto:

```csharp
public Produto(string nome, string descricao, decimal preco, int estoque)
{
    this.nome = nome;
    this.descricao = descricao;
    this.preco = preco;
    this.estoque = estoque;
}
```

**Verificação e Ajustes Finais**  
Para verificar se tudo está funcionando corretamente, comentaremos o Console.WriteLine e observaremos que o método alterarPrecoComDesconto funciona normalmente. Vamos também remover a linha 13. Assim, temos uma classe correta, onde criamos um produto, inicializamos os valores no início e alteramos o preço quando necessário. Modificamos os dados utilizando métodos, evitando expor informações de forma inadequada.

Para visualizar melhor o funcionamento do construtor com valores padrão, analisemos o slide. A ideia é que, ao usar a instrução new Produto padrão, primeiro reservamos espaço na memória para depois preenchê-lo. No passo 1, tudo está vazio, e no passo 2, os espaços são preenchidos. Contudo, os dados não estavam bem protegidos. Para protegê-los, usamos new Produto com todos os dados de uma vez, construindo o objeto já inicializado. O construtor auxilia no encapsulamento, pois os atributos estão ocultos e encapsulados no momento da inicialização.

**Flexibilidade do Construtor**  
Um ponto interessante sobre o construtor é que, embora estejamos criando um que utiliza todos os parâmetros, não é necessário fazer isso. Podemos, por exemplo, inicializar o atributo estoque sempre como zero, sem passá-lo como parâmetro. Assim, podemos passar quantos parâmetros forem necessários e preencher ou não os atributos desejados. Se não passarmos o valor 15 para o estoque, precisaremos criar um método para alterá-lo, garantindo o encapsulamento.

Aqui está como podemos criar um produto com o novo construtor:

```csharp
Produto item1 = new Produto("Teclado", "Modelo compacto e silencioso, " +
                   " perfeito para produtividade diária.", 80.00m, 15);
```

E se decidirmos não passar o estoque como parâmetro, podemos definir um valor padrão no construtor:

```csharp
public Produto(string nome, string descricao, decimal preco)
{
    this.nome = nome;
    this.descricao = descricao;
    this.preco = preco;
    this.estoque = 0;
}
```

Dessa forma, garantimos que o encapsulamento seja mantido, inicializando os valores necessários e protegendo os dados da classe.

## Aula 2 - Getters, Setters e Propriedades

### Aula 2 - Getters e Setters - Vídeo 1

Transcrição  
Nós já conseguimos começar a desenvolver o encapsulamento da nossa classe. Por isso, nossos atributos estão privados, os métodos estão públicos, e temos um método especial, que é o construtor, responsável por criar o objeto e inicializá-lo com determinados valores. No entanto, ainda enfrentamos alguns problemas em nossa classe.

**Problemas de Acesso a Atributos Privados**  
Se voltarmos ao nosso program.cs e apagarmos o que está comentado, como o Console.WriteLine, podemos verificar que existem alguns erros de compilação. Esses erros ocorrem porque nossos atributos estão privados. Por exemplo, ao tentar acessar o nome do item1, ele está privado, o que gera um erro indicando que o atributo não é acessível. Esse mesmo erro ocorre para cada um dos atributos.

Para ilustrar, o código que tenta acessar diretamente os atributos privados seria algo como:

```csharp
Console.WriteLine(@$"Dados do item 1:
            Nome: {item1.nome};
            Descrição: {item1.descricao};
            Preço: {item1.preco};
            Estoque: {item1.estoque};
            ");
```

**Solução: Métodos para Leitura de Atributos**  
Como resolvemos essa situação? Observamos que queremos apenas obter o valor do nome sem realizar alterações. Portanto, estamos apenas lendo dados, não alterando. Podemos criar um método específico para ler esses valores dos dados. Dessa forma, não comprometemos o encapsulamento, pois criamos um método que apenas lê, sem alterar dados sensíveis.

Vamos criar um método que leia o valor do nome, por exemplo. Após o método alterarPrecoComDesconto, declararemos um public string ObterNome. Assim, retornaremos o valor do atributo nome.

Primeiro, declaramos o método:

```csharp
public string ObterNome()
```

Em seguida, implementamos o método para retornar o nome:

```csharp
public string ObterNome()
{
    return nome;
}
```

Com isso, ao voltarmos para a nossa classe Program.cs, podemos ler o valor do nome utilizando item1.ObterNome. Dessa forma, não enfrentamos mais problemas para ler nossos atributos. O código atualizado para exibir os dados do item seria:

```csharp
Console.WriteLine(@$"Dados do item 1:
            Nome: {item1.ObterNome()};
            Descrição: {item1.descricao};
            Preço: {item1.preco};
            Estoque: {item1.estoque};
            ");
```

Poderíamos criar métodos para cada um dos atributos para ler esses valores, mas ainda não faremos isso por enquanto.

**Adicionando e Alterando Imagens**  
Vamos considerar outra situação agora. Temos a nossa classe Produto, e é comum em sites de e-commerce que os produtos tenham imagens para representá-los. Para adicionar uma imagem, declararemos um private string imagem. Essa string será o link de uma imagem que aparecerá no nosso site.

```csharp
private string imagem;
```

Após adicionar a imagem como um atributo, podemos declará-la também no construtor. Assim, toda vez que criarmos um novo produto, também adicionaremos uma imagem.

```csharp
public Produto(string nome, string descricao, 
        decimal preco, string imagem)
```

Dentro do construtor, atribuiremos o valor da imagem ao atributo correspondente:

```csharp
this.imagem = imagem;
```

Agora, vamos pensar em uma nova situação: cadastramos o produto com uma determinada imagem, mas, por algum motivo, queremos trocá-la ou atualizá-la. Para isso, precisamos alterar nossos dados. Como fazemos isso novamente? Utilizando um método. Vamos criar, então, na nossa classe Produto, um método responsável por alterar a imagem.

Primeiro, declaramos o método:

```csharp
public void AlterarImagem(string imagem)
{

}
```

Para conseguirmos alterar uma imagem, precisamos de algumas validações. Para representar uma validação de um link da imagem, colocaremos um if para verificar se a imagem está vazia ou não.

```csharp
if(imagem.Length > 0)
```

E então, implementamos a lógica completa para alterar a imagem:

```csharp
if(imagem.Length > 0)
{
    this.imagem = imagem;
}
```

**Diferença entre Alteração de Dados e Regras de Negócio**  
Note que estamos alterando um atributo, mas realizamos algumas verificações antes de fazer a alteração. Essas verificações garantem o encapsulamento. Se tivéssemos deixado a imagem pública, correríamos o risco de alguém alterá-la para um link vazio ou inválido, o que poderia causar problemas no site. Ao criar métodos que possam alterar nossos dados, garantimos o encapsulamento.

Há um ponto importante sobre essa alteração: alterar a imagem é diferente de alterar o preço com desconto. Por quê? Alterar a imagem simplesmente modifica o dado. A string fornecida como parâmetro é alterada após a verificação. No caso de alterar o preço com desconto, trata-se de uma operação que representa uma regra de negócio, que é aplicar o preço com desconto.

**Métodos Getters e Setters**  
Temos dois tipos de operações comuns ao trabalhar com dados e programação orientada a objetos: o acesso a dados e a alteração de dados. Como são operações frequentes, a programação orientada a objetos já define alguns métodos para elas. Vamos conferir quais são esses métodos.

Teremos os acessos a dados, representados por métodos getters. Todo método getter começa com o prefixo get. Também teremos a alteração de dados, representada por métodos setters. Todo método setter começa com o prefixo set. Isso é importante porque define padronizações. Por exemplo, se quisermos que um método de acesso na classe seja chamado de obterNome, podemos nomeá-lo como getNome.

```csharp
public string GetNome()
{
    return nome;
}
```

Se quisermos que alterarImagem seja um método setter, usaremos setImagem.

```csharp
public void SetImagem(string imagem)
{
    if(imagem.Length > 0)
    {
        this.imagem = imagem;
    }
}
```

Lembre-se de que, ao alterar o preço com desconto, não utilizaremos setImagem, pois estamos nos referindo a regras de negócio. As regras de negócio são diferentes dos getters e setters.

**Encapsulamento e Padrões de Acesso**  
No final, sobre o encapsulamento, temos nossos atributos, que devem ser encapsulados. Ao usar getters e setters, continuamos encapsulando nossos dados. O getter representa o encapsulamento nas operações de acesso, e o setter representa o encapsulamento nas operações de alteração.

No C#, há um recurso interessante que nos ajuda a trabalhar com esses métodos getters e setters. Na sequência, vamos conferir melhor qual é esse recurso.

### Aula 2 -  Propriedades - Vídeo 2

Transcrição  
Nós conhecemos os métodos getters e setters e, anteriormente, já definimos os métodos getNome e setImagem. Para adiantar nosso trabalho, criamos um novo método, o getImagem. Na classe Program.cs, podemos ver esses métodos sendo utilizados. Utilizamos um Console.WriteLine para imprimir o valor atual da imagem, usando o getImagem. Em seguida, alteramos a imagem com o setImagem e, novamente, pegamos o valor para verificar se a mudança foi feita.

```csharp
public string GetImagem()
{
    return imagem;
}

Console.WriteLine($"Imagem: {item1.GetImagem()}");
item1.SetImagem("Nova Imagem");
Console.WriteLine($"Imagem: {item1.GetImagem()}");
```

Ao executar a classe, podemos ver que, inicialmente, foi impressa a imagem definida no construtor. Depois, a imagem foi alterada para a nova imagem, conforme a modificação realizada. Dessa forma, nossos métodos estão funcionando corretamente.

**Problemas com Getters e Setters e Introdução às Propriedades**  
No entanto, ao observar a classe Program.cs, notamos uma confusão com os métodos get e set. Temos três métodos sendo chamados para uma única operação. Se precisássemos obter e alterar dados constantemente, isso resultaria em uma confusão de get e set no código, tornando-o ilegível. Para melhorar isso, o C# fornece um recurso chamado propriedades. Com elas, não precisamos escrever get e set o tempo todo, tornando o código mais legível.

**Criando Propriedades na Classe Produto**  
Para criar uma propriedade dentro de uma classe, vamos ao arquivo produto.cs. Após o setImagem, declaramos uma propriedade public string Imagem com "I" maiúsculo. A sintaxe padrão de uma propriedade é pública e do mesmo tipo do atributo ao qual se refere. Neste caso, como estamos nos referindo à imagem, que é uma string, a propriedade Imagem também será uma string. Abrimos e fechamos chaves e, dentro delas, definimos como queremos os get e set.

```csharp
public string Imagem { }
```

Utilizamos palavras-chave para isso. O get retorna os dados com um return imagem.

```csharp
public string Imagem
{
    get
    {
        return imagem;
    }
    set { }
}
```

No set, validamos o tamanho da imagem que queremos adicionar, copiando o if de cima. O set não possui parâmetros, então utilizamos a palavra-chave value para calcular o tamanho e, se estiver correto, atribuímos esse value.

```csharp
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

**Substituindo Métodos por Propriedades**  
Uma vez que declaramos o get e o set, já definimos como a imagem será acessada, eliminando a necessidade de métodos específicos para getters e setters. No program.cs, substituímos o getImagem por item1.Imagem com "I" maiúsculo, representando a propriedade. O compilador entende que queremos pegar um valor e chama o método get. Para o setImagem, fazemos item1.Imagem = novaImagem, onde novaImagem é o value que estamos tentando atribuir. O compilador verifica o tamanho do value e, se estiver correto, faz a atribuição.

```csharp
Console.WriteLine($"Imagem: {item1.Imagem}");
item1.Imagem = "Nova Imagem";
Console.WriteLine($"Imagem: {item1.Imagem}");
```

Se quisermos pegar esse valor novamente, chamamos a propriedade, que usará o método get. Ao executar o código, o resultado no console será o mesmo comportamento anterior. Estamos trabalhando com propriedades que implementamos, definindo a lógica para o get e o set. No entanto, existem casos em que não há lógica específica para tratar esses gets ou sets. Nesses casos, podemos utilizar as chamadas propriedades autoimplementadas.

**Propriedades Autoimplementadas**  
Dessa forma, vamos apenas declarar uma propriedade com o get e o set, se necessário. Uma vez que declaramos, podemos utilizar essa propriedade, em vez de precisar criar manualmente um método get e um método set. Como faremos isso? Alterando nossos atributos. Na classe atributo, no lugar de private string nome, por exemplo, podemos declarar public string Nome. Agora, não será mais um atributo, mas sim uma propriedade. Ao declarar essa propriedade, estamos criando um campo oculto que será acessado por um get e, se necessário, por um set. Podemos criar um get; e depois um set;.

```csharp
public string Nome { get; set; }
```

Quando usamos o get, estamos indicando que faremos um retorno padrão. Para acessar esse valor, simplesmente faremos um return nome. Já para o set, faremos uma alteração padrão, alterando o valor sem validação prévia. Poderíamos deixar assim, mas não faz sentido ter um set para o nome, pois antes não estávamos alterando esse nome em lugar algum. Portanto, podemos deixar o nome apenas como leitura, com apenas um get.

```csharp
public string Nome { get; }
```

**Aplicando Propriedades a Outros Atributos**  
Vamos aplicar o mesmo procedimento aos outros atributos. Copiaremos o get e colaremos nas linhas posteriores, renomeando os atributos para nome, descrição, preço e estoque. Eles estão privados, então os tornaremos públicos: public string Descrição, public decimal Preço, e public int Estoque. O ideal é que deixemos os campos, os atributos da classe, antes das propriedades, então os separaremos dessa forma.

```csharp
public string Descricao { get; }
public decimal Preco { get; }
public int Estoque { get; }
```

Já temos o atributo privado imagem e as propriedades autoimplementadas com esse get padrão. Ainda há alguns erros relacionados às alterações nos nomes que fizemos. Vamos corrigir rapidamente: des.Nome = nome, des.Descricao = descricao, des.Preco = preco, e des.Estoque = estoque. Renomearemos também o estoque e o preço para os nomes das propriedades.

private string imagem;

```csharp
public string Nome { get; };
public string Descricao { get; };
public decimal Preco { get; };
public int Estoque { get; };
```

**Ajustando o Acesso às Propriedades**  
Note que o preço ainda apresenta um erro de compilação. Isso ocorre porque estamos usando diretamente a propriedade, tentando alterá-la, mas ela só possui um get, sem set. Para alterá-la, precisamos declarar explicitamente um set. Ao voltar para o método alterarPreçoComDesconto, o erro desaparece. No entanto, se declararmos um set dessa forma, poderemos alterar o preço em outra classe, o que não desejamos. Queremos que a alteração do preço ocorra apenas no método alterarPreçoComDesconto. Assim, podemos declarar o set como private set. Dessa forma, conseguimos modificar os dados, mas a modificação fica restrita aos métodos dentro da classe.

```csharp
public decimal Preco { get; private set; }
```

**Removendo Métodos Redundantes e Utilizando Propriedades**  
Os métodos getNome, getImagem e setImagem podem ser removidos, pois já definimos tudo corretamente. Por fim, podemos substituir o atributo imagem pela própria propriedade Imagem. Ao utilizar o operador =, ele acionará o set da imagem e fará a validação desde a primeira atribuição, verificando se a string é vazia ou se o link é válido, por exemplo. Assim, garantimos que todas as atribuições sejam válidas.

```csharp
this.Imagem = imagem;
```

**Testando as Propriedades no Program.cs**  
Já utilizamos nossas propriedades, então vamos voltar ao Program.cs para utilizá-las. Vamos descomentar o Console.WriteLine e substituir obterNome por Nome, fazendo o mesmo para Descrição, Preço e Estoque. Vamos verificar se tudo está funcionando corretamente. Ao executar o código, os dados do item 1, como nome, descrição, preço, estoque e imagem, são obtidos corretamente. Assim, garantimos o encapsulamento com getters e setters, mantendo a legibilidade das propriedades.

```csharp
Nome: {item1.Nome};
Descricao: {item1.Descricao};
Preco: {item1.Preco};
Estoque: {item1.Estoque};
```

**Conclusão e Próximos Passos**  
Esses são tópicos importantes sobre encapsulamento que precisam ser praticados para internalizarmos. Na sequência, teremos exercícios para visualizar a aplicação prática desses conceitos. Vamos começar?

### Aula 2 - Faça como eu fiz, 1: controle de velocidade

Você está criando um sistema de monitoramento de veículos para uma empresa de transporte. A classe Veiculo precisa controlar a velocidade atual, mas a empresa quer garantir que ninguém consiga alterar diretamente esse valor, para evitar fraudes. O valor só pode ser alterado através de um método autorizado.

Crie uma classe chamada Veiculo que tenha:

- Uma propriedade pública Placa.
- Um campo privado velocidadeAtual.
- Um método público AtualizarVelocidade(double novaVelocidade) que atualize a velocidade.
- Uma propriedade pública de leitura (get) chamada VelocidadeAtual que retorne a velocidade atual.

Exemplo de entrada:

```csharp
Veiculo veiculo = new Veiculo("ABC-1234");
veiculo.AtualizarVelocidade(72.5);
```

Exemplo de saída:

```csharp
Veículo: ABC-1234
Velocidade atual: 72,5 km/h
```

Opinião do instrutor

O foco dessa atividade é mostrar por que encapsular certos dados — neste caso, a velocidade. Perceba que o campo velocidadeAtual foi declarado como private, ou seja, não pode ser acessado diretamente fora da classe. Isso garante que a alteração de um dado sensível (como velocidade) só aconteça de forma controlada, por meio de métodos.

O método AtualizarVelocidade é o único ponto onde esse valor pode ser modificado. E a propriedade VelocidadeAtual fornece acesso somente leitura, via get.

Esse é um caso clássico onde encapsulamento evita problemas de integridade de dados. Em sistemas reais, isso pode representar segurança, legalidade ou validação de regras de negócio.

Veja como podemos fazer:

```csharp
public class Veiculo
{
    public string Placa { get; set; }

    private double velocidadeAtual;

    public Veiculo(string placa)
    {
        Placa = placa;
    }

    public void AtualizarVelocidade(double novaVelocidade)
    {
        velocidadeAtual = novaVelocidade;
    }

    public double VelocidadeAtual
    {
        get { return velocidadeAtual; }
    }
}
Veiculo veiculo = new Veiculo("ABC-1234");
veiculo.AtualizarVelocidade(72.5);
Console.WriteLine("Veículo: " + veiculo.Placa);
Console.WriteLine("Velocidade atual: " + veiculo.VelocidadeAtual + " km/h");
```

Teste o código, pratique e compartilhe sua solução no fórum com as outras pessoas.

### Aula 2 - Faça como eu fiz, 2: validação de nota mínima

Você está desenvolvendo um sistema de avaliação para uma escola. Um professor só pode atribuir notas maiores ou iguais a 0 e menores ou iguais a 10. Nenhum outro ponto do sistema pode alterar a nota de um aluno diretamente.

Crie uma classe chamada Avaliacao com:

- Uma propriedade pública Aluno.
- Uma propriedade Nota, com get público e set privado.
- Um método público AtribuirNota(double nota) que só permita valores entre 0 e 10. Se o valor for inválido, exiba uma mensagem de erro.

Exemplo de entrada:

```csharp
Avaliacao avaliacao = new Avaliacao("Carla Silva");
avaliacao.AtribuirNota(11);   // inválido
avaliacao.AtribuirNota(8.5);  // válido
```

Exemplo de saída:

```csharp
Erro: A nota deve estar entre 0 e 10.
Aluno: Carla Silva
Nota atribuída: 8,5
```

Opinião do instrutor

Esse exercício mostra o uso estratégico de um set privado — ou seja, apenas a própria classe pode definir o valor da nota, e isso sempre passa por uma validação. Assim, evitamos que alguém, por acidente, insira uma nota fora do intervalo permitido.

Isso é um bom exemplo de como o encapsulamento ajuda a proteger a integridade dos dados. A propriedade Nota só pode ser alterada usando o método AtribuirNota(), onde colocamos a lógica de validação.

Para deixar mais claro o que está acontecendo dentro do método AtribuirNota, veja esse fluxograma com as decisões que o programa toma internamente:

Diagrama de fluxo que representa a validação de uma nota. O processo começa com o bloco "Receber valor da nota", seguido por um losango com a pergunta "Nota entre 0 e 10?". Se a resposta for "Sim", a próxima etapa é "Atribuir à propriedade Nota", e então "Fim". Se a resposta for "Não", o fluxo segue para "Exibir mensagem de erro", e depois também finaliza em "Fim". As setas indicam o caminho de decisão e execução. As bordas dos blocos são coloridas com um gradiente azul e vermelho.

Esse tipo de lógica é muito comum em sistemas que precisam garantir regras de negócio. Ao encapsular o set, você centraliza o controle da regra em um único lugar. Isso facilita a manutenção e protege seu código de alterações indesejadas.

Observe o código:

```csharp
public class Avaliacao
{
    public string Aluno { get; set; }

    public double Nota { get; private set; }

    public Avaliacao(string aluno)
    {
        Aluno = aluno;
    }

    public void AtribuirNota(double nota)
    {
        if (nota >= 0 && nota <= 10)
        {
            Nota = nota;
        }
        else
        {
            Console.WriteLine("Erro: A nota deve estar entre 0 e 10.");
        }
    }
}

Avaliacao avaliacao = new Avaliacao("Carla Silva");
avaliacao.AtribuirNota(11);
avaliacao.AtribuirNota(8.5);

Console.WriteLine("Aluno: " + avaliacao.Aluno);
Console.WriteLine("Nota atribuída: " + avaliacao.Nota);
```

Agora é sua vez! Experimente alterar os valores, simule notas inválidas e poste sua explicação no fórum para ajudar os colegas.

### Aula 2 - Faça como eu fiz, 3: controlando acesso

Você está desenvolvendo um sistema de acesso a dados médicos. Informações sensíveis, como um código de prontuário, não devem ser acessadas de fora da aplicação, mas ainda podem ser lidas por classes dentro do mesmo projeto.

Crie duas classes:

- Paciente (pública), com propriedades públicas Nome e Idade.
- HistoricoMedico (com modificador internal), contendo uma propriedade CodigoProntuario e um método ExibirCodigo() que imprime o código no console.
- No programa principal, crie um paciente e um histórico médico, e exiba os dados.

Exemplo de entrada:

```csharp
Paciente paciente = new Paciente("Luiz Costa", 42);
HistoricoMedico historico = new HistoricoMedico("XPT-9987");
historico.ExibirCodigo();
```

Exemplo de saída:

```csharp
Código do prontuário: XPT-9987
```

Opinião do instrutor

A classe HistoricoMedico foi declarada como internal, o que significa que ela só pode ser acessada dentro do mesmo projeto — nenhuma biblioteca externa pode usar essa classe.

Isso é muito útil para proteger dados sensíveis, como um código de prontuário médico, que só deve ser acessado por quem está “dentro da casa”.

O fluxo de acesso a esses dados pode ser representado assim:

Fluxograma com quatro caixas conectadas por setas verticais pretas. A primeira caixa diz "Código do prontuário é informado ao construtor". A segunda, "Armazenado na classe internal". A terceira, "Método ExibirCodigo imprime o valor". E a quarta, "Valor visível apenas dentro do projeto". As bordas das caixas têm um gradiente de azul para rosa.

Esse tipo de encapsulamento acontece não só no nível de campos e propriedades, mas também na estrutura do projeto. E quanto maior o sistema, mais importante isso se torna.

Observe a solução:

```csharp
public class Paciente
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public Paciente(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
}
internal class HistoricoMedico
{
    public string CodigoProntuario { get; set; }

    public HistoricoMedico(string codigo)
    {
        CodigoProntuario = codigo;
    }

    public void ExibirCodigo()
    {
        Console.WriteLine("Código do prontuário: " + CodigoProntuario);
    }
}
Paciente paciente = new Paciente("Luiz Costa", 42);
HistoricoMedico historico = new HistoricoMedico("XPT-9987");
historico.ExibirCodigo();
```

Agora é com você! Tente mudar a visibilidade da classe para public e veja como isso afeta o acesso. Compartilhe suas conclusões no fórum e veja o que os colegas estão descobrindo também.

### Aula 2 - Faça como eu fiz, 4: encapsulando reajuste de salário

Imagine que você está desenvolvendo um sistema de folha de pagamento. A classe Funcionario possui um salário que só pode ser aumentado via método, e o novo valor não pode ser menor que o atual. Você quer garantir que essa regra não seja burlada.

Crie uma classe Funcionario com:

- Uma propriedade pública Nome.
- Um campo privado salario.
- Um construtor que receba nome e salário inicial.
- Um método público ReajustarSalario(double novoValor) que apenas aceite valores maiores que o salário atual.
- Uma propriedade pública de leitura Salario (apenas get).

Exemplo de entrada:

```csharp
Funcionario f = new Funcionario("Fernanda Lima", 4000);
f.ReajustarSalario(3500); // Inválido
f.ReajustarSalario(4200); // Válido
```

Exemplo de saída:

```csharp
Erro: O novo salário deve ser maior que o atual.
Funcionário: Fernanda Lima
Salário atual: R$ 4200,00
```

Opinião do instrutor

Esse exercício mostra como o encapsulamento pode proteger regras de negócio. Aqui, o campo salario é private justamente para impedir alterações diretas de fora da classe — dessa forma, ninguém consegue reduzir o salário de um funcionário sem passar pela lógica definida.

O método ReajustarSalario é o único ponto autorizado a alterar o valor. Nele, colocamos a lógica de validação: só aceitamos novos valores se forem maiores que o salário atual. A propriedade Salario possui apenas um get, permitindo leitura externa com segurança.

Veja como essa proteção se encaixa no fluxo de decisão do sistema:

Fluxograma com cinco etapas e setas direcionais pretas. A primeira caixa retangular diz: "Usuário chama ReajustarSalário(valor)". A seguir, há um losango com a pergunta: "Valor > salário atual?". Dois caminhos saem do losango — à esquerda, com a palavra "Sim", leva a uma caixa que diz: "Atualiza campo salário"; à direita, com a palavra "Não", leva a "Exibe mensagem de erro". Ambos os caminhos convergem para a última caixa que diz: "Fim". As bordas das caixas têm gradiente azul e rosa.

Observe a resolução em código:

```csharp
public class Funcionario
{
    public string Nome { get; set; }
    private double salario;

    public Funcionario(string nome, double salarioInicial)
    {
        Nome = nome;
        salario = salarioInicial;
    }

    public void ReajustarSalario(double novoValor)
    {
        if (novoValor > salario)
        {
            salario = novoValor;
        }
        else
        {
            Console.WriteLine("Erro: O novo salário deve ser maior que o atual.");
        }
    }

    public double Salario
    {
        get { return salario; }
    }
}

Funcionario f = new Funcionario("Fernanda Lima", 4000);
f.ReajustarSalario(3500);
f.ReajustarSalario(4200);

Console.WriteLine("Funcionário: " + f.Nome);
Console.WriteLine("Salário atual: R$ " + f.Salario.ToString("F2"));
```

Teste variações e compartilhe sua solução com sua explicação no fórum.

### Aula 2 - Faça como eu fiz, 5: controle de tarefas

Você está desenvolvendo um sistema de gestão de projetos. Cada projeto possui uma lista de tarefas internas, que não pode ser acessada nem modificada diretamente de fora da classe. O sistema só permite adicionar tarefas, e precisa mostrar quantas já existem.

Crie uma classe Projeto com:

- Uma propriedade pública Nome.
- Uma lista privada de strings chamada tarefas.
- Um método público AdicionarTarefa(string tarefa) que insere uma nova tarefa.
- Um método público ExibirTarefas() que imprime todas as tarefas.
- Uma propriedade somente leitura QuantidadeTarefas, baseada no tamanho da lista.

Exemplo de entrada:

```csharp
Projeto projeto = new Projeto("Sistema de Inventário");
projeto.AdicionarTarefa("Criar tela de login");
projeto.AdicionarTarefa("Implementar banco de dados");
projeto.ExibirTarefas();
```

Exemplo de saída:

```csharp
Projeto: Sistema de Inventário
Tarefas:
- Criar tela de login
- Implementar banco de dados
Total: 2 tarefas
```

Opinião do instrutor

Aqui demos mais um passo no uso do encapsulamento para proteger estruturas de dados mais complexas, como coleções. A lista tarefas foi declarada como private para que nenhuma parte externa possa remover, alterar ou substituir tarefas diretamente.

A única forma de adicionar uma tarefa é por meio do método AdicionarTarefa(), que futuramente poderia ter regras, como impedir tarefas duplicadas ou vazias. Essa é uma prática extremamente comum em sistemas reais: proteger coleções internas e expor métodos controlados.

A leitura das tarefas também é controlada: em vez de retornar diretamente a lista, usamos o método ExibirTarefas(), que imprime internamente o conteúdo. Isso ajuda a evitar modificações externas não autorizadas.

E, para fechar, a propriedade QuantidadeTarefas permite acompanhar a evolução do projeto com segurança e sem risco de inconsistência.

Veja como podemos fazer:

```csharp
public class Projeto
{
    public string Nome { get; set; }
    private List<string> tarefas;

    public Projeto(string nome)
    {
        Nome = nome;
        tarefas = new List<string>();
    }

    public void AdicionarTarefa(string tarefa)
    {
        tarefas.Add(tarefa);
    }

    public void ExibirTarefas()
    {
        Console.WriteLine("Projeto: " + Nome);
        Console.WriteLine("Tarefas:");
        foreach (string tarefa in tarefas)
        {
            Console.WriteLine("- " + tarefa);
        }
        Console.WriteLine("Total: " + QuantidadeTarefas + " tarefas");
    }

    public int QuantidadeTarefas
    {
        get { return tarefas.Count; }
    }
}

Projeto projeto = new Projeto("Sistema de Inventário");
projeto.AdicionarTarefa("Criar tela de login");
projeto.AdicionarTarefa("Implementar banco de dados");
projeto.ExibirTarefas();
```

Agora é com você! Rode o código e compartilhe no fórum como você organizou o acesso.

### Aula 2 - Faça como eu fiz, 6: validação de saque

Imagine que você está desenvolvendo uma aplicação bancária e precisa encapsular o comportamento de um saque de dinheiro.

Por questões de segurança, a lógica de validação do saque não pode ficar dentro da própria conta, mas deve ser delegada a uma classe interna de segurança, responsável por validar os limites permitidos para a operação.

Crie:

Uma classe ContaBancaria, com:

- Propriedade pública Titular
- Campo privado saldo
- Construtor para definir o titular e saldo inicial
- Método público Sacar(double valor) que só realiza o saque se a classe interna de segurança permitir
- Propriedade Saldo (somente leitura)
- Uma classe SegurancaConta (com modificador internal), com:

Um método ValidarSaque(double valor) que apenas autoriza saques de até R$ 1000

Exemplo de entrada:

```csharp
ContaBancaria conta = new ContaBancaria("Carlos Silva", 2500);
conta.Sacar(1500); // inválido
conta.Sacar(800);  // válido
```

Exemplo de saída:

```csharp
Saque negado pela política de segurança.
Saque realizado com sucesso.
Saldo atual: R$ 1700,00
```

Opinião do instrutor

Nessa atividade, a gente começou a trabalhar com encapsulamento não só de dados, mas de comportamentos. Até agora, você aprendeu a proteger campos com private, limitar escrita com set privado, e até esconder listas inteiras dentro de um objeto.

Mas neste caso, o desafio é diferente: e se a regra de validação não for só um número que pode ou não ser aceito, mas uma lógica completa? É o que acontece com o saque de uma conta bancária. O valor não pode ser qualquer um — precisa ser validado por uma política de segurança, que pode mudar com o tempo ou com o perfil do cliente, por exemplo.

Por isso, criamos uma segunda classe chamada SegurancaConta, que tem a função exclusiva de dizer se o saque pode ser feito ou não. E essa classe foi marcada como internal, o que significa que apenas outras partes do mesmo sistema podem usá-la — bibliotecas externas, por exemplo, nem sabem que ela existe.

Dentro da classe ContaBancaria, deixamos o saldo como um campo private, e criamos o método Sacar, que só faz o saque se a classe de segurança permitir. Isso é importante porque a ContaBancaria não decide sozinha — ela depende da validação externa para proteger o dinheiro. Esse padrão é muito comum em aplicações que lidam com regras sensíveis, como bancos, hospitais e governos.

Outra coisa importante é a separação de responsabilidades. A conta cuida dos dados (titular, saldo, operações), e a segurança cuida das regras de validação. Isso deixa o código mais organizado, mais testável e mais seguro.

Veja como aplicamos isso no código:

```csharp
public class ContaBancaria
{
    public string Titular { get; set; }
    private double saldo;

    public ContaBancaria(string titular, double saldoInicial)
    {
        Titular = titular;
        saldo = saldoInicial;
    }

    public void Sacar(double valor)
    {
        SegurancaConta seguranca = new SegurancaConta();
        if (seguranca.ValidarSaque(valor))
        {
            saldo -= valor;
            Console.WriteLine("Saque realizado com sucesso.");
        }
        else
        {
            Console.WriteLine("Saque negado pela política de segurança.");
        }
    }

    public double Saldo
    {
        get { return saldo; }
    }
}

internal class SegurancaConta
{
    public bool ValidarSaque(double valor)
    {
        return valor <= 1000;
    }
}

ContaBancaria conta = new ContaBancaria("Carlos Silva", 2500);
conta.Sacar(1500);
conta.Sacar(800);
Console.WriteLine("Saldo atual: R$ " + conta.Saldo.ToString("F2"));
```

Agora é com você! Rode o código e poste sua solução no fórum explicando qual foi sua ideia e o que aprendeu com isso.

### Aula 2 - Faça como eu fiz, 7: agenda com controle de contatos duplicados

Você está desenvolvendo um sistema de agenda pessoal. Cada agenda pode conter vários contatos, mas você quer garantir que:

A lista de contatos não possa ser acessada nem modificada diretamente por fora da classe.
Nenhum contato com o mesmo nome seja adicionado duas vezes.
O sistema informe se o contato foi adicionado ou recusado, para que outras partes possam reagir.
Então para isso, crie:

- Uma classe Contato, com:
- Propriedades públicas Nome e Telefone.
- Uma classe Agenda, com:
- Propriedade pública Proprietario.
- Um campo privado e readonly contatos (do tipo List`<Contato>`).
- Um método público bool AdicionarContato(Contato contato), que verifica se o nome já existe.
- Um método ListarContatos(), que imprime os contatos.
- Uma propriedade pública somente leitura QuantidadeContatos.

Exemplo de entrada:

```csharp
Agenda agenda = new Agenda("Marina Souza");
agenda.AdicionarContato(new Contato("Carlos", "11998887777"));
agenda.AdicionarContato(new Contato("Carlos", "11991112222")); // duplicado
agenda.AdicionarContato(new Contato("Julia", "21988776655"));
agenda.ListarContatos();
```

Exemplo de saída:

```csharp
Contato com esse nome já está na agenda.
Agenda de: Marina Souza
Contatos:
- Carlos | 11998887777
- Julia  | 21988776655
Total de contatos: 2
```

Opinião do instrutor

Até aqui, trabalhamos com listas internas, propriedades derivadas e regras básicas de acesso. Agora, você começa a tratar regras de integridade, ou seja, proteger os dados de incoerências e repetições.

A lista contatos foi declarada como private readonly, o que significa que ninguém de fora pode acessá-la diretamente, nem mesmo substituir a lista inteira. Apenas a própria classe Agenda pode adicionar contatos, e isso acontece por meio do método AdicionarContato.

Mas repare que não é só adicionar — agora o método toma uma decisão: se o nome do contato já existe na lista, ele não permite duplicar. Esse tipo de lógica é essencial em sistemas reais. Imagine se uma agenda aceitasse dois "Carlos" diferentes — como o sistema saberia qual é qual?

E, o método AdicionarContato retorna um bool, que indica se a operação foi bem-sucedida. Esse retorno pode ser usado futuramente para mostrar alertas, registrar logs ou até salvar em banco de dados apenas os contatos válidos. É mais uma forma de encapsular a operação e permitir que o resto do sistema reaja com base no resultado da lógica interna.

Observe a solução abaixo:

```csharp
public class Contato
{
    public string Nome { get; set; }
    public string Telefone { get; set; }

    public Contato(string nome, string telefone)
    {
        Nome = nome;
        Telefone = telefone;
    }
}

public class Agenda
{
    public string Proprietario { get; set; }
    private readonly List<Contato> contatos;

    public Agenda(string proprietario)
    {
        Proprietario = proprietario;
        contatos = new List<Contato>();
    }

    public bool AdicionarContato(Contato contato)
    {
        if (contatos.Any(c => c.Nome == contato.Nome))
        {
            Console.WriteLine("Contato com esse nome já está na agenda.");
            return false;
        }

        contatos.Add(contato);
        return true;
    }

    public void ListarContatos()
    {
        Console.WriteLine("Agenda de: " + Proprietario);
        Console.WriteLine("Contatos:");
        foreach (var c in contatos)
        {
            Console.WriteLine("- " + c.Nome + " | " + c.Telefone);
        }
        Console.WriteLine("Total de contatos: " + QuantidadeContatos);
    }

    public int QuantidadeContatos
    {
        get { return contatos.Count; }
    }
}

Agenda agenda = new Agenda("Marina Souza");
agenda.AdicionarContato(new Contato("Carlos", "11998887777"));
agenda.AdicionarContato(new Contato("Carlos", "11991112222")); // duplicado
agenda.AdicionarContato(new Contato("Julia", "21988776655"));
agenda.ListarContatos();
```

Agora é com você! Teste o código, explore e compartilhe no fórum sua versão explicada para inspirar seus colegas no fórum.

### Aula 2 -  Faça como eu fiz, 8: determinando a situação de um estudante com base na média

Você está desenvolvendo um sistema de boletim escolar. Cada estudante possui duas notas, e a situação final (“Aprovado” ou “Reprovado”) não deve ser inserida manualmente. Em vez disso, a situação deve ser calculada automaticamente com base na média das duas notas.

Crie uma classe Estudante, com:

- Propriedade pública Nome
- Propriedades públicas Nota1 e Nota2, ambas com get e set
- Propriedade pública somente leitura Media
- Propriedade pública somente leitura Situacao, que retorna:
- "Aprovado" se a média for maior ou igual a 6
- "Reprovado" se for menor

Exemplo de entrada:

```csharp
Estudante estudante = new Estudante("Lucas Rocha");
estudante.Nota1 = 7.5;
estudante.Nota2 = 5.0;
```

Exemplo de saída:

```csharp
Estudante: Lucas Rocha
Média: 6,25
Situação: Aprovado
```

Opinião do instrutor

Nesta atividade, queremos usar os dados disponíveis para derivar informações automaticamente — e manter tudo sempre coerente.

A propriedade Situacao não pode ser alterada manualmente. Afinal, faz sentido uma pessoa com média 3 aparecer como “Aprovada”? Não. Por isso, usamos propriedades somente leitura (get sem set) com lógica interna, para garantir que a situação sempre corresponda à média real da pessoa estudante.

Já a propriedade Media também é calculada dinamicamente com base em Nota1 e Nota2. Isso garante que, se uma nota for alterada, a média e a situação se atualizem automaticamente, sem precisar recalcular em outro lugar.

Esse tipo de encapsulamento é muito útil quando você tem dados interdependentes: você expõe os dados-base (notas), mas protege as informações derivadas (média e situação) com regras claras dentro do próprio objeto.

Veja o código abaixo:

```csharp
public class Estudante
{
    public string Nome { get; set; }
    public double Nota1 { get; set; }
    public double Nota2 { get; set; }

    public Estudante(string nome)
    {
        Nome = nome;
    }

    public double Media
    {
        get { return (Nota1 + Nota2) / 2; }
    }

    public string Situacao
    {
        get
        {
            return Media >= 6.0 ? "Aprovado" : "Reprovado";
        }
    }
}

Estudante estudante = new Estudante("Lucas Rocha");
estudante.Nota1 = 7.5;
estudante.Nota2 = 5.0;

Console.WriteLine("Estudante: " + estudante.Nome);
Console.WriteLine("Média: " + estudante.Media.ToString("F2"));
Console.WriteLine("Situação: " + estudante.Situacao);
```

Teste com diferentes notas, veja como a lógica reage automaticamente, e poste sua versão no fórum explicando o que aprendeu sobre propriedades calculadas e lógica encapsulada.

### Aula 2 - Faça como eu fiz, 9: controle de matrícula

Você está desenvolvendo um sistema de controle de matrículas para uma escola. Nesse sistema, um estudante só pode ser matriculado se o curso ainda tiver vagas disponíveis. A regra é clara: se o número de estudantes já matriculados alcançar o limite, novas matrículas devem ser recusadas.

Você precisa modelar duas classes:

Classe Curso:

- Propriedade pública Nome
- Propriedade pública VagasTotais (definida no construtor)
- Campo privado matriculas (lista de estudantes)
- Método bool Matricular(Estudante estudante) que:
  - Adiciona o estudante se houver vaga
  - Exibe mensagem de erro e retorna false caso contrário
- Método ListarMatriculados(), que mostra todos os estudantes matriculados
- Propriedade somente leitura VagasDisponiveis

Classe Estudante:

Propriedade pública Nome (com construtor)

Exemplo de entrada:

```csharp
Curso curso = new Curso("Lógica de Programação", 2);
curso.Matricular(new Estudante("Rafaela"));
curso.Matricular(new Estudante("João"));
curso.Matricular(new Estudante("Mirela")); // excede o limite
curso.ListarMatriculados();
```

Exemplo de saída:

```csharp
Estudante matriculado com sucesso.
Estudante matriculado com sucesso.
Erro: Não há vagas disponíveis para este curso.

Estudantes matriculados em Lógica de Programação:
- Rafaela
- João
Vagas disponíveis: 0
```

Opinião do instrutor

Essa atividade traz um ponto-chave da programação orientada a objetos: um objeto precisa saber como reagir quando outro objeto tenta interagir com ele. Aqui, o curso precisa decidir se aceita ou não um novo estudante com base no seu estado interno — mais especificamente, na quantidade de vagas.

O campo matriculas é uma lista private, pois ninguém fora da classe Curso deve conseguir manipular os estudantes diretamente. O único caminho para adicionar uma matrícula é através do método Matricular, que implementa a lógica de verificação de vagas.

Esse método retorna bool, o que permite saber se a matrícula foi bem-sucedida. Isso é ótimo para tomada de decisão no restante do sistema, e ainda ajuda a manter o controle sobre as regras de negócio.

Outro detalhe importante é a propriedade VagasDisponiveis, que é calculada automaticamente com base no total de vagas e na quantidade de estudantes já matriculados. Isso garante que o valor esteja sempre correto, sem precisar ser atualizado manualmente.

Veja a implementação completa no código abaixo:

```csharp
public class Estudante
{
    public string Nome { get; set; }

    public Estudante(string nome)
    {
        Nome = nome;
    }
}

public class Curso
{
    public string Nome { get; set; }
    public int VagasTotais { get; set; }

    private List<Estudante> matriculas;

    public Curso(string nome, int vagasTotais)
    {
        Nome = nome;
        VagasTotais = vagasTotais;
        matriculas = new List<Estudante>();
    }

    public bool Matricular(Estudante estudante)
    {
        if (matriculas.Count >= VagasTotais)
        {
            Console.WriteLine("Erro: Não há vagas disponíveis para este curso.");
            return false;
        }

        matriculas.Add(estudante);
        Console.WriteLine("Estudante matriculado com sucesso.");
        return true;
    }

    public void ListarMatriculados()
    {
        Console.WriteLine($"Estudantes matriculados em {Nome}:");
        foreach (var estudante in matriculas)
        {
            Console.WriteLine("- " + estudante.Nome);
        }
        Console.WriteLine("Vagas disponíveis: " + VagasDisponiveis);
    }

    public int VagasDisponiveis
    {
        get { return VagasTotais - matriculas.Count; }
    }
}

Curso curso = new Curso("Lógica de Programação", 2);
curso.Matricular(new Estudante("Rafaela"));
curso.Matricular(new Estudante("João"));
curso.Matricular(new Estudante("Mirela"));
curso.ListarMatriculados();
```

Agora é com você! Experimente testar com diferentes limites de vagas, valide a lógica, e compartilhe sua versão explicada no fórum para ajudar outras pessoas a entender como usar encapsulamento com objetos que se relacionam.

### Aula 2 - Faça como eu fiz, 10: sistema de reservas em hotel

Imagine que você está desenvolvendo um sistema para um hotel que deseja organizar suas reservas. Ao realizar uma reserva, é necessário associar um hóspede a um quarto, registrar a quantidade de diárias e calcular automaticamente o valor total da estadia. Mas, é importante garantir que:

- A quantidade de diárias seja obrigatoriamente maior que zero;
- O valor da diária do quarto não seja negativo nem nulo;
- O sistema não permita alterações manuais no valor total da reserva.

Você deve garantir essas regras usando encapsulamento adequado, protegendo os dados e centralizando a lógica de verificação e cálculo dentro das próprias classes.

Crie:

Classe Hospede:

Propriedade pública Nome, definida no construtor

Classe Quarto:

Propriedade pública Numero

Propriedade ValorDiaria, com get e set, validando que o valor seja positivo

Classe Reserva:

- Campo privado diarias
- Propriedade somente leitura Hospede (objeto)
- Propriedade somente leitura Quarto (objeto)
- Propriedade somente leitura ValorTotal (calculada)
- Construtor que receba Hospede, Quarto e diarias, e valide se as diárias são maiores que zero

Exemplo de entrada:

```csharp
Hospede hospede = new Hospede("Juliana Moura");
Quarto quarto = new Quarto(101);
quarto.ValorDiaria = 250;

Reserva reserva = new Reserva(hospede, quarto, 3);
```

Exemplo de saída:

```csharp
Reserva para: Juliana Moura
Quarto: 101
Valor total: R$ 750,00
```

Opinião do instrutor

Nesta atividade, você vai praticar o uso do encapsulamento para garantir que os dados de uma reserva sejam sempre consistentes e que regras importantes sejam respeitadas automaticamente. Aqui, não basta apenas armazenar informações — é preciso controlar como elas são criadas, validadas e usadas.

Começamos pela classe Hospede, que guarda o nome da pessoa associada à reserva. Depois, temos a classe Quarto, onde aplicamos um set com validação no ValorDiaria. Isso é muito importante: não podemos permitir que um quarto tenha uma diária negativa ou igual a zero, pois isso comprometeria o cálculo final.

Na classe Reserva, colocamos a quantidade de diárias como um campo privado (diarias) e exigimos, no construtor, que esse valor seja maior que zero. Essa verificação é feita logo no início, usando um throw com ArgumentException caso a regra não seja cumprida. Isso impede que a reserva seja criada de forma inválida.

As propriedades Hospede, Quarto e ValorTotal são todas somente leitura — ou seja, não podem ser modificadas depois que a reserva foi criada. Isso traz segurança ao sistema, pois uma reserva confirmada não deve sofrer alterações estruturais de forma livre.

A propriedade ValorTotal aplica um dos conceitos mais importantes do encapsulamento: cálculo baseado no estado atual do objeto. Ela não depende de uma variável que precisa ser atualizada manualmente, mas sempre pega os valores reais de diarias e ValorDiaria, garantindo precisão e consistência no resultado.

Para ajudar a visualizar o que acontece quando uma reserva é criada, veja o fluxo de validação e cálculo dentro da classe:

Fluxograma representando a validação de uma reserva de hospedagem. O processo inicia com a entrada de dados: hóspede, quarto e número de diárias. Em seguida, há uma verificação se o número de diárias é maior que zero. Se não for, ocorre o erro 'reserva inválida'. Se for, verifica-se se o valor da diária é maior que zero. Caso não seja, o erro exibido é 'valor inválido'. Se o valor for válido, calcula-se o valor total da reserva (diária × diárias) e a reserva é confirmada com dados imutáveis.

Observe a implementação completa:

```csharp
public class Hospede
{
    public string Nome { get; set; }

    public Hospede(string nome)
    {
        Nome = nome;
    }
}

public class Quarto
{
    public int Numero { get; set; }
    private double valorDiaria;
    public double ValorDiaria
    {
        get { return valorDiaria; }
        set
        {
            if (value > 0)
                valorDiaria = value;
            else
                Console.WriteLine("Erro: O valor da diária deve ser maior que zero.");
        }
    }
    public Quarto(int numero)
    {
        Numero = numero;
    }
}

public class Reserva
{
    private int diarias;
    public Hospede Hospede { get; }
    public Quarto Quarto { get; }
    public Reserva(Hospede hospede, Quarto quarto, int diarias)
    {
        if (diarias <= 0)
        {
            throw new ArgumentException("O número de diárias deve ser maior que zero.");
        }
        Hospede = hospede;
        Quarto = quarto;
        this.diarias = diarias;
    }
    public double ValorTotal
    {
        get { return Quarto.ValorDiaria * diarias; }
    }
}
Hospede hospede = new Hospede("Juliana Moura");
Quarto quarto = new Quarto(101);
quarto.ValorDiaria = 250;

Reserva reserva = new Reserva(hospede, quarto, 3);

Console.WriteLine("Reserva para: " + reserva.Hospede.Nome);
Console.WriteLine("Quarto: " + reserva.Quarto.Numero);
Console.WriteLine("Valor total: R$ " + reserva.ValorTotal.ToString("F2"));
```

Agora é a sua vez. Experimente criar reservas com diferentes valores, testar diárias inválidas e alterar o valor da diária após a reserva. Depois, compartilhe sua versão no fórum com sua explicação sobre o que fez e o que aprendeu.

### Aula 2 - Para saber mais: encapsulamento versus acoplamento, qual a relação?

Durante este curso, falamos bastante sobre encapsular dados e comportamentos dentro de uma classe, mas existe outro conceito que anda lado a lado com o encapsulamento: o acoplamento.

Encapsulamento diz respeito a esconder detalhes internos de uma classe e oferecer apenas uma interface segura e controlada para interagir com o objeto. Isso te ajuda a proteger regras, validar dados e manter o objeto sempre em um estado consistente.

Já o acoplamento é o grau de dependência entre diferentes partes do seu sistema. Quando uma classe conhece demais os detalhes internos de outra, dizemos que há alto acoplamento, o que pode dificultar a manutenção, testes e evolução do software.

Agora vem o ponto chave: Quanto mais bem encapsulada uma classe for, menor será o acoplamento entre os objetos.

Isso acontece porque, ao esconder a implementação interna e expor apenas o que é necessário, você força os outros objetos a se relacionarem apenas com aquilo que foi planejado, e não com os detalhes internos. É como um contrato: a classe se compromete com um comportamento, não com uma estrutura específica.

Veja a seguir um exemplo de alto acoplamento (sem encapsulamento)

```csharp
public class ContaBancaria
{
    public double Saldo; // público!

    public ContaBancaria(double saldoInicial)
    {
        Saldo = saldoInicial;
    }
}

public class CaixaEletronico
{
    public void Sacar(ContaBancaria conta, double valor)
    {
        conta.Saldo -= valor; // acesso direto ao saldo
    }
}
```

Nesse exemplo, a classe CaixaEletronico conhece e manipula diretamente o estado interno da conta. Se amanhã o banco mudar a regra de saque, todas as partes que acessam Saldo diretamente terão que ser ajustadas. Isso é alto acoplamento.

Agora veja o mesmo exemplo com baixo acoplamento (com encapsulamento)

```csharp
public class ContaBancaria
{
    private double saldo;

    public ContaBancaria(double saldoInicial)
    {
        saldo = saldoInicial;
    }

    public bool Sacar(double valor)
    {
        if (valor <= saldo)
        {
            saldo -= valor;
            return true;
        }
        return false;
    }

    public double Saldo => saldo;
}

public class CaixaEletronico
{
    public void Sacar(ContaBancaria conta, double valor)
    {
        if (!conta.Sacar(valor))
        {
            Console.WriteLine("Saldo insuficiente.");
        }
    }
}
```

Agora, CaixaEletronico depende apenas da interface pública de ContaBancaria.

Ele não sabe (nem precisa saber) como o saldo é armazenado ou validado. Isso reduz o acoplamento, tornando o sistema mais modular e flexível a mudanças.

Agora, quando for projetar suas classes, pense sempre: o que realmente precisa ser exposto?!

### Aula 2 - Conclusão

Parabéns por concluir este curso! Ao longo desta jornada, você colocou a mão no código e aplicou conceitos fundamentais de encapsulamento em C#. Agora, você é capaz de:

- Controlar o acesso a atributos sensíveis, protegendo regras de negócio e evitando alterações indevidas.
- Utilizar get e set de forma estratégica, encapsulando validações e garantindo a integridade dos dados.
- Aplicar modificadores de acesso como private, internal e readonly para organizar a estrutura do seu sistema com segurança.
- Separar responsabilidades entre classes, criando soluções mais coesas, seguras e de fácil manutenção.

Quer continuar se aprofundando? Recomendamos a [formação C# e Orientação a Objetos: coleções](https://cursos.alura.com.br/formacao-avancando-c-sharp), arquivos e bibliotecas para seguir evoluindo na linguagem e construir aplicações ainda mais completas.

Nos vemos nos próximos cursos práticos!
