using OpenQA.Selenium;
using System;
using System.Collections.Generic;

namespace DotnetSelenium.Pages
{
    public class GmailLoginPage
    {
        private readonly IWebDriver driver;

        public GmailLoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        IWebElement CreateAccount => driver.FindElement(By.XPath("//span[text()='Create account']"));

        IWebElement ClickPersonal => driver.FindElement(By.XPath("//span[text()='For my personal use']"));

        IWebElement UserFirstName => driver.FindElement(By.Name("firstName"));

        IWebElement UserLastName => driver.FindElement(By.Name("lastName"));

        IWebElement Nextbtn => driver.FindElement(By.XPath("//span[text()='Next']"));

        IWebElement SelectMonth => driver.FindElement(By.Id("month"));

        IWebElement SelectDay => driver.FindElement(By.Id("day"));

        IWebElement SelectYear => driver.FindElement(By.Id("year"));

        IWebElement SelectGender => driver.FindElement(By.Id("gender"));

        IWebElement EnterEmail => driver.FindElement(By.XPath("//input[@type='text']"));

        IWebElement EnterPassword => driver.FindElement(By.XPath("//input[@name='Passwd']"));

        IWebElement ConfirmPassword => driver.FindElement(By.XPath("//input[@name='PasswdAgain']"));

        public void ClickCreateAccount()
        {
            SeleniumCustomMethods.Click(CreateAccount);
            SeleniumCustomMethods.Click(ClickPersonal);
        }

        public void CreatAccountPage(string userfirstname, string userlastname, string month, string day, string year,
                                     string gender, string entermail, string enterpassword, string confirmpasword)
        {
            SeleniumCustomMethods.EnterText(UserFirstName, userfirstname);
            SeleniumCustomMethods.EnterText(UserLastName, userlastname);
            SeleniumCustomMethods.Click(Nextbtn);

            // use selectelement to interact with dropdown 
            SeleniumCustomMethods.SelectDropDownText(SelectMonth, month);
            SeleniumCustomMethods.SelectDropDownText(SelectDay, day);
            SeleniumCustomMethods.SelectDropDownText(SelectYear, year);
            SeleniumCustomMethods.SelectDropDownText(SelectGender, gender);
            SeleniumCustomMethods.Click(Nextbtn);

            // Enter email, password and confirm password
            SeleniumCustomMethods.EnterText(EnterEmail, entermail);
            SeleniumCustomMethods.Click(Nextbtn);
            SeleniumCustomMethods.EnterText(EnterPassword, enterpassword);
            SeleniumCustomMethods.EnterText(ConfirmPassword, confirmpasword);

            SeleniumCustomMethods.Click(Nextbtn);


        }

    }
}





