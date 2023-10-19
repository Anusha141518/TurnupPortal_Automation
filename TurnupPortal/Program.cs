using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TurnupPortal.Pages;

public class Program
{
    private static void Main(string[] args)
    {
        //Open chrome browser
        IWebDriver driver = new ChromeDriver();

        //LoginPage page object initialize and definition
        LoginPage loginPageObj = new LoginPage();
        loginPageObj.LoginAction(driver);

        //Home page object initialize and definition
        HomePage homePageObj = new HomePage();
        homePageObj.GoToTMPage(driver);

        //TMPage page object initialize and definition
        TMPage tmPageObj = new TMPage();
        tmPageObj.CreateTimeRecord(driver);
    }
}
        /*
        //Check if the user has logged in successfully
        //ExpectedResult = "Hello hari!";
        IWebElement ActualResult = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));

        if (ActualResult.Text == "Hello hari!")
        {
            Console.WriteLine("User has logged in successfully");

        }
        else

        {
            Console.WriteLine("User has not logged in successfully");
        }

        // Test case - create a new time record

        

      
        */


