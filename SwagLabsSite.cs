using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetSelenium
{
    public class SwagLabsSite
    {
        private readonly IWebDriver driver;

        public SwagLabsSite(IWebDriver driver)
        {
            this.driver = driver;
        }

        IWebElement TextUserName => driver.FindElement(By.XPath("//input[@placeholder='Username']"));

        IWebElement TextPassword => driver.FindElement(By.XPath("//input[@placeholder='Password']"));

        IWebElement LoginBtn => driver.FindElement(By.XPath("//input[@type='submit']"));

        IWebElement PickedOnProduct => driver.FindElement(By.XPath("//div[text()='Sauce Labs Backpack']"));
        IWebElement AddToCardProduct => driver.FindElement(By.XPath("//button[text()='Add to cart']"));
        IWebElement ClickOnCartOption => driver.FindElement(By.XPath("//a[@class='shopping_cart_link']"));
        IWebElement ClickOnCheckOut => driver.FindElement(By.Name("checkout"));
        IWebElement TextFirstName => driver.FindElement(By.Name("firstName"));
        IWebElement TextLastName => driver.FindElement(By.Name("lastName"));
        IWebElement TextZipCode => driver.FindElement(By.Name("postalCode"));
        IWebElement ClickOnContinue => driver.FindElement(By.Name("continue"));
        IWebElement ClickOnFinish => driver.FindElement(By.Name("finish"));





        public void Login(string username, string password)
        { 
            SeleniumCustomMethods.EnterText(TextUserName, username);
            SeleniumCustomMethods.EnterText(TextPassword, password);
            SeleniumCustomMethods.Click(LoginBtn);
        }

        public void AddProduct(string firstname, string lastname, string pincode)
        {
            SeleniumCustomMethods.Click(PickedOnProduct);
            SeleniumCustomMethods.Click(AddToCardProduct);
            SeleniumCustomMethods.Click(ClickOnCartOption);
            SeleniumCustomMethods.Click(ClickOnCheckOut);
            SeleniumCustomMethods.EnterText(TextFirstName, firstname);
            SeleniumCustomMethods.EnterText(TextLastName, lastname);
            SeleniumCustomMethods.EnterText(TextZipCode, pincode);
            SeleniumCustomMethods.Click(ClickOnContinue);
            SeleniumCustomMethods.Click(ClickOnFinish);
            Console.WriteLine("Thank you for your order!..");
        }
        
    }
}
