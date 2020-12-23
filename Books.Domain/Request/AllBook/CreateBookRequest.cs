using System;
using System.Collections.Generic;
using System.Text;

namespace Books.Domain.Request.AllBook
{
    public class CreateBookRequest
    {
        public string BookName { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
        public int Amount { get; set; }
        public string CategoryName { get; set; }
    }
}
