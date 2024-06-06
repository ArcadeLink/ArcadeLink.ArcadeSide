
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.TrackingModule
{

    // C++: class TrackerBoosting
    /**
     * the Boosting tracker
     *
     * This is a real-time object tracking based on a novel on-line version of the AdaBoost algorithm.
     * The classifier uses the surrounding background as negative examples in update step to avoid the
     * drifting problem. The implementation is based on CITE: OLB .
     */

    public class legacy_TrackerBoosting : legacy_Tracker
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
                        tracking_legacy_1TrackerBoosting_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal legacy_TrackerBoosting(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new legacy_TrackerBoosting __fromPtr__(IntPtr addr) { return new legacy_TrackerBoosting(addr); }

        //
        // C++: static Ptr_legacy_TrackerBoosting cv::legacy::TrackerBoosting::create()
        //

        /**
         * Constructor
         * return automatically generated
         */
        public static legacy_TrackerBoosting create()
        {


            return legacy_TrackerBoosting.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(tracking_legacy_1TrackerBoosting_create_10()));


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++: static Ptr_legacy_TrackerBoosting cv::legacy::TrackerBoosting::create()
        [DllImport(LIBNAME)]
        private static extern IntPtr tracking_legacy_1TrackerBoosting_create_10();

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void tracking_legacy_1TrackerBoosting_delete(IntPtr nativeObj);

    }
}
