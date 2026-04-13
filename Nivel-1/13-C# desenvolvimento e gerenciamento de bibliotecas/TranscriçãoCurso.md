# Curso Alura: C# desenvolvimento e gerenciamento de bibliotecas

## Aula 1: O que são Bibiotecas

### Aula 1: Apresentação - Vídeo 1

Transcrição  
Olá! Meu nome é Vinícius Santos e serei seu instrutor no curso de Bibliotecas em Sechá.

Audiodescrição: Vinícius é um homem negro de 40 anos, com cabelo raspado. Ele usa óculos e veste uma camisa preta. Ao fundo, há uma parede com iluminação azul.

**Explorando o conteúdo do curso**  
Neste curso, vamos explorar como criar uma biblioteca, os conceitos de organização de bibliotecas, como publicar essa biblioteca em feed público e feeds privados, além de como deixá-la melhor organizada e documentada. Também abordaremos como utilizar bibliotecas no dia a dia. Preparamos um material muito interessante e estamos certos de que será do agrado de todos. Vamos aprender bastante nesta jornada, continuando a estudar e programar.

### Aula 1: Introdução às bibliotecas no .NET - Vídeo 2

Transcrição  
Olá, tudo bem? Ao estudarmos a orientação a objetos, abordamos os conceitos de reutilização de código, herança, interfaces e classes. Esses conceitos ganham ainda mais relevância quando começamos a discutir sobre bibliotecas.

As bibliotecas são conjuntos de funcionalidades organizadas em código para serem reutilizadas em diferentes projetos. Dessa forma, podemos incluir nessas bibliotecas classes, interfaces, métodos e outros recursos que serão reaproveitados, evitando a necessidade de desenvolvê-los novamente em projetos futuros.

**Exemplificando o uso de bibliotecas em sistemas**  
Vamos imaginar o seguinte cenário: estamos em uma organização que possui um sistema de vendas, um sistema de estoque e um sistema financeiro. Todos esses sistemas têm algo em comum: a necessidade de gerar relatórios CSV. Como resolver isso? Em vez de cada sistema ter sua própria forma de gerar um relatório CSV, podemos criar uma biblioteca específica para geração de relatórios CSV e distribuí-la para esses sistemas. Assim, desenvolvemos a funcionalidade uma única vez e a utilizamos em todos os sistemas.

Agora, imagine a seguinte situação: a empresa decide mudar o cabeçalho de todos os seus relatórios. Por algum motivo, a identidade visual da empresa mudou e isso precisa ser aplicado em todos os sistemas.

**Destacando as vantagens das bibliotecas**  
Se tivéssemos uma implementação para cada um dos sistemas, cada equipe teria que desenvolver sua própria solução para esse novo cabeçalho. Quando fazemos isso em uma biblioteca, precisamos apenas ajustar a biblioteca uma vez, redistribuí-la para os novos sistemas e tudo já estará aplicado. Assim, percebemos a grande vantagem de utilizar bibliotecas e distribuí-las não apenas dentro da nossa organização, mas também de forma pública.

A biblioteca nos proporciona vantagens como reutilização de código, organização e modularidade. Teremos um código mais organizado e modular. A manutenção torna-se muito mais fácil, pois não precisamos realizar um novo trabalho em cada sistema que requer atualização. Além disso, a distribuição do código é facilitada. Em vez de subir um arquivo de código e solicitar que seja copiado e ajustado em cada sistema, subimos a biblioteca, que já se encaixa perfeitamente em todos os projetos que a utilizam.

**Concluindo sobre o papel das bibliotecas**  
Resumindo, as bibliotecas, mais do que um conceito técnico, resolvem problemas reais nas empresas. Elas têm uma ligação direta com o que estudamos em Programação Orientada a Objetos: reutilização de código, hierarquia e distribuição desse código. Continuaremos explorando esse tema na próxima aula, quando veremos como buscar bibliotecas e utilizá-las em nosso projeto.

### Aula 1: Hierarquia de classes na plataforma Zoop - Exercício

A Zoop, uma plataforma de e-commerce que oferece soluções tecnológicas completas para vendedores online, incluindo gestão de estoque, pagamentos integrados e marketing digital, está desenvolvendo um novo recurso que permitirá aos vendedores personalizar suas lojas online com temas e layouts diferentes. A equipe de design criou várias opções de temas, mas a equipe de desenvolvimento precisa garantir que todos os temas sigam uma estrutura básica comum para facilitar a manutenção e futuras atualizações.

Como a equipe pode aplicar o conceito de hierarquia de classes para organizar os diferentes temas de forma eficiente?

Resposta:  
Criar uma classe base que defina a estrutura básica comum a todos os temas, incluindo elementos como cabeçalho, rodapé e layout de página, e implementar cada tema específico como uma subclasse que herda da classe base.

> Correta, pois essa abordagem permite que cada tema adicione ou modifique elementos específicos enquanto mantém a estrutura básica definida pela classe base. Isso facilita a manutenção, pois qualquer alteração na estrutura básica pode ser feita na classe base e automaticamente aplicada a todos os temas que herdam dela.

### Aula 1: Buscando e utilizando bibliotecas - Vídeo 3

Transcrição  
Olá, bem-vindos de volta. No nosso último vídeo, discutimos para que servem as bibliotecas, e agora vamos explorar como utilizá-las e sua utilidade na prática. Para isso, vamos considerar o seguinte exemplo: no Screensound, nosso velho conhecido, podemos ter a necessidade de transformar a lista de músicas que recebemos em um arquivo JSON. Se fizermos isso manualmente, precisaríamos pegar cada um dos atributos recebidos, colocá-los no formato JSON e concatenar linha por linha, o que seria um trabalho desnecessário, uma vez que o JSON já é um formato de dados amplamente utilizado. Felizmente, alguém já fez isso por nós. Por exemplo, existe uma biblioteca muito famosa e amplamente utilizada, a Newtonsoft, que serializa e desserializa formatos de JSON, transformando objetos em JSON e vice-versa.

**Adicionando referências de bibliotecas ao projeto**  
Existem algumas formas de adicionar essa referência ao nosso projeto. Ao utilizar a biblioteca, precisamos ir ao nosso projeto e adicionar essa referência. Existem formas distintas de fazer isso. A primeira, que é a mais antiga, consiste em referenciar e exportar diretamente a DLL, que é o arquivo de ligação dinâmica para o nosso código. Para isso, baixamos essa DLL do site da Newtonsoft ou a recebemos de outra forma, e então a adicionamos diretamente ao nosso computador. Vou mostrar como fazemos isso. Primeiro, abrimos o projeto. Com o projeto aberto, vamos à seção de dependências, se o Visual Studio estiver em português. Clicamos com o botão direito e selecionamos "adicionar referência ao projeto". Depois, procuramos a pasta no computador onde a DLL está armazenada. Após adicionar, clicamos em "ok" e já podemos utilizá-la.

Aqui está um exemplo de como a referência à DLL pode ser adicionada no arquivo de projeto:

```csharp
<ItemGroup>
  <Reference Include="Newtonsoft.Json">
    <HintPath>..\..\..\..\..\..\Users\alura\OneDrive\Área de Trabalho\Newtonsoft.Json.dll</HintPath>
  </Reference>
</ItemGroup>
```

**Utilizando o Nuget para gerenciar pacotes**  
Podemos perceber que essa forma de utilizar a biblioteca apresenta alguns problemas. Corremos o risco de ter uma biblioteca desatualizada, pois, se não a atualizarmos manualmente, ela não será atualizada. Também há o risco de adicionar uma DLL errada ou falsa, o que compromete a segurança do projeto. Felizmente, não precisamos mais fazer isso. Hoje, temos o gerenciador de pacotes do ecossistema .NET, o Nuget. A forma de adicionar bibliotecas aos nossos projetos, mantê-las atualizadas e garantir a segurança, sabendo quem é o autor dessas bibliotecas, é através do Nuget.

Para adicionar uma biblioteca via Nuget, com o projeto aberto, clicamos com o botão direito e selecionamos "gerenciar pacotes do Nuget". Ao clicar, uma tela de busca se abre. No nosso caso, queremos a Newtonsoft, então digitamos "Newtonsoft" para buscar. Ela aparecerá e já podemos instalá-la, tendo-a funcionando na nossa aplicação.

**Implementando a biblioteca Newtonsoft no projeto**  
Após adicionar a referência da biblioteca Newtonsoft ao nosso projeto, vamos ver como utilizá-la. Vamos até o arquivo onde precisamos gerar o arquivo CSV. Primeiro, utilizamos a palavra reservada using para importar a biblioteca, digitando Newtonsoft.

```csharp
using Newtonsoft;
```

No entanto, para trabalhar com JSON, precisamos ser mais específicos e importar o namespace correto:

```csharp
using Newtonsoft.Json;
```

Com ela no nosso arquivo, no método gerarArquivo, utilizamos o JsonConvert da Newtonsoft para gerar nosso screen em formato JSON sem precisar criar uma lógica para essa transformação. Vamos começar criando o método GerarArquivoJson:

```csharp
public void GerarArquivoJson()
{

}
```

Serializando objetos e salvando arquivos JSON
Agora, vamos adicionar a lógica para serializar o objeto e salvar o arquivo:

```csharp
string json = JsonConvert.SerializeObject(new
{
    nome = Nome,
    musicas = ListaDeMusicasFavoritas
});
string nomeDoArquivo = $"musicas-favoritas-{Nome}.json";

File.WriteAllText(nomeDoArquivo, json);
Console.WriteLine($"O arquivo Json foi criado com sucesso! {Path.GetFullPath(nomeDoArquivo)}");
```

Vamos passar rapidamente pelo que esse método faz. Declaramos um screenJson e utilizamos o serializador da Newtonsoft para transformar um objeto com o nome da lista de músicas e as listas de músicas em uma screen. Depois, criamos um arquivo, definimos seu nome e utilizamos a classe File para salvá-lo no computador. Após salvar, verificamos em qual pasta ele está guardado. Vamos executar rapidamente para ver o resultado final. Como podem ver, o Screensound fez a busca na nossa API, trouxe uma lista de músicas e informou que o JSON da lista de músicas foi salvo em uma pasta específica. Vamos acessar essa pasta para verificar o arquivo.

Agora, acessamos o caminho onde o arquivo JSON foi salvo. Ele está em músicasfavoritas.json. Vamos verificar seu conteúdo. Temos um arquivo com todo o conteúdo em formato JSON, pronto para ser utilizado por outra aplicação ou API que utilize esse formato de arquivo.

**Explicando o Nuget e suas funcionalidades**  
Mencionamos que para baixar pacotes de bibliotecas, podemos utilizar o Nuget, o gerenciador de pacotes da Microsoft. No entanto, não explicamos o que é exatamente o Nuget. O nuget.org é como um marketplace de bibliotecas, onde cada pessoa ou empresa que desenvolveu uma biblioteca a disponibiliza para que a comunidade de pessoas desenvolvedoras possa utilizá-la.

Podemos observar no site do NuGet que é possível buscar uma biblioteca, fazer o upload da nossa própria biblioteca e verificar quais pacotes estão disponíveis. Por exemplo, o Newtonsoft, um dos pacotes mais populares do NuGet, está no topo da lista, entre muitos outros que podemos utilizar.

**Considerando boas práticas ao utilizar bibliotecas**  
Devemos considerar algumas boas práticas ao utilizar bibliotecas. É importante prestar atenção à segurança do nosso código e garantir que ele não comprometerá a aplicação, especialmente se for uma aplicação grande em produção. Imagine baixar uma biblioteca incompatível e a aplicação parar de funcionar. Isso não pode acontecer. A primeira ação ao decidir baixar uma biblioteca é verificar sua compatibilidade com o nosso projeto.

No Visual Studio, podemos ver os critérios aos quais devemos estar atentos ao adicionar uma biblioteca ao projeto. Clicamos com o botão direito, gerenciamos o pacote do NuGet, e ele abrirá o conjunto de bibliotecas disponíveis. Por exemplo, ao acessar o Newtonsoft na aba de instalados, podemos verificar detalhes importantes. A primeira coisa a observar é a versão do .NET de dependência, verificando se é compatível com a versão do nosso projeto. No caso do nosso Screen Sound, ele foi escrito utilizando o .NET versão 6.0. Precisamos verificar se o Newtonsoft é compatível com o .NET 6.0. Nas dependências, vemos que ele utiliza o .NET 6.0, não requer dependências extras e é compatível com o nosso .NET. Assim, temos segurança para baixá-lo e garantir que funcionará no nosso projeto.

Outra verificação necessária é sobre o autor do projeto. Precisamos confirmar se o autor é confiável e reconhecido pela comunidade. No caso do Newtonsoft, o autor é confiável, como indicado pelo selo de verificação. Outras empresas também são verificadas. Por exemplo, ao procurar um pacote para acesso a banco de dados do MySQL Server, o MySQL Server Connector também é verificado. Isso garante que o pacote adicionado ao projeto é seguro.

**Verificando atualizações e vulnerabilidades de pacotes**  
Por último, devemos verificar as atualizações do pacote. Precisamos saber se o pacote recebe atualizações e se estão disponíveis. No caso do Newtonsoft, ao verificar mudanças de versão, constatamos que estamos utilizando a última versão. Se estivéssemos usando uma versão antiga, como a Crease.1, ela apareceria na aba de atualização, indicando que há uma atualização disponível. Precisamos avaliar se essa atualização é adequada para o nosso projeto e, se for, instalá-la.

Outro ponto importante sobre atualizações é que alguns pacotes podem estar vulneráveis. Podemos forçar o Newtonsoft a utilizar um pacote vulnerável, como a versão 12.03, que está marcada como vulnerável. Recebemos um aviso de que estamos utilizando um pacote vulnerável. Devemos atualizá-lo para a última versão, que já teve a vulnerabilidade corrigida, e adicioná-la ao nosso projeto.

**Garantindo a segurança do projeto**  
Falando em vulnerabilidades, podemos enfrentar problemas como a adição de um backdoor na aplicação, a entrada de vírus ou a exposição do servidor a riscos, tudo por utilizar uma biblioteca não confiável e vulnerável. Isso pode abrir portas para invasões no sistema. Portanto, é crucial escrever um código seguro e ter cuidado com as dependências utilizadas no projeto.

Com isso em mente, preparamos um checklist para verificar a segurança de uma biblioteca antes de adicioná-la ao projeto:

```csharp
✓ Owners: quem mantém o pacote?
✓ Tem verificação/badges?
✓ Qual o número de downloads?
✓ Repositório ativo no GitHub? Commits recentes? Issues respondidas?
✓ A licença é compatível com o seu uso?
✓ A versão do .NET é compatível com o Target Framework do meu projeto?
```

**Concluindo e próximos passos**  
Concluímos que vimos para que serve a biblioteca, como utilizá-la e os cuidados necessários ao adicioná-la ao projeto. Na próxima aula, trabalharemos na construção da nossa própria biblioteca, explorando os passos necessários para criá-la e reutilizá-la em outros projetos.

### Aula 1: Modularidade em sistemas de gestão da Clínica Médica Voll - Exercício

A Clínica Médica Voll, especializada em serviços médicos e exames, está expandindo seus serviços e precisa integrar novos sistemas de gestão para agendamentos, prontuários eletrônicos e faturamento. Cada um desses sistemas precisa acessar e atualizar informações de pacientes, mas a clínica quer evitar duplicação de código e inconsistências nos dados.

Como a equipe de TI da clínica pode utilizar o conceito de bibliotecas para garantir que todos os sistemas compartilhem e atualizem informações de forma eficiente e consistente?

Resposta:  
Desenvolver uma biblioteca centralizada que contenha classes e métodos para manipulação de dados de pacientes, servindo como um módulo comum para todos os sistemas de gestão utilizarem.

> Correta, pois ao criar uma biblioteca centralizada, a clínica garante que qualquer alteração na manipulação ou armazenamento de dados seja feita em um único local, promovendo consistência e facilitando a manutenção.

### Aula 1: Para saber mais: checklist para bibliotecas seguras

