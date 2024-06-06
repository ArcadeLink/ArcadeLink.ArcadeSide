
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.ImgprocModule
{

    // C++: class GeneralizedHough
    /**
     * finds arbitrary template in the grayscale image using Generalized Hough Transform
     */

    public class GeneralizedHough : Algorithm
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
                        imgproc_GeneralizedHough_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal GeneralizedHough(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new GeneralizedHough __fromPtr__(IntPtr addr) { return new GeneralizedHough(addr); }

        //
        // C++:  void cv::GeneralizedHough::setTemplate(Mat templ, Point templCenter = Point(-1, -1))
        //

        public void setTemplate(Mat templ, Point templCenter)
        {
            ThrowIfDisposed();
            if (templ != null) templ.ThrowIfDisposed();

            imgproc_GeneralizedHough_setTemplate_10(nativeObj, templ.nativeObj, templCenter.x, templCenter.y);


        }

        public void setTemplate(Mat templ)
        {
            ThrowIfDisposed();
            if (templ != null) templ.ThrowIfDisposed();

            imgproc_GeneralizedHough_setTemplate_11(nativeObj, templ.nativeObj);


        }


        //
        // C++:  void cv::GeneralizedHough::setTemplate(Mat edges, Mat dx, Mat dy, Point templCenter = Point(-1, -1))
        //

        public void setTemplate(Mat edges, Mat dx, Mat dy, Point templCenter)
        {
            ThrowIfDisposed();
            if (edges != null) edges.ThrowIfDisposed();
            if (dx != null) dx.ThrowIfDisposed();
            if (dy != null) dy.ThrowIfDisposed();

            imgproc_GeneralizedHough_setTemplate_12(nativeObj, edges.nativeObj, dx.nativeObj, dy.nativeObj, templCenter.x, templCenter.y);


        }

        public void setTemplate(Mat edges, Mat dx, Mat dy)
        {
            ThrowIfDisposed();
            if (edges != null) edges.ThrowIfDisposed();
            if (dx != null) dx.ThrowIfDisposed();
            if (dy != null) dy.ThrowIfDisposed();

            imgproc_GeneralizedHough_setTemplate_13(nativeObj, edges.nativeObj, dx.nativeObj, dy.nativeObj);


        }


        //
        // C++:  void cv::GeneralizedHough::detect(Mat image, Mat& positions, Mat& votes = Mat())
        //

        public void detect(Mat image, Mat positions, Mat votes)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (positions != null) positions.ThrowIfDisposed();
            if (votes != null) votes.ThrowIfDisposed();

            imgproc_GeneralizedHough_detect_10(nativeObj, image.nativeObj, positions.nativeObj, votes.nativeObj);


        }

        public void detect(Mat image, Mat positions)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (positions != null) positions.ThrowIfDisposed();

            imgproc_GeneralizedHough_detect_11(nativeObj, image.nativeObj, positions.nativeObj);


        }


        //
        // C++:  void cv::GeneralizedHough::detect(Mat edges, Mat dx, Mat dy, Mat& positions, Mat& votes = Mat())
        //

        public void detect(Mat edges, Mat dx, Mat dy, Mat positions, Mat votes)
        {
            ThrowIfDisposed();
            if (edges != null) edges.ThrowIfDisposed();
            if (dx != null) dx.ThrowIfDisposed();
            if (dy != null) dy.ThrowIfDisposed();
            if (positions != null) positions.ThrowIfDisposed();
            if (votes != null) votes.ThrowIfDisposed();

            imgproc_GeneralizedHough_detect_12(nativeObj, edges.nativeObj, dx.nativeObj, dy.nativeObj, positions.nativeObj, votes.nativeObj);


        }

        public void detect(Mat edges, Mat dx, Mat dy, Mat positions)
        {
            ThrowIfDisposed();
            if (edges != null) edges.ThrowIfDisposed();
            if (dx != null) dx.ThrowIfDisposed();
            if (dy != null) dy.ThrowIfDisposed();
            if (positions != null) positions.ThrowIfDisposed();

            imgproc_GeneralizedHough_detect_13(nativeObj, edges.nativeObj, dx.nativeObj, dy.nativeObj, positions.nativeObj);


        }


        //
        // C++:  void cv::GeneralizedHough::setCannyLowThresh(int cannyLowThresh)
        //

        public void setCannyLowThresh(int cannyLowThresh)
        {
            ThrowIfDisposed();

            imgproc_GeneralizedHough_setCannyLowThresh_10(nativeObj, cannyLowThresh);


        }


        //
        // C++:  int cv::GeneralizedHough::getCannyLowThresh()
        //

        public int getCannyLowThresh()
        {
            ThrowIfDisposed();

            return imgproc_GeneralizedHough_getCannyLowThresh_10(nativeObj);


        }


        //
        // C++:  void cv::GeneralizedHough::setCannyHighThresh(int cannyHighThresh)
        //

        public void setCannyHighThresh(int cannyHighThresh)
        {
            ThrowIfDisposed();

            imgproc_GeneralizedHough_setCannyHighThresh_10(nativeObj, cannyHighThresh);


        }


        //
        // C++:  int cv::GeneralizedHough::getCannyHighThresh()
        //

        public int getCannyHighThresh()
        {
            ThrowIfDisposed();

            return imgproc_GeneralizedHough_getCannyHighThresh_10(nativeObj);


        }


        //
        // C++:  void cv::GeneralizedHough::setMinDist(double minDist)
        //

        public void setMinDist(double minDist)
        {
            ThrowIfDisposed();

            imgproc_GeneralizedHough_setMinDist_10(nativeObj, minDist);


        }


        //
        // C++:  double cv::GeneralizedHough::getMinDist()
        //

        public double getMinDist()
        {
            ThrowIfDisposed();

            return imgproc_GeneralizedHough_getMinDist_10(nativeObj);


        }


        //
        // C++:  void cv::GeneralizedHough::setDp(double dp)
        //

        public void setDp(double dp)
        {
            ThrowIfDisposed();

            imgproc_GeneralizedHough_setDp_10(nativeObj, dp);


        }


        //
        // C++:  double cv::GeneralizedHough::getDp()
        //

        public double getDp()
        {
            ThrowIfDisposed();

            return imgproc_GeneralizedHough_getDp_10(nativeObj);


        }


        //
        // C++:  void cv::GeneralizedHough::setMaxBufferSize(int maxBufferSize)
        //

        public void setMaxBufferSize(int maxBufferSize)
        {
            ThrowIfDisposed();

            imgproc_GeneralizedHough_setMaxBufferSize_10(nativeObj, maxBufferSize);


        }


        //
        // C++:  int cv::GeneralizedHough::getMaxBufferSize()
        //

        public int getMaxBufferSize()
        {
            ThrowIfDisposed();

            return imgproc_GeneralizedHough_getMaxBufferSize_10(nativeObj);


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  void cv::GeneralizedHough::setTemplate(Mat templ, Point templCenter = Point(-1, -1))
        [DllImport(LIBNAME)]
        private static extern void imgproc_GeneralizedHough_setTemplate_10(IntPtr nativeObj, IntPtr templ_nativeObj, double templCenter_x, double templCenter_y);
        [DllImport(LIBNAME)]
        private static extern void imgproc_GeneralizedHough_setTemplate_11(IntPtr nativeObj, IntPtr templ_nativeObj);

        // C++:  void cv::GeneralizedHough::setTemplate(Mat edges, Mat dx, Mat dy, Point templCenter = Point(-1, -1))
        [DllImport(LIBNAME)]
        private static extern void imgproc_GeneralizedHough_setTemplate_12(IntPtr nativeObj, IntPtr edges_nativeObj, IntPtr dx_nativeObj, IntPtr dy_nativeObj, double templCenter_x, double templCenter_y);
        [DllImport(LIBNAME)]
        private static extern void imgproc_GeneralizedHough_setTemplate_13(IntPtr nativeObj, IntPtr edges_nativeObj, IntPtr dx_nativeObj, IntPtr dy_nativeObj);

        // C++:  void cv::GeneralizedHough::detect(Mat image, Mat& positions, Mat& votes = Mat())
        [DllImport(LIBNAME)]
        private static extern void imgproc_GeneralizedHough_detect_10(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr positions_nativeObj, IntPtr votes_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void imgproc_GeneralizedHough_detect_11(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr positions_nativeObj);

        // C++:  void cv::GeneralizedHough::detect(Mat edges, Mat dx, Mat dy, Mat& positions, Mat& votes = Mat())
        [DllImport(LIBNAME)]
        private static extern void imgproc_GeneralizedHough_detect_12(IntPtr nativeObj, IntPtr edges_nativeObj, IntPtr dx_nativeObj, IntPtr dy_nativeObj, IntPtr positions_nativeObj, IntPtr votes_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void imgproc_GeneralizedHough_detect_13(IntPtr nativeObj, IntPtr edges_nativeObj, IntPtr dx_nativeObj, IntPtr dy_nativeObj, IntPtr positions_nativeObj);

        // C++:  void cv::GeneralizedHough::setCannyLowThresh(int cannyLowThresh)
        [DllImport(LIBNAME)]
        private static extern void imgproc_GeneralizedHough_setCannyLowThresh_10(IntPtr nativeObj, int cannyLowThresh);

        // C++:  int cv::GeneralizedHough::getCannyLowThresh()
        [DllImport(LIBNAME)]
        private static extern int imgproc_GeneralizedHough_getCannyLowThresh_10(IntPtr nativeObj);

        // C++:  void cv::GeneralizedHough::setCannyHighThresh(int cannyHighThresh)
        [DllImport(LIBNAME)]
        private static extern void imgproc_GeneralizedHough_setCannyHighThresh_10(IntPtr nativeObj, int cannyHighThresh);

        // C++:  int cv::GeneralizedHough::getCannyHighThresh()
        [DllImport(LIBNAME)]
        private static extern int imgproc_GeneralizedHough_getCannyHighThresh_10(IntPtr nativeObj);

        // C++:  void cv::GeneralizedHough::setMinDist(double minDist)
        [DllImport(LIBNAME)]
        private static extern void imgproc_GeneralizedHough_setMinDist_10(IntPtr nativeObj, double minDist);

        // C++:  double cv::GeneralizedHough::getMinDist()
        [DllImport(LIBNAME)]
        private static extern double imgproc_GeneralizedHough_getMinDist_10(IntPtr nativeObj);

        // C++:  void cv::GeneralizedHough::setDp(double dp)
        [DllImport(LIBNAME)]
        private static extern void imgproc_GeneralizedHough_setDp_10(IntPtr nativeObj, double dp);

        // C++:  double cv::GeneralizedHough::getDp()
        [DllImport(LIBNAME)]
        private static extern double imgproc_GeneralizedHough_getDp_10(IntPtr nativeObj);

        // C++:  void cv::GeneralizedHough::setMaxBufferSize(int maxBufferSize)
        [DllImport(LIBNAME)]
        private static extern void imgproc_GeneralizedHough_setMaxBufferSize_10(IntPtr nativeObj, int maxBufferSize);

        // C++:  int cv::GeneralizedHough::getMaxBufferSize()
        [DllImport(LIBNAME)]
        private static extern int imgproc_GeneralizedHough_getMaxBufferSize_10(IntPtr nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void imgproc_GeneralizedHough_delete(IntPtr nativeObj);

    }
}
