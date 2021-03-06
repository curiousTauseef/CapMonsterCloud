﻿using CapMonsterCloud.Models.CaptchaTasks;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapMonsterCloud.Models.Requests
{
    internal class CreateTaskRequest : BaseRequest
    {
        /// <summary>
        /// Task data
        /// </summary>
        public CaptchaTask Task { get; set; }
    }
}
