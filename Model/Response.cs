﻿using Newtonsoft.Json;

namespace Shared_Static_Class.Models
{
    public class Response<T>
    {
        [JsonProperty("data")]
        public T Data { get; set; }
        public bool Succeeded { get; set; }
        [JsonProperty("errors")]
        public string[] Errors { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }
    }
}
