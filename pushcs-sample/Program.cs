﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pushcs_sample
{
    public class Program
    {
        public void Main(string[] args)
        {
			var ar = new pushcs.Api.ApiRoot();

			ar.Push("asadasdasd", "asdasdasd");
        }
    }
}
