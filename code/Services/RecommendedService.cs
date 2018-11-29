using HelixComponents.Feature.Recommended.Models;
using HelixComponents.Foundation.Content.Repositories;
using HelixComponents.Foundation.Logging.Repositories;

namespace HelixComponents.Feature.Recommended.Services
{
    public class RecommendedService : IRecommendedService
    {
        private readonly IContextRepository _contextRepository;
        private readonly ILogRepository _logRepository;
        private readonly IRenderingRepository _renderingRepository;

        public RecommendedService(IContextRepository contextRepository,
            ILogRepository logRepository, IRenderingRepository renderingRepository)
        {
            _contextRepository = contextRepository;
            _logRepository = logRepository;
            _renderingRepository = renderingRepository;
        }

        public IRecommendedPages GetRecommendedPages()
        {
            var dataSource = _renderingRepository.GetDataSourceItem<IRecommendedPages>();
            if (dataSource == null)
                _logRepository.Warn(Constants.Logging.Error.DataSourceError);

            return dataSource;
        }

        public IRecommendedPagesRenderingParameters GetRecommendedPagesRenderingParameters()
        {
            var renderingParameters = _renderingRepository.GetRenderingParameters<IRecommendedPagesRenderingParameters>();

            if (renderingParameters == null)
                _logRepository.Warn(Constants.Logging.Error.RenderingParametersError);

            return renderingParameters;
        }

        public bool IsExperienceEditor => _contextRepository.IsExperienceEditor;
    }
}