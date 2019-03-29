using NUnit.Framework;
using SeleniumCSharpProject.com.chsarp.ServiceLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCSharpProject.com.csharp.PresentationLayer
{
    class FirstCryTestClass:BaseTestClass
    {
        FirstCryPage objFirstCryPage;
        [OneTimeSetUp]
        public  void InitEnv()
        {
            objFirstCryPage = new FirstCryPage(this);
            Initialization();
        }
        [Test]
        public void FirstCryAssignment1()
        {
            //Assignment1
            Console.WriteLine("Start");
            objFirstCryPage.CloseAdvPopUp();
            objFirstCryPage.MouseHoverOnUpperMenu();
            objFirstCryPage.ClickOnBuyGiftCertificate();
            objFirstCryPage.SetName();
            objFirstCryPage.SetEmailId();
            objFirstCryPage.SetMessage();
            objFirstCryPage.SetGiftFromName();
            objFirstCryPage.SelectAmount();
            objFirstCryPage.ClickOnGiftNow();
            objFirstCryPage.ClickOnContinueShopping();
            objFirstCryPage.MouseHoverOnUpperMenu();
            objFirstCryPage.ClickOnBottomMenu();
            objFirstCryPage.ClosePopUpWindow();
            objFirstCryPage.SelectSpecificProduct();
            objFirstCryPage.SwitchToIframeQuickView();
            objFirstCryPage.ClickOnMoreProductDeatails();
            objFirstCryPage.SwitchToNextWindow();
            objFirstCryPage.ClickOnAddToCartButton();
            objFirstCryPage.AddQuantity();
            objFirstCryPage.ValidateTotal();
            objFirstCryPage.ClickOnPlaceOrder();
            objFirstCryPage.SetYourEmailAddress();
            objFirstCryPage.ClickOnLoginContinueButton();
            objFirstCryPage.SetFirstName();
            objFirstCryPage.SetFlatOrBuildinnName();
            objFirstCryPage.SetAddresss();
            objFirstCryPage.SetShippingCityName();
            objFirstCryPage.SetPinCode();
            objFirstCryPage.SetShippingState();
            objFirstCryPage.SetMobileNumber();
            objFirstCryPage.ClickOnSubmitButton();
            objFirstCryPage.ClickOnAddGiftWrapLink();
            objFirstCryPage.SetGiftTo();
            objFirstCryPage.SetGiftFrom();
            objFirstCryPage.CLickOnSaveButton();
            objFirstCryPage.ClickOnFinalPaymentButton();
            objFirstCryPage.SelectNetBanking();
            objFirstCryPage.SelectBankingName();
            objFirstCryPage.ClickOnPayNowButton();
            objFirstCryPage.verifyBankPage();

        }

        [Test]
        public void FirstCryAssignment2()
        {
            objFirstCryPage.CloseAdvPopUp();
            objFirstCryPage.ClickOnLogin();
            objFirstCryPage.SetUserName();
            objFirstCryPage.SetPassword();
            objFirstCryPage.UncheckRememberMeCheckBox();
            objFirstCryPage.ClickOnLoginButton();
            objFirstCryPage.NavigateToSiteMap();
         
            objFirstCryPage.WriteAllCategoryFile();
            objFirstCryPage.ClosePopUpWindow();
            objFirstCryPage.ClickOnViewMoreLink();
            objFirstCryPage.SwitchToNextWindow();
            objFirstCryPage.ClearCartEmpty();
           
            objFirstCryPage.ApplyFilter("","");
            objFirstCryPage.ClosePopUpWindow();
            objFirstCryPage.SelectSpecificProduct();
            objFirstCryPage.SwitchToIframeQuickView();
            objFirstCryPage.ClickOnMoreProductDeatails();
            objFirstCryPage.SwitchToNextWindow();
            objFirstCryPage.AddQuantity();
            objFirstCryPage.ClickOnAddToCartButton();
            objFirstCryPage.ValidateTotal();///
            objFirstCryPage.ClickOnPlaceOrder();

            objFirstCryPage.SetYourEmailAddress();
            objFirstCryPage.ClickOnLoginContinueButton();
            objFirstCryPage.SetFirstName();
            objFirstCryPage.SetFlatOrBuildinnName();
            objFirstCryPage.SetAddresss();
            objFirstCryPage.SetShippingCityName();
            objFirstCryPage.SetPinCode();
            objFirstCryPage.SetShippingState();
            objFirstCryPage.SetMobileNumber();
            objFirstCryPage.ClickOnSubmitButton();
            objFirstCryPage.ValidateTotal();////

            objFirstCryPage.ClickOnFinalPaymentButton();
            objFirstCryPage.SelectPaypal();
            objFirstCryPage.SelectCurrency();
            objFirstCryPage.ClickOnPayNowButton();
            objFirstCryPage.verifyPaypalBankPage();
        }
        [OneTimeTearDown]
        public void TearDownEnv()
        {
           // TearDown();
        }
    }
}
