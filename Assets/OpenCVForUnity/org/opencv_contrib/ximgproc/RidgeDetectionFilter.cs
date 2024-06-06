
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.XimgprocModule
{

    // C++: class RidgeDetectionFilter
    /**
     *  Applies Ridge Detection Filter to an input image.
     * Implements Ridge detection similar to the one in [Mathematica](http://reference.wolfram.com/language/ref/RidgeFilter.html)
     * using the eigen values from the Hessian Matrix of the input image using Sobel Derivatives.
     * Additional refinement can be done using Skeletonization and Binarization. Adapted from CITE: segleafvein and CITE: M_RF
     */

    public class RidgeDetectionFilter : Algorithm
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
                        ximgproc_RidgeDetectionFilter_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal RidgeDetectionFilter(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new RidgeDetectionFilter __fromPtr__(IntPtr addr) { return new RidgeDetectionFilter(addr); }

        //
        // C++: static Ptr_RidgeDetectionFilter cv::ximgproc::RidgeDetectionFilter::create(int ddepth = CV_32FC1, int dx = 1, int dy = 1, int ksize = 3, int out_dtype = CV_8UC1, double scale = 1, double delta = 0, int borderType = BORDER_DEFAULT)
        //

        /**
         * Create pointer to the Ridge detection filter.
         *     param ddepth  Specifies output image depth. Defualt is CV_32FC1
         *     param dx Order of derivative x, default is 1
         *     param dy  Order of derivative y, default is 1
         *     param ksize Sobel kernel size , default is 3
         *     param out_dtype Converted format for output, default is CV_8UC1
         *     param scale Optional scale value for derivative values, default is 1
         *     param delta  Optional bias added to output, default is 0
         *     param borderType Pixel extrapolation method, default is BORDER_DEFAULT
         *     SEE: Sobel, threshold, getStructuringElement, morphologyEx.( for additional refinement)
         * return automatically generated
         */
        public static RidgeDetectionFilter create(int ddepth, int dx, int dy, int ksize, int out_dtype, double scale, double delta, int borderType)
        {


            return RidgeDetectionFilter.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ximgproc_RidgeDetectionFilter_create_10(ddepth, dx, dy, ksize, out_dtype, scale, delta, borderType)));


        }

        /**
         * Create pointer to the Ridge detection filter.
         *     param ddepth  Specifies output image depth. Defualt is CV_32FC1
         *     param dx Order of derivative x, default is 1
         *     param dy  Order of derivative y, default is 1
         *     param ksize Sobel kernel size , default is 3
         *     param out_dtype Converted format for output, default is CV_8UC1
         *     param scale Optional scale value for derivative values, default is 1
         *     param delta  Optional bias added to output, default is 0
         *     SEE: Sobel, threshold, getStructuringElement, morphologyEx.( for additional refinement)
         * return automatically generated
         */
        public static RidgeDetectionFilter create(int ddepth, int dx, int dy, int ksize, int out_dtype, double scale, double delta)
        {


            return RidgeDetectionFilter.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ximgproc_RidgeDetectionFilter_create_11(ddepth, dx, dy, ksize, out_dtype, scale, delta)));


        }

        /**
         * Create pointer to the Ridge detection filter.
         *     param ddepth  Specifies output image depth. Defualt is CV_32FC1
         *     param dx Order of derivative x, default is 1
         *     param dy  Order of derivative y, default is 1
         *     param ksize Sobel kernel size , default is 3
         *     param out_dtype Converted format for output, default is CV_8UC1
         *     param scale Optional scale value for derivative values, default is 1
         *     SEE: Sobel, threshold, getStructuringElement, morphologyEx.( for additional refinement)
         * return automatically generated
         */
        public static RidgeDetectionFilter create(int ddepth, int dx, int dy, int ksize, int out_dtype, double scale)
        {


            return RidgeDetectionFilter.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ximgproc_RidgeDetectionFilter_create_12(ddepth, dx, dy, ksize, out_dtype, scale)));


        }

        /**
         * Create pointer to the Ridge detection filter.
         *     param ddepth  Specifies output image depth. Defualt is CV_32FC1
         *     param dx Order of derivative x, default is 1
         *     param dy  Order of derivative y, default is 1
         *     param ksize Sobel kernel size , default is 3
         *     param out_dtype Converted format for output, default is CV_8UC1
         *     SEE: Sobel, threshold, getStructuringElement, morphologyEx.( for additional refinement)
         * return automatically generated
         */
        public static RidgeDetectionFilter create(int ddepth, int dx, int dy, int ksize, int out_dtype)
        {


            return RidgeDetectionFilter.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ximgproc_RidgeDetectionFilter_create_13(ddepth, dx, dy, ksize, out_dtype)));


        }

        /**
         * Create pointer to the Ridge detection filter.
         *     param ddepth  Specifies output image depth. Defualt is CV_32FC1
         *     param dx Order of derivative x, default is 1
         *     param dy  Order of derivative y, default is 1
         *     param ksize Sobel kernel size , default is 3
         *     SEE: Sobel, threshold, getStructuringElement, morphologyEx.( for additional refinement)
         * return automatically generated
         */
        public static RidgeDetectionFilter create(int ddepth, int dx, int dy, int ksize)
        {


            return RidgeDetectionFilter.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ximgproc_RidgeDetectionFilter_create_14(ddepth, dx, dy, ksize)));


        }

        /**
         * Create pointer to the Ridge detection filter.
         *     param ddepth  Specifies output image depth. Defualt is CV_32FC1
         *     param dx Order of derivative x, default is 1
         *     param dy  Order of derivative y, default is 1
         *     SEE: Sobel, threshold, getStructuringElement, morphologyEx.( for additional refinement)
         * return automatically generated
         */
        public static RidgeDetectionFilter create(int ddepth, int dx, int dy)
        {


            return RidgeDetectionFilter.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ximgproc_RidgeDetectionFilter_create_15(ddepth, dx, dy)));


        }

        /**
         * Create pointer to the Ridge detection filter.
         *     param ddepth  Specifies output image depth. Defualt is CV_32FC1
         *     param dx Order of derivative x, default is 1
         *     SEE: Sobel, threshold, getStructuringElement, morphologyEx.( for additional refinement)
         * return automatically generated
         */
        public static RidgeDetectionFilter create(int ddepth, int dx)
        {


            return RidgeDetectionFilter.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ximgproc_RidgeDetectionFilter_create_16(ddepth, dx)));


        }

        /**
         * Create pointer to the Ridge detection filter.
         *     param ddepth  Specifies output image depth. Defualt is CV_32FC1
         *     SEE: Sobel, threshold, getStructuringElement, morphologyEx.( for additional refinement)
         * return automatically generated
         */
        public static RidgeDetectionFilter create(int ddepth)
        {


            return RidgeDetectionFilter.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ximgproc_RidgeDetectionFilter_create_17(ddepth)));


        }

        /**
         * Create pointer to the Ridge detection filter.
         *     SEE: Sobel, threshold, getStructuringElement, morphologyEx.( for additional refinement)
         * return automatically generated
         */
        public static RidgeDetectionFilter create()
        {


            return RidgeDetectionFilter.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ximgproc_RidgeDetectionFilter_create_18()));


        }


        //
        // C++:  void cv::ximgproc::RidgeDetectionFilter::getRidgeFilteredImage(Mat _img, Mat& _out)
        //

        /**
         * Apply Ridge detection filter on input image.
         *     param _img InputArray as supported by Sobel. img can be 1-Channel or 3-Channels.
         * param _out automatically generated
         */
        public void getRidgeFilteredImage(Mat _img, Mat _out)
        {
            ThrowIfDisposed();
            if (_img != null) _img.ThrowIfDisposed();
            if (_out != null) _out.ThrowIfDisposed();

            ximgproc_RidgeDetectionFilter_getRidgeFilteredImage_10(nativeObj, _img.nativeObj, _out.nativeObj);


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++: static Ptr_RidgeDetectionFilter cv::ximgproc::RidgeDetectionFilter::create(int ddepth = CV_32FC1, int dx = 1, int dy = 1, int ksize = 3, int out_dtype = CV_8UC1, double scale = 1, double delta = 0, int borderType = BORDER_DEFAULT)
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_RidgeDetectionFilter_create_10(int ddepth, int dx, int dy, int ksize, int out_dtype, double scale, double delta, int borderType);
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_RidgeDetectionFilter_create_11(int ddepth, int dx, int dy, int ksize, int out_dtype, double scale, double delta);
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_RidgeDetectionFilter_create_12(int ddepth, int dx, int dy, int ksize, int out_dtype, double scale);
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_RidgeDetectionFilter_create_13(int ddepth, int dx, int dy, int ksize, int out_dtype);
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_RidgeDetectionFilter_create_14(int ddepth, int dx, int dy, int ksize);
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_RidgeDetectionFilter_create_15(int ddepth, int dx, int dy);
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_RidgeDetectionFilter_create_16(int ddepth, int dx);
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_RidgeDetectionFilter_create_17(int ddepth);
        [DllImport(LIBNAME)]
        private static extern IntPtr ximgproc_RidgeDetectionFilter_create_18();

        // C++:  void cv::ximgproc::RidgeDetectionFilter::getRidgeFilteredImage(Mat _img, Mat& _out)
        [DllImport(LIBNAME)]
        private static extern void ximgproc_RidgeDetectionFilter_getRidgeFilteredImage_10(IntPtr nativeObj, IntPtr _img_nativeObj, IntPtr _out_nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void ximgproc_RidgeDetectionFilter_delete(IntPtr nativeObj);

    }
}
