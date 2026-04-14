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

### Aula 3: Corpo da requisição - Vídeo 1

Transcrição  
Já discutimos um pouco sobre como funcionam os cabeçalhos e este momento pode ser interessante para analisarmos o Postman, a fim de entendermos onde cada elemento de uma requisição HTTP está localizado. No Postman, conseguimos visualizar exatamente onde está cada parte de uma requisição HTTP.

Para começar, vamos realizar uma requisição GET para o site da Alura. No Postman, isso é feito da seguinte forma:

> GET https://www.alura.com.br

Podemos ver o site da Alura, onde realizaremos um GET para obter algumas informações. Ao solicitar o site da Alura, receberemos uma resposta contendo o HTML da página. Se clicarmos em Preview, o HTML será exibido em sua forma mais pura, sem processamento de CSS ou JavaScript, como feito no site da Alura. Assim, conseguimos visualizar o HTML da Alura e algumas informações pertinentes.

```html
<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width,initial-scale=1,minimum-scale=1.0">
    <title>Alura | Cursos online de Tecnologia</title>
    <meta name="description"
        content="Aprenda Programação, Front-end, Back-end, Data Science, UX, DevOps, Inovação e Gestão na maior plataforma de tecnologia do Brasil">
    <link rel="canonical" href="https://www.alura.com.br">
    <link rel="icon" href="/assets/favicon.1790606030.ico">
    <link rel="preconnect" href="https://fonts.googleapis.com">
    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
```

Explorando os cabeçalhos padrão do Postman  
A primeira delas são os headers (cabeçalhos) da requisição. Mesmo que não vejamos nenhum cabeçalho explícito, o Postman possui cabeçalhos padrão que são enviados em todas as requisições. É importante saber que, mesmo que não percebamos, o Postman pode estar enviando cabeçalhos. Esses são os cabeçalhos padrão que ele envia, como Cache-Control e Postman-Token, que são utilizados para o gerenciamento das requisições feitas pelo Postman.

```cmd
Cache-Control: no-cache
Postman-Token: <calculated when request is sent>
Host: <calculated when request is sent>
User-Agent: PostmanRuntime/7.45.0
Accept: */*
Accept-Encoding: gzip, deflate, br
Connection: keep-alive
```

O cabeçalho Host é calculado quando a requisição é enviada, pois a URL pode ser alterada a qualquer momento. O User-Agent, por exemplo, não utiliza o Chrome ou Firefox, mas sim o próprio cliente HTTP do Postman em tempo real. Além disso, temos o Accept, Accept-Encoding e Connection.

Analisando a resposta HTTP e seus cabeçalhos  
Aqui estão algumas informações de requisição padrão que o Postman sempre faz. O mais importante é analisarmos os headers e o corpo da requisição que ele devolve. Temos o HTML e os headers associados a ele. Por exemplo, podemos ver o Content-Type, que é text/html, e o Charset ou Encoding, que é crucial, pois pode haver conflitos de codificação. Neste caso, está usando UTF-8. O servidor é o Cloudflare.

```cmd
Date                Thu, 21 Aug 2025 18:30:39 GMT
Content-Type        text/html; charset=UTF-8
Transfer-Encoding   chunked
Connection          keep-alive
Server              cloudflare
Nel                 {"report_to":"cf-nel","success_fraction":0.0,"max_age":604800}
Vary                Accept-Encoding
Expires             Thu, 21 Aug 2025 18:00:39 GMT
Cache-Control       public, max-age=1800
Report-To           {"group":"cf-nel","max_age":604800,"endpoints":[{...}]}
CT-Cache-Status     DYNAMIC
Content-Encoding    br
```

Para identificar o corpo de uma resposta e de uma requisição, podemos observar dessa forma. No Postman, é possível ver toda a requisição na parte superior, que cuida da requisição, enquanto a parte inferior apresenta a resposta. O status code no Postman, por exemplo, apresenta 200 OK, indicando que a requisição foi bem-sucedida. Também podemos ver o tamanho da página web e o tempo que levou para processar o corpo da requisição.

Compreendendo o processo HTTP e introduzindo novos tópicos  
É importante compreender o processo HTTP como um todo. Podemos observar todas as partes de uma requisição. Neste caso, não houve corpo de requisição, pois não é necessário enviar nada; geralmente, o método GET não requer informações para envio. A resposta já contém um corpo, que é o próprio HTML recebido.

Para introduzir os próximos tópicos, se clicarmos no canto superior direito, onde há um símbolo semelhante ao HTML, que é o code, conseguimos ver o HTTP, que é o modelo padrão. Geralmente, o Postman abre por padrão o URL. Temos o HTTP, onde ele utiliza o método GET e a versão do HTTP, que é 1.1. Existem outras versões do HTTP, e será interessante discutirmos sobre elas posteriormente.

```cmd
GET / HTTP/1.1
Host: www.alura.com.br
```

### Aula 3: Cabeçalhos da requisição - Vídeo 2

Transcrição  
Agora que já entendemos como funciona a parte de status code, outra parte importante que nos ajuda a definir o que esperar de resposta, o que precisamos solicitar e como solicitar, para receber os status codes adequados, é compreender como funcionam os cabeçalhos HTTP. Vamos entender melhor a estrutura dos cabeçalhos no HTTP.

Podemos ver um exemplo de uma requisição HTTP, especificamente uma requisição POST. Temos a URI, o protocolo HTTP 1.1. Abaixo, começam os cabeçalhos, que vão até onde começa a abertura de chaves, que é o corpo da requisição, representado por um JSON utilizado como exemplo.

Exemplificando uma requisição POST  
Para ilustrar, veja o seguinte exemplo de requisição POST:

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

Quais cabeçalhos temos? São quatro: o host, que é a URL ou domínio que queremos acessar; o content-type, que indica o tipo de conteúdo que estamos encaminhando, como application/json, mas poderia ser XML, HTML ou uma imagem; o authorization, muito utilizado para verificações de autorização e logins, que aqui é um bearer token, geralmente um código extenso; e o content-length, que é o tamanho do corpo da requisição. Geralmente, ele conta os caracteres do corpo, e o navegador já converte isso em um número, indicando o tamanho da requisição. Isso é importante, pois o servidor pode devolver a solicitação informando que a requisição está muito longa, como no caso do payload too large, um dos status codes possíveis.

Estrutura dos cabeçalhos HTTP  
Essa é a estrutura de um cabeçalho HTTP. Geralmente, ao ver uma requisição web, observamos a parte de cabeçalhos. Esses quatro itens formam uma estrutura de cabeçalhos, dividida pela estrutura de chave e valor. A chave pode ser host, content-type, authorization, seguida de dois pontos e o valor associado. O que divide cada um dos cabeçalhos é uma estrutura chamada CRLF. Não há ponto e vírgula no final, nem indentação. O que separa cada cabeçalho na requisição é a quebra de linha.

Vamos ver alguns dos cabeçalhos mais comuns em uma requisição HTTP. Temos o accept, que indica o tipo de resposta que aceitamos. Existem recursos que são apenas JSON, mas podemos querer uma versão em texto plano ou XML. Embora o JSON seja a linguagem predominante na web, muitos sistemas antigos utilizam formatos de dados mais antigos. Por isso, podemos solicitar ao servidor uma informação diferente, como aceitar XML em vez de JSON.

Especificando tipos de conteúdo e autorização  
Por exemplo, podemos especificar os tipos de conteúdo que aceitamos na resposta com o cabeçalho Accept:

```cmd
Accept: text/html, application/json
```

O authorization pode conter credenciais. No exemplo da requisição, foi usado um bearer token, um tipo de token moderno para aplicações. No cabeçalho da requisição, essa informação ainda fica aberta, por isso não é ideal enviar usuário e senha. Geralmente, enviamos um token ou chave de API, um código extenso e alfanumérico que identifica o usuário que está acessando o sistema.

Utilizando o User-Agent e Accept-Language  
O User-Agent é bastante utilizado por navegadores ou outros clientes HTTP, que enviam essa informação por padrão. Ele identifica o navegador que está sendo utilizado. Algumas aplicações podem não funcionar em determinados navegadores, solicitando o uso de uma versão mais atualizada do Chrome ou Firefox. Antigamente, muitas aplicações rodavam apenas no Internet Explorer, e havia avisos informando que o uso de outros navegadores poderia causar problemas. O User-Agent ajuda o servidor a saber se a requisição vem de um navegador que suportará a resposta.

Às vezes, utilizamos uma versão muito antiga de um navegador, e o HTML já possui um recurso novo que o navegador ainda não renderiza. Nesse caso, o User Agent pode ajudar a obter como resposta a sugestão de atualizar o navegador para utilizar o site corretamente. Temos também o Accept Language, que geralmente é usado quando precisamos lidar com questões de idioma. Por exemplo, ao acessar o site da Amazon Espanha para comprar um produto, mesmo estando em outro país, podemos querer que o site seja exibido em português. Se o site permitir, podemos enviar o Accept Language como português do Brasil, inglês americano ou qualquer outro idioma, e ele será traduzido para nós, adaptando o site ao idioma desejado.

Preferências de idioma e tamanho de conteúdo  
Podemos especificar as preferências de idioma com o cabeçalho Accept-Language:

```cmd
Accept-Language: pt-BR, en-US
```

Outro exemplo ocorre quando queremos comprar um produto para ser entregue a um amigo em uma região diferente. Se não dominarmos o idioma do site, podemos alterar o Accept Language para que ele traduza para o idioma especificado, caso o servidor aceite esse tipo de requisição.

Temos o Content Length, que os navegadores geralmente processam previamente para determinar o tamanho da requisição, pois às vezes o servidor pode informar que o payload está muito grande. O Content Type funciona de maneira semelhante ao Accept, permitindo que informemos ao servidor o tipo de conteúdo que estamos enviando.

Importância do campo Date e identificação do servidor  
O campo Date indica a data e hora da requisição, o que é importante para evitar conflitos. Em situações de concorrência, como em sistemas de venda de passagens aéreas ou ingressos, o Date ajuda a determinar quem estava na fila primeiro e tem prioridade no uso do recurso.

O Server indica de onde veio a requisição. Nossas aplicações podem estar hospedadas na nuvem, em um serviço externo ou próprio, e o Server nos informa a origem da requisição.

