using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using OpenQA.Selenium.Firefox;
using Microsoft.Edge.SeleniumTools;

namespace NUnit_Auto_2022
{
    class AuthenticationTests
    {

        IWebDriver driver;

        const string protocol = "http";
        const string hostname = "86.121.249.150";
        const string port = "4999";
        const string path = "/#/";

        string url = protocol + "://" + hostname + ":" + port + path;

        [SetUp]
        public void Setup()
        {
            // Chrome Options
            var options = new ChromeOptions();
            //options.AddArgument("--start-maximized");
            //options.AddArgument("headless");
            options.AddArgument("ignore-certificate-errors");
            var proxy = new Proxy();
            proxy.HttpProxy = "127.0.0.1:8080";
            proxy.IsAutoDetect = false;
            //options.Proxy = proxy;
            //options.AddExtension("C:\\Users\\alex\\Downloads\\extension_4_42_0_0.crx");

            // Firefox Options
            var firefoxOptions = new FirefoxOptions();
            string[] optionList =
            {
                //"--headless",
                "--ignore-certificate-errors",
                "--no-sandbox",
                "--disable-gpu"
            };
            firefoxOptions.AddArguments(optionList);
            FirefoxProfile fProfile = new FirefoxProfile();
            fProfile.AddExtension("C:\\Users\\alex\\Downloads\\metamask-10.8.1-an+fx.xpi");
            firefoxOptions.Profile = fProfile;

            // Edge options
            var edgeOptions = new EdgeOptions();
            //edgeOptions.AddExtension("C:\\Users\\alex\\Downloads\\extension_4_42_0_0.crx");
            edgeOptions.AddArguments("args", "['--start-maximized', '--headless']");
            edgeOptions.AddArgument("headless");

            driver = new ChromeDriver(options);
            //driver = new FirefoxDriver(firefoxOptions);
            //driver = new EdgeDriver(edgeOptions);
            driver.Manage().Window.Maximize();
        }

        [TestCase("dinosaur", "dinosaurpassword", "", "")]
        [TestCase("dinosaur", "", "", "Password is required!")]
        [TestCase("", "", "Username is required!", "Password is required!")]
        [TestCase("", "dinopass", "Username is required!", "")]
        public void Test01(string user, string pass, string userErr, string passErr)
        {
            Console.WriteLine(url);
            driver.Navigate().GoToUrl(url);

            var pageText = driver.FindElement(By.CssSelector("#root > div > div.content > div > div:nth-child(1) > div > div > h1 > small"));
            Assert.AreEqual("Home", pageText.Text);

            var loginLink = driver.FindElement(By.CssSelector("#root > div > div.sidebar > a:nth-child(2)"));
            loginLink.Click();
            Console.WriteLine(loginLink.GetAttribute("href"));

            pageText = driver.FindElement(By.CssSelector("#root > div > div.content > div > div:nth-child(1) > div > div > h1 > small"));
            Assert.AreEqual("Authentication", pageText.Text);

            var username = driver.FindElement(By.Id("input-login-username"));
            var password = driver.FindElement(By.Id("input-login-password"));
            var submit = driver.FindElement(By.CssSelector("#login-form > div:nth-child(3) > div.text-left.col-lg > button"));

            var usernameError = driver.FindElement(By.CssSelector("#login-form > div:nth-child(1) > div > div > div.text-left.invalid-feedback"));
            var passwordError = driver.FindElement(By.CssSelector("#login-form > div.form-group.row.row-cols-lg-true > div > div > div.text-left.invalid-feedback"));

            username.Clear();
            username.SendKeys(user);

            password.Clear();
            password.SendKeys(pass);

            submit.Submit();

            Assert.AreEqual(userErr, usernameError.Text);
            Assert.AreEqual(passErr, passwordError.Text);

        }


        // implicit wait test
        [Test]
        public void Test02()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            string url = protocol + "://" + hostname + ":8081/lazy.html";
            driver.Navigate().GoToUrl(url);

            var button1 = driver.FindElement(By.Id("btn1"));
            button1.Click();

        }

        // explicit wait test
        [Test]
        public void Test03()
        {
            string url = protocol + "://" + hostname + ":8081/lazy.html";
            driver.Navigate().GoToUrl(url);

            var button1 = Utils.WaitForElement(driver, 20, By.Id("btn1"));
            button1.Click();

        }

        [Test]
        public void Test04()
        {
            string url = protocol + "://" + hostname + ":8081/lazy.html";
            driver.Navigate().GoToUrl(url);

            var button2 = Utils.WaitForElement(driver, 15, By.Id("btn2"));
            for (int i = 0; i < 100; i++)
            {
                button2.Click();
            }
            Thread.Sleep(20000); // pausing test execution for 20 seconds !!! Please avoid !!
        }

        [Test]
        public void Test05()
        {
            string url = protocol + "://" + hostname + ":8081/lazy.html";
            driver.Navigate().GoToUrl(url);

            var element = Utils.WaitForFluentElement(driver, 20, By.Id("btn2"));
            element.Click();
        }

        [Test]
        public void Test06()
        {
            driver.Navigate().GoToUrl("https://magazinulcolectionarului.ro/");

            var cookies = driver.Manage().Cookies;
            Console.WriteLine("The site contains {0} cookies", cookies.AllCookies.Count);
            Utils.PrintCookies(cookies);
            Cookie myCookie = new Cookie("myCookie", "vineoaiapapalupu");
            cookies.AddCookie(myCookie);
            Utils.PrintCookies(cookies);

            var ck = cookies.GetCookieNamed("PHPSESSID");
            Console.WriteLine("Cookie name {0} and value {1}", ck.Name, ck.Value);


            cookies.DeleteAllCookies();
            Console.WriteLine("The site contains {0} cookies", cookies.AllCookies.Count);

            Utils.TakeScreenshotWithDate(driver, "C:\\Temp", "screenshot", ScreenshotImageFormat.Png);

        }

        [Test]
        public void Test07()
        {
            driver.Navigate().GoToUrl("http://86.121.249.150:4999/#/alert");
            var alertButton = driver.FindElement(By.Id("alert-trigger"));
            var confirmButton = driver.FindElement(By.Id("confirm-trigger"));
            var promptButton = driver.FindElement(By.Id("prompt-trigger"));

            alertButton.Click();
            IAlert alert = driver.SwitchTo().Alert();
            Console.WriteLine(alert.Text);
            alert.Accept();

            confirmButton.Click();
            alert = driver.SwitchTo().Alert();
            Console.WriteLine(alert.Text);
            alert.Dismiss();

            promptButton.Click();
            alert = driver.SwitchTo().Alert();
            Console.WriteLine(alert.Text);
            alert.SendKeys("alex");
            alert.Accept();
        }

        [TearDown]
        public void Teardown()
        {
            driver.Quit();
        }


    }
}

