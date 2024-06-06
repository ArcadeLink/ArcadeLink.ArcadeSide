
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.ObjdetectModule
{

    // C++: class QRCodeDetectorAruco


    public class QRCodeDetectorAruco : GraphicalCodeDetector
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
                        objdetect_QRCodeDetectorAruco_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal QRCodeDetectorAruco(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new QRCodeDetectorAruco __fromPtr__(IntPtr addr) { return new QRCodeDetectorAruco(addr); }

        //
        // C++:   cv::QRCodeDetectorAruco::QRCodeDetectorAruco()
        //

        public QRCodeDetectorAruco() :
            base(DisposableObject.ThrowIfNullIntPtr(objdetect_QRCodeDetectorAruco_QRCodeDetectorAruco_10()))
        {



        }


        //
        // C++:   cv::QRCodeDetectorAruco::QRCodeDetectorAruco(QRCodeDetectorAruco_Params _params)
        //

        /**
         * QR code detector constructor for Aruco-based algorithm. See cv::QRCodeDetectorAruco::Params
         * param _params automatically generated
         */
        public QRCodeDetectorAruco(QRCodeDetectorAruco_Params _params) :
            base(DisposableObject.ThrowIfNullIntPtr(objdetect_QRCodeDetectorAruco_QRCodeDetectorAruco_11(_params.nativeObj)))
        {



        }


        //
        // C++:  QRCodeDetectorAruco_Params cv::QRCodeDetectorAruco::getDetectorParameters()
        //

        /**
         * Detector parameters getter. See cv::QRCodeDetectorAruco::Params
         * return automatically generated
         */
        public QRCodeDetectorAruco_Params getDetectorParameters()
        {
            ThrowIfDisposed();

            return new QRCodeDetectorAruco_Params(DisposableObject.ThrowIfNullIntPtr(objdetect_QRCodeDetectorAruco_getDetectorParameters_10(nativeObj)));


        }


        //
        // C++:  QRCodeDetectorAruco cv::QRCodeDetectorAruco::setDetectorParameters(QRCodeDetectorAruco_Params _params)
        //

        /**
         * Detector parameters setter. See cv::QRCodeDetectorAruco::Params
         * param _params automatically generated
         * return automatically generated
         */
        public QRCodeDetectorAruco setDetectorParameters(QRCodeDetectorAruco_Params _params)
        {
            ThrowIfDisposed();
            if (_params != null) _params.ThrowIfDisposed();

            return new QRCodeDetectorAruco(DisposableObject.ThrowIfNullIntPtr(objdetect_QRCodeDetectorAruco_setDetectorParameters_10(nativeObj, _params.nativeObj)));


        }


        //
        // C++:  aruco_DetectorParameters cv::QRCodeDetectorAruco::getArucoParameters()
        //

        // Return type 'aruco_DetectorParameters' is not supported, skipping the function


        //
        // C++:  void cv::QRCodeDetectorAruco::setArucoParameters(aruco_DetectorParameters _params)
        //

        // Unknown type 'aruco_DetectorParameters' (I), skipping the function


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:   cv::QRCodeDetectorAruco::QRCodeDetectorAruco()
        [DllImport(LIBNAME)]
        private static extern IntPtr objdetect_QRCodeDetectorAruco_QRCodeDetectorAruco_10();

        // C++:   cv::QRCodeDetectorAruco::QRCodeDetectorAruco(QRCodeDetectorAruco_Params _params)
        [DllImport(LIBNAME)]
        private static extern IntPtr objdetect_QRCodeDetectorAruco_QRCodeDetectorAruco_11(IntPtr _params_nativeObj);

        // C++:  QRCodeDetectorAruco_Params cv::QRCodeDetectorAruco::getDetectorParameters()
        [DllImport(LIBNAME)]
        private static extern IntPtr objdetect_QRCodeDetectorAruco_getDetectorParameters_10(IntPtr nativeObj);

        // C++:  QRCodeDetectorAruco cv::QRCodeDetectorAruco::setDetectorParameters(QRCodeDetectorAruco_Params _params)
        [DllImport(LIBNAME)]
        private static extern IntPtr objdetect_QRCodeDetectorAruco_setDetectorParameters_10(IntPtr nativeObj, IntPtr _params_nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void objdetect_QRCodeDetectorAruco_delete(IntPtr nativeObj);

    }
}
