# Curso Alura - Praticando C#: orientação a objetos com classes

## Aula 1 - Praticando C#: Classes e objetos

### Aula 1 - Apresentação - Vídeo 1

Transcrição
Olá! Meu nome é Yasmin Araújo, sou instrutora na Escola de Programação, e irei me autodescrever para fins de acessibilidade.

Audiodescrição: Yasmin é uma mulher branca com cabelo castanho escuro médio, aproximadamente na altura dos ombros. Seu cabelo está repartido ao meio e ela está usando uma camiseta rosa choque. Ao fundo, há uma parede iluminada com luz azul.

**Conteúdo do Curso**  
Neste curso, vamos praticar a habilidade de trabalhar com classes, objetos e abstração. Mais especificamente, abordaremos os seguintes tópicos: o uso de classes, entendendo em que contexto é interessante utilizá-las, e aprenderemos a diferenciar classes de objetos.

**Objetivos e Metodologia**  
Vamos aprender a usar a palavra-chave nil para criar nossos objetos. Veremos também quais são os pilares da Programação Orientada a Objetos (P.O.O.). Por fim, vamos diferenciar o que são atributos e métodos.

**Importância da Abstração e Prática**  
Dentre os pilares da P.O.O., temos a abstração. A abstração nos ajudará a criar os melhores atributos e métodos possíveis para nossas classes. Todos esses tópicos relacionados a classes, objetos e abstração precisam ser muito praticados para que possamos internalizar nosso conhecimento.

**Recomendações para o Aprendizado**  
É interessante assistir a todos os vídeos de revisão e, em seguida, focar bastante na prática para realmente aprender todos esses tópicos.

Conclusão  
Vamos começar?

### Aula 1 -  O que esperar deste curso?

Antes de mergulharmos no código, que tal alinharmos as expectativas?

**O que significa um curso prático?**  
Já se pegou pensando — será que consigo aplicar o que aprendi na prática? Este curso é a sua resposta. Aqui, o foco é colocar a mão no código, resolver problemas e testar seu conhecimento de forma ativa. Você terá:

- Vídeo de revisão do conteúdo
- Material de apoio
- Desafios de código

**Pré requisitos**  
É importante ter concluído o curso C#: criando sua primeira aplicação, pois ele cobre os fundamentos da linguagem, garantindo que você consiga realizar os exercícios deste curso com mais segurança.

#### Dicas para potencializar seu aprendizado neste curso

- Assista ao vídeo de revisão com atenção. Pause, anote e revise sempre que necessário.
- Baixe o material complementar para ter um apoio nas atividades.
- Faça os desafios na sua IDE favorita.

Compartilhe o que aprendeu no fórum, pois sua abordagem pode inspirar outras pessoas.
Vamos começar?

### Aula 1 - Classes e objetos - Vídeo 2

Transcrição  
Para começarmos, vamos analisar os dados apresentados no slide. Temos dados de produtos diferentes e a ideia é construir um sistema de e-commerce para vender todos esses produtos. Para cada produto na tabela, temos um nome, uma descrição, um preço e um estoque. Os produtos incluem teclado, cadeira gamer, notebook, outro teclado e um mouse. Este é o exemplo da tabela.

**Representação de Dados com Variáveis**  
Se quisermos representar esses dados via código, com o conhecimento que temos até agora, como isso ficaria? No Visual Studio, temos alguns exemplos. Criamos várias variáveis diferentes: nome1, descrição1, preço1, estoque1 para representar o primeiro produto, e nome2, descrição2 e assim por diante, para o segundo produto. Neste caso, escolhemos representar apenas dois produtos. Note que, para representar duas coisas diferentes, já precisamos criar muitas variáveis distintas. Imagine se tivéssemos 10, 15 ou 100 produtos. Criar quatro variáveis distintas para cada um deles seria cansativo e difícil de gerenciar.

Aqui está um exemplo de como isso seria feito com variáveis separadas:

```csharp
string nome1 = "Teclado";
string descricao1 = "Modelo compacto e silencioso, " +
                    "perfeito para produtividade diária.";
decimal preco1 = 80.00m;
int estoque1 = 15;

Console.WriteLine($@"Dados do item 1:
Nome: {nome1},
Descrição: {descricao1}
Preço: {preco1},
Estoque: {estoque1}
");

string nome2 = "Cadeira gamer";
string descricao2 = "Conforto ergonômico com design" +
                    " moderno para longas sessões de jogo.";
decimal preco2 = 600.00m;
int estoque2 = 5;

Console.WriteLine($@"Dados do item 2:
Nome: {nome2},
Descrição: {descricao2}
Preço: {preco2},
Estoque: {estoque2}
");
```

**Problemas com a Abordagem de Variáveis Isoladas**  
Além disso, há outro ponto a considerar. Temos a variável estoque1. Olhando para o exemplo, sabemos que estoque1 está relacionado a nome1, mas poderia não estar. Não há garantia, pois as variáveis estão isoladas no código. O ideal seria que essas informações estivessem concentradas para que pudéssemos associá-las de alguma forma.

**Introdução ao Uso de Classes**  
Para isso, podemos criar um tipo que agrupe todas essas características em comum. Como criamos um tipo em C#? Utilizando classes. Para criar uma classe que represente um produto com todas essas características em comum, dentro da solução "praticando C-sharp", no menu lateral direito, clicamos com o botão direito e selecionamos "adicionar novo item". Selecionamos "arquivo de código" e nomeamos como produto.cs. Adicionamos ao código.

Feito isso, criamos um arquivo de código. Agora, precisamos criar o tipo produto, que será uma classe. Usamos a palavra-chave class e colocamos o nome da classe, que é produto. Abrimos e fechamos chaves e, dentro delas, colocamos todas as características em comum de um produto: uma string para o nome, uma string para a descrição, um decimal para o preço e, por fim, um int para o estoque. Assim, criamos uma classe e a salvamos.

```csharp
class Produto
{
    string nome;
    string descricao;
    decimal preco;
    int estoque;
}
```

**Criando Objetos a Partir de Classes**  
Ao criar esse tipo, que é uma classe, estamos criando um tipo referenciado. Lembrando do nosso primeiro curso sobre variáveis e tipos, vimos os tipos primitivos e os tipos referenciados. Como trabalhamos com esses tipos referenciados? Como criamos uma variável com esse tipo? Começamos a criação como fizemos antes. Temos, por exemplo, o nome do nosso tipo, que será produto. Em seguida, passamos o nome da variável, que chamaremos de item1.

