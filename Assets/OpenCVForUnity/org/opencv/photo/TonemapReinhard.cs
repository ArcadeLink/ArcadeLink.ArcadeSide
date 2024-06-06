
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.PhotoModule
{

    // C++: class TonemapReinhard
    /**
     * This is a global tonemapping operator that models human visual system.
     *
     * Mapping function is controlled by adaptation parameter, that is computed using light adaptation and
     * color adaptation.
     *
     * For more information see CITE: RD05 .
     */

    public class TonemapReinhard : Tonemap
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
                        photo_TonemapReinhard_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal TonemapReinhard(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new TonemapReinhard __fromPtr__(IntPtr addr) { return new TonemapReinhard(addr); }

        //
        // C++:  float cv::TonemapReinhard::getIntensity()
        //

        public float getIntensity()
        {
            ThrowIfDisposed();

            return photo_TonemapReinhard_getIntensity_10(nativeObj);


        }


        //
        // C++:  void cv::TonemapReinhard::setIntensity(float intensity)
        //

        public void setIntensity(float intensity)
        {
            ThrowIfDisposed();

            photo_TonemapReinhard_setIntensity_10(nativeObj, intensity);


        }


        //
        // C++:  float cv::TonemapReinhard::getLightAdaptation()
        //

        public float getLightAdaptation()
        {
            ThrowIfDisposed();

            return photo_TonemapReinhard_getLightAdaptation_10(nativeObj);


        }


        //
        // C++:  void cv::TonemapReinhard::setLightAdaptation(float light_adapt)
        //

        public void setLightAdaptation(float light_adapt)
        {
            ThrowIfDisposed();

            photo_TonemapReinhard_setLightAdaptation_10(nativeObj, light_adapt);


        }


        //
        // C++:  float cv::TonemapReinhard::getColorAdaptation()
        //

        public float getColorAdaptation()
        {
            ThrowIfDisposed();

            return photo_TonemapReinhard_getColorAdaptation_10(nativeObj);


        }


        //
        // C++:  void cv::TonemapReinhard::setColorAdaptation(float color_adapt)
        //

        public void setColorAdaptation(float color_adapt)
        {
            ThrowIfDisposed();

            photo_TonemapReinhard_setColorAdaptation_10(nativeObj, color_adapt);


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  float cv::TonemapReinhard::getIntensity()
        [DllImport(LIBNAME)]
        private static extern float photo_TonemapReinhard_getIntensity_10(IntPtr nativeObj);

        // C++:  void cv::TonemapReinhard::setIntensity(float intensity)
        [DllImport(LIBNAME)]
        private static extern void photo_TonemapReinhard_setIntensity_10(IntPtr nativeObj, float intensity);

        // C++:  float cv::TonemapReinhard::getLightAdaptation()
        [DllImport(LIBNAME)]
        private static extern float photo_TonemapReinhard_getLightAdaptation_10(IntPtr nativeObj);

        // C++:  void cv::TonemapReinhard::setLightAdaptation(float light_adapt)
        [DllImport(LIBNAME)]
        private static extern void photo_TonemapReinhard_setLightAdaptation_10(IntPtr nativeObj, float light_adapt);

        // C++:  float cv::TonemapReinhard::getColorAdaptation()
        [DllImport(LIBNAME)]
        private static extern float photo_TonemapReinhard_getColorAdaptation_10(IntPtr nativeObj);

        // C++:  void cv::TonemapReinhard::setColorAdaptation(float color_adapt)
        [DllImport(LIBNAME)]
        private static extern void photo_TonemapReinhard_setColorAdaptation_10(IntPtr nativeObj, float color_adapt);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void photo_TonemapReinhard_delete(IntPtr nativeObj);

    }
}
