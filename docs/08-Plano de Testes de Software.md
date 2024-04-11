# Plano de Testes de Software

<!-- <span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>

Apresente os cenários de testes utilizados na realização dos testes da sua aplicação. Escolha cenários de testes que demonstrem os requisitos sendo satisfeitos.

Não deixe de enumerar os casos de teste de forma sequencial e de garantir que o(s) requisito(s) associado(s) a cada um deles está(ão) correto(s) - de acordo com o que foi definido na seção "2 - Especificação do Projeto". 

Por exemplo:-->
 
| **Caso de Teste** 	| **CT-01 – Cadastrar perfil** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-009 - A aplicação deve apresentar, na página principal, a funcionalidade de cadastro de usuários para que esses consigam criar e gerenciar seu perfil. |
| Objetivo do Teste 	| Verificar se o usuário consegue se cadastrar na aplicação. |
| Passos 	| <br> - Acessar o navegador <br> - Informar o endereço do site do NutriGenius <br> - Clicar em "Criar conta" <br> - Preencher os campos obrigatórios (e-mail, nome, sobrenome, celular, CPF, senha, confirmação de senha) <br> - Aceitar os termos de uso <br> - Clicar em "Registrar" |
|Critério de Êxito | - O cadastro foi realizado com sucesso. |
|  	|  	|
| **Caso de Teste** 	| **CT-02 – Efetuar login**	|
|Requisito Associado | RF-010	- A aplicação deve possuir opção de fazer login, sendo o login o endereço de e-mail. |
| Objetivo do Teste 	| Verificar se o usuário consegue realizar login. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site NutriGenius <br> - Clicar no botão "Entrar" <br> - Preencher o campo de e-mail <br> - Preencher o campo da senha <br> - Clicar em "Login" |
|Critério de Êxito | - O login foi realizado com sucesso. |
|  	|  	|
| **Caso de Teste** 	| **CT-03 – Ser impedido de acessar as funcionalidades se não estiver cadastrado**	|
|Requisito Associado | RF-009 e RF-010	- tornar o cadastro e login para acessar outras funcionalidades |
| Objetivo do Teste 	| Verificar se o usuário consegue acessar outras funcionalidades se não estiver cadastrado/logado. |
| Passos 	| - Acessar o navegador <br> - Informar os endereços do site relacionados a outras funcionalidades <br> - visualizar tela informando que não está autorizado a visualizar a página<br> |
|Critério de Êxito | - Não foi possível visualizar as outras páginas. |
|  	|  	|
| **Caso de Teste** 	| **CT-04 - Pesquisar os ingredientes**	|
|Requisito Associado | RF-001	- A aplicação deve permitir a pesquisa e seleção de ingredientes |
| Objetivo do Teste 	| Verificar se o usuário consegue pesquisar o ingredientes dentro da aplicação. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço da página de cadastrar receita <br> - digitar na barra de pesquisa "farinha" ou outro ingrediente escolhido e visualizar os resultados <br> - Selecionar o ingrediente e fechar as opções, mostrando o ingrediente selecionado na tela de cadastro de tabela.  |
|Critério de Êxito | - Pesquisar e selecionar o ingrediente escolhido. |
|  	|  	|
| **Caso de Teste** 	| **CT-05 - Editar a quantidade dos ingredientes selecionados**	|
|Requisito Associado | RF-004 - A aplicação deve permitir a escolha da quantidade de ingredientes para escrever na tabela nutricional |
| Objetivo do Teste 	| Verificar se o usuário consegue escolher a quantidade dos ingredientes selecionados. |
| Passos 	| - Concluir o caso de teste CT-04 <br> - Visualizar a quantidade de ingrediente selecionado (1) <br> - Clicar no número e digitar a quantidade desejada <br> - Visualizar a nova quantidade na tela <br> |
|Critério de Êxito | - Visualizar a tabela com a quantidade desejada. |
|  	|  	|
| **Caso de Teste** 	| **CT-06 - Salvar a tabela**	|
|Requisito Associado | RF-005 - A aplicação deve salvar a tabela no perfil do usuário que a construiu |
| Objetivo do Teste 	| Salvar a tabela que foi construida. |
| Passos 	| - Concluir o caso de teste CT-04 e CT-05 <br> - Selecionar a opção de salvar <br> - Visualizar a tabela salva no perfil. |
|Critério de Êxito | - A mensagem de êxito e a tabela no perfil. |
|  	|  	|
| **Caso de Teste** 	| **CT-07 - Consultar os itens cadastrados no perfil do usuário**	|
|Requisito Associado | RF-006 - A aplicação deve permitir a consulta das tabelas salvas pelo usuário no perfil |
| Objetivo do Teste 	| Visualizar todas as tabelas já construidas no perfil do usuário. |
| Passos 	| - Concluir o caso de teste CT-04 e CT-05 e CT-06 <br> - Construir mais uma tabela para verificar se é possível visualizar as duas <br> - Clicar na opção visualizar itens cadastrados no menu de perfil do usuário <br> - Verificar se as tabelas construidas estão sendo listadas |
|Critério de Êxito | - Tabelas consultadas com sucesso na tela de visualizar tabelas. |
|  	|  	|
| **Caso de Teste** 	| **CT-09 - Fazer o download da tabela**	|
|Requisito Associado | RF-007 -	A aplicação deve permitir baixar em PDF a tabela que o usuário construiu |
| Objetivo do Teste 	| Fazer o download da tabela. |
| Passos 	| - Concluir o case de teste CT-06 <br> - Clicar no botão de download na página de visualizar tabela <br> - Verificar nos arquivos do dispositivo se foi concluído com sucesso |
|Critério de Êxito | - Arquivo da tabela aberto com sucesso no dispositivo. |
|  	|  	|
| **Caso de Teste** 	| **CT-10 - Baixar em PDF o relatório com as tabelas já criadas pelo usuário**	|
|Requisito Associado | RF-008 -	A aplicação deve permitir baixar em PDF o relatório com as tabelas já criadas pelo usuário |
| Objetivo do Teste 	| Fazer o download do relatório de dados dos itens já cadastrados pelo usuário. |
| Passos 	| - Concluir o case de teste CT-06 <br> - Entrar na página de visualizar itens já cadastrados pelo usuário <br> - Clicar no botão de baixar relatório <br> - Verificar nos arquivos do dispositivo se foi concluído com sucesso |
|Critério de Êxito | - Arquivo do relatório com todos os PDFs aberto com sucesso no dispositivo. |
|  	|  	|
| **Caso de Teste** 	| **CT-11 - Trocar a senha do usuário**	|
|Requisito Associado | RF-011 -	A aplicação deve permitir a troca de senha do usuário |
| Objetivo do Teste 	| Trocar a senha do usuário. |
| Passos 	| - Concluir o case de teste CT-01 <br> - Sair da conta do usuário e entrar na tela inicial com as opções de login ou trocar a senha <br> - Clicar no botão de trocar a senha <br> - Preencher e-mail para receber código <br> - Abrir e-mail com o link que leva a página de troca de senha e preencher a nova senha <br> - Clicar em concluir <br> - Fazer o login na conta com o e-mail e a nova senha |
|Critério de Êxito | - Login efetuado com sucesso após a troca de senha. |
|  	|  	|
| **Caso de Teste** 	| **CT-12 - Excluir a conta do usuário**	|
|Requisito Associado | RF-012 -	A aplicação deve permitir a exclusão de conta do usuário |
| Objetivo do Teste 	| Excluir a conta do usuário. |
| Passos 	| - Concluir o case de teste CT-01 <br> - Entrar em configurações e clicar em excluir conta <br> - Clicar em confirmar a exclusão <br> - Ser levado de volta para a tela de login <br> - Fazer a tentativa de login na conta com o e-mail e a senha e receber mensagem de conta não existente |
|Critério de Êxito | - receber mensagem de erro na tentativa de login. |

 
<!-- >> **Links Úteis**:
> - [IBM - Criação e Geração de Planos de Teste](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Práticas e Técnicas de Testes Ágeis](http://assiste.serpro.gov.br/serproagil/Apresenta/slides.pdf)
> -  [Teste de Software: Conceitos e tipos de testes](https://blog.onedaytesting.com.br/teste-de-software/)
> - [Criação e Geração de Planos de Teste de Software](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Ferramentas de Test para Java Script](https://geekflare.com/javascript-unit-testing/)
> - [UX Tools](https://uxdesign.cc/ux-user-research-and-user-testing-tools-2d339d379dc7) -->
