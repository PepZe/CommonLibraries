﻿using CommonLibraries.Enum;

namespace CommonLibraries
{
    public class RequestDto
    {
        public ApiType ApiType { get; set; } = ApiType.Get;
        public string Url { get; set; }
        public object Data { get; set; }
        public string AccessToken { get; set; }
    }
}