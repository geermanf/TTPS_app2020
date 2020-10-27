﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GestionCovid.Configuration
{
    public class TokenConfiguration
    {
        public string IssuerSigningKey { get; set; }
        public string ApiURL { get; set; }
        public string WebAppRootURL { get; set; }
        public int TokenExpirationMinutes { get; set; }

    }
}
