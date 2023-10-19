using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnupPortal.Pages;
using NUnit.Framework;
using TurnupPortal.Utilities;

namespace TurnupPortal.Tests
{
    public class TMtests : CommonDriver
    {
        [SetUp]
        public void SetUpTM()
        {
            //Open chrome browser
            driver = new ChromeDriver();

            //LoginPage page object initialize and definition
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginAction(driver);

            //Home page object initialize and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToTMPage(driver);
        }
        [Test, Order(1), Description("This test creates a new Time record with valid data")]
        public void TestCreateTimeRecord()
        {
            //TMPage page object initialize and definition
            TMPage tmPageObj = new TMPage();
            tmPageObj.CreateTimeRecord(driver);

        }
        [Test, Order(1), Description("This test update an existing Time record with valid data")]
        public void TestEditTimeRecord()
        {
            //TMPage page object initialize and definition
            TMPage tmPageObj = new TMPage();
            tmPageObj.EditTimeRecord(driver);

        }
        [Test, Order(1), Description("This test delete Time record")]
        public void TestDeleteTimeRecord()
        {
            //TMPage page object initialize and definition
            TMPage tmPageObj = new TMPage();
            tmPageObj.DeleteTimeRecord(driver);

        }
        [TearDown]
        public void CloseTestRun()
        {
            driver.Quit();
        }




















    }
}