**Critérios de Confiabilidade**  
Quando se adiciona uma biblioteca a um projeto, é fundamental ter um olhar atento para diversos critérios de segurança e manutenção. Um checklist bem estruturado pode ajudar a garantir que a dependência escolhida não traga riscos à estabilidade ou à integridade do código. Entre esses critérios, destacam-se:

- Verificar o owner e a reputação do mantenedor, assegurando que pessoas ou organizações confiáveis estão por trás da biblioteca.
- Analisar as indicações e badges, que podem sinalizar se o pacote foi verificado e validado pela comunidade.
- Observar o número de downloads e a popularidade; pacotes amplamente utilizados tendem a ter uma comunidade ativa e menos vulnerabilidades inesperadas.

Avaliação Técnica e de Atualizações

Além dos aspectos sociais e de mercado, é importante mergulhar na parte técnica:

- Verifique se o repositório (por exemplo, no GitHub) está ativo, com commits recentes e respostas a eventuais issues. Um repositório abandonado pode não receber atualizações e correções de segurança.
- Consulte a licença de uso para garantir que a forma de utilização da biblioteca seja compatível com os objetivos e a política da aplicação. Licenças restritivas ou proprietárias podem impor limitações indesejadas.
- Confirme a compatibilidade do pacote com o target do seu projeto, como a versão do .NET Framework ou outras dependências técnicas. Problemas de compatibilidade podem resultar em falhas durante a compilação ou, pior, em tempo de execução.

Monitoramento Contínuo

Adotar um checklist não termina na escolha inicial. É recomendável manter um processo contínuo de monitoramento:

- Fique atento às atualizações disponíveis para o pacote, avaliando se alguma nova versão traz correções importantes ou, por outro lado, modificações significativas que demandem uma reavaliação.
- Esteja ciente das vulnerabilidades reportadas, utilizando ferramentas e alertas que identificam, de maneira proativa, possíveis riscos de segurança associados ao pacote.
- Utilizar um checklist robusto ao selecionar bibliotecas é uma prática que minimiza riscos e assegura que a manutenção do software seja mais tranquila, contribuindo para a escalabilidade e segurança do projeto a longo prazo.

### Aula 1: Faça como eu fiz: usar bibliotecas

Nesta aula, vimos como as bibliotecas facilitam a reutilização e organização do código, além de aprimorarem a manutenção com atualizações centralizadas.

Agora é o momento de praticar o que foi ensinado. Para isso:

- Revise os conceitos de bibliotecas e como elas aplicam os princípios de orientação a objeto.
- Adicione uma referência manual de uma DLL em um projeto para testar a inclusão de código externo.
- Utilize o Nuget para buscar, instalar e atualizar uma biblioteca (ex.: Newtonsoft).
- Implemente a serialização de um objeto em JSON utilizando métodos da biblioteca escolhida.
- Gere e salve um arquivo JSON a partir de dados do projeto, verificando o resultado.
- Verifique a compatibilidade, segurança e atualizações da biblioteca conforme os critérios aprendidos.

Se tiver alguma dúvida, contate-nos no fórum ou no Discord!

### Aula 1: O que aprendemos?

Nesta aula, aprendemos:

- O conceito e a importância das bibliotecas no desenvolvimento de software.
- As vantagens das bibliotecas, como reutilização de código e facilidade de manutenção.
- Impacto das bibliotecas na padronização de funcionalidades em empresas.
- Necessidade de transformar dados em formatos padrãos e como bibliotecas ajudam.
- Formas de adicionar bibliotecas: manualmente e via gerenciadores de pacotes.
- Como o Nuget melhora o gerenciamento de bibliotecas com segurança e atualizações.
- Uso da biblioteca Newtonsoft para manipulação de JSON.
- Boas práticas na escolha de bibliotecas seguras e verificação de vulnerabilidades.

## Aula 2: Criando uma biblioteca

### Aula 2: Criando uma biblioteca - Vídeo 1

Transcrição  
Olá, tudo bem? Bem-vindos de volta. Continuando nosso curso, na última aula comentamos sobre a importância das bibliotecas no .NET e o que são elas. Nesta aula, nosso foco será criar nossa própria biblioteca.

É interessante entendermos quando é necessário criar uma biblioteca. Anos atrás, trabalhávamos em uma empresa de tecnologia que fornecia sistemas de busca de passagens aéreas para algumas empresas. Precisávamos conectar com várias companhias aéreas, consultar a disponibilidade de passagens e, ao obter o retorno, apresentar no site e nos sites dos clientes. No entanto, enfrentávamos um problema: cada companhia aérea devolvia os dados das passagens em um formato diferente. Precisávamos formatar esses dados para um formato único e apresentá-los no site, o que gerava um desafio.

**Desenvolvendo uma solução com bibliotecas**  
Pensamos em como simplificar esse projeto e decidimos criar uma biblioteca própria para atender nossa necessidade. O formato que a companhia aérea nos devolvia era específico dela, mas o formato que precisávamos internamente era algo exclusivo nosso. Desenvolvemos uma biblioteca que consultava todas as companhias aéreas, recebia as informações, traduzia para nosso formato e, então, apresentávamos tanto no nosso site quanto nos sites dos clientes e até mesmo no aplicativo móvel que tínhamos. Isso nos permitiu centralizar uma lógica, alcançar um resultado interessante e distribuir esse resultado em diferentes sistemas.

Da mesma forma que resolvemos esse problema na empresa em que trabalhávamos, podemos aplicar isso ao Screensound e verificar qual problema ou funcionalidade podemos entregar a partir de uma biblioteca. Podemos pensar na necessidade do Screensound gerar relatórios sobre as músicas favoritas de cada usuário. Em vez de alterar o código do Screensound para fornecer essa funcionalidade, podemos criar uma nova biblioteca que gerará esses arquivos de relatório, e o Screensound simplesmente utilizará essa biblioteca. Teremos a vantagem de que essa biblioteca não será utilizada apenas no Screensound, mas poderá ser distribuída para diferentes projetos, funcionando da mesma forma.

**Explorando a programação orientada a objetos**  
Anteriormente na formação, estudamos sobre a programação orientada a objetos e as vantagens para a organização do nosso código que o paradigma nos traz. A criação de bibliotecas é um passo além de aplicar os conceitos de orientação a objetos no projeto, pois criamos novas funcionalidades com os conceitos de P.O. aplicados, mas distribuímos isso em diferentes projetos que poderão utilizar a lógica já encapsulada pela biblioteca, disponível para uso não só no Screensound, mas em qualquer outro projeto que seja interessante.

**Criando um projeto de biblioteca no Visual Studio**
Para compreendermos melhor o que está sendo discutido, vamos criar um primeiro projeto de biblioteca de classe utilizando o Visual Studio. Ao abrir o Visual Studio, teremos a opção de criar um novo projeto. Devemos clicar nessa opção e, em seguida, escolher o tipo de projeto. O projeto escolhido será uma biblioteca de classe, então podemos buscar por "biblioteca" e selecionar a biblioteca de classe compatível com C#, Android, Linux, Mac OS e Windows.

Após escolhermos esse tipo de projeto, avançamos e nomeamos nosso projeto como ReportGenerator, que será utilizado ao longo do curso.

```csharp
ReportGenerator
```

Definimos o nome do projeto e prosseguimos. O projeto será gerado no local já definido, mas esse local pode ser alterado, se necessário. Avançamos, escolhemos a versão do .NET a ser utilizada no projeto; no caso, utilizaremos a versão 8.0, que, embora não seja a mais recente, possui suporte de longo prazo. Para projetos reais, é indicado sempre utilizar a versão com suporte de longo prazo. Clicamos em criar, e o Visual Studio começa a montar nosso projeto.

Explorando a estrutura do projeto gerado
Ao final, o projeto estará montado. Veremos que ele foi criado apenas com um arquivo de classe, um arquivo de exemplo. Vamos dar uma olhada na estrutura inicial do nosso projeto:

```csharp
namespace ReportGenerator
{
    public class Class1
    {

    }
}
```

No entanto, se formos à pasta onde o projeto foi criado, veremos que outras estruturas foram geradas. Clicamos para abrir a pasta recipiente e observamos que há duas pastas: "BIM" e "OBJ". A pasta "OBJ" é temporária, contendo arquivos que o compilador e a IDE utilizam durante a compilação ou execução do código. Não é necessário interagir com essa pasta, pois ela é gerida pela IDE.

A pasta "BIM" é interessante, pois geralmente contém duas subpastas: "debug" e "release". A pasta "debug" é utilizada enquanto testamos o código, realizando execuções em modo de depuração, e contém arquivos que auxiliam nesse processo. Já a pasta "release" é onde estará a versão final do projeto, incluindo o .exe ou a .dll da biblioteca que estamos desenvolvendo.

**Compilando e distribuindo a biblioteca**
Vamos demonstrar como isso funciona. Com o projeto aberto, vamos apenas compilá-lo. Embora ele ainda não faça nada, ao compilar, veremos que alguns arquivos já foram gerados na pasta "debug", incluindo a .dll. No entanto, essa .dll ainda não está pronta para produção.

Para gerar a .dll pronta para distribuição, mudamos o tipo de execução para "release", clicamos novamente no projeto e recompilamos. Após a compilação, os arquivos serão salvos na pasta "release". É nessa pasta que encontraremos a .dll que será distribuída para uso em outros projetos.

Por enquanto, é isso que faremos. Na próxima aula, trabalharemos com nosso gerador de relatórios, acrescentando funcionalidades e utilidades. Até lá!

### Aula 2: Funcionalidades iniciais da biblioteca - Vídeo 2

Transcrição  
Olá, desenvolvedores. Vamos agora dar vida à nossa biblioteca, atribuindo-lhe uma função e tornando-a verdadeiramente útil. Começaremos criando uma primeira versão da nossa biblioteca, que será simples, mas com um propósito claro do que precisa fazer, ainda sem tanta flexibilidade. O que faremos? Vamos criar uma biblioteca que gerará relatórios no formato CSV. O CSV é um formato amplamente utilizado, que pode ser lido em vários sistemas operacionais, então vamos criar nossa biblioteca com esse formato, que é mais universal.

Como ela funcionará? A biblioteca receberá uma lista de dados, converterá esses dados para CSV e, em seguida, salvará o arquivo. Basicamente, essa será a função da nossa primeira versão: receber a lista, converter para CSV e salvar. Agora, vamos alterar nosso projeto para ver como ficará.

**Criando a classe ReporterGenerator**  
Com o Visual Studio aberto, vamos criar nossa primeira classe no projeto Reporter Generator, que vimos na última aula. Para criá-la, clicamos com o botão direito sobre o nome do projeto, vamos até "adicionar", escolhemos "novo item". Nossa classe será chamada de ReporterGenerator. Após clicar em adicionar, a classe já estará disponível. Vamos alterar o modificador dela de interno para public (público em inglês), pois pretendemos disponibilizá-la para que outras pessoas utilizem. Se mantivéssemos o modificador de acesso como interno, não ficaria disponível para outros usuários. Vamos mudar para public e começar a criar a primeira propriedade.

```csharp
namespace ReportGenerator
{
    public class ReporterGenerator
    {
    }
}
```

A primeira coisa que essa classe precisará é de um input de dados, que é a lista de dados mencionada anteriormente. Como faremos isso? Vamos criar uma propriedade pública, que será uma lista de dicionários. Vamos nomeá-la de Input, que são os dados de entrada. O que significa essa lista? Cada elemento será um dicionário com pares de chave e valor, representando uma linha do nosso relatório. As chaves desses dicionários serão todas iguais, representando o cabeçalho do nosso relatório.

```csharp
public List<Dictionary<string, string>> Input { get; set; }
```

Implementando o construtor e método de geração de relatório
Em seguida, vamos criar o construtor da classe ReporterGenerator. Será um construtor público, que receberá essa lista de input. Ao construir um objeto do tipo ReporterGenerator, já passaremos um input para ele. Ao passar esse input, definimos nosso input. Toda vez que criarmos um objeto do tipo ReporterGenerator, precisaremos passar um input de dados.

```csharp
public ReporterGenerator(List<Dictionary<string, string>> input)
{
    Input = input;
}
```

Agora, vamos criar nosso método que gerará o relatório em si, executando o que precisamos. Vamos nomeá-lo como GenerateReport, e ele devolverá uma string. Essa string será o caminho do arquivo salvo. Não precisaremos passar nenhum parâmetro para ele, pois o input já está no objeto. Já passamos o input ao criar o objeto.

```csharp
public string GenerateReport()
{
    if (Input == null || Input.Count == 0)
    {
        throw new Exception("Input de dados invalido");
    }
}
```

O que faremos agora? A primeira coisa é verificar se esse input é válido, se foi passada alguma informação ou se é nulo. Faremos um condicional: se o input for nulo ou input.count for igual a zero, dispararemos uma exceção, pois está sendo utilizado em um momento errado. Vamos criar uma nova exceção com a mensagem "input de dados inválido". Quando alguém criar um ReporterGenerator e passar um input sem dados ou vazio, essa exceção será disparada, e a pessoa desenvolvedora precisará tratar esse erro no programa.

**Construindo o relatório CSV**  
Se estiver tudo certo, continuaremos. A primeira coisa que faremos agora é criar um StringBuilder. Nesse StringBuilder, concatenaremos cada linha do nosso relatório. Vamos chamá-lo de report, pois é para isso que será utilizado, e seguindo boas práticas, variáveis precisam ter nomes claros que definam sua função.

```csharp
StringBuilder report = new StringBuilder();
```

A primeira coisa que faremos é pegar o cabeçalho, ou as chaves, para definir o cabeçalho do nosso relatório. Como faremos isso? Sabemos que a lista está populada, então o primeiro elemento existe. Vamos acessar o primeiro elemento da lista Input, que é um dicionário, e obter as chaves com .Keys. Para juntar tudo em uma única string, utilizaremos a função String.Join. Definimos o delimitador, que será um ponto e vírgula, e passamos uma lista de valores em string, que será transformada em uma única string.

```csharp
string header = string.Join(';', Input.First().Keys);
report.AppendLine(header);
```

Utilizando o método String.Join, evitamos criar um laço para ler todas as chaves presentes no dicionário, simplificando bastante o código. A string resultante será chamada de header. Vamos declarar uma variável header que receberá essa string resultante. Em seguida, o nosso StringBuilder, o report, receberá esses valores, já tendo a primeira linha do nosso relatório.

**Adicionando registros e salvando o arquivo**  
Agora, vamos adicionar as linhas com os registros do nosso relatório. Para isso, utilizaremos o foreach. O foreach irá, para cada elemento da nossa lista, executar uma ação. Então, foreach vai record, in, Input. Ele faz um laço de foreach, implicitamente entendendo que, para cada elemento dentro desse Input, uma ação será executada. A ação que vamos executar agora é semelhante ao que fizemos com o cabeçalho, mas, neste caso, com elementos de linha, com registros já existentes.

```csharp
foreach(var record in Input)
{
    string line = string.Join(";", record.Values);
    report.AppendLine(line);
}
```

Vamos, mais uma vez, utilizar o String, e chamaremos agora de line, que será igual a String.Join. Em vez de fazer isso com as chaves, faremos com os valores do dicionário. Após isso, precisamos fazer o append no string builder do relatório. A partir desse momento, já temos nossos dados convertidos para o formato CSV. O próximo passo é salvar esse CSV em um arquivo físico no computador, pois até o momento está tudo na memória. Utilizaremos a classe File do .NET e o método WriteAllText.

```csharp
File.WriteAllText("report.csv", report.ToString());
return Path.GetFullPath("report.csv");
```

O que fazemos aqui? Passamos o nome do arquivo, que chamaremos de report.csv, e o conteúdo desse arquivo, que está dentro do nosso string builder do relatório. Então, report, e passamos para string. Após isso, esse método devolverá o caminho completo onde salvamos esse relatório. O que faremos agora? Colocaremos o return, chamaremos novamente a classe Path, e utilizaremos o método GetFullPath, passando o nome do relatório, que é report.csv. Nesse momento, temos a primeira versão da nossa biblioteca pronta e funcional. Agora precisamos ver como podemos utilizá-la.

