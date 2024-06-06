
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.VideoModule
{

    // C++: class FarnebackOpticalFlow
    /**
     * Class computing a dense optical flow using the Gunnar Farneback's algorithm.
     */

    public class FarnebackOpticalFlow : DenseOpticalFlow
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
                        video_FarnebackOpticalFlow_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal FarnebackOpticalFlow(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new FarnebackOpticalFlow __fromPtr__(IntPtr addr) { return new FarnebackOpticalFlow(addr); }

        //
        // C++:  int cv::FarnebackOpticalFlow::getNumLevels()
        //

        public int getNumLevels()
        {
            ThrowIfDisposed();

            return video_FarnebackOpticalFlow_getNumLevels_10(nativeObj);


        }


        //
        // C++:  void cv::FarnebackOpticalFlow::setNumLevels(int numLevels)
        //

        public void setNumLevels(int numLevels)
        {
            ThrowIfDisposed();

            video_FarnebackOpticalFlow_setNumLevels_10(nativeObj, numLevels);


        }


        //
        // C++:  double cv::FarnebackOpticalFlow::getPyrScale()
        //

        public double getPyrScale()
        {
            ThrowIfDisposed();

            return video_FarnebackOpticalFlow_getPyrScale_10(nativeObj);


        }


        //
        // C++:  void cv::FarnebackOpticalFlow::setPyrScale(double pyrScale)
        //

        public void setPyrScale(double pyrScale)
        {
            ThrowIfDisposed();

            video_FarnebackOpticalFlow_setPyrScale_10(nativeObj, pyrScale);


        }


        //
        // C++:  bool cv::FarnebackOpticalFlow::getFastPyramids()
        //

        public bool getFastPyramids()
        {
            ThrowIfDisposed();

            return video_FarnebackOpticalFlow_getFastPyramids_10(nativeObj);


        }


        //
        // C++:  void cv::FarnebackOpticalFlow::setFastPyramids(bool fastPyramids)
        //

        public void setFastPyramids(bool fastPyramids)
        {
            ThrowIfDisposed();

            video_FarnebackOpticalFlow_setFastPyramids_10(nativeObj, fastPyramids);


        }


        //
        // C++:  int cv::FarnebackOpticalFlow::getWinSize()
        //

        public int getWinSize()
        {
            ThrowIfDisposed();

            return video_FarnebackOpticalFlow_getWinSize_10(nativeObj);


        }


        //
        // C++:  void cv::FarnebackOpticalFlow::setWinSize(int winSize)
        //

        public void setWinSize(int winSize)
        {
            ThrowIfDisposed();

            video_FarnebackOpticalFlow_setWinSize_10(nativeObj, winSize);


        }


        //
        // C++:  int cv::FarnebackOpticalFlow::getNumIters()
        //

        public int getNumIters()
        {
            ThrowIfDisposed();

            return video_FarnebackOpticalFlow_getNumIters_10(nativeObj);


        }


        //
        // C++:  void cv::FarnebackOpticalFlow::setNumIters(int numIters)
        //

        public void setNumIters(int numIters)
        {
            ThrowIfDisposed();

            video_FarnebackOpticalFlow_setNumIters_10(nativeObj, numIters);


        }


        //
        // C++:  int cv::FarnebackOpticalFlow::getPolyN()
        //

        public int getPolyN()
        {
            ThrowIfDisposed();

            return video_FarnebackOpticalFlow_getPolyN_10(nativeObj);


        }


        //
        // C++:  void cv::FarnebackOpticalFlow::setPolyN(int polyN)
        //

        public void setPolyN(int polyN)
        {
            ThrowIfDisposed();

            video_FarnebackOpticalFlow_setPolyN_10(nativeObj, polyN);


        }


        //
        // C++:  double cv::FarnebackOpticalFlow::getPolySigma()
        //

        public double getPolySigma()
        {
            ThrowIfDisposed();

            return video_FarnebackOpticalFlow_getPolySigma_10(nativeObj);


        }


        //
        // C++:  void cv::FarnebackOpticalFlow::setPolySigma(double polySigma)
        //

        public void setPolySigma(double polySigma)
        {
            ThrowIfDisposed();

            video_FarnebackOpticalFlow_setPolySigma_10(nativeObj, polySigma);


        }


        //
        // C++:  int cv::FarnebackOpticalFlow::getFlags()
        //

        public int getFlags()
        {
            ThrowIfDisposed();

            return video_FarnebackOpticalFlow_getFlags_10(nativeObj);


        }


        //
        // C++:  void cv::FarnebackOpticalFlow::setFlags(int flags)
        //

        public void setFlags(int flags)
        {
            ThrowIfDisposed();

            video_FarnebackOpticalFlow_setFlags_10(nativeObj, flags);


        }


        //
        // C++: static Ptr_FarnebackOpticalFlow cv::FarnebackOpticalFlow::create(int numLevels = 5, double pyrScale = 0.5, bool fastPyramids = false, int winSize = 13, int numIters = 10, int polyN = 5, double polySigma = 1.1, int flags = 0)
        //

        public static FarnebackOpticalFlow create(int numLevels, double pyrScale, bool fastPyramids, int winSize, int numIters, int polyN, double polySigma, int flags)
        {


            return FarnebackOpticalFlow.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(video_FarnebackOpticalFlow_create_10(numLevels, pyrScale, fastPyramids, winSize, numIters, polyN, polySigma, flags)));


        }

        public static FarnebackOpticalFlow create(int numLevels, double pyrScale, bool fastPyramids, int winSize, int numIters, int polyN, double polySigma)
        {


            return FarnebackOpticalFlow.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(video_FarnebackOpticalFlow_create_11(numLevels, pyrScale, fastPyramids, winSize, numIters, polyN, polySigma)));


        }

        public static FarnebackOpticalFlow create(int numLevels, double pyrScale, bool fastPyramids, int winSize, int numIters, int polyN)
        {


            return FarnebackOpticalFlow.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(video_FarnebackOpticalFlow_create_12(numLevels, pyrScale, fastPyramids, winSize, numIters, polyN)));


        }

        public static FarnebackOpticalFlow create(int numLevels, double pyrScale, bool fastPyramids, int winSize, int numIters)
        {


            return FarnebackOpticalFlow.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(video_FarnebackOpticalFlow_create_13(numLevels, pyrScale, fastPyramids, winSize, numIters)));


        }

        public static FarnebackOpticalFlow create(int numLevels, double pyrScale, bool fastPyramids, int winSize)
        {


            return FarnebackOpticalFlow.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(video_FarnebackOpticalFlow_create_14(numLevels, pyrScale, fastPyramids, winSize)));


        }

        public static FarnebackOpticalFlow create(int numLevels, double pyrScale, bool fastPyramids)
        {


            return FarnebackOpticalFlow.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(video_FarnebackOpticalFlow_create_15(numLevels, pyrScale, fastPyramids)));


        }

        public static FarnebackOpticalFlow create(int numLevels, double pyrScale)
        {


            return FarnebackOpticalFlow.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(video_FarnebackOpticalFlow_create_16(numLevels, pyrScale)));


        }

        public static FarnebackOpticalFlow create(int numLevels)
        {


            return FarnebackOpticalFlow.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(video_FarnebackOpticalFlow_create_17(numLevels)));


        }

        public static FarnebackOpticalFlow create()
        {


            return FarnebackOpticalFlow.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(video_FarnebackOpticalFlow_create_18()));


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  int cv::FarnebackOpticalFlow::getNumLevels()
        [DllImport(LIBNAME)]
        private static extern int video_FarnebackOpticalFlow_getNumLevels_10(IntPtr nativeObj);

        // C++:  void cv::FarnebackOpticalFlow::setNumLevels(int numLevels)
        [DllImport(LIBNAME)]
        private static extern void video_FarnebackOpticalFlow_setNumLevels_10(IntPtr nativeObj, int numLevels);

        // C++:  double cv::FarnebackOpticalFlow::getPyrScale()
        [DllImport(LIBNAME)]
        private static extern double video_FarnebackOpticalFlow_getPyrScale_10(IntPtr nativeObj);

        // C++:  void cv::FarnebackOpticalFlow::setPyrScale(double pyrScale)
        [DllImport(LIBNAME)]
        private static extern void video_FarnebackOpticalFlow_setPyrScale_10(IntPtr nativeObj, double pyrScale);

        // C++:  bool cv::FarnebackOpticalFlow::getFastPyramids()
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool video_FarnebackOpticalFlow_getFastPyramids_10(IntPtr nativeObj);

        // C++:  void cv::FarnebackOpticalFlow::setFastPyramids(bool fastPyramids)
        [DllImport(LIBNAME)]
        private static extern void video_FarnebackOpticalFlow_setFastPyramids_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool fastPyramids);

        // C++:  int cv::FarnebackOpticalFlow::getWinSize()
        [DllImport(LIBNAME)]
        private static extern int video_FarnebackOpticalFlow_getWinSize_10(IntPtr nativeObj);

        // C++:  void cv::FarnebackOpticalFlow::setWinSize(int winSize)
        [DllImport(LIBNAME)]
        private static extern void video_FarnebackOpticalFlow_setWinSize_10(IntPtr nativeObj, int winSize);

        // C++:  int cv::FarnebackOpticalFlow::getNumIters()
        [DllImport(LIBNAME)]
        private static extern int video_FarnebackOpticalFlow_getNumIters_10(IntPtr nativeObj);

        // C++:  void cv::FarnebackOpticalFlow::setNumIters(int numIters)
        [DllImport(LIBNAME)]
        private static extern void video_FarnebackOpticalFlow_setNumIters_10(IntPtr nativeObj, int numIters);

        // C++:  int cv::FarnebackOpticalFlow::getPolyN()
        [DllImport(LIBNAME)]
        private static extern int video_FarnebackOpticalFlow_getPolyN_10(IntPtr nativeObj);

        // C++:  void cv::FarnebackOpticalFlow::setPolyN(int polyN)
        [DllImport(LIBNAME)]
        private static extern void video_FarnebackOpticalFlow_setPolyN_10(IntPtr nativeObj, int polyN);

        // C++:  double cv::FarnebackOpticalFlow::getPolySigma()
        [DllImport(LIBNAME)]
        private static extern double video_FarnebackOpticalFlow_getPolySigma_10(IntPtr nativeObj);

        // C++:  void cv::FarnebackOpticalFlow::setPolySigma(double polySigma)
        [DllImport(LIBNAME)]
        private static extern void video_FarnebackOpticalFlow_setPolySigma_10(IntPtr nativeObj, double polySigma);

        // C++:  int cv::FarnebackOpticalFlow::getFlags()
        [DllImport(LIBNAME)]
        private static extern int video_FarnebackOpticalFlow_getFlags_10(IntPtr nativeObj);

        // C++:  void cv::FarnebackOpticalFlow::setFlags(int flags)
        [DllImport(LIBNAME)]
        private static extern void video_FarnebackOpticalFlow_setFlags_10(IntPtr nativeObj, int flags);

        // C++: static Ptr_FarnebackOpticalFlow cv::FarnebackOpticalFlow::create(int numLevels = 5, double pyrScale = 0.5, bool fastPyramids = false, int winSize = 13, int numIters = 10, int polyN = 5, double polySigma = 1.1, int flags = 0)
        [DllImport(LIBNAME)]
        private static extern IntPtr video_FarnebackOpticalFlow_create_10(int numLevels, double pyrScale, [MarshalAs(UnmanagedType.U1)] bool fastPyramids, int winSize, int numIters, int polyN, double polySigma, int flags);
        [DllImport(LIBNAME)]
        private static extern IntPtr video_FarnebackOpticalFlow_create_11(int numLevels, double pyrScale, [MarshalAs(UnmanagedType.U1)] bool fastPyramids, int winSize, int numIters, int polyN, double polySigma);
        [DllImport(LIBNAME)]
        private static extern IntPtr video_FarnebackOpticalFlow_create_12(int numLevels, double pyrScale, [MarshalAs(UnmanagedType.U1)] bool fastPyramids, int winSize, int numIters, int polyN);
        [DllImport(LIBNAME)]
        private static extern IntPtr video_FarnebackOpticalFlow_create_13(int numLevels, double pyrScale, [MarshalAs(UnmanagedType.U1)] bool fastPyramids, int winSize, int numIters);
        [DllImport(LIBNAME)]
        private static extern IntPtr video_FarnebackOpticalFlow_create_14(int numLevels, double pyrScale, [MarshalAs(UnmanagedType.U1)] bool fastPyramids, int winSize);
        [DllImport(LIBNAME)]
        private static extern IntPtr video_FarnebackOpticalFlow_create_15(int numLevels, double pyrScale, [MarshalAs(UnmanagedType.U1)] bool fastPyramids);
        [DllImport(LIBNAME)]
        private static extern IntPtr video_FarnebackOpticalFlow_create_16(int numLevels, double pyrScale);
        [DllImport(LIBNAME)]
        private static extern IntPtr video_FarnebackOpticalFlow_create_17(int numLevels);
        [DllImport(LIBNAME)]
        private static extern IntPtr video_FarnebackOpticalFlow_create_18();

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void video_FarnebackOpticalFlow_delete(IntPtr nativeObj);

    }
}
