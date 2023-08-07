using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vtiger_Framework.Main_Folder.ObjectRepository.CampaignsRepo
{
    /// <summary>
    /// All the eklements of Campaign home page located here in this class
    /// </summary>
    public class CampaignsHomePage
    {

        [FindsBy(How = How.XPath, Using = "//img[@alt='Create Campaign...']")] private IWebElement add_ymbol { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[@class='hdrLink']")] private IWebElement campaignLink;//{ get; set; }
        public IWebElement campaign_Link
        {
            get { return campaignLink; }
            set { campaignLink = value; }

        }
        public CampaignsHomePage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        public void click_on_add()
        {
            add_ymbol.Click();
        }


    }
}
