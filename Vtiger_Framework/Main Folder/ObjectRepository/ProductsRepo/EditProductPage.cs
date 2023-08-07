using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Vtiger_Framework.Main_Folder.ObjectRepository.ProductsRepo
{
    internal class EditProductPage
    {
        [FindsBy(How = How.XPath, Using = "//a[.='Products']")]
        public IWebElement productslink; //click on Products link
        [FindsBy(How=How.Name,Using = "search_text")]
        public IWebElement searchproducttext; //enter product number which you want to search
        [FindsBy(How=How.XPath,Using = "//input[@value=' Search Now ' and @name='submit']")]
        public IWebElement searchproduct; //click on search now
        [FindsBy(How=How.XPath,Using = "//a[.='edit']")]
        public IWebElement editlink; //click on edit link
        [FindsBy(How = How.Id, Using = "unit_price")]
        public IWebElement unitpricetxt; //enter price of a unit
        [FindsBy(How = How.Id, Using = "qtyinstock")]
        public IWebElement quantitytxt; //enter quantity available stocks
        [FindsBy(How = How.Id, Using = "commissionrate")]
        public IWebElement commissionratetext;
        [FindsBy(How = How.Id, Using = "qty_per_unit")]
        public IWebElement qtytext; //enter quantity

        public EditProductPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
      
        public void Productslink()
        {
            productslink.Click();
        }

        public void SearchProduct(string productnum)
        {
            searchproducttext.SendKeys(productnum);
        }

        public void Searchproduct()
        {
            searchproduct.Click();
        }
        public void Unitprice(string price)
        {
            unitpricetxt.SendKeys(price);
        }

        public void Editlink()
        {
            editlink.Click();
        }
    }
}
