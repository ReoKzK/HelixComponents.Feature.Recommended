using System.Collections.Generic;
using System.Web;

namespace HelixComponents.Feature.Recommended.ViewModels
{
    public class RecommendedPagesViewModel
    {
        public HtmlString Title { get; set; }
        public List<RecommendedCardViewModel> Cards { get; set; }
        public string CssClass { get; set; }

        public bool IsExperienceEditor { get; set; }
    }
}