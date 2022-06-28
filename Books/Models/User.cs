using System.Collections.Generic;

namespace Books.Models
{
    public class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public string surename { get; set; }
        public string groupno { get; set; }
        public string cartnumber { get; set; }
        public string mail { get; set; }
        public string phone  { get; set; }

        public List<BookModel> Books { get; set; }
    }
}
