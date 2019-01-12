using System.Collections;
using System.Collections.Generic;

namespace ChkLst.Core
{
    public interface INode<T> :
          IList<T>
        , ICollection<T>
        , IEnumerable<T>
        , IList
        , ICollection
        , IEnumerable
        where T : INode<T>
    {
        new int Count { get; }

        new T this[int index] { get; }

        T GetParent();
    }
}
