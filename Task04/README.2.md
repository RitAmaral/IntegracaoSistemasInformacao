# Serialização

Serialização é o processo de conversão do estado de um objeto numa forma que pode ser persistido ou transportado.
Ou seja, converte uma estrutura de dados ou um objeto num formato que possa ser armazenado ou transferido.
O complemento da serialização é a desseserialização, que converte um fluxo em um objeto. 

XML é um padrão aberto e por isso é bom para a partilha de dados através da web.

A classe central na serialização XML é a **XmlSerializer** classe e os métodos mais importantes nesta classe são os métodos Serializar e Anular Serialização. 
O XmlSerializer cria ficheiros C# e compila-os em .dll ficheiros para efetuar esta serialização. 

 Classes XmlReader e XmlWriter são usadas para analisar e escrever um fluxo XML.

*[Mais informação sobre Serialização XML](https://learn.microsoft.com/pt-pt/dotnet/standard/serialization/introducing-xml-serialization)*

---

Em [anotações v2](Task04/Anotacoes_v02) foi criada uma biblioteca de classes e uma classe chamada XmlMethods, onde foram criados 4 métodos, 2 para serializar e 
2 para desserializar. Foram colocados `[Serializable]` em AnotacoesAula e em Tipo (um enum, por isso tem de ser sempre colocado, se não, dá erro). 
Em AnotacoesAula foi ainda criado um struct RegistoAnotacao porque não se pode serializar uma classe. Coloquei `[XmlElement]` nas propriedades/atributos 
do struct.
