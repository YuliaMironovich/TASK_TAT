using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using WordPressTask.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;

namespace WordPressTask
{
    /// <summary>
    /// Class contains tests for LogIn page.
    /// </summary>
    [TestFixture]
    public class LogInPageTests
    {
        private IWebDriver driver;

        [SetUp]
        public void SetupTest()
        {
            driver = new ChromeDriver();
        }

        [TearDown]
        public void TeardownTest()
        {
            driver.Quit();
        }

        static object[] UserData =
        {
            new object[] { "Administraror", "123456" },
            new object[] { "Editor", "12345" },
            new object[] { "Author", "12345" },
            new object[] { "Contributor", "1234567" },
            new object[] { "User1", "12345" },
        };
        
        [Test, TestCaseSource("UserData")]
        public void LogInPositive(string login, string password)
        {
            LogInPage logInPage = new LogInPage(driver);
            logInPage.Navigate();
            logInPage.LogIn(login, password);
            IWebElement wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementIsVisible(By.XPath(new SubscriberPage(driver).DisplayNameXpath)));
            Assert.AreEqual(login, driver.FindElement(By.XPath(new SubscriberPage(driver).DisplayNameXpath)).Text);
        }

        static object[] UserIncorrectData =
        {
            new object[] { "Administrar", "123456" },
            new object[] { "Editor", "123456" },
            new object[] { "", "12345" },
            new object[] { "Contributor", "" }
        };

        
        [Test, TestCaseSource("UserIncorrectData")]
        public void LogInNotCorrectDataNegative(string login, string password)
        {
            LogInPage logInPage = new LogInPage(driver);
            logInPage.Navigate();
            logInPage.LogIn(login, password);
            Assert.IsTrue(new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath(new SubscriberPage(driver).DisplayNameXpath))));
        }

        [Test]
        public void RememberUserNegative()
        {
            SubscriberPage subscriberPage = new SubscriberPage(driver);
            LogInPage logInPage = new LogInPage(driver);
            logInPage.Navigate();
            logInPage.RememberUser(); 
            logInPage.LogIn(subscriberPage.Login, subscriberPage.Password);
            IWebElement wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementIsVisible(By.XPath(new SubscriberPage(driver).DisplayNameXpath)));
            subscriberPage.LogOut();
            bool startpage = new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.UrlContains(logInPage.Url));
            logInPage.UserPassword.SendKeys(subscriberPage.Password);
            logInPage.LogInButton.Click();
            Assert.IsTrue(new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath(new SubscriberPage(driver).DisplayNameXpath))));
        }
    }
}
