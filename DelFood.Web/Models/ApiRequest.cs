﻿using static DelFood.Web.SD;

namespace DelFood.Web.Models
{
    public class ApiRequest
    {
        public ApiType ApiType { get; set; } = ApiType.GET;
        public string Url {  get; set; }
        public object Data { get; set; }
        public string AccessToken { get; set; }
    }
}
