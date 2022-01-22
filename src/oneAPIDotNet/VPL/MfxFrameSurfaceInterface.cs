using System;

// oneAPI
using mfxChar = System.Char;
using mfxU8 = System.Byte;
using mfxU16 = System.UInt16;
using mfxU32 = System.UInt32;
using mfxU64 = System.UInt64;
using mfxI8 = System.SByte;
using mfxI16 = System.Int16;
using mfxI32 = System.Int32;
using mfxI64 = System.Int64;
using mfxF64 = System.Double;
using mfxIMPL = System.Int32;
using mfxF32 = System.Single;
using mfxHDL = System.IntPtr;
using mfxMemId = System.IntPtr;
using mfxThreadTask = System.IntPtr;

namespace OneAPIDotNet.VPL
{

    /// <summary>
    /// Specifies frame surface interface. This class cannot be inherited.
    /// </summary>
    public sealed class MfxFrameSurfaceInterface : OneAPIObject
    {

        #region Constructors

        internal MfxFrameSurfaceInterface(IntPtr nativePtr, bool isEnabledDispose = true):
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
        }

        #endregion

        #region Methods

        public MfxStatus Map(MfxFrameSurface1 surface, MfxMemoryFlags flags)
        {
            if (surface == null)
                throw new ArgumentNullException(nameof(surface));

            surface.ThrowIfDisposed();

            return NativeMethods.oneapi_vpl_mfxFrameSurfaceInterface_Map(this.NativePtr, surface.NativePtr, flags);
        } 

        public MfxStatus Release(MfxFrameSurface1 surface)
        {
            if (surface == null)
                throw new ArgumentNullException(nameof(surface));

            surface.ThrowIfDisposed();

            return NativeMethods.oneapi_vpl_mfxFrameSurfaceInterface_Release(this.NativePtr, surface.NativePtr);
        } 

        public MfxStatus Synchronize(MfxFrameSurface1 surface, mfxU32 wait)
        {
            if (surface == null)
                throw new ArgumentNullException(nameof(surface));

            surface.ThrowIfDisposed();

            return NativeMethods.oneapi_vpl_mfxFrameSurfaceInterface_Synchronize(this.NativePtr, surface.NativePtr, wait);
        } 

        public MfxStatus Unmap(MfxFrameSurface1 surface)
        {
            if (surface == null)
                throw new ArgumentNullException(nameof(surface));

            surface.ThrowIfDisposed();

            return NativeMethods.oneapi_vpl_mfxFrameSurfaceInterface_Unmap(this.NativePtr, surface.NativePtr);
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