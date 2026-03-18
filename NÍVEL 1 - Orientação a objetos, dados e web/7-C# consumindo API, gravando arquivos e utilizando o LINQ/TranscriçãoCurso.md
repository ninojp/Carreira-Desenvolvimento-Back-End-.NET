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

```csharp
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

```csharp
Nome: Margaery Tyrell
Apelidos:
- The Little Queen
- The Little Rose
- Maid Margaery
```

**Os campos do JSON precisam ter o mesmo nome das propriedades?**  
No caso de deserialização de JSON sem o [JsonPropertyName("")], as propriedades da classe em que você está deserializando precisam ter nomes correspondentes aos campos no JSON para que a deserialização seja bem-sucedida por padrão, como vimos no exemplo acima.

No exemplo fornecido, a classe Personagem possui propriedades name e aliases, e a resposta JSON contém campos com os mesmos nomes. Portanto, a deserialização funcionará corretamente, e os valores correspondentes no JSON serão atribuídos às propriedades da classe Personagem.

**[JsonProperty]**  
Se os nomes das propriedades da classe forem diferentes dos campos no JSON, você pode usar atributos de serialização, como o atributo [JsonProperty("nomeCampoJson")] assim como fizemos as aulas.

Lembrando: Ao fazer a deserialização de um objeto JSON para uma classe em C#, você não precisa ter todas as propriedades correspondentes no objeto. O processo de deserialização é flexível e apenas as propriedades presentes no JSON serão mapeadas para as propriedades da classe.

### Aula 2: O que aprendemos?

Estes foram os pontos principais abordados nesta aula:

- Criamos uma classe com propriedades mapeadas para alguns campos da API com JsonPropertyName e realizamos a desserialização da resposta;

- Desserializamos os dados recebidos em um formato adequado para manipulação em nosso código. A serialização nos permite converter os dados recebidos em um formato como JSON em objetos que podemos trabalhar em nosso programa, facilitando a manipulação e extração das informações relevantes.

**Na próxima aula:**  
Vamos aprender de forma prática como usar uma poderosa tecnologia disponível no C# que oferece recursos avançados para consulta e manipulação de dados!

## Aula 3: LINQ

### Aula 3: Projeto da aula anterior

Aqui você pode [baixar o zip da Aula 02](https://github.com/alura-cursos/csharp-curso-4/archive/refs/heads/aula_2.zip) ou acessar os [arquivos no Github!](https://github.com/alura-cursos/csharp-curso-4/tree/aula_2)

### Aula 3: Selecionando gêneros musicais - Vídeo 1

Transcrição  
Guilherme: Vamos começar a desenvolver esses filtros. Não vamos criar os filtros dentro da pasta de "Modelos", porque não faz sentido. Pensando na forma como a aplicação vai ser desenvolvida, queremos criar um filtro que seja possível manipular e reutilizar, independente da lista passada.

**Selecionar todos os gêneros musicais da lista**  
Guilherme: Por isso, vamos clicar com o botão direito pasta "ScreenSound-04 > Adicionar > Nova Pasta". Vamos chamar essa nova pasta de "Filtros". Dentro dela, vamos clicar com o botão direito e escolher "Adicionar > Classe".

O nome dessa classe já apareceu nos cursos anteriores, mas não a tínhamos enfatizado. Quem pode nos ajudar nessa tarefa de ordenar, selecionar e filtrar é um método chamado LINQ. Por isso, nomeamos a classe como LinqFilter.

O que esse método vai fazer? Nele, vamos criar a responsabilidade de realizar alguns filtros. Antes, colocamos um ponto e vírgula após o namespace.

Dentro das chaves de LinqFilter, podemos começar a desenvolver a classe.

O primeiro desafio é exibir todos os gêneros musicais da lista.

É interessante notar que toda vez que criamos uma nova classe, a IDE sempre traz o using System.Linq. Vamos deletar os outros using e deixar somente essa linha, pois vamos utilizá-la.

LinqFilter.cs:

```csharp
using System.Linq;

namespace ScreenSound_04.Filtros;

internal class LinqFilter
{
}
```

Por enquanto a linha using System.Linq está acinzentada, porque ainda não a usamos.

Queremos criar um método em que não precisamos dar um new para usar esse filtro, como fizemos com o JSON Serializer. Por isso, vamos chamar o método de public e colocar a palavra static.

Já que esse método não vai ter nenhum retorno, vamos deixá-lo como void e vamos chamá-lo de FiltrarTodosOsGenerosMusicais().

O que vamos precisar para conseguir filtrar todos os gêneros musicais? Vamos precisar da lista. Portanto, entre parênteses, vamos passar uma List`<Musica>` que vamos chamar de musicas.

Para resolver o erro que apareceu, basta clicar na lâmpada e pedir para colocar o using ScreenSound_04.Modelos na primeira linha.

```csharp
using ScreenSound_04.Modelos;
using System.Linq;

namespace ScreenSound_04.Filtros;

internal class LinqFilter
{
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {
    }
}
```

Nesse método, vamos criar uma variável var chamada todosOsGenerosMusicais por inferência, ou seja, não vamos definir o tipo dela. Ela vai ser igual a lista de musicas onde vamos usar a propriedade .Select() para selecionar esses gêneros.

Poderíamos passar o Select para uma outra função para que essa função nos retornasse todas as listas com base no gênero. Mas, não vamos fazer isso. Podemos usar uma função anônima.

Entre os parênteses do Select, digitamos generos, uma arrow funcion (=>) , generos.Genero.

Agora, queremos apenas os gêneros únicos, ou seja, não queremos gêneros repetidos. Para isso, vamos colocar um ponto e a função Distinct(). No final, queremos que o resultado seja de fato uma lista. Por isso, colocamos .ToList() e ponto e vírgula.

Com esse Select() conseguimos pegar todos os gêneros musicais distintos passados através da lista.

Em seguida, vamos criar um foreach(). Poderíamos colocá-lo em outro lugar para maior clareza, mas vamos criá-lo na próxima linha por enquanto.

A condição será uma variável genero para a lista de todosOsGenerosMusicais. No corpo do foreach(), colocamos um Console.WriteLine(). Nele, vamos passar uma interpolação com cifrão e, entre aspas duplas, - {genero}.

```csharp
internal class LinqFilter
{
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {
        var todosOsGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();
        foreach (var genero in todosOsGenerosMusicais)
        {
            Console.WriteLine($"- {genero}");
        }
    }
```

Vamos salvar o documento.

Apesar de usar o Select(), não precisamos usar o System.Linq.

Daniel: Nesse caso, alguns namespaces já são importados por padrão pelo .NET para economiza digitação. O System.Linq é um deles.

Guilherme: Então, podemos apagar using System.Linq.

Para conseguir de fato utilizar esse método, vamos no Program.cs para trazer o using ScreenSound_04.Filtros.

No lugar de exibir musicas[1998] dentro do try, vamos chamar o tipo LinqFilter e o método FiltrarTodosOsGenerosMusicais(), passando a lista de musicas.

Program.cs:

```csharp
using ScreenSound_04.Filtros;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
    }

