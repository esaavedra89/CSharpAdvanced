using CSharpAdvance.Generics;
using System;

namespace CSharpAdvance
{

    class Program
    {
        static void Main(string[] args)
        {
            #region Using generic list
            //// Console.WriteLine("Hello World!");
            //var book = new Book { Isbn = "1111", Title = "C# Advanced" };

            //// In this case, we can add any object
            ////var numbers = new List();
            ////numbers.Add(10);

            ////var books = new BookList();
            ////books.Add(book);

            //// With the GenericList, we can add every object, because
            //// GenericList allows every kind of object with T parameter.

            //var numbers = new GenericList<int>();
            //numbers.Add(10);

            //var books = new GenericList<Book>();
            ////books.Add(book);
            //books.Add(new Book()); 
            #endregion

            #region Using Generic dictionary
            // With GenericDictionary we can pass two king of object.
            //var dictionary = new GenericDictionary<string, Book>();
            //dictionary.Add("1234", new Book()); 
            #endregion

            var number = new CSharpAdvance.Generics.Nullable<int>();
            Console.WriteLine("Has Value ?" + number.HasValue);
            Console.WriteLine(" Value: " + number.GetValueOrDefault());
        }
    }
}
