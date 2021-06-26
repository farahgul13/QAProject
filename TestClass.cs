using System;
using System.Configuration;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;

namespace QAProject
{
    [TestClass]
    public class TestClass
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        public void TestHuman()
        {
            
            Human.Walk("Farah walking");
        }
        [TestMethod]
        [DataSource ("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "language", DataAccessMethod.Sequential)]
        public void TestChangeLanguageChromeBrowserUsingXML()
        {
           
            
            //ChromeOptions options = new ChromeOptions();

            //options.AddArguments(TestContext.DataRow["Fn"].ToString());
            //options.AddArguments("--lang=en-US");

            ChromeDriver driver = new ChromeDriver()
            {
                Url = "http://www.google.com"
            };
            string en = TestContext.DataRow["en"].ToString();
            string browser = ConfigurationManager.AppSettings["Browser"];
            MessageBox.Show(browser);

        }

        [TestMethod]
        public void FinnishLanguage()
        {
            string lang = ConfigurationManager.AppSettings["language1"];
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--lang="+lang);
            ChromeDriver driver = new ChromeDriver(options)
            {
                Url = "http://www.google.com"
            };

        }
    }
}
