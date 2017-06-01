using System.Web;
using System.Web.Mvc;

namespace JoonasW.DevOps.DemoApp
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