Analisando cabeçalhos de resposta e cache  
No exemplo do site da Alura, ao abrir o DevTools e atualizar a página, podemos ver a requisição para alura.com.br e algumas informações, como a URL da requisição e o status code 200. O site pode estar em cache, mas ainda assim retorna 200, indicando que não houve atualização.

Podemos ver informações de cabeçalho da resposta, como a data e o campo expires, que indica quando uma nova requisição precisará ser feita fora do cache. Isso é usado para atualização de cache, especialmente em navegadores. O servidor, neste caso, é a Cloudflare, que hospeda a Alura e é uma das empresas mais importantes na internet atualmente.

Identificando a plataforma e versão do navegador  
Entre os cabeçalhos de requisição enviados, temos o User Agent e a plataforma. A plataforma pode ser, por exemplo, Windows, e o navegador pode enviar essa informação para que o servidor identifique o sistema operacional. O User Agent mostra o navegador, como Mozilla, WebKit (para Safari) e Chrome, indicando que a requisição vem de um navegador comum. A versão do navegador, como 537.36 ou 139.0, é importante para o servidor saber qual versão está sendo utilizada e, se necessário, sugerir uma atualização.

Esses exemplos mostram como a web trabalha com cabeçalhos para identificar o tipo de informação enviada e esperada, auxiliando o servidor a responder com base em filtros específicos.

### Aula 3: Garantindo segurança em agendamentos de spa - Exercício

A Calmaria Spas, uma plataforma que conecta usuários a experiências de bem-estar e serviços de spas, oferecendo agendamentos online e personalização de tratamentos de relaxamento, está preocupada com a segurança das informações dos usuários durante o processo de agendamento online. A equipe de desenvolvimento que você faz parte está implementando um sistema de autenticação que utiliza tokens para verificar a identidade dos usuários antes de permitir o acesso aos serviços de agendamento.

Como o cabeçalho HTTP "Authorization" pode ser utilizado para garantir que apenas usuários autenticados possam acessar e agendar serviços na plataforma?

Alternativa correta  
O cabeçalho HTTP Authorization envia um token de autenticação junto com a requisição. Esse token, geralmente do tipo Bearer, é gerado após o login e comprova a identidade do usuário. O servidor valida o token e, se for válido, libera o acesso; caso contrário, nega a requisição, garantindo que apenas usuários autenticados acessem a plataforma.

> Correta, pois o uso do cabeçalho "Authorization" com um Bearer Token é uma prática padrão para autenticação, permitindo que o servidor valide a identidade do usuário antes de conceder acesso aos serviços.

### Aula 3: Status codes - Vídeo 3

Transcrição  
Agora que já entendemos mais sobre como funciona a base do protocolo HTTP com os métodos e a parte de requisição e resposta, precisamos compreender alguns detalhes que são apresentados no momento em que fazemos uma requisição e obtemos uma resposta. Podemos começar com um dos pontos mais importantes, principalmente no desenvolvimento de aplicações: os status codes do HTTP.

Quando seguimos um protocolo, especialmente os protocolos web, é importante entender que toda requisição obterá, antes do corpo da resposta, um status daquela resposta. Existe uma série de status codes que o HTTP possui, os quais podem nos ajudar a entender determinadas informações. Um dos status codes mais comuns que já devemos ter visto é o 404, "não encontrado". Isso ocorre, por exemplo, quando estamos acessando uma página na web e a conexão com a internet cai. O navegador não consegue retornar o site procurado e, por isso, devolve um status code indicando que o recurso não foi encontrado, devido a uma falha na infraestrutura. Isso ajuda o navegador a entender que, naquele momento, estamos sem conexão com a internet.

Explorando as categorias dos status codes HTTP  
Da mesma forma, alguns aplicativos conseguem avisar quando estamos sem conexão, seja por ativar o modo avião ou por estar em um local sem internet. Quem garante isso são certos status codes do HTTP, que permitem enviar um status indicando que o recurso não foi encontrado.

Vamos explorar as categorias dos status codes HTTP para entender os tipos de respostas que podemos ter a partir de cada tipo de status code. Quando fazemos uma solicitação, podemos obter uma série de categorias ordenadas por números. A categoria de número 100, que vai de 100 até 199, é a categoria informativa. Ou seja, a solicitação enviada devolverá uma resposta cujo objetivo é fornecer alguma informação sobre o recurso solicitado. Pode ser algo relacionado ao servidor ou a alguma configuração interna que desejamos obter. Não se trata necessariamente de obter um HTML, um JSON ou um recurso específico, mas sim de obter alguma informação sobre o recurso.

Detalhando os status codes informativos  
Alguns códigos dessa faixa, de 100 a 199, incluem o status code "continue", que indica que podemos continuar a operação a partir daquele ponto, sendo muito usado para microserviços. Outro exemplo é o código 103, "processing", utilizado para mostrar que a solicitação ainda está em processamento, como em casos de pagamento, onde é necessário informar que a requisição ainda está em processamento.

Agora, passando para os status codes que vão de 200 a 299, essa faixa é voltada para resultados corretos ou de sucesso. Geralmente, quando acessamos uma página da web e ela é carregada corretamente, obtemos o status code 200, que é o "OK". Esse código é utilizado para a maioria das requisições bem-sucedidas, quando o serviço consegue devolver a informação solicitada. Outros códigos dessa faixa incluem o 201, "created", muito utilizado quando enviamos informações ou fazemos um post na web. Há também o status code "accepted", que significa que a requisição foi aceita e podemos continuar. Existem detalhes específicos para cada status code, mas o importante é entender que a faixa de 200 a 299 representa tipos de sucesso.

Compreendendo os status codes de redirecionamento  
Em seguida, temos os status codes de 300 a 399, que são de redirecionamento. Quando acessamos um recurso HTTP, é comum que algumas páginas sejam redirecionadas. Um exemplo simples é quando acessamos o site da Amazon digitando amazon.com e somos redirecionados para o site da Amazon Brasil. Isso ocorre em e-commerces ou páginas web com versões em vários países, onde, a partir do nosso IP, somos redirecionados para o país onde o serviço é mais otimizado. Por exemplo, podemos fazer uma compra no site da Amazon nos Estados Unidos, mas há restrições. O ideal é comprar no site da Amazon Brasil. Para esses cenários, existem códigos que indicam redirecionamento, apontando para a página correta.

Depois, temos os status codes de 400, que são erros voltados à parte do cliente. Esses erros podem ocorrer por vários fatores, como digitar uma URL errada, resultando em um 404, "not found". Isso acontece quando digitamos incorretamente o endereço do site no navegador. Outros status codes dessa faixa incluem "não autorizado", "proibido", "requisição muito grande" ou "URL muito longa". São erros que ocorrem devido a problemas na solicitação do cliente.

Analisando os status codes de erro do servidor  
Por último, temos os erros 500, que são erros de servidor. Nesse caso, a culpa não é do cliente, mas sim de um erro interno na aplicação que impede a obtenção da solicitação. Isso pode ocorrer por diversos fatores, como um bug interno ou um método ainda não construído. Esses problemas resultam em um erro 500. É comum encontrar sites mais antigos que não escondem esses status codes dos clientes e apresentam "internal server error", erro 500. Isso indica um erro interno no servidor, e é necessário aguardar uma correção para acessar o recurso adequadamente.

Agora, vamos explorar em mais detalhes como funcionam alguns dos códigos mais utilizados pelo HTTP. Como mencionado anteriormente, temos o status code "continue", código 100, que indica que o servidor recebeu a solicitação e podemos continuar a partir dali. Esse código é utilizado para indicar que podemos prosseguir após uma etapa.

Detalhando os status codes de sucesso  
Temos o 101, que é a troca de protocolos. Por exemplo, a troca de HTTP para HTTPS, geralmente feita por redirecionamento. Se não houver redirecionamento, o código 101 pode indicar a troca de protocolos.

Em seguida, temos o 103. Peço desculpas pela confusão anterior: o 102 é "processing" e o 103 é "early hints". O "early hints" apresenta os cabeçalhos que algumas requisições podem informar. Por exemplo, ao usar o método HEAD para obter informações sobre cabeçalhos de uma requisição, podemos receber o código de status 200, indicando "OK", ou o 103, que apresenta cabeçalhos de respostas antes do HTTP final.

Agora, vamos para os status codes de sucesso. O principal deles é o 200, "OK", que é o mais comum. Qualquer solicitação bem-sucedida resulta em um status 200, além da resposta da requisição, que pode ser um HTML, uma imagem ou um JSON. O 201, "created", é utilizado para quando criamos um novo recurso, como adicionar um produto ao carrinho ou um novo endereço. O 204, "no content", indica que a solicitação foi bem-sucedida, mas não houve devolutiva de conteúdo. Isso é comum em atualizações put ou delete, onde não há retorno de informação. O 206, "partial content", ocorre quando apenas parte do recurso é devolvida, como em downloads ou serviços de streaming.

Explicando os status codes de redirecionamento  
Agora, vamos para os status codes da faixa de 300. O 301, "moved permanently", indica que um recurso foi movido permanentemente para outra página. O 302, "found", é utilizado para indicar que um recurso foi encontrado, mas geralmente não é o status code final. O 304, "not modified", é utilizado para verificar o status de um recurso que não foi modificado.

Pode ser necessário, em alguns casos, ter dois campos para gerenciar o tempo de processamento. Um campo indicaria o status, para saber se o valor já foi alterado ou não, e outro mostraria em que estágio de processamento o recurso se encontra. Sabemos que existem vários status codes diferentes, mas eles representam coisas distintas. O processo indica que algo está em andamento, enquanto o not modified representa um resultado final, indicando que nada foi alterado.

Abordando os status codes de erro do cliente  
Agora, vamos abordar os status codes de erros, 400 e 500. Começando pelo 400, o Bad Request ocorre quando uma solicitação é feita de forma incorreta, o que pode acontecer por diversos motivos. Geralmente, o Bad Request é utilizado quando enviamos um POST e o corpo da requisição não corresponde ao que deveria ser enviado. Isso pode ocorrer se o navegador alterar algum recurso inadvertidamente, se uma aplicação no front-end fizer uma alteração no back-end, ou se o corpo da requisição JSON estiver incorreto. Nesses casos, o sistema retornará um Bad Request, com o status code 400.

