
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.TrackingModule
{

    // C++: class MultiTracker
    /**
     * This class is used to track multiple objects using the specified tracker algorithm.
     *
     * The %MultiTracker is naive implementation of multiple object tracking.
     * It process the tracked objects independently without any optimization accross the tracked objects.
     */

    public class legacy_MultiTracker : Algorithm
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
                        tracking_legacy_1MultiTracker_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal legacy_MultiTracker(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new legacy_MultiTracker __fromPtr__(IntPtr addr) { return new legacy_MultiTracker(addr); }

        //
        // C++:   cv::legacy::MultiTracker::MultiTracker()
        //

        /**
         * Constructor.
         */
        public legacy_MultiTracker() :
            base(DisposableObject.ThrowIfNullIntPtr(tracking_legacy_1MultiTracker_legacy_1MultiTracker_10()))
        {



        }


        //
        // C++:  bool cv::legacy::MultiTracker::add(Ptr_legacy_Tracker newTracker, Mat image, Rect2d boundingBox)
        //

        /**
         * Add a new object to be tracked.
         *
         * param newTracker tracking algorithm to be used
         * param image input image
         * param boundingBox a rectangle represents ROI of the tracked object
         * return automatically generated
         */
        public bool add(legacy_Tracker newTracker, Mat image, Rect2d boundingBox)
        {
            ThrowIfDisposed();
            if (newTracker != null) newTracker.ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();

            return tracking_legacy_1MultiTracker_add_10(nativeObj, newTracker.getNativeObjAddr(), image.nativeObj, boundingBox.x, boundingBox.y, boundingBox.width, boundingBox.height);


        }


        //
        // C++:  bool cv::legacy::MultiTracker::update(Mat image, vector_Rect2d& boundingBox)
        //

        /**
         * Update the current tracking status.
         * param image input image
         * param boundingBox the tracking result, represent a list of ROIs of the tracked objects.
         * return automatically generated
         */
        public bool update(Mat image, MatOfRect2d boundingBox)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (boundingBox != null) boundingBox.ThrowIfDisposed();
            Mat boundingBox_mat = boundingBox;
            return tracking_legacy_1MultiTracker_update_10(nativeObj, image.nativeObj, boundingBox_mat.nativeObj);


        }


        //
        // C++:  vector_Rect2d cv::legacy::MultiTracker::getObjects()
        //

        /**
         * Returns a reference to a storage for the tracked objects, each object corresponds to one tracker algorithm
         * return automatically generated
         */
        public MatOfRect2d getObjects()
        {
            ThrowIfDisposed();

            return MatOfRect2d.fromNativeAddr(DisposableObject.ThrowIfNullIntPtr(tracking_legacy_1MultiTracker_getObjects_10(nativeObj)));


        }


        //
        // C++: static Ptr_MultiTracker cv::legacy::MultiTracker::create()
        //

        // Return type 'Ptr_MultiTracker' is not supported, skipping the function


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:   cv::legacy::MultiTracker::MultiTracker()
        [DllImport(LIBNAME)]
        private static extern IntPtr tracking_legacy_1MultiTracker_legacy_1MultiTracker_10();

        // C++:  bool cv::legacy::MultiTracker::add(Ptr_legacy_Tracker newTracker, Mat image, Rect2d boundingBox)
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool tracking_legacy_1MultiTracker_add_10(IntPtr nativeObj, IntPtr newTracker_nativeObj, IntPtr image_nativeObj, double boundingBox_x, double boundingBox_y, double boundingBox_width, double boundingBox_height);

        // C++:  bool cv::legacy::MultiTracker::update(Mat image, vector_Rect2d& boundingBox)
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool tracking_legacy_1MultiTracker_update_10(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr boundingBox_mat_nativeObj);

        // C++:  vector_Rect2d cv::legacy::MultiTracker::getObjects()
        [DllImport(LIBNAME)]
        private static extern IntPtr tracking_legacy_1MultiTracker_getObjects_10(IntPtr nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void tracking_legacy_1MultiTracker_delete(IntPtr nativeObj);

    }
}
