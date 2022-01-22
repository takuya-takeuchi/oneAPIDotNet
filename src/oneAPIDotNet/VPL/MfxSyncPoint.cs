using System;

namespace OneAPIDotNet.VPL
{

    /// <summary>
    /// Synchronization point object handle. This class cannot be inherited.
    /// </summary>
    public sealed class MfxSyncPoint : OneAPIObject
    {

        #region Constructors

        internal MfxSyncPoint(IntPtr ptr)
        {
            this.NativePtr = ptr;
        }

        #endregion

        #region Overrides 

        /// <summary>
        /// Releases all unmanaged resources.
        /// </summary>
        protected override void DisposeUnmanaged()
        {
            base.DisposeUnmanaged();

            if (this.NativePtr == IntPtr.Zero)
                return;

            // Should use MFXUnload
        }

        #endregion

    }

}