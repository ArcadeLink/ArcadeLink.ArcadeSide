
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.PhotoModule
{

    // C++: class MergeExposures
    /**
     * The base class algorithms that can merge exposure sequence to a single image.
     */

    public class MergeExposures : Algorithm
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
                        photo_MergeExposures_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal MergeExposures(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new MergeExposures __fromPtr__(IntPtr addr) { return new MergeExposures(addr); }

        //
        // C++:  void cv::MergeExposures::process(vector_Mat src, Mat& dst, Mat times, Mat response)
        //

        /**
         * Merges images.
         *
         *     param src vector of input images
         *     param dst result image
         *     param times vector of exposure time values for each image
         *     param response 256x1 matrix with inverse camera response function for each pixel value, it should
         *     have the same number of channels as images.
         */
        public virtual void process(List<Mat> src, Mat dst, Mat times, Mat response)
        {
            ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
            if (times != null) times.ThrowIfDisposed();
            if (response != null) response.ThrowIfDisposed();
            Mat src_mat = Converters.vector_Mat_to_Mat(src);
            photo_MergeExposures_process_10(nativeObj, src_mat.nativeObj, dst.nativeObj, times.nativeObj, response.nativeObj);


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  void cv::MergeExposures::process(vector_Mat src, Mat& dst, Mat times, Mat response)
        [DllImport(LIBNAME)]
        private static extern void photo_MergeExposures_process_10(IntPtr nativeObj, IntPtr src_mat_nativeObj, IntPtr dst_nativeObj, IntPtr times_nativeObj, IntPtr response_nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void photo_MergeExposures_delete(IntPtr nativeObj);

    }
}
