using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnit_Auto_2022
{
    class SeleniumTests
    {
       // public string path = "c:\\driver";
        IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
           // driver = new ChromeDriver();
            driver = new FirefoxDriver();
             //driver = new EdgeDriver();
        }
        [Test]
        public void Test01()
        {
                   
            driver.Url = "https://facebook.com";
            driver.Navigate();
                     


        }
        [TearDown]
        public void Teardown()
        {
            driver.Quit();
        }
    }
}
