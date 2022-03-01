using System;
using System.Collections.Generic;
using System.Text;

namespace ListDelegateTask.Models
{
    class Library
    {
        private List<Book> _books;
        public List<Book> Books => _books;

        public Library()
        {
            _books = new List<Book>();
        }
        public void AddBook(string name, string authorName, int pageCount)
        {
            Book book = new Book(name, authorName, pageCount);
            _books.Add(book);
        }
        public List<Book> FindAllBooksByName(string search)
        {
            List<Book> book = new List<Book>();
            foreach (var item in _books)
            {
                if (item.Name.ToLower().Contains(search.ToLower()))
                {
                    book.Add(item);
                }
            }
            return book;

        }
        public void RemoveAllBookByName(string search)
        {
            List<Book> book = new List<Book>();
            foreach (var item in _books)
            {
                if (item.Name.ToLower().Contains(search.ToLower()))
                {
                    book.Add(item);
                }
            }
            foreach (var item in book)
            {
                _books.Remove(item);
            }
        }

        public List<Book> SearchBooks(string search)
        {
            List<Book> books = new List<Book>();
            foreach (var item in _books)
            {
                if (item.Name.ToLower().Contains(search.ToLower()) || item.PageCount.ToString().Contains(search) || item.AuthorName.ToLower().Contains(search.ToLower()))
                {
                    books.Add(item);
                }
            }
            return books;
        }
        public List<Book> FindAllBooksByPageCountRange(int minCount, int maxCount)
        {
            List<Book> book = new List<Book>();
            foreach (var item in _books)
            {
                if (item.PageCount>minCount && item.PageCount<maxCount)
                {
                    book.Add(item);
                }
            }
            return book;
        }
        public void RemoveByNo(string search)
        {
            Book bookRemove = null;
            foreach (var item in _books)
            {
                if (item.Code.ToLower().Contains(search.ToLower()))
                {
                    bookRemove = item;
                }
            }
            _books.Remove(bookRemove);
        }
        public void GetBook()
        {
            foreach (var item in _books)
            {
                Console.WriteLine($"{item}\n");
            }
        }
    }
}
