using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace webervice
{
    /// <summary>
    /// Summary description for rectanglearea
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class rectanglearea : System.Web.Services.WebService
    {

        [WebMethod]
        public string findrectanglearea(int l, int b)
        {
            int area = l * b;
            return $"The area of the rectangle is: {area} square units.";
        }
    }
}
