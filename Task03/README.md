# Task 03

**Padrões de Arquitetura:** MVC (Model-View-Controller)

- Modelo/Model: é a parte do sistema que trata dos dados e da lógica;
- Visualização/View: lida com a interface do utilizador e a forma como as informações são exibidas;
- Controlador/Controller: coordena as ações do utilizador e comunica-se com o modelo e a visualização. 

## Material de Trabalho

Utilizando como base o projeto de POO, deve-se escolher uma estrutura do projeto entregue para rescrever e transformar para o padrão MVC.

## Objetivo:

Aplicar as estratégias abordadas em contexto de aula para reescrever o código escolhido.

**Material de apoio:**
- [Task 03](https://github.com/pinjoa/ufcd5420_CESAE_SDEV03_BRA/tree/main/Task03)
- [Codigo do Colaborador](https://github.com/RitAmaral/TrabalhoAplicacao/blob/main/TPApp1/TPApp1/Entities/Colaborador.cs)
- [Codigo do Médico](https://github.com/RitAmaral/TrabalhoAplicacao/blob/main/TPApp1/TPApp1/Entities/Medico.cs)

---

## Resposta da Task 03

**Padrão de Arquitetura:** MVC (Model-View-Controller).

O MVC é um padrão de arquitetura usado para implementar interfaces de utilizador (view), dados (model) e um controlador que comunica com o model e a view (controller).
Escolhi as classes [Colaborador](https://github.com/RitAmaral/TrabalhoAplicacao/blob/main/TPApp1/TPApp1/Entities/Colaborador.cs) e [Médico](https://github.com/RitAmaral/TrabalhoAplicacao/blob/main/TPApp1/TPApp1/Entities/Medico.cs) do [projeto de POO](https://github.com/RitAmaral/TrabalhoAplicacao/tree/main/TPApp1/TPApp1) para alicar o padrão de MVC.

Comecei por criar 3 pastas: Controller, Model, View, e depois as respetivas classes do Colaborador e do Médico em cada pasta. Comecei por escrever os models/modelos do Colaborador e do Médico, onde coloquei as propriedades e métodos de *ObterDetalhes* onde coloquei alguns dados sobre o Colaborador e o Médico, respetivamente.

Depois, nas classes View, coloquei mais métodos onde vai aparecer a informação que vai ser mostrada ao utilizador no programa. Por exemplo na classe MedicoView, criei o método *EscreverDetalhesMedico* que recebe os seguintes parâmetros: string funcao, int id, string nome, entre outros. Dentro do método escrevo: 

` Console.WriteLine("Detalhes: "); `

` Console.WriteLine(); `

` Console.WriteLine("Função: " + funcao); `

` Console.WriteLine("ID: " + id); `

` Console.WriteLine("Nome: " + nome); `

Este código é o que vai aparecer no terminal do programa quando chamarmos o método *MostrarDetalhes* que vai ser criado na classe do MedicoController. Neste método vamos buscar o método *ObterDetalhes* que foi criado na classe MedicoModel, e vamos buscar o método *EscreverDetalhesMedico* criado na classe MedicoView. 

Depois, no programa, são criados objetos das 3 classes (exemplo: `MedicoModel medmodel = new MedicoModel();`), e chamamos então o método *MostrarDetalhes*: `med22.MostrarDetalhes(1)`, que nos mostra isto no terminal:

![image](https://github.com/RitAmaral/IntegracaoSistemasInformacao/assets/132366922/c29e7074-a536-464a-9710-dfe114b76be4)

De seguida foi aplicada a mesma forma de pensar para os restantes métodos criados.

---

**Notas:**

*Tive que alterar algumas coisas em relação ao projeto original:*
- *Em relação à classe do Colaborador, alterei o método RemoveColaborador (porque não estava a funcionar), e alterei a forma como mostrar os colaboradores adicionados na lista de colaboradores, porque se não, também não funcionava.*
- *Em relação à classe do médico adicionei um método para mostrar os detalhes do médico. Também alterei os métodos de Login e SetPassword, apesar de que não consegui colocar o método SetPassword a funcionar, portanto comentei o código. No projeto de POO pergunto os dados no programa, e aqui, para fazer perguntas ao utilizador passei os console.readline para dentro do método na classe MedicoController. Também tive de colocar a password de private para public, porque estava a dar erros.*

