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
        [Test,Order(2)]
        public void test_Dismiss()
        {
            DoActions.DoActions.test_Dismiss();
        }
        [Test,Order(3)]
        public void test_Promt()
        {
            DoActions.DoActions.test_Promt();
        }
    }
}
