using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetSelenium
{
    class SeleniumCustomMethods
    {
        // Methods should get the locator
        // start getting the type of identifier
        // perform operation on the locator

        public static void Click(IWebElement locator)
        {
            locator.Click();
        }

        public static void EnterText(IWebElement locator, string text)
        {
            locator.Clear();
            locator.SendKeys(text);
        }

        public static void SelectDropDownText(IWebElement locator, string text)
        {
            locator.Click();
            SelectElement selectElement = new SelectElement(locator);
            selectElement.SelectByText(text);
        }
    }
}
