﻿using FridgeDate.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace FridgeDate.Core.Responses
{
    public class FoodItemResponse : HttpResponseMessage
    {
        public new FoodItem Content;

    }
}
