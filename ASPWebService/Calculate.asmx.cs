using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ASPWebService
{
    /// <summary>
    /// Summary description for Calculate
    /// </summary>
    [WebService(Namespace = "http://localhost:9999/Calculate.asmx")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class Calculate : System.Web.Services.WebService
    {

        [WebMethod]
        public void Calc(string a, string b, string op)
        {
            int res = 0;
            int n1 = Convert.ToInt32(a);
            int n2 = Convert.ToInt32(b);
            switch (op)
            {
                case "-": res = n1 - n2; break;
                case "+": res = n1 + n2; break;
                case "*": res = n1 * n2; break;
                case "/": res = n1 / n2; break;
            }

            Object o = new
            {
                Result = res
            };

            var oSerializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            Context.Response.Write(oSerializer.Serialize(o));
        }
    }
}
