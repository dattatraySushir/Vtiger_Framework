using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtiger_Framework.Main_Folder.ObjectRepository.ProductsRepo
{
    internal class DeleteProductpage
    {
        [FindsBy(How = How.XPath, Using = "//a[.='Products']")]
        public IWebElement productslink; //click on Products link
        [FindsBy(How = How.Name, Using = "search_text")]
        public IWebElement searchproducttext; //enter product number which you want to search
        [FindsBy(How = How.XPath, Using = "//input[@value=' Search Now ' and @name='submit']")]
        public IWebElement searchproduct; //click on search now
        [FindsBy(How = How.XPath, Using = "//a[.='del']")]
        public IWebElement Deleteproduct;

        public DeleteProductpage(IWebDriver driver)
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

        public void DeleteProduct()
        {
            Deleteproduct.Click();
        }
    }
}
