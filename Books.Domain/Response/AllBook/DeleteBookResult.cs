using System;
using System.Collections.Generic;
using System.Text;

namespace Books.Domain.Response.AllBook
{
    public class DeleteBookResult
    {
        public int BookId { get; set; }
        public string Message { get; set; }
    }
}
