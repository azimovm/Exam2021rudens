using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;


namespace Test.TestsCases
{
    internal class Tests
    {
        public Tests(){
        IWebDriver driver;
        var options = new ChromeOptions();
        options.AddExcludedArgument("enable-logging");
        driver = new ChromeDriver(@"D:\Education\5 Semestr\Software Development Technology\Drivers", options);
        driver.Url = "https://www.ebay.com/";
        driver.FindElement(By.Id("gh-ac")).SendKeys("Samsung");
        driver.FindElement(By.Id("gh-btn")).Click();

        }

    }
}
