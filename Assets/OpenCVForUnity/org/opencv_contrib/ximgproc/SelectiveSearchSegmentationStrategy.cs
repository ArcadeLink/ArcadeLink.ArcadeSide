
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.XimgprocModule
{

    // C++: class SelectiveSearchSegmentationStrategy
    /**
     * Strategie for the selective search segmentation algorithm
     *                         The class implements a generic stragery for the algorithm described in CITE: uijlings2013selective.
     */

    public class SelectiveSearchSegmentationStrategy : Algorithm
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
                        ximgproc_SelectiveSearchSegmentationStrategy_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal SelectiveSearchSegmentationStrategy(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new SelectiveSearchSegmentationStrategy __fromPtr__(IntPtr addr) { return new SelectiveSearchSegmentationStrategy(addr); }

        //
        // C++:  void cv::ximgproc::segmentation::SelectiveSearchSegmentationStrategy::setImage(Mat img, Mat regions, Mat sizes, int image_id = -1)
        //

        /**
         * Set a initial image, with a segmentation.
         *                                 param img The input image. Any number of channel can be provided
         *                                 param regions A segmentation of the image. The parameter must be the same size of img.
         *                                 param sizes The sizes of different regions
         *                                 param image_id If not set to -1, try to cache pre-computations. If the same set og (img, regions, size) is used, the image_id need to be the same.
         */
        public void setImage(Mat img, Mat regions, Mat sizes, int image_id)
        {
            ThrowIfDisposed();
            if (img != null) img.ThrowIfDisposed();
            if (regions != null) regions.ThrowIfDisposed();
            if (sizes != null) sizes.ThrowIfDisposed();

            ximgproc_SelectiveSearchSegmentationStrategy_setImage_10(nativeObj, img.nativeObj, regions.nativeObj, sizes.nativeObj, image_id);


        }

        /**
         * Set a initial image, with a segmentation.
         *                                 param img The input image. Any number of channel can be provided
         *                                 param regions A segmentation of the image. The parameter must be the same size of img.
         *                                 param sizes The sizes of different regions
         */
        public void setImage(Mat img, Mat regions, Mat sizes)
        {
            ThrowIfDisposed();
            if (img != null) img.ThrowIfDisposed();
            if (regions != null) regions.ThrowIfDisposed();
            if (sizes != null) sizes.ThrowIfDisposed();

            ximgproc_SelectiveSearchSegmentationStrategy_setImage_11(nativeObj, img.nativeObj, regions.nativeObj, sizes.nativeObj);


        }


        //
        // C++:  float cv::ximgproc::segmentation::SelectiveSearchSegmentationStrategy::get(int r1, int r2)
        //

        /**
         * Return the score between two regions (between 0 and 1)
         *                                 param r1 The first region
         *                                 param r2 The second region
         * return automatically generated
         */
        public float get(int r1, int r2)
        {
            ThrowIfDisposed();

            return ximgproc_SelectiveSearchSegmentationStrategy_get_10(nativeObj, r1, r2);


        }


        //
        // C++:  void cv::ximgproc::segmentation::SelectiveSearchSegmentationStrategy::merge(int r1, int r2)
        //

        /**
         * Inform the strategy that two regions will be merged
         *                                 param r1 The first region
         *                                 param r2 The second region
         */
        public void merge(int r1, int r2)
        {
            ThrowIfDisposed();

            ximgproc_SelectiveSearchSegmentationStrategy_merge_10(nativeObj, r1, r2);


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  void cv::ximgproc::segmentation::SelectiveSearchSegmentationStrategy::setImage(Mat img, Mat regions, Mat sizes, int image_id = -1)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_SelectiveSearchSegmentationStrategy_setImage_10(IntPtr nativeObj, IntPtr img_nativeObj, IntPtr regions_nativeObj, IntPtr sizes_nativeObj, int image_id);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_SelectiveSearchSegmentationStrategy_setImage_11(IntPtr nativeObj, IntPtr img_nativeObj, IntPtr regions_nativeObj, IntPtr sizes_nativeObj);

        // C++:  float cv::ximgproc::segmentation::SelectiveSearchSegmentationStrategy::get(int r1, int r2)
        [DllImport(LIBNAME)]
        private static extern float ximgproc_SelectiveSearchSegmentationStrategy_get_10(IntPtr nativeObj, int r1, int r2);

        // C++:  void cv::ximgproc::segmentation::SelectiveSearchSegmentationStrategy::merge(int r1, int r2)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_SelectiveSearchSegmentationStrategy_merge_10(IntPtr nativeObj, int r1, int r2);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void ximgproc_SelectiveSearchSegmentationStrategy_delete(IntPtr nativeObj);

    }
}
