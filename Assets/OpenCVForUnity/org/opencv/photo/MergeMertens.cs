
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.PhotoModule
{

    // C++: class MergeMertens
    /**
     * Pixels are weighted using contrast, saturation and well-exposedness measures, than images are
     * combined using laplacian pyramids.
     *
     * The resulting image weight is constructed as weighted average of contrast, saturation and
     * well-exposedness measures.
     *
     * The resulting image doesn't require tonemapping and can be converted to 8-bit image by multiplying
     * by 255, but it's recommended to apply gamma correction and/or linear tonemapping.
     *
     * For more information see CITE: MK07 .
     */

    public class MergeMertens : MergeExposures
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
                        photo_MergeMertens_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal MergeMertens(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new MergeMertens __fromPtr__(IntPtr addr) { return new MergeMertens(addr); }

        //
        // C++:  void cv::MergeMertens::process(vector_Mat src, Mat& dst, Mat times, Mat response)
        //

        public override void process(List<Mat> src, Mat dst, Mat times, Mat response)
        {
            ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
            if (times != null) times.ThrowIfDisposed();
            if (response != null) response.ThrowIfDisposed();
            Mat src_mat = Converters.vector_Mat_to_Mat(src);
            photo_MergeMertens_process_10(nativeObj, src_mat.nativeObj, dst.nativeObj, times.nativeObj, response.nativeObj);


        }


        //
        // C++:  void cv::MergeMertens::process(vector_Mat src, Mat& dst)
        //

        /**
         * Short version of process, that doesn't take extra arguments.
         *
         *     param src vector of input images
         *     param dst result image
         */
        public void process(List<Mat> src, Mat dst)
        {
            ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
            Mat src_mat = Converters.vector_Mat_to_Mat(src);
            photo_MergeMertens_process_11(nativeObj, src_mat.nativeObj, dst.nativeObj);


        }


        //
        // C++:  float cv::MergeMertens::getContrastWeight()
        //

        public float getContrastWeight()
        {
            ThrowIfDisposed();

            return photo_MergeMertens_getContrastWeight_10(nativeObj);


        }


        //
        // C++:  void cv::MergeMertens::setContrastWeight(float contrast_weiht)
        //

        public void setContrastWeight(float contrast_weiht)
        {
            ThrowIfDisposed();

            photo_MergeMertens_setContrastWeight_10(nativeObj, contrast_weiht);


        }


        //
        // C++:  float cv::MergeMertens::getSaturationWeight()
        //

        public float getSaturationWeight()
        {
            ThrowIfDisposed();

            return photo_MergeMertens_getSaturationWeight_10(nativeObj);


        }


        //
        // C++:  void cv::MergeMertens::setSaturationWeight(float saturation_weight)
        //

        public void setSaturationWeight(float saturation_weight)
        {
            ThrowIfDisposed();

            photo_MergeMertens_setSaturationWeight_10(nativeObj, saturation_weight);


        }


        //
        // C++:  float cv::MergeMertens::getExposureWeight()
        //

        public float getExposureWeight()
        {
            ThrowIfDisposed();

            return photo_MergeMertens_getExposureWeight_10(nativeObj);


        }


        //
        // C++:  void cv::MergeMertens::setExposureWeight(float exposure_weight)
        //

        public void setExposureWeight(float exposure_weight)
        {
            ThrowIfDisposed();

            photo_MergeMertens_setExposureWeight_10(nativeObj, exposure_weight);


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  void cv::MergeMertens::process(vector_Mat src, Mat& dst, Mat times, Mat response)
        [DllImport(LIBNAME)]
        private static extern void photo_MergeMertens_process_10(IntPtr nativeObj, IntPtr src_mat_nativeObj, IntPtr dst_nativeObj, IntPtr times_nativeObj, IntPtr response_nativeObj);

        // C++:  void cv::MergeMertens::process(vector_Mat src, Mat& dst)
        [DllImport(LIBNAME)]
        private static extern void photo_MergeMertens_process_11(IntPtr nativeObj, IntPtr src_mat_nativeObj, IntPtr dst_nativeObj);

        // C++:  float cv::MergeMertens::getContrastWeight()
        [DllImport(LIBNAME)]
        private static extern float photo_MergeMertens_getContrastWeight_10(IntPtr nativeObj);

        // C++:  void cv::MergeMertens::setContrastWeight(float contrast_weiht)
        [DllImport(LIBNAME)]
        private static extern void photo_MergeMertens_setContrastWeight_10(IntPtr nativeObj, float contrast_weiht);

        // C++:  float cv::MergeMertens::getSaturationWeight()
        [DllImport(LIBNAME)]
        private static extern float photo_MergeMertens_getSaturationWeight_10(IntPtr nativeObj);

        // C++:  void cv::MergeMertens::setSaturationWeight(float saturation_weight)
        [DllImport(LIBNAME)]
        private static extern void photo_MergeMertens_setSaturationWeight_10(IntPtr nativeObj, float saturation_weight);

        // C++:  float cv::MergeMertens::getExposureWeight()
        [DllImport(LIBNAME)]
        private static extern float photo_MergeMertens_getExposureWeight_10(IntPtr nativeObj);

        // C++:  void cv::MergeMertens::setExposureWeight(float exposure_weight)
        [DllImport(LIBNAME)]
        private static extern void photo_MergeMertens_setExposureWeight_10(IntPtr nativeObj, float exposure_weight);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void photo_MergeMertens_delete(IntPtr nativeObj);

    }
}
