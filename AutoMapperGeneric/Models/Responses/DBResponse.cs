using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMapperGeneric.Models.Responses
{
    public class DBResponse<T> where T : class
    {
        public T Data { get; set; }
        public bool IsSuccess { get; set; }
    }
}
