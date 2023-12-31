﻿using AventStack.ExtentReports.Reporter;
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

            //reading data fro excel
          // string campaignData = "G:\\TYSS\\C#\\Vtiger_Data.xlsx";

            //creating the new campaign
            string campaignName = "Mi Mobiles";
            string campaignType = "Advertisement";
            string campaignStatus = "Active";
            string revenue = "2000000";
            string closeDate = "10/20/2023";
            createCampaign.CreateNewCampaign_Test(campaignName, campaignType, campaignStatus, revenue, closeDate);
            string campaignNo = driver.FindElement(By.XPath("//td[text()='Campaign No']/following-sibling::td[@class='dvtCellInfo']")).Text;

            campaignHome.campaign_Link.Click();
            campaignNo = campaignNo.Trim();
            Console.WriteLine(campaignNo);


            string act_campaignName = driver.FindElement(By.XPath("//td[contains(text(),'" + campaignNo + "')]/following-sibling::td/a[@title='Campaigns']")).Text;
            act_campaignName= act_campaignName.Trim();
            CreateNewCampaign createcampaign = new CreateNewCampaign();
            createcampaign.Validation_Test( "Campaign Name", campaignName ,act_campaignName);


        }
        public  void Validation_Test(string validatationName, string expected, string actual)
        {
            string path = "C:\\Users\\Admin\\Source\\Repos\\Vtiger_Framework05\\Vtiger_Framework\\Reports\\";
            ExtentReports extent_Reports = new ExtentReports();
            ExtentHtmlReporter htmlReport = new ExtentHtmlReporter(path);
            extent_Reports.AttachReporter(htmlReport);
            ExtentTest test = extent_Reports.CreateTest("Create_New_Campaign");
            try
            {
                Assert.AreEqual(expected, actual);
                test.Pass(validatationName+" ValidationPass");
            }
            catch (Exception ex)
            {
                test.Fail(validatationName+" Validation fail");
            }
            extent_Reports.Flush();
            htmlReport.Stop();

        }
    }
}
