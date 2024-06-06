
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.Features2dModule
{

    // C++: class AKAZE
    /**
     * Class implementing the AKAZE keypoint detector and descriptor extractor, described in CITE: ANB13.
     *
     * AKAZE descriptors can only be used with KAZE or AKAZE keypoints. This class is thread-safe.
     *
     * <b>Note:</b> When you need descriptors use Feature2D::detectAndCompute, which
     * provides better performance. When using Feature2D::detect followed by
     * Feature2D::compute scale space pyramid is computed twice.
     *
     * <b>Note:</b> AKAZE implements T-API. When image is passed as UMat some parts of the algorithm
     * will use OpenCL.
     *
     * <b>Note:</b> [ANB13] Fast Explicit Diffusion for Accelerated Features in Nonlinear
     * Scale Spaces. Pablo F. Alcantarilla, Jesús Nuevo and Adrien Bartoli. In
     * British Machine Vision Conference (BMVC), Bristol, UK, September 2013.
     */

    public class AKAZE : Feature2D
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
                        features2d_AKAZE_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal AKAZE(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new AKAZE __fromPtr__(IntPtr addr) { return new AKAZE(addr); }

        // C++: enum cv.AKAZE.DescriptorType
        public const int DESCRIPTOR_KAZE_UPRIGHT = 2;
        public const int DESCRIPTOR_KAZE = 3;
        public const int DESCRIPTOR_MLDB_UPRIGHT = 4;
        public const int DESCRIPTOR_MLDB = 5;
        //
        // C++: static Ptr_AKAZE cv::AKAZE::create(AKAZE_DescriptorType descriptor_type = AKAZE::DESCRIPTOR_MLDB, int descriptor_size = 0, int descriptor_channels = 3, float threshold = 0.001f, int nOctaves = 4, int nOctaveLayers = 4, KAZE_DiffusivityType diffusivity = KAZE::DIFF_PM_G2)
        //

        /**
         * The AKAZE constructor
         *
         *     param descriptor_type Type of the extracted descriptor: DESCRIPTOR_KAZE,
         *     DESCRIPTOR_KAZE_UPRIGHT, DESCRIPTOR_MLDB or DESCRIPTOR_MLDB_UPRIGHT.
         *     param descriptor_size Size of the descriptor in bits. 0 -&gt; Full size
         *     param descriptor_channels Number of channels in the descriptor (1, 2, 3)
         *     param threshold Detector response threshold to accept point
         *     param nOctaves Maximum octave evolution of the image
         *     param nOctaveLayers Default number of sublevels per scale level
         *     param diffusivity Diffusivity type. DIFF_PM_G1, DIFF_PM_G2, DIFF_WEICKERT or
         *     DIFF_CHARBONNIER
         * return automatically generated
         */
        public static AKAZE create(int descriptor_type, int descriptor_size, int descriptor_channels, float threshold, int nOctaves, int nOctaveLayers, int diffusivity)
        {


            return AKAZE.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(features2d_AKAZE_create_10(descriptor_type, descriptor_size, descriptor_channels, threshold, nOctaves, nOctaveLayers, diffusivity)));


        }

        /**
         * The AKAZE constructor
         *
         *     param descriptor_type Type of the extracted descriptor: DESCRIPTOR_KAZE,
         *     DESCRIPTOR_KAZE_UPRIGHT, DESCRIPTOR_MLDB or DESCRIPTOR_MLDB_UPRIGHT.
         *     param descriptor_size Size of the descriptor in bits. 0 -&gt; Full size
         *     param descriptor_channels Number of channels in the descriptor (1, 2, 3)
         *     param threshold Detector response threshold to accept point
         *     param nOctaves Maximum octave evolution of the image
         *     param nOctaveLayers Default number of sublevels per scale level
         *     DIFF_CHARBONNIER
         * return automatically generated
         */
        public static AKAZE create(int descriptor_type, int descriptor_size, int descriptor_channels, float threshold, int nOctaves, int nOctaveLayers)
        {


            return AKAZE.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(features2d_AKAZE_create_11(descriptor_type, descriptor_size, descriptor_channels, threshold, nOctaves, nOctaveLayers)));


        }

        /**
         * The AKAZE constructor
         *
         *     param descriptor_type Type of the extracted descriptor: DESCRIPTOR_KAZE,
         *     DESCRIPTOR_KAZE_UPRIGHT, DESCRIPTOR_MLDB or DESCRIPTOR_MLDB_UPRIGHT.
         *     param descriptor_size Size of the descriptor in bits. 0 -&gt; Full size
         *     param descriptor_channels Number of channels in the descriptor (1, 2, 3)
         *     param threshold Detector response threshold to accept point
         *     param nOctaves Maximum octave evolution of the image
         *     DIFF_CHARBONNIER
         * return automatically generated
         */
        public static AKAZE create(int descriptor_type, int descriptor_size, int descriptor_channels, float threshold, int nOctaves)
        {


            return AKAZE.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(features2d_AKAZE_create_12(descriptor_type, descriptor_size, descriptor_channels, threshold, nOctaves)));


        }

        /**
         * The AKAZE constructor
         *
         *     param descriptor_type Type of the extracted descriptor: DESCRIPTOR_KAZE,
         *     DESCRIPTOR_KAZE_UPRIGHT, DESCRIPTOR_MLDB or DESCRIPTOR_MLDB_UPRIGHT.
         *     param descriptor_size Size of the descriptor in bits. 0 -&gt; Full size
         *     param descriptor_channels Number of channels in the descriptor (1, 2, 3)
         *     param threshold Detector response threshold to accept point
         *     DIFF_CHARBONNIER
         * return automatically generated
         */
        public static AKAZE create(int descriptor_type, int descriptor_size, int descriptor_channels, float threshold)
        {


            return AKAZE.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(features2d_AKAZE_create_13(descriptor_type, descriptor_size, descriptor_channels, threshold)));


        }

        /**
         * The AKAZE constructor
         *
         *     param descriptor_type Type of the extracted descriptor: DESCRIPTOR_KAZE,
         *     DESCRIPTOR_KAZE_UPRIGHT, DESCRIPTOR_MLDB or DESCRIPTOR_MLDB_UPRIGHT.
         *     param descriptor_size Size of the descriptor in bits. 0 -&gt; Full size
         *     param descriptor_channels Number of channels in the descriptor (1, 2, 3)
         *     DIFF_CHARBONNIER
         * return automatically generated
         */
        public static AKAZE create(int descriptor_type, int descriptor_size, int descriptor_channels)
        {


            return AKAZE.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(features2d_AKAZE_create_14(descriptor_type, descriptor_size, descriptor_channels)));


        }

        /**
         * The AKAZE constructor
         *
         *     param descriptor_type Type of the extracted descriptor: DESCRIPTOR_KAZE,
         *     DESCRIPTOR_KAZE_UPRIGHT, DESCRIPTOR_MLDB or DESCRIPTOR_MLDB_UPRIGHT.
         *     param descriptor_size Size of the descriptor in bits. 0 -&gt; Full size
         *     DIFF_CHARBONNIER
         * return automatically generated
         */
        public static AKAZE create(int descriptor_type, int descriptor_size)
        {


            return AKAZE.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(features2d_AKAZE_create_15(descriptor_type, descriptor_size)));


        }

        /**
         * The AKAZE constructor
         *
         *     param descriptor_type Type of the extracted descriptor: DESCRIPTOR_KAZE,
         *     DESCRIPTOR_KAZE_UPRIGHT, DESCRIPTOR_MLDB or DESCRIPTOR_MLDB_UPRIGHT.
         *     DIFF_CHARBONNIER
         * return automatically generated
         */
        public static AKAZE create(int descriptor_type)
        {


            return AKAZE.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(features2d_AKAZE_create_16(descriptor_type)));


        }

        /**
         * The AKAZE constructor
         *
         *     DESCRIPTOR_KAZE_UPRIGHT, DESCRIPTOR_MLDB or DESCRIPTOR_MLDB_UPRIGHT.
         *     DIFF_CHARBONNIER
         * return automatically generated
         */
        public static AKAZE create()
        {


            return AKAZE.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(features2d_AKAZE_create_17()));


        }


        //
        // C++:  void cv::AKAZE::setDescriptorType(AKAZE_DescriptorType dtype)
        //

        public void setDescriptorType(int dtype)
        {
            ThrowIfDisposed();

            features2d_AKAZE_setDescriptorType_10(nativeObj, dtype);


        }


        //
        // C++:  AKAZE_DescriptorType cv::AKAZE::getDescriptorType()
        //

        public int getDescriptorType()
        {
            ThrowIfDisposed();

            return features2d_AKAZE_getDescriptorType_10(nativeObj);


        }


        //
        // C++:  void cv::AKAZE::setDescriptorSize(int dsize)
        //

        public void setDescriptorSize(int dsize)
        {
            ThrowIfDisposed();

            features2d_AKAZE_setDescriptorSize_10(nativeObj, dsize);


        }


        //
        // C++:  int cv::AKAZE::getDescriptorSize()
        //

        public int getDescriptorSize()
        {
            ThrowIfDisposed();

            return features2d_AKAZE_getDescriptorSize_10(nativeObj);


        }


        //
        // C++:  void cv::AKAZE::setDescriptorChannels(int dch)
        //

        public void setDescriptorChannels(int dch)
        {
            ThrowIfDisposed();

            features2d_AKAZE_setDescriptorChannels_10(nativeObj, dch);


        }


        //
        // C++:  int cv::AKAZE::getDescriptorChannels()
        //

        public int getDescriptorChannels()
        {
            ThrowIfDisposed();

            return features2d_AKAZE_getDescriptorChannels_10(nativeObj);


        }


        //
        // C++:  void cv::AKAZE::setThreshold(double threshold)
        //

        public void setThreshold(double threshold)
        {
            ThrowIfDisposed();

            features2d_AKAZE_setThreshold_10(nativeObj, threshold);


        }


        //
        // C++:  double cv::AKAZE::getThreshold()
        //

        public double getThreshold()
        {
            ThrowIfDisposed();

            return features2d_AKAZE_getThreshold_10(nativeObj);


        }


        //
        // C++:  void cv::AKAZE::setNOctaves(int octaves)
        //

        public void setNOctaves(int octaves)
        {
            ThrowIfDisposed();

            features2d_AKAZE_setNOctaves_10(nativeObj, octaves);


        }


        //
        // C++:  int cv::AKAZE::getNOctaves()
        //

        public int getNOctaves()
        {
            ThrowIfDisposed();

            return features2d_AKAZE_getNOctaves_10(nativeObj);


        }


        //
        // C++:  void cv::AKAZE::setNOctaveLayers(int octaveLayers)
        //

        public void setNOctaveLayers(int octaveLayers)
        {
            ThrowIfDisposed();

            features2d_AKAZE_setNOctaveLayers_10(nativeObj, octaveLayers);


        }


        //
        // C++:  int cv::AKAZE::getNOctaveLayers()
        //

        public int getNOctaveLayers()
        {
            ThrowIfDisposed();

            return features2d_AKAZE_getNOctaveLayers_10(nativeObj);


        }


        //
        // C++:  void cv::AKAZE::setDiffusivity(KAZE_DiffusivityType diff)
        //

        public void setDiffusivity(int diff)
        {
            ThrowIfDisposed();

            features2d_AKAZE_setDiffusivity_10(nativeObj, diff);


        }


        //
        // C++:  KAZE_DiffusivityType cv::AKAZE::getDiffusivity()
        //

        public int getDiffusivity()
        {
            ThrowIfDisposed();

            return features2d_AKAZE_getDiffusivity_10(nativeObj);


        }


        //
        // C++:  String cv::AKAZE::getDefaultName()
        //

        public override string getDefaultName()
        {
            ThrowIfDisposed();

            string retVal = Marshal.PtrToStringAnsi(DisposableObject.ThrowIfNullIntPtr(features2d_AKAZE_getDefaultName_10(nativeObj)));

            return retVal;
        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++: static Ptr_AKAZE cv::AKAZE::create(AKAZE_DescriptorType descriptor_type = AKAZE::DESCRIPTOR_MLDB, int descriptor_size = 0, int descriptor_channels = 3, float threshold = 0.001f, int nOctaves = 4, int nOctaveLayers = 4, KAZE_DiffusivityType diffusivity = KAZE::DIFF_PM_G2)
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_AKAZE_create_10(int descriptor_type, int descriptor_size, int descriptor_channels, float threshold, int nOctaves, int nOctaveLayers, int diffusivity);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_AKAZE_create_11(int descriptor_type, int descriptor_size, int descriptor_channels, float threshold, int nOctaves, int nOctaveLayers);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_AKAZE_create_12(int descriptor_type, int descriptor_size, int descriptor_channels, float threshold, int nOctaves);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_AKAZE_create_13(int descriptor_type, int descriptor_size, int descriptor_channels, float threshold);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_AKAZE_create_14(int descriptor_type, int descriptor_size, int descriptor_channels);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_AKAZE_create_15(int descriptor_type, int descriptor_size);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_AKAZE_create_16(int descriptor_type);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_AKAZE_create_17();

        // C++:  void cv::AKAZE::setDescriptorType(AKAZE_DescriptorType dtype)
        [DllImport(LIBNAME)]
        private static extern void features2d_AKAZE_setDescriptorType_10(IntPtr nativeObj, int dtype);

        // C++:  AKAZE_DescriptorType cv::AKAZE::getDescriptorType()
        [DllImport(LIBNAME)]
        private static extern int features2d_AKAZE_getDescriptorType_10(IntPtr nativeObj);

        // C++:  void cv::AKAZE::setDescriptorSize(int dsize)
        [DllImport(LIBNAME)]
        private static extern void features2d_AKAZE_setDescriptorSize_10(IntPtr nativeObj, int dsize);

        // C++:  int cv::AKAZE::getDescriptorSize()
        [DllImport(LIBNAME)]
        private static extern int features2d_AKAZE_getDescriptorSize_10(IntPtr nativeObj);

        // C++:  void cv::AKAZE::setDescriptorChannels(int dch)
        [DllImport(LIBNAME)]
        private static extern void features2d_AKAZE_setDescriptorChannels_10(IntPtr nativeObj, int dch);

        // C++:  int cv::AKAZE::getDescriptorChannels()
        [DllImport(LIBNAME)]
        private static extern int features2d_AKAZE_getDescriptorChannels_10(IntPtr nativeObj);

        // C++:  void cv::AKAZE::setThreshold(double threshold)
        [DllImport(LIBNAME)]
        private static extern void features2d_AKAZE_setThreshold_10(IntPtr nativeObj, double threshold);

        // C++:  double cv::AKAZE::getThreshold()
        [DllImport(LIBNAME)]
        private static extern double features2d_AKAZE_getThreshold_10(IntPtr nativeObj);

        // C++:  void cv::AKAZE::setNOctaves(int octaves)
        [DllImport(LIBNAME)]
        private static extern void features2d_AKAZE_setNOctaves_10(IntPtr nativeObj, int octaves);

        // C++:  int cv::AKAZE::getNOctaves()
        [DllImport(LIBNAME)]
        private static extern int features2d_AKAZE_getNOctaves_10(IntPtr nativeObj);

        // C++:  void cv::AKAZE::setNOctaveLayers(int octaveLayers)
        [DllImport(LIBNAME)]
        private static extern void features2d_AKAZE_setNOctaveLayers_10(IntPtr nativeObj, int octaveLayers);

        // C++:  int cv::AKAZE::getNOctaveLayers()
        [DllImport(LIBNAME)]
        private static extern int features2d_AKAZE_getNOctaveLayers_10(IntPtr nativeObj);

        // C++:  void cv::AKAZE::setDiffusivity(KAZE_DiffusivityType diff)
        [DllImport(LIBNAME)]
        private static extern void features2d_AKAZE_setDiffusivity_10(IntPtr nativeObj, int diff);

        // C++:  KAZE_DiffusivityType cv::AKAZE::getDiffusivity()
        [DllImport(LIBNAME)]
        private static extern int features2d_AKAZE_getDiffusivity_10(IntPtr nativeObj);

        // C++:  String cv::AKAZE::getDefaultName()
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_AKAZE_getDefaultName_10(IntPtr nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void features2d_AKAZE_delete(IntPtr nativeObj);

    }
}
