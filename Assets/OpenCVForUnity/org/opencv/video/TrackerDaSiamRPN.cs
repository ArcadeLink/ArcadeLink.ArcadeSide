
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.VideoModule
{

    // C++: class TrackerDaSiamRPN


    public class TrackerDaSiamRPN : Tracker
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
                        video_TrackerDaSiamRPN_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal TrackerDaSiamRPN(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new TrackerDaSiamRPN __fromPtr__(IntPtr addr) { return new TrackerDaSiamRPN(addr); }

        //
        // C++: static Ptr_TrackerDaSiamRPN cv::TrackerDaSiamRPN::create(TrackerDaSiamRPN_Params parameters = TrackerDaSiamRPN::Params())
        //

        /**
         * Constructor
         *     param parameters DaSiamRPN parameters TrackerDaSiamRPN::Params
         * return automatically generated
         */
        public static TrackerDaSiamRPN create(TrackerDaSiamRPN_Params parameters)
        {
            if (parameters != null) parameters.ThrowIfDisposed();

            return TrackerDaSiamRPN.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(video_TrackerDaSiamRPN_create_10(parameters.nativeObj)));


        }

        /**
         * Constructor
         * return automatically generated
         */
        public static TrackerDaSiamRPN create()
        {


            return TrackerDaSiamRPN.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(video_TrackerDaSiamRPN_create_11()));


        }


        //
        // C++:  float cv::TrackerDaSiamRPN::getTrackingScore()
        //

        /**
         * Return tracking score
         * return automatically generated
         */
        public float getTrackingScore()
        {
            ThrowIfDisposed();

            return video_TrackerDaSiamRPN_getTrackingScore_10(nativeObj);


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++: static Ptr_TrackerDaSiamRPN cv::TrackerDaSiamRPN::create(TrackerDaSiamRPN_Params parameters = TrackerDaSiamRPN::Params())
        [DllImport(LIBNAME)]
        private static extern IntPtr video_TrackerDaSiamRPN_create_10(IntPtr parameters_nativeObj);
        [DllImport(LIBNAME)]
        private static extern IntPtr video_TrackerDaSiamRPN_create_11();

        // C++:  float cv::TrackerDaSiamRPN::getTrackingScore()
        [DllImport(LIBNAME)]
        private static extern float video_TrackerDaSiamRPN_getTrackingScore_10(IntPtr nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void video_TrackerDaSiamRPN_delete(IntPtr nativeObj);

    }
}
