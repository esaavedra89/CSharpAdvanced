using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAdvance.Generics
{
    public class BookList
    {
        public void Add() 
        {
            throw new NotImplementedException();
        }

        public Book this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }

    /// <summary>
    /// We can pass two kind of object.
    /// </summary>
    /// <typeparam name="TKey"></typeparam>
    /// <typeparam name="TValue"></typeparam>
    public class GenericDictionary<TKey, TValue>
    {
        public void Add(TKey key, TValue value)
        {

        }
    }

    /// <summary>
    /// Generic list can allow any king of object.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class GenericList<T> 
    {
        /// <summary>
        /// Method can receive every kind of object.
        /// </summary>
        /// <param name="value"></param>
        public void Add(T value)
        {
            
        }

        public T this[int index] 
        {
            get { throw new NotImplementedException(); }
        }
    }
}
