using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using Vtiger_Framework.Main_Folder.GenericUtility;

namespace Vtiger_Framework.Main_Folder.ObjectRepository.CampaignsRepo
{
    /// <summary>
    /// All the elements of create new campaign will be located here 
    /// </summary>
    [TestClass]

    public class CreatingNewCampaignPage
    {
        [FindsBy(How = How.XPath, Using = "//input[@name='campaignname']")] private IWebElement campaign_Name { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@type='radio' and @value='U']")] private IWebElement assignTo_User_radioBtn { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@type='radio' and @value='T']")] private IWebElement assignTo_group_radioBtn { get; set; }
        [FindsBy(How = How.Name, Using = "campaigntype")] private IWebElement campaignTypeList { get; set; }
        [FindsBy(How = How.Id, Using = "targetaudience")] private IWebElement targetAudienceTxtField { get; set; }
        [FindsBy(How = How.Id, Using = "sponsor")] private IWebElement sponsorTxtField { get; set; }
        [FindsBy(How = How.Id, Using = "numsent")] private IWebElement numsentTxtField { get; set; }
        [FindsBy(How = How.Name, Using = "campaignstatus")] private IWebElement campaignStatusList { get; set; }
        [FindsBy(How = How.Id, Using = "jscal_field_closingdate")] private IWebElement closeDateTxtField { get; set; }
        [FindsBy(How = How.Id, Using = "targetsize")] private IWebElement targetSize { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@class='crmButton small save']")] private IWebElement saveBtn { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@class='crmbutton small cancel']")] private IWebElement cancelBtn { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@name='expectedrevenue']")] private IWebElement ExptRevenueTextField { get; set; }

        public CreatingNewCampaignPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        public void CreateNewCampaign_Test(string campainName, string campaignType, string campaignStatus, string revenue, string closeDate)
        {
            campaign_Name.SendKeys(campainName);
            assignTo_User_radioBtn.Click();
            WebDriverUtility webAction = new WebDriverUtility();
            webAction.ListBox_SelectByValue(campaignTypeList, campaignType);
            webAction.ListBox_SelectByValue(campaignStatusList, campaignStatus);
            ExptRevenueTextField.SendKeys(revenue);
            closeDateTxtField.SendKeys(closeDate);
            saveBtn.Click();

        }
    }
}
