using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlertPopupHandling.AlertClass
{
    public class Alert
    {
        public Alert(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
        //To locate the webelement for the JSALERT 
        [FindsBy(How = How.CssSelector, Using = "button[onclick='jsAlert()']")]
        [CacheLookup]
        public IWebElement jsAlert;
/*
        [FindsBy(How = How.Id, Using = "result")]
        [CacheLookup]
        public IWebElement clickResult;*/
    
        [FindsBy(How = How.CssSelector, Using = "button[onclick = 'jsConfirm()']")]
        [CacheLookup]
        public IWebElement jsConfirm;

        [FindsBy(How = How.Id, Using = "result")]
        [CacheLookup]
        public IWebElement clickResult;
    }
}
