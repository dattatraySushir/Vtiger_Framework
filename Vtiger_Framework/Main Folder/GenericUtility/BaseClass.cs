using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vtiger_Framework.Main_Folder.ObjectRepository.HomeRepo;

namespace Vtiger_Framework.Main_Folder.GenericUtility
{
    /// <summary>
    /// This class is going to perform the constant and common activity of login.
    /// </summary>
    public class BaseClass
    {
        public IWebDriver driver;
        public static ExtentReports extentReports;
        public static ExtentHtmlReporter extentHtmlReporter;
        public static TestContext TestContext;
        public static ExtentTest extentTest;
        public TestContext test_context
        {
            get { return TestContext; }
            set { TestContext = value; }
        }

        /// <summary>
        /// This method is used to get or generate the reports from the every execution.
        /// </summary>
        /// <param name="_testcontext"></param>
        [AssemblyInitialize]
        [Owner("Datta")]
        public static void AssemblyInitialize(TestContext _testcontext) 
        {
            TestContext = _testcontext;
            extentReports = new ExtentReports();
            extentHtmlReporter = new ExtentHtmlReporter(CommonData.reportspath);
            extentReports.AddSystemInfo("Organisation" , "Tyss");
            extentReports.AttachReporter(extentHtmlReporter);
        }
        [AssemblyCleanup]
        [Owner("Datta")]
        public static void AssemblyCleanup()
        {
            extentReports.Flush();
            extentHtmlReporter.Stop();
        }
        /// <summary>
        /// This test initialise is use to open the browser.
        /// </summary>
        [TestInitialize]
        [Owner("Datta")]
        
        public void OpenBrowser()
        {
            //  test_context =TestContext;
            /* 
             if (TestContext.Properties["Browser"].Equals("Chrome"))
             {
                 driver=new ChromeDriver();
             }
             else if (TestContext.Properties["Browser"].Equals("Firefox"))
             {
                 driver=new FirefoxDriver();
             }
             else if (TestContext.Properties["Browser"].Equals("Edge"))
             {
                 driver=new EdgeDriver();
             }
             else
             {
                 driver= new ChromeDriver();
                 
             }*/
            driver = new ChromeDriver();
            driver.Url = CommonData.url;
            WebDriverUtility webDriverUtility = new WebDriverUtility();
            webDriverUtility.MaximiseWindow(driver);
            webDriverUtility.WaitImplicitly(driver);


        }
        /// <summary>
        /// This test cleanup is use to close the browser and dispose the driver reference.
        /// </summary>
        [TestCleanup]
        public void CloseBrowser()
        {
            
            driver.Close();
            driver.Dispose();
        }
    }
}
