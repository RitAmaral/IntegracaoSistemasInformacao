# Task 04

## Material de Trabalho

Utilizando a imagem como modelo visual, pretende-se criar uma aplicação para produzir um relatório. Cada registo da grelha corresponde à estrutura de dados a criar. 

![image](https://github.com/RitAmaral/IntegracaoSistemasInformacao/assets/132366922/58b07a71-dd22-49b8-8c3a-d55a738e1e2b)


O objetivo é criar uma solução com o código criado e separado por módulos reutilizáveis. Pode-se utilizar exemplos produzidos e abordados em contexto de aula esta semana (dias 13 e 14), 
deverá incluir todas as aprendizagens até ao momento. O “único” output da solução deverá ser feito a partir de um projeto do tipo “Console app” incluído na mesma. 

### Método para responder ao desafio: 

- Na resposta da tarefa no TEAMS deverá ser fornecido o URL para uma pasta "Task04" (do repositório individual no github), local onde deve ser criada a solução em C#; 

- Deverá ser fornecido a parte do código escolhida para se analisar as opções e comparar as funcionalidades originais com o resultado apresentado; 

- Nessa pasta também deverá existir um ficheiro "README.md" com a descrição das escolhas feitas para responder ao desafio proposto.

---

### Resposta: 

Nesta task, tive como base o exercício feito na aula de dia 14/06/2023 - [Agenda 01](https://github.com/pinjoa/ufcd5420_CESAE_SDEV03_BRA/tree/main/Work01/Agenda_v01).

Comecei por criar os diferentes projetos / bibliotecas de classes: 
- BO = business object
- BL = business logic
- DAL = data access layer

Depois dentro de cada projeto fui criando diferentes classes (BR = business rule, DAO = data access object) e até um Enum (Tipo).

Na biblioteca de classes *Anotacao_BO*, onde definimos as estruturas de dados, criei a classe *AnotacoesAula*. Aqui coloquei as propriedades, um construtor, e um método (override ToString) onde colocamos a forma como queremos que apareça o resultado na consola. Nesta altura também criei a pasta *Anotacoes_Constantes* onde criei o Enum Tipo, porque depois vai ser usado como uma propriedade na classe *AnotacoesAula*.

Depois criei biblioteca de classes *Anotacao_DAL*, que é a camada de acesso ao dados, e criei a classe *AnotacoesAula_DAO* onde criei uma lista e os respetivos métodos associados (adicionar, apagar, mostrar)

Na biblioteca de classes *Anotacao_BL* criei a classe *AnotacoesAula_BR* onde coloquei as regras, por exemplo as propriedades nome e aula não podem ser nulos.

Depois no programa adicionei anotações à lista e coloquei o método para mostrar a lista.
