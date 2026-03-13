# Curso Alura: C# consumindo API, gravando arquivos e utilizando o LINQ

## Aula 1: Integrando uma API externa

### Aula 1: Apresentação - Vídeo 1

Transcrição  
Guilherme: Queremos te dar as boas-vindas a esse curso de C#. Meu nome é Guilherme Lima e serei um dos instrutores desse curso.

Guilherme é um homem branco, de cabelo curto e barba castanhos, e olhos também castanhos. Usa óculos quadrados de armação preta e está com uma camisa verde com estampa na frente.

Estou nos estúdios da Alura em companhia do professor Daniel Portugal.

Daniel Portugal é um homem branco com cabelo e barba curtos e pretos. Tem olhos castanhos, usa óculos quadrados de armação preta e está de camisa preta com estampa na frente.

Daniel: Gui, o que vamos conhecer nesse curso?

**O que vamos aprender?**  
Guilherme: Nesse curso, vamos entender de forma prática como integrar uma aplicação em C# com uma API externa. Para isso, vamos aprender como funciona o HttpClient, uma importante biblioteca no C#.

Daniel: Também temos outros conteúdos interessantes. Por exemplo, para poder pegar essas fontes de informações, vamos conhecer sobre exceções.

Depois que tivermos essa coleção da API em memória, vamos começar a manipular essas coleções. Para isso, vamos usar uma biblioteca importante no desenvolvimento .NET, o LINQ.

Com isso, vamos aprender a ordenar, filtrar e mapear para outros elementos.

Guilherme: Além disso, vamos aprender como gerar e consumir arquivos em C#.

Daniel: É um processo de serialização e desserialização.

Guilherme: Tudo isso de forma prática, seguindo boas convenções da linguagem em um projeto muito interessante. Espero você lá!

### Aula 1: Realizando uma requisição - Vídeo 2

