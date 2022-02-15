using NUnit.Framework;
using NUnit_Auto_2022.HomeworkFA.Utils;
using OpenQA.Selenium;
using Sentry.Protocol;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnit_Auto_2022.HomeworkFA.Tests
{
    public class BaseTest
    {
        public IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = Browsers.GetDriver();
        }

        [TearDown]
        public void Teardown()
        {
            driver.Quit();
        }

    }
}
