using System;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace Calculator.Selenium.Tests
{
    [TestFixture]
    public class SeleniumTests
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;

        [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            baseURL = "http://localhost:52698/";
            verificationErrors = new StringBuilder();
        }

        [Test]
        public void TestAll()
        {
            driver.Navigate().GoToUrl("http://localhost:52698/");
            driver.FindElement(By.XPath("(//input[@name='param'])[8]")).Click();
            driver.FindElement(By.XPath("(//input[@name='param'])[9]")).Click();
            driver.FindElement(By.XPath("(//input[@name='param'])[10]")).Click();
            driver.FindElement(By.XPath("(//input[@name='param'])[5]")).Click();
            driver.FindElement(By.XPath("(//input[@name='param'])[6]")).Click();
            driver.FindElement(By.XPath("(//input[@name='param'])[7]")).Click();
            driver.FindElement(By.XPath("(//input[@name='param'])[2]")).Click();
            driver.FindElement(By.XPath("(//input[@name='param'])[3]")).Click();
            driver.FindElement(By.XPath("(//input[@name='param'])[4]")).Click();
            driver.FindElement(By.XPath("(//input[@name='operation'])[5]")).Click();
            driver.FindElement(By.XPath("(//input[@name='param'])[4]")).Click();
            driver.FindElement(By.XPath("(//input[@name='param'])[3]")).Click();
            driver.FindElement(By.XPath("(//input[@name='param'])[2]")).Click();
            driver.FindElement(By.XPath("(//input[@name='param'])[7]")).Click();
            driver.FindElement(By.XPath("(//input[@name='param'])[6]")).Click();
            driver.FindElement(By.XPath("(//input[@name='param'])[5]")).Click();
            driver.FindElement(By.XPath("(//input[@name='param'])[10]")).Click();
            driver.FindElement(By.XPath("(//input[@name='param'])[9]")).Click();
            driver.FindElement(By.XPath("(//input[@name='param'])[8]")).Click();
            driver.FindElement(By.Id("equal")).Click();
            driver.FindElement(By.Id("clear")).Click();
            driver.FindElement(By.XPath("(//input[@name='param'])[8]")).Click();
            driver.FindElement(By.XPath("(//input[@name='param'])[6]")).Click();
            driver.FindElement(By.XPath("(//input[@name='operation'])[7]")).Click();
            driver.FindElement(By.XPath("(//input[@name='param'])[9]")).Click();
            driver.FindElement(By.XPath("(//input[@name='param'])[11]")).Click();
            driver.FindElement(By.Id("equal")).Click();
            driver.FindElement(By.Id("clear")).Click();
            driver.FindElement(By.XPath("(//input[@name='param'])[9]")).Click();
            driver.FindElement(By.XPath("(//input[@name='param'])[11]")).Click();
            driver.FindElement(By.XPath("(//input[@name='operation'])[5]")).Click();
            driver.FindElement(By.XPath("(//input[@name='param'])[9]")).Click();
            driver.FindElement(By.XPath("(//input[@name='param'])[10]")).Click();
            driver.FindElement(By.Id("equal")).Click();
            driver.FindElement(By.Id("clear")).Click();
            driver.FindElement(By.XPath("(//input[@name='param'])[7]")).Click();
            driver.FindElement(By.XPath("(//input[@name='operation'])[3]")).Click();
            driver.FindElement(By.XPath("(//input[@name='param'])[7]")).Click();
            driver.FindElement(By.Id("equal")).Click();
            driver.FindElement(By.XPath("(//input[@name='param'])[4]")).Click();
            driver.FindElement(By.Name("operation")).Click();
            driver.FindElement(By.XPath("(//input[@name='param'])[9]")).Click();
            driver.FindElement(By.Id("equal")).Click();
            driver.FindElement(By.Id("clear")).Click();
            driver.FindElement(By.XPath("(//input[@name='param'])[3]")).Click();
            driver.FindElement(By.XPath("(//input[@name='param'])[6]")).Click();
            driver.FindElement(By.XPath("(//input[@name='param'])[9]")).Click();
            driver.FindElement(By.XPath("(//input[@name='operation'])[2]")).Click();
            driver.FindElement(By.Id("clear")).Click();
        }

        [Test]
        public void Multiply()
        {
            driver.Navigate().GoToUrl("http://localhost:52698/");
            driver.FindElement(By.XPath("(//input[@name='param'])[3]")).Click();
            driver.FindElement(By.XPath("(//input[@name='operation'])[3]")).Click();
            driver.FindElement(By.XPath("(//input[@name='param'])[3]")).Click();
            driver.FindElement(By.Id("equal")).Click();
        }

        [Test]
        public void Add()
        {
            driver.Navigate().GoToUrl("http://localhost:52698/");
            driver.FindElement(By.XPath("(//input[@name='param'])[6]")).Click();
            driver.FindElement(By.XPath("(//input[@name='operation'])[7]")).Click();
            driver.FindElement(By.XPath("(//input[@name='param'])[6]")).Click();
            driver.FindElement(By.Id("equal")).Click();
        }
        [Test]
        public void Divide()
        {
            driver.Navigate().GoToUrl("http://localhost:52698/");
            driver.FindElement(By.XPath("(//input[@name='param'])[3]")).Click();
            driver.FindElement(By.XPath("(//input[@name='param'])[3]")).Click();
            driver.FindElement(By.Name("operation")).Click();
            driver.FindElement(By.XPath("(//input[@name='param'])[8]")).Click();
            driver.FindElement(By.XPath("(//input[@name='param'])[8]")).Click();
            driver.FindElement(By.Id("equal")).Click();
        }

        [Test]
        public void Subtract()
        {
            driver.Navigate().GoToUrl("http://localhost:52698/");
            driver.FindElement(By.XPath("(//input[@name='param'])[8]")).Click();
            driver.FindElement(By.XPath("(//input[@name='param'])[9]")).Click();
            driver.FindElement(By.XPath("(//input[@name='param'])[11]")).Click();
            driver.FindElement(By.XPath("(//input[@name='operation'])[5]")).Click();
            driver.FindElement(By.XPath("(//input[@name='param'])[4]")).Click();
            driver.FindElement(By.XPath("(//input[@name='param'])[7]")).Click();
            driver.FindElement(By.Id("equal")).Click();
        }

        [Test]
        public void Sqrt()
        {
            driver.Navigate().GoToUrl("http://localhost:52698/");
            driver.FindElement(By.XPath("(//input[@name='param'])[3]")).Click();
            driver.FindElement(By.XPath("(//input[@name='param'])[3]")).Click();
            driver.FindElement(By.XPath("(//input[@name='operation'])[2]")).Click();
            driver.FindElement(By.XPath("(//input[@name='operation'])[4]")).Click();
            driver.FindElement(By.XPath("(//input[@name='param'])[6]")).Click();
            driver.FindElement(By.XPath("(//input[@name='param'])[11]")).Click();
            driver.FindElement(By.Id("equal")).Click();
        }
    }
}
