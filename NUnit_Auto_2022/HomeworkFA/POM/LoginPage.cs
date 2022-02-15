using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnit_Auto_2022.HomeworkFA.POM
{
        public class LoginPage : BasePage
    {

        const string loginLink = "#root > div > div.sidebar > a:nth-child(2)";
        const string authenticationText = "#root > div > div.content > div > div:nth-child(1) > div > div > h1 > small";
        const string usernameInput = "#input-login-username";
        const string passwordInput = "#input-login-password";
        const string submitButton = "#login-form > div:nth-child(3) > div.text-left.col-lg > button";
        const string usernameErrorMsg = "#login-form > div:nth-child(1) > div > div > div.text-left.invalid-feedback"; 
        const string passwordErrorMsg = "#login-form > div.form-group.row.row-cols-lg-true > div > div > div.text-left.invalid-feedback"; 
      
        public LoginPage(IWebDriver driver) : base(driver)
        {
        }
                
        public void ClickLoginPage()
        {
         var loginButton = driver.FindElement(By.CssSelector(POM.LoginPage.loginLink));
         loginButton.Click();
        }


        public string CheckPage()
        { 
            var loginText = driver.FindElement(By.CssSelector(authenticationText));        
            return loginText.Text;
        }

        public void Login(string user, string pass)
        {
            var username = driver.FindElement(By.Id(usernameInput));
            var password = driver.FindElement(By.Id(passwordInput));
            var submit = driver.FindElement(By.CssSelector(submitButton));



            username.Clear();
            username.SendKeys(user);


            
            password.Clear();
            password.SendKeys(pass);

            
            submit.Submit();
         }

        public string UsernameErrorMsg()
        {
            var usernameError = driver.FindElement(By.CssSelector(usernameErrorMsg));
            return usernameError.Text;
        }


        public string PasswordErrorMsg()
        {
            var passwordError = driver.FindElement(By.CssSelector(passwordErrorMsg));
            return passwordError.Text;
        }


    }
}