using System;

namespace HelixComponents.Feature.Recommended
{
    public struct Constants
    {
        public static class RecommendedPages
        {
            public static Guid TemplateId = new Guid("{B66C99F8-4BE4-4068-AC15-782D753A4F1D}");
        }

        public static class RecommendedCard
        {
            public static Guid TemplateId = new Guid("{0AE29C71-BDF5-4D65-B5A0-AB32456F5033}");
        }

        public static class RecommendedPagesRenderingParameters
        {
            public static Guid TemplateId = new Guid("{A6A0F108-FEEA-459B-AFD6-9B337ACD984F}");
        }

        public static class RecommendedPagesDisplayType
        {
            public static Guid TemplateId = new Guid("{DC39BC3A-6DC1-46B6-8896-DEAD839C9927}");
        }

        public class MediatorCodes
        {
            public struct RecommendedPagesResponse
            {
                public const string DataSourceError = "FeaturedContentMediator.CreateRecommendedPagesViewModel.DataSourceError";
                public const string RenderingParamError = "FeaturedContentMediator.CreateRecommendedPagesViewModel.RenderingParamError";

                public const string Ok = "FeaturedContentMediator.CreateRecommendedPagesViewModel.Ok";
            }
        }

        public class Logging
        {
            public struct Error
            {
                public const string DataSourceError = "The datasource was empty";
                public const string RenderingParametersError = "The rendering parameters was empty";
            }
        }
    }
}