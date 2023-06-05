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
    public sealed class Case2StepDefinitions
    {
        private IWebDriver driver;

        [Given(@"That the user wants to select an existing color in the system")]
        public void GivenThatTheUserWantsToSelectAnExistingColorInTheSystem()
        {
            driver = new ChromeDriver();
            driver.Url = "https://amcomtesteqa.z15.web.core.windows.net/";
            Thread.Sleep(000);
            
        }

        [When(@"and selects the color YELLOW")]
        public void WhenAndSelectsTheColorYELLOW()
        {

            IWebElement selectElement = driver.FindElement(By.XPath("//select[@id ='colors']"));
            SelectElement select = new SelectElement(selectElement);
            select.SelectByText("Amarelo");
        }

        [Then(@"the box should change color")]
        public void ThenTheBoxShouldChangeColor()
        {
            IWebElement divFormulario = driver.FindElement(By.Id("card-color"));

            // Obtenha o valor da propriedade "background-color" da div
            string corFundo = divFormulario.GetCssValue("background-color");

            // Verifique se a cor de fundo é amarela
            if (corFundo == "rgb(255, 193, 7)") // Verificar a cor RGB correspondente ao amarelo
            {
                Console.WriteLine("A cor de fundo do formulário é amarela.");
            }
            
        }

        [When(@"and selects the green color")]
        public void WhenAndSelectsTheGreenColor()
        {
             
            {

                IWebElement selectElement = driver.FindElement(By.XPath("//select[@id ='colors']"));
                SelectElement select = new SelectElement(selectElement);
                IWebElement divFormulario = driver.FindElement(By.Id("card-color"));
                select.SelectByText("Verde");

                string corFundo = divFormulario.GetCssValue("background-color");

                if (corFundo == "rgb(0, 128, 0)") // Verificar a cor RGB correspondente ao verde
                {
                    Console.WriteLine("Não existe a cor verde.");
                }
            }
        }

    }
}




