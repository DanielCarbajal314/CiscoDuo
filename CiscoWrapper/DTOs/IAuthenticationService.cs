using CiscoWrapper.DTOs.Configuration;
using CiscoWrapper.DTOs.Request;
using CiscoWrapper.DTOs.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiscoWrapper.DTOs
{
    public interface IAuthenticationService
    {
        string IntegrationKey { get; }
        string SecretKey { get; }
        string PostBackUrl { get;}
        string LoggingUrl { get;}

        SingInResponse SingIn(SignInRequest request);
        void Configure(AuthenticationConfiguration configuration);
        bool VerifySession(VerifySessionRequest VerifySessionRequest);
    }
}
