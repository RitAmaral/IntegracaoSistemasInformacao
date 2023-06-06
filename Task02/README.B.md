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

**Padrão de Design Identificado:** Factory

Na Task 02.A identifiquei 4 classes, 1 superclasse (Jar) e 3 subclasses (Golf Balls, Pebbles, Sand). A superclasse Jar, que representa a vida, é uma classe **abstrata** pois possui características que vão ser herdadas pelas subclasses, como o nome, a data de nascimento, a nacionalidade e o género. As subclasses são usadas para adicionar outras características mais específicas da vida da pessoa. Por exemplo, na subclasse Golf Balls ficamos a saber mais detalhes sobre a vida de uma pessoa, se tem família, amigos, saúde e hobbies. Na subclasse Pebbles, ficamos a saber mais detalhes como o carro, o trabalho e se tem casa. Na última subclasse, Sand, ficamos a aprender sobre se a pessoa perde muito tempo a procrastinar ou em brigas/zangas.

Como não podemos instanciar objetos de superclasses, podemos fazê-lo a partir das suas subclasses, e adicionar também as tais características específicas (mencionadas em cima) das subclasses. Para isto acontecer devemos criar um processo de fabricação específico, usando o **padrão de desenho Factory**.

Depois de criadas as 4 classes (jar, golf balls, pebbles, sand) com as respetivas propriedades e métodos, foi criada a classe FabricaJar com um método (CriarJar), que é usado para preencher o Jar. Este método vai receber como parâmetro o elemento que vai ser utilizado num bloco switch, indicando o que vai ser colocado no Jar.

Por último, criei a classe JarException que herda de ApplicationException, e coloquei um construtor com um parâmetro message que recebe de ApplicationException. Depois coloquei no switch case um default para aparecer um erro. E chamei-o no programa usando o bloco try / catch.

*Nota: alterações feitas desde a task01: não criei a lista passions, coloquei apenas a propriedade passions. Alterei também o tipo DateTime para DateOnly nas propriedades do Jar.*

