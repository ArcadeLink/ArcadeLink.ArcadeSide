
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.TrackingModule
{

    // C++: class TrackerMIL
    /**
     * The MIL algorithm trains a classifier in an online manner to separate the object from the
     * background.
     *
     * Multiple Instance Learning avoids the drift problem for a robust tracking. The implementation is
     * based on CITE: MIL .
     *
     * Original code can be found here &lt;http://vision.ucsd.edu/~bbabenko/project_miltrack.shtml&gt;
     */

    public class legacy_TrackerMIL : legacy_Tracker
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
                        tracking_legacy_1TrackerMIL_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal legacy_TrackerMIL(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new legacy_TrackerMIL __fromPtr__(IntPtr addr) { return new legacy_TrackerMIL(addr); }

        //
        // C++: static Ptr_legacy_TrackerMIL cv::legacy::TrackerMIL::create()
        //

        /**
         * Constructor
         * return automatically generated
         */
        public static legacy_TrackerMIL create()
        {


            return legacy_TrackerMIL.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(tracking_legacy_1TrackerMIL_create_10()));


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++: static Ptr_legacy_TrackerMIL cv::legacy::TrackerMIL::create()
        [DllImport(LIBNAME)]
        private static extern IntPtr tracking_legacy_1TrackerMIL_create_10();

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void tracking_legacy_1TrackerMIL_delete(IntPtr nativeObj);

    }
}
