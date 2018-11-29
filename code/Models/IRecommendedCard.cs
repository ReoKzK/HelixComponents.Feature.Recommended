using Glass.Mapper.Sc.Fields;
using HelixComponents.Foundation.ORM.Models;

namespace HelixComponents.Feature.Recommended.Models
{
    public interface IRecommendedCard : IGlassBase
    {
        string Title { get; set; }
        string Body { get; set; }
        Image Image { get; set; }
        Link CallToAction { get; set; }
    }
}