using System;

namespace OneAPIDotNet.VPL
{

    /// <summary>
    /// Defines the uncompressed frames surface information and data buffers. This class cannot be inherited.
    /// </summary>
    public sealed class MfxFrameSurface1 : OneAPIObject
    {

        #region Constructors

        internal MfxFrameSurface1(IntPtr nativePtr, bool isEnabledDispose = true):
            base(isEnabledDispose)
        {
            this.NativePtr = nativePtr;
        }

        #endregion

        #region Properties

        public MfxFrameData Data
        {
            get
            {
                this.ThrowIfDisposed();
                var ret = NativeMethods.oneapi_vpl_mfxFrameSurface1_get_Data(this.NativePtr);
                return new MfxFrameData(ret, false);
            }
        }

        public MfxFrameSurfaceInterface FrameInterface
        {
            get
            {
                this.ThrowIfDisposed();
                var ret = NativeMethods.oneapi_vpl_mfxFrameSurface1_get_FrameInterface(this.NativePtr);
                return new MfxFrameSurfaceInterface(ret, false);
            }
        }

        public MfxFrameInfo Info
        {
            get
            {
                this.ThrowIfDisposed();
                var ret = NativeMethods.oneapi_vpl_mfxFrameSurface1_get_Info(this.NativePtr);
                return new MfxFrameInfo(ret, false);
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

            // NativeMethods.oneapi_vpl_mfxVersion_delete(this.NativePtr);
        }

        #endregion

    }

}