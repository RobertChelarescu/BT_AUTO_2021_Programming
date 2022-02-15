using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace NUnit_Auto_2022.HomeworkFA.Tests
{
    class TestsRegistrationPage : BaseTest
    {
        string url = Utilities.FrameworkConstants.GetUrl();
    
    [Test]
    public  void CheckingRegistrationPage()
       
        {              
            driver.Navigate().GoToUrl(url + "registration");
            POM.RegisterPage rp = new POM.RegisterPage(driver);
            Assert.AreEqual("Registration", rp.RegistrationText());
            rp.RegistrationPage();
        }

        private static IEnumerable<TestCaseData> GetCredentialsDataCsv()
        {
            string path = "TestDataRegister\\testdataregister.csv";

            var index = 0;
            using var reader = new StreamReader(path);
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');
                if (index > 0)
                {
                    yield return new TestCaseData(values[0].Trim(), values[1].Trim(), values[2].Trim(), values[3].Trim(), bool.Parse(values[4].Trim()), bool.Parse(values[5].Trim()), values[6].Trim(), values[7].Trim(), values[8].Trim(), values[9].Trim(), values[10].Trim(), bool.Parse(values[11].Trim()), values[12].Trim(), values[13].Trim(), values[14].Trim(), values[15].Trim(), values[16].Trim(), values[17].Trim(), values[18].Trim());
                }
                index++;
            }
        }
            [Test, TestCaseSource("TestDataRegister\\testdataregister.csv")]
             public void RegistrationTest(string user, string pass, string confirmPass, bool mr, bool mis, string firstN, string lastN, string emailadress, string date, string nationality, bool terms)

            {
                driver.Navigate().GoToUrl(url);
                POM.RegisterPage rp = new POM.RegisterPage(driver);
                rp.RegistrationPage();
                rp.Registration(user, pass, confirmPass, mr, mis, firstN, lastN, emailadress, date, nationality, terms);


            }
        }
}
