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

Representação de Dados com Variáveis
Se quisermos representar esses dados via código, com o conhecimento que temos até agora, como isso ficaria? No Visual Studio, temos alguns exemplos. Criamos várias variáveis diferentes: nome1, descrição1, preço1, estoque1 para representar o primeiro produto, e nome2, descrição2 e assim por diante, para o segundo produto. Neste caso, escolhemos representar apenas dois produtos. Note que, para representar duas coisas diferentes, já precisamos criar muitas variáveis distintas. Imagine se tivéssemos 10, 15 ou 100 produtos. Criar quatro variáveis distintas para cada um deles seria cansativo e difícil de gerenciar.

Aqui está um exemplo de como isso seria feito com variáveis separadas:

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
Copiar código
Problemas com a Abordagem de Variáveis Isoladas
Além disso, há outro ponto a considerar. Temos a variável estoque1. Olhando para o exemplo, sabemos que estoque1 está relacionado a nome1, mas poderia não estar. Não há garantia, pois as variáveis estão isoladas no código. O ideal seria que essas informações estivessem concentradas para que pudéssemos associá-las de alguma forma.

Introdução ao Uso de Classes
Para isso, podemos criar um tipo que agrupe todas essas características em comum. Como criamos um tipo em C#? Utilizando classes. Para criar uma classe que represente um produto com todas essas características em comum, dentro da solução "praticando C-sharp", no menu lateral direito, clicamos com o botão direito e selecionamos "adicionar novo item". Selecionamos "arquivo de código" e nomeamos como produto.cs. Adicionamos ao código.

Feito isso, criamos um arquivo de código. Agora, precisamos criar o tipo produto, que será uma classe. Usamos a palavra-chave class e colocamos o nome da classe, que é produto. Abrimos e fechamos chaves e, dentro delas, colocamos todas as características em comum de um produto: uma string para o nome, uma string para a descrição, um decimal para o preço e, por fim, um int para o estoque. Assim, criamos uma classe e a salvamos.

class Produto
{
    string nome;
    string descricao;
    decimal preco;
    int estoque;
}
Copiar código
Criando Objetos a Partir de Classes
Ao criar esse tipo, que é uma classe, estamos criando um tipo referenciado. Lembrando do nosso primeiro curso sobre variáveis e tipos, vimos os tipos primitivos e os tipos referenciados. Como trabalhamos com esses tipos referenciados? Como criamos uma variável com esse tipo? Começamos a criação como fizemos antes. Temos, por exemplo, o nome do nosso tipo, que será produto. Em seguida, passamos o nome da variável, que chamaremos de item1.

Agora, vem a diferença entre tipos primitivos e tipos referenciados. No tipo primitivo, conseguimos passar um valor diretamente, mas o tipo referenciado contém várias informações. Não conseguimos passar esse valor de uma vez. Precisamos pedir à memória que reserve um espaço para guardar essas informações.

Para realizar essa tarefa, utilizaremos o new, Produto, abrindo e fechando parênteses. Com isso, já reservamos espaço na memória.

Produto item1 = new Produto();
Copiar código
Agora, podemos preencher esse espaço, atribuindo valores a cada uma das características definidas na classe. Por exemplo, utilizaremos item1.nome. Ao usar o ponto, acessamos a característica específica da classe. Assim, faremos item1.nome e atribuiremos "teclado". Para as demais características, seguiremos o mesmo procedimento.

item1.nome = "Teclado";
item1.descricao = "Modelo compacto e silencioso, " +
                  "perfeito para produtividade diária.";
item1.preco = 80.00m;
item1.estoque = 15;
Copiar código
Tornando as Propriedades Visíveis
Identificamos um problema: o nome não está visível. Para corrigir isso, utilizaremos na classe produto a palavra-chave public. Vamos compreender melhor esse conceito no curso de encapsulamento. Por ora, aplicamos essa palavra-chave e posteriormente entenderemos seu significado. Usamos public antes de cada característica da classe.

public string nome;
public string descricao;
public decimal preco;
public int estoque;
Copiar código
Agora, recompilamos o código e ele voltou a funcionar normalmente.

Imprimindo Dados do Objeto
Prosseguindo, vamos definir item1.descrição e atribuir a descrição do produto ao nosso item. Em seguida, item1.preço será 80.00m e, por fim, item1.estoque terá o valor 15.

Nosso objetivo é manter o comportamento anterior, que consiste em imprimir os dados de item1. Para isso, copiaremos o console.writeLine que está acima. Queremos que os dados sejam impressos, e para isso, utilizaremos o ponto novamente. Assim, usaremos item1.nome, item1.descrição, item1.preço e item1.estoque.

