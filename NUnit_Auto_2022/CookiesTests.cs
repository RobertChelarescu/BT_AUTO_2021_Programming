using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace NUnit_Auto_2022
{
    class CookiesTests
    {
        IWebDriver driver;

        const string protocol = "http";
        const string hostname = "86.121.249.150";
        const string port = "4999";
        const string path = "/#/";

        string url = protocol + "://" + hostname + ":" + port + path;

        [SetUp]
        public void SetUp()
        {
            var options = new ChromeOptions();
            driver = new ChromeDriver(options);
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void CookieTest()

        {
            driver.Navigate().GoToUrl(url);
            var cookieClick = driver.FindElement(By.XPath("/html/body/div/div/div[1]/a[5]"));
            cookieClick.Click();
            

            var setCookie = driver.FindElement(By.XPath("/html/body/div/div/div[2]/div/div[2]/div/div/div[1]/button[1]"));
            setCookie.Click();
            
            

            var cookies = driver.Manage().Cookies;
            Console.WriteLine("Found {0}  cookies", cookies.AllCookies.Count);

            

            foreach ( Cookie cook in cookies.AllCookies)
            {
                Console.WriteLine("Cookie name{0} and value {1}", cook.Name, cook.Value);
            }

            var setCookies = driver.FindElements(By.Id("set-cookie"));
            var removeCookie = driver.FindElement(By.Id("delete-cookie"));
            var cookieValue = driver.FindElement(By.Id("cookie-value"));

            setCookie.Click();
            var c = cookies.GetCookieNamed("gibberish");
            Assert.AreEqual(cookieValue.Text,cookieValue.Text);
            Console.WriteLine("Cookie text is {1}");


            removeCookie.Click();
            cookies.DeleteAllCookies();
            Console.WriteLine("The site contains {0} cookies", cookies.AllCookies.Count);
                      
        }
        [TearDown]
        public void Teardown()
        {
            driver.Quit();
        }
    }
}
