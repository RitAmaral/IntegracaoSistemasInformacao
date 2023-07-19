# Task 07

## Enunciado:

Utilizando todo o trabalho produzido na “Task06” (duplicando a pasta utilizando os conselhos fornecidos em contexto de aula) e mantendo a imagem do modelo visual, pretende-se que seja acrescentado um novo conjunto de projetos para implementar as alterações necessárias na solução para adicionar o acesso à base de dados PostgreSQL, utilizando as estratégias sugeridas em contexto de aula.
O novo conjunto de projetos da solução para acesso à base de dados deve reproduzir o mesmo comportamento evidenciado no conjunto de projetos que implementa o acesso aos dados em XML.
NOTA: todo o código deverá estar a funcionar sem erros.

O objetivo é atualizar a solução duplicada com o código criado e separado por módulos reutilizáveis, deve-se acrescentar as funcionalidades que se considerem necessárias de acordo com a interpretação feita do enunciado. Deverá incluir todas as aprendizagens até ao momento. O output da solução deverá ser feito a partir de projetos do tipo “Console app” correspondente a cada uma funcionalidade adicionada desde a “Task04”.


![image](https://github.com/RitAmaral/IntegracaoSistemasInformacao/assets/132366922/dce2d556-99f3-4354-b9cf-cabd737ba4e0)

---

### Resposta Task 07:

Primeiro foi criada a base de dados ANOTACOESDB, para serem guardadas as anotações criadas.

**(Colocar aqui código sql)**

Depois foram feitas várias alterações na solução:

- Foram duplicados os projetos BO, BL, DAL, Task04App (é a Console), Services2Api, WebAPI, e modificados para BOpg, BLpg, DALpg, Task04Apppg, Services2Apipg, WebApipg, tanto no nome como depois no ficheiro .csproj. Nota: quando forem adicionados os projetos, não esquecer de alterar os namespaces (acrescentar pg), e também de alterar as dependências.
- Em Anotacoes_Constantes foi adicionada uma constante que vai ser depois necessária para o projeto Anotacoes_Configuration (que vai ser criado de seguida): public const string NomeXmlConfiguration = "AnotacoesCFG.xml";
- Foi criada a biblioteca de classes Anotacoes_Configuration que é necessária para tornar persistente a configuração de acesso à base de dados PostgreSQL. (Contém uma estrutura para guardar todas as informações de configuração do software).
- O ID é agora gerado automaticamente através da base de dados, e não da classe GetNewId;
- Foram removidas as estruturas para serialização em xml e json em quase todas as bibliotecas.
- Em BLpg e DALpg, foi adicionado o package Npgsql 7.0.4 que permite a conexão e interação com o server PostgreSQL.

**Nota:** Os outputs estão nos projetos: “Task04App”, “Task04Apppg”, “AnotConsole2Api”, “Anotacoes_WebAPI” e “Anotacoes_WebAPIpg”**.
  
