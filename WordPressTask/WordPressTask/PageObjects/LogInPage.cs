using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace WordPressTask.PageObjects
{
    /// <summary>
    /// Class corresponds to a main page of WordPress 
    /// where the users can log in their profile.
    /// Contains main methods to work with the page.
    /// </summary>
    public class LogInPage
    {
        private IWebDriver driver;
        public string Url { get; } = @"http://localhost:8080/wp-login.php";

        [FindsBy(How = How.Id, Using = "user_login")]
        public IWebElement UserLogin { get; private set; }

        [FindsBy(How = How.Id, Using = "user_pass")]
        public IWebElement UserPassword { get; private set; }

        [FindsBy(How = How.Id, Using = "wp-submit")]
        public IWebElement LogInButton { get; private set; }

        [FindsBy(How = How.XPath, Using = "//input[@name = 'rememberme']")]
        public IWebElement RememberMeButton { get; private set; }

        public LogInPage(IWebDriver browser)
        {
            driver = browser;
            PageFactory.InitElements(browser, this);
        }

        /// <summary>
        /// Method allows to navigate to this page.
        /// </summary>
        public void Navigate()
        {
            driver.Navigate().GoToUrl(Url);
        }

        /// <summary>
        /// Method allows to remember the user in system.
        /// </summary>
        public void RememberUser()
        {
            RememberMeButton.Click();
        }

        /// <summary>
        /// Method allows to log in the user's profile.
        /// </summary>
        public void LogIn(string login, string password)
        {
            UserLogin.SendKeys(login);
            UserPassword.SendKeys(password);
            LogInButton.Click();
        }
    }
}
