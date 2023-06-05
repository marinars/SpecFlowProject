using Microsoft.Graph;
using Microsoft.Graph.Models;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;

namespace SpecFlowProject.StepDefinitions
{
    [Binding]
    public sealed class Case1StepDefinitions
    {
        private IWebDriver driver;

        [Given(@"that the user fills out the complete form")]
        public void GivenThatTheUserFillsOutTheCompleteForm()
        {
            driver = new ChromeDriver();
            driver.Url = "https://amcomtesteqa.z15.web.core.windows.net/";
            Thread.Sleep(000);
            driver.FindElement(By.XPath("//*[@name ='fname']")).SendKeys("Marina");
            driver.FindElement(By.XPath("//*[@name ='lname']")).SendKeys("Rosa");
            driver.FindElement(By.XPath("//*[@name ='phone']")).SendKeys("31930303030");
            Thread.Sleep(1000);

        }

        [When(@"they click Send")]
        public void WhenTheyClickSend()
        {
            driver.FindElement(By.XPath("//*[@value='Enviar']")).Click();
            Thread.Sleep(1000);
        }

        [Then(@"the modal displaying the success message appears")]
        public void ThenTheModalDisplayingTheSuccessMessageAppears()
        {
            
            // Localize o elemento usando XPath
            IWebElement elemento = driver.FindElement(By.XPath("//div[@id='myModal']//div[@class='modal-content']//p"));

            // Extrair o texto do elemento
            string texto = elemento.Text;

            Assert.AreEqual("Enviado com sucesso", texto);

        }

        [Then(@"The user can close the modal")]
        public void ThenTheUserCanCloseTheModal()
        {
            driver.FindElement(By.XPath("//*[@class='close']")).Click();
        }


    }
}




