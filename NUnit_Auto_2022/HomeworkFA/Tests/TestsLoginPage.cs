using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace NUnit_Auto_2022.HomeworkFA.Tests
{
    class TestsLoginPage: BaseTest
    {
        readonly string url = Utils.FrameworkConstants.GetUrl();

        [Test]
        public void CheckLoginPage(string username, string password)
        {
            driver.Navigate().GoToUrl(url + "login");
            POM.LoginPage lp = new POM.LoginPage(driver);
            Assert.AreEqual("Authentication", lp.CheckPage());
            lp.Login(username, password);
        }

            private static IEnumerable<TestCaseData> GetCredentialsDataCsv()
            {
                string path = "TestDataLogin\\testdatalogin.csv";
            using var reader = new StreamReader(path);
            var index = 0;
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');
                if (index > 0)
                {
                    yield return new TestCaseData(values[0], values[1]);
                }
                index++;
            }
        }

              
        public void Login(string user, string pass)
        {
            driver.Navigate().GoToUrl(url);            
            POM.LoginPage lp = new POM.LoginPage(driver);           
            lp.ClickLoginPage();
            lp.Login(user, pass);
                     
      }
   }
}
