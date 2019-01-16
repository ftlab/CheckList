using System;
using System.Collections.Generic;
using System.Text;

namespace ChkLst.Core
{
    public abstract partial class Node<T>
        where T : Node<T>
    {
        public T this[int index] { get => Nodes[index]; }

        protected internal T Parent { get; private set; }

        protected internal List<T> Nodes { get; } = new List<T>();

        public int Count => Nodes.Count;

        public bool IsRoot => Parent == null;

        public int Insert(int index, T node)
        {
            if (index < 0 || index > Count) throw new ArgumentOutOfRangeException(nameof(index));
            Guard.ArgumentNotNull(node, nameof(node));
            Guard.MustBeNull(node.Parent, nameof(node.Parent), "Parent must be null");

            Nodes.Insert(index, node);
            node.Parent = (T)this;

            return index;
        }

        public int Add(T node)
        {
            return Insert(Count, node);
        }

        public void Clear()
        {
            var nodes = Nodes.ToArray();

            foreach (var node in nodes)
            {
                //Remove
            }
        }

        public bool Contains(T node)
        {
            return Nodes.Contains(node);
        }

        public bool Remove(T node)
        {
            Guard.ArgumentNotNull(node, nameof(node));

            var removed = Nodes.Remove(node);
            if (removed)
            {
                node.Parent = null;
            }
            return removed;
        }

        public int IndexOf(T node)
        {
            Guard.ArgumentNotNull(node, nameof(node));

            return Nodes.IndexOf(node);
        }

        public void RemoveAt(int index)
        {
            var node = Nodes[index];
            Remove(node);
        }
    }
}
