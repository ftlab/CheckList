using System;
using System.Collections;
using System.Collections.Generic;

namespace ChkLst.Core.Monadas
{
    public class WFRuleSet<Ctx> : ICollection<IWFRule<Ctx>>, IEnumerable<IWFRule<Ctx>>, ICollection, IEnumerable
    {
        private List<IWFRule<Ctx>> _rules = new List<IWFRule<Ctx>>();

        public int Count { get { return _rules.Count; } }

        public void Add(IWFRule<Ctx> rule)
        {
            _rules.Add(rule);
        }

        public void Add(WFRule<Ctx> rule)
        {
            Add((IWFRule<Ctx>)rule);
        }

        public void Add(Action<WFRuleBuilder<Ctx>> init)
        {
            var builder = new WFRuleBuilder<Ctx>();
            init(builder);
            var rule = builder.Build();
            Add(rule);
        }

        #region ICollection Support

        int ICollection.Count => Count;

        int ICollection<IWFRule<Ctx>>.Count => Count;

        bool ICollection.IsSynchronized => throw new NotImplementedException();

        object ICollection.SyncRoot => throw new NotImplementedException();

        bool ICollection<IWFRule<Ctx>>.IsReadOnly => throw new NotImplementedException();

        void ICollection<IWFRule<Ctx>>.Add(IWFRule<Ctx> item)
        {
            Add(item);
        }

        void ICollection<IWFRule<Ctx>>.Clear()
        {
            throw new NotImplementedException();
        }

        bool ICollection<IWFRule<Ctx>>.Contains(IWFRule<Ctx> item)
        {
            throw new NotImplementedException();
        }

        void ICollection.CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        void ICollection<IWFRule<Ctx>>.CopyTo(IWFRule<Ctx>[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region IEnumerator Support

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _rules.GetEnumerator();
        }

        IEnumerator<IWFRule<Ctx>> IEnumerable<IWFRule<Ctx>>.GetEnumerator()
        {
            return _rules.GetEnumerator();
        }

        bool ICollection<IWFRule<Ctx>>.Remove(IWFRule<Ctx> item)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
