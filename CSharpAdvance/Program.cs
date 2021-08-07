using CSharpAdvance.Delegates;
using CSharpAdvance.Events;
using CSharpAdvance.ExtensionMethods;
using CSharpAdvance.Generics;
using CSharpAdvance.LambdaExpressions;
using System;
using System.Linq;

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
            //var photoProcessor = new PhotoProcessor();
            //var filters = new PhotoFilters();

            //// We apply the delegate with methods.
            //// We can use this created in a class or use the default Action<> or Func<>
            ////PhotoProcessor.PhotoFilterHandler filterHandler = filters.ApplyBrightness;
            //Action<Photo> filterHandler = filters.ApplyBrightness;
            //filterHandler += filters.ApplyContast;
            //filterHandler += filters.ApplyResize;
            //// Using a method created here.
            //filterHandler += RemoveRedEyesFilter;
            //photoProcessor.Process("photo.png", filterHandler);

            #endregion

            #region Lambda Expressions
            // asrg => expression
            // number => number*number;

            // () => ... without arguments
            // x => ... one  argument
            // (x, y, z) => ... more arguments
            // Func<int, int> square = number => number * number;

            //// Variable.
            //const int factor = 5;

            //// Delegate with argument.
            //Func<int, int> multipler = n => n * factor;

            //// Result.
            //var result = multipler(10);

            // Find all that satisface that method.
            //       var cheapBooks = books.FindAll(IsCheaperThan10Dollars);
            // We can achive this, without using the IsCheaperThan10Dollars methods, only using 
            // Lambda expressions

            // We instanciate the BookRepository and once execute the GetBook method.
            //var books = new BookRepository().GetBook();

            // We get all Book objects, when the Price is < 10.
            //var cheapBooks = books.FindAll(book => book.Price < 10);
            //var cheapBooks = books.FindAll(b => b.Price < 10);

            //for (int i = 0; i < cheapBooks.Count; i++)
            //{
            //    // sHOW THE RESULT.
            //    Console.WriteLine(cheapBooks[i].Title);
            //} 
            #endregion

            #region Events
            // Instances.
            //var video = new Video() { Title = "video 1" };
            ////var videoEncoder = new VideoEncoder(); // Publisher.
            //var videoEncoder = new VideoEncoder2(); // Publisher.
            //var mailService = new MailService(); // Subscriber.
            //var messageService = new MessageService(); // Subscriber.
            //// We make the subscription of the methods OnVideoEncoded.
            //videoEncoder.VideoEncoded += mailService.OnVideoEncoded;// This is a pointer, we just name the method, not called.
            //videoEncoder.VideoEncoded += messageService.OnVideoEncoded;// Subscribe.

            //// Excecute the method.
            //videoEncoder.Encode(video); 
            #endregion

            //string post = "this is a supposed to be a very long  blog post blah blah blah";

            //var shortenedPost = post.Shorten(5);

            //Console.WriteLine(shortenedPost);

            #region Linq

            #region Comentado
            //var books = new CSharpAdvance.LINQ.BookRepository().GetBooks();

            ////LINQ Query Opératos.
            //var cheaperBooks =
            //        from b in books
            //        where b.Price < 10
            //        orderby b.Title
            //        select b;

            //// LINQ Extensions Methods.
            //// With select (.Select(x => x.Title)) you can converto a list o objects into a list of one object, for example
            //// In this case, we convert a List<Book>, into a List<string>.

            //var cheapBooks = books
            //                    .Where(x => x.Price < 10)
            //                    .OrderBy(x => x.Title)
            //                    .Select(x => x.Title);

            //foreach (var item in cheapBooks)
            //{
            //    Console.WriteLine(item);
            //}

            //// This two operations are similar. 
            #endregion

            var books = new CSharpAdvance.LINQ.BookRepository().GetBooks();

            // LINQ Extensions Methods.

            // Skip salta los primeros 2 en este caso
            // Take, toma los 3 siguientes despues del skip.
            //var pagedBooks = books.Skip(2).Take(3);

            //foreach (var item in pagedBooks)
            //{
            //    Console.WriteLine(item.Title + " " + item.Price);
            //}

            // Get the most highest value from the list.
            var maxPriceFromList = books.Max(x => x.Price);
            var moreChipperFromList = books.Min(x => x.Price);
            Console.WriteLine(maxPriceFromList);
            Console.WriteLine(moreChipperFromList);


            #endregion

            //DateTime? date = null;

            //Console.WriteLine("GetValueOrDefault: " + date.GetValueOrDefault());
            //Console.WriteLine("HasValue: " + date.HasValue);
            //Console.WriteLine("Value: " + date.Value);// Get an exeption here because the value is null.

            //DateTime? date = new DateTime(2014,1,1);
            //DateTime date2 = date.GetValueOrDefault();// This way we avoid the mark from Compiler.
            //DateTime? date3 = date2;// In this case there is no neccesary to use method GetValueOrDefault();

            DateTime? date = null;
            // If like a if/else.
            DateTime date2 = date ?? DateTime.Today;
            DateTime date3 = (date != null ? date.GetValueOrDefault() : DateTime.Today);

            Console.WriteLine(date2);
        }

        #region Delegates

        // Custom methods to show how to use another method in that delegate.
        //static void RemoveRedEyesFilter(Photo photo)
        //{
        //    Console.WriteLine("Apply RemoveRedEyes");
        //} 

        #endregion

        #region LambdaExpressions
        //static int Square(int number)
        //{
        //    return number * number;
        //} 

        //static bool IsCheaperThan10Dollars(Book book) 
        //{
        //    // if book.Price < 10 return true, else return false.
        //    // Here we are making a comparition.
        //    return book.Price < 10;
        //}
        #endregion


    }
}
