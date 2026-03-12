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

### Aula 2:  - Vídeo 1
### Aula 2:  - Vídeo 2
### Aula 2:  - Vídeo 3
### Aula 2:  - Vídeo 4
### Aula 2:  - Vídeo 5
### Aula 2:  - Vídeo 6
### Aula 2:  - Vídeo 7
### Aula 2:  - Vídeo 8
### Aula 2:  - Vídeo 9
### Aula 2:
