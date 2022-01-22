using System;

namespace OneAPIDotNet.VPL
{

    /// <summary>
    /// Describes the loader handle. This class cannot be inherited.
    /// </summary>
    public sealed class MfxLoader : OneAPIObject
    {

        #region Constructors

        internal MfxLoader(IntPtr ptr)
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