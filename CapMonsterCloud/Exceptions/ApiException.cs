﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CapMonsterCloud.Exceptions
{
    public class ApiException : Exception
    {
        public ApiException(string message, Exception inner = null) : base(message, inner)
        {
        }
    }
}
