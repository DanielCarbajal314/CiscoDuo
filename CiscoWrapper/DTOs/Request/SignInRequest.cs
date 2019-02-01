using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiscoWrapper.DTOs.Request
{
    public class SignInRequest
    {
        public string UserHash { get; set; }
        public string UserName { get; set; }
    }
}
