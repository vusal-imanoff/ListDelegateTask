using ListDelegateTask.Models;
using System;
using System.Collections.Generic;

namespace ListDelegateTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            library.AddBook("Sefiller", "Viktor", 125);
            library.AddBook("Filler", "Vusal", 100);
            library.AddBook("Alqoritma", "Isaq", 400);
            library.AddBook("Proqramlasdirma", "Hemid", 150);
            library.AddBook("Salam", "Camal", 78);
            //library.GetBook();
            //library.RemoveByNo("SE1");
            //library.RemoveAllBookByName("salam");
            //library.GetBook();
            //ShowBook(library.SearchBooks("fil"));
            //ShowBook(library.FindAllBooksByPageCountRange(70, 110));
            ShowBook(library.SearchBooks("Vusal")); 
      
        }
        static void ShowBook(List<Book> books)
        {
            foreach (var item in books)
            {
                Console.WriteLine("************");
                Console.WriteLine(item);
                Console.WriteLine("************");
            }
        }
    }
}
