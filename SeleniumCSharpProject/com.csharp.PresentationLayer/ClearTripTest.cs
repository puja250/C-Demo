using NUnit.Framework;
using SeleniumCSharpProject.com.chsarp.ServiceLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCSharpProject.com.csharp.PresentationLayer
{
    class ClearTripTest:BaseTestClass
    {
        public HomePage objHomePage;
        [SetUp]
        public void init()
        {
            objHomePage = new HomePage(this);
            Initialization();
        }
        [Test]
        public void Test1()
        {
            objHomePage.selectTriptype("RoundTrip");
            objHomePage.setFromcityName("Mumbai");
            objHomePage.setTocityName("Delhi");
            objHomePage.selectFormAdultsDropdown();
            objHomePage.clickOnDepatureDateCalenderIcon();
            objHomePage.selectDepartureDate();
            objHomePage.clickOnReturnDateCalenderIcon();
            objHomePage.selectReturnDate();
            objHomePage.clickOnSearchButton();
            objHomePage.selectStop();
            // objHomePage.selectDepartureSecondFlight();
            // objHomePage.selectReturnSecondFlight();
            objHomePage.clickOnBookButton();
            objHomePage.clickOnInsurance();
            objHomePage.clickOncontinueBookingButton();
            objHomePage.setEmailID();
            objHomePage.clickOnContinueButton();
            objHomePage.setName();
            objHomePage.setSurname();
            objHomePage.selectTitle();
            objHomePage.selectTitle1();
            objHomePage.setReceName();
            objHomePage.setReceSurname();
            objHomePage.setMobileNumber();
            objHomePage.clickOnContinueButton1();
            objHomePage.clickPaymentLink();
            objHomePage.clickPaymentRadioButton();
            objHomePage.clickPaymentButton();
            objHomePage.verifyPaymentPageDisplayed();
        }
    }
}
