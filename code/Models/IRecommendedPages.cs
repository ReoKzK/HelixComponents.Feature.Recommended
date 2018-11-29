using System.Collections.Generic;
using HelixComponents.Foundation.ORM.Models;

namespace HelixComponents.Feature.Recommended.Models
{
    public interface IRecommendedPages : IGlassBase
    {
        string Title { get; set; }
        IEnumerable<IRecommendedCard> Cards { get; set; }
    }
}