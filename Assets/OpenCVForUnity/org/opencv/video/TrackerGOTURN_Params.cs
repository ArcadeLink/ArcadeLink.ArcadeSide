

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.VideoModule
{
    // C++: class Params


    public class TrackerGOTURN_Params : DisposableOpenCVObject
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
                        video_TrackerGOTURN_1Params_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal TrackerGOTURN_Params(IntPtr addr) : base(addr) { }


        public IntPtr getNativeObjAddr() { return nativeObj; }

        // internal usage only
        public static TrackerGOTURN_Params __fromPtr__(IntPtr addr) { return new TrackerGOTURN_Params(addr); }

        //
        // C++:   cv::TrackerGOTURN::Params::Params()
        //

        public TrackerGOTURN_Params()
        {


            nativeObj = DisposableObject.ThrowIfNullIntPtr(video_TrackerGOTURN_1Params_TrackerGOTURN_1Params_10());


        }


        //
        // C++: string TrackerGOTURN_Params::modelTxt
        //

        public string get_modelTxt()
        {
            ThrowIfDisposed();

            string retVal = Marshal.PtrToStringAnsi(DisposableObject.ThrowIfNullIntPtr(video_TrackerGOTURN_1Params_get_1modelTxt_10(nativeObj)));

            return retVal;
        }


        //
        // C++: void TrackerGOTURN_Params::modelTxt
        //

        public void set_modelTxt(string modelTxt)
        {
            ThrowIfDisposed();

            video_TrackerGOTURN_1Params_set_1modelTxt_10(nativeObj, modelTxt);


        }


        //
        // C++: string TrackerGOTURN_Params::modelBin
        //

        public string get_modelBin()
        {
            ThrowIfDisposed();

            string retVal = Marshal.PtrToStringAnsi(DisposableObject.ThrowIfNullIntPtr(video_TrackerGOTURN_1Params_get_1modelBin_10(nativeObj)));

            return retVal;
        }


        //
        // C++: void TrackerGOTURN_Params::modelBin
        //

        public void set_modelBin(string modelBin)
        {
            ThrowIfDisposed();

            video_TrackerGOTURN_1Params_set_1modelBin_10(nativeObj, modelBin);


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:   cv::TrackerGOTURN::Params::Params()
        [DllImport(LIBNAME)]
        private static extern IntPtr video_TrackerGOTURN_1Params_TrackerGOTURN_1Params_10();

        // C++: string TrackerGOTURN_Params::modelTxt
        [DllImport(LIBNAME)]
        private static extern IntPtr video_TrackerGOTURN_1Params_get_1modelTxt_10(IntPtr nativeObj);

        // C++: void TrackerGOTURN_Params::modelTxt
        [DllImport(LIBNAME)]
        private static extern void video_TrackerGOTURN_1Params_set_1modelTxt_10(IntPtr nativeObj, string modelTxt);

        // C++: string TrackerGOTURN_Params::modelBin
        [DllImport(LIBNAME)]
        private static extern IntPtr video_TrackerGOTURN_1Params_get_1modelBin_10(IntPtr nativeObj);

        // C++: void TrackerGOTURN_Params::modelBin
        [DllImport(LIBNAME)]
        private static extern void video_TrackerGOTURN_1Params_set_1modelBin_10(IntPtr nativeObj, string modelBin);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void video_TrackerGOTURN_1Params_delete(IntPtr nativeObj);

    }
}
