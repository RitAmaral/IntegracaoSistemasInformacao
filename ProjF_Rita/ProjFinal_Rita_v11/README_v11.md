# Projeto Final

## Tema: Implementar um Sistema de Informação para gestão de concurso "tipo" festival da canção da eurovisão.

### Versão 11

Nesta versão foi implementada a base de dados EUROVISAODB, para serem guardados os concorrentes participantes na Eurovisão 2023.

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

Depois foram feitas várias alterações na solução:
- Foram duplicados os projetos BO, BL, DAL, Console, Services2Api, WebAPI, e modificados para BOpg, BLpg, DALpg, Consolepg, Services2Apipg, WebApipg, tanto no nome como depois no ficheiro .csproj. Nota: quando forem adicionados os projetos, não esquecer de alterar os namespaces (acrescentar pg), e também de alterar as dependências.
- Em Eurovisao_Constantes foi adicionada uma constante que vai ser depois necessária para o projeto Eurovisao_Configuration (que vai ser criado de seguida): public const string NomeXmlConfiguration = "EurovisaoCFG.xml";
- Foi criada a biblioteca de classes Eurovisao_Configuration que é necessária para tornar persistente a configuração de acesso à base de dados PostgreSQL. (Contém uma estrutura para guardar todas as informações de configuração do software).
- O ID é agora gerado automaticamente através da base de dados, e não da classe GetNewId;
- Em BLpg e DALpg, foi adicionado o package Npgsql 7.0.4 que permite a conexão e interação com o server PostgreSQL.