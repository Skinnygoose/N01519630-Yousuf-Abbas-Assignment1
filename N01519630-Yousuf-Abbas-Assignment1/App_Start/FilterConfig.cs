using System.Web;
using System.Web.Mvc;

namespace N01519630_Yousuf_Abbas_Assignment1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