Agora, vem a diferença entre tipos primitivos e tipos referenciados. No tipo primitivo, conseguimos passar um valor diretamente, mas o tipo referenciado contém várias informações. Não conseguimos passar esse valor de uma vez. Precisamos pedir à memória que reserve um espaço para guardar essas informações.

Para realizar essa tarefa, utilizaremos o new, Produto, abrindo e fechando parênteses. Com isso, já reservamos espaço na memória.

```csharp
Produto item1 = new Produto();
```

Agora, podemos preencher esse espaço, atribuindo valores a cada uma das características definidas na classe. Por exemplo, utilizaremos item1.nome. Ao usar o ponto, acessamos a característica específica da classe. Assim, faremos item1.nome e atribuiremos "teclado". Para as demais características, seguiremos o mesmo procedimento.

```csharp
item1.nome = "Teclado";
item1.descricao = "Modelo compacto e silencioso, " +
                  "perfeito para produtividade diária.";
item1.preco = 80.00m;
item1.estoque = 15;
```

**Tornando as Propriedades Visíveis**  
Identificamos um problema: o nome não está visível. Para corrigir isso, utilizaremos na classe produto a palavra-chave public. Vamos compreender melhor esse conceito no curso de encapsulamento. Por ora, aplicamos essa palavra-chave e posteriormente entenderemos seu significado. Usamos public antes de cada característica da classe.

```csharp
public string nome;
public string descricao;
public decimal preco;
public int estoque;
```

Agora, recompilamos o código e ele voltou a funcionar normalmente.

**Imprimindo Dados do Objeto**  
Prosseguindo, vamos definir item1.descrição e atribuir a descrição do produto ao nosso item. Em seguida, item1.preço será 80.00m e, por fim, item1.estoque terá o valor 15.

Nosso objetivo é manter o comportamento anterior, que consiste em imprimir os dados de item1. Para isso, copiaremos o console.writeLine que está acima. Queremos que os dados sejam impressos, e para isso, utilizaremos o ponto novamente. Assim, usaremos item1.nome, item1.descrição, item1.preço e item1.estoque.

```csharp
Console.WriteLine($@"Dados do item 1:
Nome: {item1.nome},
Descrição: {item1.descricao}
Preço: {item1.preco},
Estoque: {item1.estoque}
");
```

Após isso, podemos executar o código para verificar o resultado. Comentaremos o que está acima para não perdermos os dados. Executamos a aplicação e visualizamos os dados de item1 com todas as informações.

**Conclusão e Próximos Passos**
Verificamos que a criação da classe foi bem-sucedida. Observamos que cada informação está associada corretamente. O estoque 15 está associado ao nome "teclado", que também está associado ao preço e à descrição. Ao criar tipos, conseguimos agrupar todas essas informações.

Falando sobre a diferença entre classes e objetos, temos que uma classe é o modelo do tipo, descrevendo tudo que ele contém. Por exemplo, no caso de produto, dizemos que todo produto tem um nome, descrição, preço e estoque. Contudo, não há valores associados a esses dados. Para associar valores e criar diferentes produtos, criamos objetos. A partir do modelo, podemos criar vários itens com valores distintos. Um sinônimo para objetos é instância, ou seja, temos várias instâncias de um mesmo produto.

Diferenciando classes de objetos, podemos afirmar que, ao utilizá-los, trabalhamos com o paradigma de Programação Orientada a Objetos (POO). Nesse paradigma, focamos em criar classes para descrever diferentes tipos. A POO possui vários pilares: abstração, encapsulamento, herança e polimorfismo. Neste curso, abordaremos a abstração, que se concentra em representar informações do mundo real através da programação orientada a objetos. Na sequência, aprofundaremos esse tema e aprenderemos a estruturar nossas classes de forma mais eficiente. Nos vemos na próxima aula!

### Aula 1 - Atributos e métodos - Vídeo 3

Transcrição  
Nós vimos que existem várias características em comum que podem ser agrupadas. Uma vez que agrupamos essas características, temos um tipo referenciado. Em C#, representamos esses tipos referenciados utilizando classes. Criamos uma classe para representar nosso produto e, dentro dessa classe, incluímos um nome, uma descrição, um preço e um estoque.

**Estrutura Básica da Classe Produto**  
Para começar, vamos definir a estrutura básica da nossa classe Produto com seus atributos:

```csharp
class Produto
{
    public string nome;
    public string descricao;
    public decimal preco;
    public int estoque;
}
```

**Comportamentos Comuns dos Produtos**  
Além dessas características em comum, também temos comportamentos em comum. Por exemplo, para todo produto, podemos querer saber se ele está disponível ou não. Para determinar isso, precisamos verificar a característica estoque, observando se o estoque é maior do que zero. Podemos também trabalhar com o preço, aplicando um desconto que atualiza o valor. São várias operações em comum que ocorrem para todos os produtos, e conseguimos representar essas operações.

**Implementação de Métodos na Classe Produto**  
As características do nosso produto se assemelham a variáveis, enquanto os comportamentos de um produto, representados dentro das classes, se assemelham a funções. Dentro da classe Produto, criaremos essas funções que serão comportamentos em comum. Para isso, declaramos um public, que será ignorado por enquanto, e o retorno da função, que será um bool. Criamos uma função para verificar se o estoque está disponível. Usamos o nome EstáDisponível e abrimos e fechamos parênteses. O nome da função na classe utiliza o método Pascal Casing, no qual a primeira letra e as letras de todas as outras palavras são maiúsculas. Dentro dos parênteses, poderíamos colocar parâmetros, mas não será o caso nesta primeira função. Dentro das chaves, passamos o corpo da função, que retornará se o estoque é maior do que zero. Assim, sabemos se o produto está disponível ou não.

Construção da Função EstaDisponivel  
Vamos construir essa função passo a passo:

Primeiro, declaramos a função EstaDisponivel:

```csharp
public bool EstaDisponivel()
{
}
```

Em seguida, implementamos a lógica para verificar se o estoque é maior que zero:

```csharp
public bool EstaDisponivel()
{
    return estoque > 0;
}
```

