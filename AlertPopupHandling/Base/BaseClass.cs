/*Project = Popup Handling
 * created by = SivaRanjani B
 * dated on = 13/09/21
 */

using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlertPopupHandling.Base
{
    public class BaseClass
    {
        public string testurl = "https://the-internet.herokuapp.com/javascript_alerts";
        public IWebDriver driver;

      [SetUp]
      public void start_Browser()
      {
            
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("Start-Maximized");
            options.AddArgument("headless");

            //local selenium webdriver
            driver = new ChromeDriver();
           driver.Manage().Window.Maximize();
            System.Threading.Thread.Sleep(200);
      }
        [TearDown]
        public void close_Browser()
        {
            driver.Quit();
        }

    }
}
