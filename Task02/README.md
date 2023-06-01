# Task 02

## Objetivo:
Tendo como base as pistas fornecidas por imagem, som e a própria mensagem. Pretende-se uma lista de classes (podem pôr mais do que uma lista) com o seguinte detalhe individual para cada classe:
- uma breve descrição;
- hierarquia, dependência, ... ou outra carateristica considerada importante;

---

## Método para responder ao desafio:
- Na resposta da tarefa do TEAMS deverá ser fornecido o **URL** para uma pasta "Task02" (do repositório individual no github);
- Nessa pasta deverá existir um ficheiro "README.md" (documento escrito em notação Markdown) com todo o conteúdo necessário para responder ao desafio proposto.

---

## Resposta da Task 02

- **Classe Mãe / Superclasse: Jar = Life**
  - Propriedades:
      - `public string Name {get; set;}` <!-- (o meu nome) -->
      - `public int Age {get; set;}` // Nota: (a minha idade, ou colocar data de nascimento?)
      - `public string Nationality {get; set;}` <!-- (a minha nacionalidade) -->

Relação de generalização / herança. 

- **Subclasses (herdam da classe Jar / Life):**

  - *Golf Balls = { Family, Friends, Health, Passions }*
      - ##### Propriedades:
        - `public int Family {get; set;}` <!-- (quantos membros da família temos) -->
        - `public int Friends {get; set;}` <!-- (quantos amigos temos) -->
        - `public string Health {get; set;}` <!-- (a nossa saúde é boa ou não) -->
        - ~~`public string Passions {get; set;}`~~ // Nota: (talvez criar lista com quantas paixões/hobbies temos?)
        - `public List<Passion> Passions { get; set; } = new List<Passion>();` <!-- (Lista Passions) -->
     
      - ##### Métodos:
        - `public void AddPassion(Passion passion) { Passions.Add(passion); }` <!-- (adcionar à lista Passion) -->
        - `public void RemovePassion(Passion passion) { Passions.Remove(passion); }` <!-- (remover da lista Passion) -->
        - ~~`public override ToString() {return ...}`~~

  - *Pebbles = { Car, Job, Home }*
      - ##### Propriedades:
        - `public string Car {get; set;}` <!-- (marca do carro) -->
        - `public string Job {get; set;}` <!-- (trabalho) -->
        - `public int Home {get; set;}` <!-- (tem casa ou não -->

  - *Sand = { Everything else }*
      - ##### Propriedades:
        - `public string Procrastinate {get; set;}` <!-- (ou procrastinas ou não) -->

