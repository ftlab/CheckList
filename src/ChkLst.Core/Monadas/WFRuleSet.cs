using System;
using System.Collections;
using System.Collections.Generic;

namespace ChkLst.Core.Monadas
{
    public interface IWFRuleSet<Ctx> : IEnumerable<IWFRule<Ctx>>
    {
    }

    public class WFRuleSet<Ctx> : IWFRuleSet<Ctx>, IEnumerable<IWFRule<Ctx>>
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

        IEnumerator<IWFRule<Ctx>> IEnumerable<IWFRule<Ctx>>.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
