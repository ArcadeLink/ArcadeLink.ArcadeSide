

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.VideoModule
{
    // C++: class Tracker
    /**
     * Base abstract class for the long-term tracker
     */

    public class Tracker : DisposableOpenCVObject
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
                        video_Tracker_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal Tracker(IntPtr addr) : base(addr) { }


        public IntPtr getNativeObjAddr() { return nativeObj; }

        // internal usage only
        public static Tracker __fromPtr__(IntPtr addr) { return new Tracker(addr); }

        //
        // C++:  void cv::Tracker::init(Mat image, Rect boundingBox)
        //

        /**
         * Initialize the tracker with a known bounding box that surrounded the target
         *     param image The initial frame
         *     param boundingBox The initial bounding box
         */
        public void init(Mat image, Rect boundingBox)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();

            video_Tracker_init_10(nativeObj, image.nativeObj, boundingBox.x, boundingBox.y, boundingBox.width, boundingBox.height);


        }


        //
        // C++:  bool cv::Tracker::update(Mat image, Rect& boundingBox)
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
        public bool update(Mat image, Rect boundingBox)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            double[] boundingBox_out = new double[4];
            bool retVal = video_Tracker_update_10(nativeObj, image.nativeObj, boundingBox_out);
            if (boundingBox != null) { boundingBox.x = (int)boundingBox_out[0]; boundingBox.y = (int)boundingBox_out[1]; boundingBox.width = (int)boundingBox_out[2]; boundingBox.height = (int)boundingBox_out[3]; }
            return retVal;
        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  void cv::Tracker::init(Mat image, Rect boundingBox)
        [DllImport(LIBNAME)]
        private static extern void video_Tracker_init_10(IntPtr nativeObj, IntPtr image_nativeObj, int boundingBox_x, int boundingBox_y, int boundingBox_width, int boundingBox_height);

        // C++:  bool cv::Tracker::update(Mat image, Rect& boundingBox)
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool video_Tracker_update_10(IntPtr nativeObj, IntPtr image_nativeObj, double[] boundingBox_out);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void video_Tracker_delete(IntPtr nativeObj);

    }
}
