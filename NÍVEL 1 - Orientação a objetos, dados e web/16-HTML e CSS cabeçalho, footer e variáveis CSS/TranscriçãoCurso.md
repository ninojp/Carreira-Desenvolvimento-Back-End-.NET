# Curso Alura - HTML e CSS: cabeçalho, footer e variáveis CSS

## Aula 1 - Preparando o layout do projeto

### Aula 1 - Apresentação - Vídeo 1

Transcrição  
Guilherme: Olá! Meu nome é Guilherme Lima.

Rafaella: Eu sou a Rafaella Ballerini.

Guilherme: Neste curso receberemos um projeto para atualizar o que havíamos implementado.

Rafaella: Exatamente. Teremos uma tela com novas funcionalidades, assim como faremos a implementação de uma nova tela.

Guilherme: Refinaremos ainda mais nosso projeto, para que os ícones sejam exibidos ao lado dos nossos links. Além disso, implementaremos um aspecto essencial do projeto: a navegação entre as telas.

Rafaella: Teremos um cabeçalho onde conseguiremos transitar de uma tela para a outra. Além disso, veremos detalhes relacionados ao código, como por exemplo, maneiras de trocar as cores do projeto todo através de um único local do nosso código.

Guilherme: Vamos nessa?

Rafaella: Vamos.

### Aula 1 - Preparando o ambiente

Olá Dev!  
Boas vindas ao curso de HTML e CSS - Desenvolvendo o cabeçalho, footer e variáveis CSS!

Este curso é o terceiro da sequência de HTML e CSS, por isso, caso você não tenha desenvolvido o código dos cursos anteriores, é importante que [baixe o zip do projeto](https://github.com/alura-cursos/Portifolio-HTML-e-CSS-Curso2/archive/refs/heads/aula_5.zip) dos cursos anteriores ou acesse os arquivos no Github antes de iniciarmos.

Aqui vamos aprimorar ainda mais nosso projeto de portfólio, aprenderemos a atualizar nosso código e a implementar a navegação entre telas!

Para que esse refinamento ocorra da melhor forma possível, iremos trabalhar com um layout atualizado, que você pode acessar através [desse Figma](https://www.figma.com/community/file/1410367096860989575).

Além disso, seguiremos utilizando o editor de código [Visual Studio Code](https://code.visualstudio.com/download) como ferramenta de desenvolvimento, que pode ser baixado para Windows, Linux ou Mac.

> Caso tenha dúvidas na instalação ou ao longo do curso, fique à vontade tanto para criar um tópico no fórum como para interagir conosco através do Discord da Alura. E ainda que não tenha dúvidas, você também pode ajudar outras pessoas compartilhando seus aprendizados e projetos por lá e nós vamos adorar acompanhar seu progresso!

### Aula 1 - Figma do projeto atualizado - Vídeo 2

Transcrição  
Guilherme: Iniciaremos um novo desafio: atualizar a nossa aplicação. No mundo real, geralmente desenvolvemos uma tela, assim como fizemos, e de repente precisamos atualizá-la, incluindo novas funcionalidades.

Sistemas de software, páginas Web e aplicações geralmente passam por atualizações.

Rafaella: Principalmente em momentos de alta nas vendas, como na Black Friday. Nestas datas, empresas de e-commerce enviam landing pages para que modifiquemos, adicionando chamadas de desconto. É bem comum recebermos no dia-a-dia pedidos de atualização de projetos.

Guilherme: Traremos acontecimentos do mundo real para esse curso. Não somos um e-commerce, mas temos uma atualização a ser implementada. O nosso projeto evoluirá um pouco mais: ele terá uma nova tela.

Vamos acessar o Figma do nosso projeto em sua nova etapa.

Tela atualizada do projeto no Figma. O fundo é preto. Na parte superior, temos dois textos em negrito na cor ciano: "Home" e "Sobre mim", dispostos na horizontal, da esquerda para a direita. Abaixo deles, temos dois blocos de conteúdo, lado a lado, centralizados. O bloco esquerdo possui um texto que se divide em duas partes: título e parágrafo. O título apresenta um texto em negrito dividido em duas cores: "Eleve seu negócio digital a outro nível" em branco, seguido de "com um Front-end de qualidade!" em ciano. O parágrafo está na cor branca, e exibe o texto de apresentação de Joana Santos. Abaixo do parágrafo temos subtítulo com o texto "Acesse minhas redes:", em negrito. Abaixo dele temos três botões pretos que possuem um contorno na cor ciano, dispostos na vertical: no botão superior temos o texto "Github" e à esquerda um ícone que representa esta aplicação. No botão do meio temos o texto texto "LinkedIn" acompanhado do ícone que representa esta aplicação, à esquerda. No botão inferior temos o texto "Twitch" e à esquerda o ícone representando esta aplicação. Já o bloco direito se constitui de uma fotografia em preto e branco representando Joana Santos, uma mulher desenvolvedora, sentada em frente a um notebook aberto. A fotografia também conta com um desenho em ciano de uma linha circulando Joana e seu notebook três vezes e terminando em uma estrela. Na parte inferior da tela, temos uma barra na cor ciano que se estende do canto esquerdo ao canto direito. Em seu interior há o texto "Desenvolvido por Alura", na cor preta.

Temos botões com ícones em seu interior. O que visualmente chama mais a atenção, Rafa?

Rafaella: Os botões, definitivamente. Também temos o novo subtítulo "Acesse minhas redes", que antes eram completamente ciano. Agora eles possuem apenas uma borda nesta cor. Temos também ícones nos botões.

Guilherme: Estes elementos estão nas cores que estamos utilizando.

Rafaella: Exato.

Guilherme: Agora temos também na parte superior os menus "Home" e "Sobre mim".

Rafaella: Nós já desenvolvemos o `<header>`, agora vamos adicionar em seu interior todas as nossas tags para criar o cabeçalho de fato. Nós o adicionamos e o deixamos vazio somente para entender onde ele deveria ficar.

Guilherme: O mesmo vale para o `<footer>` (ou "rodapé"). Onde está escrito "Desenvolvido por Alura", você pode adicionar seu nome.

Além dessa, temos uma página nova, que será acessada quando clicarmos no menu "Sobre mim".

Tela "Sobre mim" do projeto no Figma. O fundo é preto. Na parte superior, temos dois textos em negrito na cor ciano: "Home" e "Sobre mim", dispostos na horizontal, da esquerda para a direita. Abaixo deles, temos dois blocos de conteúdo, lado a lado, centralizados. O bloco esquerdo possui um texto que se divide em duas partes: título e parágrafo. O título apresenta o texto "Sobre mim" em negrito e na cor branca. Os dois parágrafos estão um abaixo do outro, na cor branca, e exibem um texto "Lorem ipsum". Já o bloco direito se constitui de uma fotografia em preto e branco representando Joana Santos, uma mulher desenvolvedora, sentada em frente a um notebook aberto. A fotografia também conta com um desenho em ciano de uma linha circulando Joana e seu notebook três vezes e terminando em uma estrela. Na parte inferior da tela, temos uma barra na cor ciano que se estende do canto esquerdo ao canto direito. Em seu interior há o texto "Desenvolvido por Alura", na cor preta.

Nela, o cabeçalho e o rodapé continuam iguais. O que muda é o conteúdo principal, do meio da tela. Teremos a chance de criar uma biografia, onde poderemos escrever um pouco sobre nós. Por isso, o texto que incluímos no Figma e no curso é ilustrativo.

Rafaella: É importante salientar que, quando recebemos um design para trabalhar, é comum que haja nele esse tipo de texto chamado Lorem ipsum. Ele serve para nos mostrar como o texto final fica disposto na página, sem precisarmos acessar o texto verdadeiro, o qual às vezes nem foi produzido ainda.

Guilherme: Vamos comparar as duas páginas?

Rafaella: Vamos sim.

Guilherme: Os estilos das duas páginas são parecidos, utilizam os mesmos estilos.

Rafaella: Exatamente, a mudança está nas disposições e nos tamanhos do texto. A foto também é a mesma.

Guilherme: Com base no que já aprendemos, é possível deduzir os estilos de cada trecho: o "Sobre mim" seria um <h1>, e os blocos de biografia seriam dois blocos de parágrafo. Nós nos pegamos pensando se vamos utilizar um Flexbox na horizontal ou na vertical. Isso é muito comum. Com a prática, aos poucos, desenvolvemos esse tipo de percepção e passamos a aplicá-la em todas as páginas que vemos.

A seguir, começaremos a criar esta nova etapa do nosso projeto.

### Aula 1 - Posicionando os links - Vídeo 3

Transcrição  
Guilherme: Já conhecemos o projeto novo. Por onde devemos começar: cabeçalho, rodapé, botões?

Rafaella: Isso é uma escolha de cada pessoa desenvolvedora. No nosso caso podemos começar pelos botões, pois existe uma diferença bem clara entre a etapa anterior e a atual.

Guilherme: A primeira mudança que podemos ver é a presença de um novo subtítulo antes dos links, escrito "Acesse minhas redes:". Vamos adicioná-lo.

Rafaella: Voltando ao VS Code, acessaremos o arquivo index.html. Em seu interior encontraremos a `<div>` que agrega os dois botões que criamos: "Instagram" e "Github". Criamos ela para utilizar o Flexbox e realizar o posicionamento dos dois.

```html
//código omitido
    <main class="apresentacao">
        <section class="apresentacao__conteudo">
//código omitido
           <div class="apresentacao__links">
                <a  class="apresentacao__links__link" href="https://instagram.com/rafaballerini">Instagram</a>
                <a class="apresentacao__links__link" href="https://github.com/guilhermeonrails">Github</a>
            </div>
        </section>
        <img src="imagem.png" alt="Foto da Joana Santos programando">
    </main>
    <footer></footer>
</body>
</html>
```

Adicionaremos o novo subtítulo dentro dessa `<div>`, pois ela fará parte da divisão. Acima da linha com o botão do Instagram, adicionaremos um `<h2>`. Por que usamos o `<h2>` e não o `<h1>`?

Guilherme: Porque o `<h1>` é o título principal da página.

Rafaella: Isso mesmo. O correto é utilizar somente um `<h1>` por página, para não atrapalharmos a pesquisa dela no Google. Assim, a página será retornada na pesquisa exibindo somente um título.

Entre as tags de fechamento e abertura do `<h2>` adicionaremos o texto "Acesse minhas redes:".

```html
//código omitido
    <main class="apresentacao">
        <section class="apresentacao__conteudo">
//código omitido
            <div class="apresentacao__links">
                <h2>Acesse minhas redes:</h2>
                <a  class="apresentacao__links__link" href="https://instagram.com/rafaballerini">Instagram</a>
                <a class="apresentacao__links__link" href="https://github.com/guilhermeonrails">Github</a>
            </div>
        </section>
        <img src="imagem.png" alt="Foto da Joana Santos programando">
    </main>
    <footer></footer>
</body>
</html>
```

Guilherme: Acessaremos a nossa página por meio do navegador e veremos que o texto aparece em uma disposição totalmente errada: à esquerda dos botões, e não acima.

Precisamos alterar a forma como dispomos esses elementos.

Rafaella: Exatamente. Eles estão na horizontal porque criamos, dentro de style.css, um .apresentacao__links{} cujo interior possui um justify-content: space-between. Sabemos que quando se cria um display: flex, automaticamente a direção dele será de Row (ou linha). Precisamos alterar a sua direção para Column (ou coluna).

Para isso, acessaremos novamente o arquivo style.css. No interior das chaves de .apresentacao__links{}, abaixo de display: flex adicionaremos um flex-direction: column.

```CSS
.apresentacao__links{
    display: flex;
    flex-direction: column;
    justify-content: space-between;
}
```

Guilherme: Isso mesmo. Queremos que eles fiquem dispostos em coluna, ou seja, na vertical.

Rafaella: Se retornarmos à nossa página aberta no navegador já veremos a alteração. Agora o texto "Acesse minhas redes:" aparece acima dos botões.

Guilherme: Os três elementos (texto e botões) estão grudados. A impressão é de que, além de estarem muito próximos um do outro, estão encostados na borda esquerda do espaço dedicado a eles.

Rafaella: Exatamente. Para centralizar nossos elementos no eixo vertical, podemos utilizar uma outra propriedade do Flexbox, a qual já utilizamos anteriormente: o align-items.

Importante: Anteriormente havíamos utilizado o align-items para centralizar os elementos na vertical, pois o flex-direction estava em Row. Agora que alteramos a direção do Flexbox para Column, os elementos serão alinhados na vertical. Sempre que realizarmos uma alteração no flex-direction, ela se aplicará a todas as propriedades relacionadas.

Por este motivo, utilizaremos a mesma propriedade, mas obteremos um resultado diferente do anterior. Acessaremos novamente o interior das chaves de .apresentacao__links{}, e abaixo de justify-content adicionaremos um align-items: center.

```CSS
.apresentacao__links{
    display: flex;
    flex-direction: column;
    justify-content: space-between;
    align-items: center;
}
```

Guilherme: Se abrirmos o Figma, temos um espaço entre cada elemento. Podemos adicioná-lo com o gap.

Rafaella: Se clicarmos no subtítulo e arrastarmos o mouse para o primeiro botão, o Figma nos mostrará a distância exata entre cada elemento: 32px.

Guilherme: Podemos dizer que queremos um espaço de 32px entre cada uma das redes.

Rafaella: Exato. Já havíamos conhecido a propriedade gap, a qual deve ser inserida em nossa tag contêiner. Para configurar esse espaçamento vamos adicionar um gap: 32px abaixo de align-items: center.

```CSS
.apresentacao__links{
    display: flex;
    flex-direction: column;
    justify-content: space-between;
    align-items: center;
    gap: 32px;
}
```

Salvaremos nosso código e retornaremos à página aberta no navegador. Nela, tanto o texto "Acesse minhas redes:" quanto os botões aparecem centralizados verticalmente, com um espaçamento entre cada um deles.

Guilherme: Nossa página está cada vez mais parecida com o projeto principal. Se abrirmos o Figma, veremos que os botões possuem a mesma cor do fundo da página, possuem uma imagem ao lado do texto e parece que o tamanho do botão também é diferente.

Rafaella: Exatamente.

Guilherme: A seguir, vamos implementar essas mudanças.

### Aula 1 - Alinhando com display flex

Aprendemos que podemos utilizar o display: flex para posicionar elementos na tela, observando seu comportamento padrão. Dito isso, observe o código HTML a seguir, no qual o elemento pai container contém quatro divs e cada uma será um quadrado na tela:

```html
    <body>
        <div class="container">
            <div class="quadrado"></div>
            <div class="quadrado"></div>
            <div class="quadrado"></div>
            <div class="quadrado"></div>
        </div>
    </body>
```

Já no CSS, o elemento pai foi estilizado da seguinte maneira:

```CSS
.container {
margin: 20%;/* adiciona uma margem para centralizar os quadrados na tela*/
display: flex;/* coloca os quadrados lado a lado */
gap: 10px;/* adiciona espaços iguais entre cada quadrado */
}
```

Esses códigos exibem o seguinte resultado na tela:

Tela com fundo branco com quatro quadrados azuis alinhados ao centro da tela e horizontalmente dispostos lado a lado com espaços iguais entre si

Imagine que você deseja alinhar esses quadrados verticalmente, um embaixo do outro, porém mesmo adicionando o display: flex ainda não obteve esse resultado.

Como você pode organizar os quadrados verticalmente?

Resposta:  
Podemos adicionar a propriedade flex-direction: column ao CSS da classe .container.

> Ao adicionarmos a propriedade flex-direction: column os quadrados irão se posicionar verticalmente, já que define que a direção do display: flex deve ser em “coluna”.

### Aula 1 - Estilizando os links - Vídeo 4

Transcrição  
Rafaella: Conseguimos posicionar nossos links corretamente. O subtítulo ainda possui fonte e tamanho errados, portanto vamos estilizá-lo.

Guilherme: Vamos.

Rafaella: Retornaremos ao VS Code e acessaremos o arquivo index.html, onde criaremos uma classe para o subtítulo. Acessaremos a tag de abertura do nosso <h2>, entre os sinais de menor e de maior, e adicionaremos uma class="". Qual será o nome dessa classe?

Guilherme: Considerando o padrão seguido, pode ser apresentacao__links__subtitulo?

Rafaella: Pode ser. Adicionaremos este nome entre as aspas e salvaremos nosso código.

```html
<!-- código omitido -->
    <main class="apresentacao">
                    <section class="apresentacao__conteudo">
            <div class="apresentacao__links">
                <h2 class="apresentacao__links__subtitulo">Acesse minhas redes:</h2>
                <a  class="apresentacao__links__link" href="https://instagram.com/rafaballerini">Instagram</a>
                <a class="apresentacao__links__link" href="https://github.com/guilhermeonrails">Github</a>
            </div>
        </section>
        <img src="imagem.png" alt="Foto da Joana Santos programando">
    </main>
    <footer></footer>
</body>
</html>
```

Copiaremos o nome da classe e acessaremos o arquivo style.css.

Devemos sempre escrever o CSS na ordem em que utilizamos as *tags no HTML*. Portanto, adicionaremos a nova classe .apresentacao__links__subtitulo{} acima de .apresentacao__links__link{}.

```CSS
.apresentacao__links__subtitulo{

}

.apresentacao__links__link{
    //código omitido
}
```

Iniciaremos a nossa estilização.

Guilherme: O primeiro detalhe a ser alterado será a fonte do subtítulo.

Rafaella: Se acessarmos o Figma e clicarmos neste elemento, descobriremos na aba "Design" o nome da fonte: Krona One. Já utilizamos esta fonte anteriormente, portanto já temos a sua importação no projeto. Basta que a chamemos.

Guilherme: Para chamá-la, adicionaremos entre as chaves de .apresentacao__links__subtitulo{} um font-family:'Krona One', 'sans-serif'. Temos que modificar também o peso e o tamanho dessa fonte.

Rafaella: Exato. Se acessarmos o Figma e clicarmos no subtítulo, descobriremos na aba "Inspect" o font-weight (ou "peso da fonte"): 400. Na mesma aba veremos o Size (ou "tamanho") de 24px.

Voltaremos ao VS Code e traremos estas configurações adicionando abaixo de font-family um font-weight: 400. Abaixo de font-weight, por sua vez, adicionaremos um font-size: 24px.

```CSS
.apresentacao__links__subtitulo{
    font-family:'Krona One', 'sans-serif';
    font-weight: 400;
    font-size: 24px;
}
```

Guilherme: O sans-serif é uma propriedade, portanto não precisamos adicioná-lo entre aspas simples. Vamos retirá-las.

```CSS
.apresentacao__links__subtitulo{
    font-family:'Krona One', sans-serif;
    font-weight: 400;
    font-size: 24px;
}
```

Rafaella: Salvaremos o código e retornaremos à página aberta pelo navegador. Nela, temos o subtítulo com a fonte, tamanho e peso desejados. Em seguida, estilizaremos os botões em si, trocando o fundo ciano por bordas nessa cor.

Retornaremos ao arquivo style.css pelo VS Code e buscaremos a classe .apresentacao__links__link{}. Entre suas chaves, alteraremos os seguintes elementos:

- removeremos o fundo ciano, deletando o comando background-color: #22D4FD;
- mudaremos a cor dos textos, modificando o valor de color de #000000 (preto) para #F6F6F6 (branco);
- adicionaremos a borda 2px solid (borda sólida com 2px de espessura), na cor #22D4FD (ciano);

Os valores de cor do texto e de borda encontraremos no Figma. Com a seleção ativa nestes elementos, veremos na aba "Inspect" os campos color: #F6F6F6 e border: 2px solid #22D4FD, respectivamente. Basta copiar os valores destes campos.

Dica: Se você gostou da configuração anterior, é possível comentar estes trechos de código em vez de excluí-los. Os trechos de código que comentamos não são lidos pelo sistema. No Visual Studio Code, o atalho para comentar uma linha de código é "Ctrl + K + C". Após ativá-lo, o VS Code adicionará os comando /* e */ no início e no final da linha, respectivamente.

Vamos comentar um trecho do código como exemplo: /* background-color: #22D4FD; */.

```CSS
.apresentacao__links__link{
    /* background-color: #22D4FD; */
    border: 2px solid #22D4FD;
    width: 280px;
    text-align: center;
    border-radius: 16px;
    font-size: 24px;
    font-weight: 600;
    padding: 21.5px 0;
    text-decoration: none;
    color: #F6F6F6;
    font-family: 'Montserrat', sans-serif;
}
```

Salvaremos o código e retornaremos à página aberta pelo navegador. Nela, temos os dois botões na cor preta, com bordas ciano e seus respectivos textos na cor branca. Ficou do jeito que queríamos.

Guilherme: Vamos entender o código: na propriedade border, o primeiro valor informa a espessura da borda.

Rafaella: O segundo valor informa o tipo de tracejado. Neste caso é sólido. Se acessarmos a página do W3Schools sobre bordas do CSS, veremos na seção "CSS Border Style" (ou "estilo de borda CSS") vários opções de estilização de borda disponíveis.

Guilherme: O próprio CSS possui configurações nativas. Existem muitas propriedades pré-definidas, e cabe a nós explorarmos e aprendermos sobre elas.

Rafaella: Imagine receber um Figma com bordas pontilhadas, por exemplo. Se não houvesse a propriedade border, seria muito difícil configurar algo assim.

Voltaremos ao VS Code para entender o último valor de border: a cor. Como vimos anteriormente, se trata de um valor hexadecimal que traz a cor escolhida.

Acessaremos o Figma e veremos que a largura do botão também mudou, está maior. Clicaremos neste elemento e buscaremos na aba Inspect o valor de sua width: 378px. Copiaremos este valor e voltaremos ao VS Code. Em .apresentacao__links__link{} substituiremos o valor da width de 280px para 378px.

A forma do botão também mudou. Antes, tínhamos cantos arredondados, e agora eles estão mais retos. Buscaremos e copiaremos no Figma o valor de Radius da borda: 8px. Ainda em .apresentacao__links__link{} substituiremos o valor da border-radius de 16px para 8px.

```CSS
.apresentacao__links__link{
    /* background-color: #22D4FD; */
    border: 2px solid #22D4FD;
    width: 378px;
    text-align: center;
    border-radius: 8px;
    font-size: 24px;
    font-weight: 600;
    padding: 21.5px 0;
    text-decoration: none;
    color: #F6F6F6;
    font-family: 'Montserrat', sans-serif;
}
```

Salvaremos o código e veremos as alterações no navegador, onde temos os dois botões mais largos e com bordas menos redondas.

Guilherme: Os ícones dos botões estão fazendo falta. A seguir, vamos adicioná-los.

### Aula 1 - Para saber mais: border e comentário nos códigos

Durante a aula, personalizamos a propriedade CSS chamada border, para adicionar a borda em volta dos botões. Essa propriedade pode ser usada para definir os valores de largura da borda, estilo da borda e cor da borda e possui alguns estilos diferentes, como o “dotted”, que conhecemos na aula [através da documentação](https://www.w3schools.com/css/css_border.asp).

Caso você queira conhecer melhor essa propriedade, que tal dar uma olhada no artigo [CSS Border: estilizando com bordas seus elementos CSS](https://www.alura.com.br/artigos/css-border-estilizando-bordas-elementos-css) e no [Alura+](https://cursos.alura.com.br/extra/alura-mais/css-border-estilizando-com-bordas-seus-elementos-css-c1486) de mesmo nome feitos pelo instrutor Luan Alves.

O que são comentários?  
Comentários são notas de texto que podem ser inseridas ao longo do desenvolvimento e que serão ignoradas pelo código, portanto não interferem em seu funcionamento.

Para que servem os comentários  
Os comentários podem ser usados para anotar informações importantes sobre o código, para salvar códigos que estivermos testando sem que haja necessidade de apagar e reescrever, para descrever alguma função específica e facilitar manutenções futuras ou até para auxiliar na organização das ideias de construção do código.

Como comentar em HTML e CSS  
O uso de comentários é comum em diversas linguagens e cada uma terá sua sintaxe particular. Isso também acontece em HTML e CSS, já que em cada uma temos uma maneira de adicionar comentários, que vamos conhecer a seguir:

HTML  
Os comentários no HTML se assemelham com uma abertura de tag. Abrimos um comentário com <!-- e fazemos seu fechamento com -->. Tudo que estiver entre esses dois marcadores será considerado como comentário, inclusive quebras de linha:

```html
<p> Isso é um parágrafo de texto e será exibido pelo navegador </p>

<!-- Isso é um comentário e será ignorado  -->

<!-- Isso é um comentário com quebra de linha

e também será ignorado  -->

<p> Isso é um parágrafo de texto e será exibido pelo navegador </p>
```

CSS
Os comentários em CSS também possuem abertura e fechamento. Abrimos esse tipo de comentário com /* e fechamos com */ e assim como no HTML, tudo que estiver entre essas marcações será considerado comentário, ainda que esteja entre mais de uma linha:

```CSS
body{
    background-color: white; 
    /* Isso é um comentário em CSS */
    /* 
        Isso é um comentário em CSS com
        quebra de linha
    */
}
```

Boas práticas ao comentar  
Os comentários podem ser muito úteis para facilitar o desenvolvimento, no entanto, precisamos ter atenção a algumas boas práticas para fazer seu uso adequado:

- Evite adicionar muitos comentários para não gerar uma “bagunça” em seu código;
- Evite criar comentários muito longos. Tenha em mente que apesar de não serem executados, esses comentários ocupam espaço e podem deixar seu arquivo mais pesado;
- Use os comentários a seu favor, ou seja, anote informações essenciais neles, pois isso irá facilitar com que você encontre aquilo que é realmente necessário lembrar no momento de fazer manutenções em seu código;
- Ao usar comentários para testar sua aplicação, lembre-se de apagar essas notas quando terminar, para que seu código não fique desorganizado e com partes desnecessárias;
- Por fim, lembre-se sempre que um código descritivo é mais duradouro que muitos comentários. Quando estiver trabalhando com HTML, lembre-se de usar as [Tags semânticas](https://developer.mozilla.org/pt-BR/docs/Glossary/Semantics) e ao criar suas classes CSS, adicione nomes significativos. Assim, seu código ficará naturalmente descritivo e não dependerá tanto dos comentários, que podem ser apagados ou se perderem ao longo de manutenções =) .

### Aula 1 - Lista de exercícios

O que é:  
Boas-vindas à nossa lista de exercícios "Mão na massa", um caminho prático e envolvente para aprender e aprimorar suas habilidades em tecnologia. Aqui, você não encontrará longas leituras teóricas ou explicações abstratas. Em vez disso, nossos exercícios são projetados para colocar você no centro do processo de aprendizado, permitindo que você construa, experimente e explore conceitos tecnológicos de forma direta e aplicada.

Para que serve:  
Esta lista é uma ferramenta dinâmica para aprender, reforçar e aprimorar habilidades práticas em programação e desenvolvimento web. Cada exercício é uma oportunidade de aplicar conhecimentos teóricos em cenários reais, preparando você não apenas para entender a tecnologia, mas para utilizá-la de maneira eficaz e criativa em seus próprios projetos ou no ambiente de trabalho.

Como fazer:

- Leia cada exercício com atenção: comece entendendo o cenário proposto e o que se espera como resultado.
- Escreva o código: utilize o ambiente de codificação de sua escolha para escrever e testar o seu código. Não se preocupe em acertar de primeira, a prática leva à perfeição.
- Verifique o gabarito: após tentar resolver o exercício, compare seu código com o gabarito fornecido em “Opinião do instrutor”. Isso ajudará a identificar áreas de melhoria e consolidar o aprendizado.
- Repita: a repetição é chave para o aprendizado. Tente fazer os exercícios mais de uma vez, aplicando melhorias e variantes.
- Lembre-se, cada desafio é uma chance de crescer. Não se desanime com os erros; eles são degraus no caminho do aprendizado. E acima de tudo, divirta-se! O aprendizado mais eficaz acontece quando nos engajamos e nos interessamos pelo que estamos fazendo.

Não se esqueça que estamos no Fórum e no Discord para te ajudar!

Bons estudos!

1) Adicionando um subtítulo à página  
Imagine que você está desenvolvendo uma página web para compartilhar suas redes sociais. Você precisa adicionar um subtítulo "Acesse minhas redes:" acima dos links para Instagram e Github. Sua tarefa é editar o arquivo index.html para incluir esse subtítulo. Lembre-se de usar a tag `<h2>` para o subtítulo e colocá-lo dentro da `<div>` que já contém os links.

2) Alterando a disposição dos elementos com Flexbox  
Agora que o subtítulo foi adicionado, você percebe que ele está alinhado à esquerda dos botões, ao invés de acima deles. Isso aconteceu porque os elementos estão dispostos horizontalmente. Sua missão é alterar a disposição dos elementos (subtítulo e botões) para uma disposição vertical. Edite o arquivo style.css, modificando a propriedade flex-direction para column dentro da classe .apresentacao__links. Isso mudará a direção do Flexbox, alinhando os elementos verticalmente.

3) Ajustando o alinhamento e o espaçamento dos elementos  
Após modificar a direção do Flexbox, você observa que os elementos (texto e botões) estão muito próximos uns dos outros e alinhados à esquerda. Para melhorar a estética da página, você precisa centralizar esses elementos verticalmente e adicionar um espaçamento entre eles. No arquivo style.css, dentro da classe .apresentacao__links, adicione a propriedade align-items: center para centralizar os elementos. Em seguida, insira a propriedade gap com o valor de 32px para adicionar o espaçamento entre cada elemento.

4) Criando uma classe para o subtítulo  
Você está desenvolvendo uma página web e decidiu que o subtítulo "Acesse minhas redes:" precisa de uma estilização específica. Para isso, você vai criar uma classe CSS para este subtítulo. No arquivo index.html, encontre a tag `<h2>` que contém o subtítulo e adicione uma classe chamada apresentacao__links__subtitulo. Sua tarefa é inserir essa classe na tag `<h2>` de forma correta.

5) Estilizando o subtítulo  
Agora que você criou uma classe para o subtítulo, é hora de estilizá-lo. No arquivo style.css, adicione a classe .apresentacao__links__subtitulo e configure as propriedades de estilo. Utilize a fonte 'Krona One', com um peso de fonte (font-weight) de 400 e um tamanho de fonte (font-size) de 24px. Ajuste a fonte para ser 'sans-serif' sem aspas. Sua tarefa é escrever o código CSS para aplicar essas configurações ao subtítulo.

6) Modificando o estilo dos botões  
Os botões da sua página precisam de um novo visual. No arquivo style.css, encontre a classe .apresentacao__links__link e faça as seguintes alterações: remova o fundo ciano, mude a cor do texto para branco (#F6F6F6), adicione uma borda sólida de 2px na cor ciano (#22D4FD), altere a largura para 378px, e ajuste o border-radius para 8px. Sua tarefa é alterar o código CSS para refletir estas mudanças, criando botões com bordas ciano, texto branco, e cantos menos arredondados.

Opinião do instrutor

1) Adicionando um subtítulo à página

