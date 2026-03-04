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

### Aula 3 -  - Vídeo 3
### Aula 4 -  - Vídeo 4
### Aula 5 -  - Vídeo 5
### Aula 5 -  - Vídeo 6
### Aula 5 -  - Vídeo 7
