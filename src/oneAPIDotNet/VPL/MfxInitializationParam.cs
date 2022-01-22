using System;

namespace OneAPIDotNet.VPL
{

    /// <summary>
    /// Specifies initialization parameters for API version starting from 2.0. This class cannot be inherited.
    /// </summary>
    public sealed class MfxInitializationParam : OneAPIObject
    {

        #region Constructors

        public MfxInitializationParam()
        {
            this.NativePtr = NativeMethods.oneapi_vpl_mfxInitializationParam_new();
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

            NativeMethods.oneapi_vpl_mfxInitializationParam_delete(this.NativePtr);
        }

        #endregion

    }

}