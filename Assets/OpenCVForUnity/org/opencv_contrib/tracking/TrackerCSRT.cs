
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using OpenCVForUnity.VideoModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.TrackingModule
{

    // C++: class TrackerCSRT
    /**
     * the CSRT tracker
     *
     * The implementation is based on CITE: Lukezic_IJCV2018 Discriminative Correlation Filter with Channel and Spatial Reliability
     */

    public class TrackerCSRT : Tracker
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
                        tracking_TrackerCSRT_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal TrackerCSRT(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new TrackerCSRT __fromPtr__(IntPtr addr) { return new TrackerCSRT(addr); }

        //
        // C++: static Ptr_TrackerCSRT cv::TrackerCSRT::create(TrackerCSRT_Params parameters = TrackerCSRT::Params())
        //

        /**
         * Create CSRT tracker instance
         *     param parameters CSRT parameters TrackerCSRT::Params
         * return automatically generated
         */
        public static TrackerCSRT create(TrackerCSRT_Params parameters)
        {
            if (parameters != null) parameters.ThrowIfDisposed();

            return TrackerCSRT.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(tracking_TrackerCSRT_create_10(parameters.nativeObj)));


        }

        /**
         * Create CSRT tracker instance
         * return automatically generated
         */
        public static TrackerCSRT create()
        {


            return TrackerCSRT.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(tracking_TrackerCSRT_create_11()));


        }


        //
        // C++:  void cv::TrackerCSRT::setInitialMask(Mat mask)
        //

        public void setInitialMask(Mat mask)
        {
            ThrowIfDisposed();
            if (mask != null) mask.ThrowIfDisposed();

            tracking_TrackerCSRT_setInitialMask_10(nativeObj, mask.nativeObj);


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++: static Ptr_TrackerCSRT cv::TrackerCSRT::create(TrackerCSRT_Params parameters = TrackerCSRT::Params())
        [DllImport(LIBNAME)]
        private static extern IntPtr tracking_TrackerCSRT_create_10(IntPtr parameters_nativeObj);
        [DllImport(LIBNAME)]
        private static extern IntPtr tracking_TrackerCSRT_create_11();

        // C++:  void cv::TrackerCSRT::setInitialMask(Mat mask)
        [DllImport(LIBNAME)]
        private static extern void tracking_TrackerCSRT_setInitialMask_10(IntPtr nativeObj, IntPtr mask_nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void tracking_TrackerCSRT_delete(IntPtr nativeObj);

    }
}
