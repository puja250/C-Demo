using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumCSharpProject.com.chsarp.ServiceLayer
{
    public class FirstCryPage
    {
        BaseTestClass objBaseTestClass;
        int RandomNo;
        int RandomNo1;
        public FirstCryPage(BaseTestClass objBaseTestClass)
        {
            this.objBaseTestClass = objBaseTestClass;
        }
        By lnkByBertificate = By.XPath(
            "//a[@href='/firstcry_gift_certificate?ref2=menu_dd_bdaygifts']//img[@title='Buy a Gift Certificate']");
        By inpName = By.Id("txtRecepientName");
        By inpEmailId = By.Id("txtEmailId");
        By inpMessage = By.Id("txtMessage");
        By inpGiftFrom = By.Id("txtGiftFrom");
        By drpSelectAmount = By.XPath("//div[contains(text(),'Select Amount:')]//following-sibling::div//select");
        By btnGiftNow = By.XPath("//div[@class='right fl_l']//input[@value='GIFT NOW']");
        By lnkContinueShopping = By.XPath("//div[@class='sc_cs rgt']//span[contains(text(),'Continue Shopping')]");
        By bottomMenubar = By.XPath(
                "//div[@class='sticky-menu-footer submenu1-11']//ul//li[contains(text(),'TOP BRANDS:')]//following-sibling::li//a");
        By lnkClearAll = By.XPath("//span[@class='ftr_clr txt_aln rit']//a");
        By lnkProducts = By.XPath("//div[@class='lblock lft']//div[@class='li_txt1 wifi lft']//a");
        By lnkProductPrise = By.XPath(
                "//div[@class='lblock lft']//div[@class='li_txt1 wifi lft']//following-sibling::div[@class='rupee fw lft']//span[@class='r1']//a");
        By lnkSortBy = By.XPath("//div[@class='shmid lft']//div//a[contains(text(),'Top Rated')]");
        By product = By.XPath("//div[@id='maindiv']//div[@class='list_block lft']");
        By lnkQuickView = By.XPath("//div[@id='maindiv']//div[@class='list_block lft'][]//div[@class='qv lft']//a");
        By lnkMoreProductDetails = By.XPath("//div[@class='more_pd lft']//a");
        By iframeQuickView = By.Id("popupiframe");
        By btnAddtocart = By.XPath("//div[@class='p_rgt_section p_rgt']//div[@class='p_buy_now p_lft']//div[contains(text(),'ADD TO CART')]");
        By inpAddQuantity = By.XPath(
                "//div[@id='productlist']//div[@class='crs_h4 lft ']//div[@class='p_plus_incre lft cp'][contains(text(),'+')]");
        By lnkPrize = By.XPath("//div[@id='productlist']//div[@class='crs_h5 lft']//div//span[@class='lft']");
        By btnPlaceOrder = By.XPath("//div[@id='Cart_PlaceOrder']");

        By inpSampleEmailId = By.Id("BillEmailAddress");
        By btnloginContinue = By.XPath("//button[@class='btn1 sub_btn_blue']");
        By inpShipFirstName = By.Id("ShipFirstName");
        By inpAddressLine1 = By.Id("AddressLine1");
        By inpAddressLine2 = By.Id("AddressLine2");
        By inpShipPinCode = By.Id("ShipPinCode");
        By inpShipCity = By.Id("ShipCity");
        By inptxtShipState = By.Id("txtShipState");
        By inpShipMobileNo = By.Id("ShipMobileNo");
        By btnSubmitAdd = By.Id("btnSubmitAdd");
        By btnAddGiftWrap = By.XPath("//div[@class='btnr'][contains(text(),'add gift wrap')]");
        By inpGiftTo = By.Id("GiftTo");
        By inpGiftFrom2 = By.Id("GiftFrom");
        By inpGiftMsg = By.Id("GiftMsg");
        By btnSave = By.XPath("//input[@onclick='SaveGiftMsg();']");
        By btnFinalPayment = By.Id("fpay");

        By drpSelectBank = By.Id("drpNetBank");
        By btnPayNow = By.Id("BtnNetBankPayNow");
        By rdbCancelPreviousOrder = By.Id("radSimilarOrder1");
        By btnSubmitButton = By.Id("btnSimilarOrder");

        By btnContinue = By.Id("btnlogin");

        By btnclose1 = By.XPath("//div[@id='webklipper-publisher-widget-container-notification-container']//span");
        By btnclose2 = By.XPath("//div[@class='_pop_close _pop_reg_bg']");
        By iframe1 = By.Id("webklipper-publisher-widget-container-notification-frame");
        By lnkBank = By.XPath("//div[@class='header_logoText']");

        By rdbPayment = By.XPath("//li[@id='Netbank']//p[@id='pymentbtn1']");
        By rdbPaypal = By.XPath("//li[@id='Paypal']//p[@id='pymentbtn6']");
        By rdbAxisBank = By.XPath("//div[@class='axis_bank fc_ckot_sp']//div");
        By headerAxixBankPaymentPage = By.XPath("//div[@class='header_logoBg']//div//img[contains(@src,'AxisLogo.png')]");

        // *****************

        By inpEmail = By.XPath("//form[@id='frmLoginPopup']//input[@id='txtLUNm']");
        By inpPassword = By.XPath("//form[@id='frmLoginPopup']//input[@id='txtLPass']");
        By btnLogin = By.Id("btnlogon");
        By lnkLogin = By.XPath("//div[@class='welcome_forusers']//a");
        By lnkSpecificproduct = By.XPath("//div[@id='maindiv']//div[@class='list_block lft'][1]");
        By lnkQuickview = By.XPath(
                "//div[@id='maindiv']//div[@class='list_block lft'][1]//div[@class='qv lft']//a[contains(text(),'Quick View')]");
        By lnkBottomMenubar2 = By.XPath(
                "//div[@class='sticky-menu-footer submenu1-11']//ul//li[contains(text(),'TOP BRANDS:')]//following-sibling::li//a[contains(text(),'Karmallys')]");
        By lnkCategory = By.XPath("//div[@class='main_con wt lft']//div[@class='top']");


        public void CloseAdvPopUp()
        {
            objBaseTestClass.GetObjUtilityClass().logReporter("Close Login Page Window", objBaseTestClass.GetObjWrapperClass().ClickByJavaScriptExecutor(btnclose2));
        }
        public void ClickOnLogin()
        {
            objBaseTestClass.GetObjUtilityClass().logReporter("Click On Login link", objBaseTestClass.GetObjWrapperClass().ClickByJavaScriptExecutor(lnkLogin));
        }
        public void UncheckRememberMeCheckBox()
        {
            By chkRememberMe = By.XPath("//div[@id='kpLogImg']");
            if (objBaseTestClass.GetObjWrapperClass().IsCheckBoxChecked(chkRememberMe))
            {
                objBaseTestClass.GetObjUtilityClass().logReporter("UnCheck Remember Me check Box", objBaseTestClass.GetObjWrapperClass().ClickByJavaScriptExecutor(chkRememberMe));
            }
        }
        public void SetUserName()
        {
            objBaseTestClass.GetObjUtilityClass().logReporter("Set UserName ", objBaseTestClass.GetObjWrapperClass().setText(inpEmail, "bugtracker@ivavsys.com"));
        }
        public void SetPassword()
        {
            objBaseTestClass.GetObjUtilityClass().logReporter("Set Password ", objBaseTestClass.GetObjWrapperClass().setText(inpPassword, "Demouser123"));
        }
        public void ClickOnLoginButton()
        {
            objBaseTestClass.GetObjUtilityClass().logReporter("Click On Login Button ", objBaseTestClass.GetObjWrapperClass().clickOnElement(btnLogin));
        }
        public void NavigateToSiteMap()
        {
            objBaseTestClass.GetObjUtilityClass().logReporter("Navigate To SiteMAp", objBaseTestClass.GetObjWrapperClass().NavigateToUrl("http://www.firstcry.com/sitemap"));
        }
        public void MouseHoverOnUpperMenu()
        {
            Thread.Sleep(2000);
            By lnkMenuBar = By
                .XPath("//div[@class='menu-container media-pros']//ul//li//a[contains(text(),'day')]");
            objBaseTestClass.GetObjWrapperClass().ScrollToView(lnkMenuBar);
            objBaseTestClass.GetObjUtilityClass().logReporter("Mouse hover on B'day And Gift Menu", objBaseTestClass.GetObjWrapperClass().MouseHover(lnkMenuBar));

        }
        public void ClickOnBuyGiftCertificate()
        {
            objBaseTestClass.GetObjUtilityClass().logReporter("Click On Buy Gift Certificate", objBaseTestClass.GetObjWrapperClass().ClickByJavaScriptExecutor(lnkByBertificate));
        }

        public void SetName()
        {
            objBaseTestClass.GetObjWrapperClass().SwitchToIframe(iframe1);
            objBaseTestClass.GetObjUtilityClass().logReporter("Close PopUp Window", objBaseTestClass.GetObjWrapperClass().clickOnElement(btnclose1));
            objBaseTestClass.GetObjWrapperClass().SwitchToDefaultIframe();
            objBaseTestClass.GetObjUtilityClass().logReporter("Set Name", objBaseTestClass.GetObjWrapperClass().setText(inpName, "Neha"));
        }

        public void SetEmailId()
        {

            objBaseTestClass.GetObjUtilityClass().logReporter("Set Email Id", objBaseTestClass.GetObjWrapperClass().setText(inpEmailId, "abc@gmail.com"));
        }
        public void SetMessage()
        {

            objBaseTestClass.GetObjUtilityClass().logReporter("Set Message", objBaseTestClass.GetObjWrapperClass().setText(inpMessage, "Gift"));
        }
        public void SetGiftFromName()
        {

            objBaseTestClass.GetObjUtilityClass().logReporter("Set Message", objBaseTestClass.GetObjWrapperClass().setText(inpGiftFrom, "Neha"));
        }

        public void SelectAmount()
        {
            objBaseTestClass.GetObjUtilityClass().logReporter("Select Amount", objBaseTestClass.GetObjWrapperClass().selectDropDownValue(drpSelectAmount, "2"));
        }
        public void ClickOnGiftNow()
        {
            // objBaseTestClass.GetObjUtilityClass().logReporter("Scroll To View", objBaseTestClass.GetObjWrapperClass().ScrollToView(btnGiftNow));
            objBaseTestClass.GetObjUtilityClass().logReporter("Click On Gift Now button", objBaseTestClass.GetObjWrapperClass().ClickByJavaScriptExecutor(btnGiftNow));
        }

        public void ClickOnContinueShopping()
        {
            objBaseTestClass.GetObjUtilityClass().logReporter("Click On Continue Shopping button", objBaseTestClass.GetObjWrapperClass().clickOnElement(lnkContinueShopping));
            // objBaseTestClass.GetObjWrapperClass().ScrollToViewUp();
        }

        public void ClickOnBottomMenu()
        {
            IList<IWebElement> list = objBaseTestClass.GetObjdriver().FindElements(bottomMenubar);
            Console.WriteLine(list.Count);
            objBaseTestClass.GetObjUtilityClass().wait(2000);
            foreach (IWebElement element in list)
            {
                if (element.Displayed)
                {
                    if (element.Text.Trim().Equals("Karmallys"))
                    {
                        Console.WriteLine("Karmallys " + element.Text);
                        objBaseTestClass.GetObjUtilityClass().logReporter("Click On Bottom Menu", objBaseTestClass.GetObjWrapperClass().clickOnElement(element));
                        break;
                    }
                }
            }
        }
        public void ClickOnSortBy()
        {
            objBaseTestClass.GetObjUtilityClass().logReporter("Click On SortBy:- Top Rated", objBaseTestClass.GetObjWrapperClass().clickOnElement(lnkSortBy));
        }
        public void SelectSpecificProduct()
        {
            IList<IWebElement> list = objBaseTestClass.GetObjdriver().FindElements(product);
            Console.WriteLine(list.Count);
            int index = 0;
            string[] lines = new string[list.Count];
            for (int i = 0; i < list.Count; i++)
            {
                lines[i] = list.ElementAt(i).Text;
            }
            objBaseTestClass.GetObjUtilityClass().logReporter("Write Data Into File", objBaseTestClass.GetObjWrapperClass().WriteDataToFile(lines, "ProductDetails"));
           
            foreach (IWebElement element in list)
            {
                index++;
                if (index == 2)
                {
                    objBaseTestClass.GetObjUtilityClass().logReporter("Mouse Hover On Specific Product", objBaseTestClass.GetObjWrapperClass().MouseHover(element));
                    //  IWebElement ele = element.FindElement(By.XPath("//div//a[contains(text(),'Quick View')]"));
                    By Locator = By.XPath("//div[@id='maindiv']//div[@class='list_block lft'][2]//div//a[contains(text(),'Quick View')]");
                    objBaseTestClass.GetObjUtilityClass().wait(3000);
                    objBaseTestClass.GetObjUtilityClass().logReporter("Click On Quick View", objBaseTestClass.GetObjWrapperClass().ClickByJavaScriptExecutor(Locator));
                    break;
                }
            }

        }
        public void SwitchToIframeQuickView()
        {
            objBaseTestClass.GetObjUtilityClass().logReporter("Switch to Quick View Iframe", objBaseTestClass.GetObjWrapperClass().SwitchToIframe(iframeQuickView));
        }
        public void ClosePopUpWindow()
        {
            objBaseTestClass.GetObjUtilityClass().logReporter("Switch to ifrme", objBaseTestClass.GetObjWrapperClass().SwitchToIframe(iframe1));
            objBaseTestClass.GetObjUtilityClass().logReporter("Close PopUp Window", objBaseTestClass.GetObjWrapperClass().clickOnElement(btnclose1));
            objBaseTestClass.GetObjUtilityClass().logReporter("Switch To Default", objBaseTestClass.GetObjWrapperClass().SwitchToDefaultIframe());
        }
        public void ClickOnMoreProductDeatails()
        {
            objBaseTestClass.GetObjUtilityClass().logReporter("Click On Bottom Menu", objBaseTestClass.GetObjWrapperClass().clickOnElement(lnkMoreProductDetails));
            //  objBaseTestClass.GetObjWrapperClass().clickOnElement(btnclose1);
        }
        public void SwitchToNextWindow()
        {
            objBaseTestClass.GetObjUtilityClass().logReporter("Switch To second Window", objBaseTestClass.GetObjWrapperClass().SwitchToSecondWindow());

        }
        public void ClickOnAddToCartButton()
        {
            objBaseTestClass.GetObjUtilityClass().logReporter("Click On Add To Cart Button", objBaseTestClass.GetObjWrapperClass().ClickByJavaScriptExecutor(btnAddtocart));

        }
        public void AddQuantity()
        {
            Random random = new Random();
            for (int i = 0; i < random.Next(2, 10); i++)
            {
                objBaseTestClass.GetObjWrapperClass().clickOnElement(inpAddQuantity);
            }
        }
        public void ValidateTotal()
        {
            objBaseTestClass.GetObjUtilityClass().logReporter("Validate TOtal", true);
        }
        public void ClickOnPlaceOrder()
        {
            objBaseTestClass.GetObjUtilityClass().logReporter("Click On Place Order Button", objBaseTestClass.GetObjWrapperClass().ClickByJavaScriptExecutor(btnPlaceOrder));
        }
        public void SetYourEmailAddress()
        {
            objBaseTestClass.GetObjUtilityClass().logReporter("Set Your Email Address", objBaseTestClass.GetObjWrapperClass().setText(inpSampleEmailId, "abcd@gmail.com"));
        }

        public void ClickOnLoginContinueButton()
        {
            objBaseTestClass.GetObjUtilityClass().logReporter("Set Your Email Address", objBaseTestClass.GetObjWrapperClass().clickOnElement(btnloginContinue));
        }
        public void SetFirstName()
        {
            objBaseTestClass.GetObjUtilityClass().logReporter("Set First Name", objBaseTestClass.GetObjWrapperClass().setText(inpShipFirstName, "PQRS"));

        }
        public void SetFlatOrBuildinnName()
        {
            objBaseTestClass.GetObjUtilityClass().logReporter("Set Building name", objBaseTestClass.GetObjWrapperClass().setText(inpAddressLine1, "Flat no B 14 Ganesh Vision"));

        }
        public void SetAddresss()
        {
            objBaseTestClass.GetObjUtilityClass().logReporter("Set Address", objBaseTestClass.GetObjWrapperClass().setText(inpAddressLine2, "Chikhali Road"));

        }
        public void SetPinCode()
        {
            objBaseTestClass.GetObjUtilityClass().logReporter("Set PinCode", objBaseTestClass.GetObjWrapperClass().setText(inpShipPinCode, "411011"));

        }
        public void SetShippingCityName()
        {
            objBaseTestClass.GetObjUtilityClass().logReporter("Set PinCode", objBaseTestClass.GetObjWrapperClass().setText(inpShipCity, "Pune"));

        }
        public void SetShippingState()
        {
            objBaseTestClass.GetObjUtilityClass().logReporter("Set State", objBaseTestClass.GetObjWrapperClass().setText(inptxtShipState, "Maharashtra"));

        }
        public void SetMobileNumber()
        {
            objBaseTestClass.GetObjUtilityClass().logReporter("Set Mobile Number", objBaseTestClass.GetObjWrapperClass().setText(inpShipMobileNo, "9874561230"));

        }
        public void ClickOnSubmitButton()
        {
            objBaseTestClass.GetObjUtilityClass().logReporter("Click On Submit Button", objBaseTestClass.GetObjWrapperClass().clickOnElement(btnSubmitAdd));
            objBaseTestClass.GetObjUtilityClass().wait(1000);

        }
        public void ClickOnAddGiftWrapLink()
        {
            objBaseTestClass.GetObjWrapperClass().ScrollToView(btnAddGiftWrap);
            objBaseTestClass.GetObjUtilityClass().logReporter("Click On Add Gift Wrap Button", objBaseTestClass.GetObjWrapperClass().ClickByJavaScriptExecutor(btnAddGiftWrap));

        }
        public void SetGiftTo()
        {
            objBaseTestClass.GetObjUtilityClass().logReporter("Set Gift To", objBaseTestClass.GetObjWrapperClass().setText(inpGiftTo, "ABCDEF"));

        }
        public void SetGiftFrom()
        {
            objBaseTestClass.GetObjUtilityClass().logReporter("Set Gift From", objBaseTestClass.GetObjWrapperClass().setText(inpGiftFrom2, "ASDF"));

        }
        public void AddMessage()
        {
            objBaseTestClass.GetObjUtilityClass().logReporter("Set Message", objBaseTestClass.GetObjWrapperClass().setText(inpGiftMsg, "This is my gift"));

        }

        public void CLickOnSaveButton()
        {
            objBaseTestClass.GetObjUtilityClass().logReporter("Click On Save Button", objBaseTestClass.GetObjWrapperClass().clickOnElement(btnSave));

        }
        public void ClickOnFinalPaymentButton()
        {
            objBaseTestClass.GetObjWrapperClass().ScrollToView(btnFinalPayment);
            objBaseTestClass.GetObjUtilityClass().logReporter("Click On Final Payment Button", objBaseTestClass.GetObjWrapperClass().clickOnElement(btnFinalPayment));
        }

        public void SelectNetBanking()
        {
            objBaseTestClass.GetObjWrapperClass().ScrollToView(rdbPayment);
            objBaseTestClass.GetObjUtilityClass().logReporter("Select Net Banking Option", objBaseTestClass.GetObjWrapperClass().clickOnElement(rdbPayment));
        }
        public void SelectPaypal()
        {
            objBaseTestClass.GetObjWrapperClass().ScrollToView(rdbPaypal);
            objBaseTestClass.GetObjUtilityClass().logReporter("Select Paypal Option", objBaseTestClass.GetObjWrapperClass().clickOnElement(rdbPaypal));
        }
        public void WriteAllCategoryFile()
        {
            IList<IWebElement> list = objBaseTestClass.GetObjdriver().FindElements(lnkCategory);
            String[] Lines = new String[list.Count];
            objBaseTestClass.GetObjUtilityClass().logReporter("Write Data Into Files", objBaseTestClass.GetObjWrapperClass().WriteDataToFile(Lines, "CategoryDetails"));
        }
        public void ClickOnViewMoreLink()
        {
            IList<IWebElement> list = objBaseTestClass.GetObjdriver().FindElements(lnkCategory);
            RandomNo = objBaseTestClass.GetObjUtilityClass().GenerateRandomNumber(list.Count);
            Console.WriteLine("RandomNo " + RandomNo);
            By Locator = By.XPath("(//div[@class='main_txt']//div[@class='info wt lft'])["+ RandomNo + "]//div[contains(text(),'View More')]");
            objBaseTestClass.GetObjWrapperClass().ScrollToView(Locator);
            objBaseTestClass.GetObjUtilityClass().logReporter("Click On View More Link", objBaseTestClass.GetObjWrapperClass().clickOnElement(Locator));
            this.ClickOnCategorySublink(RandomNo);
        }
        public void ClickOnCategorySublink(int number)
        {
            By locatorlinks = By.XPath("(//div[@class='main_txt']//div[@class='info wt lft'])["+ number + "]//div[contains(text(),'View More')]//parent::div//preceding-sibling::div[contains(@class,'bottom btn')]//a");
            IList<IWebElement> list = objBaseTestClass.GetObjdriver().FindElements(locatorlinks);
            RandomNo1= objBaseTestClass.GetObjUtilityClass().GenerateRandomNumber(list.Count);
            Console.WriteLine("RandomNo1 " + RandomNo1);
           // objBaseTestClass.GetObjWrapperClass().ScrollToView(list.ElementAt(RandomNo1));
            objBaseTestClass.GetObjUtilityClass().logReporter("Click On Category Link", objBaseTestClass.GetObjWrapperClass().clickOnElement(list.ElementAt(RandomNo1)));
        }
        public void SelectBankingName()
        {
            //SelectElement selectele = new SelectElement(objBaseTestClass.GetObjdriver().FindElement(drpSelectBank));
            //Console.WriteLine("Select Count" + selectele.Options.Count);
            //int randomNo= objBaseTestClass.GetObjUtilityClass().GenerateRandomNumber(selectele.Options.Count);
            //objBaseTestClass.GetObjUtilityClass().logReporter("Select Bank", objBaseTestClass.GetObjWrapperClass().selectDropDownByIndex(drpSelectBank, randomNo));
   
            objBaseTestClass.GetObjUtilityClass().logReporter("Select Bank", objBaseTestClass.GetObjWrapperClass().clickOnElement(rdbAxisBank));
        }
        By lnkCart = By.XPath("//div[@id='cart_TotalCount']//div");
        By iconDelete = By.XPath("//div[@class='crs_dl lft']//div[contains(@onclick,'RemoveFromCart')]");
        String strData = null;
        By lnkCartEmpty = By.XPath("//div[@class='cartemptybig']");
        public void ClearCartEmpty()
        {
            strData = objBaseTestClass.GetObjWrapperClass().GetText(lnkCart);
            if(!strData.Equals("0"))
            {
                objBaseTestClass.GetObjUtilityClass().logReporter("Click On Cart", objBaseTestClass.GetObjWrapperClass().clickOnElement(lnkCart));
                while (objBaseTestClass.GetObjWrapperClass().isElementDisplayed(iconDelete))
                {
                    objBaseTestClass.GetObjUtilityClass().logReporter("Remove Product From Cart", objBaseTestClass.GetObjWrapperClass().clickOnElement(iconDelete));
                }
                strData = objBaseTestClass.GetObjWrapperClass().GetText(lnkCartEmpty);
                if (strData.Equals("Your Cart is empty. Please add items that you would like to buy to your cart"))
                {
                    objBaseTestClass.GetObjUtilityClass().logReporter("Verify Cart Is Empty", true);
                    this.ClickOnContinueShopping();
                }
            }
            else
            {
                objBaseTestClass.GetObjUtilityClass().logReporter("Verify Cart Is Empty", true);
            }
        }
     
        public void ApplyFilter(String Category,String Subcategory)
        {
            By locator = By.XPath("//div[@class='lft_mid_inr lft fw']//div[contains(@class,'brw_tit')]//span[text()='AGE']//preceding-sibling::span[@class='sprite_list arrow_l lft arw_rli']");
            if(objBaseTestClass.GetObjWrapperClass().isElementDisplayed(locator))
            {
                objBaseTestClass.GetObjWrapperClass().clickOnElement(locator);
                By Locator1 = By.XPath("//span[contains(text(),'0-3 Months ')]//ancestor::a//span[@class='sprite_list sprt']");
                if(objBaseTestClass.GetObjWrapperClass().isElementDisplayed(Locator1))
                {
                    objBaseTestClass.GetObjWrapperClass().clickOnElement(Locator1);
                }
            }
        }
       
        public void ClickOnPayNowButton()
        {
            objBaseTestClass.GetObjUtilityClass().logReporter("Click On PayNow Button", objBaseTestClass.GetObjWrapperClass().clickOnElement(btnPayNow));
           if(objBaseTestClass.GetObjWrapperClass().isElementDisplayed(rdbCancelPreviousOrder))
            {
                objBaseTestClass.GetObjUtilityClass().logReporter("Click On Cancel Order Button", objBaseTestClass.GetObjWrapperClass().clickOnElement(rdbCancelPreviousOrder));
                objBaseTestClass.GetObjUtilityClass().logReporter("Click On Submit Button", objBaseTestClass.GetObjWrapperClass().clickOnElement(btnSubmitButton));
            }
        }

        public void SelectCurrency()
        {
            By Locator = By.XPath("//div[contains(text(),' International')]//parent::div//div[contains(@onclick,'selectPaypalCurrency')]");
            objBaseTestClass.GetObjUtilityClass().logReporter("Select Currrency", objBaseTestClass.GetObjWrapperClass().clickOnElement(Locator));
        }
        public void  verifyBankPage()
        {
            objBaseTestClass.GetObjUtilityClass().logReporter("Verify BANK pAGE", objBaseTestClass.GetObjWrapperClass().isElementDisplayed(headerAxixBankPaymentPage));
            
        }
        public void verifyPaypalBankPage()
        {
            objBaseTestClass.GetObjUtilityClass().wait(5000);
            strData = objBaseTestClass.GetObjdriver().Url;
            Console.WriteLine("Url " + strData);
            if(strData.Contains("paypal"))
            { 
            objBaseTestClass.GetObjUtilityClass().logReporter("Verify Paypal Bank Page is displayed", objBaseTestClass.GetObjWrapperClass().isElementDisplayed(headerAxixBankPaymentPage));
            }
        }
    }
}
