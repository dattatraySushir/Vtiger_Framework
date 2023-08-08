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
    internal class CreateProductpage 
    {
        [FindsBy(How = How.XPath, Using = "//a[.='Products']")]
        public IWebElement productslink; //click on products link
        [FindsBy(How = How.XPath, Using = "//img[@title='Create Product...']")]
        public IWebElement createproductbtn; //click on create productbutton
        [FindsBy(How = How.Name, Using = "productname")]
        public IWebElement productnametxt;//enter product name
        [FindsBy(How = How.XPath, Using = "//select[@name='productcategory']")]
        public IWebElement productcategorydropdown; //select category
        [FindsBy(How = How.Id, Using = "qtyinstock")]
        public IWebElement stockquantitytxt; //enter quantity available stocks
        [FindsBy(How = How.Id, Using = "commissionrate")]
        public IWebElement commissionratetext;
        [FindsBy(How = How.Id, Using = "qty_per_unit")]
        public IWebElement unitqtytext; //enter quantity
        [FindsBy(How = How.Id, Using = "unit_price")]
        public IWebElement unitpricetxt; //enter price of a unit
        [FindsBy(How = How.XPath, Using = "//input[@title='Save [Alt+S]' and @fdprocessedid='4lvaer']")]
        public IWebElement savebtn; //click on save button
        [FindsBy(How = How.XPath, Using = "//input[@title='Cancel [Alt+X]' and @fdprocessedid='uiewai']")]
        public IWebElement cancelbtn; //click on cancel button

        public CreateProductpage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        public void Productlink()
        {
            productslink.Click();
        }

        public void Createproduct()
        {
            createproductbtn.Click();
        }

        public void Productname(string productname)
        {
            productnametxt.SendKeys(productname);
        }

        public void Productcategory()
        {

            productcategorydropdown.Click();
        }

        public void Unitprice(string price)
        {
            unitpricetxt.SendKeys(price);
        }

        public void Commissionrate(string commissionrate)
        {
            commissionratetext.SendKeys(commissionrate);
        }

        public void Quantityperunit(string unitqty)
        {
            unitqtytext.SendKeys(unitqty);
        }
        public void StockQuantity(string stockquantity)
        {
            stockquantitytxt.SendKeys(stockquantity);
        }

        public void Save()
        {
            savebtn.Click();
        }

    }
}
