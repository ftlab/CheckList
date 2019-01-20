using System;

namespace ChkLst.Core.Monadas
{
    public interface IWFRule<Ctx>
    {
        string Name { get; }
        int Priority { get; }
        bool Enabled { get; }

        bool If(Ctx ctx);
        void Then(Ctx ctx);
        void Else(Ctx ctx);
    }

    public class WFRule<Ctx> : IWFRule<Ctx>
    {
        public string Name { get; set; }
        string IWFRule<Ctx>.Name => Name;

        public int Priority { get; set; }
        int IWFRule<Ctx>.Priority => Priority;

        public bool Enabled { get; set; }
        bool IWFRule<Ctx>.Enabled => Enabled;

        public Func<Ctx, bool> IfCondition { get; set; }

        public Action<Ctx> ThenAction { get; set; }

        public Action<Ctx> ElseAction { get; set; }

        public bool If(Ctx ctx)
        {
            return IfCondition(ctx);
        }

        bool IWFRule<Ctx>.If(Ctx ctx) => If(ctx);

        public void Then(Ctx ctx)
        {
            ThenAction?.Invoke(ctx);
        }

        void IWFRule<Ctx>.Then(Ctx ctx) => Then(ctx);

        public void Else(Ctx ctx)
        {
            ElseAction?.Invoke(ctx);
        }

        void IWFRule<Ctx>.Else(Ctx ctx) => Else(ctx);
    }
}
