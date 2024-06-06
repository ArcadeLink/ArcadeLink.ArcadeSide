

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.ObjdetectModule
{
    // C++: class RefineParameters
    /**
     * struct RefineParameters is used by ArucoDetector
     */

    public class RefineParameters : DisposableOpenCVObject
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
                        objdetect_RefineParameters_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal RefineParameters(IntPtr addr) : base(addr) { }


        public IntPtr getNativeObjAddr() { return nativeObj; }

        // internal usage only
        public static RefineParameters __fromPtr__(IntPtr addr) { return new RefineParameters(addr); }

        //
        // C++:   cv::aruco::RefineParameters::RefineParameters(float minRepDistance = 10.f, float errorCorrectionRate = 3.f, bool checkAllOrders = true)
        //

        public RefineParameters(float minRepDistance, float errorCorrectionRate, bool checkAllOrders)
        {


            nativeObj = DisposableObject.ThrowIfNullIntPtr(objdetect_RefineParameters_RefineParameters_10(minRepDistance, errorCorrectionRate, checkAllOrders));


        }

        public RefineParameters(float minRepDistance, float errorCorrectionRate)
        {


            nativeObj = DisposableObject.ThrowIfNullIntPtr(objdetect_RefineParameters_RefineParameters_11(minRepDistance, errorCorrectionRate));


        }

        public RefineParameters(float minRepDistance)
        {


            nativeObj = DisposableObject.ThrowIfNullIntPtr(objdetect_RefineParameters_RefineParameters_12(minRepDistance));


        }

        public RefineParameters()
        {


            nativeObj = DisposableObject.ThrowIfNullIntPtr(objdetect_RefineParameters_RefineParameters_13());


        }


        //
        // C++:  bool cv::aruco::RefineParameters::readRefineParameters(FileNode fn)
        //

        // Unknown type 'FileNode' (I), skipping the function


        //
        // C++:  bool cv::aruco::RefineParameters::writeRefineParameters(FileStorage fs, String name = String())
        //

        // Unknown type 'FileStorage' (I), skipping the function


        //
        // C++: float RefineParameters::minRepDistance
        //

        public float get_minRepDistance()
        {
            ThrowIfDisposed();

            return objdetect_RefineParameters_get_1minRepDistance_10(nativeObj);


        }


        //
        // C++: void RefineParameters::minRepDistance
        //

        public void set_minRepDistance(float minRepDistance)
        {
            ThrowIfDisposed();

            objdetect_RefineParameters_set_1minRepDistance_10(nativeObj, minRepDistance);


        }


        //
        // C++: float RefineParameters::errorCorrectionRate
        //

        public float get_errorCorrectionRate()
        {
            ThrowIfDisposed();

            return objdetect_RefineParameters_get_1errorCorrectionRate_10(nativeObj);


        }


        //
        // C++: void RefineParameters::errorCorrectionRate
        //

        public void set_errorCorrectionRate(float errorCorrectionRate)
        {
            ThrowIfDisposed();

            objdetect_RefineParameters_set_1errorCorrectionRate_10(nativeObj, errorCorrectionRate);


        }


        //
        // C++: bool RefineParameters::checkAllOrders
        //

        public bool get_checkAllOrders()
        {
            ThrowIfDisposed();

            return objdetect_RefineParameters_get_1checkAllOrders_10(nativeObj);


        }


        //
        // C++: void RefineParameters::checkAllOrders
        //

        public void set_checkAllOrders(bool checkAllOrders)
        {
            ThrowIfDisposed();

            objdetect_RefineParameters_set_1checkAllOrders_10(nativeObj, checkAllOrders);


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:   cv::aruco::RefineParameters::RefineParameters(float minRepDistance = 10.f, float errorCorrectionRate = 3.f, bool checkAllOrders = true)
        [DllImport(LIBNAME)]
        private static extern IntPtr objdetect_RefineParameters_RefineParameters_10(float minRepDistance, float errorCorrectionRate, [MarshalAs(UnmanagedType.U1)] bool checkAllOrders);
        [DllImport(LIBNAME)]
        private static extern IntPtr objdetect_RefineParameters_RefineParameters_11(float minRepDistance, float errorCorrectionRate);
        [DllImport(LIBNAME)]
        private static extern IntPtr objdetect_RefineParameters_RefineParameters_12(float minRepDistance);
        [DllImport(LIBNAME)]
        private static extern IntPtr objdetect_RefineParameters_RefineParameters_13();

        // C++: float RefineParameters::minRepDistance
        [DllImport(LIBNAME)]
        private static extern float objdetect_RefineParameters_get_1minRepDistance_10(IntPtr nativeObj);

        // C++: void RefineParameters::minRepDistance
        [DllImport(LIBNAME)]
        private static extern void objdetect_RefineParameters_set_1minRepDistance_10(IntPtr nativeObj, float minRepDistance);

        // C++: float RefineParameters::errorCorrectionRate
        [DllImport(LIBNAME)]
        private static extern float objdetect_RefineParameters_get_1errorCorrectionRate_10(IntPtr nativeObj);

        // C++: void RefineParameters::errorCorrectionRate
        [DllImport(LIBNAME)]
        private static extern void objdetect_RefineParameters_set_1errorCorrectionRate_10(IntPtr nativeObj, float errorCorrectionRate);

        // C++: bool RefineParameters::checkAllOrders
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool objdetect_RefineParameters_get_1checkAllOrders_10(IntPtr nativeObj);

        // C++: void RefineParameters::checkAllOrders
        [DllImport(LIBNAME)]
        private static extern void objdetect_RefineParameters_set_1checkAllOrders_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool checkAllOrders);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void objdetect_RefineParameters_delete(IntPtr nativeObj);

    }
}
