
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.Calib3dModule
{

    // C++: class StereoMatcher
    /**
     * The base class for stereo correspondence algorithms.
     */

    public class StereoMatcher : Algorithm
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
                        calib3d_StereoMatcher_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal StereoMatcher(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new StereoMatcher __fromPtr__(IntPtr addr) { return new StereoMatcher(addr); }

        // C++: enum <unnamed>
        public const int DISP_SHIFT = 4;
        public const int DISP_SCALE = (1 << DISP_SHIFT);
        //
        // C++:  void cv::StereoMatcher::compute(Mat left, Mat right, Mat& disparity)
        //

        /**
         * Computes disparity map for the specified stereo pair
         *
         *     param left Left 8-bit single-channel image.
         *     param right Right image of the same size and the same type as the left one.
         *     param disparity Output disparity map. It has the same size as the input images. Some algorithms,
         *     like StereoBM or StereoSGBM compute 16-bit fixed-point disparity map (where each disparity value
         *     has 4 fractional bits), whereas other algorithms output 32-bit floating-point disparity map.
         */
        public void compute(Mat left, Mat right, Mat disparity)
        {
            ThrowIfDisposed();
            if (left != null) left.ThrowIfDisposed();
            if (right != null) right.ThrowIfDisposed();
            if (disparity != null) disparity.ThrowIfDisposed();

            calib3d_StereoMatcher_compute_10(nativeObj, left.nativeObj, right.nativeObj, disparity.nativeObj);


        }


        //
        // C++:  int cv::StereoMatcher::getMinDisparity()
        //

        public int getMinDisparity()
        {
            ThrowIfDisposed();

            return calib3d_StereoMatcher_getMinDisparity_10(nativeObj);


        }


        //
        // C++:  void cv::StereoMatcher::setMinDisparity(int minDisparity)
        //

        public void setMinDisparity(int minDisparity)
        {
            ThrowIfDisposed();

            calib3d_StereoMatcher_setMinDisparity_10(nativeObj, minDisparity);


        }


        //
        // C++:  int cv::StereoMatcher::getNumDisparities()
        //

        public int getNumDisparities()
        {
            ThrowIfDisposed();

            return calib3d_StereoMatcher_getNumDisparities_10(nativeObj);


        }


        //
        // C++:  void cv::StereoMatcher::setNumDisparities(int numDisparities)
        //

        public void setNumDisparities(int numDisparities)
        {
            ThrowIfDisposed();

            calib3d_StereoMatcher_setNumDisparities_10(nativeObj, numDisparities);


        }


        //
        // C++:  int cv::StereoMatcher::getBlockSize()
        //

        public int getBlockSize()
        {
            ThrowIfDisposed();

            return calib3d_StereoMatcher_getBlockSize_10(nativeObj);


        }


        //
        // C++:  void cv::StereoMatcher::setBlockSize(int blockSize)
        //

        public void setBlockSize(int blockSize)
        {
            ThrowIfDisposed();

            calib3d_StereoMatcher_setBlockSize_10(nativeObj, blockSize);


        }


        //
        // C++:  int cv::StereoMatcher::getSpeckleWindowSize()
        //

        public int getSpeckleWindowSize()
        {
            ThrowIfDisposed();

            return calib3d_StereoMatcher_getSpeckleWindowSize_10(nativeObj);


        }


        //
        // C++:  void cv::StereoMatcher::setSpeckleWindowSize(int speckleWindowSize)
        //

        public void setSpeckleWindowSize(int speckleWindowSize)
        {
            ThrowIfDisposed();

            calib3d_StereoMatcher_setSpeckleWindowSize_10(nativeObj, speckleWindowSize);


        }


        //
        // C++:  int cv::StereoMatcher::getSpeckleRange()
        //

        public int getSpeckleRange()
        {
            ThrowIfDisposed();

            return calib3d_StereoMatcher_getSpeckleRange_10(nativeObj);


        }


        //
        // C++:  void cv::StereoMatcher::setSpeckleRange(int speckleRange)
        //

        public void setSpeckleRange(int speckleRange)
        {
            ThrowIfDisposed();

            calib3d_StereoMatcher_setSpeckleRange_10(nativeObj, speckleRange);


        }


        //
        // C++:  int cv::StereoMatcher::getDisp12MaxDiff()
        //

        public int getDisp12MaxDiff()
        {
            ThrowIfDisposed();

            return calib3d_StereoMatcher_getDisp12MaxDiff_10(nativeObj);


        }


        //
        // C++:  void cv::StereoMatcher::setDisp12MaxDiff(int disp12MaxDiff)
        //

        public void setDisp12MaxDiff(int disp12MaxDiff)
        {
            ThrowIfDisposed();

            calib3d_StereoMatcher_setDisp12MaxDiff_10(nativeObj, disp12MaxDiff);


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  void cv::StereoMatcher::compute(Mat left, Mat right, Mat& disparity)
        [DllImport(LIBNAME)]
        private static extern void calib3d_StereoMatcher_compute_10(IntPtr nativeObj, IntPtr left_nativeObj, IntPtr right_nativeObj, IntPtr disparity_nativeObj);

        // C++:  int cv::StereoMatcher::getMinDisparity()
        [DllImport(LIBNAME)]
        private static extern int calib3d_StereoMatcher_getMinDisparity_10(IntPtr nativeObj);

        // C++:  void cv::StereoMatcher::setMinDisparity(int minDisparity)
        [DllImport(LIBNAME)]
        private static extern void calib3d_StereoMatcher_setMinDisparity_10(IntPtr nativeObj, int minDisparity);

        // C++:  int cv::StereoMatcher::getNumDisparities()
        [DllImport(LIBNAME)]
        private static extern int calib3d_StereoMatcher_getNumDisparities_10(IntPtr nativeObj);

        // C++:  void cv::StereoMatcher::setNumDisparities(int numDisparities)
        [DllImport(LIBNAME)]
        private static extern void calib3d_StereoMatcher_setNumDisparities_10(IntPtr nativeObj, int numDisparities);

        // C++:  int cv::StereoMatcher::getBlockSize()
        [DllImport(LIBNAME)]
        private static extern int calib3d_StereoMatcher_getBlockSize_10(IntPtr nativeObj);

        // C++:  void cv::StereoMatcher::setBlockSize(int blockSize)
        [DllImport(LIBNAME)]
        private static extern void calib3d_StereoMatcher_setBlockSize_10(IntPtr nativeObj, int blockSize);

        // C++:  int cv::StereoMatcher::getSpeckleWindowSize()
        [DllImport(LIBNAME)]
        private static extern int calib3d_StereoMatcher_getSpeckleWindowSize_10(IntPtr nativeObj);

        // C++:  void cv::StereoMatcher::setSpeckleWindowSize(int speckleWindowSize)
        [DllImport(LIBNAME)]
        private static extern void calib3d_StereoMatcher_setSpeckleWindowSize_10(IntPtr nativeObj, int speckleWindowSize);

        // C++:  int cv::StereoMatcher::getSpeckleRange()
        [DllImport(LIBNAME)]
        private static extern int calib3d_StereoMatcher_getSpeckleRange_10(IntPtr nativeObj);

        // C++:  void cv::StereoMatcher::setSpeckleRange(int speckleRange)
        [DllImport(LIBNAME)]
        private static extern void calib3d_StereoMatcher_setSpeckleRange_10(IntPtr nativeObj, int speckleRange);

        // C++:  int cv::StereoMatcher::getDisp12MaxDiff()
        [DllImport(LIBNAME)]
        private static extern int calib3d_StereoMatcher_getDisp12MaxDiff_10(IntPtr nativeObj);

        // C++:  void cv::StereoMatcher::setDisp12MaxDiff(int disp12MaxDiff)
        [DllImport(LIBNAME)]
        private static extern void calib3d_StereoMatcher_setDisp12MaxDiff_10(IntPtr nativeObj, int disp12MaxDiff);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void calib3d_StereoMatcher_delete(IntPtr nativeObj);

    }
}
