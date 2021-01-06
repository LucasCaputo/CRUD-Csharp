<h1 align="center">
    <img alt="GoStack" src="https://rocketseat-cdn.s3-sa-east-1.amazonaws.com/bootcamp-header.png" width="200px" />
</h1>

### 🔥 3.1 - Conceitos NodeJS

<p>NodeJS permite que utilize o JavaScript no back-end</p>
<p>A única forma de ouvir eventos do usuário são as rotas da aplicação</p>
<p>O Node é um plataforma para desenvolvimento backend, que utiliza a linguagem javascript</p>

<h5>NPM</h5>

<p>O NPM permite que instale ferramenta de terceiros no nosso projeto, como por exemplo meios de pagamento</p>

<p>Também é possível criar pacotes com node e fornecer ferramentas que podem ser instaladas outros projetos</p>

<h5>Yarn</h5>

<p>O Yarn é mais rápido e também está evoluindo mais rápido que o NPM</p>

<p>Yarn WorkSpaces é uma funcionalidade do yarn que permite compartilhar dependências comuns entre projetos que utilizam os mesmo pacotes</p>

<p>Cada linguagem possui seu próprio gerenciador de pacotes</p>

<ul>
  <li>Composer do PHP</li>
  <li>Gems do Ruby</li>
  <li>PIP do Python</li>
</ul>

<h5>Características do Node</h5>

<p>A arquitetura do Node é baseada em <b>Event-loop</b>, baseadas em eventos </p>

<p><b>Call Stack</b> é uma pilha de eventos e o evento é uma função disparada no nosso código e o Node processa através de um loop eterno rodando na nossa aplicação o tempo todo, observando se teve alguma nova função disparada e <b>executa no sistema de pilha</b></p>

<p><b>Node é single-thread,</b> mas ele utiliza C++ por trás com a libuv que possibilita utilizar multi-threads no processamento</p>

<p><b>Non-blocking I/O,</b> quando eu faço uma requisição para o node eu não preciso retornar todos os dados de uma vez, esse retorno pode ser em partes, algo que não ocorre em outras tecnologias, muito utilizado para aplicações em tempo real como chats, utilizando o protocolo websocket que é uma conexão com o backend que nunca se fecha</p>

<h5>Frameworks</h5>

<p><b>ExpressJS</b>é aberto para criarmos a estrutura como quisermos, ele é um micro framework com poucas funções, mas que funciona muito bem, pode ser utilizado em micro-serviços</p>

<p><b>AdonisJS</b> e <b>NestJS</b> são frameworks com escopo mais fechado que o express</p>

### 🎓 3.2 - Conceitos API REST

<h5>Como funciona um API REST</h5>

<p>Fluxo de requisição e resposta</p>

<p>A requisição é feita por um cliente, browser acessando uma url, e a resposta retornada através de uma estrutura de dados</p>

<p>A única coisa que o API retorna é uma estrutura de dados</p>

<p>As rotas utilizam métodos HTTP</p>
<ul>
  <li>GET(Método HTTP) - (http://minhaapi.com/<b>users</b>(route)</li>
  <li>POST(Método HTTP) - (http://minhaapi.com/<b>users</b>(route)</li>
  <li>PUT(Método HTTP) - (http://minhaapi.com/<b>users</b>(route)/1(route params)</li>
  <li>DELETE(Método HTTP) - (http://minhaapi.com/<b>users</b>(route)/1(route params)</li>
</ul>

<h5>Benefícios API REST</h5>

<p>Múltiplos front-end utilizando o mesmo back-end</p>

<p>Protocolo de comunicação padronizada - JSON - JavaScript Object Notation</p>

<p>GET (Método HTTP) - (http://minhaapi.com/<b>company</b>(route)/1(route params)?page=2(query params)</p>

<p>POST (Método HTTP) - (http://minhaapi.com/<b>company</b>(route)/1(route params)/user(route)</p>

<p>No caso de uma requisição POST para cadastro nós não utilizamos os query params pelo fato que todos os dados são enviados pela url o que pode gerar problemas inclusive de segurança</p>

<p>Nesse exemplo abaixo os dados desse usuário do qual é feito a requisição POST todos os dados são enviados pelo corpo da requisição que também pode ser chamado de body ou request body, utilizado somente no métodos POST e PUT, que são para cadastro e edição</p>

{
"user": {
"name": "Lucas Caputo"
"email": "lccaputo@hotmail.com"
"tech": ["React", "NodeJS", "React Native"]
}
}
{
"locale": "pt_BR"
}

<p>No caso desse JSON o "locale" não tem a ver com os dados do user, dessa forma ele é um header que pode ser utilizado para formatar, autorizar nosso usuário dentro da aplicação.</p>

<h5>HTTP Codes</h5>

<ul>
  <li>1xx: Informational (rara utilização)</li>
  <li>2xx: Success
    <ul>
      <li>200: Success</li>
      <li>201: Created</li>
    </ul>
  </li>
  <li>3xx: Redirection
    <ul>
      <li>301: Moved Permanently</li>
      <li>302: Moved (pode ser que volte)</li>
    </ul>
  </li>
  <li>4xx: Client Error
    <ul>
      <li>400: Bad Request</li>
      <li>401: Unauthorized </li>
      <li>404: Not Found </li>
    </ul>
  </li>
    <li>5xx: Server Error
    <ul>
      <li>500: Internal Server Error</li>
    </ul>
  </li>
</ul>

### 👨‍🎓 3.3 - Criando Projeto Node

<h5>Criando primeiro projeto Node</h5>

<ul>
  <li>Criar uma pasta para o projeto com comando mkdir backend</li>
  <li>Executar comando yarn init -y dentro da pasta criada anteriormente</li>
  <li>O comando anterior criará o package.json</li>
  <li>Dentro da pasta backend executando o comando code . ele abrirá o VS Code</li>
  <li>Dentro da pasta backend criar uma pasta src</li>
  <li>Dentro da pasta src criar arquivo index.js</li>
  <li>Instalar o pacote do Express utilizando o comando yarn add express</li>
   <li>Para rodar o projeto node basta rodar o comando node src/index.js</li>
  <li>O Node por padrão não faz a reinicialização em caso de alteração no código</li>
</ul>

### 👨‍🏫 3.4 - Configurando Nodemon

<p>Nodemon é uma ferramenta para observar as alterações no código e reiniciar a aplicação automaticamente</p>

<p>Para instalar o pacote rodar o yarn add nodemon -D</p>

<p>o -D indica que a dependência é somente em desenvolvimento</p>

<p>Dentro do package.json pode ser criado um script personalizado para rodar o projeto com um pequeno trecho de código, nesse caso basta rodar yarn dev para iniciar o projeto</p>

<p>A função no express listen pode receber um segundo parâmetro que é uma função dessa forma é possível adicionar um console.log para informar que o servidor foi reiniciado</p>

<p>É possível adicionar um emoji nesse console.log, basta adicionar a extensão Emoji no VS Code</p>

### 👨‍🏫 3.5 - Métodos HTTP
