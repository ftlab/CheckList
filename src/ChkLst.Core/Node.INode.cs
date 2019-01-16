using System;
using System.Collections.Generic;
using System.Text;

namespace ChkLst.Core
{
    public partial class Node<T> : INode<T>
    {
        T INode<T>.this[int index] { get => this[index]; }

        int INode<T>.Count => Count;

        T INode<T>.GetParent() => Parent;

        int INode<T>.Insert(int index, T item) => Insert(index, item);
    }
}