- Abra o arquivo index.html.
- Localize a `<div class="apresentacao__links">`.
- Acima da linha do primeiro link, adicione a tag `<h2>` com o texto "Acesse minhas redes:". Seu código deve ficar assim:

```html
<div class="apresentacao__links">
    <h2>Acesse minhas redes:</h2>
    <a class="apresentacao__links__link" href="https://instagram.com/rafaballerini">Instagram</a>
    <a class="apresentacao__links__link" href="https://github.com/guilhermeonrails">Github</a>
</div>
```

2) Alterando a disposição dos elementos com Flexbox

- Abra o arquivo style.css.
- Encontre a classe .apresentacao__links.
- Adicione a propriedade flex-direction: column; para mudar a disposição dos elementos para vertical. O código ficará:

```CSS
.apresentacao__links {
    display: flex;
    flex-direction: column;
    justify-content: space-between;
}
```

3) Ajustando o alinhamento e o espaçamento dos elementos

- Continuando no arquivo style.css, dentro da classe .apresentacao__links:
- Adicione align-items: center; para centralizar os elementos verticalmente.
- Insira gap: 32px; para criar um espaçamento de 32px entre cada elemento. O código final será:

```CSS
.apresentacao__links {
    display: flex;
    flex-direction: column;
    justify-content: space-between;
    align-items: center;
    gap: 32px;
}
```

4) Criando uma classe para o subtítulo

- Abra o arquivo index.html.
- Localize a tag `<h2>` que contém o texto "Acesse minhas redes:".
- Adicione a classe apresentacao__links__subtitulo à tag `<h2>`. O trecho de código deve ficar assim: `<h2 class="apresentacao__links__subtitulo">Acesse minhas redes:</h2>`

5) Estilizando o subtítulo

- Abra o arquivo style.css.
- Adicione a classe .apresentacao__links__subtitulo no início do arquivo.
- Configure as propriedades da classe da seguinte forma:

```CSS
.apresentacao__links__subtitulo {
    font-family: 'Krona One', sans-serif;
    font-weight: 400;
    font-size: 24px;
}
```

6) Modificando o estilo dos botões

- Ainda no arquivo style.css, encontre a classe .apresentacao__links__link.
- Faça as seguintes modificações na classe:

```CSS
.apresentacao__links__link {
    /* background-color: #22D4FD; */ /* Código comentado */
    border: 2px solid #22D4FD;
    color: #F6F6F6;
    width: 378px;
    border-radius: 8px;
    /* Outras propriedades existentes permanecem inalteradas */
}
```

Salve o arquivo e visualize as mudanças no navegador.

## Aula 2 - Criando icones Clicáveis

### Aula 2 - Projeto da aula anterior