// código omitido…
```

Vamos clicar no botão "Iniciar Sem Depurar" (ou "Ctrl + F5") para executar a aplicação.

```csharp
pop, Dance/Electronic
hip hop, pop
hip hop
pop
hip hop, pop, R&B pop, R&B
pop, latin hip hop, pop, R&B, Dance/Electronic - rock
Dance/Electronic hip hop, pop, Dance/Electronic rock, pop
rock, easy listening
Folk/Acoustic, pop
hip hop, latin, Dance/Electronic
rock, metal
country, latin
pop, Folk/Acoustic
set()
R&B
rock, blues
hip hop, Dance/Electronic
country
```

Uma questão importante é a base de dados não classifica uma música por apenas um gênero. Então, uma mesma música pode ser pop, folk e rock juntos.

Daniel: É como se colocasse umas tags (etiquetas).

Guilherme: Tem até um gênero chamado set() que está sinalizado errado. Já escutou esse gênero?

O primeiro desafio foi concluído! Já listamos os gêneros musicais da nossa base de dados.

### Aula 3: Ordenando os artistas - Vídeo 2

Transcrição  
Daniel: Concluímos um primeiro desafio que era exibir os gêneros musicais. Foram exibidos como uma lista. Agora, vamos para o próximo desafio: ordenar artistas por nome.

**Ordenar artistas por nome**  
Guilherme: Podemos manter cada arquivo com um tipo de filtro específico para não ficar muito grande. Vamos criar mais uma classe na pasta "Filtros", chamada de LinqOrder.

Primeiro, vamos criar mais um método que vai ser responsável por fazer a ordenação nessa classe. Em internal class LinqOrder, vamos criar um método public static void chamado de ExibirListaDeArtistasOrdenados().

Como não está especificado se a ordenação é em ordem ascendente ou descendente, podemos mostrar as duas possibilidades. Entre os parênteses do método, vamos receber uma lista de música, ou seja, List`<Musica>`, chamada musicas. Por fim, abre e fecha chaves.

Precisamos colocar o using ScreenSound_04.Modelos na primeira linha do arquivo. Podemos usar a sugestão do "ações rápidas" ("Alt+Enter" ou "Ctrl + .") clicando na lâmpada amarela à esquerda.

LinqOrder.cs:

```csharp
using ScreenSound_04.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound_04.Filtros
{
    internal class LinqOrder
    {
        public static void ExibirListaDeArtistasOrdenados(List<Musica> musicas)
        {

        }
    }
}
```

Entre as chaves do método ExibirListaDeArtistasOrdenados(), vamos criar uma variável var chamada artistasOrdenados que vai ser igual à lista de musicas, ponto e o método de ordenação.

Existem dois métodos de ordenação: OrderBy() que ordena de forma ascendente (A a Z) e OrderByDescending() que ordena de forma descendente (Z a A).

Nesse caso, vamos colocar OrderBy() que vai pegar o elemento musica e ordenar com arrow function (=>) através do tipo musica.Artista.

Daniel: Com isso, vamos ordenar pela propriedade Artista.

Guilherme: Segundo passo é exibir apenas os nomes dos artistas ordenados. Por isso, vamos precisar realizar um Select(). Se deixamos apenas com OrderBy(), o código vai ordenar com base nos artistas, mas vai mostrar o nome da música, o gênero e duração.

Por isso, após o OrderBy() ser concluído, vamos colocar .Select(). O que queremos selecionar? Só artistas. Então, digitamos musica => musica.Artista.

Temos mais uma questão: se o artista estiver em mais de uma música, vai aparecer repetidamente. Logo, vamos colocar .Distinct() para aparecer somente uma única vez.

Precisamos novamente do .ToList()?

Daniel: É bom colocar, porque assim o resultado já vai ser traduzido em uma lista. Não é obrigatório fazê-lo, mas vamos manter o padrão que usamos anteriormente.

Guilherme: Podemos tirar os using que não vamos usar da linha 2 a linha 6. E vamos colocar um ponto e vírgula ao final do namespace, ao invés das chaves.

using ScreenSound_04.Modelos;

```csharp
namespace ScreenSound_04.Filtros;
internal class LinqOrder
{
    public static void ExibirListaDeArtistasOrdenados(List<Musica> musicas)
    {
        var artistasOrdenados = musicas.OrderBy(musica => musica.Artista).Select(musica => musica.Artista).Distinct().ToList();
    }
}
```

Vamos recapitular o que fizemos? Primeiro, ordenamos todas as músicas com base no artista.

Daniel: Depois, a partir do resultado da lista de músicas ordenada, vamos selecionar somente a propriedade artista. Com isso, temos uma lista de strings que representam os artistas.

Após o resultado de lista de strings, vamos tirar o que está repetido. Por fim, vamos colocar em memória como uma lista de strings sem repetição.

Se você passar o mouse em cima da variável artistasOrdenados, você vai notar que tem uma lista de strings ali: (variável local) List`<string?>`? artistasOrdenados.

Guilherme: Para fechar, vamos fazer um Console.WriteLine() com a Lista de artistas ordenados entre aspas duplas. Na próxima linha, vamos fazer um foreach(), onde vamos criar uma variável var chamada artista.

Para cada artista em artistasOrdenados, queremos colocar um Console.WriteLine() com interpolação de string. Isto é, cifrão e, entre aspas duplas, - {artista}.

using ScreenSound_04.Modelos;

namespace ScreenSound_04.Filtros;

```csharp
internal class LinqOrder
{
    public static void ExibirListaDeArtistasOrdenados(List<Musica> musicas)
    {
        var artistasOrdenados = musicas.OrderBy(musica => musica.Artista).Select(musica => musica.Artista).Distinct().ToList();
        Console.WriteLine("Lista de artistas ordenados");
        foreach (var artista in artistasOrdenados)
        {
            Console.WriteLine($"- {artista}");
        }
    }
}
```

Agora, vamos no Program.cs. Em try, vamos comentar o LinqFilter.FiltrarTodosOsGenerosMusicais() para não aparecer no console.

Na próxima linha, vamos digitar LinqOrder.ExibirListaDeArtistasOrdenados(), passando a lista de musicas.

Program.cs:

```csharp
try
{
    string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
    var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;

    // LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
    LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
}
// código omitido…
```

Após executar o aplicativo, temos uma lista de artistas ordenados de A a Z sem repetição.

Lista de artistas ordenados

```csharp
(…)
Wyclef Jean
X Ambassadors XXXTENTACION
Years & Years YG
Ying Yang Twins
Ylvis
Yo Gotti
Yolanda Be Cool Young Money
Young T & Bugsey
Young Thug Youngbloodz
Yung Joc
Zara Larsson
Zay Hilfigerrr
ZAYN
Zedd
ZHU
```

Quantos artistas desses o Daniel conhece?

Daniel: Todos, é claro!

Guilherme: Tem muitas bandas boas! Você pode escolher os artistas que você mais gosta.

Nosso próximo desafio é filtrar artistas por gênero musical. Vamos descobrir mais gêneros que o Daniel adora na sequência.

### Aula 3: Artistas por gênero musical - Vídeo 3

Transcrição  
Guilherme: Desafio dado é desafio vencido! O próximo passo é filtrar artistas por um determinado gênero musical.

**Filtrar artista por gênero musical**  
Guilherme: No Visual Studio, podemos usar o mesmo arquivo LinqFilter.cs com mais um método estático após o FiltrarTodosOsGenerosMusicais(). Na próxima linha, vamos criar um public static void chamado FiltrarArtistasPorGeneroMusical().

Como parâmetro, devemos receber uma lista de música chamada musicas. Porém, também vamos precisa saber o gênero musical. Por isso, também colocamos como parâmetro, uma string com o genero.

Daniel: Aquele campo que você tinha falado do front-end, onde a pessoa digitou ou clicou.

LinqFilter.cs:

```csharp
internal class LinqFilter
{

// código omitido…

