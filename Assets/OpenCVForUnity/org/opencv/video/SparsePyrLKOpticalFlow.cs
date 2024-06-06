
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.VideoModule
{

    // C++: class SparsePyrLKOpticalFlow
    /**
     * Class used for calculating a sparse optical flow.
     *
     * The class can calculate an optical flow for a sparse feature set using the
     * iterative Lucas-Kanade method with pyramids.
     *
     * SEE: calcOpticalFlowPyrLK
     */

    public class SparsePyrLKOpticalFlow : SparseOpticalFlow
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
                        video_SparsePyrLKOpticalFlow_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal SparsePyrLKOpticalFlow(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new SparsePyrLKOpticalFlow __fromPtr__(IntPtr addr) { return new SparsePyrLKOpticalFlow(addr); }

        //
        // C++:  Size cv::SparsePyrLKOpticalFlow::getWinSize()
        //

        public Size getWinSize()
        {
            ThrowIfDisposed();

            double[] tmpArray = new double[2];
            video_SparsePyrLKOpticalFlow_getWinSize_10(nativeObj, tmpArray);
            Size retVal = new Size(tmpArray);

            return retVal;
        }


        //
        // C++:  void cv::SparsePyrLKOpticalFlow::setWinSize(Size winSize)
        //

        public void setWinSize(Size winSize)
        {
            ThrowIfDisposed();

            video_SparsePyrLKOpticalFlow_setWinSize_10(nativeObj, winSize.width, winSize.height);


        }


        //
        // C++:  int cv::SparsePyrLKOpticalFlow::getMaxLevel()
        //

        public int getMaxLevel()
        {
            ThrowIfDisposed();

            return video_SparsePyrLKOpticalFlow_getMaxLevel_10(nativeObj);


        }


        //
        // C++:  void cv::SparsePyrLKOpticalFlow::setMaxLevel(int maxLevel)
        //

        public void setMaxLevel(int maxLevel)
        {
            ThrowIfDisposed();

            video_SparsePyrLKOpticalFlow_setMaxLevel_10(nativeObj, maxLevel);


        }


        //
        // C++:  TermCriteria cv::SparsePyrLKOpticalFlow::getTermCriteria()
        //

        public TermCriteria getTermCriteria()
        {
            ThrowIfDisposed();

            double[] tmpArray = new double[3];
            video_SparsePyrLKOpticalFlow_getTermCriteria_10(nativeObj, tmpArray);
            TermCriteria retVal = new TermCriteria(tmpArray);

            return retVal;
        }


        //
        // C++:  void cv::SparsePyrLKOpticalFlow::setTermCriteria(TermCriteria crit)
        //

        public void setTermCriteria(TermCriteria crit)
        {
            ThrowIfDisposed();

            video_SparsePyrLKOpticalFlow_setTermCriteria_10(nativeObj, crit.type, crit.maxCount, crit.epsilon);


        }


        //
        // C++:  int cv::SparsePyrLKOpticalFlow::getFlags()
        //

        public int getFlags()
        {
            ThrowIfDisposed();

            return video_SparsePyrLKOpticalFlow_getFlags_10(nativeObj);


        }


        //
        // C++:  void cv::SparsePyrLKOpticalFlow::setFlags(int flags)
        //

        public void setFlags(int flags)
        {
            ThrowIfDisposed();

            video_SparsePyrLKOpticalFlow_setFlags_10(nativeObj, flags);


        }


        //
        // C++:  double cv::SparsePyrLKOpticalFlow::getMinEigThreshold()
        //

        public double getMinEigThreshold()
        {
            ThrowIfDisposed();

            return video_SparsePyrLKOpticalFlow_getMinEigThreshold_10(nativeObj);


        }


        //
        // C++:  void cv::SparsePyrLKOpticalFlow::setMinEigThreshold(double minEigThreshold)
        //

        public void setMinEigThreshold(double minEigThreshold)
        {
            ThrowIfDisposed();

            video_SparsePyrLKOpticalFlow_setMinEigThreshold_10(nativeObj, minEigThreshold);


        }


        //
        // C++: static Ptr_SparsePyrLKOpticalFlow cv::SparsePyrLKOpticalFlow::create(Size winSize = Size(21, 21), int maxLevel = 3, TermCriteria crit = TermCriteria(TermCriteria::COUNT+TermCriteria::EPS, 30, 0.01), int flags = 0, double minEigThreshold = 1e-4)
        //

        public static SparsePyrLKOpticalFlow create(Size winSize, int maxLevel, TermCriteria crit, int flags, double minEigThreshold)
        {


            return SparsePyrLKOpticalFlow.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(video_SparsePyrLKOpticalFlow_create_10(winSize.width, winSize.height, maxLevel, crit.type, crit.maxCount, crit.epsilon, flags, minEigThreshold)));


        }

        public static SparsePyrLKOpticalFlow create(Size winSize, int maxLevel, TermCriteria crit, int flags)
        {


            return SparsePyrLKOpticalFlow.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(video_SparsePyrLKOpticalFlow_create_11(winSize.width, winSize.height, maxLevel, crit.type, crit.maxCount, crit.epsilon, flags)));


        }

        public static SparsePyrLKOpticalFlow create(Size winSize, int maxLevel, TermCriteria crit)
        {


            return SparsePyrLKOpticalFlow.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(video_SparsePyrLKOpticalFlow_create_12(winSize.width, winSize.height, maxLevel, crit.type, crit.maxCount, crit.epsilon)));


        }

        public static SparsePyrLKOpticalFlow create(Size winSize, int maxLevel)
        {


            return SparsePyrLKOpticalFlow.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(video_SparsePyrLKOpticalFlow_create_13(winSize.width, winSize.height, maxLevel)));


        }

        public static SparsePyrLKOpticalFlow create(Size winSize)
        {


            return SparsePyrLKOpticalFlow.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(video_SparsePyrLKOpticalFlow_create_14(winSize.width, winSize.height)));


        }

        public static SparsePyrLKOpticalFlow create()
        {


            return SparsePyrLKOpticalFlow.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(video_SparsePyrLKOpticalFlow_create_15()));


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  Size cv::SparsePyrLKOpticalFlow::getWinSize()
        [DllImport(LIBNAME)]
        private static extern void video_SparsePyrLKOpticalFlow_getWinSize_10(IntPtr nativeObj, double[] retVal);

        // C++:  void cv::SparsePyrLKOpticalFlow::setWinSize(Size winSize)
        [DllImport(LIBNAME)]
        private static extern void video_SparsePyrLKOpticalFlow_setWinSize_10(IntPtr nativeObj, double winSize_width, double winSize_height);

        // C++:  int cv::SparsePyrLKOpticalFlow::getMaxLevel()
        [DllImport(LIBNAME)]
        private static extern int video_SparsePyrLKOpticalFlow_getMaxLevel_10(IntPtr nativeObj);

        // C++:  void cv::SparsePyrLKOpticalFlow::setMaxLevel(int maxLevel)
        [DllImport(LIBNAME)]
        private static extern void video_SparsePyrLKOpticalFlow_setMaxLevel_10(IntPtr nativeObj, int maxLevel);

        // C++:  TermCriteria cv::SparsePyrLKOpticalFlow::getTermCriteria()
        [DllImport(LIBNAME)]
        private static extern void video_SparsePyrLKOpticalFlow_getTermCriteria_10(IntPtr nativeObj, double[] retVal);

        // C++:  void cv::SparsePyrLKOpticalFlow::setTermCriteria(TermCriteria crit)
        [DllImport(LIBNAME)]
        private static extern void video_SparsePyrLKOpticalFlow_setTermCriteria_10(IntPtr nativeObj, int crit_type, int crit_maxCount, double crit_epsilon);

        // C++:  int cv::SparsePyrLKOpticalFlow::getFlags()
        [DllImport(LIBNAME)]
        private static extern int video_SparsePyrLKOpticalFlow_getFlags_10(IntPtr nativeObj);

        // C++:  void cv::SparsePyrLKOpticalFlow::setFlags(int flags)
        [DllImport(LIBNAME)]
        private static extern void video_SparsePyrLKOpticalFlow_setFlags_10(IntPtr nativeObj, int flags);

        // C++:  double cv::SparsePyrLKOpticalFlow::getMinEigThreshold()
        [DllImport(LIBNAME)]
        private static extern double video_SparsePyrLKOpticalFlow_getMinEigThreshold_10(IntPtr nativeObj);

        // C++:  void cv::SparsePyrLKOpticalFlow::setMinEigThreshold(double minEigThreshold)
        [DllImport(LIBNAME)]
        private static extern void video_SparsePyrLKOpticalFlow_setMinEigThreshold_10(IntPtr nativeObj, double minEigThreshold);

        // C++: static Ptr_SparsePyrLKOpticalFlow cv::SparsePyrLKOpticalFlow::create(Size winSize = Size(21, 21), int maxLevel = 3, TermCriteria crit = TermCriteria(TermCriteria::COUNT+TermCriteria::EPS, 30, 0.01), int flags = 0, double minEigThreshold = 1e-4)
        [DllImport(LIBNAME)]
        private static extern IntPtr video_SparsePyrLKOpticalFlow_create_10(double winSize_width, double winSize_height, int maxLevel, int crit_type, int crit_maxCount, double crit_epsilon, int flags, double minEigThreshold);
        [DllImport(LIBNAME)]
        private static extern IntPtr video_SparsePyrLKOpticalFlow_create_11(double winSize_width, double winSize_height, int maxLevel, int crit_type, int crit_maxCount, double crit_epsilon, int flags);
        [DllImport(LIBNAME)]
        private static extern IntPtr video_SparsePyrLKOpticalFlow_create_12(double winSize_width, double winSize_height, int maxLevel, int crit_type, int crit_maxCount, double crit_epsilon);
        [DllImport(LIBNAME)]
        private static extern IntPtr video_SparsePyrLKOpticalFlow_create_13(double winSize_width, double winSize_height, int maxLevel);
        [DllImport(LIBNAME)]
        private static extern IntPtr video_SparsePyrLKOpticalFlow_create_14(double winSize_width, double winSize_height);
        [DllImport(LIBNAME)]
        private static extern IntPtr video_SparsePyrLKOpticalFlow_create_15();

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void video_SparsePyrLKOpticalFlow_delete(IntPtr nativeObj);

    }
}
