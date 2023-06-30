# Projeto Final

## Tema: Implementar um Sistema de Informação para gestão de concurso "tipo" festival da canção da eurovisão.

### Versão 8

Nesta versão 8: 
- antes as listas estavam separadas por ronda, agora estão todas na mesma lista
- novo método para apagar concorrente por ronda
- novo método para obter/get concorrentes por ronda
- novo métodos historico - no entanto não percebo porque devo implementar porque so mostra o histórico dos países que estão na final, aliás, nem mostra histórico, só mostra mesmo os pontos obtidos na final.. não mostra os concorrentes que já foram eliminados da lista..
- **serialização Json:**

Foi criada uma nova solução API Web do ASP.NET Core: Eurovisao_WebAPI. Depois criado um novo Controller: EurovisaoController. Foram criadas 2 bibliotecas de classes:
- Eurovisao_Models2Api
  - Contêm 2 classes: EuroRegistoRequest e EuroRegistoResponse
- Eurovisao_Services2Api
  - Contêm 1 classe: EurovisaoServices

Foram criados novos métodos: GetConcorrenteListResponse() em Eurovisao_BR e GetConcorrentes em Eurovisao_DAO.

Nas propriedades da Eurovisao Web API devemos ir a Saída e fazer check no Arquivo da documentação. 

Também foi criado um outro projeto, aplicativo de console: EuroConsole2Api. Que permite vermos na consola o formato json que aparece no swagger. Em cima da Console2Api devemos clicar no gerir nuget, e instalar o Newtonsoft.Json.

 
