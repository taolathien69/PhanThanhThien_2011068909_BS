using System.Web;
using System.Web.Mvc;

namespace PhanThanhThien_2011068909_BS
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
