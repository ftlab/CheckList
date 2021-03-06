﻿using System;

namespace ChkLst.Core.Monadas
{
    public class WFContext<Ctx> : CallContext<WFContext<Ctx>>
    {
        public WFContext(Ctx context) : base()
        {
            Context = Guard.ArgumentNotNull(context, nameof(context));

        }
        public Ctx Context { get; }
        public IWFRule<Ctx> CurrentRule { get; internal set; }
        public IWFRuleSet<Ctx> RuleSet { get; internal set; }
        public bool Break { get; internal set; }

        #region IDisposable Support

        private bool disposedValue = false; // To detect redundant calls



        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~WFContext() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion
    }
}
