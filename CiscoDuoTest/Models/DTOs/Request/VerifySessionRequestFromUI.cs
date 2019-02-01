using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CiscoDuoTest.Models.DTOs.Request
{
    public class VerifySessionRequestFromUI
    {
        public string UserName { get; set; }
        public string VerificationHash { get; set; }
    }
}