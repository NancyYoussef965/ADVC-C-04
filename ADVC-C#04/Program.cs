using System;
using ADVC_C_04;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region

            Book book = new Book(
               "12345",
               "Back End ",
             new string[] { "Nancy", "Youssef" },
               new DateTime(2023, 5, 1),
                       150.75m
);

            Console.WriteLine("Title: " + BookFunctions.GetTitle(book));
            Console.WriteLine("Authors: " + BookFunctions.GetAuthors(book));
            Console.WriteLine("Price: " + BookFunctions.GetPrice(book));
            Console.WriteLine("Publication Date: " + BookFunctions.GetPublicationDate(book));
            Console.WriteLine("\nFull Book Info:\n" + book);

            #endregion




            #region

            MyList<int> numbers = new MyList<int>();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);

            Console.WriteLine(numbers.Exists(x => x > 2));   
            Console.WriteLine(numbers.Find(x => x % 2 == 0));

            var evens = numbers.FindAll(x => x % 2 == 0);
            evens.ForEach(x => Console.WriteLine("Even: " + x));

            Console.WriteLine(numbers.FindIndex(x => x == 3));  
            Console.WriteLine(numbers.FindLast(x => x < 4));    
            Console.WriteLine(numbers.FindLastIndex(x => x % 2 == 0));
            Console.WriteLine(numbers.TrueForAll(x => x > 0));  

            #endregion




        }
    }
}