**Método para Aplicar Desconto no Preço**  
Agora, vamos criar uma nova função que representará a aplicação de um desconto no preço. Para isso, não teremos nenhum retorno, então usamos a palavra-chave void, que indica que o retorno é vazio. Criamos o método AlterarPrecoComDesconto. Abrimos os parênteses e, dentro deles, passamos um parâmetro que será um decimal desconto. Agora, podemos pensar no corpo da função novamente.

Para conseguirmos alterar o preço aplicando um desconto, precisamos utilizar uma variável da classe. Vamos definir que o preço será igual ao preço antigo multiplicado pelo valor com desconto. O valor com desconto será 1 menos o desconto. Dessa forma, temos dois comportamentos, ou seja, duas funções diferentes para a mesma classe.

Construção do Método AlterarPrecoComDesconto  
Vamos construir o método AlterarPrecoComDesconto:

Primeiro, declaramos o método com o parâmetro desconto:

```csharp
public void AlterarPrecoComDesconto(decimal desconto)
{
}
```

Em seguida, implementamos a lógica para aplicar o desconto ao preço:

```csharp
public void AlterarPrecoComDesconto(decimal desconto)
{
    preco = preco * (1 - desconto);
}
```

**Utilização dos Métodos no program.cs**  
Como utilizamos essas funções no program.cs? Utilizamos pontos, assim como fazemos com os atributos. Podemos, por exemplo, verificar se o item 1 está disponível ou não. Para isso, utilizamos item1.EstáDisponível. Aqui, estamos realizando uma verificação para obter um valor booleano. Se o item estiver disponível, exibiremos uma mensagem no console com Console.WriteLine informando que o produto está disponível. Corrigindo, a mensagem correta é "Produto está disponível".

Exemplo de Verificação de Disponibilidade
Vamos ver como isso é feito no código:

```csharp
if(item1.EstaDisponivel())
{
    Console.WriteLine("Produto está disponível!");
}
```

**Aplicação de Desconto e Impressão dos Dados**  
Além disso, podemos também alterar o preço do produto. Para isso, utilizamos item1.AlterarPrecoComDesconto, passando o valor do desconto. Suponhamos que utilizemos um desconto de 20%, então passamos 0.2m. Após isso, podemos imprimir novamente os dados do item. Utilizamos Ctrl+C e Ctrl+V para copiar e colar o código logo abaixo. Em seguida, executamos a aplicação.

item1.AlterarPrecoComDesconto(0.2m);

```csharp
Console.WriteLine(@$"Dados do item 1:
Nome: {item1.nome};
Descrição: {item1.descricao};
Preço: {item1.preco};
Estoque: {item1.estoque};
");
```

**Resultados e Conclusão**  
Ao executar, visualizamos os dados do item 1 anteriormente, com preço de R$ 80 e estoque de 15 unidades. Depois, imprimimos que o produto está disponível. Alteramos o código e, após aplicar o desconto, o preço passou a ser R$ 64. Dessa forma, verificamos que as funções da classe estão funcionando corretamente. Corrigimos o "S" em "disponível".

Assim, as funções e as variáveis ou características da classe estão funcionando corretamente. Utilizamos os termos variáveis ou características em comum, assim como funções ou comportamentos em comum. No entanto, a Programação Orientada a Objetos (P.O.) define termos específicos para isso. As características de uma classe são chamadas de atributos, e as funções de uma classe são chamadas de métodos.

**Desafio da Abstração na Programação Orientada a Objetos**  
O grande desafio é escolher os melhores atributos e métodos para representar nossas classes. Esse desafio é a abstração, que consiste em pegar o que está no mundo real e transformar em código, escolhendo os melhores atributos, métodos e classes específicas que queremos modelar. Na sequência, teremos uma série de exercícios para praticar essa habilidade de representar elementos do mundo real na programação, utilizando a abstração.

### Aula 1 - Preparando o ambiente: instalando o Visual Studio

Olá!

O IDE do Visual Studio é uma plataforma de lançamento criativa que você pode usar para editar, depurar e criar código e, em seguida, publicar um aplicativo. Além do editor e depurador padrão fornecidos pela maioria dos IDEs, o Visual Studio inclui compiladores, ferramentas de conclusão de código, designers gráficos e muitos outros recursos para aprimorar o processo de desenvolvimento de software. O IDE mais abrangente para desenvolvedores .NET no Windows e Mac para criação de web, nuvem, desktop, aplicativos móveis, serviços e jogos.

Sabendo disso, preparamos alguns vídeos para instalar em diferentes sistemas operacionais. Para este curso em específico, marque a opção Desenvolvimento para Desktop com .NET. no processo de instalação.

Visual Studio no Windows

Visual Studio no Mac

C# no VSCODE (SDK)

C# em distribuições Linux

