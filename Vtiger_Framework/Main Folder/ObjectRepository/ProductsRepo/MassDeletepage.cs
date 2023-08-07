using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtiger_Framework.Main_Folder.ObjectRepository.ProductsRepo
{
    internal class MassDeletepage
    {
        [FindsBy(How = How.XPath, Using = "//a[.='Products']")]
        public IWebElement productslink; //click on Products link
        [FindsBy(How = How.XPath, Using = "//input[@name='selectall']")]
        public IWebElement selectallcheckbox; //select the checkbox
        [FindsBy(How = How.XPath, Using = "//input[@value='Delete' and @fdprocessedid='ymc8cj']")]
        public IWebElement deletebtn; //click on delete button

        public Massdeletepage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        public void Productslink()
        {
            productslink.Click();
        }

        public void Selectallcheckbox()
        {
            selectallcheckbox.Click();
        }

        public void Massdelete()
        {
            deletebtn.Click();
        }
    }
}
