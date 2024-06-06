
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.Features2dModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.Xfeatures2dModule
{

    // C++: class BoostDesc
    /**
     * Class implementing BoostDesc (Learning Image Descriptors with Boosting), described in
     * CITE: Trzcinski13a and CITE: Trzcinski13b.
     *
     * desc type of descriptor to use, BoostDesc::BINBOOST_256 is default (256 bit long dimension)
     * Available types are: BoostDesc::BGM, BoostDesc::BGM_HARD, BoostDesc::BGM_BILINEAR, BoostDesc::LBGM,
     * BoostDesc::BINBOOST_64, BoostDesc::BINBOOST_128, BoostDesc::BINBOOST_256
     * use_orientation sample patterns using keypoints orientation, enabled by default
     * scale_factor adjust the sampling window of detected keypoints
     * 6.25f is default and fits for KAZE, SURF detected keypoints window ratio
     * 6.75f should be the scale for SIFT detected keypoints window ratio
     * 5.00f should be the scale for AKAZE, MSD, AGAST, FAST, BRISK keypoints window ratio
     * 0.75f should be the scale for ORB keypoints ratio
     * 1.50f was the default in original implementation
     *
     * <b>Note:</b> BGM is the base descriptor where each binary dimension is computed as the output of a single weak learner.
     * BGM_HARD and BGM_BILINEAR refers to same BGM but use different type of gradient binning. In the BGM_HARD that
     * use ASSIGN_HARD binning type the gradient is assigned to the nearest orientation bin. In the BGM_BILINEAR that use
     * ASSIGN_BILINEAR binning type the gradient is assigned to the two neighbouring bins. In the BGM and all other modes that use
     * ASSIGN_SOFT binning type the gradient is assigned to 8 nearest bins according to the cosine value between the gradient
     * angle and the bin center. LBGM (alias FP-Boost) is the floating point extension where each dimension is computed
     * as a linear combination of the weak learner responses. BINBOOST and subvariants are the binary extensions of LBGM
     * where each bit is computed as a thresholded linear combination of a set of weak learners.
     * BoostDesc header files (boostdesc_*.i) was exported from original binaries with export-boostdesc.py script from
     * samples subfolder.
     */

    public class BoostDesc : Feature2D
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
                        xfeatures2d_BoostDesc_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal BoostDesc(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new BoostDesc __fromPtr__(IntPtr addr) { return new BoostDesc(addr); }

        //
        // C++: static Ptr_BoostDesc cv::xfeatures2d::BoostDesc::create(int desc = BoostDesc::BINBOOST_256, bool use_scale_orientation = true, float scale_factor = 6.25f)
        //

        public static BoostDesc create(int desc, bool use_scale_orientation, float scale_factor)
        {


            return BoostDesc.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_BoostDesc_create_10(desc, use_scale_orientation, scale_factor)));


        }

        public static BoostDesc create(int desc, bool use_scale_orientation)
        {


            return BoostDesc.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_BoostDesc_create_11(desc, use_scale_orientation)));


        }

        public static BoostDesc create(int desc)
        {


            return BoostDesc.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_BoostDesc_create_12(desc)));


        }

        public static BoostDesc create()
        {


            return BoostDesc.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_BoostDesc_create_13()));


        }


        //
        // C++:  String cv::xfeatures2d::BoostDesc::getDefaultName()
        //

        public override string getDefaultName()
        {
            ThrowIfDisposed();

            string retVal = Marshal.PtrToStringAnsi(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_BoostDesc_getDefaultName_10(nativeObj)));

            return retVal;
        }


        //
        // C++:  void cv::xfeatures2d::BoostDesc::setUseScaleOrientation(bool use_scale_orientation)
        //

        public void setUseScaleOrientation(bool use_scale_orientation)
        {
            ThrowIfDisposed();

            xfeatures2d_BoostDesc_setUseScaleOrientation_10(nativeObj, use_scale_orientation);


        }


        //
        // C++:  bool cv::xfeatures2d::BoostDesc::getUseScaleOrientation()
        //

        public bool getUseScaleOrientation()
        {
            ThrowIfDisposed();

            return xfeatures2d_BoostDesc_getUseScaleOrientation_10(nativeObj);


        }


        //
        // C++:  void cv::xfeatures2d::BoostDesc::setScaleFactor(float scale_factor)
        //

        public void setScaleFactor(float scale_factor)
        {
            ThrowIfDisposed();

            xfeatures2d_BoostDesc_setScaleFactor_10(nativeObj, scale_factor);


        }


        //
        // C++:  float cv::xfeatures2d::BoostDesc::getScaleFactor()
        //

        public float getScaleFactor()
        {
            ThrowIfDisposed();

            return xfeatures2d_BoostDesc_getScaleFactor_10(nativeObj);


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++: static Ptr_BoostDesc cv::xfeatures2d::BoostDesc::create(int desc = BoostDesc::BINBOOST_256, bool use_scale_orientation = true, float scale_factor = 6.25f)
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_BoostDesc_create_10(int desc, [MarshalAs(UnmanagedType.U1)] bool use_scale_orientation, float scale_factor);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_BoostDesc_create_11(int desc, [MarshalAs(UnmanagedType.U1)] bool use_scale_orientation);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_BoostDesc_create_12(int desc);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_BoostDesc_create_13();

        // C++:  String cv::xfeatures2d::BoostDesc::getDefaultName()
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_BoostDesc_getDefaultName_10(IntPtr nativeObj);

        // C++:  void cv::xfeatures2d::BoostDesc::setUseScaleOrientation(bool use_scale_orientation)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_BoostDesc_setUseScaleOrientation_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool use_scale_orientation);

        // C++:  bool cv::xfeatures2d::BoostDesc::getUseScaleOrientation()
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool xfeatures2d_BoostDesc_getUseScaleOrientation_10(IntPtr nativeObj);

        // C++:  void cv::xfeatures2d::BoostDesc::setScaleFactor(float scale_factor)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_BoostDesc_setScaleFactor_10(IntPtr nativeObj, float scale_factor);

        // C++:  float cv::xfeatures2d::BoostDesc::getScaleFactor()
        [DllImport(LIBNAME)]
        private static extern float xfeatures2d_BoostDesc_getScaleFactor_10(IntPtr nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_BoostDesc_delete(IntPtr nativeObj);

    }
}
