
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.PhotoModule
{

    // C++: class TonemapMantiuk
    /**
     * This algorithm transforms image to contrast using gradients on all levels of gaussian pyramid,
     * transforms contrast values to HVS response and scales the response. After this the image is
     * reconstructed from new contrast values.
     *
     * For more information see CITE: MM06 .
     */

    public class TonemapMantiuk : Tonemap
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
                        photo_TonemapMantiuk_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal TonemapMantiuk(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new TonemapMantiuk __fromPtr__(IntPtr addr) { return new TonemapMantiuk(addr); }

        //
        // C++:  float cv::TonemapMantiuk::getScale()
        //

        public float getScale()
        {
            ThrowIfDisposed();

            return photo_TonemapMantiuk_getScale_10(nativeObj);


        }


        //
        // C++:  void cv::TonemapMantiuk::setScale(float scale)
        //

        public void setScale(float scale)
        {
            ThrowIfDisposed();

            photo_TonemapMantiuk_setScale_10(nativeObj, scale);


        }


        //
        // C++:  float cv::TonemapMantiuk::getSaturation()
        //

        public float getSaturation()
        {
            ThrowIfDisposed();

            return photo_TonemapMantiuk_getSaturation_10(nativeObj);


        }


        //
        // C++:  void cv::TonemapMantiuk::setSaturation(float saturation)
        //

        public void setSaturation(float saturation)
        {
            ThrowIfDisposed();

            photo_TonemapMantiuk_setSaturation_10(nativeObj, saturation);


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  float cv::TonemapMantiuk::getScale()
        [DllImport(LIBNAME)]
        private static extern float photo_TonemapMantiuk_getScale_10(IntPtr nativeObj);

        // C++:  void cv::TonemapMantiuk::setScale(float scale)
        [DllImport(LIBNAME)]
        private static extern void photo_TonemapMantiuk_setScale_10(IntPtr nativeObj, float scale);

        // C++:  float cv::TonemapMantiuk::getSaturation()
        [DllImport(LIBNAME)]
        private static extern float photo_TonemapMantiuk_getSaturation_10(IntPtr nativeObj);

        // C++:  void cv::TonemapMantiuk::setSaturation(float saturation)
        [DllImport(LIBNAME)]
        private static extern void photo_TonemapMantiuk_setSaturation_10(IntPtr nativeObj, float saturation);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void photo_TonemapMantiuk_delete(IntPtr nativeObj);

    }
}