Console.WriteLine($@"Dados do item 1:
Nome: {item1.nome},
Descrição: {item1.descricao}
Preço: {item1.preco},
Estoque: {item1.estoque}
");
Copiar código
Após isso, podemos executar o código para verificar o resultado. Comentaremos o que está acima para não perdermos os dados. Executamos a aplicação e visualizamos os dados de item1 com todas as informações.

Conclusão e Próximos Passos
Verificamos que a criação da classe foi bem-sucedida. Observamos que cada informação está associada corretamente. O estoque 15 está associado ao nome "teclado", que também está associado ao preço e à descrição. Ao criar tipos, conseguimos agrupar todas essas informações.

Falando sobre a diferença entre classes e objetos, temos que uma classe é o modelo do tipo, descrevendo tudo que ele contém. Por exemplo, no caso de produto, dizemos que todo produto tem um nome, descrição, preço e estoque. Contudo, não há valores associados a esses dados. Para associar valores e criar diferentes produtos, criamos objetos. A partir do modelo, podemos criar vários itens com valores distintos. Um sinônimo para objetos é instância, ou seja, temos várias instâncias de um mesmo produto.

Diferenciando classes de objetos, podemos afirmar que, ao utilizá-los, trabalhamos com o paradigma de Programação Orientada a Objetos (POO). Nesse paradigma, focamos em criar classes para descrever diferentes tipos. A POO possui vários pilares: abstração, encapsulamento, herança e polimorfismo. Neste curso, abordaremos a abstração, que se concentra em representar informações do mundo real através da programação orientada a objetos. Na sequência, aprofundaremos esse tema e aprenderemos a estruturar nossas classes de forma mais eficiente. Nos vemos na próxima aula!

### Aula 1 - Atributos e métodos - Vídeo 3

Transcrição
Nós vimos que existem várias características em comum que podem ser agrupadas. Uma vez que agrupamos essas características, temos um tipo referenciado. Em C#, representamos esses tipos referenciados utilizando classes. Criamos uma classe para representar nosso produto e, dentro dessa classe, incluímos um nome, uma descrição, um preço e um estoque.

Estrutura Básica da Classe Produto
Para começar, vamos definir a estrutura básica da nossa classe Produto com seus atributos:

class Produto
{
    public string nome;
    public string descricao;
    public decimal preco;
    public int estoque;
}
Copiar código
Comportamentos Comuns dos Produtos
Além dessas características em comum, também temos comportamentos em comum. Por exemplo, para todo produto, podemos querer saber se ele está disponível ou não. Para determinar isso, precisamos verificar a característica estoque, observando se o estoque é maior do que zero. Podemos também trabalhar com o preço, aplicando um desconto que atualiza o valor. São várias operações em comum que ocorrem para todos os produtos, e conseguimos representar essas operações.

Implementação de Métodos na Classe Produto
As características do nosso produto se assemelham a variáveis, enquanto os comportamentos de um produto, representados dentro das classes, se assemelham a funções. Dentro da classe Produto, criaremos essas funções que serão comportamentos em comum. Para isso, declaramos um public, que será ignorado por enquanto, e o retorno da função, que será um bool. Criamos uma função para verificar se o estoque está disponível. Usamos o nome EstáDisponível e abrimos e fechamos parênteses. O nome da função na classe utiliza o método Pascal Casing, no qual a primeira letra e as letras de todas as outras palavras são maiúsculas. Dentro dos parênteses, poderíamos colocar parâmetros, mas não será o caso nesta primeira função. Dentro das chaves, passamos o corpo da função, que retornará se o estoque é maior do que zero. Assim, sabemos se o produto está disponível ou não.

Construção da Função EstaDisponivel
Vamos construir essa função passo a passo:

Primeiro, declaramos a função EstaDisponivel:

public bool EstaDisponivel()
{
}
Copiar código
Em seguida, implementamos a lógica para verificar se o estoque é maior que zero:

public bool EstaDisponivel()
{
    return estoque > 0;
}
Copiar código
Método para Aplicar Desconto no Preço
Agora, vamos criar uma nova função que representará a aplicação de um desconto no preço. Para isso, não teremos nenhum retorno, então usamos a palavra-chave void, que indica que o retorno é vazio. Criamos o método AlterarPrecoComDesconto. Abrimos os parênteses e, dentro deles, passamos um parâmetro que será um decimal desconto. Agora, podemos pensar no corpo da função novamente.

Para conseguirmos alterar o preço aplicando um desconto, precisamos utilizar uma variável da classe. Vamos definir que o preço será igual ao preço antigo multiplicado pelo valor com desconto. O valor com desconto será 1 menos o desconto. Dessa forma, temos dois comportamentos, ou seja, duas funções diferentes para a mesma classe.

Construção do Método AlterarPrecoComDesconto
Vamos construir o método AlterarPrecoComDesconto:

Primeiro, declaramos o método com o parâmetro desconto:

public void AlterarPrecoComDesconto(decimal desconto)
{
}
Copiar código
Em seguida, implementamos a lógica para aplicar o desconto ao preço:

public void AlterarPrecoComDesconto(decimal desconto)
{
    preco = preco * (1 - desconto);
}
Copiar código
Utilização dos Métodos no program.cs
Como utilizamos essas funções no program.cs? Utilizamos pontos, assim como fazemos com os atributos. Podemos, por exemplo, verificar se o item 1 está disponível ou não. Para isso, utilizamos item1.EstáDisponível. Aqui, estamos realizando uma verificação para obter um valor booleano. Se o item estiver disponível, exibiremos uma mensagem no console com Console.WriteLine informando que o produto está disponível. Corrigindo, a mensagem correta é "Produto está disponível".

Exemplo de Verificação de Disponibilidade
Vamos ver como isso é feito no código:

if(item1.EstaDisponivel())
{
    Console.WriteLine("Produto está disponível!");
}
Copiar código
Aplicação de Desconto e Impressão dos Dados
Além disso, podemos também alterar o preço do produto. Para isso, utilizamos item1.AlterarPrecoComDesconto, passando o valor do desconto. Suponhamos que utilizemos um desconto de 20%, então passamos 0.2m. Após isso, podemos imprimir novamente os dados do item. Utilizamos Ctrl+C e Ctrl+V para copiar e colar o código logo abaixo. Em seguida, executamos a aplicação.

item1.AlterarPrecoComDesconto(0.2m);

Console.WriteLine(@$"Dados do item 1:
Nome: {item1.nome};
Descrição: {item1.descricao};
Preço: {item1.preco};
Estoque: {item1.estoque};
");
Copiar código
Resultados e Conclusão
Ao executar, visualizamos os dados do item 1 anteriormente, com preço de R$ 80 e estoque de 15 unidades. Depois, imprimimos que o produto está disponível. Alteramos o código e, após aplicar o desconto, o preço passou a ser R$ 64. Dessa forma, verificamos que as funções da classe estão funcionando corretamente. Corrigimos o "S" em "disponível".

Assim, as funções e as variáveis ou características da classe estão funcionando corretamente. Utilizamos os termos variáveis ou características em comum, assim como funções ou comportamentos em comum. No entanto, a Programação Orientada a Objetos (P.O.) define termos específicos para isso. As características de uma classe são chamadas de atributos, e as funções de uma classe são chamadas de métodos.

Desafio da Abstração na Programação Orientada a Objetos
O grande desafio é escolher os melhores atributos e métodos para representar nossas classes. Esse desafio é a abstração, que consiste em pegar o que está no mundo real e transformar em código, escolhendo os melhores atributos, métodos e classes específicas que queremos modelar. Na sequência, teremos uma série de exercícios para praticar essa habilidade de representar elementos do mundo real na programação, utilizando a abstração.

### Aula 1 - Preparando o ambiente: instalando o Visual Studio
 Próxima Atividade

Olá!
O IDE do Visual Studio é uma plataforma de lançamento criativa que você pode usar para editar, depurar e criar código e, em seguida, publicar um aplicativo. Além do editor e depurador padrão fornecidos pela maioria dos IDEs, o Visual Studio inclui compiladores, ferramentas de conclusão de código, designers gráficos e muitos outros recursos para aprimorar o processo de desenvolvimento de software. O IDE mais abrangente para desenvolvedores .NET no Windows e Mac para criação de web, nuvem, desktop, aplicativos móveis, serviços e jogos.

Sabendo disso, preparamos alguns vídeos para instalar em diferentes sistemas operacionais. Para este curso em específico, marque a opção Desenvolvimento para Desktop com .NET. no processo de instalação.

Visual Studio no Windows

Visual Studio no Mac

C# no VSCODE (SDK)

C# em distribuições Linux
Neste link, você encontra um passo a passo da própria Microsoft de como instalar em distribuições Linux, como Alpine, CentOS, Debian, entre outras.

Vamos começar?

### Aula 1 -  Preparando o ambiente: material de apoio
 Próxima Atividade

Após revisar os conceitos de coleções em C#, é hora de colocar o conhecimento em prática com uma série de atividades focadas no tema. Caso queira acessar os slides da revisão, eles estão disponíveis no link abaixo:

Baixe os slides do curso
Top-level statements

A partir da versão 9.0 do C#, não é mais necessário escrever using System; ou criar uma classe Program com o método Main. Isso acontece graças ao recurso chamado top-level statements (ou instruções de nível superior), que permite eliminar a estrutura tradicional usada como ponto de entrada do programa. Antes, um aplicativo de console típico era escrito assim:

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
Copiar código
Com as instruções de nível superior, você pode simplificar e escrever apenas:

Console.WriteLine("Hello, World!");
Copiar código
Esse recurso pode te ajudar a deixar os exercícios mais simples e diretos, com foco na lógica e não na estrutura do programa. Após finalizar todos os desafios, não esqueça de compartilhar sua solução no fórum. Será incrível ver como você resolveu!

Vamos nessa?

### Aula 1 - Faça como eu fiz: cadastro de livros na biblioteca

Imagine que você está desenvolvendo uma aplicação para uma biblioteca que precisa cadastrar livros. Cada livro deve ter um título e um autor.

Crie uma classe chamada Livro que possua duas propriedades públicas: Titulo e Autor. Depois, crie um objeto dessa classe e preencha os dados com um título e autor de sua escolha e exiba a saída.

Exemplo de entrada:

meuLivro.Titulo = "Dom Casmurro";  
meuLivro.Autor = "Machado de Assis";  
Copiar código
Exemplo de saída:

Livro: Dom Casmurro
Autor: Machado de Assis
Copiar código

### Aula 1 -  - Vídeo 4
