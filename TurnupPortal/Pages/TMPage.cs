using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnupPortal.Pages
{
    public class TMPage
    {
        public void CreateTimeRecord(IWebDriver driver)
        {
            // Click on create new button
            IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            createNewButton.Click();

            // Select time from dropdown
            IWebElement typeCodeMainDropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span"));
            typeCodeMainDropdown.Click();


            IWebElement typeCodeDropdown = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
            typeCodeDropdown.Click();



            // Enter code
            IWebElement typeCodeTextBox = driver.FindElement(By.Id("Code"));
            typeCodeTextBox.SendKeys("September2023");


            // Enter description
            IWebElement descriptionTextBox = driver.FindElement(By.Id("Description"));
            descriptionTextBox.SendKeys("Desc September2023");

            // Enter the Price
            IWebElement priceTextBox = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            priceTextBox.SendKeys("100");

            // Click on the save button 
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();

            Thread.Sleep(5000);

            // Check if new Time record has created
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            goToLastPageButton.Click();

            IWebElement newCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

            if (newCode.Text == "Spetember2023")
            {

                Console.WriteLine("New time record has been created successfully");
            }
            else
            {

                Console.WriteLine("New time record hasn't been created ");

            }
            Console.ReadKey();
        }
        public void EditTimeRecord()
        { 
        }
        public void DeleteTimeRecord()
        {
        }
    }
}
