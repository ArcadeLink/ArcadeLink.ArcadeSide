
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.PhotoModule
{

    // C++: class AlignMTB
    /**
     * This algorithm converts images to median threshold bitmaps (1 for pixels brighter than median
     * luminance and 0 otherwise) and than aligns the resulting bitmaps using bit operations.
     *
     * It is invariant to exposure, so exposure values and camera response are not necessary.
     *
     * In this implementation new image regions are filled with zeros.
     *
     * For more information see CITE: GW03 .
     */

    public class AlignMTB : AlignExposures
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
                        photo_AlignMTB_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal AlignMTB(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new AlignMTB __fromPtr__(IntPtr addr) { return new AlignMTB(addr); }

        //
        // C++:  void cv::AlignMTB::process(vector_Mat src, vector_Mat dst, Mat times, Mat response)
        //

        public override void process(List<Mat> src, List<Mat> dst, Mat times, Mat response)
        {
            ThrowIfDisposed();
            if (times != null) times.ThrowIfDisposed();
            if (response != null) response.ThrowIfDisposed();
            Mat src_mat = Converters.vector_Mat_to_Mat(src);
            Mat dst_mat = Converters.vector_Mat_to_Mat(dst);
            photo_AlignMTB_process_10(nativeObj, src_mat.nativeObj, dst_mat.nativeObj, times.nativeObj, response.nativeObj);


        }


        //
        // C++:  void cv::AlignMTB::process(vector_Mat src, vector_Mat dst)
        //

        /**
         * Short version of process, that doesn't take extra arguments.
         *
         *     param src vector of input images
         *     param dst vector of aligned images
         */
        public void process(List<Mat> src, List<Mat> dst)
        {
            ThrowIfDisposed();
            Mat src_mat = Converters.vector_Mat_to_Mat(src);
            Mat dst_mat = Converters.vector_Mat_to_Mat(dst);
            photo_AlignMTB_process_11(nativeObj, src_mat.nativeObj, dst_mat.nativeObj);


        }


        //
        // C++:  Point cv::AlignMTB::calculateShift(Mat img0, Mat img1)
        //

        /**
         * Calculates shift between two images, i. e. how to shift the second image to correspond it with the
         *     first.
         *
         *     param img0 first image
         *     param img1 second image
         * return automatically generated
         */
        public Point calculateShift(Mat img0, Mat img1)
        {
            ThrowIfDisposed();
            if (img0 != null) img0.ThrowIfDisposed();
            if (img1 != null) img1.ThrowIfDisposed();

            double[] tmpArray = new double[2];
            photo_AlignMTB_calculateShift_10(nativeObj, img0.nativeObj, img1.nativeObj, tmpArray);
            Point retVal = new Point(tmpArray);

            return retVal;
        }


        //
        // C++:  void cv::AlignMTB::shiftMat(Mat src, Mat& dst, Point shift)
        //

        /**
         * Helper function, that shift Mat filling new regions with zeros.
         *
         *     param src input image
         *     param dst result image
         *     param shift shift value
         */
        public void shiftMat(Mat src, Mat dst, Point shift)
        {
            ThrowIfDisposed();
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            photo_AlignMTB_shiftMat_10(nativeObj, src.nativeObj, dst.nativeObj, shift.x, shift.y);


        }


        //
        // C++:  void cv::AlignMTB::computeBitmaps(Mat img, Mat& tb, Mat& eb)
        //

        /**
         * Computes median threshold and exclude bitmaps of given image.
         *
         *     param img input image
         *     param tb median threshold bitmap
         *     param eb exclude bitmap
         */
        public void computeBitmaps(Mat img, Mat tb, Mat eb)
        {
            ThrowIfDisposed();
            if (img != null) img.ThrowIfDisposed();
            if (tb != null) tb.ThrowIfDisposed();
            if (eb != null) eb.ThrowIfDisposed();

            photo_AlignMTB_computeBitmaps_10(nativeObj, img.nativeObj, tb.nativeObj, eb.nativeObj);


        }


        //
        // C++:  int cv::AlignMTB::getMaxBits()
        //

        public int getMaxBits()
        {
            ThrowIfDisposed();

            return photo_AlignMTB_getMaxBits_10(nativeObj);


        }


        //
        // C++:  void cv::AlignMTB::setMaxBits(int max_bits)
        //

        public void setMaxBits(int max_bits)
        {
            ThrowIfDisposed();

            photo_AlignMTB_setMaxBits_10(nativeObj, max_bits);


        }


        //
        // C++:  int cv::AlignMTB::getExcludeRange()
        //

        public int getExcludeRange()
        {
            ThrowIfDisposed();

            return photo_AlignMTB_getExcludeRange_10(nativeObj);


        }


        //
        // C++:  void cv::AlignMTB::setExcludeRange(int exclude_range)
        //

        public void setExcludeRange(int exclude_range)
        {
            ThrowIfDisposed();

            photo_AlignMTB_setExcludeRange_10(nativeObj, exclude_range);


        }


        //
        // C++:  bool cv::AlignMTB::getCut()
        //

        public bool getCut()
        {
            ThrowIfDisposed();

            return photo_AlignMTB_getCut_10(nativeObj);


        }


        //
        // C++:  void cv::AlignMTB::setCut(bool value)
        //

        public void setCut(bool value)
        {
            ThrowIfDisposed();

            photo_AlignMTB_setCut_10(nativeObj, value);


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  void cv::AlignMTB::process(vector_Mat src, vector_Mat dst, Mat times, Mat response)
        [DllImport(LIBNAME)]
        private static extern void photo_AlignMTB_process_10(IntPtr nativeObj, IntPtr src_mat_nativeObj, IntPtr dst_mat_nativeObj, IntPtr times_nativeObj, IntPtr response_nativeObj);

        // C++:  void cv::AlignMTB::process(vector_Mat src, vector_Mat dst)
        [DllImport(LIBNAME)]
        private static extern void photo_AlignMTB_process_11(IntPtr nativeObj, IntPtr src_mat_nativeObj, IntPtr dst_mat_nativeObj);

        // C++:  Point cv::AlignMTB::calculateShift(Mat img0, Mat img1)
        [DllImport(LIBNAME)]
        private static extern void photo_AlignMTB_calculateShift_10(IntPtr nativeObj, IntPtr img0_nativeObj, IntPtr img1_nativeObj, double[] retVal);

        // C++:  void cv::AlignMTB::shiftMat(Mat src, Mat& dst, Point shift)
        [DllImport(LIBNAME)]
        private static extern void photo_AlignMTB_shiftMat_10(IntPtr nativeObj, IntPtr src_nativeObj, IntPtr dst_nativeObj, double shift_x, double shift_y);

        // C++:  void cv::AlignMTB::computeBitmaps(Mat img, Mat& tb, Mat& eb)
        [DllImport(LIBNAME)]
        private static extern void photo_AlignMTB_computeBitmaps_10(IntPtr nativeObj, IntPtr img_nativeObj, IntPtr tb_nativeObj, IntPtr eb_nativeObj);

        // C++:  int cv::AlignMTB::getMaxBits()
        [DllImport(LIBNAME)]
        private static extern int photo_AlignMTB_getMaxBits_10(IntPtr nativeObj);

        // C++:  void cv::AlignMTB::setMaxBits(int max_bits)
        [DllImport(LIBNAME)]
        private static extern void photo_AlignMTB_setMaxBits_10(IntPtr nativeObj, int max_bits);

        // C++:  int cv::AlignMTB::getExcludeRange()
        [DllImport(LIBNAME)]
        private static extern int photo_AlignMTB_getExcludeRange_10(IntPtr nativeObj);

        // C++:  void cv::AlignMTB::setExcludeRange(int exclude_range)
        [DllImport(LIBNAME)]
        private static extern void photo_AlignMTB_setExcludeRange_10(IntPtr nativeObj, int exclude_range);

        // C++:  bool cv::AlignMTB::getCut()
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool photo_AlignMTB_getCut_10(IntPtr nativeObj);

        // C++:  void cv::AlignMTB::setCut(bool value)
        [DllImport(LIBNAME)]
        private static extern void photo_AlignMTB_setCut_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool value);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void photo_AlignMTB_delete(IntPtr nativeObj);

    }
}
