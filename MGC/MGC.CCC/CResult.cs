using System;
using System.Collections.Generic;
using System.Text;

namespace MGC.CCC
{
    public class CResult<T>
    {
        public bool IsSucceeded { get; set; }
        public string Message { get; set; }
        public string Data { get; set; }
        public string Id { get; set; }
        public T Model { get; set; }
    }

    public class CResult
    {
        public bool IsSucceeded { get; set; }
        public string Message { get; set; }
    }
}
