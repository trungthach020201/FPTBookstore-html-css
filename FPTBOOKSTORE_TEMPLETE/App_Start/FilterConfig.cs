using System.Web;
using System.Web.Mvc;

namespace FPTBOOKSTORE_TEMPLETE
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