Aqui você pode [baixar os arquivos da aula 01](https://github.com/alura-cursos/Portifolio-HTML-e-CSS-Curso3/archive/refs/heads/aula_1.zip) ou acessar os [arquivos no Github!](https://github.com/alura-cursos/Portifolio-HTML-e-CSS-Curso3/tree/aula_1)

### Aula 2 - Preparando o ambiente

Nas próximas aulas iremos adicionar ícones ao nosso projeto. Para baixar a pasta com as imagens que usaremos para criar esses ícones, basta [clicar aqui](https://github.com/alura-cursos/Assets-aula2-curso3-html-e-css/archive/refs/heads/main.zip) ou acessar os [arquivos no Github!](https://github.com/alura-cursos/Assets-aula2-curso3-html-e-css) =)

### Aula 2 - Ícones das redes sociais - Vídeo 1

Transcrição  
Guilherme: Vamos inserir os ícones em nossos links. Em nosso código, temos links de duas redes: o Instagram e o Github.

Rafaella: Isso. Já no Figma, temos três: Github, LinkedIn e Twitch. Vamos atualizar com base no Figma. Contudo, você pode atualizar com as suas próprias redes!

Voltando ao VS Code, acessaremos novamente o arquivo index.html para trazer as imagens dos ícones, considerando que já sabemos como criar a tag `<img>`.

Primeiro, vamos realizar os passos abaixo:

- deletar a tag `<a>` correspondente ao Github;
- alterar o texto do primeiro `<a>`, de "Instagram" para "Github", substituindo o endereço do Instagram por um endereço de Github;
- separar a tag de abertura `<a>`, o texto "Github" e a tag de fechamento `</a>`, pressionando "Enter" entre elas, deixando uma linha vazia acima do texto.
- Nesta linha vazia adicionaremos a tag `<img>`.

```html
//código omitido
    <main class="apresentacao">
        <section class="apresentacao__conteudo">
//código omitido
            <div class="apresentacao__links">
                <h2 class="apresentacao__links__subtitulo">Acesse minhas redes:</h2>
                <a  class="apresentacao__links__link" href="https://github.com/rafaballerini">
                    <img>
                    Github
                </a>
            </div>
        </section>
        <img src="imagem.png" alt="Foto da Joana Santos programando">
    </main>
    <footer></footer>
</body>
</html>
```

O que faremos para trazer a nossa imagem?

Guilherme: Precisamos especificar o local em que essa imagem está. Já fizemos o download de todas as imagens com os ícones das redes que precisamos.

Rafaella: Inclusive de alguns que não utilizaremos no projeto, mas que disponibilizamos para que sejam utilizados.

Guilherme: Acessaremos o explorador do nosso sistema operacional. Abriremos a pasta onde se encontram as imagens, e em seguida vamos selecioná-las e arrastá-las para o explorador do VS Code. Neste momento, todas as imagens serão coladas no projeto e ficarão dispostas aleatoriamente entre os arquivos.

Como boa prática, criaremos uma pasta para isolar todas as imagens do restante dos arquivos.

Rafaella: No topo do explorador, clicaremos no ícone de pasta denominado "New Folder" (ou "Novo Arquivo"). No campo de texto que será aberto, digitaremos o nome da nova pasta. Vamos nomeá-la "assets" pois é um nome muito utilizado nos projetos reais.

Pelo explorador, arrastaremos cada uma das imagens para dentro da pasta "assets".

Observação: A imagem que já havíamos utilizado, denominada imagem.png, será realocada. Portanto, precisamos informar no código o novo local em que ela se encontra. Para isso, acessaremos a linha dessa `<img>` e substituiremos dentro de src o local antigo ("imagem.png") pelo local novo: "./assets/imagem.png".

```html
//código omitido
        </section>
        <img src="./assets/imagem.png" alt="Foto da Joana Santos programando">
    </main>
    <footer></footer>
</body>
</html>
```

Guilherme: Informaremos o caminho da imagem que vamos inserir — ou seja, o ícone do Github. Voltaremos à nova tag `<img>` e antes do sinal de menor adicionaremos um src="", o qual possuirá entre as aspas duplas o endereço ./assets/github.png.

```html
//código omitido
    <main class="apresentacao">
        <section class="apresentacao__conteudo">

//código omitido

            <div class="apresentacao__links">
                <h2 class="apresentacao__links__subtitulo">Acesse minhas redes:</h2>
                <a  class="apresentacao__links__link" href="https://github.com/rafaballerini">
                <img src="./assets/github.png">
                Github
                </a>
            </div>
        </section>
        <img src="./assets/imagem.png" alt="Foto da Joana Santos programando">
    </main>
    <footer></footer>
</body>
</html>
```

Rafaella: Para adicionar os outros ícones e botões, copiaremos a estrutura da tag `<a>` e colaremos duas vezes, uma embaixo da outra, já que utilizaremos a mesma classe, apresentacao__links__link, para as três.

Em seguida modificaremos o conteúdo de href, de src e do texto para que correspondam à cada rede social: acima o Github, no meio o LinkedIn, e embaixo a Twitch.

Atenção ao endereço de cada rede social, pois elas possuem padrões diferentes. Por exemplo, o endereço base do LinkedIn é "linkedin.com/in/nome-da-pessoa".

```html
//código omitido
    <main class="apresentacao">
        <section class="apresentacao__conteudo">

//código omitido

            <div class="apresentacao__links">
                <h2 class="apresentacao__links__subtitulo">Acesse minhas redes:</h2>
                <a  class="apresentacao__links__link" href="https://github.com/rafaballerini">
                    <img src="./assets/github.png">
                    Github
                </a>
                <a  class="apresentacao__links__link" href="https://linkedin.com/in/rafaellaballerini">
                    <img src="./assets/linkedin.png">
                    LinkedIn
                </a>
                <a  class="apresentacao__links__link" href="https://twitch.tv/guilimadev">
                    <img src="./assets/twitch.png">
                    Twitch
                </a>
            </div>
        </section>
        <img src="./assets/imagem.png" alt="Foto da Joana Santos programando">
    </main>
    <footer></footer>
</body>
</html>
```

Salvaremos o nosso código e retornaremos ao navegador, onde veremos nossa página com os três botões, "Github", "LinkedIn" e "Twitch", com seus respectivos ícones à esquerda. Entretanto, eles estão desalinhados em relação ao texto (alguns para cima, outros para baixo). Precisamos modificar a estilização de posicionamento dos nossos dois elementos que estão dentro de cada botão.

Guilherme: Faremos isso na sequência.

### Aula 2 - Buscando arquivos em pastas

Aprendemos que uma prática comum no desenvolvimento com HTML e CSS é criar uma pasta assets para inserir todas as imagens do projeto. No entanto, quando buscamos alguma imagem através da tag img no HTML, precisamos nos atentar ao caminho desse arquivo que está dentro de pastas. Com isso em mente, observe a organização das pastas do projeto à seguir:

Aba de pastas do editor de código, na parte superior esquerda há o nome da pasta de projeto aberto, que é “meu-projeto”. Dentro dessa pasta há um arquivo “index.html” e um arquivo “style.css”, além de uma pasta “assets”, que contém um arquivo chamado “montanha.png”.

Você precisa que o arquivo montanha.png, localizado dentro da pasta assets do projeto, seja exibido em uma página (com HTML). Logo, você escreve o código à seguir:

```html
<div class="container">
<img src="montanha.png" alt="imagem de uma montanha">
</div>
```

Como a imagem será exibida na página?

Alternativa correta:  
A imagem será quebrada e será exibido apenas o texto alternativo, já que o link da imagem em src está incorreto.

> O HTML não irá encontrar a imagem, pois o link em src deveria considerar que a imagem está dentro de uma pasta. Portanto, o link correto deveria ser ./assets/montanha.png. Devemos sempre estar atentos à organização das pastas quando queremos buscar um arquivo através de seu caminho.

### Aula 2 - Posicionando os ícones - Vídeo 2

Transcrição
Rafaella: Alinharemos os ícones junto a seus respectivos textos dentro dos botões de redes sociais. Consegue imaginar como faremos isso?

Guilherme: Teremos que alterar o alinhamento e disposição de todos os elementos localizados dentro da tag `<a>`.

Rafaella: Por que justamente na tag `<a>`?

Guilherme: Porque precisamos alinhar tanto a imagem quanto o texto.

Rafaella: Exatamente. São os dois elementos filhos dessa tag. Normalmente, no Flexbox, alteramos o contêiner com as propriedades que costumamos usar. Também existem propriedades para os elementos filhos.

Acessaremos o arquivo style.css, no qual encontraremos a tag `<a>`. Faremos isso através da busca pela classe dela: .apresentacao__links__link{}. Qual propriedade usaremos para iniciar o Flexbox?

Guilherme: Para garantir que os elementos tenham uma disposição diferente através do Flexbox, utilizamos o display: flex.

Rafaella: Perfeito. Vamos inserir o display: flex junto ao seu ponto e vírgula. Essa inserção será feita entre os códigos background-color e border.

```CSS
.apresentacao__links__link {
    /* background-color: #22D4FD; */
    display: flex;
    border: 2px solid #22D4FD;
    width: 378px;
    text-align: center;
    border-radius: 8px;
    font-size: 24px;
    font-weight: 600;
    padding: 21.5px 0;
    text-decoration: none;
    color: #F6F6F6;
    font-family: 'Montserrat', sans-serif;
}
```

Guilherme: Se consultarmos nossa página por meio do navegador, veremos que tanto os ícones quanto os textos foram movidos para o canto esquerdo do botão.

Rafaella: Sim, pois este é o padrão do Flexbox.

Guilherme: Agora precisamos alterar o alinhamento, informando aos elementos do botão que eles devem ser centralizados.

Rafaella: Para isso, utilizaremos qual propriedade?

Guilherme: O justify-content.

Rafaella: Isso mesmo. Consultaremos a página do Flexbox Guide (ou "Guia do Flexbox") conforme já fizemos anteriormente. Nela vamos até a seção "justify-content", onde encontraremos o valor que devemos utilizar dentro da propriedade justify-content para que o nosso conteúdo fique centralizado no eixo horizontal: center.

Vamos lembrar que, no Flexbox, a direção padrão é Row (ou seja, já é horizontal). Portanto, basta que adicionemos ao CSS dos nossos botões o comando justify-content: center. Essa adição será feita entre os códigos display e border.

```CSS
.apresentacao__links__link {
    /* background-color: #22D4FD; */
    display: flex;
    justify-content: center;
    border: 2px solid #22D4FD;
    width: 378px;
    text-align: center;
    border-radius: 8px;
    font-size: 24px;
    font-weight: 600;
    padding: 21.5px 0;
    text-decoration: none;
    color: #F6F6F6;
    font-family: 'Montserrat', sans-serif;
}
```

Guilherme: Temos outro problema: o ícone e o texto estão grudados. Se consultarmos o Figma, veremos que existe um pequeno espaço entre eles.

Rafaella: Sim. Acessaremos o Figma do projeto e clicaremos em um dos ícones de botão. Em seguida, direcionaremos o cursor para o texto à sua direita. O número que aparece em laranja é o valor do espaçamento em px entre o ícone e o texto. Neste caso, o valor é 16. Utilizaremos este valor em uma propriedade específica. Qual seria ela?

Guilherme: Para adicionar espaço entre todos os elementos, usaremos o gap.

Rafaella: Perfeito. Retornaremos ao arquivo CSS onde, abaixo da propriedade justify-content, adicionaremos um gap: 16px.

```CSS
.apresentacao__links__link {
    /* background-color: #22D4FD; */
    display: flex;
    justify-content: center;
    gap: 16px;
    border: 2px solid #22D4FD;
    width: 378px;
    text-align: center;
    border-radius: 8px;
    font-size: 24px;
    font-weight: 600;
    padding: 21.5px 0;
    text-decoration: none;
    color: #F6F6F6;
    font-family: 'Montserrat', sans-serif;
}
```

Salvaremos nosso código e voltaremos à nossa página aberta pelo navegador. Veremos que os ícones e textos estão agora centralizados no interior do botão, separados por um pequeno espaço entre eles.

### Aula 2 - Posicionando com Flexbox

Você cria um projeto HTML com uma imagem e um parágrafo de texto, que estão dentro de uma section, como podemos observar no código a seguir:

```html
<section>
    <img src="logo-alura.png" alt="Logo da Alura">
    <p>Estou aprendendo HTML e CSS na Alura!</p>
</section>  
```

Logo, você cria um arquivo CSS para essa página, onde estiliza alguns detalhes de acordo com sua preferência e adiciona um display: flex para posicionar os elementos lado a lado, da seguinte forma:

```CSS
section{
    border-style: solid;    /* Cria uma borda sólida */
    border-color:red;   /* Colore a borda com a cor vermelha */
    margin: 10%;    /* Adiciona uma margem ao redor da section */
    display: flex;  /* Adiciona o display flex */
}
```

Com o display: flex, os elementos que antes ficavam um embaixo do outro como nessa imagem:  
![alt text](image.png)

Tela com fundo branco e um retângulo com uma borda fina em vermelho e área interna com fundo branco. Dentro do retângulo, no canto esquerdo encostado na borda há uma imagem que é um quadrado em azul escuro com o texto “Alura” escrito na cor branca no centro do quadrado. Abaixo da imagem, também encostado na borda esquerda do retângulo há o texto “Estou aprendendo HTML e CSS na Alura!” escrito na cor preta

Se posicionam lado a lado na tela, como está representado na imagem abaixo:  
![alt text](image-1.png)

Tela com fundo branco e um retângulo com uma borda fina em vermelho e área interna com fundo branco. Dentro do retângulo, no canto esquerdo encostado na borda há uma imagem que é um quadrado em azul escuro com o texto “Alura” escrito na cor branca no centro do quadrado. Do lado direito da imagem, encostado na borda superior do retângulo há o texto “Estou aprendendo HTML e CSS na Alura!” escrito na cor preta

Observe que mesmo aplicando o display: flex em seu elemento pai (section), todos os elementos filhos (imagem e parágrafo) continuaram deslocados para o canto esquerdo da section.

O que podemos fazer para que a imagem e o parágrafo se desloquem para o centro dentro dessa section ?

Alternativa correta:  
Podemos adicionar a propriedade justify-content: space-around ao CSS da section.

> A propriedade justify-content controla o posicionamento dos elementos filhos ao longo do eixo principal e também ajuda a distribuir o espaço livre entre eles. Com o valor space-around, os itens serão distribuídos cada um com um espaço ao seu redor.

Alternativa correta:  
Podemos adicionar a propriedade justify-content: center ao CSS da section.

> A propriedade justify-content controla o posicionamento dos elementos filhos ao longo do eixo principal e também ajuda a distribuir o espaço livre entre eles. Com o valor center, os elementos serão centralizados em seu elemento pai, mas sem espaços entre si.

Alternativa correta:  
Podemos adicionar a propriedade justify-content: space-evenly ao CSS da section.

> A propriedade justify-content controla o posicionamento dos elementos filhos ao longo do eixo principal e também ajuda a distribuir o espaço livre entre eles. Com o valor space-evenly, os itens são distribuídos com espaços iguais entre si e até as bordas. Como temos apenas 2 elementos, eles ficarão centralizados.

### Aula 2 - Hover - Vídeo 3

Transcrição  
Rafaella: Conseguimos aproximar nosso código do Figma. No entanto, existe um detalhe que não é possível visualizar no Figma: uma espécie de animação. Quando passamos o mouse por cima do explorador lateral do Figma, cada menu perpassado ganha um destaque por meio de uma borda azul. Chamamos este efeito de Hover.

Vamos aplicá-lo em nossa página de portfólio, de modo que quando passamos o cursor por cima dos botões, eles serão destacados em outra cor.

Guilherme: É possível notar outro detalhe: quando o cursor passa pela tela da nossa página, ele se torna uma seta. Já quando o passamos por cima de um botão, ele se torna uma mão com o indicador levantado.

Rafaella: Exatamente. Isso é feito automaticamente pela âncora, quando utilizamos essa tag. Contudo, também é possível estilizar esse pointer, ou cursor. Por ora, focaremos no Hover.

Guilherme: A ideia consiste em ativar um recurso visual quando o cursor acessar a área do nosso elemento clicável.

Rafaella: Exatamente. Os designers disponibilizaram dentro do Figma, abaixo da nossa página, dois ícones de botão soltos: um representando o seu estado normal, e outro representando a borda destacada do Hover, preenchida na cor 272727. Essa cor consiste na cor de fundo original, em um tom levemente mais claro. Esta será a cor que veremos quando o cursor passar por cima do botão.

Veremos como esse processo funciona acessando a documentação do Hover no site W3Schools. Dentro da subseção "Example", veremos o exemplo de utilização abaixo.

```CSS
a:hover {
    background-color: yellow;
}
```

Acima deste exemplo temos uma frase indicando que, com este comando, seremos capazes de selecionar e estilizar o link quando o mouse estiver por cima dele.

No exemplo, utilizamos a tag âncora a seguida de :hover.

Guilherme: Contudo, não precisamos necessariamente utilizar a tag a. Em vez disso, podemos informar uma classe.

Rafaella: Exatamente. Estamos utilizando a classe .apresentacao__links__link {}, portanto vamos copiá-la e colá-la abaixo de suas chaves, inserindo :hover à direita.

```CSS
.apresentacao__links__link {
//código omitido
}

.apresentacao__links__link:hover {

}
```

Guilherme: Quando estamos inserindo o hover, o VS Code mostra que existem várias outras opções de configuração possíveis.

Rafaella: Sim, existem outras configurações para utilizarmos no CSS.

Tudo o que adicionarmos dentro das chaves de .apresentacao__links__link:hover {} será estilizado no momento em que o mouse passar por cima dos links. Podemos mudar diversos aspectos: o tamanho da fonte, o seu tipo, a borda, etc. Neste caso, modificaremos apenas o fundo — adicionaremos um background-color que receberá uma hashtag (#) junto à cor que encontramos no Figma: 272727.

```CSS
.apresentacao__links__link {
//código omitido
}

.apresentacao__links__link:hover {
    background-color: #272727;
}
```

Salvaremos o nosso código e retornaremos à nossa página aberta pelo navegador. Se passarmos o mouse por cima de um dos botões, a sua cor será alterada para o tom que configuramos — um preto mais claro do que a cor de fundo da tela principal.

Guilherme: Isso é interessante pois conseguimos perceber visualmente a presença do mouse no botão.

Rafaella: Exato. Se adicionássemos uma cor para a fonte, ela seria alterada junto à cor de fundo. Neste caso faremos somente a alteração de cor do botão, pois já conseguimos um ótimo efeito.

### Aula 2 - Desafio: personalizando com o Hover

Agora que você já conhece o seletor hover temos um desafio para você!

Escolha algum elemento em seu portfólio, pode ser seu nome, o texto sobre você, o link de suas redes sociais ou algum item novo que você queira adicionar.

Nesse elemento, você deve fazer alguma personalização através do uso do hover. Aqui vale explorar cores, tamanhos, imagens e perceber como cada elemento age com o hover.

Lembre-se que para usar o hover, basta chamar em seu CSS o seletor da tag que deseja personalizar, seja seu nome ou classe, seguido por :hover. Por exemplo, se quisesse personalizar uma div, chamaria:

```CSS
div:hover{
    /* insira aqui sua personalização */
}
```

A ideia aqui é deixar o projeto com a sua cara, então capriche na customização =)

Opinião do instrutor

O seletor hover pode ser uma ferramenta muito divertida do CSS, já que conseguimos simular algumas animações com seu comportamento. Adicionando um padding: 3% no hover da classe apresentacao__links__link, por exemplo, conseguimos um efeito semelhante a uma animação nos botões, como podemos ver no gif abaixo:

gif da tela do projeto de portfólio do curso, com fundo escuro, uma imagem no lado direito e do lado esquerdo, na parte superior, há um título com um parágrafo de texto logo abaixo, ambos com a cor branca. Ainda do lado esquerdo, abaixo do parágrafo de texto, estão em foco os três botões com link para o Github, Linkedin e Twitch em cada um deles, respectivamente e ao passarmos o mouse sobre eles, a cor de fundo muda de preto para cinza e há aumento em seu tamanho, devido ao uso da propriedade hover.

O hover permite personalizar nossa aplicação de muitas formas e ao usarmos a criatividade, podemos criar efeitos encantadores com essa ferramenta.

### Aula 2 - Para saber mais: Hover

O hover é usado para selecionar elementos quando você passa o mouse sobre eles. Essa e outras informações úteis sobre o hover você pode encontrar na [documentação](https://www.w3schools.com/CSSref/sel_hover.php) =)

### Aula 2 - Lista de exercícios

1) Organizando ícones nas redes sociais

Imagine que você está trabalhando em um projeto pessoal onde deseja incluir links para suas redes sociais com ícones correspondentes. Você já tem um link para o GitHub com um ícone, mas precisa adicionar outros dois: LinkedIn e Twitch. Utilize o seguinte trecho de código HTML como ponto de partida:

```html
<main class="apresentacao">
    <section class="apresentacao__conteudo">
        <div class="apresentacao__links">
            <h2 class="apresentacao__links__subtitulo">Acesse minhas redes:</h2>
            <a class="apresentacao__links__link" href="https://github.com/seunome">
                <img src="./assets/github.png">
                Github
            </a>
            <!-- Adicione os links do LinkedIn e Twitch aqui -->
        </div>
    </section>
    <img src="./assets/imagem.png" alt="Foto da Joana Santos programando">
</main>
<footer></footer>
</body>
</html>
```

2) Centralizando ícones e textos nos botões  
Imagine que você está trabalhando em um projeto de site onde precisa alinhar ícones de redes sociais com seus respectivos textos dentro de botões. O desafio é utilizar Flexbox para centralizar tanto o ícone quanto o texto dentro dos botões. Comece acessando o arquivo style.css e encontre a classe .apresentacao__links__link. Sua tarefa é adicionar as propriedades display: flex, justify-content: center e gap: 16px nesta classe, respeitando a ordem e posição corretas entre as outras propriedades existentes.

3) Espaçamento entre ícones e textos  
Neste desafio, você precisa ajustar o espaçamento entre os ícones e os textos dentro dos botões de redes sociais no mesmo projeto do site. Primeiro, consulte o Figma do projeto para identificar o valor exato do espaçamento em pixels entre o ícone e o texto. Depois, volte ao arquivo style.css e adicione a propriedade gap com o valor encontrado no Figma à classe .apresentacao__links__link. Certifique-se de que o gap esteja posicionado corretamente dentro da declaração da classe.

4) Personalizando o efeito Hover  
Você está desenvolvendo uma página de portfólio e quer criar um efeito visual atraente. O objetivo é fazer com que, ao passar o mouse sobre os botões, eles se destaquem com uma borda azul. Para isso, utilize a classe .apresentacao__links__link já existente no seu código CSS. Seu desafio é adicionar o efeito Hover a essa classe, fazendo com que a borda do botão mude para a cor azul (#0000FF) quando o cursor passar sobre ele.

5) Alterando o cursor e o fundo dos botões  
Na sua página de portfólio, você observou que, ao passar o mouse sobre um botão, o cursor se transforma em uma mão com o indicador levantado. Além disso, você deseja que o fundo do botão mude para um tom de preto levemente mais claro (#272727) ao passar o mouse. Seu desafio é editar a classe .apresentacao__links__link:hover no seu arquivo CSS para alterar o cursor para o estilo 'pointer' e mudar a cor de fundo do botão ao passar o mouse sobre ele.

Opinião do instrutor

1) Organizando ícones nas redes sociais  
1.1 Copie a estrutura da tag `<a>` do GitHub.  
1.2 Cole-a duas vezes para criar espaços para LinkedIn e Twitch.  
1.3 Altere o atributo href para refletir os endereços corretos de suas contas no LinkedIn e Twitch.  
1.4 Modifique o atributo src da tag `<img>` para apontar para os ícones corretos do LinkedIn e Twitch, armazenados na pasta assets.  
1.5 Atualize o texto dentro da tag `<a>` para corresponder a cada rede social.  
O código finalizado para adicionar os links do LinkedIn e Twitch deve ser semelhante a este:  

```html
<main class="apresentacao">
    <section class="apresentacao__conteudo">
        <div class="apresentacao__links">
            <h2 class="apresentacao__links__subtitulo">Acesse minhas redes:</h2>
            <a class="apresentacao__links__link" href="https://github.com/seunome">
                <img src="./assets/github.png">
                Github
            </a>
            <a class="apresentacao__links__link" href="https://linkedin.com/in/seunome">
                <img src="./assets/linkedin.png">
                LinkedIn
            </a>
            <a class="apresentacao__links__link" href="https://twitch.tv/seunome">
                <img src="./assets/twitch.png">
                Twitch
            </a>
        </div>
    </section>
    <img src="./assets/imagem.png" alt="Foto da Joana Santos programando">
</main>
<footer></footer>
</body>
</html>
```

2) Centralizando ícones e textos nos botões

- Acesse o arquivo style.css.
- Localize a classe .apresentacao__links__link.
- Adicione a propriedade display: flex entre background-color e border.
- Em seguida, adicione justify-content: center entre display: flex e border.

O código deve ficar assim:

```CSS
.apresentacao__links__link {
    /* background-color: #22D4FD; */
    display: flex;
    justify-content: center;
    border: 2px solid #22D4FD;
    ... /* outras propriedades */
}
```

3) Espaçamento entre ícones e textos

- Consulte o Figma do projeto para verificar o valor de espaçamento (em px) entre o ícone e o texto.
- Volte ao arquivo style.css.
- Localize a mesma classe .apresentacao__links__link.
- Adicione a propriedade gap com o valor identificado no Figma, posicionando-a após justify-content.

O código deve ficar assim:

```CSS
.apresentacao__links__link {
    /* background-color: #22D4FD; */
    display: flex;
    justify-content: center;
    gap: 16px; /* valor do espaçamento identificado no Figma */
    ... /* outras propriedades */
}
```

4) Personalizando o efeito Hover

- Comece encontrando a classe .apresentacao__links__link no seu arquivo CSS.
- Abaixo desta classe, crie uma nova regra para o estado Hover: .apresentacao__links__link:hover.
- Dentro das chaves desta nova regra, adicione a propriedade border e defina-a para 2px solid #0000FF. Isso adicionará uma borda azul ao redor do botão quando o mouse estiver sobre ele.
Código:

```CSS
  .apresentacao__links__link:hover {
      border: 2px solid #0000FF;
  }
```

5) Alterando o cursor e o fundo dos botões

- Acesse novamente a classe .apresentacao__links__link:hover no seu arquivo CSS.
- Adicione a propriedade cursor: pointer; para mudar o estilo do cursor para uma mão com o indicador levantado.
- Adicione a propriedade background-color: #272727; para alterar a cor de fundo do botão para um tom de preto mais claro ao passar o mouse sobre ele.
Código:

```CSS
  .apresentacao__links__link:hover {
      cursor: pointer;
      background-color: #272727;
  }
```

### Aula 2 - O que aprendemos?

Nessa aula, você aprendeu como:

- Adicionar ícones aos links clicáveis;
- Alinhar elementos com justify-content;
- Estilizar elementos ao passar o mouse sobre eles com o seletor hover.

## Aula 3 - Criando o Header e o Footer

### Aula 3 - Projeto da aula anterior

