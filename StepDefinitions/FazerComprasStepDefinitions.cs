using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;

namespace DemoBlazeSpecFlow2.StepDefinitions
{
    [Binding]
    public class FazerComprasStepDefinitions
    {

        private LoginClienteStepDefinitions loginClientes;

        IWebDriver driver;
        public FazerComprasStepDefinitions() => driver =
               new ChromeDriver(@"C:\Users\dyeslen.duraes\source\repos\demoblase-specflow\DemoBlazeSpecFlow2\Drivers");



        [Given(@"Entro no site da demoblaze")]
        public void GivenEntroNoSiteDaDemoblaze()
        {
            driver.Navigate().GoToUrl("https://www.demoblaze.com/index.html");
        }

        [When(@"clico no botao de login para digitar do usuario")]
        public void WhenClicoNoBotaoDeLoginParaDigitarDoUsuario()
        {
            IWebElement botaoLogin = driver.FindElement(By.XPath("//a[@id='login2']"));
            botaoLogin.Click();
        }

        [When(@"preencho dados com login e senha")]
        public void WhenPreenchoDadosComLoginESenha()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            IWebElement txtLogin = driver.FindElement(By.XPath("//input[@id='loginusername']"));
            IWebElement txtSenha = driver.FindElement(By.XPath("//input[@id='loginpassword']"));

            txtLogin.SendKeys("dyeslen");
            txtSenha.SendKeys("dyeslen");
        }

        [When(@"clico no botao  login")]
        public void WhenClicoNoBotaoLogin()
        {
        
            IWebElement botaoLogin = driver.FindElement(By.XPath("//button[@onclick='logIn()']"));
            
            botaoLogin.Click();
        }

        [When(@"escolho o produto que desejo comprar")]
        public void WhenEscolhoOProdutoQueDesejoComprar()
        {
            Thread.Sleep(10000);

            IWebElement clickBotao = driver.FindElement(By.XPath("//a[text()='Nokia lumia 1520']"));
            clickBotao.Click();
        }

        [When(@"adiciono produto no carrinho")]
        public void WhenAdicionoProdutoNoCarrinho()
        {
            IWebElement adicionandoProduto = driver.FindElement(By.XPath("//a[@onclick='addToCart(2)']"));
            adicionandoProduto.Click(); 
        }

        [When(@"clico no botao <cart>")]
        public void WhenClicoNoBotaoCart()
        {
            IWebElement clicoNoBotaoCart = driver.FindElement(By.XPath("//a[@href='cart.html']"));
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            clicoNoBotaoCart.Click();
        }

        [When(@"clico no botao <place order>")]
        public void WhenClicoNoBotaoPlaceOrder()
        {
            IWebElement botaoPlaceOrder = driver.FindElement(By.XPath("//button[@class='btn btn-success']"));
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            botaoPlaceOrder.Click();
        
        }

        [When(@"preencho o formulario de compra")]
        public void WhenPreenchoOFormularioDeCompra()
        {
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            IWebElement txtName = driver.FindElement(By.XPath("//input[@id='name']"));
            txtName.SendKeys("Marcelo");


            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            IWebElement txtCoutry = driver.FindElement(By.XPath("//input[@id='country']"));
            txtCoutry.SendKeys("Brasil");

            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            IWebElement txtCity = driver.FindElement(By.XPath("//input[@id='city']"));
            txtCity.SendKeys("Terra Roxa - PR");

            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            IWebElement txtCreditCard = driver.FindElement(By.XPath("//input[@id='card']"));
            txtCreditCard.SendKeys("2392320");
           // driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            IWebElement txtMonth = driver.FindElement(By.XPath("//input[@id='month']"));
            txtMonth.SendKeys("01");
           // driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            IWebElement txtYear = driver.FindElement(By.XPath("//input[@id='year']"));
           txtYear.SendKeys("2022");

        }




        [When(@"clico no botao purchase")]
        public void WhenClicoNoBotaoPurchase()
        {

            IWebElement btPurchase = driver.FindElement(By.XPath("//button[@onclick='purchaseOrder()']"));
           // driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            btPurchase.Click();

        }

        [When(@"clico no botao ok")]
        public void WhenClicoNoBotaoOk()
        {
            IWebElement botaoOk = driver.FindElement(By.XPath("//button[@class='confirm btn btn-lg btn-primary']"));
         //   driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            botaoOk.Click();
        }

        [Then(@"redireciona para a pagina inicial")]
        public void ThenRedirecionaParaAPaginaInicial()
        {
            driver.Navigate().GoToUrl("https://www.demoblaze.com/index.html");
            driver.Quit();
        }
    }
}
