using System;
using System.Collections;
using System.Security.Principal;
using ClassLibrary;
using Tree;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Non-generic collection:");
            ArrayList BooksList = new ArrayList();

            BooksList.Add(new Book(1, "Book 1", 1999, 500, 3000));
            BooksList.Add(new Book(2, "Book 2", 2002, 550, 2500));
            BooksList.Add(new Book(3, "Book 3", 2012, 635, 5000));
            BooksList.Add(new Book(4, "Book 4", 2023, 1020, 6000));

            Book expensiveBook = BooksList.OfType<Book>().FirstOrDefault(s => s.Cost > 1000)!;
            Console.WriteLine("expensiveBook - " + expensiveBook);

            BooksList.Remove(BooksList.OfType<Book>().FirstOrDefault(s => s.SerialNumber == 2));

            Console.WriteLine($"The total cost of circulation of {expensiveBook.Name} - {expensiveBook.TotalCostOfCirculation}");

            foreach (Book book in BooksList)
            {
                Console.WriteLine(book);
            }

            Console.WriteLine();

            Console.WriteLine("Generic collection:");
            List<Book> BookGenericList = new List<Book>();

            BookGenericList.Add(new Book(1, "Book 1", 1999, 500, 3000));
            BookGenericList.Add(new Book(2, "Book 2", 2002, 550, 2500));
            BookGenericList.Add(new Book(3, "Book 3", 2012, 635, 5000));
            BookGenericList.Add(new Book(4, "Book 4", 2023, 1020, 6000));

            Book modernBook = BookGenericList.OfType<Book>().FirstOrDefault(s => s.YearOfPublishing == 2023)!;
            Console.WriteLine("modernBook - " + modernBook);

            BookGenericList.Remove(BookGenericList.OfType<Book>().FirstOrDefault(s => s.SerialNumber == 2));

            Console.WriteLine($"The total cost of circulation of {modernBook.Name} - {modernBook.TotalCostOfCirculation}");

            foreach (Book book in BookGenericList)
            {
                Console.WriteLine(book);
            }

            Console.WriteLine();

            Console.WriteLine("Simple array:");
            Book[] BookArray = new Book[4];

            BookArray[0] = new Book(1, "Book 1", 1999, 500, 3000);
            BookArray[1] = new Book(2, "Book 2", 2002, 550, 2500);
            BookArray[2] = new Book(3, "Book 3", 2012, 635, 5000);
            BookArray[3] = new Book(4, "Book 4", 2023, 1020, 6000);
           
            BookArray[2] = null;

            Book bookOf1999Year = Array.Find(BookArray, s => s != null && s.YearOfPublishing == 1999)!;
            Console.WriteLine($"The total cost of circulation of {bookOf1999Year.Name} - {bookOf1999Year.TotalCostOfCirculation}");

            foreach (Book book in BookArray)
            {
                if (book != null)
                {
                    Console.WriteLine(book);
                }
            }

            Console.WriteLine();

            Console.WriteLine("Binary tree");
            BinaryTree<Book> BinaryTree = new BinaryTree<Book>();

            BinaryTree.Add(new Book(1, "Book 1", 1999, 500, 3000));
            BinaryTree.Add(new Book(2, "Book 2", 2002, 550, 2500));
            BinaryTree.Add(new Book(3, "Book 3", 2023, 635, 5000));
            BinaryTree.Add(new Book(4, "Book 4", 2010, 1020, 6000));

            foreach (Book book in BinaryTree)
            {
                if (book != null)
                {
                    Console.WriteLine(book);
                }
            }

            Console.WriteLine();
            BinaryTree.print();
        }
    }
}