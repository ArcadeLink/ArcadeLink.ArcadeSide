#if !UNITY_WEBGL

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.Structured_lightModule
{
    // C++: class Params
    /**
     * Parameters of SinusoidalPattern constructor
     * width Projector's width.
     * height Projector's height.
     * nbrOfPeriods Number of period along the patterns direction.
     * shiftValue Phase shift between two consecutive patterns.
     * methodId Allow to choose between FTP, PSP and FAPS.
     * nbrOfPixelsBetweenMarkers Number of pixels between two consecutive markers on the same row.
     * setMarkers Allow to set markers on the patterns.
     * markersLocation vector used to store markers location on the patterns.
     */

    public class SinusoidalPattern_Params : DisposableOpenCVObject
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
                        structured_1light_SinusoidalPattern_1Params_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal SinusoidalPattern_Params(IntPtr addr) : base(addr) { }


        public IntPtr getNativeObjAddr() { return nativeObj; }

        // internal usage only
        public static SinusoidalPattern_Params __fromPtr__(IntPtr addr) { return new SinusoidalPattern_Params(addr); }

        //
        // C++:   cv::structured_light::SinusoidalPattern::Params::Params()
        //

        public SinusoidalPattern_Params()
        {


            nativeObj = DisposableObject.ThrowIfNullIntPtr(structured_1light_SinusoidalPattern_1Params_SinusoidalPattern_1Params_10());


        }


        //
        // C++: int SinusoidalPattern_Params::width
        //

        public int get_width()
        {
            ThrowIfDisposed();

            return structured_1light_SinusoidalPattern_1Params_get_1width_10(nativeObj);


        }


        //
        // C++: void SinusoidalPattern_Params::width
        //

        public void set_width(int width)
        {
            ThrowIfDisposed();

            structured_1light_SinusoidalPattern_1Params_set_1width_10(nativeObj, width);


        }


        //
        // C++: int SinusoidalPattern_Params::height
        //

        public int get_height()
        {
            ThrowIfDisposed();

            return structured_1light_SinusoidalPattern_1Params_get_1height_10(nativeObj);


        }


        //
        // C++: void SinusoidalPattern_Params::height
        //

        public void set_height(int height)
        {
            ThrowIfDisposed();

            structured_1light_SinusoidalPattern_1Params_set_1height_10(nativeObj, height);


        }


        //
        // C++: int SinusoidalPattern_Params::nbrOfPeriods
        //

        public int get_nbrOfPeriods()
        {
            ThrowIfDisposed();

            return structured_1light_SinusoidalPattern_1Params_get_1nbrOfPeriods_10(nativeObj);


        }


        //
        // C++: void SinusoidalPattern_Params::nbrOfPeriods
        //

        public void set_nbrOfPeriods(int nbrOfPeriods)
        {
            ThrowIfDisposed();

            structured_1light_SinusoidalPattern_1Params_set_1nbrOfPeriods_10(nativeObj, nbrOfPeriods);


        }


        //
        // C++: float SinusoidalPattern_Params::shiftValue
        //

        public float get_shiftValue()
        {
            ThrowIfDisposed();

            return structured_1light_SinusoidalPattern_1Params_get_1shiftValue_10(nativeObj);


        }


        //
        // C++: void SinusoidalPattern_Params::shiftValue
        //

        public void set_shiftValue(float shiftValue)
        {
            ThrowIfDisposed();

            structured_1light_SinusoidalPattern_1Params_set_1shiftValue_10(nativeObj, shiftValue);


        }


        //
        // C++: int SinusoidalPattern_Params::methodId
        //

        public int get_methodId()
        {
            ThrowIfDisposed();

            return structured_1light_SinusoidalPattern_1Params_get_1methodId_10(nativeObj);


        }


        //
        // C++: void SinusoidalPattern_Params::methodId
        //

        public void set_methodId(int methodId)
        {
            ThrowIfDisposed();

            structured_1light_SinusoidalPattern_1Params_set_1methodId_10(nativeObj, methodId);


        }


        //
        // C++: int SinusoidalPattern_Params::nbrOfPixelsBetweenMarkers
        //

        public int get_nbrOfPixelsBetweenMarkers()
        {
            ThrowIfDisposed();

            return structured_1light_SinusoidalPattern_1Params_get_1nbrOfPixelsBetweenMarkers_10(nativeObj);


        }


        //
        // C++: void SinusoidalPattern_Params::nbrOfPixelsBetweenMarkers
        //

        public void set_nbrOfPixelsBetweenMarkers(int nbrOfPixelsBetweenMarkers)
        {
            ThrowIfDisposed();

            structured_1light_SinusoidalPattern_1Params_set_1nbrOfPixelsBetweenMarkers_10(nativeObj, nbrOfPixelsBetweenMarkers);


        }


        //
        // C++: bool SinusoidalPattern_Params::horizontal
        //

        public bool get_horizontal()
        {
            ThrowIfDisposed();

            return structured_1light_SinusoidalPattern_1Params_get_1horizontal_10(nativeObj);


        }


        //
        // C++: void SinusoidalPattern_Params::horizontal
        //

        public void set_horizontal(bool horizontal)
        {
            ThrowIfDisposed();

            structured_1light_SinusoidalPattern_1Params_set_1horizontal_10(nativeObj, horizontal);


        }


        //
        // C++: bool SinusoidalPattern_Params::setMarkers
        //

        public bool get_setMarkers()
        {
            ThrowIfDisposed();

            return structured_1light_SinusoidalPattern_1Params_get_1setMarkers_10(nativeObj);


        }


        //
        // C++: void SinusoidalPattern_Params::setMarkers
        //

        public void set_setMarkers(bool setMarkers)
        {
            ThrowIfDisposed();

            structured_1light_SinusoidalPattern_1Params_set_1setMarkers_10(nativeObj, setMarkers);


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:   cv::structured_light::SinusoidalPattern::Params::Params()
        [DllImport(LIBNAME)]
        private static extern IntPtr structured_1light_SinusoidalPattern_1Params_SinusoidalPattern_1Params_10();

        // C++: int SinusoidalPattern_Params::width
        [DllImport(LIBNAME)]
        private static extern int structured_1light_SinusoidalPattern_1Params_get_1width_10(IntPtr nativeObj);

        // C++: void SinusoidalPattern_Params::width
        [DllImport(LIBNAME)]
        private static extern void structured_1light_SinusoidalPattern_1Params_set_1width_10(IntPtr nativeObj, int width);

        // C++: int SinusoidalPattern_Params::height
        [DllImport(LIBNAME)]
        private static extern int structured_1light_SinusoidalPattern_1Params_get_1height_10(IntPtr nativeObj);

        // C++: void SinusoidalPattern_Params::height
        [DllImport(LIBNAME)]
        private static extern void structured_1light_SinusoidalPattern_1Params_set_1height_10(IntPtr nativeObj, int height);

        // C++: int SinusoidalPattern_Params::nbrOfPeriods
        [DllImport(LIBNAME)]
        private static extern int structured_1light_SinusoidalPattern_1Params_get_1nbrOfPeriods_10(IntPtr nativeObj);

        // C++: void SinusoidalPattern_Params::nbrOfPeriods
        [DllImport(LIBNAME)]
        private static extern void structured_1light_SinusoidalPattern_1Params_set_1nbrOfPeriods_10(IntPtr nativeObj, int nbrOfPeriods);

        // C++: float SinusoidalPattern_Params::shiftValue
        [DllImport(LIBNAME)]
        private static extern float structured_1light_SinusoidalPattern_1Params_get_1shiftValue_10(IntPtr nativeObj);

        // C++: void SinusoidalPattern_Params::shiftValue
        [DllImport(LIBNAME)]
        private static extern void structured_1light_SinusoidalPattern_1Params_set_1shiftValue_10(IntPtr nativeObj, float shiftValue);

        // C++: int SinusoidalPattern_Params::methodId
        [DllImport(LIBNAME)]
        private static extern int structured_1light_SinusoidalPattern_1Params_get_1methodId_10(IntPtr nativeObj);

        // C++: void SinusoidalPattern_Params::methodId
        [DllImport(LIBNAME)]
        private static extern void structured_1light_SinusoidalPattern_1Params_set_1methodId_10(IntPtr nativeObj, int methodId);

        // C++: int SinusoidalPattern_Params::nbrOfPixelsBetweenMarkers
        [DllImport(LIBNAME)]
        private static extern int structured_1light_SinusoidalPattern_1Params_get_1nbrOfPixelsBetweenMarkers_10(IntPtr nativeObj);

        // C++: void SinusoidalPattern_Params::nbrOfPixelsBetweenMarkers
        [DllImport(LIBNAME)]
        private static extern void structured_1light_SinusoidalPattern_1Params_set_1nbrOfPixelsBetweenMarkers_10(IntPtr nativeObj, int nbrOfPixelsBetweenMarkers);

        // C++: bool SinusoidalPattern_Params::horizontal
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool structured_1light_SinusoidalPattern_1Params_get_1horizontal_10(IntPtr nativeObj);

        // C++: void SinusoidalPattern_Params::horizontal
        [DllImport(LIBNAME)]
        private static extern void structured_1light_SinusoidalPattern_1Params_set_1horizontal_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool horizontal);

        // C++: bool SinusoidalPattern_Params::setMarkers
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool structured_1light_SinusoidalPattern_1Params_get_1setMarkers_10(IntPtr nativeObj);

        // C++: void SinusoidalPattern_Params::setMarkers
        [DllImport(LIBNAME)]
        private static extern void structured_1light_SinusoidalPattern_1Params_set_1setMarkers_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool setMarkers);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void structured_1light_SinusoidalPattern_1Params_delete(IntPtr nativeObj);

    }
}

#endif