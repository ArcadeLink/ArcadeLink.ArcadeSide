
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.XimgprocModule
{

    // C++: class FastBilateralSolverFilter
    /**
     * Interface for implementations of Fast Bilateral Solver.
     *
     * For more details about this solver see CITE: BarronPoole2016 .
     */

    public class FastBilateralSolverFilter : Algorithm
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
                        ximgproc_FastBilateralSolverFilter_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal FastBilateralSolverFilter(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new FastBilateralSolverFilter __fromPtr__(IntPtr addr) { return new FastBilateralSolverFilter(addr); }

        //
        // C++:  void cv::ximgproc::FastBilateralSolverFilter::filter(Mat src, Mat confidence, Mat& dst)
        //

        /**
         * Apply smoothing operation to the source image.
         *
         *     param src source image for filtering with unsigned 8-bit or signed 16-bit or floating-point 32-bit depth and up to 3 channels.
         *
         *     param confidence confidence image with unsigned 8-bit or floating-point 32-bit confidence and 1 channel.
         *
         *     param dst destination image.
         *
         *     <b>Note:</b> Confidence images with CV_8U depth are expected to in [0, 255] and CV_32F in [0, 1] range.
         */
        public void filter(Mat src, Mat confidence, Mat dst)
        {
            ThrowIfDisposed();
            if (src != null) src.ThrowIfDisposed();
            if (confidence != null) confidence.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            ximgproc_FastBilateralSolverFilter_filter_10(nativeObj, src.nativeObj, confidence.nativeObj, dst.nativeObj);


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  void cv::ximgproc::FastBilateralSolverFilter::filter(Mat src, Mat confidence, Mat& dst)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_FastBilateralSolverFilter_filter_10(IntPtr nativeObj, IntPtr src_nativeObj, IntPtr confidence_nativeObj, IntPtr dst_nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void ximgproc_FastBilateralSolverFilter_delete(IntPtr nativeObj);

    }
}
