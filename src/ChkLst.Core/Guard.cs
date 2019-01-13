using System;
using System.Collections;
using System.IO;

namespace ChkLst.Core
{
    public class Guard
    {
        public static T ArgumentNotNull<T>(T arg, string name)
        {
            if (arg == null) throw new ArgumentNullException($"Argument {name}({typeof(T).Name}) is null");

            return arg;
        }

        public static T CheckNotNull<T>(T value, string name, string message = null)
        {
            if (value == null)
            {
                if (message != null) throw new NullReferenceException($"Value {name}({typeof(T).Name}) is null. {message}.");
                else throw new NullReferenceException($"Value {name}({typeof(T).Name}) is null.");
            }

            return value;
        }

        public static void CheckIndexOf(int index, ICollection collection)
        {
            Guard.CheckNotNull(collection, nameof(collection));

            if (index < 0 || index >= collection.Count)
                throw new IndexOutOfRangeException($"Index {index} out of range collection ({collection.GetType().Name}[{collection.Count}])");
        }

        public static void MustBeNull<T>(T value, string name, string message = null)
        {
            if (value != null)
            {
                if (message != null) throw new InvalidOperationException(message);
                else throw new InvalidOperationException($"Value {name}({typeof(T).Name}) must be null.");
            }
        }
    }
}