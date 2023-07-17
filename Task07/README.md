# Task 07

## Enunciado:

<Em construção>

![image](https://github.com/RitAmaral/IntegracaoSistemasInformacao/assets/132366922/dce2d556-99f3-4354-b9cf-cabd737ba4e0)

---

### Resposta Task 07:

<Em construção>

Para ser feita a serialização em formato JSON:

Primeiro foi criado um novo projeto WEB API: **Anotacoes_WebAPI**. Dentro deste projeto, existe uma pasta Controllers, onde foi criado um novo Controller: *AnotacoesController*.
De seguida foram criadas 2 bibliotecas de classes:
- Anotacoes_Models2Api
  - Contêm 2 classes: AnotRegistoRequest e AnotRegistoResponse
- Anotacoes_Services2Api
  - Contêm 1 classe: AnotacoesServicos
 
Foram criados novos métodos em **AnotacoesAula_BR** para poder ser feito o CRUD (Create, Read, Update e Delete). E por isso, também foram adicionados os métodos correspondentes em **AnotacoesAula_DAO** (se estivessem em falta).

Depois, no Agenda Controller foi colocada a estrutura necessária que permite executar o CRUD (que aparece como *Get, Post, Put, Delete*) na lista de anotações. Quando acedermos ao swagger (que é um site que nos permite visualizar, documentar e testar APIs), vai aparecer a lista em formato JSON e depois podemos aplicar as alterações que quisermos na lista de anotações (obter, inserir, modificar, apagar).

O que aparece no swagger:

![image](https://github.com/RitAmaral/IntegracaoSistemasInformacao/assets/132366922/f799260e-176d-4aa6-af8c-850ac8762d9d)

Se executarmos o GET/api/Anotacoes, vemos a lista de anotações, como podemos ver na imagem seguinte algumas anotações:

![image](https://github.com/RitAmaral/IntegracaoSistemasInformacao/assets/132366922/7c082aa8-75db-460e-bd0f-599dd7b61d1c)

Podemos verificar que na anotação com o id 10 temos revisado como false, podemos alterar para true em PUT/api/Anotacoes/{id}:

![image](https://github.com/RitAmaral/IntegracaoSistemasInformacao/assets/132366922/057e0bee-fbf0-47cc-8d66-dd8168a09a57)

Como podemos verificar na imagem acima, a alteração foi feita com sucesso. A propriedade revisado passou para true, e obtivemos o status code 200, que é o status OK.

Também foi criado um outro projeto, aplicativo de console: **AnotConsole2Api**. Que permite vermos na consola o formato JSON que aparece no swagger (apesar de que também podemos apresentar o resultado de uma forma mais fácil de ler, como vemos na imagem embaixo as 2 formas). Em cima da Console2Api devemos clicar no gerir nuget, e instalar o Newtonsoft.Json.

![image](https://github.com/RitAmaral/IntegracaoSistemasInformacao/assets/132366922/81a46893-dcfb-40ee-9982-1d60cfd89e52)


**Nota:** Um dos outputs da solução está no Projeto chamado **“Task04App”**.
  
