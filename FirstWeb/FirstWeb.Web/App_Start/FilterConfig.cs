using System.Web;
using System.Web.Mvc;

namespace FirstWeb.Web
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new StoreExceptionAttribute());
        }

        public class StoreExceptionAttribute : FilterAttribute, IExceptionFilter
        {
            public void OnException(ExceptionContext filterContext)
            {
                if (filterContext.ExceptionHandled) return;

                var log = log4net.LogManager.GetLogger(filterContext.Exception.TargetSite.DeclaringType);

                log.Error(filterContext.Exception.TargetSite.Name, filterContext.Exception);

                filterContext.ExceptionHandled = true;
            }
        }
    }
}
