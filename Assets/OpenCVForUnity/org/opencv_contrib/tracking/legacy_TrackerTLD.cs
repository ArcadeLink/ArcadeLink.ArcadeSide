
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.TrackingModule
{

    // C++: class TrackerTLD
    /**
     * the TLD (Tracking, learning and detection) tracker
     *
     * TLD is a novel tracking framework that explicitly decomposes the long-term tracking task into
     * tracking, learning and detection.
     *
     * The tracker follows the object from frame to frame. The detector localizes all appearances that
     * have been observed so far and corrects the tracker if necessary. The learning estimates detector's
     * errors and updates it to avoid these errors in the future. The implementation is based on CITE: TLD .
     *
     * The Median Flow algorithm (see cv::TrackerMedianFlow) was chosen as a tracking component in this
     * implementation, following authors. The tracker is supposed to be able to handle rapid motions, partial
     * occlusions, object absence etc.
     */

    public class legacy_TrackerTLD : legacy_Tracker
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
                        tracking_legacy_1TrackerTLD_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal legacy_TrackerTLD(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new legacy_TrackerTLD __fromPtr__(IntPtr addr) { return new legacy_TrackerTLD(addr); }

        //
        // C++: static Ptr_legacy_TrackerTLD cv::legacy::TrackerTLD::create()
        //

        /**
         * Constructor
         * return automatically generated
         */
        public static legacy_TrackerTLD create()
        {


            return legacy_TrackerTLD.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(tracking_legacy_1TrackerTLD_create_10()));


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++: static Ptr_legacy_TrackerTLD cv::legacy::TrackerTLD::create()
        [DllImport(LIBNAME)]
        private static extern IntPtr tracking_legacy_1TrackerTLD_create_10();

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void tracking_legacy_1TrackerTLD_delete(IntPtr nativeObj);

    }
}
