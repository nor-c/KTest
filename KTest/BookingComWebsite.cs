using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace KTest
{
    [TestFixture]
    public class BookingComWebsite

    {
        private IWebDriver driver;
        public string homeURL;
        


        [Test(Description = "Check Limerick Strand Hotel with Sauna filter")]
        public void LimerickStrandHotelSaunaCheck()
        {


            homeURL = "https://www.booking.com/";
            driver.Navigate().GoToUrl(homeURL);
            WebDriverWait wait = new WebDriverWait(driver, System.TimeSpan.FromSeconds(15));
            wait.Until(driver => driver.FindElement(By.XPath("//*[@id='ss']")));
            Thread.Sleep(3000);

            var cc = driver.FindElement(By.CssSelector("#onetrust-accept-btn-handler"));
            if (cc != null)
            {
                cc.Click();
            }

            IWebElement findCity = driver.FindElement(By.XPath("//*[@id='ss']"));

            findCity.SendKeys("Limerick");
            Thread.Sleep(3000);

            DateTime date = DateTime.Now.AddMonths(3);
            var checkIn = date.ToString("yyyy-MM-dd");
            var checkOut = date.AddDays(1).ToString("yyyy-MM-dd");

            driver.FindElement(By.XPath("//body/div[1]/div[1]/div[1]/div[2]/form[1]/div[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/span[1]")).Click();
            driver.FindElement(By.XPath("//body/div[1]/div[1]/div[1]/div[2]/form[1]/div[1]/div[2]/div[2]/div[1]/div[1]/div[2]/*[1]")).Click();
            driver.FindElement(By.XPath("//body/div[1]/div[1]/div[1]/div[2]/form[1]/div[1]/div[2]/div[2]/div[1]/div[1]/div[2]/*[1]")).Click();


            var locatorIn = By.CssSelector($".bui-calendar__date[data-date='{checkIn}']");
            var dateIn = wait.Until(ExpectedConditions.ElementToBeClickable(locatorIn));
            dateIn.Click();

            var locatorOut = By.CssSelector($".bui-calendar__date[data-date='{checkOut}']");
            var dateOut = wait.Until(ExpectedConditions.ElementToBeClickable(locatorOut));
            dateOut.Click();

            driver.FindElement(By.XPath("//label[@id='xp__guests__toggle']")).Click();
            driver.FindElement(By.XPath("//body/div[1]/div[1]/div[1]/div[2]/form[1]/div[1]/div[3]/div[2]/div[1]/div[1]/div[1]/div[1]/div[2]/span[1]"));


            driver.FindElement(By.XPath("//*[@id='frm']/div[1]/div[4]/div[2]/button")).Click();


            Thread.Sleep(1000);

            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollBy(0,1000)");


            //driver.FindElement(By.XPath("//a[@data-filters-item='popular_activities=54']")).Click();
            //driver.FindElement(By.XPath("//a[@data-filters-item='popular_activities=10']")).Click();
            //driver.FindElement(By.XPath("//a[@data-filters-item='popular_activities=54']")).Click();

            driver.FindElement(By.XPath("//a[@data-id='popular_activities-54']")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//a[@data-id='popular_activities-10']")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//a[@data-id='popular_activities-54']")).Click();
            Thread.Sleep(2000);

            IWebElement t = driver.FindElement(By.XPath("//span[contains(text(),'Limerick Strand Hotel')]"));
            //List<IWebElement> dateEl = new List<IWebElement>(driver.FindElements(By.ClassName("sr-hotel__name")));
            Thread.Sleep(1000);
            t.Click();

            Thread.Sleep(10000);
        }

        [Test(Description = "Check George Limerick Hotel with Sauna filter")]
        public void GeorgeLimerickHotelSaunaCheck()
        {


            homeURL = "https://www.booking.com/";
            driver.Navigate().GoToUrl(homeURL);
            WebDriverWait wait = new WebDriverWait(driver, System.TimeSpan.FromSeconds(15));
            wait.Until(driver => driver.FindElement(By.XPath("//*[@id='ss']")));
            Thread.Sleep(3000);

            var cc = driver.FindElement(By.CssSelector("#onetrust-accept-btn-handler"));
            if (cc != null)
            {
                cc.Click();
            }

            IWebElement findCity = driver.FindElement(By.XPath("//*[@id='ss']"));

            findCity.SendKeys("Limerick");
            Thread.Sleep(3000);

            DateTime date = DateTime.Now.AddMonths(3);
            var checkIn = date.ToString("yyyy-MM-dd");
            var checkOut = date.AddDays(1).ToString("yyyy-MM-dd");

            driver.FindElement(By.XPath("//body/div[1]/div[1]/div[1]/div[2]/form[1]/div[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/span[1]")).Click();
            driver.FindElement(By.XPath("//body/div[1]/div[1]/div[1]/div[2]/form[1]/div[1]/div[2]/div[2]/div[1]/div[1]/div[2]/*[1]")).Click();
            driver.FindElement(By.XPath("//body/div[1]/div[1]/div[1]/div[2]/form[1]/div[1]/div[2]/div[2]/div[1]/div[1]/div[2]/*[1]")).Click();


            var locatorIn = By.CssSelector($".bui-calendar__date[data-date='{checkIn}']");
            var dateIn = wait.Until(ExpectedConditions.ElementToBeClickable(locatorIn));
            dateIn.Click();

            var locatorOut = By.CssSelector($".bui-calendar__date[data-date='{checkOut}']");
            var dateOut = wait.Until(ExpectedConditions.ElementToBeClickable(locatorOut));
            dateOut.Click();

            driver.FindElement(By.XPath("//label[@id='xp__guests__toggle']")).Click();
            driver.FindElement(By.XPath("//body/div[1]/div[1]/div[1]/div[2]/form[1]/div[1]/div[3]/div[2]/div[1]/div[1]/div[1]/div[1]/div[2]/span[1]"));


            driver.FindElement(By.XPath("//*[@id='frm']/div[1]/div[4]/div[2]/button")).Click();


            Thread.Sleep(1000);

            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollBy(0,700)");


            //driver.FindElement(By.XPath("//a[@data-filters-item='popular_activities=54']")).Click();
            //driver.FindElement(By.XPath("//a[@data-filters-item='popular_activities=10']")).Click();
            //driver.FindElement(By.XPath("//a[@data-filters-item='popular_activities=54']")).Click();

            driver.FindElement(By.XPath("//a[@data-id='popular_activities-54']")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//a[@data-id='popular_activities-10']")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//a[@data-id='popular_activities-54']")).Click();
            Thread.Sleep(2000);

            driver.FindElement(By.XPath("//span[contains(text(),'George Limerick Hotel')]"));
        }

        [Test(Description = "Check The Savoy Hotel with 5 Stars filter")]
        public void TheSavoyHotel5StarsCheck()
        {


            homeURL = "https://www.booking.com/";
            driver.Navigate().GoToUrl(homeURL);
            WebDriverWait wait = new WebDriverWait(driver, System.TimeSpan.FromSeconds(15));
            wait.Until(driver => driver.FindElement(By.XPath("//*[@id='ss']")));
            Thread.Sleep(3000);

            var cc = driver.FindElement(By.CssSelector("#onetrust-accept-btn-handler"));
            if (cc != null)
            {
                cc.Click();
            }

            IWebElement findCity = driver.FindElement(By.XPath("//*[@id='ss']"));

            findCity.SendKeys("Limerick");
            Thread.Sleep(3000);

            DateTime date = DateTime.Now.AddMonths(3);
            var checkIn = date.ToString("yyyy-MM-dd");
            var checkOut = date.AddDays(1).ToString("yyyy-MM-dd");

            driver.FindElement(By.XPath("//body/div[1]/div[1]/div[1]/div[2]/form[1]/div[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/span[1]")).Click();
            driver.FindElement(By.XPath("//body/div[1]/div[1]/div[1]/div[2]/form[1]/div[1]/div[2]/div[2]/div[1]/div[1]/div[2]/*[1]")).Click();
            driver.FindElement(By.XPath("//body/div[1]/div[1]/div[1]/div[2]/form[1]/div[1]/div[2]/div[2]/div[1]/div[1]/div[2]/*[1]")).Click();


            var locatorIn = By.CssSelector($".bui-calendar__date[data-date='{checkIn}']");
            var dateIn = wait.Until(ExpectedConditions.ElementToBeClickable(locatorIn));
            dateIn.Click();

            var locatorOut = By.CssSelector($".bui-calendar__date[data-date='{checkOut}']");
            var dateOut = wait.Until(ExpectedConditions.ElementToBeClickable(locatorOut));
            dateOut.Click();

            driver.FindElement(By.XPath("//label[@id='xp__guests__toggle']")).Click();
            driver.FindElement(By.XPath("//body/div[1]/div[1]/div[1]/div[2]/form[1]/div[1]/div[3]/div[2]/div[1]/div[1]/div[1]/div[1]/div[2]/span[1]"));


            driver.FindElement(By.XPath("//*[@id='frm']/div[1]/div[4]/div[2]/button")).Click();


            Thread.Sleep(1000);

            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollBy(0,700)");

            driver.FindElement(By.XPath("//a[@data-id='class-5']")).Click();
            Thread.Sleep(2000);


            IWebElement t = driver.FindElement(By.XPath("//span[contains(text(),'The Savoy Hotel')]"));

            Thread.Sleep(3000);
            t.Click();

            Thread.Sleep(10000);
        }

        [Test(Description = "Check George Limerick Hotel with 5 Stars filter")]
        public void GeorgeLimerickHotel5StarsCheck()
        {


            homeURL = "https://www.booking.com/";
            driver.Navigate().GoToUrl(homeURL);
            WebDriverWait wait = new WebDriverWait(driver, System.TimeSpan.FromSeconds(15));
            wait.Until(driver => driver.FindElement(By.XPath("//*[@id='ss']")));
            Thread.Sleep(3000);

            var cc = driver.FindElement(By.CssSelector("#onetrust-accept-btn-handler"));
            if (cc != null)
            {
                cc.Click();
            }

            IWebElement findCity = driver.FindElement(By.XPath("//*[@id='ss']"));

            findCity.SendKeys("Limerick");
            Thread.Sleep(3000);

            DateTime date = DateTime.Now.AddMonths(3);
            var checkIn = date.ToString("yyyy-MM-dd");
            var checkOut = date.AddDays(1).ToString("yyyy-MM-dd");

            driver.FindElement(By.XPath("//body/div[1]/div[1]/div[1]/div[2]/form[1]/div[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/span[1]")).Click();
            driver.FindElement(By.XPath("//body/div[1]/div[1]/div[1]/div[2]/form[1]/div[1]/div[2]/div[2]/div[1]/div[1]/div[2]/*[1]")).Click();
            driver.FindElement(By.XPath("//body/div[1]/div[1]/div[1]/div[2]/form[1]/div[1]/div[2]/div[2]/div[1]/div[1]/div[2]/*[1]")).Click();


            var locatorIn = By.CssSelector($".bui-calendar__date[data-date='{checkIn}']");
            var dateIn = wait.Until(ExpectedConditions.ElementToBeClickable(locatorIn));
            dateIn.Click();

            var locatorOut = By.CssSelector($".bui-calendar__date[data-date='{checkOut}']");
            var dateOut = wait.Until(ExpectedConditions.ElementToBeClickable(locatorOut));
            dateOut.Click();

            driver.FindElement(By.XPath("//label[@id='xp__guests__toggle']")).Click();
            driver.FindElement(By.XPath("//body/div[1]/div[1]/div[1]/div[2]/form[1]/div[1]/div[3]/div[2]/div[1]/div[1]/div[1]/div[1]/div[2]/span[1]"));


            driver.FindElement(By.XPath("//*[@id='frm']/div[1]/div[4]/div[2]/button")).Click();


            Thread.Sleep(1000);

            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollBy(0,700)");

            driver.FindElement(By.XPath("//a[@data-id='class-5']")).Click();
            Thread.Sleep(5000);

            driver.FindElement(By.XPath("//span[contains(text(),'George Limerick Hotel')]"));
        }


        [TearDown]
        public void TearDownTest()
        {
            driver.Quit();
        }


        [SetUp]
        public void SetupTest()
        {
            homeURL = "https://www.booking.com/";
            //driver = new ChromeDriver(@"your local path of chromedriver.exe");
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

        }


    }
}
