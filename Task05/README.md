# Task 05

## Enunciado:

Utilizando todo o trabalho produzido na “Task04” (duplicando a pasta utilizando os conselhos fornecidos em contexto de aula) e mantendo a imagem do modelo visual, 
pretende-se que sejam acrescentadas as funcionalidades necessárias para exportar/importar os dados para um ficheiro XML, pode-se utilizar o código (SerializeTools) que foi partilhado em aulas anteriores. 
O objetivo é atualizar a solução duplicada com o código criado e separado por módulos reutilizáveis, deve-se acrescentar as funcionalidades que se considerem necessárias de acordo com a interpretação feita do enunciado. 
Deverá incluir todas as aprendizagens até ao momento. O “único” output da solução deverá ser feito a partir de um projeto do tipo “Console app” incluído na mesma. 

![image](https://github.com/RitAmaral/IntegracaoSistemasInformacao/assets/132366922/dce2d556-99f3-4354-b9cf-cabd737ba4e0)

---

### Resposta Task 05:

Primeiro comecei por adicionar mais bibliotecas de classes às já existentes que foram feitas na Task04. Como a **ToolBox** e a **SerializeTools**, onde na primeira foi criada a classe *GetNewId*, que permite atribuir um ID automático. Na segunda foi criada uma classe chamada *XmlMethods*, onde foram criados 4 métodos, 2 para serializar e 2 para desserializar. 
Esta biblioteca é essencial em todos os projetos em que seja necessário para serializar os dados.

Foi depois criada uma struct (porque não se pode serializar uma classe) - **RegistoAnotacao** - e inserido `[Serializable]` em *AnotacoesAula* e em *Tipo* (um enum, por isso tem de ser sempre colocado, se não, dá erro). Ainda em **AnotacoesAula** foram inseridos vários `[XmlElement]` nas propriedades/atributo do struct. Foi também criado um construtor e um método RegistoAnotacao().
Depois foram inseridos nas classes **AnotacoesAula_BR** e **AnotacoesAula_DAO** métodos para Exportar e Importar, que são usados para exportar os dados para o XML.

Dentro da classe **AnotacoesAula_DAO** foi também criado uma classe AnotacoesBD que vai representar a base de dados, por isso colocamos em cima `[XmlRoot(ElementName = "Anotacoes")]`. Dentro desta classe foi também criado o método AnotacoesBD(), que é composto por uma lista de anotações - RegistoAnotacao.
Também foi alterada a lista que foi criada na Task04 (`private List<AnotacoesAula> _anotacoesList;` para: `private AnotacoesBD _anotacoesList;`).

**Nota:** O output da solução está no Projeto chamado “Task04App”.
  