[Neste link](https://learn.microsoft.com/pt-br/dotnet/core/install/linux), você encontra um passo a passo da própria Microsoft de como instalar em distribuições Linux, como Alpine, CentOS, Debian, entre outras.

Vamos começar?

### Aula 1 -  Preparando o ambiente: material de apoio

Após revisar os conceitos de coleções em C#, é hora de colocar o conhecimento em prática com uma série de atividades focadas no tema. Caso queira acessar os slides da revisão, eles estão disponíveis no link abaixo:

[Baixe os slides do curso](https://cdn3.gnarususercontent.com.br/4701-praticando-csharp/Praticando%20C%23%20e%20OO_%20Classes%2C%20objetos%20e%20abstra%C3%A7%C3%A3o.pptx.pdf)

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

### Aula 1 - Faça como eu fiz: cadastro de livros na biblioteca

Imagine que você está desenvolvendo uma aplicação para uma biblioteca que precisa cadastrar livros. Cada livro deve ter um título e um autor.

Crie uma classe chamada Livro que possua duas propriedades públicas: Titulo e Autor. Depois, crie um objeto dessa classe e preencha os dados com um título e autor de sua escolha e exiba a saída.

Exemplo de entrada:

```csharp
meuLivro.Titulo = "Dom Casmurro";  
meuLivro.Autor = "Machado de Assis";  
```

Exemplo de saída:

```csharp
Livro: Dom Casmurro
Autor: Machado de Assis
```

Opinião do instrutor

Neste exercício, trabalhamos com o conceito de classe. Criamos a classe Livro, que define dois atributos muito importantes para descrever qualquer livro: o Título e o Autor. Esses atributos foram implementados usando propriedades públicas com { get; set; }, o que nos permite tanto ler quanto modificar os valores de fora da classe.

O próximo passo foi instanciar a classe, criando o objeto meuLivro. Isso é importante, porque enquanto a classe é só o molde (como a planta de uma casa), o objeto é a construção real que podemos usar no nosso programa. Definimos os valores do título e do autor diretamente nas propriedades do objeto, o que ilustra o ciclo básico de trabalho em orientação a objetos: primeiro definimos a estrutura, depois criamos a instância, manipulamos seus dados e, por fim, usamos esses dados para algum propósito.

Fluxograma mostrando o ciclo de vida de um objeto em programação orientada a objetos: começa com 'Definir a estrutura do objeto (ex: class Pessoa)', seguido por 'Criar uma instância (ex: pessoa1 = Pessoa())', 'Manipular dados da instância (ex: pessoa1.nome = "Ana")' e termina com 'Utilizar os dados (ex: print(pessoa1.nome))'."

Na exibição dos dados, utilizamos o Console.WriteLine, combinando texto com as informações do objeto usando o operador +. Isso nos permitiu montar mensagens personalizadas. Embora a concatenação com + funcione bem, saiba que existem formas mais modernas de montar strings em C#, como a interpolação ($"Livro: {meuLivro.Titulo}"), que você pode explorar em exercícios futuros.

```csharp
public class Livro 
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
}

Livro meuLivro = new Livro();
meuLivro.Titulo = "Dom Casmurro";
meuLivro.Autor = "Machado de Assis";

Console.WriteLine("Livro: " + meuLivro.Titulo);
Console.WriteLine("Autor: " + meuLivro.Autor);
```

Agora é sua vez! Teste o programa, compartilhe no fórum e compare sua lógica com outras soluções.

### Aula 1 - Faça como eu fiz: emissão de passagem de viagem

Você está criando um sistema de emissão de passagens para uma agência de viagens. Cada passagem precisa obrigatoriamente conter o nome do passageiro e o destino, definidos no momento da criação.

Crie uma classe chamada Passagem que tenha:

- Uma propriedade pública Passageiro.
- Uma propriedade pública Destino.
- Um construtor que obrigue o preenchimento dessas informações na criação do objeto.

Depois, crie uma instância da classe e exiba os dados da passagem.

Exemplo de entrada:

Passagem passagem = new Passagem("Lucas Souza", "Paris");

Exemplo de saída:

Passageiro: Lucas Souza  
Destino: Paris

Opinião do instrutor

O foco principal dessa atividade está no uso de construtores para garantir que objetos sejam criados com todos os dados necessários.

```csharp
public class Passagem
{
    public string Passageiro { get; set; }
    public string Destino { get; set; }

    public Passagem(string passageiro, string destino)
    {
        Passageiro = passageiro;
        Destino = destino;
    }
}
```

O construtor recebe dois parâmetros (passageiro e destino) que devem ser fornecidos quando o objeto é criado. Isso garante que nunca teremos uma passagem sem essas informações.

Passagem passagem = new Passagem("Lucas Souza", "Paris");

```csharp
Console.WriteLine("Passageiro: " + passagem.Passageiro);
Console.WriteLine("Destino: " + passagem.Destino);
```

Esta implementação ilustra vários conceitos importantes na orientação a objetos, como você pode acompanhar na imagem abaixo:

O fluxograma começa com a caixa "Classe Passagem criada", seguida pela caixa "Propriedades agrupadas: Encapsulamento", depois "Construtor exige dados: Validação Implícita" e, por fim, "Objeto criado de forma clara: Clareza no uso". As caixas estão conectadas por setas apontando para baixo, indicando a sequência dos conceitos.

Agora é sua vez! Teste o programa, compartilhe no fórum e compare sua lógica com outras soluções.

### Aula 1 - Faça como eu fiz: criando uma classe conta bancária

Você foi contratado(a) para desenvolver um sistema de operações bancárias. Cada conta precisa ter um número e um saldo inicial. E, deve existir um método para realizar depósitos, recebendo o valor a ser depositado como parâmetro.

Crie uma classe chamada ContaBancaria que tenha:

- Uma propriedade pública NumeroConta.
- Uma propriedade pública Saldo.
- Um método Depositar(double valor) que adicione o valor ao saldo existente.
- Depois, crie uma instância da classe, realize um depósito e exiba o saldo atualizado.

Exemplo de entrada:

```csharp
ContaBancaria conta = new ContaBancaria("78901-2", 1000.00);
conta.Depositar(500.00);
```

Exemplo de saída:

```csharp
Conta: 78901-2
Saldo atual: R$ 1500,00
```

**Opinião do instrutor**  

Neste exercício, criamos a estrutura de uma classe chamada ContaBancaria, que representa uma conta bancária. Definimos duas propriedades: NumeroConta, que guarda o identificador da conta como uma string, e Saldo, que armazena o valor em dinheiro usando o tipo double.

O primeiro passo na classe foi construir o método construtor (ContaBancaria), que é executado assim que um novo objeto da classe é criado. Com ele, conseguimos inicializar a conta já com um número e um saldo inicial, tornando o objeto funcional desde sua criação.

Depois, adicionamos um método chamado Depositar, que recebe um valor e adiciona esse valor ao saldo atual da conta. Perceba como o método modifica diretamente a propriedade Saldo, mostrando como um comportamento (ação) altera o estado de um objeto.

Na parte prática, instanciamos um objeto da classe (new ContaBancaria("78901-2", 1000.00)), realizamos um depósito de 500.00 e exibimos as informações. A exibição usa o Console.WriteLine para mostrar tanto o número da conta quanto o saldo atualizado. Aplicamos também a formatação ToString("F2") para garantir que o saldo apareça com duas casas decimais. Veja a seguir o código completo:

```csharp
public class ContaBancaria
{
    public string NumeroConta { get; set; }
    public double Saldo { get; set; }

    public ContaBancaria(string numeroConta, double saldoInicial)
    {
        NumeroConta = numeroConta;
        Saldo = saldoInicial;
    }

    public void Depositar(double valor)
    {
        Saldo += valor;
    }
}
ContaBancaria conta = new ContaBancaria("78901-2", 1000.00);
conta.Depositar(500.00);

Console.WriteLine("Conta: " + conta.NumeroConta);
Console.WriteLine("Saldo atual: R$ " + conta.Saldo.ToString("F2"));
```

É seu momento! Experimente o programa, divida sua experiência no fórum e observe diferentes formas de pensar o problema.

### Aula 1 - Faça como eu fiz: gerenciamento de funcionários

Você está desenvolvendo um sistema de gestão de pessoas para uma empresa. O sistema precisa cadastrar funcionários informando o nome e o cargo no momento da criação. E, ele deve permitir que um funcionário seja promovido para um novo cargo, mas apenas se o novo cargo for diferente do atual — não faria sentido uma promoção que não mudasse o cargo da pessoa, concorda?!

Crie uma classe chamada Funcionario que tenha:

- Uma propriedade pública Nome.
- Uma propriedade pública Cargo.
- Um construtor que receba nome e cargo como parâmetros obrigatórios.
- Um método chamado Promover(string novoCargo) que atualize o cargo do funcionário, somente se o novo cargo for diferente do atual. Se for o mesmo, exiba uma mensagem de erro informando que a promoção não pode ocorrer.
- Depois, crie uma instância da classe, exiba os dados iniciais, promova o funcionário e exiba os dados atualizados.

Exemplo de entrada:

```csharp
Funcionario funcionario = new Funcionario("Carlos Pereira", "Assistente Administrativo");
funcionario.Promover("Assistente Administrativo"); // Tentativa inválida
funcionario.Promover("Analista de Projetos");       // Promoção válida
```

Exemplo de saída:

```csharp
Funcionário: Carlos Pereira
Cargo Atual: Assistente Administrativo
 
Erro: O novo cargo deve ser diferente do cargo atual.
 
Promoção realizada com sucesso!
 
--- Após promoção ---
Funcionário: Carlos Pereira
Cargo Atual: Analista de Projetos
```

Opinião do instrutor

Nesta atividade, introduzimos a ideia de regras de negócio dentro das classes. Construímos a classe Funcionario com duas propriedades: Nome e Cargo. O ponto central desta atividade é o método Promover. Nele, não basta simplesmente trocarmos o cargo — incluímos uma verificação: só permitimos a promoção se o novo cargo for diferente do atual. Essa validação dentro do método protege nosso objeto de alterações sem sentido e representa uma prática muito comum em sistemas reais, onde não basta apenas "permitir mudanças", mas também controlar como e quando elas acontecem.

Essa lógica foi implementada usando uma estrutura if. Se o novo cargo for igual ao atual, exibimos uma mensagem de erro; se forem diferentes, atualizamos o cargo e informamos que a promoção foi concluída com sucesso. Acompanhe abaixo a resolução:

```csharp
public class Funcionario
{
    public string Nome { get; set; }
    public string Cargo { get; set; }
 
    public Funcionario(string nome, string cargo)
    {
        Nome = nome;
        Cargo = cargo;
    }
 
    public void Promover(string novoCargo)
    {
        if (novoCargo != Cargo)
        {
            Cargo = novoCargo;
            Console.WriteLine("Promoção realizada com sucesso!");
        }
        else
        {
            Console.WriteLine("Erro: O novo cargo deve ser diferente do cargo atual.");
        }
    }
}
 
class Program
{
    static void Main(string[] args)
    {
        Funcionario funcionario = new Funcionario("Carlos Pereira", "Assistente Administrativo");
 
        Console.WriteLine("Funcionário: " + funcionario.Nome);
        Console.WriteLine("Cargo Atual: " + funcionario.Cargo);
 
        funcionario.Promover("Assistente Administrativo"); // Tentativa inválida
        funcionario.Promover("Analista de Projetos");       // Promoção válida
 
        Console.WriteLine("--- Após promoção ---");
        Console.WriteLine("Funcionário: " + funcionario.Nome);
        Console.WriteLine("Cargo Atual: " + funcionario.Cargo);
    }
}
```

Vamos colocar em prática? Execute o programa, compartilhe no fórum e inspire-se em outras abordagens.

### Aula 1 - Faça como eu fiz: representando retângulos e calculando área

Você está desenvolvendo uma ferramenta de cálculo geométrico para auxiliar estudantes de um curso de matemática. Uma das funcionalidades é representar um retângulo, permitindo calcular sua área de acordo com a altura e a largura fornecidas.

Crie uma classe chamada Retangulo que tenha:

Duas propriedades públicas: Altura e Largura.
Um método chamado CalcularArea() que retorne a área do retângulo (altura × largura).
Depois, crie um objeto da classe, atribua os valores e mostre o resultado da área na tela.

Exemplo de entrada:

```csharp
Retangulo retangulo = new Retangulo();
retangulo.Altura = 5;
retangulo.Largura = 8; 
```

Exemplo de saída:

```csharp
Área do Retângulo: 40
```

Opinião do instrutor

Nesta atividade, criamos a classe Retangulo, encapsulando duas informações para descrever essa figura geométrica: Altura e Largura.

Essas propriedades foram declaradas como double. Ao usar double em vez de int, garantimos que o retângulo possa ter dimensões com valores decimais, como 5,5 cm de altura ou 8,2 cm de largura. Isso traz mais realismo ao nosso sistema, já que, no mundo real, as medidas raramente são números inteiros perfeitos.

Dentro da classe, adicionamos o método CalcularArea(), que implementa a fórmula da área de um retângulo (altura × largura). A lógica foi diretamente embutida no objeto, seguindo o princípio de que um objeto deve saber se comportar com base nos seus próprios dados. Assim, sempre que quisermos saber a área, basta chamar o método — sem precisar reescrever a fórmula em outro lugar do código.

```csharp
public class Retangulo
{
    public double Altura { get; set; }
    public double Largura { get; set; }

    public double CalcularArea()
    {
        return Altura * Largura;
    }
}
```

E aqui como usamos a classe:

```csharp
Retangulo retangulo = new Retangulo();
retangulo.Altura = 5;
retangulo.Largura = 8;

Console.WriteLine("Área do Retângulo: " + retangulo.CalcularArea());
```

Um ponto muito importante é que o método CalcularArea() não armazena a área em uma variável fixa dentro da classe. Ele sempre recalcula o valor da área toda vez que é chamado, usando os valores atuais de Altura e Largura. Isso traz uma vantagem: você não precisa se preocupar em atualizar a área manualmente se as dimensões do retângulo mudarem. O método vai fazer isso automaticamente para você. Por exemplo, imagine que você criou um retângulo assim:

```csharp
Retangulo retangulo = new Retangulo();
retangulo.Altura = 5;
retangulo.Largura = 8;
```

Se você chamar retangulo.CalcularArea(), o resultado será 5 × 8 = 40. Agora, suponha que depois disso você mude o valor da altura: retangulo.Altura = 10;

Se você chamar retangulo.CalcularArea() de novo, o cálculo vai usar os novos valores, e o resultado será 10 × 8 = 80, sem que você precise alterar nada no método ou criar novas variáveis. Isso acontece porque CalcularArea() não depende dos valores antigos — ele sempre olha os valores atuais no momento em que você pede o cálculo. É como se o retângulo dissesse: "Me diga agora qual é minha altura e largura, que eu te mostro a área certa neste instante." Esse comportamento mostra como objetos bem construídos mantêm seus dados e suas operações sempre atualizadas e consistentes, sem depender de ações externas para corrigir ou sincronizar informações.

Ufa! Chegou a sua vez. Rode o programa, publique no fórum e veja como sua solução se conecta com as dos colegas.

### Aula 1 - Faça como eu fiz: validação de acesso a filmes

Imagine que você está criando um sistema de recomendação para uma plataforma de filmes. Cada filme tem um título e uma classificação indicativa. Para garantir que as pessoas vejam apenas conteúdos apropriados para sua idade, o sistema deve verificar se a pessoa pode assistir ao filme com base na idade informada.

Crie uma classe chamada Filme que tenha:

Propriedades públicas Titulo e ClassificacaoEtaria (int).
Um método chamado PodeAssistir(int idadeUsuario) que retorna true se a idade for maior ou igual à classificação etária, e false caso contrário.
Um método ExibirResultado(int idadeUsuario) que exiba uma mensagem amigável informando se o usuário pode ou não assistir ao filme.
Exemplo de entrada:

```csharp
Filme filme = new Filme("Matrix", 16);
filme.ExibirResultado(14);
filme.ExibirResultado(20);
```

Exemplo de saída:

```csharp
Usuário com 14 anos não pode assistir ao filme Matrix.
Usuário com 20 anos pode assistir ao filme Matrix.
```

Opinião do instrutor

Aqui começamos a pensar no comportamento dos objetos de forma mais ativa. A classe Filme representa mais do que só dados — ela tem decisões internas sobre quem pode ou não acessar o conteúdo. Isso é típico em qualquer sistema com regras de acesso, como plataformas de streaming, aplicativos educacionais ou serviços financeiros.

A propriedade ClassificacaoEtaria representa o mínimo de idade exigida para assistir ao filme. O método PodeAssistir faz a comparação entre a idade do usuário e essa classificação. Se a idade for suficiente, retorna true. Caso contrário, false.

Criamos ainda o método ExibirResultado, que centraliza a exibição da mensagem para o usuário. Assim, mantemos a lógica e a apresentação separadas, facilitando ajustes futuros (como trocar a mensagem, traduzir, etc).

Acompanhe abaixo a implementação:

```csharp
public class Filme
{
    public string Titulo { get; set; }
    public int ClassificacaoEtaria { get; set; }

    public Filme(string titulo, int classificacao)
    {
        Titulo = titulo;
        ClassificacaoEtaria = classificacao;
    }

    public bool PodeAssistir(int idadeUsuario)
    {
        return idadeUsuario >= ClassificacaoEtaria;
    }

    public void ExibirResultado(int idadeUsuario)
    {
        if (PodeAssistir(idadeUsuario))
        {
            Console.WriteLine("Usuário com " + idadeUsuario + " anos pode assistir ao filme " + Titulo + ".");
        }
        else
        {
            Console.WriteLine("Usuário com " + idadeUsuario + " anos não pode assistir ao filme " + Titulo + ".");
        }
    }
}

Filme filme = new Filme("Matrix", 16);
filme.ExibirResultado(14);
filme.ExibirResultado(20);
```

Que tal colocar em prática? Depois disso, publique no fórum para compartilhar a sua versão com a comunidade.

### Aula 1 - Faça como eu fiz: controle de estoque

Você recebeu a missão de automatizar o sistema de estoque de uma papelaria. Cada item precisa registrar seu nome e a quantidade atual em estoque. O sistema deve permitir retirar itens, mas somente se houver quantidade suficiente disponível. Caso contrário, deve exibir uma mensagem informando a falha.

Crie uma classe chamada Produto com:

- Propriedade pública Nome.
- Campo privado quantidadeEstoque.
- Um construtor que receba o nome e a quantidade inicial.
- Um método público Retirar(int quantidade) que:
- Reduz a quantidade apenas se houver estoque suficiente.
- Exiba uma mensagem indicando o sucesso ou a falha da operação.
- Um método ExibirEstoque() para mostrar a quantidade atual.

Exemplo de entrada:

```csharp
Produto produto = new Produto("Caneta Azul", 20);
produto.Retirar(5);
produto.ExibirEstoque();
produto.Retirar(30);
```

Exemplo de saída:

```csharp
Retirada de 5 unidades realizada com sucesso.
Produto: Caneta Azul
Estoque: 15
Erro: Estoque insuficiente para retirada de 30 unidades.
```

Opinião do instrutor

Agora entramos em uma parte muito importante da orientação a objetos: controlar os dados internos e proteger o estado do objeto. Repare que a quantidade em estoque não é pública — ela só pode ser alterada pelos métodos da própria classe. Isso é intencional. Estamos evitando que outra parte do programa altere o estoque diretamente, o que pode causar inconsistência ou erros de lógica.

O método Retirar implementa a regra de negócio: só retira se tiver quantidade suficiente. Se puder retirar, atualiza o estoque e informa o sucesso. Se não puder, exibe uma mensagem clara para o usuário. Essa lógica simula o comportamento de sistemas de lojas, e-commerces, e até aplicativos de delivery.

Fluxograma representando a lógica do método Retirar da classe Produto. O fluxo começa com a etapa "Início da retirada", seguida de uma decisão: "Quantidade solicitada <= Estoque?". Se a resposta for "Sim", o fluxo segue para "Subtrai quantidade do estoque", depois para "Exibe mensagem de sucesso" e então "Fim". Se a resposta for "Não", o fluxo segue para "Exibe mensagem de erro" e depois também para "Fim". O fluxograma ilustra visualmente a verificação de estoque antes da retirada, com ações distintas para cada resultado da condição.

Esse fluxo garante que apenas retiradas válidas aconteçam. Esse tipo de controle é essencial em qualquer sistema de estoque — físico ou digital — para manter a integridade dos dados.

Agora vamos para a solução:

```csharp
public class Produto
{
    public string Nome { get; set; }
    private int quantidadeEstoque;

    public Produto(string nome, int quantidadeInicial)
    {
        Nome = nome;
        quantidadeEstoque = quantidadeInicial;
    }
    public void Retirar(int quantidade)
    {
        if (quantidade <= quantidadeEstoque)
        {
            quantidadeEstoque -= quantidade;
            Console.WriteLine("Retirada de " + quantidade + " unidades realizada com sucesso.");
        }
        else
        {
            Console.WriteLine("Erro: Estoque insuficiente para retirada de " + quantidade + " unidades.");
        }
    }
    public void ExibirEstoque()
    {
        Console.WriteLine("Produto: " + Nome);
        Console.WriteLine("Estoque: " + quantidadeEstoque);
    }
}
Produto produto = new Produto("Caneta Azul", 20);
produto.Retirar(5);
produto.ExibirEstoque();
produto.Retirar(30);
```

Agora é com você, pratique bastante e, depois, compartilhe sua versão no fórum e diga como chegou nela!

### Aula 1 -  Faça como eu fiz: representando um pedido de compra

Imagine que você está desenvolvendo um sistema de pedidos para uma loja virtual. Toda vez que alguém faz uma compra, o sistema precisa registrar o número do pedido, o nome do cliente e o status atual (por exemplo: "Pendente", "Enviado", "Entregue").

Seu papel é representar esse pedido como uma classe, com os principais atributos e um comportamento: permitir que o status seja atualizado conforme o pedido avança.

Crie uma classe chamada Pedido com:

- Propriedade pública NumeroPedido (string).
- Propriedade pública NomeCliente (string).
- Propriedade pública Status (string).
- Um método chamado AtualizarStatus(string novoStatus) para alterar o status.
- Um método chamado ExibirPedido() que mostre os dados na tela.

Exemplo de entrada:

```csharp
Pedido pedido = new Pedido("001", "Ana Silva", "Pendente");
pedido.ExibirPedido();
pedido.AtualizarStatus("Enviado");
pedido.ExibirPedido();
```

Exemplo de saída:

```csharp
Pedido nº 001
Cliente: Ana Silva
Status: Pendente

Pedido nº 001
Cliente: Ana Silva
Status: Enviado
```

Opinião do instrutor

Essa atividade nos leva a pensar de forma mais próxima do que é abstração. Pare e pense: quando você faz um pedido em um site, você não está preocupado com os bastidores do sistema. O que importa pra você é o número do pedido, o nome do cliente e o status atual.

Foi justamente isso que fizemos aqui: extraímos a essência do que é um pedido. Nada além do necessário. Não colocamos forma de pagamento, endereço ou valor — isso poderia existir em outras classes, mas não aqui. A classe Pedido está focada apenas em representar aquilo que realmente a define.

Com isso, criamos as propriedades básicas (NumeroPedido, NomeCliente e Status) e um método para atualizar o status. Assim, o pedido pode mudar ao longo do tempo, mas de forma controlada e organizada.

Também criamos um método ExibirPedido() para mostrar as informações do pedido. Ele centraliza a apresentação, o que nos ajuda a evitar código duplicado e facilita futuras mudanças (como exibir o status em cores, por exemplo).

Aqui tem uma forma de resolver a atividade:

```csharp
public class Pedido
{
    public string NumeroPedido { get; set; }
    public string NomeCliente { get; set; }
    public string Status { get; set; }

    public Pedido(string numeroPedido, string nomeCliente, string status)
    {
        NumeroPedido = numeroPedido;
        NomeCliente = nomeCliente;
        Status = status;
    }

    public void AtualizarStatus(string novoStatus)
    {
        Status = novoStatus;
    }

    public void ExibirPedido()
    {
        Console.WriteLine("Pedido nº " + NumeroPedido);
        Console.WriteLine("Cliente: " + NomeCliente);
        Console.WriteLine("Status: " + Status);
        Console.WriteLine();
    }
}

Pedido pedido = new Pedido("001", "Ana Silva", "Pendente");
pedido.ExibirPedido();
pedido.AtualizarStatus("Enviado");
pedido.ExibirPedido();
```

Agora é sua vez, e depois disso, compartilhe sua solução no fórum e veja como seus colegas modelaram esse mesmo conceito.

### Aula 1 - Faça como eu fiz: agendamento médico

Você está criando um sistema para agendamento de consultas em uma clínica. Toda consulta envolve o nome do paciente, o nome do médico e a data marcada. É comum que consultas sejam reagendadas — e seu sistema precisa permitir isso.

Você deve criar uma classe que represente uma consulta com os dados essenciais e um método para reagendar, mantendo o controle da data atualizada.

Crie uma classe chamada Consulta com:

- Propriedade pública NomePaciente.
- Propriedade pública NomeMedico.
- Propriedade pública DataConsulta (do tipo DateTime).
- Método Reagendar(DateTime novaData) para atualizar a data.
- Método ExibirResumo() que mostra as informações da consulta, usando "Data:" na primeira exibição e "Nova data:" se ela tiver sido reagendada.

Exemplo de entrada:

```csharp
Consulta consulta = new Consulta("João Lima", "Dra. Renata", new DateTime(2025, 5, 20));
consulta.ExibirResumo();
consulta.Reagendar(new DateTime(2025, 5, 25));
consulta.ExibirResumo();
```

Exemplo de saída:

```csharp
Consulta marcada com Dra. Renata para o paciente João Lima.
Data: 20/05/2025

Consulta marcada com Dra. Renata para o paciente João Lima.
Nova data: 25/05/2025
```

Opinião do instrutor

O destaque aqui está no controle da reagendamento. Criamos um campo privado chamado foiReagendada, que começa como false. Quando o método Reagendar() é chamado, além de atualizar a data, também marcamos esse campo como true.

Assim, o método ExibirResumo() pode verificar esse estado interno da consulta e exibir "Data:" ou "Nova data:" dependendo do momento. Isso mostra bem o princípio do encapsulamento, pois a classe lida com sua lógica interna sem depender do código externo para decidir o que mostrar.

Esse tipo de controle interno torna o código mais confiável e fácil de entender.

Acompanhe abaixo a solução:

```csharp
public class Consulta
{
    public string NomePaciente { get; set; }
    public string NomeMedico { get; set; }
    public DateTime DataConsulta { get; set; }
    private bool foiReagendada;
    public Consulta(string paciente, string medico, DateTime data)
    {
        NomePaciente = paciente;
        NomeMedico = medico;
        DataConsulta = data;
        foiReagendada = false;
    }
    public void Reagendar(DateTime novaData)
    {
        DataConsulta = novaData;
        foiReagendada = true;
    }
    public void ExibirResumo()
    {
        Console.WriteLine("Consulta marcada com " + NomeMedico + " para o paciente " + NomePaciente + ".");
        if (foiReagendada)
        {
            Console.WriteLine("Nova data: " + DataConsulta.ToString("dd/MM/yyyy"));
        }
        else
        {
            Console.WriteLine("Data: " + DataConsulta.ToString("dd/MM/yyyy"));
        }
        Console.WriteLine();
    }
}
Consulta consulta = new Consulta("João Lima", "Dra. Renata", new DateTime(2025, 5, 20));
consulta.ExibirResumo();
consulta.Reagendar(new DateTime(2025, 5, 25));
consulta.ExibirResumo();
```

Agora é sua vez! Teste o código, altere os valores e veja como o comportamento se adapta. Depois, compartilhe sua solução no fórum com sua explicação do que aprendeu!

### Aula 1 - Faça como eu fiz: modelando um produto digital com informações técnicas

Você precisa criar um sistema para uma loja de software. Cada produto digital tem um nome, um preço e detalhes técnicos, como o tamanho do arquivo e o sistema operacional compatível. Esses detalhes técnicos podem variar bastante e, por isso, fazem mais sentido em uma estrutura separada — uma classe só para isso.

Crie:

- Uma classe InformacaoTecnica com:
- Propriedades TamanhoMB e SistemaOperacional.
- Uma classe ProdutoDigital com:
- Propriedades Nome, Preco e InfoTecnica (do tipo InformacaoTecnica).
- Um método ExibirDetalhes() para mostrar tudo na tela.

Exemplo de entrada:

```csharp
InformacaoTecnica info = new InformacaoTecnica(1500, "Windows/Mac");
ProdutoDigital produto = new ProdutoDigital("Photoshop", 89.99, info);
produto.ExibirDetalhes();
```

Exemplo de saída:

```csharp
Produto: Photoshop
Preço: R$ 89,99
Tamanho: 1500MB
Compatível com: Windows/Mac
```

Opinião do instrutor

Ao invés de colocar todos os dados técnicos direto na classe ProdutoDigital, criamos a classe InformacaoTecnica separadamente. Isso porque as informações técnicas têm sua própria identidade e lógica. Esse tipo de separação é uma forma de enxergar as partes de um todo, e tornar o código mais limpo e reutilizável.

A classe ProdutoDigital agora fica responsável apenas por reunir os dados principais do produto e manter uma referência à parte técnica. Já a classe InformacaoTecnica fica livre para crescer: amanhã ela pode ter resolução, idioma, tipo de licença — e o código vai continuar organizado.

Para visualizar melhor a estrutura e a relação entre as classes, observe a imagem abaixo:

Diagrama de classes representando a relação entre as classes ProdutoDigital e InformacaoTecnica. A classe ProdutoDigital contém três atributos privados: Nome (string), Preco (double) e InfoTecnica (do tipo InformacaoTecnica), além de um método público ExibirDetalhes(). Abaixo dela, conectada por uma seta com o rótulo "contém", está a classe InformacaoTecnica, que possui dois atributos: TamanhoMB (int) e SistemaOperacional (string). O diagrama ilustra uma relação de composição, onde ProdutoDigital depende de InformacaoTecnica.

Veja a proposta de solução:

```csharp
public class InformacaoTecnica
{
    public int TamanhoMB { get; set; }
    public string SistemaOperacional { get; set; }

    public InformacaoTecnica(int tamanhoMB, string sistemaOperacional)
    {
        TamanhoMB = tamanhoMB;
        SistemaOperacional = sistemaOperacional;
    }
}
public class ProdutoDigital
{
    public string Nome { get; set; }
    public double Preco { get; set; }
    public InformacaoTecnica InfoTecnica { get; set; }

    public ProdutoDigital(string nome, double preco, InformacaoTecnica info)
    {
        Nome = nome;
        Preco = preco;
        InfoTecnica = info;
    }
    public void ExibirDetalhes()
    {
        Console.WriteLine("Produto: " + Nome);
        Console.WriteLine("Preço: R$ " + Preco.ToString("F2"));
        Console.WriteLine("Tamanho: " + InfoTecnica.TamanhoMB + "MB");
        Console.WriteLine("Compatível com: " + InfoTecnica.SistemaOperacional);
    }
}

InformacaoTecnica info = new InformacaoTecnica(1500, "Windows/Mac");
ProdutoDigital produto = new ProdutoDigital("Photoshop", 89.99, info);
produto.ExibirDetalhes();
```

Agora é sua vez! Teste o programa, compartilhe no fórum e compare sua lógica com outras soluções.

### Aula 1 - Conclusão

Parabéns por concluir este curso! Ao longo desta jornada, você colocou a mão no código e aplicou conceitos de programação orientada a objetos com C#, com foco na criação e uso de classes, atributos e métodos. Agora, você é capaz de:

- Criar classes e instanciar objetos para representar entidades do mundo real no seu sistema.
- Definir e utilizar construtores para garantir que os objetos sejam criados com dados consistentes.
- Aplicar comportamentos com métodos, encapsulando ações específicas como cálculos, alterações de estado ou validações simples.
- Organizar melhor seu código, separando responsabilidades entre diferentes classes e mantendo clareza na modelagem.

Quer continuar evoluindo em C#? Recomendamos a formação [C# e Orientação a Objetos: coleções, arquivos e bibliotecas](https://cursos.alura.com.br/formacao-avancando-c-sharp) para avançar ainda mais na linguagem e construir sistemas mais completos e profissionais.

Nos vemos nos próximos cursos práticos!
