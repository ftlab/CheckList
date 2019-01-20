using System;

namespace ChkLst.Core.Monadas
{
    public class WFRuleBuilder<Ctx>
    {
        private string _name;
        private int _priority;
        private bool _enabled = true;
        private Func<Ctx, bool> _ifCondition;
        private Action<Ctx> _thenAction;
        private Action<Ctx> _elseAction;

        public WFRuleBuilder<Ctx> SetName(string name)
        {
            _name = name;
            return this;
        }

        public WFRuleBuilder<Ctx> SetPriority(int priority)
        {
            _priority = priority;
            return this;
        }

        public WFRuleBuilder<Ctx> SetEnabled(bool enabled)
        {
            _enabled = enabled;
            return this;
        }

        public WFRuleBuilder<Ctx> New(int priority, string name, bool enabled = true)
        {
            return
                SetPriority(priority)
                .SetName(name)
                .SetEnabled(enabled);
        }

        public WFRuleBuilder<Ctx> If(Func<Ctx, bool> ifCondition)
        {
            _ifCondition = ifCondition;
            return this;
        }

        public WFRuleBuilder<Ctx> Then(Action<Ctx> thenAction)
        {
            _thenAction = thenAction;
            return this;
        }

        public WFRuleBuilder<Ctx> Else(Action<Ctx> elseAction)
        {
            _elseAction = elseAction;
            return this;
        }

        public WFRule<Ctx> Build()
        {
            var rule = new WFRule<Ctx>();
            rule.Name = _name;
            rule.Priority = _priority;
            rule.Enabled = _enabled;
            rule.IfCondition = _ifCondition;
            rule.ThenAction = _thenAction;
            rule.ElseAction = _elseAction;

            return rule;
        }
    }
}