Aqui você pode [baixar os arquivos da aula 02](https://github.com/alura-cursos/Portifolio-HTML-e-CSS-Curso3/archive/refs/heads/aula_2.zip) ou acessar os [arquivos no Github!](https://github.com/alura-cursos/Portifolio-HTML-e-CSS-Curso3/tree/aula_2)

### Aula 3 - Desenvolvendo o footer - Vídeo 1

Transcrição  
Guilherme: Nosso próximo desafio sera o menu de "Home" e "Sobre mim", ou o footer. O que você sugere, Rafa?

Rafaella: Como ainda não criamos a outra página, poderemos finalizar o rodapé da página inicial para depois trabalharmos no menu.

Guilherme: Vamos copiar o texto de "Desenvolvido por Alura" na base da tela do Figma, porque é o único conteúdo que possui.

Rafaella: Sim, depois abriremos o arquivo index.html no VSCode e iremos até o `<footer>` que tínhamos definido no momento em que separamos a página em `<header>`, `<main>` e a tag do rodapé.

Dentro dela, abriremos uma nova linha e adicionaremos um parágrafo com `<p>` que receberá o texto copiado do Figma.

Guilherme: Lembrando que "Desenvolvido por Alura" pode ser substituído por qualquer outro escrito que quisermos.

Rafaella: No `<footer>`, adicionaremos uma classe chamada "rodape" para podermos estilizar o rodapé.

```html
<!DOCTYPE html>
<html lang="pt-br">
//código omitido
<body>

//código omitido
    <footer class="rodape">
        <p>Desenvolvido por Alura.</p>
    </footer>
</body>
</html>
```

Rafaella: Em seguida, acessaremos o arquivo style.css e, na última linha, criaremos o seletor .rodape e abriremos chaves.

Guilherme: Salvando e voltando ao navegador, notaremos o texto "Desenvolvido por Alura" escrito bem pequeno na parte esquerda da base da tela.

Mesmo que não tenhamos colocado uma propriedade color: diretamente em .rodape, os caracteres aparecem na cor branca porque definimos como #F6F6F6 em body.

Rafaella: Esse texto "herda" dos elementos-pais que estão acima, e por isso fica em branco mesmo automaticamente.

Guilherme: Então vamos alterar a cor do texto do .rodape colocando color: com o valor #000000 para ficar na cor preta.

Já a propriedade da cor de fundo background-color terá o valor hexadecimal #22D4FD para ficar com a cor azul claro.

Conforme utilizamos a mesma paleta com os mesmos valores nas propriedades, o VSCode memoriza automaticamente o que escrevemos.

```CSS
//código omitido

.rodape {
    color: #000000;
    background-color: #22D4FD;
}
```

Guilherme: Vamos observar o resultado no navegador.

Rafaella: Já está aparecendo com a cor de texto e de fundo que definimos, mas a faixa ainda está muito estreita porque tem a altura do conteúdo, então não há uma margem e uma borda com padding: no rodapé.

Guilherme: Vamos relembrar o que é essa propriedade?

Rafaella: Abrindo a janela lateral de "Inspecionar" em nossa página no navegador, teremos uma parte inferior com a aba "Estilos" contendo a representação dos elementos da tela.

Parte da página do projeto no navegador em que está visível apenas a fotografia em preto e branco representando Joana Santos, uma mulher desenvolvedora, sentada em frente a um notebook aberto. A imagem também conta com um desenho em ciano de uma linha circulando Joana e seu notebook três vezes e terminando em uma estrela. Ao lado direito da tela, está aberta a aba de "Inspecionar" em que apenas a metade inferior está visível, e contém a aba "Estilos" aberta. Abaixo, há uma área contendo quatro retângulos com linhas pontilhadas com valores de distâncias entre si que representam os posicionamentos dos elementos: O maior e mais externo é "margin" em vermelho, dentro há o "border" em laranja", dentro deste está "padding" em verde e por fim há um retângulo azul menor ao centro.

Guilherme: Temos a margem ou "margin" que é onde o conteúdo está, dentro dela temos a borda ou "border" onde inserimos o border-radius, e dentro dele há o "padding" que representa a distância do conteúdo para a borda de sua área.

Rafaella: Neste caso do rodapé, só teremos o conteúdo textual mesmo.

Não colocaremos uma margem para aumentarmos a altura da faixa azul porque significaria da borda dela para os demais elementos externos. No arquivo style.css, criaremos uma propriedade margin: de 28px apenas para entendermos como funciona.

```CSS
//código omitido
.rodape {
    margin: 28px;
    color: #000000;
    background-color: #22D4FD;
}
```

Rafaella: Quando fazemos isso, salvamos e voltamos ao navegador, notaremos que há um espaçamento entre a borda da tela inteira e o início da faixa azul do rodapé, criando pequenos espaços em preto nas laterais dela.

Como queremos trabalhar na distância entre o conteúdo e a borda dessa própria faixa, substituiremos o margin: por padding:.

De volta ao Figma, apertaremos a tecla "Alt" e passaremos o cursor sobre o rodapé para obtermos o valor dessa propriedade.

Depois adicionaremos 24px à propriedade do .rodape.

```CSS
//código omitido
.rodape {
    padding: 24px;
    color: #000000;
    background-color: #22D4FD;
}
```

Rafaella: Salvando e analisando o resultado no navegador, notaremos uma distância maior entre os limites da faixa azul do rodapé e o conteúdo textual interno.

Guilherme: O texto ainda está alinhado à esquerda, e iremos centralizá-lo de acordo com o projeto do Figma usando a propriedade text-align:.

Rafaella: Exatamente. A colocaremos com o valor center e salvaremos o arquivo.

```CSS
//código omitido
.rodape {
    padding: 24px;
    color: #000000;
    background-color: #22D4FD;
    text-align: center;
}
```

Rafaella: No navegador, já teremos o escrito centralizado.

Guilherme: Ainda precisamos definir a fonte correta e o tamanho do texto.

Rafaella: A família da fonte 'Montserrat' será definida na propriedade font-family: que já conhecemos, que também é sem serifa ou sans-serif.

Em seguida, o tamanho de font-size: será de 24px. Vamos salvar e analisar a página no navegador.

```CSS
//código omitido
.rodape {
    padding: 24px;
    color: #000000;
    background-color: #22D4FD;
    text-align: center;
    font-family: 'Montserrat', sans-serif;
    font-size: 24px;
}
```

Rafaella: Agora já estará bem parecido com o projeto no Figma.

Guilherme: Ainda falta vermos se o peso da fonte está certo também.

Rafaella: Vamos abrir o Figma e acessar a aba "Inspect" da janela lateral direita de propriedades, onde descobriremos que é 400.

De volta ao código, adicionaremos font-weight: com este valor, salvaremos e observaremos o resultado no navegador.

```CSS
//código omitido
.rodape {
    padding: 24px;
    color: #000000;
    background-color: #22D4FD;
    text-align: center;
    font-family: 'Montserrat', sans-serif;
    font-size: 24px;
    font-weight: 400;
}
```

Rafaella: Agora já está certo.

Guilherme: Como comentamos no início do nosso curso, queremos que todo o conteúdo em body esteja visível no tamanho da página usando a propriedade height: 100vh que determina a altura.

Rafaella: Ou seja, este valor é de 100% do viewport height ou da "altura da tela".

Guilherme: Agora não há mais necessidade de termos isso.

Rafaella: Sim, afinal já temos um rodapé e mais elementos na página, e antes os elementos não alcançavam a base da tela, justificando o uso de toda altura disponível que não é mais necessário.

Inclusive, abrindo o Inspecionador de Elementos e selecionando a área do body, veremos que a seleção não atinge a base onde está o rodapé.

Portanto é interessante retiramos a height: 100vh para ajustarmos um novo valor e o footer ficar dentro do body.

No style.css, comentaremos a linha desta propriedade da altura usando o atalho "Ctrl + K + C" e salvaremos.

```CSS
//código omitido
body {
    /* height: 100vh; */
    box-sizing: border-box;
    background-color: #000000;
    color: #F6F6F6;
}
//código omitido
```

Com a aba de Inspecionar Elementos aberta no navegador, notaremos que a seleção do body estará englobando toda a página, inclusive os novos elementos adicionados que estavam maiores do que a área visível da tela.

Guilherme: Outro problema que temos agora é que os espaçamentos entre todos os elementos estão maiores do que deveriam. Quando navegamos e scrollamos, notaremos um espaço desnecessariamente grande no topo.

Rafaella: Já tínhamos definido essas margens como 10% e 15%, então poderemos usar um padding: ao invés de margin:, o qual definirá a distância da borda da tela até o conteúdo interno.

Em .apresentacao no style.css, substituiremos a propriedade de margem pelo padding:.

Guilherme: Vamos testar um valor de porcentagem como de 5%, por exemplo.

```CSS
//código omitido
.apresentacao {
    padding: 5% 15%;
    display: flex;
    align-items: center;
    justify-content: space-between;
}
//código omitido
```

Rafaella: Salvando e observando a página no navegador, notaremos que os elementos até cabem na tela, mas o ideal é mantermos um espaço para inserirmos o cabeçalho. Então vamos testar o valor de 8%.

Guilherme: E já ficou bem melhor.

A seguir, nosso próximo passo será trabalharmos com o header.

### Aula 3 - Desenvolvendo o cabeçalho - Vídeo 2

Transcrição  
Guilherme: Agora que terminamos nosso rodapé, nosso próximo desafio será o cabeçalho.

Rafaella: No Figma, temos dois links no topo da tela principal para "Home" e "Sobre mim".

Em nosso projeto no index.html, já temos a tag `<header>` preparada dentro de `<body>` para conseguirmos desenvolver o cabeçalho.

Guilherme: O `<header>` geralmente é composto por um menu de navegação na grande maioria das páginas web, contendo diversos links que nos direcionam para outras telas.

Para isso, também existe uma tag semântica.

Rafaella: Ela é chamada `<nav>` e receberá os links para navegarmos na página, que podem ser de um blog com uma hierarquia de links por assuntos, como uma opção "Programação" que envolveria "Front-end", seguido de "HTML" por exemplo. Essa forma também é uma navegação com a tag `<nav>`.

Nosso caso possui apenas dois: o da página inicial e "Sobre mim" com outras informações.

Dentro de `<nav>`, adicionaremos a tag âncora que já conhecemos, a qual receberá o texto Home. Já na segunda `<a>`, teremos Sobre mim.

Também criaremos as classes do cabeçalho para podermos estilizar. Então, ao lado de `<header e antes de >` na mesma linha, escreveremos class igual a "cabecalho". Já em `<nav, a classe será "cabecalho__menu", e as duas tags <a, será "cabecalho__menu__link">`.

Guilherme: Vamos salvar e ver o resultado no navegador.

```html
<!DOCTYPE html>
<html lang="pt-br">

//código omitido

<body>
    <header class="cabecalho">
        <nav class="cabecalho__menu">
            <a class="cabecalho__menu__link">Home</a>
            <a class="cabecalho__menu__link">Sobre mim</a>
        </nav>
    </header>

//código omitido

</body>
</html>
```

Rafaella: Parece que não há nada.

Guilherme: Sim, mas na verdade está bem pequeno no canto superior, então precisaremos estilizar no arquivo style.css para ficar igual ao projeto no Figma.

### Aula 3 - Trabalhando com tags semânticas

Trabalhamos com as tags semânticas `<header>` e `<footer>` na organização de nosso projeto.

Sobre essas tags, selecione as alternativas corretas:

Alternativa correta  
A tag `<header>` representa o cabeçalho da página, que tem como principal função otimizar a navegação da pessoa usuária e irá conter elementos que favoreçam esse processo.

> A tag `<header>` auxilia com que a pessoa usuária se localize na página e aceita elementos como barra de navegação, logo da página, informações de autoria e até mesmo formulários de pesquisa, embora não seja comum usá-los no `<header>`.

Alternativa correta  
A tag `<footer>` representa o rodapé e é comum que contenha informações sobre o autor da página, direitos autorais, endereços ou links para outras páginas relacionadas.

> A tag `<footer>` será uma área informativa sobre a página e segue o mesmo princípio de `<header>`, pois não deve ser criada dentro de outra tag `<footer>` ou dentro de tag `<header>`.

Alternativa correta  
A tag header pode receber títulos de `<h1>` até `<h6>`, entre outros elementos comuns ao corpo do HTML, como a tag <p>.

> A tag `<header>` permite o uso das tags comuns ao corpo do HTML, mas precisamos nos atentar que não é recomendável colocar tag `<header>` dentro de outra tag `<header>` ou dentro de `<footer>`.

### Aula 3 - Para saber mais: Padding

Observe a imagem a seguir:

Imagem com foco nos botões do projeto para acessar as redes sociais. O fundo em cor preta. Na parte superior há o texto “Acesse minhas redes” centralizado, escrito em cor branca. Abaixo há três botões, cada um com uma borda retangular em azul claro delimitando seus espaços, que são iguais. Esses botões estão posicionados um abaixo do outro no sentido vertical. O primeiro tem dentro de sua borda o logo do Github em azul claro, seguido do texto “Github” em branco. O segundo tem dentro de sua borda o logo do Linkedin em azul claro, seguido do texto “linkedin” em branco. O terceiro tem dentro de sua borda o logo da Twitch em azul claro, seguido do texto “Twitch” em branco. Não há espaço entre as bordas dos botões e seu conteúdo, que no caso é composto pelo texto e o ícone.

A tela acima apresenta os botões que criamos em nosso projeto para acessar as redes sociais. No entanto, podemos perceber que o ícone e o texto dentro de cada botão ficou “espremido” pelas bordas, o que desfavorece o visual do projeto.

Todos os botões têm conteúdos: um ícone e o texto com o nome da rede social. Além disso, todos os botões possuem uma borda fina em azul. Portanto, precisamos adicionar alguma propriedade que faça com que haja um espaço entre o conteúdo e as bordas do botão, para obtermos o seguinte resultado:

Imagem com foco nos botões do projeto para acessar as redes sociais. O fundo em cor preta. Na parte superior há o texto “Acesse minhas redes” centralizado, escrito em cor branca. Abaixo há três botões, cada um com uma borda retangular em azul claro delimitando seus espaços, que são iguais. Esses botões estão posicionados um abaixo do outro no sentido vertical. O primeiro tem dentro de sua borda o logo do Github em azul claro, seguido do texto “Github” em branco. O segundo tem dentro de sua borda o logo do Linkedin em azul claro, seguido do texto “linkedin” em branco. O terceiro tem dentro de sua borda o logo da Twitch em azul claro, seguido do texto “Twitch” em branco. Há espaço entre as bordas dos botões e seu conteúdo, que no caso é composto pelo texto e o ícone.

Bem melhor, não é? Mas você sabe qual propriedade nos ajudou a definir a distância entre o conteúdo e a borda?

Se você pensou no padding, acertou!

O Padding é responsável por definir a distância entre um conteúdo e suas bordas. No caso do nosso projeto, adicionamos um padding: 21.5px 0, que já foi suficiente para criar um espaço interno mais amplo nos botões. Essa propriedade é extremamente útil pois garante que exista esse espaço de “respiro” entre as bordas e o conteúdo, deixando o visual mais limpo e harmônico.

Para entender melhor ainda como o padding funciona, você pode consultar a [documentação](https://www.w3schools.com/csS/css_padding.asp).

### Aula 3 - Lista de exercícios

1) Personalizando o rodapé do seu site  
Imagine que você está desenvolvendo um site e chegou a hora de personalizar o rodapé. O desafio é criar um rodapé estilizado com as seguintes características: deve ter um fundo azul claro (#22D4FD), texto em preto (#000000), e o texto deve ser centralizado e usar a fonte 'Montserrat', tamanho 24px e peso 400. Além disso, o rodapé deve ter um padding de 24px. Use o HTML e CSS fornecidos como base e aplique as modificações necessárias.

2) Ajustando o espaçamento interno da apresentação  
Você ficou responsável por ajustar o layout de uma seção de apresentação em um site. Atualmente, os elementos estão muito próximos das bordas, o que prejudica a estética do site. Sua tarefa é substituir a propriedade margin por padding na classe .apresentacao do CSS, testando valores de porcentagem para encontrar o espaçamento ideal. Comece com 5% e ajuste conforme necessário para obter um visual equilibrado.

3) Removendo o height para adaptar o layout  
Seu site está enfrentando um problema de layout: a propriedade height: 100vh no body está impedindo que o conteúdo se ajuste corretamente na tela, especialmente com a adição de novos elementos como um rodapé. Sua missão é comentar a linha que define height: 100vh no CSS e verificar o impacto dessa mudança no layout do site. Observe como o conteúdo e o rodapé se adaptam à nova configuração.

4) Estilizando o cabeçalho com CSS  
Você está criando um site e chegou a hora de estilizar o cabeçalho para que ele fique visível e atraente, similar ao projeto no Figma. Você precisa adicionar estilo ao cabeçalho no arquivo style.css, de forma que os links "Home" e "Sobre mim" fiquem alinhados horizontalmente e com uma aparência moderna. Considere usar propriedades como font-size, color, margin, padding, e display. Tente também adicionar um hover para alterar a cor dos links quando o mouse passar por cima.

5) Ajustando o espaçamento interno dos links  
Com base no estilo atual do cabeçalho, percebe-se que os links podem estar muito próximos um do outro ou da borda do cabeçalho, o que pode afetar a legibilidade e a estética do site. Sua tarefa é ajustar o espaçamento interno (padding) dos links "Home" e "Sobre mim" para garantir que eles tenham um espaçamento adequado em torno do texto. Isso tornará o cabeçalho mais atraente e fácil de usar.

Opinião do instrutor

1) Personalizando o rodapé do seu site

- Abra o arquivo style.css e localize a classe .rodape.
- Atualize a propriedade background-color para #22D4FD.
- Defina a propriedade color para #000000.
- Centralize o texto adicionando text-align: center.
- Aplique a fonte 'Montserrat', com tamanho 24px e peso 400 usando font-family: 'Montserrat', sans-serif; e font-size: 24px; e font-weight: 400.
- Adicione padding: 24px para criar um espaçamento interno.

```CSS
.rodape {
    padding: 24px;
    color: #000000;
    background-color: #22D4FD;
    text-align: center;
    font-family: 'Montserrat', sans-serif;
    font-size: 24px;
    font-weight: 400;
}
```

2) Ajustando o espaçamento interno da apresentação

- Abra o arquivo style.css e localize a classe .apresentacao.
- Substitua a propriedade margin por padding.
- Inicialmente, defina padding: 5% 15%.
- Ajuste o valor do padding para encontrar o equilíbrio visual ideal, por exemplo, 8%.

```CSS
.apresentacao {
    padding: 8% 15%;
    display: flex;
    align-items: center;
    justify-content: space-between;
}
```

3) Removendo o height para adaptar o layout

- Abra o arquivo style.css e localize a seção do body.
- Comente a linha que contém height: 100vh usando /* height: 100vh; */.
- Salve o arquivo e observe como o layout do site se adapta, especialmente a área do rodapé.

```CSS
body {
    /* height: 100vh; */
    box-sizing: border-box;
    background-color: #000000;
    color: #F6F6F6;
}
```

4) Estilizando o cabeçalho com CSS

- Adicione as seguintes propriedades CSS à classe cabecalho__menu__link para estilizar os links:

```CSS
  .cabecalho__menu__link {
      font-size: 18px;
      color: #333;
      margin: 0 10px;
      padding: 5px 10px;
      text-decoration: none;
  }

  .cabecalho__menu__link:hover {
      color: #007bff;
  }
```

- Ajuste as propriedades display, justify-content e align-items na classe cabecalho__menu para alinhar os links horizontalmente:

```CSS
  .cabecalho__menu {
      display: flex;
      justify-content: center;
      align-items: center;
  }

```

5) Ajustando o espaçamento interno dos links

- Para melhorar o espaçamento interno dos links no cabeçalho, ajuste a propriedade padding na classe cabecalho__menu__link. Isso aumentará o espaço ao redor do texto dentro dos links, tornando-os mais legíveis e esteticamente agradáveis. Aqui está o código:

```CSS
  .cabecalho__menu__link {
      padding: 10px 15px;
  }
```

Essa alteração garantirá que os links tenham um espaçamento interno maior, tornando o cabeçalho mais confortável para navegação.

### Aula 3 - O que aprendemos?

Nessa aula, você aprendeu como:

- Criar e fazer a estilização do footer da página;
- Criar o header da página;
- Aplicar os links de navegação através da tag `<nav>`.

## Aula 4 - Navegando entre Páginas

### Aula 4 - Projeto da aula anterior