Transcrição  
Para acessar os dados dessa API, vamos acessar o [GitHub da API de músicas](https://github.com/guilhermeonrails/api-csharp-songs/tree/main) e clicar no link para acessar o [arquivo songs.json](https://guilhermeonrails.github.io/api-csharp-songs/songs.json).

Guilherme: Algo muito comum no desenvolvimento de software é integrar a aplicação que estamos desenvolvendo com outro sistema. Pensando nisso, criamos uma API com diversas músicas aleatórias e queremos integrá-la no projeto.

```json
[
    {
        "artist": "The Chainsmokers",
        "song": "#SELFIE - Original Mix",
        "duration_ms": 183750,
        "explicit": "False",
        "year": "2014",
        "popularity": "0",
        "danceability": "0.789",
        "energy": "0.915",
        "key": 0,
        "loudness": "-3.263",
        "mode": "1",
        "speechiness": "0.248",
        "acousticness": "0.0135",
        "instrumentalness": "8.77e-06",
        "liveness": "0.0818",
        "valence": "0.66",
        "tempo": "127.955",
        "genre": "pop, Dance/Electronic"
    },

(restante omitido …)
```

Nesse documento, temos uma lista já que começa com colchetes. Cada par de chaves contém as informações de uma música.

Por exemplo, a primeira música é do The Chainsmokers, a segunda do will.i.am., a terceira do Eminem e assim por diante. São várias músicas com diversos campos e propriedades diferentes.

O nosso desafio é acessar o endereço desse arquivo que chamamos de endpoint e pegar todas essas músicas e trazer para a nossa aplicação.

Por isso, vamos utilizar a ideia de cliente e servidor.

Esquema de requisição. Do lado direito, ícone de computador com a inscrição "Client". Do lado esquerdo, ícone de banco de dados com a inscrição "Server". Uma seta com a inscrição "Request HTTP" sai de cliente e vai para servidor. Uma seta com a inscrição "Response" sai de server e vai para client.

Quando clicamos no link, fizemos uma requisição. É como se tivéssemos falado "queremos visualizar as músicas dessa API".

Foi feita uma requisição (request) para um determinado servidor (server). Não sabemos em que linguagem foi feita essa API, como foram dispostos os dados, se tem classes ou orientação a objetos. Mas, o servidor devolveu uma resposta (response). Ele respondeu "estão aqui as músicas que você quer".

Vamos precisar pensar nesse mesmo conceito agora do lado do C#.

Daniel: Esse cliente (client) que mostramos está no navegador. Agora, queremos fazer um cliente em um programa C#.

**Cliente no C#**  
Guilherme: Vamos abrir o Microsoft Visual Studio e clicar "Criar um projeto" para criar um novo projeto com o modelo "Aplicativo de Console".

Vamos chamá-lo de ScreenSound-04 e clicar em "Próximo". Vamos usar a estrutura ".NET 6.0 (Suporte de Longo Prazo)" e clicar em "Criar". Agora, podemos começar a desenvolver nosso projeto.

Já que é algo tão comum realizar requisições para APIs externas, pegar os dados e trabalhar naqueles dados no nosso sistema usando HTTP, provavelmente deve existir uma biblioteca, um tipo responsável para nos auxiliar nesse tarefa.

Por isso, na primeira linha do arquivo, vamos escrever a palavra using e abrir e fechar parênteses. O tipo que vamos utilizar será o HttpClient.

A IDE até dá uma sugestão de autocomplete de HttpClient client = new HttpClient(). Geralmente, por convenção, chamamos a variável do tipo HttpClient de client (cliente). Após fechar os parênteses do using, abrimos chaves.

Um ponto diferente é que não colocamos ponto e vírgula ao final da linha em que declaramos a variável HttpClient client. Significa que vamos usar esse módulo somente dentro do using.

Program.cs:

```csharp
using (HttpClient client = new HttpClient())
{
}
```

Por que fazemos isso?

Daniel: É importante destacar que já conhecemos a palavra reservada using, porém, em outro contexto. Já a usamos para abreviar o nome de um tipo.

Ou seja, se temos um tipo que está dentro de um namespace, podemos escrever o nome completo desse tipo ou colocar o using no início do documento para criar o objeto e economizar na escrita.

Enquanto o using atual tem um contexto de gerenciar os recursos entre suas chaves. Quando a chave fechar, vamos liberar esse recurso que é o objeto client.

Guilherme: O que vamos fazer primeiro?

Se observamos o JSON de músicas, o conteúdo era do tipo string. Por exemplo, tanto artista quanto o nome da música estavam entre aspas duplas. A primeira ideia que podemos escrever é que a resposta que vamos receber também vai ser do tipo string.

Por isso, dentro do using, vamos criar uma string chamada de resposta que vai ser igual à variável client seguida de um ponto para poder acessar alguns métodos desse objeto.

Dentre os métodos sugeridos, vamos colocar o GetStringAsync() para pegar os dados em um formato string de forma assíncrona. Nesse caso, vamos utilizar o async porque não sabemos de fato quantas músicas e qual o tamanho do recurso que vamos receber.

Queremos garantir que vamos conseguir receber todos esses recursos. Se colocamos sem o async, pode ser ele receba apenas uma parte e passe para a próxima instrução. Não é isso que queremos.

```csharp
using (HttpClient client = new HttpClient())
{
    string resposta = client.GetStringAsync()
}
```

Daniel: É uma convenção ter nome de métodos que terminam com async para indicar que esse método é assíncrono.

Guilherme: O que vamos fazer é passar o endereço do endpoint entre aspas duplas para o método GetStringAsync(). Fora dos parênteses, colocamos um ponto e vírgula.

O trecho de código após o sinal de igual fica sublinhado em vermelho e com uma mensagem, porque o GetStringAsync() não consegue converter um tipo task em string.

O que precisamos fazer? Precisamos usar o await antes de client.GetStringAsync() para sinalizar que o código espere de fato a tarefa ser concluída para depois pegar o resultado e colocar na variável.

Para visualizar a resposta no console, vamos digitar Console.WriteLine(resposta) em uma nova linha.

```csharp
using (HttpClient client = new HttpClient())
{
    string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
    Console.WriteLine(resposta);
}
```

Vamos executar o nosso código ao apertar o botão "Iniciar Sem Depurar" na barra de ferramentas (ou atalho "Ctrl + F5"). Com isso, abre um console de depuração com o JSON.

Parece que deu certo, temos várias músicas. Mas, ainda nem sabemos quantas músicas têm nessa API ou quais tipos de músicas temos. Precisamos conseguir trabalhar e manipular esses dados de uma forma melhor.

Daniel: Mas, já conseguimos criar um cliente no C#.

### Aula 1: Try Catch - Vídeo 3

Transcrição  
Daniel: Fizemos um cliente e já retornamos no console a mesma resposta que estava no navegador. Mas, o que acontece se houver algum problema? Por exemplo, se a conexão não estiver funcionando, tiver sem internet ou o endpoint tiver mudado?

Guilherme: Para conferir, vamos retirar a letra "N" do endereço do JSON.

Program.cs:

```csharp
using (HttpClient client = new HttpClient())
{
    string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.jso");
    Console.WriteLine(resposta);
}
```

Unhandled exception. System.Net.Http.HttpRequestException: Response status code does not indicate success: 404 (Not Found).

Após executar, a nossa aplicação dá um erro e para. Isso não é algo bom, porque não queremos que a aplicação pare.

Existe uma forma de tentar fazer a requisição e, caso contrário, exibir uma mensagem e talvez criar um segundo caminho. Por exemplo, se já temos da API cadastradas, podemos mostrá-los ou pensar em outra abordagem.

Daniel: O caminho correto é essa tentativa, mas tem um segundo caminho possível quando a exceção acontecer.

**Lidando com exceções com try-catch**  
Guilherme: Não queremos que o programa pare quando dá algo errado. Queremos receber uma mensagem avisando sobre o erro e fornecer um segundo caminho.

Para isso, podemos usar a propriedade try que vai tentar fazer o código em seu corpo. Vamos recortar com "Ctrl + X" desde string resposta até Console.WriteLine() para colá-lo dentro do bloco try.

```csharp
using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.jso");
        Console.WriteLine(resposta);
    }
}
```

Atenção: Usamos o word wrap para quebrar linhas no documento.

Após o try, vamos lançar uma exceção com catch (Exception ex). Assim, caso não consigamos realizar a tentativa de requisição, vamos exibir uma mensagem.

Entre as chaves, vamos apertar "Enter" para aceitar a sugestão do código Console.WriteLine(ex). Mas, podemos melhorar essa mensagem com uma interpolação de string.

Para isso, em Console.WriteLine(), digitamos o cifrão seguido da string Temos um problema: e, entre chaves, ex.Message. Assim, usamos o nome da requisição ex e uma mensagem informando de fato qual erro aconteceu.

Daniel: A Message é uma propriedade que existe dentro do tipo exception.

```csharp
using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.jso");
        Console.WriteLine(resposta);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}
```

Guilherme: Como o endereço da API ainda está errada, sem o "N" no JSON, vamos cair em uma exceção ao executar o código. Não vai ser possível pegar a resposta que esperamos.

Temos um problema: Response status code does not indicate success: 404 (Not Found).

Após executar, a resposta já mudou e nos é informado que o status code não indicou sucesso. Recebemos um 404.

Cada requisição que fazemos temos um código de resposta. Vamos deixar uma atividade de "Para Saber Mais" para você conhecer sobre esses códigos.

Não é preciso memorizar todos esses códigos, mas é importante entender do que se trata cada faixa. Por exemplo, faixa de sucesso de 200 a 299 ou faixa de erro no servidor entre 500 e 599.

Agora, vamos consertar o endereço, colocando o "N" em JSON.

```csharp
using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        Console.WriteLine(resposta);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}
```

Após executar continuamos a receber todos os dados feitos com sucesso.

Daniel: Agora temos o caminho "feliz" com o try e o caminho da exceção com o catch, onde capturamos a exceção para fazer o que quisermos com ela.

Nesse caso, apenas escrevemos essa exceção no console.

Guilherme: Fizemos questão de mostrar o try e o catch, porque endereços de API mudam.

Por exemplo, se a API mudar para uma segunda versão, vai acrescentar um v2/ na URL. Com isso, o endereço antigo não funciona mais. Precisamos pensar nessas possibilidades.

O código sempre vai passar por alterações e atualizações. Por isso, criamos um try para fazer o caminho desejado e o catch para caso haja um problema com o primeiro caminho.

Nesse momento, não vamos dar ênfase no catch. Contudo, no mundo real pode acontecer de ter uma base local para mostrar algumas músicas, por exemplo.

Daniel: É importante saber e conhecer esse tipo de código try-catch para lidar com exceções.

### Aula 1: Divisão por zero - Exercício

O bloco try-catch é essencial para lidar com erros em um programa. Ele protege o código que pode gerar problemas, permitindo capturar e tratar as exceções que ocorrem. Sem o try-catch, o programa poderia travar e mostrar mensagens de erro confusas para o usuário, deixando o programa em um estado ruim.

Assim como vimos em aula, observe este exemplo prático do uso de try-catch:

```csharp
try
{
    for (int i = 3; i >= 0; i--)
    {
        Console.WriteLine($"{ 10/i}");
    }
}
catch (Exception ex)
{
    Console.WriteLine($"Tivemos um problema: {ex.Message}");
}
```

Com base nas informações do enunciado e no código acima, analise as afirmações abaixo e marque apenas as verdadeiras.

**Alternativa correta**  
Ocorrerá uma exceção durante a execução do loop quando o valor de i atingir o valor 0.

> Isso aí! Quando for igual a zero, ocorrerá a exceção e o programa será desviado para o bloco catch. Isso ocorre porque a divisão por zero é uma operação inválida e resultará em uma exceção DivideByZeroException.

**Alternativa correta**  
Os valores 3, 5 e 10 serão exibidos no console.

> Isso aí! Os números 3, 5 e 10 serão impressos antes da exceção ser lançada, já que as divisões por 3, 2 e 1 são válidas.

### Aula 1: Para saber mais: Status Code

Status code no HTTP é um código numérico retornado pelo servidor para indicar o resultado de uma requisição feita pelo cliente. Alguns exemplos são:

|Código|Descrição                                       |
|------|------------------------------------------------|
|200   |OK - Requisição bem-sucedida                    |
|201   |Created - Recurso criado com sucesso            |
|204   |No Content - Sem conteúdo para retornar         |
|400   |Bad Request - Requisição inválida               |
|401   |Unauthorized - Não autorizado                   |
|403   |Forbidden - Acesso proibido                     |
|404   |Not Found - Recurso não encontrado              |
|500   |Internal Server Error - Erro interno do servidor|
|502   |Bad Gateway - Gateway inválido                  |
|503   |Service Unavailable - Serviço indisponível      |

Memorizar todos os códigos de status HTTP não é estritamente necessário, mas é útil ter conhecimento dos códigos mais comuns e entender o significado deles para lidar adequadamente com as respostas de uma API.

Para saber mais sobre isso, recomendamos essa leitura: [Códigos de status de respostas HTTP do Mozila](https://developer.mozilla.org/pt-BR/docs/Web/HTTP/Status).

### Aula 1: Desafio: hora da prática

A prática é um elemento essencial ao iniciar os estudos em programação, pois é por meio da aplicação prática dos conceitos teóricos que se solidificam os conhecimentos. Ao escrever código, resolver problemas e construir projetos reais, os iniciantes não apenas internalizam a sintaxe das linguagens de programação, mas também desenvolvem a habilidade de pensar logicamente e abordar desafios de maneira eficiente.

Pensando nisso, criamos uma lista de atividades (não obrigatórias) focada em prática para melhorar ainda mais sua experiência de aprendizagem. Bora praticar, então?

1. Escrever um programa que faça uma requisição para a API de games CheapShark e mostre na tela a lista de promoções cadastrada na ferramenta (Você pode utilizar o endpoint: https://www.cheapshark.com/api/1.0/deals).

2. Escrever um programa que solicite dois números a e b lidos do teclado e realize a divisão de a por b. Caso essa operação não seja possível, mostrar uma mensagem no console que deixe claro o erro ocorrido.

3. Declarar uma lista de inteiros e tente acessar um elemento em um índice inexistente. Tratar a exceção apropriada.

4. Criar uma classe simples com um método e chame esse método em um objeto nulo. Tratar a exceção de método em objeto nulo.

Opinião do instrutor

Para te ajudar a verificar seus códigos, disponibilizamos uma lista com as [possíveis soluções no Github](https://github.com/ArthurOcFernandes/Exerc-cios-C-/tree/curso-4-aula-1).

Boa sorte nos estudos!

### Aula 1: Faça como eu fiz: a importância das classes

Como desenvolvedor experiente, posso dizer que saber trabalhar com APIs, requisições, respostas e manipulação de dados é essencial para uma carreira bem-sucedida na área de desenvolvimento. Aqui estão algumas razões pelas quais essas habilidades são tão importantes:

Integração de sistemas: As APIs (Application Programming Interfaces) são utilizadas para permitir a comunicação entre diferentes sistemas e aplicativos. Ao saber trabalhar com APIs, você será capaz de integrar seus aplicativos com serviços externos, como redes sociais, sistemas de pagamento, serviços de armazenamento em nuvem, entre outros. Isso permite que você desenvolva soluções mais robustas e com maior funcionalidade.

Reutilização de código: APIs bem projetadas seguem princípios de modularidade e encapsulamento, permitindo que você reutilize código e evite a duplicação de esforços.

Acesso a dados e serviços externos: Muitas vezes, você precisará acessar dados ou serviços externos em seus aplicativos.

Agora é a sua vez! Neste link, existe uma série de APIs públicas e seu desafio é realizar uma requisição e exibir os dados no console.

Opinião do instrutor

Segue um exemplo do uso da [Game Of Thrones API](https://anapioficeandfire.com/) com recursos de um dos personagens da série com o ID igual a 583. O objetivo é realizar uma requisição e ter os seguintes recursos:

> https://anapioficeandfire.com/api/characters/583

O resultado da requisição é:

> {"url":"https://anapioficeandfire.com/api/characters/583","name":"Jon Snow","gender":"Male","culture":"Northmen","born":"In 283 AC","died":"","titles":["Lord Commander of the Night's Watch"],"aliases":["Lord Snow","Ned Stark's Bastard","The Snow of Winterfell","The Crow-Come-Over","The 998th Lord Commander of the Night's Watch","The Bastard of Winterfell","The Black Bastard of the Wall","Lord Crow"],"father":"","mother":"","spouse":"","allegiances":["https://anapioficeandfire.com/api/houses/362"],"books":["https://anapioficeandfire.com/api/books/5"],"povBooks":["https://anapioficeandfire.com/api/books/1","https://anapioficeandfire.com/api/books/2","https://anapioficeandfire.com/api/books/3","https://anapioficeandfire.com/api/books/8"],"tvSeries":["Season 1","Season 2","Season 3","Season 4","Season 5","Season 6"],"playedBy":["Kit Harington"]}

Podemos realizar requisição com o seguinte código:

```csharp
using (HttpClient client = new HttpClient())
{
    string resposta = await client.GetStringAsync("https://anapioficeandfire.com/api/characters/583");
    Console.WriteLine(resposta);
}
```

Agora temos a resposta da requisição no console do nosso programa. Realizar requisições é importante para obter dados de fontes externas, como APIs, permitindo a integração de informações atualizadas e dinâmicas em um programa.

## Aula 2: Linq e ordenação

### Aula 2: Projeto da aula anterior

Aqui você pode [baixar o zip da Aula 01](https://github.com/alura-cursos/ScreenSound/archive/refs/heads/aula-1.zip) ou acessar os [arquivos no Github!](https://github.com/alura-cursos/ScreenSound/tree/aula-1)

### Aula 2: Modelo de música - Vídeo 1

Transcrição  
Guilherme: Conseguimos capturar as respostas que contêm os dados desejados. No entanto, notamos que todas as respostas são do tipo string, como pode ser visto no trecho de código a seguir:

Program.cs

```csharp
using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        Console.WriteLine(resposta);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}
```

Essa situação se torna complicada, uma vez que, supondo que precisemos manipular essa string como texto, torna-se bastante desafiador.

Endereço da API do instrutor:

```csharp
guilhermeonrails.github.io/api-csharp-songs/songs.json
```

Ao analisarmos a API, seria interessante extrair campos como o nome do artista ou da música, para que possamos utilizar esses dados e solicitá-los a apontar para uma classe específica.

Daniel: Existe uma estrutura na resposta, então podemos estruturar o código.

**Criando a classe Musica**  
Guilherme: No VS Code, vamos clicar no menu superior e selecionar as opções "Exibir > Gerenciador de soluções". Na janela exibida à direita, iremos criar uma nova pasta chamada Modelos. Isso nos permitirá criar a classe que fará referência a essa resposta e, assim, seremos capazes de manipulá-la adequadamente.

Daniel: Para cada elemento da coleção, certo?

Guilherme: Isso mesmo.

Clicamos com o botão direito em "ScreenSound-04" e escolhemos as opções "Adicionar > Nova pasta". Digitamos o nome da pasta como "Modelos". Dentro dessa pasta, criamos uma classe chamada Musica. Para isso, clicamos com o botão direito em Modelos e escolhemos as opções "Adicionar > Classe". Na janela seguinte, selecionamos a opção "Arquivo de Código" e, em seguida, clicamos no botão "Adicionar" localizado no canto inferior direito.

Musica.cs

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound_04.Modelos
{
        internal class Musica
        {
        }
}
```

Podemos remover todos os using, dado que não estamos usando e inserir ; no final no namespace.

Musica.cs

```csharp
namespace ScreenSound_04.Modelos;

internal class Musica
{
}
```

Agora, enfrentamos um desafio: quais campos precisamos serializar?

JSON da API

```json
[
    {
        "artist": "The Chainsmokers",
        "song": "#SELFIE - Original Mix",
        "duration_ms": 183750,
        "explicit": "False",
        "year": "2014",
        "popularity": "0",
        "danceability": "0.789",
        "energy": "0.915",
        "key": 0,
        "loudness": "-3.263",
        "mode": "1",
        "speechiness": "0.248",
        "acousticness": "0.0135",
        "instrumentalness": "8.77e-06",
        "liveness": "0.0818",
        "valence": "0.66",
        "tempo": "127.955",
        "genre": "pop, Dance/Electronic"
    },
(restante omitido …)
```

Isso é bem comum, dado que não é obrigatório utilizar todos os dados ao recebermos uma API. Por uma questão de otimização de tempo, não incluiremos todos os campos. Sugerimos selecionar quatro campos, sendo:

artist  
song  
duration_ms  
genre

A pergunta é: ao montarmos a classe, qual nome devemos atribuir para apontar cada uma dessas propriedades?

Daniel: Por enquanto acho que vamos usar o mesmo nome que consta na API.

Guilherme: Isso é uma boa prática?

Daniel: Não, outra situação comum na carreira de pessoas desenvolvedoras é a necessidade de traduzir uma estrutura de dados para outra. Pode ser para alterar a hierarquia ou tradução mesmo.

Guilherme: Para criar o primeiro campo Nome (nome da música), utilizamos a sintaxe public string Nome {}. No entanto, é importante ressaltar que esse campo não está disponível na API.

Existe uma maneira de especificar que a propriedade "Nome" será associada a um campo específico no JSON. É possível utilizar atributos de serialização, como o atributo [JsonProperty], para indicar o nome do campo correspondente no JSON.

Para realizar essa associação, utilizamos o atributo [JsonPropertyName] acima da propriedade Nome. Em seguida, pressionamos "Enter" e inserimos entre parênteses o nome do campo que desejamos utilizar, no caso: ("song").

Musica.cs

```csharp
using System.Text.Json.Serialization;

namespace ScreenSound_04.Modelos;

internal class Musica
{
        [JsonPropertyName("song")]
        public string Nome { get; set;}
}
```

Dessa forma, a propriedade Nome será mapeada para o campo song no JSON.

Daniel: Vamos incluir uma atividade que forneça uma explicação mais detalhada sobre o assunto. Em resumo, o atributo utilizado, como o [JsonPropertyName], é responsável por adicionar metadados específicos à propriedade Nome.

Esses metadados auxiliam na serialização e desserialização de objetos JSON, permitindo a associação adequada entre as propriedades e os campos correspondentes.

Guilherme: Exatamente.

Aplicaremos a mesma lógica para os demais campos e propriedades que iremos inserir no código:

Os pontos de interrogação indicam que o campo pode ser nulo, por exemplo: public string? Nome { get; set;}.

Musica.cs

```csharp
using System.Text.Json.Serialization;

namespace ScreenSound_04.Modelos;

internal class Musica
{
        [JsonPropertyName("song")]
        public string? Nome { get; set;}

        [JsonPropertyName("artist")]
        public string? Artista { get; set; }
}
```

Estamos traduzindo as propriedades.

Daniel: O atributo em C# é análogo à anotação em outras linguagens, como Java. Em Java, a sintaxe utiliza o símbolo "@" seguido do nome da anotação, enquanto em C# utilizamos colchetes para definir o atributo.

Apesar dessa diferença na sintaxe, ambos os conceitos têm o mesmo propósito, que é adicionar metadados ou informações adicionais a um elemento do código. No caso específico do C#, o uso de colchetes para definir atributos é uma convenção adotada pela linguagem.

Guilherme: Interessante, Daniel.

Vamos fazer para os outros dois campos:

Musica.cs

```csharp
using System.Text.Json.Serialization;

namespace ScreenSound_04.Modelos;

internal class Musica
{
        [JsonPropertyName("song")]
        public string? Nome { get; set;}

        [JsonPropertyName("artist")]
        public string? Artista { get; set; }
        
        [JsonPropertyName("duration_ms")]
        public int Duracao { get; set; }
        
        [JsonPropertyName("genre")]
        public string? Genero { get; set; }
}
```

Para finalizar, vamos criar um método apenas para exibir as informações.

Criaremos um método público chamado ExibirDetalhesDaMusica(), sem valor de retorno e sem parâmetros. Dentro do corpo do método, utilizaremos o Console.WriteLine() para exibir os respectivos campos:

Musica.cs

```csharp
using System.Text.Json.Serialization;

namespace ScreenSound_04.Modelos;

internal class Musica
{
        [JsonPropertyName("song")]
        public string? Nome { get; set;}

        [JsonPropertyName("artist")]
        public string? Artista { get; set; }
        
        [JsonPropertyName("duration_ms")]
        public int Duracao { get; set; }
        
        [JsonPropertyName("genre")]
        public string? Genero { get; set; }
        
    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Música: {Nome}");
        Console.WriteLine($"Duração em segundos: {Duracao / 1000}");
        Console.WriteLine($"Gênero musical: {Genero}");
        }
}
```

Para exibir a duração em segundos, considerando que a unidade de medida esteja em milissegundos (ms), podemos realizar o cálculo Duracao / 1000 para converter para segundos.

Conclusão  
Para criar uma lista de músicas com base na resposta desse trecho de código, é necessário realizar algumas etapas adicionais no arquivo Program.cs.

Faremos isso no próximo vídeo. Até mais!

### Aula 2: Deserializando os dados - Vídeo 2

Transcrição  
Daniel: Criamos a classe e a estrutura, utilizando o JsonProperty para realizar a tradução dos campos. Agora, necessitamos que a partir desta string resposta seja exibida uma lista de músicas. É isso mesmo, Gui?

Guilherme: Isso mesmo, Daniel. Vamos capturar o JSON e informar para qual classe ele irá apontar. Dessa forma, obtemos um objeto com a lista criada.

Daniel: O bom é que sabemos quantas músicas irão retornar.

Guilherme: Primeiramente, no arquivo Program.cs, vamos criar uma variável sem especificar o tipo. Para isso, utilizamos a declaração var musicas =. Essa variável irá armazenar o JSON que será obtido a partir da resposta capturada.

Vamos informar que desejamos criar uma lista dessa resposta em JSON, ou seja, baseado nesse objeto. Para tal, usamos a propriedade JsonSerializer do tipo System.Text.Json após o console da resposta.

Há alguns anos, existia uma biblioteca em C# chamada Newtonsoft, cujos recursos foram incorporados ao System.Text.Json. Inclusive, o using System.Text.Json aparece na parte superior do arquivo.

Program.cs

```csharp
using System.Text.Json;
using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        Console.WriteLine(resposta);
                var musicas = JsonSerializer.
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}
```

O que desejamos fazer agora é uma desserialização. Portanto, após o JsonSerializer, escrevemos Deserialize. Aqui vamos informar para que o JSON seja capturado e convertido em um objeto manipulável no C#.

Essa é uma prática comum em todas as linguagens de programação: recebemos um JSON e precisamos manipular suas variáveis, convertendo-o para o tipo de dados usado na linguagem em que estamos trabalhando. O processo de transformação do JSON para a linguagem chamamos de desserialização.

Desserialização é o processo de converter dados serializados, como JSON, em objetos ou estruturas de dados utilizáveis em uma linguagem de programação específica.

Continuando, a função Deserialize retornará uma lista, então passamos uma lista de músicas: `<List<Musica>>`. Em seguida, fornecemos a string `<resposta>` como entrada para o processo de desserialização.

Program.cs

```csharp
using System.Text.Json;
using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        Console.WriteLine(resposta);
                var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}
```

Daniel: No caso do método estático Deserialize para JSON, não é necessário criar uma instância, mas sim utilizá-lo diretamente. Em vez de instanciar, chamamos o método estático Deserialize para realizar a operação de desserialização do JSON.

Guilherme: Não precisamos criar um new JSON Deserialize. Observem que o `<Musica>` está com um sublinhado na cor vermelha, passando o mouse por cima, obtemos a seguinte mensagem:

CS0246: O nome do tipo ou do namespace "Musica" não pode ser encontrado (esta faltando uma diretiva using ou uma referência de assembly?)

Vamos clicar no ícone de lâmpada do lado esquerdo da linha, será exibido um menu flutuante e vamos clicar em "using ScreenSound_04.Modelos". No topo no arquivo temos a importação: using ScreenSound_04.Modelos;, e o erro não consta mais. Para determinar o número de músicas na API, podemos utilizar o método Console.WriteLine() passando musicas.Count. De fato, se a lista de músicas é um objeto manipulável, ela terá a propriedade Count, que nos fornecerá a quantidade de músicas presentes na lista.

Program.cs

```csharp
using ScreenSound_04.Modelos;
using System.Text.Json;
using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        Console.WriteLine(resposta);
                var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta);
                Console.WriteLine(musicas.Count);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}
```

Vamos executar clicando no botão ":arrow_forward:" e como retorno, obtemos:

O retorno abaixo foi parcialmente transcrito. Para conferi-lo na íntegra, execute o código na sua máquina.

```csharp
{
    "artist":"Post Malone", 
    "song": "Circles",
    "duration_ms": 215280,
    "explicit": "False", "year": "2019",
    "popularity": "85",
    "danceability": "0.695",
    "energy": "0.762",
    "key": 0,
    "Loudness":"-3.497",
    "mode": "1",
    "speechiness": "0.0395",
    "acousticness": "0.192",
    "instrumentalness": "0.00244",
    "Liveness": "0.0863",
    "valence": "0.553",
    "tempo": "120.042"
    "genre": "hip hop"
}
```

Temos 1999 músicas, interessante. Podemos remover tanto o resposta quanto a propriedade Count. Agora, vamos exibir os detalhes de uma música. Para fazer isso, criamos o método ExibirDetalhesDaMusica() no arquivo Musica.cs. Em seguida, de forma aleatória, se tivermos uma lista de músicas, podemos utilizar o índice 0 para exibir os detalhes dessa música: musicas[0].ExibirDetalhesDaMusica();.

Program.cs

```csharp
using ScreenSound_04.Modelos;
using System.Text.Json;
using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
                var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta);
                musicas[0].ExibirDetalhesDaMusica();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}
