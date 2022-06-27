using System;

namespace Books.Models
{
    public class UserBookKap
    {
        public int Id { get; set; }

        public int BookId { get; set; }
        public BookModel Book { get; set; }

        public int StudentId { get; set; }
        public User User { get; set; }
    }
}
