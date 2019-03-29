using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCSharpProject.com.chsarp.ServiceLayer
{
    public class HomePage
    {
        BaseTestClass objBaseTestClass;
        public HomePage(BaseTestClass objBaseTestClass)
        {
            this.objBaseTestClass = objBaseTestClass;
        }
        By lnkmenu = By.XPath("//nav[@class='hasProductIcons']//ul//li//a[contains(text(),'Flights')]");
        By inpFrom = By.XPath("//div[@id='ORtrip']//input[@id='FromTag']");
        By inpTo = By.XPath("//div[@id='ORtrip']//input[@id='ToTag']");
        By fromDate = By.XPath("//div[@id='ORtrip']//input[@id='DepartDate']");
        By toDate = By.XPath("//div[@id='ORtrip']//input[@id='ReturnDate']");
        By drpAdults = By.XPath("//select[@id='Adults']");
        By inpDepartDate = By.XPath("//section[@class='row fieldRow searchBox']//input[@id='DepartDate']");
        By inpReturnDate = By.XPath("//section[@class='row fieldRow searchBox']//input[@id='ReturnDate']");
        By icon = By.XPath("//a//i[@class='icon ir datePicker']");
        By btnSearch = By.Id("SearchBtn");
        By lblStops = By.XPath(
                "//form[@class='filtersForm']//ul[@class='list clearFix inline ']//li//input[@value='0']//parent::li//label");
        By lblDepartureFlights = By.XPath(
                "//div[@class='colZero leg col12']//ul//td//span[@class='truncate']//parent::td//span[text()='GoAir ' or text()='IndiGo ']//ancestor::table//tr//input");
        By lblReturnFlights = By.XPath(
                "//div[@class='colZero leg col12 last']//ul//td//span[@class='truncate']//parent::td//span[text()='SpiceJet  ' or text()='Air India ']//ancestor::table//tr//input");
        By elementToScroll = By.XPath("//div[@data-block-type='tripDuration']//h5");

        By iconDepartDate = By.XPath("//input[@id='DepartDate']//parent::div//a[@class='calendarIcon']//i");
        By iconReturnDate = By.XPath("//input[@id='ReturnDate']//parent::div//a[@class='calendarIcon']//i");


        By btnBook = By.XPath(
            "//div[@class='row roundTripHead']//span//parent::div//following-sibling::div[@class='col col3 actionCol']//button");
        By inpInsurance = By.XPath("//input[@id='insurance_box']");
        By btnContinueBooking = By.XPath("//input[@id='itineraryBtn']");
        By inpEmail = By.XPath("//input[@id='username']");

        By drpAdult = By.XPath("//select[@id='AdultTitle1']");
        By inpName = By.XPath("//dd[@id='addAD1']//input[@id='AdultFname1']");
        By inpSurname = By.Id("AdultLname1");
        By drpDay = By.XPath("//select[@id='AdultDobDay1']");
        By drpMonth = By.XPath("//select[@id='AdultDobMonth1']");
        By drpYear = By.XPath("//select[@id='AdultDobYear1']");
        By inpNationality = By.XPath("//input[@data-idfield='adultNationality1']");


        By drpAdult1 = By.XPath("//select[@id='AdultTitle2']");
        By inpName1 = By.Id("AdultFname2");
        By inpSurname1 = By.Id("AdultLname2");
        By drpDay1 = By.XPath("//select[@id='AdultDobDay2']");
        By drpMonth1 = By.XPath("//select[@id='AdultDobMonth2']");
        By drpYear1 = By.XPath("//select[@id='AdultDobYear2']");
        By inpNationality1 = By.XPath("//input[@data-idfield='adultNationality2']");
        By inpMobileNo = By.XPath("//input[@id='mobileNumber']");

        By lnkPayment = By.XPath("//nav[@id='paymentTypes']//ul//li//a[@title='Net Banking']");
        By rdbPayment = By.XPath("//input[@id='kotak_bank']");
        By btnPayment = By.XPath("//input[@id='paymentSubmit']");
        By btnContinue = By.Id("LoginContinueBtn_1");
        By lnkBank = By.XPath("//header[@id='header-main']//strong[@class='logo']//img[@title='Kotak']");
        By btnContinue1 = By.Id("travellerBtn");


        public void selectTriptype(String RadioButtonId)
        {
            By rdbButton = By.XPath("//nav[@class='row fieldRow tripType']//ul//li//input[@id='"+ RadioButtonId + "']");
            Console.WriteLine("Enter into selectTriptype ");
            objBaseTestClass.GetObjUtilityClass().logReporter("Select Round Trip", objBaseTestClass.GetObjWrapperClass().clickOnElement(rdbButton));
        }
        public void setFromcityName(String cityName)
        {
            objBaseTestClass.GetObjUtilityClass().logReporter("Set Destination City", objBaseTestClass.GetObjWrapperClass().setText(inpFrom, cityName));
        }
        public void setTocityName(String cityName)
        {
            objBaseTestClass.GetObjUtilityClass().logReporter("Set  City", objBaseTestClass.GetObjWrapperClass().setText(inpTo, cityName));
        }
        public void selectFormAdultsDropdown()
        {
            objBaseTestClass.GetObjUtilityClass().logReporter("Select Adults", objBaseTestClass.GetObjWrapperClass().selectDropDownValue(drpAdults, "2"));
        }
        public void clickOnDepatureDateCalenderIcon()
        {
            objBaseTestClass.GetObjUtilityClass().logReporter("Click on Departure Calender Icon", objBaseTestClass.GetObjWrapperClass().clickOnElement(iconDepartDate));
        }
        public void selectDepartureDate()
        {
            String strDate = (DateTime.Now.AddDays(5)).ToString("dd'/'MM'/'yyyy");
            objBaseTestClass.GetObjWrapperClass().selectDate(strDate);
        }
        public void clickOnReturnDateCalenderIcon()
        {
            objBaseTestClass.GetObjUtilityClass().logReporter("Click on Departure Calender Icon", objBaseTestClass.GetObjWrapperClass().clickOnElement(iconReturnDate));
        }
        public void selectReturnDate()
        {
            String strDate = (DateTime.Now.AddDays(6)).ToString("dd'/'MM'/'yyyy");
            objBaseTestClass.GetObjWrapperClass().selectDate(strDate);
        }
        public void clickOnSearchButton()
        {
            objBaseTestClass.GetObjUtilityClass().logReporter("click On search button", objBaseTestClass.GetObjWrapperClass().clickOnElement(btnSearch));
            objBaseTestClass.GetObjUtilityClass().wait(5000);
        }
        public void selectStop()
        {
            objBaseTestClass.GetObjUtilityClass().logReporter("Select stop", objBaseTestClass.GetObjWrapperClass().clickOnElement(lblStops));
            objBaseTestClass.GetObjUtilityClass().wait(5000);
        }
        public void selectDepartureSecondFlight()
        {
            IWebElement element = objBaseTestClass.GetObjWrapperClass().selectFlights(lblDepartureFlights);
            objBaseTestClass.GetObjWrapperClass().ScrollToView(element);
            objBaseTestClass.GetObjUtilityClass().logReporter("Select second flight", objBaseTestClass.GetObjWrapperClass().clickOnElement(element));
        }
        public void selectReturnSecondFlight()
        {
            IWebElement element = objBaseTestClass.GetObjWrapperClass().selectFlights(lblReturnFlights);
            objBaseTestClass.GetObjWrapperClass().ScrollToView(element);
            objBaseTestClass.GetObjUtilityClass().logReporter("Select second flight", objBaseTestClass.GetObjWrapperClass().clickOnElement(element));
        }

        public void clickOnBookButton()
        {
            objBaseTestClass.GetObjUtilityClass().logReporter("click on book button", objBaseTestClass.GetObjWrapperClass().clickOnElement(btnBook));
        }
        public void clickOnInsurance()
        {
            objBaseTestClass.GetObjUtilityClass().logReporter("click on Insurance", objBaseTestClass.GetObjWrapperClass().clickOnElement(inpInsurance));
        }
        public void clickOncontinueBookingButton()
        {
            objBaseTestClass.GetObjUtilityClass().logReporter("click on Continue button", objBaseTestClass.GetObjWrapperClass().clickOnElement(btnContinueBooking));
        }

        public void setEmailID()
        {
            objBaseTestClass.GetObjUtilityClass().logReporter("Set Email ID", objBaseTestClass.GetObjWrapperClass().setText(inpEmail, "abc@gmail.com"));
        }
        public void clickOnContinueButton()
        {
            objBaseTestClass.GetObjUtilityClass().logReporter("click continue", objBaseTestClass.GetObjWrapperClass().clickOnElement(btnContinue));
        }
      
        public void selectTitle()
        {
            objBaseTestClass.GetObjUtilityClass().logReporter("Select Title 1", objBaseTestClass.GetObjWrapperClass().selectDropDownValue(drpAdult, "Ms"));
        }
        public void setName()
        {
            objBaseTestClass.GetObjUtilityClass().logReporter("Set Name", objBaseTestClass.GetObjWrapperClass().setText(inpName, "abc"));
        }
        public void setSurname()
        {
            objBaseTestClass.GetObjUtilityClass().logReporter("Set surname", objBaseTestClass.GetObjWrapperClass().setText(inpSurname, "XYZ"));
        }
        public void selectTitle1()
        {
            objBaseTestClass.GetObjUtilityClass().logReporter("Select Title 2", objBaseTestClass.GetObjWrapperClass().selectDropDownValue(drpAdult1, "Ms"));
        }

        public void setReceName()
        {
            objBaseTestClass.GetObjUtilityClass().logReporter("Set Name", objBaseTestClass.GetObjWrapperClass().setText(inpName1, "PQR"));
        }
        public void setReceSurname()
        {
            objBaseTestClass.GetObjUtilityClass().logReporter("Set surname", objBaseTestClass.GetObjWrapperClass().setText(inpSurname1, "MNK"));
        }
        public void setMobileNumber()
        {
            objBaseTestClass.GetObjUtilityClass().logReporter("Set surname", objBaseTestClass.GetObjWrapperClass().setText(inpMobileNo, "7894561230"));
        }

        public void clickOnContinueButton1()
        {
            objBaseTestClass.GetObjUtilityClass().logReporter("click continue", objBaseTestClass.GetObjWrapperClass().clickOnElement(btnContinue1));
        }

        public void clickPaymentLink()
        {
            objBaseTestClass.GetObjUtilityClass().logReporter("click payment Link", objBaseTestClass.GetObjWrapperClass().clickOnElement(lnkPayment));
        }
        public void clickPaymentRadioButton()
        {
            objBaseTestClass.GetObjUtilityClass().logReporter("click payment radio", objBaseTestClass.GetObjWrapperClass().clickOnElement(rdbPayment));
        }
        public void clickPaymentButton()
        {
            objBaseTestClass.GetObjUtilityClass().logReporter("click payment button", objBaseTestClass.GetObjWrapperClass().clickOnElement(btnPayment));
        }
        public void verifyPaymentPageDisplayed()
        {
            objBaseTestClass.GetObjUtilityClass().logReporter("Verify payment page", objBaseTestClass.GetObjWrapperClass().isElementDisplayed(lnkPayment));
        }
    }
}
