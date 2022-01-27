using Amazon.DynamoDBv2;
using Microsoft.Azure.Documents;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace NUnit_Auto_2022
{
    class RegistrationTest
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


       [TestCase("robert.chelarescu", "automation2021", "automation2021", "Chelarescu","Robert","robert.chelarescu@yahoo.com","19.01.1983","Romanian","","","","","","","","")]
       [TestCase("robert.chelarescu", "", "", "Chelarescu", "Robert", "robert.chelarescu@yahoo.com","19.01.1983", "Romanian","", "Password is required!", "", "", "", "", "","")]
       

        public void Testregistration(string username, string pass, string confpass, string firstname, string lastname, string email,string dateofbirth, string nationality,string usrnameError,string passwError,string confrmpassError,string firstnamError,string lastnamError,string emaillError, string dateofbirthError,string nationalityError)

        {
            Console.WriteLine(url);
            driver.Navigate().GoToUrl(url);

            var registrationClick = driver.FindElement(By.XPath("/html/body/div/div/div[1]/a[3]"));
             registrationClick.Click();

            var pageText = driver.FindElement(By.CssSelector("#root > div > div.sidebar > a:nth-child(3)"));
            Assert.AreEqual("Registration", pageText.Text);


            var enterUsername = driver.FindElement(By.Id("input-username"));
            //enterUsername.SendKeys("robert.chelarescu");
            

            var enterPassword = driver.FindElement(By.Id("input-password"));
           // enterPassword.SendKeys("automation2021");
            

            

            var enterConfirmPassword = driver.FindElement(By.Id("input-password-confirm"));
            // enterConfirmPassword.SendKeys("automation2021");

            var titlMr = driver.FindElement(By.XPath("/html/body/div/div/div[2]/div/div[3]/div/div/form/div[6]/div/div[1]/input"));
            var titlMs = driver.FindElement(By.XPath("/html/body/div/div/div[2]/div/div[3]/div/div/form/div[6]/div/div[2]/input"));

            var radioBtn = driver.FindElement(By.ClassName("form-check-input"));
            radioBtn.Click();
            

            var enterFirstName = driver.FindElement(By.Id("input-first-name"));
            //enterFirstName.SendKeys("Chelarescu");            
            

            var enterLastName = driver.FindElement(By.Id("input-last-name"));
            //enterLastName.SendKeys("Robert");           
            

            var enterEmail = driver.FindElement(By.Id("input-email"));
            //enterEmail.SendKeys("robert.chelarescu@yahoo.com");
                        

            var enterDateofBirth = driver.FindElement(By.Id("input-dob"));
            //enterDateofBirth.Click();
            

            //var selectMonth = driver.FindElement(By.CssSelector("#registration-form > div:nth-child(10) > div > div > div.react-datepicker__tab-loop > div.react-datepicker-popper > div > div > div.react-datepicker__month-container > div.react-datepicker__header > div.react-datepicker__current-month"));
            //selectMonth.Click();
            

            var selectDate = driver.FindElement(By.Id("input-dob"));
            selectDate.Click();           



            var selectElement = driver.FindElement(By.Id("input-nationality"));
            selectElement.Click();
            


            var nationalitySelectedList = driver.FindElement(By.Id("input-nationality"));
            SelectElement element = new SelectElement(nationalitySelectedList);
            element.SelectByText("Romanian");
            
            var acceptTheTherm = driver.FindElement(By.Id("terms"));
            acceptTheTherm.Click();
            

            

            var usernameError = driver.FindElement(By.CssSelector("#registration-form > div:nth-child(2) > div > div > div.text-left.invalid-feedback"));
            var passError = driver.FindElement(By.CssSelector("#registration-form > div:nth-child(3) > div > div > div.text-left.invalid-feedback"));
            var confpassError = driver.FindElement(By.CssSelector("#registration-form > div:nth-child(4) > div > div > div.text-left.invalid-feedback"));
            var firstnameError = driver.FindElement(By.CssSelector("#registration-form > div:nth-child(7) > div > div > div.text-left.invalid-feedback"));
            var lastnameError = driver.FindElement(By.CssSelector("#registration-form > div:nth-child(8) > div > div > div.text-left.invalid-feedback"));
            var emailError = driver.FindElement(By.CssSelector("#registration-form > div:nth-child(9) > div > div > div.text-left.invalid-feedback"));
            var termError = driver.FindElement(By.XPath("/html/body/div/div/div[2]/div/div[3]/div/div/form/div[12]/div[2]/div/label"));


            enterUsername.Clear();
            enterUsername.SendKeys(username);

            enterPassword.Clear();
            enterPassword.SendKeys(pass);

            enterConfirmPassword.Clear();
            enterConfirmPassword.SendKeys(confpass);

            enterFirstName.Clear();
            enterFirstName.SendKeys(firstname);

            enterLastName.Clear();
            enterLastName.SendKeys(lastname);

            enterEmail.Clear();
            enterEmail.SendKeys(email);

            enterDateofBirth.Clear();
            enterDateofBirth.SendKeys(dateofbirth);

           
            var submit = driver.FindElement(By.CssSelector("#registration-form > div:nth-child(13) > div.text-left.col-lg > button"));
            submit.Submit();
            Assert.AreEqual(usrnameError,usernameError.Text);
            Assert.AreEqual(passwError, passError.Text);
            Assert.AreEqual(confrmpassError, confpassError.Text);
            Assert.AreEqual(firstnamError, firstnameError.Text);
            Assert.AreEqual(lastnamError, lastnameError.Text);
            Assert.AreEqual(emaillError, emailError.Text);
           
        }
   
        [TearDown]
        public void Teardown()
        {
            driver.Quit();
        }
    }
}


