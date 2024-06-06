
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.XimgprocModule
{

    // C++: class ContourFitting
    /**
     * Class for ContourFitting algorithms.
     *     ContourFitting match two contours \( z_a \) and \( z_b \) minimizing distance
     *     \( d(z_a,z_b)=\sum (a_n - s  b_n e^{j(n \alpha +\phi )})^2 \) where \( a_n \) and \( b_n \) are Fourier descriptors of \( z_a \) and \( z_b \) and s is a scaling factor and  \( \phi \) is angle rotation and \( \alpha \) is starting point factor adjustement
     */

    public class ContourFitting : Algorithm
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
                        ximgproc_ContourFitting_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal ContourFitting(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new ContourFitting __fromPtr__(IntPtr addr) { return new ContourFitting(addr); }

        //
        // C++:  void cv::ximgproc::ContourFitting::estimateTransformation(Mat src, Mat dst, Mat& alphaPhiST, double& dist, bool fdContour = false)
        //

        /**
         * Fit two closed curves using fourier descriptors. More details in CITE: PersoonFu1977 and CITE: BergerRaghunathan1998
         *
         *         param src Contour defining first shape.
         *         param dst Contour defining second shape (Target).
         *         param alphaPhiST : \( \alpha \)=alphaPhiST(0,0), \( \phi \)=alphaPhiST(0,1) (in radian), s=alphaPhiST(0,2), Tx=alphaPhiST(0,3), Ty=alphaPhiST(0,4) rotation center
         *         param dist distance between src and dst after matching.
         *         param fdContour false then src and dst are contours and true src and dst are fourier descriptors.
         */
        public void estimateTransformation(Mat src, Mat dst, Mat alphaPhiST, double[] dist, bool fdContour)
        {
            ThrowIfDisposed();
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
            if (alphaPhiST != null) alphaPhiST.ThrowIfDisposed();
            double[] dist_out = new double[1];
            ximgproc_ContourFitting_estimateTransformation_10(nativeObj, src.nativeObj, dst.nativeObj, alphaPhiST.nativeObj, dist_out, fdContour);
            if (dist != null) dist[0] = (double)dist_out[0];

        }

        /**
         * Fit two closed curves using fourier descriptors. More details in CITE: PersoonFu1977 and CITE: BergerRaghunathan1998
         *
         *         param src Contour defining first shape.
         *         param dst Contour defining second shape (Target).
         *         param alphaPhiST : \( \alpha \)=alphaPhiST(0,0), \( \phi \)=alphaPhiST(0,1) (in radian), s=alphaPhiST(0,2), Tx=alphaPhiST(0,3), Ty=alphaPhiST(0,4) rotation center
         *         param dist distance between src and dst after matching.
         */
        public void estimateTransformation(Mat src, Mat dst, Mat alphaPhiST, double[] dist)
        {
            ThrowIfDisposed();
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
            if (alphaPhiST != null) alphaPhiST.ThrowIfDisposed();
            double[] dist_out = new double[1];
            ximgproc_ContourFitting_estimateTransformation_11(nativeObj, src.nativeObj, dst.nativeObj, alphaPhiST.nativeObj, dist_out);
            if (dist != null) dist[0] = (double)dist_out[0];

        }


        //
        // C++:  void cv::ximgproc::ContourFitting::setCtrSize(int n)
        //

        /**
         * set number of Fourier descriptors used in estimateTransformation
         *
         *         param n number of Fourier descriptors equal to number of contour points after resampling.
         */
        public void setCtrSize(int n)
        {
            ThrowIfDisposed();

            ximgproc_ContourFitting_setCtrSize_10(nativeObj, n);


        }


        //
        // C++:  void cv::ximgproc::ContourFitting::setFDSize(int n)
        //

        /**
         * set number of Fourier descriptors when estimateTransformation used vector&lt;Point&gt;
         *
         *         param n number of fourier descriptors used for optimal curve matching.
         */
        public void setFDSize(int n)
        {
            ThrowIfDisposed();

            ximgproc_ContourFitting_setFDSize_10(nativeObj, n);


        }


        //
        // C++:  int cv::ximgproc::ContourFitting::getCtrSize()
        //

        /**
         * return number of fourier descriptors
         */
        public int getCtrSize()
        {
            ThrowIfDisposed();

            return ximgproc_ContourFitting_getCtrSize_10(nativeObj);


        }


        //
        // C++:  int cv::ximgproc::ContourFitting::getFDSize()
        //

        /**
         * return number of fourier descriptors used for optimal curve matching
         */
        public int getFDSize()
        {
            ThrowIfDisposed();

            return ximgproc_ContourFitting_getFDSize_10(nativeObj);


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  void cv::ximgproc::ContourFitting::estimateTransformation(Mat src, Mat dst, Mat& alphaPhiST, double& dist, bool fdContour = false)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_ContourFitting_estimateTransformation_10(IntPtr nativeObj, IntPtr src_nativeObj, IntPtr dst_nativeObj, IntPtr alphaPhiST_nativeObj, double[] dist_out, [MarshalAs(UnmanagedType.U1)] bool fdContour);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_ContourFitting_estimateTransformation_11(IntPtr nativeObj, IntPtr src_nativeObj, IntPtr dst_nativeObj, IntPtr alphaPhiST_nativeObj, double[] dist_out);

        // C++:  void cv::ximgproc::ContourFitting::setCtrSize(int n)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_ContourFitting_setCtrSize_10(IntPtr nativeObj, int n);

        // C++:  void cv::ximgproc::ContourFitting::setFDSize(int n)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_ContourFitting_setFDSize_10(IntPtr nativeObj, int n);

        // C++:  int cv::ximgproc::ContourFitting::getCtrSize()
        [DllImport(LIBNAME)]
        private static extern int ximgproc_ContourFitting_getCtrSize_10(IntPtr nativeObj);

        // C++:  int cv::ximgproc::ContourFitting::getFDSize()
        [DllImport(LIBNAME)]
        private static extern int ximgproc_ContourFitting_getFDSize_10(IntPtr nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void ximgproc_ContourFitting_delete(IntPtr nativeObj);

    }
}
