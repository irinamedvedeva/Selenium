using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium
{
    class Program
    {
        static void Main()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("http://www.vk.com");
            driver.Manage().Window.Maximize();

            IWebElement emailTextField = driver.FindElement(By.Id("index_email"));
            emailTextField.Clear();
            emailTextField.SendKeys("380958368820"); 



            driver.Close();
            driver.Quit();


        }
    }
}
