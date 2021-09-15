/*Project = Popup Handling
 * created by = SivaRanjani B
 * dated on = 13/09/21
 */
using Nest;
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
            DoActions.DoActions.JS_Alert();

        }
        [Test,Order(1)]
        public void test_confirm()
        {
            DoActions.DoActions.test_Confirm();
        }
    }
}
