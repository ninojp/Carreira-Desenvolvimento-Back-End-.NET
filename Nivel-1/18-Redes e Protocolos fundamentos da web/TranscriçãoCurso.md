# Curso Alura: Redes e Protocolos fundamentos da web

## Aula 1: Fundamentos de Redes e TCP/IP

### Aula 1: Apresentação - Vídeo 1

Transcrição  
Olá! Meu nome é Leonardo e estarei acompanhando vocês neste curso de redes e introdução à parte da infraestrutura da web.

Audiodescrição: Leonardo é um homem pardo, com cabelo e barba escuros, usa óculos retangulares pretos e veste uma camisa polo marrom. Ao fundo, há uma iluminação com leds azuis e alguns detalhes quadriculados.

Explorando a infraestrutura da web  
Neste curso, vamos aprender como funciona toda a parte da internet e os mecanismos que nos permitem construir aplicações web. Primeiramente, vamos entender como funciona a infraestrutura da web. Exploraremos os protocolos e compreenderemos como uma mensagem chega do nosso navegador até o servidor de qualquer outra aplicação, seja o Google, Netflix ou Spotify. Em seguida, vamos nos aprofundar no principal protocolo utilizado para criar aplicações web, que é o protocolo HTTP.

Depois, vamos entender quais são os métodos que o protocolo exige e as características necessárias para escrever uma mensagem que atenda a esse protocolo. Entraremos em detalhes sobre como o protocolo opera, principalmente em relação à armazenagem e segurança de dados dentro do protocolo e da internet de forma geral.

Discutindo ferramentas e suporte para desenvolvimento web  
Falaremos também sobre a infraestrutura da web, ou seja, algumas ferramentas, empresas e produtos que nos ajudam a construir aplicações web. Isso inclui não apenas a hospedagem de aplicações, mas também o desenvolvimento, acompanhamento, depuração, teste e viabilização das aplicações que podemos criar nesse modelo, quando pensamos na internet.

Além dos vídeos, temos uma série de atividades que podemos realizar. Caso surjam dúvidas, há o fórum da plataforma e o grupo do Discord, onde podemos consultar informações que possam nos ajudar.

Iniciando o estudo de aplicações web  
Vamos começar mais uma parte do entendimento de como funciona toda essa dinâmica de construção de aplicações, agora voltada para aplicações web.

### Aula 1: Introdução às redes - Vídeo 2

Transcrição  
Agora que já passamos pelo desenvolvimento de aplicações como o Soli e entendemos como a parte web é estruturada com HTML, CSS e JavaScript, surge a dúvida: como podemos compartilhar nossa aplicação para que o mundo todo possa utilizá-la? Até o momento, conseguimos testar nossas aplicações localmente e verificar como elas funcionam dentro do nosso computador. No entanto, para disponibilizá-las mundialmente, precisamos de mecanismos que permitam o compartilhamento do programa que criamos. Um dos modelos mais comumente usados para essa distribuição é a internet e o desenvolvimento de aplicações web.

A programação é uma parte fundamental da web, especialmente no que diz respeito ao desenvolvimento do back-end. Para compartilhar isso globalmente, utilizamos os mecanismos da internet e a infraestrutura global da web. Vamos entender como a web funciona de maneira abrangente. A partir de agora, exploraremos os mecanismos que fazem a internet funcionar como ela é. Usaremos o exemplo comum de acessar uma URL pelo navegador. Quando digitamos um site na barra de endereços, enviamos uma solicitação ao navegador para acessar um determinado site. O navegador, que possui um cliente HTTP, envia essa solicitação pela internet, passando por diversos intermediários até chegar ao servidor da página, como o Google, por exemplo.

Explicando o funcionamento das solicitações na web  
Os servidores da web entendem essa solicitação, procuram o site ou página solicitada e, uma vez encontrada, devolvem uma resposta. Essa resposta é processada pelo navegador, que exibe o conteúdo, podendo ser HTML, PDF, imagem, ou JSON. Não estamos limitados apenas a HTML, CSS e JavaScript; existem diversos tipos de dados que podemos receber. Esse é o mecanismo que compõe todas as etapas de uma solicitação comum na web ao digitarmos um endereço de site na barra de endereços. Precisamos entender como esses mecanismos permitem que tenhamos uma infraestrutura capaz de realizar solicitações e obter respostas.

A internet surgiu como um projeto colaborativo entre universidades, com o objetivo de compartilhar rapidamente trabalhos realizados em laboratórios e centros de pesquisa. Isso só seria possível com uma rede global de dispositivos interconectados. Para comunicar-se entre o Brasil e universidades nos EUA, Europa ou Ásia, era necessário ter dispositivos espalhados pelo mundo, servindo como intermediários entre pontos distantes. Assim como um avião faz paradas em sua rota, a internet também possui pontos de parada para que a informação chegue de um ponto a outro.

Comparando LAN e WAN  
Para disponibilizar recursos, era necessário uma linguagem comum, que conseguimos através dos protocolos. A internet é um modelo global de compartilhamento de recursos, mas existem redes menores, como a LAN, que são usadas em empresas ou no cotidiano para permitir o compartilhamento de recursos de forma controlada. A LAN é um modelo local, como um interfone em um prédio, enquanto a WAN é mais abrangente, como um telefone comum que permite ligações nacionais sem a necessidade de um DDI.

A diferença entre LAN e WAN está na abrangência geográfica e no controle de acesso à informação. A LAN é restrita a um estabelecimento ou alguns andares de um prédio, enquanto a WAN pode abranger uma empresa com várias filiais, permitindo o compartilhamento de informações internas. A internet, por sua vez, é um modelo mundial de compartilhamento interconectado entre dispositivos.

Discutindo o acesso público e privado na internet  
Além disso, a LAN é considerada privada, sem acesso externo, enquanto a WAN pode ter dados públicos ou privados. A internet, por ser global, permite o compartilhamento de informações públicas e privadas, dependendo da configuração de acesso.

Um exemplo de uma WAN pode ser pública ou privada. Consideremos uma universidade que deseja disponibilizar algumas informações, como o calendário escolar. Essa informação pode ser pública, permitindo que qualquer pessoa acesse o calendário. No entanto, informações como notas são mais privadas e, nesse cenário, provavelmente desejamos mantê-las internas. Assim, podemos configurar a rede para que apenas aqueles conectados à rede local da universidade possam acessar certas páginas, enquanto outras informações ficam disponíveis na rede pública. A universidade pode usar a mesma infraestrutura da internet para transmitir informações públicas, enquanto as informações privadas são acessíveis apenas localmente, em alguns polos da universidade, para acessar recursos como notas ou faltas.

Explorando as características de LAN, WAN e internet  
A internet, por padrão, é pública e não possui restrições nativas de acesso. Todos os mecanismos que permitem um acesso mais restrito são implementados por meio de aplicações. Para acessar um recurso específico, basta conhecer o endereço e, dependendo da aplicação, um login pode ser necessário. A questão de público e privado nas redes se dá pelo acesso. LANs e WANs tendem a ser restritas, permitindo acesso apenas a quem está dentro da rede. Na LAN, todos os conectados têm acesso aos recursos, e o mesmo vale para a WAN, geralmente voltada para uma instituição.

A internet é aberta, permitindo que qualquer pessoa que conheça a URL acesse o recurso, seja uma página web ou uma foto, sem restrições de acesso. Por isso, quando estamos na internet, estamos em um ambiente aberto, sem restrições de acesso, a menos que a aplicação tenha particularidades. LANs e WANs, por serem redes mais controladas, são geralmente mais rápidas que a internet. Em uma LAN, o tráfego é local e rápido, funcionando quase instantaneamente. Já a internet pode ter várias etapas de comunicação, o que pode afetar a velocidade.

Analisando latência, custo e confiabilidade  
A latência, ou tempo de resposta, é uma característica importante. Na internet, a latência pode ser alta devido ao tempo de requisição até o servidor e a resposta. Quando uma página é carregada novamente, o cache do navegador torna o processo mais rápido, semelhante a uma LAN, onde a latência é baixa. A WAN pode ter variações de velocidade dependendo dos locais.

O custo é outro fator a considerar. Implementar uma LAN tem um custo baixo, enquanto a internet e a WAN têm custos mais altos devido à infraestrutura necessária. A internet funciona globalmente porque os países compartilham os custos operacionais, desde redes locais até cabos submarinos.

A confiabilidade é alta em LANs, com poucas interferências na comunicação. Em WANs, a confiabilidade pode variar devido a fatores regionais. A internet, sendo compartilhada, tem várias etapas intermediárias que podem afetar a confiabilidade, dependendo do local de acesso e dos intermediários envolvidos.

Concluindo a compreensão dos mecanismos da internet  
A internet é vasta e entender todos os seus mecanismos não é trivial. Existem muitas etapas e divisões que nos ajudam a compreender seu funcionamento. Já abordamos como a internet funciona de maneira abrangente, os tipos principais de redes (internet, LAN e WAN) e suas diferenças. Agora, vamos explorar como elas se comunicam por meio de protocolos que permitem o acesso a recursos em diferentes locais.

### Aula 1: Protocolo TCP/IP - Vídeo 3

Transcrição  
Agora que já passamos por uma visão geral sobre o funcionamento da infraestrutura da internet, é importante entendermos como a comunicação entre o navegador e outros serviços da internet ocorre. Para isso, é necessário que uma linguagem comum entre todas as partes da infraestrutura da internet seja estabelecida, garantindo que essa comunicação seja eficiente. Isso é o que chamamos de protocolos quando falamos de internet.

O protocolo talvez mais importante que utilizamos atualmente para nos comunicarmos e usarmos boa parte dos serviços da internet é o protocolo TCP/IP. Ele abrange uma série de camadas dentro da internet, permitindo que cada uma dessas camadas tenha as particularidades do envio de uma mensagem, possibilitando que consigamos acessar informações na internet. Vamos entender então como o protocolo TCP/IP funciona.

Explorando as camadas do protocolo TCP/IP  
Devemos compreender que o protocolo TCP/IP opera com uma série de camadas que, juntas, compõem o protocolo inteiro. A primeira camada, ou a camada mais alta do protocolo, é a camada de aplicação, que é basicamente a transmissão da informação que queremos compartilhar. Dentro do protocolo TCP/IP, na camada de aplicação, temos protocolos dentro de outros, como o protocolo HTTP.