```

Clicamos no botão ":arrow_forward:" e obtemos:

Artista: The Chainsmokers

Música: #SELFIE Original Mix

Duração em segundos: 183

Gênero musical: pop, Dance/Electronic

Vamos alterar o índice para 1998 (dado que começa no índice zero): musicas[1998].ExibirDetalhesDaMusica();. Clicamos em ":arrow_forward:" e obtemos:

Artista: Post Malone

Música: Circles

Duração em segundos: 215

Gênero musical: hip hop

Daniel: Estamos realizando testes na tradução que fizemos, em que o campo artist foi transformado em Artista, song virou Nome, duration_ms se tornou Duração e genre foi traduzido para gênero. Até o momento, tudo está funcionando conforme o esperado.

Guilherme: Observem que o musicas[] está com um sublinhado, passando o mouse por cima, temos a seguinte mensagem:

(variável local) List`<Musica>` ? musicas

'musicas' pode ser nulo aqui.

CS8602: Desreferência de uma referência possivelmente nula.

É comunicado que a lista de músicas pode ser nula. Para garantir que não seja nula, adicionamos um sinal de exclamação após a resposta da lista de músicas. Dessa forma, ao realizar o parsing, precisamos de uma classe que não seja nula para receber os dados.

```csharp
var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
```

Observem que não temos mais o erro.

Conclusão  
Guilherme: Agora, após concluirmos a desserialização dos dados em uma classe, temos uma base de dados contendo 1999 músicas. Além disso, implementamos um método que nos permite exibir os detalhes de cada música. Com isso, estamos prontos para acessar e visualizar as informações detalhadas das músicas presentes na base de dados.

### Aula 2: Desafios - Vídeo 3

Transcrição  
Daniel: Já possuímos uma lista de músicas e estamos prontos para manipulá-la.

Desafio

Exibir todos os gêneros musicais da lista;

Ordenar os artistas por nome;

Filtrar artistas por gênero musical;

Filtrar as músicas de um artista.

Recebemos um desafio que será comum no dia-a-dia de uma pessoa desenvolvedora: lidar com uma demanda que envolve trabalhar com uma coleção de dados. Primeiro, será necessário exibir todos os gêneros musicais da lista, algo que não é realizado de forma tão fácil e rápida.

Em seguida, é preciso ordenar os artistas por nome, podendo ser em ordem crescente ou decrescente, seguindo a ordem alfabética. Depois disso, será feita a filtragem dos artistas por gênero musical e também das músicas de um determinado artista.

Guilherme: Manualmente, de fato, esses processos podem ser complicados, mesmo com apenas 1999 dados. No entanto, ao transformarmos a lista em uma classe, será possível utilizar os recursos do C# para exibir as músicas de um gênero específico ou de um determinado artista. Dessa forma, encontraremos uma maneira de realizar essas operações de forma mais eficiente e automatizada.

Daniel: De fato, utilizando um loop foreach na lista e aplicando uma estrutura condicional if(), podemos realizar algumas operações básicas. No entanto, é importante destacar que nem todos os desafios podem ser resolvidos dessa forma.

Guilherme: Nas equipes de pessoas desenvolvedoras, é comum que as pessoas responsáveis pelo desenvolvimento backend, como em C#, lidem com a lógica de negócios, manipulação e entrega dos dados.

Nesse contexto, a exibição dos gêneros musicais da lista pode não ser uma informação relevante para a lógica de backend em si, mas pode ser importante para a equipe de front-end, que utilizará esses dados para a construção da interface do usuário.

Na interface do usuário, é possível implementar recursos como a ordenação dos dados por gênero musical, a filtragem por artista e outros recursos interativos, como as setas para cima e para baixo para alterar a ordem de classificação.

Na interface, é possível listar e mencionar os diferentes gêneros musicais, como Jazz, Rock, Pop e outros, de forma interativa. As pessoas usuárias poderão clicar em um determinado gênero musical e visualizar os artistas associados a ele.

Precisamos garantir que as informações e métodos necessários estejam disponíveis para o front-end, de modo a assegurar a entrega dos dados quando necessário.

Faremos isso na próxima aula!

### Aula 2: Gryffindor - Execício

Uma pessoa que estava estudando C#, resolveu realizar uma requisição para uma API que contém recursos relacionados aos personagens da casa Gryffindor, da série Harry Potter, no seguinte endpoint:

```csharp
https://hp-api.onrender.com/api/characters/house/gryffindor
```

Para isso, ela desenvolveu o seguinte código:

```csharp
using (HttpClient client = new HttpClient())
{
    string json = await client.GetStringAsync("https://hp-api.onrender.com/api/characters/house/gryffindor");
    // código restante omitido…
}
```

Com base nas informações acima e no código desenvolvido, analise as afirmações abaixo e marque apenas as verdadeiras.

**Alternativa correta**  
O HttpClient é uma classe na biblioteca padrão do .NET que fornece um cliente HTTP para enviar e receber requisições e respostas HTTP.

> Isso aí! O HttpClient oferece recursos poderosos e flexíveis para trabalhar com requisições e respostas HTTP. Ele permite especificar cabeçalhos personalizados, enviar e receber dados em formato JSON, lidar com autenticação, definir timeouts e muito mais. Além disso, o HttpClient é projetado para suportar operações assíncronas, o que é crucial para manter a responsividade e a eficiência em aplicativos modernos.

**Alternativa correta**  
O GetStringAsync é um método assíncrono que faz uma requisição HTTP GET para um determinado URI e retorna a resposta como uma string.

> Isso aí! O método GetStringAsync nesse caso está sendo usado para obter o conteúdo de uma página ou serviço web como uma string no formato JSON.

### Aula 2: Desafio: hora da prática

A prática é um elemento essencial ao iniciar os estudos em programação, pois é por meio da aplicação prática dos conceitos teóricos que se solidificam os conhecimentos. Ao escrever código, resolver problemas e construir projetos reais, os iniciantes não apenas internalizam a sintaxe das linguagens de programação, mas também desenvolvem a habilidade de pensar logicamente e abordar desafios de maneira eficiente.

Pensando nisso, criamos uma lista de atividades (não obrigatórias) focada em prática para melhorar ainda mais sua experiência de aprendizagem. Bora praticar, então?

1. Modelar e desserializar a classe Filme, que pode ser encontrada no [endpoint disponibilizado](https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/TopMovies.json)

2. Modelar e desserializar a classe Pais, que pode ser encontrada no [endpoint disponibilizado](https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Paises.json)

3. Modelar e desserializar a classe Carro, que pode ser encontrada no [endpoint disponibilizado](https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Carros.json)

4. Modelar e desserializar a classe Livro, que pode ser encontrada no [endpoint disponibilizado](https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Livros.json)

Opinião do instrutor

Para te ajudar a verificar seus códigos, disponibilizamos uma lista com as [possíveis soluções no Github](https://github.com/ArthurOcFernandes/Exerc-cios-C-/tree/curso-4-aula-2).

Boa sorte nos estudos!

### Aula 2: Faça como eu fiz: refatorando uma função

[Nesta API do Game Of Thrones API](https://anapioficeandfire.com/) com recursos dos personagens da série pelo ID, por exemplo o Margaery Tyrell possui o ID 16 :

```csharp
https://www.anapioficeandfire.com/api/characters/16
```

Ao realizar uma requisição para este endpoint, temos a seguinte resposta:

```csharp
{"url":"https://www.anapioficeandfire.com/api/characters/16","name":"Margaery Tyrell","gender":"Female","culture":"Westeros","born":"In 283 AC, at Highgarden","died":"","titles":["Queen of the Seven Kingdoms"],"aliases":["The Little Queen","The Little Rose","Maid Margaery"],"father":"","mother":"","spouse":"https://www.anapioficeandfire.com/api/characters/862","allegiances":["https://www.anapioficeandfire.com/api/houses/398"],"books":["https://www.anapioficeandfire.com/api/books/1","https://www.anapioficeandfire.com/api/books/2","https://www.anapioficeandfire.com/api/books/3","https://www.anapioficeandfire.com/api/books/5","https://www.anapioficeandfire.com/api/books/8"],"povBooks":[],"tvSeries":["Season 2","Season 3","Season 4","Season 5","Season 6"],"playedBy":["Natalie Dormer"]}
```

Agora é sua vez! Crie uma classe e faça a deserialização deste recurso nela, e exibe a classe no console. Sinta-se livre para escolher quais dados você deseja utilizar na classe.

Opinião do instrutor

Inicialmente, vamos criar uma classe que utiliza 2 informações da API: o nome do personagem e seus apelidos.

```csharp
class Personagem
{
    public string name { get; set; }
    public List<string>? aliases { get; set; }

