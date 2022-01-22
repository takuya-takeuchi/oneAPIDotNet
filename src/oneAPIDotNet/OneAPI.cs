using System.Text;

namespace OneAPIDotNet
{

    /// <summary>
    /// Provides the methods of oneAPI.
    /// </summary>
    public static partial class OneAPI
    {

        #region Methods

        /// <summary>
        /// Get the string representation of the version of wrapper library of oneAPI.
        /// </summary>
        /// <returns>The string representation of the version of wrapper library of oneAPI.</returns>
        public static string GetNativeVersion()
        {
            return StringHelper.FromStdString(NativeMethods.get_version(), true);
        }

        #endregion

        #region Properties

        private static Encoding _Encoding = Encoding.UTF8;

        public static Encoding Encoding
        {
            get => _Encoding;
            set => _Encoding = value ?? Encoding.UTF8;
        }

        #endregion

    }

}