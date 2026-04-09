# Curso Alura - Git e GitHub: compartilhando e colaborando em projetos

## Aula 1: Compartilhando projetos

### Aula 1: Apresentação - Vídeo 1

Transcrição  
Rodrigo: Olá, seja bem-vindo(a) ao curso de GIT e GitHub. Meu nome é Rodrigo Ferreira, sou um dos instrutores da Alura e acompanharei você ao longo deste curso.

Audiodescrição: Rodrigo Ferreira se descreve como um homem de pele branca, cabelo curto na cor castanha. Está com uma camisa na cor azul.

E não estou sozinho, estou com minha colega Gabrielle Ribeiro.

Gabrielle: Olá, eu sou a Gabi Ribeiro, também sou instrutora aqui na Alura e acompanharei você nesse curso.

Audiodescrição: Gabrielle Ribeiro se descreve como uma mulher parda, com cabelo curto e verde. Usa óculos com armação arredondada, piercing no septo e uma camisa preta. Ambos estão nos estúdios da Alura, sentados em uma mesa redonda e com laptops à sua frente.

**O que vamos aprender?**  
Rodrigo: Vamos apresentar o que vamos discutir de interessante nesse curso.

Este curso é para você que trabalha com programação, ou que tem interesse em trabalhar com programação, independentemente da linguagem de programação ou da área (se vai trabalhar com back-end, front-end, mobile), pois vamos apresentar ferramentas para compartilhamento de código e para colaboração em código, que é o GitHub e também o GIT.

Nesse curso, você vai aprender o que é esse tal de GitHub, como que ele funciona, como criar uma conta nesse GitHub, criar repositórios, que são os locais onde será compartilhado o seu código, assim como trabalhar em time, compartilhando projetos com outras pessoas e essas outras pessoas também fazendo alterações no código e compartilhando com você.

Gabrielle: Você também vai aprender qual é o fluxo de trabalho dentro do GIT e GitHub.

Rodrigo: E, além disso, vamos utilizar o Prompt de Comandos e a IDE Visual Studio Code para fazer essa integração com o GIT e aprenderemos também como lidar com conflitos, já que num trabalho em equipe, eventualmente alguém pode mexer no mesmo arquivo, numa mesma linha e o GIT consegue nos auxiliar com essa parte de conflitos.

Gabrielle: Você também vai aprender sobre o histórico de versões do GIT e como alterá-lo, apagando e modificando algumas informações.

Rodrigo: Além disso, vamos apresentar algumas ferramentas adicionais do GitHub, como o Gist, para compartilhar trechos de código, como criar um README no seu repositório e o Gitignore, para ignorar determinados arquivos do seu projeto.

Há muita coisa legal que vamos discutir nesse curso, certo Gabi? Se você se interessou, venha conosco e nos encontramos na primeira aula.

### Aula 1: Preparando o ambiente: projeto do curso

Neste curso utilizaremos o projeto sorteador de número secreto, que foi desenvolvido nos cursos de lógica de programação. Você pode fazer o download do projeto inicial neste link:

[Projeto inicial](https://github.com/alura-cursos/3386-git-github/archive/refs/heads/projeto_inicial.zip)

Após baixar o arquivo zip, descompacte-o em algum diretório do seu computador e na sequência importe o projeto em sua IDE. No curso, utilizaremos o [VSCode como IDE](https://code.visualstudio.com/download), sendo recomendado que você também utilize essa mesma IDE para facilitar o seu aprendizado.

### Aula 1: Conheça o GitHub - Vídeo 2

Transcrição  
Gabrielle: Imagine que você finalizou o desenvolvimento de um projeto e agora deseja compartilhar o seu código com outras pessoas. Como isso pode ser feito? Será que é enviando por e-mail uma pasta compactada? Ou talvez colocando em um pendrive?

Rodrigo: Neste curso, vamos trabalhar com o projeto do número secreto. Inclusive, já abrimos o projeto na IDE do Visual Studio Code. A intenção é compartilhar o código, não o projeto.

Nos cursos de lógica de programação, vocês aprenderam a compartilhar este projeto utilizando o Vercel para fazer o que chamamos de deploy, colocando o projeto no ar. Ele gera uma URL que pode ser enviada para as pessoas acessarem o seu projeto.

Porém, não queremos compartilhar o projeto, queremos compartilhar o código. Queremos compartilhar este código HTML, CSS e JavaScript para que outras pessoas desenvolvedoras possam visualizar o código e colaborar com este projeto.

Conhecendo o GitHub  
Gabrielle: Como compartilhamos esse código? Como outra pessoa pode visualizar e, às vezes, até contribuir para o código do nosso projeto?

Rodrigo: Assim como você mencionou, poderíamos enviá-lo por e-mail, compactá-lo, colocá-lo em um pendrive, entre outros.

Mas, da mesma forma que existe um site, como o Vercel, para realizar o deploy do projeto, existem também sites para compartilhar códigos de projetos de programação, onde podemos disponibilizar, deixar aberto para outras pessoas para visualizar, baixar e colaborar com o nosso código.

Há um site que é muito famoso para isso, não é mesmo, Gabi?

Gabrielle: Sim, é o GitHub, que é o site que vamos utilizar neste curso.

Rodrigo: Perfeito. Então, vamos abrir o navegador, abrir uma nova aba e entrar no site: github.com. Esse é um dos sites que oferece esse serviço de hospedagem de projetos e de código-fonte de aplicações.

Ao entrar no site, temos uma explicação de como funciona. Você consegue pesquisar alguns projetos, tem nomes de algumas empresas que o utilizam. Ele oferece esse serviço para hospedar o código do nosso projeto.

Então, fica a questão: será que é necessário pagar? Isso é de graça, Gabi?

Gabrielle: Nós podemos usar este site gratuitamente, só precisamos criar uma conta.

Criando uma conta no GitHub  
Rodrigo: Para criar uma conta, caso você ainda não tenha, no canto superior direito no site do GitHub, existe um botão chamado "Sign up" (registrar-se).

Clicando nele, será exibido um formulário para você realizar um cadastro, que é como qualquer outro, pedindo seu nome, e-mail, entre outras informações.

Criaremos uma conta do zero, apenas para mostrar o passo-a-passo. Primeiro, você vai digitar o seu e-mail. Por exemplo, usaremos um e-mail fictício apenas para testar: rodrigo.alura87@gmail.com, pois os instrutores já tem uma conta no GitHub com o seus e-mails pessoais.

Ao clicar no botão de "continue" (continuar), será pedido para gerar uma senha. Nesse caso, incluiremos uma senha qualquer. Ele tem algumas validações, pedindo para você incluir uma senha forte com pelo menos 15 caracteres ou 8 caracteres incluindo um número e uma letra minúscula. Então, não pode digitar 1, 2, 3, 4, 5, 6.

Após clicar em continuar, será pedido para você digitar um username (nome de usuário).

Gabrielle: Esse nome deve ser único para te identificar dentro da plataforma.

Rodrigo: Não podemos colocar, por exemplo, rodrigo, porque provavelmente outra pessoa já criou uma conta com esse nome de usuário. Quando o nome não está disponível, aparece uma mensagem abaixo: "Username rodrigo is not available".

Vamos usar outro nome de usuário, por exemplo, colocaremos rodrigoalura87. Está disponível. Então, vamos continuar o cadastro com esse nome de usuário.

O site pergunta se você deseja receber anúncios e atualizações via e-mail. Vamos digitar "n" para indicar que não queremos. Se você desejar receber anúncios de promoções e afins, deve digitar "y".

Após clicar para continuar, a plataforma precisa verificar se não somos um robô, ou seja, algum software que está criando contas de forma aleatória.

Vamos clicar nesse botão para "Verificar", e tem um CAPTCHA um tanto peculiar. É um pouco diferente dos tradicionais. Ele exibe duas imagens, uma imagem à esquerda com um dedo apontando para alguma direção e à direita tem outro desenho de um animal de pelagem curta.

Há algumas setas que você precisa clicar para fazer esse animal apontar para a mesma direção que os dedos indicam.

Existe a opção de escutar em áudio ou reiniciar o CAPTCHA. Neste caso, vamos apenas virar o animal para a direita e clicar em "Enviar". Ele vai verificar se a resposta está correta e, então, habilitar o botão "Create account" (criar conta).

Pronto. Após criar, o Google Chrome pergunta se queremos salvar a senha no navegador. Podemos salvar.

Agora, o GitHub pede para confirmar a conta. O GitHub te envia um e-mail, fornecendo um código que você precisa colar em "Enter code".

Já temos o e-mail cadastrado aberto, você precisa aguardar um pouco e em breve chegará o e-mail do GitHub. Se for por Gmail, confira as caixas de promoções, social ou spam, pois às vezes acaba indo para lá.

Clicamos no e-mail do GitHub, vamos copiar o código para continuar o cadastro. É um código para confirmar que somos proprietários do e-mail.

Voltamos a aba do GitHub e o colamos. Após a verificação, aparecem algumas perguntas: se trabalhamos sozinhos ou se fazemos parte de uma equipe ou empresa. Vamos selecionar a opção "Just me" (apenas eu), pois trabalharemos majoritariamente sozinhos.

Em seguida, pergunta se você é um estudante ou professor. Lembra-se que, como mencionamos, este site tem um plano gratuito, mas também oferece um plano pago, com algumas opções adicionais. Então, vamos indicar que não sou nem estudante, nem professor, ou seja, marcamos "N/A".

Após clicar para continuar, ele pergunta para que você vai usar o GitHub e quais funcionalidades você tem interesse em utilizar. Tem algumas opções, mas vamos marcar apenas a primeira opção de "Collaborative coding" (programação colaborativa).

Logo abaixo, temos o botão "Continuar" e aí o GitHub apresenta o plano gratuito e o plano de times, que é pago.

E aí, vamos pagar ou vamos usar a opção gratuita?

Gabrielle: Acredito que para o nosso propósito, o plano gratuito é suficiente.

Rodrigo: Você também não precisa pagar, pode usar o plano gratuito. O plano de times, que é privado, tem um custo e, em geral, é mais voltado para grandes empresas, que têm muitas pessoas e, portanto, consegue-se usar mais recursos do GitHub. Não será o nosso caso, então vamos clicar em "Continue for free" (continue gratuitamente).

Feito isso, surge uma animação que parece que estamos navegando no espaço, não é interessante?

Agora, abre-se a página inicial do GitHub. Após você criar a conta, ou se fechar o navegador e fizer login novamente, ele te direciona para essa tela.

Agora que criamos a nossa conta no GitHub, já podemos enviar código para cá, certo?

Gabrielle: Sim, é só importante lembrar que no momento em que for criar sua conta, pode ser que esse formulário seja um pouco diferente, tenha um layout diferente, mas não se preocupe, porque esses passos serão relativamente os mesmos sempre.

Com a nossa conta criada, agora podemos prosseguir para compartilhar o nosso projeto na sequência.

### Aula 1: Faça como eu fiz: criando uma conta no GitHub

Agora é com você! Caso ainda não tenha uma conta no GitHub, entre no site e crie uma nova conta, da mesma forma que foi demonstrado no vídeo anterior.

Opinião do instrutor

Para criar sua conta, você precisa acessar o site do GitHub e clicar no botão Sign up.

Imagem com print da tela inicial do site GitHub. Possui um botão de Sign up no canto superior direito, que está realçado com um contorno em vermelho.

Isso abrirá um formulário, que você deve preencher com suas informações de e-mail, uma senha com pelo menos 8 caracteres, incluindo algum número e letra minúscula, e um nome de usuário, que deve ser único. A cada campo preenchido você deve apertar o botão Continue.

Imagem com print do formulário de cadastro do Github. O formulário possui respectivamente os seguintes campos: e-mail, senha e nome de usuário. No canto inferior direito do último campo existe um botão de Continue.

Em seguida, o GitHub te perguntará se você deseja receber atualizações de produtos e anúncios em seu e-mail. Você deve digitar “y” caso queira, ou “n” caso contrário. Por padrão, vamos responder “n” e clicar no botão Continue.

Imagem com print de trecho do formulário de cadastro no GitHub, que pergunta se você deseja receber atualizações de produtos e anúncios em seu e-mail.

Na sequência, o GitHub realizará uma verificação, para garantir que você não é um robô. :)

Clique no botão Verificar.

Caso você seja uma pessoa com deficiência visual, você deve usar o botão Áudio, ao invés do botão Verificar.

Imagem com Print de tela inicial de verificação do cadastro do GitHub. Possui no centro um botão de Verificar e logo abaixo um botão de Áudio.

Iniciado o processo de verificação, duas imagens aparecerão na tela: à esquerda, uma imagem com uma mão apontando em uma direção e, à direita, um animal. Você deve utilizar os botões de seta para esquerda e seta para direita para girar o animal, até que ele esteja na mesma direção apontada pela mão. A imagem a seguir mostra um exemplo:

Imagem com print do teste de verificação do GitHub. À esquerda existe uma imagem com uma mão apontando para a esquerda. Ao lado dessa imagem, à direita, existe uma imagem com um animal e nos seus cantos inferiores há botões de seta para esquerda e seta para direita. Logo abaixo das duas imagens há um botão de enviar.

Depois, você deve clicar no botão Enviar. Assim, o botão Create account será habilitado e você deverá clicar nele.

Imagem com print da verificação do GitHub. Mostra o botão Create account habilitado.

Por fim, o GitHub enviará um código para o seu e-mail. Verifique seu e-mail, inclusive as abas de “Promoções”, “Social” e “Spam”. Após encontrá-lo, informe o código enviado.

Imagem com print da tela do GitHub que pede o código de verificação enviado por email. Há um campo para informar o código.

E voilà! Sua conta no GitHub está criada e pronta para uso.

### Aula 1: Criando um repositório - Vídeo 3

Transcrição  
Gabrielle: Criamos uma conta no GitHub que já está ativa e agora podemos subir o nosso projeto. Entretanto, como podemos fazer o upload desse projeto? Como organizar vários projetos no GitHub?

Rodrigo: Esta é uma questão interessante. Criamos a conta, mas e se tivermos dois, três, cinco, dez ou mesmo cem projetos? É bastante comum desenvolver vários projetos quando estamos aprendendo a programar. Queremos separá-los, porque cada projeto tem seus próprios arquivos específicos, um não tem relação com o outro.

O GitHub tem um conceito conhecido como repositório:

O repositório de um projeto é o local onde vamos guardar os códigos de um projeto específico.

Então, a ideia agora é criar um novo repositório e depois fazer o upload do nosso projeto.

Mas antes de fazer essa mudança, vamos fazer uma pequena configuração no GitHub. Vamos alterar o tema do claro para o tema escuro, para melhorar a visualização. Podemos fazer isso, clicando no canto superior direito da tela na foto do seu avatar para expandir o menu.

Em seguida, você vai até a opção de "Settings" (configurações). Nessa opção, no menu lateral esquerdo, tem a opção "Appearance" (aparência). Ele sincronizou com o sistema operacional, mas vamos mudar essa opção na combobox para "single theme" (tema único). E depois selecionar a opção "dark default" (escuro padrão).

Dica: Você pode escolher opções de alto contraste, clicando em "Dark high contrast" ou para daltonismo, clicando em "Dark Protanopia & Deuteranopia" ou "Dark Tritanopia".

Pronto, alteramos o tema para o escuro. Vamos voltar para a tela principal do GitHub, clicando no ícone do GitHub no canto superior esquerdo da tela.

Criando um repositório  
Rodrigo: Para criar o repositório, podemos clicar no botão verde chamado "Create Repository" (criar repositório) na lateral esquerda da página inicial do GitHub. Ou, no ícone de "+" no menu superior, podemos ir em "Create new > New Repository".

Existem várias opções para criar um novo repositório.

Com isso, se abre um novo formulário com a conta logada já identificada. O GitHub pede para digitar o nome desse repositório. É como se fosse o nome do projeto e deve ser único.

Gabrielle: Da mesma forma que temos o nome de usuário único, também precisamos de um nome único para o nosso repositório.

Esse nome único se refere a um repositório de uma pessoa. Então, poderíamos criar um repositório na sua conta com o mesmo nome que outro repositório em minha conta.

O nome do repositório tem que ser único na sua conta.

Rodrigo: Por exemplo, poderíamos colocar projeto. Ele não vai verificar em todos os usuários do GitHub se alguém já escolheu esse nome. Ele vai verificar apenas no nosso usuário se já temos um repositório com esse nome. Se já tiver, ele não permite, caso contrário geraria um conflito de nomes.

Nesse caso, vamos criar com o nome numero-secreto, que é o nome do nosso projeto.

No próximo campo, podemos inserir uma descrição. É opcional, caso queira descrever o que é esse projeto. Vamos deixar em branco.

O próximo campo é importante. Devemos colocar se esse repositório será público (public) ou privado (private).

Gabrielle: A visibilidade do nosso repositório é definida nesse passo. Se deixarmos marcado como público, qualquer pessoa que tiver a URL do repositório conseguirá acessar o nosso projeto e visualizar os códigos.

Se deixarmos como privado, será um repositório fechado com informações mais confidenciais.

Rodrigo: Essa escolha vai depender de como você deseja compartilhar esse código.

Se for um projeto para compartilhar, montar um portfólio e você quer mostrar o código para outras pessoas, deixe-o como público. Agora, se o projeto é pessoal ou da empresa, ou seja, é restrito e outras pessoas não devem acessar o código, deixe-o como privado.

Deixaremos o repositório como público no nosso caso.

Existem algumas outras opções, como README, .gitignore, license (licença), mas não modificaremos essas opções agora. Explicaremos o que cada uma delas significa posteriormente no curso.

Para iniciar, inserimos apenas o nome e marcamos como público. Em seguida, clicamos no botão verde "Create Repository" (criar repositório) na parte inferior.

O GitHub criará o repositório e nos redirecionará para a página do repositório. Note como a URL do navegador é:

github.com/rodrigoalura87/numero-secreto

Onde rodrigoaluro87 é o nome do usuário que criamos na conta GitHub e numero-secreto é o nome do repositório.

Agora que já criamos o repositório, agora vamos ter que obter o código do projeto que está no nosso computador e fazer o upload para esse repositório.

Gabrielle: Correto. O GitHub até mostra um tipo de tutorial, um passo a passo, sobre como usar esses comandos e fazer o upload do nosso projeto. Veremos isso na sequência.

### Aula 1: Para saber mais: repositórios privados

A visibilidade dos repositórios no GitHub serve para controlar quem tem acesso a eles.

Repositórios públicos permitem que qualquer pessoa na internet os acesse, enquanto repositórios privados só podem ser acessados pelo dono do repositório e as pessoas que são adicionadas como colaboradoras do projeto.

Caso você não saiba o que é um colaborador em um projeto, não se preocupe. Mostraremos como isso funciona no GitHub mais adiante.

Nas contas gratuitas do GitHub existe uma condição para o uso de repositórios privados: a quantidade de pessoas colaboradoras em cada projeto é limitada a três. Para a inclusão de mais pessoas em repositórios privados, é preciso utilizar um plano pago ou manter a visibilidade como pública.

Caso queira se aprofundar mais no assunto, deixamos como recomendação a leitura das documentações a seguir:

[Sobre repositórios](https://docs.github.com/pt/repositories/creating-and-managing-repositories/about-repositories) - GitHub Docs

[Definir a visibilidade do repositório](https://docs.github.com/pt/repositories/managing-your-repositorys-settings-and-features/managing-repository-settings/setting-repository-visibility) - GitHub Docs

### Aula 1: Para saber mais: GitHub Student Developer Pack

Caso você seja estudante em uma instituição de ensino, você pode aproveitar os benefícios de uma conta Pro do GitHub (conta paga), além de acesso gratuito a diversas ferramentas pagas de desenvolvimento de software, através da licença para estudantes do GitHub (a GitHub Student Developer Pack).

Para obter essa licença, você precisará do seu e-mail institucional e do comprovante de matrícula. Depois, basta preencher o [formulário disponível no site GitHub Education](https://education.github.com/discount_requests/application) e aguardar a aprovação.

Para mais informações, você pode acessar o site do [GitHub Student Developer Pack.](https://education.github.com/pack?ref=producthunt)

### Aula 1: Instalando o Git - Vídeo 5

Transcrição  
Gabrielle: Já criamos nossa conta e o repositório. Agora, como faremos essa conexão do projeto com o repositório do GitHub que criamos? Existe um tutorial, mas onde e como executamos esses comandos?

Rodrigo: Nós já fizemos a parte do GitHub, criamos a conta e o repositório. Entretanto, o projeto está no VS Code. Baixamos o projeto, importamos no VS Code e, portanto, está local no nosso computador.

O que precisamos fazer é criar ligação entre o projeto que está no computador e o repositório do GitHub.

Diferença entre Git e GitHub  
Esse tutorial que apareceu após criar o repositório, é uma série de comandos que precisamos executar tanto para criar um novo repositório pela linha de comando ou fazer upload de repositório existente pela linha de comando.

São comandos, logo vamos precisar abrir o prompt de comandos do Windows.

Porém, já que estamos utilizando o Visual Studio Code, ele tem um terminal integrado. No menu superior do VS Code, clicamos na opção "Terminal > Novo terminal" (ou "Ctrl + Shift + '"). No canto inferior, é aberto o prompt de comandos.

Queremos rodar esses comandos por esse terminal integrado ao projeto. Quando abrimos o terminal pelo VS Code, ele já está na pasta do projeto aberto, que no nosso computador se chama C:\Users\Rodrigo\Desktop\numeros-secretos.

Precisamos rodar aqueles comandos na pasta do projeto. Vamos ao GitHub para copiá-los.

Se você ainda não tem um repositório local no seu computador, o GitHub fornece os seguintes comandos:

```bash
git init
git add README.md
echo "# numero-secreto" >> README.md
git init
git add README.md
git commit -m "first commit"
git branch -M main
git remote add origin https://github.com/rodrigoalura87/numero-secreto.git
git push -u origin main
```

Se você já tem um repositório existente local, outros comandos são sugeridos:

```bash
git remote add origin https://github.com/rodrigoalura87/numero-secreto.git
git branch -M main
git push -u origin main
```

O comando que começa com echo seria apenas se você quisesse criar um arquivo de exemplo do zero. Não é o nosso caso, já temos um projeto com arquivos. Então, vamos começar a partir do segundo passo.

Precisamos rodar esse comando git init. Vamos copiar esse comando com "Ctrl + C" e colar com "Ctrl + V" no terminal integrado. Vamos pressionar "Enter" e verificar o que acontece.

```bash
git init
```

git: O termo 'git' não é reconhecido como nome de cmdlet, função, arquivo de script ou programa operável. Verifique a grafia do nome ou, se um caminho tiver sido incluído, veja se o caminho está correto e tente novamente.

Gabi, não deu certo, deu um erro. Mas, o que aconteceu? Por que não funcionou?

Gabrielle: Esse erro está acontecendo porque precisamos instalar o Git no nosso computador.

Rodrigo: Exatamente, o Git é uma ferramenta que nos permite trabalhar com a parte de repositório e histórico. Mas, qual a diferença entre Git e GitHub?

Gabrielle: São ferramentas diferentes.

O GitHub é a plataforma onde vamos hospedar nosso código, enquanto o Git é a ferramenta onde conseguimos fazer o controle de versões do nosso código, registrar quais as mudanças foram feitas ao longo do tempo.

Rodrigo: São duas ferramentas separadas. O GitHub já conhecemos, e a partir de agora, precisaremos ter o Git instalado no computador. Ainda não temos essa ferramenta instalada, por isso que apareceu essa mensagem de erro.

Instalando o Git  
Rodrigo: Portanto, vamos baixar e instalar o Git no computador. No navegador, vamos abrir uma nova aba e pesquisar "git download" no mecanismo de busca. O primeiro link é a página de download do site do Git.

Na página de downloads, você deve escolher o seu sistema operacional. No nosso caso, vamos clicar na opção do Windows. Depois, devemos escolher o instalador para 32 ou 64 bits - no geral é 64 bits.

São oferecidas duas opções: o instalador standalone (sozinho) e portable (portátil). O portátil não instala no computador, e, sim, cria um executável que você executa no computador.

Vamos baixar a primeira opção standalone para Windows 64 bits, pois queremos instalar de fato no computador.

Em seguida, abre-se a tela de downloads. Dependendo da sua conexão, pode demorar um pouco. Ele vai baixar um arquivo, provavelmente .exe ou .msi, para fazer a instalação no Windows. No nosso caso, foi um .exe.

Após terminar, você vai até a pasta de downloads e clica duas vezes para abrir o arquivo .exe. Não se preocupe, não haverá vírus desde que você baixe do site oficial do Git.

Vamos clicar em "sim" para permitir que o aplicativo faça alterações no dispositivo. E então vamos para a instalação.

A instalação é bem direta. Basta clicar para avançar em "Next" até concluir a instalação com "Finish". São várias opções, mas não precisa se preocupar, manteremos todas as opções padrão.

Pode surgir um alerta avisando que já existe essa pasta e perguntado se desejamos sobrescrevê-la. No nosso caso, já tínhamos uma pasta chamada Git nos arquivos de programa, por isso, vamos permitir que ele a sobrescreva.

Agora o Git será instalado no sistema operacional, e, quando ele terminar, voltaremos ao Visual Studio Code, e aquele comando deveria funcionar, certo?

Assim que o Git finaliza a instalação, ele pergunta se queremos abrir um arquivo de notas de lançamento ou abrir o Git Bash, vamos desmarcar ambas opções. Apenas clicaremos em "Finish" para finalizar.

Configurando variáveis de ambiente  
Rodrigo: Vamos voltar para o terminal integrado do VS Code. Vamos rodar novamente o comando git init?

```bash
git init
```

git: O termo 'git' não é reconhecido como nome de cmdlet, função, arquivo de script ou programa operável. Verifique a grafia do nome ou, se um caminho tiver sido incluído, veja se o caminho está correto e tente novamente.

Mas, ele ainda não reconheceu. O que aconteceu? Como já tínhamos aberto esse terminal, ele não detectou que o Git foi instalado no computador. É preciso fechar essa janela do terminal, clicando no botão "Close panel" (fechar painel) no canto direito,

Novamente, vamos lá no menu superior em "Terminal > Novo terminal". O VS Code abre um novo prompt e agora deve pegar as novas instalações. Então, vamos rodar o git init.

E aí não funcionou novamente, Gabi. Isso acontece por causa do Windows. O Windows tem variáveis de ambiente que devemos configurar.

No Windows, vamos clicar no botão iniciar e buscar por "variáveis". Vamos escolher a opção "editar as variáveis de ambiente do sistema".

Na janela que se abre, vamos clicar no botão "Variáveis de Ambiente" e outra janela se abrirá com as variáveis do sistema operacional. Na parte de baixo, temos que procurar uma variável chamada Path.

Após selecioná-la, vamos clicar no botão "Editar" para abrir uma nova janela de edição. Essa variável Path tem o caminho dos programas que estão instalados no computador. Até existe um caminho para o Git definido como C:\Programs Files\Git\cmd.

Contudo, será que esse diretório está correto? Precisamos verificar.

Por isso, vamos abrir o explorador de arquivos e fazer o caminho C:\Programs Files\Git. Existe uma pasta cmd, que contém o aplicativo do Git. Na verdade, ele já adicionou a variável de ambiente, só que ainda não a reconheceu por algum motivo.

Talvez seja preciso fechar e abrir novamente o Visual Studio Code para ele detectar essa mudança.

Agora que verificamos que as variáveis estão configuradas, vamos fechar todas as janelas e fechar o Visual Studio Code.

Gabrielle: Caso no seu computador essa variável de ambiente não esteja configurada, você vai editar a variável de ambiente Path e adicionar o caminho para onde o seu Git está instalado.

Rodrigo: Perfeito. Vamos abrir o Visual Studio Code e também o terminal integrado. Vamos novamente rodar git init e dar "Enter".

Initialized empty Git repository in C:/Users/Rodrigo/Desktop/numero-secreto/.git/

Agora deu certo, pois ele mostrou a mensagem: "Repositório vazio do Git foi inicializado".

Dica: Quando for instalar o Git, verifique nas variáveis de ambiente se o caminho foi adicionado corretamente. Às vezes, não é adicionado. Nesse caso, você terá de colocar o caminho daquela pasta cmd do Git no seu computador.

E não basta apenas fechar o terminal integrado no Visual Studio Code. É necessário reiniciar o Visual Studio Code para detectar o Git.

Agora, Gabi, rodamos o primeiro comando. Na sequência, entenderemos quais são aqueles outros comandos, o que eles fazem.

### Aula 1: Para saber mais: git init

O comando git init deve ser utilizado para converter um diretório existente no computador, que geralmente é o diretório de algum projeto, em um repositório Git. No entanto, seu uso requer atenção e cuidado para evitar problemas indesejados. Vamos entender melhor o que o comando git init faz.

O que é o comando git init?  
Para que possamos realizar o controle de versão de um projeto, registrando as mudanças realizadas nele ao longo do tempo, devemos, primeiramente, transformar o diretório do projeto em um repositório Git. O comando git init é utilizado para esse objetivo, devendo ser executado apenas uma vez. Quando executado, ele configura o diretório atual para ser rastreado pelo Git, inicializando um repositório vazio.

Executando o comando git init  
Suponha que no seu computador exista um diretório chamado meu-projeto, que represente um projeto pessoal seu e que você deseja transformar em um repositório do Git. Para isso, você pode abrir esse diretório no VSCode, abrir uma janela do terminal e executar o comando git init. A saída será algo como:

Terminal do VSCode com o comando git init sendo executado no diretório "~/Projetos/alura/meu-projeto" e recebendo como saída a mensagem "Initialized empty Git repository in /home/rodrigo/Projetos/alura/meu-projeto/.git/"

Repare na imagem anterior que o comando git init foi executado no terminal do VSCode. Observe também que no terminal é indicado qual o diretório no qual o comando foi executado, que no exemplo foi em: ~/Projetos/alura/meu-projeto. É importante se atentar a isso, pois o comando git init transforma o diretório atual em um repositório do Git, logo ele deve ser executado dentro do diretório do projeto e não em outros diretórios do computador.

Ao executar o comando, note que a saída no terminal foi a mensagem Initialized empty Git repository in /home/rodrigo/Projetos/alura/meu-projeto/.git/. Essa mensagem indica que o comando foi executado corretamente e um repositório local do Git foi criado com sucesso nesse diretório. A partir desse ponto, já podemos trabalhar no projeto, adicionando arquivos, realizando modificações e registrando as mudanças no Git.

Cuidados com o comando git init  
Aprendemos que o comando git init serve para criar um novo repositório Git e por isso deve ser executado apenas uma única vez. Ou seja, se um diretório já for um repositório Git, não faz sentido rodar novamente o comando git init. Esse é um erro bastante comum de ser cometido.

Se você executar o comando git init em um diretório que já foi inicializado como um repositório Git, a seguinte mensagem será exibida:

> Reinitialized existing Git repository in /home/rodrigo/Projetos/alura/meu-projeto/.git/

Isso indica que o Git reinicializou um repositório já existente, ou seja, o comando git init foi executado em um diretório que já era um repositório Git.

Caso você tenha cometido esse equívoco, não precisa se preocupar, pois todo o histórico de mudanças e commits no projeto não será apagado. O Git detecta que o diretório já era um repositório Git e com isso o comando não tem efeito nenhum.

Na dúvida, antes de executar o comando git init, execute primeiramente o comando git status. Se aparecer a mensagem fatal: not a git repository (or any of the parent directories): .git, isso significa que o diretório atual não é um repositório Git e você pode então executar o comando git init.

### Aula 1: Para saber mais: Git vs. GitHub

É muito comum confundir Git e GitHub quando estamos começando no mundo da programação. Embora seus nomes sejam parecidos e eles trabalhem juntos, eles desempenham papéis completamente diferentes no desenvolvimento de software.

Então, vamos entender as distinções fundamentais.

O que é o Git, exatamente?  
O Git é uma ferramenta de controle de versão. Imagine que ele é uma "máquina do tempo" para o seu código. Ele roda localmente no seu computador e permite que você salve versões do seu projeto conforme ele evolui.

- Onde fica: No seu computador (local).  
- Função: Registrar alterações, criar ramificações (branches) para testar novas ideias e reverter erros.
- Interface: Geralmente utilizado via linha de comando (Terminal).

E o que é o GitHub?  
O GitHub é uma plataforma de hospedagem na nuvem que utiliza o Git. Ele funciona como uma "rede social" para programadores, onde você pode guardar seus projetos (repositórios) online e colaborar com outras pessoas.

Onde fica: Na internet (remoto).  
Função: Armazenar seus códigos de forma segura, permitir colaboração em equipe, revisão de código e gerenciamento de projetos.
Interface: Interface gráfica amigável acessada pelo navegador.
Resumindo...

|Característica|Git|GitHub|
|Natureza|Software instalado localmente.|Serviço baseado na nuvem.|
|Dependência|Funciona sozinho, sem internet.|Depende do Git para funcionar.|
|Foco|Gerenciamento de histórico de arquivos.|Compartilhamento e colaboração.|
|Competidores|SVN, Mercurial.|GitLab, Bitbucket.|

Pense no Git como o seu processador de texto (como o Microsoft Word), onde você escreve e edita seu arquivo localmente. O GitHub seria como o Google Drive ou Dropbox, onde você envia esse arquivo para que outras pessoas vejam, comentem e ajudem a editar.

Dica Pro: Você não precisa do GitHub para usar o Git, mas o GitHub torna o uso do Git muito mais poderoso para o trabalho em equipe e para construir seu portfólio profissional!

### Aula 1: Faça como eu fiz: instalação do Git

Agora é com você! Caso ainda não tenha o Git instalado em seu computador, faça o download e instalação conforme demonstrado no vídeo anterior.

Windows  
Para instalar o Git em seu computador, você deve acessar o site de downloads do Git. Em seguida, você deve clicar no botão referente ao seu sistema operacional. No nosso caso, clicamos em Windows.

Imagem com print da tela do site de downloads do Git. Em destaque ao redor de um retângulo vermelho se encontra botões de download correspondentes a cada sistema operacional, sendo eles macOS, Windows e Linux/Unix.

No site do Git será aberta uma lista com diversas opções de download. Vamos clicar na opção 64-bit Git for Windows Setup. Assim, baixamos um arquivo com a extensão .exe.

Imagem com print da lista de opções de downloads do Git para Windows. Existem opções para computadores 32 bits e 64 bits.

Você deve clicar no arquivo baixado para iniciar a instalação. Provavelmente uma janela será aberta perguntando se você deseja permitir que esse programa faça alterações em seu computador; caso esse cenário ocorra, você deve clicar em Sim para continuar.

Na janela de instalação, você deve prosseguir clicando nos botões de Next. Neste momento, não é necessário realizar nenhuma alteração nas configurações padrão da instalação do Git.

Imagem com print de tela de configuração da instalação do Git. Está em destaque com um retângulo vermelho o botão Next.

Após uma sequência de cliques no botão Next, você deve clicar no botão Install, para instalar o Git.

Imagem com print de tela da instalação do Git. Está em destaque com um retângulo vermelho o botão Install.

Por fim, clique no botão Finish.

Imagem com print da tela de finalização da instalação do Git. Está em destaque em um retângulo vermelho o botão finish.

Assim, o Git estará instalado em seu computador.

MacOS  
Existem várias opções para instalar o Git no macOS, mas o próprio git indica algumas soluções.

Ao clicar em macOS na página de download, você pode conferir a instalação.

O Homebrew é um gerenciador de pacotes para o macOS que simplifica a instalação de software.

Abra o Terminal e cole o comando que o site oferece para instalar o Homebrew.

Insira aqui a descrição dessa imagem para ajudar na acessibilidade

```bash
/bin/bash -c "$(curl -fsSL https://raw.githubusercontent.com/Homebrew/install/HEAD/install.sh)"
```

Pressione "Return" para executar o script. O Terminal pode solicitar que você insira sua senha. Digite sua senha e pressione "Return" novamente.

Após a conclusão da instalação, precisamos adicionar o brew no PATH. O terminal fornecerá instruções sobre como adicionar o diretório do Homebrew ao seu PATH. Normalmente, as instruções serão semelhantes a:

```bash
echo 'eval "$(/opt/homebrew/bin/brew shellenv)"' >> /Users/seu_usuario/.zprofile
'eval "$(/opt/homebrew/bin/brew shellenv)"'
```

Copie um de cada vez e execute no terminal.

Lembre-se de modificar o seu_usuario pelo seu nome de usuário!

Para garantir que o Homebrew foi instalado corretamente, digite o seguinte comando:

```bash
brew --version
```

Feche o Terminal, abra-o novamente e digite o seguinte comando para instalar o git:

```bash
$brew install git
```

Pressione "Return" para iniciar o processo de instalação.

Após a conclusão da instalação, verifique se o Git foi instalado corretamente usando o comando:

```bash
git --version
```

Pronto. Você concluiu a instalação do Git no macOS usando o Homebrew!

Linux  
A instalação do Git no Linux pode variar um pouco dependendo da distribuição que você está utilizando. No entanto, a maioria das distribuições Linux oferece o Git nos repositórios padrão, o que torna a instalação bastante simples.

Ubuntu e derivados do Debian  
Para instalar o Git no Ubuntu ou em distribuições baseadas em Debian, como o Debian em si, você pode usar o gerenciador de pacotes apt. Abra o terminal e execute o seguinte comando:

```bash
sudo apt install git
```

Fedora  
Para instalar o Git no Fedora, você pode usar o gerenciador de pacotes dnf. Abra o terminal e execute o seguinte comando:

```bash
sudo dnf install git
```

Arch Linux e derivados  
No Arch Linux e em distribuições baseadas nele, como Manjaro, você pode usar o pacman para instalar o Git. No terminal, execute o seguinte comando:

```bash
sudo pacman -S git
```

Após a conclusão da instalação, você pode verificar se o Git foi instalado corretamente digitando o seguinte comando no terminal:

```bash
git --version
```

Isso deve exibir a versão do Git que foi instalada.

### Aula 1: Sincronizando repositórios - Vídeo 6

Transcrição  
Gabrielle: Já instalamos o Git e inicializamos o repositório local com o comando git init. Mas agora, como podemos prosseguir para conectar esse repositório local ao repositório remoto no GitHub.

Rodrigo: Isso é muito importante. O Git possui esse conceito de repositório local e repositório remoto. Quando criamos o repositório no GitHub, o repositório que se encontra lá é denominado repositório remoto. No entanto, em nosso computador, também precisamos criar um repositório, que será o local.

Esses dois repositórios não estão conectados. Agora que instalamos o Git e criamos o repositório local, podemos seguir o tutorial que foi apresentado para estabelecer essa conexão entre o meu repositório local e o repositório remoto no GitHub.

Adicionar arquivos e vincular repositório  
Rodrigo: Vamos retornar ao site do GitHub. Já executamos o comando git init. O próximo comando que aparece no tutorial é git add, que mostra como exemplo um arquivo README.md que não possui existe no nosso projeto. Ao invés disso, precisamos adicionar os arquivos do nosso projeto.

Vamos copiar o comando git add e o colar no terminal integrado do VS Code. No entanto, precisamos adicionar cada um dos arquivos do projeto. Mas, temos vários arquivos neste projeto, como o app.js, index.html e outros. Precisaremos adicionar cada um manualmente?

Gabrielle: Temos a opção de adicionar manualmente, informando o nome de cada um dos arquivos, mas às vezes pode ser um pouco trabalhoso, especialmente quando temos um projeto grande com muitos arquivos.

Para facilitar esse processo, temos um atalho no comando do Git, onde podemos adicionar todos os arquivos de uma só vez. É o comando git add .. Esse ponto vai adicionar todos os arquivos do repositório.

```bash
git add .
```

Rodrigo: Após pressionar "Enter", apareceram alguns alertas, porque existem algumas diferenças entre Windows e Linux, dependendo do sistema operacional que você estiver utilizando. No entanto, são só alertas e não vão afetar nada.

Retornando ao GitHub, o próximo comando que encontramos é o git commit -m e temos que inserir uma mensagem entre aspas. Copiamos até o -m, porque vamos alterar a mensagem. Colocaremos a mensagem projeto inicial entre aspas duplas.

```bash
git commit -m "projeto inicial"
```

Estes comandos, add e commit, foram somente copiados e executados, mas nas próximas aulas, vamos explicar detalhadamente o que cada um faz. No momento, o objetivo é apenas conectar os dois repositórios: o local no computador com o remoto no GitHub.

Author identity unkown

Após pressionar "Enter", houve um erro ao tentar fazer o commit.

Gabrielle: Apareceu uma mensagem indicando que a identidade do autor desse commit é desconhecida. Precisamos fazer uma configuração para informar quem é a pessoa responsável por esse commit.

No terminal, é exibida uma dica indicando quais comandos devemos usar para fazer essa configuração:

```bash
git config --global user.email "your@example.com"
git config --global user.name "Your Name"
```

Rodrigo: No GitHub, criamos uma nova conta e fiz o login. Portanto, o GitHub sabe quem somos, porque estamos logados no navegador. No entanto, instalamos o Git no computador e o Git não sabe quem somos, pois não possui vínculo direto com o GitHub.

Esses comandos são justamente para nos identificar ao Git no computador.

Copiamos apenas comando git config --global user.email, mas só até email. Vamos colar no terminal e incluir o e-mail que configuramos no GitHub. No nosso caso, é o rodrigo.alura87@gmail.com entre aspas duplas.

```bash
git config --global user.email "rodrigo.alura87@gmail.com"
```

Atenção: Você deve substituir pelo e-mail usado para criar sua conta no GitHub!

Após pressionar "Enter", vamos utilizar a seta para cima para resgatar o último comando digitado. Alteraremos o user.email para user.name, pois além do e-mail, o Git também precisa saber o seu nome.

Entre as aspas, inserimos o Rodrigo Ferreira e apertamos "Enter". Você deverá colocar seu nome e sobrenome.

```bash
git config --global user.name "Rodrigo Ferreira"
```

Pronto. Realizamos a configuração de maneira global, devido a esse parâmetro --global. Agora, neste computador, qualquer repositório que criamos, o Git já nos reconhece.

Gabrielle: Agora, podemos prosseguir e tentar realizar esse commit.

Rodrigo: Vamos apertar novamente a seta para cima três vezes para voltar para o comando de commit e dar um "Enter". Agora o commit foi realizado.

[master (root-commit) 250c665] projeto inicial

10 files changed, 334 insertions (+)

Ele registrou esses arquivos no nosso repositório local. Ótimo, vamos voltar para o tutorial no GitHub.

O próximo comando, git branch -M main. Vamos copiar, colar e executar. Não deu nenhum alerta.

```bash
git branch -M main
```

E o próximo comando é o principal, pois é o comando que vai fazer o vínculo do repositório do GitHub com o meu repositório local, que é esse git remote add.

Gabrielle: Sim, após executar esse comando, vamos conseguir que esse repositório que temos localmente em nosso computador esteja conectado com esse repositório do GitHub.

Rodrigo: Vamos apenas fazer uma alteração, porque por padrão ele vem com o protocolo HTTPS. Mas acima, onde temos instruções para o Quick Setup (configuração rápida), tem um botão chamado "SSH". Se clicamos neste botão, o GitHub troca para o protocolo para o SSH.

Geralmente, o protocolo SSH é o mais recomendado para fazer esse ligação com o GitHub.

O comando git remote add origin já foi alterado, e agora a URL não está com http://. Ela está usando o formato SSH. Vamos copiar e colar no terminal integrado:

```bash
git remote add origin git@github.com:rodrigoalura87/numero-secreto.git
```

Lembre-se que a URL do GitHub vai variar de acordo com o nome do seu usuário e projeto!

Gerar chave SSH  
Por fim, temos o comando para enviar esses arquivos, ou seja, esse commit que fizemos localmente para o GitHub com o comando git push. O remote add não envia automaticamente, ele só faz a ligação.

```bash
git push -u origin main
```

Vamos copiar e colar esse último comando. Com isso, ele vai tentar sincronizar, de fato, com o GitHub. Vamos conferir se vai funcionar.

The authenticity of host 'GitHub.com (20.201.28.151)' can't be established

Deu outro erro! Foi um erro de autenticação. Afinal, instalamos o Git no computador, colocamos o e-mail e nome, mas como é que o GitHub vai saber que somos nós mesmos - e não é outra pessoa que está usando nosso nome e e-mail?

De alguma forma, precisamos fazer essa configuração de segurança para ele saber que neste computador, é, de fato, o Rodrigo com e-mail específico e está vinculado com a conta do Rodrigo no GitHub.

Como copiamos o protocolo SSH, o Git já nos dá a sugestão de gerar uma chave SSH no computador porque ainda não temos uma. Ele faz uma pergunta que precisamos responder com "sim" ou "não".

Are you sure you want to continue connecting (yes/no/[fingerprint])?

Em inglês, ele pergunta: quer continuar a conexão? Respondemos com um yes (sim). Feito isso, ele manda uma mensagem dizendo que não reconhece esse computador, portanto, não está autorizado para se conectar no GitHub.

Warning: Permanently added 'github.com' (ED25519) to the list of known hosts

git@github.com: Permission denied (publickey)

Isso é importante para garantir a segurança. Ou seja, vamos ter que fazer essa configuração no GitHub.

Gabrielle: Isso mesmo. Vamos ao GitHub finalizar essa configuração.

Rodrigo: Essas são configurações iniciais, pois como acabamos de instalar o Git, não tem nada disso configurado. Será apenas uma vez que precisamos fazer todos esses comandos.

De volta ao GitHub, no canto superior direito da página, vamos clicar no ícone do avatar para abrir o menu lateral e selecionar a opção "Settings". Assim, entraremos nas configurações da nossa conta e não do repositório.

Na página de configurações da nossa conta, no menu à esquerda, existe a opção "SSH and GPG keys" onde podemos fazer a configuração do SSH.

Em seguida, vamos clicar no botão verde "New SSH key" (nova chave SSH). Ao clicar nesse botão, devemos colocar um título. É como se estivéssemos criando uma chave para conectar esse nosso computador com o GitHub. Vamos colocar notebook pessoal, apenas para identificar que chave é essa.

Ele também solicita um tipo, nesse caso, é uma chave de autenticação (Authentication key). Além disso, nos orienta a colar a chave. Mas, de onde vamos conseguir essa chave, Gabi?

Gabrielle: Devemos gerar essa chave em nosso computador.

Rodrigo: Assim, no nosso computador, teremos que acessar essa chave que foi gerada com o SSH.

No terminal integrado, quando pressionamos "yes", ele deve ter criado uma chave que fica salva dentro do computador na pasta do usuário. Podemos tanto fazer isso pelo terminal ou navegar até a pasta, o que é mais fácil.

Portanto, vamos abrir o explorador de arquivos e entrar na pasta do usuário. Nesse casso, a pasta Rodrigo. Agora, vamos procurar uma pasta oculta chamada .ssh. Entrando nela, há um arquivo chamado known_hosts, que são os hosts conhecidos, mas a chave não foi gerada.

Para gerar a chave, existe um comando que temos que copiar. Inclusive, existe um tutorial no próprio site do GitHub, que vamos disponibilizar no curso como uma atividade. Ele tem um tutorial ensinando como gerar uma chave SSH para cada sistema operacional. No nosso caso, é o Windows.

Nessa documentação, temos a explicação do que é e como gerar uma chave SSH. Vamos copiar o comando sugerido ssh-keygen -t ed25519 -C seguido do e-mail da conta do GitHub.

No terminal do Visual Studio Code, vamos colá-lo. Porém, temos que alterar o e-mail de exemplo para o nosso e-mail, que é rodrigo.alura87@gmail.com. Você deve substituir com seu e-mail pessoal.

```bash
ssh-keygen -t ed25519 -C "rodrigo.alura87@gmail.com"
```

Após apertar "Enter", ele informa que vai gerar um par de chaves SSH. E nos pergunta onde queremos salvar esse arquivo.

Enter file in which to save the key (C:\User\Rodrigo/.ssh/id_ed25519):

Você pode simplesmente pressionar "Enter" para salvá-lo na própria pasta SSH, que é a pasta padrão. Ele pergunta se você quer digitar uma senha.

Enter passphrase (empty for no passphrase):

Se digitamos uma senha, toda vez que eu for sincronizar com o GitHub, ele vai nos pedir essa senha. Por isso, vamos apenas pressionar "Enter" para não ter uma senha. Depois, devemos digitar a mesma senha novamente, damos "Enter" novamente.

Pronto. Agora a chave foi gerada.

Vamos até a pasta "Rodrigo > .ssh". Agora, contém dois arquivo chamamos id_ed25519, um com a chave privada, outro com a chave pública. Devemos abrir o da chave pública, vamos conferir.

Vamos dar dois cliques e mandar abrir com o bloco de notas. Estava escrito private key, era a chave privada.

Vamos abrir o outro arquivo. Podemos clicar com o botão direito e selecionar "Abrir com" e escolher o aplicativo de bloco de notas. Agora, temos o código da chave começando com ssh ed-25519 que precisamos copiar e colar no site do GitHub.

No campo key, vamos colá-lo e apertar o botão "Add SSH Key" para adicionar a chave SSH. O GitHub já adicionou e listou a chave do notebook pessoal em "SSH keys".

Agora o GitHub sabe que neste notebook tem uma chave e já nos autenticamos, pois geramos essa chave com o nosso e-mail. Assim, o GitHub confia neste computador. Desse modo, conseguiremos sincronizar com a nossa conta no GitHub.

Sincronizar repositórios  
Rodrigo: Vamos voltar para o Visual Studio Code e tentar fazer novamente aquele git push:

```bash
git push -u origin main
```

Vamos conferir se agora vai funcionar.

```bash
Total 14 (delta 0), reused 0 (delta 0), pack-reused 0

To github.com: rodrigoalura87/numero-secreto.git

[new branch) main -> main
branch 'main' set up to track 'origin/main'.
```

Finalmente, o upload dos arquivos e do commit para o nosso repositório no GitHub foi bem-sucedido, ao que tudo indica. Será que está sincronizado, Gabi?

Gabrielle: Sim, aparentemente funcionou, mas vamos abrir nosso repositório no navegador e atualizar a página para verificar se encontramos nosso projeto lá?

Rodrigo: No navegador, precisamos voltar para a página do repositório. Basta clicar no ícone do avatar e acessar "Your repositories" (seus repositórios) e escolher o numero-secreto. Em seguida, vamos atualizar a página (atalho "F5") e o projeto apareceu.

O tutorial que estava antes sumiu, porque agora tudo já está sincronizado e os arquivos estão sincronizados no repositório remoto.

Temos o index.html, o app.js e o sistema identificou o commit e usuário, o rodrigoalura87. Podemos navegar pelos arquivos e ter acesso ao código-fonte.

Logo, nosso repositório está sincronizado e na barra de endereços temos a URL do repositório. No nosso caso, é github.com/rodrigoalura87/numero-secreto.

Podemos compartilhar esse link com outras pessoas e elas podem acessar o repositório, inclusive você, Gabi. Eu posso te enviar este repositório e fica aí essa pergunta: será que você conseguirá baixar o projeto no seu computador?

Gabrielle: O GitHub nos proporciona essa possibilidade de outras pessoas não apenas acessarem nosso código, mas também contribuírem para ele. Vamos explorar isso em seguida.

### Aula 1: Para saber mais: Chave SSH

O comando git push deve ser executado para sincronizar as mudanças do repositório local com o repositório remoto, ou seja, quando desejamos enviar os novos commits que realizamos em nosso repositório local para o repositório remoto. No entanto, para garantir uma conexão segura, é essencial configurar uma chave SSH no computador antes de executar esse comando.

Chave SSH  
Ao vincular um repositório remoto ao nosso repositório local, via comando git remote add, precisamos utilizar algum protocolo seguro, como HTTPS ou SSH. No caso de se utilizar o protocolo SSH, escolha realizada neste curso, devemos gerar uma chave SSH em nosso computador, além de cadastrá-la em nossa conta do GitHub. Isso é necessário para garantir a autenticação, pois o GitHub checa se quem está realizando o push dos commits tem permissão para realizar tal ação.

Geração de uma chave SSH  
Antes de executar o comando git push, precisamos gerar uma chave SSH. A geração da chave é feita via terminal, com o comando ssh-keygen -t ed25519 -C "SEU EMAIL AQUI":

Terminal do VSCode com o comando ssh-keygen -t ed25519 -C "fulano@email.com.br" sendo executado.

Repare, na imagem anterior, que ao executar o comando para gerar uma chave SSH, uma pergunta foi feita e o terminal fica travado esperando nossa resposta:

```bash
Generating public/private ed25519 key pair.
Enter file in which to save the key (/home/rodrigo/.ssh/id_ed25519):
```

Essa primeira pergunta é para indicarmos o diretório em nosso computador no qual a chave será salva, sendo que entre parênteses é indicado o diretório padrão. O recomendado é apenas apertar a tecla enter no teclado para que a chave seja salva no diretório padrão, pois assim o Git consegue encontrar essa chave automaticamente sempre que executarmos o comando git push.

Após apertar a tecla enter, uma nova pergunta será apresentada no terminal:

```bash
Enter passphrase (enter for no passphrase):
```

Essa segunda pergunta é para indicarmos se desejamos adicionar uma senha à chave SSH que será gerada. Caso você digite uma senha, toda vez que executar o comando git push será necessário digitar tal senha. Ao não digitar nada e apenas apertar a tecla enter, a chave será gerada sem a proteção de uma senha.

Por fim, a terceira e última pergunta é apenas para confirmar a senha anterior:

```bash
Enter same passphrase again:
```

A chave será gerada e a seguinte mensagem será exibida no terminal:

```bash
Your identification has been saved in /home/rodrigo/.ssh/id_ed25519
Your public key has been saved in /home/rodrigo/.ssh/id_ed25519.pub
The key fingerprint is:
SHA256:jxAkhGR7NHm/0fcmyPnErZxSKr+ObsH7r4AC/vUNvPY fulano@email.com.br
The key's randomart image is:
+--[ED25519 256]--+
| .oo=..          |
| ..o.+.          |
|  . .... .       |
|   .   .o . .    |
|  .   ..S+ = o   |
| . .   ++o+ = +  |
|  . . o =o.* =   |
|   . o .=*o =    |
|    .  +=*E=.    |
+----[SHA256]-----+
```

Na primeira linha da mensagem você consegue identificar o diretório no seu computador no qual a chave foi salva. Agora, basta acessar tal diretório para ter acesso à chave SSH.

Observação: Nesse diretório serão gerados dois arquivos que representam a chave SSH, sendo um para a chave privada (arquivo id_ed25519) e o outro para a chave pública (id_ed25519.pub).

Cadastrando a chave SSH no GitHub  
Após gerar a chave, precisamos cadastrá-la em nossa conta do GitHub, para que assim o GitHub consiga nos identificar e autenticar ao executar o comando git push de nosso computador.

Acesse a página de chaves SSH de sua conta no GitHub e clique no botão New SSH key ou Nova chave SSH para realizar o cadastro da chave:

Formulário para cadastro de chave SSH no site do GitHub, contendo os campos "title", "key type" e "key".

Repare que o formulário exibido na imagem anterior contém três campos:

- Title ou Título: Informe um apelido para sua chave SSH (por exemplo: computador casa)
- Key type ou Tipo de chave: Escolha o tipo Authentication Key ou Chave de autenticação
- Key ou Chave: Nesse campo você deve colar o conteúdo do arquivo da sua chave SSH pública (arquivo id_ed25519.pub)

Após realizar esse procedimento, será possível sincronizar o repositório local com o remoto, enviando os novos commits com o comando git push.

### Aula 1: Para saber mais: O comando git remote

Vimos no vídeo anterior que para fazer o link entre o repositório local, que está em nosso computador, com o repositório remoto, que está no GitHub, devemos utilizar o comando git remote.

Esse comando tem algumas variações e parâmetros opcionais que podem ser úteis em certas situações. Confira a seguir exemplos de uso desse comando:

1 - Adicionar um repositório remoto:

Quando você deseja estabelecer uma conexão entre seu repositório local e um repositório remoto, como aquele hospedado no GitHub, o comando git remote add é a ferramenta essencial. Essa etapa é crucial para possibilitar a colaboração e o compartilhamento de código com outras pessoas, bem como para fazer backup de seu trabalho em um servidor remoto.

A sintaxe básica do comando é a seguinte:

```bash
git remote add apelido url
```

'apelido': Este é um nome que você atribui ao repositório remoto. Geralmente, se utiliza nomes descritivos, como "origin" para o repositório principal no GitHub, mas você pode escolher nomes que façam sentido para o seu projeto.

'url': Aqui, você insere a URL do repositório remoto. Esta URL é única para cada repositório remoto e serve como o endereço para acessar e interagir com ele pela internet. Certifique-se de copiar a URL correta do repositório que deseja adicionar.

2 - Listar os repositórios remotos:

Para listar os repositórios remotos associados ao seu projeto local, você pode utilizar o comando git remote -v. Isso exibirá uma lista de todos os repositórios remotos vinculados ao seu projeto, juntamente com suas URLs. Veja um exemplo:

```bash
git remote -v
```

A saída será algo semelhante a:

```bash
origin   https://github.com/seu-usuario/seu-projeto.git (fetch)
origin   https://github.com/seu-usuario/seu-projeto.git (push)
```

Essa lista é útil para verificar se os repositórios remotos estão configurados corretamente. Obs: Vai aparecer duplicado mesmo, pois o Git separa a url de envio de commits (push) da url de baixar commits (fetch).

3 - Remover um repositório remoto:

Caso você não precise mais de um repositório remoto específico, pode removê-lo com o comando git remote remove apelido. Substitua 'apelido' pelo nome do repositório remoto que deseja remover. Aqui está um exemplo:

```bash
git remote remove origin
```

Após a execução deste comando, o repositório remoto chamado "origin" será desvinculado do seu projeto local.

4 - Alterar a URL de um repositório remoto:

Às vezes, é necessário atualizar a URL de um repositório remoto, como quando a URL do servidor do GitHub é modificada ou quando você copiou a URL incorreta ao adicionar o repositório remoto. Use o comando git remote set-url apelido nova_url para realizar essa atualização. Substitua 'apelido' pelo nome do repositório remoto e 'nova_url' pela nova URL que você deseja associar a ele. Aqui está um exemplo:

```bash
git remote set-url origin https://github.com/seu-usuario/seu-repositorio.git
```

Isso atualizará a URL do repositório remoto "origin" para a nova URL especificada.

5 - Alterar o apelido de um repositório remoto:

Se você deseja renomear um repositório remoto, use o comando git remote rename apelido novo_apelido. Substitua 'apelido' pelo nome atual do repositório remoto e 'novo_apelido' pelo novo nome que você deseja atribuir a ele. Aqui está um exemplo:

```bash
git remote rename origin novo-origin
```

Isso renomeará o repositório remoto de "origin" para "novo-origin".

Lembre-se de que o comando git remote é fundamental para a gestão de conexões entre seu repositório local e repositórios remotos, permitindo a colaboração eficiente e o controle de versão. Praticar esses comandos em seu ambiente de desenvolvimento ajudará a consolidar seu entendimento.

### Aula 1:  - Vídeo 9
### Aula 1:  - Vídeo 4
### Aula 1:  - Vídeo 4
### Aula 1:  - Vídeo 4
