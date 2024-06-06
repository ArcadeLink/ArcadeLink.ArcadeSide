
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.VideoModule
{

    // C++: class SparseOpticalFlow
    /**
     * Base interface for sparse optical flow algorithms.
     */

    public class SparseOpticalFlow : Algorithm
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
                        video_SparseOpticalFlow_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal SparseOpticalFlow(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new SparseOpticalFlow __fromPtr__(IntPtr addr) { return new SparseOpticalFlow(addr); }

        //
        // C++:  void cv::SparseOpticalFlow::calc(Mat prevImg, Mat nextImg, Mat prevPts, Mat& nextPts, Mat& status, Mat& err = cv::Mat())
        //

        /**
         * Calculates a sparse optical flow.
         *
         *     param prevImg First input image.
         *     param nextImg Second input image of the same size and the same type as prevImg.
         *     param prevPts Vector of 2D points for which the flow needs to be found.
         *     param nextPts Output vector of 2D points containing the calculated new positions of input features in the second image.
         *     param status Output status vector. Each element of the vector is set to 1 if the
         *                   flow for the corresponding features has been found. Otherwise, it is set to 0.
         *     param err Optional output vector that contains error response for each point (inverse confidence).
         */
        public void calc(Mat prevImg, Mat nextImg, Mat prevPts, Mat nextPts, Mat status, Mat err)
        {
            ThrowIfDisposed();
            if (prevImg != null) prevImg.ThrowIfDisposed();
            if (nextImg != null) nextImg.ThrowIfDisposed();
            if (prevPts != null) prevPts.ThrowIfDisposed();
            if (nextPts != null) nextPts.ThrowIfDisposed();
            if (status != null) status.ThrowIfDisposed();
            if (err != null) err.ThrowIfDisposed();

            video_SparseOpticalFlow_calc_10(nativeObj, prevImg.nativeObj, nextImg.nativeObj, prevPts.nativeObj, nextPts.nativeObj, status.nativeObj, err.nativeObj);


        }

        /**
         * Calculates a sparse optical flow.
         *
         *     param prevImg First input image.
         *     param nextImg Second input image of the same size and the same type as prevImg.
         *     param prevPts Vector of 2D points for which the flow needs to be found.
         *     param nextPts Output vector of 2D points containing the calculated new positions of input features in the second image.
         *     param status Output status vector. Each element of the vector is set to 1 if the
         *                   flow for the corresponding features has been found. Otherwise, it is set to 0.
         */
        public void calc(Mat prevImg, Mat nextImg, Mat prevPts, Mat nextPts, Mat status)
        {
            ThrowIfDisposed();
            if (prevImg != null) prevImg.ThrowIfDisposed();
            if (nextImg != null) nextImg.ThrowIfDisposed();
            if (prevPts != null) prevPts.ThrowIfDisposed();
            if (nextPts != null) nextPts.ThrowIfDisposed();
            if (status != null) status.ThrowIfDisposed();

            video_SparseOpticalFlow_calc_11(nativeObj, prevImg.nativeObj, nextImg.nativeObj, prevPts.nativeObj, nextPts.nativeObj, status.nativeObj);


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  void cv::SparseOpticalFlow::calc(Mat prevImg, Mat nextImg, Mat prevPts, Mat& nextPts, Mat& status, Mat& err = cv::Mat())
        [DllImport(LIBNAME)]
        private static extern void video_SparseOpticalFlow_calc_10(IntPtr nativeObj, IntPtr prevImg_nativeObj, IntPtr nextImg_nativeObj, IntPtr prevPts_nativeObj, IntPtr nextPts_nativeObj, IntPtr status_nativeObj, IntPtr err_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void video_SparseOpticalFlow_calc_11(IntPtr nativeObj, IntPtr prevImg_nativeObj, IntPtr nextImg_nativeObj, IntPtr prevPts_nativeObj, IntPtr nextPts_nativeObj, IntPtr status_nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void video_SparseOpticalFlow_delete(IntPtr nativeObj);

    }
}
