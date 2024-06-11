# Arquitetura da Solução

Pré-requisitos: [Projeto de Interface](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t9-pmv-ads-2024-1-e2-proj-tabela-nutri-t9/blob/main/docs/04-Projeto%20de%20Interface.md)

Definição de como o software é estruturado em termos dos componentes que fazem parte da solução e do ambiente de hospedagem da aplicação.

## Diagrama de Classes
![Diagrama de Classes](/docs/img/Diagrama%20de%20Classes.png)
<!-- O diagrama de classes ilustra graficamente como será a estrutura do software, e como cada uma das classes da sua estrutura estarão interligadas. Essas classes servem de modelo para materializar os objetos que executarão na memória.

As referências abaixo irão auxiliá-lo na geração do artefato “Diagrama de Classes”.

> - [Diagramas de Classes - Documentação da IBM](https://www.ibm.com/docs/pt-br/rational-soft-arch/9.6.1?topic=diagrams-class)
> - [O que é um diagrama de classe UML? | Lucidchart](https://www.lucidchart.com/pages/pt/o-que-e-diagrama-de-classe-uml)
-->
## Modelo ER (Projeto Conceitual)
![Modelo Conceitual](/docs/img/Modelo%20Conceitual.png)

<!-- O Modelo ER representa através de um diagrama como as entidades (coisas, objetos) se relacionam entre si na aplicação interativa.

Sugestão de ferramentas para geração deste artefato: LucidChart e Draw.io.

A referência abaixo irá auxiliá-lo na geração do artefato “Modelo ER”.
 
> - [Como fazer um diagrama entidade relacionamento | Lucidchart](https://www.lucidchart.com/pages/pt/como-fazer-um-diagrama-entidade-relacionamento)
-->
## Projeto da Base de Dados
![Modelo Físico](/docs/img/Modelo%20Físico.png)

O projeto da base de dados corresponde à representação das entidades e relacionamentos identificadas no Modelo ER, no formato de tabelas, com colunas e chaves primárias/estrangeiras necessárias para representar corretamente as restrições de integridade.
 
## Tecnologias Utilizadas

Para realização desse projeto usaremos as seguintes tecnologias:

- HTML
- CSS
- JavaScript
- C# - ASP.NET
- Framework Bootstrap
- Banco de Dados - MySQL

## Hospedagem

A hospedagem do projeto foi feita em uma máquina virtual no azure, com sistema operacional linux ubuntu e tamanho Standard B2s (2 vcpus, 4 GiB de memória). 
Nessa máquina configuramos a rede e o apache para acesso à página. Não configuramos o DNS, então ele está disponível pelo link [http://4.246.226.83/](http://4.246.226.83/)