Vamos entender melhor como funciona essa parte do HTTP, pelo menos de uma maneira mais geral, para vermos como ele está dentro da parte do TCP. O que seria a camada de aplicação quando falamos do TCP/IP? Vamos considerar o nosso navegador. Quando precisamos digitar um endereço, por exemplo, o endereço da Alura, digitamos no Google "Alura" e clicamos no link. Mesmo que o link mostre apenas "alura.com.br", se formos com a seta na barra de endereços do navegador até o início, conseguimos ver "HTTPS". Ou seja, dentro do navegador, para fazermos a transmissão de uma página web, utilizamos o HTTP na camada de aplicação.

Inspecionando a comunicação HTTP  
Se inspecionarmos essa página e acessarmos a parte de rede, ao atualizar a página, conseguimos ver todos os pacotes que serão transferidos. Observamos uma série de pacotes, incluindo imagens, GIFs, sons, se necessário, e links. Há uma transmissão significativa de informação. No primeiro item, que é a atualização da página, verificamos que a requisição foi feita através do HTTPS, que foi a página que acessamos para obter a informação da página HTML da Alura. Nesse exemplo, temos um exemplo claro da camada de aplicação do TCP/IP, que opera sobre o HTTP.

Embora pareça haver muita informação, não se preocupe. Vamos detalhar todas as particularidades da parte do HTTP, pois além do TCP, essa pequena parte do protocolo inteiro, que é o HTTP, é fundamental para entendermos como funcionam aplicações web. Isso será explicado posteriormente.

Compreendendo a camada de transporte  
Continuando com as camadas do TCP/IP, vamos para a camada de transporte, que é a camada anterior à do HTTP. Ela gerencia a transmissão de dados utilizando outros dois protocolos possíveis: o TCP e o UDP. Não devemos confundir TCP/IP com TCP. Muitas vezes, há uma confusão inicial que leva a crer que os dois são a mesma coisa, mas não são. TCP/IP é todo esse conjunto que abrange todas as camadas de comunicação da internet com as quais trabalhamos. Dentro do TCP/IP, temos a camada de transporte que pode transferir informações por TCP ou UDP. Portanto, TCP/IP e TCP são coisas diferentes.

Explorando ferramentas de rede no Windows  
Agora, vamos olhar para uma questão mais interna do computador e entender como o próprio sistema operacional do Windows possui ferramentas que nos permitem verificar algumas questões da rede do nosso computador. Por exemplo, se quisermos verificar usando o TCP, já que vimos a camada de aplicação, não precisamos ver o HTTP no momento. Vamos focar apenas no TCP. Para testar o TCP no Windows, podemos digitar no terminal telnet alura.com.br e pressionar "Enter". Ele se conectará com o ambiente da Alura, e o comando que inserimos desaparecerá.

> telnet alura.com.br

Ao pressionarmos "Ctrl+C" e interrompermos a conexão, o sistema indicará que a conexão foi fechada. Ele apresentará um resultado, mostrando que tentamos nos conectar a outro servidor, exibindo ainda o HTTP utilizado, incluindo a versão. Essa tentativa foi feita por meio de uma conexão TCP, que é o telnet. Assim, conseguimos observar o uso de duas partes da camada do TCP/IP: a camada TCP, quando solicitamos o telnet, e a camada de aplicação, que nos devolveu o HTTP.

Utilizando o comando curl para visualizar a camada de aplicação  
Vamos agora explorar como visualizar a camada de aplicação do TCP/IP diretamente pelo terminal. Ao digitar o comando curl, que é um comando do Windows, podemos utilizá-lo como um cliente HTTP para consumir informações da internet via protocolo HTTP. Utilizamos a opção "-v" para tornar a informação mais descritiva, caso contrário, ele informará apenas o geral da requisição. Ao inserir https://alura.com.br, ele apresenta toda a questão da conexão com o site da Alura e todos os parâmetros necessários para essa conexão.

> curl -v https://alura.com.br

Posteriormente, entenderemos várias das informações apresentadas. Algumas delas já podemos verificar, como a apresentação do HTTP na versão 1.1. Veremos também outras versões do HTTP. Ele também mostra o host que estamos tentando acessar, que é o alura.com.br.

Analisando as camadas de rede e interface de rede  
Agora, vamos analisar as outras camadas que compõem o TCP/IP. Após a camada de transporte, passamos para a camada de rede. A camada de rede é responsável pelo roteamento, identificando o caminho necessário para alcançar o destino desejado. Funciona como um GPS da internet, ajudando a determinar a rota que a comunicação deve seguir.

Por último, temos a camada de interface de rede, que lida com a transmissão elétrica dos sinais necessários para a comunicação. Essa parte está mais próxima da engenharia elétrica e dos componentes que compõem a internet. A comunicação nessa camada é feita principalmente por meio de um endereço, que entenderemos melhor mais adiante, conhecido como MAC address.

No computador, ao digitar ipconfig /all, podemos visualizar todas as informações da rede, tanto local quanto da internet. Um campo específico para a camada física do TCP/IP é o endereço físico, que é um código alfanumérico vinculado ao hardware do computador. Cada dispositivo que utiliza a internet, como computadores, roteadores, celulares, modems, ou consoles de videogame, possui esse endereço físico, que é reconhecido pelo protocolo TCP/IP.

> ipconfig /all

Concluindo a visão geral do protocolo TCP/IP  
Com isso, já temos uma visão geral de como funciona o protocolo TCP/IP. É importante entender as características de algumas dessas camadas para manipular adequadamente as informações, fazer pedidos corretos e interpretar as respostas recebidas. A partir daqui, vamos explorar a camada de transporte e entender as diferenças entre TCP e UDP. É essencial saber diferenciar o que cada um faz, pois existem duas opções dentro da camada de transporte. Começaremos a ver essas diferenças entre TCP e UDP.

### Aula 1: Entendendo a comunicação entre navegador e servidor no e-commerce - Exercício

A UseDev, um e-commerce especializado na venda de produtos geeks, está enfrentando dificuldades com a lentidão no carregamento de suas páginas, o que está afetando a experiência da pessoa usuária e, consequentemente, as vendas. A equipe de desenvolvimento que você faz parte foi contratada para investigar e resolver esse problema. Durante a análise, foi observado que a comunicação entre o navegador das pessoas clientes e o servidor da UseDev pode estar comprometida.

Considerando o funcionamento dos protocolos de internet, como o TCP/IP e o HTTP, qual das alternativas abaixo melhor explica a importância desses protocolos para garantir uma comunicação eficiente e como eles podem estar impactando o desempenho do site da UseDev?

Alternativa correta  
Os protocolos TCP/IP e HTTP são fundamentais para a comunicação eficiente entre o navegador da pessoa usuária e o servidor do e-commerce. O TCP/IP garante a transmissão confiável e ordenada dos dados, enquanto o HTTP permite a transferência de páginas web. Problemas na configuração, como latência no TCP ou má configuração de cache no HTTP, podem causar lentidão. A equipe deve otimizar o uso de cache HTTP e garantir a eficiência do TCP para minimizar a latência.

> Correta, pois esta alternativa descreve com precisão como os protocolos TCP/IP e HTTP funcionam e como problemas em suas configurações podem impactar negativamente o desempenho do site, além de sugerir soluções adequadas.

### Aula 1: Para saber mais: comandos bash para entender o protocolo TCP/IP

O TCP/IP é a base da comunicação em redes modernas, incluindo a internet. Ele é formado por uma pilha de protocolos que garante desde a identificação de dispositivos até a entrega confiável de pacotes de dados. Para estudar e entender como o TCP/IP funciona na prática, o Linux e o Bash oferecem diversos comandos que permitem inspecionar conexões, interfaces e fluxos de rede.

Principais comandos

**ifconfig ou ip addr**  
Exibe informações sobre interfaces de rede, endereços IP atribuídos e status da conexão.
Exemplo:

> ip addr show

**ping**  
Testa a conectividade entre o host local e outro dispositivo, usando o protocolo ICMP.
Exemplo:

> ping google.com

**traceroute**  
Mostra o caminho percorrido pelos pacotes até um destino, revelando cada roteador intermediário.
Exemplo:

> traceroute google.com

**netstat ou ss**  
Exibe conexões ativas, portas abertas e estatísticas de rede. O ss é mais moderno e recomendado.
Exemplo:

> ss -tulnp

**tcpdump**  
Captura pacotes em tempo real, permitindo analisar tráfego detalhado no nível TCP/IP.
Exemplo (capturando pacotes na porta 80):

> sudo tcpdump -i any port 80

**curl**  
Realiza requisições HTTP/HTTPS e pode ser usado para inspecionar cabeçalhos e verificar protocolos.
Exemplo:

> curl -I `https://www.example.com`

**nmap**  
Scanner de rede usado para descobrir hosts ativos e verificar portas abertas.
Exemplo:

> nmap -Pn 192.168.1.1

Referências

