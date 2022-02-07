Feature: LoginCliente

@loginCliente
Scenario: Login Cliente
	Given acessa a pagina inicial
	When clico no botao de login 
	And Preenche dados do cliente com login e senha
	And clico no botao <login>
	Then valido o login do cliente
