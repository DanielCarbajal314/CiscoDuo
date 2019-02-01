using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiscoWrapper.DTOs.Response
{
    public class SingInResponse
    {
        public string HashKey { get; set; }
        public string LoggingUrl { get; set; }
        public string UrlPostBack { get; set; }
    }
}
