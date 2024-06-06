
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.Xfeatures2dModule
{

    // C++: class TBMR
    /**
     * Class implementing the Tree Based Morse Regions (TBMR) as described in
     * CITE: Najman2014 extended with scaled extraction ability.
     *
     * min_area prune areas smaller than minArea
     * max_area_relative prune areas bigger than maxArea = max_area_relative *
     * input_image_size
     * scale_factor scale factor for scaled extraction.
     * n_scales number of applications of the scale factor (octaves).
     *
     * <b>Note:</b> This algorithm is based on Component Tree (Min/Max) as well as MSER but
     * uses a Morse-theory approach to extract features.
     *
     * Features are ellipses (similar to MSER, however a MSER feature can never be a
     * TBMR feature and vice versa).
     */

    public class TBMR : AffineFeature2D
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
                        xfeatures2d_TBMR_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal TBMR(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new TBMR __fromPtr__(IntPtr addr) { return new TBMR(addr); }

        //
        // C++: static Ptr_TBMR cv::xfeatures2d::TBMR::create(int min_area = 60, float max_area_relative = 0.01f, float scale_factor = 1.25f, int n_scales = -1)
        //

        public static TBMR create(int min_area, float max_area_relative, float scale_factor, int n_scales)
        {


            return TBMR.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_TBMR_create_10(min_area, max_area_relative, scale_factor, n_scales)));


        }

        public static TBMR create(int min_area, float max_area_relative, float scale_factor)
        {


            return TBMR.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_TBMR_create_11(min_area, max_area_relative, scale_factor)));


        }

        public static TBMR create(int min_area, float max_area_relative)
        {


            return TBMR.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_TBMR_create_12(min_area, max_area_relative)));


        }

        public static TBMR create(int min_area)
        {


            return TBMR.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_TBMR_create_13(min_area)));


        }

        public static TBMR create()
        {


            return TBMR.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_TBMR_create_14()));


        }


        //
        // C++:  void cv::xfeatures2d::TBMR::setMinArea(int minArea)
        //

        public void setMinArea(int minArea)
        {
            ThrowIfDisposed();

            xfeatures2d_TBMR_setMinArea_10(nativeObj, minArea);


        }


        //
        // C++:  int cv::xfeatures2d::TBMR::getMinArea()
        //

        public int getMinArea()
        {
            ThrowIfDisposed();

            return xfeatures2d_TBMR_getMinArea_10(nativeObj);


        }


        //
        // C++:  void cv::xfeatures2d::TBMR::setMaxAreaRelative(float maxArea)
        //

        public void setMaxAreaRelative(float maxArea)
        {
            ThrowIfDisposed();

            xfeatures2d_TBMR_setMaxAreaRelative_10(nativeObj, maxArea);


        }


        //
        // C++:  float cv::xfeatures2d::TBMR::getMaxAreaRelative()
        //

        public float getMaxAreaRelative()
        {
            ThrowIfDisposed();

            return xfeatures2d_TBMR_getMaxAreaRelative_10(nativeObj);


        }


        //
        // C++:  void cv::xfeatures2d::TBMR::setScaleFactor(float scale_factor)
        //

        public void setScaleFactor(float scale_factor)
        {
            ThrowIfDisposed();

            xfeatures2d_TBMR_setScaleFactor_10(nativeObj, scale_factor);


        }


        //
        // C++:  float cv::xfeatures2d::TBMR::getScaleFactor()
        //

        public float getScaleFactor()
        {
            ThrowIfDisposed();

            return xfeatures2d_TBMR_getScaleFactor_10(nativeObj);


        }


        //
        // C++:  void cv::xfeatures2d::TBMR::setNScales(int n_scales)
        //

        public void setNScales(int n_scales)
        {
            ThrowIfDisposed();

            xfeatures2d_TBMR_setNScales_10(nativeObj, n_scales);


        }


        //
        // C++:  int cv::xfeatures2d::TBMR::getNScales()
        //

        public int getNScales()
        {
            ThrowIfDisposed();

            return xfeatures2d_TBMR_getNScales_10(nativeObj);


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++: static Ptr_TBMR cv::xfeatures2d::TBMR::create(int min_area = 60, float max_area_relative = 0.01f, float scale_factor = 1.25f, int n_scales = -1)
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_TBMR_create_10(int min_area, float max_area_relative, float scale_factor, int n_scales);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_TBMR_create_11(int min_area, float max_area_relative, float scale_factor);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_TBMR_create_12(int min_area, float max_area_relative);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_TBMR_create_13(int min_area);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_TBMR_create_14();

        // C++:  void cv::xfeatures2d::TBMR::setMinArea(int minArea)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_TBMR_setMinArea_10(IntPtr nativeObj, int minArea);

        // C++:  int cv::xfeatures2d::TBMR::getMinArea()
        [DllImport(LIBNAME)]
        private static extern int xfeatures2d_TBMR_getMinArea_10(IntPtr nativeObj);

        // C++:  void cv::xfeatures2d::TBMR::setMaxAreaRelative(float maxArea)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_TBMR_setMaxAreaRelative_10(IntPtr nativeObj, float maxArea);

        // C++:  float cv::xfeatures2d::TBMR::getMaxAreaRelative()
        [DllImport(LIBNAME)]
        private static extern float xfeatures2d_TBMR_getMaxAreaRelative_10(IntPtr nativeObj);

        // C++:  void cv::xfeatures2d::TBMR::setScaleFactor(float scale_factor)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_TBMR_setScaleFactor_10(IntPtr nativeObj, float scale_factor);

        // C++:  float cv::xfeatures2d::TBMR::getScaleFactor()
        [DllImport(LIBNAME)]
        private static extern float xfeatures2d_TBMR_getScaleFactor_10(IntPtr nativeObj);

        // C++:  void cv::xfeatures2d::TBMR::setNScales(int n_scales)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_TBMR_setNScales_10(IntPtr nativeObj, int n_scales);

        // C++:  int cv::xfeatures2d::TBMR::getNScales()
        [DllImport(LIBNAME)]
        private static extern int xfeatures2d_TBMR_getNScales_10(IntPtr nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_TBMR_delete(IntPtr nativeObj);

    }
}
