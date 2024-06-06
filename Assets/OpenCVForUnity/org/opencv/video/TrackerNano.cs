
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.VideoModule
{

    // C++: class TrackerNano
    /**
     * the Nano tracker is a super lightweight dnn-based general object tracking.
     *
     * Nano tracker is much faster and extremely lightweight due to special model structure, the whole model size is about 1.9 MB.
     * Nano tracker needs two models: one for feature extraction (backbone) and the another for localization (neckhead).
     * Model download link: https://github.com/HonglinChu/SiamTrackers/tree/master/NanoTrack/models/nanotrackv2
     * Original repo is here: https://github.com/HonglinChu/NanoTrack
     * Author: HongLinChu, 1628464345qq.com
     */

    public class TrackerNano : Tracker
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
                        video_TrackerNano_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal TrackerNano(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new TrackerNano __fromPtr__(IntPtr addr) { return new TrackerNano(addr); }

        //
        // C++: static Ptr_TrackerNano cv::TrackerNano::create(TrackerNano_Params parameters = TrackerNano::Params())
        //

        /**
         * Constructor
         *     param parameters NanoTrack parameters TrackerNano::Params
         * return automatically generated
         */
        public static TrackerNano create(TrackerNano_Params parameters)
        {
            if (parameters != null) parameters.ThrowIfDisposed();

            return TrackerNano.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(video_TrackerNano_create_10(parameters.nativeObj)));


        }

        /**
         * Constructor
         * return automatically generated
         */
        public static TrackerNano create()
        {


            return TrackerNano.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(video_TrackerNano_create_11()));


        }


        //
        // C++:  float cv::TrackerNano::getTrackingScore()
        //

        /**
         * Return tracking score
         * return automatically generated
         */
        public float getTrackingScore()
        {
            ThrowIfDisposed();

            return video_TrackerNano_getTrackingScore_10(nativeObj);


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++: static Ptr_TrackerNano cv::TrackerNano::create(TrackerNano_Params parameters = TrackerNano::Params())
        [DllImport(LIBNAME)]
        private static extern IntPtr video_TrackerNano_create_10(IntPtr parameters_nativeObj);
        [DllImport(LIBNAME)]
        private static extern IntPtr video_TrackerNano_create_11();

        // C++:  float cv::TrackerNano::getTrackingScore()
        [DllImport(LIBNAME)]
        private static extern float video_TrackerNano_getTrackingScore_10(IntPtr nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void video_TrackerNano_delete(IntPtr nativeObj);

    }
}
