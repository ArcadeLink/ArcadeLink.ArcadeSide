
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.TrackingModule
{

    // C++: class TrackerMOSSE
    /**
     * the MOSSE (Minimum Output Sum of Squared %Error) tracker
     *
     * The implementation is based on CITE: MOSSE Visual Object Tracking using Adaptive Correlation Filters
     * <b>Note:</b> this tracker works with grayscale images, if passed bgr ones, they will get converted internally.
     */

    public class legacy_TrackerMOSSE : legacy_Tracker
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
                        tracking_legacy_1TrackerMOSSE_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal legacy_TrackerMOSSE(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new legacy_TrackerMOSSE __fromPtr__(IntPtr addr) { return new legacy_TrackerMOSSE(addr); }

        //
        // C++: static Ptr_legacy_TrackerMOSSE cv::legacy::TrackerMOSSE::create()
        //

        /**
         * Constructor
         * return automatically generated
         */
        public static legacy_TrackerMOSSE create()
        {


            return legacy_TrackerMOSSE.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(tracking_legacy_1TrackerMOSSE_create_10()));


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++: static Ptr_legacy_TrackerMOSSE cv::legacy::TrackerMOSSE::create()
        [DllImport(LIBNAME)]
        private static extern IntPtr tracking_legacy_1TrackerMOSSE_create_10();

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void tracking_legacy_1TrackerMOSSE_delete(IntPtr nativeObj);

    }
}
