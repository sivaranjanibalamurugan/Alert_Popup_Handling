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
    public  class BaseClass
    {
        
        public static  IWebDriver driver;

        [SetUp]
        public void start_Browser()
        {
            //local selenium webdriver
            driver = new ChromeDriver();
           driver.Manage().Window.Maximize();
            System.Threading.Thread.Sleep(200);
           driver.Url = "https://the-internet.herokuapp.com/javascript_alerts";
      }
        [TearDown]
        public  void close_Browser()
        {
            driver.Quit();
        }

    }
}
