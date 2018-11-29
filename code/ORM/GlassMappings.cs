using Glass.Mapper.Sc.Maps;
using HelixComponents.Feature.Recommended.Models;
using Sitecore.Mvc.Extensions;

namespace HelixComponents.Feature.Recommended.ORM
{
    public class RecommendedPagesMappings : SitecoreGlassMap<IRecommendedPages>
    {
        public override void Configure()
        {
            Map(config =>
            {
                config.AutoMap();
                config.TemplateId(Constants.RecommendedPages.TemplateId);
                config.Field(f => f.Title).FieldName("Title");
                config.Field(f => f.Cards).FieldName("Cards");
            });
        }
    }

    public class RecommendedCardMappings : SitecoreGlassMap<IRecommendedCard>
    {
        public override void Configure()
        {
            Map(config =>
            {
                config.AutoMap();
                config.TemplateId(Constants.RecommendedCard.TemplateId);
                config.Field(f => f.Title).FieldName("Title");
                config.Field(f => f.Body).FieldName("Body");
                config.Field(f => f.CallToAction).FieldName("CallToAction");
                config.Field(f => f.Image).FieldName("Image");
            });
        }
    }

    public class RecommendedPagesRenderingParametersMappings : SitecoreGlassMap<IRecommendedPagesRenderingParameters>
    {
        public override void Configure()
        {
            Map(config =>
            {
                config.AutoMap();
                config.TemplateId(Constants.RecommendedPagesRenderingParameters.TemplateId);
                config.Field(f => f.DisplayType).FieldName("DisplayType");
            });
        }
    }

    public class RecommendedPagesDisplayTypeMappings : SitecoreGlassMap<IRecommendedPagesDisplayType>
    {
        public override void Configure()
        {
            Map(config =>
            {
                config.AutoMap();
                config.TemplateId(Constants.RecommendedPagesDisplayType.TemplateId);
                config.Field(f => f.CssClass).FieldName("CssClass");
            });
        }
    }
}
