using System.Collections.Generic;
using System.Linq;
using System.Web;
using Glass.Mapper.Sc;
using HelixComponents.Feature.Recommended.Models;
using HelixComponents.Feature.Recommended.Services;
using HelixComponents.Feature.Recommended.ViewModels;
using HelixComponents.Foundation.Core.Models;
using HelixComponents.Foundation.Core.Services;

namespace HelixComponents.Feature.Recommended.Mediators
{
    public class RecommendedMediator : IRecommendedMediator
    {
        private readonly IGlassHtml _glassHtml;
        private readonly IRecommendedService _recommendedService;
        private readonly IMediatorService _mediatorService;

        public RecommendedMediator(IGlassHtml glassHtml, IRecommendedService recommendedService, IMediatorService mediatorService)
        {
            _glassHtml = glassHtml;
            _recommendedService = recommendedService;
            _mediatorService = mediatorService;
        }

        public MediatorResponse<RecommendedPagesViewModel> CreateRecommendedPagesViewModel()
        {
            var dataSource = _recommendedService.GetRecommendedPages();

            if (dataSource == null)
            {
                return _mediatorService.GetMediatorResponse<RecommendedPagesViewModel>(Constants.MediatorCodes.RecommendedPagesResponse.DataSourceError, message: Constants.Logging.Error.DataSourceError);
            }

            var renderingParameters = _recommendedService.GetRecommendedPagesRenderingParameters();

            if (renderingParameters == null)
            {
                return _mediatorService.GetMediatorResponse<RecommendedPagesViewModel>(Constants.MediatorCodes.RecommendedPagesResponse.RenderingParamError, message: Constants.Logging.Error.RenderingParametersError);
            }

            var viewModel = new RecommendedPagesViewModel
            {
                Title = new HtmlString(_glassHtml.Editable(dataSource, i => i.Title, new { EnclosingTag = "h1" })),
                Cards = dataSource.Cards != null && dataSource.Cards.Any()
                    ? dataSource.Cards.Select(MapRecommendedItemToRecommendedCardViewModel).ToList()
                    : new List<RecommendedCardViewModel>(),
                CssClass = renderingParameters.DisplayType?.CssClass,
                
                IsExperienceEditor = _recommendedService.IsExperienceEditor
            };

            return _mediatorService.GetMediatorResponse(Constants.MediatorCodes.RecommendedPagesResponse.Ok, viewModel);
        }

        private RecommendedCardViewModel MapRecommendedItemToRecommendedCardViewModel(IRecommendedCard card)
        {
            var recommendedCardViewModel = new RecommendedCardViewModel();
            
            recommendedCardViewModel.Title = new HtmlString(_glassHtml.Editable(card, i => i.Title));
            recommendedCardViewModel.Body = new HtmlString(_glassHtml.Editable(card, i => i.Body));
            recommendedCardViewModel.Image = new HtmlString(_glassHtml.RenderImage(card, i => i.Image, isEditable: true));
            recommendedCardViewModel.CallToActionLink = new HtmlString(_glassHtml.RenderLink(card, i => i.CallToAction));
            recommendedCardViewModel.Url = card.CallToAction?.Url;

            return recommendedCardViewModel;
        }
    }
}