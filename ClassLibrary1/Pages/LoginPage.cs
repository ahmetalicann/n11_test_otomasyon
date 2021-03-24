using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Pages
{
    public class LoginPage
    {
        IWebDriver driver;
        By Username = By.Id("email");
        By Password = By.Id("password");
        By login_Button = By.Id("loginButton");

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void TypeUsername()
        {
            driver.FindElement(Username).SendKeys("ahmetali.6117@gmail.com");
        }

        public void TypePassword()
        {
            driver.FindElement(Password).SendKeys("fnm230596");
        }

        public void ClickLoginButton()
        {
            driver.FindElement(login_Button).Click();
        }
    }
}