O status code 401 indica que a solicitação não é autorizada. Isso ocorre quando é necessário fazer login. Por exemplo, ao tentar acessar um repositório privado no GitHub sem estar logado, o sistema retornará um 401, indicando que a autorização é necessária. Em alguns casos, o sistema pode redirecionar para a página de login, retornando um 302. Algumas aplicações informam que o usuário não está autorizado a ver o projeto, enquanto outras redirecionam para a página de login.

Explorando os status codes de erro do servidor  
O status code Forbidden ocorre quando o login foi realizado, mas o acesso a uma página específica não é permitido. Nesse cenário, o usuário pode ter autorização para acessar a aplicação, mas está proibido de acessar aquele recurso específico. Isso é comum em sistemas com diferentes papéis, como administrador, gerente, coordenador e usuário comum, onde diferentes usuários têm diferentes níveis de acesso.

O Not Found, ou 404, é um clássico. Ele indica que o recurso desejado não foi encontrado. Isso pode ocorrer ao digitar um endereço incorreto na barra de endereços e tentar acessar um site inexistente.

O status code 405 pode parecer que estamos apresentando mais códigos de erro do que outros, mas, de fato, ao desenvolver uma aplicação, é mais comum nos atentarmos a esses tipos de erros. Em projetos de software, há muitas discussões entre sistemas de back-end e front-end para garantir que a comunicação entre as equipes esteja correta. Os status codes do HTTP são fundamentais para assegurar que a comunicação está correta, seja no front-end ou no back-end da aplicação.

Discutindo os status codes de timeout e segurança  
O Request Timeout, ou 408, ocorre quando a internet está fraca, dificultando o acesso a um recurso. Isso pode acontecer se a requisição for muito longa e não houver tempo suficiente para obter a resposta completa. Em tais casos, o sistema entra em Request Timeout. Isso é comum no desenvolvimento de aplicações web, onde há valores padrão no servidor para evitar travamentos em requisições muito grandes. Se necessário, o sistema pode devolver um Timeout e sugerir que a requisição seja dividida em partes menores.

O Payload Too Large, ou 413, ocorre quando uma requisição é enviada com um JSON muito grande ou com muita informação. Um exemplo comum é o envio de imagens de perfil, onde alguns sistemas não conseguem comprimir a imagem e limitam o tamanho permitido. Isso também acontece com e-mails, que não podem ter anexos maiores que 25MB. O Payload Too Large indica que a requisição excede o tamanho máximo permitido.

O Too Many Requests, ou 429, é utilizado por questões de segurança, envolvendo rate limit. Isso ocorre quando uma página é acessada muitas vezes em um curto período. Em vez de travar ou cortar o acesso, o sistema entra em Too Many Requests, indicando que o número de requisições foi excedido. Isso é mais comum em aplicações que fazem muitas requisições, como web scraping, ou em casos de bugs que causam múltiplas chamadas a uma API.

Concluindo com os status codes de erro do servidor  
Os erros 500 são erros do servidor, não da aplicação ou do cliente. O erro 500 é o mais tradicional e pode ocorrer por diversos motivos, como bugs na aplicação, excesso de uso de memória, problemas de conexão com o banco de dados, entre outros. Quando uma exceção é lançada, o sistema retorna um erro 500 ao cliente. Se os erros estiverem na faixa dos 400, podemos corrigir a aplicação e enviar a alteração. No entanto, erros 500 dependem do servidor onde a aplicação está hospedada, tornando a correção mais complexa.

O Not Implemented, ou 501, ocorre quando alguns recursos estão habilitados, mas ainda não foram implementados. Isso é comum em testes beta, onde o usuário pode testar até certo ponto, mas algumas funcionalidades ainda estão em desenvolvimento.

O Bad Gateway, ou 502, ocorre quando uma requisição é considerada inválida, seja por uso interno ou externo da rede. Isso pode acontecer devido a configurações incorretas de rede, como endereços IP errados, resultando em um Bad Gateway.

O Service Unavailable, ou 503, é utilizado quando um serviço está em manutenção. Serviços web críticos precisam estar disponíveis 99,99% do tempo, o que significa que podem ficar indisponíveis por, no máximo, seis minutos por ano. Durante manutenções programadas, o sistema pode retornar um 503, indicando que o serviço está temporariamente indisponível.

Resumindo a importância dos status codes  
Em resumo, os status codes são essenciais para orientar quem está consumindo a aplicação, seja um front-end ou alguém acessando a URL diretamente. Eles ajudam a seguir o protocolo HTTP e a garantir que o cliente entenda como a aplicação funciona. Existem guias e boas práticas sobre como cada endpoint deve lidar com os status codes. A documentação do MDN, mantida pela Mozilla, é uma excelente referência para entender os status codes e o protocolo HTTP.

### Aula 3: Para saber mais: redirecionamento HTTP

Entendimento do Redirecionamento  
O redirecionamento HTTP é um mecanismo que, quando acionado, instrui o navegador ou cliente a buscar o recurso em uma nova URL. Ao receber um código de status na faixa dos 300, o cliente interpreta que precisa direcionar sua requisição para outro local indicado no cabeçalho da resposta. Esse processo assegura que o usuário seja encaminhado para a página correta, mesmo que o endereço original tenha sido alterado ou reestruturado.

Distinção Entre 301 e 302  
Entre os códigos de redirecionamento, os mais comuns são o 301 e o 302. O código 301 (Moved Permanently) indica que o recurso foi movido de forma permanente para uma nova URL. Esse redirecionamento normalmente é cacheado pelo navegador e pelos mecanismos de busca, o que pode influenciar positivamente o ranqueamento e a indexação, desde que a mudança seja definitiva.

Por outro lado, o código 302 (Found) sinaliza um redirecionamento temporário. Embora o cliente seja encaminhado para outro endereço, ele entende que o recurso pode voltar ao local original em requisições futuras. Por ser temporário, esse tipo de redirecionamento pode não ser cacheado da mesma maneira, impactando como as atualizações na URL são percebidas pelos mecanismos de busca.

Boas Práticas e Considerações Técnicas  
Ao optar por um tipo de redirecionamento, é importante considerar o contexto da aplicação. Redirecionamentos permanentes (301) são ideais para migrações de site, pois comunicam aos motores de busca que a mudança é definitiva. Já os redirecionamentos temporários (302) são mais apropriados para testes ou atualizações momentâneas, onde se espera retornar ao endereço original posteriormente.

Exemplo de como pode ser definido um redirecionamento em uma resposta HTTP:

```cmd
HTTP/1.1 301 Moved Permanently
Location: http://novosite.com
```

Entender essas nuances não só melhora o gerenciamento dos recursos web, mas também contribui significativamente para a experiência do usuário e a otimização do SEO. Ao aplicar corretamente esses conceitos, as aplicações podem lidar de forma mais robusta com mudanças de URL e migrações, garantindo que os acessos dos usuários sejam sempre direcionados para o conteúdo correto.

### Aula 3: Otimizando feedback de treinos na Runner Circle - Exercício

A Runner Circle, uma plataforma social dedicada a corredores, onde os usuários podem compartilhar treinos, metas e desafios, está desenvolvendo um novo recurso que permite aos usuários compartilhar seus treinos e receber feedback em tempo real. Durante os testes, a equipe percebeu que, em algumas situações, os usuários não estão recebendo atualizações sobre o status de seus uploads de treinos. A equipe de desenvolvimento que você faz parte precisa garantir que os usuários sejam informados sobre o progresso de seus uploads de forma eficaz.

Como você utilizaria os status codes HTTP para informar os usuários sobre o progresso de seus uploads de treinos na Runner Circle?

Resposta correta  
Utilizar o status code 100 (Continue) para indicar que o upload está em andamento, o status code 201 (Created) para confirmar o sucesso do upload, o status code 413 (Payload Too Large) para erros de cliente, e o status code 500 (Internal Server Error) para erros de servidor, sempre com mensagens claras no corpo da resposta.

> Correta, pois essa abordagem utiliza adequadamente os status codes HTTP para comunicar o progresso e o resultado dos uploads, fornecendo informações claras e específicas sobre o estado da operação e orientações para o usuário.

### Aula 3: Versões do HTTP - Vídeo 4

Transcrição  
Quando a web foi idealizada, ela não foi concebida para suportar o que vemos hoje. Atualmente, temos uma vasta gama de serviços rodando na internet, como streamings, jogos online e muitos processos que operam de forma assíncrona. Esses serviços escalam para milhões ou bilhões de usuários, e todas as alterações necessárias para suportar esse tipo de aplicação precisaram ser implementadas na internet e nos protocolos HTTP, permitindo que a internet crescesse até a magnitude que possui atualmente.

Assim como várias aplicações passam por atualizações, o HTTP também passou por certas atualizações, assim como a infraestrutura da web inteira. Podemos pensar na evolução das redes móveis, como o 3G, 4G e agora o 5G, com discussões contínuas sobre formas de tornar a internet mais rápida. Tanto a infraestrutura física quanto a lógica da internet passam por mudanças.

Explorando as versões do HTTP  
Podemos dividir as principais versões do HTTP em três categorias: HTTP, que engloba as versões 1 e 2, usadas por padrão hoje em dia; HTTPS, que é o HTTP com uma camada de segurança através de criptografia e certificados digitais; e HTTP 3, que está sendo introduzido em vários servidores para permitir o uso de tecnologias mais modernas, visando um ganho de performance em aplicações críticas ao desenvolvimento de software atual.

Vamos entender as diferenças principais entre essas três versões de HTTP. A questão da segurança é a mais importante. O HTTP, por padrão, não é seguro, pois possui vulnerabilidades que tornam os dados públicos, permitindo que qualquer pessoa os rastreie. Alterações foram feitas no protocolo para garantir segurança no envio de dados. Por muito tempo, não era possível realizar pagamentos de maneira segura na web até a introdução do HTTPS, que trouxe certificados digitais e criptografia. O HTTP 3 já é seguro por padrão, com mecanismos nativos para impedir vulnerabilidades, ao contrário do HTTPS, que foi uma adaptação do HTTP.

