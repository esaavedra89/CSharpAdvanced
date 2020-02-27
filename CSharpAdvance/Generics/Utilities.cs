using System;

namespace CSharpAdvance.Generics
{
    // Generic class where T is a IComparable interface.

    // where T : IComparable
    // where T : Product
    // where T : struct
    // where T : class
    // where T : new()
    public class Utilities<T> where T : IComparable, new()
    {
        /// <summary>
        /// Return the bigger one oarameter.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int Max(int a, int b) 
        {
            // If a is mayor to b return a otherwise return b.
            return a > b ? a : b;
        }

        public void DoSomething(T value) 
        {
            var obj = new T();
        }

        public T Max(T a, T b) 
        {
            // If a compare to b is bigger than 0, return a otherwise return b.
            return a.CompareTo(b) > 0 ? a : b;
        }
    }
}
