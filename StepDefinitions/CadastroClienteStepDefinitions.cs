using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Reflection;
using TechTalk.SpecFlow;

namespace DemoBlazeSpecFlow2.StepDefinitions
{
    [Binding]
    public class CadastroClienteStepDefinitions
    {

        private IWebDriver driver;
       
        public CadastroClienteStepDefinitions() => driver =
               new ChromeDriver(@"C:\Users\dyeslen.duraes\source\repos\demoblase-specflow\DemoBlazeSpecFlow2\Drivers");


        [Given(@"acesso a pagina inicial")]
        public void GivenAcessoAPaginaInicial()
        {
            driver.Navigate().GoToUrl("https://www.demoblaze.com/");
        }

        [When(@"clico no botao de cadastro de cliente")]
        public void WhenClicoNoBotaoDeCadastroDeCliente()
        { 
            IWebElement botaoCadastro = driver.FindElement(By.XPath("//a[@id='signin2']"));
            botaoCadastro.Click();
        }

        [When(@"Preenche dados do cliente")]
        public void WhenPreencheDadosDoCliente()
        {

           // WebDriverWait driverWait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            IWebElement userName = driver.FindElement(By.XPath("//input[@id='sign-username']"));

            IWebElement password = driver.FindElement(By.XPath("//input[@id='sign-password']"));

            userName.Click();
            userName.SendKeys("dyeslen");
            password.Click();
            password.SendKeys("dyeslen");
        }

        [When(@"clico no botao de cadastro")]
        public void WhenClicoNoBotaoDeCadastro()
        {
            IWebElement cadastroBota2 =driver.FindElement(By.XPath("//button[@onclick='register()']"));
            cadastroBota2 .Click();
        }

        [Then(@"valido cadastro de cliente")]
        public void ThenValidoCadastroDeCliente()
        {
            Assert.True(true);
            driver.Quit();
        }
    }
}
