using System;

namespace CSAPI
{
    class Entity : IDisposable
    {
        private bool disposed = false;

        private readonly IntPtr pointer;

        public int Value
        {
            get
            {
                return EntityAPI.GetEntityValueByPointer(pointer);
            }

            set
            {
                EntityAPI.SetEntityValueByPointer(pointer, value);
            }
        }

        public Entity()
        {
            pointer = EntityAPI.CreateEntityPointer();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.

                EntityAPI.DeleteEntity(pointer);

                // TODO: set large fields to null.

                disposed = true;
            }
        }

        ~Entity()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(false);
        }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            GC.SuppressFinalize(this);
        }
    }
}