- [Guia da GNU/Linux iproute2](https://man7.org/linux/man-pages/man8/ip.8.html) (substituto do ifconfig).
- [Manual do tcpdump](https://www.tcpdump.org/manpages/tcpdump.1.html).
- [Documentação do ss/netstat](https://man7.org/linux/man-pages/man8/ss.8.html).
- [Projeto nmap](https://nmap.org).
- [Tutorial de redes Linux no DigitalOcean](https://www.digitalocean.com/community/tutorials).

### Aula 1: TCP vs. UDP - Vídeo 4

Transcrição  
Agora que já vimos o protocolo TCP/IP, é importante que entendamos melhor a camada de transporte do TCP/IP, que envolve a diferença entre TCP e UDP. A principal diferença entre TCP e UDP é que, apesar de ambos fazerem parte da camada de transporte do TCP/IP, eles possuem características distintas.

Explicando o funcionamento do TCP  
Primeiramente, o TCP/IP estabelece uma conexão e garante que a entrega dos pacotes seja ordenada. Isso significa que, para receber uma informação via TCP, é necessário que ela seja enviada na sequência correta. Caso contrário, pode haver perda de pacotes e corrupção da informação recebida. O TCP detecta e corrige erros caso algum problema ocorra durante a transmissão. Isso assegura que, ao receber uma informação através do TCP, ela tenha passado por correções de erros, caso haja interferências na comunicação e transferência.

Para que tipo de aplicação utilizamos o TCP? Principalmente em aplicações web tradicionais. Quando falamos de páginas web, imagens, textos e arquivos, geralmente esses pacotes são transferidos via TCP. Isso ocorre porque, se houver um problema, como um JavaScript não carregado adequadamente, a página pode quebrar. Precisamos garantir que todos os componentes de uma página web sejam transferidos de maneira integral, correta e ordenada. Às vezes, é necessário que o HTML seja enviado primeiro para que o JavaScript possa dinamizar a página. A ordem correta dos pacotes é crucial para evitar que a página web fique quebrada, como quando um CSS é recebido antes do HTML e não consegue aplicar os estilos, ou quando o JavaScript tenta renderizar algo em uma página que ainda não foi carregada.

Descrevendo o funcionamento do UDP  
Por outro lado, o UDP funciona de maneira diferente. No caso do UDP, não há estabelecimento de conexão, o que significa que a entrega não é ordenada. Podemos receber pacotes de maneira totalmente assíncrona, sem controle sobre a ordem de recebimento. Isso impede a detecção e correção de erros durante as transferências. Se houver perda de pacotes, não é possível corrigi-los durante a transferência.

A comunicação via protocolo UDP é frequentemente utilizada em jogos online ou em streamings de informação. Por exemplo, ao assistirmos vídeos em plataformas como Netflix ou YouTube, ocorre uma transferência de dados em vídeo. Se perdermos um dos pacotes durante essa transferência, isso não representa um problema significativo. É comum que, ocasionalmente, uma legenda não apareça porque o pacote correspondente não foi recebido, ou que uma pequena parte da imagem apresente falhas momentâneas, mas depois retorne ao normal.

Comparando o impacto da perda de pacotes em TCP e UDP  
Também observamos variações na qualidade do vídeo devido a picos de tráfego. Por exemplo, ao assistir um vídeo, a qualidade pode subitamente diminuir. Em situações em que o vídeo começa a tremer, mas não cai completamente, isso ocorre porque o UDP permite a continuidade da transmissão, mesmo com a perda de alguns pacotes. Esses pacotes perdidos são considerados indiferentes para mantermos a comunicação adequada da informação. Assim, ao assistirmos um filme, mesmo que haja pequenos problemas na imagem ou no som, continuamos assistindo com os pacotes restantes sendo entregues corretamente.

No caso do TCP, a situação é diferente. Com o TCP, é necessário que a informação seja entregue corretamente. Em jogos online, o princípio é semelhante. Em jogos que exigem transferência rápida de informações, como Fortnite, é comum que jogadores com conexão de internet instável experimentem travamentos no cenário. Isso ocorre porque a transferência de dados via UDP não está sendo eficiente, mas o jogador ainda consegue participar do jogo. Se a conexão se deteriorar a ponto de impedir a continuidade do jogo, o jogador é desconectado da sala e perde a fase. Isso acontece porque o UDP aceita a transferência de dados até um limite de perda de pacotes, além do qual a conexão é interrompida.

### Aula 1: Analisando a camada de transporte em uma loja de livros

Na loja Meu Pequeno Grimório, especializada em livros de literatura fantástica e esotérica, a equipe de TI está desenvolvendo um sistema de recomendação de livros baseado no histórico de navegação dos clientes. Durante os testes, foi identificado que algumas requisições de dados estão falhando, e a equipe suspeita que o problema esteja na camada de transporte do protocolo TCP/IP.

Qual das alternativas abaixo melhor explica a função da camada de transporte e a diferença entre os protocolos TCP e UDP, e como isso pode estar afetando a comunicação no sistema de recomendação da loja?

Resposta correta  
A camada de transporte do protocolo TCP/IP é responsável por gerenciar a transmissão de dados entre dispositivos na rede. O protocolo TCP garante a entrega confiável e ordenada dos dados, enquanto o UDP é mais rápido, mas não garante a entrega ou a ordem dos pacotes. No contexto do sistema de recomendação da loja, se as requisições de dados estão falhando, pode ser que o sistema esteja utilizando o UDP, que não garante a entrega dos pacotes, ou que haja problemas na configuração do TCP, como congestionamento ou perda de pacotes. A equipe deve verificar se o protocolo correto está sendo utilizado e otimizar a configuração do TCP para garantir a entrega confiável dos dados necessários para o sistema de recomendação.

> Correta, pois descreve com precisão as funções da camada de transporte e as características dos protocolos TCP e UDP, além de identificar como esses fatores podem impactar a comunicação no sistema de recomendação da loja.

### Aula 1: Endereços IP - Vídeo 5

Transcrição  
Agora que já compreendemos como funciona a parte de transporte e como a viagem de dados ocorre para buscar informações na internet, vamos entender mais sobre endereçamento. Se pensarmos no mundo real, como no envio de pacotes quando compramos algo online, é necessário definir um endereço para que os correios saibam como chegar ao destino. Isso também se aplica à internet, onde temos um sistema de endereçamento que permite registrar e identificar o endereço de uma máquina ou aplicação.

Já vimos um pouco sobre o endereço físico, que está vinculado a cada computador e hardware. Agora, vamos explorar o endereçamento IP, que está relacionado ao protocolo TCP e à identificação de máquinas e aplicações na parte de software. O endereçamento IP é um sistema que cria um valor específico, permitindo identificar um computador ou aplicação dentro de uma rede. Isso é válido para redes locais (LANs) ou dispositivos conectados ao Wi-Fi, como quando imprimimos uma página na impressora através do computador, mesmo sem internet.

Explorando o funcionamento do endereço IP  
O endereço IP funciona como um endereço residencial. Por exemplo, o número 104.26.0.70 é um IP. Para saber o IP de um computador, os sistemas têm maneiras de reconhecer esses números. Ao digitar o seguinte comando no terminal, podemos identificar o IP de um site:

> ping alura.com.br

Esse comando ping utiliza o IP para localizar o endereço, semelhante a um CEP, e verificar se o endereço está correto.

Entendendo o papel das portas na comunicação  
Após entender o endereço IP, vamos para a parte de portas. As portas ajudam a identificar o tipo de protocolo e a resposta esperada. Cada aplicação funciona em portas diferentes, com numerações específicas e padrões. Existem entre 0 a 65 mil portas, algumas reservadas para funções específicas. Exemplos incluem a porta HTTP (80) e HTTPS (443) para aplicações web, a porta 25 para e-mails via SMTP, e a porta DNS para endereçamento de URLs.

O endereço completo inclui o IP e a porta utilizada. No terminal, podemos usar comandos para verificar endereços. Por exemplo, para ver todas as conexões TCP estabilizadas pelo HTTPS, podemos usar:

> netstat -an | findstr :443

E para verificar as conexões na porta HTTP, utilizamos:

> netstat -an | findstr :80

Esses comandos mostram os IPs conectados e seus estados. Ao usar outra porta, como a 80, vemos uma gama diferente de endereços, incluindo endereços locais como 0.0.0.0 e 127.0.0.1, que são vinculados ao nosso computador.

Mapeando rotas com comandos de terminal  
Por fim, vamos explorar alguns comandos do Windows para entender melhor o endereçamento e como mapear o caminho até um endereço de destino. Podemos utilizar o terminal para digitar:

> tracert -h 60 alura.com.br

Nesse cenário, o comando começa a mapear toda a infraestrutura da internet, funcionando quase como um GPS. Ele identifica cada rota ou endereço de IP necessário para chegar ao destino, que neste caso é o endereço da Alura. Assim, conseguimos visualizar toda a infraestrutura e os dispositivos envolvidos no rastreamento até o destino.

Esse procedimento também é aplicável a endereços fora do Brasil. Por exemplo, ao digitar:

> tracert -h 60 amazon.es

Observamos que o número de IP é completamente diferente do da Alura, pois está vinculado à Espanha. O caminho necessário para chegar ao endereço da Amazon na Espanha é diferente, passando por rotas distintas. Em alguns momentos, algumas rotas podem estar obstruídas, resultando em um tempo limite esgotado. Isso indica que houve uma tentativa de alcançar o endereço, mas não foi possível devido a alguma obstrução, como problemas de rede. Nesses casos, o sistema tenta encontrar um desvio nas rotas disponíveis na internet até chegar ao site da Amazon na Espanha.

Explorando o conceito de sockets e a transição para IPv6  
Passando para a parte de sockets, é importante entender que um socket é a combinação entre um endereço de IP e uma porta. Existem rastreamentos que dependem de uma porta específica e outros que não exigem a especificação da porta. É importante saber que existem ambas as possibilidades, pois podemos ter o mesmo endereço de IP, mas com portas diferentes para acessar aplicações distintas.

Ao falar de endereços de IP, estamos nos referindo ao IPv4. O IPv4 é uma faixa de IPs, ou seja, um conjunto de números de IPs que podem ser registrados na internet. Atualmente, o IPv4 possui um formato de 32 bits, utilizado para criar os endereços de IP mencionados anteriormente. Isso resulta em aproximadamente 4 bilhões de endereços de IP disponíveis na internet. Embora pareça um número grande, não é suficiente para atender à demanda atual. Por isso, está em andamento uma transição para o IPv6, que possui 128 bits e comporta muito mais opções do que os 4,3 bilhões do IPv4.

Essa transição é semelhante à inclusão do número 9 nos números de telefone, que foi necessária para aumentar a quantidade de números disponíveis. O mesmo ocorre com a internet, onde o número de IPs disponíveis não é suficiente para atender à demanda atual de dispositivos. No momento, o IPv4 ainda atende às necessidades, mas, caso não seja mais suficiente, o IPv6 estará disponível como alternativa.

Visualizando o uso do IPv4 e a resolução de nomes

Para visualizar o uso do IPv4, podemos digitar:

> curl -4 google.com.br

O Google retorna um resultado a partir dessa consulta, indicando o uso do IPv4. O "-4" força o uso do IPv4, mas é o padrão do curl, então funcionaria da mesma forma sem ele. Ao trocar "-4" por "-6", o sistema informa que não consegue resolver o host no modelo IPv6, indicando que o site do Google ainda não suporta essa opção, mas já possui a versão IPv4:

> curl -6 google.com.br

Caso o Google decida adotar o IPv6, provavelmente usará outro endereço de IP, permitindo o acesso tanto pelo IPv6 quanto pelo IPv4.

É interessante notar que, em nenhum momento, inserimos os endereços de IP diretamente. Utilizamos a resolução de nomes, ou DNS, que será explicada posteriormente. Ao digitar google.com.br, o sistema sabe que esse nome corresponde a um endereço de IP específico. Isso é possível graças ao mecanismo de resolução de DNS, que será abordado em detalhes mais adiante. É importante destacar que o endereço de IP e o DNS são conceitos distintos.

### Aula 1: Sistema de Nomes de Domínio (DNS) - Vídeo 6

Transcrição  
Agora que passamos pela parte de endereçamento e entendemos como o computador utiliza o endereço de IP para chegar a um destino, precisamos compreender que, para o computador, o funcionamento se dá através do endereço de IP. No entanto, para nós, seria muito difícil memorizar todos os IPs de todos os computadores e saber a ordem numérica do que estamos buscando. Para resolver esse problema, existe a resolução de DNS, ou a resolução de nomes por DNS.

O que é essa resolução de DNS? A internet desenvolveu um sistema que possui um servidor responsável por armazenar os endereços de IP e vinculá-los aos nomes de domínio. Esses nomes de domínio são, na verdade, o DNS que temos para o nome de nossa aplicação. Na internet, existem servidores que cuidam de associar o nome de uma aplicação, como Google, Amazon, Spotify ou Alura, a um IP. É esse sistema que nos informa a diferença entre o nome de uma URL que digitamos e o IP correspondente. É semelhante à diferença entre o CEP e o endereço completo. Não sabemos o CEP de todos, mas conhecemos o endereço completo de uma pessoa, incluindo o nome da rua, número e complemento. O DNS seria como esse endereço completo, enquanto o endereço IP seria o CEP vinculado àquela pessoa.

Comparando DNS e endereços postais  
Para nós, é mais comum procurar alguém pelo endereço completo. Já para sistemas como correios ou aplicações como o Google Maps, é mais intuitivo procurar pelo CEP, que é um número mais fácil de identificar e geralmente único. Podemos ter o mesmo nome de rua em diferentes cidades, mas o CEP é único em todos os lugares. Assim, o CEP é o endereço único, e o endereço completo é o que entendemos por DNS.

Por fim, temos os servidores DNS, que são aplicações na internet responsáveis por manter uma lista ou tabela que verifica se um endereço de IP está vinculado a um nome específico. Toda URL que digitamos no navegador para acessar um site possui um número de IP vinculado a ela. Durante o tráfego, como no TraceSearch, algum servidor de DNS é encontrado e direciona para o próximo servidor com o DNS resolvido.

Funcionamento do processo de resolução de DNS  
Vamos entender de maneira geral como esse processo funciona. No navegador, digitamos o nome do domínio que queremos acessar, como Google, Amazon, Spotify ou Netflix. O navegador envia uma consulta de DNS porque não sabe qual é o IP vinculado ao DNS, a menos que essa informação já esteja registrada. Se acessamos um site recentemente e pedimos para atualizar, o navegador pode guardar essa informação e saber qual IP precisa diretamente. Mas, se for a primeira vez que acessamos um site, ele precisará consultar diretamente.

Dentro do servidor, verifica-se se a informação está disponível. Caso não haja correspondência entre a URL digitada e um IP específico, o servidor perguntará a outros servidores de DNS até encontrar um que possua essa informação. Uma vez encontrado o endereço, o IP é retornado ao navegador. Com o IP, o navegador consulta o local correto e, a partir do IP correto, o recurso é respondido, permitindo que saibamos exatamente onde nos conectar.

Exemplificando a resolução de DNS com URLs  
Vamos entender como isso funciona no navegador ao encontrar os IPs. Se digitarmos um site, por exemplo, alura.com.br, temos a resolução do nome do DNS alura.com.br através dessa URL. A URL é o que digitamos no navegador e compõe o endereço que queremos acessar. Toda vez que acessamos a barra de endereços do navegador, estamos lidando com uma URL.

Basicamente, o domínio que estamos acessando na URL completa é alura.com.br. Este é o DNS, alura.com.br, e esse endereço completo é a URL. Podemos observar algumas características, como o .br, que indica que o site é brasileiro ou, pelo menos, que a parte de endereçamento é brasileira. Se quisermos acessar outro site, podemos usar, por exemplo, amazon.es, que nos leva à Amazon na versão da Espanha, diferente da versão no Brasil. Para acessar a Amazon do Brasil, utilizamos amazon.com.br. Assim, podemos ver a diferença entre a Amazon Espanha e a Amazon Brasil, que possuem IPs diferentes. A resolução do DNS apresentará informações distintas; na Amazon Espanha, provavelmente, as informações estarão em espanhol, enquanto no Brasil, estarão em português. Isso demonstra que a resolução de nomes impacta o comportamento da aplicação e do HTML, transmitindo informações específicas. O idioma é um dos aspectos mais importantes quando falamos de DNS.

Explorando domínios específicos e suas regras  
Outro detalhe sobre DNS é que existem DNS específicos para determinadas aplicações. Por exemplo, sites governamentais possuem o .gov. Se utilizarmos .gov, temos várias aplicações vinculadas ao governo, sendo o mais tradicional o .gov.br, específico para sites governamentais. Não podemos usar .gov em uma URL pessoal; apenas entidades governamentais têm essa permissão. O .br indica o país ao qual o site governamental pertence.

Outro tipo de site comum é o .edu, voltado para universidades. Por exemplo, ao buscar MIT edu no Google, encontramos o site do MIT com o .edu, indicando que estamos acessando o site institucional da universidade. Toda universidade ou instituição educacional pode ter o .edu, uma URL específica para instituições educacionais.

Concluindo o entendimento sobre DNS e infraestrutura da internet  
Uma vantagem dos DNS com domínios diferentes é que eles seguem regras específicas de cada instituição. Se alguém tentasse criar um site falso do MIT, dificilmente conseguiria a mesma resolução de DNS. A menos que estivesse em uma instituição, não poderia usar MIT.edu, precisando de outra URL para simular o site do MIT. O mesmo ocorre com sites governamentais. Os subdomínios ajudam a identificar se um site é verdadeiro ou falso, pois um site falso não pode usar .gov para se passar por governamental.

Com isso, concluímos um entendimento sobre a infraestrutura da internet. É importante compreender o caminho que nos leva de um endereço a outro, o que nos ajuda a criar aplicações que entendam esse processo. A partir daqui, temos uma base para entender não apenas aplicações de console, mas também como construir aplicações web, que possuem comportamentos e particularidades diferentes. Aplicações web funcionam por tempo indeterminado, enquanto aplicações de console podem ser encerradas ao fechar o programa. Precisamos entender essas particularidades, pois elas compõem uma série de regras que diferenciam as aplicações web. É isso que exploraremos nas próximas aulas.

### Aula 1: Para saber mais: impacto da latência e confiabilidade

Conceito de Latência  
A latência pode ser entendida como o tempo que uma requisição leva para percorrer um caminho na rede, desde o envio pelo dispositivo até o recebimento de uma resposta. Esse conceito é essencial para avaliar a experiência do usuário, pois redes com alta latência podem fazer com que operações pareçam lentas ou até interromper a interação em tempo real, como em jogos online ou videoconferências.

Em uma rede local (LAN), a latência tende a ser muito baixa, devido à curta distância entre os dispositivos e à infraestrutura dedicada. Em contrapartida, ao utilizar a internet – com sua série de dispositivos intermediários, longas distâncias e rotas dinâmicas – o tempo de resposta pode aumentar consideravelmente. Além disso, fatores como congestionamento da rede ou a necessidade de passar por múltiplos roteadores podem impactar esse tempo.

Para exemplificar, uma simples verificação de latência pode ser feita utilizando o comando "ping" no terminal. Essa ferramenta envia pequenos pacotes de dados e mede o tempo que eles levam para retornar, ajudando a identificar se a rede possui ou não atrasos significativos.

Entendimento de Confiabilidade  
A confiabilidade de uma rede diz respeito à capacidade de garantir que os dados transmitidos cheguem ao destino sem perdas ou erros. Essa característica é influenciada por diversos fatores, como a qualidade dos equipamentos, a estabilidade da conexão e a resiliência do caminho utilizado para comunicação.

Em infraestruturas locais, onde os elementos que compõem a rede são controlados, a confiabilidade costuma ser alta. Por outro lado, na internet, a transmissão pode ser afetada por diversos intermediários e por condições variáveis (como falhas temporárias em algum nó da rede), o que pode resultar em perda de pacotes ou na necessidade de retransmissão de dados. Esse cenário exige mecanismos de controle, como o protocolo TCP, que garante que os dados sejam entregues de forma ordenada e completa.

Fatores de Influência e Estratégias de Otimização  
Diversos aspectos podem impactar tanto a latência quanto a confiabilidade:

- Distância Física e Número de Saltos: Quanto maior a distância e maior o número de dispositivos intermediários, maior tende a ser a latência e menor a confiabilidade, pois há mais pontos de possível falha.
- Qualidade dos Equipamentos e Infraestrutura: Equipamentos modernos e bem configurados suportam melhor as demandas da rede, colaborando para transmissões mais estáveis.
- Congestionamento e Tráfego: Em momentos de alta demanda, a rede pode sofrer congestionamento, aumentando os tempos de resposta e a chance de perda de pacotes.

Como estratégia para otimizar essas variáveis, técnicas como o uso de cache local, balanceamento de carga e até mesmo redes privadas podem ser adotadas para minimizar os impactos. Ferramentas de monitoramento e diagnóstico, como análises de pacotes, ajudam a identificar gargalos e falhas na comunicação.

Em resumo, compreender os mecanismos por trás da latência e confiabilidade permite desenhar redes mais eficientes e oferecer uma experiência de uso superior, seja em ambientes controlados como em uma LAN, ou na vasta e variada infraestrutura da internet.

### Aula 1: Otimizando a experiência de streaming em viagens - Exercício

A Jornada Viagens é uma plataforma tecnológica especializada na comparação e reserva de pacotes de viagens, hotéis e passagens aéreas, oferecendo recursos como monitoramento de preços em tempo real. A empresa está desenvolvendo um novo recurso que permite às pessoas usuárias assistir a vídeos promocionais de destinos turísticos diretamente na plataforma.

Considerando que a experiência de visualização deve ser fluida, mesmo em conexões de internet instáveis, qual protocolo de transporte seria mais adequado para a transmissão desses vídeos?

Resposta correta  
UDP

> Correta, pois o protocolo UDP permite a transmissão de dados sem a necessidade de estabelecer uma conexão confiável, resultando em uma entrega mais rápida e eficiente. Embora não corrija a perda de pacotes, é ideal para streaming de vídeo, já que pequenas perdas de dados não afetam significativamente a experiência de visualização, garantindo uma reprodução contínua.

### Aula 1: Faça como eu fiz: infraestrutura web

Nesta aula, vimos os mecanismos que suportam a aplicação web e a infraestrutura da internet, desde protocolos até endereçamento.

Agora é a sua chance de fixar os conceitos abordados. Para isso:

- Identifique a necessidade de compartilhar aplicações globalmente;
- Compare o teste local com a distribuição via internet;
- Analise a infraestrutura global composta por dispositivos e conexões;
- Entenda o fluxo de requisição entre navegador e servidor;
- Reconheça o papel do cliente HTTP na comunicação;
- Compreenda a importância dos protocolos para padronizar a comunicação;
- Diferencie redes locais (LAN), regionais (WAN) e globais (Internet);
- Utilize exemplos como LAN houses para ilustrar redes locais;
- Explore a analogia entre redes e sistemas de telefonia para WAN;
- Avalie a abrangência geográfica e o acesso público versus privado;
- Considere aspectos de velocidade, latência e custo de cada rede;
- Identifique as camadas do protocolo TCP/IP;
- Reconheça a camada de aplicação e o uso do HTTP/HTTPS;
- Explore a camada de transporte com os protocolos TCP e UDP;
- Realize testes práticos com Telnet para visualizar conexões TCP;
- Utilize o CURL para monitorar requisições HTTP;
- Diferencie a entrega ordenada do TCP da transmissão assíncrona do UDP;
- Associe o TCP à integridade na entrega de páginas web;
- Compreenda o endereçamento IP como um identificador único, similar a um CEP;
- Investigue a resolução de nomes via DNS e sua relação com URLs;
- Teste a resolução de DNS com comandos como ping.

Para acessar mais conteúdos, consulte as transcrições da aula.

### Aula 1: O que aprendemos?

Nesta aula, aprendemos:

- A importância de usar infraestrutura web e mecanismos HTTP para compartilhar aplicações globalmente.
- Os componentes e diferenças de LAN, WAN e internet, além de seus protocolos de comunicação.
- O funcionamento do protocolo TCP/IP e suas camadas, com foco em TCP e UDP.
- As diferenças entre TCP e UDP e suas aplicações práticas, como streaming e jogos online.
- O conceito e uso de endereçamento IP para identificar dispositivos em redes.
- A função do DNS em associar nomes de domínio a endereços IP para facilitar o acesso a sites.
- O processo de resolução de DNS ao acessar uma URL.
- A estrutura de URLs e a importância de domínios para autenticação e segurança online.

## Aula 2: Modelo cliente-servidor e Protocolo HTTP

### Aula 2: Modelo cliente-servidor - Vídeo 1

Transcrição  
Já compreendemos como funciona toda a infraestrutura da web, desde o processo em que uma solicitação do navegador chega ao servidor e retorna como uma resposta. Exploramos diversos aspectos desse processo, incluindo o funcionamento dos modelos de rede, o protocolo TCP/IP, a resolução de DNS, entre outros. Para que tudo isso funcione adequadamente, as aplicações que desenvolvemos para a internet precisam estar alinhadas com essas funcionalidades.

O modelo de aplicação web possui particularidades distintas de uma aplicação console ou desktop, pois precisa operar em conjunto com a internet. Vamos explorar a construção dessas aplicações. Em geral, as aplicações seguem um modelo chamado cliente-servidor. Este modelo é composto por um cliente, que solicita os recursos, e um servidor, que disponibiliza esses recursos para a aplicação.

Exemplificando o modelo cliente-servidor  
Um exemplo comum de projeto que utiliza o modelo cliente-servidor são os jogos online. Quando baixamos e jogamos um jogo como Fortnite, por exemplo, o cliente é a parte que está instalada em nossos dispositivos, enquanto o servidor gerencia o jogo para todos os jogadores simultaneamente. Essa distinção entre uma aplicação local que se comunica pela internet e um repositório central que gerencia tudo é o que chamamos de aplicação cliente-servidor.

É comum ouvirmos que um jogo "caiu" quando a empresa responsável desativa os servidores, fazendo com que o jogo online deixe de funcionar, pois os recursos online não estão mais disponíveis. No modelo cliente-servidor, o servidor, geralmente controlado pela empresa desenvolvedora do jogo, é responsável por manter o funcionamento dos recursos online.

Funcionamento do modelo cliente-servidor  
Resumidamente, o modelo cliente-servidor é uma forma de criar aplicações onde existem dois atores principais: o cliente, que consome os serviços e solicita sua disponibilização, e o servidor, que fornece esses serviços. Isso pode ocorrer em um navegador, em uma aplicação móvel ou desktop que utiliza recursos da internet.

Vamos entender melhor como o modelo cliente-servidor funciona. Basicamente, ele não difere muito do processo de uma aplicação web ou do funcionamento geral da internet.

Hospedando uma aplicação web  
Temos a possibilidade de o usuário digitar uma URL ou acessar uma página da aplicação móvel, o que desencadeará o efeito de o recurso ser solicitado a um servidor. Esse servidor processará a solicitação e enviará uma resposta de volta, seja no navegador ou no aplicativo.

Agora, vamos hospedar uma aplicação para entender como funciona a questão de uma aplicação cliente-servidor. Estamos utilizando um HTML padrão, index.html, com uma aplicação simples, apenas um HTML com um CSS mínimo, contendo a mensagem "Hello World". Nada muito diferente do que já vimos em front-end. A única preocupação aqui é o uso de uma extensão que permitirá hospedar esta aplicação.

Visualizando o código HTML  
Para ilustrar isso, vamos ver o código HTML que estamos utilizando:

```html
<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Olá, Mundo!</title>
    <style>
        body {
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
            margin: 0;
            background-color: #f0f0f0;
            font-family: Arial, sans-serif;
        }

        h1 {
            color: #333;
            font-size: 3rem;
        }
    </style>
</head>
<body>
    <h1>Olá, Mundo!</h1>
</body>
</html>
```

Explicando o conceito de hospedagem  
O que significa hospedar esta aplicação? Diferentemente de uma aplicação desktop, que é instalada, uma aplicação web é hospedada. Isso significa que ela será colocada dentro de um servidor, que gerenciará os recursos necessários para disponibilizar o serviço da aplicação.

Vamos entender isso melhor. Temos um HTML que é o conteúdo que queremos disponibilizar para que os clientes vejam. Se clicarmos no Visual Studio, no canto superior direito, em "Show Preview", que vem da extensão Live Preview, comumente utilizada para testar aplicações web no Visual Studio Code, ele apresentará um navegador mais simples. Poderíamos pegar esse endereço e colocá-lo no Chrome, sem problemas. Aqui, ele indica que a aplicação está hospedada em um endereço específico e em uma porta.

Detalhando o uso de portas e protocolos  
O protocolo utilizado é o HTTP, e ele mostra o endereço local, localhost 127.0.0.1, nosso IP. Utiliza a porta 3000, e é importante saber que há uma diferença entre uma porta local e a porta externa, que é a porta 80 do HTTP. Não devemos confundir isso. Quando falamos de porta local, não há problema em não ser a porta 80. Na internet, devemos usar a porta 80 para HTTP ou a porta 443 para HTTPS.

O navegador está sendo o cliente que acessa o servidor hospedado neste endereço, que devolverá um conteúdo. A resposta desse conteúdo, além da mensagem definida pelo protocolo HTTP, inclui o HTML e o conteúdo processado por este HTML renderizado pelo navegador.

Concluindo sobre o modelo cliente-servidor  
Devemos entender que, nesse modelo, não há instalação de aplicações. Não há o modelo de baixar um aplicativo. Temos um modelo de cliente e servidor, onde o cliente solicita um serviço através da URL, e um serviço hospedado devolve o recurso solicitado.

Para que essa comunicação entre cliente e servidor funcione com todos os tipos de aplicações, precisamos de um meio comum que permita solicitar um recurso e recebê-lo no formato correto para processamento nos navegadores. Isso é possível graças ao protocolo HTTP, que veremos com mais detalhes agora.

### Aula 2: Protocolo HTTP - Vídeo 2

Transcrição  
Agora que já entendemos o modelo de aplicações web e a necessidade de construir uma aplicação que siga o padrão cliente-servidor, vamos abordar o meio de comunicação que precisa existir entre as duas partes para que a aplicação seja funcional: o protocolo HTTP. Precisamos seguir esse protocolo para que nossa aplicação funcione corretamente.

Podemos pensar nisso como a construção de uma casa. Ao construir uma casa, precisamos seguir alguns protocolos ao iniciar a estrutura. Seguimos algumas plantas para garantir que tenhamos o mesmo modelo. Por convenção, temos uma planta elétrica, uma planta hidráulica, e elas geralmente têm o mesmo formato. Por exemplo, uma planta hidráulica para uma cozinha sempre considera os mesmos elementos: uma casa sempre terá um chuveiro, uma pia e um tanque. Assim, existe uma estrutura comum, convencionada entre as casas. Mesmo que existam mil modelos de casas diferentes, umas mais luxuosas, outras mais simples, elas geralmente seguem o mesmo padrão, o mesmo modo de comunicação entre as partes para garantir que o plano da aplicação esteja funcionando corretamente.

Explorando a evolução do HTTP  
Essa mesma estrutura é aplicada quando seguimos o padrão do protocolo HTTP. É uma convenção iniciada para que a internet funcione de maneira eficaz, e ela evoluiu ao longo do tempo. Temos novas maneiras de comunicação dentro do protocolo HTTP, mas o mais importante é que todos na internet sigam esse protocolo.

Para entender um pouco do cenário histórico, é importante saber que o HTTP foi inventado na década de 1990, no projeto da World Wide Web, que visava permitir que universidades compartilhassem dados de seus laboratórios e centros de pesquisa. O HTTP passou por várias alterações ao longo do tempo. Temos o HTTP 1.0, a primeira versão, e em 1999 foi lançado o HTTP 1.1, um dos modelos mais utilizados até hoje. Em 2015, houve a adoção do HTTP 2.0, e em 2020, o lançamento do HTTP 3.0.

Verificando versões do HTTP com curl  
Como podemos verificar essas versões do HTTP? No terminal, podemos verificar o uso do HTTP. Vamos fazer um teste. No terminal, no prompt de comando, utilizamos o comando curl para iniciar o processo de requisição.

> curl

Para obter mais informações sobre a requisição que estamos fazendo, utilizamos o comando curl -v.

> curl -v

Agora, vamos fazer uma requisição específica para o site da Alura usando curl -v alura.com.br. Isso nos permitirá ver todas as informações da requisição, como cliente acessando o servidor da Alura.

> curl -v alura.com.br

Ele mostra todas as informações da requisição, como cliente acessando o servidor da Alura. Apresenta informações relacionadas ao TCP e IP, indicando que não há IPv6, mas mostra os IPs do IPv4, a conexão TCP com a Alura na porta 80, e a versão do HTTP utilizada para acessar o recurso do DNS alura.com.br.

Entendendo a estrutura das requisições HTTP  
Ali, a partir do método GET, utilizamos o HTTP como protocolo para nos comunicarmos com um determinado endereço. Precisamos seguir esse padrão, semelhante a um envelope que deve seguir um formato específico para ser enviado pelo correio. O processo começa com o GET, seguido por HTTP 1.1, o host, que funciona como um endereço.

> GET / HTTP/1.1

Enviamos uma requisição para o Alura.com.br, e o agente que está solicitando essa requisição é o curl na versão 8.14. Aqui, temos o mínimo necessário do protocolo: quem está enviando a requisição, para onde está sendo enviada, o tipo de requisição e a versão do HTTP.

```cmd
GET / HTTP/1.1
Host: alura.com.br
User-Agent: curl/8.14.1
Accept: */*
```

Utilizando DevTools para inspecionar requisições  
No terminal, podemos ver o básico de como o protocolo HTTP funciona. No navegador, também conseguimos visualizar informações sobre o funcionamento da web e dos protocolos HTTP através do DevTools. Ao inspecionar o site, o DevTools mostra uma série de informações. Na barra de opções do DevTools, clicamos em "rede" e atualizamos a página da Alura para obter a primeira informação desejada, que é o acesso ao Alura.com.br. Na seção de rede, há opções de protocolo. Se não estiver visível no DevTools, basta clicar com o botão direito para acessar todas as opções disponíveis. Selecionamos "protocolo" para visualizar como todos os pacotes foram requisitados no navegador.

Podemos observar que todos os pacotes, sejam CSS, o site em si, imagens SVG ou PNG, foram requisitados pelo protocolo HTTP na versão 3. Descendo a lista, podemos encontrar outras versões, como HTTP 2 ou até mesmo HTTP 1.1, como fizemos anteriormente com o curl. Mesmo com protocolos em versões diferentes em operação, as versões mais antigas ainda são utilizadas e mantidas na internet. Embora existam versões mais novas e atualizadas, elas não são necessariamente utilizadas o tempo todo para fazer requisições. Sempre é possível verificar qual versão do HTTP está sendo utilizada, pois a requisição indicará o protocolo em uso. Podemos verificar isso pelo DevTools ou pelo terminal usando o curl.

Concluindo a importância do protocolo HTTP  
Entendemos que precisamos utilizar um protocolo para nos comunicarmos com os servidores na internet. Além disso, é necessário seguir esse protocolo, não apenas conhecendo o endereço, mas também enviando a mensagem correta no protocolo adequado e recebendo uma resposta correta da informação passada para nós como clientes. Com o curl, já temos uma noção de como funciona a requisição e a resposta. No entanto, há muitos detalhes sobre a estrutura dessas requisições e respostas, que é o que vamos explorar agora.

### Aula 2: Para saber mais: o projeto World Wide Web (WWW)

A história do projeto World Wide Web (WWW) começa no final da década de 1980, dentro do CERN (Organização Europeia para a Pesquisa Nuclear), em Genebra. O físico britânico Tim Berners-Lee identificou um problema recorrente entre os pesquisadores: a dificuldade de compartilhar e acessar informações de maneira eficiente, já que os documentos estavam dispersos em diferentes computadores, sistemas e formatos. Sua ideia foi criar um ambiente universal de informações interligadas por meio de hipertexto, capaz de conectar documentos e facilitar a navegação entre eles.

Em 1989, Berners-Lee elaborou a proposta inicial do projeto, que não apenas visava organizar documentos científicos, mas também permitir que diferentes pessoas pudessem acessar, editar e interconectar conteúdos de forma colaborativa. O conceito de hipertexto não era novo, mas sua aplicação em redes distribuídas foi inovadora. Em 1990, ele desenvolveu os três componentes fundamentais: o HTML (linguagem de marcação para estruturar documentos), o HTTP (protocolo de transferência de hipertexto) e o primeiro navegador/editor, chamado WorldWideWeb (depois renomeado Nexus). Ao mesmo tempo, criou o primeiro servidor web, o CERN httpd, e publicou a primeira página da web, que explicava o próprio projeto.

A web começou como uma ferramenta interna do CERN, mas em 1991 foi aberta ao público externo, inicialmente voltada para a comunidade acadêmica. A simplicidade de seu modelo — documentos conectados por links acessíveis a partir de qualquer computador conectado à rede — fez com que rapidamente ultrapassasse as fronteiras científicas. Em 1993, com o lançamento do navegador gráfico Mosaic, desenvolvido no NCSA (National Center for Supercomputing Applications), a web ganhou popularidade, tornando-se acessível a um público mais amplo e fomentando o surgimento de sites fora do meio acadêmico.

O impacto da World Wide Web foi tão profundo que transformou radicalmente a forma de comunicação, pesquisa, comércio e entretenimento. Tim Berners-Lee sempre defendeu que a web deveria ser uma plataforma aberta, gratuita e de acesso universal, o que garantiu sua expansão exponencial. Desde então, a web evoluiu de simples páginas estáticas para ambientes dinâmicos e interativos, passando pela Web 2.0 (redes sociais, colaboração em massa) e chegando hoje a aplicações de inteligência artificial, realidade virtual e descentralização com a Web3.

Referências  

- “Information Management: A Proposal” – documento original de Tim Berners-Lee (1989), disponível no site do CERN.

- World Wide Web Consortium (W3C) – organização fundada por Berners-Lee em 1994 para estabelecer [padrões abertos para a web](https://www.w3.org/)

- Livro “Weaving the Web”, escrito por Tim Berners-Lee, no qual ele narra a concepção e os primeiros anos do projeto.
Documentos históricos sobre o navegador Mosaic e seu papel na popularização da internet.

### Aula 2: Requisições e respostas - Vídeo 3

Transcrição  
A necessidade de utilizar o protocolo HTTP é fundamental para que possamos criar aplicações funcionais na internet. Quando falamos sobre a utilização do protocolo HTTP, precisamos entender que é necessário sempre comunicar uma requisição e obter uma resposta. Para isso, as requisições possuem um formato que precisa ser enviado adequadamente. Vamos entender um exemplo de requisição HTTP. Já vimos anteriormente como trabalhar com uma requisição utilizando uma URL, mas aqui temos outro exemplo de como funciona estruturalmente uma requisição HTTP.

Basicamente, a requisição HTTP funciona através de um cliente HTTP que envia a mensagem. Temos aqui o método GET e a URI que está sendo enviada para aquele recurso. É importante saber a diferença entre URI e URL. Aqui temos o nosso host, que é a composição do host com o endereço que vem em seguida. Essa é a URL de fato, mas temos a composição do host e da URI, além do protocolo utilizado, que é o HTTP 1.1, e o user agent, que é basicamente o que estamos utilizando para fazer a requisição. Anteriormente, estávamos usando a URL e ela mostrou que era um agente diferente. Aqui, utilizamos uma extensão do Visual Studio chamada Thunder Client, que permite simular um cliente HTTP dentro da nossa aplicação.

Demonstrando requisições HTTP com Thunder Client  
Para ilustrar, veja o exemplo de uma requisição GET utilizando o Thunder Client:

```cmd
GET /sets/2ec77b94-6d47-4891-a480-5d0b4e5c9372 HTTP/1.1
Host: api.scryfall.com
User-Agent: Thunder Client (https://www.thunderclient.com)
```

Vamos entender como funciona essa parte da requisição HTTP dentro do navegador e quais outras ferramentas podemos utilizar para entender melhor o funcionamento de uma requisição. No navegador, podemos inspecionar o site da Alura. Ao acessar a rede, podemos limpar e atualizar a requisição, carregando todos os pacotes necessários para a página. Ao clicar em Alura, podemos ver no DevTools algumas informações, principalmente os cabeçalhos de requisição, que permitem enviar a mensagem e obter uma resposta. Conseguimos ver informações como a URL requisitada, o método e o código de status. Isso será melhor explicado quando falarmos sobre respostas HTTP, mas já conseguimos obter algumas informações da requisição.

Explorando ferramentas para requisições HTTP  
Se quisermos entender melhor, o DevTools apresenta uma visão ampla de tudo que foi requisitado e respondido, mas não fica tão claro como enviar de fato aquele cabeçalho HTTP com as informações necessárias. Vamos usar uma ferramenta diferente que ajuda a ver o mínimo necessário para fazer uma requisição HTTP: o Postman. O Postman é uma das ferramentas mais utilizadas como cliente HTTP, permitindo testar sites, APIs ou outros tipos de aplicações que trabalham com a internet, testando nos mínimos detalhes o comportamento do protocolo HTTP.

No Postman, ao criar uma nova requisição, podemos escrever a URL desejada, como http://www.alura.com.br, e clicar em enviar. Ele fará a requisição e devolverá o HTML daquela requisição. No botão de preview, podemos ver o HTML, mas ele não é renderizado completamente, pois no momento da requisição, o preview não carrega todos os pacotes de CSS, JavaScript e imagens, apenas o HTML puro. Os outros pacotes vêm em sequência. Por isso, comentamos que a transferência de dados precisa ser ordenada, recebendo primeiro o HTML e depois as outras informações.

Utilizando o Postman para requisições HTTP  
No canto superior direito, há um símbolo de código, semelhante a uma tag HTML. Ao clicar nele, podemos ver como executar essa requisição através de outros mecanismos. O principal mostrado é o curl, que usamos no terminal. Podemos copiar esse comando e executá-lo no terminal para obter o mesmo resultado. No entanto, o curl não é o ponto mais importante. Acima da linha que apresenta o curl, há um drop-down com várias linguagens de programação, como C#, Java, JavaScript, Kotlin, Node.js, entre outras. O mais importante no momento é o HTTP, pois ao clicar nele, conseguimos ver a requisição HTTP mais pura possível. Com isso, vemos exatamente o exemplo de mensagem solicitado anteriormente:

```cmd
GET / HTTP/1.1
Host: www.alura.com.br
```

Já entendemos como funciona o mínimo para fazer uma requisição HTTP. A partir dessa requisição, podemos obter os recursos necessários a partir de um endereço específico. Precisamos entender algumas coisas sobre o cabeçalho da requisição HTTP. Primeiro, indicamos o método. Existem outros tipos de métodos HTTP, como GET, POST, PUT e DELETE. Mais adiante, explicaremos o que cada um faz. Fazemos uma solicitação através de uma URI, que é o detalhamento do recurso da URL completa que estamos requisitando. Estávamos pegando algumas páginas que já são o índice de uma página HTML, como www.alura.com.br, que nos leva à página principal. Claro que existem outras páginas que compõem o site inteiro da Alura, e essas outras páginas fazem parte da URI, entrando em subpáginas dentro da aplicação da Alura.

Diferenciando URL e URI  
Vou mostrar um exemplo sobre a diferença entre URL e URI. No navegador, verificamos o site inicial da Alura, ou seja, o índice do HTML da Alura. Ao clicar em qualquer link, como "programação", aparece outra seção da aplicação da Alura, com o caminho /escola/programacao. Essa é uma URI que vem da URL www.alura.com.br. No DevTools, ao verificar a requisição dessa página, vemos que o request URL foi www.alura.com.br/escola/programacao. Vou copiar essa URI e colá-la no Postman, substituindo a URL anterior. Ao enviar e ver como isso funciona no HTTP, o GET busca agora a URI /escola/programacao com o host www.alura.com.br. Para o HTTP, há uma distinção entre o que é o host e o que é a URI, que vem após o .com.br.

```cmd
GET /escola-programacao HTTP/1.1
Host: www.alura.com.br
```

Explorando requisições POST  
Além das requisições onde solicitamos informações, existem requisições onde enviamos informações. Aqui, vemos outro tipo de requisição HTTP, com duas propriedades para trabalhar com o protocolo HTTP. Temos outro método, o POST, com os mesmos parâmetros.

```cmd
POST /api/v1/usuarios HTTP/1.1
Host: exemplo.com
Content-Type: application/json
Authorization: Bearer token-exemplo
Content-Length: 49

{
    "nome": "João",
    "idade": 30,
    "cidade": "São Paulo"
}
```

Temos a URI, o host e a versão. Além disso, há informações adicionais que fazem parte do cabeçalho. Não é necessário saber todas elas de imediato, pois com o tempo entenderemos o significado de cada uma dentro dos headers HTTP. O mais importante é compreender que agora estamos enviando um corpo na requisição. Este corpo é o que permite atualizar ou enviar informações ao servidor, solicitando alguma alteração.

Exemplificando o uso do método POST  
Vamos exemplificar como o método POST funciona. No site da Amazon, ao selecionar um produto qualquer, podemos inspecionar o DevTools para observar o comportamento de um POST. Ao adicionar um produto ao carrinho, enviamos um POST na requisição. Isso ocorre porque estamos solicitando ao servidor da Amazon que registre a adição do produto ao carrinho. Nesse momento, deixamos de ser apenas consumidores de informação e também enviamos dados para o servidor processar. O corpo da requisição, que utilizamos, está no payload, onde podemos ver todas as informações enviadas ao servidor da Amazon, compondo a requisição junto com o cabeçalho.

É importante destacar que o corpo da mensagem é opcional. Dependendo da solicitação HTTP, não é necessário enviar o corpo da mensagem. Ele é geralmente reservado para métodos que atualizam ou enviam algo ao servidor, como POST ou PUT, que veremos posteriormente.

Analisando respostas de requisições HTTP  
Podemos verificar como funciona a resposta de uma requisição HTTP. Basicamente, ela indica algumas informações, como o status, que retorna o número 200 quando a requisição é bem-sucedida, o tipo de conteúdo devolvido, que pode ser um JSON, e a formatação desse JSON, que utiliza UTF-8. É importante entender o que é o content-type e o conteúdo devolvido em uma resposta.

```cmd
HTTP 200 success
Content-Type: application/json; charset=utf-8
{
    "object": "set",
    "id": "2ec77b94-6d47-4891-a480-5d0b4e5c9372",
    "code": "uma",
    "mtgo_code": "uma",
    "arena_code": "uma",
    "tcgplayer_id": 2360,
    "name": "Ultimate Masters",
    "uri": "https://api.scryfall.com/sets/2ec77b94-6d47-4891-a480-5d0b4e5c9372",
    "scryfall_uri": "https://scryfall.com/sets/uma",
    "search_uri": "https://api.scryfall.com/cards/search?include_extras=true&include_variations=true&order=set&q=e%3Auma&unique=prints",
    "released_at": "2018-12-07",
    "set_type": "masters",
    "card_count": 254,
    "printed_size": 254,
    "digital": false,
    "nonfoil_only": false,
    "foil_only": false,
    "icon_svg_uri": "https://svgs.scryfall.io/sets/uma.svg?1754280000"
}
```

No Postman, ao fazer uma solicitação no site da Alura, podemos ver cabeçalhos de requisição e resposta. A resposta geralmente inclui a data, o tipo de conteúdo, que pode ser um HTML, e o charset, que é a formatação do HTML. Assim, várias informações compõem a resposta de um cabeçalho HTTP. O mais importante é que no final temos o corpo da requisição, que pode ser HTML ou outro tipo de informação.

Explorando diferentes tipos de conteúdo em respostas HTTP  
No navegador, ao buscar imagens do Google e abrir uma imagem em uma nova guia, podemos inspecionar os cabeçalhos e ver que o content-type é diferente do solicitado no Postman. No caso, é uma imagem JPEG, diferente do texto HTML devolvido anteriormente. Diversos tipos de dados podem ser trafegados, como imagem, áudio, vídeo ou texto.

```cmd
Content-Type: image/jpeg
```

Vamos mostrar um tipo diferente de resposta que o HTTP pode fornecer. Além de imagem e HTML, existem outros formatos importantes. No site Scryfall, que apresenta cartas de Magic, ao clicar em uma coleção, podemos ver as cartas e suas descrições. Ao clicar no link CopyPaste.json, vemos uma formatação de dados textual em JSON, muito utilizada por JavaScript e APIs. Ao inspecionar a página, podemos verificar os headers das requisições, onde o content-type é application-json, um tipo específico de formatação de dados.

```cmd
application/json; charset=utf-8
```

Concluindo sobre o protocolo HTTP e suas funcionalidades  
Todos esses formatos têm um propósito específico. Se a aplicação não indicar na resposta que se trata de um JSON, HTML, texto ou imagem, o navegador pode não renderizar corretamente o dado. No Scryfall, ao devolver um JSON, podemos formatá-lo no navegador, pois ele segue uma estrutura comum. Se não indicarmos que é um JSON, mesmo recebendo a informação, não poderíamos formatá-la. Isso vale para áudio, imagem e vídeo. O navegador precisa saber o padrão devolvido na resposta do serviço consumido.

Entendemos como funciona o protocolo HTTP a partir da requisição e da resposta. Precisamos compreender melhor os tipos de requisição que podemos fazer. Mencionamos anteriormente os métodos GET, POST, PUT, DELETE, PATCH, OPTIONS, entre outros. Esses métodos HTTP são essenciais para o funcionamento correto da aplicação. Na próxima aula, exploraremos como esses métodos funcionam e como interagem com o HTTP.

### Aula 2: Compreendendo requisições HTTP no aplicativo Fokus
 Próxima Atividade

A equipe de desenvolvimento do aplicativo Fokus, que ajuda pessoas usuárias a aumentar a produtividade utilizando a técnica Pomodoro, está trabalhando em uma nova funcionalidade que permite sincronizar sessões de foco com um calendário online. Para isso, é necessário enviar e receber dados de um servidor externo utilizando requisições HTTP.

Durante uma reunião, a equipe discutiu a importância de entender a diferença entre URI e URL ao configurar as requisições.

Qual das alternativas abaixo explica corretamente a diferença entre URI e URL e sua importância ao configurar requisições HTTP no aplicativo Fokus?

Resposta correta  
A URI é um identificador genérico que pode ser usado para nomear qualquer recurso na internet, enquanto a URL é um tipo específico de URI que fornece o endereço completo para acessar um recurso na web. No contexto do aplicativo Fokus, entender essa diferença é crucial porque a URL inclui o protocolo, o domínio e o caminho específico para o recurso, garantindo que o aplicativo possa se comunicar efetivamente com o servidor externo e sincronizar as sessões de foco.

> Correta, pois esta alternativa descreve com precisão a diferença entre URI e URL e destaca a importância de configurar corretamente a URL para a comunicação eficaz com o servidor externo.

### Aula 2: Métodos HTTP - Vídeo 4

Transcrição  
Agora que entendemos que precisamos ter uma informação base que será o nosso cabeçalho da requisição, podemos fazer uma analogia com os correios. Assim como precisamos deixar em cima de um pacote a informação de para quem será enviado e de onde veio, também precisamos declarar o que estamos enviando. Dessa forma, temos o corpo da requisição, que é de fato o pacote que está sendo enviado.

Precisamos entender que existem métodos que devem ser enviados em cada requisição. Assim como nos correios, é necessário definir qual é o tipo de método de envio que será utilizado quando compramos ou enviamos algo. Ao enviar algo pelo correio, é preciso declarar o tipo de envio, o que ajuda a definir se o pacote que estamos utilizando pode ou não seguir as regras de envio selecionadas. Da mesma forma, trabalhamos com o HTTP ao pensar no envio de uma requisição.

Introduzindo os métodos HTTP  
Existem alguns métodos que definem o tipo de requisição que estamos fazendo. Vimos anteriormente os métodos GET e POST, que são os mais comuns, mas é interessante conhecermos os outros métodos e como funcionam.

Entre os métodos HTTP, começamos pelo GET, localizado no canto superior esquerdo. O método GET é o padrão. Quando digitamos uma informação na URL do navegador, toda requisição é um GET. Toda solicitação de informação pela URL é um método GET. Ele é o método padrão utilizado para buscar qualquer outra informação. Ao abrir um navegador e buscar uma requisição, independentemente da página web que estamos acessando, estamos utilizando um método GET.

Explorando os métodos POST, PUT e PATCH  
No canto superior direito, temos o método POST, que é amplamente utilizado para formulários ou para criar um recurso. Por exemplo, ao adicionar um produto ao carrinho em um site como a Amazon, ocorre um POST. Quando removemos algo do carrinho, também pode ocorrer um POST. Ao preencher um formulário para assinar uma newsletter ou clicar em "play" em um curso, qualquer solicitação que modifique algo no servidor é feita através de um POST.

No canto inferior direito, temos o método PUT, que, junto com o PATCH, realiza modificações em um recurso. Por exemplo, se quisermos atualizar um carrinho na Amazon, podemos usar o PUT para substituir todo o carrinho. Se desejarmos apenas alterar a quantidade de um produto específico, utilizamos o PATCH, que atualiza apenas a quantidade desse produto. Essa é a diferença entre PUT e PATCH.

Descrevendo os métodos DELETE, OPTIONS e HEAD  
No canto inferior esquerdo, temos o método DELETE, que serve para remover um recurso. Caso queiramos eliminar um recurso do servidor, utilizamos o DELETE. Os métodos mais utilizados são GET, POST, PUT, DELETE e PATCH.

Além desses, temos o OPTIONS e o HEAD, que são menos utilizados. O método HEAD retorna apenas o cabeçalho de qualquer requisição, sem o recurso solicitado. Por exemplo, ao usar o HEAD em uma página web, recebemos apenas o cabeçalho. O método OPTIONS apresenta as opções disponíveis para solicitar um recurso, indicando quais métodos podem ser utilizados, como GET, POST, PUT, PATCH, DELETE ou HEAD. Ele define o que é permitido ou não em uma página.

Ressaltando a importância dos métodos HTTP  
É importante entender que os métodos HTTP devem ser seguidos corretamente para garantir o funcionamento adequado de uma aplicação web. Existem recursos que facilitam a adesão às convenções do protocolo HTTP, como acompanhar os métodos HTTP. Posteriormente, abordaremos os STATUS CODE, que são parte da resposta de uma requisição e nos fornecem um status que podemos usar para monitorar a requisição.

### Aula 2: Otimizando a entrega de conteúdo na VideoFlowNow - Exercício

A VideoFlowNow, uma plataforma de streaming especializada em vídeos curtos e transmissões ao vivo, está buscando otimizar a entrega de conteúdo para seus usuários. A equipe de desenvolvimento que você faz parte está implementando um sistema de requisições HTTP para gerenciar o fluxo de dados entre o servidor e os dispositivos dos usuários. Durante o processo, surgiu a necessidade de decidir quais métodos HTTP utilizar para diferentes tipos de interações, como carregar vídeos, enviar feedbacks dos usuários e atualizar perfis.

Considerando o contexto da VideoFlowNow, como você aplicaria os métodos GET, POST, PUT e DELETE para otimizar essas interações na plataforma?

Resposta correta  
Utilizar o método GET para carregar vídeos e informações de perfil, POST para enviar feedbacks dos usuários, PUT para atualizar informações de perfil e DELETE para remover vídeos ou feedbacks.

> Correta, pois essa aplicação dos métodos HTTP é ideal para otimizar as interações na VideoFlowNow. O método GET é usado para solicitações de dados sem alterar o estado do servidor, POST para criar novos recursos, PUT para substituir recursos existentes e DELETE para excluir recursos.

### Aula 2: Para saber mais: user-agent nas requisições HTTP

Origem e Propósito  
O cabeçalho User-Agent é responsável por informar ao servidor qual cliente (navegador, ferramenta ou outro agente) está efetuando a requisição. Essa informação permite que o servidor adapte suas respostas de acordo com o agente que está solicitando os dados. Por exemplo, é comum que servidores enviem recursos otimizados para diferentes navegadores ou mesmo ofereçam versões mobile quando o user-agent indica um dispositivo móvel.

Funcionamento na Prática  
Ao realizar uma requisição HTTP, o cliente inclui o cabeçalho User-Agent junto com outros dados da requisição. Esse cabeçalho contém uma cadeia de caracteres que normalmente especifica o nome, a versão e, em alguns casos, o sistema operacional do cliente. Um exemplo comum em uma requisição pode ser:

```cmd
GET /exemplo HTTP/1.1
Host: www.exemplo.com
User-Agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/85.0.4183.102 Safari/537.36
```

Com esses dados, o servidor pode identificar que o pedido vem de um navegador específico em um sistema Windows e enviar respostas compatíveis com esse ambiente.

Aplicações e Considerações Técnicas  
A utilização do User-Agent vai além da simples identificação do cliente:

Adaptação de Conteúdo: Servidores podem oferecer conteúdos customizados, selecionando estilos, scripts ou até mesmo versões diferentes de uma página de acordo com o agente identificado.

Análise e Métricas: Dados sobre os user-agents podem ajudar desenvolvedores e equipes de operação a entender a diversidade de clientes acessando um serviço, permitindo otimizações direcionadas.

Segurança: Em alguns cenários, a informação do User-Agent é utilizada para filtrar requisições suspeitas ou automatizadas. No entanto, é importante ter em mente que esse cabeçalho pode ser facilmente manipulado ou falsificado, o que limita seu uso como única camada de segurança.

Variações e Impacto na Experiência do Usuário  
Embora o User-Agent seja amplamente utilizado, há algumas variações a serem consideradas:

Atualizações Constantes: Com a rápida evolução dos navegadores e dispositivos, as cadeias de caracteres dos user-agents mudam com frequência. Isso pode exigir atualizações nos sistemas que dependem dessa informação para oferecer conteúdo adaptado.

Falsificação de Dados: O User-Agent pode ser alterado programaticamente, o que permite que clientes enviem dados incorretos. Essa característica deve ser levada em conta em aplicações que tentam aplicar restrições ou personalizações rigorosas baseadas nesse cabeçalho.

Em resumo, o User-Agent é uma ferramenta valiosa para personalizar a experiência de uso e coletar informações sobre os clientes que acessam um serviço. Contudo, seu uso deve ser complementado por outras práticas de detecção e segurança, considerando que a informação repassada pode não ser plenamente confiável.

### Aula 2: Faça como eu fiz: requisições HTTP
 Próxima Atividade

Nesta aula, foram explorados os fundamentos da infraestrutura web, do modelo cliente-servidor e do protocolo HTTP, desde a hospedagem da aplicação até a análise de requisições e respostas. Agora é sua chance de revisar e exercitar os conteúdos vistos nesta aula, se ainda não colocou em prática. Para isso:

- Configure o VS Code com a extensão Live Preview para hospedar um arquivo HTML simples.
- Realize uma requisição GET usando cURL no terminal e identifique os cabeçalhos retornados.
- Utilize o DevTools do navegador para inspecionar requisições e verificar o uso do protocolo HTTP.
- Diferencie porta local (ex.: 3000) e portas padrão (80 para HTTP, 443 para HTTPS) nas requisições.
- Abra o Postman, insira uma URL (por exemplo, www.alura.com.br) e envie uma requisição GET para visualizar o HTML retornado.
- Analise os cabeçalhos de requisição e resposta tanto no Postman quanto no DevTools.
- Crie e envie uma requisição POST no Postman simulando o envio de dados (ex.: dados de formulário).
- Verifique o content-type nas respostas e compare formatos como HTML, JSON e imagens.
- Execute novamente uma requisição via cURL e identifique a versão HTTP empregada.
- Liste e documente os principais métodos HTTP (GET, POST, PUT, DELETE, PATCH, HEAD, OPTIONS) utilizados na aula.

Para acessar o guia detalhado, consulte as transcrições da aula.

### Aula 2: O que aprendemos?

Nesta aula, aprendemos:

- A importância do modelo cliente-servidor na estruturação de aplicações web.
- Como hospedar uma aplicação web para facilitar o acesso por meio de um servidor.
- O uso do Visual Studio Code e Live Preview para visualizar aplicações locais.
- A diferença entre portas HTTP (80) e HTTPS (443) na comunicação.
- A evolução do protocolo HTTP e suas versões até o HTTP 3.
- Como utilizar o CURL e DevTools para inspecionar requisições HTTP.
- A estrutura e métodos das requisições HTTP, como GET, POST, PUT e DELETE.
- A função dos cabeçalhos HTTP e do content-type na comunicação web.

## Aula 3: Detalhes do HTTP, segurança e evolução

### Aula 3:  - Vídeo 1
### Aula 3:  - Vídeo 2
### Aula 3:  - Vídeo 3
### Aula 3:  - Vídeo 4
### Aula 3:  - Vídeo 5
### Aula 3:  - Vídeo 6
### Aula 3:  - Vídeo 7
### Aula 3:  - Vídeo 8
### Aula 3:  -
