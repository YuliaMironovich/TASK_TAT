using System;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using WordPressTask.PageObjects;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework.Internal;

namespace WordPressTask
{
    public class ContributorPageTests
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

        static object[] TextOfComment =
        {
            new object[] { "First comment", "pending-count", "1" },
            new object[] { String.Empty, "pending-count", "1" }
        };

        [Test, TestCaseSource("TextOfComment")]
        public void CommentPostPositive(string text, string className, string count)
        {
            ContributorPage contributorPage = new ContributorPage(driver);
            contributorPage.Navigate();
            IWebElement wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementIsVisible(By.XPath(contributorPage.DisplayNameXpath)));
            contributorPage.CommentPost(text);
            contributorPage.ReturnToProfilePage();
            Assert.AreEqual(count, driver.FindElement(By.ClassName(className)).Text);
        }

        [Test]
        public void LogOutPositive()
        {
            ContributorPage contributorPage = new ContributorPage(driver);
            contributorPage.Navigate();
            IWebElement wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementIsVisible(By.XPath(contributorPage.DisplayNameXpath)));
            contributorPage.LogOut();
            Assert.IsTrue(new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.UrlContains(new LogInPage(driver).Url)));
        }

        static object[] TextOfQuickOfPost =
        {
            new object[] { "QuickPost", "Contributor Quick Post" }
        };

        [Test, TestCaseSource("TextOfQuickOfPost")]
        public void CreateQuickDraftPositive(string title, string content)
        {
            ContributorPage contributorPage = new ContributorPage(driver);
            contributorPage.Navigate();
            IWebElement wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementIsVisible(By.XPath(contributorPage.DisplayNameXpath)));
            contributorPage.CreateQuickDraft(title, content);
            contributorPage.PostsMenu.Click();
            IWebElement waitForPostMenu = new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementToBeClickable(contributorPage.MyPostsButton));
            contributorPage.MyPostsButton.Click();
            Assert.AreEqual(title, driver.FindElement(By.LinkText(title)).Text);
        }

        [Test]
        public void CreateQuickDraftNegative()
        {
            ContributorPage contributorPage = new ContributorPage(driver);
            contributorPage.Navigate();
            IWebElement wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementIsVisible(By.XPath(contributorPage.DisplayNameXpath)));
            contributorPage.DashboardMenu.Click();
            contributorPage.PostTitle.Clear();
            contributorPage.PostContent.Clear();
            contributorPage.SaveQuickPostButton.Click();
            contributorPage.PostsMenu.Click();
            Assert.IsTrue(new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.InvisibilityOfElementLocated(By.ClassName("mine"))));
        }

        static object[] TextOfPost =
        {
            new object[] { "Post", "Contributor Post" },
        };

        [Test, TestCaseSource("TextOfPost")]
        public void CreatePostPositive(string title, string content)
        {
            ContributorPage contributorPage = new ContributorPage(driver);
            contributorPage.Navigate();
            IWebElement wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementIsVisible(By.XPath(contributorPage.DisplayNameXpath)));
            contributorPage.CreatePost(title, content);
            contributorPage.PostsMenu.Click();
            IAlert alert = driver.SwitchTo().Alert();
            alert.Accept();
            IWebElement waitForPostMenu = new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementToBeClickable(contributorPage.MyPostsButton));
            contributorPage.MyPostsButton.Click();
            Assert.AreEqual(title, driver.FindElement(By.LinkText(title)).Text);
        }

        [Test]
        public void CreatePostNegative()
        {
            ContributorPage contributorPage = new ContributorPage(driver);
            contributorPage.Navigate();
            IWebElement wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementIsVisible(By.XPath(contributorPage.DisplayNameXpath)));
            contributorPage.PostsMenu.Click();
            contributorPage.AddNewPostButton.Click();
            IWebElement waitForTextAreaOfPost = new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementToBeClickable(contributorPage.PostTitle));
            contributorPage.PostTitle.Clear();
            contributorPage.PostContent.Clear();
            contributorPage.SubmitToReviewButton.Click();
            contributorPage.PostsMenu.Click();
            IWebElement waitForPostMenu = new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementToBeClickable(contributorPage.MyPostsButton));
            contributorPage.MyPostsButton.Click();
            Assert.IsTrue(new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath("//a[@aria-label = '“”']"))));
        }

        [Test]
        public void MoveToTrashPositive()
        {
            ContributorPage contributorPage = new ContributorPage(driver);
            contributorPage.Navigate();
            string title = "Title to trash";
            string content = "Content to trash";
            contributorPage.CreatePost(title, content);
            contributorPage.PostsMenu.Click();
            IAlert alert = driver.SwitchTo().Alert();
            alert.Accept();
            IWebElement wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementIsVisible(By.XPath(contributorPage.DisplayNameXpath)));
            contributorPage.MoveToTrashPost();
            Assert.IsTrue(new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.InvisibilityOfElementLocated(By.ClassName("mine"))));
        }

        [Test]
        public void DeletePostPositive()
        {
            ContributorPage contributorPage = new ContributorPage(driver);
            contributorPage.Navigate();
            string title = "Title to delete";
            string content = "Content to delete";
            contributorPage.CreatePost(title, content);
            contributorPage.PostsMenu.Click();
            IAlert alert = driver.SwitchTo().Alert();
            alert.Accept();
            contributorPage.MoveToTrashPost();
            contributorPage.DeleteFromTrash();
            Assert.IsTrue(new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.InvisibilityOfElementLocated(By.ClassName("mine"))));
        }

        [Test]
        public void RestoreFromTrashPositive()
        {
            ContributorPage contributorPage = new ContributorPage(driver);
            contributorPage.Navigate();
            string title = "Title to resore";
            string content = "Content to restore";
            contributorPage.CreatePost(title, content);
            contributorPage.PostsMenu.Click();
            IAlert alert = driver.SwitchTo().Alert();
            alert.Accept();
            contributorPage.MoveToTrashPost();
            contributorPage.RestoreFromTrash();
            contributorPage.MyPostsButton.Click();
            Assert.AreEqual(title, driver.FindElement(By.LinkText(title)).Text);
        }

        [Test]
        public void EditPostTitlePositive()
        {
            ContributorPage contributorPage = new ContributorPage(driver);
            contributorPage.Navigate();
            string title = "Title";
            string content = "Content";
            string editTitle = "Edit Title";
            contributorPage.CreatePost(title, content);
            contributorPage.PostsMenu.Click();
            IAlert alert = driver.SwitchTo().Alert();
            alert.Accept();
            contributorPage.EditPostTitle(editTitle);
            contributorPage.PostsMenu.Click();
            contributorPage.MyPostsButton.Click();
            Assert.AreEqual(editTitle, driver.FindElement(By.LinkText(editTitle)).Text);
        }

    }
}