Comparando protocolos de transporte e multiplexação    
Quanto ao protocolo de transporte, o HTTP e o HTTPS ainda utilizam o protocolo TCP, enquanto o HTTP 3 opera através de uma versão diferente, não utilizando o TCP. Isso permite uma transferência de informações mais rápida, embora ainda exista a questão dos problemas de pacotes entre TCP e UDP.

A multiplexação, que permite várias requisições simultâneas em uma mesma conexão, é suportada pelo HTTP e HTTPS, mas com certos limites. O HTTP 3, pensado para acessos simultâneos, é bem suportado pelo UDP, permitindo múltiplos acessos ao mesmo tempo.

Avaliando o desempenho e a adoção do HTTP/3  
Em termos de desempenho, o HTTP e o HTTPS possuem limitações, especialmente em acessos extensos de dados. O HTTP 3, por outro lado, foi projetado para ter uma alta margem de transferência de dados, aprimorando o desempenho. É interessante notar que, em versões antigas do HTTP, não se transferia mais do que quilobytes de informação, o que era o máximo necessário na época.

Atualmente, observamos que uma série ou um vídeo no YouTube pode ter mais de 30 gigabytes, e um jogo inteiro para download pode ultrapassar 100 gigabytes. Os protocolos antigos do HTTP não são mais adequados para esse volume de dados e transferência de informações. O HTTP/3 surge para resolver esse tipo de problema. A adoção do HTTP/3 é um ponto importante. Quando utilizamos URLs ou mesmo requisições no Postman, ainda se usa muito o HTTP, que é o padrão da web 1.1. Ele já realiza todas as requisições necessárias. As versões do HTTPS e do HTTP são amplamente adotadas na internet e continuarão a ser até que não suportem mais o volume de dados ou o modelo de protocolo atual.

Testando diferentes versões do HTTP com curl  
O HTTP/3 está em processo de adoção. Algumas empresas já utilizam o HTTP/3 por padrão, mas nem todos os servidores de hospedagem trabalham com ele por padrão. Em algum momento, ele será amplamente adotado. Vamos agora explorar como testar essas diferentes versões do HTTP utilizando, por exemplo, o curl.

Para começar, podemos testar como fazer uma requisição na web de um site utilizando o HTTP/3. No terminal, utilizamos o seguinte comando:

> curl --http3 -I http://www.cloudflare.com

Ao digitar esse comando, a requisição é feita no HTTP/3, mas a resposta é devolvida no HTTP/1.1. Isso ocorre porque, ao usar a versão HTTP, é normal que a resposta seja redirecionada para o HTTPS, como indicado pelo status code 301 (movido permanentemente).

Comparando tempos de resposta entre versões do HTTP  
Com essa versão do curl, podemos testar tanto o HTTP/3 quanto outras versões do HTTP. Por exemplo, para testar o HTTP/2, podemos usar:

> curl --http2 -I http://www.cloudflare.com

Ao repetir o comando, podemos substituir o HTTP/3 pelo HTTP/2, obtendo a mesma resposta e status code. É importante notar que o protocolo utilizado em cada consulta é diferente, mesmo que a resposta mantenha o HTTP/1.1.

Podemos verificar o tempo de cada requisição para diferentes versões do HTTP. Por exemplo, ao executar uma consulta no site usando HTTP/1.1, utilizamos o seguinte comando:

> curl --http1.1 -w "Time: %{time_total}s\n" -o /dev/null -s https://api.scryfall.com/cards/random

O tempo foi de 0,61 segundos. Ao trocar para HTTP/2, o comando é:

> curl --http2 -w "Time: %{time_total}s\n" -o /dev/null -s https://api.scryfall.com/cards/random

E o tempo foi de 0,78 segundos. Com o HTTP/3, observamos algumas diferenças ao usar:

> curl --http3 -w "Time: %{time_total}s\n" -o /dev/null -s https://api.scryfall.com/cards/random

O HTTP/1.1 é o mais rápido porque não realiza verificações de segurança antes da requisição, não havendo processo de criptografia. Já o HTTP/2, com 0,78 segundos, envolve mais segurança, especialmente com o HTTPS, realizando verificações que o HTTP/1.1 não faz. O HTTP/3, por ser seguro por padrão, é mais demorado. Embora o HTTP/3 seja mais rápido em desempenho, ele ainda não é amplamente utilizado. As requisições padrão são feitas no HTTP/2, e a necessidade de trocar a versão do protocolo torna a requisição mais demorada. A vantagem do HTTP/3 é que ele é seguro por definição, diferentemente do HTTP/2 e do HTTP/1.1.

### Aula 3: Para saber mais: evolução do HTTP

O protocolo HTTP (Hypertext Transfer Protocol) é a base da comunicação na web, permitindo a transferência de documentos e dados entre navegadores e servidores. Desde sua criação, ele passou por diversas evoluções para lidar com as crescentes demandas de desempenho, segurança e escalabilidade da internet.

HTTP/1.0 e HTTP/1.1  
O HTTP/1.0 surgiu em 1996 como a primeira padronização formal, porém cada requisição exigia uma nova conexão TCP, tornando-o ineficiente para páginas mais complexas. Em 1999, o HTTP/1.1 introduziu conexões persistentes e melhorias como o pipeline de requisições, que reduziram a latência, mas ainda apresentavam limitações com múltiplos recursos carregados simultaneamente.

HTTP/2  
Lançado em 2015, trouxe mudanças significativas, como multiplexação de streams, compressão de cabeçalhos (HPACK) e priorização de requisições. Essas melhorias diminuíram a sobrecarga das conexões e tornaram a navegação muito mais rápida, especialmente em sites com muitos elementos (imagens, scripts, folhas de estilo).

HTTP/3  
Baseado no protocolo QUIC (desenvolvido inicialmente pelo Google), o HTTP/3 substitui o TCP pelo UDP, reduzindo a latência e aumentando a resiliência em redes instáveis. Além disso, incorpora de forma nativa TLS 1.3, trazendo maior segurança. Hoje, grandes provedores de conteúdo e navegadores já oferecem suporte a esse padrão, que está se tornando a nova base para a web moderna.

Referências

