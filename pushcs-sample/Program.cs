﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Framework.ConfigurationModel;

namespace pushcs_sample
{
    public class Program
    {
        public void Main(string[] args)
        {
			//var configuration = new Configuration();
			//configuration.AddJsonFile("config.json");
			//configuration.AddUserSecrets();

			var ap = new pushcs.Api.ApiRoot();
			var x = ap.Push(Private: "this_is_a_60_char_string_that_looks_like_a_valid_private_key" , Event: "ayy", Payload: "{\"ayy\" : \"lemayo\"}");
        }
    }
}
