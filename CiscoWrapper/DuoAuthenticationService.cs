using CiscoWrapper.DTOs;
using CiscoWrapper.DTOs.Request;
using CiscoWrapper.DTOs.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Duo;
using CiscoWrapper.DTOs.Configuration;

namespace CiscoWrapper
{
    public class DuoAuthenticationService : IAuthenticationService
    {
        private AuthenticationConfiguration _config;

        public string IntegrationKey => _config.IntegrationKey;

        public string SecretKey => _config.SecretKey;

        public string PostBackUrl => _config.PostBackUrl;

        public string LoggingUrl => _config.LoggingUrl;

        public void Configure(AuthenticationConfiguration configuration)
        {
            this._config = configuration;
        }

        public SingInResponse SingIn(SignInRequest request)
        {
            string hashKey = Web.SignRequest(
                    this._config.IntegrationKey,
                    this._config.SecretKey,
                    request.UserHash,
                    request.UserName
                );
            return new SingInResponse()
            {
                HashKey = hashKey,
                LoggingUrl = this._config.LoggingUrl,
                UrlPostBack = this.PostBackUrl
            };
        }

        public bool VerifySession(VerifySessionRequest VerifySessionRequest)
        {
            return VerifySessionRequest.UserName == Web.VerifyResponse(this._config.IntegrationKey, this._config.SecretKey, VerifySessionRequest.UserHash, VerifySessionRequest.VerificationResponse);
        }
    }
}
