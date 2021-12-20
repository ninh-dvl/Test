using System.Web;
using System.Web.Mvc;

namespace EAP_Product_NGUYEN_KHANH_NINH
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
