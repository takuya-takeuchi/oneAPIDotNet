using System;

namespace OneAPIDotNet.VPL
{

    /// <summary>
    /// Describes MFX structures version info. This class cannot be inherited.
    /// </summary>
    public sealed class MfxStructVersion : OneAPIObject
    {

        #region Constructors

        public MfxStructVersion()
        {
            this.NativePtr = NativeMethods.oneapi_vpl_mfxStructVersion_new();
        }

        internal MfxStructVersion(IntPtr nativePtr, bool isEnabledDispose = true):
            base(isEnabledDispose)
        {
            this.NativePtr = nativePtr;
        }

        #endregion

        #region Properties

        public byte Major
        {
            get
            {
                this.ThrowIfDisposed();
                return NativeMethods.oneapi_vpl_mfxStructVersion_get_Major(this.NativePtr);
            }
            set
            {
                this.ThrowIfDisposed();
                NativeMethods.oneapi_vpl_mfxStructVersion_set_Major(this.NativePtr, value);
            }
        }

        public byte Minor
        {
            get
            {
                this.ThrowIfDisposed();
                return NativeMethods.oneapi_vpl_mfxStructVersion_get_Minor(this.NativePtr);
            }
            set
            {
                this.ThrowIfDisposed();
                NativeMethods.oneapi_vpl_mfxStructVersion_set_Minor(this.NativePtr, value);
            }
        }

        public ushort Version
        {
            get
            {
                this.ThrowIfDisposed();
                return NativeMethods.oneapi_vpl_mfxStructVersion_get_Version(this.NativePtr);
            }
            set
            {
                this.ThrowIfDisposed();
                NativeMethods.oneapi_vpl_mfxStructVersion_set_Version(this.NativePtr, value);
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

            NativeMethods.oneapi_vpl_mfxStructVersion_delete(this.NativePtr);
        }

        #endregion

    }

}