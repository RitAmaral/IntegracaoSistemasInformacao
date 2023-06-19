# Work01 - Agenda

Projeto que evolui com a matéria da aula.

**Enunciado versão 01**:

Recebemos uma encomenda do Sr António Ocupado, um consultor que dedica apenas 15min do seu tempo para cada cliente. 

Este método de trabalho está a criar-lhe constrangimentos na gestão do agendamento de compromissos.

Para evitar colisões de agendamento pediu um sistema que permita registar este conjunto de dados ordenados por Data/Hora:
  - Data/Hora (ajustar para blocos de 15min);
  - Nº bloco (1-4); (numa hora temos 4 blocos de 15 minutos, por isso no bloco 1 vai uma pessoa, etc)
  - Prioridade (1-alta, 2-média, 3-baixa);
  - Nome do cliente;
  - Assunto;
  - Tipo de agendamento (Profissional, Pessoal);
  - Concluído (S/N)
  - Data/Hora da conclusão;

---

## Arquitetura N-Tier

A arquitetura de N camadas (ou multi-camadas) refere-se a software que tem as suas várias camadas processadas por ambientes informáticos distintos (camadas) sob uma lógica cliente-servidor.

A interface do utilizador (camada de apresentação) é executada num ambiente separado do "cálculo" (camada de lógica comercial) que, por sua vez, também é executado num ambiente distinto do motor e das instâncias da base de dados (camada de dados).

Estes ambientes distintos (níveis) envolvem normalmente diferentes servidores, redes de centros de dados e, muitas vezes, regiões geográficas.

Antes de prosseguir, é importante esclarecer a diferença entre "Nível" e "Camada". Uma camada é um componente lógico dentro de um conjunto de software que realiza uma determinada funcionalidade, enquanto que um nível é a plataforma lógica e de hardware onde essa camada é executada.

Na maioria das vezes, faz sentido dividir os níveis acima mencionados para obter ainda mais flexibilidade, refinamento, segurança e eficiência da arquitetura.