    public static void FiltrarArtistasPorGeneroMusical(List<Musica> musicas, string genero) 
    {
    }
}
```

Guilherme: Dentro do método FiltrarArtistasPorGeneroMusical(), vamos criar uma variável var chamada artistasPorGeneroMusical que vai ser igual à variável musicas, ponto e uma propriedade diferente.

Já conhecemos o Select() e OrderBy(). Mas, nesse caso, vamos precisar de uma propriedade para filtrar a lista de músicas onde o gênero seja igual ao gênero que recebemos como parâmetro.

Daniel: Onde uma condição seja atendida. No caso desse exemplo, é a questão do gênero musical.

Guilherme: Para isso, vamos usar a palavra Where(), passando a musica => onde genero == musica.Genero.

Daniel: Mas, uma música pode ter mais de um gênero. Por isso, quando formos passar o argumento genero nessa string, teríamos que passar pop, poprock e ficaria complicado. E se queremos só pop, por exemplo?

Nesse caso, seria melhor usar o método Contains() que faz parte da classe string.

Guilherme: Sim! Na verdade, ao invés de genero == musica.Genero, vamos colocar musica.Genero.Contains(), passando o genero. Por fim, poderíamos colocar o ToList() para transformar em lista.

Só isso já pegaria todas as músicas que contém determinado gênero? Sim. Porém, repare que o nome do método diz que devemos filtrar artistas.

Com base nesse resultado do Where(), precisamos selecionar apenas os artistas. Por isso, após Where(), vamos colocar .Select() passando musica => musica.Artista. Como não queremos receber artistas duplicados, vamos colocar um .Distinct antes do .ToList().

```csharp
internal class LinqFilter
{
// código omitido…
    public static void FiltrarArtistasPorGeneroMusical(List<Musica> musicas, string genero) 
    {
        var artistasPorGeneroMusical = musicas.Where(musica => musica.Genero.Contains(genero)).Select(musica => musica.Artista).Distinct().ToList();
    }
}
```

Por fim, vamos colocar um Console.WriteLine() com cifrão no começo para interpolar as strings Exibindo os artistas por gênero musical >>> {genero}.

Agora, queremos fazer o foreach(), onde vamos ter a condição para cada var artista na nossa lista artistasPorGeneroMusical. No corpo, vamos colocar um Console.WriteLine() com interpolação de string. Isto é, cifrão e, entre aspas duplas, - {artista}.

A IDE coloca uma marcação amarela abaixo de musica.Genero, pois Genero pode ser nulo.

Daniel: Para resolver isso, podemos colocar uma exclamação após Genero. Assim, garantimos ao compilador que não é nulo.

```csharp
internal class LinqFilter
{
// código omitido…
    public static void FiltrarArtistasPorGeneroMusical(List<Musica> musicas, string genero) 
    {
        var artistasPorGeneroMusical = musicas.Where(musica => musica.Genero!.Contains(genero)).Select(musica => musica.Artista).Distinct().ToList();
        Console.WriteLine($"Exibindo os artistas por gênero musical >>> {genero}");
        foreach(var artista in artistasPorGeneroMusical)
        {
            Console.WriteLine($"- {artista}");
        }
    }
}
```

Guilherme: Antes de chamar o método, vamos visualizar todos os gêneros musicais que temos? Para isso, vamos em Program.cs e comentamos a linha LinqOrder.ExibirListaDeArtistasOrdenados() e descomentamos o LinqFilter.FiltrarTodosOsGenerosMusicais().

Program.cs:

```csharp
try
{
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;

        LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        // LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
}

// código omitido…
```

Com isso, podemos executar o método de filtrar os gêneros. Dentre os gêneros musicais exibidos no console, vamos escolher rock e pop.

Podemos fechar o console e comentar a linha desse filtro novamente. Agora, podemos escrever LinqFilter.FiltrarArtistasPorGeneroMusical().

Precisamos passar como argumento a lista de musicas e uma string para o gênero. Primeiro, vamos colocar o rock.

```csharp
try
{
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;

        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        // LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "rock");
}
// código omitido…
```

Após executar, descobrimos que existem muitos artistas que tocam rock. Não estamos com a lista ordenada, mas isso não foi pedido.

Exibindo os artistas por gênero musical >>> rock

```csharp
(…)
Muse
Marilyn Manson
My Chemical Romance
Thirty Seconds To Mars
Jimmy Eat World
Hoobastank
Scouting For Girls
Grouplove
Hot Chelle Rae
Alex Clare
```

Daniel: Temos Red Hot Chili Peppers, Artic Monkeys, Paramore, Switchfoot, entre outros.

Guilherme: Vamos colocar outro estilo musical, o pop. Basta substituir o argumento rock por pop em LinqFilter.FiltrarArtistasPorGeneroMusical() em Program.cs.

Nesse caso, temos artistas como The Chainsmokers, Sean Paul, Taylor Swift entre outros.

Desse modo, terminamos o desafio de exibir artistas por gênero musical.

### Aula 3: Exibindo músicas por artistas - Vídeo 4

Transcrição  
Guilherme: Nosso próximo desafio é filtrar as músicas de determinado artista. Depois, o Daniel vai escolher um artista para usarmos como exemplo.

**Filtrar música por artista**  
Já estamos usando o LinqFilter.cs para dois propósitos: filtrar os gêneros e filtrar artistas. Assim, podemos usá-lo para filtrar músicas de um artista, já que também é um filtro.

Na classe LinqFilter, vamos criar mais um método public static void chamado FiltrarMusicasDeUmArtista(). Como parâmetro, devemos receber a lista de músicas chamada musicas e também a string com o nomeDoArtista.

Entre as chaves, vamos começar a desenvolver esse método. Para isso, vamos criar uma variável var por inferência, ou seja, sem declarar seu tipo. Vamos chamá-la de musicasDoArtista.

Queremos pegar todas as músicas de um artista da lista de musicas. Nesse caso, vamos usar o Select() ou Where()?

Daniel: Sempre que queremos pegar o subconjunto de uma lista, usamos o Where().

Guilherme: Por isso, a variável vai ser igual à lista de musicas.Where(), a partir da musica vamos pegar musica.Artista, garantindo que não é uma propriedade nula com !ao final. Isto é, musica => musica.Artista!.

Agora, queremos conferir se essa musica.Artista é igual ao nomeDoArtista que recebemos como parâmetro. Para isso, devemos usar == ou um método específico?

Daniel: Como é uma string, podemos usar o Equals(). As strings são recursos muito utilizados nas aplicações e vão ter uma área de memória específica para essa gestão.

Por exemplo, tanto o .NET quanto o JVM do Java o fazem. Vamos colocar uma atividade para nos aprofundar mais nesse tema.

Guilherme: Após musica.Artista!, vamos digitar Equals(), passando o nomeDoArtista. No final, vamos usar também o .ToList() para transformar esses dados em uma lista.

LinqFilter.cs:

```csharp
internal class LinqFilter
{
// código omitido…
    public static void FiltrarMusicasDeUmArtista(List<Musica> musicas, string nomeDoArtista)
    {
        var musicasDoArtista = musicas.Where(musica => musica.Artista!.Equals(nomeDoArtista)).ToList();
    }
}
```

Com isso, se temos as músicas desse artista, vamos colocá-las dentro da variável musicasDoArtista.

Em seguida, vamos colocar um Console.WriteLine() com o nomeDoArtista. Depois, fazemos um foreach para saber quantas músicas esse artista tem.

Na condição, criamos uma variável var musica para cada música em musicasDoArtista.

No corpo, passamos um Console.WriteLine() somente com o nome da música que está na propriedade musica.Nome. Para isso, vamos usar interpolação de string com cifrão e, entre aspas duplas, - {musica.Nome}.

```csharp
internal class LinqFilter
{

// código omitido…

    public static void FiltrarMusicasDeUmArtista(List<Musica> musicas, string nomeDoArtista)
    {
        var musicasDoArtista = musicas.Where(musica => musica.Artista!.Equals(nomeDoArtista)).ToList();
        Console.WriteLine(nomeDoArtista);
        foreach (var musica in musicasDoArtista)
        {
            Console.WriteLine($"- {musica.Nome}");
        }
    }
}
```

Já temos nosso método concluído. Agora, podemos voltar para o Program.cs.

Antes de exibir os artistas específicos, vamos comentar o LiqFilter.FiltrarArtistasPorGeneroMusical() e descomentar a linha LinqOrder.ExibirListaDeArtistasOrdenados() para o Daniel escolher um artista que ele gosta.

Após executar a aplicação, conferimos a lista de artistas ordenados.

Daniel: Um artista que fez parte da minha infância foi o Michael Jackson.

Guilherme Mas, perto do nome dele, temos o nome de um artista brasileiro, o Michel Teló. Essa base de dados foi feita em inglês, mas temos um artista nacional.

Daniel: Queremos conhecer quais são as músicas do Michel Teló.

Guilherme: Podemos fechar a aplicação. Em try no Program.cs, vamos digitar LinqFilter.FiltrarMusicasDeUmArtista(), passando a lista de musicas e a string com o nome do Michel Teló.

Program.cs:

```csharp
try
{
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;

        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        // LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        // LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "pop");
        LinqFilter.FiltrarMusicasDeUmArtista(musicas, "Michel Teló");
}
// código omitido…
```

Já imagino qual música deve ser. Ao executar o código, vamos conferir qual música temos.

Michel Teló

Ai Se Eu Te Pego - Live

Também podemos filtrar as músicas da banda U2. Basta substituir, o argumento Michel Teló por U2 e executar novamente.

U2

Sometimes You Can't Make It On Your Own  
Vertigo

Com isso, terminamos o último desafio de filtrar as músicas de um artista.

Daniel: Para isso, usamos o LINQ, uma biblioteca do .NET usada para separar os dados/coleções que pegamos de um banco ou API em métodos como Select(), Where(), OrderBy(), OrderByDescending(). Assim, podemos fazer todo o trabalho de operações em listas.

Guilherme: Nas próximas aulas, vamos criar uma classe específica para definir nossas músicas preferidas.

### Aula 3: Determinando os campos para deserializar - Execício

Trabalhar com JSON é importante para desenvolvedores porque é um formato de dados amplamente utilizado em comunicações entre sistemas, facilitando a interoperabilidade e o compartilhamento de informações. Além disso, a manipulação e análise de JSON são tarefas comuns no desenvolvimento de aplicativos web e móveis, permitindo a criação de interfaces dinâmicas e a integração com serviços e APIs externas.

Abaixo temos um exemplo de uma resposta JSON de uma determinada API:

```json
{
  "temperatura": "25°C",
  "umidade": "60%",
  "condicao": "ensolarado"
}
```

Para realizar a deserialização o JSON em uma classe chamada Clima, poderíamos usar o seguinte código:

```csharp
using System.Text.Json;

