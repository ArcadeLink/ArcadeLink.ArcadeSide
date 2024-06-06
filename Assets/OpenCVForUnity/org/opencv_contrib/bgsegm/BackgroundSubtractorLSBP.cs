
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using OpenCVForUnity.VideoModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.BgsegmModule
{

    // C++: class BackgroundSubtractorLSBP
    /**
     * Background Subtraction using Local SVD Binary Pattern. More details about the algorithm can be found at CITE: LGuo2016
     */

    public class BackgroundSubtractorLSBP : BackgroundSubtractor
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
                        bgsegm_BackgroundSubtractorLSBP_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal BackgroundSubtractorLSBP(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new BackgroundSubtractorLSBP __fromPtr__(IntPtr addr) { return new BackgroundSubtractorLSBP(addr); }

        //
        // C++:  void cv::bgsegm::BackgroundSubtractorLSBP::apply(Mat image, Mat& fgmask, double learningRate = -1)
        //

        public override void apply(Mat image, Mat fgmask, double learningRate)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (fgmask != null) fgmask.ThrowIfDisposed();

            bgsegm_BackgroundSubtractorLSBP_apply_10(nativeObj, image.nativeObj, fgmask.nativeObj, learningRate);


        }

        public override void apply(Mat image, Mat fgmask)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (fgmask != null) fgmask.ThrowIfDisposed();

            bgsegm_BackgroundSubtractorLSBP_apply_11(nativeObj, image.nativeObj, fgmask.nativeObj);


        }


        //
        // C++:  void cv::bgsegm::BackgroundSubtractorLSBP::getBackgroundImage(Mat& backgroundImage)
        //

        public override void getBackgroundImage(Mat backgroundImage)
        {
            ThrowIfDisposed();
            if (backgroundImage != null) backgroundImage.ThrowIfDisposed();

            bgsegm_BackgroundSubtractorLSBP_getBackgroundImage_10(nativeObj, backgroundImage.nativeObj);


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  void cv::bgsegm::BackgroundSubtractorLSBP::apply(Mat image, Mat& fgmask, double learningRate = -1)
        [DllImport(LIBNAME)]
        private static extern void bgsegm_BackgroundSubtractorLSBP_apply_10(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr fgmask_nativeObj, double learningRate);
        [DllImport(LIBNAME)]
        private static extern void bgsegm_BackgroundSubtractorLSBP_apply_11(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr fgmask_nativeObj);

        // C++:  void cv::bgsegm::BackgroundSubtractorLSBP::getBackgroundImage(Mat& backgroundImage)
        [DllImport(LIBNAME)]
        private static extern void bgsegm_BackgroundSubtractorLSBP_getBackgroundImage_10(IntPtr nativeObj, IntPtr backgroundImage_nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void bgsegm_BackgroundSubtractorLSBP_delete(IntPtr nativeObj);

    }
}
