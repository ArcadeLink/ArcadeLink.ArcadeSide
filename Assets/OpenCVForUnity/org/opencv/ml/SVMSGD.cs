
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.MlModule
{

    // C++: class SVMSGD
    /**
     * *************************************************************************************\
     * Stochastic Gradient Descent SVM Classifier                      *
     * \***************************************************************************************
     */

    public class SVMSGD : StatModel
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
                        ml_SVMSGD_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal SVMSGD(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new SVMSGD __fromPtr__(IntPtr addr) { return new SVMSGD(addr); }

        // C++: enum cv.ml.SVMSGD.MarginType
        public const int SOFT_MARGIN = 0;
        public const int HARD_MARGIN = 1;
        // C++: enum cv.ml.SVMSGD.SvmsgdType
        public const int SGD = 0;
        public const int ASGD = 1;
        //
        // C++:  Mat cv::ml::SVMSGD::getWeights()
        //

        /**
         * return the weights of the trained model (decision function f(x) = weights * x + shift).
         */
        public Mat getWeights()
        {
            ThrowIfDisposed();

            return new Mat(DisposableObject.ThrowIfNullIntPtr(ml_SVMSGD_getWeights_10(nativeObj)));


        }


        //
        // C++:  float cv::ml::SVMSGD::getShift()
        //

        /**
         * return the shift of the trained model (decision function f(x) = weights * x + shift).
         */
        public float getShift()
        {
            ThrowIfDisposed();

            return ml_SVMSGD_getShift_10(nativeObj);


        }


        //
        // C++: static Ptr_SVMSGD cv::ml::SVMSGD::create()
        //

        /**
         * Creates empty model.
         * Use StatModel::train to train the model. Since %SVMSGD has several parameters, you may want to
         * find the best parameters for your problem or use setOptimalParameters() to set some default parameters.
         * return automatically generated
         */
        public static SVMSGD create()
        {


            return SVMSGD.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ml_SVMSGD_create_10()));


        }


        //
        // C++: static Ptr_SVMSGD cv::ml::SVMSGD::load(String filepath, String nodeName = String())
        //

        /**
         * Loads and creates a serialized SVMSGD from a file
         *
         * Use SVMSGD::save to serialize and store an SVMSGD to disk.
         * Load the SVMSGD from this file again, by calling this function with the path to the file.
         * Optionally specify the node for the file containing the classifier
         *
         * param filepath path to serialized SVMSGD
         * param nodeName name of node containing the classifier
         * return automatically generated
         */
        public static SVMSGD load(string filepath, string nodeName)
        {


            return SVMSGD.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ml_SVMSGD_load_10(filepath, nodeName)));


        }

        /**
         * Loads and creates a serialized SVMSGD from a file
         *
         * Use SVMSGD::save to serialize and store an SVMSGD to disk.
         * Load the SVMSGD from this file again, by calling this function with the path to the file.
         * Optionally specify the node for the file containing the classifier
         *
         * param filepath path to serialized SVMSGD
         * return automatically generated
         */
        public static SVMSGD load(string filepath)
        {


            return SVMSGD.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ml_SVMSGD_load_11(filepath)));


        }


        //
        // C++:  void cv::ml::SVMSGD::setOptimalParameters(int svmsgdType = SVMSGD::ASGD, int marginType = SVMSGD::SOFT_MARGIN)
        //

        /**
         * Function sets optimal parameters values for chosen SVM SGD model.
         * param svmsgdType is the type of SVMSGD classifier.
         * param marginType is the type of margin constraint.
         */
        public void setOptimalParameters(int svmsgdType, int marginType)
        {
            ThrowIfDisposed();

            ml_SVMSGD_setOptimalParameters_10(nativeObj, svmsgdType, marginType);


        }

        /**
         * Function sets optimal parameters values for chosen SVM SGD model.
         * param svmsgdType is the type of SVMSGD classifier.
         */
        public void setOptimalParameters(int svmsgdType)
        {
            ThrowIfDisposed();

            ml_SVMSGD_setOptimalParameters_11(nativeObj, svmsgdType);


        }

        /**
         * Function sets optimal parameters values for chosen SVM SGD model.
         */
        public void setOptimalParameters()
        {
            ThrowIfDisposed();

            ml_SVMSGD_setOptimalParameters_12(nativeObj);


        }


        //
        // C++:  int cv::ml::SVMSGD::getSvmsgdType()
        //

        /**
         * SEE: setSvmsgdType
         * return automatically generated
         */
        public int getSvmsgdType()
        {
            ThrowIfDisposed();

            return ml_SVMSGD_getSvmsgdType_10(nativeObj);


        }


        //
        // C++:  void cv::ml::SVMSGD::setSvmsgdType(int svmsgdType)
        //

        /**
         *  getSvmsgdType SEE: getSvmsgdType
         * param svmsgdType automatically generated
         */
        public void setSvmsgdType(int svmsgdType)
        {
            ThrowIfDisposed();

            ml_SVMSGD_setSvmsgdType_10(nativeObj, svmsgdType);


        }


        //
        // C++:  int cv::ml::SVMSGD::getMarginType()
        //

        /**
         * SEE: setMarginType
         * return automatically generated
         */
        public int getMarginType()
        {
            ThrowIfDisposed();

            return ml_SVMSGD_getMarginType_10(nativeObj);


        }


        //
        // C++:  void cv::ml::SVMSGD::setMarginType(int marginType)
        //

        /**
         *  getMarginType SEE: getMarginType
         * param marginType automatically generated
         */
        public void setMarginType(int marginType)
        {
            ThrowIfDisposed();

            ml_SVMSGD_setMarginType_10(nativeObj, marginType);


        }


        //
        // C++:  float cv::ml::SVMSGD::getMarginRegularization()
        //

        /**
         * SEE: setMarginRegularization
         * return automatically generated
         */
        public float getMarginRegularization()
        {
            ThrowIfDisposed();

            return ml_SVMSGD_getMarginRegularization_10(nativeObj);


        }


        //
        // C++:  void cv::ml::SVMSGD::setMarginRegularization(float marginRegularization)
        //

        /**
         *  getMarginRegularization SEE: getMarginRegularization
         * param marginRegularization automatically generated
         */
        public void setMarginRegularization(float marginRegularization)
        {
            ThrowIfDisposed();

            ml_SVMSGD_setMarginRegularization_10(nativeObj, marginRegularization);


        }


        //
        // C++:  float cv::ml::SVMSGD::getInitialStepSize()
        //

        /**
         * SEE: setInitialStepSize
         * return automatically generated
         */
        public float getInitialStepSize()
        {
            ThrowIfDisposed();

            return ml_SVMSGD_getInitialStepSize_10(nativeObj);


        }


        //
        // C++:  void cv::ml::SVMSGD::setInitialStepSize(float InitialStepSize)
        //

        /**
         *  getInitialStepSize SEE: getInitialStepSize
         * param InitialStepSize automatically generated
         */
        public void setInitialStepSize(float InitialStepSize)
        {
            ThrowIfDisposed();

            ml_SVMSGD_setInitialStepSize_10(nativeObj, InitialStepSize);


        }


        //
        // C++:  float cv::ml::SVMSGD::getStepDecreasingPower()
        //

        /**
         * SEE: setStepDecreasingPower
         * return automatically generated
         */
        public float getStepDecreasingPower()
        {
            ThrowIfDisposed();

            return ml_SVMSGD_getStepDecreasingPower_10(nativeObj);


        }


        //
        // C++:  void cv::ml::SVMSGD::setStepDecreasingPower(float stepDecreasingPower)
        //

        /**
         *  getStepDecreasingPower SEE: getStepDecreasingPower
         * param stepDecreasingPower automatically generated
         */
        public void setStepDecreasingPower(float stepDecreasingPower)
        {
            ThrowIfDisposed();

            ml_SVMSGD_setStepDecreasingPower_10(nativeObj, stepDecreasingPower);


        }


        //
        // C++:  TermCriteria cv::ml::SVMSGD::getTermCriteria()
        //

        /**
         * SEE: setTermCriteria
         * return automatically generated
         */
        public TermCriteria getTermCriteria()
        {
            ThrowIfDisposed();

            double[] tmpArray = new double[3];
            ml_SVMSGD_getTermCriteria_10(nativeObj, tmpArray);
            TermCriteria retVal = new TermCriteria(tmpArray);

            return retVal;
        }


        //
        // C++:  void cv::ml::SVMSGD::setTermCriteria(TermCriteria val)
        //

        /**
         *  getTermCriteria SEE: getTermCriteria
         * param val automatically generated
         */
        public void setTermCriteria(TermCriteria val)
        {
            ThrowIfDisposed();

            ml_SVMSGD_setTermCriteria_10(nativeObj, val.type, val.maxCount, val.epsilon);


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  Mat cv::ml::SVMSGD::getWeights()
        [DllImport(LIBNAME)]
        private static extern IntPtr ml_SVMSGD_getWeights_10(IntPtr nativeObj);

        // C++:  float cv::ml::SVMSGD::getShift()
        [DllImport(LIBNAME)]
        private static extern float ml_SVMSGD_getShift_10(IntPtr nativeObj);

        // C++: static Ptr_SVMSGD cv::ml::SVMSGD::create()
        [DllImport(LIBNAME)]
        private static extern IntPtr ml_SVMSGD_create_10();

        // C++: static Ptr_SVMSGD cv::ml::SVMSGD::load(String filepath, String nodeName = String())
        [DllImport(LIBNAME)]
        private static extern IntPtr ml_SVMSGD_load_10(string filepath, string nodeName);
        [DllImport(LIBNAME)]
        private static extern IntPtr ml_SVMSGD_load_11(string filepath);

        // C++:  void cv::ml::SVMSGD::setOptimalParameters(int svmsgdType = SVMSGD::ASGD, int marginType = SVMSGD::SOFT_MARGIN)
        [DllImport(LIBNAME)]
        private static extern void ml_SVMSGD_setOptimalParameters_10(IntPtr nativeObj, int svmsgdType, int marginType);
        [DllImport(LIBNAME)]
        private static extern void ml_SVMSGD_setOptimalParameters_11(IntPtr nativeObj, int svmsgdType);
        [DllImport(LIBNAME)]
        private static extern void ml_SVMSGD_setOptimalParameters_12(IntPtr nativeObj);

        // C++:  int cv::ml::SVMSGD::getSvmsgdType()
        [DllImport(LIBNAME)]
        private static extern int ml_SVMSGD_getSvmsgdType_10(IntPtr nativeObj);

        // C++:  void cv::ml::SVMSGD::setSvmsgdType(int svmsgdType)
        [DllImport(LIBNAME)]
        private static extern void ml_SVMSGD_setSvmsgdType_10(IntPtr nativeObj, int svmsgdType);

        // C++:  int cv::ml::SVMSGD::getMarginType()
        [DllImport(LIBNAME)]
        private static extern int ml_SVMSGD_getMarginType_10(IntPtr nativeObj);

        // C++:  void cv::ml::SVMSGD::setMarginType(int marginType)
        [DllImport(LIBNAME)]
        private static extern void ml_SVMSGD_setMarginType_10(IntPtr nativeObj, int marginType);

        // C++:  float cv::ml::SVMSGD::getMarginRegularization()
        [DllImport(LIBNAME)]
        private static extern float ml_SVMSGD_getMarginRegularization_10(IntPtr nativeObj);

        // C++:  void cv::ml::SVMSGD::setMarginRegularization(float marginRegularization)
        [DllImport(LIBNAME)]
        private static extern void ml_SVMSGD_setMarginRegularization_10(IntPtr nativeObj, float marginRegularization);

        // C++:  float cv::ml::SVMSGD::getInitialStepSize()
        [DllImport(LIBNAME)]
        private static extern float ml_SVMSGD_getInitialStepSize_10(IntPtr nativeObj);

        // C++:  void cv::ml::SVMSGD::setInitialStepSize(float InitialStepSize)
        [DllImport(LIBNAME)]
        private static extern void ml_SVMSGD_setInitialStepSize_10(IntPtr nativeObj, float InitialStepSize);

        // C++:  float cv::ml::SVMSGD::getStepDecreasingPower()
        [DllImport(LIBNAME)]
        private static extern float ml_SVMSGD_getStepDecreasingPower_10(IntPtr nativeObj);

        // C++:  void cv::ml::SVMSGD::setStepDecreasingPower(float stepDecreasingPower)
        [DllImport(LIBNAME)]
        private static extern void ml_SVMSGD_setStepDecreasingPower_10(IntPtr nativeObj, float stepDecreasingPower);

        // C++:  TermCriteria cv::ml::SVMSGD::getTermCriteria()
        [DllImport(LIBNAME)]
        private static extern void ml_SVMSGD_getTermCriteria_10(IntPtr nativeObj, double[] retVal);

        // C++:  void cv::ml::SVMSGD::setTermCriteria(TermCriteria val)
        [DllImport(LIBNAME)]
        private static extern void ml_SVMSGD_setTermCriteria_10(IntPtr nativeObj, int val_type, int val_maxCount, double val_epsilon);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void ml_SVMSGD_delete(IntPtr nativeObj);

    }
}
