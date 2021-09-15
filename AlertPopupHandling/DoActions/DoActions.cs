using AlertPopupHandling.AlertClass;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlertPopupHandling.DoActions
{
    public  class  DoActions : Base.BaseClass
    {
       public static void JS_Alert()
       {
            Alert alert = new Alert(driver);
            alert.jsAlert.Click();
            System.Threading.Thread.Sleep(2000);
            var alert_win = driver.SwitchTo().Alert();
            alert_win.Accept();
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine(alert.clickResult.Text);
            if (alert.clickResult.Text == "You successfully clicked an alert")
            {
                Console.WriteLine("Alert Text successful");
            }
       }
        public static void test_Confirm()
        {
            Alert alert = new Alert(driver);
            alert.jsConfirm.Click();
            System.Threading.Thread.Sleep(2000);
            var alert_win = driver.SwitchTo().Alert();
            alert_win.Accept();
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine(alert.clickonResult.Text);
            if (alert.clickonResult.Text == "You clicked: Ok") 
            {
                Console.WriteLine("Confirm Text Successful");
            }
        }
        public static void test_Dismiss()
        {
            Alert alert = new Alert(driver);
            alert.jsDismiss.Click();
            System.Threading.Thread.Sleep(2000);
            var alert_win = driver.SwitchTo().Alert();
            alert_win.Dismiss();
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine(alert.clickforResult.Text);
            if(alert.clickforResult.Text == "You clicked: Cancel")
            {
                Console.WriteLine("Dismiss Test Successful");
            }
        }
    }
}
