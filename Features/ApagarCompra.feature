Feature: Apagar Compra

A short summary of the feature

@tag1
Scenario: Apagar Compra
	Given Entrar no site da demoblaze
	When Clico no botao de login
	And preencho o formulario de login
	And clica no botao de login
	And escolho um produto
	And adiciono um produto no carrinho
	And clico no botao cart
	And clico no botao delete

	Then valido cenario de apagar produto do carrinho
