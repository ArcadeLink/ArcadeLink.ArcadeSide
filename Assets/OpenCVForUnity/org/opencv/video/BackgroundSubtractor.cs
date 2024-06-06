
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.VideoModule
{

    // C++: class BackgroundSubtractor
    /**
     * Base class for background/foreground segmentation. :
     *
     * The class is only used to define the common interface for the whole family of background/foreground
     * segmentation algorithms.
     */

    public class BackgroundSubtractor : Algorithm
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
                        video_BackgroundSubtractor_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal BackgroundSubtractor(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new BackgroundSubtractor __fromPtr__(IntPtr addr) { return new BackgroundSubtractor(addr); }

        //
        // C++:  void cv::BackgroundSubtractor::apply(Mat image, Mat& fgmask, double learningRate = -1)
        //

        /**
         * Computes a foreground mask.
         *
         *     param image Next video frame.
         *     param fgmask The output foreground mask as an 8-bit binary image.
         *     param learningRate The value between 0 and 1 that indicates how fast the background model is
         *     learnt. Negative parameter value makes the algorithm to use some automatically chosen learning
         *     rate. 0 means that the background model is not updated at all, 1 means that the background model
         *     is completely reinitialized from the last frame.
         */
        public virtual void apply(Mat image, Mat fgmask, double learningRate)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (fgmask != null) fgmask.ThrowIfDisposed();

            video_BackgroundSubtractor_apply_10(nativeObj, image.nativeObj, fgmask.nativeObj, learningRate);


        }

        /**
         * Computes a foreground mask.
         *
         *     param image Next video frame.
         *     param fgmask The output foreground mask as an 8-bit binary image.
         *     learnt. Negative parameter value makes the algorithm to use some automatically chosen learning
         *     rate. 0 means that the background model is not updated at all, 1 means that the background model
         *     is completely reinitialized from the last frame.
         */
        public virtual void apply(Mat image, Mat fgmask)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (fgmask != null) fgmask.ThrowIfDisposed();

            video_BackgroundSubtractor_apply_11(nativeObj, image.nativeObj, fgmask.nativeObj);


        }


        //
        // C++:  void cv::BackgroundSubtractor::getBackgroundImage(Mat& backgroundImage)
        //

        /**
         * Computes a background image.
         *
         *     param backgroundImage The output background image.
         *
         *     <b>Note:</b> Sometimes the background image can be very blurry, as it contain the average background
         *     statistics.
         */
        public virtual void getBackgroundImage(Mat backgroundImage)
        {
            ThrowIfDisposed();
            if (backgroundImage != null) backgroundImage.ThrowIfDisposed();

            video_BackgroundSubtractor_getBackgroundImage_10(nativeObj, backgroundImage.nativeObj);


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  void cv::BackgroundSubtractor::apply(Mat image, Mat& fgmask, double learningRate = -1)
        [DllImport(LIBNAME)]
        private static extern void video_BackgroundSubtractor_apply_10(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr fgmask_nativeObj, double learningRate);
        [DllImport(LIBNAME)]
        private static extern void video_BackgroundSubtractor_apply_11(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr fgmask_nativeObj);

        // C++:  void cv::BackgroundSubtractor::getBackgroundImage(Mat& backgroundImage)
        [DllImport(LIBNAME)]
        private static extern void video_BackgroundSubtractor_getBackgroundImage_10(IntPtr nativeObj, IntPtr backgroundImage_nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void video_BackgroundSubtractor_delete(IntPtr nativeObj);

    }
}
