
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.Features2dModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.Xfeatures2dModule
{

    // C++: class VGG
    /**
     * Class implementing VGG (Oxford Visual Geometry Group) descriptor trained end to end
     * using "Descriptor Learning Using Convex Optimisation" (DLCO) aparatus described in CITE: Simonyan14.
     *
     * desc type of descriptor to use, VGG::VGG_120 is default (120 dimensions float)
     * Available types are VGG::VGG_120, VGG::VGG_80, VGG::VGG_64, VGG::VGG_48
     * isigma gaussian kernel value for image blur (default is 1.4f)
     * img_normalize use image sample intensity normalization (enabled by default)
     * use_orientation sample patterns using keypoints orientation, enabled by default
     * scale_factor adjust the sampling window of detected keypoints to 64.0f (VGG sampling window)
     * 6.25f is default and fits for KAZE, SURF detected keypoints window ratio
     * 6.75f should be the scale for SIFT detected keypoints window ratio
     * 5.00f should be the scale for AKAZE, MSD, AGAST, FAST, BRISK keypoints window ratio
     * 0.75f should be the scale for ORB keypoints ratio
     *
     * dsc_normalize clamp descriptors to 255 and convert to uchar CV_8UC1 (disabled by default)
     */

    public class VGG : Feature2D
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
                        xfeatures2d_VGG_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal VGG(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new VGG __fromPtr__(IntPtr addr) { return new VGG(addr); }

        //
        // C++: static Ptr_VGG cv::xfeatures2d::VGG::create(int desc = VGG::VGG_120, float isigma = 1.4f, bool img_normalize = true, bool use_scale_orientation = true, float scale_factor = 6.25f, bool dsc_normalize = false)
        //

        public static VGG create(int desc, float isigma, bool img_normalize, bool use_scale_orientation, float scale_factor, bool dsc_normalize)
        {


            return VGG.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_VGG_create_10(desc, isigma, img_normalize, use_scale_orientation, scale_factor, dsc_normalize)));


        }

        public static VGG create(int desc, float isigma, bool img_normalize, bool use_scale_orientation, float scale_factor)
        {


            return VGG.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_VGG_create_11(desc, isigma, img_normalize, use_scale_orientation, scale_factor)));


        }

        public static VGG create(int desc, float isigma, bool img_normalize, bool use_scale_orientation)
        {


            return VGG.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_VGG_create_12(desc, isigma, img_normalize, use_scale_orientation)));


        }

        public static VGG create(int desc, float isigma, bool img_normalize)
        {


            return VGG.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_VGG_create_13(desc, isigma, img_normalize)));


        }

        public static VGG create(int desc, float isigma)
        {


            return VGG.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_VGG_create_14(desc, isigma)));


        }

        public static VGG create(int desc)
        {


            return VGG.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_VGG_create_15(desc)));


        }

        public static VGG create()
        {


            return VGG.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_VGG_create_16()));


        }


        //
        // C++:  String cv::xfeatures2d::VGG::getDefaultName()
        //

        public override string getDefaultName()
        {
            ThrowIfDisposed();

            string retVal = Marshal.PtrToStringAnsi(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_VGG_getDefaultName_10(nativeObj)));

            return retVal;
        }


        //
        // C++:  void cv::xfeatures2d::VGG::setSigma(float isigma)
        //

        public void setSigma(float isigma)
        {
            ThrowIfDisposed();

            xfeatures2d_VGG_setSigma_10(nativeObj, isigma);


        }


        //
        // C++:  float cv::xfeatures2d::VGG::getSigma()
        //

        public float getSigma()
        {
            ThrowIfDisposed();

            return xfeatures2d_VGG_getSigma_10(nativeObj);


        }


        //
        // C++:  void cv::xfeatures2d::VGG::setUseNormalizeImage(bool img_normalize)
        //

        public void setUseNormalizeImage(bool img_normalize)
        {
            ThrowIfDisposed();

            xfeatures2d_VGG_setUseNormalizeImage_10(nativeObj, img_normalize);


        }


        //
        // C++:  bool cv::xfeatures2d::VGG::getUseNormalizeImage()
        //

        public bool getUseNormalizeImage()
        {
            ThrowIfDisposed();

            return xfeatures2d_VGG_getUseNormalizeImage_10(nativeObj);


        }


        //
        // C++:  void cv::xfeatures2d::VGG::setUseScaleOrientation(bool use_scale_orientation)
        //

        public void setUseScaleOrientation(bool use_scale_orientation)
        {
            ThrowIfDisposed();

            xfeatures2d_VGG_setUseScaleOrientation_10(nativeObj, use_scale_orientation);


        }


        //
        // C++:  bool cv::xfeatures2d::VGG::getUseScaleOrientation()
        //

        public bool getUseScaleOrientation()
        {
            ThrowIfDisposed();

            return xfeatures2d_VGG_getUseScaleOrientation_10(nativeObj);


        }


        //
        // C++:  void cv::xfeatures2d::VGG::setScaleFactor(float scale_factor)
        //

        public void setScaleFactor(float scale_factor)
        {
            ThrowIfDisposed();

            xfeatures2d_VGG_setScaleFactor_10(nativeObj, scale_factor);


        }


        //
        // C++:  float cv::xfeatures2d::VGG::getScaleFactor()
        //

        public float getScaleFactor()
        {
            ThrowIfDisposed();

            return xfeatures2d_VGG_getScaleFactor_10(nativeObj);


        }


        //
        // C++:  void cv::xfeatures2d::VGG::setUseNormalizeDescriptor(bool dsc_normalize)
        //

        public void setUseNormalizeDescriptor(bool dsc_normalize)
        {
            ThrowIfDisposed();

            xfeatures2d_VGG_setUseNormalizeDescriptor_10(nativeObj, dsc_normalize);


        }


        //
        // C++:  bool cv::xfeatures2d::VGG::getUseNormalizeDescriptor()
        //

        public bool getUseNormalizeDescriptor()
        {
            ThrowIfDisposed();

            return xfeatures2d_VGG_getUseNormalizeDescriptor_10(nativeObj);


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++: static Ptr_VGG cv::xfeatures2d::VGG::create(int desc = VGG::VGG_120, float isigma = 1.4f, bool img_normalize = true, bool use_scale_orientation = true, float scale_factor = 6.25f, bool dsc_normalize = false)
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_VGG_create_10(int desc, float isigma, [MarshalAs(UnmanagedType.U1)] bool img_normalize, [MarshalAs(UnmanagedType.U1)] bool use_scale_orientation, float scale_factor, [MarshalAs(UnmanagedType.U1)] bool dsc_normalize);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_VGG_create_11(int desc, float isigma, [MarshalAs(UnmanagedType.U1)] bool img_normalize, [MarshalAs(UnmanagedType.U1)] bool use_scale_orientation, float scale_factor);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_VGG_create_12(int desc, float isigma, [MarshalAs(UnmanagedType.U1)] bool img_normalize, [MarshalAs(UnmanagedType.U1)] bool use_scale_orientation);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_VGG_create_13(int desc, float isigma, [MarshalAs(UnmanagedType.U1)] bool img_normalize);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_VGG_create_14(int desc, float isigma);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_VGG_create_15(int desc);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_VGG_create_16();

        // C++:  String cv::xfeatures2d::VGG::getDefaultName()
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_VGG_getDefaultName_10(IntPtr nativeObj);

        // C++:  void cv::xfeatures2d::VGG::setSigma(float isigma)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_VGG_setSigma_10(IntPtr nativeObj, float isigma);

        // C++:  float cv::xfeatures2d::VGG::getSigma()
        [DllImport(LIBNAME)]
        private static extern float xfeatures2d_VGG_getSigma_10(IntPtr nativeObj);

        // C++:  void cv::xfeatures2d::VGG::setUseNormalizeImage(bool img_normalize)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_VGG_setUseNormalizeImage_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool img_normalize);

        // C++:  bool cv::xfeatures2d::VGG::getUseNormalizeImage()
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool xfeatures2d_VGG_getUseNormalizeImage_10(IntPtr nativeObj);

        // C++:  void cv::xfeatures2d::VGG::setUseScaleOrientation(bool use_scale_orientation)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_VGG_setUseScaleOrientation_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool use_scale_orientation);

        // C++:  bool cv::xfeatures2d::VGG::getUseScaleOrientation()
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool xfeatures2d_VGG_getUseScaleOrientation_10(IntPtr nativeObj);

        // C++:  void cv::xfeatures2d::VGG::setScaleFactor(float scale_factor)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_VGG_setScaleFactor_10(IntPtr nativeObj, float scale_factor);

        // C++:  float cv::xfeatures2d::VGG::getScaleFactor()
        [DllImport(LIBNAME)]
        private static extern float xfeatures2d_VGG_getScaleFactor_10(IntPtr nativeObj);

        // C++:  void cv::xfeatures2d::VGG::setUseNormalizeDescriptor(bool dsc_normalize)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_VGG_setUseNormalizeDescriptor_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool dsc_normalize);

        // C++:  bool cv::xfeatures2d::VGG::getUseNormalizeDescriptor()
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool xfeatures2d_VGG_getUseNormalizeDescriptor_10(IntPtr nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_VGG_delete(IntPtr nativeObj);

    }
}
