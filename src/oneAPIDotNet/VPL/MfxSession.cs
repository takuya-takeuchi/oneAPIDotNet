using System;

namespace OneAPIDotNet.VPL
{

    /// <summary>
    /// Describes the session handle. This class cannot be inherited.
    /// </summary>
    public sealed class MfxSession : OneAPIObject
    {

        #region Constructors

        internal MfxSession(IntPtr ptr)
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

            //NativeMethods.oneapi_vpl_mfxVersion_delete(this.NativePtr);
        }

        #endregion

    }

}