**Utilizando a biblioteca em outro projeto**  
Como explicado anteriormente, uma biblioteca não é autoexecutável, ela não gera um .exe, mas sim um arquivo chamado .dll, que não podemos executar diretamente. Podemos importar esse arquivo em outro projeto que gerará um .exe para ver seu funcionamento. Já criamos anteriormente um POC para realizar esse teste, que tem a seguinte função: criamos alguns registros com nome, idade e cidade das pessoas, e precisamos converter isso para um .csv e salvá-lo em um arquivo.

Como faremos isso? A primeira coisa que precisamos fazer, como estamos em outro projeto e não no mesmo projeto do nosso gerador de relatórios, é importar nossa biblioteca. Já explicamos como fazer a importação de biblioteca, pegando diretamente a referência .dll ou a partir do Nuget. Ainda não publicamos esse projeto no Nuget, então podemos pegar pela .dll, mas há uma forma mais fácil quando se trabalha dentro da mesma solução, que é o nosso caso.

Vamos fazer o seguinte: clicamos no nosso projeto, que será o usuário da biblioteca, com o botão direito, em dependências, e adicionamos uma referência de projeto. Clicamos em adicionar referência de projeto, e vemos que dentro da nossa solução já existe o gerador de relatórios. A partir do momento que adicionamos o gerador de relatórios, nosso projeto anterior já consegue entender e visualizar as funcionalidades que ele provê. Assim, já conseguimos fazer essa chamada do gerador de relatórios.

**Executando o programa e verificando o resultado**  
Vamos ver agora como proceder. Dentro do arquivo program e do nosso console, a primeira coisa que precisamos fazer é o using, para que nosso programa entenda o gerador de relatórios. Fazemos o using, passando o nome do namespace do gerador de relatórios, e já conseguiremos fazer uso dessa biblioteca.

```csharp
using ReportGenerator;
```

Após definir o using, vamos utilizar nosso gerador de relatórios. Nesta linha, começamos a digitar ReporterGenerator, ReporterGenerator, é new ReporterGenerator, passando os dados que criamos anteriormente, nosso dicionário com as informações de pessoas, idade e cidade.

```csharp
List<Dictionary<string, string>> data = new()
{
    new Dictionary<string, string>
    {
        { "Nome", "Alice" },
        { "Idade", "30" },
        { "Cidade", "São Paulo" },
    },
    new Dictionary<string, string>
    {
        { "Nome", "Roberto" },
        { "Idade", "25" },
        { "Cidade", "Salvador" },
    },
    new Dictionary<string, string>
    {
        { "Nome", "Carlos" },
        { "Idade", "35" },
        { "Cidade", "Rio de Janeiro" }
    }
};

ReporterGenerator reporterGenerator = new ReporterGenerator(data);
```

Depois de criar o objeto ReporterGenerator, precisamos efetivamente salvar o arquivo do nosso relatório. Vamos fazer reporterGenerator.GenerateReport. Como fizemos no GenerateReport, esse método devolverá o caminho físico do arquivo que salvamos. Vamos recuperar esse caminho para exibir na tela e verificar o que foi salvo.

```csharp
string caminhoArquivo = reporterGenerator.GenerateReport();
Console.WriteLine("O arquivo foi salvo em: " + caminhoArquivo);
```

Certo? Esta é apenas uma demonstração rápida. Agora, vamos executar e ver o resultado final. Clicamos em executar nosso console, ele executa, e já terminou o programa, mas escreveu: "O arquivo foi salvo em" e o caminho. Agora, vamos buscar esse caminho e ver o que há dentro dele. Abrimos o explorador de arquivos, vamos para a pasta indicada onde o arquivo foi salvo. Temos aqui um arquivo report, vamos ver seu conteúdo. Abrimos e conseguimos ver as informações que salvamos, no formato CSV, delimitado por ponto e vírgula, que também podemos abrir utilizando o Excel. Abrimos com Excel, e aqui está nosso relatório.

Vemos que a biblioteca, mesmo simples, já agrega valor ao nosso projeto, e conseguimos extrair alguma utilidade dela. Nosso próximo passo é evoluí-la, tornando-a mais flexível e expansível, o que faremos na próxima aula.

### Aula 2: Otimizando a gestão de inventário com bibliotecas - Exercício

A UseDev, um e-commerce especializado em produtos geeks, enfrenta dificuldades na gestão de seu inventário devido à variedade de fornecedores, cada um com seu próprio formato de dados para envio de informações sobre produtos e estoque. A empresa contratou você para desenvolver uma solução que permita a integração desses dados de forma eficiente e padronizada.

Como a criação de uma biblioteca poderia ajudar a UseDev a resolver esse problema e melhorar a gestão de seu inventário?

Resposta:  
Desenvolvendo uma biblioteca dedicada à integração de dados de fornecedores, que processa e converte os dados de inventário para um formato padronizado, facilitando a integração de novos fornecedores e promovendo consistência no sistema de gestão de inventário da UseDev.

> Correta, pois a biblioteca centraliza a lógica de conversão de dados, permitindo que novos formatos sejam facilmente adicionados e reutilizados em diferentes partes do sistema, melhorando a eficiência e a consistência.

### Aula 2: Tornando a biblioteca flexível e expansível - Vídeo 3

Transcrição  
Agora, já temos a primeira versão da nossa biblioteca criada, mas podemos melhorá-la. Podemos torná-la mais flexível e robusta, promovendo uma evolução. De que forma podemos fazer isso? Podemos definir algumas funcionalidades adicionais para a nossa biblioteca. Vamos definir como serão os cabeçalhos da nossa biblioteca e do nosso relatório. Podemos fazer a exportação de diferentes tipos de objetos, e não apenas de dicionários, além de formatar os dados, como datas, horários e valores monetários. Podemos adicionar esse tipo de funcionalidade na biblioteca, escolher os delimitadores, pois o CSV não aceita apenas ponto e vírgula como delimitador; ele também aceita vírgula, pipeline, espaço, entre outros. Muitas vezes, isso depende de onde estamos utilizando. Por exemplo, nos EUA, o delimitador do CSV costuma ser uma vírgula, e não ponto e vírgula.

Também podemos adicionar no arquivo que criamos alguns metadados, como informações do autor e a data de criação do arquivo. Essas são evoluções que podemos considerar e adicionar na nossa biblioteca de geração de relatórios. O objetivo é torná-la expansível e flexível, tornando-a mais robusta e útil. Atualmente, ela grava apenas arquivos CSV, mas no futuro, poderia gravar arquivos em formato Excel, PDF, JSON. Podemos criar muitos formatos diferentes a partir dessa biblioteca, o que pode ser um desafio para o futuro, com base no que vimos na nossa aula.

**Utilizando boas práticas de programação orientada a objetos**  
Dito isso, como podemos alcançar esse objetivo e tornar nossa biblioteca mais expansiva, trazendo mais funcionalidades para ela? Vamos utilizar boas práticas de programação orientada a objetos. Vamos criar interfaces para definir como os relatórios serão criados, implementar essas interfaces seguindo um padrão concreto e ter um código pronto para uma evolução futura, disponibilizando-o não só dentro da nossa própria organização, mas também para a comunidade na internet.

No vídeo anterior, criamos a classe ReportGenerator dentro do nosso projeto, mas ela não é tão expansível assim. Como vamos resolver isso? O primeiro passo é definir uma interface para o nosso ReportGenerator. Vamos criar um novo arquivo no projeto ReportGenerator, clicar com o botão direito e adicionar um novo item. Vamos chamar esse arquivo de IReportGenerator, e ele será uma interface.

**Definindo a interface IReportGenerator**  
Inicialmente, definimos a interface de forma interna:

```csharp
internal interface IReportGenerator
{
}
```

No entanto, para que ela seja acessível externamente, alteramos o modificador de acesso para público:

```csharp
public interface IReportGenerator
{
}
```

Dentro da IReportGenerator, vamos definir o concreto, ou seja, o que as classes que implementarem essa interface precisam ter. A primeira coisa que nossa interface precisa ter é o input data. Vamos definir que ela precisa ter uma lista de dados de entrada:

```csharp
List<Dictionary<string, string>> Input { get; set; }
```

Para adicionar mais funcionalidades ao nosso relatório, podemos definir um título para o relatório, pois geralmente os relatórios têm um título que os identifica. Vamos adicionar um título, que é necessário:

```csharp
string Title { get; set; }
```

Também vamos adicionar o cabeçalho desse relatório, uma descrição, algo que destaque o relatório:

```csharp
string HeadLine { get; set; }
```

Outra funcionalidade que podemos adicionar é um rodapé:

```csharp
string FooterLine { get; set; }
```

Além disso, o IntelliSense está nos sugerindo que escrevamos o método generateReport, que devolverá um screen:

```csharp
string GenerateReport();
```

Com todos esses elementos, nossa interface IReportGenerator fica assim:

```csharp
public interface IReportGenerator
{
    List<Dictionary<string, string>> Input { get; set; }
    string Title { get; set; }
    string HeadLine { get; set; }
    string FooterLine { get; set; }
    string GenerateReport();
}
```

**Implementando a interface na classe CSVReportGenerator**  
Agora, vamos modificar a classe CSVReportGenerator que já criamos, para que ela implemente essa interface. Inicialmente, a classe é definida assim:

```csharp
public class CSVReporterGenerator
```

Vamos modificá-la para implementar a interface IReportGenerator:

```csharp
public class CSVReporterGenerator: IReportGenerator
```

No momento em que fizemos isso, um erro foi apontado. O motivo desse erro é que não estamos implementando todos os elementos concretos do IReportGenerator. Não temos o título, o subtítulo (headline), nem o rodapé (footerline). Vamos adicionar essas propriedades à nossa classe:

```csharp
public string Title { get; set; }
public string HeadLine { get; set; }
public string FooterLine { get; set; }
```

Agora que adicionamos as opções de título, subtítulo e rodapé ao nosso relatório, vamos utilizá-las para que tenham efeito no que estamos desenvolvendo. A primeira coisa que faremos é adicionar o título, continuando o nosso código do generateReport. Na primeira linha, vamos verificar se o título foi definido. Usaremos if screen.isNullOrWhitespace e negaremos, para garantir que não seja nulo nem apenas um espaço em branco. Essa função da classe Screen é interessante, pois considera quando há apenas um espaço em branco. Se a condição for atendida, adicionaremos o título ao nosso relatório:

```csharp
if(!string.IsNullOrWhiteSpace(Title))
{
    report.AppendLine(Title);
    report.AppendLine("");
}
```

**Adicionando subtítulo e rodapé ao relatório**  
Em seguida, verificaremos o subtítulo, que seria o subtítulo do nosso relatório. Se ele foi informado, também o adicionaremos ao relatório:

```csharp
if(!string.IsNullOrWhiteSpace(HeadLine))
{
    report.AppendLine(HeadLine);
    report.AppendLine("");
}
```

Podemos adicionar um espaço para separar o título do subtítulo e do conteúdo. Vamos expandir report.appendLine para adicionar um espaço, criando uma quebra de linha entre eles. O mesmo faremos com o subtítulo, adicionando appendLine.

Agora que adicionamos tanto o título quanto o subtítulo ao relatório, voltamos para a implementação que já estava pronta. O cabeçalho foi criado, e após ele, adicionaremos cada linha do relatório. No final, verificaremos se foi passado algum rodapé para o nosso dicionário. Se sim, adicionaremos esse rodapé ao relatório:

```csharp
if(!string.IsNullOrWhiteSpace(FooterLine))
{
    report.AppendLine("");
    report.AppendLine(FooterLine);
}
```

**Salvando o relatório e ajustando a codificação**  
Passamos para a parte de salvar o relatório, criar o arquivo e devolver o caminho completo, como já fazíamos anteriormente. Para garantir que os caracteres especiais sejam exibidos corretamente, podemos especificar a codificação ao salvar o arquivo:

```csharp
File.WriteAllText("report.csv", report.ToString(), Encoding.UTF8);
```

Com as modificações na nossa biblioteca, adicionando mais funcionalidades ao gerador de relatórios, vamos alterar nosso programa de teste, nosso POC, para que ele utilize essas novas funcionalidades. Após criar o objeto reportGenerator, vamos definir o título do nosso relatório:

```csharp
reporterGenerator.Title = "Relatório de Pessoas";
```

Podemos também definir o subtítulo ou a descrição do relatório, como "lista de pessoas cadastradas no sistema":

```csharp
reporterGenerator.HeadLine = "Lista de pessoas cadastradas no sistema";
```

Por fim, definimos o rodapé, como "total de pessoas", utilizando a quantidade de dados que temos com data.count:

```csharp
reporterGenerator.FooterLine = "Total de pessoas: " + data.Count;
```

**Executando e verificando o relatório gerado**  
Com tudo isso pronto, estamos prontos para executar e verificar como ficou o nosso novo relatório. Salvamos, executamos, e o relatório foi salvo na pasta, como vimos anteriormente. Acessamos a pasta, copiamos o caminho do console, e verificamos o relatório. O arquivo está lá, com o título "Relatório de Pessoas", a lista de pessoas cadastradas no sistema, o cabeçalho com nome, idade e cidade, e totalizando a quantidade de pessoas.

Notamos que alguns caracteres especiais ficaram diferentes, uma questão de encode. Podemos modificar o encode de saída do nosso relatório. Quando abrimos pelo bloco de notas, não há problema com os caracteres especiais, mas podemos ajustar isso ajustando a codificação do nosso código. Voltamos para a classe, e no momento em que o arquivo será salvo, podemos passar o encode como um parâmetro. Fazendo isso, o arquivo será salvo com os caracteres no formato que o Excel entenderá. Executamos novamente e verificamos o resultado. Desta vez, os caracteres especiais ficaram corretos.

Outro ponto importante na definição da nossa biblioteca é deixá-la bem documentada e definir claramente quais pontos serão acessíveis para os usuários, qual lógica deve ficar encapsulada e não será acessível, e como facilitar o entendimento de como funciona cada classe e método. Continuaremos explorando isso no próximo vídeo.

### Aula 2: Flexibilizando a exportação de dados na Jornada Viagens
 Próxima Atividade

A Jornada Viagens, uma plataforma tecnológica especializada na comparação e reserva de pacotes de viagens, está buscando melhorar a forma como os dados de pacotes de viagens são exportados para seus parceiros comerciais. Atualmente, a plataforma só exporta dados em formato CSV, mas a equipe de desenvolvimento, da qual você faz parte, foi encarregada de tornar essa funcionalidade mais flexível e robusta. A ideia é permitir que os dados possam ser exportados em diferentes formatos, como Excel, PDF e JSON, para atender às diversas necessidades dos parceiros.

Considerando as boas práticas de programação orientada a objetos, qual abordagem você adotaria para estruturar essa funcionalidade de forma que a plataforma possa facilmente adicionar novos formatos de exportação no futuro?

Resposta:  
Definir uma interface, como IExportadorDeDados, que declare métodos necessários para exportar dados, como Exportar(). Cada formato de exportação (CSV, Excel, PDF, JSON) deve ter sua própria classe que implemente essa interface, garantindo que todas sigam um padrão comum.

> Correta, pois essa abordagem permite que novos formatos sejam adicionados no futuro sem alterar o código existente, apenas criando novas classes que implementem a interface. Isso promove a reutilização de código e facilita a manutenção e expansão da funcionalidade.

### Aula 2: Controlando o acesso - Vídeo 4

Transcrição  
Até o momento, já criamos nossa biblioteca do gerador de relatórios, definimos suas funcionalidades e realizamos testes. Agora, precisamos dar dois passos importantes no desenvolvimento de uma biblioteca. O primeiro é definir o que será interno, ou seja, não acessível por outras pessoas desenvolvedoras, e o que estará disponível na API pública. Isso significa determinar quais métodos e classes estarão acessíveis para que outras pessoas desenvolvedoras utilizem nossa biblioteca. Além disso, é essencial documentá-la adequadamente para que seja de fácil entendimento para quem a utilizar, explicando o significado de cada classe e método disponibilizado.

