
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.MlModule
{

    // C++: class StatModel
    /**
     * Base class for statistical models in OpenCV ML.
     */

    public class StatModel : Algorithm
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
                        ml_StatModel_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal StatModel(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new StatModel __fromPtr__(IntPtr addr) { return new StatModel(addr); }

        // C++: enum cv.ml.StatModel.Flags
        public const int UPDATE_MODEL = 1;
        public const int RAW_OUTPUT = 1;
        public const int COMPRESSED_INPUT = 2;
        public const int PREPROCESSED_INPUT = 4;
        //
        // C++:  int cv::ml::StatModel::getVarCount()
        //

        /**
         * Returns the number of variables in training samples
         * return automatically generated
         */
        public int getVarCount()
        {
            ThrowIfDisposed();

            return ml_StatModel_getVarCount_10(nativeObj);


        }


        //
        // C++:  bool cv::ml::StatModel::empty()
        //

        public override bool empty()
        {
            ThrowIfDisposed();

            return ml_StatModel_empty_10(nativeObj);


        }


        //
        // C++:  bool cv::ml::StatModel::isTrained()
        //

        /**
         * Returns true if the model is trained
         * return automatically generated
         */
        public bool isTrained()
        {
            ThrowIfDisposed();

            return ml_StatModel_isTrained_10(nativeObj);


        }


        //
        // C++:  bool cv::ml::StatModel::isClassifier()
        //

        /**
         * Returns true if the model is classifier
         * return automatically generated
         */
        public bool isClassifier()
        {
            ThrowIfDisposed();

            return ml_StatModel_isClassifier_10(nativeObj);


        }


        //
        // C++:  bool cv::ml::StatModel::train(Ptr_TrainData trainData, int flags = 0)
        //

        /**
         * Trains the statistical model
         *
         *     param trainData training data that can be loaded from file using TrainData::loadFromCSV or
         *         created with TrainData::create.
         *     param flags optional flags, depending on the model. Some of the models can be updated with the
         *         new training samples, not completely overwritten (such as NormalBayesClassifier or ANN_MLP).
         * return automatically generated
         */
        public bool train(TrainData trainData, int flags)
        {
            ThrowIfDisposed();
            if (trainData != null) trainData.ThrowIfDisposed();

            return ml_StatModel_train_10(nativeObj, trainData.getNativeObjAddr(), flags);


        }

        /**
         * Trains the statistical model
         *
         *     param trainData training data that can be loaded from file using TrainData::loadFromCSV or
         *         created with TrainData::create.
         *         new training samples, not completely overwritten (such as NormalBayesClassifier or ANN_MLP).
         * return automatically generated
         */
        public bool train(TrainData trainData)
        {
            ThrowIfDisposed();
            if (trainData != null) trainData.ThrowIfDisposed();

            return ml_StatModel_train_11(nativeObj, trainData.getNativeObjAddr());


        }


        //
        // C++:  bool cv::ml::StatModel::train(Mat samples, int layout, Mat responses)
        //

        /**
         * Trains the statistical model
         *
         *     param samples training samples
         *     param layout See ml::SampleTypes.
         *     param responses vector of responses associated with the training samples.
         * return automatically generated
         */
        public bool train(Mat samples, int layout, Mat responses)
        {
            ThrowIfDisposed();
            if (samples != null) samples.ThrowIfDisposed();
            if (responses != null) responses.ThrowIfDisposed();

            return ml_StatModel_train_12(nativeObj, samples.nativeObj, layout, responses.nativeObj);


        }


        //
        // C++:  float cv::ml::StatModel::calcError(Ptr_TrainData data, bool test, Mat& resp)
        //

        /**
         * Computes error on the training or test dataset
         *
         *     param data the training data
         *     param test if true, the error is computed over the test subset of the data, otherwise it's
         *         computed over the training subset of the data. Please note that if you loaded a completely
         *         different dataset to evaluate already trained classifier, you will probably want not to set
         *         the test subset at all with TrainData::setTrainTestSplitRatio and specify test=false, so
         *         that the error is computed for the whole new set. Yes, this sounds a bit confusing.
         *     param resp the optional output responses.
         *
         *     The method uses StatModel::predict to compute the error. For regression models the error is
         *     computed as RMS, for classifiers - as a percent of missclassified samples (0%-100%).
         * return automatically generated
         */
        public float calcError(TrainData data, bool test, Mat resp)
        {
            ThrowIfDisposed();
            if (data != null) data.ThrowIfDisposed();
            if (resp != null) resp.ThrowIfDisposed();

            return ml_StatModel_calcError_10(nativeObj, data.getNativeObjAddr(), test, resp.nativeObj);


        }


        //
        // C++:  float cv::ml::StatModel::predict(Mat samples, Mat& results = Mat(), int flags = 0)
        //

        /**
         * Predicts response(s) for the provided sample(s)
         *
         *     param samples The input samples, floating-point matrix
         *     param results The optional output matrix of results.
         *     param flags The optional flags, model-dependent. See cv::ml::StatModel::Flags.
         * return automatically generated
         */
        public virtual float predict(Mat samples, Mat results, int flags)
        {
            ThrowIfDisposed();
            if (samples != null) samples.ThrowIfDisposed();
            if (results != null) results.ThrowIfDisposed();

            return ml_StatModel_predict_10(nativeObj, samples.nativeObj, results.nativeObj, flags);


        }

        /**
         * Predicts response(s) for the provided sample(s)
         *
         *     param samples The input samples, floating-point matrix
         *     param results The optional output matrix of results.
         * return automatically generated
         */
        public virtual float predict(Mat samples, Mat results)
        {
            ThrowIfDisposed();
            if (samples != null) samples.ThrowIfDisposed();
            if (results != null) results.ThrowIfDisposed();

            return ml_StatModel_predict_11(nativeObj, samples.nativeObj, results.nativeObj);


        }

        /**
         * Predicts response(s) for the provided sample(s)
         *
         *     param samples The input samples, floating-point matrix
         * return automatically generated
         */
        public virtual float predict(Mat samples)
        {
            ThrowIfDisposed();
            if (samples != null) samples.ThrowIfDisposed();

            return ml_StatModel_predict_12(nativeObj, samples.nativeObj);


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  int cv::ml::StatModel::getVarCount()
        [DllImport(LIBNAME)]
        private static extern int ml_StatModel_getVarCount_10(IntPtr nativeObj);

        // C++:  bool cv::ml::StatModel::empty()
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool ml_StatModel_empty_10(IntPtr nativeObj);

        // C++:  bool cv::ml::StatModel::isTrained()
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool ml_StatModel_isTrained_10(IntPtr nativeObj);

        // C++:  bool cv::ml::StatModel::isClassifier()
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool ml_StatModel_isClassifier_10(IntPtr nativeObj);

        // C++:  bool cv::ml::StatModel::train(Ptr_TrainData trainData, int flags = 0)
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool ml_StatModel_train_10(IntPtr nativeObj, IntPtr trainData_nativeObj, int flags);
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool ml_StatModel_train_11(IntPtr nativeObj, IntPtr trainData_nativeObj);

        // C++:  bool cv::ml::StatModel::train(Mat samples, int layout, Mat responses)
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool ml_StatModel_train_12(IntPtr nativeObj, IntPtr samples_nativeObj, int layout, IntPtr responses_nativeObj);

        // C++:  float cv::ml::StatModel::calcError(Ptr_TrainData data, bool test, Mat& resp)
        [DllImport(LIBNAME)]
        private static extern float ml_StatModel_calcError_10(IntPtr nativeObj, IntPtr data_nativeObj, [MarshalAs(UnmanagedType.U1)] bool test, IntPtr resp_nativeObj);

        // C++:  float cv::ml::StatModel::predict(Mat samples, Mat& results = Mat(), int flags = 0)
        [DllImport(LIBNAME)]
        private static extern float ml_StatModel_predict_10(IntPtr nativeObj, IntPtr samples_nativeObj, IntPtr results_nativeObj, int flags);
        [DllImport(LIBNAME)]
        private static extern float ml_StatModel_predict_11(IntPtr nativeObj, IntPtr samples_nativeObj, IntPtr results_nativeObj);
        [DllImport(LIBNAME)]
        private static extern float ml_StatModel_predict_12(IntPtr nativeObj, IntPtr samples_nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void ml_StatModel_delete(IntPtr nativeObj);

    }
}
