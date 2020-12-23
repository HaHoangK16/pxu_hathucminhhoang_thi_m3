using System;
using System.Collections.Generic;
using System.Text;

namespace Books.Domain.Response.AllBook
{
    public class UpdateBookResult
    {
        public int BookId { get; set; }
        public string Message { get; set; }
        public string Result { get; set; }
    }
}
