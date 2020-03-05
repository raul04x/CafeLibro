using System;
using System.Collections.Generic;
using System.Text;

namespace Cafe.Libro.Entities.Utils
{
    public class BaseRequest<T> where T : class
    {
        public String Message { get; set; }

        public Boolean IsError { get; set; }

        public T Object { get; set; }

        public List<T> Objects { get; set; }
    }
}
