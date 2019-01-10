using System;
using System.IO;

namespace ChkLst.Core
{
    internal class Guard
    {
        internal static T ArgumentNotNull<T>(T arg, string name)
        {
            if (arg == null) throw new ArgumentNullException($"{typeof(T).Name}: {name}");

            return arg;
        }
    }
}