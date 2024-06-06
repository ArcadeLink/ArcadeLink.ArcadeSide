
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.XimgprocModule
{

    // C++: class EdgeDrawing
    /**
     * Class implementing the ED (EdgeDrawing) CITE: topal2012edge, EDLines CITE: akinlar2011edlines, EDPF CITE: akinlar2012edpf and EDCircles CITE: akinlar2013edcircles algorithms
     */

    public class EdgeDrawing : Algorithm
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
                        ximgproc_EdgeDrawing_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal EdgeDrawing(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new EdgeDrawing __fromPtr__(IntPtr addr) { return new EdgeDrawing(addr); }

        // C++: enum cv.ximgproc.EdgeDrawing.GradientOperator
        public const int PREWITT = 0;
        public const int SOBEL = 1;
        public const int SCHARR = 2;
        public const int LSD = 3;
        //
        // C++:  void cv::ximgproc::EdgeDrawing::detectEdges(Mat src)
        //

        /**
         * Detects edges in a grayscale image and prepares them to detect lines and ellipses.
         *
         *     param src 8-bit, single-channel, grayscale input image.
         */
        public void detectEdges(Mat src)
        {
            ThrowIfDisposed();
            if (src != null) src.ThrowIfDisposed();

            ximgproc_EdgeDrawing_detectEdges_10(nativeObj, src.nativeObj);


        }


        //
        // C++:  void cv::ximgproc::EdgeDrawing::getEdgeImage(Mat& dst)
        //

        /**
         * returns Edge Image prepared by detectEdges() function.
         *
         *     param dst returns 8-bit, single-channel output image.
         */
        public void getEdgeImage(Mat dst)
        {
            ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            ximgproc_EdgeDrawing_getEdgeImage_10(nativeObj, dst.nativeObj);


        }


        //
        // C++:  void cv::ximgproc::EdgeDrawing::getGradientImage(Mat& dst)
        //

        /**
         * returns Gradient Image prepared by detectEdges() function.
         *
         *     param dst returns 16-bit, single-channel output image.
         */
        public void getGradientImage(Mat dst)
        {
            ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            ximgproc_EdgeDrawing_getGradientImage_10(nativeObj, dst.nativeObj);


        }


        //
        // C++:  vector_vector_Point cv::ximgproc::EdgeDrawing::getSegments()
        //

        /**
         * Returns std::vector&lt;std::vector&lt;Point&gt;&gt; of detected edge segments, see detectEdges()
         * return automatically generated
         */
        public List<MatOfPoint> getSegments()
        {
            ThrowIfDisposed();
            List<MatOfPoint> retVal = new List<MatOfPoint>();
            Mat retValMat = new Mat(DisposableObject.ThrowIfNullIntPtr(ximgproc_EdgeDrawing_getSegments_10(nativeObj)));
            Converters.Mat_to_vector_vector_Point(retValMat, retVal);
            return retVal;
        }


        //
        // C++:  vector_int cv::ximgproc::EdgeDrawing::getSegmentIndicesOfLines()
        //

        /**
         * Returns for each line found in detectLines() its edge segment index in getSegments()
         * return automatically generated
         */
        public MatOfInt getSegmentIndicesOfLines()
        {
            ThrowIfDisposed();

            return MatOfInt.fromNativeAddr(DisposableObject.ThrowIfNullIntPtr(ximgproc_EdgeDrawing_getSegmentIndicesOfLines_10(nativeObj)));


        }


        //
        // C++:  void cv::ximgproc::EdgeDrawing::detectLines(Mat& lines)
        //

        /**
         * Detects lines.
         *
         *     param lines  output Vec&lt;4f&gt; contains the start point and the end point of detected lines.
         *     <b>Note:</b> you should call detectEdges() before calling this function.
         */
        public void detectLines(Mat lines)
        {
            ThrowIfDisposed();
            if (lines != null) lines.ThrowIfDisposed();

            ximgproc_EdgeDrawing_detectLines_10(nativeObj, lines.nativeObj);


        }


        //
        // C++:  void cv::ximgproc::EdgeDrawing::detectEllipses(Mat& ellipses)
        //

        /**
         * Detects circles and ellipses.
         *
         *     param ellipses  output Vec&lt;6d&gt; contains center point and perimeter for circles, center point, axes and angle for ellipses.
         *     <b>Note:</b> you should call detectEdges() before calling this function.
         */
        public void detectEllipses(Mat ellipses)
        {
            ThrowIfDisposed();
            if (ellipses != null) ellipses.ThrowIfDisposed();

            ximgproc_EdgeDrawing_detectEllipses_10(nativeObj, ellipses.nativeObj);


        }


        //
        // C++:  void cv::ximgproc::EdgeDrawing::setParams(EdgeDrawing_Params parameters)
        //

        /**
         * sets parameters.
         *
         *     this function is meant to be used for parameter setting in other languages than c++ like python.
         *     param parameters Parameters of the algorithm
         */
        public void setParams(EdgeDrawing_Params parameters)
        {
            ThrowIfDisposed();
            if (parameters != null) parameters.ThrowIfDisposed();

            ximgproc_EdgeDrawing_setParams_10(nativeObj, parameters.nativeObj);


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  void cv::ximgproc::EdgeDrawing::detectEdges(Mat src)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_EdgeDrawing_detectEdges_10(IntPtr nativeObj, IntPtr src_nativeObj);

        // C++:  void cv::ximgproc::EdgeDrawing::getEdgeImage(Mat& dst)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_EdgeDrawing_getEdgeImage_10(IntPtr nativeObj, IntPtr dst_nativeObj);

        // C++:  void cv::ximgproc::EdgeDrawing::getGradientImage(Mat& dst)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_EdgeDrawing_getGradientImage_10(IntPtr nativeObj, IntPtr dst_nativeObj);

        // C++:  vector_vector_Point cv::ximgproc::EdgeDrawing::getSegments()
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_EdgeDrawing_getSegments_10(IntPtr nativeObj);

        // C++:  vector_int cv::ximgproc::EdgeDrawing::getSegmentIndicesOfLines()
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_EdgeDrawing_getSegmentIndicesOfLines_10(IntPtr nativeObj);

        // C++:  void cv::ximgproc::EdgeDrawing::detectLines(Mat& lines)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_EdgeDrawing_detectLines_10(IntPtr nativeObj, IntPtr lines_nativeObj);

        // C++:  void cv::ximgproc::EdgeDrawing::detectEllipses(Mat& ellipses)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_EdgeDrawing_detectEllipses_10(IntPtr nativeObj, IntPtr ellipses_nativeObj);

        // C++:  void cv::ximgproc::EdgeDrawing::setParams(EdgeDrawing_Params parameters)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_EdgeDrawing_setParams_10(IntPtr nativeObj, IntPtr parameters_nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void ximgproc_EdgeDrawing_delete(IntPtr nativeObj);

    }
}
