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

### Notas do Projeto Final:

**Descrição do modelo de negócio/atividade do tema do trabalho prático:**

O objetivo do projeto é implementar um Sistema de Informação para gestão de concurso "tipo" festival da canção da eurovisão. Neste projeto vai ser usado o padrão de arquitetura N-tier, para dividir o sistema em camadas lógicas e físicas e assim dividir responsabilidades e gerir dependências.  Também vai ser usado o padrão de design singleton na classe GetNewId (que está na biblioteca de classes ToolBox). O padrão Singleton garante que uma classe tenha apenas uma instância e fornece um ponto de acesso global a essa instância. Neste projeto isto é importante pois tem de haver apenas uma instância da classe GetNewId, o que garante controlo sobre os IDs, evitando assim duplicações. 

**Estruturas de dados que vão ser utilizadas:**

A classe *Eurovisao* (que está na biblioteca de classes **Eurovisao_BO** – business object, onde definimos as estruturas de dados) possui as seguintes propriedades:  
- ID: (get new id) int
- NomePais: string
- NomeRepresentante: string
- NomeMusica: string
- PontosJuri: int
- PontosPublico: int
- TotalPontos: int => PontosJuri + PontosTelevoto; TotalPontos é uma Propriedade - Read-only: só leitura, que get/recebe PontosJuri + PontosTelevoto

Depois foram criadas as seguintes bibliotecas de classes em concordância com o padrão de arquitetura N-tier: 

- Camada de Apresentação: biblioteca de classes **Eurovisao_Console** - responsável pela interação com o utilizador, é a camada que mostra informações.
- Business Logic: biblioteca de classes **Eurovisao_BL** - é a camada da lógica e das regras de negócio, que define classes e métodos (que interagem com a camada Data Access Layer) para lidar com as operações e regras de negócio relacionadas com os objetos da classe *Eurovisao*.
- Data Access Layer: biblioteca de classes **Eurovisao_DAL** - é a camada de dados que é responsável por aceder e manipular os dados. Contém métodos para executar operações nos objetos da classe *Eurovisao* (como por exemplo: AdicionarConcorrente, ModificarPontos, ExisteConcorrente, ApagarConcorrente). 

Neste projeto também foram criadas as seguintes bibliotecas de classes: 
- **Eurovisao_Constantes** - para ser possível a serialização
- **ToolBox** - para ser possível atribuir um id automático
- **SerializeTools** - para ser possível a serialização 

Posteriormente, foi criada uma estrutura (struct) chamada *RegistoConcorrente* para possibilitar a serialização dos dados. 

Além disso, foi criada a lista *_eurovisaoList*, que será utilizada para armazenar os objetos da classe *Eurovisao* e realizar operações de adição, remoção e manipulação dos dados que mencionei acima na biblioteca de classes **DAL**. 

**Requisitos funcionais:** 

1. Inserir concorrentes: O sistema deve permitir a inserção dos 37 países concorrentes da Eurovisão 2023, fornecendo as informações necessárias, como nome do país, nome do representante, nome da música, etc.
2. Atribuir pontos do júri e televoto: O sistema deve permitir a atribuição ou modificação dos pontos obtidos por cada concorrente nas semi-finais, tanto pelo júri quanto pelo televoto. Apesar de que, este ano, não houve votações do júri nas semi-finais, e por isso nesta fase vão ser colocados 0 pontos de júri em todas as músicas.
3. Calcular total de pontos: Com base nos pontos atribuídos pelo júri e televoto, o sistema deve calcular o total de pontos de cada concorrente, somando os dois valores.
4. Selecionar finalistas: O sistema deve identificar os 10 concorrentes com maior pontuação em cada semi-final para avançarem para a final. Além disso, devem ser adicionados automaticamente os 6 países já qualificados para a final (os big 5: Reino Unido, Itália, Espanha, França e Alemanha; e o país vencedor da última edição da Eurovisão, a Ucrânia).
5. Ordenar lista por total de pontos: Após a realização da final, o sistema deve ordenar a lista de concorrentes por ordem decrescente de total de pontos, para determinar a classificação final.
6. Identificar vencedor: Com a lista ordenada por total de pontos, o sistema deve identificar o concorrente com a maior pontuação como o vencedor da Eurovisão. 

**Estrutura pensada para o desenvolvimento do projeto:**

A gestão do sistema da Eurovisão vai ser feita por uma lista, onde inserimos todos os 37 concorrentes. Vão ser colocados os pontos obtidos (júri, televoto), em cada semi-final, e vão ser calculados o total de pontos. No entanto, nas semi-finais, o júri não votou, por isso todos os votos do júri vão ser 0. Depois, passam para a final os 10 concorrentes de cada semi-final, e juntam-se a eles, 6 países já automaticamente qualificados para final. No fim a lista é ordenada por total pontos, e quem tiver mais pontos será o vencedor da Eurovisão 2023. 
