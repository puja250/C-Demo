using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumCSharpProject.com.chsarp.ServiceLayer
{
    public class UtilityClass
    {
        BaseTestClass objBaseTestClass;
        public UtilityClass(BaseTestClass objBaseTestClass)
        {
            this.objBaseTestClass = objBaseTestClass;
        }
        public void logReporter(String strMsg, Boolean blnResult)
        {
            Console.WriteLine("Step Description ----> " + strMsg);
            Assert.IsTrue(blnResult);
        }
        public void logReporter(String strMsg, Boolean blnExpectedResult, Boolean blnActualResult)
        {
            Console.WriteLine("Step Description ----> " + strMsg + "Expected Result || " + blnExpectedResult + "Actual Result " + blnActualResult);
            Assert.AreEqual(blnExpectedResult, blnActualResult);
        }
        public void logReporter(String strMsg, String strExpectedResult, String strActualResult)
        {
            Console.WriteLine("Step Description ----> " + strMsg + "Expected Result ||" + strExpectedResult + "Actual Result " + strActualResult);
            Assert.AreEqual(strExpectedResult, strActualResult);
        }
        public void wait(int time)
        {
            try
            {
                Thread.Sleep(time);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public int GenerateRandomNumber(int max)
        {
            Random random = new Random();
            return random.Next(1, max);
        }
    }
}
