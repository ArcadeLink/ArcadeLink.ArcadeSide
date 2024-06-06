

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.ObjdetectModule
{
    // C++: class Params
    /**
     * QR code encoder parameters.
     *      version The optional version of QR code (by default - maximum possible depending on
     *                     the length of the string).
     *      correction_level The optional level of error correction (by default - the lowest).
     *      mode The optional encoding mode - Numeric, Alphanumeric, Byte, Kanji, ECI or Structured Append.
     *      structure_number The optional number of QR codes to generate in Structured Append mode.
     */

    public class QRCodeEncoder_Params : DisposableOpenCVObject
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
                        objdetect_QRCodeEncoder_1Params_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal QRCodeEncoder_Params(IntPtr addr) : base(addr) { }


        public IntPtr getNativeObjAddr() { return nativeObj; }

        // internal usage only
        public static QRCodeEncoder_Params __fromPtr__(IntPtr addr) { return new QRCodeEncoder_Params(addr); }

        //
        // C++:   cv::QRCodeEncoder::Params::Params()
        //

        public QRCodeEncoder_Params()
        {


            nativeObj = DisposableObject.ThrowIfNullIntPtr(objdetect_QRCodeEncoder_1Params_QRCodeEncoder_1Params_10());


        }


        //
        // C++: int QRCodeEncoder_Params::version
        //

        public int get_version()
        {
            ThrowIfDisposed();

            return objdetect_QRCodeEncoder_1Params_get_1version_10(nativeObj);


        }


        //
        // C++: void QRCodeEncoder_Params::version
        //

        public void set_version(int version)
        {
            ThrowIfDisposed();

            objdetect_QRCodeEncoder_1Params_set_1version_10(nativeObj, version);


        }


        //
        // C++: CorrectionLevel QRCodeEncoder_Params::correction_level
        //

        // Return type 'CorrectionLevel' is not supported, skipping the function


        //
        // C++: void QRCodeEncoder_Params::correction_level
        //

        // Unknown type 'CorrectionLevel' (I), skipping the function


        //
        // C++: EncodeMode QRCodeEncoder_Params::mode
        //

        // Return type 'EncodeMode' is not supported, skipping the function


        //
        // C++: void QRCodeEncoder_Params::mode
        //

        // Unknown type 'EncodeMode' (I), skipping the function


        //
        // C++: int QRCodeEncoder_Params::structure_number
        //

        public int get_structure_number()
        {
            ThrowIfDisposed();

            return objdetect_QRCodeEncoder_1Params_get_1structure_1number_10(nativeObj);


        }


        //
        // C++: void QRCodeEncoder_Params::structure_number
        //

        public void set_structure_number(int structure_number)
        {
            ThrowIfDisposed();

            objdetect_QRCodeEncoder_1Params_set_1structure_1number_10(nativeObj, structure_number);


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:   cv::QRCodeEncoder::Params::Params()
        [DllImport(LIBNAME)]
        private static extern IntPtr objdetect_QRCodeEncoder_1Params_QRCodeEncoder_1Params_10();

        // C++: int QRCodeEncoder_Params::version
        [DllImport(LIBNAME)]
        private static extern int objdetect_QRCodeEncoder_1Params_get_1version_10(IntPtr nativeObj);

        // C++: void QRCodeEncoder_Params::version
        [DllImport(LIBNAME)]
        private static extern void objdetect_QRCodeEncoder_1Params_set_1version_10(IntPtr nativeObj, int version);

        // C++: int QRCodeEncoder_Params::structure_number
        [DllImport(LIBNAME)]
        private static extern int objdetect_QRCodeEncoder_1Params_get_1structure_1number_10(IntPtr nativeObj);

        // C++: void QRCodeEncoder_Params::structure_number
        [DllImport(LIBNAME)]
        private static extern void objdetect_QRCodeEncoder_1Params_set_1structure_1number_10(IntPtr nativeObj, int structure_number);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void objdetect_QRCodeEncoder_1Params_delete(IntPtr nativeObj);

    }
}