Clima clima = JsonSerializer.Deserialize<Clima>(json);
```

Com base nos conhecimentos adquiridos durante o curso, analise as classes abaixo e marque aqueles que podem realizar a deserialização de forma correta apenas dos campos temperatura e condicao.

Respostas:

```csharp
class Clima
{
[JsonProperty("temperatura")]
public string RegistroDeTemperatura { get; set; }
[JsonProperty("condicao")]
public string CondicaoDoTempo { get; set; }
}
```

> As propriedades RegistroDeTemperatura e CondicaoDoTempo são atualizadas com os respectivos atributos [JsonPropertyName] para mapear os campos do JSON.

Alternativa correta

```csharp
class Clima
{
           public string Temperatura { get; set; }
          public string Condicao { get; set; }
}
```

> Isso aí! As propriedades da classe em que você está deserializando precisam ter nomes correspondentes aos campos no JSON.

### Aula 3: Desafio: hora da prática

A prática é um elemento essencial ao iniciar os estudos em programação, pois é por meio da aplicação prática dos conceitos teóricos que se solidificam os conhecimentos. Ao escrever código, resolver problemas e construir projetos reais, os iniciantes não apenas internalizam a sintaxe das linguagens de programação, mas também desenvolvem a habilidade de pensar logicamente e abordar desafios de maneira eficiente.

Pensando nisso, criamos uma lista de atividades (não obrigatórias) focada em prática para melhorar ainda mais sua experiência de aprendizagem. Bora praticar, então?

1. Dada uma lista de números, criar uma consulta LINQ para retornar apenas os elementos únicos da lista.

2. Dada uma lista de livros com título, autor e ano de publicação, criar uma consulta LINQ para retornar uma lista com os títulos dos livros publicados após o ano 2000, ordenados alfabeticamente.

3. Dada uma lista de produtos com nome e preço, criar uma consulta LINQ para calcular o preço médio dos produtos.

4. Dada uma lista de inteiros, criar uma consulta LINQ para retornar apenas os números pares.

Opinião do instrutor

Para te ajudar a verificar seus códigos, disponibilizamos uma [lista com as possíveis soluções](https://github.com/ArthurOcFernandes/Exerc-cios-C-/tree/curso-4-aula-3) no Github.

Boa sorte nos estudos!

### Aula 3: Faça como eu fiz: mais uma classe

No geral, o uso do LINQ no C# oferece uma sintaxe elegante e eficaz para consultas e manipulação de dados, tornando o código mais legível, conciso e fácil de manter. Durante as aulas, realizamos diferentes tipos de filtros criando métodos estáticos e agora chegou a sua vez.

Sua vez: que tal filtrar as músicas por ano?

Opinião do instrutor

Para iniciar, vamos criar uma propriedade para receber o campo Ano:

```csharp
[JsonPropertyName("year")]
    public string? AnoString { get; set; }
    public int Ano
    {
        get
        {
            return int.Parse(AnoString!);
        }
    }
```

Observe que na API o campo year é uma string e criamos uma propriedade chamada AnoString apenas para receber o valor do ano em texto. Em seguida, criamos uma variável chamada Ano, onde convertemos o tipo do AnoString para um inteiro. Com base no modelo atualizado e preparado para receber o ano das músicas, podemos criar o filtro das músicas pelo ano:

```csharp
public static void FiltrarMusicasPeloAno(List<Musica> musicas, int ano)
{
    var musicasDoAno = musicas.Where(musica => musica.Ano == ano)
        .OrderBy(musicas => musicas.Nome) // ordena as músicas pelo nome
        .Select(musicas => musicas.Nome) // seleciona apenas o nome das músicas
        .Distinct() // remove as duplicidades
        .ToList(); // converte o resultado em uma lista
    Console.WriteLine($"Músicas de {year}");
    foreach (var musica in musicasDoAno)
    {
        Console.WriteLine($"- {musica}");
    }
}
```

De forma resumida, o código filtra as músicas de um determinado ano, as ordena pelo nome, seleciona apenas o nome das músicas, remove as duplicidades e retorna uma lista com os nomes das músicas correspondentes ao ano especificado.

No Program.cs podemos ver o filtro que criamos em ação:

```csharp
LinqFilter.FiltrarMusicasPeloAno(songs,  2012);
```

Nosso resultado será:

```csharp
Músicas de 2012
- 22
- Ai Se Eu Te Pego - Live
- As Long As You Love Me
- Battle Scars (feat. Lupe Fiasco)
- Beauty And A Beat
- Blown Away
…e muitas outras…
```

Lembrando: é comum receber os dados de uma API em um tipo específico e, durante a manipulação desses dados, realizar conversões para outros tipos, conforme necessário, para atender às necessidades da aplicação.

### Aula 3: O que aprendemos?

**Estes foram os pontos principais abordados nesta aula:**  
Aplicamos o LINQ (Language Integrated Query) no C# e vimos que ele é importante porque oferece uma forma poderosa e expressiva de realizar consultas e manipulações de dados em diversas fontes, como coleções, bancos de dados e serviços web. Com o LINQ, podemos simplificar nosso código, melhorar a legibilidade e aumentar nossa produtividade durante o desenvolvimento;

Entendemos que podemos realizar uma ampla variedade de operações, como selecionar, filtrar, ordenar, projetar, agrupar e juntar dados de diferentes fontes, de forma fácil e eficiente.

**Na próxima aula:**  
Vamos criar um arquivo json com nossas músicas favoritas e utilizar um front-end que utiliza este arquivo!

## Aula 4: Criando arquivos com C#

### Aula 4: Projeto da aula anterior

Aqui você pode [baixar o zip da Aula 03](https://github.com/alura-cursos/csharp-curso-4/archive/refs/heads/aula_3.zip) ou acessar os [arquivos no Github!](https://github.com/alura-cursos/csharp-curso-4/tree/aula_3)

### Aula 4: Músicas preferidas - Vídeo 1

Transcrição  
Guilherme: Agora, nosso desafio é realizar uma ação contrária ao que fizemos. Nós pegamos a resposta e fizemos a desserialização dos dados que estavam em JSON para um formato que o C# entende.

Agora, faremos o oposto. De alguma forma, queremos manipular um determinado valor, criar uma classe e dessa classe exportar para um arquivo JSON.

Daniel: Da memória da aplicação para um arquivo JSON.

Guilherme: Vamos criar uma nova classe dentro da pasta "Modelos" chamada MusicasPreferidas.

Vamos criar um public string Nome, que pode ser nulo, para informar de quem é a lista. Em seguida teremos public List`<Musica>` ListaDeMusicasFavoritas.

A convenção de nomenclatura determina que os nomes de propriedades iniciem com letra maiúscula.

```csharp
namespace ScreenSound_04.Modelos;

internal class MusicasPreferidas
{

