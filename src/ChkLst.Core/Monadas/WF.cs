using System;
using System.Linq;

namespace ChkLst.Core.Monadas
{
    public static class WF<Ctx>
    {
        public static WFTrace<Ctx> Trace { get; } = new WFTrace<Ctx>();

        public static void Execute(Ctx context)
        {
            Guard.ArgumentNotNull(context, nameof(context));

            using (var wf = new WFContext<Ctx>(context))
            {
                Trace.OnStart();
                Exception exception = null;
                try
                {
                    var ruleSet = GetRuleSet(context);
                    wf.RuleSet = Guard.CheckNotNull(ruleSet, nameof(ruleSet));
                    var rules = ruleSet.OrderByDescending(r => r.Priority).ToArray();

                    for (int i = 0; i < rules.Length; i++)
                    {
                        var rule = rules[i];
                        wf.CurrentRule = rule;

                        Trace.OnStartExecute(rule);

                        var result = rule.If(context);
                        Trace.OnIf(rule, result);

                        if (result)
                        {
                            rule.Then(context);
                            Trace.OnThen(rule);
                        }
                        else
                        {
                            rule.Else(context);
                            Trace.OnElse(rule);
                        }

                        if (wf.Break)
                        {
                            Trace.OnHalt(rule);
                            break;
                        }

                        Trace.OnEndExecute(rule);
                    }
                }
                catch (Exception e)
                {
                    exception = e;
                    throw;
                }
                finally
                {
                    Trace.OnEnd(exception);
                }
            }
        }

        private static IWFRuleSet<Ctx> GetRuleSet(Ctx context)
        {
            throw new NotImplementedException();
        }
    }
}
