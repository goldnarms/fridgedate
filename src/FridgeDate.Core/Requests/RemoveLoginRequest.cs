﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FridgeDate.Core.Requests
{
    public class RemoveLoginRequest
    {
        public string LoginProvider { get; set; }

        public string ProviderKey { get; set; }
    }
}