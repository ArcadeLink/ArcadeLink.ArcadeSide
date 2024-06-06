

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.VideoModule
{
    // C++: class Params


    public class TrackerDaSiamRPN_Params : DisposableOpenCVObject
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
                        video_TrackerDaSiamRPN_1Params_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal TrackerDaSiamRPN_Params(IntPtr addr) : base(addr) { }


        public IntPtr getNativeObjAddr() { return nativeObj; }

        // internal usage only
        public static TrackerDaSiamRPN_Params __fromPtr__(IntPtr addr) { return new TrackerDaSiamRPN_Params(addr); }

        //
        // C++:   cv::TrackerDaSiamRPN::Params::Params()
        //

        public TrackerDaSiamRPN_Params()
        {


            nativeObj = DisposableObject.ThrowIfNullIntPtr(video_TrackerDaSiamRPN_1Params_TrackerDaSiamRPN_1Params_10());


        }


        //
        // C++: string TrackerDaSiamRPN_Params::model
        //

        public string get_model()
        {
            ThrowIfDisposed();

            string retVal = Marshal.PtrToStringAnsi(DisposableObject.ThrowIfNullIntPtr(video_TrackerDaSiamRPN_1Params_get_1model_10(nativeObj)));

            return retVal;
        }


        //
        // C++: void TrackerDaSiamRPN_Params::model
        //

        public void set_model(string model)
        {
            ThrowIfDisposed();

            video_TrackerDaSiamRPN_1Params_set_1model_10(nativeObj, model);


        }


        //
        // C++: string TrackerDaSiamRPN_Params::kernel_cls1
        //

        public string get_kernel_cls1()
        {
            ThrowIfDisposed();

            string retVal = Marshal.PtrToStringAnsi(DisposableObject.ThrowIfNullIntPtr(video_TrackerDaSiamRPN_1Params_get_1kernel_1cls1_10(nativeObj)));

            return retVal;
        }


        //
        // C++: void TrackerDaSiamRPN_Params::kernel_cls1
        //

        public void set_kernel_cls1(string kernel_cls1)
        {
            ThrowIfDisposed();

            video_TrackerDaSiamRPN_1Params_set_1kernel_1cls1_10(nativeObj, kernel_cls1);


        }


        //
        // C++: string TrackerDaSiamRPN_Params::kernel_r1
        //

        public string get_kernel_r1()
        {
            ThrowIfDisposed();

            string retVal = Marshal.PtrToStringAnsi(DisposableObject.ThrowIfNullIntPtr(video_TrackerDaSiamRPN_1Params_get_1kernel_1r1_10(nativeObj)));

            return retVal;
        }


        //
        // C++: void TrackerDaSiamRPN_Params::kernel_r1
        //

        public void set_kernel_r1(string kernel_r1)
        {
            ThrowIfDisposed();

            video_TrackerDaSiamRPN_1Params_set_1kernel_1r1_10(nativeObj, kernel_r1);


        }


        //
        // C++: int TrackerDaSiamRPN_Params::backend
        //

        public int get_backend()
        {
            ThrowIfDisposed();

            return video_TrackerDaSiamRPN_1Params_get_1backend_10(nativeObj);


        }


        //
        // C++: void TrackerDaSiamRPN_Params::backend
        //

        public void set_backend(int backend)
        {
            ThrowIfDisposed();

            video_TrackerDaSiamRPN_1Params_set_1backend_10(nativeObj, backend);


        }


        //
        // C++: int TrackerDaSiamRPN_Params::target
        //

        public int get_target()
        {
            ThrowIfDisposed();

            return video_TrackerDaSiamRPN_1Params_get_1target_10(nativeObj);


        }


        //
        // C++: void TrackerDaSiamRPN_Params::target
        //

        public void set_target(int target)
        {
            ThrowIfDisposed();

            video_TrackerDaSiamRPN_1Params_set_1target_10(nativeObj, target);


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:   cv::TrackerDaSiamRPN::Params::Params()
        [DllImport(LIBNAME)]
        private static extern IntPtr video_TrackerDaSiamRPN_1Params_TrackerDaSiamRPN_1Params_10();

        // C++: string TrackerDaSiamRPN_Params::model
        [DllImport(LIBNAME)]
        private static extern IntPtr video_TrackerDaSiamRPN_1Params_get_1model_10(IntPtr nativeObj);

        // C++: void TrackerDaSiamRPN_Params::model
        [DllImport(LIBNAME)]
        private static extern void video_TrackerDaSiamRPN_1Params_set_1model_10(IntPtr nativeObj, string model);

        // C++: string TrackerDaSiamRPN_Params::kernel_cls1
        [DllImport(LIBNAME)]
        private static extern IntPtr video_TrackerDaSiamRPN_1Params_get_1kernel_1cls1_10(IntPtr nativeObj);

        // C++: void TrackerDaSiamRPN_Params::kernel_cls1
        [DllImport(LIBNAME)]
        private static extern void video_TrackerDaSiamRPN_1Params_set_1kernel_1cls1_10(IntPtr nativeObj, string kernel_cls1);

        // C++: string TrackerDaSiamRPN_Params::kernel_r1
        [DllImport(LIBNAME)]
        private static extern IntPtr video_TrackerDaSiamRPN_1Params_get_1kernel_1r1_10(IntPtr nativeObj);

        // C++: void TrackerDaSiamRPN_Params::kernel_r1
        [DllImport(LIBNAME)]
        private static extern void video_TrackerDaSiamRPN_1Params_set_1kernel_1r1_10(IntPtr nativeObj, string kernel_r1);

        // C++: int TrackerDaSiamRPN_Params::backend
        [DllImport(LIBNAME)]
        private static extern int video_TrackerDaSiamRPN_1Params_get_1backend_10(IntPtr nativeObj);

        // C++: void TrackerDaSiamRPN_Params::backend
        [DllImport(LIBNAME)]
        private static extern void video_TrackerDaSiamRPN_1Params_set_1backend_10(IntPtr nativeObj, int backend);

        // C++: int TrackerDaSiamRPN_Params::target
        [DllImport(LIBNAME)]
        private static extern int video_TrackerDaSiamRPN_1Params_get_1target_10(IntPtr nativeObj);

        // C++: void TrackerDaSiamRPN_Params::target
        [DllImport(LIBNAME)]
        private static extern void video_TrackerDaSiamRPN_1Params_set_1target_10(IntPtr nativeObj, int target);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void video_TrackerDaSiamRPN_1Params_delete(IntPtr nativeObj);

    }
}
