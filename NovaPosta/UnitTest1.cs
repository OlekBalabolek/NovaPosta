using System;

using NUnit.Framework;

using OpenQA.Selenium;

using OpenQA.Selenium.Chrome;

using OpenQA.Selenium.Support.UI;

using SeleniumExtras.WaitHelpers;


namespace NovaPosta
{
    public class Tests
    {
        IWebDriver driver;
        string ttnNumber = "20450866143311";
        IWebElement inputTtnField;
    


        [SetUp]
       
        public void Initialize()

            {
            driver = new ChromeDriver();

            }


        [Test]
        public void Test()
        {
            driver.Url = "https://novaposhta.ua/";


            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            inputTtnField = wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"cargo_number\"]")));

            inputTtnField.SendKeys(ttnNumber);

            IWebElement inputSend = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"top_block\"]/div[1]/div/div[2]/form/input[2]")));
            inputSend.Click();
        }



        [TearDown]
        
        
        public void FinishTest()
        {
            driver.Quit();
        }
    }
}