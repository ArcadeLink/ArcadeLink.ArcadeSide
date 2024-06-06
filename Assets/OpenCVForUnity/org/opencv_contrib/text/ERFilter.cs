#if !UNITY_WSA_10_0

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.TextModule
{

    // C++: class ERFilter
    /**
     * Base class for 1st and 2nd stages of Neumann and Matas scene text detection algorithm CITE: Neumann12. :
     *
     * Extracts the component tree (if needed) and filter the extremal regions (ER's) by using a given classifier.
     */

    public class ERFilter : Algorithm
    {

        protected override void Dispose(bool disposing)
        {

            try
            {
                if (disposing)
                {
                }
                if (IsEnabledDispose)
                {
                    if (nativeObj != IntPtr.Zero)
                        text_ERFilter_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal ERFilter(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new ERFilter __fromPtr__(IntPtr addr) { return new ERFilter(addr); }

#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void text_ERFilter_delete(IntPtr nativeObj);

    }
}

#endif