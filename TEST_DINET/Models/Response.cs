﻿using System;
using System.Text.Json.Serialization;

namespace TEST_DINET.Models
{
	public class Response
	{
        [JsonPropertyName("N_PARM_SAL")]
        public int N_PARM_SAL { get; set; }

        [JsonPropertyName("C_PARM_SAL")]
        public string C_PARM_SAL { get; set; }
	}
}

