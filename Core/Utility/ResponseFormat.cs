﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utility
{
    public class ResponseFormat
    {
        public bool status { get; set; }
        public string message { get; set; }
        public dynamic? value { get; set; }

    }
}
