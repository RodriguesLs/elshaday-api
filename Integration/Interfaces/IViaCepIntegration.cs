using elshaday_test_api.Integration.Response;

namespace elshaday_test_api.Integration.Interfaces
{
    public interface IViaCepIntegration
    {
        Task<ViaCepResponse> getViaCepData(string cep);
    }
}
