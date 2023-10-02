using Microsoft.AspNetCore.Mvc;
using Traversal.Business.Abstract;

namespace Traversal.App.ViewComponents.Default
{
    public class _FeaturePartial : ViewComponent
    {
        private readonly IFeatureService featureService;

        public _FeaturePartial(IFeatureService featureService)
        {
            this.featureService = featureService;
        }

        public IViewComponentResult Invoke()
        {
            var result = featureService.GetAll();
            return View(result);
        }
    }
}
