using api.mstiEFD.SDKcsharp.ViewModels;

namespace api.mstiEFD.SDKcsharp.Services
{
    public class EfdSdkServices
    {
        private readonly EfdConfigAmbienteSDK _configAmbienteSDK;

        private readonly EFD_ContribuicoesServices _efd_ContribuicoesServices;
        private readonly EFD_ICMS_IPIServices _eFD_ICMS_IPIServices;
        private readonly EstoqueServices _estoqueServices;
        private readonly HealthServices _healthServices;
        private readonly NotasFiscaisServices _notasFiscaisServices;

        public EfdSdkServices(EfdConfigAmbienteSDK efdConfigAmbienteSDK)
        {
            _configAmbienteSDK = efdConfigAmbienteSDK;
            _efd_ContribuicoesServices = new(_configAmbienteSDK);
            _eFD_ICMS_IPIServices = new(_configAmbienteSDK);
            _estoqueServices = new(_configAmbienteSDK);
            _healthServices = new(_configAmbienteSDK);
            _notasFiscaisServices = new(_configAmbienteSDK);
        }

        /// <summary>
        /// Serviços relacionados ao arquivo EFD Contribuições
        /// </summary>
        /// <returns></returns>
        public EFD_ContribuicoesServices EFDContribuicoesServices()
        {
            this.VerificaConfiguracaoSDK();
            return _efd_ContribuicoesServices;
        }

        /// <summary>
        /// Serviços relacionados ao arquivo EFD Contribuições
        /// </summary>
        /// <returns></returns>
        public EFD_ICMS_IPIServices EfdIcmsIpiServices()
        {
            VerificaConfiguracaoSDK();
            return _eFD_ICMS_IPIServices;
        }

        /// <summary>
        /// Serviços relacionados ao arquivo EFD ICMS / IPI
        /// </summary>
        /// <returns></returns>
        public EstoqueServices EfdInventarioServices()
        {
            VerificaConfiguracaoSDK();
            return _estoqueServices;
        }

        /// <summary>
        /// Serviços relacionados à verificação da integração com a API
        /// </summary>
        /// <returns></returns>
        public HealthServices EfdHealthServices()
        {
            VerificaConfiguracaoSDK();
            return _healthServices;
        }

        /// <summary>
        /// Serviços relacionados às operações envolvendo notas fiscais
        /// </summary>
        /// <returns></returns>
        public NotasFiscaisServices EfdNotasFiscaisServices()
        {
            VerificaConfiguracaoSDK();
            return _notasFiscaisServices;
        }

        private void VerificaConfiguracaoSDK()
        {
            if (this._configAmbienteSDK == null)
                throw new Exception("Nenhuma configuração de ambiente fornecida ao amiEFD - SDK.");

            if (string.IsNullOrEmpty(this._configAmbienteSDK.Token))
                throw new Exception("Nenhum 'token' de integração fornecido ao amiEFD - SDK.");

            if (string.IsNullOrEmpty(this._configAmbienteSDK.URL))
                throw new Exception("Nenhuma 'URL' de conexão fornecido ao amiEFD - SDK.");
        }
    }
}
