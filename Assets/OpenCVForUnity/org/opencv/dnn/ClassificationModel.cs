#if !UNITY_WSA_10_0

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.DnnModule
{

    // C++: class ClassificationModel
    /**
     * This class represents high-level API for classification models.
     *
     * ClassificationModel allows to set params for preprocessing input image.
     * ClassificationModel creates net from file with trained weights and config,
     * sets preprocessing input, runs forward pass and return top-1 prediction.
     */

    public class ClassificationModel : Model
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
                        dnn_ClassificationModel_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal ClassificationModel(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new ClassificationModel __fromPtr__(IntPtr addr) { return new ClassificationModel(addr); }

        //
        // C++:   cv::dnn::ClassificationModel::ClassificationModel(String model, String config = "")
        //

        /**
         * Create classification model from network represented in one of the supported formats.
         * An order of {code model} and {code config} arguments does not matter.
         * param model Binary file contains trained weights.
         * param config Text file contains network configuration.
         */
        public ClassificationModel(string model, string config) :
            base(DisposableObject.ThrowIfNullIntPtr(dnn_ClassificationModel_ClassificationModel_10(model, config)))
        {



        }

        /**
         * Create classification model from network represented in one of the supported formats.
         * An order of {code model} and {code config} arguments does not matter.
         * param model Binary file contains trained weights.
         */
        public ClassificationModel(string model) :
            base(DisposableObject.ThrowIfNullIntPtr(dnn_ClassificationModel_ClassificationModel_11(model)))
        {



        }


        //
        // C++:   cv::dnn::ClassificationModel::ClassificationModel(Net network)
        //

        /**
         * Create model from deep learning network.
         * param network Net object.
         */
        public ClassificationModel(Net network) :
            base(DisposableObject.ThrowIfNullIntPtr(dnn_ClassificationModel_ClassificationModel_12(network.nativeObj)))
        {



        }


        //
        // C++:  ClassificationModel cv::dnn::ClassificationModel::setEnableSoftmaxPostProcessing(bool enable)
        //

        /**
         * Set enable/disable softmax post processing option.
         *
         * If this option is true, softmax is applied after forward inference within the classify() function
         * to convert the confidences range to [0.0-1.0].
         * This function allows you to toggle this behavior.
         * Please turn true when not contain softmax layer in model.
         * param enable Set enable softmax post processing within the classify() function.
         * return automatically generated
         */
        public ClassificationModel setEnableSoftmaxPostProcessing(bool enable)
        {
            ThrowIfDisposed();

            return new ClassificationModel(DisposableObject.ThrowIfNullIntPtr(dnn_ClassificationModel_setEnableSoftmaxPostProcessing_10(nativeObj, enable)));


        }


        //
        // C++:  bool cv::dnn::ClassificationModel::getEnableSoftmaxPostProcessing()
        //

        /**
         * Get enable/disable softmax post processing option.
         *
         * This option defaults to false, softmax post processing is not applied within the classify() function.
         * return automatically generated
         */
        public bool getEnableSoftmaxPostProcessing()
        {
            ThrowIfDisposed();

            return dnn_ClassificationModel_getEnableSoftmaxPostProcessing_10(nativeObj);


        }


        //
        // C++:  void cv::dnn::ClassificationModel::classify(Mat frame, int& classId, float& conf)
        //

        public void classify(Mat frame, int[] classId, float[] conf)
        {
            ThrowIfDisposed();
            if (frame != null) frame.ThrowIfDisposed();
            double[] classId_out = new double[1];
            double[] conf_out = new double[1];
            dnn_ClassificationModel_classify_10(nativeObj, frame.nativeObj, classId_out, conf_out);
            if (classId != null) classId[0] = (int)classId_out[0];
            if (conf != null) conf[0] = (float)conf_out[0];

        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:   cv::dnn::ClassificationModel::ClassificationModel(String model, String config = "")
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_ClassificationModel_ClassificationModel_10(string model, string config);
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_ClassificationModel_ClassificationModel_11(string model);

        // C++:   cv::dnn::ClassificationModel::ClassificationModel(Net network)
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_ClassificationModel_ClassificationModel_12(IntPtr network_nativeObj);

        // C++:  ClassificationModel cv::dnn::ClassificationModel::setEnableSoftmaxPostProcessing(bool enable)
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_ClassificationModel_setEnableSoftmaxPostProcessing_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool enable);

        // C++:  bool cv::dnn::ClassificationModel::getEnableSoftmaxPostProcessing()
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool dnn_ClassificationModel_getEnableSoftmaxPostProcessing_10(IntPtr nativeObj);

        // C++:  void cv::dnn::ClassificationModel::classify(Mat frame, int& classId, float& conf)
        [DllImport(LIBNAME)]
        private static extern void dnn_ClassificationModel_classify_10(IntPtr nativeObj, IntPtr frame_nativeObj, double[] classId_out, double[] conf_out);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void dnn_ClassificationModel_delete(IntPtr nativeObj);

    }
}

#endif