using System.Web.Mvc;

namespace MvcPagingDemo.Areas.AreaOne
{
    public class AreaOneAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "AreaOne";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "AreaOne_default",
                "AreaOne/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional },
                new[] { "MvcPagingDemo.Areas.AreaOne.Controllers" }
            );
        }
    }
}
