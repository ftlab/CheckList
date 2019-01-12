using System.Collections.Generic;

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
    }
}