O primeiro passo é definir quais são as APIs públicas da nossa biblioteca, ou seja, os métodos e classes que ficarão acessíveis para outras pessoas desenvolvedoras. Quando alguém inserir nossa biblioteca em seu projeto, conseguirá acessar esses métodos e classes, podendo até herdar e expandir as funcionalidades que criamos. O outro ponto a definir é o que ficará privado, ou seja, a lógica que deve ser mantida sem que ninguém que utilize nossa biblioteca tenha acesso ou conhecimento do que está sendo feito.

**Utilizando modificadores de acesso no C#**  
No C#, podemos definir o que será interno e o que estará na API pública utilizando os modificadores que a linguagem disponibiliza. O modificador public expõe a informação para fora da biblioteca, permitindo que qualquer pessoa desenvolvedora a visualize. Isso pode incluir classes, interfaces, métodos, propriedades, entre outros.

```csharp
public → expõe algo para quem está fora da biblioteca.
```

O modificador internal faz com que a propriedade, classe ou interface fique disponível apenas dentro do assembly da nossa biblioteca, ou seja, apenas dentro do projeto da biblioteca, não ficando acessível para quem utilizar a biblioteca, mas apenas para quem for dar manutenção e alterar o código.

```csharp
internal → limita a visibilidade apenas dentro do assembly da biblioteca.
```

Outra forma é utilizar os modificadores protected e virtual, que são úteis quando trabalhamos com herança ou classes virtuais que podem ser divididas em mais de um arquivo.

```csharp
protected / virtual → permitem extensões controladas em classes derivadas.
```

O modificador private define que a informação deve ser acessível apenas dentro da classe, impedindo que outras pessoas desenvolvedoras visualizem o que foi marcado como private. No entanto, quem precisar de manutenção ou alteração no código conseguirá visualizar essa informação se estiver dentro da própria classe.

```csharp
private → restringe completamente para uso interno da classe.
```

Outro modificador é o sealed, que impede a criação de heranças de uma classe, não permitindo que se crie uma classe herdeira que, além de herdar as funcionalidades, faça alguma implementação adicional. Marcar uma classe como selada é útil para aumentar a segurança da biblioteca.

```csharp
sealed → impede que uma classe seja herdada, garantindo estabilidade.
```

**Criando interfaces e classes internas**  
Voltando ao nosso projeto, podemos criar algumas classes ou interfaces que serão utilizadas apenas internamente e não serão disponibilizadas. Por exemplo, a interface iReportGenerator é pública, permitindo que quem utilizar nossa biblioteca visualize essa interface, suas propriedades e métodos. Da mesma forma, a classe que implementa iReportGenerator, que é a CSVReportGenerator, também estará disponível para quem utilizar a biblioteca.

Vamos criar uma nova interface de formatação. Para isso, clicamos com o botão direito no nome do projeto, adicionamos um novo item e o chamamos de iDataFormatter. Definimos essa interface como interna, o que significa que as funções desse formatador de dados estarão disponíveis apenas internamente na nossa biblioteca.

```csharp
namespace ReportGenerator
{
    internal interface IDataFormatter
    {
    }
}
```

Quando a biblioteca precisar formatar algum dado, ela acessará essa interface, mas isso não ficará disponível para quem estiver utilizando a biblioteca. A partir dessa interface que criamos, vamos desenvolver um método de formatação de resultado que receberá uma string e devolverá uma string. Esse método retornará a string em formato de data, recebendo apenas a string e não os dados inteiros.

```csharp
string FormatData(string input);
```

**Implementando a classe DateFormatter**  
Agora, vamos criar uma classe que implementará essa interface, chamada DateFormatter. Adicionamos um novo item, definimos como uma classe interna e indicamos que ela implementa o IDataFormatter.

```csharp
namespace ReportGenerator
{
    internal class DateFormatter : IDataFormatter
    {
    }
}
```

Precisamos implementar o método de formato de data. O IntelliSense nos ajudou com o Copilot, que sugeriu um código utilizável. Esse código recebe um input, verifica se é compatível com o formato de DateTime e, se for, formata no padrão ano, mês e dia.

```csharp
public string FormatData(string input)
{
    if(DateTime.TryParse(input, out DateTime date))
    {
        return date.ToString("yyyy-MM-dd");
    }
    return input;
}
```

Podemos ajustar para o formato brasileiro: dia, mês, e ano, com dois dígitos para dia e mês, e quatro dígitos para o ano.

```csharp
return date.ToString("dd/MM/yyyy");
```

Assim, sempre que uma informação compatível com o formato de DateTime for passada, ela será devolvida nesse formato de dia, mês e ano.

**Integrando DateFormatter ao gerador de relatórios**  
Voltando à nossa classe CSVReportGenerator, podemos adicionar isso ao final do nosso relatório. Toda vez que gerarmos um relatório, criaremos um objeto DateFormatter e passaremos um valor para que ele devolva.

```csharp
DateFormatter dateFormatter = new DateFormatter();
dateFormatter.FormatData(DateTime.Now.ToString());
```

Utilizamos DateFormatter.formatData com DateTime.now, a data de hoje, e adicionamos isso como uma nova linha no relatório.

```csharp
report.Append(dateFormatter.FormatData(DateTime.Now.ToString()));
```

No programa de teste, continuamos observando que o DateFormatter não está disponível e não conseguimos visualizá-lo, mesmo utilizando o namespace do Hipótese Generator. No entanto, internamente, ele está marcando a data no relatório gerado. Essa função pode ser utilizada para adicionar algum tipo de arquivo ou assinatura que identifique quem gerou o arquivo, sem que a pessoa desenvolvedora que estiver utilizando tenha controle para modificar.

**Preparando para a documentação e publicação**  
Com tudo pronto, não precisamos alterar o código, apenas verificar o resultado. Executamos, salvamos o relatório na mesma pasta, acessamos o arquivo e verificamos o resultado. Observamos que ele adicionou o total de pessoas e, no final, colocou a data, conforme esperado. Isso está fora do controle da pessoa desenvolvedora que utiliza a nossa biblioteca.

Nosso próximo passo, agora que definimos o que é acessível na nossa biblioteca, é documentá-la para prepará-la para publicação. Isso será feito no próximo vídeo.

### Aula 2: Documentando e preparando para uso externo - Vídeo 5

Transcrição  
Agora que já definimos os pontos de acesso da nossa biblioteca, o que está disponível pela API e o que é acessível apenas internamente, chegamos a um passo importante: realizar a documentação da nossa biblioteca. Isso é essencial para que, quando ela for publicada, seja de fácil entendimento para os usuários e para outras pessoas desenvolvedoras, permitindo que compreendam tanto a função da biblioteca quanto o que cada método executa.

Para isso, utilizaremos o padrão de documentação do C#, que é feito a partir do XML. Esse método é muito simples de ser utilizado. Na sua classe, basta digitar três barras acima do nome da interface, como IReportGenerator, por exemplo, e ele já abrirá uma tag de sumário. Vamos começar documentando a interface:

```csharp
/// <summary>
/// 
/// </summary>
public interface IReportGenerator
```

**Aceitando sugestões do Copilot para documentação**  
Nessa tag de sumário, devemos descrever o que essa interface faz. O IntelliSense, ou Copilot, já nos fornece uma sugestão do que escrever. Vamos aceitar essa sugestão para tornar o processo mais dinâmico.

```csharp
/// <summary>
/// Defines the contract for generating reports with customizable input, title, headline, and footer.
/// </summary>
/// <remarks>Implementations of this interface allow users to configure report data and metadata, such as
/// the title, headline, and footer, and generate a report as a string.</remarks>
public interface IReportGenerator
```

Precisamos, então, escrever essa mesma documentação para cada propriedade existente dentro da interface, aceitando as sugestões do Copilot conforme vamos escrevendo. Vamos começar com a propriedade Input:

```csharp
/// <summary>
/// Gets or sets the input data as a list of dictionaries, where each dictionary represents a row of
/// key-value pairs.
/// </summary>
List<Dictionary<string, string>> Input { get; set; }
```

Documentando propriedades e métodos  
Agora, com Title:

```csharp
/// <summary>
/// Gets or sets the title associated with the current object.
/// </summary>
string Title { get; set; }
```

E por último, o nosso método GenerateReport. Além de ter o sumário descrevendo o que esse método faz, ele possui a tag returns, que descreve o que está retornando. Inicialmente, a descrição estava incorreta, pois, na verdade, ela deveria conter a pasta onde o relatório foi salvo. Vamos ajustar isso para descrever corretamente o que está sendo feito.

```csharp
/// <summary>
/// Generates a report and returns its file path.
/// </summary>
/// <returns>A string containing the generated report's file path.</returns>
string GenerateReport();
```

**Utilizando a documentação com IntelliSense**  
Assim, GenerateReportPath indica a pasta onde o relatório foi salvo, FirePath.

Onde isso terá efeito? Quando formos utilizar a nossa biblioteca, a classe que implementa essa interface já permitirá que o IntelliSense faça a leitura dessa documentação e apresente isso para a pessoa programadora. Por exemplo, ao apertar o título, podemos escolher a propriedade, e ele já nos mostra uma descrição do que esse título faz. Assim, get ou set é o título associado a um objeto. O mesmo acontece com o headline. Quando decidimos utilizá-lo, o IntelliSense já consegue ler a documentação e apresentar qual é a função dessa propriedade.

Ainda mais importante é o método GenerateReport. Ele indicará que gera um relatório e o retorna como uma string. Podemos ajustar essa descrição, pois é exatamente isso que ele faz.

**Corrigindo a descrição do método GenerateReport**  
Gera-se o relatório e retorna-se como uma string. No entanto, na verdade, não estamos retornando o relatório como string, mas sim o caminho do arquivo. Portanto, geramos o relatório e retornamos o caminho do arquivo. Quando voltarmos aqui, veremos que a descrição do que será devolvido foi modificada. Esse é um passo muito importante para realizar a documentação XML em todo o código, para que fique claro o que está acontecendo e para guiar a pessoa desenvolvedora que irá utilizá-lo.

**Documentando informações de autoria e versionamento**  
Outro ponto importante é documentar o projeto com informações de autoria, versionamento e descrição. Como faremos isso? Vamos editar as propriedades do nosso projeto para definir a autoria e o título. Para isso, clicamos com o botão direito sobre o nome do projeto, report generator, e escolhemos propriedades. Em propriedades, vamos para as informações de pacote. A primeira tag que podemos definir é o título. Vamos chamá-lo de Alura report generator.

Depois disso, definimos os autores e a versão do nosso relatório. Atualmente, nosso relatório está na versão 1.0. É importante prestar atenção na forma de nomear a versão, pois cada ponto separa algo. O 1.0 é a versão principal (major), que pode indicar uma quebra de compatibilidade com versões anteriores. O segundo dígito, após o primeiro ponto, define o incremento de funcionalidades. Por exemplo, se inicialmente tínhamos a geração do relatório via CSV e passamos a ter a geração via PDF, saímos do 1.0 para 1.1, 1.2 e assim por diante, sempre que uma nova funcionalidade for adicionada sem provocar incompatibilidade com versões anteriores. O último conjunto de números é utilizado para correções de bugs, como primeira correção de bug 1, segunda correção de bug 2, e assim por diante.

**Finalizando a documentação e ajustes**  
Além disso, podemos definir o nome da empresa, que será Alura, e adicionar uma descrição ao nosso pacote. Por último, definimos o tipo de licença associada à nossa biblioteca, podendo ser pública, padrão ou proprietária. Após realizar essas documentações e ajustes, teremos uma biblioteca encapsulada, documentada e versionada.

Nosso próximo passo é utilizar essa biblioteca em um projeto externo, o que faremos no próximo vídeo, utilizando nossa biblioteca no Screensound.

### Aula 2: Para saber mais: CSV - interoperabilidade e simplicidade

**A Estrutura do CSV**  
O CSV, sigla para Comma-Separated Values, é um formato de arquivo texto que organiza dados em linhas e colunas de maneira simples. Cada linha do arquivo representa um registro, e os valores são separados por um delimitador, normalmente a vírgula, embora outros caracteres, como ponto e vírgula, possam ser usados conforme a convenção adotada. Essa estrutura minimalista permite que arquivos CSV sejam gerados e lidos por diversas linguagens e ferramentas, contribuindo para a interoperabilidade entre sistemas.

**Como Funciona a Organização dos Dados**  
Em um arquivo CSV, a definição do delimitador é essencial. Ao escrever ou ler um CSV, deve-se considerar:

- O delimitador escolhido: deve ser consistente ao longo do arquivo e adequado ao conjunto de dados.
- O tratamento de campos que contenham o caractere delimitador, que geralmente envolve o encapsulamento dos dados em aspas.
- A possibilidade de linhas de dados conterem quebras de linha internas, que precisam ser corretamente interpretadas para não confundir a divisão dos registros.

Essa abordagem simplificada torna o CSV uma opção leve e fácil de ser implementada, sem a necessidade de estruturas complexas de metadados ou anotações.

**Vantagens e Cuidados ao Utilizar CSV**  
A simplicidade do CSV traz diversas vantagens:

- Facilidade de Uso: Qualquer linguagem de programação oferece suporte básico para manipulação de strings, tornando a leitura e a escrita em CSV acessível.
- Interoperabilidade: Programas de planilhas, bancos de dados e até sistemas operacionais conseguem trabalhar com esse formato sem grandes adaptações.
- Leveza: Sendo um arquivo de texto, os arquivos CSV costumam ter um tamanho reduzido, facilitando o armazenamento e transferência de dados.

Contudo, há cuidados necessários ao optar pelo CSV:

- Consistência de Formatação: A ausência de um padrão único pode levar a variações na forma como os campos são delimitados ou encapsulados, exigindo um tratamento especial em ambientes que possam ter mais de uma fonte de dados.
- Limitações na Complexidade: Dados com estrutura mais profunda, como hierarquias ou listas aninhadas, podem precisar ser raspados a um formato plano, o que nem sempre é eficiente ou claro.

Ao compreender esses detalhes, desenvolvedores podem decidir quando o uso do CSV é a solução mais prática para a troca de informações entre sistemas, considerando tanto suas facilidades quanto suas limitações.

### Aula 2: Faça como eu fiz: Relatórios CSV

Nesta aula, desenvolvemos uma biblioteca para geração de relatórios em CSV, evoluindo sua estrutura para torná-la flexível, robusta e bem documentada.

Agora é a sua vez de revisar e aplicar os conceitos vistos nesta aula, se ainda não colocou em prática. Para isso:

- Analise a importância de criar uma biblioteca para centralizar lógicas de negócio.
- Crie um projeto do tipo Biblioteca de Classe no Visual Studio.
- Configure o projeto definindo nome, caminho, versão e build (Debug e Release).
- Compile o projeto para gerar a DLL pronta para distribuição.
- Implemente a funcionalidade básica de conversão de uma lista de dados em arquivo CSV.
- Adicione propriedades para título, headline e rodapé no relatório.
- Refatore a classe para implementar a interface IReportGenerator.
- Crie uma interface de formatação para padronizar a conversão dos dados internos.
- Utilize modificadores de acesso (public, internal e private) para definir a API pública da biblioteca.
- Implemente um formatador interno para datas, garantindo formatação correta.
- Gere, salve e valide o relatório, ajustando parâmetros de encode se necessário.
- Documente toda a biblioteca utilizando o padrão XML e configure metadados de versão e autoria.

Se tiver alguma dúvida, contate-nos no fórum ou no Discord!

### Aula 2: O que aprendemos?

Nesta aula, aprendemos:

