#if !UNITY_WSA_10_0

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.DnnModule
{
    // C++: class Model
    /**
     * This class is presented high-level API for neural networks.
     *
     * Model allows to set params for preprocessing input image.
     * Model creates net from file with trained weights and config,
     * sets preprocessing input and runs forward pass.
     */

    public class Model : DisposableOpenCVObject
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
                        dnn_Model_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal Model(IntPtr addr) : base(addr) { }


        public IntPtr getNativeObjAddr() { return nativeObj; }

        // internal usage only
        public static Model __fromPtr__(IntPtr addr) { return new Model(addr); }

        //
        // C++:   cv::dnn::Model::Model(String model, String config = "")
        //

        /**
         * Create model from deep learning network represented in one of the supported formats.
         * An order of {code model} and {code config} arguments does not matter.
         * param model Binary file contains trained weights.
         * param config Text file contains network configuration.
         */
        public Model(string model, string config)
        {


            nativeObj = DisposableObject.ThrowIfNullIntPtr(dnn_Model_Model_10(model, config));


        }

        /**
         * Create model from deep learning network represented in one of the supported formats.
         * An order of {code model} and {code config} arguments does not matter.
         * param model Binary file contains trained weights.
         */
        public Model(string model)
        {


            nativeObj = DisposableObject.ThrowIfNullIntPtr(dnn_Model_Model_11(model));


        }


        //
        // C++:   cv::dnn::Model::Model(Net network)
        //

        /**
         * Create model from deep learning network.
         * param network Net object.
         */
        public Model(Net network)
        {
            if (network != null) network.ThrowIfDisposed();

            nativeObj = DisposableObject.ThrowIfNullIntPtr(dnn_Model_Model_12(network.nativeObj));


        }


        //
        // C++:  Model cv::dnn::Model::setInputSize(Size size)
        //

        /**
         * Set input size for frame.
         * param size New input size.
         * <b>Note:</b> If shape of the new blob less than 0, then frame size not change.
         * return automatically generated
         */
        public Model setInputSize(Size size)
        {
            ThrowIfDisposed();

            return new Model(DisposableObject.ThrowIfNullIntPtr(dnn_Model_setInputSize_10(nativeObj, size.width, size.height)));


        }


        //
        // C++:  Model cv::dnn::Model::setInputSize(int width, int height)
        //

        /**
         *
         * param width New input width.
         * param height New input height.
         * return automatically generated
         */
        public Model setInputSize(int width, int height)
        {
            ThrowIfDisposed();

            return new Model(DisposableObject.ThrowIfNullIntPtr(dnn_Model_setInputSize_11(nativeObj, width, height)));


        }


        //
        // C++:  Model cv::dnn::Model::setInputMean(Scalar mean)
        //

        /**
         * Set mean value for frame.
         * param mean Scalar with mean values which are subtracted from channels.
         * return automatically generated
         */
        public Model setInputMean(Scalar mean)
        {
            ThrowIfDisposed();

            return new Model(DisposableObject.ThrowIfNullIntPtr(dnn_Model_setInputMean_10(nativeObj, mean.val[0], mean.val[1], mean.val[2], mean.val[3])));


        }


        //
        // C++:  Model cv::dnn::Model::setInputScale(Scalar scale)
        //

        /**
         * Set scalefactor value for frame.
         * param scale Multiplier for frame values.
         * return automatically generated
         */
        public Model setInputScale(Scalar scale)
        {
            ThrowIfDisposed();

            return new Model(DisposableObject.ThrowIfNullIntPtr(dnn_Model_setInputScale_10(nativeObj, scale.val[0], scale.val[1], scale.val[2], scale.val[3])));


        }


        //
        // C++:  Model cv::dnn::Model::setInputCrop(bool crop)
        //

        /**
         * Set flag crop for frame.
         * param crop Flag which indicates whether image will be cropped after resize or not.
         * return automatically generated
         */
        public Model setInputCrop(bool crop)
        {
            ThrowIfDisposed();

            return new Model(DisposableObject.ThrowIfNullIntPtr(dnn_Model_setInputCrop_10(nativeObj, crop)));


        }


        //
        // C++:  Model cv::dnn::Model::setInputSwapRB(bool swapRB)
        //

        /**
         * Set flag swapRB for frame.
         * param swapRB Flag which indicates that swap first and last channels.
         * return automatically generated
         */
        public Model setInputSwapRB(bool swapRB)
        {
            ThrowIfDisposed();

            return new Model(DisposableObject.ThrowIfNullIntPtr(dnn_Model_setInputSwapRB_10(nativeObj, swapRB)));


        }


        //
        // C++:  void cv::dnn::Model::setInputParams(double scale = 1.0, Size size = Size(), Scalar mean = Scalar(), bool swapRB = false, bool crop = false)
        //

        /**
         * Set preprocessing parameters for frame.
         * param size New input size.
         * param mean Scalar with mean values which are subtracted from channels.
         * param scale Multiplier for frame values.
         * param swapRB Flag which indicates that swap first and last channels.
         * param crop Flag which indicates whether image will be cropped after resize or not.
         * blob(n, c, y, x) = scale * resize( frame(y, x, c) ) - mean(c) )
         */
        public void setInputParams(double scale, Size size, Scalar mean, bool swapRB, bool crop)
        {
            ThrowIfDisposed();

            dnn_Model_setInputParams_10(nativeObj, scale, size.width, size.height, mean.val[0], mean.val[1], mean.val[2], mean.val[3], swapRB, crop);


        }

        /**
         * Set preprocessing parameters for frame.
         * param size New input size.
         * param mean Scalar with mean values which are subtracted from channels.
         * param scale Multiplier for frame values.
         * param swapRB Flag which indicates that swap first and last channels.
         * blob(n, c, y, x) = scale * resize( frame(y, x, c) ) - mean(c) )
         */
        public void setInputParams(double scale, Size size, Scalar mean, bool swapRB)
        {
            ThrowIfDisposed();

            dnn_Model_setInputParams_11(nativeObj, scale, size.width, size.height, mean.val[0], mean.val[1], mean.val[2], mean.val[3], swapRB);


        }

        /**
         * Set preprocessing parameters for frame.
         * param size New input size.
         * param mean Scalar with mean values which are subtracted from channels.
         * param scale Multiplier for frame values.
         * blob(n, c, y, x) = scale * resize( frame(y, x, c) ) - mean(c) )
         */
        public void setInputParams(double scale, Size size, Scalar mean)
        {
            ThrowIfDisposed();

            dnn_Model_setInputParams_12(nativeObj, scale, size.width, size.height, mean.val[0], mean.val[1], mean.val[2], mean.val[3]);


        }

        /**
         * Set preprocessing parameters for frame.
         * param size New input size.
         * param scale Multiplier for frame values.
         * blob(n, c, y, x) = scale * resize( frame(y, x, c) ) - mean(c) )
         */
        public void setInputParams(double scale, Size size)
        {
            ThrowIfDisposed();

            dnn_Model_setInputParams_13(nativeObj, scale, size.width, size.height);


        }

        /**
         * Set preprocessing parameters for frame.
         * param scale Multiplier for frame values.
         * blob(n, c, y, x) = scale * resize( frame(y, x, c) ) - mean(c) )
         */
        public void setInputParams(double scale)
        {
            ThrowIfDisposed();

            dnn_Model_setInputParams_14(nativeObj, scale);


        }

        /**
         * Set preprocessing parameters for frame.
         * blob(n, c, y, x) = scale * resize( frame(y, x, c) ) - mean(c) )
         */
        public void setInputParams()
        {
            ThrowIfDisposed();

            dnn_Model_setInputParams_15(nativeObj);


        }


        //
        // C++:  void cv::dnn::Model::predict(Mat frame, vector_Mat& outs)
        //

        /**
         * Given the {code input} frame, create input blob, run net and return the output {code blobs}.
         * param outs Allocated output blobs, which will store results of the computation.
         * param frame automatically generated
         */
        public void predict(Mat frame, List<Mat> outs)
        {
            ThrowIfDisposed();
            if (frame != null) frame.ThrowIfDisposed();
            Mat outs_mat = new Mat();
            dnn_Model_predict_10(nativeObj, frame.nativeObj, outs_mat.nativeObj);
            Converters.Mat_to_vector_Mat(outs_mat, outs);
            outs_mat.release();

        }


        //
        // C++:  Model cv::dnn::Model::setPreferableBackend(dnn_Backend backendId)
        //

        public Model setPreferableBackend(int backendId)
        {
            ThrowIfDisposed();

            return new Model(DisposableObject.ThrowIfNullIntPtr(dnn_Model_setPreferableBackend_10(nativeObj, backendId)));


        }


        //
        // C++:  Model cv::dnn::Model::setPreferableTarget(dnn_Target targetId)
        //

        public Model setPreferableTarget(int targetId)
        {
            ThrowIfDisposed();

            return new Model(DisposableObject.ThrowIfNullIntPtr(dnn_Model_setPreferableTarget_10(nativeObj, targetId)));


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:   cv::dnn::Model::Model(String model, String config = "")
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_Model_Model_10(string model, string config);
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_Model_Model_11(string model);

        // C++:   cv::dnn::Model::Model(Net network)
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_Model_Model_12(IntPtr network_nativeObj);

        // C++:  Model cv::dnn::Model::setInputSize(Size size)
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_Model_setInputSize_10(IntPtr nativeObj, double size_width, double size_height);

        // C++:  Model cv::dnn::Model::setInputSize(int width, int height)
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_Model_setInputSize_11(IntPtr nativeObj, int width, int height);

        // C++:  Model cv::dnn::Model::setInputMean(Scalar mean)
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_Model_setInputMean_10(IntPtr nativeObj, double mean_val0, double mean_val1, double mean_val2, double mean_val3);

        // C++:  Model cv::dnn::Model::setInputScale(Scalar scale)
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_Model_setInputScale_10(IntPtr nativeObj, double scale_val0, double scale_val1, double scale_val2, double scale_val3);

        // C++:  Model cv::dnn::Model::setInputCrop(bool crop)
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_Model_setInputCrop_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool crop);

        // C++:  Model cv::dnn::Model::setInputSwapRB(bool swapRB)
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_Model_setInputSwapRB_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool swapRB);

        // C++:  void cv::dnn::Model::setInputParams(double scale = 1.0, Size size = Size(), Scalar mean = Scalar(), bool swapRB = false, bool crop = false)
        [DllImport(LIBNAME)]
        private static extern void dnn_Model_setInputParams_10(IntPtr nativeObj, double scale, double size_width, double size_height, double mean_val0, double mean_val1, double mean_val2, double mean_val3, [MarshalAs(UnmanagedType.U1)] bool swapRB, [MarshalAs(UnmanagedType.U1)] bool crop);
        [DllImport(LIBNAME)]
        private static extern void dnn_Model_setInputParams_11(IntPtr nativeObj, double scale, double size_width, double size_height, double mean_val0, double mean_val1, double mean_val2, double mean_val3, [MarshalAs(UnmanagedType.U1)] bool swapRB);
        [DllImport(LIBNAME)]
        private static extern void dnn_Model_setInputParams_12(IntPtr nativeObj, double scale, double size_width, double size_height, double mean_val0, double mean_val1, double mean_val2, double mean_val3);
        [DllImport(LIBNAME)]
        private static extern void dnn_Model_setInputParams_13(IntPtr nativeObj, double scale, double size_width, double size_height);
        [DllImport(LIBNAME)]
        private static extern void dnn_Model_setInputParams_14(IntPtr nativeObj, double scale);
        [DllImport(LIBNAME)]
        private static extern void dnn_Model_setInputParams_15(IntPtr nativeObj);

        // C++:  void cv::dnn::Model::predict(Mat frame, vector_Mat& outs)
        [DllImport(LIBNAME)]
        private static extern void dnn_Model_predict_10(IntPtr nativeObj, IntPtr frame_nativeObj, IntPtr outs_mat_nativeObj);

        // C++:  Model cv::dnn::Model::setPreferableBackend(dnn_Backend backendId)
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_Model_setPreferableBackend_10(IntPtr nativeObj, int backendId);

        // C++:  Model cv::dnn::Model::setPreferableTarget(dnn_Target targetId)
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_Model_setPreferableTarget_10(IntPtr nativeObj, int targetId);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void dnn_Model_delete(IntPtr nativeObj);

    }
}

#endif