using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnit_Auto_2022.HomeworkFA.POM
{
    class LandingPage : BasePage
    {
        const string homeText = "#root > div > div.content > div > div > div > div > h1 > small";

        public LandingPage(IWebDriver driver) : base(driver)
        {
        }

        public string HomePageCheck()
        {
            var homeText = driver.FindElement(By.CssSelector(LandingPage.homeText));
            return homeText.Text;
        }
    }
}

