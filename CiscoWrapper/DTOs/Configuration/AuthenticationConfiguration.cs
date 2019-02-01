using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiscoWrapper.DTOs.Configuration
{
    public class AuthenticationConfiguration
    {
        public string IntegrationKey { get; set; }
        public string SecretKey { get; set; }
        public string PostBackUrl { get; set; }
        public string LoggingUrl { get; set; }
    }
}
