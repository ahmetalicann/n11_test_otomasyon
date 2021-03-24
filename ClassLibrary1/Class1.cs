using ClassLibrary1.BaseClass;
using ClassLibrary1.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    [TestFixture]
    public class Class1 : BaseTest
    {
        [Test]
        public void TestMethod1()
        {
            search();
            //pop_up();
            scrollDown();
            var priceText = driver.FindElement(By.CssSelector("div#p-449429646 ins")).Text;
            var priceText2 = driver.FindElement(By.CssSelector("#p-238339646 ins")).Text;
            cssClick("div#p-449429646 h3.productName");
            productOptions(".//*[@id = '768877666']/option[2]");
            productOptions(".//*[@id = '768877667']/option[2]");
            cssClick("div#contentProDetail a.btnAddBasket");
            Back();
            scrollDown();
            cssClick("div#p-238339646 h3.productName");
            productOptions(".//*[@id = '754652198']/option[2]");
            productOptions(".//*[@id = '754652199']/option[2]");
            cssClick("div#contentProDetail a.btnAddBasket");
            cssClick("div#wrapper a.myBasket");
            kvkk();
            var basketPrice = driver.FindElement(By.CssSelector("div#newCheckout table:nth-child(6) div.priceArea span")).Text;
            var basketPrice2 = driver.FindElement(By.CssSelector("div#newCheckout table:nth-child(5) div.priceArea span")).Text;
            if (priceText == basketPrice && priceText2 == basketPrice2)
            {  
                cssClick("span#js-buyBtn");
                LoginPage login = new LoginPage(driver);
                login.TypeUsername();
                login.TypePassword();
                login.ClickLoginButton(); 
            }
            
            
            
        }

        [Test]
        public void TestMethod2()
        {
            kategori("//*[@id='contentMain']/div/nav/ul/li[6]/a", "//*[@id='contentMain']/div/nav/ul/li[6]/div/ul/li[2]/a");
            cssClick("ul#filter-list > li:nth-child(1)");
            //productOptions(".//*[@id = '772151561']/label[1]");
            cssClick("#addToBasket");
            cssClick("div#wrapper a.myBasket");
            kvkk();
            cssClick("span#js-buyBtn");
            login();
        }

        [Test]
        public void TestMethod3()
        {
            search();
            scrollDown();
            cssClick("#brand-klm-Kadın");
            cssClick("#brand-numara-38");
            cssClick("#p-390053319 .productName");
            productOptions(".//*[@id = '743015531']/option[3]");
            cssClick("div#contentProDetail a.btnAddBasket");
            cssClick("div#wrapper a.myBasket");
            kvkk();
            cssClick("span#js-buyBtn");
            login();
        }

        [Test]
        public void TestMethod4()
        {
            cssClick("#contentMain .categoryMenuTab ul > li:nth-child(3)");
            cssClick("#p-449520953 .productName");
            cssClick(".addBasketUnify");
            Back();
            cssClick("#p-469727351 .productName");
            cssClick(".addBasketUnify");
            cssClick("div#wrapper a.myBasket");
            kvkk();
            cssClick("span#js-buyBtn");
            login();
        }
    }
}
