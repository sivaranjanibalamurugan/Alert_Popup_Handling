
/*Project = Popup Handling
 * created by = SivaRanjani B
 * dated on = 13/09/21
 */
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace AlertPopupHandling
{
    public class Tests : Base.BaseClass
    {
        [Test, Order(0)]
        public void test_alert()
        {
            string button_xpath = "//button[.='Click for JS Alert']";
            var expectedAlertText = "I am a JS Alert";

            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(20));
            driver.Url = testurl;
            System.Threading.Thread.Sleep(2000);
            IWebElement alertbutton = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath(button_xpath)));

            System.Threading.Thread.Sleep(2000);
            alertbutton.Click();

            var alert_win = driver.SwitchTo().Alert();
            Assert.AreEqual(expectedAlertText, alert_win.Text);
            System.Threading.Thread.Sleep(2000);
            alert_win.Accept();

            var clickResult = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("result")));
            Console.WriteLine(clickResult.Text);

            if (clickResult.Text == "You successfully clicked an alert")
            {
                Console.WriteLine("Alert Text successful");
            }
        }

    }
}