namespace CSharpAdvance.Generics
{
    /// <summary>
    /// Generic class can admit nullable objects.
    /// By the way, this class is not neccesary because the using System have that class.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Nullable<T> where T : struct
    {
        private object _value;

        public Nullable()
        {
        }

        /// <summary>
        /// Receive a generci vale.
        /// </summary>
        /// <param name="value"></param>
        public Nullable(T value)
        {
            _value = value;
        }

        /// <summary>
        /// Return a boolean wheather there is a value.
        /// </summary>
        public bool HasValue
        {
            get { return _value != null; }
        }

        /// <summary>
        /// Return the value in _value or a default value.
        /// </summary>
        /// <returns></returns>
        public T GetValueOrDefault() 
        {
            // If T is different to null, return the value.
            if (HasValue)
                return (T)_value;

            // In case that T is null, return default value.
            return default(T);
        }
    }
}
