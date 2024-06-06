

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.VideoModule
{
    // C++: class Params


    public class TrackerNano_Params : DisposableOpenCVObject
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
                        video_TrackerNano_1Params_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal TrackerNano_Params(IntPtr addr) : base(addr) { }


        public IntPtr getNativeObjAddr() { return nativeObj; }

        // internal usage only
        public static TrackerNano_Params __fromPtr__(IntPtr addr) { return new TrackerNano_Params(addr); }

        //
        // C++:   cv::TrackerNano::Params::Params()
        //

        public TrackerNano_Params()
        {


            nativeObj = DisposableObject.ThrowIfNullIntPtr(video_TrackerNano_1Params_TrackerNano_1Params_10());


        }


        //
        // C++: string TrackerNano_Params::backbone
        //

        public string get_backbone()
        {
            ThrowIfDisposed();

            string retVal = Marshal.PtrToStringAnsi(DisposableObject.ThrowIfNullIntPtr(video_TrackerNano_1Params_get_1backbone_10(nativeObj)));

            return retVal;
        }


        //
        // C++: void TrackerNano_Params::backbone
        //

        public void set_backbone(string backbone)
        {
            ThrowIfDisposed();

            video_TrackerNano_1Params_set_1backbone_10(nativeObj, backbone);


        }


        //
        // C++: string TrackerNano_Params::neckhead
        //

        public string get_neckhead()
        {
            ThrowIfDisposed();

            string retVal = Marshal.PtrToStringAnsi(DisposableObject.ThrowIfNullIntPtr(video_TrackerNano_1Params_get_1neckhead_10(nativeObj)));

            return retVal;
        }


        //
        // C++: void TrackerNano_Params::neckhead
        //

        public void set_neckhead(string neckhead)
        {
            ThrowIfDisposed();

            video_TrackerNano_1Params_set_1neckhead_10(nativeObj, neckhead);


        }


        //
        // C++: int TrackerNano_Params::backend
        //

        public int get_backend()
        {
            ThrowIfDisposed();

            return video_TrackerNano_1Params_get_1backend_10(nativeObj);


        }


        //
        // C++: void TrackerNano_Params::backend
        //

        public void set_backend(int backend)
        {
            ThrowIfDisposed();

            video_TrackerNano_1Params_set_1backend_10(nativeObj, backend);


        }


        //
        // C++: int TrackerNano_Params::target
        //

        public int get_target()
        {
            ThrowIfDisposed();

            return video_TrackerNano_1Params_get_1target_10(nativeObj);


        }


        //
        // C++: void TrackerNano_Params::target
        //

        public void set_target(int target)
        {
            ThrowIfDisposed();

            video_TrackerNano_1Params_set_1target_10(nativeObj, target);


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:   cv::TrackerNano::Params::Params()
        [DllImport(LIBNAME)]
        private static extern IntPtr video_TrackerNano_1Params_TrackerNano_1Params_10();

        // C++: string TrackerNano_Params::backbone
        [DllImport(LIBNAME)]
        private static extern IntPtr video_TrackerNano_1Params_get_1backbone_10(IntPtr nativeObj);

        // C++: void TrackerNano_Params::backbone
        [DllImport(LIBNAME)]
        private static extern void video_TrackerNano_1Params_set_1backbone_10(IntPtr nativeObj, string backbone);

        // C++: string TrackerNano_Params::neckhead
        [DllImport(LIBNAME)]
        private static extern IntPtr video_TrackerNano_1Params_get_1neckhead_10(IntPtr nativeObj);

        // C++: void TrackerNano_Params::neckhead
        [DllImport(LIBNAME)]
        private static extern void video_TrackerNano_1Params_set_1neckhead_10(IntPtr nativeObj, string neckhead);

        // C++: int TrackerNano_Params::backend
        [DllImport(LIBNAME)]
        private static extern int video_TrackerNano_1Params_get_1backend_10(IntPtr nativeObj);

        // C++: void TrackerNano_Params::backend
        [DllImport(LIBNAME)]
        private static extern void video_TrackerNano_1Params_set_1backend_10(IntPtr nativeObj, int backend);

        // C++: int TrackerNano_Params::target
        [DllImport(LIBNAME)]
        private static extern int video_TrackerNano_1Params_get_1target_10(IntPtr nativeObj);

        // C++: void TrackerNano_Params::target
        [DllImport(LIBNAME)]
        private static extern void video_TrackerNano_1Params_set_1target_10(IntPtr nativeObj, int target);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void video_TrackerNano_1Params_delete(IntPtr nativeObj);

    }
}