Aqui você pode [baixar os arquivos da aula 03](https://github.com/alura-cursos/Portifolio-HTML-e-CSS-Curso3/archive/refs/heads/aula_3.zip) ou acessar os [arquivos no Github!](https://github.com/alura-cursos/Portifolio-HTML-e-CSS-Curso3/tree/aula_3)

### Aula 4 - Estilizando o cabeçalho - Vídeo 1

Transcrição  
Rafaella: Já criamos nosso cabeçalho com HTML, mas ainda precisamos estilizá-lo.

Abrindo o arquivo style.css no VSCode, inseriremos as classes que já criamos no index.html, mas sempre deveremos colocar no momento em que as tags vão aparecendo.

Vamos deslocar o .titulo-destaque para depois de .apresentacao__conteudo__titulo porque possui a tag <strong> que é utilizada logo depois do <h1>.

Começaremos a estilização do escrito para depois posicionarmos os elementos, então a classe "cabecalho__menu__link" na âncora <a> de index.html será copiada e colada após o body em style.css.

Abriremos as chaves de .cabecalho__menu__link e dentro colocaremos as propriedades de cor, fonte e tamanho obtidas do projeto do Figma.

Guilherme: Primeiro, a font-family: é 'Montserrat', sans-serif, depois o font-size: terá o valor de 24px e, por fim, seu peso font-weight: será de 600.

Rafaella: Também precisaremos trocar a cor do texto de cabeçalho para azul claro, e já temos este valor também. Então color: será #22D4FD. Salvaremos e analisaremos o resultado no navegador.

```CSS
//código omitido
body {
    /*height: 100vh */
    box-sizing: border-box;
    background-color: #000000;
    color: #F6F6F6;
}

.cabecalho__menu__link {
    font-family: 'Montserrat', sans-serif;
    font-size: 24px;
    font-weight: 600;
    color: #22D4FD;
}

//código omitido
```

Rafaella: Com isso, teremos nossos elementos estilizados.

Guilherme: Agora precisaremos trabalhar no posicionamento deles.

Rafaella: Exatamente, e poderemos usar o cabeçalho para estabelecer a posição de cima para baixo com espaçamento lateral usando padding:.

Pegaremos a classe "cabecalho" do `<header>` em index.html que agrupará toda a barra de navegação que contém as duas tags âncoras para podermos estilizá-las.

Copiaremos o nome dessa class e a adicionaremos acima de .cabecalho__menu__link, pois aparece antes.

Dentro das chaves, colocaremos o padding: para espaçarmos as duas âncoras, e queremos apenas na parte superior e de um lado só. Já aprendemos uma forma de escrevermos dois valores para trabalharmos no sentido vertical e horizontal.

Porém, agora precisaremos espaçar apenas dois lados, e não no sentido vertical e horizontal, e para isso poderemos inserir quatro valores para o padding:, o qual possui uma ordem específica.

Analisando a documentação do padding: aqui, encontraremos a parte "Se a propriedade padding tiver quatro valores:", que é justamente o que queremos.

O primeiro diz respeito à parte superior do conteúdo.

Guilherme: Então, no padding: de .cabecalho, colocaremos o valor 2% em porcentagem que é melhor, pois se fixarmos em pixels, pode ser que sofra distorções na tela dependendo do dispositivo que acessará a aplicação.

```CSS
//código omitido
body {
    /*height: 100vh */
    box-sizing: border-box;
    background-color: #000000;
    color: #F6F6F6;
}

.cabecalho {
    padding: 2%;
}
//código omitido
```

Rafaella: Feito isso, notaremos que a porcentagem foi aplicada a todos os quatro lados do conteúdo, pois só colocamos um valor apenas.

De volta à documentação, o espaçamento do lado direito será o segundo valor, que neste caso será 0%. Já o terceiro valor diz respeito ao espaçamento inferior que também será 0%. Por fim, o quarto valor do preenchimento do lado esquerdo terá 10%.

Salvaremos e veremos o resultado no navegador.

```CSS
//código omitido
.cabecalho {
    padding: 2% 0% 0% 10%;
}
//código omitido
```

Rafaella: Com isso, repararemos que o espaçamento já está bem diferente de antes.

Guilherme: Mas ainda não está na mesma linha.

Rafaella: Isso aconteceu porque colocamos um padding: horizontal de 15% como segundo valor no main de .apresentacao do style.css.

Então, para ficar mais parecido com o Figma, colocaremos o valor de 15% ao invés de 10% no padding: do .cabecalho.

```CSS
//código omitido
.cabecalho {
    padding: 2% 0% 0% 15%;
}

//código omitido
```

Rafaella: Feito isso, o texto já ficará alinhado. Agora, precisaremos afastar um pouco os conteúdos das duas tags âncoras.

No arquivo index.html, iremos para a `<nav>` e usaremos o FlexBox, lembrando que sempre jogaremos o display: flex no elemento container, no elemento-pai.

Copiaremos a classe "cabecalho__menu" e colaremos após o .cabecalho em style.css. Dentro, criaremos a propriedade display: flex para inicializarmos o FlexBox.

Guilherme: Vamos ver qual é essa distância de gap: no Figma.

Rafaella: Descobriremos que é de 80px.

```CSS
//código omitido
.cabecalho {
    padding: 2% 0% 0% 15%;
}
.cabecalho__menu {
    display: flex;
    gap: 80px;
}
//código omitido
```

Rafaella: Feito isso, teremos o espaçamento entre os textos "Home" e "Sobre mim" que queríamos.

Então terminamos nosso cabeçalho, porém ainda não está funcional, ou seja, quando clicamos em algum dos dois links, não nos direcionamos para as respectivas páginas.

Guilherme: Ainda tem um detalhe, pois seria interessante subir o bloco de texto que inicia com "Eleve seu negócio digital...".

Rafaella: Podemos subir para que fique mais próximo do cabeçalho.

De volta ao padding: de .apresentacao em style.css, substituiremos o valor 8% por 5%.

```CSS
//código omitido
.cabecalho__menu__link {
    font-family: 'Montserrat', sans-serif;
    font-size: 24px;
    font-weight: 600;
    color: #22D4FD;
}
.apresentacao {
    padding: 5% 15%;
    display: flex;
    align-items: center;
    justify-content: space-between;
}
//código omitido
```

Rafaella: Assim ficou bem melhor e mais parecido com o projeto final no Figma.

Guilherme: Então já temos a página inteira feita.

Rafaella: Exato, mas ainda não está funcional, porque ao clicarmos ainda não vamos para outra página.

Guilherme: O desafio será tornar esse menu funcional para nos direcionarmos à página de "Sobre mim" para depois a desenvolvermos.

### Aula 4 - Navegando entre páginas - Vídeo 2

Transcrição  
Rafaella: Criaremos uma nova página para deixarmos o menu do cabeçalho funcional, em que poderemos clicar para nos redirecionarmos para outras páginas.

Guilherme: Abriremos o VSCode e veremos que, na aba lateral esquerda de "Explorer", teremos a arquitetura das pastas do portfólio em que "assets" contém todas as imagens. Ainda teremos os dois arquivos: index.html e styles.css.

Como criaremos uma nova página, da forma como nosso código está organizado, pode ser que sua manutenção e edição fiquem mais complicadas conforme cresce o número de telas do projeto.

Clicando com o botão direito do mouse sobre a aba "Explorer", escolheremos "New Folder..." ou "Nova pasta..." e nomearemos como "styles" porque é o padrão.

Em seguida, deslocaremos o arquivo styles.css para dentro da nova pasta. A partir de agora, qualquer documento .css que criarmos deverá ficar nela.

Depois, abriremos a página no navegador e não teremos mais a estilização dos elementos que aplicamos.

Isso aconteceu porque alteramos o lugar do documento de estilos, fazendo com que o index.html não o encontrasse mais através do href igual a "styles.css".

Rafaella: Então precisaremos alterar o endereço que estamos usando, e bastará substituirmos por "./styles/styles.css" para indicarmos o caminho de dentro da pasta "styles".

Desta forma, a estilização voltará a ser aplicada na página no navegador.

Guilherme: Todos os arquivos relacionados aos estilos dos elementos serão criados na pasta "styles", todas as imagens estarão em "assets" e todos os arquivos .html ficarão fora na raiz da aplicação.

Clicando com o botão direito na área da aba lateral de pastas, e escolheremos "New File..." ou "Novo Arquivo...".

Geralmente, a página de "Sobre mim" é nomeada como about.html, que é "sobre" em inglês.

Neste novo arquivo, usaremos o atalho "ponto de exclamação + Enter" para escrevermos a estrutura básica do HTML automaticamente, que é bastante comum, mas precisaremos alterar alguns detalhes.

Rafaella: Também apertaremos as teclas "Alt + Z" para quebrarmos a linha e conseguirmos exibir todo o texto sem cortes da tela.

Guilherme: Na segunda linha, mudaremos o idioma oficial de inglês para protuguês brasileiro substituindo lang igual a "en" por "pt-br", e o título da nossa aba será “Sobre mim” dentro da tag `<title>` do `<head>`. Também adicionaremos um `<h1>` dentro de `<body>` contendo o texto “Sobre mim”.

Por enquanto não trabalharemos muito nos elementos desta tela, pois queremos apenas conseguir clicar no link "Sobre mim" do cabeçalho da página principal e nos redirecionar para a nova que criamos.

```html
<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Sobre mim</title>
</head>
<body>
    <h1>Sobre mim</h1>
</body>
</html>
```

Guilherme: Feito isso, voltaremos ao index.html onde temos o menu de navegação, e precisaremos fazer com que nos redirecione através do link "Sobre mim".

Sempre utilizamos o href para navegar até uma outra pasta, ou ainda, no caso de imagens, há o src que significa "source" ou "fonte" em português.

Rafaella: Para navegarmos até outra página com um link, também utilizaremos o href.

Guilherme: Outro ponto de atenção é que, onde temos a classe de `<a>`, escreveremos o href logo após seu nome e antes de fechar a navegação em >.

No caso do link "Home", sempre iremos voltar para a página inicial quando clicarmos, que é o "index.html".

Rafaella: não colocaremos o ./ antes do nome do arquivo porque já estamos na mesma pasta que ele.

Guilherme: Faremos a mesma coisa para a segunda tag âncora, em que href será igual a "about.html". Salvaremos e voltaremos à página no navegador.

```html
<!DOCTYPE html>
<html lang="pt-br">

//código omitido

<body>
    <header class="cabecalho">
        <nav class="cabecalho__menu">
            <a class="cabecalho__menu__link" href="index.html">Home</a>
            <a class="cabecalho__menu__link" href="about.html">Sobre mim</a>
        </nav>
    </header>

//código omitido

</body>
</html>
```

Guilherme: Repararemos que os dois links estão sublinhados depois que colocamos os dois hrefs.

Rafaella: Mas não queremos que fiquem sublinhados, então vamos retirar isso no arquivo de estilização.

Guilherme: Para isso, em styles.css, iremos ao seletor .cabecalho__menu__link e inseriremos a propriedade text-decoration: none ao final do bloco dentro das chaves.

```CSS
//código omitido

.cabecalho__menu__link {
    font-family: 'Montserrat', sans-serif;
    font-size: 24px;
    font-weight: 600;
    color: #22D4FD;
    text-decoration: none;
}
//código omitido
```

Rafaella: Voltando à página no navegador, teremos retirado os sublinhados.

Guilherme: Se clicarmos em "Home", iremos apenas recarregar porque já estaremos na página principal, mas se clicarmos em "Sobre mim", iremos à nova tela que criamos.

Rafaella: Então já conseguimos navegar entre páginas. A seguir, iremos desenvolver o about.html.

### Aula 4 - Desenvolvendo a nova página - Vídeo 3

Transcrição  
Rafaella: Nesta aula, iremos desenvolver a página "Sobre mim" que por enquanto só tem este texto no `<h1>` de `<body>` no about.html, que inclusive poderemos apagar pois não o utilizaremos mais.

Vamos lembrar da estrutura inicial mais semântica que sempre utilizamos no HTML.

Guilherme: Dentro de `<body>`, usaremos o `<header>`, seguido de `<main>` que é o conteúdo principal da página, e o `<footer>` depois.

Porém, se observarmos a tela de "Sobre mim" no Figma, notaremos que o cabeçalho e o rodapé são exatamente iguais aos da página inicial.

Então poderemos copiar este código de index.html com "Ctrl + C" e colar com "Ctrl + V" no about.html.

Rafaella: No documento da página inicial, usamos as classes "cabecalho" em `<header>` e "cabecalho__menu" em `<nav>`, e poderemos copiar este bloco para depois estilizarmos.

Dentro do `<body>` que acabamos de colocar em about.html, colaremos todo o bloco de `<header>` copiado do index.html.

Faremos a mesma coisa com o `<footer>` de classe "rodape" do index.html, colando-o em about.html.

```html
<!DOCTYPE html>
<html lang="pt-br">

//código omitido

<body>
    <header class="cabecalho">
        <nav class="cabecalho__menu">
            <a class="cabecalho__menu__link" href="index.html">Home</a>
            <a class="cabecalho__menu__link" href="about.html">Sobre mim</a>
        </nav>
    </header>
    <main></main>
    <footer class="rodape">
        <p>Desenvolvido por Alura.</p>
    </footer>
</body>
</html>
```

Rafaella: Com isso, já teremos o `<header>` e o `<footer>` da página "Sobre mim" igual aos da página inicial.

Agora precisaremos completar o `<main>`.

Guilherme: Vamos salvar e abrir o navegador para analisarmos o resultado.

Por enquanto há apenas os textos do cabeçalho sublinhados em azul porque são clicáveis, e a frase "Desenvolvido por Alura." do rodapé logo abaixo, tudo no canto superior esquerdo do fundo em branco.

Se clicarmos em "Home", nos redirecionaremos para a página inicial porque os links já estão definidos em <a>.

Rafaella: Ainda não temos os estilos porque não importamos o CSS.

Guilherme: Deveremos criar um novo arquivo style.css para essa página nova, ou manteremos o que já temos?

Rafaella: conseguiremos trazer este documento de estilos para a "Sobre mim", pois estamos utilizando exatamente as mesmas classes da mesma forma.

Por exemplo, se estivéssemos com um menu de cores e formatos diferentes, teríamos que utilizar outras classes ou criar mais arquivos .css.

Existem diversas possibilidades quando estamos em ambiente de desenvolvimento e criamos vários documentos para cada página para nos organizarmos, principalmente em grandes projetos.

Porém, na prática, no momento de colocarmos o projeto no ar, o ideal para a performance da nossa página ser boa, é termos o menor número de arquivos .css possível.

Então conseguiremos reutilizar nosso arquivo style.css em nosso projeto porque é bastante simples, e de fato usamos a mesma estilização.

Portanto, importaremos este documento no código da nova página.

Guilherme: Uma dica importante é, se formos em `<title>` com Sobre mim no about.html, e abaixo escrevermos apenas “link: css” para apertarmos a tecla "Enter" depois, aparecerá a linha de código `<link>` completa.

```html
<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Sobre mim</title>
    <link rel="stylesheet" href="styles.css">
</head>
//código omitido
</html>
```

Rafaella: O problema é que temos "style.css" em href, mas havíamos criado uma pasta, então precisaremos corrigir para "./styles/style.css".

Se salvarmos e voltarmos ao navegador, encontraremos os links do cabeçalho e o texto do rodapé já com os estilos corretos.

Guilherme: Aparecem ainda muito juntos.

Rafaella: É porque ainda não temos nada no `<main>` do about.html, e a seguir iremos desenvolver o corpo da página.

### Aula 4 - Criando a navegação entre páginas

Imagine que você deseja criar uma navegação entre as páginas Home e Sobre mim em seu `<header>`. Qual das abordagens a seguir é recomendada para que consiga desenvolver essa navegação?

Resposta:  

```html
    <header>
        <nav>
            <a href="index.html">Home</a>
            <a href="about.html">Sobre mim</a>
        </nav>
    </header>
```

> Ao adicionar links de navegação ao `<header>`, devemos criar uma `<nav>`, com um `<a>` para cada link, e adicionar seu endereço na propriedade href.

### Aula 4 - Desafio: crie uma página currículo!

Agora que você aprendeu a criar outras páginas com HTML, queremos te desafiar!

Crie mais uma página em seu projeto e construa nela o seu currículo.

Você pode seguir a estrutura dos currículos tradicionais, com suas informações no topo e sua estrutura dividida em seções, ou você pode soltar sua criatividade e fazer algo totalmente diferente, fica a seu critério.

É importante que nessa página currículo você adicione uma imagem sua e crie pelo menos uma lista HTML, que contenha suas experiências de trabalho ou estudos.

Além disso, pode ser interessante adicionar outros projetos caso você tenha.

Lembre-se: não tenha medo de personalizar esta página, afinal é o seu currículo e quanto mais tiver “a sua cara”, melhor.

Agora é sua vez de criar, topa o desafio?

Opinião do instrutor

Criamos a seguinte página currículo:

Imagem da tela da página currículo criada no projeto, onde temos um fundo escuro, uma imagem no lado direito e no lado esquerdo um há na parte superior um título “Currículo” e um parágrafo de texto logo abaixo, ambos com a cor branca. Em seguida há o texto “Experiências” seguido de uma lista com o texto “Empresa tal (2020 - 2021) - fazia isso e aquilo” na primeira linha e o texto “Empresa tal (2021 - 2023) - fazia isso e aquilo” na segunda linha, tudo na cor branca. Em seguida há o texto “Estudos” seguido de uma lista com o texto “Curso tal - Alura Cursos com certificado” se repetindo três vezes, onde  “Curso tal - Alura Cursos” está em branco e “com certificado” está em azul claro, pois é um link.

Para isso, criamos um novo arquivo chamado curriculo.html e adicionamos seu link na barra de navegação do header. Dentro desse arquivo, criamos um `<main>` entre o `<header>` e o `<footer`>, onde criamos uma seção Experiências e uma seção Estudos. Aproveitamos as classes que já usamos no index.html para facilitar a estilização e adicionamos tanto as experiências como os estudos através das tags `<ul>` e `<li>`, que utilizamos para criar listas com HTML. Também inserimos links para os certificados de cada curso através da tag <a>, com a propriedade href. Estilizamos os links adicionando um text-decoration: none e um color: #22D4FD no CSS com a classe .apresentacao__conteudo__texto a, para que os links ficassem sem sublinhado e com a cor secundária do projeto. Por fim, adicionamos a imagem da “Joana Santos”. O resultado em código foi o seguinte:

```html
    <main class="apresentacao">
        <section class="apresentacao__conteudo">
            <h1 class="apresentacao__conteudo__titulo">Currículo</h1>
            <p class="apresentacao__conteudo__texto">
                Apresentação e informações principais
            </p>
            <h2 class="apresentacao__conteudo__titulo">Experiências</h2>
            <ul class="apresentacao__conteudo__texto">
                <li> Empresa tal (2020 - 2021) - fazia isso e aquilo </li>
                <li> Empresa tal (2021 - 2023) - fazia isso e aquilo </li>
            </ul>
            <h2 class="apresentacao__conteudo__titulo">Estudos</h2>
            <div class="apresentacao__conteudo__texto">
            <ul class="apresentacao__conteudo__texto">
                <li>Curso tal - Alura Cursos <a href="linkdocertificado">com certificado</a> </li>
                <li>Curso tal - Alura Cursos <a href="linkdocertificado">com certificado</a></li>
                <li>Curso tal - Alura Cursos <a href="linkdocertificado">com certificado</a></li>
            </ul>
            </div>    
        </section>
        <img src="./assets/imagem.png" alt="Foto da Joana Santos programando">
    </main> 
```

E a única adição no CSS foi a estilização dos links de certificado, como no seguinte bloco de código:

```CSS
.apresentacao__conteudo__texto a{
    text-decoration: none;
    color: #22D4FD;
}
```

Caso queira entender melhor como funcionam as listas HTML, você pode consultar a documentação.

Fez esse desafio?

Compartilhe conosco através do fórum ou das redes sociais, marcando a Alura =)

### Aula 4 - Lista de exercícios

1) Estilizando o cabeçalho com CSS  
Imagine que você trabalha com desenvolvimento front-end trabalhando em um projeto de website. O seu desafio é estilizar o cabeçalho da página de acordo com as especificações fornecidas. Utilize o arquivo style.css para aplicar as propriedades CSS no cabeçalho.

2) Ajustando o espaçamento do conteúdo  
Agora, como quem trabalha com desenvolvimento, seu próximo desafio é ajustar o espaçamento do conteúdo da página para que se alinhe corretamente com o cabeçalho.

