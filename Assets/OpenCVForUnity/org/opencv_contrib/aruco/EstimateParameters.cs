

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.ArucoModule
{
    // C++: class EstimateParameters
    /**
     * Pose estimation parameters
     *
     * pattern Defines center this system and axes direction (default PatternPositionType::ARUCO_CCW_CENTER).
     * useExtrinsicGuess Parameter used for SOLVEPNP_ITERATIVE. If true (1), the function uses the provided
     * rvec and tvec values as initial approximations of the rotation and translation vectors, respectively, and further
     * optimizes them (default false).
     * solvePnPMethod Method for solving a PnP problem: see REF: calib3d_solvePnP_flags (default SOLVEPNP_ITERATIVE).
     * SEE: PatternPositionType, solvePnP(), check tutorial_aruco_detection in aruco contrib
     */

    public class EstimateParameters : DisposableOpenCVObject
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
                        aruco_EstimateParameters_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal EstimateParameters(IntPtr addr) : base(addr) { }


        public IntPtr getNativeObjAddr() { return nativeObj; }

        // internal usage only
        public static EstimateParameters __fromPtr__(IntPtr addr) { return new EstimateParameters(addr); }

        //
        // C++:   cv::aruco::EstimateParameters::EstimateParameters()
        //

        public EstimateParameters()
        {


            nativeObj = DisposableObject.ThrowIfNullIntPtr(aruco_EstimateParameters_EstimateParameters_10());


        }


        //
        // C++: PatternPositionType EstimateParameters::pattern
        //

        // Return type 'PatternPositionType' is not supported, skipping the function


        //
        // C++: void EstimateParameters::pattern
        //

        // Unknown type 'PatternPositionType' (I), skipping the function


        //
        // C++: bool EstimateParameters::useExtrinsicGuess
        //

        public bool get_useExtrinsicGuess()
        {
            ThrowIfDisposed();

            return aruco_EstimateParameters_get_1useExtrinsicGuess_10(nativeObj);


        }


        //
        // C++: void EstimateParameters::useExtrinsicGuess
        //

        public void set_useExtrinsicGuess(bool useExtrinsicGuess)
        {
            ThrowIfDisposed();

            aruco_EstimateParameters_set_1useExtrinsicGuess_10(nativeObj, useExtrinsicGuess);


        }


        //
        // C++: int EstimateParameters::solvePnPMethod
        //

        public int get_solvePnPMethod()
        {
            ThrowIfDisposed();

            return aruco_EstimateParameters_get_1solvePnPMethod_10(nativeObj);


        }


        //
        // C++: void EstimateParameters::solvePnPMethod
        //

        public void set_solvePnPMethod(int solvePnPMethod)
        {
            ThrowIfDisposed();

            aruco_EstimateParameters_set_1solvePnPMethod_10(nativeObj, solvePnPMethod);


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:   cv::aruco::EstimateParameters::EstimateParameters()
        [DllImport(LIBNAME)]
        private static extern IntPtr aruco_EstimateParameters_EstimateParameters_10();

        // C++: bool EstimateParameters::useExtrinsicGuess
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool aruco_EstimateParameters_get_1useExtrinsicGuess_10(IntPtr nativeObj);

        // C++: void EstimateParameters::useExtrinsicGuess
        [DllImport(LIBNAME)]
        private static extern void aruco_EstimateParameters_set_1useExtrinsicGuess_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool useExtrinsicGuess);

        // C++: int EstimateParameters::solvePnPMethod
        [DllImport(LIBNAME)]
        private static extern int aruco_EstimateParameters_get_1solvePnPMethod_10(IntPtr nativeObj);

        // C++: void EstimateParameters::solvePnPMethod
        [DllImport(LIBNAME)]
        private static extern void aruco_EstimateParameters_set_1solvePnPMethod_10(IntPtr nativeObj, int solvePnPMethod);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void aruco_EstimateParameters_delete(IntPtr nativeObj);

    }
}