- RFC 1945 e RFC 2616 – documentos oficiais sobre HTTP/1.0 e HTTP/1.1.
- RFC 7540 – especificação do HTTP/2.
- RFC 9114 – especificação do HTTP/3.
- Site oficial do IETF [Internet Engineering Task Force](https://www.ietf.org).
- [Cloudflare Learning Center](https://www.cloudflare.com/learning) – guias introdutórios sobre protocolos da web.

### Aula 3: Armazenamento de informações - Vídeo 5

Transcrição  
Além da segurança, uma das questões mais importantes em uma aplicação web é o armazenamento de informações. Isso se aplica tanto ao lado do cliente quanto ao banco de dados, pois algumas informações precisam ser persistidas no cliente, não apenas no servidor.

Vamos considerar um exemplo simples. Ao acessar o site MermaidJS, que é utilizado para criar diagramas, podemos observar que ele está no modo escuro. Se alterarmos para o modo claro e atualizarmos a página, teoricamente, o site deveria retornar ao modo escuro, pois o valor padrão pode ser o do sistema da máquina ou a versão escura. No entanto, o site mantém a configuração no modo claro, indicando que ele persiste essa informação no navegador. Assim, ao mudar para o modo escuro e atualizar a página novamente, o estado permanece. Isso demonstra que o site possui um mecanismo para persistir informações no navegador, permitindo que ele saiba quais configurações foram guardadas, mesmo após uma atualização.

Explorando o uso de cookies para persistência de dados  
Um dos sistemas mais comuns para realizar essa persistência é através de cookies. Por exemplo, ao utilizar o Postman para consultar o site da Amazon, ao enviar uma requisição, recebemos o HTML da Amazon. Ao verificar os cookies, observamos que muitos são utilizados, como o i18n, que é importante para internacionalização e definição de idioma. O cookie BLR pode estar relacionado a questões monetárias, enquanto IPTBR refere-se ao idioma. Assim, ao acessar a Amazon novamente, o site já possui informações sobre o idioma e a moeda, garantindo que o conteúdo esteja adequado às preferências regionais da pessoa usuária.

Quando diversos sites perguntam se desejamos guardar cookies, eles estão se referindo a esse tipo de informação: idioma, moeda, entre outros. Em cerca de 90% dos e-commerces, essas informações são armazenadas por padrão, pois os sites desejam carregar o conteúdo de acordo com as preferências regionais da pessoa usuária.

Analisando o papel de sessões e cookies no contexto de login  
Um dos usos mais comuns de sessões e cookies é no contexto de login.

Fizemos o login no GitHub para demonstrar que, caso fechemos a aba e retornemos ao Postman, ao abrir o GitHub novamente, ele nos direciona para a tela de login, em vez de abrir diretamente a página do GitHub. Isso ocorre porque todos aqueles formulários de login, que às vezes apresentam o campo "Remember Me" para lembrar a pessoa usuária que está acessando o sistema, são geridos por cookies e sessões. Todo esse processo de reconhecimento do login feito na máquina envolve informações armazenadas no cliente, neste caso, no navegador.

Por exemplo, se tentarmos acessar o GitHub pelo Postman, o login do nosso usuário não seria realizado, pois são contextos diferentes. No GitHub, o login já efetuado é armazenado em uma sessão, e outras informações podem ser guardadas por cookies. Este é um exemplo claro de como algumas informações são armazenadas, incluindo preferências como o idioma utilizado no GitHub. Se houver um cookie que armazene essa informação para traduções, ele também pode ser utilizado. Essas pequenas alterações geralmente são guardadas por cookies, para que, caso a informação seja recarregada no navegador, ela já esteja configurada, evitando a necessidade de buscar essa informação no banco de dados ou mantê-la em um servidor. Isso pode ser vantajoso ou desvantajoso, dependendo de como a aplicação é configurada.

Examinando o impacto do armazenamento de sessões em e-commerces  
Um exemplo interessante é o e-commerce. Quando criamos um carrinho, como na Amazon, algumas aplicações armazenam o carrinho como um cookie ou como parte da sessão. Se criarmos um pedido em um computador e tentarmos finalizá-lo em outro, alguns e-commerces possuem mecanismos internos para guardar o carrinho, enquanto outros não. Assim, ao abrir um carrinho novo em outro computador, ele pode estar zerado. Este é um exemplo comum de sessão, onde a informação armazenada apenas no lado do cliente, e não no servidor, pode resultar em uma quebra na experiência do usuário.

Refletindo sobre a evolução da web e a importância do armazenamento e segurança  
Com isso, percebemos que a web evoluiu de um simples envio e recebimento de mensagens, como era na década de 90, para um ambiente com diversas preocupações, especialmente em armazenamento e segurança. É crucial que qualquer pessoa desenvolvedora compreenda os mecanismos da web para implementar corretamente esses sistemas e criar produtos adequados à experiência desejada para a aplicação.

### Aula 3: Criptografia - Vídeo 6

Transcrição  
Uma questão que podemos ter percebido nas explicações sobre as versões do HTTP é que a segurança se tornou primordial para o funcionamento da web como a conhecemos atualmente. Hoje em dia, realizamos muitas operações consideradas vulneráveis no ambiente da internet. Pagamos produtos por e-commerce, fazemos transferências em aplicações bancárias e enviamos informações pessoais que não queremos que sejam vazadas. Todos esses tipos de informações precisam de uma camada de segurança para impedir que sejam roubadas ou adulteradas.

Quando a web foi inicialmente concebida, especialmente na versão HTTP, ela era vulnerável a diversos tipos de ataques. Vamos discutir alguns dos ataques mais comuns que ocorriam na web e mostrar casos de como esses problemas aconteciam.

Explorando tipos comuns de ataques na web  
Primeiramente, temos a interceptação. Quando tentamos acessar um recurso, clicamos em um link e, em vez de obtermos o resultado esperado, somos redirecionados para outro link. Isso é chamado de interceptação. O recurso solicitado é capturado por um interceptador, que nos envia uma resposta com base nessa interceptação. Esse tipo de problema é sério, pois podemos estar enviando dados sensíveis que são utilizados pelo interceptador.

Outro ataque é o man-in-the-middle, que é semelhante à interceptação, mas com um cenário diferente. Nesse caso, o atacante não intercepta a requisição para redirecioná-la, mas atua como um agente no meio, capturando as informações entre a requisição enviada e a resposta recebida. Embora inicialmente pareça inofensivo, o man-in-the-middle pode utilizar essas informações para fins maliciosos, especialmente em transações financeiras.

Temos também o phishing, uma prática ainda bastante utilizada na internet. Nesse caso, um site é criado para parecer exatamente como outro site legítimo, mas não é o site verdadeiro. Isso ocorre frequentemente com sites do governo, onde um site falso é utilizado para roubar informações de pessoas distraídas que acreditam estar acessando o site oficial.

Por fim, temos o problema de injection, comumente exemplificado pelo SQL Injection. Esse tipo de invasão ocorre quando informações maliciosas são enviadas para o servidor através de formulários. Não é uma questão do lado do cliente, mas sim do lado do servidor. Pessoas mal-intencionadas podem preencher campos de formulários com comandos SQL para realizar consultas ou até mesmo deletar o banco de dados inteiro do servidor.

Explicando o papel do TLS e HTTPS na segurança  
O que ajudou a proteger a web contra esses tipos de ataques foi, principalmente, o protocolo de criptografia que utilizamos atualmente na web, o TLS (Transport Layer Security).

O HTTPS, que é a versão segura do HTTP, funciona a partir do protocolo TLS, que é uma camada responsável pelo transporte seguro das informações. Ele possui mecanismos de segurança que garantem que, ao enviar uma informação, ela já esteja criptografada. Mesmo que alguém intercepte a comunicação, não conseguirá descriptografar ou traduzir a informação, pois não possui o mecanismo necessário para quebrar a criptografia e verificar a mensagem corretamente.

Compreendendo os tipos de criptografia utilizados  
O HTTPS utiliza uma combinação de dois tipos de criptografia: simétrica e assimétrica. Na prática, para nós, como usuárias e usuários, a diferença é mínima. A URL passa a incluir um "S", indicando segurança, como em https://www.alura.com.br, em vez de http://alura.com.br.

Vamos entender a diferença entre as criptografias. A criptografia simétrica é mais simples e requer que ambas as extremidades conheçam a chave para descriptografar a mensagem. Isso ocorre no navegador, sem que precisemos nos preocupar. Já a criptografia assimétrica não exige o compartilhamento de chaves entre as extremidades. Ela utiliza um sistema de chave pública e chave privada, oferecendo maior segurança na transferência de informações, mesmo que alguém conheça a chave compartilhada.

Destacando a importância dos certificados digitais  
Para que a web utilize esses mecanismos de criptografia, são necessários certificados digitais. Todo site possui um certificado, emitido por uma autoridade certificadora, que garante o uso do HTTPS. No site da Alura, por exemplo, podemos verificar essas informações no navegador. Ao clicar no ícone de informações do site, ao lado da barra de endereços, vemos que a conexão é segura, pois o site utiliza HTTPS. As informações transmitidas são criptografadas e permanecem privadas, graças ao certificado válido.

Cada site possui um certificado digital específico, vinculado à aplicação, que permite a criptografia das informações enviadas. Para nós, como pessoas desenvolvedoras, é importante gerar um certificado digital para aplicações que exigem segurança. Esse certificado deve estar vinculado ao domínio da aplicação, como alura.com.br. Quando geramos um certificado digital, ele é associado ao nosso domínio específico.

### Aula 3: Para saber mais: como o HTTPS funciona?

O HTTPS (Hypertext Transfer Protocol Secure) é a versão segura do protocolo HTTP, amplamente utilizado na web para garantir que a comunicação entre navegador e servidor seja confidencial e protegida contra ataques. Ele adiciona uma camada de segurança baseada em SSL/TLS (Secure Sockets Layer / Transport Layer Security).

Como funciona o HTTPS

Conexão inicial (handshake TLS)  
Quando um cliente (como o navegador) acessa um servidor via HTTPS, ocorre o chamado handshake. Nesse processo, as partes negociam algoritmos de criptografia e o servidor envia um certificado digital para comprovar sua identidade.

Verificação do certificado  
O navegador verifica se o certificado foi emitido por uma Autoridade Certificadora (CA) confiável. Isso assegura que o site realmente é quem diz ser, evitando ataques de falsificação (como phishing ou man-in-the-middle).

Troca de chaves  
Durante o handshake, o cliente e o servidor trocam informações para gerar uma chave de sessão. Essa chave será usada para criptografar toda a comunicação de forma simétrica, garantindo velocidade e segurança.

Transmissão segura de dados  
Com a chave de sessão estabelecida, todas as informações trocadas (como logins, senhas e dados pessoais) são criptografadas. Assim, mesmo que alguém intercepte o tráfego, não conseguirá ler os dados.

Benefícios do HTTPS

- Confidencialidade: dados transmitidos não podem ser lidos por terceiros.
- Integridade: evita que informações sejam alteradas durante a transmissão.
- Autenticidade: confirma que o servidor acessado é realmente o correto.
- SEO e confiança: navegadores modernos marcam sites sem HTTPS como inseguros, e buscadores dão preferência a sites seguros nos resultados.

Referências

- [Guia da Mozilla sobre HTTPS](https://developer.mozilla.org/docs/Web/HTTP/HTTPS)
- [Documentação do TLS 1.3 no IETF](https://datatracker.ietf.org/doc/html/rfc8446)
- [Let’s Encrypt](https://letsencrypt.org) (CA gratuita e automatizada)
- [Google Security Blog](https://security.googleblog.com) sobre o impacto do HTTPS

### Aula 3: Faça como eu fiz: HTTP e Cabeçalhos
 Próxima Atividade

Nesta aula, revisamos conceitos de status codes, cabeçalhos HTTP, versões do protocolo e segurança na web. Agora é a oportunidade de aplicar estes conceitos na prática. Para isso:

- Identifique as categorias de status codes (100, 200, 300, 400, 500) e seus significados.
- Enumere exemplos comuns, como 200 (OK), 404 (Not Found) e 500 (Erro Interno).
- Diferencie os elementos da requisição: linha de método, URI e protocolo.
- Separe claramente os cabeçalhos do corpo da requisição.
- Configure uma requisição POST com cabeçalhos como Host, Content-Type, Authorization e Content-Length.
- Analise os cabeçalhos exibidos em uma requisição e identifique o papel de cada um.
- Utilize o DevTools ou Postman para visualizar os detalhes dos headers enviados e recebidos.
- Verifique como o Accept, User-Agent e Accept-Language definem o tipo de resposta e a localidade.
- Realize uma requisição GET e confirme o retorno de status code 200 e o conteúdo HTML.
- Compare os casos de resposta utilizando diferentes versões do HTTP (1.1, 2 e 3).
- Teste requisições com ferramentas de linha de comando para forçar o uso do HTTP/3.
- Registre os tempos de resposta de cada versão para avaliar desempenho.
- Explique a diferença entre HTTP e HTTPS, enfatizando a segurança oferecida pelos certificados digitais.
- Descreva as vantagens do HTTP/3, como a multiplexação e desempenho aprimorado.
- Liste os tipos de dados armazenados via cookies e sessões no navegador.
- Reconheça os riscos de vulnerabilidades, como man-in-the-middle, interceptação, phishing e injection.
- Analise como o TLS e os certificados digitais garantem a criptografia e segurança das requisições.

Para consultar o guia detalhado, verifique as transcrições da aula.

### Aula 3: O que aprendemos?

Nesta aula, aprendemos:

- Os status codes do protocolo HTTP e suas cinco categorias principais.
- A estrutura e uso de cabeçalhos em requisições HTTP, como Content-Type e Authorization.
- O uso do Postman para inspecionar componentes de requisições HTTP.
- As diferenças entre HTTP, HTTPS e HTTP/3, e suas implicações de segurança e desempenho.
- A importância do armazenamento de informações no cliente através de cookies e sessões para experiência do usuário.
- A necessidade de segurança nas operações web modernas e proteção contra ataques cibernéticos.
- Como o protocolo TLS no HTTPS protege a web através de criptografia.
- A importância de certificados digitais para assegurar conexões HTTPS.

## Aula 4: Desenvolvimento Web

### Aula 4: Ferramentas e depuração - Vídeo 1

Transcrição  
Existem diversas ferramentas para entender e trabalhar com a infraestrutura da web. Vamos explorar como essas ferramentas são utilizadas, começando com o DevTools e passando por clientes HTTP e ferramentas de linha de comando como o curl.

Enquanto tentávamos entender como a web funciona, percebemos que uma série de ferramentas se tornou necessária para verificar vários aspectos da infraestrutura da web. Utilizamos desde o terminal até aplicações que operam no navegador, e é importante compreender como cada uma delas funciona e como são úteis no nosso dia a dia.

Utilizando o DevTools para depuração  
A principal dessas ferramentas é o DevTools, que é a ferramenta de depuração que usamos para verificar qualquer coisa na internet. Ao acessar o navegador e pressionar F12, podemos inspecionar o HTML e visualizar diversos recursos que permitem a inspeção de como a web está funcionando, como uma determinada aplicação está operando e quais informações estamos recebendo. Para aplicações web, o navegador é a fonte final de verdade, mostrando como a informação está sendo transmitida para cada cliente.

Devemos entender que o DevTools não é apenas uma ferramenta, mas um conjunto de ferramentas que trabalha em conjunto com o navegador para compreender o comportamento das nossas aplicações. Ele permite verificar a rede para acessar todas as informações disponíveis, inspecionar cookies no navegador, analisar requisições para entender o protocolo HTTP e verificar as respostas recebidas. A inspeção de HTML também é uma função importante. Todas essas ferramentas estão agrupadas no DevTools.

Inspecionando HTML e realizando debug  
Geralmente, usamos o DevTools principalmente para inspecionar HTML e realizar debug para verificar se o JavaScript está funcionando corretamente, se o CSS foi carregado adequadamente ou se as imagens estão no formato correto. Toda a visão detalhada do código do front-end está relacionada às versões HTML, CSS, JavaScript e qualquer outra função que possa ser inspecionada pelo navegador.

Compreendendo clientes HTTP e suas aplicações  
Além disso, temos os clientes HTTP, que são essenciais para entender o funcionamento da web, especialmente no que diz respeito às APIs. Ao longo dos vídeos, discutimos sobre APIs, e em breve abordaremos o que de fato é uma API. Os clientes HTTP são fundamentais para testar modelos de aplicações que trabalham com a diferença entre back-end e front-end, que são as APIs.

Existem vários clientes HTTP, sendo o mais famoso o Postman, mas também temos o Insomnia e o Thunderclient, que é uma extensão do Visual Studio Code que simula um cliente HTTP. O próprio cURL pode ser considerado um cliente HTTP, mas aqui nos referimos a clientes com interface, um ambiente mais completo para testar nossas aplicações. A vantagem de usar esse tipo de ferramenta é que podemos criar uma plataforma colaborativa. Assim, podemos estruturar requisições que uma organização pode acompanhar, controlar, testar e alterar, tudo isso graças a essas plataformas.

Facilitando testes colaborativos com Postman  
Imagine que temos uma empresa com várias aplicações, e essas aplicações possuem diversas rotas que precisam ser testadas continuamente. Seria complicado se cada pessoa criasse seu próprio projeto para fazer requisições web utilizando clientes HTTP, ou se cada uma configurasse seu Postman da maneira que achasse melhor. Para isso, o Postman oferece ferramentas para que todo o time, com acesso a um workspace (espaço de trabalho), possa configurar de forma aceitável esses testes, tornando-se o melhor cliente HTTP para as aplicações.

Os principais clientes HTTP utilizados são o Postman, Insomnia, Thunderclient, entre outros. Sempre surgem novos modelos, open source ou não, cada um com suas diferenças e particularidades que podem ser mais proveitosas, dependendo da aplicação que está sendo testada.

Utilizando curl e ferramentas de linha de comando  
No lado do terminal, em um nível mais baixo, trabalhamos com recursos do sistema operacional, como o curl, um programa utilizado em aplicações de console (CLI). Utilizamos o curl para tarefas intensivas, como rodar scripts em Bash ou Python, ou agentes de IA na linha de comando. Atualmente, temos o Codex CLI, Dantropic, Cloud Code, e outras ferramentas de IA que operam com agentes no computador. Essas ferramentas precisam executar comandos no sistema operacional, e o curl é um dos comandos mais utilizados para testar APIs ou acessos a aplicações web, verificando o comportamento esperado, se o status code está correto, e se a informação está sendo enviada corretamente em HTML.

Exemplificando o uso do curl  
Para ilustrar como o curl pode ser utilizado, vejamos um exemplo de requisição HTTP para obter um card aleatório da API Scryfall:

```cmd
curl -X GET \
  'https://api.scryfall.com/cards/random' \
  --header 'Accept: */*' \
  --header 'User-Agent: Thunder Client'
```

Esse comando curl faz uma requisição GET para a API Scryfall, especificando cabeçalhos para aceitar qualquer tipo de resposta e identificando o cliente como Thunder Client. Isso demonstra como podemos usar o curl para interagir com APIs diretamente do terminal.

Incorporando ferramentas CLI em scripts  
Essas ferramentas CLI estão sendo cada vez mais incorporadas e utilizadas por agentes de IA, e são úteis para nós ao criar scripts ou testar no terminal, pois o curl permite realizar testes de forma pura, garantindo que o cliente HTTP está sendo executado corretamente. Com o curl, podemos transferir informações de maneira simples pelas URLs, suportando diversos protocolos, não apenas o HTTP. A web funciona com outros protocolos, como SMTP para e-mails e FTP para arquivos. Embora o HTTP seja o protocolo mais comum em aplicações web, outros protocolos também precisam ser verificados, dependendo da aplicação.

Concluindo sobre ferramentas para desenvolvedores  
A web oferece uma série de ferramentas que facilitam nosso trabalho, cada uma com sua responsabilidade. Existem várias ferramentas que podem ser utilizadas para auxiliar nosso trabalho como pessoas desenvolvedoras. Aqui estão as principais que utilizamos no dia a dia. Cada empresa tem suas particularidades, mas geralmente seguem esse padrão ao lidar com aplicações web.

### Aula 4: Utilizando DevTools para otimizar a experiência do usuário na Clickbonus - Exercício

A Clickbonus, uma plataforma digital que oferece um clube de vantagens e recompensas personalizadas por meio de parcerias com diversas empresas, está enfrentando desafios para garantir que a experiência do usuário seja fluida e sem interrupções. A equipe de desenvolvimento que você faz parte foi encarregada de investigar por que algumas pessoas usuárias estão relatando lentidão ao acessar a página de recompensas.

Qual abordagem utilizando o DevTools seria mais eficaz para identificar e resolver os problemas de desempenho na página?

Resposta correta  
Utilizar a aba "Network" para monitorar o carregamento de recursos, identificar arquivos que demoram para carregar e verificar erros de requisição, seguido pela aba "Performance" para analisar o tempo de execução de scripts, renderização e layout, e a aba "Lighthouse" para gerar relatórios de desempenho e sugestões de melhorias.

> Correta, pois essa abordagem permite uma análise abrangente dos aspectos de desempenho da página, identificando gargalos como imagens não otimizadas ou scripts pesados, e fornece sugestões práticas para melhorias.

### Aula 4: O conceito de API - Vídeo 2

Transcrição  
Quando falamos de aplicações web, é importante nos atentarmos ao fato de que, ao acessarmos e consultarmos uma informação na internet, como em páginas da Amazon, Alura ou Netflix, recebemos apenas a informação completa do HTML. No entanto, uma aplicação web, especialmente nos modelos atuais, é geralmente dividida em dois componentes: o front-end, que inclui HTML, CSS, JavaScript ou uma aplicação móvel, e o back-end, onde ocorre todo o processamento das informações que serão armazenadas. O back-end é a parte do servidor, conforme discutido anteriormente no modelo cliente-servidor.

Existem aplicações integradas, geralmente desenvolvidas por pessoas desenvolvedoras full-stack, que trabalham em ambas as partes simultaneamente. Contudo, na maioria dos casos, as aplicações são separadas devido à complexidade. O back-end, por não exigir uma interface gráfica, precisa se comunicar adequadamente com uma aplicação front-end ou móvel. Além disso, os serviços do back-end podem ser públicos e consumidos por outros clientes.

Definindo o conceito de API  
Esse modelo de aplicação é conhecido como API (Application Program Interface), que é uma interface voltada para a comunicação entre diferentes aplicações. Uma API permite que um ou mais softwares se comuniquem e compartilhem dados entre si. Por exemplo, em uma aplicação móvel, muitos serviços são compartilhados entre si. A aplicação móvel não possui todo o back-end; muitos serviços são de terceiros e gerenciados por outras entidades.

Esses serviços de terceiros podem incluir comunicação por e-mail ou SMS, onde um servidor fornece a interface para que o dispositivo móvel se comunique com o back-end. O mesmo se aplica a conteúdo multimídia, como imagens e vídeos, que geralmente são armazenados em servidores na Amazon, Microsoft Azure ou Google Cloud. Para armazenamento na nuvem, quando precisamos guardar dados específicos, utilizamos bancos de dados com interfaces próprias.

Explorando o uso de APIs em diferentes serviços  
Na análise de dados, a ciência de dados e a geração de relatórios podem ser geridos por serviços separados. Redes sociais como Twitter, Facebook e Instagram possuem APIs específicas para comunicação e operações relacionadas. Isso também é comum em aplicações de pagamento, onde serviços de terceiros, como Mercado Pago e PagBank, fornecem meios de pagamento para as aplicações.

A geolocalização é outro exemplo, com a API do Google Maps sendo amplamente utilizada por aplicativos de GPS, como Waze e Uber, e por aplicações de logística. Notificações, como as recebidas no celular, são geridas por APIs externas. O gerenciamento de dados, segurança e autenticação também são vinculados a APIs ou serviços externos.

Exemplificando o uso de APIs em aplicações web  
Cada um desses serviços pode ser uma API separada, compondo a aplicação final. Por exemplo, uma aplicação web como o Scryfall, que exibe informações de cartas de Magic, é voltada para o usuário final. Ao clicar em uma coleção, a aplicação carrega informações e imagens em HTML. No entanto, outra aplicação, como o Moxfield, que cria decks, pode utilizar os serviços do Scryfall para obter informações de cartas e imagens.

O Scryfall possui uma documentação de API que permite a consulta de informações sem carregar o HTML completo. Em vez disso, ele gera um JSON que pode ser consumido por outras aplicações para carregar um HTML diferente. Essa diferença entre uma API e uma aplicação web tradicional permite que informações sejam compartilhadas entre aplicações.

Introduzindo os tipos de APIs  
Agora, vamos discutir os tipos de APIs.

Desde que o conceito de API foi desenvolvido, ele foi inicialmente pensado em um modelo chamado SOA, que por sua vez sucedeu outro modelo. O raciocínio de ter serviços compartilhados existe há muito tempo. No entanto, o conceito de API se popularizou principalmente com a definição das APIs REST ou APIs RESTful. Isso ocorre porque elas seguem o padrão REST, que é o principal protocolo utilizado atualmente para comunicação entre serviços web completamente distribuídos ou separados.

Comparando diferentes modelos de APIs  
Quando mencionamos gateways de pagamento, notificações push e até mesmo alguns protocolos que envolvem aplicações de IA, percebemos que eles utilizam bastante a API REST. Isso se deve ao fato de ser o modelo mais simples e comum, amplamente difundido pela comunidade. Portanto, a API REST é o modelo padrão utilizado. A própria API do SquareFolk, mencionada anteriormente, segue o padrão RESTful.

Há também um modelo mais antigo, as APIs SOAP, que operavam com um modelo mais rígido de transferência de informações. O SOAP não utilizava JSON, mas sim XML, o que resultava em uma transferência de dados mais volumosa e, consequentemente, em problemas. Um JSON requer apenas chaves, parênteses e dois pontos para estruturar chave-valor, formando uma estrutura de árvore mais condensada. Já o SOAP, com suas tags XML, podia apresentar problemas se uma tag fosse enviada incorretamente. Embora ainda utilizado por sistemas legados, o SOAP foi substituído pelo padrão API REST, que é mais eficiente e possui um padrão de comunicação definido pela OpenAPI, uma organização que promove APIs abertas.

Explorando novos modelos de APIs  
Outro modelo é o GraphQL, uma ferramenta criada pelo Facebook que permite um modelo de API mais flexível, baseado em consultas personalizadas para cada usuário. Embora comparado a uma consulta SQL na web, o GraphQL permite que se faça uma consulta dentro da requisição, solicitando dados de forma dinâmica conforme as definições feitas. Isso proporciona uma flexibilidade que outras APIs não possuem, pois as APIs REST são voltadas a contratos, exigindo um corpo de requisição específico para obter uma resposta específica. O GraphQL, por outro lado, permite especificar exatamente os campos desejados na resposta.

Temos também o modelo de APIs WebSocket, voltado para aplicações em tempo real, como jogos online, gráficos e bolsas de valores. Diferente dos outros modelos, onde é necessário enviar requisições constantemente, o WebSocket estabelece um canal de comunicação contínuo entre as extremidades, permitindo uma transferência constante de informações.

O gRPC é um modelo mais recente de comunicação adotado por APIs, que, ao contrário dos outros modelos, não utiliza JSON, mas sim informações binárias convertidas e enviadas. Isso torna o gRPC mais rápido na entrega de informações em comparação com a API REST, que ainda utiliza JSON. Devido à sua velocidade, o gRPC é preferido em aplicações que exigem alta performance.

Discutindo APIs abertas e seus usos  
Existem APIs abertas, como a do SquareFolk, que qualquer pessoa pode acessar, desde que siga as regras estipuladas na documentação. APIs abertas não significam necessariamente uso gratuito, mas sim que não é necessário se cadastrar como uma entidade para acessá-las. Existem várias APIs abertas no mundo, oferecendo funcionalidades em diversas categorias, como a NASA API, que fornece dados de pesquisas, ou a Open Weather Map, que disponibiliza informações de previsão do tempo.

Um projeto interessante no GitHub é o "Public APIs", que apresenta uma série de APIs públicas e abertas para teste e uso. Ele abrange diversas categorias, como APIs de animais, animes, livros, calendário, e-mail, finanças, comidas, jogos, geolocalização, governo, saúde, trabalhos, música e notícias. Essas APIs abertas podem estar disponíveis ou não, mas oferecem várias opções e até mesmo APIs de reserva para garantir o funcionamento contínuo das aplicações. Quando falamos de uma aplicação web que consome APIs, se não for um serviço pago, geralmente há APIs de backup para garantir a continuidade do serviço.

### Aula 4: Testando APIs de dispositivos na HomeHub - Exercício

A HomeHub, uma plataforma de monitoramento e controle de dispositivos para casas inteligentes, está desenvolvendo uma nova funcionalidade que integra dispositivos de segurança com o sistema de iluminação. A equipe de desenvolvimento precisa garantir que as APIs que conectam esses dispositivos estejam funcionando corretamente.

Qual é a melhor maneira de utilizar um cliente HTTP, como o Postman, para testar e validar as rotas das APIs envolvidas nessa integração?

Resposta correta  
Utilizar o Postman para criar requisições HTTP que simulem as interações esperadas entre os dispositivos, configurando requisições GET, POST, PUT ou DELETE conforme necessário para cada rota da API. Enviar as requisições, verificar as respostas, observando o status code, o tempo de resposta e o formato dos dados retornados. Criar coleções de requisições que podem ser compartilhadas e executadas por toda a equipe.

> Correta, pois essa abordagem permite testar de forma abrangente e colaborativa as interações entre dispositivos, garantindo que as APIs funcionem conforme o esperado e que todos os membros da equipe possam acompanhar e validar o funcionamento das APIs.

### Aula 4: Para saber mais: tipos de protocolos de API

As APIs (Application Programming Interfaces) são fundamentais para a comunicação entre sistemas, permitindo a integração de serviços, dados e funcionalidades. Existem diferentes protocolos de API, cada um com características próprias, que influenciam no desempenho, segurança e facilidade de implementação.

REST (Representational State Transfer)  
Baseado no protocolo HTTP, é o padrão mais popular atualmente. Utiliza recursos identificados por URLs e operações baseadas em métodos HTTP (GET, POST, PUT, DELETE). É simples, escalável e amplamente suportado.

SOAP (Simple Object Access Protocol)  
Mais antigo e formal, utiliza XML para troca de mensagens. É orientado a contratos (WSDL) e conhecido pela robustez em ambientes corporativos, mas também pela maior complexidade em comparação ao REST.

GraphQL  
Criado pelo Facebook em 2015, permite ao cliente definir exatamente quais dados deseja receber, evitando overfetching (trazer dados em excesso) ou underfetching (trazer dados insuficientes). É altamente flexível para aplicações modernas.

gRPC (Google Remote Procedure Call)  
Desenvolvido pelo Google, utiliza Protocol Buffers (Protobuf) para serialização de dados binários, o que garante alta performance e baixo consumo de rede. É muito usado em microsserviços e comunicação em tempo real.

WebSockets  
Não é um protocolo de API no sentido clássico, mas um padrão para comunicação bidirecional em tempo real entre cliente e servidor. Ideal para chats, jogos online e sistemas de monitoramento.

Referências

- [Documentação oficial do REST](https://restfulapi.net)
- [Guia da W3C sobre SOAP](https://www.w3.org/TR/soap)
- [GraphQL oficial](https://graphql.org)
- [gRPC oficial](https://grpc.io)
- [WebSockets MDN](https://developer.mozilla.org/docs/Web/API/WebSockets_API)

### Aula 4: Nuvem - Vídeo 3

Transcrição  
No final de tudo, uma preocupação importante é garantir que nossa aplicação esteja funcionando corretamente. Quando falamos em "funcionar corretamente", não nos referimos apenas a executar o código, mas sim a hospedar nosso código em um local que permita que a aplicação esteja disponível para o mundo inteiro. No contexto de aplicações web, isso significa estar "de pé". Isso difere de um aplicativo móvel, que instalamos no celular, ou de um aplicativo de desktop, que baixamos e instalamos no computador.

Para hospedar nossas aplicações, precisamos colocá-las na nuvem. Existem dois tipos de hospedagem que discutimos: a hospedagem tradicional e a hospedagem na nuvem. A hospedagem tradicional envolve a compra e configuração de um servidor próprio, onde colocamos nossa aplicação. Nesse caso, é necessário contratar um serviço de internet, adquirir um IP e um domínio, além de todos os mecanismos de rede necessários para hospedar a aplicação e permitir que ela se comunique com o mundo.

Comparando hospedagem tradicional e na nuvem  
No entanto, o modelo mais utilizado atualmente, por diversos fatores como facilidade de distribuição, manutenção, garantias de redundância, entre outros, é a hospedagem na nuvem. Embora a hospedagem tradicional seja importante para o aprendizado e testes, a nuvem oferece um ambiente muito mais seguro para disponibilizar aplicações de maneira adequada.

Entre os principais serviços de hospedagem na nuvem, destacamos a AWS, gerenciada pela Amazon. A AWS é um dos principais serviços que disponibilizam aplicações na web. Já foi mencionado que um terço ou mais da internet mundial atualmente opera sobre a AWS.

Explorando fornecedores de nuvem  
Existem empresas de grande porte que utilizam a AWS, como a Netflix e a Pokémon Company, além de várias outras grandes empresas que também têm suas aplicações hospedadas na AWS. Temos também a Azure, que é o serviço da Microsoft e é um dos principais concorrentes da AWS em termos de participação de mercado e capacidade de competição. A Azure oferece boa parte dos serviços que a AWS possui. Cada fornecedor de nuvem pode ter suas particularidades, mas, em geral, eles oferecem serviços semelhantes. Algumas pequenas particularidades podem levar uma empresa a escolher um fornecedor em detrimento de outro.

A Oracle também é uma parceira de serviços de nuvem em nível mundial, sendo uma empresa antiga e consolidada, com um trabalho significativo na área de serviços de nuvem. Além disso, existem serviços que utilizam a nuvem e fornecem outros serviços para aplicações mais consolidadas, facilitando certos tipos de hospedagem. Um exemplo notável é a Vercel, que dita as regras através do framework que criaram, o Next.js, talvez o framework mais utilizado com o React. Muitas aplicações web são mantidas pela Vercel, que atualmente agrupa uma série de aplicações populares mundialmente.

Considerando opções de segurança e hospedagem  
Temos também a Cloudflare, que é uma das principais empresas em segurança para aplicações web no mundo. Muitos desenvolvedores afirmam que, se a Cloudflare cair, a internet também cai, pois ela é responsável por muitos dos principais serviços de segurança em plataformas de serviços web.

Existem várias maneiras de hospedar uma aplicação web, cada uma com suas particularidades. A escolha depende do que se considera melhor e da complexidade da aplicação. Por exemplo, para uma página estática em HTML, o GitHub Pages é um serviço comum para testar o básico de uma aplicação web. Para uma aplicação em React, pode ser necessário utilizar a Vercel. Se a aplicação incluir front-end, back-end, serviços de IA e outros componentes, pode ser necessário um serviço de nuvem mais robusto para atender às necessidades. A escolha do serviço dependerá da complexidade da aplicação.

### Aula 4: Mercado de trabalho web - Vídeo 4

Transcrição  
A web tornou-se tão complexa que foi necessária a criação de uma série de funções, cada uma dividida para lidar com toda essa complexidade atual da internet. No passado, o mercado de trabalho contava com o webmaster ou apenas um serviço de desenvolvedor web, que era uma pessoa responsável por tudo. Desde a concepção de uma página web até a hospedagem, essa pessoa dominava todas as etapas. Atualmente, é impossível dominar todas as fases de uma aplicação web. Com isso, houve uma divisão em vários pequenos papéis que, juntos, compõem o mercado de trabalho em aplicações web.

Definindo os papéis dos desenvolvedores  
Temos o desenvolvedor front-end, que cuida da parte visual, a qual será utilizada pelos usuários finais. O desenvolvedor back-end atua nos bastidores, criando serviços que serão utilizados pelos clientes em forma de APIs, ou desenvolvendo as APIs que serão utilizadas pelo front-end. O desenvolvedor full-stack é mais generalista, pois consegue trabalhar tanto no front-end quanto no back-end, atuando em ambas as frentes. Esse papel é muito importante em várias empresas que necessitam desse tipo de profissional.

Explorando o papel do engenheiro de DevOps  
Temos o engenheiro de DevOps, que é responsável principalmente pela implantação e observabilidade das aplicações. Ele verifica se as aplicações estão funcionando corretamente, identifica possíveis problemas, programa manutenções e auxilia na implementação de novas versões. O profissional de DevOps desempenha o papel crucial de manter o software em operação, garantindo que ele funcione de maneira eficaz.

Garantindo a qualidade com o engenheiro de QA  
Além disso, temos o engenheiro de QA, que também precisa ter conhecimento em web. Sua função é testar a aplicação de todas as formas possíveis para identificar falhas e apresentar os insights necessários para que as pessoas desenvolvedoras possam corrigir e melhorar as aplicações. É importante ressaltar que todas as aplicações geralmente apresentam bugs, e cabe ao QA identificar esses problemas e colaborar na sua resolução.

Assegurando a segurança das aplicações  
Outro papel importante é o do engenheiro de segurança. A segurança é fundamental para garantir que as informações não sejam comprometidas, e essa responsabilidade recai sobre o engenheiro de segurança.

Colaborando para o sucesso das aplicações web  
Observamos que o desenvolvimento web envolve diversos setores, cada um colaborando para garantir aplicações web funcionais. Em aplicações de grande porte, todos esses papéis são necessários, e equipes são formadas para gerenciar essas funções. Isso ocorre porque as aplicações web atuais são bastante complexas, abrangendo muitas áreas que precisam interagir de maneira eficaz para que tudo funcione corretamente.

### Aula 4: Para saber mais: comunicação com gRPC

Visão Geral do gRPC  
O gRPC é um framework de chamada remota de procedimento (RPC) desenvolvido pelo Google, que se destaca por utilizar o protocolo HTTP/2 para comunicação e o Protocol Buffers para serialização dos dados. Essa combinação torna a transferência de informações mais rápida e eficiente, principalmente em aplicações que exigem alta performance e baixa latência.

Funcionamento Interno  
No gRPC, o contrato entre serviços é definido por arquivos de especificação chamados de .proto. Esses arquivos descrevem as mensagens (estruturas de dados) e os métodos disponíveis no serviço. Durante a compilação, são geradas as classes necessárias para a comunicação tanto no lado do servidor quanto no do cliente.

Um dos diferenciais do gRPC é a capacidade de suportar diferentes padrões de comunicação: além da chamada simples (unária), ele possibilita comunicações com streaming do cliente, do servidor ou bidirecional, o que é fundamental em cenários como atualizações em tempo real e transmissão contínua de dados.

Exemplo de definição em um arquivo .proto:

```Script
syntax = "proto3";

service ExemploService {
  rpc ObterDados (Requisicao) returns (Resposta);
}

message Requisicao {
  string parametro = 1;
}

message Resposta {
  string resultado = 1;
}
```

Comparativo com Outras Abordagens  
Diferente do tradicional modelo REST, que normalmente utiliza JSON para intercâmbio de informações, o gRPC adota uma abordagem binária. Isso implica em mensagens menores e maior rapidez na comunicação. Contudo, essa eficiência vem acompanhada de uma complexidade maior na configuração e na depuração, especialmente para equipes que ainda não estão familiarizadas com o ecossistema do Protocol Buffers.

Entre as vantagens, destaca-se a performance aprimorada e o suporte nativo a streaming, que permite a implementação de sistemas em tempo real de maneira simples e estruturada. Por outro lado, como desvantagens, a curva de aprendizado é um pouco mais acentuada e a interoperabilidade com tecnologias legadas pode requerer passos adicionais para integração.

Considerações Finais  
O gRPC se mostra uma excelente alternativa quando o desempenho é uma prioridade e a comunicação entre serviços precisa ser feita de forma eficiente e com baixa latência. Ao optar por essa abordagem, é importante pesar os benefícios da velocidade e escalabilidade contra a complexidade adicional no desenvolvimento e na manutenção dos contratos de comunicação.

### Aula 4: Faça como eu fiz: testar serviços web

Nesta aula, foram explorados conceitos e ferramentas essenciais para entender e testar aplicações web, desde a inspeção via DevTools até a hospedagem na nuvem.

Agora é sua chance de colocar em prática os conteúdos, se ainda não experimentou. Para isso:

- Use o DevTools para inspecionar HTML, CSS, JavaScript e monitorar a rede.
- Execute requisições HTTP com clientes como Postman, Insomnia ou cURL.
- Verifique respostas de APIs analisando status code e formato dos dados.
- Compare diferentes tipos de APIs: REST, SOAP, GraphQL, WebSocket e gRPC.
- Documente os endpoints e os contratos de comunicação conforme a documentação da API.
- Configure a hospedagem da aplicação em um serviço de nuvem, como AWS, Azure ou Oracle.
- Estruture a separação entre front-end, back-end e integrações de serviços externos.

Para acessar o guia detalhado, consulte as transcrições da aula.

### Aula 4: O que aprendemos?

Nesta aula, aprendemos:

- A utilizar DevTools para depurar aplicações web.
- A função de clientes HTTP como Postman e cURL para testar APIs.
- A separação entre front-end e back-end em aplicações web.
- O conceito e uso de APIs, incluindo diferentes tipos como REST e GraphQL.
- A importância de hospedar aplicações na nuvem e os principais serviços disponíveis.
- As funções no desenvolvimento web moderno, incluindo front-end, back-end e DevOps.
- A importância do engenheiro de QA na melhoria da qualidade das aplicações.
- O papel do engenheiro de segurança na proteção de informações em aplicações web.

### Aula 4: Conclusão - Vídeo 6

Transcrição  
Se chegamos até aqui, parabéns! Agora já compreendemos todas as preocupações necessárias para o desenvolvimento de aplicações web. Iniciamos entendendo como a internet funciona, abrangendo todos os mecanismos, sejam físicos ou digitais, que compõem a web.

Em seguida, passamos a entender o protocolo mais importante no qual a web opera atualmente: o HTTP. É por meio dele que todas as páginas web são trafegadas pela internet, sendo solicitadas e respondidas. Analisamos os detalhes desse protocolo, incluindo os status que uma página web pode retornar, os cabeçalhos, as requisições e as respostas que podemos obter.

Explorando armazenamento e segurança na web  
Compreendemos também os mecanismos de armazenamento interno que os navegadores possuem, assim como os mecanismos de segurança da web. Esses mecanismos são fundamentais para que possamos trafegar informações sem nos preocupar com possíveis invasões ou ataques maliciosos que possam roubar nossas informações.

Por último, exploramos as ferramentas e produtos que nos auxiliam a finalizar, hospedar e depurar aplicações web.

Acompanhando o ciclo de desenvolvimento de aplicações web  
Podemos observar que todo o ciclo de desenvolvimento de uma aplicação web começa com a compreensão de como a aplicação que estamos construindo funciona. É essencial acompanhar, depurar e realizar o debug dessa aplicação, além de estabelecer uma infraestrutura para hospedá-la. Assim, percorremos desde o início, que é a concepção, até o final, que é a implantação do software.

Com isso, já conseguimos entender que sabemos, pelo menos, como a aplicação se comporta quando está sendo hospedada e requisitada. Compreendemos como a internet lida com essas solicitações e como envia as informações de volta. Entendemos todo o mecanismo. Ainda não vimos como construir uma aplicação web, mas, ao menos, sabemos quais serão os pontos de atenção necessários para que a aplicação funcione normalmente dentro das regras da internet quando estiver no ar.

Incentivando o estudo contínuo de desenvolvimento web  
Convidamos você a continuar estudando e a entender como construir aplicações que sigam as regras da internet. Ou seja, que consigam acompanhar os protocolos, seguir as regras do HTTP e trabalhar com todos os outros mecanismos que a internet possui, para criar uma aplicação que funcione adequadamente para as pessoas que irão utilizá-la, estando disponível no mundo inteiro.
