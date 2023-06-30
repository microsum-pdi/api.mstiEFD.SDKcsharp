using api.mstiEFD.SDKcsharp.Enums;
using api.mstiEFD.SDKcsharp.Services;
using api.mstiEFD.SDKcsharp.ViewModels;

namespace api.mstiEFD.SDKcsharp.Tests.Services
{
    public class HealthServicesTests : GenericTests
    {
        private HealthServices _healthServices;

        public HealthServicesTests()
        {
            EfdConfigAmbienteSDK config = new(TOKEN, URL);
            _healthServices = new(config);
        }

        [Fact]
        public async Task AtualizaFormula()
        {
            var resp = await _healthServices.HealthCheck();
            Assert.Equal(EHttpStatusCode.OK, resp.HttpStatusCode);
        }
    }
}