using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;

namespace WordPressTask.PageObjects
{
    /// <summary>
    /// Class corresponds to a subscriber page that can manage only their profile.
    /// Contains main methods to work with the page.
    /// </summary>
    public class SubscriberPage
    {
        private IWebDriver driver;

        public string Login { get; private set; } = "User1";
        public string Password { get; private set; } = "12345";


        [FindsBy(How = How.Id, Using = "menu-users")]
        public IWebElement Profile { get; private set; }

        [FindsBy(How = How.CssSelector, Using = "#wp-admin-bar-my-account")]
        public IWebElement UserBar { get; private set; }

        [FindsBy(How = How.XPath, Using = "//input[@value = 'Update Profile']")]
        public IWebElement UpdateProfileButton { get; private set; }

        [FindsBy(How = How.XPath, Using = "//select[@id = 'display_name']")]
        public IWebElement DisplayNamePublicy { get; private set; }

        [FindsBy(How = How.CssSelector, Using = "#wp-admin-bar-logout a")]
        public IWebElement LogOutButton { get; private set; }

        public string DisplayNameXpath { get; private set; } = "//span[@class = 'display-name']";

        public SubscriberPage(IWebDriver browser)
        {
            driver = browser;
            PageFactory.InitElements(browser, this);
        }

        /// <summary>
        /// Method allows to navigate to this page.
        /// </summary>
        public void Navigate()
        {
            LogInPage logInPage = new LogInPage(driver);
            logInPage.Navigate();
            logInPage.LogIn(Login, Password);
        }

        /// <summary>
        /// Method allows to log out from this page.
        /// </summary>
        public void LogOut()
        {
            Actions action = new Actions(driver);
            action.MoveToElement(UserBar).Perform();
            action.Click(LogOutButton).Perform();
        }

        /// <summary>
        /// Method allows to update user's profile.
        /// </summary>
        public void UpdateProfile()
        {
            UpdateProfileButton.Click();
        }
    }
}
