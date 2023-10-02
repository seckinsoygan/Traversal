using Microsoft.AspNetCore.Mvc;

namespace Traversal.App.ViewComponents.Default
{
    public class _SliderPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
