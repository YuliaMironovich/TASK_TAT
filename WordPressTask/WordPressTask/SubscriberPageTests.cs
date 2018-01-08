using System;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using WordPressTask.PageObjects;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework.Internal;

namespace WordPressTask
{
    /// <summary>
    /// Class contains tests for Subscriber page.
    /// </summary>
    [TestFixture]
    public class SubscriberPageTests
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

        static object[] ColorSchemes =
       {
            new object[] { "//input[@value = 'ectoplasm']", "//input[@id = 'admin_color_ectoplasm']" },
            new object[] { "//input[@value = 'fresh']", "//input[@id = 'admin_color_fresh']" },
            new object[] { "//input[@value = 'light']", "//input[@id = 'admin_color_light']" },
            new object[] { "//input[@value = 'coffee']", "//input[@id = 'admin_color_coffee']" },
            new object[] { "//input[@value = 'blue']", "//input[@id = 'admin_color_blue']" },
            new object[] { "//input[@value = 'midnight']", "//input[@id = 'admin_color_midnight']" },
            new object[] { "//input[@value = 'ocean']", "//input[@id = 'admin_color_ocean']" },
            new object[] { "//input[@value = 'sunrise']", "//input[@id = 'admin_color_sunrise']" }
        };

        [Test, TestCaseSource("ColorSchemes")]
        public void ChangeColorSchemeProfilePositive(string schemeValue, string selectedScheme)
        {
            SubscriberPage subscriberPage = new SubscriberPage(driver);
            subscriberPage.Navigate();
            subscriberPage.Profile.Click();
            Actions action = new Actions(driver);
            action.MoveToElement(driver.FindElement(By.XPath(schemeValue))).Click().Perform();
            subscriberPage.UpdateProfile();
            subscriberPage.Profile.Click();
            Assert.IsTrue(new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementToBeSelected(By.XPath(selectedScheme))));
        }

        static object[] TextField =
        {
            new object[] { "//input[@id = 'first_name']", "Ivan", "//input[@value = 'Ivan']" },
            new object[] { "//input[@id = 'last_name']", "Ivanov", "//input[@value = 'Ivanov']" },
            new object[] { "//input[@id = 'nickname']", "Subscriber", "//input[@value = 'Subscriber']" },
            new object[] { "//input[@id = 'email']", "user1@mail.ru", "//input[@value = 'user1@mail.ru]"},
            new object[] { "//input[@id = 'url']", "http://ivanovy.ru", "//input[@value = 'http://ivanovy.ru']" },
            new object[] { "//input[@id = 'aim']", "ivanovAIM", "//input[@value = 'ivanovAIM']" },
            new object[] { "//input[@id = 'yim']", "ivanovYIM", "//input[@value = 'ivanovYIM']"},
            new object[] { "//input[@id = 'jabber']", "ivanovJABBER",  "//input[@value = 'ivanovJABBER']" }
        };

        [Test, TestCaseSource("TextField")]
        public void FillTheTextBoxPositive(string textBox, string text, string textBoxValueAttribute)
        {
            SubscriberPage subscriberPage = new SubscriberPage(driver);
            subscriberPage.Navigate();
            subscriberPage.Profile.Click();
            IWebElement element = driver.FindElement(By.XPath(textBox));
            element.Clear();
            element.SendKeys(text);  
            subscriberPage.UpdateProfile();
            subscriberPage.Profile.Click();
            Assert.AreEqual(text, driver.FindElement(By.XPath(textBoxValueAttribute)).GetAttribute("value"));
        }

        static object[] RequiredTextField =
        {
            new object[] { "//input[@value = 'user1@mail.ru']", "user1@mail.ru" },
            new object[] { "//input[@value = 'Subscriber']", "Subscriber" }
        };

        [Test, TestCaseSource("RequiredTextField")]
        public void EmptyRequiredTextBoxNegative(string textBox, string resultTextOfTextBox)
        {
            SubscriberPage subscriberPage = new SubscriberPage(driver);
            subscriberPage.Navigate();
            subscriberPage.Profile.Click();
            IWebElement element = driver.FindElement(By.XPath(textBox));
            element.Clear();
            subscriberPage.UpdateProfile();
            element = driver.FindElement(By.XPath(textBox));
            Assert.AreEqual(resultTextOfTextBox, element.GetAttribute("value"));
        }

        static object[] NamePublicity =
        {
            new object[] { "Ivan" },
            new object[] { "Ivanov" },
            new object[] { "Ivan Ivanov" },
            new object[] { "Subscriber" },
            new object[] { "User1" },
            new object[] { "Ivanov Ivan" }
        };

        [Test, TestCaseSource("NamePublicity")]
        public void ChangePublicNamePositive(string text)
        {
            SubscriberPage subscriberPage = new SubscriberPage(driver);
            subscriberPage.Navigate();
            subscriberPage.Profile.Click();
            subscriberPage.DisplayNamePublicy.Click();
            SelectElement selectElement = new SelectElement(subscriberPage.DisplayNamePublicy);
            selectElement.SelectByText(text);
            subscriberPage.UpdateProfile();
            Assert.AreEqual(text, driver.FindElement(By.XPath(subscriberPage.DisplayNameXpath)).Text);
        }

        [Test, TestCaseSource("NamePublicity")]
        public void ChangePublicNameNegative(string text)
        {
            SubscriberPage subscriberPage = new SubscriberPage(driver);
            subscriberPage.Navigate();
            subscriberPage.Profile.Click();
            subscriberPage.DisplayNamePublicy.Click();
            SelectElement selectElement = new SelectElement(subscriberPage.DisplayNamePublicy);
            selectElement.SelectByText(text);
            subscriberPage.Profile.Click();
            Assert.AreNotEqual(text, driver.FindElement(By.XPath(subscriberPage.DisplayNameXpath)).Text);
        }

        [Test]
        public void LogOutPositive()
        {
            SubscriberPage subscriberPage = new SubscriberPage(driver);
            subscriberPage.Navigate();
            IWebElement wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementIsVisible(By.XPath(subscriberPage.DisplayNameXpath)));
            subscriberPage.LogOut();
            Assert.IsTrue(new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.UrlContains(new LogInPage(driver).Url)));
        }
    }
}
