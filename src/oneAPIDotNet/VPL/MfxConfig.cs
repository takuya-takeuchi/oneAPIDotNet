using System;

namespace OneAPIDotNet.VPL
{

    /// <summary>
    /// Describes the config handle. This class cannot be inherited.
    /// </summary>
    public sealed class MfxConfig : OneAPIObject
    {

        #region Constructors

        internal MfxConfig(IntPtr ptr)
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
        }

        #endregion

    }

}