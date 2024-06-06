#if !UNITY_WSA_10_0

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.DnnModule
{
    // C++: class DictValue
    /**
     * This struct stores the scalar value (or array) of one of the following type: double, cv::String or int64.
     * TODO: Maybe int64 is useless because double type exactly stores at least 2^52 integers.
     */

    public class DictValue : DisposableOpenCVObject
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
                        dnn_DictValue_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal DictValue(IntPtr addr) : base(addr) { }


        public IntPtr getNativeObjAddr() { return nativeObj; }

        // internal usage only
        public static DictValue __fromPtr__(IntPtr addr) { return new DictValue(addr); }

        //
        // C++:   cv::dnn::DictValue::DictValue(int i)
        //

        public DictValue(int i)
        {


            nativeObj = DisposableObject.ThrowIfNullIntPtr(dnn_DictValue_DictValue_10(i));


        }


        //
        // C++:   cv::dnn::DictValue::DictValue(double p)
        //

        public DictValue(double p)
        {


            nativeObj = DisposableObject.ThrowIfNullIntPtr(dnn_DictValue_DictValue_11(p));


        }


        //
        // C++:   cv::dnn::DictValue::DictValue(String s)
        //

        public DictValue(string s)
        {


            nativeObj = DisposableObject.ThrowIfNullIntPtr(dnn_DictValue_DictValue_12(s));


        }


        //
        // C++:  bool cv::dnn::DictValue::isInt()
        //

        public bool isInt()
        {
            ThrowIfDisposed();

            return dnn_DictValue_isInt_10(nativeObj);


        }


        //
        // C++:  bool cv::dnn::DictValue::isString()
        //

        public bool isString()
        {
            ThrowIfDisposed();

            return dnn_DictValue_isString_10(nativeObj);


        }


        //
        // C++:  bool cv::dnn::DictValue::isReal()
        //

        public bool isReal()
        {
            ThrowIfDisposed();

            return dnn_DictValue_isReal_10(nativeObj);


        }


        //
        // C++:  int cv::dnn::DictValue::getIntValue(int idx = -1)
        //

        public int getIntValue(int idx)
        {
            ThrowIfDisposed();

            return dnn_DictValue_getIntValue_10(nativeObj, idx);


        }

        public int getIntValue()
        {
            ThrowIfDisposed();

            return dnn_DictValue_getIntValue_11(nativeObj);


        }


        //
        // C++:  double cv::dnn::DictValue::getRealValue(int idx = -1)
        //

        public double getRealValue(int idx)
        {
            ThrowIfDisposed();

            return dnn_DictValue_getRealValue_10(nativeObj, idx);


        }

        public double getRealValue()
        {
            ThrowIfDisposed();

            return dnn_DictValue_getRealValue_11(nativeObj);


        }


        //
        // C++:  String cv::dnn::DictValue::getStringValue(int idx = -1)
        //

        public string getStringValue(int idx)
        {
            ThrowIfDisposed();

            string retVal = Marshal.PtrToStringAnsi(DisposableObject.ThrowIfNullIntPtr(dnn_DictValue_getStringValue_10(nativeObj, idx)));

            return retVal;
        }

        public string getStringValue()
        {
            ThrowIfDisposed();

            string retVal = Marshal.PtrToStringAnsi(DisposableObject.ThrowIfNullIntPtr(dnn_DictValue_getStringValue_11(nativeObj)));

            return retVal;
        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:   cv::dnn::DictValue::DictValue(int i)
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_DictValue_DictValue_10(int i);

        // C++:   cv::dnn::DictValue::DictValue(double p)
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_DictValue_DictValue_11(double p);

        // C++:   cv::dnn::DictValue::DictValue(String s)
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_DictValue_DictValue_12(string s);

        // C++:  bool cv::dnn::DictValue::isInt()
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool dnn_DictValue_isInt_10(IntPtr nativeObj);

        // C++:  bool cv::dnn::DictValue::isString()
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool dnn_DictValue_isString_10(IntPtr nativeObj);

        // C++:  bool cv::dnn::DictValue::isReal()
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool dnn_DictValue_isReal_10(IntPtr nativeObj);

        // C++:  int cv::dnn::DictValue::getIntValue(int idx = -1)
        [DllImport(LIBNAME)]
        private static extern int dnn_DictValue_getIntValue_10(IntPtr nativeObj, int idx);
        [DllImport(LIBNAME)]
        private static extern int dnn_DictValue_getIntValue_11(IntPtr nativeObj);

        // C++:  double cv::dnn::DictValue::getRealValue(int idx = -1)
        [DllImport(LIBNAME)]
        private static extern double dnn_DictValue_getRealValue_10(IntPtr nativeObj, int idx);
        [DllImport(LIBNAME)]
        private static extern double dnn_DictValue_getRealValue_11(IntPtr nativeObj);

        // C++:  String cv::dnn::DictValue::getStringValue(int idx = -1)
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_DictValue_getStringValue_10(IntPtr nativeObj, int idx);
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_DictValue_getStringValue_11(IntPtr nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void dnn_DictValue_delete(IntPtr nativeObj);

    }
}

#endif