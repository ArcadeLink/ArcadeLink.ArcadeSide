
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.XimgprocModule
{

    // C++: class FastGlobalSmootherFilter
    /**
     * Interface for implementations of Fast Global Smoother filter.
     *
     * For more details about this filter see CITE: Min2014 and CITE: Farbman2008 .
     */

    public class FastGlobalSmootherFilter : Algorithm
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
                        ximgproc_FastGlobalSmootherFilter_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal FastGlobalSmootherFilter(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new FastGlobalSmootherFilter __fromPtr__(IntPtr addr) { return new FastGlobalSmootherFilter(addr); }

        //
        // C++:  void cv::ximgproc::FastGlobalSmootherFilter::filter(Mat src, Mat& dst)
        //

        /**
         * Apply smoothing operation to the source image.
         *
         *     param src source image for filtering with unsigned 8-bit or signed 16-bit or floating-point 32-bit depth and up to 4 channels.
         *
         *     param dst destination image.
         */
        public void filter(Mat src, Mat dst)
        {
            ThrowIfDisposed();
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            ximgproc_FastGlobalSmootherFilter_filter_10(nativeObj, src.nativeObj, dst.nativeObj);


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  void cv::ximgproc::FastGlobalSmootherFilter::filter(Mat src, Mat& dst)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_FastGlobalSmootherFilter_filter_10(IntPtr nativeObj, IntPtr src_nativeObj, IntPtr dst_nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void ximgproc_FastGlobalSmootherFilter_delete(IntPtr nativeObj);

    }
}
