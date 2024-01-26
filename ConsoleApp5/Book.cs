using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Book : Product
    {
        public string Genre { get; set; }

        public Book(string genre)
        {
            this.Genre = genre;
        }
    }
}
