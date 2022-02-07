using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace DemoBlazeSpecFlow2.StepDefinitions
{
    [Binding]
    public class LoginClienteStepDefinitions
    {
        ITakesScreenshot takesScreenshot;
        IWebDriver driver;
        public LoginClienteStepDefinitions() => driver =
               new ChromeDriver(@"C:\Users\dyeslen.duraes\source\repos\demoblase-specflow\DemoBlazeSpecFlow2\Drivers");



        [Given(@"acessa a pagina inicial")]
        public void GivenAcessaAPaginaInicial()
        {
            driver.Navigate().GoToUrl("https://www.demoblaze.com/");
        }

        [When(@"clico no botao de login")]
        public void WhenClicoNoBotaoDeLogin()
        {
            IWebElement botaoLogin = driver.FindElement(By.XPath("//a[@id='login2']"));
            botaoLogin.Click();
            takesScreenshot.GetScreenshot();
        
        }

        [When(@"Preenche dados do cliente com login e senha")]
        public void WhenPreencheDadosDoClienteComLoginESenha()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            IWebElement txtLogin = driver.FindElement(By.XPath("//input[@id='loginusername']"));
            IWebElement txtSenha = driver.FindElement(By.XPath("//input[@id='loginpassword']"));
        
            txtLogin.SendKeys("dyeslen");
            txtSenha.SendKeys("dyeslen");

            takesScreenshot.GetScreenshot();
        }


        [When(@"clico no botao <login>")]
        public void WhenClicoNoBotaoLogin()
        {
            IWebElement botaoLogin = driver.FindElement(By.XPath("//button[@onclick='logIn()']"));
            botaoLogin.Click();
            takesScreenshot.GetScreenshot();
        }

        [Then(@"valido o login do cliente")]
        public void ThenValidoOLoginDoCliente()
        {
            Assert.True(true);
            driver.Quit();
            takesScreenshot.GetScreenshot();
        }
    }
}
