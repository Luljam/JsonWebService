using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Linq;
using System.Web.Script.Serialization;
using System.Web.Script.Services;

namespace JsonWebService
{
    /// <summary>
    /// Summary description for Service1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class Service1 : System.Web.Services.WebService
    {
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        [WebMethod]
        public string GetPeople()
        {
            var jsonData = new
            {
                pessoas = new[]{
                  new {id = 1, nome = "Luciano"},
                  new {id = 2, nome = "Junior"},
                  new {id = 3, nome = "Henrique"}
                }
            };
            JavaScriptSerializer ser = new JavaScriptSerializer();
            return ser.Serialize(jsonData);
        }
    }
}
