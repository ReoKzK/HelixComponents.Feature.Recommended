using HelixComponents.Foundation.ORM.Models;

namespace HelixComponents.Feature.Recommended.Models
{
    public interface IRecommendedPagesRenderingParameters : IGlassBase
    {
        IRecommendedPagesDisplayType DisplayType { get; set; }
    }
}