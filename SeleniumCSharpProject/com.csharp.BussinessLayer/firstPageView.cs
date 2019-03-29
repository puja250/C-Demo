using SeleniumCSharpProject.com.chsarp.ServiceLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCSharpProject.com.csharp.BussinessLayer
{
    public class firstPageView
    {
        BaseTestClass objBaseTestClass;
        FirstCryPage objFirstCryPage;
        public firstPageView(BaseTestClass objBaseTestClass)
        {
            this.objBaseTestClass = objBaseTestClass;
        }
        public void ApplyFilters()
        {
            String strCategory = "";
            String strSubCategory = "";
            objFirstCryPage.ApplyFilter(strCategory, strSubCategory);
        }

    }
}
