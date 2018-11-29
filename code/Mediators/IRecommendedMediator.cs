using HelixComponents.Feature.Recommended.ViewModels;
using HelixComponents.Foundation.Core.Models;

namespace HelixComponents.Feature.Recommended.Mediators
{
    public interface IRecommendedMediator
    {
        MediatorResponse<RecommendedPagesViewModel> CreateRecommendedPagesViewModel();
    }
}