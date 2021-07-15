using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task3_Vala_48207
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 1 : Check for incorrect sign-in

            IWebDriver driver = new ChromeDriver();     
            driver.Url = "https://the-internet.herokuapp.com/login";

            driver.Manage().Window.Maximize();


            driver.FindElement(By.Id("username")).SendKeys("Vala");
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.Id("password")).SendKeys("Vala123" + Keys.Enter);

            System.Threading.Thread.Sleep(2000);

            driver.Quit();

            System.Threading.Thread.Sleep(2000);

            // Task 2 : Check support for the correct login

            IWebDriver driver1 = new ChromeDriver(); 
            driver1.Url = "https://the-internet.herokuapp.com/login";

            System.Threading.Thread.Sleep(2000);

            driver1.Manage().Window.Maximize();

            driver1.FindElement(By.Id("username")).SendKeys("tomsmith");
            System.Threading.Thread.Sleep(2000);
            driver1.FindElement(By.Id("password")).SendKeys("SuperSecretPassword!" + Keys.Enter);

            System.Threading.Thread.Sleep(2000);

            driver1.FindElement(By.XPath("/html[1]/body[1]/div[2]/div[1]/div[1]/a[1]")).Click();

            System.Threading.Thread.Sleep(2000);

            driver1.Quit();

            System.Threading.Thread.Sleep(2000);

            // Task 3 : Change the status of checkboxes

            IWebDriver driver2 = new ChromeDriver();
            driver2.Url = "http://the-internet.herokuapp.com/checkboxes";

            System.Threading.Thread.Sleep(2000);

            driver2.Manage().Window.Maximize();

            System.Threading.Thread.Sleep(2000);

            driver2.FindElement(By.XPath("/html[1]/body[1]/div[2]/div[1]/div[1]/form[1]/input[2]")).Click();

            System.Threading.Thread.Sleep(2000);

            driver2.FindElement(By.XPath("/html[1]/body[1]/div[2]/div[1]/div[1]/form[1]/input[1]")).Click();

            System.Threading.Thread.Sleep(2000);

            driver2.Quit();



        }
    }
}
