using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Vtiger_Framework.Main_Folder.GenericUtility;
using Vtiger_Framework.Main_Folder.ObjectRepository.CampaignsRepo;
using Vtiger_Framework.Main_Folder.ObjectRepository.LoginRepo;

namespace Vtiger_Framework.Test_Scripts.Test.CampaignsTest
{
    [TestClass]
    public class CreateNewCampaign : BaseClass
    {
        [TestMethod]
        [Owner("Thejas")]
        public void Create_New_campaign()
        {
            // IWebDriver driver = new ChromeDriver();
            LoginPage Login = new LoginPage(driver);
            VTigerHomePage home = new VTigerHomePage(driver);
            CampaignsHomePage campaignHome = new CampaignsHomePage(driver);
            CreatingNewCampaignPage createCampaign = new CreatingNewCampaignPage(driver);
            WebDriverUtility webaction = new WebDriverUtility();
            webaction.WaitImplicitly(driver);
            webaction.MaximiseWindow(driver);
            driver.Navigate().GoToUrl("http://localhost:8888/");
            Login.Login();
            home.MoreDropDown();
            home.CampaignLink();
            campaignHome.click_on_add();

            //creating the new campaign
            string campaignName = "Mi Mobiles";
            string campaignType = "Advertisement";
            string campaignStatus = "Active";
            string revenue = "2000000";
            string closeDate = "10/20/2023";
            createCampaign.CreateNewCampaign_Test(campaignName, campaignType, campaignStatus, revenue, closeDate);
            string campaignNo = driver.FindElement(By.XPath("//td[text()='Campaign No']/following-sibling::td[@class='dvtCellInfo']")).Text;

            campaignHome.campaign_Link.Click();
            Console.WriteLine(campaignNo);


            string act_campaignName = driver.FindElement(By.XPath("//td[contains(text(),'" + campaignNo + "')]/following-sibling::td/a[@title='Campaigns']")).Text;

            //td[contains(text(),'CAM11 ')]/following-sibling::td/a[@title='Campaigns']
            Console.WriteLine(act_campaignName);


            //validating and creating extent report.
            string path = "C:\\Users\\Admin\\Source\\Repos\\Vtiger_Framework_new\\Vtiger_Framework\\Results\\Extent_Report_Thejas\\";
            ExtentReports extentReports = new ExtentReports();
            ExtentHtmlReporter htmlReport = new ExtentHtmlReporter(path);
            extentReports.AttachReporter(htmlReport);
            ExtentTest test = extentReports.CreateTest("Create_New_Campaign");


            Thread.Sleep(2000);


        }
    }
}
