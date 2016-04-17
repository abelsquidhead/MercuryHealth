//using Microsoft.VisualStudio.TestTools.UITesting;

//namespace MercuryHEalth.CodedUITests.Pages
//{
//    public  class MyMetricsPage
//    {
//        private BrowserWindow _browser;

//        public MyMetricsPage(BrowserWindow _browser)
//        {
//            this._browser = _browser;
//        }
//    }
//}


using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MercuryHEalth.CodedUITests.Pages
{
    public class MyMetricsPage : BasePage
    {
        public MyMetricsPage(BrowserWindow browser)
        {
            _browser = browser;
        }

        #region Verifications
        public MyMetricsPage VerifyMyMetricsPageReached()
        {
            try
            {
                var createNewLink = new HtmlHyperlink(_browser);
                createNewLink.SearchProperties.Add(HtmlHyperlink.PropertyNames.InnerText, "CreateNew");
                createNewLink.SearchProperties.Add(HtmlHyperlink.PropertyNames.AbsolutePath, "/MyMetricsPage/Create");
                createNewLink.Find();
            }
            catch (Exception e)
            {
                Assert.Fail("Could not find create new link and verify my metrics page reached: " + e.Message);
            }
            return this;


        }
        #endregion
    }
}