
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.XimgprocModule
{

    // C++: class AdaptiveManifoldFilter
    /**
     * Interface for Adaptive Manifold Filter realizations.
     *
     * For more details about this filter see CITE: Gastal12 and References_.
     *
     * Below listed optional parameters which may be set up with Algorithm::set function.
     * <ul>
     *   <li>
     *    member double sigma_s = 16.0
     * Spatial standard deviation.
     *   </li>
     *   <li>
     *    member double sigma_r = 0.2
     * Color space standard deviation.
     *   </li>
     *   <li>
     *    member int tree_height = -1
     * Height of the manifold tree (default = -1 : automatically computed).
     *   </li>
     *   <li>
     *    member int num_pca_iterations = 1
     * Number of iterations to computed the eigenvector.
     *   </li>
     *   <li>
     *    member bool adjust_outliers = false
     * Specify adjust outliers using Eq. 9 or not.
     *   </li>
     *   <li>
     *    member bool use_RNG = true
     * Specify use random number generator to compute eigenvector or not.
     *   </li>
     * </ul>
     */

    public class AdaptiveManifoldFilter : Algorithm
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
                        ximgproc_AdaptiveManifoldFilter_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal AdaptiveManifoldFilter(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new AdaptiveManifoldFilter __fromPtr__(IntPtr addr) { return new AdaptiveManifoldFilter(addr); }

        //
        // C++:  void cv::ximgproc::AdaptiveManifoldFilter::filter(Mat src, Mat& dst, Mat joint = Mat())
        //

        /**
         * Apply high-dimensional filtering using adaptive manifolds.
         *
         *     param src filtering image with any numbers of channels.
         *
         *     param dst output image.
         *
         *     param joint optional joint (also called as guided) image with any numbers of channels.
         */
        public void filter(Mat src, Mat dst, Mat joint)
        {
            ThrowIfDisposed();
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
            if (joint != null) joint.ThrowIfDisposed();

            ximgproc_AdaptiveManifoldFilter_filter_10(nativeObj, src.nativeObj, dst.nativeObj, joint.nativeObj);


        }

        /**
         * Apply high-dimensional filtering using adaptive manifolds.
         *
         *     param src filtering image with any numbers of channels.
         *
         *     param dst output image.
         *
         */
        public void filter(Mat src, Mat dst)
        {
            ThrowIfDisposed();
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            ximgproc_AdaptiveManifoldFilter_filter_11(nativeObj, src.nativeObj, dst.nativeObj);


        }


        //
        // C++:  void cv::ximgproc::AdaptiveManifoldFilter::collectGarbage()
        //

        public void collectGarbage()
        {
            ThrowIfDisposed();

            ximgproc_AdaptiveManifoldFilter_collectGarbage_10(nativeObj);


        }


        //
        // C++: static Ptr_AdaptiveManifoldFilter cv::ximgproc::AdaptiveManifoldFilter::create()
        //

        public static AdaptiveManifoldFilter create()
        {


            return AdaptiveManifoldFilter.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ximgproc_AdaptiveManifoldFilter_create_10()));


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  void cv::ximgproc::AdaptiveManifoldFilter::filter(Mat src, Mat& dst, Mat joint = Mat())
        [DllImport(LIBNAME)]
        private static extern void ximgproc_AdaptiveManifoldFilter_filter_10(IntPtr nativeObj, IntPtr src_nativeObj, IntPtr dst_nativeObj, IntPtr joint_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_AdaptiveManifoldFilter_filter_11(IntPtr nativeObj, IntPtr src_nativeObj, IntPtr dst_nativeObj);

        // C++:  void cv::ximgproc::AdaptiveManifoldFilter::collectGarbage()
        [DllImport(LIBNAME)]
        private static extern void ximgproc_AdaptiveManifoldFilter_collectGarbage_10(IntPtr nativeObj);

        // C++: static Ptr_AdaptiveManifoldFilter cv::ximgproc::AdaptiveManifoldFilter::create()
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_AdaptiveManifoldFilter_create_10();

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void ximgproc_AdaptiveManifoldFilter_delete(IntPtr nativeObj);

    }
}
