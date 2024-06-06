#if !UNITY_WSA_10_0

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.DnnModule
{

    // C++: class SegmentationModel
    /**
     * This class represents high-level API for segmentation  models
     *
     * SegmentationModel allows to set params for preprocessing input image.
     * SegmentationModel creates net from file with trained weights and config,
     * sets preprocessing input, runs forward pass and returns the class prediction for each pixel.
     */

    public class SegmentationModel : Model
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
                        dnn_SegmentationModel_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal SegmentationModel(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new SegmentationModel __fromPtr__(IntPtr addr) { return new SegmentationModel(addr); }

        //
        // C++:   cv::dnn::SegmentationModel::SegmentationModel(String model, String config = "")
        //

        /**
         * Create segmentation model from network represented in one of the supported formats.
         * An order of {code model} and {code config} arguments does not matter.
         * param model Binary file contains trained weights.
         * param config Text file contains network configuration.
         */
        public SegmentationModel(string model, string config) :
            base(DisposableObject.ThrowIfNullIntPtr(dnn_SegmentationModel_SegmentationModel_10(model, config)))
        {



        }

        /**
         * Create segmentation model from network represented in one of the supported formats.
         * An order of {code model} and {code config} arguments does not matter.
         * param model Binary file contains trained weights.
         */
        public SegmentationModel(string model) :
            base(DisposableObject.ThrowIfNullIntPtr(dnn_SegmentationModel_SegmentationModel_11(model)))
        {



        }


        //
        // C++:   cv::dnn::SegmentationModel::SegmentationModel(Net network)
        //

        /**
         * Create model from deep learning network.
         * param network Net object.
         */
        public SegmentationModel(Net network) :
            base(DisposableObject.ThrowIfNullIntPtr(dnn_SegmentationModel_SegmentationModel_12(network.nativeObj)))
        {



        }


        //
        // C++:  void cv::dnn::SegmentationModel::segment(Mat frame, Mat& mask)
        //

        /**
         * Given the {code input} frame, create input blob, run net
         * param mask Allocated class prediction for each pixel
         * param frame automatically generated
         */
        public void segment(Mat frame, Mat mask)
        {
            ThrowIfDisposed();
            if (frame != null) frame.ThrowIfDisposed();
            if (mask != null) mask.ThrowIfDisposed();

            dnn_SegmentationModel_segment_10(nativeObj, frame.nativeObj, mask.nativeObj);


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:   cv::dnn::SegmentationModel::SegmentationModel(String model, String config = "")
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_SegmentationModel_SegmentationModel_10(string model, string config);
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_SegmentationModel_SegmentationModel_11(string model);

        // C++:   cv::dnn::SegmentationModel::SegmentationModel(Net network)
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_SegmentationModel_SegmentationModel_12(IntPtr network_nativeObj);

        // C++:  void cv::dnn::SegmentationModel::segment(Mat frame, Mat& mask)
        [DllImport(LIBNAME)]
        private static extern void dnn_SegmentationModel_segment_10(IntPtr nativeObj, IntPtr frame_nativeObj, IntPtr mask_nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void dnn_SegmentationModel_delete(IntPtr nativeObj);

    }
}

#endif