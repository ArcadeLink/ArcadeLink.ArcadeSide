
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.Features2dModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.Xfeatures2dModule
{

    // C++: class DAISY
    /**
     * Class implementing DAISY descriptor, described in CITE: Tola10
     *
     * radius radius of the descriptor at the initial scale
     * q_radius amount of radial range division quantity
     * q_theta amount of angular range division quantity
     * q_hist amount of gradient orientations range division quantity
     * norm choose descriptors normalization type, where
     * DAISY::NRM_NONE will not do any normalization (default),
     * DAISY::NRM_PARTIAL mean that histograms are normalized independently for L2 norm equal to 1.0,
     * DAISY::NRM_FULL mean that descriptors are normalized for L2 norm equal to 1.0,
     * DAISY::NRM_SIFT mean that descriptors are normalized for L2 norm equal to 1.0 but no individual one is bigger than 0.154 as in SIFT
     * H optional 3x3 homography matrix used to warp the grid of daisy but sampling keypoints remains unwarped on image
     * interpolation switch to disable interpolation for speed improvement at minor quality loss
     * use_orientation sample patterns using keypoints orientation, disabled by default.
     */

    public class DAISY : Feature2D
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
                        xfeatures2d_DAISY_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal DAISY(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new DAISY __fromPtr__(IntPtr addr) { return new DAISY(addr); }

        // C++: enum cv.xfeatures2d.DAISY.NormalizationType
        public const int NRM_NONE = 100;
        public const int NRM_PARTIAL = 101;
        public const int NRM_FULL = 102;
        public const int NRM_SIFT = 103;
        //
        // C++: static Ptr_DAISY cv::xfeatures2d::DAISY::create(float radius = 15, int q_radius = 3, int q_theta = 8, int q_hist = 8, DAISY_NormalizationType norm = DAISY::NRM_NONE, Mat H = Mat(), bool interpolation = true, bool use_orientation = false)
        //

        public static DAISY create(float radius, int q_radius, int q_theta, int q_hist, Mat H, bool interpolation, bool use_orientation)
        {
            if (H != null) H.ThrowIfDisposed();

            return DAISY.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_DAISY_create_10(radius, q_radius, q_theta, q_hist, H.nativeObj, interpolation, use_orientation)));


        }

        public static DAISY create(float radius, int q_radius, int q_theta, int q_hist, Mat H, bool interpolation)
        {
            if (H != null) H.ThrowIfDisposed();

            return DAISY.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_DAISY_create_11(radius, q_radius, q_theta, q_hist, H.nativeObj, interpolation)));


        }

        public static DAISY create(float radius, int q_radius, int q_theta, int q_hist, Mat H)
        {
            if (H != null) H.ThrowIfDisposed();

            return DAISY.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_DAISY_create_12(radius, q_radius, q_theta, q_hist, H.nativeObj)));


        }

        public static DAISY create(float radius, int q_radius, int q_theta, int q_hist)
        {


            return DAISY.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_DAISY_create_13(radius, q_radius, q_theta, q_hist)));


        }

        public static DAISY create(float radius, int q_radius, int q_theta)
        {


            return DAISY.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_DAISY_create_15(radius, q_radius, q_theta)));


        }

        public static DAISY create(float radius, int q_radius)
        {


            return DAISY.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_DAISY_create_16(radius, q_radius)));


        }

        public static DAISY create(float radius)
        {


            return DAISY.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_DAISY_create_17(radius)));


        }

        public static DAISY create()
        {


            return DAISY.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_DAISY_create_18()));


        }


        //
        // C++:  void cv::xfeatures2d::DAISY::setRadius(float radius)
        //

        public void setRadius(float radius)
        {
            ThrowIfDisposed();

            xfeatures2d_DAISY_setRadius_10(nativeObj, radius);


        }


        //
        // C++:  float cv::xfeatures2d::DAISY::getRadius()
        //

        public float getRadius()
        {
            ThrowIfDisposed();

            return xfeatures2d_DAISY_getRadius_10(nativeObj);


        }


        //
        // C++:  void cv::xfeatures2d::DAISY::setQRadius(int q_radius)
        //

        public void setQRadius(int q_radius)
        {
            ThrowIfDisposed();

            xfeatures2d_DAISY_setQRadius_10(nativeObj, q_radius);


        }


        //
        // C++:  int cv::xfeatures2d::DAISY::getQRadius()
        //

        public int getQRadius()
        {
            ThrowIfDisposed();

            return xfeatures2d_DAISY_getQRadius_10(nativeObj);


        }


        //
        // C++:  void cv::xfeatures2d::DAISY::setQTheta(int q_theta)
        //

        public void setQTheta(int q_theta)
        {
            ThrowIfDisposed();

            xfeatures2d_DAISY_setQTheta_10(nativeObj, q_theta);


        }


        //
        // C++:  int cv::xfeatures2d::DAISY::getQTheta()
        //

        public int getQTheta()
        {
            ThrowIfDisposed();

            return xfeatures2d_DAISY_getQTheta_10(nativeObj);


        }


        //
        // C++:  void cv::xfeatures2d::DAISY::setQHist(int q_hist)
        //

        public void setQHist(int q_hist)
        {
            ThrowIfDisposed();

            xfeatures2d_DAISY_setQHist_10(nativeObj, q_hist);


        }


        //
        // C++:  int cv::xfeatures2d::DAISY::getQHist()
        //

        public int getQHist()
        {
            ThrowIfDisposed();

            return xfeatures2d_DAISY_getQHist_10(nativeObj);


        }


        //
        // C++:  void cv::xfeatures2d::DAISY::setNorm(int norm)
        //

        public void setNorm(int norm)
        {
            ThrowIfDisposed();

            xfeatures2d_DAISY_setNorm_10(nativeObj, norm);


        }


        //
        // C++:  int cv::xfeatures2d::DAISY::getNorm()
        //

        public int getNorm()
        {
            ThrowIfDisposed();

            return xfeatures2d_DAISY_getNorm_10(nativeObj);


        }


        //
        // C++:  void cv::xfeatures2d::DAISY::setH(Mat H)
        //

        public void setH(Mat H)
        {
            ThrowIfDisposed();
            if (H != null) H.ThrowIfDisposed();

            xfeatures2d_DAISY_setH_10(nativeObj, H.nativeObj);


        }


        //
        // C++:  Mat cv::xfeatures2d::DAISY::getH()
        //

        public Mat getH()
        {
            ThrowIfDisposed();

            return new Mat(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_DAISY_getH_10(nativeObj)));


        }


        //
        // C++:  void cv::xfeatures2d::DAISY::setInterpolation(bool interpolation)
        //

        public void setInterpolation(bool interpolation)
        {
            ThrowIfDisposed();

            xfeatures2d_DAISY_setInterpolation_10(nativeObj, interpolation);


        }


        //
        // C++:  bool cv::xfeatures2d::DAISY::getInterpolation()
        //

        public bool getInterpolation()
        {
            ThrowIfDisposed();

            return xfeatures2d_DAISY_getInterpolation_10(nativeObj);


        }


        //
        // C++:  void cv::xfeatures2d::DAISY::setUseOrientation(bool use_orientation)
        //

        public void setUseOrientation(bool use_orientation)
        {
            ThrowIfDisposed();

            xfeatures2d_DAISY_setUseOrientation_10(nativeObj, use_orientation);


        }


        //
        // C++:  bool cv::xfeatures2d::DAISY::getUseOrientation()
        //

        public bool getUseOrientation()
        {
            ThrowIfDisposed();

            return xfeatures2d_DAISY_getUseOrientation_10(nativeObj);


        }


        //
        // C++:  String cv::xfeatures2d::DAISY::getDefaultName()
        //

        public override string getDefaultName()
        {
            ThrowIfDisposed();

            string retVal = Marshal.PtrToStringAnsi(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_DAISY_getDefaultName_10(nativeObj)));

            return retVal;
        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++: static Ptr_DAISY cv::xfeatures2d::DAISY::create(float radius = 15, int q_radius = 3, int q_theta = 8, int q_hist = 8, DAISY_NormalizationType norm = DAISY::NRM_NONE, Mat H = Mat(), bool interpolation = true, bool use_orientation = false)
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_DAISY_create_10(float radius, int q_radius, int q_theta, int q_hist, IntPtr H_nativeObj, [MarshalAs(UnmanagedType.U1)] bool interpolation, [MarshalAs(UnmanagedType.U1)] bool use_orientation);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_DAISY_create_11(float radius, int q_radius, int q_theta, int q_hist, IntPtr H_nativeObj, [MarshalAs(UnmanagedType.U1)] bool interpolation);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_DAISY_create_12(float radius, int q_radius, int q_theta, int q_hist, IntPtr H_nativeObj);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_DAISY_create_13(float radius, int q_radius, int q_theta, int q_hist);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_DAISY_create_15(float radius, int q_radius, int q_theta);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_DAISY_create_16(float radius, int q_radius);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_DAISY_create_17(float radius);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_DAISY_create_18();

        // C++:  void cv::xfeatures2d::DAISY::setRadius(float radius)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_DAISY_setRadius_10(IntPtr nativeObj, float radius);

        // C++:  float cv::xfeatures2d::DAISY::getRadius()
        [DllImport(LIBNAME)]
        private static extern float xfeatures2d_DAISY_getRadius_10(IntPtr nativeObj);

        // C++:  void cv::xfeatures2d::DAISY::setQRadius(int q_radius)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_DAISY_setQRadius_10(IntPtr nativeObj, int q_radius);

        // C++:  int cv::xfeatures2d::DAISY::getQRadius()
        [DllImport(LIBNAME)]
        private static extern int xfeatures2d_DAISY_getQRadius_10(IntPtr nativeObj);

        // C++:  void cv::xfeatures2d::DAISY::setQTheta(int q_theta)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_DAISY_setQTheta_10(IntPtr nativeObj, int q_theta);

        // C++:  int cv::xfeatures2d::DAISY::getQTheta()
        [DllImport(LIBNAME)]
        private static extern int xfeatures2d_DAISY_getQTheta_10(IntPtr nativeObj);

        // C++:  void cv::xfeatures2d::DAISY::setQHist(int q_hist)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_DAISY_setQHist_10(IntPtr nativeObj, int q_hist);

        // C++:  int cv::xfeatures2d::DAISY::getQHist()
        [DllImport(LIBNAME)]
        private static extern int xfeatures2d_DAISY_getQHist_10(IntPtr nativeObj);

        // C++:  void cv::xfeatures2d::DAISY::setNorm(int norm)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_DAISY_setNorm_10(IntPtr nativeObj, int norm);

        // C++:  int cv::xfeatures2d::DAISY::getNorm()
        [DllImport(LIBNAME)]
        private static extern int xfeatures2d_DAISY_getNorm_10(IntPtr nativeObj);

        // C++:  void cv::xfeatures2d::DAISY::setH(Mat H)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_DAISY_setH_10(IntPtr nativeObj, IntPtr H_nativeObj);

        // C++:  Mat cv::xfeatures2d::DAISY::getH()
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_DAISY_getH_10(IntPtr nativeObj);

        // C++:  void cv::xfeatures2d::DAISY::setInterpolation(bool interpolation)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_DAISY_setInterpolation_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool interpolation);

        // C++:  bool cv::xfeatures2d::DAISY::getInterpolation()
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool xfeatures2d_DAISY_getInterpolation_10(IntPtr nativeObj);

        // C++:  void cv::xfeatures2d::DAISY::setUseOrientation(bool use_orientation)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_DAISY_setUseOrientation_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool use_orientation);

        // C++:  bool cv::xfeatures2d::DAISY::getUseOrientation()
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool xfeatures2d_DAISY_getUseOrientation_10(IntPtr nativeObj);

        // C++:  String cv::xfeatures2d::DAISY::getDefaultName()
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_DAISY_getDefaultName_10(IntPtr nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_DAISY_delete(IntPtr nativeObj);

    }
}
