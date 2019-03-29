using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCSharpProject.com.chsarp.ServiceLayer
{
    enum MONTH { January, February, March, April, May, June, July, August, September, October, November, December };

    public class WrapperClass : LoadableComponent<WrapperClass>
    {
        BaseTestClass objBaseTestClass;
        public WrapperClass(BaseTestClass objBaseTestClass)
        {
            this.objBaseTestClass = objBaseTestClass;
        }
      
        public Boolean ClickByJavaScriptExecutor(By locator)
        {
            try
            {
                objBaseTestClass.GetObjIJavaScriptExecutor().ExecuteScript("arguments[0].click(true)", objBaseTestClass.GetObjdriver().FindElement(locator));
                return true;
            }
            catch (Exception exception)
            {
                Console.WriteLine("Got Exception : " + exception.Message);
                return false;
            }
        }
        public Boolean isElementDisplayed(By locator)
        {
            try
            {
                return objBaseTestClass.GetObjdriver().FindElement(locator).Displayed;
            }
            catch (Exception exception)
            {
                Console.WriteLine("Got Exception : " + exception.Message);
                return false;
            }
        }
        public Boolean IsCheckBoxChecked(By locator)
        {
            try
            {
                return objBaseTestClass.GetObjdriver().FindElement(locator).Selected;
            }
            catch (Exception exception)
            {
                Console.WriteLine("Got Exception : " + exception.Message);
                return false;
            }
        }
        public Boolean NavigateToUrl(String url)
        {
            try
            {
               
                objBaseTestClass.GetObjdriver().Navigate().GoToUrl(url);
                objBaseTestClass.GetObjUtilityClass().wait(2000);
                return true;
            }
            catch (Exception exception)
            {
                Console.WriteLine("Got Exception : " + exception.Message);
                return false;
            }
        }
        public Boolean WriteDataToFile(String[] strArray,String FileName)
        {
            try
            {
                System.IO.File.WriteAllLines(@"F:\Neha\CSharp\SeleniumCSharpProject\SeleniumCSharpProject\Data\"+ FileName + ".txt", strArray);
                return true;
            }
            catch (Exception exception)
            {
                Console.WriteLine("Got Exception : " + exception.Message);
                return false;
            }
            
        }

        public Boolean setText(By locator, String text)
        {
            try
            {
                objBaseTestClass.GetObjdriver().FindElement(locator).SendKeys(text);
                return true;
            }
            catch (Exception exception)
            {
                Console.WriteLine("Got Exception : " + exception.Message);
                return false;
            }
        }

        public Boolean ScrollToView(By Locator)
        {
            try
            {
                IWebElement element = objBaseTestClass.GetObjdriver().FindElement(Locator);
                objBaseTestClass.GetObjIJavaScriptExecutor().ExecuteScript("arguments[0].scrollIntoView(true)", element);
                return true;
            }
            catch (Exception exception)
            {
                Console.WriteLine("Got Exception : " + exception.Message);
                return false;
            }

        }
        public Boolean ScrollToView(IWebElement element)
        {
            try
            {
                objBaseTestClass.GetObjIJavaScriptExecutor().ExecuteScript("arguments[0].scrollIntoView(true)", element);
                return true;
            }
            catch (Exception exception)
            {
                Console.WriteLine("Got Exception : " + exception.Message);
                return false;
            }

        }
        public Boolean ScrollToViewDown()
        {

            try
            {
                objBaseTestClass.GetObjIJavaScriptExecutor().ExecuteScript("window.scrollTo(0, document.body.scrollHeight); return document.body.scrollHeight;");
                return true;
            }
            catch (Exception exception)
            {
                Console.WriteLine("Got Exception : " + exception.Message);
                return false;
            }
        }
        public Boolean ScrollToViewUp()
        {

            try
            {
                objBaseTestClass.GetObjIJavaScriptExecutor().ExecuteScript("window.scrollTo(0, -document.body.scrollHeight); return document.body.scrollHeight;");
                return true;
            }
            catch (Exception exception)
            {
                Console.WriteLine("Got Exception : " + exception.Message);
                return false;
            }
        }

        public IWebElement CheckElementToBeClickable(By Locator)
        {
            IWebElement element = objBaseTestClass.GetObjWebDriverWait().Until(ExpectedConditions.ElementToBeClickable(Locator));
            return element;
        }
        public Boolean clickOnElement(By Locator)
        {
            try
            {
                IWebElement element = objBaseTestClass.GetObjWebDriverWait().Until(ExpectedConditions.ElementToBeClickable(Locator));
                element.Click();
                return true;
            }
            catch (Exception exception)
            {
                Console.WriteLine("Got Exception : " + exception.Message);
                return false;
            }

        }

        public Boolean clickOnElement(IWebElement element)
        {
            try
            {
                element.Click();
                return true;
            }
            catch (Exception exception)
            {
                Console.WriteLine("Got Exception : " + exception.Message);
                return false;
            }

        }


        public Boolean selectDropDownValue(By Locator, String strValue)
        {
            try
            {
                SelectElement selectele = new SelectElement(objBaseTestClass.GetObjdriver().FindElement(Locator));
                selectele.SelectByValue(strValue);

                return true;
            }
            catch (Exception exception)
            {

                Console.WriteLine("Got Exception : " + exception.Message);
                return false;
            }

        }
        public Boolean selectDropDownByIndex(By Locator, int Index)
        {
            try
            {
                SelectElement selectele = new SelectElement(objBaseTestClass.GetObjdriver().FindElement(Locator));
                selectele.SelectByIndex(Index);
                return true;
            }
            catch (Exception exception)
            {

                Console.WriteLine("Got Exception : " + exception.Message);
                return false;
            }

        }
        public void selectDate(String strDate)
        {
            By arrowNext = By.XPath("//div[@class='monthBlock last']//a[@class='nextMonth ']");
            By locMonth = By.XPath("//div[@class='monthBlock first']//div[@class='title']");

            DateTime locDate = DateTime.ParseExact(strDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            int day = locDate.Day; Console.WriteLine("Day" + day);
            int month = locDate.Month; Console.WriteLine("Month" + month);
            int year = locDate.Year; Console.WriteLine("year" + year);
            MONTH MonthName = (MONTH)(month - 1); Console.WriteLine("Month name " + MonthName.ToString());
            String currentMonth = objBaseTestClass.GetObjdriver().FindElement(locMonth).Text;
            while (!currentMonth.Contains(MonthName.ToString()) && !currentMonth.Contains(year.ToString()))
            {
                this.clickOnElement(arrowNext);
                objBaseTestClass.GetObjdriver().FindElement(arrowNext).Click();
                Console.WriteLine("Click on next  arrow");
                break;
            }
            By date = By.XPath("//div[@class='monthBlock first']//div[@class='title']/parent::div/following-sibling::table/tbody/tr/td/a[text()='" + day + "']");
            this.clickOnElement(date);
        }

        public IWebElement selectFlights(By Locator)
        {
            String strData;
            var list = objBaseTestClass.GetObjdriver().FindElements(Locator);
            int index = 0;
            foreach (IWebElement ele in list)
            {
                strData = ele.Text;
                if (strData.Contains("SpiceJet"))
                {
                    Console.WriteLine("SpiceJet");
                    break;
                }
                if (strData.Contains("Air India"))
                {
                    Console.WriteLine("Air India");
                    break;
                }
                if (strData.Contains("GoAir "))
                {
                    Console.WriteLine("GoAir");
                    break;
                }
                if (strData.Contains("IndiGo"))
                {
                    Console.WriteLine("IndiGo");
                    break;
                }
            }
            Console.WriteLine("index" + index);
            return list.ElementAt(index);

        }
        public Boolean MouseHover(By Locator)
        {
            Actions action = new Actions(objBaseTestClass.GetObjdriver());
            try
            {
                IWebElement element = objBaseTestClass.GetObjdriver().FindElement(Locator);
                action.MoveToElement(element).Build().Perform();
                return true;
            }catch(Exception e)
            {
                Console.WriteLine("Got Exception" + e.Message);
                return false;
            }

        }
        public Boolean MouseHover(IWebElement element)
        {
            Actions action = new Actions(objBaseTestClass.GetObjdriver());
            try
            {
                action.MoveToElement(element).Build().Perform();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Got Exception" + e.Message);
                return false;
            }

        }
        public Boolean SwitchToIframe(By Locator)
        {
            try
            {
             objBaseTestClass.GetObjWebDriverWait().Until(ExpectedConditions.FrameToBeAvailableAndSwitchToIt(Locator));
             return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Got Exception" + e.Message);
                return false;
            }

        }
        public Boolean SwitchToSecondWindow()
        {
            try
            {
                var strWindow = objBaseTestClass.GetObjdriver().WindowHandles;
                String strFirstWindow = objBaseTestClass.GetObjdriver().CurrentWindowHandle;
                foreach(String strWindowName in strWindow)
                {
                    if(!strWindowName.Equals(strFirstWindow))
                    {
                        objBaseTestClass.GetObjdriver().SwitchTo().Window(strWindowName);
                    }
                }
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Got Exception" + e.Message);
                return false;
            }

        }
        public Boolean SwitchToParentIframe()
        {
            try
            {
                objBaseTestClass.GetObjdriver().SwitchTo().ParentFrame();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Got Exception" + e.Message);
                return false;
            }

        }
        public Boolean SwitchToDefaultIframe()
        {
            try
            {
                objBaseTestClass.GetObjdriver().SwitchTo().DefaultContent();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Got Exception" + e.Message);
                return false;
            }

        }
        protected override bool EvaluateLoadedStatus()
        {
            throw new NotImplementedException();
        }

        protected override void ExecuteLoad()
        {
            throw new NotImplementedException();
        }

        public string GetText(By lnkCart)
        {
            try
            {
                return objBaseTestClass.GetObjdriver().FindElement(lnkCart).Text;
                
            }
            catch (Exception e)
            {
                Console.WriteLine("Got Exception" + e.Message);
                return null;
            }
        }
    }
}
