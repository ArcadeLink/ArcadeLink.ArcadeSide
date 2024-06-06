
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.Features2dModule
{

    // C++: class KAZE
    /**
     * Class implementing the KAZE keypoint detector and descriptor extractor, described in CITE: ABD12 .
     *
     * <b>Note:</b> AKAZE descriptor can only be used with KAZE or AKAZE keypoints .. [ABD12] KAZE Features. Pablo
     * F. Alcantarilla, Adrien Bartoli and Andrew J. Davison. In European Conference on Computer Vision
     * (ECCV), Fiorenze, Italy, October 2012.
     */

    public class KAZE : Feature2D
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
                        features2d_KAZE_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal KAZE(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new KAZE __fromPtr__(IntPtr addr) { return new KAZE(addr); }

        // C++: enum cv.KAZE.DiffusivityType
        public const int DIFF_PM_G1 = 0;
        public const int DIFF_PM_G2 = 1;
        public const int DIFF_WEICKERT = 2;
        public const int DIFF_CHARBONNIER = 3;
        //
        // C++: static Ptr_KAZE cv::KAZE::create(bool extended = false, bool upright = false, float threshold = 0.001f, int nOctaves = 4, int nOctaveLayers = 4, KAZE_DiffusivityType diffusivity = KAZE::DIFF_PM_G2)
        //

        /**
         * The KAZE constructor
         *
         *     param extended Set to enable extraction of extended (128-byte) descriptor.
         *     param upright Set to enable use of upright descriptors (non rotation-invariant).
         *     param threshold Detector response threshold to accept point
         *     param nOctaves Maximum octave evolution of the image
         *     param nOctaveLayers Default number of sublevels per scale level
         *     param diffusivity Diffusivity type. DIFF_PM_G1, DIFF_PM_G2, DIFF_WEICKERT or
         *     DIFF_CHARBONNIER
         * return automatically generated
         */
        public static KAZE create(bool extended, bool upright, float threshold, int nOctaves, int nOctaveLayers, int diffusivity)
        {


            return KAZE.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(features2d_KAZE_create_10(extended, upright, threshold, nOctaves, nOctaveLayers, diffusivity)));


        }

        /**
         * The KAZE constructor
         *
         *     param extended Set to enable extraction of extended (128-byte) descriptor.
         *     param upright Set to enable use of upright descriptors (non rotation-invariant).
         *     param threshold Detector response threshold to accept point
         *     param nOctaves Maximum octave evolution of the image
         *     param nOctaveLayers Default number of sublevels per scale level
         *     DIFF_CHARBONNIER
         * return automatically generated
         */
        public static KAZE create(bool extended, bool upright, float threshold, int nOctaves, int nOctaveLayers)
        {


            return KAZE.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(features2d_KAZE_create_11(extended, upright, threshold, nOctaves, nOctaveLayers)));


        }

        /**
         * The KAZE constructor
         *
         *     param extended Set to enable extraction of extended (128-byte) descriptor.
         *     param upright Set to enable use of upright descriptors (non rotation-invariant).
         *     param threshold Detector response threshold to accept point
         *     param nOctaves Maximum octave evolution of the image
         *     DIFF_CHARBONNIER
         * return automatically generated
         */
        public static KAZE create(bool extended, bool upright, float threshold, int nOctaves)
        {


            return KAZE.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(features2d_KAZE_create_12(extended, upright, threshold, nOctaves)));


        }

        /**
         * The KAZE constructor
         *
         *     param extended Set to enable extraction of extended (128-byte) descriptor.
         *     param upright Set to enable use of upright descriptors (non rotation-invariant).
         *     param threshold Detector response threshold to accept point
         *     DIFF_CHARBONNIER
         * return automatically generated
         */
        public static KAZE create(bool extended, bool upright, float threshold)
        {


            return KAZE.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(features2d_KAZE_create_13(extended, upright, threshold)));


        }

        /**
         * The KAZE constructor
         *
         *     param extended Set to enable extraction of extended (128-byte) descriptor.
         *     param upright Set to enable use of upright descriptors (non rotation-invariant).
         *     DIFF_CHARBONNIER
         * return automatically generated
         */
        public static KAZE create(bool extended, bool upright)
        {


            return KAZE.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(features2d_KAZE_create_14(extended, upright)));


        }

        /**
         * The KAZE constructor
         *
         *     param extended Set to enable extraction of extended (128-byte) descriptor.
         *     DIFF_CHARBONNIER
         * return automatically generated
         */
        public static KAZE create(bool extended)
        {


            return KAZE.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(features2d_KAZE_create_15(extended)));


        }

        /**
         * The KAZE constructor
         *
         *     DIFF_CHARBONNIER
         * return automatically generated
         */
        public static KAZE create()
        {


            return KAZE.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(features2d_KAZE_create_16()));


        }


        //
        // C++:  void cv::KAZE::setExtended(bool extended)
        //

        public void setExtended(bool extended)
        {
            ThrowIfDisposed();

            features2d_KAZE_setExtended_10(nativeObj, extended);


        }


        //
        // C++:  bool cv::KAZE::getExtended()
        //

        public bool getExtended()
        {
            ThrowIfDisposed();

            return features2d_KAZE_getExtended_10(nativeObj);


        }


        //
        // C++:  void cv::KAZE::setUpright(bool upright)
        //

        public void setUpright(bool upright)
        {
            ThrowIfDisposed();

            features2d_KAZE_setUpright_10(nativeObj, upright);


        }


        //
        // C++:  bool cv::KAZE::getUpright()
        //

        public bool getUpright()
        {
            ThrowIfDisposed();

            return features2d_KAZE_getUpright_10(nativeObj);


        }


        //
        // C++:  void cv::KAZE::setThreshold(double threshold)
        //

        public void setThreshold(double threshold)
        {
            ThrowIfDisposed();

            features2d_KAZE_setThreshold_10(nativeObj, threshold);


        }


        //
        // C++:  double cv::KAZE::getThreshold()
        //

        public double getThreshold()
        {
            ThrowIfDisposed();

            return features2d_KAZE_getThreshold_10(nativeObj);


        }


        //
        // C++:  void cv::KAZE::setNOctaves(int octaves)
        //

        public void setNOctaves(int octaves)
        {
            ThrowIfDisposed();

            features2d_KAZE_setNOctaves_10(nativeObj, octaves);


        }


        //
        // C++:  int cv::KAZE::getNOctaves()
        //

        public int getNOctaves()
        {
            ThrowIfDisposed();

            return features2d_KAZE_getNOctaves_10(nativeObj);


        }


        //
        // C++:  void cv::KAZE::setNOctaveLayers(int octaveLayers)
        //

        public void setNOctaveLayers(int octaveLayers)
        {
            ThrowIfDisposed();

            features2d_KAZE_setNOctaveLayers_10(nativeObj, octaveLayers);


        }


        //
        // C++:  int cv::KAZE::getNOctaveLayers()
        //

        public int getNOctaveLayers()
        {
            ThrowIfDisposed();

            return features2d_KAZE_getNOctaveLayers_10(nativeObj);


        }


        //
        // C++:  void cv::KAZE::setDiffusivity(KAZE_DiffusivityType diff)
        //

        public void setDiffusivity(int diff)
        {
            ThrowIfDisposed();

            features2d_KAZE_setDiffusivity_10(nativeObj, diff);


        }


        //
        // C++:  KAZE_DiffusivityType cv::KAZE::getDiffusivity()
        //

        public int getDiffusivity()
        {
            ThrowIfDisposed();

            return features2d_KAZE_getDiffusivity_10(nativeObj);


        }


        //
        // C++:  String cv::KAZE::getDefaultName()
        //

        public override string getDefaultName()
        {
            ThrowIfDisposed();

            string retVal = Marshal.PtrToStringAnsi(DisposableObject.ThrowIfNullIntPtr(features2d_KAZE_getDefaultName_10(nativeObj)));

            return retVal;
        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++: static Ptr_KAZE cv::KAZE::create(bool extended = false, bool upright = false, float threshold = 0.001f, int nOctaves = 4, int nOctaveLayers = 4, KAZE_DiffusivityType diffusivity = KAZE::DIFF_PM_G2)
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_KAZE_create_10([MarshalAs(UnmanagedType.U1)] bool extended, [MarshalAs(UnmanagedType.U1)] bool upright, float threshold, int nOctaves, int nOctaveLayers, int diffusivity);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_KAZE_create_11([MarshalAs(UnmanagedType.U1)] bool extended, [MarshalAs(UnmanagedType.U1)] bool upright, float threshold, int nOctaves, int nOctaveLayers);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_KAZE_create_12([MarshalAs(UnmanagedType.U1)] bool extended, [MarshalAs(UnmanagedType.U1)] bool upright, float threshold, int nOctaves);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_KAZE_create_13([MarshalAs(UnmanagedType.U1)] bool extended, [MarshalAs(UnmanagedType.U1)] bool upright, float threshold);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_KAZE_create_14([MarshalAs(UnmanagedType.U1)] bool extended, [MarshalAs(UnmanagedType.U1)] bool upright);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_KAZE_create_15([MarshalAs(UnmanagedType.U1)] bool extended);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_KAZE_create_16();

        // C++:  void cv::KAZE::setExtended(bool extended)
        [DllImport(LIBNAME)]
        private static extern void features2d_KAZE_setExtended_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool extended);

        // C++:  bool cv::KAZE::getExtended()
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool features2d_KAZE_getExtended_10(IntPtr nativeObj);

        // C++:  void cv::KAZE::setUpright(bool upright)
        [DllImport(LIBNAME)]
        private static extern void features2d_KAZE_setUpright_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool upright);

        // C++:  bool cv::KAZE::getUpright()
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool features2d_KAZE_getUpright_10(IntPtr nativeObj);

        // C++:  void cv::KAZE::setThreshold(double threshold)
        [DllImport(LIBNAME)]
        private static extern void features2d_KAZE_setThreshold_10(IntPtr nativeObj, double threshold);

        // C++:  double cv::KAZE::getThreshold()
        [DllImport(LIBNAME)]
        private static extern double features2d_KAZE_getThreshold_10(IntPtr nativeObj);

        // C++:  void cv::KAZE::setNOctaves(int octaves)
        [DllImport(LIBNAME)]
        private static extern void features2d_KAZE_setNOctaves_10(IntPtr nativeObj, int octaves);

        // C++:  int cv::KAZE::getNOctaves()
        [DllImport(LIBNAME)]
        private static extern int features2d_KAZE_getNOctaves_10(IntPtr nativeObj);

        // C++:  void cv::KAZE::setNOctaveLayers(int octaveLayers)
        [DllImport(LIBNAME)]
        private static extern void features2d_KAZE_setNOctaveLayers_10(IntPtr nativeObj, int octaveLayers);

        // C++:  int cv::KAZE::getNOctaveLayers()
        [DllImport(LIBNAME)]
        private static extern int features2d_KAZE_getNOctaveLayers_10(IntPtr nativeObj);

        // C++:  void cv::KAZE::setDiffusivity(KAZE_DiffusivityType diff)
        [DllImport(LIBNAME)]
        private static extern void features2d_KAZE_setDiffusivity_10(IntPtr nativeObj, int diff);

        // C++:  KAZE_DiffusivityType cv::KAZE::getDiffusivity()
        [DllImport(LIBNAME)]
        private static extern int features2d_KAZE_getDiffusivity_10(IntPtr nativeObj);

        // C++:  String cv::KAZE::getDefaultName()
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_KAZE_getDefaultName_10(IntPtr nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void features2d_KAZE_delete(IntPtr nativeObj);

    }
}
