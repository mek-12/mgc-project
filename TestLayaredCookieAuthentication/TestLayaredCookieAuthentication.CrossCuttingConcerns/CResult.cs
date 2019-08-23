using System;
using System.Collections.Generic;
using System.Text;

namespace TestLayaredCookieAuthentication.CrossCuttingConcerns
{
    public class CResult<T>
    {
        public bool IsSucceeded { get; set; }
        public string Description { get; set; }
        public string Data { get; set; }
        public string Id { get; set; }
        public T Object { get; set; }
    }
}
