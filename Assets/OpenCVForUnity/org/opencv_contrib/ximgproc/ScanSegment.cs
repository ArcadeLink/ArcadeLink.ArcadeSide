
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.XimgprocModule
{

    // C++: class ScanSegment
    /**
     * Class implementing the F-DBSCAN (Accelerated superpixel image segmentation with a parallelized DBSCAN algorithm) superpixels
     * algorithm by Loke SC, et al. CITE: loke2021accelerated for original paper.
     *
     * The algorithm uses a parallelised DBSCAN cluster search that is resistant to noise, competitive in segmentation quality, and faster than
     * existing superpixel segmentation methods. When tested on the Berkeley Segmentation Dataset, the average processing speed is 175 frames/s
     * with a Boundary Recall of 0.797 and an Achievable Segmentation Accuracy of 0.944. The computational complexity is quadratic O(n2) and
     * more suited to smaller images, but can still process a 2MP colour image faster than the SEEDS algorithm in OpenCV. The output is deterministic
     * when the number of processing threads is fixed, and requires the source image to be in Lab colour format.
     */

    public class ScanSegment : Algorithm
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
                        ximgproc_ScanSegment_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal ScanSegment(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new ScanSegment __fromPtr__(IntPtr addr) { return new ScanSegment(addr); }

        //
        // C++:  int cv::ximgproc::ScanSegment::getNumberOfSuperpixels()
        //

        /**
         * Returns the actual superpixel segmentation from the last image processed using iterate.
         *
         *     Returns zero if no image has been processed.
         * return automatically generated
         */
        public int getNumberOfSuperpixels()
        {
            ThrowIfDisposed();

            return ximgproc_ScanSegment_getNumberOfSuperpixels_10(nativeObj);


        }


        //
        // C++:  void cv::ximgproc::ScanSegment::iterate(Mat img)
        //

        /**
         * Calculates the superpixel segmentation on a given image with the initialized
         *     parameters in the ScanSegment object.
         *
         *     This function can be called again for other images without the need of initializing the algorithm with createScanSegment().
         *     This save the computational cost of allocating memory for all the structures of the algorithm.
         *
         *     param img Input image. Supported format: CV_8UC3. Image size must match with the initialized
         *     image size with the function createScanSegment(). It MUST be in Lab color space.
         */
        public void iterate(Mat img)
        {
            ThrowIfDisposed();
            if (img != null) img.ThrowIfDisposed();

            ximgproc_ScanSegment_iterate_10(nativeObj, img.nativeObj);


        }


        //
        // C++:  void cv::ximgproc::ScanSegment::getLabels(Mat& labels_out)
        //

        /**
         * Returns the segmentation labeling of the image.
         *
         *     Each label represents a superpixel, and each pixel is assigned to one superpixel label.
         *
         *     param labels_out Return: A CV_32UC1 integer array containing the labels of the superpixel
         *     segmentation. The labels are in the range [0, getNumberOfSuperpixels()].
         */
        public void getLabels(Mat labels_out)
        {
            ThrowIfDisposed();
            if (labels_out != null) labels_out.ThrowIfDisposed();

            ximgproc_ScanSegment_getLabels_10(nativeObj, labels_out.nativeObj);


        }


        //
        // C++:  void cv::ximgproc::ScanSegment::getLabelContourMask(Mat& image, bool thick_line = false)
        //

        /**
         * Returns the mask of the superpixel segmentation stored in the ScanSegment object.
         *
         *     The function return the boundaries of the superpixel segmentation.
         *
         *     param image Return: CV_8UC1 image mask where -1 indicates that the pixel is a superpixel border, and 0 otherwise.
         *     param thick_line If false, the border is only one pixel wide, otherwise all pixels at the border are masked.
         */
        public void getLabelContourMask(Mat image, bool thick_line)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();

            ximgproc_ScanSegment_getLabelContourMask_10(nativeObj, image.nativeObj, thick_line);


        }

        /**
         * Returns the mask of the superpixel segmentation stored in the ScanSegment object.
         *
         *     The function return the boundaries of the superpixel segmentation.
         *
         *     param image Return: CV_8UC1 image mask where -1 indicates that the pixel is a superpixel border, and 0 otherwise.
         */
        public void getLabelContourMask(Mat image)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();

            ximgproc_ScanSegment_getLabelContourMask_11(nativeObj, image.nativeObj);


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  int cv::ximgproc::ScanSegment::getNumberOfSuperpixels()
        [DllImport(LIBNAME)]
        private static extern int ximgproc_ScanSegment_getNumberOfSuperpixels_10(IntPtr nativeObj);

        // C++:  void cv::ximgproc::ScanSegment::iterate(Mat img)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_ScanSegment_iterate_10(IntPtr nativeObj, IntPtr img_nativeObj);

        // C++:  void cv::ximgproc::ScanSegment::getLabels(Mat& labels_out)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_ScanSegment_getLabels_10(IntPtr nativeObj, IntPtr labels_out_nativeObj);

        // C++:  void cv::ximgproc::ScanSegment::getLabelContourMask(Mat& image, bool thick_line = false)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_ScanSegment_getLabelContourMask_10(IntPtr nativeObj, IntPtr image_nativeObj, [MarshalAs(UnmanagedType.U1)] bool thick_line);
        [DllImport(LIBNAME)]
        private static extern void ximgproc_ScanSegment_getLabelContourMask_11(IntPtr nativeObj, IntPtr image_nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void ximgproc_ScanSegment_delete(IntPtr nativeObj);

    }
}
