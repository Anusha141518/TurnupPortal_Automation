using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnupPortal.Pages
{
    public class LoginPage
    {
        public void LoginAction(IWebDriver driver) 
        {
            driver.Manage().Window.Maximize();

            //Launch turnup portal and navigate to website login page
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login");

            //Identify username textbox and enter valid username
            IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
            usernameTextbox.SendKeys("hari");

            //Identify password textbox and enter valid password
            IWebElement usernamePassword = driver.FindElement(By.Id("Password"));
            usernamePassword.SendKeys("123123");

            //Identify login button and click on the button
            IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
            loginButton.Click();

        }
    }
}
