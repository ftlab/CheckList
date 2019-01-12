using System;
using System.Collections;
using System.Collections.Generic;

namespace ChkLst.Core
{
    public partial class Node<T> : IEnumerable<T>, IEnumerable
    {
        IEnumerator IEnumerable.GetEnumerator() => Nodes.GetEnumerator();

        IEnumerator<T> IEnumerable<T>.GetEnumerator() => Nodes.GetEnumerator();
    }
}
