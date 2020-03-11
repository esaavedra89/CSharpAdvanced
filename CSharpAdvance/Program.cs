using CSharpAdvance.Delegates;
using CSharpAdvance.Events;
using CSharpAdvance.Generics;
using CSharpAdvance.LambdaExpressions;

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
            var video = new Video() { Title = "video 1" };
            //var videoEncoder = new VideoEncoder(); // Publisher.
            var videoEncoder = new VideoEncoder2(); // Publisher.
            var mailService = new MailService(); // Subscriber.
            var messageService = new MessageService(); // Subscriber.
            // We make the subscription of the methods OnVideoEncoded.
            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;// This is a pointer, we just name the method, not called.
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;// Subscribe.

            // Excecute the method.
            videoEncoder.Encode(video); 
            #endregion
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