  public string? Nome { get; set; }
  public List<Musica> ListaDeMusicasFavoritas;
}
```

Sempre que criarmos uma playlist de músicas preferidas, queremos criar um construtor que atribua sempre um nome para essa playlist. Nesse construtor precisaremos apenas do Nome e informaremos que o Nome será o nome que passarmos como propriedade.

Podemos também começar com a lista vazia.

```csharp
namespace ScreenSound_04.Modelos;
internal class MusicasPreferidas
{
  public string? Nome { get;set; }
  public List<Musica> ListaDeMusicasFavoritas { get; }
  public MusicasPreferidas(string nome){
     Nome = nome;
     ListaDeMusicasFavoritas = new List<Musica>();
    }
}
```

Agora, podemos pensar em algum método para nossa classe. Precisamos adicionar as músicas favoritas. Vamos colocar um public void AdicionarMusicasFavoritas, que vai ser do tipo Musica. Precisamos apenas pegar a ListaDeMusicasFavoritas.

```csharp
public void AdicionarMusicasFavoritas(Musica musica)
{
    ListaDeMusicasFavoritas.Add(musica);
}
```

Em seguida, precisamos de um método para visualizar as informações.Faremos isso com o ExibirMusicasFavoritas().

```csharp
public void ExibirMusicasFavoritas()
{

}
```

Primeiro, colocaremos um Console.WriteLine() com a mensagem "Essas são as músicas favoritas -> {Nome}", onde está {Nome} vai aparecer o nome da pessoa.

```csharp
public void ExibirMusicasFavoritas()
{
    Console.WriteLine($"Essas são as músicas favoritas -> {Nome}");
}
```

Depois, faremos um foreach informando que para cada música de ListaDeMusicasFavoritasqueremos exibir as músicas. Podemos colocar duas informações: o nome da música e o artista.

```csharp
public void ExibirMusicasFavoritas()
{
    Console.WriteLine($"Essas são as músicas favoritas -> {Nome}");
    foreach (var musica in ListaDeMusicasFavoritas)
    {
        Console.WriteLine($"- {musica.Nome} de {musica.Artista}");
    }
}
```

Temos dois métodos, um para adicionar e outro para exibir as músicas. No próximo vídeo, vamos instanciar esse método e criar uma lista de músicas preferidas!

### Aula 4: Instanciando a classe - Vídeo 2

Transcrição  
Daniel: Agora, que já criamos a classe que representa as músicas preferidas, vamos instanciar essa classe e usar o método para exibir a lista.

Guilherme: Vamos instanciar. No Program.cs, na linha 17, primeiro, vamos criar uma variável chamada musicasPreferidasDoDaniel que será igual a new MusicasPreferidas. O argumento vai ser o nome da playlista, deixaremos "Daniel".

> var musicasPreferidasDoDaniel = new MusicasPreferidas("Daniel");

Agora, vamos para um momento incrível. Vamos criar cinco músicas, ou seja, cinco linhas e vamos alterar apenas o valor do índice. Vou colocar valores que eu selecionei anteriormente.

```csharp
var musicasPreferidasDoDaniel = new MusicasPreferidas("Daniel");
musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[1]);
musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[377]);
musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[4]);
musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[6]);
musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[1467]);
```

Daniel: Agora, vem o método para exibir, certo?

Guilherme: Sim. Vamos chamar o método ExibirMusicasFavoritas().

```csharp
var musicasPreferidasDoDaniel = new MusicasPreferidas("Daniel");
musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[1]);
musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[377]);
musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[4]);
musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[6]);
musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[1467]);

musicasPreferidasDoDaniel.ExibirMusicasFavoritas();
```

Podemos salvar e executar a aplicação. Tivemos o seguinte retorno:

Essas são as músicas favoritas -> Daniel

```csharp
#thatPOWER de will.i.am
Dangerous de Kardinal Offishall
... Ready for It? de Taylor Swift
1 Thing de Amerie
Shalala lala de Vengaboys
```

Podemos inserir as músicas favoritas de outra pessoa. Vamos colocar cinco músicas para a Emilly:

```csharp
        var musicasPreferidasDoDaniel = new MusicasPreferidas("Daniel");
        sicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[1]);
        musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[377]);
        musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[4]);
        musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[6]);
        musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[1467]);
        musicasPreferidasDoDaniel.ExibirMusicasFavoritas();
        var musicasPreferidasEmilly = new MusicasPreferidas("Emy");

        musicasPreferidasEmilly.AdicionarMusicasFavoritas(musicas[500]);
        musicasPreferidasEmilly.AdicionarMusicasFavoritas(musicas[637]);
        musicasPreferidasEmilly.AdicionarMusicasFavoritas(musicas[428]);
        musicasPreferidasEmilly.AdicionarMusicasFavoritas(musicas[13]);
        musicasPreferidasEmilly.AdicionarMusicasFavoritas(musicas[71]);
        musicasPreferidasEmilly.ExibirMusicasFavoritas();
```

Para pular uma linha e termos um espaço quando listarmos mais de uma pessoa, no final de MusicasPreferidas.cs vamos inserir um Console.WriteLine() vazio. Assim garantimos que da próxima vez que for executado, vai ter uma linha em branco entre as listas.

```csharp
    public void ExibirMusicasFavoritas()
    {
        Console.WriteLine($"Essas são as músicas favoritas -> {Nome}");
        foreach (var musica in ListaDeMusicasFavoritas)
        {
            Console.WriteLine($"- {musica.Nome} de {musica.Artista}");
        }
        Console.WriteLine();
    }
