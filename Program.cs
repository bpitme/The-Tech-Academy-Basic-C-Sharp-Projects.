using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Harry Potter","JK Rowling",400);
            Book book2 = new Book("Lord of the Rings", "Tolken",700);
            book2.pages = 850;
            
            Console.WriteLine(book2.pages);

            Console.ReadLine();
        }
    }
}
