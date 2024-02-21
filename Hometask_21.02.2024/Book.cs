using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask_21._02._2024
{
    internal class Book
    {
        public string name;
        public string author;

        public Book()
        {
            Console.WriteLine("PB101");
        }
        public Book(string name) 
        {
            Console.WriteLine("12321312");
        }

        public Book(string name, string author)
        {
            this.name = name;
            this.author = author;
        }
    }
}
