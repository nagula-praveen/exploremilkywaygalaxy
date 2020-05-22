using System.Web;
using System.Web.Mvc;

namespace ExploreMilkywayGalaxy
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