    public void ExibirApelidosDaPersonagem()
    {
        Console.WriteLine($"Nome: {name}");
        Console.WriteLine("Apelidos:");
        foreach (string apelido in aliases)
        {
            Console.WriteLine($"- {apelido}");
        }
    }
}
```

Vamos realizar a deserialização utilizando a classe:

using screensound_04.Models;
using System.Text.Json;
using (HttpClient client = new HttpClient())
{
    string json = await client.GetStringAsync("https://www.anapioficeandfire.com/api/characters/16");

    Personagem margaery = JsonSerializer.Deserialize<Personagem>(json)!;
    margaery.ExibirApelidosDaPersonagem();
}
```

A saída do console será:

Nome: Margaery Tyrell
Apelidos:
- The Little Queen
- The Little Rose
- Maid Margaery
```

Os campos do JSON precisam ter o mesmo nome das propriedades?
No caso de deserialização de JSON sem o [JsonPropertyName("")], as propriedades da classe em que você está deserializando precisam ter nomes correspondentes aos campos no JSON para que a deserialização seja bem-sucedida por padrão, como vimos no exemplo acima.

No exemplo fornecido, a classe Personagem possui propriedades name e aliases, e a resposta JSON contém campos com os mesmos nomes. Portanto, a deserialização funcionará corretamente, e os valores correspondentes no JSON serão atribuídos às propriedades da classe Personagem.

[JsonProperty]
Se os nomes das propriedades da classe forem diferentes dos campos no JSON, você pode usar atributos de serialização, como o atributo [JsonProperty("nomeCampoJson")] assim como fizemos as aulas.

Lembrando: Ao fazer a deserialização de um objeto JSON para uma classe em C#, você não precisa ter todas as propriedades correspondentes no objeto. O processo de deserialização é flexível e apenas as propriedades presentes no JSON serão mapeadas para as propriedades da classe.

### Aula 2:  - Vídeo 7
### Aula 2:  - Vídeo 8
### Aula 2:  - Vídeo 9
### Aula 2:
