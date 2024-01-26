using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Product
    {
        public string No { get; set; }
        public  string Name { get; set; }
        private int _price;
        private int _count;
        public int Price
        {
            get 
            {
                return _price;
            }
            set
            {
                if (value > 0) 
                {
                    _price = value;
                }
               
            }
        }

        public int Count
        {
            get
            {
                return _count;
            }
            set
            {
                if (value > 0)
                {
                    _count = value;
                }

            }
        }

    }
}
