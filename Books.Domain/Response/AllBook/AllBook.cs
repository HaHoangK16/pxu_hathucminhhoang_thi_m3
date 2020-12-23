using System;

namespace Books.Domain
{
    public class AllBook
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
        public int Amount { get; set; }
        public string CategoryName { get; set; }
    }
}
