using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace DemoBlazeSpecFlow2.StepDefinitions
{
    [Binding]
    public class ApagarCompraStepDefinitions
    {

        ITakesScreenshot takesScreenshot;

        IWebDriver driver;
        public ApagarCompraStepDefinitions() => driver =
               new ChromeDriver(@"C:\Users\dyeslen.duraes\source\repos\demoblase-specflow\DemoBlazeSpecFlow2\Drivers");


        [Given(@"Entrar no site da demoblaze")]
        public void GivenEntrarNoSiteDaDemoblaze()
        {
            driver.Navigate().GoToUrl("https://www.demoblaze.com/index.html");
        }

        [When(@"Clico no botao de login")]
        public void WhenClicoNoBotaoDeLogin()
        {
            IWebElement botaoLogin = driver.FindElement(By.XPath("//a[@id='login2']"));
            botaoLogin.Click();
        }

        [When(@"preencho o formulario de login")]
        public void WhenPreenchoOFormularioDeLogin()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            IWebElement txtLogin = driver.FindElement(By.XPath("//input[@id='loginusername']"));
            IWebElement txtSenha = driver.FindElement(By.XPath("//input[@id='loginpassword']"));

            txtLogin.SendKeys("dyeslen");
            txtSenha.SendKeys("dyeslen");
        }

        [When(@"clica no botao de login")]
        public void WhenClicaNoBotaoDeLogin()
        {
            IWebElement botaoLogin = driver.FindElement(By.XPath("//button[@onclick='logIn()']"));
            botaoLogin.Click();
        }

        [When(@"escolho um produto")]
        public void WhenEscolhoUmProduto()
        {
            Thread.Sleep(10000);

            IWebElement clickBotao = driver.FindElement(By.XPath("//a[text()='Nexus 6']"));
            clickBotao.Click();
        }

        [When(@"adiciono um produto no carrinho")]
        public void WhenAdicionoUmProdutoNoCarrinho()
        {
            IWebElement adicionandoProduto = driver.FindElement(By.XPath("//a[@onclick='addToCart(3)']"));
            adicionandoProduto.Click();
        }

        [When(@"clico no botao cart")]
        public void WhenClicoNoBotaoCart()
        {
            IWebElement clicoNoBotaoCart = driver.FindElement(By.XPath("//a[@href='cart.html']"));
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            clicoNoBotaoCart.Click();
        }

        [When(@"clico no botao delete")]
        public void WhenClicoNoBotaoDelete()
        {
            IWebElement botaoDelete = driver.FindElement(By.XPath("//a[text()='Delete']"));
        }

        [Then(@"valido cenario de apagar produto do carrinho")]
        public void ThenValidoCenarioDeApagarProdutoDoCarrinho()
        {
            driver.Navigate().GoToUrl("https://www.demoblaze.com/index.html");
        }
    }
}
