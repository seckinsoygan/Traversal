using Microsoft.AspNetCore.Mvc;
using Traversal.DataAccess.Concrete;

namespace Traversal.App.ViewComponents.Default
{
    public class _StatisticsPartial : ViewComponent
    {
        private readonly Context context;

        public _StatisticsPartial(Context context)
        {
            this.context = context;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = context.Destinations.Count();
            ViewBag.v2 = context.Guides.Count();
            ViewBag.v3 = 285;
            return View();
        }
    }
}
