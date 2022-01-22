using System;

namespace OneAPIDotNet.VPL
{

    /// <summary>
    /// This class represents the implementation description. This class cannot be inherited.
    /// </summary>
    public sealed class MfxImplDescription : OneAPIObject
    {

        #region Constructors

        public MfxImplDescription()
        {
            this.NativePtr = NativeMethods.oneapi_vpl_mfxImplDescription_new();
        }

        internal MfxImplDescription(IntPtr nativePtr, bool isEnabledDispose = true):
            base(isEnabledDispose)
        {
            this.NativePtr = nativePtr;
        }

        #endregion

        #region Properties

        public MfxAccelerationMode AccelerationMode

        {
            get
            {
                this.ThrowIfDisposed();
                return NativeMethods.oneapi_vpl_mfxImplDescription_get_AccelerationMode(this.NativePtr);
            }
        }

        public MfxVersion ApiVersion
        {
            get
            {
                this.ThrowIfDisposed();
                var ret = NativeMethods.oneapi_vpl_mfxImplDescription_get_ApiVersion(this.NativePtr);
                return new MfxVersion(ret, false);
            }
        }

        public MfxImplType Impl

        {
            get
            {
                this.ThrowIfDisposed();
                return NativeMethods.oneapi_vpl_mfxImplDescription_get_Impl(this.NativePtr);
            }
        }

        public MfxStructVersion Version

        {
            get
            {
                this.ThrowIfDisposed();
                var ret = NativeMethods.oneapi_vpl_mfxImplDescription_get_Version(this.NativePtr);
                return new MfxStructVersion(ret, false);
            }
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

            NativeMethods.oneapi_vpl_mfxImplDescription_delete(this.NativePtr);
        }

        #endregion

    }

}