```

Agora, o desafio é o seguinte: como construir um JSON com base nessas informações? Além disso, como criar um arquivo com C#? Aprenderemos isso no próximo vídeo.

### Aula 4: Criando arquivos com C# - Vídeo 3

Transcrição  
Daniel: Agora vamos pegar essas músicas favoritas, que foram gravadas nesses objetos, e colocá-las em um arquivo JSON.

Guilherme: Sim. Minha ideia é fazer um método chamado GerarArquivoJson(). Assim poderíamos fazer algo como a linha abaixo e a aplicação vai gerar um arquivo com a músicas:

```csharp
musicasPreferidasEmilly.GerarArquivoJson();
```

Para isso, no MusicasPreferidas.cs, vamos criar esse novo método. Não precisamos receber nenhuma informação nele porque tanto a lista das músicas quanto o nome e outras propriedades já fazem parte da instância.

```csharp
public void GerarArquivoJson()
{
}
```

Primeiro, vamos criar uma string que contenham essas informações. Agora, nós queremos fazer a serialização de dados, queremos transformar em uma string. Usaremos o Json Serializer. Não queremos serializar só as músicas, queremos o nome da pessoa também. Podemos usar um objeto anônimo para isso.

```csharp
public void GerarArquivoJson()
{
    string json = Json Serializer.Serialize(new 
    {
            nome = Nome,
            musicas = ListaDeMusicasFavoritas
    });
}
```

Daniel: Estamos muito acostumados a fazer new com o tipo do lado, para representar aquela estrutura que queremos criar. Nesse caso, é um objeto anônimo, não tem tipo. É algo específico para esse tipo de situação em que queremos criar uma estrutura temporária.

Guilherme: O próximo passo é: queremos que o nome do arquivo gerado tenha o nome da pessoa. Para isso, vamos criar uma string nomeDoArquivo que será uma interpolação de string onde colocaremos $"musica-favoritas-{Nome}.json".

```csharp
public void GerarArquivoJson()
{
    string json = Json Serializer.Serialize(new 
    {
            nome = Nome,
            musicas = ListaDeMusicasFavoritas
    });
    string nomeDoArquivo = $"musica-favoritas-{Nome}.json";
}
```

Para criar o arquivo usaremos o método File.WriteAllText(), entre parênteses passaremos o nomeDoArquivo e o json que vamos gerar, o conteúdo em texto.

```csharp
    public void GerarArquivoJson()
    {
        string json = JsonSerializer.Serialize(new
        {
            nome = Nome,
            musicas = ListaDeMusicasFavoritas
        });
        string nomeDoArquivo = $"musicas-favoritas-{Nome}.json";

        File.WriteAllText(nomeDoArquivo, json);
```

No final vamos exibir uma mensagem informando que o arquivo JSON foi criado com sucesso.

```csharp
    public void GerarArquivoJson()
    {
        string json = JsonSerializer.Serialize(new
        {
            nome = Nome,
            musicas = ListaDeMusicasFavoritas
        });
        string nomeDoArquivo = $"musicas-favoritas-{Nome}.json";
        File.WriteAllText(nomeDoArquivo, json);
                Console.WriteLine("O arquivo Json foi criado com sucesso!");
        }
```

Podemos salvar e testar.

No Program.cs vamos ficar só com as músicas da Emilly. Podemos selecionar as linhas referentes às músicas do Daniel e pressionar "Ctrl + K + C" para comentar as linhas selecionadas.

```csharp
var musicasPreferidasEmilly = new MusicasPreferidas("Emy");
musicasPreferidasEmilly.AdicionarMusicasFavoritas(musicas[500]);
musicasPreferidasEmilly.AdicionarMusicasFavoritas(musicas[637]);
musicasPreferidasEmilly.AdicionarMusicasFavoritas(musicas[428]);
musicasPreferidasEmilly.AdicionarMusicasFavoritas(musicas[13]);
musicasPreferidasEmilly.AdicionarMusicasFavoritas(musicas[71]);
musicasPreferidasEmilly.ExibirMusicasFavoritas();
musicasPreferidasEmilly.GerarArquivoJson();
```

Vamos executar. Tivemos o seguinte retorno no console:

Essa são as músicas favoritas -> Emy

```csharp
Face Down de The Red Jumpsuit Apparatus
Harde de Rihanna
Don't Give Up de Chicane
2 Phones de Kevin Gates
All The Small Things de Blink-182
O arquivo Json foi criado com sucesso!
```

Ele informou que o arquivo Json foi criado com sucesso. Será que foi mesmo? Vamos descobrir no próximo vídeo!

### Aula 4:  Para saber mais: criando um arquivo txt

Para criar um arquivo de texto com C# de forma simples, você pode usar a classe StreamWriter juntamente com o método WriteLine() para escrever conteúdo no arquivo. Primeiro, você precisa instanciar a classe StreamWriter passando o caminho e o nome do arquivo como parâmetro. Em seguida, você pode usar o método WriteLine() para escrever linhas de texto no arquivo. Por fim, lembre-se de fechar o arquivo usando o método Close() para garantir que todas as alterações sejam salvas.

```csharp
public void GerarDocumentoTXTComAsMusicasFavoritas()
{
    string nomeDoArquivo = $"musicas-favoritas-{Nome}.txt";
    using (StreamWriter arquivo = new StreamWriter(nomeDoArquivo))
    {
        arquivo.WriteLine($"Músicas favoritas do {Nome}\n");
        foreach (var musica in listaDasMusicasFavoritas)
        {
            arquivo.WriteLine($"- {musica.Song}");
        }
    }
    Console.WriteLine("txt gerado com sucesso!");
}
```

Agora podemos instânciar as músicas favoritas no Program.cs, como ilustra o código abaixo:

```csharp
var musicasFavoritasDoGuilherme = new MusicasFavoritas("Guilherme");
musicasFavoritasDoGuilherme.AdicionarMusicaFavorita(songs[980]);
musicasFavoritasDoGuilherme.AdicionarMusicaFavorita(songs[513]);
musicasFavoritasDoGuilherme.AdicionarMusicaFavorita(songs[1024]);
musicasFavoritasDoGuilherme.AdicionarMusicaFavorita(songs[999]);
musicasFavoritasDoGuilherme.AdicionarMusicaFavorita(songs[37]);
musicasFavoritasDoGuilherme.GerarDocumentoTXTComAsMusicasFavoritas();
```

Ao executar o código, a saída do console será txt gerado com sucesso! seguido do caminho onde o arquivo se encontra. Ao abrir o arquivo txt teremos as seguintes informações:

Músicas favoritas do Guilherme

```csharp
- Locked out of Heaven
- Feel This Moment (feat. Christina Aguilera)
- LoveGame
- Lost in the Fire (feat. The Weeknd)
- A Thousand Years
```

> Lembre-se: Com C#, você é capaz de criar diversos tipos de arquivos, incluindo arquivos de texto, arquivos binários, arquivos XML, arquivos JSON e muitos outros.

### Aula 4: Comparando tipos - Exercício

A criação, leitura e manipulação de arquivos são habilidades essenciais na carreira de um desenvolvedor. Os arquivos desempenham um papel fundamental no armazenamento e compartilhamento de dados em qualquer aplicativo ou sistema. Isso permite que os dados sejam salvos entre as execuções do programa e compartilhados entre diferentes partes do sistema.

Agora, analise as afirmações abaixo e marque apenas as verdadeiras.

Respostas:

Com C#, você pode criar e manipular vários tipos de arquivos.

> Isso aí! Durante o curso, aprendemos como criar um arquivo JSON e na atividade para saber mais, como criar um arquivo TXT. Porém, é possível criar outros tipos de arquivos como binários, xml, csv, entre outros.

### Aula 4: Desafio: hora da prática

A prática é um elemento essencial ao iniciar os estudos em programação, pois é por meio da aplicação prática dos conceitos teóricos que se solidificam os conhecimentos. Ao escrever código, resolver problemas e construir projetos reais, os iniciantes não apenas internalizam a sintaxe das linguagens de programação, mas também desenvolvem a habilidade de pensar logicamente e abordar desafios de maneira eficiente.

Pensando nisso, criamos uma lista de atividades (não obrigatórias) focada em prática para melhorar ainda mais sua experiência de aprendizagem. Bora praticar, então?

1. Criar um programa que permite ao usuário inserir informações de uma pessoa (nome, idade, e e-mail), serializa essas informações em formato JSON e salva em um arquivo.

2. Criar um programa que lê um arquivo JSON contendo informações de uma pessoa, desserializa essas informações e exibe na tela.

3. Criar um programa que permite ao usuário inserir informações de várias pessoas, armazena essas informações em uma lista, serializa a lista em formato JSON e salva em um arquivo.

4. Criar um programa que lê um arquivo JSON contendo informações de várias pessoas, desserializa essas informações em uma lista e exibe na tela.

5. Criar um programa que lê um arquivo JSON contendo informações de várias pessoas, permite ao usuário inserir uma idade e exibe as pessoas com aquela idade.

Opinião do instrutor

Para te ajudar a verificar seus códigos, disponibilizamos uma lista com as [possíveis soluções no Github](https://github.com/ArthurOcFernandes/Exerc-cios-C-/tree/curso-4-aula-4).

Boa sorte nos estudos!

### Aula 4: O que aprendemos?

Estes foram os pontos principais abordados nesta aula:

- Criamos uma lista com as nossas 5 músicas preferidas e utilizamos o C# para criar um arquivo JSON contendo o nome da playlist e as músicas;

- Exploramos a forma de vincular o arquivo JSON com o frontend da aplicação, possibilitando a exibição das músicas preferidas de cada pessoa.

**Na próxima aula:**  
Você terá a chance de colocar todo o conhecimento que adquiriu em prática resolvendo um desafio. Até lá!

## Aula 5: Desafios

### Aula 5: Projeto da aula anterior

Aqui você pode [baixar o zip da Aula 04](https://github.com/alura-cursos/csharp-curso-4/archive/refs/heads/aula_4.zip) ou acessar os [arquivos no Github!](https://github.com/alura-cursos/csharp-curso-4/tree/aula_4)

### Aula 5: Apresentação do desafio #1 - Vídeo 1

Transcrição  
Daniel: Chegou a hora de você colocar em prática os ensinamentos que vimos no curso! Qual será seu primeiro desafio?

**Desafio #1**  
O desafio será novamente a [partir da API](https://guilhermeonrails.github.io/api-csharp-songs/songs.json) que estamos buscando, composta por uma coleção de músicas. Nessa coleção, já mapeamos algumas propriedades na classe Musica.cs.

Agora queremos trazer mais uma propriedade, chamada key. O objetivo é mapear essa propriedade, porém, ela está com um valor numérico. Você precisa traduzir esse número para a tonalidade conforme a tabela abaixo:

|Valor do Key|Como exibir no console|
|---|---|
|0|C|
|1|C#|
|2|D|
|3|D#|
|4|E|
|5|F|
|6|F#|
|7|G|
|8|G#|
|9|A|
|10|A#|
|11|B|

Não é necessário que você entenda de música. A ideia é você conseguir fazer a tradução e apresentar as músicas com suas respectivas tonalidades da segunda coluna. Vamos lá?

### Aula 5: Resolvendo o desafio #1 - Vídeo 2

Transcrição  
Guilherme: O primeiro passo para resolver o desafio #1 é buscar de fato o valor da propriedade key. Algo importante é que todos os outros valores na API estão entre aspas duplas. Já o valor de key está sem as aspas, ou seja, é representado por um número inteiro.

```JSON
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

// Código suprimido
```

Antes de manipular para representar a propriedade key com outro valor, a primeira coisa que faremos será exibir key no método ExibirDetalhesDaMusica() do arquivo Musica.cs.

Para isso, na classe Musica, vamos declarar uma nova propriedade chamada Key, que será pública (public) e inteira (int).

Assim como em todas as outras classes, vamos usar o atributo JsonPropertyName, passando entre parênteses e entre aspas duplas o nome key.

```csharp
[JsonPropertyName("key")]
public int Key { get; set; }
```

Um ponto importante: se não colocarmos o JsonPropertyName() antes da declaração da propriedade, e quisermos que o valor tenha o mesmo conteúdo mapeado para a propriedade Key, precisaríamos escrever o Key da mesma forma que ele está marcado na API.

```csharp
"key": 0
```

Note que a inicial "k" está minúscula.

Então, temos duas opções de código: ou mantemos o Key da forma como está, com letra maiúscula e usando o atributo JsonPropertyName recebendo o nome com inicial minúscula; ou deixamos a inicial da propriedade minúscula (key) e removemos o atributo.

Agora, no método ExibirDetalhesDaMusica(), criaremos um novo Console.WriteLine() interpolando a string ($), e vamos digitar entre aspas duplas "Tonalidade: {Key}".

```csharp
public void ExibirDetalhesDaMusica()
{
    Console.WriteLine($"Artista: {Artista}");
    Console.WriteLine($"Música: {Nome}");
    Console.WriteLine($"Duração em segundos: {Duracao /1000}");
    Console.WriteLine($"Gênero musical: {Genero}");
    Console.WriteLine($"Tonalidade: {Key}");
}
```

Feito isso, vamos retornar ao programa principal (arquivo Program.cs) e comentar as músicas preferidas da Emilly. Para isso, podemos usar o atalho "Ctrl + K + C".

```csharp
//musicas[1].ExibirDetalhesDaMusica();
//LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
//LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
//LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "rock");
//LinqFilter.FiltrarMusicasDeUmArtista(musicas, "U2");

//var musicasPreferidasDoDaniel = new MusicasPreferidas("Daniel");
//musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[1]);
//musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[377]);
//musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[4]);
//musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[6]);
//musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[1467]);

//var musicasPreferidasEmilly = new MusicasPreferidas("Emy");

//musicasPreferidasEmilly.AdicionarMusicasFavoritas(musicas[500]);
//musicasPreferidasEmilly.AdicionarMusicasFavoritas(musicas[637]);
//musicasPreferidasEmilly.AdicionarMusicasFavoritas(musicas[428]);
//musicasPreferidasEmilly.AdicionarMusicasFavoritas(musicas[13]);
//musicasPreferidasEmilly.AdicionarMusicasFavoritas(musicas[71]);

//musicasPreferidasEmilly.ExibirMusicasFavoritas();

//musicasPreferidasEmilly.GerarArquivoJson();
```

Em seguida, criaremos uma variável para exibir a primeira música. Primeiro, teremos a lista; depois, será feita a desserialização; e por último, teremos o método musicas[0].ExibirDetalhesDaMusica(), com o índice 0 para musicas.

```csharp
try
{
    string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
    var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
    musicas[0].ExibirDetalhesDaMusica();
```

Retornando à API, identificamos que a primeira música da banda "The Chainsmokers" está definida com key igual a 0. Agora vamos executar a aplicação para verificar se temos a tonalidade 0.

Resultado no console:

```csharp
Artista: The Chainsmokers
Música: #SELFIE - Original Mix
Duração em segundos: 183
Gênero musical: pop, Dance/Electronic
Tonalidade: 0
```

Vamos verificar com o segundo elemento, para conferir se os valores estão funcionando corretamente. Para isso, alteramos o índice de musica para 1.

```csharp
try
{
    string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
    var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
    musicas[1].ExibirDetalhesDaMusica();
```

Nesse índice, temos a tonalidade 6.

Resultado no console:

```csharp
Artista: will.i.am
Música: #thatPOWER
Duração em segundos: 279
Gênero musical: hip hop, pop
Tonalidade: 6
```

Nosso próximo desafio é de fato mapear os valores do método ExibirDetalhesDaMusica(), para que eles exibam a tonalidade representada por uma letra, algo comum na música.

Pensando nisso, criamos um arquivo .txt que contém a lista de tonalidades que iremos utilizar. Quando o índice for 0, por exemplo, o que queremos mostrar de fato na tonalidade é o valor "C"; quando o índice for 1, queremos mostrar "C#"; e assim por diante.

tonalidades.txt

```csharp
"C", "C#", "D", "Eb", "E", "F", "F#", "G", "Ab", "A", "Bb", "B"
```

Logo após a declaração da classe Musica, vamos criar um campo privado (private) que será uma lista de string (string[]). Chamaremos esse campo de tonalidades, com inicial minúscula, e ele será igual a uma abertura de chaves contendo o conteúdo do arquivo .txt.

```csharp
private string[] tonalidades = { "C", "C#", "D", "Eb", "E", "F", "F#", "G", "Ab", "A", "Bb", "B" };
```

Agora precisamos criar uma propriedade cujo modo de leitura será alterado, isto é, o modo get. Vamos indicar que quando essa propriedade estiver no modo de leitura e ela for solicitada, exibiremos o campo tonalidades com base no índice de key.

Dessa forma, se key for igual a 0, iremos retornar "C"; se o key for 1, retornaremos "C#"; se o key for 2, retornaremos "D"; e assim por diante.

Abaixo da propriedade Key, na linha 22, vamos declarar uma nova propriedade. Ela será uma string, pois são os valores exibidos no campo tonalidades, e o nome da propriedade será Tonalidade, no singular e com inicial maiúscula.

Para esse caso, não precisamos do método set, apenas do get. Além disso, vamos reescrever o get. Abriremos chaves após sua declaração, e entre elas teremos um return.

Nós queremos retornar com base na lista tonalidades com a chave da propriedade Key, então após o return vamos digitar tonalidades seguida de Key entre colchetes.

```csharp
public string Tonalidade {
    get
    {
        return tonalidades[Key];
    }
}
```

Isso já é suficiente para conseguirmos exibir as tonalidades como "C", "C#", "D", "D#", e assim por diante. Para finalizar, no lugar de Key no Console.WriteLine() que adicionamos, que até então exibia os valores 0, 1, 2…, colocaremos a propriedade Tonalidade.

Resultado do código de Musica.cs:

```csharp
using System.Text.Json.Serialization;

namespace ScreenSound_04.Modelos;

internal class Musica
{
    private string[] tonalidades = { "C", "C#", "D", "Eb", "E", "F", "F#", "G", "Ab", "A", "Bb", "B" };

    [JsonPropertyName("song")]
    public string? Nome { get; set; }
    [JsonPropertyName("artist")]
    public string? Artista { get; set; }

    [JsonPropertyName("duration_ms")]
    public int Duracao { get; set; }
    [JsonPropertyName("genre")]
    public string? Genero { get; set; }

    [JsonPropertyName("key")]
    public int Key { get; set; }

    public string Tonalidade {
        get
        {
            return tonalidades[Key];
        }
    }
    public void ExibirDetalhesDaMusica()
    {
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Música: {Nome}");
        Console.WriteLine($"Duração em segundos: {Duracao /1000}");
        Console.WriteLine($"Gênero musical: {Genero}");
        Console.WriteLine($"Tonalidade: {Tonalidade}");
    }
}
```

Agora vamos testar na aplicação a exibição da música com índice 0. Indicamos isso no arquivo Program.cs:

```csharp
try
{
    string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
    var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
    musicas[0].ExibirDetalhesDaMusica();
```

Resultado no console:

```csharp
Artista: The Chainsmokers
Música: #SELFIE - Original Mix
Duração em segundos: 183
Gênero musical: pop, Dance/Electronic
Tonalidade: C
```

Podemos testar também com o índice 1:

Resultado no console:

```csharp
Artista: will.i.am
Música: #thatPOWER
Duração em segundos: 279
Gênero musical: hip hop, pop
Tonalidade: F#
```

Assim, concluímos nosso desafio #1!

### Aula 5: Apresentação do desafio #2 - Vídeo 3

Transcrição  
Guilherme: Se você pensou que os desafios acabaram, ainda não! Temos um desafio final para esse curso.

**Desafio #2**  
Já conseguimos visualizar as tonalidades das músicas com a letra C, que representa o dó, F, que representa o fá, e assim por diante. Agora quero passar um desafio extremo para você!

O desafio é o seguinte: você deverá criar um método que exiba o nome de todas as músicas que estejam na tonalidade de C#, ou seja, dó sustenido.

Lembrando que, na nossa lista do GitHub, a tonalidade que representa o C# corresponde ao índice 1. Então, a ideia é que você busque todas as músicas com índice 1 e exiba apenas elas.

Na sequência, teremos um vídeo com uma possível resolução para o desafio.

Boa sorte!

### Aula 5: Resolvendo o desafio #2 - Vídeo 4

Transcrição  
Daniel: Vamos resolver o desafio #2? Precisamos filtrar as músicas em C# (dó sustenido). Começaremos criando mais um método estático no arquivo LinqFilter.cs, agora para fazer a filtragem e exibir as músicas.

Primeiro, vamos comentar a linha 11 do arquivo Program.cs, que não será usada:

```csharp
// musicas[1].ExibirDetalhesDaMusica();
```

No lugar dessa linha, vamos começar a chamar o método FiltrarMusicasEmCSharp() que criaremos em breve. Para isso, digitamos LinqFilter.FiltrarMusicasEmCSharp().

```csharp
LinqFilter.FiltrarMusicasEmCSharp();
```

Como ainda não exite esse método em static, podemos pedir para o Visual Studio gerá-lo, usando o atalho "Ctrl + ." e selecionando a primeira opção. Feito isso, ao clicar sobre o método com a tecla "Ctrl" pressionada, somos direcionados para a declaração do método estático FiltrarMusicasEmCSharp() no arquivo LinqFilter.cs.

```csharp
internal static void FiltrarMusicasEmCSharp()
{
    {
        throw new NotImplementedException();
    }
}
```

Precisamos passar a lista do tipo Musica como parâmetro do método FiltrarMusicasEmCSharp(). Podemos copiar esse trecho do componente List<> da linha 26, no método FiltrarMusicasDeUmArtista().

```csharp
internal static void FiltrarMusicasEmCSharp(List<Musica> musicas)
{
    {
        throw new NotImplementedException();
    }
}
```

Agora vamos completar a declaração. Começaremos removendo o bloco throw new. Em seguida, podemos criar uma variável chamada musicasEmCSharp, e a partir da lista musicas, pegar aquelas onde (Where()) a tonalidade (musica.Tonalidade) seja igual a "C#" (para isso, usamos o método Equals()).

Vamos quebrar a linha a partir de .Where() para facilitar a visualização.

```csharp
internal static void FiltrarMusicasEmCSharp(List<Musica> musicas)
{
    {
        var musicasEmCSharp = musicas
            .Where(musica => musica.Tonalidade.Equals("C#"))
    }
}
```

Dessa forma, obtemos as músicas que possuem tonalidade em C#. Porém, essa lista ainda é de músicas. Queremos só o nome das músicas, então iremos transformar a lista de músicas (musica) em uma lista de string (musica.Nome). Para transformar, usamos o método Select().

```csharp
internal static void FiltrarMusicasEmCSharp(List<Musica> musicas)
{
    {
        var musicasEmCSharp = musicas
            .Where(musica => musica.Tonalidade.Equals("C#"))
            .Select(musica => musica.Nome)
    }
}
```

Assim, selecionamos de cada elemento musica apenas o Nome.

Para finalizar, vamos colocar todos os elementos em uma lista, usando o método ToList().

```csharp
internal static void FiltrarMusicasEmCSharp(List<Musica> musicas)
{
    {
        var musicasEmCSharp = musicas
            .Where(musica => musica.Tonalidade.Equals("C#"))
            .Select(musica => musica.Nome)
            .ToList();
    }
}
```

Agora que temos a nossa lista de nomes de músicas, vamos usar o foreach() para indicar que, para cada música, será exibido o nome da música, isto é, {musica}. Usaremos interpolação, então adicionamos $ antes do texto.

Além disso, antes do foreach(), podemos adicionar um método Console.WriteLine() com o texto "Músicas em C#:".

```csharp
internal static void FiltrarMusicasEmCSharp(List<Musica> musicas)
{
    var musicasEmCSharp = musicas
        .Where(musica => musica.Tonalidade.Equals("C#"))
        .Select(musica => musica.Nome)
        .ToList();
    Console.WriteLine("Músicas em C#:");
    foreach (var musica in musicasEmCSharp)
    {
        Console.WriteLine($"- {musica}");
    }
}
```

Temos nossa solução! Geramos a lista de nomes de músicas, uma lista de strings. Ao passar o cursor sobre a variável musicasEmCSharp, temos a indicação List<string?>.

Adicionamos também um cabeçalho, e por fim a exibição da lista.

Para finalizar, no arquivo Program.cs, precisamos passar como argumento do método FiltrarMusicasEmCSharp() a lista musicas.

```csharp
LinqFilter.FiltrarMusicasEmCSharp(musicas);
```

Assim, serão exibidas todas as músicas da API que estiverem na tonalidade C#. Será que existe alguma música em dó sustenido? Vamos testar!

Com "Ctrl + F5", abrimos o console:

```csharp
Músicas em C#:
- 'Till I Collapse
- 1, 2, 3 (feat. Jason Derulo & De La Ghetto)
- 2002
- 21 Seconds
- 24K Magic
- 4 My People (feat. Eve)
- 7 rings
- About You Now
- Adan y Eva
- Against All Odds (Take A Look at Me Now) (feat. Westlife)
- All Day And Night
- All I Have (feat. LL Cool J)
- All Of The Lights
- Alors on danse - Radio Edit
- American Idiot
- Animals - Radio Edit
// Retorno suprimido. Para visualizá-lo na íntegra, execute o código na sua máquina.
```

Conseguimos gerar a lista de músicas em C#, a partir do LINQ, tema que também abordamos ao longo do curso!

### Aula 5: Projeto final do curso

Aqui você pode [baixar o zip da Aula 05](https://github.com/alura-cursos/csharp-curso-4/archive/refs/heads/aula_5.zip) ou acessar os [arquivos no Github!](https://github.com/alura-cursos/csharp-curso-4/tree/aula_5)

### Aula 5: Referências

1. [Chamar uma API Web de um cliente .NET](https://learn.microsoft.com/pt-br/aspnet/web-api/overview/advanced/calling-a-web-api-from-a-net-client) (gratuito, português, documentação)

> Documentação oficial da Microsoft que apresenta conceitos sobre a utilização de uma Web API e exemplos de implementação.

2. [Usando Exceções](https://learn.microsoft.com/pt-br/dotnet/csharp/fundamentals/exceptions/using-exceptions) (gratuito, português, documentação)

> Documentação oficial da Microsoft que apresenta conceitos sobre exceções em C# e exemplos de implementação.

3. [LINQ (Consulta Integrada à Linguagem)](https://learn.microsoft.com/pt-br/dotnet/csharp/linq/) (gratuito, português, documentação)

> Documentação oficial da Microsoft que apresenta conceitos sobre LINQ e exemplos de implementação.

4. [Introdução a consultas LINQ](https://learn.microsoft.com/pt-br/dotnet/csharp/programming-guide/concepts/linq/introduction-to-linq-queries) (gratuito, português, documentação)

> Documentação oficial da Microsoft que apresenta conceitos sobre LINQ e um tutorial de implementação.

5. [Como gravar texto em um arquivo](https://learn.microsoft.com/pt-br/dotnet/standard/io/how-to-write-text-to-a-file) (gratuito, português, documentação)

> Documentação oficial da Microsoft que apresenta conceitos sobre criação de arquivos em C# e exemplos de implementação.

### Aula 5: Conclusão - Vídeo 7

Transcrição
Guilherme: Se você chegou até aqui, meus parabéns! Você está finalizando mais um curso na Alura! Daniel, nesse curso aprendemos várias coisas. O que somos capazes de fazer com esses conhecimentos?

Daniel: Agora você consegue pegar uma fonte de dados, independentemente de onde ela vier, e manipular as coleções por meio do LINQ, uma biblioteca muito importante que você usará bastante na sua carreira de dev.

No nosso caso, usamos uma API e HttpClient, mas essa fonte pode vir de banco de dados, de leitura de arquivos, ou da própria memória da aplicação.

Guilherme: Esses conceitos serão muito utilizados no dia a dia, não é?

Daniel: Sim, é muito comum!

Guilherme: Espero que você tenha gostado desse curso, se divertido, e aprendido bastante, consolidando ainda mais seus conhecimentos em C#.

Lembre-se de dar a sua nota ao final do curso e falar o que você mais gostou.

Nos encontramos em uma próxima oportunidade!
