using HelixComponents.Feature.Recommended.Models;

namespace HelixComponents.Feature.Recommended.Services
{
    public interface IRecommendedService
    {
        IRecommendedPages GetRecommendedPages();
        IRecommendedPagesRenderingParameters GetRecommendedPagesRenderingParameters();

        bool IsExperienceEditor { get; }
    }
}