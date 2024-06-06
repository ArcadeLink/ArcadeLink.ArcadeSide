
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.XimgprocModule
{

    // C++: class GuidedFilter
    /**
     * Interface for realizations of Guided Filter.
     *
     * For more details about this filter see CITE: Kaiming10 .
     */

    public class GuidedFilter : Algorithm
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
                        ximgproc_GuidedFilter_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal GuidedFilter(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new GuidedFilter __fromPtr__(IntPtr addr) { return new GuidedFilter(addr); }

        //
        // C++:  void cv::ximgproc::GuidedFilter::filter(Mat src, Mat& dst, int dDepth = -1)
        //

        /**
         * Apply Guided Filter to the filtering image.
         *
         *     param src filtering image with any numbers of channels.
         *
         *     param dst output image.
         *
         *     param dDepth optional depth of the output image. dDepth can be set to -1, which will be equivalent
         *     to src.depth().
         */
        public void filter(Mat src, Mat dst, int dDepth)
        {
            ThrowIfDisposed();
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            ximgproc_GuidedFilter_filter_10(nativeObj, src.nativeObj, dst.nativeObj, dDepth);


        }

        /**
         * Apply Guided Filter to the filtering image.
         *
         *     param src filtering image with any numbers of channels.
         *
         *     param dst output image.
         *
         *     to src.depth().
         */
        public void filter(Mat src, Mat dst)
        {
            ThrowIfDisposed();
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            ximgproc_GuidedFilter_filter_11(nativeObj, src.nativeObj, dst.nativeObj);


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  void cv::ximgproc::GuidedFilter::filter(Mat src, Mat& dst, int dDepth = -1)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_GuidedFilter_filter_10(IntPtr nativeObj, IntPtr src_nativeObj, IntPtr dst_nativeObj, int dDepth);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_GuidedFilter_filter_11(IntPtr nativeObj, IntPtr src_nativeObj, IntPtr dst_nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void ximgproc_GuidedFilter_delete(IntPtr nativeObj);

    }
}
