using System.Collections.Generic;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace NUnitTestProject1
{
    public class Tests
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test1()
        {
            driver.Navigate().GoToUrl("https://www.google.com/");

            IWebElement search = driver.FindElement(By.Name("q"));
            search.SendKeys("GeForce 1650");
            search.SendKeys(OpenQA.Selenium.Keys.Enter);

            IList<IWebElement> elements = driver.FindElements(By.ClassName("g"));
            Assert.AreNotEqual(0, elements.Count);
        }

        [TearDown]
        public void EndTest()
        {
            driver.Close();
        }
    }
}