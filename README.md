# Ruler
###### Esse documento auxiliará no desenvolvimento da Aplicação

### Dados do projeto
**Empresa:** ##\
**Nome do app:** Ruler\
**Site:** ##\
**Tecnologias de desenvolvimento:** [C#](https://docs.microsoft.com/pt-br/dotnet/csharp/) | [Asp.net Web Forms](https://dotnet.microsoft.com/apps/aspnet/web-forms) | [Entity Framework](https://docs.microsoft.com/pt-br/ef/ef6/get-started) 

### Requisitos
- [Visual Studio](https://visualstudio.microsoft.com/pt-br/).
- [SQL Server](https://www.microsoft.com/pt-br/sql-server/sql-server-downloads).
- [.Net Framework 4.5](https://www.microsoft.com/pt-br/download/details.aspx?id=30653).

### Dependencias
- [Entity FrameWork](https://docs.microsoft.com/pt-br/ef/ef6/fundamentals/install)

### Instalação Requisitos
- Via Executavel.

### Instalação Dependencias
- Via Nuget.
- Via Console.

### Estrutura dos arquivos da Aplicação
**Content/** - Arquivos estáticos: fontes, imagens, etc.\
**Views/** - Arquivos referentes as views. \
**Controllers/** - Arquivos referentes aos controladores.\
**Models/** - Arquivos referentes aos modelos de entidades.\
**Context/** - Arquivos referentes a conexão entre as entidades com o banco.\
**Components/** - Arquivos comuns da aplicação. Inclui componentes e utilitários.\
**Components/Styles/** - Arquivos de estilo da aplicação.\
**.gitignore** - Configura arquivos a serem ignorados pelo git.\
**BasePge.Master** - Pagina pai.\
**Globals.cs** - Metodos e atributos staticos.\
**packages.config** - Arquivo de dependências do projeto.\
**web.config** - Arquivo de configurações do projeto.\
**README.md** - Leia-me com instruções.\

### GitFlow
O [GitFlow](https://medium.com/trainingcenter/utilizando-o-fluxo-git-flow-e63d5e0d5e04) Workflow é um design de fluxo de trabalho Git que define um modelo de ramificação projetado em torno da versão do projeto. Isso fornece uma estrutura robusta para gerenciar projetos maiores.\
[Saiba mais](https://datasift.github.io/gitflow/IntroducingGitFlow.html) sobre o GitFlow.\
[Explicação da ferramenta git-flow](https://fjorgemota.com/git-flow-uma-forma-legal-de-organizar-repositorios-git/) se for usar ela.

![](https://proxy.duckduckgo.com/iu/?u=https%3A%2F%2Fraw.githubusercontent.com%2FVoronenko%2Fgitflow-release%2Fmaster%2Fimages%2Fgit-workflow-release-cycle-4maintenance.png&f=1)

### Versionamento Semântico
O Versionamento Semântico são regras que formalizam de forma prática e eficiente o incremento de versões de software. O versionamento do ruler deve basedado na versão 2 do Versionament Semântico utilizando as regras 2, 3, 4, 6, 7, 8, 9 e 11 encontradas no [site do samver.org](https://semver.org/lang/pt-BR/).

### Commits Semânticos
Para uma melhor navegação pelos commits, possibilitando um entendimento melhor e mais rápido, e consequentemente melhorando a manutenção do sistema, utilizamos um [padrão](https://gist.github.com/eltonea/a717e3c786686b674f4ebe2475ca3313) na escrita do commit similar ao proposto por http://karma-runner.github.io/3.0/dev/git-commit-msg.html.
As linhas das mensagens de commit não devem exceder 72 caracteres. Essa convenção permite uma boa leitura dos commits na maiorias dos terminais.

**Formato da mensagem de commit:**\
\<tipo\>\(<escopo>\): \<assunto\>\
\<linha em branco\>\
\<mensagem\>\
\<linha em branco\>\
\<rodapé\>

**Exemplo:**
```sh
chore(eslint): instalar dependência eslint

A dependência eslint é um utilitário de linting para JavaScript.
Auxilia o desenvolvedor a escrever o código em um padrão
preestabelecido.

BREAKING CHANGE:
Quanto ao foo.bar, foo.baz deve ser utilizado ao invés disso.
```

**\<tipo\>:**
  - **feat** - nova funcionalidade/recurso (features)
  - **fix** - correção de bug
  - **perf** - uma mudança de código que melhora a performance
  - **docs** - alterações na documentação
  - **style** - formatação, falta de ponto e vírgula, etc; não afetam o significado do código
  - **refactor** - refatoração do código, não corrige um bug nem adiciona um recurso; por exemplo, renomear variável
  - **test** - adição ou correção de testes
  - **chore** - atualizando tasks do Grunt, Webpack, etc; mudanças que não modificam o src/

**\<escopo\>:** Opcional, principalmente se a alteração for global.\
Exemplos: init, runner, watcher, config, web-server, proxy, etc.

**\<assunto\>:** Deve ser escrito na forma imperativa, ou se preferir, de uma forma que complete a frase "Se aplicado, este commit irá ".

**\<corpo\>:** Deve conter descrições mais precisas do que está contido no commit, mostrando as razões ou consequências geradas pela alteração, assim como instruções futuras.

**\<rodapé\>:** È dedicado para notas e avisos importantes, como fechamento de issue e se existem mudanças radicais que quebrem funcionalidades. No caso de mudanças de quebras (BREAKING CHANGE) deve ser indicado “BREAKING CHANGE:” seguido com a explicação que leva a inclusão dessa marcação.
