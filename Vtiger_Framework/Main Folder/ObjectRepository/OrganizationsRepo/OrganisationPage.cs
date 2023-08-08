using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtiger_Framework.Main_Folder.ObjectRepository.OrganizationsRepo
{
    public class OrgPage
    {
        [FindsBy(How = How.XPath, Using = "//img[@title='Create Organization...']")]
        private IWebElement createOrg;
       
    }
}
