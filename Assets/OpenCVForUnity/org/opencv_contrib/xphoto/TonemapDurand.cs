
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.PhotoModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.XphotoModule
{

    // C++: class TonemapDurand
    /**
     * This algorithm decomposes image into two layers: base layer and detail layer using bilateral filter
     * and compresses contrast of the base layer thus preserving all the details.
     *
     * This implementation uses regular bilateral filter from OpenCV.
     *
     * Saturation enhancement is possible as in cv::TonemapDrago.
     *
     * For more information see CITE: DD02 .
     */

    public class TonemapDurand : Tonemap
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
                        xphoto_TonemapDurand_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal TonemapDurand(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new TonemapDurand __fromPtr__(IntPtr addr) { return new TonemapDurand(addr); }

        //
        // C++:  float cv::xphoto::TonemapDurand::getSaturation()
        //

        public float getSaturation()
        {
            ThrowIfDisposed();

            return xphoto_TonemapDurand_getSaturation_10(nativeObj);


        }


        //
        // C++:  void cv::xphoto::TonemapDurand::setSaturation(float saturation)
        //

        public void setSaturation(float saturation)
        {
            ThrowIfDisposed();

            xphoto_TonemapDurand_setSaturation_10(nativeObj, saturation);


        }


        //
        // C++:  float cv::xphoto::TonemapDurand::getContrast()
        //

        public float getContrast()
        {
            ThrowIfDisposed();

            return xphoto_TonemapDurand_getContrast_10(nativeObj);


        }


        //
        // C++:  void cv::xphoto::TonemapDurand::setContrast(float contrast)
        //

        public void setContrast(float contrast)
        {
            ThrowIfDisposed();

            xphoto_TonemapDurand_setContrast_10(nativeObj, contrast);


        }


        //
        // C++:  float cv::xphoto::TonemapDurand::getSigmaSpace()
        //

        public float getSigmaSpace()
        {
            ThrowIfDisposed();

            return xphoto_TonemapDurand_getSigmaSpace_10(nativeObj);


        }


        //
        // C++:  void cv::xphoto::TonemapDurand::setSigmaSpace(float sigma_space)
        //

        public void setSigmaSpace(float sigma_space)
        {
            ThrowIfDisposed();

            xphoto_TonemapDurand_setSigmaSpace_10(nativeObj, sigma_space);


        }


        //
        // C++:  float cv::xphoto::TonemapDurand::getSigmaColor()
        //

        public float getSigmaColor()
        {
            ThrowIfDisposed();

            return xphoto_TonemapDurand_getSigmaColor_10(nativeObj);


        }


        //
        // C++:  void cv::xphoto::TonemapDurand::setSigmaColor(float sigma_color)
        //

        public void setSigmaColor(float sigma_color)
        {
            ThrowIfDisposed();

            xphoto_TonemapDurand_setSigmaColor_10(nativeObj, sigma_color);


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  float cv::xphoto::TonemapDurand::getSaturation()
        [DllImport(LIBNAME)]
        private static extern float xphoto_TonemapDurand_getSaturation_10(IntPtr nativeObj);

        // C++:  void cv::xphoto::TonemapDurand::setSaturation(float saturation)
        [DllImport(LIBNAME)]
        private static extern void xphoto_TonemapDurand_setSaturation_10(IntPtr nativeObj, float saturation);

        // C++:  float cv::xphoto::TonemapDurand::getContrast()
        [DllImport(LIBNAME)]
        private static extern float xphoto_TonemapDurand_getContrast_10(IntPtr nativeObj);

        // C++:  void cv::xphoto::TonemapDurand::setContrast(float contrast)
        [DllImport(LIBNAME)]
        private static extern void xphoto_TonemapDurand_setContrast_10(IntPtr nativeObj, float contrast);

        // C++:  float cv::xphoto::TonemapDurand::getSigmaSpace()
        [DllImport(LIBNAME)]
        private static extern float xphoto_TonemapDurand_getSigmaSpace_10(IntPtr nativeObj);

        // C++:  void cv::xphoto::TonemapDurand::setSigmaSpace(float sigma_space)
        [DllImport(LIBNAME)]
        private static extern void xphoto_TonemapDurand_setSigmaSpace_10(IntPtr nativeObj, float sigma_space);

        // C++:  float cv::xphoto::TonemapDurand::getSigmaColor()
        [DllImport(LIBNAME)]
        private static extern float xphoto_TonemapDurand_getSigmaColor_10(IntPtr nativeObj);

        // C++:  void cv::xphoto::TonemapDurand::setSigmaColor(float sigma_color)
        [DllImport(LIBNAME)]
        private static extern void xphoto_TonemapDurand_setSigmaColor_10(IntPtr nativeObj, float sigma_color);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void xphoto_TonemapDurand_delete(IntPtr nativeObj);

    }
}
