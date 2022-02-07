Feature: CadastroCliente

@cadastroDeCliente
Scenario: Cadastrar Cliente
	Given acesso a pagina inicial
	When clico no botao de cadastro de cliente
	And Preenche dados do cliente
	And clico no botao de cadastro
	Then valido cadastro de cliente