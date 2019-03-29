using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCSharpProject.com.chsarp.ServiceLayer
{
    public class BaseTestClass
    {
        private IWebDriver objIWebDriver;
        private WebDriverWait objWebDriverWait;
        private IJavaScriptExecutor objIJavaScriptExecutor;
        private WrapperClass objWrapperClass;
        private UtilityClass objUtilityClass;
        public void Initialization()
        {
            objIWebDriver = new ChromeDriver();
            objIWebDriver.Manage().Window.Maximize();
            
            objIWebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);
            objIWebDriver.Url = "http://www.firstcry.com";
            objWebDriverWait = new WebDriverWait(objIWebDriver, TimeSpan.FromSeconds(50));
            objIJavaScriptExecutor = objIWebDriver as IJavaScriptExecutor;
            objWrapperClass = new WrapperClass(this);
            objUtilityClass = new UtilityClass(this);
        }

        public IWebDriver GetObjdriver()
        {
            return objIWebDriver;
        }
        public WebDriverWait GetObjWebDriverWait()
        {
            return objWebDriverWait;
        }
        public IJavaScriptExecutor GetObjIJavaScriptExecutor()
        {
            return objIJavaScriptExecutor;
        }
        public WrapperClass GetObjWrapperClass()
        {
            return objWrapperClass;
        }
        public UtilityClass GetObjUtilityClass()
        {
            return objUtilityClass;
        }
        public void TearDown()
        {
            objIWebDriver.Quit();
        }
       
    }

}
