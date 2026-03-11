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
Para acessar os dados dessa API, vamos acessar o GitHub da API de músicas e clicar no link para acessar o arquivo songs.json.

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

### Aula 1:  - Vídeo 3
### Aula 1:  - Vídeo 4
### Aula 1:  - Vídeo 5
### Aula 1:  - Vídeo 6
### Aula 1:  - Vídeo 7
### Aula 1:  - Vídeo 8
### Aula 1:  - Vídeo 9

