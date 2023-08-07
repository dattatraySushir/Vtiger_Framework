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
    public class CreateNewCampaign //: BaseClass
    {
        [TestMethod]
        [Owner("Thejas")]
        public void Create_New_campaign()
        {
            IWebDriver driver=new ChromeDriver();
            LoginPage Login = new LoginPage(driver);
            VTigerHomePage home = new VTigerHomePage(driver);
            WebDriverUtility webaction = new WebDriverUtility();
            webaction.WaitImplicitly(driver);
            webaction.MaximiseWindow(driver);
            driver.Navigate().GoToUrl("http://localhost:8888/");
            Login.Login();


          
            home.MoreDropDown();
            home.CampaignLink();
           

            
            Thread.Sleep(2000);


        }
    }
}
