using System;
using System.Collections.Generic;
using System.Text;

namespace ListDelegateTask.Models
{
    class Book
    {
        private static int _count = 1;
        public string  Name { get; set; }
        public string AuthorName { get; set; }
        public int PageCount { get; set; }
        public string Code { get; set; }
        public Book(string name, string authorName,int pageCount)
        {
            Name = name;
            AuthorName = authorName;
            PageCount = pageCount;
            Code = $"{name[0..2].ToUpper()}{_count}";
            _count++;
        }
        public override string ToString()
        {
            return $"Book Code: {Code}\nBook Name: {Name}\nAuthor Name: {AuthorName}\nPage Count: {PageCount}";
        }
    }
}
