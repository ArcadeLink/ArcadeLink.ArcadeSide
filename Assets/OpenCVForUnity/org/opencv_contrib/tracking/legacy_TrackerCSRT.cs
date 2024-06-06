
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
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

    public class legacy_TrackerCSRT : legacy_Tracker
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
                        tracking_legacy_1TrackerCSRT_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal legacy_TrackerCSRT(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new legacy_TrackerCSRT __fromPtr__(IntPtr addr) { return new legacy_TrackerCSRT(addr); }

        //
        // C++: static Ptr_legacy_TrackerCSRT cv::legacy::TrackerCSRT::create()
        //

        /**
         * Constructor
         * return automatically generated
         */
        public static legacy_TrackerCSRT create()
        {


            return legacy_TrackerCSRT.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(tracking_legacy_1TrackerCSRT_create_10()));


        }


        //
        // C++:  void cv::legacy::TrackerCSRT::setInitialMask(Mat mask)
        //

        public void setInitialMask(Mat mask)
        {
            ThrowIfDisposed();
            if (mask != null) mask.ThrowIfDisposed();

            tracking_legacy_1TrackerCSRT_setInitialMask_10(nativeObj, mask.nativeObj);


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++: static Ptr_legacy_TrackerCSRT cv::legacy::TrackerCSRT::create()
        [DllImport(LIBNAME)]
        private static extern IntPtr tracking_legacy_1TrackerCSRT_create_10();

        // C++:  void cv::legacy::TrackerCSRT::setInitialMask(Mat mask)
        [DllImport(LIBNAME)]
        private static extern void tracking_legacy_1TrackerCSRT_setInitialMask_10(IntPtr nativeObj, IntPtr mask_nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void tracking_legacy_1TrackerCSRT_delete(IntPtr nativeObj);

    }
}
