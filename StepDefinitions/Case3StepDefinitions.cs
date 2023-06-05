using Microsoft.Graph;
using Microsoft.Graph.Models;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;

namespace SpecFlowProject.StepDefinitions
{
    [Binding]
    public sealed class Case3StepDefinitions
    {
        private IWebDriver driver;

        [Given(@"I am on the site")]
        public void GivenIAmOnTheSite()
        {
            driver = new ChromeDriver();
            driver.Url = "https://amcomtesteqa.z15.web.core.windows.net/";
            Thread.Sleep(000);
        }




        [When(@"I get the current time")]
        public void WhenIGetTheCurrentTime()
        {
            DateTime horaAtual = DateTime.Now;
        }

        [When(@"I set the greeting based on the time of day")]
        public void WhenISetTheGreetingBasedOnTheTimeOfDay()
        {
            string saudacao;
        }

        [When(@"I click the greeting button")]
        public void WhenIClickTheGreetingButton()
        {
            IWebElement botao = driver.FindElement(By.XPath("//*[@value='Saudação']"));
                botao.Click();
            Thread.Sleep(1000);
        }

        [Then(@"I wait for the greeting message to be displayed")]
        public void ThenIWaitForTheGreetingMessageToBeDisplayed()
        {

            string saudacao;
            DateTime horaAtual = DateTime.Now;

            if (horaAtual.Hour < 12)
            {
                saudacao = "Bom dia";
            }
            else if (horaAtual.Hour < 18)
            {
                saudacao = "Boa tarde";
            }
            else
            {
                saudacao = "Boa noite";
            }

        }

        [Then(@"the displayed greeting message should be equal to the correct greeting")]
        public void ThenTheDisplayedGreetingMessageShouldBeEqualToTheCorrectGreeting()
        {


            DateTime horaAtual = DateTime.Now;

        }
    }
}




