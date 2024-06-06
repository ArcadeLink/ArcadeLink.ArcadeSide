

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.ObjdetectModule
{
    // C++: class Params


    public class QRCodeDetectorAruco_Params : DisposableOpenCVObject
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
                        objdetect_QRCodeDetectorAruco_1Params_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal QRCodeDetectorAruco_Params(IntPtr addr) : base(addr) { }


        public IntPtr getNativeObjAddr() { return nativeObj; }

        // internal usage only
        public static QRCodeDetectorAruco_Params __fromPtr__(IntPtr addr) { return new QRCodeDetectorAruco_Params(addr); }

        //
        // C++:   cv::QRCodeDetectorAruco::Params::Params()
        //

        public QRCodeDetectorAruco_Params()
        {


            nativeObj = DisposableObject.ThrowIfNullIntPtr(objdetect_QRCodeDetectorAruco_1Params_QRCodeDetectorAruco_1Params_10());


        }


        //
        // C++: float QRCodeDetectorAruco_Params::minModuleSizeInPyramid
        //

        public float get_minModuleSizeInPyramid()
        {
            ThrowIfDisposed();

            return objdetect_QRCodeDetectorAruco_1Params_get_1minModuleSizeInPyramid_10(nativeObj);


        }


        //
        // C++: void QRCodeDetectorAruco_Params::minModuleSizeInPyramid
        //

        public void set_minModuleSizeInPyramid(float minModuleSizeInPyramid)
        {
            ThrowIfDisposed();

            objdetect_QRCodeDetectorAruco_1Params_set_1minModuleSizeInPyramid_10(nativeObj, minModuleSizeInPyramid);


        }


        //
        // C++: float QRCodeDetectorAruco_Params::maxRotation
        //

        public float get_maxRotation()
        {
            ThrowIfDisposed();

            return objdetect_QRCodeDetectorAruco_1Params_get_1maxRotation_10(nativeObj);


        }


        //
        // C++: void QRCodeDetectorAruco_Params::maxRotation
        //

        public void set_maxRotation(float maxRotation)
        {
            ThrowIfDisposed();

            objdetect_QRCodeDetectorAruco_1Params_set_1maxRotation_10(nativeObj, maxRotation);


        }


        //
        // C++: float QRCodeDetectorAruco_Params::maxModuleSizeMismatch
        //

        public float get_maxModuleSizeMismatch()
        {
            ThrowIfDisposed();

            return objdetect_QRCodeDetectorAruco_1Params_get_1maxModuleSizeMismatch_10(nativeObj);


        }


        //
        // C++: void QRCodeDetectorAruco_Params::maxModuleSizeMismatch
        //

        public void set_maxModuleSizeMismatch(float maxModuleSizeMismatch)
        {
            ThrowIfDisposed();

            objdetect_QRCodeDetectorAruco_1Params_set_1maxModuleSizeMismatch_10(nativeObj, maxModuleSizeMismatch);


        }


        //
        // C++: float QRCodeDetectorAruco_Params::maxTimingPatternMismatch
        //

        public float get_maxTimingPatternMismatch()
        {
            ThrowIfDisposed();

            return objdetect_QRCodeDetectorAruco_1Params_get_1maxTimingPatternMismatch_10(nativeObj);


        }


        //
        // C++: void QRCodeDetectorAruco_Params::maxTimingPatternMismatch
        //

        public void set_maxTimingPatternMismatch(float maxTimingPatternMismatch)
        {
            ThrowIfDisposed();

            objdetect_QRCodeDetectorAruco_1Params_set_1maxTimingPatternMismatch_10(nativeObj, maxTimingPatternMismatch);


        }


        //
        // C++: float QRCodeDetectorAruco_Params::maxPenalties
        //

        public float get_maxPenalties()
        {
            ThrowIfDisposed();

            return objdetect_QRCodeDetectorAruco_1Params_get_1maxPenalties_10(nativeObj);


        }


        //
        // C++: void QRCodeDetectorAruco_Params::maxPenalties
        //

        public void set_maxPenalties(float maxPenalties)
        {
            ThrowIfDisposed();

            objdetect_QRCodeDetectorAruco_1Params_set_1maxPenalties_10(nativeObj, maxPenalties);


        }


        //
        // C++: float QRCodeDetectorAruco_Params::maxColorsMismatch
        //

        public float get_maxColorsMismatch()
        {
            ThrowIfDisposed();

            return objdetect_QRCodeDetectorAruco_1Params_get_1maxColorsMismatch_10(nativeObj);


        }


        //
        // C++: void QRCodeDetectorAruco_Params::maxColorsMismatch
        //

        public void set_maxColorsMismatch(float maxColorsMismatch)
        {
            ThrowIfDisposed();

            objdetect_QRCodeDetectorAruco_1Params_set_1maxColorsMismatch_10(nativeObj, maxColorsMismatch);


        }


        //
        // C++: float QRCodeDetectorAruco_Params::scaleTimingPatternScore
        //

        public float get_scaleTimingPatternScore()
        {
            ThrowIfDisposed();

            return objdetect_QRCodeDetectorAruco_1Params_get_1scaleTimingPatternScore_10(nativeObj);


        }


        //
        // C++: void QRCodeDetectorAruco_Params::scaleTimingPatternScore
        //

        public void set_scaleTimingPatternScore(float scaleTimingPatternScore)
        {
            ThrowIfDisposed();

            objdetect_QRCodeDetectorAruco_1Params_set_1scaleTimingPatternScore_10(nativeObj, scaleTimingPatternScore);


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:   cv::QRCodeDetectorAruco::Params::Params()
        [DllImport(LIBNAME)]
        private static extern IntPtr objdetect_QRCodeDetectorAruco_1Params_QRCodeDetectorAruco_1Params_10();

        // C++: float QRCodeDetectorAruco_Params::minModuleSizeInPyramid
        [DllImport(LIBNAME)]
        private static extern float objdetect_QRCodeDetectorAruco_1Params_get_1minModuleSizeInPyramid_10(IntPtr nativeObj);

        // C++: void QRCodeDetectorAruco_Params::minModuleSizeInPyramid
        [DllImport(LIBNAME)]
        private static extern void objdetect_QRCodeDetectorAruco_1Params_set_1minModuleSizeInPyramid_10(IntPtr nativeObj, float minModuleSizeInPyramid);

        // C++: float QRCodeDetectorAruco_Params::maxRotation
        [DllImport(LIBNAME)]
        private static extern float objdetect_QRCodeDetectorAruco_1Params_get_1maxRotation_10(IntPtr nativeObj);

        // C++: void QRCodeDetectorAruco_Params::maxRotation
        [DllImport(LIBNAME)]
        private static extern void objdetect_QRCodeDetectorAruco_1Params_set_1maxRotation_10(IntPtr nativeObj, float maxRotation);

        // C++: float QRCodeDetectorAruco_Params::maxModuleSizeMismatch
        [DllImport(LIBNAME)]
        private static extern float objdetect_QRCodeDetectorAruco_1Params_get_1maxModuleSizeMismatch_10(IntPtr nativeObj);

        // C++: void QRCodeDetectorAruco_Params::maxModuleSizeMismatch
        [DllImport(LIBNAME)]
        private static extern void objdetect_QRCodeDetectorAruco_1Params_set_1maxModuleSizeMismatch_10(IntPtr nativeObj, float maxModuleSizeMismatch);

        // C++: float QRCodeDetectorAruco_Params::maxTimingPatternMismatch
        [DllImport(LIBNAME)]
        private static extern float objdetect_QRCodeDetectorAruco_1Params_get_1maxTimingPatternMismatch_10(IntPtr nativeObj);

        // C++: void QRCodeDetectorAruco_Params::maxTimingPatternMismatch
        [DllImport(LIBNAME)]
        private static extern void objdetect_QRCodeDetectorAruco_1Params_set_1maxTimingPatternMismatch_10(IntPtr nativeObj, float maxTimingPatternMismatch);

        // C++: float QRCodeDetectorAruco_Params::maxPenalties
        [DllImport(LIBNAME)]
        private static extern float objdetect_QRCodeDetectorAruco_1Params_get_1maxPenalties_10(IntPtr nativeObj);

        // C++: void QRCodeDetectorAruco_Params::maxPenalties
        [DllImport(LIBNAME)]
        private static extern void objdetect_QRCodeDetectorAruco_1Params_set_1maxPenalties_10(IntPtr nativeObj, float maxPenalties);

        // C++: float QRCodeDetectorAruco_Params::maxColorsMismatch
        [DllImport(LIBNAME)]
        private static extern float objdetect_QRCodeDetectorAruco_1Params_get_1maxColorsMismatch_10(IntPtr nativeObj);

        // C++: void QRCodeDetectorAruco_Params::maxColorsMismatch
        [DllImport(LIBNAME)]
        private static extern void objdetect_QRCodeDetectorAruco_1Params_set_1maxColorsMismatch_10(IntPtr nativeObj, float maxColorsMismatch);

        // C++: float QRCodeDetectorAruco_Params::scaleTimingPatternScore
        [DllImport(LIBNAME)]
        private static extern float objdetect_QRCodeDetectorAruco_1Params_get_1scaleTimingPatternScore_10(IntPtr nativeObj);

        // C++: void QRCodeDetectorAruco_Params::scaleTimingPatternScore
        [DllImport(LIBNAME)]
        private static extern void objdetect_QRCodeDetectorAruco_1Params_set_1scaleTimingPatternScore_10(IntPtr nativeObj, float scaleTimingPatternScore);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void objdetect_QRCodeDetectorAruco_1Params_delete(IntPtr nativeObj);

    }
}
