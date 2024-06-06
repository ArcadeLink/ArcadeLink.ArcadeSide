
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.TrackingModule
{

    // C++: class TrackerMedianFlow
    /**
     * the Median Flow tracker
     *
     * Implementation of a paper CITE: MedianFlow .
     *
     * The tracker is suitable for very smooth and predictable movements when object is visible throughout
     * the whole sequence. It's quite and accurate for this type of problems (in particular, it was shown
     * by authors to outperform MIL). During the implementation period the code at
     * &lt;http://www.aonsquared.co.uk/node/5&gt;, the courtesy of the author Arthur Amarra, was used for the
     * reference purpose.
     */

    public class legacy_TrackerMedianFlow : legacy_Tracker
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
                        tracking_legacy_1TrackerMedianFlow_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal legacy_TrackerMedianFlow(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new legacy_TrackerMedianFlow __fromPtr__(IntPtr addr) { return new legacy_TrackerMedianFlow(addr); }

        //
        // C++: static Ptr_legacy_TrackerMedianFlow cv::legacy::TrackerMedianFlow::create()
        //

        /**
         * Constructor
         * return automatically generated
         */
        public static legacy_TrackerMedianFlow create()
        {


            return legacy_TrackerMedianFlow.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(tracking_legacy_1TrackerMedianFlow_create_10()));


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++: static Ptr_legacy_TrackerMedianFlow cv::legacy::TrackerMedianFlow::create()
        [DllImport(LIBNAME)]
        private static extern IntPtr tracking_legacy_1TrackerMedianFlow_create_10();

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void tracking_legacy_1TrackerMedianFlow_delete(IntPtr nativeObj);

    }
}