3) Criando e navegando para a página "Sobre mim"  
Você está trabalhando em um projeto de site pessoal e precisa adicionar uma página "Sobre mim". Para isso, você deve criar um novo arquivo HTML, chamado about.html, e configurar um link no menu de navegação do seu site principal (index.html) para redirecionar para esta nova página. Além disso, ajuste o cabeçalho da página about.html para que o título da aba seja “Sobre mim” e adicione um `<h1>` com o texto "Sobre mim" no corpo da nova página. Certifique-se de que a navegação entre a página principal e a página "Sobre mim" esteja funcionando corretamente.

4) Ajustando a estilização após reorganização de arquivos  
Você percebeu que, após mover o arquivo styles.css para uma nova pasta chamada "styles", a estilização do seu site foi perdida. Para corrigir isso, você deve atualizar o caminho do arquivo CSS no seu arquivo index.html. Além disso, no arquivo styles.css, você deve remover o sublinhado dos links no cabeçalho do site. Após estas correções, verifique se a estilização foi aplicada corretamente e se os links do cabeçalho não estão mais sublinhados.

5) Estruturando a página "Sobre mim" com cabeçalho e rodapé  
Nesta atividade, você irá estruturar a página "Sobre mim" do seu projeto, reutilizando o cabeçalho e o rodapé da página inicial (index.html). Primeiro, copie o `<header>` e o `<footer>` do index.html e cole-os no arquivo about.html. Em seguida, adicione uma seção `<main>` vazia entre o `<header>` e o `<footer>`. Por fim, verifique se a estrutura copiada está funcionando corretamente no navegador, com os links de navegação e o texto do rodapé aparecendo.

6) Importando e corrigindo o caminho do arquivo CSS na página "Sobre mim"  
O objetivo desta atividade é importar o arquivo de estilos styles.css na página "Sobre mim" e corrigir o caminho do arquivo para refletir a estrutura de pastas atual. No arquivo about.html, adicione a tag `<link>` para importar o styles.css. Lembre-se de que o arquivo CSS foi movido para uma pasta chamada "styles", então o caminho do href na tag `<link>` precisa ser atualizado para "./styles/styles.css". Após essa correção, salve o arquivo e recarregue a página no navegador para verificar se os estilos foram aplicados corretamente.

Opinião do instrutor

1) Estilizando o cabeçalho com CSS

- Para estilizar a classe .cabecalho__menu__link, insira as seguintes propriedades em style.css:

```CSS
  .cabecalho__menu__link {
      font-family: 'Montserrat', sans-serif;
      font-size: 24px;
      font-weight: 600;
      color: #22D4FD;
  }
```

- Ajuste o padding da classe .cabecalho para espaçar corretamente o conteúdo:

```CSS
  .cabecalho {
      padding: 2% 0% 0% 15%;
  }
```

- Implemente o FlexBox na classe .cabecalho__menu e defina um gap:

```CSS
  .cabecalho__menu {
      display: flex;
      gap: 80px;
  }
```

Após aplicar essas mudanças, salve o arquivo e confira o resultado no navegador para garantir que as modificações estão de acordo com o design proposto.

2) Ajustando o espaçamento do conteúdo

- Modifique o padding da classe .apresentacao para alinhar melhor o conteúdo com o cabeçalho:

```CSS
  .apresentacao {
      padding: 5% 15%;
  }
```

Após as alterações, é importante conferir no navegador se o layout está alinhado e corresponde ao design planejado.

3) Criando e navegando para a página "Sobre mim"

- Crie um novo arquivo HTML chamado about.html.
- Crie toda a estrutura básica do HTML.
- Altere a linguagem do documento para português brasileiro (lang="pt-br").
- No `<head>`, defina o título como "Sobre mim" na tag `<title>`.
- Adicione um `<h1>` no `<body>` com o texto "Sobre mim".
- No arquivo index.html, encontre a seção do menu de navegação.
- Adicione um link para about.html usando a tag `<a>` com o atributo href.
- Verifique se ao clicar no link "Sobre mim" no index.html, a navegação é feita corretamente para a página about.html.
Código:

about.html:

```html
<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Sobre mim</title>
</head>
<body>
    <h1>Sobre mim</h1>
</body>
</html>
```

index.html (parte do código):

```html
//... código omitido
<body>
    <header class="cabecalho">
        <nav class="cabecalho__menu">
            <a class="cabecalho__menu__link" href="index.html">Home</a>
            <a class="cabecalho__menu__link" href="about.html">Sobre mim</a>
        </nav>
    </header>
//... código omitido
</body>
</html>
```

4) Ajustando a estilização após reorganização de arquivos

- No arquivo index.html, atualize o link para o styles.css para refletir o novo caminho ("./styles/styles.css").
- Abra o arquivo styles.css e encontre o seletor .cabecalho__menu__link.
- Adicione a propriedade text-decoration: none; para remover o sublinhado dos links.
- Salve as alterações e recarregue a página no navegador para verificar se a estilização foi aplicada corretamente e se os links do cabeçalho estão sem sublinhado.
Código:

index.html (parte do código):

```html
<!DOCTYPE html>
<html lang="pt-br">
<head>
    //... código omitido
    <link rel="stylesheet" href="./styles/styles.css">
    //... código omitido
</head>
//... resto do código
```

styles.css:

```CSS
//... código omitido

.cabecalho__menu__link {
    //... outras propriedades
    text-decoration: none;
}

//... código omitido
```

5) Estruturando a página "Sobre mim" com cabeçalho e rodapé

- Abra o arquivo index.html e copie o código completo do `<header>` e do `<footer>`.
- Abra o arquivo about.html e cole o código do `<header>` e do `<footer>` copiado.
- No about.html, insira uma seção `<main>` vazia entre o `<header>` e o `<footer>`.
- Salve as alterações e abra about.html no navegador para verificar se o cabeçalho e o rodapé estão aparecendo corretamente.
Código:

about.html:

```html
<!DOCTYPE html>
<html lang="pt-br">
<body>
    <header class="cabecalho">
        //... código do cabeçalho copiado
    </header>
    <main></main>
    <footer class="rodape">
        //... código do rodapé copiado
    </footer>
</body>
</html>
```

6) Importando e corrigindo o caminho do arquivo CSS na página "Sobre mim"

- No arquivo about.html, adicione a tag `<link>` no `<head>` para importar o arquivo styles.css.
- Atualize o atributo href da tag `<link>` para o caminho correto, considerando a pasta "styles" onde o arquivo CSS foi movido. O caminho correto será "./styles/styles.css".
- Salve as alterações e abra about.html no navegador para verificar se os estilos foram aplicados, e se os links do cabeçalho e o texto do rodapé estão com a estilização correta.
Código:

about.html:

```html
<!DOCTYPE html>
<html lang="pt-br">
<head>
    //... outros elementos do head
    <title>Sobre mim</title>
    <link rel="stylesheet" href="./styles/styles.css">
</head>
<body>
    //... restante do código do body
</body>
</html>
```

### Aula 4 - O que aprendemos?

- Nessa aula, você aprendeu como:
- Fazer a estilização do header do portfólio;
- Criar a nova página HTML “Sobre mim”;
- Desenvolver a navegação entre as páginas “Home” e “Sobre mim”.

## Aula 5 - Apliacando variáveis no CSS

### Aula 5 - Conteúdo da página Sobre Mim - Vídeo 1

Transcrição  
Rafaella: Já temos nosso cabeçalho e nosso rodapé. Falta adicionarmos o conteúdo principal da página "Sobre mim". Podemos ver no Figma quais elementos existem dentro do nosso main:

- o título "Sobre mim";
- abaixo dele, dois parágrafos;
- à direita destes, a mesma imagem que usamos na página inicial.

Retornaremos ao VS Code e acessaremos o arquivo about.html para inserir estes elementos. Buscaremos o nosso `<main>` vazio e nele criaremos uma `<section>` para armazenar todos os elementos da página. Abaixo da `<section>` adicionaremos uma `<img>`.

Lembrando que já realizamos esse procedimento no nosso índice. A `<section>` será o elemento visualizado à esquerda da página, enquanto a `<img>` ficará à direita.

```html
// Código omitido
        </nav>
    </header>

    <main>
        <section>

        </section>
        <img>
    </main>

    <footer class="rodape">
        <p>Desenvolvido por Alura.</p>
    </footer>
</body>
</html>
```

O que temos dentro dessa `<section>`?

Guilherme: Temos o `<h1>` com o texto "Sobre mim", e dois `<p>`s.

Dica: Para adicionarmos os dois parágrafos de uma vez, iremos até a linha vazia abaixo do `<h1>` e digitaremos o atalho p*2, seguido do "Enter".

```html
// Código omitido
        </nav>
    </header>
    <main>
        <section>
            <h1>Sobre mim</h1>
            <p></p>
            <p></p>
        </section>
        <img>
    </main>

    <footer class="rodape">
        <p>Desenvolvido por Alura.</p>
    </footer>
</body>
</html>
```

Rafaella: Voltaremos ao Figma, onde copiaremos o "Lorem ipsum" dos dois parágrafos, um por vez. Voltaremos ao nosso código e colaremos esses conteúdos no interior das suas respectivas tags.

```html
// Código omitido
        </nav>
    </header>

    <main>
        <section>
            <h1>Sobre mim</h1>
            <p>At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis praesentium voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident, similique sunt in culpa qui officia deserunt mollitia animi, id est laborum et dolorum fuga.</p>
            <p>Et harum quidem rerum facilis est et expedita distinctio. Nam libero tempore, cum soluta nobis est eligendi optio cumque nihil impedit quo minus id quod maxime placeat facere possimus, omnis voluptas assumenda est, omnis dolor repellendus. Temporibus autem quibusdam et aut officiis debitis aut rerum necessitatibus saepe eveniet ut et voluptates repudiandae sint et molestiae non recusandae. Itaque earum rerum hic tenetur a sapiente delectus, ut aut reiciendis voluptatibus maiores alias consequatur aut perferendis doloribus asperiores ipsum delis forum birol parela maxime infena. Excepteur sint occaecat cupidatat non.</p>
        </section>
        <img>
    </main>

    <footer class="rodape">
        <p>Desenvolvido por Alura.</p>
    </footer>
</body>
</html>
```

Guilherme: Agora precisamos da imagem. Ela possui as mesmas propriedades da imagem anterior. Podemos copiar o conteúdo do index.html e colá-lo no about.html. O código a ser copiado está disponível abaixo.

```html
<img src=".assets/imagem.png" alt="Foto da Joana Santos programando">
```

O resultado será este:

```html
// Código omitido
        </nav>
    </header>

    <main>
        <section>
            <h1>Sobre mim</h1>
            <p>At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis praesentium voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident, similique sunt in culpa qui officia deserunt mollitia animi, id est laborum et dolorum fuga.</p>
            <p>Et harum quidem rerum facilis est et expedita distinctio. Nam libero tempore, cum soluta nobis est eligendi optio cumque nihil impedit quo minus id quod maxime placeat facere possimus, omnis voluptas assumenda est, omnis dolor repellendus. Temporibus autem quibusdam et aut officiis debitis aut rerum necessitatibus saepe eveniet ut et voluptates repudiandae sint et molestiae non recusandae. Itaque earum rerum hic tenetur a sapiente delectus, ut aut reiciendis voluptatibus maiores alias consequatur aut perferendis doloribus asperiores ipsum delis forum birol parela maxime infena. Excepteur sint occaecat cupidatat non.</p>
        </section>
        <img src=".assets/imagem.png" alt="Foto da Joana Santos programando">
    </main>

    <footer class="rodape">
        <p>Desenvolvido por Alura.</p>
    </footer>
</body>
</html>
```

Rafaella: Salvaremos o nosso código.

Guilherme: Vamos ver como ficou no navegador. Abaixo do cabeçalho, temos os três textos e a imagem no canto esquerdo da página, dispostos na vertical. No topo temos o título "Sobre mim". Abaixo dele temos o primeiro parágrafo, e logo abaixo deste temos o segundo parágrafo. Por fim, abaixo dos textos, temos a imagem.

Rafaella: Por que as nossas configurações de CSS não estão funcionando no main?

Guilherme: Porque não atribuímos classes a elas. Vamos adicionar as seguintes classes:

- no `<main>`, a class="apresentacao";
- na `<section>`, a class="apresentacao__conteudo";
- no `<h1>`, a class="apresentacao__conteudo__titulo";
- nos dois `<p>`s, a class="apresentacao__conteudo__texto".

Dica 1: Podemos copiar os nomes das classes diretamente do index.html. Esse procedimento é muito comum no início da criação de páginas Web.

Dica 2: Para adicionar a mesma classe em dois locais de uma vez — como no caso dos nossos dois parágrafos —, basta clicar no primeiro local, segurar o botão "Alt" e clicar nos próximos locais em que deseja escrever. Desta forma, todos os locais selecionados serão editados simultaneamente.

```html
// Código omitido
        </nav>
    </header>

    <main class="apresentacao">
        <section class="apresentacao__conteudo>
            <h1 class="apresentacao__conteudo__titulo">Sobre mim</h1>
            <p>At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis praesentium voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident, similique sunt in culpa qui officia deserunt mollitia animi, id est laborum et dolorum fuga.</p>
            <p>Et harum quidem rerum facilis est et expedita distinctio. Nam libero tempore, cum soluta nobis est eligendi optio cumque nihil impedit quo minus id quod maxime placeat facere possimus, omnis voluptas assumenda est, omnis dolor repellendus. Temporibus autem quibusdam et aut officiis debitis aut rerum necessitatibus saepe eveniet ut et voluptates repudiandae sint et molestiae non recusandae. Itaque earum rerum hic tenetur a sapiente delectus, ut aut reiciendis voluptatibus maiores alias consequatur aut perferendis doloribus asperiores ipsum delis forum birol parela maxime infena. Excepteur sint occaecat cupidatat non.</p>
        </section>
        <img src=".assets/imagem.png" alt="Foto da Joana Santos programando">
    </main>

    <footer class="rodape">
        <p>Desenvolvido por Alura.</p>
    </footer>
</body>
</html>
```

Rafaella: Salvaremos nosso código e veremos o resultado no navegador. Abaixo do cabeçalho, agora temos o conteúdo centralizado na tela e dividido em dois blocos: o da esquerda possui o título, seguido abaixo pelos textos, enquanto o bloco da direita possui somente a imagem.

Tela "Sobre mim" no navegador. No topo da tela existe um cabeçalho na cor ciano com dois textos: "Home" e "Sobre mim". Abaixo dele, existem dois blocos de conteúdo, lado a lado, centralizados sobre fundo preto. O bloco esquerdo possui um texto que se divide em duas partes: um título e dois parágrafos. O título apresenta o texto em negrito "Sobre mim" na cor branca. Os parágrafos são na cor branca, e exibem um texto "Lorem ipsum". Já o bloco direito se constitui de uma fotografia em preto e branco representando Joana Santos, uma mulher desenvolvedora, sentada em frente a um notebook aberto. A fotografia também conta com um desenho em ciano de uma linha circulando Joana e seu notebook três vezes e terminando em uma estrela. Abaixo dos dois blocos, temos um rodapé constituído de uma faixa ciano que atravessa horizontalmente a parte inferior da tela, do canto direito ao canto esquerdo. Dentro dele há o texto "Desenvolvido por Alura", na cor preta.

### Aula 5 - Variáveis CSS - Vídeo 2

Transcrição  
Rafaella: O nosso projeto está sensacional! Conseguimos:

- navegar entre as páginas;
- acessar o "Sobre mim";
- visualizar o rodapé, o cabeçalho e todos os conteúdos da tela;
- voltar para o "Home" e visualizar o efeito Hover quando passamos o mouse pelos botões.

O projeto está visualmente incrível, contudo existem alguns detalhes que podemos alterar em relação ao nosso código.

Guilherme: Vamos analizar as cores do nosso projeto. Temos três cores principais:

- a cor preta de fundo 000000, que é a cor principal;
- o branco F6F6F6, utilizado em vários elementos e
- o azul ciano 22D4FD, uma cor terciária que utilizamos para dar destaque.

Utilizamos essas cores diversas vezes no nosso CSS. Vamos abrir o arquivo style.css por meio do VS Code. Pressionaremos "Ctrl + F" e pesquisaremos a cor terciária, digitando "22D4FD" no campo de pesquisa. Constataremos que essa cor foi utilizada quatro vezes ao longo do projeto. Pesquisaremos em seguida a cor do fundo, digitando "000000" no campo de pesquisa. Perceberemos que ela foi utilizada duas vezes.

Ou seja, somando somente as duas cores, repetimos o nosso código seis vezes. Na prática, repetimos uma propriedade sensível oito vezes. Isso significa que, caso precisarmos alterar alguma das três cores principais do nosso projeto, teríamos que alterá-la em oito partes diferentes.

Rafaella: Esse processo de mudança de cor é muito comum. Muitas empresas decidem alterar as suas identidades visuais em algum ponto de sua trajetória.

Guilherme: Como poderemos reutilizar um único código de cor em partes diferentes da nossa aplicação?

Rafaella: Utilizaremos variáveis no CSS. Se você conhece alguma outra linguagem de programação, deve saber que elas são muito utilizadas. As variáveis são endereços na nossa memória reservados para armazenar um valor. Elas precisam ser nomeadas.

É possível criar, por exemplo, uma variável chamada azul-claro e armazenar nela a nossa cor, informando o valor hexadecimal #22D4FD. Com isso, podemos utilizar somente a variável ao invés de declarar o valor da cor diretamente em todas as partes do código. Além disso, poderemos alterar este valor sempre que precisarmos.

Guilherme: Com esse processo, podemos realizar alterações na cor do nosso projeto recorrendo a um único local, o qual enviará a alteração para todos os outros locais em que for inserido. Vamos entender as variáveis acessando a documentação.

Rafaella: Buscaremos no Google "variables css" (ou "variáveis no css"). No resultado da pesquisa, selecionaremos o link que nos guiará para a página do Developer Mozilla sobre variáveis do CSS, em português.

Guilherme: Selecionamos o Developer Mozilla pois nele temos um exemplo prático. Na seção "Uso básico", somos informados da possibilidade de criar variáveis para um escopo global ou para um escopo local. Voltaremos ao VS Code para demonstrar os dois processos.

Começaremos entendendo a variável de escopo local. Ela consiste em uma variável que poderá ser utilizada diversas vezes, mas que funcionará apenas em um bloco de código definido — como por exemplo, o body {} do nosso arquivo style.css.

Rafaella: Não temos nenhum caso desse em nosso código.

Guilherme: Não temos esse caso nem no código nem no nosso projeto. Portanto, faz mais sentido criarmos para o escopo global. Essa técnica consiste em definir as nossas variáveis dentro de um local por meio do qual possamos utilizá-las em vários blocos diferentes, seja o body, o header, ou outro qualquer.

Rafaella: Podemos encontrar esta técnica no segundo exemplo que nos é dado no site Developer Mozilla. A técnica consiste em utilizar a pseudoclasse root para que a variável possa ser aplicada globalmente no documento HTML. Podemos consultar o exemplo mencionado abaixo:

```CSS
:root {
    --main-bg-color: brown;
}
```

Neste exemplo declaramos uma variável dentro das chaves do root, utilizando a sintaxe --nome: valor. O brown ilustra um procedimento que já realizamos anteriormente. No lugar do nome da cor, adicionaremos o seu valor hexadecimal.

Retornando ao VS Code, ainda no interior do arquivo style.css, adicionaremos na linha 3, acima de todos os blocos de código, a pseudoclasse :root {} como se ela fosse um seletor.

Guilherme: Um seletor para utilizarmos ao longo de todo o nosso documento, ou seja, de forma global.

```CSS
@import url('https://fonts.googleapis.com/css2?family=Krona+One&family=Montserrat&display=swap');

:root {

}

* {
        margin: 0;
        padding: 0;
}
```

No interior de suas chaves, criaremos nomes para as três variáveis de cor:

- a cor principal se chamará --cor-primaria;
- a cor secundária se chamará --cor-secundaria e
- a cor terciária ou de destaque, chamaremos de --cor-terciaria.
- Para definir a --cor-primaria, utilizaremos : #000000, seguido de ponto e vírgula. Faremos o mesmo para as outras cores, alterando o valor hexadecimal da --cor-secundaria para #F6F6F6, enquanto o valor da --cor-terciaria será #22D4FD.

```CSS
:root {
    --cor-primaria: #000000;
    --cor-secundaria: #F6F6F6;
    --cor-terciaria: #22D4FD;
}
```

Rafaella: Por enquanto, nada mudou no projeto, pois apenas declaramos essas variáveis.