- A motivação para criar bibliotecas personalizadas e o processo técnico de criação no Visual Studio.
- A estrutura de pastas e o processo de compilação de bibliotecas, distinguindo modos de depuração e liberação.
- O desenvolvimento de uma biblioteca para gerar relatórios CSV, incluindo a conversão e salvamento de arquivos.
- A melhoria de bibliotecas existentes com boas práticas de orientação a objetos e interfaces.
- A importância dos modificadores de acesso para definir a API pública e partes internas da biblioteca.
- Como documentar bibliotecas usando o padrão XML do C# e o uso do IntelliSense.
- A edição das propriedades do projeto para incluir informações de título, autoria e versão.
- O versionamento semântico de bibliotecas, indicando mudanças e compatibilidades.

## Aula 3: Consumindo bibliotecas

### Aula 3: Projeto da aula anterior

Na aula anterior, criamos um projeto Class Library para a nossa biblioteca de geração de relatórios, adicionamos suas primeiras funcionalidades e flexibilizamos para uma expansão futura, por nós ou por outros usuários. Para conferir o projeto desenvolvido e, se quiser, baixá-lo para começar daqui, [acesse o repositório do curso no GitHub.](https://github.com/alura-cursos/AluraReportGenerator/tree/video_2.5)

### Aula 3: Adicionando referência à biblioteca - Vídeo 1

Transcrição  
Bem-vindos de volta. Agora, já temos a nossa biblioteca Riposte de Direito criada e pronta para ser utilizada. Vamos utilizá-la no nosso projeto Screensound.

Comentamos nas primeiras aulas que existem algumas formas de inserir a referência da biblioteca no projeto. A primeira é adicionar a própria referência de projeto que está dentro da mesma solução, como vimos enquanto estávamos desenvolvendo a biblioteca Riposte de Direito. A segunda é a partir do Nuget, o que não poderemos fazer agora, pois ainda não publicamos a nossa biblioteca no Nuget.

**Adicionando a referência de DLL ao projeto Screensound**  
A terceira forma é a partir da referência de DLL diretamente, que é o que faremos neste momento com o nosso projeto Screensound.

Abrindo o projeto Screensound, vamos na parte de dependências, clicamos com o botão direito e adicionamos a referência de projeto. Na caixa de diálogo que se abriu, vamos em procurar, clicamos no botão procurar novamente e iremos na pasta da nossa biblioteca Riposte de Direito.

Na pasta bin dela, há duas pastas: a pasta "debug" e a pasta "release". A pasta "release" é onde estará o nosso binário, a nossa DLL que está pronta para ser utilizada. Então, abrimos a pasta "release" e aqui está o nosso Riposte de Direito. Adicionamos ele ao projeto, e agora está pronto para ser utilizado no nosso projeto.

Como faremos isso será abordado no próximo vídeo.

### Aula 3: Gerenciamento de dependências em sistemas de agendamento médico - Exercício

A Clínica Médica Voll, especializada em serviços médicos e exames, está desenvolvendo um sistema de agendamento online para seus pacientes. A equipe de TI, da qual você faz parte, decidiu utilizar uma biblioteca interna para gerenciar as dependências do sistema, mas essa biblioteca ainda não foi publicada em um repositório público.

Quais são as implicações de utilizar uma referência de DLL direta para essa biblioteca no projeto da Clínica Médica Voll, e como isso pode impactar a manutenção e atualização do sistema de agendamento?

Resposta:  
Utilizar uma referência de DLL direta para a biblioteca interna implica que a equipe terá controle total sobre a versão da biblioteca utilizada, mas também precisará gerenciar manualmente as atualizações, substituindo o arquivo DLL no projeto sempre que houver uma nova versão. Isso pode impactar a manutenção, mas permite testes antes de adotar novas versões.

> Correta, pois essa abordagem oferece controle sobre as versões e a possibilidade de testes, mas exige um processo manual para atualizações, impactando a manutenção.

### Aula 3: Usando classes e métodos da biblioteca - Vídeo 2

Transcrição  
Bem, agora já adicionamos a referência da nossa biblioteca RepostGenerator no ScreenSound e já podemos utilizá-la para criar um relatório a partir dos dados do ScreenSound. Como faremos isso?

O primeiro passo que devemos realizar, utilizando o Visual Studio, é adicionar a referência da nossa biblioteca na classe que vamos utilizar, no caso, na classe Programmer. Vamos fazer o using e chamar o RepostGenerator. A partir desse momento, já temos acesso às classes da biblioteca RepostGenerator e aos seus respectivos métodos.

```csharp
using ReportGenerator;
```

**Preparando os dados para o relatório**  
No ScreenSound, já foi feita uma consulta para a API e recebemos como resposta uma lista de músicas cadastradas nessa API. O que faremos agora é o seguinte: a partir dessa lista de músicas, vamos gerar um relatório em CSV.

A primeira coisa que faremos é transformar esses dados no formato que o RepostGenerator entende, que, no nosso caso, é uma lista com dicionários com chaves em screen. Começamos criando essa lista, escrevendo list. É uma lista de dicionários, e vamos povoar essa lista.

```csharp
List<Dictionary<string, string>> reportData = new List<Dictionary<string, string>>();
```

Iremos povoar essa lista a partir do que está na lista de músicas. Para cada música na lista de músicas, o Compilot já nos sugeriu criar esse dicionário com nome do artista, gênero e tonalidade da música e adicionar à nossa lista de dados. Parece uma boa sugestão, então vamos aceitá-la e seguir com nosso exemplo.

```csharp
foreach (var musica in musicas)
{
    var record = new Dictionary<string, string>
    {
        { "Nome", musica.Nome },
        { "Artista", musica.Artista },
        { "Genero", musica.Genero },
        { "Tonalidade", musica.Tonalidade }
    };
    reportData.Add(record);
}
```

**Gerando o relatório CSV**  
Para tanto, agora vamos criar um objeto RepostGenerator. RepostGenerator é igual a new csvRepostGenerator, passando nossos dados, passando o RepostData. A partir desse momento, a única coisa que...

```csharp
IReportGenerator reportGenerator = new CSVReporterGenerator(reportData);
```

Precisamos agora solicitar que o nosso RepostGenerator gere o nosso arquivo. Quando ele gera o arquivo, devolve uma string com o local onde esse arquivo foi guardado. Então, criamos uma string local para receber essa informação do nosso método GenerateReport.

```csharp
string local = reportGenerator.GenerateReport();
```

**Verificando o resultado e considerações finais**  
Uma vez feito isso, nosso projeto já está pronto para rodar e verificar qual será o resultado dessa execução. Clicamos em executar, o projeto é executado e fechado. Vamos agora à pasta do nosso projeto para ver como ficou o relatório. Verificando na pasta, já temos um arquivo report. Vamos abri-lo.

Ao abrir, já temos um relatório com todas as músicas que vieram da nossa API, incluindo o nome da música, nome do artista, gênero e tonalidade. Precisamos salvar. Dessa forma, vemos que a biblioteca RepostGenerator já trouxe uma utilidade para o nosso projeto Screenshot, sem que precisássemos escrever o código ou a lógica para gerar o relatório em CSV.

Uma coisa muito importante é que ainda podemos aprimorar o que essa biblioteca RepostGenerator nos gera, a partir de necessidades específicas do nosso projeto Screenshot. Observem que a biblioteca RepostGenerator, do jeito que a fizemos, salva todos os arquivos com o mesmo nome, report.csv. Já pensou, então, em ao invés de aceitar que ela salve sempre os arquivos com o mesmo nome, passarmos a informar como queremos que o nome do arquivo seja gravado? Essa é uma extensão que podemos criar, sem alterar a biblioteca RepostGenerator, mas no nosso próximo projeto do Screenshot. Isso é o que veremos na próxima aula.

### Aula 3:  Escolha de métodos de integração para otimizar a experiência do usuário - Exercício

A Calmaria Spas, uma plataforma que conecta usuários a experiências de bem-estar e serviços de spas, oferecendo agendamentos online e personalização de tratamentos de relaxamento, está implementando um novo recurso para permitir que usuários personalizem suas experiências de spa com base em preferências pessoais. A equipe de desenvolvimento, da qual você faz parte, precisa integrar uma biblioteca que processa dados de preferências dos usuários para gerar recomendações personalizadas.

Considerando que a biblioteca ainda não está disponível no Nuget, quais são os fatores que a equipe deve considerar ao escolher entre adicionar uma referência de projeto ou uma referência de DLL direta, e como essa escolha pode afetar a experiência do usuário final?

Resposta:  
A equipe deve considerar a facilidade de atualização e controle de versão, optando por uma referência de projeto se a biblioteca estiver em desenvolvimento ativo, pois isso permite atualizações frequentes e trabalho direto com o código-fonte, embora possa aumentar o tempo de compilação.

> Correta, pois escolher uma referência de projeto em um cenário de desenvolvimento ativo facilita a manutenção e atualização da biblioteca, garantindo que as recomendações personalizadas sejam precisas e rápidas, o que melhora a experiência do usuário final.

### Aula 3: Para saber mais: template method pattern e extensão

**O que é o Template Method Pattern**  
O Template Method Pattern é um padrão de projeto comportamental que define a estrutura de um algoritmo em uma classe base, deixando que subclasses redefinam alguns passos específicos sem alterar a estrutura geral. Em outras palavras, a classe base contém o "esqueleto" do algoritmo e delega detalhes para seus derivados. Isso promove a flexibilidade e a reutilização, pois a lógica principal não é alterada, enquanto partes específicas podem ser customizadas conforme as necessidades.

**Como o padrão auxilia na extensão de bibliotecas**  
Ao desenvolver uma biblioteca, é comum definir comportamentos padrão que atendam a um conjunto de casos de uso. No entanto, aplicações podem demandar pequenas variações sem que seja necessário modificar o código original da biblioteca. Nesse ponto entra o Template Method Pattern: ao estruturar a biblioteca com métodos marcados como "virtual" ou abstratos para determinados passos, a classe base garante uma funcionalidade consistente e, ao mesmo tempo, permite que desenvolvedores criem subclasses que alterem apenas os comportamentos necessários.

Esta abordagem reforça o princípio de que classes devem estar abertas para extensão, mas fechadas para modificação – um dos pilares dos conceitos de design de software. Assim, é possível manter a integridade do código original enquanto se cria soluções customizadas para necessidades específicas.

**Exemplo prático em C#**  
Imagine uma biblioteca que gera relatórios CSV. A classe base implementa a lógica completa para converter dados em arquivo, mas sempre gera um arquivo com o mesmo nome. Um desenvolvedor pode querer alterar esse comportamento sem modificar o código da biblioteca. Para isso, seria possível definir um método virtual que determina o nome do arquivo:

```csharp
public abstract class CsvReportGenerator
{
    protected List<Dictionary<string, object>> reportData;

    public CsvReportGenerator(List<Dictionary<string, object>> data)
    {
        reportData = data;
    }

    // Método Template que define o algoritmo
    public string GenerateReport()
    {
        // Passo 1: Gerar o arquivo CSV
        string defaultFile = "report.csv";
        // Lógica para gerar e salvar o arquivo
        SaveReport(defaultFile);

        // Passo 2: Permitir customização no nome final
        string customFileName = GetOutputFileName(defaultFile);
        // Exemplo: mover o arquivo para o nome customizado
        System.IO.File.Move(defaultFile, customFileName);

        return System.IO.Path.GetFullPath(customFileName);
    }

    // Método a ser redefinido pelas subclasses
    protected virtual string GetOutputFileName(string defaultName)
    {
        return defaultName; // comportamento padrão
    }

    private void SaveReport(string fileName)
    {
        // Lógica que converte os dados e salva o CSV
    }
}

// Implementação customizada que altera o nome do arquivo
public class CustomCsvReportGenerator : CsvReportGenerator
{
    public CustomCsvReportGenerator(List<Dictionary<string, object>> data) : base(data) { }

    protected override string GetOutputFileName(string defaultName)
    {
        return "musicas.csv";
    }
}
```

Nesse exemplo, a classe base define o fluxo completo de geração do relatório, enquanto a subclasse "CustomCsvReportGenerator" redefine apenas o método que determina o nome final do arquivo. Essa separação de responsabilidades torna a biblioteca mais flexível e facilita futuras manutenções.

**Benefícios e desafios**  
Utilizar o Template Method Pattern em bibliotecas oferece diversas vantagens, como a preservação da lógica central da aplicação e a possibilidade de extensões sem risco de afetar funcionalidades já testadas. Por outro lado, é importante documentar bem as partes que podem ser personalizadas, para evitar ambiguidades e garantir que novos desenvolvedores entendam quais pontos são seguros para a extensão.

Este padrão é uma das abordagens que viabilizam a criação de bibliotecas robustas e adaptáveis, permitindo que o mesmo código-base atenda a diferentes cenários sem a necessidade de modificações diretas.

### Aula 3: Faça como eu fiz: usar e ampliar biblioteca

Nesta aula, vimos como integrar a biblioteca RepostGenerator ao projeto Screensound e como estender suas funcionalidades para gerar relatórios personalizados.

Agora é sua vez de colocar em prática os conceitos dessa aula, se ainda não o fez. Para isso:

- Adicione a referência de DLL da biblioteca ao projeto Screensound: abra o Visual Studio, vá até a pasta de dependências, adicione a referência e converta os dados da API em uma lista de dicionários para gerar o relatório CSV.
- Crie uma nova classe que herde da biblioteca RepostGenerator, implemente um método para renomear o arquivo gerado com um nome personalizado (ex.: musicas.csv) e atualize a chamada no programa principal para utilizar essa nova funcionalidade.

Se tiver alguma dúvida, contate-nos no fórum ou no Discord!

### Aula 3: O que aprendemos?

Nesta aula, aprendemos:

- Como adicionar uma biblioteca ao projeto no Visual Studio através de uma referência a um arquivo DLL.
- A importância de escolher a versão release do binário para produção.
- Como transformar dados em uma lista de dicionários para geração de relatórios CSV.
- A criação de arquivos CSV a partir de dados estruturados.
- A possibilidade de estender funcionalidades sem modificar diretamente a biblioteca existente.
- A criar uma nova classe que herda de uma existente para estender funcionalidades.
- O conceito de sobrecarga de métodos para adicionar funcionalidades adicionais.
- O uso de File.Move e Path.GetFullPath para manipular e obter informações de arquivos.

### Aula 4: Publicando bibliotecas no NuGet

### Aula 4: Projeto da aula anterior

Na aula anterior, adicionamos referência à nossa biblioteca geradora de relatórios no projeto ScreenSound, utilizamos e estendemos suas funcionalidades. Para conferir o projeto desenvolvido e, se quiser, baixá-lo para começar daqui, [acesse o repositório do curso no GitHub.](https://github.com/alura-cursos/AluraReportGenerator/tree/video_3.3)

### Aula 4: O que é o NuGet? Por que publicar? - Vídeo 1

Transcrição  
Olá, pessoas desenvolvedoras, sejam bem-vindas de volta. Nas aulas anteriores, vimos como o Nuget nos auxilia a consumir bibliotecas disponíveis em feeds públicos ou privados. Agora, vamos discutir como o Nuget pode nos ajudar a distribuir nossas próprias bibliotecas.

Precisamos entender a importância de publicar nossas bibliotecas. A publicação permite a reutilização interna de funcionalidades desenvolvidas dentro de nossa empresa, possibilitando que outras equipes as utilizem sem a necessidade de refazer ou criar versões diferentes. Além disso, há o compartilhamento com a comunidade, onde podemos criar algo de valor e perceber seu potencial para que outras pessoas utilizem, alcançando um público mais amplo.

**Destacando a padronização e centralização**  
A padronização e centralização também são aspectos importantes. Ao desenvolvermos uma biblioteca padronizada e centralizada, saberemos como algo deve ser feito. Por exemplo, se criarmos uma biblioteca de geração de relatórios, saberemos que, dentro de nossa organização, os relatórios sempre serão gerados de uma maneira específica.

Por fim, a facilidade de distribuição que o Nuget nos proporciona é um ponto crucial.

**Explorando formas de publicação com o Nuget**  
Em vez de compartilhar por e-mail ou colocar em alguma pasta, temos um sistema robusto que nos auxilia a compartilhar nossa biblioteca, inclusive mostrando mudanças de versão e extend logs (registros estendidos). Existem duas formas de publicar e utilizar o Nuget. Podemos utilizar o Nuget a partir de um feed público, que é o mais tradicional, sendo o gerenciador de pacotes oficial do ecossistema .NET. Também podemos fazer isso a partir de um feed privado, quando desenvolvemos algo que não é interessante distribuir para o público em geral, mas apenas dentro da nossa própria organização.

**Utilizando o GitHub para publicação**  
Existem alguns produtos que utilizam o protocolo do Nuget, como o Azure, o GitHub e o MyGet. No nosso caso, vamos utilizar o GitHub para descrever nosso pacote, nossa biblioteca geradora de relatórios. Utilizar o Nuget para publicar suas bibliotecas e pacotes é uma forma de transformar algo que desenvolvemos em algo reutilizável e útil para outras pessoas.

**Preparando para a próxima etapa**  
No próximo vídeo, veremos como começar a montar um pacote Nuget e deixá-lo pronto para ser distribuído, tanto em um feed público quanto em um feed privado. Nos vemos em breve!

### Aula 4: Publicação de bibliotecas para otimizar a adoção de animais - Exercício

Considerando o contexto da ADOPET, um site de adoção de animais de estimação, qual das alternativas abaixo descreve corretamente como a publicação de bibliotecas internas pode beneficiar a organização em termos de eficiência e padronização, e quais seriam os passos essenciais para garantir sua boa gestão e atualização?

Resposta:  
A publicação de bibliotecas internas permite a reutilização de código, economizando tempo e recursos, e padroniza funcionalidades, garantindo que todas as equipes sigam as mesmas diretrizes. Para garantir boa gestão, é necessário desenvolver com modularidade, documentar bem, publicar em um feed privado, implementar versionamento semântico e estabelecer um canal de feedback.

> Correta, pois essa alternativa descreve de forma abrangente os benefícios da publicação de bibliotecas internas e os passos essenciais para sua gestão e atualização, conforme discutido no contexto da ADOPET.

### Aula 4: Configurando e publicando pacote NuGet no feed público - Vídeo 2

Transcrição  
Novamente, estamos aqui para discutir a importância do Nuget, como ele nos auxilia tanto no consumo quanto na distribuição de nossas bibliotecas em formato de pacote. Agora, vamos entender como criar um pacote, gerar nosso pacote a partir da nossa biblioteca e também como publicar esse pacote no feed público do Nuget.

Primeiramente, o que é um pacote? Um pacote é um arquivo gerado que pode ser criado a partir do Visual Studio por linha de comando, com a extensão .nupkg. Esse arquivo é, na verdade, um arquivo compactado no formato zip, contendo os binários da nossa biblioteca compilada, além de um arquivo de metadados com informações sobre a biblioteca. É esse arquivo zip que enviamos para o Nuget, permitindo que outras pessoas desenvolvedoras possam consumir nossa biblioteca.

**Gerando o arquivo Nuget no Visual Studio**  
Vamos agora ver os passos necessários para gerar esse arquivo Nuget, o pacote .nupkg. Ao abrir o Visual Studio, no Gerenciador de Soluções, clicamos com o botão direito no nome do projeto e escolhemos a opção de pacote. Quando escolhemos essa opção, o pacote gerado é exibido, mostrando o local onde foi gravado. Por exemplo, podemos ver report generator.1.0.0.nupkg.

Existem alguns pontos importantes que devemos considerar. O primeiro é garantir que o modo de compilação do Visual Studio esteja na opção release, pois estamos gerando uma versão final da biblioteca, não uma versão para depuração. Outro ponto importante é abrir o projeto, clicando duas vezes nele, para acessar o arquivo do projeto em formato XML. Precisamos definir algumas informações essenciais para que o Nuget valide nosso pacote.

**Configurando o arquivo de projeto**  
Para isso, vamos configurar o arquivo de projeto com as informações necessárias. Aqui está um exemplo de como podemos definir essas propriedades:

```xml
<PropertyGroup>
  <TargetFramework>net8.0</TargetFramework>
  <ImplicitUsings>enable</ImplicitUsings>
  <Nullable>enable</Nullable>
  <Title>Alura Report Generator</Title>
  <Authors>Professor Vinícius</Authors>
  <Version>1.0.0</Version>
  <Company>Alura</Company>
  <Description>Biblioteca de geração de relatórios da Alura</Description>
</PropertyGroup>
```

A primeira informação é o package id. Devemos escolher um package id único para nosso pacote. No exemplo, começamos com o projeto chamado report generator, mas esse nome é comum. Para evitar duplicidade, renomeamos para Alura_Underline_Report_Generator, indicando que é um pacote específico da Alura. Aqui está como podemos definir o PackageId:

```xml
<PackageId>Alura_ReportGenerator</PackageId>
```

**Definindo a licença e o arquivo README**  
Outras informações importantes incluem definir a versão do pacote, o autor, uma descrição e a licença de uso. Escolhemos a licença padrão MIT, criando um arquivo de licença com o texto padrão do MIT, explicando como o pacote pode ser utilizado, copiado e modificado. Veja como podemos definir a licença:

```xml
<PackageLicenseExpression>MIT</PackageLicenseExpression>
```

E aqui está o texto da licença MIT que devemos incluir:

```xml
MIT License

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
```

Devemos também incluir um arquivo readme na pasta da solução, contendo informações sobre o pacote, como utilizá-lo, como baixá-lo, o site do repositório e o site do projeto. Essa é uma exigência do nugget.org. Aqui está um exemplo de como o arquivo README.md pode ser estruturado:

```csharp
# Alura Report Generator

Alura Report Generator is a .NET 8 project designed to generate reports using a console application (`ConsoleReport`).

## Projects

### ConsoleReport
A console application that utilizes the `ReportGenerator` library to create and display reports.

### ReportGenerator
A library that provides functionality for generating reports in various formats.

## Features
- Generate reports in multiple formats.
- Easy-to-use console interface.
- Modular design with a reusable library.

## Requirements
- .NET 8 SDK

## Getting Started

1. Clone the repository:

   git clone https://github.com/your-repo/AluraReportGenerator.git

## Publicando o pacote no Nuget

Com tudo isso configurado, salvamos as alterações. Novamente, no Gerenciador de Soluções, clicamos com o botão direito e escolhemos a opção de pacote. Na saída, veremos que foi gerado um novo pacote com o novo nome e `package id` que escolhemos, `Alura_Underline_Report_Generator`.

Agora, precisamos saber como enviar esse pacote para o Nuget, para que ele fique disponível no feed público. A primeira etapa é acessar o site nugget.org. Dentro do site, precisamos fazer login. No canto superior direito, clicamos em *sign in*. Para fazer o login no Nuget, é necessário ter uma conta Microsoft. Caso não possua, será necessário criar uma conta Microsoft.

## Criando e utilizando a chave de API

Escolhemos fazer *sign in* (entrar) no NuGet com nossa conta Microsoft, selecionamos a conta e acessamos o NuGet. Agora, surge a questão de como enviar nosso pacote a partir do Visual Studio ou da linha de comando. Para isso, o NuGet precisa confirmar a identidade de quem está enviando o pacote, o que requer autenticação. Essa autenticação é feita por meio de uma *API key* (chave de API) que geramos no próprio site do NuGet. Vamos mostrar como criar essa chave.

No site do NuGet, no canto superior direito, clicamos no nome de usuário e selecionamos a opção *API keys*. Na tela de *API keys*, escolhemos a opção de criar uma nova chave. Definimos um nome para a chave, por exemplo, "Alura Repost Generator", e estabelecemos um período de expiração, como um dia. O proprietário será nós mesmos. Definimos o escopo da chave, que pode incluir o envio de novos pacotes e novas versões. Escolhemos essa opção e determinamos o tipo de permissão de acesso. A chave poderá trabalhar com todos os pacotes que já possuímos, então colocamos um asterisco no campo *globe pattern*. Em vez de escolher um pacote específico, clicamos em *create* (criar). Após um breve momento, a chave de API é criada.

É importante ter cuidado com essa chave. Uma vez criada, devemos guardá-la e não compartilhá-la, pois qualquer pessoa com acesso a ela poderá publicar bibliotecas em nosso nome, o que representa um risco de segurança. Com a chave criada, vamos ao Visual Studio para publicar nosso pacote.

## Enviando o pacote para o Nuget

No Visual Studio, abrimos o console do PowerShell do desenvolvedor e digitamos o seguinte comando para enviar o pacote:

dotnet nuget push ReportGenerator/bin/Release/Alura_ReportGenerator.1.0.0.nupkg --source "https://api.nuget.org/v3/index.json" --api-key oy2j7fwi546j4apclcnapcquaibfb7e3d30fnmou5yma
```

Após inserir o comando, pressionamos "Enter" e aguardamos a resposta, que foi de sucesso. Nosso pacote foi enviado para o NuGet.

Após o envio, o NuGet leva cerca de cinco minutos para validar e listar o pacote. Precisamos aguardar esse tempo para verificar o status no site do NuGet, acessando novamente o NuGet.org. No site, clicamos no nosso nome no canto superior direito e escolhemos a opção Manage Packages. Entramos na pasta que lista todos os pacotes publicados. Após aguardar cerca de dois a três minutos, nosso pacote já está disponível. Ele ainda não possui certificado e está como não listado. Podemos editá-lo para que seja listado, selecionando a opção de listar nas buscas de resultado e salvando. Assim, ele passa a ser um pacote listado.

**Verificando o pacote no Visual Studio**  
Voltamos ao Visual Studio para verificar se conseguimos visualizar o pacote no NuGet do Visual Studio. No gerenciador de soluções, na opção dependências, selecionamos gerenciar pacotes do NuGet. Na parte de pesquisa, digitamos o nome do nosso pacote para verificar se ele aparece nos resultados. O pacote já está listado nos resultados.

Neste vídeo, vimos como criar um pacote, o que é necessário para que ele seja publicado, como publicá-lo no feed público do NuGet e como recuperá-lo para uso em nossos projetos. No próximo vídeo, veremos como realizar esse processo em um feed privado, em vez de no feed público. É o que abordaremos em breve.

### Aula 4: Publicando no feed privado - Vídeo 3

Transcrição  
No vídeo anterior, criamos um pacote Nuget, publicamos esse pacote no feed público do Nuget, e agora precisamos aprender como criar e publicar esse pacote em um feed privado. Vamos entender como criar um feed privado e como publicar um pacote nele, pois existem situações em que não é interessante que uma biblioteca criada por nós fique disponível para o público. Isso pode ser estratégico para a nossa organização. Como procederemos?

Nesta aula, utilizaremos o feed privado do GitHub, que é bastante popular entre as pessoas desenvolvedoras. Vamos utilizá-lo como exemplo, mostrando o passo a passo para realizar uma publicação no feed do GitHub.

**Criando uma API key no GitHub**  
A primeira coisa que precisamos fazer é criar uma API key para o nosso usuário. Para isso, acessamos o site do GitHub, vamos ao nosso perfil no canto superior direito, clicamos no ícone do usuário e escolhemos a opção settings. Na página de configurações, rolamos até o final e escolhemos develop settings. Ao entrar na página de develop settings, selecionamos a opção no menu à esquerda, personal access tokens, e vamos para os tokens clássicos.

Na página de tokens clássicos, escolhemos a opção de gerar um novo token. Aqui, é importante prestar atenção, pois ao clicar nessa opção, o site do GitHub pergunta novamente qual tipo de token queremos. Precisamos especificar que queremos gerar um novo token clássico. Se gerarmos o outro tipo de token, o fine grained, não funcionará. Portanto, geramos um token clássico, damos um nome para ele, como "Alura Report Generator", e escolhemos um escopo para ele. No caso deste token, o escopo é o de pacotes, tanto de escrita (write) quanto de leitura.

**Gerando e armazenando o token**  
Definimos também um período de validade para o token. Vamos colocar um período customizado, com validade de um dia. Após escolhermos, clicamos em gerar token. É importante lembrar que o token gerado pelo GitHub será exibido apenas uma vez. Portanto, precisamos copiá-lo e guardá-lo em um lugar seguro. Se perdermos esse token, será necessário gerá-lo novamente, e tudo o que já tiver sido feito com o token anterior deixará de funcionar. É crucial copiar e guardar o token em um local seguro.

Agora, voltamos ao Visual Studio. Uma vez que criamos nossa API key no GitHub, vamos publicar o nosso pacote, mas desta vez no nosso feed privado, que está no GitHub.

**Publicando o pacote no feed privado**
Para publicar o pacote, utilizamos o seguinte comando no terminal:

```csharp
dotnet nuget push ReportGenerator/bin/Release/Alura_ReportGenerator.1.0.0.nupkg --source "https://nuget.pkg.github.com/profvinicius84/index.json" --api-key hp_N8TUnAGrced8NYXkLC02bYRS2dp1F60Kgun
```

Esse comando é muito parecido com o que utilizamos no vídeo anterior para fazer a publicação no feed público do Nuget. A diferença está no --source, onde especificamos o endereço do nosso feed privado no GitHub, e no --api-key, onde informamos a API key que acabamos de criar. Ao apertarmos "Enter", nosso pacote será enviado para o feed do GitHub e já poderemos utilizá-lo.

**Configurando o feed privado no Visual Studio**  
O próximo passo é configurar nosso feed privado no Visual Studio para que tenhamos acesso ao nosso pacote. Vamos abrir o gerenciador de solução, clicar com o botão direito em "Dependências", selecionar "Gerenciar Pacote Nuget" e clicar na engrenagem no canto superior direito para adicionar nosso feed. Clicamos no símbolo de adição, damos um nome para ele, como "Alura Report", e colocamos o endereço dele. O endereço que vamos colocar é o mesmo que utilizamos para subir nosso pacote:

```csharp
https://nuget.pkg.github.com/profvinicius84/index.json
```

Atualizamos e agora temos nosso feed "Alura Report" salvo. Vamos confirmar e fazer a pesquisa nele.

**Autenticando e acessando o pacote**  
Em "Origem do Pacote", mudamos para "Alura Report". Como é um feed público, ele nos pede autenticação. Podemos fazer a autenticação com aquele token que geramos. Colocamos o nome do usuário, por exemplo, profvinicius84, e pegamos novamente o token. Para pegar o token, deixamos aberta a tela do GitHub, copiamos, voltamos ao Visual Studio, colocamos o token para não precisar digitá-lo novamente, marcamos para lembrar a senha e confirmamos. Agora conseguimos ter acesso ao feed do Alura.

**Concluindo a publicação e visualização do pacote**  
Vamos pesquisar pelo nosso pacote no repositório privado. Procuramos por "Alura.ReportGenerator", saímos da aba "Instalado" e procuramos. Aqui está nosso pacote, já pronto para ser utilizado na versão 1.0. Ao clicarmos nele, conseguimos ver as informações de metadados, como a biblioteca para gerar relatórios de vários formatos, versão 1.0, o autor, a licença, a página do projeto e as informações que colocamos quando o pacote foi gerado.

Concluímos que já vimos como gerar um pacote Nuget, como publicá-lo no feed público e também no feed privado. Encerramos nossa aula com todas essas informações prontas para a próxima aula, na qual vamos evoluir nossa biblioteca, aplicar boas práticas e deixá-la ainda mais profissional.

### Aula 4:  Reutilização de funcionalidades no ADOPET - Exercício

Considerando o contexto do ADOPET, um site de adoção de animais de estimação, qual das alternativas abaixo descreve corretamente os benefícios de reutilizar funcionalidades existentes no desenvolvimento de novos recursos e como a equipe pode garantir a flexibilidade dessas bibliotecas para atender a diferentes necessidades?

Resposta:  
Reutilizar funcionalidades existentes pode reduzir o tempo de desenvolvimento e custos, além de garantir consistência no site. Para garantir flexibilidade, a equipe deve projetar bibliotecas de forma modular, incluir opções de configuração, fornecer documentação clara e coletar feedback para melhorias.

> Correta, pois essa alternativa abrange todos os benefícios e práticas necessárias para garantir a flexibilidade e eficácia das bibliotecas reutilizadas, conforme discutido.

### Aula 4: Para saber mais: Package ID único no NuGet

**Por que um Package ID único é fundamental**  
Um dos pontos críticos na publicação de pacotes é definir um identificador (Package ID) que seja realmente único. Esse identificador serve como a identidade do seu pacote dentro do ecossistema do Nuget, evitando conflitos com outros pacotes que possam existir com nomes semelhantes. Em ambientes com milhares de pacotes, essa singularidade facilita a busca e garante que os desenvolvedores obtenham exatamente a biblioteca desejada.

**Estratégias para assegurar a singularidade**  
Uma prática comum é utilizar um prefixo que identifique a origem ou instituição responsável, como por exemplo, incluir o nome da empresa ou curso no início do Package ID. Dessa forma, mesmo que o nome do componente seja genérico, a combinação com o prefixo reduz significativamente as chances de duplicidade. Outra estratégia é revisar o repositório do Nuget antes de publicar para confirmar se o nome escolhido já não está em uso.

**Impactos na manutenção e evolução**  
Um Package ID único não apenas evita conflitos durante a busca e instalação, mas também contribui para uma comunicação mais clara quando há atualizações. Por exemplo, ao estabelecer uma convenção de nomes, os usuários conseguem identificar facilmente a origem e a sequência de versões da biblioteca. Essa padronização simplifica o gerenciamento de dependências e diminui os riscos de instalação acidental de pacotes incorretos.

**Conclusão**  
Dedicar atenção à escolha do Package ID é uma etapa estratégica que influencia diretamente a segurança, integridade e usabilidade do pacote no longo prazo. Com um identificador bem estruturado e único, o processo de publicação e manutenção se torna mais confiável e organizado para toda a comunidade de desenvolvedores.

### Aula 4: Faça como eu fiz: publicar pacotes NuGet

Nesta aula, aprendemos a criar e distribuir bibliotecas em pacotes NuGet, abordando a geração do pacote no Visual Studio, a configuração dos metadados e o uso de API keys para publicação em feeds públicos e privados.

Agora é a sua vez de revisar e exercitar os conteúdos desta aula, se ainda não colocou em prática. Para isso:

- Configure o projeto em modo Release e gere o pacote (.nupkg) a partir do Visual Studio.
- Atualize os metadados no arquivo XML (package id, versão, autor, licença e inclusão do readme).
- Publique o pacote no feed público do NuGet utilizando a API key e o comando .NET nuget push.
- Publique o pacote em um feed privado no GitHub, criando um token de acesso e configurando o endereço do feed.

Se tiver alguma dúvida, contate-nos no fórum ou no Discord!

### Aula 4: O que aprendemos?

Nesta aula, aprendemos:

- A importância de publicar bibliotecas para reutilização interna e padronização.
- Como a publicação no Nuget simplifica a distribuição de bibliotecas.
- O processo de gerar um pacote Nuget (.nupkg) no Visual Studio.
- Os passos de configuração para publicação, incluindo metadados e package id.
- Criar uma API key no nuget.org para autenticar a publicação no feed público.
- Usar o comando PowerShell para publicar pacotes no Nuget.
- Criar um personal access token no GitHub para publicação em feeds privados.
- Configurar e utilizar feeds privados no Visual Studio com GitHub.

## Aula 5: Organização, dependências e documentação

### Aula 5: Projeto da aula anterior

Na aula anterior, criamos um pacote NuGet (um arquivo compactado contendo os binários da nossa biblioteca compilada, além de um arquivo de metadados com informações sobre a biblioteca) para publicar nossa biblioteca em feeds públicos e privados. Para conferir o projeto desenvolvido e, se quiser, baixá-lo para começar daqui, [acesse o repositório do curso no GitHub.](https://github.com/alura-cursos/AluraReportGenerator/tree/video_4.3)

### Aula 5: Organizando a biblioteca - Vídeo 1

Transcrição  
Olá, desenvolvedores. Chegamos à última aula do nosso curso. Nesta aula, vamos pensar em formas de evoluir nossa biblioteca e continuar aplicando boas práticas. Uma maneira de evoluir nossa biblioteca é permitir que ela gere formatos em PDF, além de CSV. Enquanto fazemos isso, aproveitamos para revisar e ajustar nossa biblioteca para que ela esteja em conformidade com as melhores práticas.

Vamos começar abrindo o Visual Studio. Com o projeto aberto, vamos criar uma nova classe chamada PDFPostGenerator. No entanto, já podemos identificar uma questão no nosso projeto: ao começarmos a criar classes, se fizermos tudo na raiz, pode gerar confusão e não ficar claro para que serve cada classe. Portanto, é melhor, enquanto o projeto ainda está pequeno, organizá-lo e estruturá-lo seguindo boas práticas.

**Organizando o projeto em pastas**  
Temos geradores e utilitários de formatação. Vamos criar uma pasta para os geradores. Clique com o botão direito, adicione uma nova pasta e nomeie-a como "Generators". Aqui, colocaremos tudo relacionado a geradores. Vamos mover o CSV para essa pasta, ajustando o namespace. O Visual Studio já pergunta se queremos ajustar o namespace, e escolhemos sim. O namespace antes era apenas reportGenerator, e agora se tornou reportGenerator.generators, facilitando nosso trabalho.

```csharp
namespace ReportGenerator.Generators
```

A interface também é movida para cá, e o Visual Studio faz a mesma pergunta, realizando a alteração necessária.

Para o DateFormatter, vamos criar uma nova pasta para utilitários, mas fora da pasta "Generators". Renomeamos essa pasta para "Util" e movemos tanto a interface quanto a classe de formatação para lá. Com isso, começamos a organizar e separar nossas classes por funções, deixando o que tem funções semelhantes em locais separados. Isso facilita a compreensão do código para quem o lê e para quem utiliza nossa biblioteca, permitindo entender onde está cada classe e funcionalidade dentro do namespace.

```csharp
namespace ReportGenerator.Util
```

**Criando a classe PDFReportGenerator**  
Com a classe CSVReportGenerator pronta, vamos criar a classe PDFReportGenerator. Clique com o botão direito, adicione uma nova classe, e podemos copiar a CSV e renomeá-la para PDF, alterando seu conteúdo internamente. Assim, ela se tornará PDFReportGenerator.

```csharp
public class CSVReporterGenerator: IReportGenerator
```

```csharp
public class PDFReporterGenerator: IReportGenerator
```

Observamos que, exceto pelo tipo do arquivo de saída, o que está na CSVReportGenerator também está na PDFReportGenerator. Portanto, faz sentido, além da interface, termos uma classe base que contenha a lógica comum entre as duas classes.

**Criando a classe base ReportGeneratorBase**  
Vamos criar uma nova classe base chamada ReportGeneratorBase. Adicione um novo item e nomeie-o como ReportGeneratorBase.

```csharp
internal class ReportGeneratorBase
{
}
```

Assim como o CSV ReportGenerator e o PDF ReportGenerator, a ReportGeneratorBase deve implementar a interface IRReportGenerator. Vamos mantê-la como uma classe interna, mas ela será uma classe abstrata. Portanto, será uma classe abstrata que implementa a IRReportGenerator.

```csharp
internal abstract class ReportGeneratorBase: IReportGenerator
```

Em seguida, vamos transferir o que está na interface IRReportGenerator para a nossa nova classe. Solicitamos ao Visual Studio que crie automaticamente os métodos e propriedades existentes, e vamos ajustá-los conforme necessário.

```csharp
public List<Dictionary<string, string>> Input { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
public string Title { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
public string Headline { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
public string FooterLine { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

public string GenerateReport()
{
    throw new NotImplementedException();
}
```

**Implementando a lógica comum na classe base**  
Não precisamos escrever tudo novamente; podemos copiar da CSV ReportGenerator, que já está pronta. Vamos copiar a propriedade input, title, headline, footer e até mesmo o construtor, e depois mudar o nome dele. Após copiar da CSV ReportGenerator, colamos na base.

```csharp
public List<Dictionary<string, string>> Input { get; set; }
public string Title { get; set; }
public string Headline { get; set; }
public string FooterLine { get; set; }
public CSVReporterGenerator(List<Dictionary<string, string>> input)
{
    Input = input;
}
```

Assim, temos a propriedade input, title, headline, footer e um construtor que recebe o input.

```csharp
public ReportGeneratorBase(List<Dictionary<string, string>> input)
{
    Input = input;
}
```

O que está faltando é o método GenerateReport. Como estamos em uma classe abstrata e esse método varia entre a classe CSV e a classe PDF, vamos mantê-lo como abstrato. Dessa forma, as classes CSV e PDF serão responsáveis por implementar esse método de acordo com suas necessidades.

```csharp
public abstract string GenerateReport();
```

**Ajustando a classe CSVReportGenerator**  
Voltando para a classe CSV ReportGenerator, faremos com que ela herde da ReportGeneratorBase. As informações duplicadas já não são mais necessárias.

```csharp
public class CSVReporterGenerator: ReportGeneratorBase
```

Podemos também modificar o construtor dela, herdando do construtor base, sem lógica adicional.

```csharp
public CSVReporterGenerator(List<Dictionary<string, string>> input): base(input)
{
}
```

Vamos deixar apenas o método que realmente interessa para o CSV ReportGenerator, que é o GenerateReport.

O Visual Studio está apresentando um erro. Esse erro ocorre porque mantivemos a ReportGeneratorBase como uma classe interna, e ele indica que a CSV ReportGenerator, que é pública, não pode herdar de uma classe interna, pois ela é menos acessível. Portanto, precisamos alterar a ReportGeneratorBase para pública.

```csharp
public abstract class ReportGeneratorBase : IReportGenerator
```

Após salvar, no CSV ReportGenerator, o erro agora indica que não implementa. Precisamos adicionar um public override ao método GenerateReport, indicando que estamos sobrescrevendo o método existente da classe abstrata.

```csharp
public override string GenerateReport()
```

Com isso, não há mais erros.

**Implementando a classe PDFReportGenerator**  
Vamos aplicar o mesmo procedimento à classe PDF. A classe CSV já está pronta, com a lógica implementada. Na classe PDF, faremos com que ela herde da classe ReportGeneratorBase.

```csharp
public class PDFReporterGenerator: ReportGeneratorBase
```

No entanto, precisamos implementar a lógica para que o arquivo de saída seja realmente um PDF. Vamos alterar a herança da classe PDF para que ela herde diretamente da ReportGeneratorBase, em vez de ser da interface. Podemos apagar o código desnecessário e modificar o construtor para invocar o construtor da classe base.

```csharp
public PDFReporterGenerator(List<Dictionary<string, string>> input) : base(input)
```

Em seguida, começaremos a alterar o método GenerateReport.

```csharp
public override string GenerateReport()
```

No .NET, não há uma forma nativa fácil de gerar arquivos PDF. Se utilizarmos apenas os recursos do .NET, o processo será demorado. No entanto, é possível utilizar uma biblioteca utilitária específica para gerar arquivos PDF. É isso que faremos na próxima aula. Vamos explorar como, ao criar uma biblioteca, podemos utilizar outra biblioteca que nos auxilie em nosso propósito.

### Aula 5: Estruturando a plataforma Freelando para melhor organização
 Próxima Atividade

A plataforma Freelando, que conecta freelancers a contratantes, está em processo de expansão e precisa melhorar a organização de seu código para facilitar a manutenção e o desenvolvimento de novas funcionalidades. A equipe de desenvolvimento decidiu criar uma estrutura de pastas que separe claramente as funcionalidades principais, como gerenciamento de usuários, projetos e pagamentos. No entanto, há uma preocupação sobre como essa reorganização pode impactar a compreensão do código por novos membros da equipe e a integração de novas funcionalidades.

Como a equipe pode estruturar o código da plataforma de forma a melhorar a organização e facilitar a compreensão e manutenção, considerando as boas práticas de desenvolvimento?

Resposta:  
A equipe pode criar uma estrutura de pastas que separe as funcionalidades principais em diretórios distintos, como "Users", "Projects" e "Payments". Cada diretório pode conter subdiretórios para classes, interfaces e utilitários específicos daquela funcionalidade. Além disso, é importante ajustar os namespaces para refletir essa estrutura, facilitando a navegação e a compreensão do código.

> Correta, pois essa abordagem organiza o código de maneira lógica e clara, permitindo que novos membros da equipe entendam rapidamente onde cada funcionalidade está localizada e como elas se relacionam, além de facilitar a adição de novas funcionalidades sem causar confusão.

### Aula 5: Dependências da biblioteca - Vídeo 2

Transcrição  
Bem-vindos de volta. Conforme mencionado no último vídeo, vamos criar nossos relatórios em PDF. Para isso, precisamos importar uma biblioteca que nos auxiliará nesse processo. Vamos procurar essa biblioteca clicando com o botão direito em dependências, gerenciar pacotes NuGet, e buscar no repositório público do NuGet. A biblioteca que vamos utilizar é a itext7, que nos ajuda a gerar arquivos PDF. Vamos selecionar essa biblioteca, verificar sua versão mais estável, escolher a versão 8.0 e instalá-la.

Após a instalação, será necessário aceitar os termos e as modificações que serão feitas no projeto. Uma vez instalada, notamos que a itext7 não foi instalada sozinha; outra biblioteca, itext7.comos, foi instalada junto como um pacote transitivo. Este é um bom momento para discutirmos a diferença entre pacotes transitivos e pacotes de referência.

**Explicando pacotes transitivos e de referência**  
Uma referência dentro de um projeto .NET ocorre quando referenciamos um projeto que já está dentro da mesma solução, como fizemos nas primeiras aulas. Quando utilizamos o NuGet, indicamos que nosso projeto tem dependências de pacotes. No entanto, quando essa dependência de pacotes requer outra biblioteca que é trazida junto, chamamos isso de dependência transitiva. No nosso caso, nosso interesse era a biblioteca itext, mas ela também precisa da itext.comos para funcionar. O mesmo acontecerá quando publicarmos a nova versão da nossa biblioteca. A biblioteca Alura Report Generator trará consigo todas as bibliotecas necessárias para funcionar como dependências transitivas.

**Modificando a classe PDF Report Generator**  
Voltando ao Visual Studio, com nossa biblioteca criada, vamos para a classe PDF Report Generator e alterar seu código. O código atual gera um CSV, mas precisamos adaptá-lo para gerar um PDF. Vamos começar a partir da Spring Builder Report, apagando o que está lá e reescrevendo nosso método. A verificação do input permanece, e começamos a desenvolver nossa lógica.

Primeiro, vamos criar o método GenerateReport que verificará se o input é válido. Se não for, lançaremos uma exceção. Em seguida, retornaremos o caminho do arquivo gerado. Inicialmente, o método está configurado para retornar um CSV:

```csharp
public override string GenerateReport()
{
    if (Input == null || Input.Count == 0)
        throw new Exception("Input de dados invalido");

    return Path.GetFullPath("report.csv");
}
```

**Criando o documento PDF**  
Agora, vamos modificar o método para gerar um PDF. Primeiro, criaremos um novo objeto para nossa biblioteca, ignorando as sugestões da licença. Vamos começar criando um PdfWriter que será responsável por escrever o documento PDF:

```csharp
using var writer = new PdfWriter("report.pdf");
```

Em seguida, precisamos criar o documento PDF, utilizando o PdfWriter que acabamos de criar:

```csharp
using var pdf = new PdfDocument(writer);
```

Agora, vamos criar o documento utilizando a classe Document da biblioteca iText:

```csharp
using var document = new iText.Layout.Document(pdf);
```

**Adicionando elementos ao documento PDF**  
Com o documento criado, podemos começar a adicionar elementos a ele. No CSV, a primeira coisa que fazíamos era definir o título no cabeçalho. Vamos fazer o mesmo agora, verificando se o nosso título está presente:

```csharp
if(!string.IsNullOrWhiteSpace(Title))
{
    var title = new iText.Layout.Element.Paragraph(Title)
        .SetFontSize(20)
        .SetBold()
        .SetMarginBottom(10);
    document.Add(title);
}
```

O próximo passo é verificar se há um headline (cabeçalho). Se houver, adicionamos ao documento:

```csharp
if(!string.IsNullOrWhiteSpace(HeadLine))
{
    var headLine = new iText.Layout.Element.Paragraph(HeadLine)
        .SetFontSize(16)
        .SetItalic()
        .SetMarginBottom(10);
    document.Add(headLine);
}
```

**Criando e preenchendo a tabela de dados**  
Agora, vamos criar nossa tabela com os dados. Primeiro, criamos a tabela com base no número de colunas que temos:

```csharp
Table table = new Table(Input.First().Keys.Count);
```

Para cada elemento, criamos um cabeçalho da tabela, adicionando uma célula de cabeçalho e colocando-a em negrito para destacar o cabeçalho:

```csharp
foreach (var header in Input.First().Keys)
{
    table.AddHeaderCell(new Cell().Add(new Paragraph(header).SetBold()));
}
```

Agora, vamos adicionar os dados à tabela. Para cada registro no input, adicionamos os valores às células da tabela:

```csharp
foreach (var record in Input)
{
    foreach (var value in record.Values)
    {
        table.AddCell(new Cell().Add(new Paragraph(value)));
    }
}
```

Depois de preencher a tabela, adicionamos a tabela ao documento:

```csharp
document.Add(table);
```

**Finalizando o documento PDF**  
Vamos verificar o footer (rodapé). Se houver um footer, adicionamos ao nosso documento também:

```csharp
if (!string.IsNullOrWhiteSpace(FooterLine))
{
    var footer = new iText.Layout.Element.Paragraph(FooterLine)
        .SetFontSize(12)
        .SetMarginTop(10);
    document.Add(footer);
}
```

Por último, precisamos apenas devolver o caminho onde nosso relatório está gravado. Em vez de repost.csv, será repost.pdf:

```csharp
return Path.GetFullPath("report.pdf");
```

Assim, já temos a nossa geração de relatórios em PDF e aumentamos as funcionalidades da nossa biblioteca. Agora, nossa biblioteca gera relatórios em CSV e em PDF.

**Próximos passos**  
No próximo vídeo, vamos verificar como adicionar essa biblioteca, melhorar a documentação para que seja mais clara e utilizada, e colocá-la no Nuget como uma atualização.

### Aula 5: Integração de bibliotecas externas na Freelando- Exercício

A plataforma Freelando, que conecta freelancers a contratantes, está considerando a integração de uma biblioteca externa para melhorar a geração de documentos PDF.

Quais são os fatores que a equipe de desenvolvimento deve considerar ao escolher e integrar essa biblioteca de forma eficiente e segura?

Resposta:  
A equipe deve considerar a compatibilidade da biblioteca com a tecnologia utilizada na plataforma, a facilidade de uso, a documentação disponível, a comunidade e o suporte oferecido, além da frequência de atualizações e correções de segurança.

> Correta, pois esses fatores garantem que a biblioteca se integre bem ao sistema existente, seja fácil de implementar e mantenha a segurança e a funcionalidade da plataforma.

### Aula 5: Documentando a biblioteca - Vídeo 4

Transcrição  
Bem, neste vídeo, vamos discutir a importância de documentar o código da nossa biblioteca para disponibilizar essas informações para quem irá utilizá-la. Antes disso, precisamos comentar algo que percebemos durante os testes da nossa biblioteca: a necessidade de adicionar mais uma dependência. Ao tentar executar, surgiu um erro solicitando essa dependência, e tivemos que adicioná-la para que o nosso código funcionasse corretamente. Essa correção se refere ao vídeo anterior.

Dito isso, vamos prosseguir com o tema deste vídeo, que é a documentação do nosso código. Em vídeos anteriores, mencionamos a importância de documentar bem o nosso código, pois quem utilizar a nossa biblioteca precisa saber para que serve cada componente. Com a documentação adequada, até o IntelliSense pode ajudar a gerar código automaticamente. Portanto, é sempre importante documentar bem a sua biblioteca.

**Exemplificando a documentação com o IntelliSense**  
Por exemplo, ao acessar nossa classe de teste e chamar o import-generator do PDF, podemos observar que o IntelliSense não exibe informações detalhadas. Ele apenas mostra o método de gerar o import, mas não explica sua finalidade, o que ele retorna ou como funciona. Por isso, precisamos documentar bem esse método.

Para isso, vamos até a nossa classe PDF do import-generator, posicionar o cursor sobre ela e digitar a barra três vezes. O Visual Studio automaticamente cria o sumário, e o IntelliSense sugere uma documentação.

**Estruturando a documentação do método**  
Aqui está um exemplo de como a documentação pode ser estruturada:

```csharp
/// <summary>
/// 
/// </summary>
/// <returns></returns>
/// <exception cref="Exception"></exception>
```

Com essa estrutura básica, podemos começar a detalhar o que o método faz. Vamos adicionar mais informações para que o IntelliSense forneça detalhes úteis:

```csharp
/// <summary>
/// Generates a PDF report based on the provided input data, title, headline, and footer.
/// </summary>
/// <remarks>
/// This method creates a PDF file named "report.pdf" in the current working directory.
/// The report includes: <list type="bullet"><item><description>An optional title displayed at the top of the document.</description></item><item><description>An optional headline displayed below the title.</description></item><item><description>A table containing the input data, with column headers derived from the keys of the first record.</description></item><item><description>An optional footer displayed at the bottom of the document.</description></item></list>The method throws an exception if the input data is null or empty. The generated PDF file's full path is returned as the result.
/// </remarks>
/// <returns>The full path to the generated PDF file.</returns>
/// <exception cref="Exception">Thrown if the input data is null or contains no records.</exception>
```

**Publicando a nova versão da biblioteca no NuGet**  
Com a documentação do nosso método pronta, podemos voltar à nossa tarefa. Ao tentar utilizar o Generate-Importes, o IntelliSense já fornece todas as informações sobre essa classe, facilitando para a pessoa desenvolvedora que estiver consumindo a biblioteca entender a finalidade de cada componente.

Portanto, é essencial documentar cada classe e método. Vamos disponibilizar este arquivo já documentado, de modo que, ao utilizá-lo sem acesso ao código-fonte, seja possível entender a finalidade de cada classe. Com essa nova funcionalidade de gerar PDF, já temos uma nova versão da nossa biblioteca.

O próximo passo é publicar novamente no NuGet e verificar como ficou por lá. A primeira coisa a fazer é abrir o gerenciador de soluções e ajustar o nome do projeto. Vamos agora alterar o número da versão. Lembrando que, em relação à numeração de versão, temos o major, o minor e os patches. O major é a versão principal, que deve ser alterada quando uma atualização gera incompatibilidade com versões anteriores. Não é o nosso caso, pois criamos a funcionalidade de gerador de relatório PDF, mas mantivemos a funcionalidade de relatório CSV funcionando como antes.

**Ajustando a versão e realizando o push no NuGet**  
Nós não alteramos a forma de funcionamento. Portanto, mantemos a versão como 1.0, mas, como adicionamos uma nova funcionalidade, incrementamos a versão minor. Agora estamos na versão 1.1. Como não foi necessário, no momento, fazer nenhuma correção de bug ou atualização de segurança, mantemos como 1.1.0. Aqui temos a nossa nova versão da biblioteca:

```csharp
<Version>1.1.0</Version>
```

Clicamos com o botão direito sobre o nome do projeto e escolhemos a opção de pacote, que gera um novo pacote. Agora, o pacote está na versão 1.1. O que falta fazer agora é rodar novamente o comando do Nuget para realizar a publicação. Vamos para o PowerShell e escrevemos normalmente aquele comando. Uma vez no PowerShell, digitamos o comando:

```csharp
dotnet nuget push ReportGenerator\bin\Debug\Alura_ReportGenerator.1.1.0.nupkg --source "https://api.nuget.org/v3/index.json" --api-key oy2lvirgvac...
```

**Aguardando a validação e discutindo versionamento semântico**  
O caminho do nosso pacote, que agora está na versão 1.1.0, é o src, que é a fonte, o feed público do Nuget, api.nuget.org/v3/index.json, e a nossa API aqui. Com tudo isso digitado, pressionamos "Enter" e fazemos o push. Mensagem de sucesso: nosso pacote já foi enviado e atualizado.

Agora, como mencionado anteriormente, aguardamos dois minutos, que é o tempo que o Nuget leva para lidar com o pacote, e verificamos como ele está disponível no feed do Nuget. No site do Nuget, ao acessar os detalhes do nosso pacote, vemos que o pacote 1.1.0 já foi enviado, mas está em validação. Aguardamos ele sair do status de validação para o status de listado. Isso levará mais alguns minutos, que é o tempo necessário para o nosso pacote ficar disponível.

Enquanto esperamos a nova versão do nosso pacote ficar disponível, é importante relembrar o conceito de versionamento semântico, já comentado anteriormente. O que significa cada parte: a parte major, que é o primeiro número, indica mudanças evolutivas, ou seja, uma nova versão do produto que não é mais compatível com a versão anterior, como passar de 1.0 para 2.0 e assim por diante:

```csharp
MAJOR - mudanças incompatíveis.
```

O versionamento minor, que é o número no meio, entre os pontos, é usado quando fazemos atualizações, adicionamos novas funcionalidades, mas mantemos a compatibilidade com a versão imediatamente anterior:

```csharp
MINOR - novas funcionalidades compatíveis.
```

O último número da versão é utilizado para publicar um patch de atualização, quando algum bug é descoberto ou uma falha de segurança é resolvida, enumerando esses patches:

```csharp
PATCH - correções de bugs.
```

Esses são conceitos que devemos ter em mente ao publicar nosso pacote, para que o usuário perceba quando é necessário realmente fazer a atualização ou não. Se disponibilizamos um patch, o usuário saberá que é preciso atualizar, pois algo foi resolvido. Se mudamos apenas o minor, ele poderá avaliar se vale a pena atualizar agora ou não. Quando mudamos para algo totalmente incompatível, é necessário ter ainda mais cuidado ao atualizar a biblioteca, pois os impactos podem ser maiores e causar erros não previstos. Nesse caso, é preciso realizar testes antes de colocar em produção.

É isso, pessoal. Estamos terminando nosso curso. Nos vemos em breve.

### Aula 5: Para saber mais: template method para relatórios

**Introdução ao Template Method**  
O padrão Template Method é uma abordagem de design orientado a objetos que define o esqueleto de um algoritmo em uma classe abstrata. Esse padrão permite que as classes derivadas implementem comportamentos específicos em determinados pontos, sem modificar a estrutura geral do algoritmo. Essa técnica é muito útil em cenários onde há partes do processamento que se repetem, como na geração de relatórios, mas onde diferentes formatos exigem implementações particulares em alguns passos.

**Funcionamento e Exemplo Prático**  
Na prática, uma classe base abstrata estabelece um método que orquestra todas as etapas necessárias para a geração de um relatório. Esse método – o template – chama, em uma sequência definida, métodos que podem ser concretizados pelas classes especializadas. Por exemplo, a classe abstrata pode definir um método GenerateReport que executa etapas como preparar os dados, formatar cabeçalho e rodapé, e montar o conteúdo principal do relatório. Em seguida, as classes derivadas implementam os detalhes de cada uma dessas partes, seja para gerar um arquivo CSV, um PDF ou outro formato.

Veja um exemplo simplificado em C#:

```csharp
public abstract class ReportGenerator
{
    // Método template que define o fluxo do algoritmo
    public void GenerateReport()
    {
        LoadData();
        FormatHeader();
        GenerateContent();
        FormatFooter();
    }

    // Métodos que serão implementados pelas classes derivadas
    protected abstract void LoadData();
    protected abstract void FormatHeader();
    protected abstract void GenerateContent();
    protected abstract void FormatFooter();
}
```

Nesse exemplo, a classe base centraliza a lógica de fluxo do relatório, enquanto permite que cada subtarefa seja personalizada de acordo com as necessidades do formato específico.

**Benefícios e Considerações da Abordagem**  
Entre as principais vantagens desse padrão, destacam-se:

Reutilização e Organização: Ao encapsular o fluxo comum em uma classe base, o código se torna mais organizado e facilita a manutenção, pois alterações no fluxo padrão precisam ser realizadas em apenas um local.

Flexibilidade Controlada: As classes derivadas têm a liberdade de definir comportamentos específicos para cada etapa, mantendo a consistência do processo global. Isso ajuda a evitar duplicações e promove a padronização do algoritmo de geração de relatórios.

Por outro lado, é importante ter cuidado com:

Rigidez na Estrutura: Caso o algoritmo exija muitas variações ou etapas dinâmicas, o padrão pode se tornar muito rígido, obligando as classes derivadas a seguir uma estrutura que nem sempre se adapta a todos os cenários.

Acoplamento com a Estrutura Base: Alterações significativas na classe base podem impactar diversas implementações derivadas, o que exige uma boa análise de design antes de adotar essa abordagem.

Em resumo, o Template Method é uma ferramenta poderosa para definir estruturas comuns e promover a reutilização de código, especialmente em contextos de geração de relatórios com múltiplos formatos. A escolha desse padrão deve levar em conta o equilíbrio entre a padronização do fluxo e a necessidade de flexibilidade em cada etapa específica.

### Aula 5: Faça como eu fiz: atualizar biblioteca

Nesta aula, vimos como estruturar e aprimorar uma biblioteca, integrando a geração de PDF e aplicando boas práticas de organização e documentação.

Agora é a sua vez de reproduzir esses passos. Para isso:

- Organize o projeto criando pastas para geradores e utilitários e ajuste os namespaces das classes.
- Crie uma classe base abstrata e faça com que as classes CSV e PDF herdem dela, centralizando a lógica comum.
- Integre a biblioteca iText7 via NuGet e implemente a lógica de geração do relatório em PDF.
- Documente os métodos e atualize a versão do pacote, realizando o push da nova versão no NuGet.

Se tiver alguma dúvida, contate-nos no fórum ou no Discord!

### Aula 5: Projeto final

Nesta aula, nós organizamos nossa biblioteca conforme boas práticas de projeto, evoluímos as funcionalidades da biblioteca ao adicionar o gerador de relatórios em PDF e documentamos tudo para publicar a nova versão. Para conferir o projeto completo, [acesse o repositório do curso no GitHub.](https://github.com/alura-cursos/AluraReportGenerator/tree/video_5.3)

### Aula 5: O que aprendemos?

Nesta aula, aprendemos:

- A importância de organizar projetos de software em pastas e utilizar namespaces para melhorar a clareza e manutenção do código.
- A implementar a herança e classes abstratas em C#, criando uma estrutura comum para diferentes geradores de relatórios com métodos abstratos.
- A integrar bibliotecas de terceiros, como o iText7 para geração de PDFs, utilizando o gerenciador de pacotes Nuget.
- A gerar relatórios em PDF, incluindo títulos, cabeçalhos, tabelas e rodapés, assegurando que o arquivo final está correto.
- A documentar o código utilizando comentários de barra tripla para gerar documentação XML e enriquecer a API.
- A atualizar versões de bibliotecas seguindo o versionamento semântico e o impacto na comunicação de mudanças aos usuários.
O processo de publicação de pacotes no Nuget, utilizando o comando .NET nuget push e entendendo o tempo de validação necessário.
- A adicionar e resolver dependências transitivas necessárias para o correto funcionamento das bibliotecas, usando exemplos práticos.

### Aula 5: Conclusão - Vídeo 8

Transcrição  
Parabéns! Chegamos ao final do nosso curso. Ao longo desta jornada, aprendemos o que são bibliotecas, como utilizá-las e consumi-las a partir de vídeos, como criar nossa própria biblioteca, como mencioná-la e lidar com ela, além de abordar a divulgação de versões e boas práticas para a divulgação de nossa biblioteca.

Agora, esperamos que realizem um bom exercício e verifiquem qual é a nossa biblioteca.

Caso surjam dúvidas, por favor, escolha a opção desejada. Agradecemos e até a próxima!
