using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;

namespace WordPressTask.PageObjects
{
    /// <summary>
    /// Class corresponds to a contributor page that can write and manage their messages.
    /// Contains main methods to work with the page.
    /// </summary>
    public class ContributorPage
    {
        private IWebDriver driver;

        public string Login { get; private set; } = "Contributor";
        public string Password { get; private set; } = "1234567";

        [FindsBy(How = How.CssSelector, Using = "#wp-admin-bar-my-account")]
        public IWebElement UserBar { get; private set; }

        [FindsBy(How = How.CssSelector, Using = "#wp-admin-bar-logout")]
        public IWebElement LogOutButton { get; private set; }

        [FindsBy(How = How.XPath, Using = "//a[@href = 'http://localhost:8080/?p=1']")]
        public IWebElement PublishedPost { get; private set; }

        [FindsBy(How = How.XPath, Using = "//a[@href = 'http://localhost:8080/wp-admin/']")]
        public IWebElement WordPRessButton { get; private set; }

        [FindsBy(How = How.LinkText, Using = "Dashboard")]
        public IWebElement DashboardMenu { get; private set; }

        [FindsBy(How = How.Id, Using = "comment")]
        public IWebElement CommentTextArea { get; private set; }

        [FindsBy(How = How.Id, Using = "submit")]
        public IWebElement PostCommentButton { get; private set; }

        [FindsBy(How = How.Id, Using = "title")]
        public IWebElement PostTitle{ get; private set; }

        [FindsBy(How = How.Id, Using = "content")]
        public IWebElement PostContent { get; private set; }

        [FindsBy(How = How.Id, Using = "save-post")]
        public IWebElement SaveQuickPostButton { get; private set; }

        [FindsBy(How = How.LinkText, Using = "Posts")]
        public IWebElement PostsMenu { get; private set; }

        [FindsBy(How = How.LinkText, Using = "Add New")]
        public IWebElement AddNewPostButton { get; private set; }

        [FindsBy(How = How.LinkText, Using = "All Posts")]
        public IWebElement AllPostsButton { get; private set; }

        [FindsBy(How = How.Id, Using = "publish")]
        public IWebElement SubmitToReviewButton { get; private set; }

        [FindsBy(How = How.ClassName, Using = "mine")]
        public IWebElement MyPostsButton { get; private set; }

        [FindsBy(How = How.ClassName, Using = "trash")]
        public IWebElement TrashButton { get; private set; }

        [FindsBy(How = How.Id, Using = "bulk-action-selector-bottom")]
        public IWebElement MoveToTrashSelector { get; private set; }

        [FindsBy(How = How.Id, Using = "doaction2")]
        public IWebElement ApplyButton { get; private set; }

        [FindsBy(How = How.Id, Using = "cb-select-all-1")]
        public IWebElement CheckboxPost{ get; private set; }     

        [FindsBy(How = How.ClassName, Using = "delete")]
        public IWebElement DeleteFromTrashButton { get; private set; }

        [FindsBy(How = How.ClassName, Using = "untrash")]
        public IWebElement RestoreFromTrashButton { get; private set; }

        [FindsBy(How = How.ClassName, Using = "row-title")]
        public IWebElement EditPostButton { get; private set; }

        public string DisplayNameXpath { get; private set; } = "//span[@class = 'display-name']";

        public ContributorPage(IWebDriver browser)
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
        /// Method allows to comment pushed post.
        /// </summary>
        /// <param name="textOfComment">Text of comment.</param>
        public void CommentPost(string textOfComment)
        {
            Actions action = new Actions(driver);
            action.MoveToElement(DashboardMenu).Click().MoveToElement(PublishedPost).Click().Perform();
            IWebElement waitForLoading = new WebDriverWait(driver, TimeSpan.FromSeconds(5)).Until(ExpectedConditions.ElementToBeClickable(CommentTextArea));
            CommentTextArea.SendKeys(textOfComment);
            PostCommentButton.Click();
        }

        /// <summary>
        /// Method allows to create a quick draft.
        /// </summary>
        /// <param name="title">Title of draft.</param>
        /// <param name="content">Content of draft.</param>
        public void CreateQuickDraft(string title, string content)
        {
            DashboardMenu.Click();
            PostTitle.SendKeys(title);
            PostContent.SendKeys(content);
            SaveQuickPostButton.Click();
        }

        /// <summary>
        /// Method allows to create post.
        /// </summary>
        /// <param name="title">Title of post.</param>
        /// <param name="content">Content of post.</param>
        public void CreatePost(string title, string content)
        {
            PostsMenu.Click();
            AddNewPostButton.Click();
            IWebElement waitForTextAreaOfPost = new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementToBeClickable(PostTitle));
            PostTitle.SendKeys(title);
            PostContent.SendKeys(content);
            SubmitToReviewButton.Click();
        }

        /// <summary>
        /// Method allows to trash your post.
        /// </summary>
        public void MoveToTrashPost()
        {
            PostsMenu.Click();
            CheckboxPost.Click();
            SelectElement selectElement = new SelectElement(MoveToTrashSelector);
            selectElement.SelectByText("Move to Trash");
            ApplyButton.Click();
        }

        /// <summary>
        /// Method allows to delete post from trash
        /// </summary>
        public void DeleteFromTrash()
        {
            SelectElement selectElement = new SelectElement(MoveToTrashSelector);
            TrashButton.Click();
            CheckboxPost.Click();
            selectElement.SelectByText("Delete Permanently");
            ApplyButton.Click();
        }

        /// <summary>
        /// Method allows to restore post from trash
        /// </summary>
        public void RestoreFromTrash()
        {
            SelectElement selectElement = new SelectElement(MoveToTrashSelector);
            TrashButton.Click();
            CheckboxPost.Click();
            selectElement.SelectByText("Restore");
            ApplyButton.Click(); 
        }

        /// <summary>
        /// Method allows to return to user page from Test WordPress site.
        /// </summary>
        public void ReturnToProfilePage()
        {
            Actions action = new Actions(driver);
            action.MoveToElement(WordPRessButton).Click();
        }

        /// <summary>
        /// Method allows to change the title of submited post.
        /// </summary>
        /// <param name="titleForChange"></param>
        public void EditPostTitle(string editTitle)
        {
            PostsMenu.Click();
            EditPostButton.Click();
            IWebElement waitForTextAreaOfPost = new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementToBeClickable(PostTitle));
            PostTitle.Clear();
            PostTitle.SendKeys(editTitle);
            SubmitToReviewButton.Click();
        }
    }
}
