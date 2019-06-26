using System.Web;
using System.Web.Http.WebHost;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.SessionState;

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
