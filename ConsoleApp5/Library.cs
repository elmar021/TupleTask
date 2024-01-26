using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Library
    {
        public Book[] Books =Array.Empty<Book>();
        public void AddBook(Book book)
        {
            Array.Resize(ref Books, Books.Length+1);
            Books[^1] = book;
        }

        public Book[] GetFiltereedBooks(string value)
        {
            Book[] newArr1 = new Book[] { };
            for (int i = 0; i < Books.Length; i++)
            {
                
                if (Books[i].Genre == value)
                {
                    Array.Resize(ref newArr1, newArr1.Length + 1);
                    newArr1[^1] = Books[i];
                }
            }
            return newArr1;
        }

        public Book[] GetFiltereedBooks(int minPrice , int maxPrice)
        {
            Book[] newArr = new Book[0] ;
            for(int i = 0;i < Books.Length;i++)
            {
                if (minPrice < Books[i].Price && maxPrice > Books[i].Price)
                {
                    Array.Resize(ref newArr, newArr.Length+1);
                    newArr[^1] = Books[i];
                }
            }
            return newArr;


        }
    }
}
