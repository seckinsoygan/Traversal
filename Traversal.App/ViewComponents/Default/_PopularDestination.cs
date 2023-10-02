using Microsoft.AspNetCore.Mvc;
using Traversal.Business.Abstract;

namespace Traversal.App.ViewComponents.Default
{
    public class _PopularDestinationPartial : ViewComponent
    {
        private readonly IDestinationService destinationService;

        public _PopularDestinationPartial(IDestinationService destinationService)
        {
            this.destinationService = destinationService;
        }

        public IViewComponentResult Invoke()
        {
            var result = destinationService.GetAll();
            return View(result);
        }
    }
}
