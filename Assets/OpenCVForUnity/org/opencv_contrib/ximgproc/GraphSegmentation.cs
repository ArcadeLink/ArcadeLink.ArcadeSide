
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.XimgprocModule
{

    // C++: class GraphSegmentation
    /**
     * Graph Based Segmentation Algorithm.
     *                         The class implements the algorithm described in CITE: PFF2004 .
     */

    public class GraphSegmentation : Algorithm
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
                        ximgproc_GraphSegmentation_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal GraphSegmentation(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new GraphSegmentation __fromPtr__(IntPtr addr) { return new GraphSegmentation(addr); }

        //
        // C++:  void cv::ximgproc::segmentation::GraphSegmentation::processImage(Mat src, Mat& dst)
        //

        /**
         * Segment an image and store output in dst
         *                                 param src The input image. Any number of channel (1 (Eg: Gray), 3 (Eg: RGB), 4 (Eg: RGB-D)) can be provided
         *                                 param dst The output segmentation. It's a CV_32SC1 Mat with the same number of cols and rows as input image, with an unique, sequential, id for each pixel.
         */
        public void processImage(Mat src, Mat dst)
        {
            ThrowIfDisposed();
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            ximgproc_GraphSegmentation_processImage_10(nativeObj, src.nativeObj, dst.nativeObj);


        }


        //
        // C++:  void cv::ximgproc::segmentation::GraphSegmentation::setSigma(double sigma)
        //

        public void setSigma(double sigma)
        {
            ThrowIfDisposed();

            ximgproc_GraphSegmentation_setSigma_10(nativeObj, sigma);


        }


        //
        // C++:  double cv::ximgproc::segmentation::GraphSegmentation::getSigma()
        //

        public double getSigma()
        {
            ThrowIfDisposed();

            return ximgproc_GraphSegmentation_getSigma_10(nativeObj);


        }


        //
        // C++:  void cv::ximgproc::segmentation::GraphSegmentation::setK(float k)
        //

        public void setK(float k)
        {
            ThrowIfDisposed();

            ximgproc_GraphSegmentation_setK_10(nativeObj, k);


        }


        //
        // C++:  float cv::ximgproc::segmentation::GraphSegmentation::getK()
        //

        public float getK()
        {
            ThrowIfDisposed();

            return ximgproc_GraphSegmentation_getK_10(nativeObj);


        }


        //
        // C++:  void cv::ximgproc::segmentation::GraphSegmentation::setMinSize(int min_size)
        //

        public void setMinSize(int min_size)
        {
            ThrowIfDisposed();

            ximgproc_GraphSegmentation_setMinSize_10(nativeObj, min_size);


        }


        //
        // C++:  int cv::ximgproc::segmentation::GraphSegmentation::getMinSize()
        //

        public int getMinSize()
        {
            ThrowIfDisposed();

            return ximgproc_GraphSegmentation_getMinSize_10(nativeObj);


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  void cv::ximgproc::segmentation::GraphSegmentation::processImage(Mat src, Mat& dst)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_GraphSegmentation_processImage_10(IntPtr nativeObj, IntPtr src_nativeObj, IntPtr dst_nativeObj);

        // C++:  void cv::ximgproc::segmentation::GraphSegmentation::setSigma(double sigma)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_GraphSegmentation_setSigma_10(IntPtr nativeObj, double sigma);

        // C++:  double cv::ximgproc::segmentation::GraphSegmentation::getSigma()
        [DllImport(LIBNAME)]
        private static extern double ximgproc_GraphSegmentation_getSigma_10(IntPtr nativeObj);

        // C++:  void cv::ximgproc::segmentation::GraphSegmentation::setK(float k)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_GraphSegmentation_setK_10(IntPtr nativeObj, float k);

        // C++:  float cv::ximgproc::segmentation::GraphSegmentation::getK()
        [DllImport(LIBNAME)]
        private static extern float ximgproc_GraphSegmentation_getK_10(IntPtr nativeObj);

        // C++:  void cv::ximgproc::segmentation::GraphSegmentation::setMinSize(int min_size)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_GraphSegmentation_setMinSize_10(IntPtr nativeObj, int min_size);

        // C++:  int cv::ximgproc::segmentation::GraphSegmentation::getMinSize()
        [DllImport(LIBNAME)]
        private static extern int ximgproc_GraphSegmentation_getMinSize_10(IntPtr nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void ximgproc_GraphSegmentation_delete(IntPtr nativeObj);

    }
}
