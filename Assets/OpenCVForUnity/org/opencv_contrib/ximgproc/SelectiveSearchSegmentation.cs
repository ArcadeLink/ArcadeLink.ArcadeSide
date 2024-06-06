
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.XimgprocModule
{

    // C++: class SelectiveSearchSegmentation
    /**
     * Selective search segmentation algorithm
     *                         The class implements the algorithm described in CITE: uijlings2013selective.
     */

    public class SelectiveSearchSegmentation : Algorithm
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
                        ximgproc_SelectiveSearchSegmentation_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal SelectiveSearchSegmentation(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new SelectiveSearchSegmentation __fromPtr__(IntPtr addr) { return new SelectiveSearchSegmentation(addr); }

        //
        // C++:  void cv::ximgproc::segmentation::SelectiveSearchSegmentation::setBaseImage(Mat img)
        //

        /**
         * Set a image used by switch* functions to initialize the class
         *                                 param img The image
         */
        public void setBaseImage(Mat img)
        {
            ThrowIfDisposed();
            if (img != null) img.ThrowIfDisposed();

            ximgproc_SelectiveSearchSegmentation_setBaseImage_10(nativeObj, img.nativeObj);


        }


        //
        // C++:  void cv::ximgproc::segmentation::SelectiveSearchSegmentation::switchToSingleStrategy(int k = 200, float sigma = 0.8f)
        //

        /**
         * Initialize the class with the 'Single stragegy' parameters describled in CITE: uijlings2013selective.
         *                                 param k The k parameter for the graph segmentation
         *                                 param sigma The sigma parameter for the graph segmentation
         */
        public void switchToSingleStrategy(int k, float sigma)
        {
            ThrowIfDisposed();

            ximgproc_SelectiveSearchSegmentation_switchToSingleStrategy_10(nativeObj, k, sigma);


        }

        /**
         * Initialize the class with the 'Single stragegy' parameters describled in CITE: uijlings2013selective.
         *                                 param k The k parameter for the graph segmentation
         */
        public void switchToSingleStrategy(int k)
        {
            ThrowIfDisposed();

            ximgproc_SelectiveSearchSegmentation_switchToSingleStrategy_11(nativeObj, k);


        }

        /**
         * Initialize the class with the 'Single stragegy' parameters describled in CITE: uijlings2013selective.
         */
        public void switchToSingleStrategy()
        {
            ThrowIfDisposed();

            ximgproc_SelectiveSearchSegmentation_switchToSingleStrategy_12(nativeObj);


        }


        //
        // C++:  void cv::ximgproc::segmentation::SelectiveSearchSegmentation::switchToSelectiveSearchFast(int base_k = 150, int inc_k = 150, float sigma = 0.8f)
        //

        /**
         * Initialize the class with the 'Selective search fast' parameters describled in CITE: uijlings2013selective.
         *                                 param base_k The k parameter for the first graph segmentation
         *                                 param inc_k The increment of the k parameter for all graph segmentations
         *                                 param sigma The sigma parameter for the graph segmentation
         */
        public void switchToSelectiveSearchFast(int base_k, int inc_k, float sigma)
        {
            ThrowIfDisposed();

            ximgproc_SelectiveSearchSegmentation_switchToSelectiveSearchFast_10(nativeObj, base_k, inc_k, sigma);


        }

        /**
         * Initialize the class with the 'Selective search fast' parameters describled in CITE: uijlings2013selective.
         *                                 param base_k The k parameter for the first graph segmentation
         *                                 param inc_k The increment of the k parameter for all graph segmentations
         */
        public void switchToSelectiveSearchFast(int base_k, int inc_k)
        {
            ThrowIfDisposed();

            ximgproc_SelectiveSearchSegmentation_switchToSelectiveSearchFast_11(nativeObj, base_k, inc_k);


        }

        /**
         * Initialize the class with the 'Selective search fast' parameters describled in CITE: uijlings2013selective.
         *                                 param base_k The k parameter for the first graph segmentation
         */
        public void switchToSelectiveSearchFast(int base_k)
        {
            ThrowIfDisposed();

            ximgproc_SelectiveSearchSegmentation_switchToSelectiveSearchFast_12(nativeObj, base_k);


        }

        /**
         * Initialize the class with the 'Selective search fast' parameters describled in CITE: uijlings2013selective.
         */
        public void switchToSelectiveSearchFast()
        {
            ThrowIfDisposed();

            ximgproc_SelectiveSearchSegmentation_switchToSelectiveSearchFast_13(nativeObj);


        }


        //
        // C++:  void cv::ximgproc::segmentation::SelectiveSearchSegmentation::switchToSelectiveSearchQuality(int base_k = 150, int inc_k = 150, float sigma = 0.8f)
        //

        /**
         * Initialize the class with the 'Selective search fast' parameters describled in CITE: uijlings2013selective.
         *                                 param base_k The k parameter for the first graph segmentation
         *                                 param inc_k The increment of the k parameter for all graph segmentations
         *                                 param sigma The sigma parameter for the graph segmentation
         */
        public void switchToSelectiveSearchQuality(int base_k, int inc_k, float sigma)
        {
            ThrowIfDisposed();

            ximgproc_SelectiveSearchSegmentation_switchToSelectiveSearchQuality_10(nativeObj, base_k, inc_k, sigma);


        }

        /**
         * Initialize the class with the 'Selective search fast' parameters describled in CITE: uijlings2013selective.
         *                                 param base_k The k parameter for the first graph segmentation
         *                                 param inc_k The increment of the k parameter for all graph segmentations
         */
        public void switchToSelectiveSearchQuality(int base_k, int inc_k)
        {
            ThrowIfDisposed();

            ximgproc_SelectiveSearchSegmentation_switchToSelectiveSearchQuality_11(nativeObj, base_k, inc_k);


        }

        /**
         * Initialize the class with the 'Selective search fast' parameters describled in CITE: uijlings2013selective.
         *                                 param base_k The k parameter for the first graph segmentation
         */
        public void switchToSelectiveSearchQuality(int base_k)
        {
            ThrowIfDisposed();

            ximgproc_SelectiveSearchSegmentation_switchToSelectiveSearchQuality_12(nativeObj, base_k);


        }

        /**
         * Initialize the class with the 'Selective search fast' parameters describled in CITE: uijlings2013selective.
         */
        public void switchToSelectiveSearchQuality()
        {
            ThrowIfDisposed();

            ximgproc_SelectiveSearchSegmentation_switchToSelectiveSearchQuality_13(nativeObj);


        }


        //
        // C++:  void cv::ximgproc::segmentation::SelectiveSearchSegmentation::addImage(Mat img)
        //

        /**
         * Add a new image in the list of images to process.
         *                                 param img The image
         */
        public void addImage(Mat img)
        {
            ThrowIfDisposed();
            if (img != null) img.ThrowIfDisposed();

            ximgproc_SelectiveSearchSegmentation_addImage_10(nativeObj, img.nativeObj);


        }


        //
        // C++:  void cv::ximgproc::segmentation::SelectiveSearchSegmentation::clearImages()
        //

        /**
         * Clear the list of images to process
         */
        public void clearImages()
        {
            ThrowIfDisposed();

            ximgproc_SelectiveSearchSegmentation_clearImages_10(nativeObj);


        }


        //
        // C++:  void cv::ximgproc::segmentation::SelectiveSearchSegmentation::addGraphSegmentation(Ptr_GraphSegmentation g)
        //

        /**
         * Add a new graph segmentation in the list of graph segementations to process.
         *                                 param g The graph segmentation
         */
        public void addGraphSegmentation(GraphSegmentation g)
        {
            ThrowIfDisposed();
            if (g != null) g.ThrowIfDisposed();

            ximgproc_SelectiveSearchSegmentation_addGraphSegmentation_10(nativeObj, g.getNativeObjAddr());


        }


        //
        // C++:  void cv::ximgproc::segmentation::SelectiveSearchSegmentation::clearGraphSegmentations()
        //

        /**
         * Clear the list of graph segmentations to process;
         */
        public void clearGraphSegmentations()
        {
            ThrowIfDisposed();

            ximgproc_SelectiveSearchSegmentation_clearGraphSegmentations_10(nativeObj);


        }


        //
        // C++:  void cv::ximgproc::segmentation::SelectiveSearchSegmentation::addStrategy(Ptr_SelectiveSearchSegmentationStrategy s)
        //

        /**
         * Add a new strategy in the list of strategy to process.
         *                                 param s The strategy
         */
        public void addStrategy(SelectiveSearchSegmentationStrategy s)
        {
            ThrowIfDisposed();
            if (s != null) s.ThrowIfDisposed();

            ximgproc_SelectiveSearchSegmentation_addStrategy_10(nativeObj, s.getNativeObjAddr());


        }


        //
        // C++:  void cv::ximgproc::segmentation::SelectiveSearchSegmentation::clearStrategies()
        //

        /**
         * Clear the list of strategy to process;
         */
        public void clearStrategies()
        {
            ThrowIfDisposed();

            ximgproc_SelectiveSearchSegmentation_clearStrategies_10(nativeObj);


        }


        //
        // C++:  void cv::ximgproc::segmentation::SelectiveSearchSegmentation::process(vector_Rect& rects)
        //

        /**
         * Based on all images, graph segmentations and stragies, computes all possible rects and return them
         *                                 param rects The list of rects. The first ones are more relevents than the lasts ones.
         */
        public void process(MatOfRect rects)
        {
            ThrowIfDisposed();
            if (rects != null) rects.ThrowIfDisposed();
            Mat rects_mat = rects;
            ximgproc_SelectiveSearchSegmentation_process_10(nativeObj, rects_mat.nativeObj);


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  void cv::ximgproc::segmentation::SelectiveSearchSegmentation::setBaseImage(Mat img)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_SelectiveSearchSegmentation_setBaseImage_10(IntPtr nativeObj, IntPtr img_nativeObj);

        // C++:  void cv::ximgproc::segmentation::SelectiveSearchSegmentation::switchToSingleStrategy(int k = 200, float sigma = 0.8f)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_SelectiveSearchSegmentation_switchToSingleStrategy_10(IntPtr nativeObj, int k, float sigma);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_SelectiveSearchSegmentation_switchToSingleStrategy_11(IntPtr nativeObj, int k);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_SelectiveSearchSegmentation_switchToSingleStrategy_12(IntPtr nativeObj);

        // C++:  void cv::ximgproc::segmentation::SelectiveSearchSegmentation::switchToSelectiveSearchFast(int base_k = 150, int inc_k = 150, float sigma = 0.8f)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_SelectiveSearchSegmentation_switchToSelectiveSearchFast_10(IntPtr nativeObj, int base_k, int inc_k, float sigma);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_SelectiveSearchSegmentation_switchToSelectiveSearchFast_11(IntPtr nativeObj, int base_k, int inc_k);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_SelectiveSearchSegmentation_switchToSelectiveSearchFast_12(IntPtr nativeObj, int base_k);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_SelectiveSearchSegmentation_switchToSelectiveSearchFast_13(IntPtr nativeObj);

        // C++:  void cv::ximgproc::segmentation::SelectiveSearchSegmentation::switchToSelectiveSearchQuality(int base_k = 150, int inc_k = 150, float sigma = 0.8f)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_SelectiveSearchSegmentation_switchToSelectiveSearchQuality_10(IntPtr nativeObj, int base_k, int inc_k, float sigma);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_SelectiveSearchSegmentation_switchToSelectiveSearchQuality_11(IntPtr nativeObj, int base_k, int inc_k);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_SelectiveSearchSegmentation_switchToSelectiveSearchQuality_12(IntPtr nativeObj, int base_k);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_SelectiveSearchSegmentation_switchToSelectiveSearchQuality_13(IntPtr nativeObj);

        // C++:  void cv::ximgproc::segmentation::SelectiveSearchSegmentation::addImage(Mat img)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_SelectiveSearchSegmentation_addImage_10(IntPtr nativeObj, IntPtr img_nativeObj);

        // C++:  void cv::ximgproc::segmentation::SelectiveSearchSegmentation::clearImages()
        [DllImport(LIBNAME)]
        private static extern void ximgproc_SelectiveSearchSegmentation_clearImages_10(IntPtr nativeObj);

        // C++:  void cv::ximgproc::segmentation::SelectiveSearchSegmentation::addGraphSegmentation(Ptr_GraphSegmentation g)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_SelectiveSearchSegmentation_addGraphSegmentation_10(IntPtr nativeObj, IntPtr g_nativeObj);

        // C++:  void cv::ximgproc::segmentation::SelectiveSearchSegmentation::clearGraphSegmentations()
        [DllImport(LIBNAME)]
        private static extern void ximgproc_SelectiveSearchSegmentation_clearGraphSegmentations_10(IntPtr nativeObj);

        // C++:  void cv::ximgproc::segmentation::SelectiveSearchSegmentation::addStrategy(Ptr_SelectiveSearchSegmentationStrategy s)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_SelectiveSearchSegmentation_addStrategy_10(IntPtr nativeObj, IntPtr s_nativeObj);

        // C++:  void cv::ximgproc::segmentation::SelectiveSearchSegmentation::clearStrategies()
        [DllImport(LIBNAME)]
        private static extern void ximgproc_SelectiveSearchSegmentation_clearStrategies_10(IntPtr nativeObj);

        // C++:  void cv::ximgproc::segmentation::SelectiveSearchSegmentation::process(vector_Rect& rects)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_SelectiveSearchSegmentation_process_10(IntPtr nativeObj, IntPtr rects_mat_nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void ximgproc_SelectiveSearchSegmentation_delete(IntPtr nativeObj);

    }
}
