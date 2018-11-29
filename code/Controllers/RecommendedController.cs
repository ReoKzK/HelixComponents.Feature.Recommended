using HelixComponents.Feature.Recommended.Mediators;
using HelixComponents.Foundation.Core.Exceptions;
using Sitecore.Mvc.Controllers;
using System.Web.Mvc;

namespace HelixComponents.Feature.Recommended.Controllers
{
    public class RecommendedController : SitecoreController
    {
        private readonly IRecommendedMediator _recommendedMediator;

        public RecommendedController(IRecommendedMediator recommendedMediator)
        {
            _recommendedMediator = recommendedMediator;
        }

        public ActionResult RecommendedPages()
        {
            var mediatorResponse = _recommendedMediator.CreateRecommendedPagesViewModel();

            switch (mediatorResponse.Code)
            {
                case Constants.MediatorCodes.RecommendedPagesResponse.DataSourceError:
                    return View("~/views/Recommended/Error.cshtml", mediatorResponse.Message);
                case Constants.MediatorCodes.RecommendedPagesResponse.Ok:
                    return View(mediatorResponse.ViewModel);
                default:
                    throw new InvalidMediatorResponseCodeException(mediatorResponse.Code);
            }
        }
    }
}