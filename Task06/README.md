# Task 06

## Enunciado:

Utilizando todo o trabalho produzido na “Task05” (duplicando a pasta utilizando os conselhos fornecidos em contexto de aula) e mantendo a imagem do modelo visual, pretende-se que seja acrescentado um novo projeto (tipo “ASP.NET Core Web API”) à solução acrescentando as funcionalidades necessárias para CRUD (acrónimo para CREATE, READ, UPDATE e DELETE). Para facilitar pode-se utilizar o mesmo método utilizado em aula. (incluindo um projeto “tipo” console para demonstrar o funcionamento utilizando a ligação ao API).

![image](https://github.com/RitAmaral/IntegracaoSistemasInformacao/assets/132366922/dce2d556-99f3-4354-b9cf-cabd737ba4e0)

---

### Resposta Task 06:

Primeiro foi criado um novo projeto WEB API: **Anotacoes_WebAPI**. Dentro deste projeto, existe uma pasta Controllers, onde foi criado um novo Controller: *AnotacoesController*.
De seguida foram criadas 2 bibliotcas de classes:
- Anotacoes_Models2Api
  - Contêm 2 classes: AnotRegistoRequest e AnotRegistoResponse
- Anotacoes_Services2Api
  - Contêm 1 classe: AnotacoesServicos
 
Foram criados novos métodos em **AnotacoesAula_BR** para poder ser feito o CRUD (Create, Read, Update e Delete). E por isso, também foram adicionados os métodos correspondentes em **AnotacoesAula_DAO** (se estivessem em falta).

Depois, no Agenda Controller foi colocada a estrutura necessária (*Get, Post, Put, Delete*) para aceder ao swagger onde vemos os dados em formato json.

Também foi criado um outro projeto, aplicativo de console: **AnotConsole2Api**. Que permite vermos na consola o formato json que aparece no swagger. Em cima da Console2Api devemos clicar no gerir nuget, e instalar o Newtonsoft.Json.

**Nota:** Um dos outputs da solução está no Projeto chamado **“Task04App”**.
  
