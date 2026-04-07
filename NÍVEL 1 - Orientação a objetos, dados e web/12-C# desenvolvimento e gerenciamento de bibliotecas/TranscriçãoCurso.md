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

### Aula 3:  - Vídeo 1
### Aula 3:  - Vídeo 2
### Aula 3:  - Vídeo 3
### Aula 3:  - Vídeo 4
### Aula 3:  - Vídeo 5
### Aula 3:  - Vídeo 6
### Aula 3:  - Vídeo 7
### Aula 3:  - Vídeo 8
### Aula 3:  - Vídeo 9
### Aula 3:  - Vídeo 10
### Aula 3:  -
