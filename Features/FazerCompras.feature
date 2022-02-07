Feature: FazerCompras

A short summary of the feature

@tag1
Scenario: Fazer Compras
	Given Entro no site da demoblaze
	When clico no botao de login para digitar do usuario
	And preencho dados com login e senha
	And clico no botao  login
	And escolho o produto que desejo comprar
	And adiciono produto no carrinho
	And clico no botao <cart>
	And clico no botao <place order>
	And preencho o formulario de compra
	And clico no botao purchase
	And clico no botao ok
	Then redireciona para a pagina inicial
