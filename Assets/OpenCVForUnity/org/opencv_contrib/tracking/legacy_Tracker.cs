
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.TrackingModule
{

    // C++: class Tracker
    /**
     * Base abstract class for the long-term tracker:
     */

    public class legacy_Tracker : Algorithm
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
                        tracking_legacy_1Tracker_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal legacy_Tracker(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new legacy_Tracker __fromPtr__(IntPtr addr) { return new legacy_Tracker(addr); }

        //
        // C++:  bool cv::legacy::Tracker::init(Mat image, Rect2d boundingBox)
        //

        /**
         * Initialize the tracker with a known bounding box that surrounded the target
         *     param image The initial frame
         *     param boundingBox The initial bounding box
         *
         *     return True if initialization went succesfully, false otherwise
         */
        public bool init(Mat image, Rect2d boundingBox)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();

            return tracking_legacy_1Tracker_init_10(nativeObj, image.nativeObj, boundingBox.x, boundingBox.y, boundingBox.width, boundingBox.height);


        }


        //
        // C++:  bool cv::legacy::Tracker::update(Mat image, Rect2d& boundingBox)
        //

        /**
         * Update the tracker, find the new most likely bounding box for the target
         *     param image The current frame
         *     param boundingBox The bounding box that represent the new target location, if true was returned, not
         *     modified otherwise
         *
         *     return True means that target was located and false means that tracker cannot locate target in
         *     current frame. Note, that latter *does not* imply that tracker has failed, maybe target is indeed
         *     missing from the frame (say, out of sight)
         */
        public bool update(Mat image, Rect2d boundingBox)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            double[] boundingBox_out = new double[4];
            bool retVal = tracking_legacy_1Tracker_update_10(nativeObj, image.nativeObj, boundingBox_out);
            if (boundingBox != null) { boundingBox.x = boundingBox_out[0]; boundingBox.y = boundingBox_out[1]; boundingBox.width = boundingBox_out[2]; boundingBox.height = boundingBox_out[3]; }
            return retVal;
        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  bool cv::legacy::Tracker::init(Mat image, Rect2d boundingBox)
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool tracking_legacy_1Tracker_init_10(IntPtr nativeObj, IntPtr image_nativeObj, double boundingBox_x, double boundingBox_y, double boundingBox_width, double boundingBox_height);

        // C++:  bool cv::legacy::Tracker::update(Mat image, Rect2d& boundingBox)
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool tracking_legacy_1Tracker_update_10(IntPtr nativeObj, IntPtr image_nativeObj, double[] boundingBox_out);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void tracking_legacy_1Tracker_delete(IntPtr nativeObj);

    }
}
