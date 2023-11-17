using elshaday_test_api.Integration.Response;
using Refit;

namespace elshaday_test_api.Integration.Refit
{
    public interface IViaCepIntegrationRefit
    {
        [Get("/ws/{cep}/json")]
        Task<ApiResponse<ViaCepResponse>> getViaCepData(string cep);
    }
}
