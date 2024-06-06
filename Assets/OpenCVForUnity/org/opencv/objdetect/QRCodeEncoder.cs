

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.ObjdetectModule
{
    // C++: class QRCodeEncoder
    /**
     * Groups the object candidate rectangles.
     *     rectList  Input/output vector of rectangles. Output vector includes retained and grouped rectangles. (The Python list is not modified in place.)
     *     weights Input/output vector of weights of rectangles. Output vector includes weights of retained and grouped rectangles. (The Python list is not modified in place.)
     *     groupThreshold Minimum possible number of rectangles minus 1. The threshold is used in a group of rectangles to retain it.
     *     eps Relative difference between sides of the rectangles to merge them into a group.
     */

    public class QRCodeEncoder : DisposableOpenCVObject
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
                        objdetect_QRCodeEncoder_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal QRCodeEncoder(IntPtr addr) : base(addr) { }


        public IntPtr getNativeObjAddr() { return nativeObj; }

        // internal usage only
        public static QRCodeEncoder __fromPtr__(IntPtr addr) { return new QRCodeEncoder(addr); }

        // C++: enum cv.QRCodeEncoder.CorrectionLevel
        public const int CORRECT_LEVEL_L = 0;
        public const int CORRECT_LEVEL_M = 1;
        public const int CORRECT_LEVEL_Q = 2;
        public const int CORRECT_LEVEL_H = 3;
        // C++: enum cv.QRCodeEncoder.ECIEncodings
        public const int ECI_UTF8 = 26;
        // C++: enum cv.QRCodeEncoder.EncodeMode
        public const int MODE_AUTO = -1;
        public const int MODE_NUMERIC = 1;
        public const int MODE_ALPHANUMERIC = 2;
        public const int MODE_BYTE = 4;
        public const int MODE_ECI = 7;
        public const int MODE_KANJI = 8;
        public const int MODE_STRUCTURED_APPEND = 3;
        //
        // C++: static Ptr_QRCodeEncoder cv::QRCodeEncoder::create(QRCodeEncoder_Params parameters = QRCodeEncoder::Params())
        //

        /**
         * Constructor
         *     param parameters QR code encoder parameters QRCodeEncoder::Params
         * return automatically generated
         */
        public static QRCodeEncoder create(QRCodeEncoder_Params parameters)
        {
            if (parameters != null) parameters.ThrowIfDisposed();

            return QRCodeEncoder.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(objdetect_QRCodeEncoder_create_10(parameters.nativeObj)));


        }

        /**
         * Constructor
         * return automatically generated
         */
        public static QRCodeEncoder create()
        {


            return QRCodeEncoder.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(objdetect_QRCodeEncoder_create_11()));


        }


        //
        // C++:  void cv::QRCodeEncoder::encode(String encoded_info, Mat& qrcode)
        //

        /**
         * Generates QR code from input string.
         *      param encoded_info Input string to encode.
         *      param qrcode Generated QR code.
         */
        public void encode(string encoded_info, Mat qrcode)
        {
            ThrowIfDisposed();
            if (qrcode != null) qrcode.ThrowIfDisposed();

            objdetect_QRCodeEncoder_encode_10(nativeObj, encoded_info, qrcode.nativeObj);


        }


        //
        // C++:  void cv::QRCodeEncoder::encodeStructuredAppend(String encoded_info, vector_Mat& qrcodes)
        //

        /**
         * Generates QR code from input string in Structured Append mode. The encoded message is splitting over a number of QR codes.
         *      param encoded_info Input string to encode.
         *      param qrcodes Vector of generated QR codes.
         */
        public void encodeStructuredAppend(string encoded_info, List<Mat> qrcodes)
        {
            ThrowIfDisposed();
            Mat qrcodes_mat = new Mat();
            objdetect_QRCodeEncoder_encodeStructuredAppend_10(nativeObj, encoded_info, qrcodes_mat.nativeObj);
            Converters.Mat_to_vector_Mat(qrcodes_mat, qrcodes);
            qrcodes_mat.release();

        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++: static Ptr_QRCodeEncoder cv::QRCodeEncoder::create(QRCodeEncoder_Params parameters = QRCodeEncoder::Params())
        [DllImport(LIBNAME)]
        private static extern IntPtr objdetect_QRCodeEncoder_create_10(IntPtr parameters_nativeObj);
        [DllImport(LIBNAME)]
        private static extern IntPtr objdetect_QRCodeEncoder_create_11();

        // C++:  void cv::QRCodeEncoder::encode(String encoded_info, Mat& qrcode)
        [DllImport(LIBNAME)]
        private static extern void objdetect_QRCodeEncoder_encode_10(IntPtr nativeObj, string encoded_info, IntPtr qrcode_nativeObj);

        // C++:  void cv::QRCodeEncoder::encodeStructuredAppend(String encoded_info, vector_Mat& qrcodes)
        [DllImport(LIBNAME)]
        private static extern void objdetect_QRCodeEncoder_encodeStructuredAppend_10(IntPtr nativeObj, string encoded_info, IntPtr qrcodes_mat_nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void objdetect_QRCodeEncoder_delete(IntPtr nativeObj);

    }
}
