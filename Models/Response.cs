using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Response<T>
    {
        public T Item { get; set; }
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public bool HasSucceeded { get; set; } = false;
        public List<string> Errors { get; set; }
    }
}
