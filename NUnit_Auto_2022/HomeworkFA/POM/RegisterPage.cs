using OpenQA.Selenium;
using System;

namespace NUnit_Auto_2022.HomeworkFA.POM
{
    public class RegisterPage : BasePage
    {
        const string registerLink = "#root > div > div.sidebar > a:nth-child(3)";
        const string registrationPageText = "#root > div > div.content > div > div:nth-child(1) > div > div > h1 > small; //css selector";
        const string usernameInput = "input-username";
        const string passwordInput = "input-password";
        const string confirmPassInput = "input-password-confirm";
        const string emailInput = "input-email";
        const string termSelector = "terms";
        const string firstnameInput = "#input-first-name";
        const string lastnameInput = "#input-last-name";
        const string mrRadioButton = "#registration-form > div:nth-child(6) > div > div:nth-child(1) > input";
        const string msRadioButton = "#registration-form > div:nth-child(6) > div > div:nth-child(2) > input";
        const string registerSubmitButton = "#registration-form > div:nth-child(13) > div.text-left.col-lg > button";
        const string usernameRegistrationError = "#registration-form > div:nth-child(2) > div > div > div.text-left.invalid-feedback";
        const string passRegistrationError = "#registration-form > div:nth-child(3) > div > div > div.text-left.invalid-feedback";
        const string confirmPassRegistrationError = "#registration-form > div:nth-child(4) > div > div > div.text-left.invalid-feedback";
        const string emailRegistrationError = "#registration-form > div:nth-child(9) > div > div > div.text-left.invalid-feedback";
        const string firstNameCharactersRequired = "#registration-form > div:nth-child(7) > div > div > div.text-left.invalid-feedback";
        const string lastNameCharactersRequired = "#registration-form > div:nth-child(8) > div > div > div.text-left.invalid-feedback";
        const string dateOfBirth = "input-dob";
        const string nationality = "#input-nationality";



        public RegisterPage(IWebDriver driver) : base(driver)
        {

        }
        
        public void RegistrationPage()
        {
            var registrationLink = driver.FindElement(By.CssSelector(registerLink));
            registrationLink.Click();
        }

        public string RegistrationText()
        {
            var registrationText = driver.FindElement(By.CssSelector(registrationPageText));
            return registrationText.Text;
        }

          public void Registration( string user, string pass, string confirmPass, bool mr, bool mis, string firstN, string lastN, string emailadress, string date, string nationality, bool terms)
        {
            var username = driver.FindElement(By.Id(usernameInput));
            var password = driver.FindElement(By.Id(passwordInput));
            var confirmPassword = driver.FindElement(By.Id(confirmPassInput));
            var misterRadioButton = driver.FindElement(By.CssSelector(RegisterPage.mrRadioButton));
            var missRadioButton = driver.FindElement(By.CssSelector(RegisterPage.msRadioButton));
            var email = driver.FindElement(By.Id(emailInput));
            var national = driver.FindElement(By.CssSelector(RegisterPage.nationality));
            var dob = driver.FindElement(By.Id(dateOfBirth));
            var term = driver.FindElement(By.Id(termSelector));
            var submit = driver.FindElement(By.CssSelector(registerSubmitButton));
            var firstName = driver.FindElement(By.CssSelector(firstnameInput));
            var lastName = driver.FindElement(By.CssSelector(lastnameInput));


            username.Clear();
            username.SendKeys(user);

            password.Clear();
            password.SendKeys(pass);

            confirmPassword.Clear();
            confirmPassword.SendKeys(confirmPass);

            firstName.Clear();
            firstName.SendKeys(firstN);

            lastName.Clear();
            lastName.SendKeys(lastN);

            email.Clear();
            email.SendKeys(emailadress);

            national.Clear();
            national.SendKeys(nationality);

            dob.Clear();
            dob.SendKeys(date);


            bool misterSelect = misterRadioButton.Selected;                       
            bool missSelect = missRadioButton.Selected;

            if (misterSelect == false & missSelect == false & mr == true & mis == false)
            {
                misterRadioButton.Click();
            }

            if (misterSelect == false & missSelect == false & mr == false & mis == true)
            {
                missRadioButton.Click();
            }

            if (terms == true)
            {
                term.Click();
            }

            submit.Submit();

        }

        public string RegistrationUsrnErrMsg()
        {
            var usernameError = driver.FindElement(By.CssSelector(usernameRegistrationError));
            return usernameError.Text;
        }

        public string RegistrationPassErrMsg()
        {
            var passwordError = driver.FindElement(By.CssSelector(passRegistrationError));
            return passwordError.Text;
        }

        public string RegistrationConfPassMsg()
        {
            var confirmPassError = driver.FindElement(By.CssSelector(confirmPassRegistrationError));
            return confirmPassError.Text;
        }

        public string RegistrationFirstErrMsg()
        {
            var firstNameCharactersError = driver.FindElement(By.CssSelector(firstNameCharactersRequired));
            return firstNameCharactersError.Text;
        }
        public string RegistrationLastErrMsg()
        {
            var lastNameCharactersError = driver.FindElement(By.CssSelector(lastNameCharactersRequired));
            return lastNameCharactersError.Text;
        }

        public string RegistrationEmailErrMsg()
        {
            var emailError = driver.FindElement(By.CssSelector(emailRegistrationError));
            return emailError.Text;
        }


        public string RegistrationTermsErrMsg()
        {
            var termsError = driver.FindElement(By.CssSelector("#registration-form > div:nth-child(12) > div.text-left.col-lg > div > div"));
            return termsError.Text;
        }

       
    }
}