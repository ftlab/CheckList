using System;
using System.Threading;

namespace ChkLst.Core.Monadas
{
    public class CallContext<T> : IDisposable
        where T : CallContext<T>
    {
        private static AsyncLocal<T> _local = new AsyncLocal<T>();

        public static T Current
        {
            get
            {
                return _local.Value;
            }
        }

        private T _saved;

        public CallContext()
        {
            _saved = Current;
            _local.Value = Value;
        }

        public T Value { get { return (T)this; } }

        #region IDisposable Support

        private bool disposedValue = false; // To detect redundant calls

        protected virtual void CheckDisposed(string name)
        {
            if (disposedValue) throw new ObjectDisposedException(name);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                _local.Value = _saved;

                if (disposing)
                {
                    DisposeManagedObjects();
                }
                FreeUnmanagedResources();
                disposedValue = true;
            }
        }

        protected virtual void FreeUnmanagedResources()
        {

        }

        protected virtual void DisposeManagedObjects()
        {

        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~CallContext() {
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
