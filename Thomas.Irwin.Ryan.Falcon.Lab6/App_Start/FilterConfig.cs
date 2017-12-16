using System.Web;
using System.Web.Mvc;

namespace Thomas.Irwin.Ryan.Falcon.Lab6
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