Guilherme: Exatamente. Nós criamos um local onde definimos que temos três cores, e atribuímos um valor para cada uma delas. Nosso próximo desafio será utilizar esses elementos no nosso projeto.

### Aula 5 - Aplicando as variáveis - Vídeo 3

Transcrição  
Rafaella: Declaramos todas as nossas variáveis. Precisamos utilizá-las nos trechos de código que fazem uso dessas cores. Para isso, voltaremos à nossa documentação sobre variáveis do CSS no site Developer Mozilla para consultar a seção abaixo da declaração de variáveis, onde encontraremos as instruções para utilização delas.

Temos o element {}, que poderá ser o body, a tag `<h2>`, o `<p>`, entre outros. Dentro dele, adiciona-se a propriedade background-color, a qual receberá a variável declarada anteriormente (--main-bg-color) dentro da função var().

```CSS
element {
    background-color: var(--main-bg-color);
}
```

Faremos esse procedimento, voltando ao VS Code.

Guilherme: Nos atentaremos ao detalhe mais importante: sempre que reutilizarmos variáveis, adicionaremos a função var() e o nome da variável entre os parênteses.

Rafaella: No arquivo CSS faremos as alterações a seguir.

Guilherme: Dica: No momento em que digitamos "var(" e pressionamos "Enter", o sistema abre uma lista com as variáveis disponíveis. Podemos selecionar cada uma por meio dessa lista.

Dentro das chaves do body {}, deletaremos os códigos hexadecimais e adicionaremos as funções abaixo:

- na propriedade background-color adicionaremos a var(--cor-primaria);
- na propriedade color adicionaremos a var(--cor-secundaria).
- Dentro das chaves das classes .cabecalho__menu__link {} e .titulo-destaque {}:

- na propriedade color removeremos os hexadecimais e adicionaremos a função var(--cor-terciaria).
- Dentro das chaves da classe .apresentacao__links__link {}, por sua vez, deletaremos os hexadecimais e adicionaremos as funções abaixo:

- na propriedade border adicionaremos a var(--cor-terciaria);
- na propriedade color adicionaremos a var(--cor-secundaria);

O resultado das alterações qeu fizemos pode ser consultado abaixo.

```CSS
body {
    /* height: 100vh; */
    box-sizing: border-box;
    background-color: var(--cor-primaria);
    color: (--cor-secundaria);
}

// código omitido

.cabecalho__menu__link {
    font-family: 'Montserrat', sans-serif;
    font-size: 24px;
    font-weight: 600;
    color: var(--cor-terciaria);
}

// código omitido

.titulo-destaque {
    color: var(--cor-terciaria);
}

// código omitido

.apresentacao__links__link {
    /* background-color: #22D4FD; */
    display: flex;
    justify-content: center;
    gap: 16px;
    border: 2px solid var(--cor-terciaria);
    width: 378px;
    text-align: center;
    border-radius: 8px;
    font-size: 24px;
    font-weight: 600;
    padding: 21.5px 0;
    text-decoration: none;
    color: var(--cor-secundaria);
    font-family: 'Montserrat', sans-serif;
}
```

Rafaella: Quando chegamos na classe .apresentacao__links__link:hover {}, percebemos que não criamos uma variável para a cor do Hover. Vamos criá-la para que seja possível modificá-la em relação à cor de fundo, caso necessário. No interior das chaves de :root {}, abaixo das outras cores, adicionaremos a variável --cor-hover, a qual receberá a cor #272727.

```CSS
:root {
    --cor-primaria: #000000;
    --cor-secundaria: #F6F6F6;
    --cor-terciaria: #22D4FD;
    --cor-hover: #272727;
}
```

Retornaremos à classe .apresentacao__links__link:hover {} e continuaremos as nossas modificações. Dentro de suas chaves, na propriedade background-color, deletaremos o hexadecimal e adicionaremos a função var(--cor-hover).

Por fim, dentro das chaves da classe .rodape {}, deletaremos os códigos hexadecimais e adicionaremos as funções abaixo:

- na propriedade color adicionaremos a var(--cor-primaria) e
- na propriedade background-color adicionaremos a var(--cor-terciaria);

O resultado das novas alterações pode ser consultado abaixo.

```CSS
.apresentacao__links__link:hover {
    background-color: var(--cor-hover);
}

.rodape {
    padding: 24px;
    color: var(--cor-primaria);
    background-color: var(--cor-terciaria);
    text-align: center;
    font-family: 'Montserrat', sans-serif;
    font-size: 24px;
    font-weight: 400;
}
```

Além das variáveis de cor, vamos declarar as variáveis de fonte, pois também se tratam de dados muito repetidos ao longo do nosso código.

Voltaremos ao interior das chaves do :root {} e abaixo das variáveis existentes, criaremos mais duas: --fonte-primaria e --font-secundaria. Vamos manter um espaço entre os dois tipos de variáveis com uma linha vazia.

Na primeira variável nova, adicionaremos o valor do título:'Krona One', sans-serif, enquanto que na segunda adicionaremos o valor dos parágrafos: 'Montserrat', sans-serif.

```CSS
:root {
    --cor-primaria: #000000;
    --cor-secundaria: #F6F6F6;
    --cor-terciaria: #22D4FD;
    --cor-hover: #272727;

    --fonte-primaria: 'Krona One', sans-serif;
    --font-secundaria: 'Montserrat', sans-serif;
}
```

Agora faremos a troca dos valores hexadecimais pelas novas variáveis, em todos os locais que utilizamos essas cores:

- na classe .cabecalho__menu__link {}, adicionaremos a var(--font-secundaria);
- na classe .apresentacao__conteudo__titulo {}, adicionaremos a var(--fonte-primaria);
- na classe .apresentacao__conteudo__texto {}, adicionaremos a var(--font-secundaria);
- na classe .apresentacao__links__subtitulo {}, adicionaremos a var(--fonte-primaria);
- na classe .apresentacao__links__link {}, adicionaremos a var(--font-secundaria) e por fim,
- na classe .rodape {}, adicionaremos a var(--font-secundaria).

```CSS
// código omitido
.cabecalho__menu__link {
    font-family: var(--font-secundaria);
    font-size: 24px;
    font-weight: 600;
    color: var(--cor-terciaria);
}

// código omitido

.apresentacao__conteudo__titulo {
    font-size: 36px;
    font-family: var(--fonte-primaria);
}

// código omitido

.apresentacao__conteudo__texto {
    font-size: 24px;
    font-family: var(--font-secundaria);
}

// código omitido

.apresentacao__links__subtitulo {
    font-family: var(--fonte-primaria);
    font-weight: 400;
    font-size: 24px;
}

.apresentacao__links__link {
    /* background-color: #22D4FD; */
    display: flex;
    justify-content: center;
    gap: 16px;
    border: 2px solid var(--cor-terciaria);
    width: 378px;
    text-align: center;
    border-radius: 8px;
    font-size: 24px;
    font-weight: 600;
    padding: 21.5px 0;
    text-decoration: none;
    color: var(--cor-secundaria);
    font-family: var(--font-secundaria)
}

// código omitido

.rodape {
    padding: 24px;
    color: var(--cor-primaria);
    background-color: var(--cor-terciaria);
    text-align: center;
    font-family: var(--font-secundaria);
    font-size: 24px;
    font-weight: 400;
}
```

Guilherme: Utilizamos essas fontes em vários lugares. Após essas alterações, se voltarmos ao projeto pelo navegador, não veremos nenhuma mudança visual. Contudo, faremos um teste que mostrará toda a diferença: mudaremos a paleta de cores do projeto.

Rafaella: Sim. Para isso, acessaremos a página Color Hunt, a qual disponibiliza uma seleção de paletas pré-definidas. Selecionaremos, no explorador à esquerda, a opção "Coffee", e nela encontraremos a paleta nova do nosso projeto, disponível neste link.

A nova paleta possui as seguintes cores, organizadas do tom mais escuro para o mais claro: #2C3639 (cinza escuro), #3F4E4F (cinza médio), #A27B5C (marrom) e #DCD7C9 (branco creme). Clicaremos em cima de cada faixa de cor para copiar o seu valor hexadecimal automaticamente.

Retornando ao VS Code, trocaremos todas as cores da pseudoclasse :root {} conforme abaixo:

- a --cor-primaria receberá o valor do cinza escuro: #2C3639;
- a --cor-secundaria receberá o valor do branco creme: #DCD7C9;
- a --cor-terciaria receberá o valor do marrom: #A27B5C e
- a --cor-hover receberá o valor do cinza médio: #3F4E4F.

```CSS
:root {
    --cor-primaria: #2C3639;
    --cor-secundaria: #DCD7C9;
    --cor-terciaria: #A27B5C;
    --cor-hover: #3F4E4F;

    --fonte-primaria: 'Krona One', sans-serif;
    --font-secundaria: 'Montserrat', sans-serif;
}
```

Guilherme: Não conseguimos nem imaginar como ficará o projeto com essas novas cores. Vamos checar!

Projeto no navegador com as cores trocadas. O fundo agora é cinza escuro. Na parte superior, os textos em negrito "Home" e "Sobre mim" são da cor marrom. O título apresenta duas novas cores: "Eleve seu negócio digital a outro nível" em branco creme, seguido de "com um Front-end de qualidade!" em marrom. O  parágrafo e o subtítulo são da cor branco creme. Os três botões possuem um contorno de cor marrom, junto a textos na cor branco creme. O bloco direito com a imagem e os ícones não foram alterados.

Este foi o resultado. Mudamos somente quatro valores e com eles alteramos as cores do projeto inteiro. A página "Sobre mim" possui o mesmo padrão nas alterações.

Podemos mudar infinitamente e facilmente essas quatro variáveis! Você pode escolher qualquer paleta que quiser para aplicar nesse projeto.

Rafaella: É possível modificar cores, fontes e até mesmo criar novas variáveis, caso você julgue que outro valor esteja se repetindo muito dentro do código.

Por que os ícones e os detalhes da imagem continuaram azul ciano? Porque são imagens prontas, baixadas diretamente do Figma. Caso você queira modificá-las, basta substituí-las por imagens de outra cor.

Finalizamos o teste, portanto retornaremos os valores de cor para o seu estado anterior.

```CSS
:root {
    --cor-primaria: #000000;
    --cor-secundaria: #F6F6F6;
    --cor-terciaria: #22D4FD;
    --cor-hover: #272727;

    --fonte-primaria: 'Krona One', sans-serif;
    --font-secundaria: 'Montserrat', sans-serif;
}
```

Agora que finalizamos o projeto, é importante remover os comentários que havíamos feito. Nós comentamos algumas propriedades que não queríamos mais utilizar, mas agora que finalizamos, vamos limpar nosso código removendo-os. A seguir temos a lista de comentários que serão removidos do arquivo style.css:

- dentro de .apresentacao__links__link {}, removeremos o /* background-color: #22D4FD */ e
- dentro de body {}, removeremos o /* height: 100vh */.

Pronto. Temos o nosso projeto finalizado.

### Aula 5 - Trabalhando com variáveis CSS

As propriedades de customização CSS, mais conhecidas como variáveis CSS, podem ser muito úteis para deixar as atualizações de layout do projeto mais práticas. Pensando nisso, imagine que você criou uma variável para armazenar a cor que deseja aplicar no cabeçalho do seu projeto, como podemos observar no código a seguir:

```CSS
:root{
    cor-atualizada-do-projeto:  #eb94bd;
}
.cabecalho{
        background-color: black;
}
```

No entanto, mesmo criando a variável de cor atualizada, o cabeçalho não sofreu alteração.

Observando o código acima, assinale as alternativas que apresentam o que você precisa fazer para que consiga de fato mudar a cor do cabeçalho com a nova variável:

Alternativa correta  
A variável precisa ser declarada com um hífen duplo (--) no início, para que seja reconhecida como variável e não como propriedade CSS.

> A variável deveria ser declarada com o nome --cor-atualizada-do-projeto, pois essa é a sintaxe correta para criação de variáveis em CSS. O hífen duplo (--) no início permite que o código entenda que essa não é uma propriedade do CSS como background-color, por exemplo, mas sim um valor que você está definindo através do uso de variável.

Alternativa correta  
Para que a cor seja alterada, é preciso que a variável não seja apenas declarada dentro de :root, ela precisa ser aplicada como background-color de .cabecalho.

> Para usarmos as variáveis, precisamos não só criá-las, mas também aplicá-las em nosso código. No caso, dentro de .cabecalho, a propriedade background-color deveria receber como valor var(--cor-atualizada-do-projeto). Lembre-se sempre de aplicar suas variáveis.

### Aula 5 - Para saber mais: as variáveis no mundo da programação

Um armário cheio de gavetas!  
Imagine que você trabalhe em uma sala de arquivos, que possui um armário muito grande e cheio de gavetas. Todos os dias, pessoas trazem seus objetos para que você guarde em uma gaveta para eles e para isso, te entregam uma etiqueta com um nome que será colado nessa gaveta que armazenará o objeto da pessoa.

Ana te entregou uma caneta e uma etiqueta com o nome: canetaDaAna, e você guardou a caneta dela em uma gaveta, onde colou a etiqueta. Ela escolheu o nome canetaDaAna, mas poderia ser qualquer outro nome e seu conteúdo poderia ser qualquer um também, como um livro, por exemplo, e não uma caneta.

Quando Ana precisar da caneta, ela irá te chamar e pedir pela canetaDaAna, e você a entregará o conteúdo da gaveta, ou seja, a caneta.

E como isso se relaciona com as variáveis?  
Seu armário de gavetas no exemplo acima representa a memória do computador. Quando criamos uma variável, estamos solicitando ao computador que reserve uma “gavetinha” em sua memória para que guarde algo que precisaremos usar futuramente, e fazemos isso atribuindo um nome de variável que poderemos chamar a qualquer momento e que retornará o conteúdo que guardamos dentro dela. Esse nome pode ser um nome qualquer, no entanto sempre que solicitado ele trará como resposta aquilo que você armazenou nele.

O que são variáveis?  
Variáveis são elementos que permitem que valores sejam manipulados ao longo da execução de seu código, através da definição de um nome para armazenar um valor que será usado repetidas vezes. Essa definição do nome e do conteúdo que será contido nele é o que nós chamamos de declaração.

Esse valor pode ser alterado ao longo do código, por isso o nome “váriavel”.

Observe o seguinte exemplo:

```CSS
:root{
     --tamanho-da-fonte:  24px;
}
```

Criamos no :root, ou seja, no escopo global de um código, uma variável que foi declarada com o nome --tamanho-da-fonte e seu valor foi atribuído como 24px. Toda vez que chamarmos pelo nome --tamanho-da-fonte, iremos obter como retorno o valor 24px.

Variáveis são utilizadas diariamente pelas pessoas desenvolvedoras para que consigam manipular e reutilizar valores em seu código e estão presentes nas mais diversas linguagens de programação, pois são elementos base ao criar qualquer código que tenha a mínima funcionalidade. Portanto, conforme você evoluir em seus conhecimentos no desenvolvimento é certo que irá lidar muito com variáveis.

Para saber mais sobre as variáveis em CSS, você pode conferir a [documentação](https://developer.mozilla.org/pt-BR/docs/Web/CSS/Using_CSS_custom_properties).

### Aula 5 - Faça como eu fiz: personalizando a paleta de cores!

Nessa aula conhecemos as variáveis CSS e descobrimos seu potencial para customização do projeto.

Agora, gostaríamos de te convidar a fazer como foi feito em aula e buscar outras paletas de cores que possam ser aplicadas no projeto através das variáveis CSS que criamos.

As cores causam um grande impacto e alterando elas você pode obter um projeto com uma cara totalmente nova. Caso queira pesquisar paletas como foi feito em aula, você pode acessar o [Color Hunt](https://colorhunt.co/). Outra opção interessante é a [Roda de Cores da Adobe](https://color.adobe.com/pt/create/color-wheel).

Um atalho que pode facilitar muito o processo de alterar as cores em todo o código para atribuir em seu lugar a variável é o ctrl + D. Basta selecionar o que deseja mudar com o mouse e em seguida clicar em ctrl + D até que todos os valores que você deseja alterar estejam selecionados. Isso irá permitir mudar ao mesmo tempo todos os valores seguintes que sejam iguais ao que você selecionou com o mouse, como podemos observar no gif a seguir:

gif de código CSS que demonstra o uso do atalho `ctrl + D`. O ponteiro do mouse seleciona um valor de cor `#000000` e ao apertar o atalho `ctrl + D` o mesmo valor fica selecionado na linha seguinte e eles são editados simultaneamente para `var(--nova-cor)`   .

Se quiser relembrar esse processo de transformação da paleta do projeto, recomendamos o [vídeo Como as variáveis CSS transformam meu projeto?](https://cursos.alura.com.br/extra/alura-mais/como-as-variaveis-css-transformam-meu-projeto--c1485), onde você pode reforçar os conceitos que aprendeu em aula. Você também pode conferir outras opções de sites para escolher sua paleta de cores através do [Para saber mais: escolhendo as cores do seu projeto](https://cursos.alura.com.br/course/html-css-ambiente-arquivos-tags/task/120614) , que está no curso 1 de HTML e CSS.

Além disso, você também pode alterar outros elementos através da criação das variáveis, como o tamanho ou peso das fontes, por exemplo. Lembre-se que explorar as ferramentas novas que conhecemos em aula é um passo que enriquece muito o aprendizado =)

Opinião do instrutor

Por aqui, escolhemos aplicar uma paleta bem colorida, que encontramos no Color Hunt. Caso queira utilizá-la, basta clicar aqui. Observe o resultado na imagem abaixo:

tela do projeto com a paleta de cores modificada com fundo rosa salmão e texto em amarelo claro

A paleta de cores tem o poder de transformar a identidade do projeto. A que escolhemos aqui, por exemplo, poderia tranquilamente se tornar uma página sobre uma sorveteria, pois traz cores que remetem a esse tipo de negócio. E tudo o que fizemos aqui foi adicionar as cores de acordo com a nova paleta no seletor :root, pois as variáveis já estavam aplicadas ao longo do projeto, bastava alterar seus valores em um único lugar, como podemos ver no código a seguir:

```CSS
:root {
    --cor-primaria: #FA7070;
    --cor-secundaria: #C6EBC5;
    --cor-terciaria: #FBF2CF;
    --cor-hover: #A1C298;
}
```

E assim temos um projeto transformado!

E se você também transformou o seu, fique à vontade para compartilhá-lo conosco através do fórum ou de suas redes sociais marcando a Alura. Você pode nos encontrar nas redes nos seguintes perfis:

Instagram;  
Twitter;  
LinkedIn.

Vamos gostar muito de conhecer seu projeto =)

### Aula 5 - Projeto final do curso

Aqui você pode [baixar o zip do projeto final da aula 05](https://github.com/alura-cursos/Portifolio-HTML-e-CSS-Curso3/archive/refs/heads/aula_5.zip) ou acessar os [arquivos no Github!](https://github.com/alura-cursos/Portifolio-HTML-e-CSS-Curso3/tree/aula_5)

### Aula 5 - Para saber mais: dicas de projeto

Para que continue praticando HTML e CSS, é importante que siga desenvolvendo novos projetos para aprimorar seus conhecimentos. Trouxemos algumas sugestões legais para você:

Página-presente
Imagine utilizar seus conhecimentos em HTML e CSS para presentear alguém!

Você pode criar uma página homenageando alguém que você goste e presentear essa pessoa.

É possível fazer uma galeria com fotos suas, escrever um texto bem legal e adicionar links para coisas que a pessoa goste.

Essas páginas também são frequentemente feitas como presente de aniversário.

Você pode embarcar nessa temática trazendo recursos como vídeos, imagens e até músicas para o projeto.

Assim, você evolui seu conhecimento e ainda faz alguém feliz!

Tela com exemplo de página presente, composta por um cabeçalho rosa escuro com os textos “Home”, “Carta” e “Nossas Fotos” em verde claro dispostos lado a lado no canto esquerdo. Abaixo há o conteúdo principal com fundo cinza claro, na primeira seção há o texto “Essa página é um presente para você: Feliz Aniversário!” escrito em rosa escuro ao lado esquerdo e do lado direito há uma ilustração com três pessoas comemorando um aniversário. Na seção abaixo há o texto centralizado “Uma carta para você” e abaixo dele um parágrafo de texto “lorem ipsum”, ambos em rosa escuro. Abaixo há outra seção com o título “Nossas Fotos”, seguido de 6 ilustrações simulando fotos de pessoas, essas ilustrações estão distribuídas em 2 linhas e 3 colunas. Todas possuem pontos com tons de verde menta. Abaixo há o rodapé do projeto, também com fundo rosa escuro com os textos “Criado em janeiro de 2023” e “People ilustrations by storyset” escritos em branco.

Lojinha
Que tal soltar a criatividade e inventar uma lojinha de algo que você goste?

Você pode criar uma página para exibir produtos de uma marca fictícia que ache interessante e assim treinar display: flex compondo a exibição dos seus produtos na página, por exemplo.

gif com exemplo de página de “lojinha” de plantas feita com HTML e CSS

Página de favoritos
Por último, um dos projetos preferidos das pessoas estudantes de HTML e CSS: Criar uma página de favoritos!

Esse projeto é muito divertido pois permite que você crie uma página com as coisas que você mais gosta. Podem ser filmes, séries, músicas, animes, jogos, produtos entre outros.

Aqui você pode escolher um único tema ou então criar seções para cada tema favorito.

Adicione imagens, links para visualizar seus favoritos, vídeos sobre eles e etc.

Você pode abusar da criatividade nesse projeto: Se você escolher músicas, por exemplo, crie links para navegação em outras páginas contando a história da música que escolheu, ou de quem compôs, ou até mesmo o porque é uma favorita.

imagem com exemplo de página de filmes favoritos feita com HTML e CSS

Você também encontra várias outras ideias de projeto nesse vídeo no canal da Rafa Ballerini:  
[Link do Video](https://youtu.be/y4ltLH9iK8E)

Enfim, não deixe de praticar e evoluir seu conhecimento. Bons estudos, até a próxima!

### Aula 5 - Lista de exercícios

1) Adicionando conteúdo à página "Sobre mim"  
Nesta atividade, você adicionará o conteúdo principal na página "Sobre mim" do seu projeto. Primeiro, no arquivo about.html, localize o `<main>` vazio e crie uma `<section>` para armazenar o conteúdo da página. Dentro desta `<section>`, adicione um `<h1>` com o texto "Sobre mim" e dois parágrafos (`<p>`), utilizando o atalho p*2 seguido de "Enter" para criar ambos. Em seguida, volte ao Figma para copiar o texto de "Lorem ipsum" e cole-o nos parágrafos correspondentes. Por fim, adicione uma imagem ao lado dos parágrafos, copiando o código da imagem da página inicial e colando-o no about.html.

2) Aplicando estilos à página "Sobre mim"  
Após adicionar o conteúdo principal, você deverá aplicar estilos à página "Sobre mim". Primeiro, atribua classes apropriadas aos elementos dentro do `<main>`: adicione a classe "apresentacao" ao `<main>`, "apresentacao__conteudo" à `<section>`, "apresentacao__conteudo__titulo" ao `<h1>` e "apresentacao__conteudo__texto" aos parágrafos. Utilize a técnica de seleção múltipla (segurando "Alt" e clicando) para adicionar a mesma classe a ambos os parágrafos simultaneamente. Após adicionar as classes, salve o arquivo e visualize no navegador para conferir o alinhamento e a estilização dos elementos.

3) Definindo variáveis de cores no CSS  
Nesta atividade, você vai definir variáveis globais no CSS para as cores principais do seu projeto. Abra o arquivo style.css no VS Code e adicione a pseudoclasse :root no início do arquivo, acima de todos os blocos de código. Dentro do :root, defina três variáveis: --cor-primaria para a cor preta (#000000), --cor-secundaria para o branco (#F6F6F6) e --cor-terciaria para o azul ciano (#22D4FD). Este processo permite que você altere facilmente as cores principais do projeto alterando apenas essas variáveis.

4) Aplicando as variáveis de cores no projeto  
Depois de definir as variáveis de cores, o próximo passo é aplicá-las em todo o projeto. Procure no arquivo style.css onde as cores originais foram usadas (utilize "Ctrl + F" para pesquisar pelas cores hexadecimais). Substitua todas as ocorrências das cores hexadecimais pelas variáveis correspondentes que você definiu. Por exemplo, substitua todas as ocorrências de #000000 por var(--cor-primaria). Isso garantirá que, se as cores principais precisarem ser alteradas no futuro, você só terá que alterá-las uma vez nas variáveis globais, simplificando a manutenção do código.

