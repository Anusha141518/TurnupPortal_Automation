using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

//Open chrome browser
IWebDriver driver = new ChromeDriver();
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

//Check if the user has logged in successfully
 //ExpectedResult = "Hello hari!";
 IWebElement ActualResult = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));

if(ActualResult.Text == "Hello hari!")
{
    Console.WriteLine("User has logged in successfully");

}
else

{
    Console.WriteLine("User has not logged in successfully");
}

driver.Quit();