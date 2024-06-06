

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.XimgprocModule
{
    // C++: class Params


    public class EdgeDrawing_Params : DisposableOpenCVObject
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
                        ximgproc_EdgeDrawing_1Params_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal EdgeDrawing_Params(IntPtr addr) : base(addr) { }


        public IntPtr getNativeObjAddr() { return nativeObj; }

        // internal usage only
        public static EdgeDrawing_Params __fromPtr__(IntPtr addr) { return new EdgeDrawing_Params(addr); }

        //
        // C++:   cv::ximgproc::EdgeDrawing::Params::Params()
        //

        public EdgeDrawing_Params()
        {


            nativeObj = DisposableObject.ThrowIfNullIntPtr(ximgproc_EdgeDrawing_1Params_EdgeDrawing_1Params_10());


        }


        //
        // C++: bool EdgeDrawing_Params::PFmode
        //

        public bool get_PFmode()
        {
            ThrowIfDisposed();

            return ximgproc_EdgeDrawing_1Params_get_1PFmode_10(nativeObj);


        }


        //
        // C++: void EdgeDrawing_Params::PFmode
        //

        public void set_PFmode(bool PFmode)
        {
            ThrowIfDisposed();

            ximgproc_EdgeDrawing_1Params_set_1PFmode_10(nativeObj, PFmode);


        }


        //
        // C++: int EdgeDrawing_Params::EdgeDetectionOperator
        //

        public int get_EdgeDetectionOperator()
        {
            ThrowIfDisposed();

            return ximgproc_EdgeDrawing_1Params_get_1EdgeDetectionOperator_10(nativeObj);


        }


        //
        // C++: void EdgeDrawing_Params::EdgeDetectionOperator
        //

        public void set_EdgeDetectionOperator(int EdgeDetectionOperator)
        {
            ThrowIfDisposed();

            ximgproc_EdgeDrawing_1Params_set_1EdgeDetectionOperator_10(nativeObj, EdgeDetectionOperator);


        }


        //
        // C++: int EdgeDrawing_Params::GradientThresholdValue
        //

        public int get_GradientThresholdValue()
        {
            ThrowIfDisposed();

            return ximgproc_EdgeDrawing_1Params_get_1GradientThresholdValue_10(nativeObj);


        }


        //
        // C++: void EdgeDrawing_Params::GradientThresholdValue
        //

        public void set_GradientThresholdValue(int GradientThresholdValue)
        {
            ThrowIfDisposed();

            ximgproc_EdgeDrawing_1Params_set_1GradientThresholdValue_10(nativeObj, GradientThresholdValue);


        }


        //
        // C++: int EdgeDrawing_Params::AnchorThresholdValue
        //

        public int get_AnchorThresholdValue()
        {
            ThrowIfDisposed();

            return ximgproc_EdgeDrawing_1Params_get_1AnchorThresholdValue_10(nativeObj);


        }


        //
        // C++: void EdgeDrawing_Params::AnchorThresholdValue
        //

        public void set_AnchorThresholdValue(int AnchorThresholdValue)
        {
            ThrowIfDisposed();

            ximgproc_EdgeDrawing_1Params_set_1AnchorThresholdValue_10(nativeObj, AnchorThresholdValue);


        }


        //
        // C++: int EdgeDrawing_Params::ScanInterval
        //

        public int get_ScanInterval()
        {
            ThrowIfDisposed();

            return ximgproc_EdgeDrawing_1Params_get_1ScanInterval_10(nativeObj);


        }


        //
        // C++: void EdgeDrawing_Params::ScanInterval
        //

        public void set_ScanInterval(int ScanInterval)
        {
            ThrowIfDisposed();

            ximgproc_EdgeDrawing_1Params_set_1ScanInterval_10(nativeObj, ScanInterval);


        }


        //
        // C++: int EdgeDrawing_Params::MinPathLength
        //

        public int get_MinPathLength()
        {
            ThrowIfDisposed();

            return ximgproc_EdgeDrawing_1Params_get_1MinPathLength_10(nativeObj);


        }


        //
        // C++: void EdgeDrawing_Params::MinPathLength
        //

        public void set_MinPathLength(int MinPathLength)
        {
            ThrowIfDisposed();

            ximgproc_EdgeDrawing_1Params_set_1MinPathLength_10(nativeObj, MinPathLength);


        }


        //
        // C++: float EdgeDrawing_Params::Sigma
        //

        public float get_Sigma()
        {
            ThrowIfDisposed();

            return ximgproc_EdgeDrawing_1Params_get_1Sigma_10(nativeObj);


        }


        //
        // C++: void EdgeDrawing_Params::Sigma
        //

        public void set_Sigma(float Sigma)
        {
            ThrowIfDisposed();

            ximgproc_EdgeDrawing_1Params_set_1Sigma_10(nativeObj, Sigma);


        }


        //
        // C++: bool EdgeDrawing_Params::SumFlag
        //

        public bool get_SumFlag()
        {
            ThrowIfDisposed();

            return ximgproc_EdgeDrawing_1Params_get_1SumFlag_10(nativeObj);


        }


        //
        // C++: void EdgeDrawing_Params::SumFlag
        //

        public void set_SumFlag(bool SumFlag)
        {
            ThrowIfDisposed();

            ximgproc_EdgeDrawing_1Params_set_1SumFlag_10(nativeObj, SumFlag);


        }


        //
        // C++: bool EdgeDrawing_Params::NFAValidation
        //

        public bool get_NFAValidation()
        {
            ThrowIfDisposed();

            return ximgproc_EdgeDrawing_1Params_get_1NFAValidation_10(nativeObj);


        }


        //
        // C++: void EdgeDrawing_Params::NFAValidation
        //

        public void set_NFAValidation(bool NFAValidation)
        {
            ThrowIfDisposed();

            ximgproc_EdgeDrawing_1Params_set_1NFAValidation_10(nativeObj, NFAValidation);


        }


        //
        // C++: int EdgeDrawing_Params::MinLineLength
        //

        public int get_MinLineLength()
        {
            ThrowIfDisposed();

            return ximgproc_EdgeDrawing_1Params_get_1MinLineLength_10(nativeObj);


        }


        //
        // C++: void EdgeDrawing_Params::MinLineLength
        //

        public void set_MinLineLength(int MinLineLength)
        {
            ThrowIfDisposed();

            ximgproc_EdgeDrawing_1Params_set_1MinLineLength_10(nativeObj, MinLineLength);


        }


        //
        // C++: double EdgeDrawing_Params::MaxDistanceBetweenTwoLines
        //

        public double get_MaxDistanceBetweenTwoLines()
        {
            ThrowIfDisposed();

            return ximgproc_EdgeDrawing_1Params_get_1MaxDistanceBetweenTwoLines_10(nativeObj);


        }


        //
        // C++: void EdgeDrawing_Params::MaxDistanceBetweenTwoLines
        //

        public void set_MaxDistanceBetweenTwoLines(double MaxDistanceBetweenTwoLines)
        {
            ThrowIfDisposed();

            ximgproc_EdgeDrawing_1Params_set_1MaxDistanceBetweenTwoLines_10(nativeObj, MaxDistanceBetweenTwoLines);


        }


        //
        // C++: double EdgeDrawing_Params::LineFitErrorThreshold
        //

        public double get_LineFitErrorThreshold()
        {
            ThrowIfDisposed();

            return ximgproc_EdgeDrawing_1Params_get_1LineFitErrorThreshold_10(nativeObj);


        }


        //
        // C++: void EdgeDrawing_Params::LineFitErrorThreshold
        //

        public void set_LineFitErrorThreshold(double LineFitErrorThreshold)
        {
            ThrowIfDisposed();

            ximgproc_EdgeDrawing_1Params_set_1LineFitErrorThreshold_10(nativeObj, LineFitErrorThreshold);


        }


        //
        // C++: double EdgeDrawing_Params::MaxErrorThreshold
        //

        public double get_MaxErrorThreshold()
        {
            ThrowIfDisposed();

            return ximgproc_EdgeDrawing_1Params_get_1MaxErrorThreshold_10(nativeObj);


        }


        //
        // C++: void EdgeDrawing_Params::MaxErrorThreshold
        //

        public void set_MaxErrorThreshold(double MaxErrorThreshold)
        {
            ThrowIfDisposed();

            ximgproc_EdgeDrawing_1Params_set_1MaxErrorThreshold_10(nativeObj, MaxErrorThreshold);


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:   cv::ximgproc::EdgeDrawing::Params::Params()
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_EdgeDrawing_1Params_EdgeDrawing_1Params_10();

        // C++: bool EdgeDrawing_Params::PFmode
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool ximgproc_EdgeDrawing_1Params_get_1PFmode_10(IntPtr nativeObj);

        // C++: void EdgeDrawing_Params::PFmode
        [DllImport(LIBNAME)]
        private static extern void ximgproc_EdgeDrawing_1Params_set_1PFmode_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool PFmode);

        // C++: int EdgeDrawing_Params::EdgeDetectionOperator
        [DllImport(LIBNAME)]
        private static extern int ximgproc_EdgeDrawing_1Params_get_1EdgeDetectionOperator_10(IntPtr nativeObj);

        // C++: void EdgeDrawing_Params::EdgeDetectionOperator
        [DllImport(LIBNAME)]
        private static extern void ximgproc_EdgeDrawing_1Params_set_1EdgeDetectionOperator_10(IntPtr nativeObj, int EdgeDetectionOperator);

        // C++: int EdgeDrawing_Params::GradientThresholdValue
        [DllImport(LIBNAME)]
        private static extern int ximgproc_EdgeDrawing_1Params_get_1GradientThresholdValue_10(IntPtr nativeObj);

        // C++: void EdgeDrawing_Params::GradientThresholdValue
        [DllImport(LIBNAME)]
        private static extern void ximgproc_EdgeDrawing_1Params_set_1GradientThresholdValue_10(IntPtr nativeObj, int GradientThresholdValue);

        // C++: int EdgeDrawing_Params::AnchorThresholdValue
        [DllImport(LIBNAME)]
        private static extern int ximgproc_EdgeDrawing_1Params_get_1AnchorThresholdValue_10(IntPtr nativeObj);

        // C++: void EdgeDrawing_Params::AnchorThresholdValue
        [DllImport(LIBNAME)]
        private static extern void ximgproc_EdgeDrawing_1Params_set_1AnchorThresholdValue_10(IntPtr nativeObj, int AnchorThresholdValue);

        // C++: int EdgeDrawing_Params::ScanInterval
        [DllImport(LIBNAME)]
        private static extern int ximgproc_EdgeDrawing_1Params_get_1ScanInterval_10(IntPtr nativeObj);

        // C++: void EdgeDrawing_Params::ScanInterval
        [DllImport(LIBNAME)]
        private static extern void ximgproc_EdgeDrawing_1Params_set_1ScanInterval_10(IntPtr nativeObj, int ScanInterval);

        // C++: int EdgeDrawing_Params::MinPathLength
        [DllImport(LIBNAME)]
        private static extern int ximgproc_EdgeDrawing_1Params_get_1MinPathLength_10(IntPtr nativeObj);

        // C++: void EdgeDrawing_Params::MinPathLength
        [DllImport(LIBNAME)]
        private static extern void ximgproc_EdgeDrawing_1Params_set_1MinPathLength_10(IntPtr nativeObj, int MinPathLength);

        // C++: float EdgeDrawing_Params::Sigma
        [DllImport(LIBNAME)]
        private static extern float ximgproc_EdgeDrawing_1Params_get_1Sigma_10(IntPtr nativeObj);

        // C++: void EdgeDrawing_Params::Sigma
        [DllImport(LIBNAME)]
        private static extern void ximgproc_EdgeDrawing_1Params_set_1Sigma_10(IntPtr nativeObj, float Sigma);

        // C++: bool EdgeDrawing_Params::SumFlag
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool ximgproc_EdgeDrawing_1Params_get_1SumFlag_10(IntPtr nativeObj);

        // C++: void EdgeDrawing_Params::SumFlag
        [DllImport(LIBNAME)]
        private static extern void ximgproc_EdgeDrawing_1Params_set_1SumFlag_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool SumFlag);

        // C++: bool EdgeDrawing_Params::NFAValidation
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool ximgproc_EdgeDrawing_1Params_get_1NFAValidation_10(IntPtr nativeObj);

        // C++: void EdgeDrawing_Params::NFAValidation
        [DllImport(LIBNAME)]
        private static extern void ximgproc_EdgeDrawing_1Params_set_1NFAValidation_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool NFAValidation);

        // C++: int EdgeDrawing_Params::MinLineLength
        [DllImport(LIBNAME)]
        private static extern int ximgproc_EdgeDrawing_1Params_get_1MinLineLength_10(IntPtr nativeObj);

        // C++: void EdgeDrawing_Params::MinLineLength
        [DllImport(LIBNAME)]
        private static extern void ximgproc_EdgeDrawing_1Params_set_1MinLineLength_10(IntPtr nativeObj, int MinLineLength);

        // C++: double EdgeDrawing_Params::MaxDistanceBetweenTwoLines
        [DllImport(LIBNAME)]
        private static extern double ximgproc_EdgeDrawing_1Params_get_1MaxDistanceBetweenTwoLines_10(IntPtr nativeObj);

        // C++: void EdgeDrawing_Params::MaxDistanceBetweenTwoLines
        [DllImport(LIBNAME)]
        private static extern void ximgproc_EdgeDrawing_1Params_set_1MaxDistanceBetweenTwoLines_10(IntPtr nativeObj, double MaxDistanceBetweenTwoLines);

        // C++: double EdgeDrawing_Params::LineFitErrorThreshold
        [DllImport(LIBNAME)]
        private static extern double ximgproc_EdgeDrawing_1Params_get_1LineFitErrorThreshold_10(IntPtr nativeObj);

        // C++: void EdgeDrawing_Params::LineFitErrorThreshold
        [DllImport(LIBNAME)]
        private static extern void ximgproc_EdgeDrawing_1Params_set_1LineFitErrorThreshold_10(IntPtr nativeObj, double LineFitErrorThreshold);

        // C++: double EdgeDrawing_Params::MaxErrorThreshold
        [DllImport(LIBNAME)]
        private static extern double ximgproc_EdgeDrawing_1Params_get_1MaxErrorThreshold_10(IntPtr nativeObj);

        // C++: void EdgeDrawing_Params::MaxErrorThreshold
        [DllImport(LIBNAME)]
        private static extern void ximgproc_EdgeDrawing_1Params_set_1MaxErrorThreshold_10(IntPtr nativeObj, double MaxErrorThreshold);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void ximgproc_EdgeDrawing_1Params_delete(IntPtr nativeObj);

    }
}