5) Aplicando variáveis CSS para cores e fontes  
Nesta atividade, você irá revisar e aplicar as variáveis CSS criadas para gerenciar as cores e fontes do seu projeto. Inicie abrindo o arquivo style.css e substitua os valores hexadecimais das cores e das fontes pelas variáveis CSS correspondentes. Por exemplo, onde você encontra a cor #22D4FD, substitua por var(--cor-terciaria). Faça isso para todas as instâncias onde as cores primária, secundária, terciária e hover são utilizadas, bem como para as fontes primária e secundária.

6) Testando a flexibilidade das variáveis CSS com uma nova paleta de cores  
Nesta atividade, você testará a flexibilidade das variáveis CSS alterando a paleta de cores do projeto. Acesse o site Color Hunt e escolha uma nova paleta de cores. Copie os valores hexadecimais das cores escolhidas e substitua-os nas variáveis CSS dentro do :root no arquivo style.css. Por exemplo, altere o valor de --cor-primaria para o novo valor de cor escolhido. Após alterar todas as cores, salve o arquivo e visualize o projeto no navegador para ver as mudanças. Esta atividade demonstrará como as variáveis CSS podem facilitar a manutenção e alteração do design de um projeto.

Opinião do instrutor

1) Adicionando conteúdo à página "Sobre mim"

- Abra o arquivo about.html e localize o elemento `<main>`.
- Dentro de `<main>`, crie uma `<section>` e, dentro desta, insira um `<h1>` com o texto "Sobre mim".
- Utilize o atalho p*2 e "Enter" para criar dois parágrafos vazios abaixo do `<h1>`.
- Retorne ao Figma, copie o texto de "Lorem ipsum" e cole nos parágrafos.
- Adicione uma tag `<img>` fora da `<section>`, mas dentro de `<main>`.
- Copie o código da imagem do arquivo index.html e cole na tag `<img>` do about.html.
Código:

about.html:

```html
<!DOCTYPE html>
<html lang="pt-br">
<body>
    //... cabeçalho e rodapé omitidos
    <main>
        <section>
            <h1>Sobre mim</h1>
            <p>Lorem ipsum dolor sit amet...</p>
            <p>Lorem ipsum dolor sit amet...</p>
        </section>
        <img src=".assets/imagem.png" alt="Foto da Joana Santos programando">
    </main>
    //... rodapé
</body>
</html>
```

2) Aplicando estilos à página "Sobre mim"

- Dentro do `<main>` do arquivo about.html, adicione a classe "apresentacao".
- Na `<section>` dentro de `<main>`, adicione a classe "apresentacao__conteudo".
- Ao `<h1>` dentro da `<section>`, adicione a classe "apresentacao__conteudo__titulo".
- Aos dois parágrafos, adicione a classe "apresentacao__conteudo__texto" usando a técnica de seleção múltipla (segurando "Alt" e clicando).
- Salve as alterações e abra o arquivo no navegador para verificar se os estilos foram aplicados corretamente.
Código:

about.html:

```html
<!DOCTYPE html>
<html lang="pt-br">
<body>
    //... cabeçalho e rodapé omitidos
    <main class="apresentacao">
        <section class="apresentacao__conteudo">
            <h1 class="apresentacao__conteudo__titulo">Sobre mim</h1>
            <p class="apresentacao__conteudo__texto">Lorem ipsum dolor sit amet...</p>
            <p class="apresentacao__conteudo__texto">Lorem ipsum dolor sit amet...</p>
        </section>
        <img src=".assets/imagem.png" alt="Foto da Joana Santos programando">
    </main>
    //... rodapé
</body>
</html>
```

3) Definindo variáveis de cores no CSS

- Abra o arquivo style.css no VS Code.
- No início do arquivo, adicione a pseudoclasse :root.
- Dentro do :root, defina três variáveis para as cores principais do projeto. Use a sintaxe --nome-da-variavel: valor; para cada cor.
Código:

```CSS
@import url('https://fonts.googleapis.com/css2?family=Krona+One&family=Montserrat&display=swap');

:root {
    --cor-primaria: #000000;
    --cor-secundaria: #F6F6F6;
    --cor-terciaria: #22D4FD;
}

* {
    margin: 0;
    padding: 0;
}
//... restante do código
```

4) Aplicando as variáveis de cores no projeto

- Procure no arquivo style.css onde as cores originais, como #000000, #F6F6F6 e #22D4FD, foram usadas.
- Substitua todas as ocorrências dessas cores pelas variáveis correspondentes, usando a sintaxe var(--nome-da-variavel).
- Por exemplo, substitua #000000 por var(--cor-primaria) em todas as suas ocorrências no arquivo.
Código:

```CSS
// Exemplo de substituição no arquivo
.cabecalho {
    background-color: var(--cor-primaria);
    //... outros estilos
}

.rodape {
    color: var(--cor-secundaria);
    //... outros estilos
}

.cabecalho__menu__link:hover {
    color: var(--cor-terciaria);
    //... outros estilos
}
//... restante do código
```

5) Aplicando variáveis CSS para cores e fontes

- Abra o arquivo style.css no seu editor de código.
- Substitua os valores hexadecimais de cores pelas variáveis CSS correspondentes. Por exemplo, onde encontrar #22D4FD, substitua por var(--cor-terciaria).
- Faça o mesmo para as cores primária, secundária e hover, bem como para as fontes primária e secundária, substituindo os valores hexadecimais pelas variáveis CSS.
- Salve as alterações e recarregue seu projeto para verificar se as cores e fontes foram aplicadas corretamente.

6) Testando a flexibilidade das variáveis CSS com uma nova paleta de cores

- Acesse o site Color Hunt e selecione uma nova paleta de cores para o seu projeto.
- Copie os valores hexadecimais das novas cores escolhidas.
- Abra o arquivo style.css e substitua os valores nas variáveis CSS dentro do :root pelas novas cores. Por exemplo, altere --cor-primaria para o novo valor de cor escolhido.
- Salve o arquivo e visualize o projeto no navegador para observar as mudanças.
- Esta atividade demonstrará a facilidade de manutenção e alteração do design do seu projeto através do uso de variáveis CSS.

### Aula 5 - Para ir mais fundo

Aqui está uma lista de referências para você se aprofundar nos estudos, aprimorar seus conhecimentos e adquirir novas habilidades.

1. [Flexbox CSS: Guia Completo, Elementos e Exemplos](https://www.alura.com.br/artigos/css-guia-do-flexbox) (Gratuito, Português, Artigo)

> Este artigo da Alura fornece uma visão detalhada sobre o Flexbox, explicando como ele é usado para criar layouts eficientes, alinhar e distribuir espaços entre itens em um container, mesmo quando as dimensões desses itens são desconhecidas ou dinâmicas.

2. [CSS: Flexbox e Layouts Responsivos](https://www.alura.com.br/conteudo/css-flexbox-layouts-responsivos) (Gratuito, Português, Artigo)

> Este conteúdo da Alura aborda como o Flexbox pode ser usado para criar interfaces modernas e ajustáveis a diferentes tamanhos de tela, tornando-se uma solução de layout eficiente para o desenvolvimento web.

3. [CSS Tricks: A Complete Guide to Flexbox](https://css-tricks.com/snippets/css/a-guide-to-flexbox/) (Gratuito, Inglês, Artigo)

> Este guia completo do CSS Tricks oferece uma explicação abrangente sobre Flexbox, abordando todas as propriedades possíveis para o elemento pai (o container flex) e os elementos filhos (os itens flex). Inclui também histórico, demonstrações, padrões e um gráfico de suporte do navegador.

4. [Como Utilizar Fontes Personalizadas em CSS](https://www.alura.com.br/artigos/tailwind-adicionando-fontes-customizadas) (Gratuito, Português, Artigo)

> Este artigo da Alura aborda como trabalhar com fontes personalizadas em CSS, incluindo a utilização de fontes externas e locais, e como a customização da fonte pode variar dependendo do framework utilizado, como o Tailwind. É uma referência útil para entender a importância da escolha e da aplicação correta das fontes em um projeto web.

5. [CSS Border: Estilizando com Bordas seus Elementos CSS](https://www.alura.com.br/artigos/css-border-estilizando-bordas-elementos-css) (Gratuito, Português, Artigo)

> Este artigo oferece um guia sobre como estilizar bordas em CSS, explorando várias possibilidades de personalização, incluindo cor, espessura e formato. É particularmente relevante para quem deseja aprender sobre a aplicação prática e criativa de bordas em elementos HTML.

6. [CSS Icons: Como Adicionar Ícones a Links em HTML e CSS](https://www.w3schools.com/Css/css_icons.asp) (Gratuito, Inglês, Tutorial)

> Este tutorial do W3Schools oferece um guia passo a passo sobre como adicionar ícones a links em HTML e CSS. Aprenda a incorporar eficientemente ícones ao seu projeto web, aumentando a atratividade e a funcionalidade dos link.

7. [Lidando com Arquivos em Projetos Web](https://developer.mozilla.org/pt-BR/docs/Learn/Getting_started_with_the_web/Dealing_with_files) (Gratuito, Português, Artigo)

> Este artigo da MDN Web Docs aborda a organização de arquivos em projetos web. Ele detalha como manter uma estrutura de arquivos eficiente e como organizar pastas para diferentes tipos de arquivos, como imagens, estilos CSS e scripts JavaScript.

8. [Regras Gerais para Caminhos de Arquivo em HTML](https://developer.mozilla.org/pt-BR/docs/Learn/Getting_started_with_the_web/Dealing_with_files) (Gratuito, Português, Artigo)

> Este conteúdo também da MDN Web Docs fornece regras gerais e melhores práticas para definir caminhos de arquivo em HTML, ensinando como referenciar corretamente imagens e outros recursos dentro da estrutura do projeto.

9. [Flexbox - Aprendendo desenvolvimento web | MDN](https://developer.mozilla.org/pt-BR/docs/Learn/CSS/CSS_layout/Flexbox) (Gratuito, Português, Artigo)

> Este artigo da MDN Web Docs oferece uma introdução prática ao Flexbox com uma série de exercícios para entender como essa ferramenta funciona, ideal para quem está começando ou quer reforçar suas habilidades em CSS Flexbox.

10. [Entendendo o Soft Hover - Curso de CSS GRATUITO](https://www.youtube.com/watch?v=6jMqjQhHoHw) (Gratuito, Português, Vídeo)

> Este vídeo do Code Universe no YouTube oferece um tutorial visual e prático sobre como implementar o efeito soft hover em CSS. É uma excelente maneira de entender visualmente o impacto do hover e como ele pode ser aplicado para melhorar a interatividade do usuário em uma página web.

11. [:hover - CSS | MDN - MDN Web Docs](https://developer.mozilla.org/pt-BR/docs/Web/CSS/:hover) (Gratuito, Português, Artigo)

> A MDN Web Docs oferece uma página detalhada sobre a pseudo-classe :hover em CSS. Este recurso é útil para entender os aspectos técnicos e as possibilidades que o hover oferece ao estilizar elementos HTML, especialmente links e botões.

12. [How To - Transition on Hover - W3Schools](https://www.w3schools.com/howto/howto_css_transition_hover.asp) (Gratuito, Inglês, Artigo)

> O W3Schools apresenta um guia prático sobre como implementar transições no hover, adicionando uma dimensão adicional ao efeito hover. Embora esteja em inglês, é um recurso valioso para entender como combinar hover com transições para criar efeitos visuais mais dinâmicos e atraentes.

13. [CSS básico - Aprendendo desenvolvimento web | MDN](https://developer.mozilla.org/pt-BR/docs/Learn/Getting_started_with_the_web/CSS_basics) (Gratuito, Português, Artigo)

> Este guia da MDN Web Docs aborda os conceitos básicos de CSS, uma linguagem de folhas de estilos usada para aplicar estilos seletivamente a elementos em documentos HTML. Ele oferece exemplos práticos de como aplicar estilos a elementos como parágrafos (`<p>`), listas (`<li>`) e títulos (`<h1>`), e como centralizar texto, ajustar tamanhos de fonte, altura da linha e espaçamento das letras para melhorar a legibilidade e o design do seu site.

14. [CSS: Trabalhando com caixas - MDN](https://developer.mozilla.org/pt-BR/docs/Learn/CSS/Building_blocks/The_box_model) (Gratuito, Português, Artigo)

> Neste outro artigo da MDN, você aprenderá sobre o modelo de caixas em CSS, que é fundamental para entender como estilizar elementos HTML. O artigo explica como o CSS trata muitos dos elementos HTML como caixas, detalhando propriedades como padding, border, margin, width, background-color, color, text-shadow e display. Estas propriedades são essenciais para criar um layout atraente e funcional para o cabeçalho do seu site.

15. [Manual do CSS: um guia prático de CSS para desenvolvedores | freeCodeCamp](https://www.freecodecamp.org/portuguese/news/manual-do-css-um-guia-pratico-de-css-para-desenvolvedores/) (Gratuito, Português, Artigo)

> Este guia abrangente do freeCodeCamp oferece uma visão geral dos principais recursos modernos do CSS que podem ser utilizados para estilizar páginas e aplicações web. É uma excelente fonte para aprender a personalizar e aprimorar a aparência de cabeçalhos usando CSS, além de outros elementos da página.

16. [29 rodapés e cabeçalhos CSS de alta qualidade para sua página web | Creativos Online](https://www.creativosonline.org/pt/27-cabe%C3%A7alhos-e-rodap%C3%A9s-css-para-seu-blog-ou-site.html) (Gratuito, Português, Artigo)

> Este artigo do Creativos Online apresenta uma coleção de 29 cabeçalhos e rodapés em CSS que podem ser usados em blogs ou sites. Inclui exemplos variados, desde cabeçalhos de artigos em tela cheia até cabeçalhos fixos e rodapés, oferecendo ideias práticas para personalizar o visual do cabeçalho do seu site.

17. [Utilizando propriedades CSS personalizadas (variáveis) - CSS | MDN](https://developer.mozilla.org/pt-BR/docs/Web/CSS/Using_CSS_custom_properties) (Gratuito, Português, Artigo)

> Este artigo da MDN Web Docs explica o uso básico de variáveis CSS. A declaração de uma propriedade personalizada é feita com um nome que começa com um hífen duplo (--) e um valor de propriedade que pode ser qualquer valor CSS válido. Este recurso é essencial para entender a sintaxe e o uso prático das variáveis em CSS.

18. [Variáveis CSS: um guia prático | desenvolvimento para web](https://www.desenvolvimentoparaweb.com/css/variaveis-css-guia-pratico/) (Gratuito, Português, Artigo)

> Este guia prático apresenta como integrar variáveis CSS no fluxo de trabalho de desenvolvimento para tornar as folhas de estilo mais fáceis de manter e evitar repetições desnecessárias. É uma excelente fonte para compreender como as variáveis podem otimizar a manutenção do código.

19. [CSS Variables - The var() function - W3Schools](https://www.w3schools.com/css/css3_variables.asp) (Gratuito, Inglês, Artigo)

> W3Schools oferece um guia sobre a função var() em CSS, utilizada para inserir o valor de uma variável CSS. O artigo aborda como criar variáveis com escopo local ou global, alterá-las com JavaScript e basear as mudanças em media queries. Este recurso é útil para entender como as variáveis CSS interagem com o DOM e podem ser aplicadas de forma dinâmica.

20. [Construa um CSS mágico com variáveis nativas | Alura](https://www.alura.com.br/artigos/construa-css-magico-variaveis-nativas) (Gratuito, Português, Artigo)

> A Alura oferece um artigo sobre como utilizar variáveis CSS, destacando a possibilidade de declará-las globalmente ou localmente. Este recurso é valioso para compreender a aplicação prática das variáveis CSS em diferentes escopos de um projeto.

### Aula 5 - Conclusão - Vídeo 4

Transcrição  
Guilherme: Parabéns! Estamos finalizando mais um curso da Alura!

Rafaella: Agora temos duas páginas e entendemos a lógica de como criar novas páginas no projeto: criamos um novo arquivo e inserimos um link no cabeçalho.

Guilherme: Criamos variáveis diferentes, por meio das quais modificamos as quatro cores principais da nossa página: a primária, a secundária, a terciária e a cor do Hover. Quando realizamos essa modificação, temos um layout totalmente diferente.

Pensamos não apenas na parte visual, mas na parte de desenvolvimento do nosso código.

Se você ficou com alguma dúvida durante esse curso, acesse o nosso Fórum, ficaremos felizes em te ajudar!

Nos vemos no próximo curso.
