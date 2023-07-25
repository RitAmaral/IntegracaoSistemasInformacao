# Projeto Final da UFCD 5421

## Tema: Implementar um Sistema de Informação para gestão de concurso "tipo" festival da canção da eurovisão.

![image](https://github.com/RitAmaral/IntegracaoSistemasInformacao/assets/132366922/f1287a71-6e84-4375-a68b-eb19ddcab248)

### Evidências demonstradas (esperadas)

  - Análise;
  - Código C# bem estruturado;
  - Aplicar e saber aplicar padrões de design (Singleton, Abstract, Factory);
  - Aplicar e saber aplicar interfaces;
  - Aplicar e saber aplicar padrões de arquitetura (MVC/MVVM, N-Tier);
  - Solução final bem construida e projetos/componentes bem definidos;
  - Reutilização de código;
  - (implementação da camada de acesso a base de dados, alternativa a XML)
  - (implementação de WebApp)
  - (implementação de cliente de WebApp)

### Entregáveis

  - Solução completa (sem binários) no repositório privado individual;
  - Pelo menos um projeto "tipo console", com evidências para demonstrar o funcionamento da solução do projeto;
  
NOTA: deve ser incluido um documento no formato PDF com os diapositivos da apresentação

### Apresentação

O formato a utilizar: **PechaKucha** 
  - **20** diapositivos x **20** segundos = 400 segundos = **6 minutos e 40 segundos**

(**NOTA**: É um formato de apresentação criado para incentivar os apresentadores a concentrarem-se e a partilharem uma ideia da forma mais concisa possível.)

Formato do conteúdo da apresentação recomendado:
  - Powerpoint programado para avançar diapositivos automáticamente a cada 20 segundos;
  - Apresentação (Powerpoint) convertida em formato vídeo; 

Mais informações:
  - [Wikipedia](https://en.wikipedia.org/wiki/PechaKucha);
  - [Advice for Participants](https://www.ucc.ie/en/appsoc/resconf/conf/cst/criticalsocialthinkingstudentresearchinitiative2015/sym/pk/);
  - [Pecha Kucha](https://www.pechakucha.com)
  - 
   
### Critérios de avaliação

<em construção, será colocado neste documento posteriormente>

---

## Notas do Projeto Final:

**Versão Final: [v11](ProjFinal_Rita_v11)**

### Descrição do modelo de negócio/atividade do tema do trabalho prático:

O objetivo do projeto é implementar um Sistema de Informação para gestão de concurso "tipo" festival da canção da eurovisão. A Eurovisão é uma competição de músicas entre países da Europa e também a Austrália. Cada país tem 3 minutos para impressionar o público e o júri com a sua música, para obter votos/pontos e ser coroado o vencedor da Eurovisão.
Neste sistema será possível criar concorrentes que vão participar na Eurovisão, sendo que, foram utilizados os dados e resultados obtidos na [Eurovisão 2023](https://eurovision.tv/story/swedens-loreen-wins-eurovision-song-contest-2023). Vão ser inseridos os países, o nome dos representantes e das músicas, os pontos obtidos por cada música pelo júri e pelo televoto em cada ronda (semifinal1, semifinal2 e final). Além da adição de concorrentes e da modificação dos pontos nas respetivas rondas, será também possível eliminar os concorrentes que não obtiveram pontos suficientes para se qualificarem para a final. Vai também ser possível ordenar os concorrentes por total de pontos obtidos (pontos júri + pontos televoto) para ser possível saber quem é o vencedor da Eurovisão 2023.
Neste projeto vai ser usado o padrão de arquitetura N-tier, para dividir o sistema em camadas lógicas e físicas e assim dividir responsabilidades e gerir dependências.  Também vai ser usado o padrão de design singleton na classe GetNewId (que está na biblioteca de classes ToolBox). O padrão Singleton garante que uma classe tenha apenas uma instância e fornece um ponto de acesso global a essa instância. Neste projeto isto é importante pois tem de haver apenas uma instância da classe GetNewId, o que garante controlo sobre os IDs, evitando assim duplicações. 

Sites consultados para verificação dos resultados obtidos na Eurovisão 2023: 

- [Site Oficial da Eurovisão](https://eurovision.tv/story/swedens-loreen-wins-eurovision-song-contest-2023)
- [Resultados da Final](https://eurovisionworld.com/eurovision/2023)
- [Resultados da Semifinal 1](https://eurovisionworld.com/eurovision/2023/semi-final-1)
- [Resultados da Semifinal2](https://eurovisionworld.com/eurovision/2023/semi-final-2) 

### Estruturas de dados que vão ser utilizadas:

Neste projeto foram criadas diversas Bibliotecas de classes, três Aplicativos de console, e um API Web do ASP.NET Core. Começando pelas bibliotecas de classes, e seguindo o padrão de arquitetura N-tier:

A classe *Eurovisao* (que está na biblioteca de classes **Eurovisao_BO** – business object, onde definimos as estruturas de dados) possui as seguintes propriedades:  
- ID: (get new id) int
- NomePais: string
- NomeRepresentante: string
- NomeMusica: string
- Ronda:  string (vem do enum Ronda que está na biblioteca de classes **Eurovisao_Constantes** que vai ser mencionada mais à frente)
- PontosJuri: int
- PontosTelevoto: int
- TotalPontos: int => PontosJuri + PontosTelevoto; TotalPontos é uma Propriedade - Read-only: só leitura, que get/recebe PontosJuri + PontosTelevoto

Depois foram criadas as seguintes bibliotecas de classes em concordância com o padrão de arquitetura N-tier: 

- Camada de Apresentação: biblioteca de classes **Eurovisao_Console** - responsável pela interação com o utilizador, é a camada que mostra informações.
- Business Logic: biblioteca de classes **Eurovisao_BL** - é a camada da lógica e das regras de negócio, que define classes e métodos (que interagem com a camada Data Access Layer) para lidar com as operações e regras de negócio relacionadas com os objetos da classe *Eurovisao*. Nesta biblioteca temos uma classe Eurovisao_BR (regras do negócio) e uma interface IEurovisaoMetodos, que define os métodos que devem ser implementados pelas classes que a utilizam, neste caso Eurovisao_BR. 
- Data Access Layer: biblioteca de classes **Eurovisao_DAL** - é a camada de dados que é responsável por aceder e manipular os dados. Contém métodos para executar operações nos objetos da classe *Eurovisao* (como por exemplo: AdicionarConcorrente, ModificarPontos, ExisteConcorrente, ApagarConcorrente, entre outros). 

Neste projeto também foram criadas as seguintes bibliotecas de classes: 
- **Eurovisao_Constantes** - com a classe *Constantes* que torna possível a serialização em XML, e com o Enum Ronda (semifinal1, semifinal2, final).
- **ToolBox** - com a classe *GetNewID*, que utiliza o padrão de design Singleton, para ser possível atribuir um id automático, e não haver duplicações de IDs neste projeto.
- **SerializeTools** - com a classe *XmlMethods*, fornece os métodos necessários para a serialização em formato XML.

Além disso, foi criada a lista *_eurovisaoList*, que será utilizada para armazenar os objetos da classe *Eurovisao* e realizar operações de adição, remoção e manipulação dos dados que mencionei acima na biblioteca de classes **DAL**. 

Posteriormente, foi criada uma estrutura (struct) chamada *RegistoConcorrente* dentro da classe Eurovisao, para possibilitar a serialização dos dados em formato XML. 

Para ser possível a serialização em formato JSON: 

Foi criada uma nova solução API Web do ASP.NET Core: Eurovisao_WebAPI. E logo de seguida foi criado um novo Controller: EurovisaoController. No Controller foi colocada a estrutura fundamental que permite executar o CRUD (Create, Read, Update, Delete) na lista de concorrentes da Eurovisão em formato JSON, através do [swagger](https://editor.swagger.io/). O swagger é uma ferramenta que nos permite visualizar, documentar e testar APIs. Neste projeto, será possível visualizar no swagger a lista de concorrentes da eurovisão (o nome dos países, representantes, músicas e pontos obtidos na final), sendo que também podemos pesquisar e obter dados de um determinado concorrente por id. Será também possível editar e apagar concorrentes. Mas para isso acontecer, foi também preciso criar as seguintes bibliotecas de classes: 

- **Eurovisao_Models2Api** - Contêm 2 classes:
  - *EuroRegistoRequest*
  - *EuroRegistoResponse*
- **Eurovisao_Services2Api** - Contêm 1 classe:
  - *EurovisaoServices* 

Também tiveram de ser criados novos métodos, como por exemplo GetConcorrenteListResponse() e ModificarConcorrenteRequest() em Eurovisao_BR e GetConcorrentes em Eurovisao_DAO. 

Também foi criada outra nova solução: aplicativo de console: EuroConsole2Api. Que permite vermos na consola o formato JSON que aparece no 'swagger'.  

Estas são as principais estruturas de dados e serializações envolvidas no projeto, abrangendo a serialização em formato XML e em formato JSON. 

Depois, para ser possível a ligação à base de dados, foram feitas mais algumas alterações, ou melhor dizendo, foram adicionadas novas estruturas para ser possível adicionar esta nova funcionalidade.
Mas primeiro, foi criada a base de dados EUROVISAODB, para serem guardados os concorrentes participantes na Eurovisão 2023:

    DROP TABLE IF EXISTS concorrentes;

    CREATE TABLE IF NOT EXISTS concorrentes (

       id integer primary key generated by default as identity,
 
       pais character varying(100) NOT NULL,
 
       nomerepresentante character varying(100) NOT NULL,

       nomemusica character varying(100) NOT NULL,
 
       ronda smallint NOT NULL,
 
       pontosjuri smallint NOT NULL,
 
       pontostelevoto smallint NOT NULL,
 
       totalpontos smallint NOT NULL );

De seguida, foram feitas as seguintes alterações na solução:
- Foram duplicados os projetos BO, BL, DAL, Console, Services2Api, WebAPI, e modificados para BOpg, BLpg, DALpg, Consolepg, Services2Apipg, WebApipg, tanto no nome como depois no ficheiro .csproj. Nota: quando forem adicionados os projetos, não esquecer de alterar os namespaces (acrescentar pg), e também de alterar as dependências;
- Em Eurovisao_Constantes foi adicionada uma constante que vai ser depois necessária para o projeto Eurovisao_Configuration (que vai ser criado/mencionado de seguida): public const string NomeXmlConfiguration = "EurovisaoCFG.xml";
- Foi criada a biblioteca de classes Eurovisao_Configuration que é necessária para tornar persistente a configuração de acesso à base de dados PostgreSQL. (Contém uma estrutura para guardar todas as informações de configuração do software);
- O ID é agora gerado automaticamente através da base de dados, e não da classe GetNewId;
- Em BLpg e DALpg, foi adicionado o package Npgsql 7.0.4 que permite a conexão e interação com o server PostgreSQL.

### Requisitos funcionais:

O sistema deve permitir:
1. Inserir concorrentes: O sistema deve permitir a inserção dos 37 países concorrentes da Eurovisão 2023 numa lista, fornecendo as informações necessárias, como o nome do país, nome do representante, nome da música, etc.
2. Atribuir pontos do júri e televoto: O sistema deve permitir a atribuição ou modificação dos pontos obtidos por cada concorrente nas semifinais, tanto pelo júri quanto pelo televoto. Apesar de que, este ano, não houve votações do júri nas semifinais, e por isso nesta fase vão ser colocados 0 pontos de júri em todas as músicas.
3. Calcular total de pontos: Com base nos pontos atribuídos pelo júri e televoto, o sistema deve calcular o total de pontos de cada concorrente, somando os dois valores.
4. Selecionar finalistas: O sistema deve identificar os 10 concorrentes com maior pontuação em cada semifinal para avançarem para a final. Além disso, devem ser adicionados automaticamente os 6 países já qualificados para a final (os 'big 5': Reino Unido, Itália, Espanha, França e Alemanha; e o país vencedor da última edição da Eurovisão, a Ucrânia).
5. Ordenar lista por total de pontos: Após a realização da final, o sistema deve ordenar a lista de concorrentes por ordem decrescente de total de pontos, para determinar a classificação final.
6. Identificar vencedor: Com a lista ordenada por total de pontos, o sistema deve identificar o concorrente com a maior pontuação como o vencedor da Eurovisão.
7. Serialização dos dados: O sistema deve suportar a serialização dos dados em formatos XML e JSON, permitindo a exportação e importação dos dados do concurso da Eurovisão. Isto garante a portabilidade dos dados, facilitando a integração com outros sistemas ou a realização de backups.
8. Acesso à Base de dados: O sistema deve permitir o acesso à base de dados PostgreSQL para guardar os dados relacionados com os concorrentes (como o nome do representante e da música de cada país).

### Estrutura pensada para o desenvolvimento do projeto:

A gestão do sistema da Eurovisão vai ser feita por uma lista, onde inserimos todos os 37 concorrentes por fases. Primeiro serão adicionados 15 concorrentes da primeira semifinal, depois mais 16 concorrentes para a segunda semifinal, e finalmente serão adicionados mais 6 países já automaticamente qualificados para a final.  

Em cada semifinal, vão ser colocados os pontos obtidos (júri e televoto), e vão ser calculados o total de pontos (Pontos do Júri + Pontos do Televoto). No entanto, nas semifinais, o júri não votou, por isso todos os votos do júri vão ser colocados a 0. Concluído o período de votação, passam para a final os 10 concorrentes de cada semifinal (20 no total) que obtiveram mais votos, e juntam-se a eles os 6 países já automaticamente qualificados para a final (Alemanha, Espanha, Itália, França, Reino Unido e Ucrânia). No fim, a lista é ordenada pelo total de pontos obtidos (soma dos pontos do júri e televoto), e quem tiver mais pontos será o vencedor da Eurovisão 2023. Esta lista será depois guardada em ficheiros XML e JSON, e também na base de dados criada.
