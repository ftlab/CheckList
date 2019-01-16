using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace ChkLst.Core
{
    public static class NodeExtension
    {
        public static T AddNearSelf<T>(this T current, T next, int offset)
            where T : INode<T>
        {
            Guard.ArgumentNotNull(current, nameof(current));

            var parent = current.GetParent();
            Guard.CheckNotNull(parent, nameof(parent), "Parent is null");

            var index = parent.IndexOf(current);
            Guard.CheckIndexOf(index, parent);

            index = index + offset + 1;
            parent.Insert(index, next);

            return next;
        }

        public static T AddBeforeSelf<T>(this T current, T next)
            where T : INode<T>
            => AddNearSelf(current, next, -1);

        public static T AddAfterSelf<T>(this T current, T next)
            where T : INode<T>
            => AddNearSelf(current, next, 0);

        public static T GetNear<T>(this T current, int offset)
            where T : INode<T>
        {
            Guard.ArgumentNotNull(current, nameof(current));

            var parent = current.GetParent();
            Guard.CheckNotNull(parent, nameof(parent), "Parent is null");

            var index = parent.IndexOf(current);
            Guard.CheckIndexOf(index, parent);

            index += offset;

            T next = default(T);
            if (index >= 0 && index < parent.Count)
                next = parent[index];

            return next;
        }

        public static T GetNext<T>(this T current)
            where T : INode<T>
            => GetNear(current, 1);

        public static T GetPrevious<T>(this T current)
            where T : INode<T>
            => GetNear(current, -1);

        public static T Delete<T>(this T node)
            where T : INode<T>
        {
            Guard.ArgumentNotNull(node, nameof(node));

            var parent = node.GetParent();
            Guard.CheckNotNull(parent, nameof(parent), "Parent is null");

            parent.Remove(node);

            return parent;
        }

        public static T GetRoot<T>(this T node)
            where T : INode<T>
        {
            var root = node;
            var current = node;
            while (current != null)
            {
                root = current;
                current = current.GetParent();
            }
            return root;
        }

        public static void Visit<T>(this T node, Action<T> observer)
            where T : INode<T>
        {
            Guard.ArgumentNotNull(node, nameof(node));
            Guard.ArgumentNotNull(observer, nameof(observer));

            observer(node);
            foreach (var child in node)
                child.Visit(observer);
        }

        public static int GetPosition<T>(this T node)
            where T : INode<T>
        {
            Guard.ArgumentNotNull(node, nameof(node));

            var root = node.GetRoot();

            int pos = -1;
            bool stop = false;
            root.Visit(n =>
            {
                if (stop == false)
                {
                    pos++;
                    if (node.Equals(n))
                        stop = true;
                }
            });

            return pos;
        }

        public static void AddAbove<T>(this T node, T newNode)
            where T : INode<T>
        {
            Guard.ArgumentNotNull(node, nameof(node));
            Guard.ArgumentNotNull(newNode, nameof(newNode));

            var position = node.GetPosition();
            var root = node.GetRoot();
            T last = default(T);
            T prev = default(T);

            position--;

            root.Visit(n =>
            {
                last = n;
                if (position == 0)
                    prev = n;

                position--;
            });

            if (prev == null)
                prev = last;

            if (prev.IsRoot)
                prev.Add(newNode);
            else
                prev.AddAfterSelf(newNode);
        }

        public static void AddBelow<T>(this T node, T newNode)
            where T : INode<T>
        {
            Guard.ArgumentNotNull(node, nameof(node));
            Guard.ArgumentNotNull(newNode, nameof(newNode));

            var position = node.GetPosition();
            var root = node.GetRoot();
            T last = default(T);
            T prev = default(T);

            position++;

            root.Visit(n =>
            {
                last = n;
                if (position == 0)
                    prev = n;
                position--;
            });

            if (prev == null)
                prev = last;

            if (prev.IsRoot)
                prev.Add(newNode);
            else
                prev.AddBeforeSelf(newNode);
        }
    }
}
