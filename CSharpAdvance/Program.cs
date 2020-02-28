using CSharpAdvance.Delegates;
using CSharpAdvance.Generics;
using System;

namespace CSharpAdvance
{

    class Program
    {
        static void Main(string[] args)
        {
            #region Generics
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

            //var number = new CSharpAdvance.Generics.Nullable<int>();
            //Console.WriteLine("Has Value ?" + number.HasValue);
            //Console.WriteLine(" Value: " + number.GetValueOrDefault()); 
            #endregion

            #region Delegates
            // Instances.
            var photoProcessor = new PhotoProcessor();
            var filters = new PhotoFilters();

            // We apply the delegate with methods.
            // We can use this created in a class or use the default Action<> or Func<>
            //PhotoProcessor.PhotoFilterHandler filterHandler = filters.ApplyBrightness;
            Action<Photo> filterHandler = filters.ApplyBrightness;
            filterHandler += filters.ApplyContast;
            filterHandler += filters.ApplyResize;
            // Using a method created here.
            filterHandler += RemoveRedEyesFilter;
            photoProcessor.Process("photo.png", filterHandler); 
            #endregion
        }

        #region Delegates
        // Custom methods to show how to use another method in that delegate.
        static void RemoveRedEyesFilter(Photo photo)
        {
            Console.WriteLine("Apply RemoveRedEyes");
        } 
        #endregion
    }
}
