using System.Web;

namespace HelixComponents.Feature.Recommended.ViewModels
{
    public class RecommendedCardViewModel
    {
        public HtmlString Title { get; set; }
        public HtmlString Body { get; set; }
        public HtmlString Image { get; set; }
        public HtmlString CallToActionLink { get; set; }
        public string Url { get; set; }
        public HtmlString CallToActionText { get; set; }

        public bool IsExperienceEditor { get; set; }
    }
}