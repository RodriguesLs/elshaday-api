using elshaday_test_api.Integration.Interfaces;
using elshaday_test_api.Integration.Refit;
using elshaday_test_api.Integration.Response;

namespace elshaday_test_api.Integration
{
    public class ViaCepIntegration : IViaCepIntegration
    {
        private readonly IViaCepIntegrationRefit _viaCepIntegrationRefit;
        public ViaCepIntegration(IViaCepIntegrationRefit viaCepIntegrationRefit)
        {
            _viaCepIntegrationRefit = viaCepIntegrationRefit;
        }
        public async Task<ViaCepResponse> getViaCepData(string cep)
        {
            var responseData = await _viaCepIntegrationRefit.getViaCepData(cep);

            if(responseData != null && responseData.IsSuccessStatusCode)
            {
                return responseData.Content;
            }

            return null;
        }
    }
}
