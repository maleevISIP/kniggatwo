using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace сп_книггату
{
    class Book
    {
        private int year;
        public int sYear
        {
            get
            {
                return year;
            }

            set
            {
                if (value > 2020)
                    year = 2020;
                else if (value < 1940)
                    year = 1940;
                else year = value;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            book.sYear = 2050;
            Console.WriteLine(book.sYear + " (Стандарт -- 2020)");
            book.sYear = 1974;
            Console.WriteLine(book.sYear);
            Console.ReadKey();
        }
    }
}
