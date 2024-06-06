

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.Calib3dModule
{
    // C++: class UsacParams


    public class UsacParams : DisposableOpenCVObject
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
                        calib3d_UsacParams_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal UsacParams(IntPtr addr) : base(addr) { }


        public IntPtr getNativeObjAddr() { return nativeObj; }

        // internal usage only
        public static UsacParams __fromPtr__(IntPtr addr) { return new UsacParams(addr); }

        //
        // C++:   cv::UsacParams::UsacParams()
        //

        public UsacParams()
        {


            nativeObj = DisposableObject.ThrowIfNullIntPtr(calib3d_UsacParams_UsacParams_10());


        }


        //
        // C++: double UsacParams::confidence
        //

        public double get_confidence()
        {
            ThrowIfDisposed();

            return calib3d_UsacParams_get_1confidence_10(nativeObj);


        }


        //
        // C++: void UsacParams::confidence
        //

        public void set_confidence(double confidence)
        {
            ThrowIfDisposed();

            calib3d_UsacParams_set_1confidence_10(nativeObj, confidence);


        }


        //
        // C++: bool UsacParams::isParallel
        //

        public bool get_isParallel()
        {
            ThrowIfDisposed();

            return calib3d_UsacParams_get_1isParallel_10(nativeObj);


        }


        //
        // C++: void UsacParams::isParallel
        //

        public void set_isParallel(bool isParallel)
        {
            ThrowIfDisposed();

            calib3d_UsacParams_set_1isParallel_10(nativeObj, isParallel);


        }


        //
        // C++: int UsacParams::loIterations
        //

        public int get_loIterations()
        {
            ThrowIfDisposed();

            return calib3d_UsacParams_get_1loIterations_10(nativeObj);


        }


        //
        // C++: void UsacParams::loIterations
        //

        public void set_loIterations(int loIterations)
        {
            ThrowIfDisposed();

            calib3d_UsacParams_set_1loIterations_10(nativeObj, loIterations);


        }


        //
        // C++: LocalOptimMethod UsacParams::loMethod
        //

        public int get_loMethod()
        {
            ThrowIfDisposed();

            return calib3d_UsacParams_get_1loMethod_10(nativeObj);


        }


        //
        // C++: void UsacParams::loMethod
        //

        public void set_loMethod(int loMethod)
        {
            ThrowIfDisposed();

            calib3d_UsacParams_set_1loMethod_10(nativeObj, loMethod);


        }


        //
        // C++: int UsacParams::loSampleSize
        //

        public int get_loSampleSize()
        {
            ThrowIfDisposed();

            return calib3d_UsacParams_get_1loSampleSize_10(nativeObj);


        }


        //
        // C++: void UsacParams::loSampleSize
        //

        public void set_loSampleSize(int loSampleSize)
        {
            ThrowIfDisposed();

            calib3d_UsacParams_set_1loSampleSize_10(nativeObj, loSampleSize);


        }


        //
        // C++: int UsacParams::maxIterations
        //

        public int get_maxIterations()
        {
            ThrowIfDisposed();

            return calib3d_UsacParams_get_1maxIterations_10(nativeObj);


        }


        //
        // C++: void UsacParams::maxIterations
        //

        public void set_maxIterations(int maxIterations)
        {
            ThrowIfDisposed();

            calib3d_UsacParams_set_1maxIterations_10(nativeObj, maxIterations);


        }


        //
        // C++: NeighborSearchMethod UsacParams::neighborsSearch
        //

        public int get_neighborsSearch()
        {
            ThrowIfDisposed();

            return calib3d_UsacParams_get_1neighborsSearch_10(nativeObj);


        }


        //
        // C++: void UsacParams::neighborsSearch
        //

        public void set_neighborsSearch(int neighborsSearch)
        {
            ThrowIfDisposed();

            calib3d_UsacParams_set_1neighborsSearch_10(nativeObj, neighborsSearch);


        }


        //
        // C++: int UsacParams::randomGeneratorState
        //

        public int get_randomGeneratorState()
        {
            ThrowIfDisposed();

            return calib3d_UsacParams_get_1randomGeneratorState_10(nativeObj);


        }


        //
        // C++: void UsacParams::randomGeneratorState
        //

        public void set_randomGeneratorState(int randomGeneratorState)
        {
            ThrowIfDisposed();

            calib3d_UsacParams_set_1randomGeneratorState_10(nativeObj, randomGeneratorState);


        }


        //
        // C++: SamplingMethod UsacParams::sampler
        //

        public int get_sampler()
        {
            ThrowIfDisposed();

            return calib3d_UsacParams_get_1sampler_10(nativeObj);


        }


        //
        // C++: void UsacParams::sampler
        //

        public void set_sampler(int sampler)
        {
            ThrowIfDisposed();

            calib3d_UsacParams_set_1sampler_10(nativeObj, sampler);


        }


        //
        // C++: ScoreMethod UsacParams::score
        //

        public int get_score()
        {
            ThrowIfDisposed();

            return calib3d_UsacParams_get_1score_10(nativeObj);


        }


        //
        // C++: void UsacParams::score
        //

        public void set_score(int score)
        {
            ThrowIfDisposed();

            calib3d_UsacParams_set_1score_10(nativeObj, score);


        }


        //
        // C++: double UsacParams::threshold
        //

        public double get_threshold()
        {
            ThrowIfDisposed();

            return calib3d_UsacParams_get_1threshold_10(nativeObj);


        }


        //
        // C++: void UsacParams::threshold
        //

        public void set_threshold(double threshold)
        {
            ThrowIfDisposed();

            calib3d_UsacParams_set_1threshold_10(nativeObj, threshold);


        }


        //
        // C++: PolishingMethod UsacParams::final_polisher
        //

        public int get_final_polisher()
        {
            ThrowIfDisposed();

            return calib3d_UsacParams_get_1final_1polisher_10(nativeObj);


        }


        //
        // C++: void UsacParams::final_polisher
        //

        public void set_final_polisher(int final_polisher)
        {
            ThrowIfDisposed();

            calib3d_UsacParams_set_1final_1polisher_10(nativeObj, final_polisher);


        }


        //
        // C++: int UsacParams::final_polisher_iterations
        //

        public int get_final_polisher_iterations()
        {
            ThrowIfDisposed();

            return calib3d_UsacParams_get_1final_1polisher_1iterations_10(nativeObj);


        }


        //
        // C++: void UsacParams::final_polisher_iterations
        //

        public void set_final_polisher_iterations(int final_polisher_iterations)
        {
            ThrowIfDisposed();

            calib3d_UsacParams_set_1final_1polisher_1iterations_10(nativeObj, final_polisher_iterations);


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:   cv::UsacParams::UsacParams()
        [DllImport(LIBNAME)]
        private static extern IntPtr calib3d_UsacParams_UsacParams_10();

        // C++: double UsacParams::confidence
        [DllImport(LIBNAME)]
        private static extern double calib3d_UsacParams_get_1confidence_10(IntPtr nativeObj);

        // C++: void UsacParams::confidence
        [DllImport(LIBNAME)]
        private static extern void calib3d_UsacParams_set_1confidence_10(IntPtr nativeObj, double confidence);

        // C++: bool UsacParams::isParallel
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool calib3d_UsacParams_get_1isParallel_10(IntPtr nativeObj);

        // C++: void UsacParams::isParallel
        [DllImport(LIBNAME)]
        private static extern void calib3d_UsacParams_set_1isParallel_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool isParallel);

        // C++: int UsacParams::loIterations
        [DllImport(LIBNAME)]
        private static extern int calib3d_UsacParams_get_1loIterations_10(IntPtr nativeObj);

        // C++: void UsacParams::loIterations
        [DllImport(LIBNAME)]
        private static extern void calib3d_UsacParams_set_1loIterations_10(IntPtr nativeObj, int loIterations);

        // C++: LocalOptimMethod UsacParams::loMethod
        [DllImport(LIBNAME)]
        private static extern int calib3d_UsacParams_get_1loMethod_10(IntPtr nativeObj);

        // C++: void UsacParams::loMethod
        [DllImport(LIBNAME)]
        private static extern void calib3d_UsacParams_set_1loMethod_10(IntPtr nativeObj, int loMethod);

        // C++: int UsacParams::loSampleSize
        [DllImport(LIBNAME)]
        private static extern int calib3d_UsacParams_get_1loSampleSize_10(IntPtr nativeObj);

        // C++: void UsacParams::loSampleSize
        [DllImport(LIBNAME)]
        private static extern void calib3d_UsacParams_set_1loSampleSize_10(IntPtr nativeObj, int loSampleSize);

        // C++: int UsacParams::maxIterations
        [DllImport(LIBNAME)]
        private static extern int calib3d_UsacParams_get_1maxIterations_10(IntPtr nativeObj);

        // C++: void UsacParams::maxIterations
        [DllImport(LIBNAME)]
        private static extern void calib3d_UsacParams_set_1maxIterations_10(IntPtr nativeObj, int maxIterations);

        // C++: NeighborSearchMethod UsacParams::neighborsSearch
        [DllImport(LIBNAME)]
        private static extern int calib3d_UsacParams_get_1neighborsSearch_10(IntPtr nativeObj);

        // C++: void UsacParams::neighborsSearch
        [DllImport(LIBNAME)]
        private static extern void calib3d_UsacParams_set_1neighborsSearch_10(IntPtr nativeObj, int neighborsSearch);

        // C++: int UsacParams::randomGeneratorState
        [DllImport(LIBNAME)]
        private static extern int calib3d_UsacParams_get_1randomGeneratorState_10(IntPtr nativeObj);

        // C++: void UsacParams::randomGeneratorState
        [DllImport(LIBNAME)]
        private static extern void calib3d_UsacParams_set_1randomGeneratorState_10(IntPtr nativeObj, int randomGeneratorState);

        // C++: SamplingMethod UsacParams::sampler
        [DllImport(LIBNAME)]
        private static extern int calib3d_UsacParams_get_1sampler_10(IntPtr nativeObj);

        // C++: void UsacParams::sampler
        [DllImport(LIBNAME)]
        private static extern void calib3d_UsacParams_set_1sampler_10(IntPtr nativeObj, int sampler);

        // C++: ScoreMethod UsacParams::score
        [DllImport(LIBNAME)]
        private static extern int calib3d_UsacParams_get_1score_10(IntPtr nativeObj);

        // C++: void UsacParams::score
        [DllImport(LIBNAME)]
        private static extern void calib3d_UsacParams_set_1score_10(IntPtr nativeObj, int score);

        // C++: double UsacParams::threshold
        [DllImport(LIBNAME)]
        private static extern double calib3d_UsacParams_get_1threshold_10(IntPtr nativeObj);

        // C++: void UsacParams::threshold
        [DllImport(LIBNAME)]
        private static extern void calib3d_UsacParams_set_1threshold_10(IntPtr nativeObj, double threshold);

        // C++: PolishingMethod UsacParams::final_polisher
        [DllImport(LIBNAME)]
        private static extern int calib3d_UsacParams_get_1final_1polisher_10(IntPtr nativeObj);

        // C++: void UsacParams::final_polisher
        [DllImport(LIBNAME)]
        private static extern void calib3d_UsacParams_set_1final_1polisher_10(IntPtr nativeObj, int final_polisher);

        // C++: int UsacParams::final_polisher_iterations
        [DllImport(LIBNAME)]
        private static extern int calib3d_UsacParams_get_1final_1polisher_1iterations_10(IntPtr nativeObj);

        // C++: void UsacParams::final_polisher_iterations
        [DllImport(LIBNAME)]
        private static extern void calib3d_UsacParams_set_1final_1polisher_1iterations_10(IntPtr nativeObj, int final_polisher_iterations);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void calib3d_UsacParams_delete(IntPtr nativeObj);

    }
}
