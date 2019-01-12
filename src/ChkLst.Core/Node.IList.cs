using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ChkLst.Core
{
    public partial class Node<T> : IList<T>, IList
    {
        object IList.this[int index] { get => this[index]; set => throw new NotSupportedException(); }

        T IList<T>.this[int index] { get => this[index]; set => throw new NotSupportedException(); }

        bool IList.IsFixedSize => ((IList)Nodes).IsFixedSize;

        bool IList.IsReadOnly => ((IList)Nodes).IsReadOnly;

        int IList.Add(object value) => Add((T)value);

        void IList.Clear() => Clear();

        bool IList.Contains(object value) => Contains((T)value);

        int IList.IndexOf(object value) => IndexOf((T)value);

        int IList<T>.IndexOf(T item) => IndexOf(item);

        void IList.Insert(int index, object value) => Insert(index, (T)value);

        void IList<T>.Insert(int index, T item) => Insert(index, item);

        void IList.Remove(object value) => Remove((T)value);

        void IList.RemoveAt(int index) => RemoveAt(index);

        void IList<T>.RemoveAt(int index) => RemoveAt(index);
    }
}
