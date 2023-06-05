# Task 02.B

## Material de trabalho:

Como material de trabalho deve ser implementada a estrutura de dados identificada na parte inicial da tarefa (Task02.A). (No caso de terem sido identificadas mais do que uma estrutura, deve-se escolher apenas uma.)

## Objetivo:

Implementar a estrutura de classes de uma forma organizada aplicando se possível um ou mais tipos de padrões de design apresentados esta manhã (Singleton, Abstract, Factory).

A execução do programa deve apresentar evidências da utilização das carateristicas que distinguem o padrão utilizado (ou padrões utilizados)

*NOTA: Podem utilizar como ponto de partida algumas ideias partilhadas nos [exemplos apresentados](https://github.com/pinjoa/ufcd5420_CESAE_SDEV03_BRA/tree/main/Task02/Conceitos).*

---

## Método para responder ao desafio:

Na resposta da tarefa no TEAMS deverá ser fornecido o URL para uma pasta "Task02" (do repositório individual no github), local onde deve ser criada a solução em C#;

Nessa pasta deverá existir um ficheiro "README.B.md" com a descrição das escolhas feitas para responder ao desafio proposto.

---

## Resposta da Task 02.B

Na Task 02.A identifiquei 4 classes, 1 superclasse (Jar) e 3 subclasses (Golf Balls, Pebbles, Sand). A superclasse Jar, que representa a vida, é uma classe **abstrata** pois possui características que vão ser herdadas pelas subclasses, como o nome, a data de nascimento, a nacionalidade e o género. As subclasses são usadas para adicionar outras características mais específicas da vida da pessoa. Por exemplo, na subclasse Golf Balls ficamos a saber mais detalhes sobre a vida de uma pessoa, se tem família, amigos, saúde e hobbies.

