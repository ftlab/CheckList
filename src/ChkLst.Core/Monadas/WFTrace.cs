using System;

namespace ChkLst.Core.Monadas
{
    public class WFTrace<Ctx>
    {
        public WFContext<Ctx> WF
        {
            get
            {
                return WFContext<Ctx>.Current;
            }
        }

        public virtual void OnStart()
        {

        }

        public virtual void OnEnd(Exception e)
        {
        }

        public virtual void OnStartExecute(IWFRule<Ctx> rule)
        {
        }

        public virtual void OnEndExecute<Ctx>(IWFRule<Ctx> rule)
        {

        }

        public virtual void OnIf(IWFRule<Ctx> rule, bool result)
        {
        }

        internal void OnThen<Ctx>(IWFRule<Ctx> rule)
        {
            throw new NotImplementedException();
        }

        internal void OnElse<Ctx>(IWFRule<Ctx> rule)
        {
            throw new NotImplementedException();
        }

        internal void OnHalt<Ctx>(IWFRule<Ctx> rule)
        {
            throw new NotImplementedException();
        }
    }
}
