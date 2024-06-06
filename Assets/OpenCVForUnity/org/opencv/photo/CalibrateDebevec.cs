
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.PhotoModule
{

    // C++: class CalibrateDebevec
    /**
     * Inverse camera response function is extracted for each brightness value by minimizing an objective
     * function as linear system. Objective function is constructed using pixel values on the same position
     * in all images, extra term is added to make the result smoother.
     *
     * For more information see CITE: DM97 .
     */

    public class CalibrateDebevec : CalibrateCRF
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
                        photo_CalibrateDebevec_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal CalibrateDebevec(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new CalibrateDebevec __fromPtr__(IntPtr addr) { return new CalibrateDebevec(addr); }

        //
        // C++:  float cv::CalibrateDebevec::getLambda()
        //

        public float getLambda()
        {
            ThrowIfDisposed();

            return photo_CalibrateDebevec_getLambda_10(nativeObj);


        }


        //
        // C++:  void cv::CalibrateDebevec::setLambda(float lambda)
        //

        public void setLambda(float lambda)
        {
            ThrowIfDisposed();

            photo_CalibrateDebevec_setLambda_10(nativeObj, lambda);


        }


        //
        // C++:  int cv::CalibrateDebevec::getSamples()
        //

        public int getSamples()
        {
            ThrowIfDisposed();

            return photo_CalibrateDebevec_getSamples_10(nativeObj);


        }


        //
        // C++:  void cv::CalibrateDebevec::setSamples(int samples)
        //

        public void setSamples(int samples)
        {
            ThrowIfDisposed();

            photo_CalibrateDebevec_setSamples_10(nativeObj, samples);


        }


        //
        // C++:  bool cv::CalibrateDebevec::getRandom()
        //

        public bool getRandom()
        {
            ThrowIfDisposed();

            return photo_CalibrateDebevec_getRandom_10(nativeObj);


        }


        //
        // C++:  void cv::CalibrateDebevec::setRandom(bool random)
        //

        public void setRandom(bool random)
        {
            ThrowIfDisposed();

            photo_CalibrateDebevec_setRandom_10(nativeObj, random);


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  float cv::CalibrateDebevec::getLambda()
        [DllImport(LIBNAME)]
        private static extern float photo_CalibrateDebevec_getLambda_10(IntPtr nativeObj);

        // C++:  void cv::CalibrateDebevec::setLambda(float lambda)
        [DllImport(LIBNAME)]
        private static extern void photo_CalibrateDebevec_setLambda_10(IntPtr nativeObj, float lambda);

        // C++:  int cv::CalibrateDebevec::getSamples()
        [DllImport(LIBNAME)]
        private static extern int photo_CalibrateDebevec_getSamples_10(IntPtr nativeObj);

        // C++:  void cv::CalibrateDebevec::setSamples(int samples)
        [DllImport(LIBNAME)]
        private static extern void photo_CalibrateDebevec_setSamples_10(IntPtr nativeObj, int samples);

        // C++:  bool cv::CalibrateDebevec::getRandom()
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool photo_CalibrateDebevec_getRandom_10(IntPtr nativeObj);

        // C++:  void cv::CalibrateDebevec::setRandom(bool random)
        [DllImport(LIBNAME)]
        private static extern void photo_CalibrateDebevec_setRandom_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool random);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void photo_CalibrateDebevec_delete(IntPtr nativeObj);

    }
}
