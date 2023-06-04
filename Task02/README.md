# Task 02

## Objetivo:
Tendo como base as pistas fornecidas por imagem, som e a própria mensagem. Pretende-se uma lista de classes (podem pôr mais do que uma lista) com o seguinte detalhe individual para cada classe:
- uma breve descrição;
- hierarquia, dependência, ... ou outra carateristica considerada importante;

---

## Resposta da Task 02

Neste trabalho, identifiquei 4 classes. A superclasse Jar, e as subclasses Golf Balls, Pebbles e Sand. Estas classes estão relacionadas pela relação de **generalização / herança**. O Jar que representa a Life são a superclasse, enquanto que as Golf Balls, os Pebbles, a Sand são as subclasses que herdam as propriedades e métodos da superclasse Jar. 

- **Classe Mãe / Superclasse: Jar = Life**
  - Propriedades:
      - `public string Name {get; set;}` <!-- (o meu nome) -->
      - `public int Age {get; set;}` // Nota: (a minha idade, ou colocar data de nascimento?)
      - `public string Nationality {get; set;}` <!-- (a minha nacionalidade) -->
      - `public string Gender {get; set;}` <!-- (o meu género) -->

    O Jar representa a vida de uma pessoa, e por isso algumas das características ou propriedades que representam uma vida são: o nome, a idade, a nacionalidade e o género da pessoa.

- **Subclasses (herdam da classe Jar / Life):**

  - *Golf Balls = { Family, Friends, Health, Passions }*
      - ##### Propriedades:
        - `public int Family {get; set;}` <!-- (quantos membros da família temos) -->
        - `public int Friends {get; set;}` <!-- (quantos amigos temos) -->
        - `public string Health {get; set;}` <!-- (a nossa saúde é boa ou não) -->
        - ~~`public string Passions {get; set;}`~~  Nota: (talvez criar lista com quantas paixões/hobbies temos?)
        - `public List<Passion> Passions { get; set; } = new List<Passion>();` <!-- (Lista Passions) -->
      
      As Golf Balls no Jar representam algo que é muito importante na nossa vida: a nossa família, amigos, saúde e hobbies. Por isso coloquei como propriedades a família (quantos memmbros temos na nossa família), amigos (quantos amigos temos), saúde (se somos saudáveis, ou não), e por último uma lista de hobbies, porque uma pessoa pode ter vários hobbies (gosta de praticar desporto, gosta de cantar, entre muitos outros hobbies).
     
      - ##### Métodos:
        - `public void AddPassion(Passion passion) { Passions.Add(passion); }` <!-- (adcionar à lista Passion) -->
        - `public void RemovePassion(Passion passion) { Passions.Remove(passion); }` <!-- (remover da lista Passion) -->
        - ~~`public override ToString() {return ...}`~~
      
      Se identifiquei como propriedade uma lista de hobbies, então na secção dos métodos certamente temos de incluir os métodos para adicionar um hobbie, ou remover um hobbie.

  - *Pebbles = { Car, Job, Home }*
      - ##### Propriedades:
        - `public string Car {get; set;}` <!-- (marca do carro) -->
        - `public string Job {get; set;}` <!-- (trabalho) -->
        - `public int Home {get; set;}` <!-- (tem casa ou não) -->
     
     Os Pebbles representam outras coisas que são importantes na vida: como o carro (se tivermos, podemos colocar a marca), o nosso trabalho, e a nossa casa.

  - *Sand = { Everything else }*
      - ##### Propriedades:
        - `public string Procrastinate {get; set;}` <!-- (ou procrastinas ou não) -->
        - `public string Quarrels {get; set;}` <!-- ("zangas/brigas/intrigas" na nossa vida) -->
     
     Por último temos a Sand, que é algo que não é tão importante na nossa vida (algo a que não devemos ocupar tanto do nosso tempo), e que às vezes perdemos muito tempo a procrastinar ou a ter brigas sem importância.

