using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClassLibrary1.BaseClass
{
    public class BaseTest
    {
        public IWebDriver driver;

        [SetUp]
        public void Open()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.n11.com/";
        }

        [TearDown]
        public void Close()
        {
            driver.Quit();
        }

        public void search()
        {
            driver.FindElement(By.Id("searchData")).SendKeys("Spor ayakkabı" + OpenQA.Selenium.Keys.Enter);
        }

        public void kategori(string x, string y)
        {
            Actions act = new Actions(driver);
            var element = driver.FindElement(By.XPath(x));
            act.MoveToElement(element).Perform();
            driver.FindElement(By.XPath(y)).Click();
        }
        public void urlGit(string x)
        {
            driver.Navigate().GoToUrl(x);
        }

        public void Search()
        {
            driver.FindElement(By.Id("searchData")).SendKeys("Spor ayakkabı" + OpenQA.Selenium.Keys.Enter);
        }

        public void cssClick(string x)
        {
            driver.FindElement(By.CssSelector(x)).Click();
            Thread.Sleep(1000);
        }

        public void xpathClick(string x)
        {
            driver.FindElement(By.XPath(x)).Click();
            Thread.Sleep(1000);
        }

        public void pop_up()
        {
            try
            {
                driver.FindElement(By.ClassName("seg-popup-close")).Click();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }
        }

        public void kvkk()
        {
            try
            {
                driver.FindElement(By.CssSelector("div#userKvkkModal span.btnBlack")).Click();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }

            //Console.WriteLine("Sayfa Başlığı" + driver.Title + "sayfa Url:" + driver.Url);
            //var productPrice = driver.FindElement(By.CssSelector("div#newCheckout table:nth-child(6) div.priceArea span")).Text;
            //var productPrice2 = driver.FindElement(By.CssSelector("div#newCheckout table:nth-child(5) div.priceArea span")).Text;
            //Console.WriteLine("1. Ürünün Sepet Fiyatı:" + productPrice + " " + "2. Ürünün Sepet Fiyatı:" + productPrice2);
        }

        public void scrollDown()
        {
            var element = driver.FindElement(By.CssSelector("div#contentListing a.active"));
            var js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].scrollIntoView({behavior: 'smooth', block: 'center'})", element);
        }

        public void productOptions(string x)
        {
            driver.FindElement(By.XPath(x)).Click();

            //support kütüphanesi ile option yakalama

            //var element = driver.FindElement(By.Id(x));
            //var selectElement = new SelectElement(element);
            //selectElement.SelectByIndex(2);
            //var element2 = driver.FindElement(By.Id(y));
            //var selectElement2 = new SelectElement(element2);
            //selectElement2.SelectByIndex(2);

        }


        public void Back()
        {
            driver.Navigate().Back();
        }

        public void login()
        {
            driver.FindElement(By.Id("email")).SendKeys("ahmetali.6117@gmail.com");
            driver.FindElement(By.Id("password")).SendKeys("fnm230596");
            driver.FindElement(By.Id("loginButton")).Click();
        }
    }
}
