using DotnetSelenium.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V133.Audits;
using OpenQA.Selenium.Support.UI;
using System.Xml.Linq;

namespace DotnetSelenium
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com/");
            driver.Manage().Window.Maximize();
            IWebElement webElement = driver.FindElement(By.Name("q"));
            webElement.SendKeys("Selenium");
            webElement.SendKeys(Keys.Return);

        }

        [Test]
        public void SwagLabs()
        {

            IWebDriver driver = new ChromeDriver();
            // Navigate to the url
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            driver.Manage().Window.Maximize();
            /*IWebElement clickOnUsername = driver.FindElement(By.Name("user-name"));
            clickOnUsername.Click();
            clickOnUsername.SendKeys("standard_user");
            IWebElement clickOnPassword = driver.FindElement(By.Name("password"));
            clickOnPassword.Click();
            clickOnPassword.SendKeys("secret_sauce");
            IWebElement LoginBtn = driver.FindElement(By.Name("login-button"));
            LoginBtn.Click();*/
            SwagLabsSite swagLabsLogin = new SwagLabsSite(driver);
            swagLabsLogin.Login("standard_user", "secret_sauce");
            swagLabsLogin.AddProduct("Yash", "Patil", "425300");
        }
       /* [Test]

        public void GmailLoginPageWithPOM()
        {
            // Create a new instance of Selenium Web driver
            IWebDriver driver = new ChromeDriver();
            // Navigate to the url
            driver.Navigate().GoToUrl("https://accounts.google.com/v3/signin/identifier?continue=https%3A%2F%2Fmail.google.com%2Fmail%2Fu%2F0%2F&emr=1&followup=https%3A%2F%2Fmail.google.com%2Fmail%2Fu%2F0%2F&ifkv=ASSHykopxe9GB0kCCiiXrqJr-aeC2kZbmkM_Vnco-XUT4ZozMTCDgkYSbiq9Og0g9xfeU075D-qjFA&osid=1&passive=1209600&service=mail&flowName=GlifWebSignIn&flowEntry=ServiceLogin&dsh=S20662687%3A1741003816676254&ddm=1");
            //  Create a new account option.
            // Create Gmail Login page object
            GmailLoginPage gmailPage = new GmailLoginPage(driver);
            gmailPage.ClickCreateAccount();
            gmailPage.CreatAccountPage("Rahul", "Patil", "May", "25", "1999","1", "rahulpatil42084000@gmail.com", "Pass@12345", "Pass@12345");
        }
        [Test]
        public void GmailWebSiteTest()
        {   
            // Create a new instance of Selenium Web driver
            IWebDriver driver = new ChromeDriver();
            // Navigate to the url
            driver.Navigate().GoToUrl("https://accounts.google.com/v3/signin/identifier?continue=https%3A%2F%2Fmail.google.com%2Fmail%2Fu%2F0%2F&emr=1&followup=https%3A%2F%2Fmail.google.com%2Fmail%2Fu%2F0%2F&ifkv=ASSHykopxe9GB0kCCiiXrqJr-aeC2kZbmkM_Vnco-XUT4ZozMTCDgkYSbiq9Og0g9xfeU075D-qjFA&osid=1&passive=1209600&service=mail&flowName=GlifWebSignIn&flowEntry=ServiceLogin&dsh=S20662687%3A1741003816676254&ddm=1");
            // Click on Create a new account option.
            var clickCreateAcc = driver.FindElement(By.XPath("//span[text()='Create account']"));
            clickCreateAcc.Click();
        //    // Click on Person Use 
            var selPersonalUsebtn = driver.FindElement(By.XPath("//span[text()='For my personal use']"));
            selPersonalUsebtn.Click();
            // Click on First Name option
            var clickOnFirstbtn = driver.FindElement(By.Name("firstName"));
            clickOnFirstbtn.Click();
            clickOnFirstbtn.SendKeys("Rahul");
            // Click on Last Name option
            var clickOnLastbtn = driver.FindElement(By.Name("lastName"));
            clickOnLastbtn.Click();
            clickOnLastbtn.SendKeys("Patil");
        //    // Click on Next option
            var clickOnNextbtn = driver.FindElement(By.XPath("//span[text()='Next']"));
           clickOnNextbtn.Click();
        //    // click on Month option (dropdown)
            SelectElement selectElementMonth = new SelectElement(driver.FindElement(By.Id("month")));
            selectElementMonth.SelectByText("May");

        //    // click on Day option
            SelectElement selectElementDay = new SelectElement(driver.FindElement(By.Id("day")));
            selectElementDay.SelectByValue("25");

        //    // click on Year option
            SelectElement selectElementYear = new SelectElement(driver.FindElement(By.Id("year")));
            selectElementYear.SelectByValue("1999");

        //    // click on Gender option
            SelectElement selectElementGender = new SelectElement(driver.FindElement(By.Id("gender")));
            selectElementGender.SelectByValue("1"); // for male value is  1

        //    // click on Next option
            clickOnNextbtn.Click();

        }*/

    }
}
