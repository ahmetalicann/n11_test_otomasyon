using ClassLibrary1.BaseClass;
using ClassLibrary1.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    [TestFixture]
    public class Class1 : HomeClass
    {
        [Test]
        public void ListedenSepeteUrunEkle()
        {
            //Case elementleri
            By firstproduct = By.CssSelector("div#p-449429646 h3.productName");
            By firstproductoptions = By.XPath(".//*[@id = '768877666']/option[2]");
            By firstproductoptions2 = By.XPath(".//*[@id = '768877667']/option[2]");
            By secondproduct = By.CssSelector("div#p-238339646 h3.productName");
            By secondproductoptions = By.XPath(".//*[@id = '754652198']/option[2]");
            By secondproductoptions2 = By.XPath(".//*[@id = '754652199']/option[2]");
            By AddBasket = By.CssSelector("div#contentProDetail a.btnAddBasket");
            By MyBasket = By.CssSelector("div#wrapper a.myBasket");
            By BuyButton = By.CssSelector("span#js-buyBtn");
            By notEqual = By.CssSelector("div.prodAction > span.removeProd.svgIcon.svgIcon_trash");

            //driver.FindElement(By.XPath("//a[1]/parent::li[@class='catMenuItem active']")).Click();

            search();
            //pop_up();
            scrollDown();
            var priceText = driver.FindElement(By.CssSelector("div#p-449429646 ins")).Text;
            var priceText2 = driver.FindElement(By.CssSelector("#p-238339646 ins")).Text;
            //Click(firstproduct);

            Click(firstproductoptions);
            Click(firstproductoptions2);
            Click(AddBasket);
            Back();
            scrollDown();
            Click(secondproduct);
            Click(secondproductoptions);
            Click(secondproductoptions2);
            Click(AddBasket);
            Click(MyBasket);
            kvkk();
            var basketPrice = driver.FindElement(By.CssSelector("div#newCheckout table:nth-child(6) div.priceArea span")).Text;
            var basketPrice2 = driver.FindElement(By.CssSelector("div#newCheckout table:nth-child(5) div.priceArea span")).Text;
            try
            {
                Assert.That(priceText, Is.EqualTo(basketPrice), priceText2, Is.EqualTo(basketPrice2));
                Click(BuyButton);
                LoginPage login = new LoginPage(driver);
                login.TypeUsername();
                login.TypePassword();
                login.ClickLoginButton();
            }
            catch (Exception)
            {
                Click(notEqual);
                Click(notEqual);
                driver.Navigate().GoToUrl("https://www.n11.com/");
            }
        }

        [Test]
        public void KategoridenUrunEkleme()
        {
            //Case elementleri
            By actionCategory = By.XPath("//*[@id='contentMain']/div/nav/ul/li[6]/a");
            By category = By.XPath("//*[@id='contentMain']/div/nav/ul/li[6]/div/ul/li[2]/a");
            By product = By.CssSelector("ul#filter-list > li:nth-child(1)");
            By productoption = By.XPath(".//*[@id = '772151561']/label[1]");
            By addBasket = By.CssSelector("#addToBasket");
            By myBasket = By.CssSelector("div#wrapper a.myBasket");
            By BuyButton = By.CssSelector("span#js-buyBtn");

            kategori(actionCategory,category);
            Click(product);
            //productOptions(productoption);
            Click(addBasket);
            Click(myBasket);
            kvkk();
            Click(BuyButton);
            LoginPage login = new LoginPage(driver);
            login.TypeUsername();
            login.TypePassword();
            login.ClickLoginButton();
        }

        //[Test]
        //public void TestMethod3()
        //{
        //    search();
        //    scrollDown();
        //    cssClick("#brand-klm-Kadın");
        //    cssClick("#brand-numara-38");
        //    cssClick("#p-390053319 .productName");
        //    productOptions(".//*[@id = '743015531']/option[3]");
        //    cssClick("div#contentProDetail a.btnAddBasket");
        //    cssClick("div#wrapper a.myBasket");
        //    kvkk();
        //    cssClick("span#js-buyBtn");
        //    login();
        //}

        //[Test]
        //public void TestMethod4()
        //{
        //    cssClick("#contentMain .categoryMenuTab ul > li:nth-child(3)");
        //    cssClick("#p-469727351 .productName");
        //    cssClick(".addBasketUnify");
        //    Back();
        //    Back();
        //    cssClick("#p-453514924 .productName");
        //    cssClick(".addBasketUnify");
        //    cssClick("div#wrapper a.myBasket");
        //    kvkk();
        //    cssClick("span#js-buyBtn");
        //    login();
        //}
    }
}
