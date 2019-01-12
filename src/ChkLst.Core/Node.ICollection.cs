using System;
using System.Collections;
using System.Collections.Generic;

namespace ChkLst.Core
{
    public partial class Node<T> : ICollection<T>, ICollection
    {
        int ICollection.Count => Count;

        int ICollection<T>.Count => Count;

        bool ICollection.IsSynchronized => ((ICollection)Nodes).IsSynchronized;

        object ICollection.SyncRoot => ((ICollection)Nodes).SyncRoot;

        bool ICollection<T>.IsReadOnly => ((ICollection<T>)Nodes).IsReadOnly;

        void ICollection<T>.Add(T item) => Add(item);

        void ICollection<T>.Clear() => Clear();

        bool ICollection<T>.Contains(T item) => Contains(item);

        void ICollection.CopyTo(Array array, int index) => ((ICollection)Nodes).CopyTo(array, index);

        void ICollection<T>.CopyTo(T[] array, int arrayIndex) => Nodes.CopyTo(array, arrayIndex);

        bool ICollection<T>.Remove(T item) => Remove(item);
    }
}
