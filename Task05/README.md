# Task 05

## Enunciado:

Utilizando todo o trabalho produzido na “Task04” (duplicando a pasta utilizando os conselhos fornecidos em contexto de aula) e mantendo a imagem do modelo visual, 
pretende-se que sejam acrescentadas as funcionalidades necessárias para exportar/importar os dados para um ficheiro XML, pode-se utilizar o código (SerializeTools) que foi partilhado em aulas anteriores. 
O objetivo é atualizar a solução duplicada com o código criado e separado por módulos reutilizáveis, deve-se acrescentar as funcionalidades que se considerem necessárias de acordo com a interpretação feita do enunciado. 
Deverá incluir todas as aprendizagens até ao momento. O “único” output da solução deverá ser feito a partir de um projeto do tipo “Console app” incluído na mesma. 

![image](https://github.com/RitAmaral/IntegracaoSistemasInformacao/assets/132366922/dce2d556-99f3-4354-b9cf-cabd737ba4e0)

---

### Resposta Task 05:

Em [anotações v2](Task05/Anotacoes_v02) foi criada uma biblioteca de classes e uma classe chamada XmlMethods, onde foram criados 4 métodos, 2 para serializar e 
2 para desserializar. Foram colocados `[Serializable]` em AnotacoesAula e em Tipo (um enum, por isso tem de ser sempre colocado, se não, dá erro). 
Em AnotacoesAula foi ainda criado um struct RegistoAnotacao porque não se pode serializar uma classe. Coloquei `[XmlElement]` nas propriedades/atributos 
do struct.
