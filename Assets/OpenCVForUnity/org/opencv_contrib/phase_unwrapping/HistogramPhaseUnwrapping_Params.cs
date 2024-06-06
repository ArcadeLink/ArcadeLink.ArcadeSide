#if !UNITY_WEBGL

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.Phase_unwrappingModule
{
    // C++: class Params
    /**
     * Parameters of phaseUnwrapping constructor.
     *
     * width Phase map width.
     * height Phase map height.
     * histThresh Bins in the histogram are not of equal size. Default value is 3*pi*pi. The one before "histThresh" value are smaller.
     * nbrOfSmallBins Number of bins between 0 and "histThresh". Default value is 10.
     * nbrOfLargeBins Number of bins between "histThresh" and 32*pi*pi (highest edge reliability value). Default value is 5.
     */

    public class HistogramPhaseUnwrapping_Params : DisposableOpenCVObject
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
                        phase_1unwrapping_HistogramPhaseUnwrapping_1Params_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal HistogramPhaseUnwrapping_Params(IntPtr addr) : base(addr) { }


        public IntPtr getNativeObjAddr() { return nativeObj; }

        // internal usage only
        public static HistogramPhaseUnwrapping_Params __fromPtr__(IntPtr addr) { return new HistogramPhaseUnwrapping_Params(addr); }

        //
        // C++:   cv::phase_unwrapping::HistogramPhaseUnwrapping::Params::Params()
        //

        public HistogramPhaseUnwrapping_Params()
        {


            nativeObj = DisposableObject.ThrowIfNullIntPtr(phase_1unwrapping_HistogramPhaseUnwrapping_1Params_HistogramPhaseUnwrapping_1Params_10());


        }


        //
        // C++: int HistogramPhaseUnwrapping_Params::width
        //

        public int get_width()
        {
            ThrowIfDisposed();

            return phase_1unwrapping_HistogramPhaseUnwrapping_1Params_get_1width_10(nativeObj);


        }


        //
        // C++: void HistogramPhaseUnwrapping_Params::width
        //

        public void set_width(int width)
        {
            ThrowIfDisposed();

            phase_1unwrapping_HistogramPhaseUnwrapping_1Params_set_1width_10(nativeObj, width);


        }


        //
        // C++: int HistogramPhaseUnwrapping_Params::height
        //

        public int get_height()
        {
            ThrowIfDisposed();

            return phase_1unwrapping_HistogramPhaseUnwrapping_1Params_get_1height_10(nativeObj);


        }


        //
        // C++: void HistogramPhaseUnwrapping_Params::height
        //

        public void set_height(int height)
        {
            ThrowIfDisposed();

            phase_1unwrapping_HistogramPhaseUnwrapping_1Params_set_1height_10(nativeObj, height);


        }


        //
        // C++: float HistogramPhaseUnwrapping_Params::histThresh
        //

        public float get_histThresh()
        {
            ThrowIfDisposed();

            return phase_1unwrapping_HistogramPhaseUnwrapping_1Params_get_1histThresh_10(nativeObj);


        }


        //
        // C++: void HistogramPhaseUnwrapping_Params::histThresh
        //

        public void set_histThresh(float histThresh)
        {
            ThrowIfDisposed();

            phase_1unwrapping_HistogramPhaseUnwrapping_1Params_set_1histThresh_10(nativeObj, histThresh);


        }


        //
        // C++: int HistogramPhaseUnwrapping_Params::nbrOfSmallBins
        //

        public int get_nbrOfSmallBins()
        {
            ThrowIfDisposed();

            return phase_1unwrapping_HistogramPhaseUnwrapping_1Params_get_1nbrOfSmallBins_10(nativeObj);


        }


        //
        // C++: void HistogramPhaseUnwrapping_Params::nbrOfSmallBins
        //

        public void set_nbrOfSmallBins(int nbrOfSmallBins)
        {
            ThrowIfDisposed();

            phase_1unwrapping_HistogramPhaseUnwrapping_1Params_set_1nbrOfSmallBins_10(nativeObj, nbrOfSmallBins);


        }


        //
        // C++: int HistogramPhaseUnwrapping_Params::nbrOfLargeBins
        //

        public int get_nbrOfLargeBins()
        {
            ThrowIfDisposed();

            return phase_1unwrapping_HistogramPhaseUnwrapping_1Params_get_1nbrOfLargeBins_10(nativeObj);


        }


        //
        // C++: void HistogramPhaseUnwrapping_Params::nbrOfLargeBins
        //

        public void set_nbrOfLargeBins(int nbrOfLargeBins)
        {
            ThrowIfDisposed();

            phase_1unwrapping_HistogramPhaseUnwrapping_1Params_set_1nbrOfLargeBins_10(nativeObj, nbrOfLargeBins);


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:   cv::phase_unwrapping::HistogramPhaseUnwrapping::Params::Params()
        [DllImport(LIBNAME)]
        private static extern IntPtr phase_1unwrapping_HistogramPhaseUnwrapping_1Params_HistogramPhaseUnwrapping_1Params_10();

        // C++: int HistogramPhaseUnwrapping_Params::width
        [DllImport(LIBNAME)]
        private static extern int phase_1unwrapping_HistogramPhaseUnwrapping_1Params_get_1width_10(IntPtr nativeObj);

        // C++: void HistogramPhaseUnwrapping_Params::width
        [DllImport(LIBNAME)]
        private static extern void phase_1unwrapping_HistogramPhaseUnwrapping_1Params_set_1width_10(IntPtr nativeObj, int width);

        // C++: int HistogramPhaseUnwrapping_Params::height
        [DllImport(LIBNAME)]
        private static extern int phase_1unwrapping_HistogramPhaseUnwrapping_1Params_get_1height_10(IntPtr nativeObj);

        // C++: void HistogramPhaseUnwrapping_Params::height
        [DllImport(LIBNAME)]
        private static extern void phase_1unwrapping_HistogramPhaseUnwrapping_1Params_set_1height_10(IntPtr nativeObj, int height);

        // C++: float HistogramPhaseUnwrapping_Params::histThresh
        [DllImport(LIBNAME)]
        private static extern float phase_1unwrapping_HistogramPhaseUnwrapping_1Params_get_1histThresh_10(IntPtr nativeObj);

        // C++: void HistogramPhaseUnwrapping_Params::histThresh
        [DllImport(LIBNAME)]
        private static extern void phase_1unwrapping_HistogramPhaseUnwrapping_1Params_set_1histThresh_10(IntPtr nativeObj, float histThresh);

        // C++: int HistogramPhaseUnwrapping_Params::nbrOfSmallBins
        [DllImport(LIBNAME)]
        private static extern int phase_1unwrapping_HistogramPhaseUnwrapping_1Params_get_1nbrOfSmallBins_10(IntPtr nativeObj);

        // C++: void HistogramPhaseUnwrapping_Params::nbrOfSmallBins
        [DllImport(LIBNAME)]
        private static extern void phase_1unwrapping_HistogramPhaseUnwrapping_1Params_set_1nbrOfSmallBins_10(IntPtr nativeObj, int nbrOfSmallBins);

        // C++: int HistogramPhaseUnwrapping_Params::nbrOfLargeBins
        [DllImport(LIBNAME)]
        private static extern int phase_1unwrapping_HistogramPhaseUnwrapping_1Params_get_1nbrOfLargeBins_10(IntPtr nativeObj);

        // C++: void HistogramPhaseUnwrapping_Params::nbrOfLargeBins
        [DllImport(LIBNAME)]
        private static extern void phase_1unwrapping_HistogramPhaseUnwrapping_1Params_set_1nbrOfLargeBins_10(IntPtr nativeObj, int nbrOfLargeBins);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void phase_1unwrapping_HistogramPhaseUnwrapping_1Params_delete(IntPtr nativeObj);

    }
}

#endif