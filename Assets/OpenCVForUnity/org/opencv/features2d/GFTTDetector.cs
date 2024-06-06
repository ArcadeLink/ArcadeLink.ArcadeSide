
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.Features2dModule
{

    // C++: class GFTTDetector
    /**
     * Wrapping class for feature detection using the goodFeaturesToTrack function. :
     */

    public class GFTTDetector : Feature2D
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
                        features2d_GFTTDetector_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal GFTTDetector(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new GFTTDetector __fromPtr__(IntPtr addr) { return new GFTTDetector(addr); }

        //
        // C++: static Ptr_GFTTDetector cv::GFTTDetector::create(int maxCorners = 1000, double qualityLevel = 0.01, double minDistance = 1, int blockSize = 3, bool useHarrisDetector = false, double k = 0.04)
        //

        public static GFTTDetector create(int maxCorners, double qualityLevel, double minDistance, int blockSize, bool useHarrisDetector, double k)
        {


            return GFTTDetector.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(features2d_GFTTDetector_create_10(maxCorners, qualityLevel, minDistance, blockSize, useHarrisDetector, k)));


        }

        public static GFTTDetector create(int maxCorners, double qualityLevel, double minDistance, int blockSize, bool useHarrisDetector)
        {


            return GFTTDetector.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(features2d_GFTTDetector_create_11(maxCorners, qualityLevel, minDistance, blockSize, useHarrisDetector)));


        }

        public static GFTTDetector create(int maxCorners, double qualityLevel, double minDistance, int blockSize)
        {


            return GFTTDetector.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(features2d_GFTTDetector_create_12(maxCorners, qualityLevel, minDistance, blockSize)));


        }

        public static GFTTDetector create(int maxCorners, double qualityLevel, double minDistance)
        {


            return GFTTDetector.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(features2d_GFTTDetector_create_13(maxCorners, qualityLevel, minDistance)));


        }

        public static GFTTDetector create(int maxCorners, double qualityLevel)
        {


            return GFTTDetector.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(features2d_GFTTDetector_create_14(maxCorners, qualityLevel)));


        }

        public static GFTTDetector create(int maxCorners)
        {


            return GFTTDetector.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(features2d_GFTTDetector_create_15(maxCorners)));


        }

        public static GFTTDetector create()
        {


            return GFTTDetector.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(features2d_GFTTDetector_create_16()));


        }


        //
        // C++: static Ptr_GFTTDetector cv::GFTTDetector::create(int maxCorners, double qualityLevel, double minDistance, int blockSize, int gradiantSize, bool useHarrisDetector = false, double k = 0.04)
        //

        public static GFTTDetector create(int maxCorners, double qualityLevel, double minDistance, int blockSize, int gradiantSize, bool useHarrisDetector, double k)
        {


            return GFTTDetector.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(features2d_GFTTDetector_create_17(maxCorners, qualityLevel, minDistance, blockSize, gradiantSize, useHarrisDetector, k)));


        }

        public static GFTTDetector create(int maxCorners, double qualityLevel, double minDistance, int blockSize, int gradiantSize, bool useHarrisDetector)
        {


            return GFTTDetector.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(features2d_GFTTDetector_create_18(maxCorners, qualityLevel, minDistance, blockSize, gradiantSize, useHarrisDetector)));


        }

        public static GFTTDetector create(int maxCorners, double qualityLevel, double minDistance, int blockSize, int gradiantSize)
        {


            return GFTTDetector.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(features2d_GFTTDetector_create_19(maxCorners, qualityLevel, minDistance, blockSize, gradiantSize)));


        }


        //
        // C++:  void cv::GFTTDetector::setMaxFeatures(int maxFeatures)
        //

        public void setMaxFeatures(int maxFeatures)
        {
            ThrowIfDisposed();

            features2d_GFTTDetector_setMaxFeatures_10(nativeObj, maxFeatures);


        }


        //
        // C++:  int cv::GFTTDetector::getMaxFeatures()
        //

        public int getMaxFeatures()
        {
            ThrowIfDisposed();

            return features2d_GFTTDetector_getMaxFeatures_10(nativeObj);


        }


        //
        // C++:  void cv::GFTTDetector::setQualityLevel(double qlevel)
        //

        public void setQualityLevel(double qlevel)
        {
            ThrowIfDisposed();

            features2d_GFTTDetector_setQualityLevel_10(nativeObj, qlevel);


        }


        //
        // C++:  double cv::GFTTDetector::getQualityLevel()
        //

        public double getQualityLevel()
        {
            ThrowIfDisposed();

            return features2d_GFTTDetector_getQualityLevel_10(nativeObj);


        }


        //
        // C++:  void cv::GFTTDetector::setMinDistance(double minDistance)
        //

        public void setMinDistance(double minDistance)
        {
            ThrowIfDisposed();

            features2d_GFTTDetector_setMinDistance_10(nativeObj, minDistance);


        }


        //
        // C++:  double cv::GFTTDetector::getMinDistance()
        //

        public double getMinDistance()
        {
            ThrowIfDisposed();

            return features2d_GFTTDetector_getMinDistance_10(nativeObj);


        }


        //
        // C++:  void cv::GFTTDetector::setBlockSize(int blockSize)
        //

        public void setBlockSize(int blockSize)
        {
            ThrowIfDisposed();

            features2d_GFTTDetector_setBlockSize_10(nativeObj, blockSize);


        }


        //
        // C++:  int cv::GFTTDetector::getBlockSize()
        //

        public int getBlockSize()
        {
            ThrowIfDisposed();

            return features2d_GFTTDetector_getBlockSize_10(nativeObj);


        }


        //
        // C++:  void cv::GFTTDetector::setGradientSize(int gradientSize_)
        //

        public void setGradientSize(int gradientSize_)
        {
            ThrowIfDisposed();

            features2d_GFTTDetector_setGradientSize_10(nativeObj, gradientSize_);


        }


        //
        // C++:  int cv::GFTTDetector::getGradientSize()
        //

        public int getGradientSize()
        {
            ThrowIfDisposed();

            return features2d_GFTTDetector_getGradientSize_10(nativeObj);


        }


        //
        // C++:  void cv::GFTTDetector::setHarrisDetector(bool val)
        //

        public void setHarrisDetector(bool val)
        {
            ThrowIfDisposed();

            features2d_GFTTDetector_setHarrisDetector_10(nativeObj, val);


        }


        //
        // C++:  bool cv::GFTTDetector::getHarrisDetector()
        //

        public bool getHarrisDetector()
        {
            ThrowIfDisposed();

            return features2d_GFTTDetector_getHarrisDetector_10(nativeObj);


        }


        //
        // C++:  void cv::GFTTDetector::setK(double k)
        //

        public void setK(double k)
        {
            ThrowIfDisposed();

            features2d_GFTTDetector_setK_10(nativeObj, k);


        }


        //
        // C++:  double cv::GFTTDetector::getK()
        //

        public double getK()
        {
            ThrowIfDisposed();

            return features2d_GFTTDetector_getK_10(nativeObj);


        }


        //
        // C++:  String cv::GFTTDetector::getDefaultName()
        //

        public override string getDefaultName()
        {
            ThrowIfDisposed();

            string retVal = Marshal.PtrToStringAnsi(DisposableObject.ThrowIfNullIntPtr(features2d_GFTTDetector_getDefaultName_10(nativeObj)));

            return retVal;
        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++: static Ptr_GFTTDetector cv::GFTTDetector::create(int maxCorners = 1000, double qualityLevel = 0.01, double minDistance = 1, int blockSize = 3, bool useHarrisDetector = false, double k = 0.04)
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_GFTTDetector_create_10(int maxCorners, double qualityLevel, double minDistance, int blockSize, [MarshalAs(UnmanagedType.U1)] bool useHarrisDetector, double k);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_GFTTDetector_create_11(int maxCorners, double qualityLevel, double minDistance, int blockSize, [MarshalAs(UnmanagedType.U1)] bool useHarrisDetector);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_GFTTDetector_create_12(int maxCorners, double qualityLevel, double minDistance, int blockSize);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_GFTTDetector_create_13(int maxCorners, double qualityLevel, double minDistance);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_GFTTDetector_create_14(int maxCorners, double qualityLevel);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_GFTTDetector_create_15(int maxCorners);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_GFTTDetector_create_16();

        // C++: static Ptr_GFTTDetector cv::GFTTDetector::create(int maxCorners, double qualityLevel, double minDistance, int blockSize, int gradiantSize, bool useHarrisDetector = false, double k = 0.04)
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_GFTTDetector_create_17(int maxCorners, double qualityLevel, double minDistance, int blockSize, int gradiantSize, [MarshalAs(UnmanagedType.U1)] bool useHarrisDetector, double k);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_GFTTDetector_create_18(int maxCorners, double qualityLevel, double minDistance, int blockSize, int gradiantSize, [MarshalAs(UnmanagedType.U1)] bool useHarrisDetector);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_GFTTDetector_create_19(int maxCorners, double qualityLevel, double minDistance, int blockSize, int gradiantSize);

        // C++:  void cv::GFTTDetector::setMaxFeatures(int maxFeatures)
        [DllImport(LIBNAME)]
        private static extern void features2d_GFTTDetector_setMaxFeatures_10(IntPtr nativeObj, int maxFeatures);

        // C++:  int cv::GFTTDetector::getMaxFeatures()
        [DllImport(LIBNAME)]
        private static extern int features2d_GFTTDetector_getMaxFeatures_10(IntPtr nativeObj);

        // C++:  void cv::GFTTDetector::setQualityLevel(double qlevel)
        [DllImport(LIBNAME)]
        private static extern void features2d_GFTTDetector_setQualityLevel_10(IntPtr nativeObj, double qlevel);

        // C++:  double cv::GFTTDetector::getQualityLevel()
        [DllImport(LIBNAME)]
        private static extern double features2d_GFTTDetector_getQualityLevel_10(IntPtr nativeObj);

        // C++:  void cv::GFTTDetector::setMinDistance(double minDistance)
        [DllImport(LIBNAME)]
        private static extern void features2d_GFTTDetector_setMinDistance_10(IntPtr nativeObj, double minDistance);

        // C++:  double cv::GFTTDetector::getMinDistance()
        [DllImport(LIBNAME)]
        private static extern double features2d_GFTTDetector_getMinDistance_10(IntPtr nativeObj);

        // C++:  void cv::GFTTDetector::setBlockSize(int blockSize)
        [DllImport(LIBNAME)]
        private static extern void features2d_GFTTDetector_setBlockSize_10(IntPtr nativeObj, int blockSize);

        // C++:  int cv::GFTTDetector::getBlockSize()
        [DllImport(LIBNAME)]
        private static extern int features2d_GFTTDetector_getBlockSize_10(IntPtr nativeObj);

        // C++:  void cv::GFTTDetector::setGradientSize(int gradientSize_)
        [DllImport(LIBNAME)]
        private static extern void features2d_GFTTDetector_setGradientSize_10(IntPtr nativeObj, int gradientSize_);

        // C++:  int cv::GFTTDetector::getGradientSize()
        [DllImport(LIBNAME)]
        private static extern int features2d_GFTTDetector_getGradientSize_10(IntPtr nativeObj);

        // C++:  void cv::GFTTDetector::setHarrisDetector(bool val)
        [DllImport(LIBNAME)]
        private static extern void features2d_GFTTDetector_setHarrisDetector_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool val);

        // C++:  bool cv::GFTTDetector::getHarrisDetector()
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool features2d_GFTTDetector_getHarrisDetector_10(IntPtr nativeObj);

        // C++:  void cv::GFTTDetector::setK(double k)
        [DllImport(LIBNAME)]
        private static extern void features2d_GFTTDetector_setK_10(IntPtr nativeObj, double k);

        // C++:  double cv::GFTTDetector::getK()
        [DllImport(LIBNAME)]
        private static extern double features2d_GFTTDetector_getK_10(IntPtr nativeObj);

        // C++:  String cv::GFTTDetector::getDefaultName()
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_GFTTDetector_getDefaultName_10(IntPtr nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void features2d_GFTTDetector_delete(IntPtr nativeObj);

    }
}
