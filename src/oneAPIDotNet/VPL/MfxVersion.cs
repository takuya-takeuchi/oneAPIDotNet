using System;

namespace OneAPIDotNet.VPL
{

    /// <summary>
    /// Describes the version of the implementation. This class cannot be inherited.
    /// </summary>
    public sealed class MfxVersion : OneAPIObject
    {

        #region Constructors

        public MfxVersion()
        {
            this.NativePtr = NativeMethods.oneapi_vpl_mfxVersion_new();
        }

        internal MfxVersion(IntPtr nativePtr, bool isEnabledDispose = true):
            base(isEnabledDispose)
        {
            this.NativePtr = nativePtr;
        }

        #endregion

        #region Properties

        public ushort Major
        {
            get
            {
                this.ThrowIfDisposed();
                return NativeMethods.oneapi_vpl_mfxVersion_get_Major(this.NativePtr);
            }
            set
            {
                this.ThrowIfDisposed();
                NativeMethods.oneapi_vpl_mfxVersion_set_Major(this.NativePtr, value);
            }
        }

        public ushort Minor
        {
            get
            {
                this.ThrowIfDisposed();
                return NativeMethods.oneapi_vpl_mfxVersion_get_Minor(this.NativePtr);
            }
            set
            {
                this.ThrowIfDisposed();
                NativeMethods.oneapi_vpl_mfxVersion_set_Minor(this.NativePtr, value);
            }
        }

        public uint Version
        {
            get
            {
                this.ThrowIfDisposed();
                return NativeMethods.oneapi_vpl_mfxVersion_get_Version(this.NativePtr);
            }
            set
            {
                this.ThrowIfDisposed();
                NativeMethods.oneapi_vpl_mfxVersion_set_Version(this.NativePtr, value);
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

            NativeMethods.oneapi_vpl_mfxVersion_delete(this.NativePtr);
        }

        #endregion

    }

}