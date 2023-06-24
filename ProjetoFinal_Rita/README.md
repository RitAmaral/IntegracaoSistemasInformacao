# Projeto Final

## Tema: Implementar um Sistema de Informação para gestão de concurso "tipo" festival da canção da eurovisão.

![image](https://github.com/RitAmaral/IntegracaoSistemasInformacao/assets/132366922/f1287a71-6e84-4375-a68b-eb19ddcab248)

**Padrão de arquitetura:** N-tier

*Camada de Apresentação:* biblioteca de classes Eurovisao_Console - responsável pela interação com o utilizador, é a camada que mostra informações.

*Business Logic:* biblioteca de classes Eurovisao_BL - é a camada da lógica e das regras de negócio, que define classes e métodos (que interagem com a camada Data Access Layer) para lidar com as operações e regras de negócio relacionadas com os objetos da Eurovisão.

*Data Access Layer:* biblioteca de classes Eurovisao_DAL - é a camada de dados que é responsável por aceder e manipular os dados. Contém métodos para executar operações nos objetos da classe Eurovisao (AdicionarConcorrente, ModificarPontos, ExisteConcorrente, ApagarConcorrente). 

Neste projeto também foram criadas as seguintes biblitoecas de classes:

- Eurovisao_Constantes - para ser possível a serialização
- ToolBox - para ser possível atribuir um id automático
- SerializeTools - para ser possível a serialização

Classe: Eurovisão

Propriedades: id (get new id), nome pais string, nome representante string, nome música string, pontos juri int, pontos público int, total pontos int, classificação final int.

Nas semi-finais não há votação juri.. colocar 0 pontos?

Criar lista1 semi-final 1, lista2 semi-final 2. Apagar da listas das semi-finais os paises eliminados. Criar lista da final? É possível ser feito isto? Se não, fazer só lista da final.
