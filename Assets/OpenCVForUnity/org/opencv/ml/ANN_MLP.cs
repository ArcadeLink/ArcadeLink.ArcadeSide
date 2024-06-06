
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.MlModule
{

    // C++: class ANN_MLP
    /**
     * Artificial Neural Networks - Multi-Layer Perceptrons.
     *
     * Unlike many other models in ML that are constructed and trained at once, in the MLP model these
     * steps are separated. First, a network with the specified topology is created using the non-default
     * constructor or the method ANN_MLP::create. All the weights are set to zeros. Then, the network is
     * trained using a set of input and output vectors. The training procedure can be repeated more than
     * once, that is, the weights can be adjusted based on the new training data.
     *
     * Additional flags for StatModel::train are available: ANN_MLP::TrainFlags.
     *
     * SEE: REF: ml_intro_ann
     */

    public class ANN_MLP : StatModel
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
                        ml_ANN_1MLP_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal ANN_MLP(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new ANN_MLP __fromPtr__(IntPtr addr) { return new ANN_MLP(addr); }

        // C++: enum cv.ml.ANN_MLP.ActivationFunctions
        public const int IDENTITY = 0;
        public const int SIGMOID_SYM = 1;
        public const int GAUSSIAN = 2;
        public const int RELU = 3;
        public const int LEAKYRELU = 4;
        // C++: enum cv.ml.ANN_MLP.TrainFlags
        public const int UPDATE_WEIGHTS = 1;
        public const int NO_INPUT_SCALE = 2;
        public const int NO_OUTPUT_SCALE = 4;
        // C++: enum cv.ml.ANN_MLP.TrainingMethods
        public const int BACKPROP = 0;
        public const int RPROP = 1;
        public const int ANNEAL = 2;
        //
        // C++:  void cv::ml::ANN_MLP::setTrainMethod(int method, double param1 = 0, double param2 = 0)
        //

        /**
         * Sets training method and common parameters.
         *     param method Default value is ANN_MLP::RPROP. See ANN_MLP::TrainingMethods.
         *     param param1 passed to setRpropDW0 for ANN_MLP::RPROP and to setBackpropWeightScale for ANN_MLP::BACKPROP and to initialT for ANN_MLP::ANNEAL.
         *     param param2 passed to setRpropDWMin for ANN_MLP::RPROP and to setBackpropMomentumScale for ANN_MLP::BACKPROP and to finalT for ANN_MLP::ANNEAL.
         */
        public void setTrainMethod(int method, double param1, double param2)
        {
            ThrowIfDisposed();

            ml_ANN_1MLP_setTrainMethod_10(nativeObj, method, param1, param2);


        }

        /**
         * Sets training method and common parameters.
         *     param method Default value is ANN_MLP::RPROP. See ANN_MLP::TrainingMethods.
         *     param param1 passed to setRpropDW0 for ANN_MLP::RPROP and to setBackpropWeightScale for ANN_MLP::BACKPROP and to initialT for ANN_MLP::ANNEAL.
         */
        public void setTrainMethod(int method, double param1)
        {
            ThrowIfDisposed();

            ml_ANN_1MLP_setTrainMethod_11(nativeObj, method, param1);


        }

        /**
         * Sets training method and common parameters.
         *     param method Default value is ANN_MLP::RPROP. See ANN_MLP::TrainingMethods.
         */
        public void setTrainMethod(int method)
        {
            ThrowIfDisposed();

            ml_ANN_1MLP_setTrainMethod_12(nativeObj, method);


        }


        //
        // C++:  int cv::ml::ANN_MLP::getTrainMethod()
        //

        /**
         * Returns current training method
         * return automatically generated
         */
        public int getTrainMethod()
        {
            ThrowIfDisposed();

            return ml_ANN_1MLP_getTrainMethod_10(nativeObj);


        }


        //
        // C++:  void cv::ml::ANN_MLP::setActivationFunction(int type, double param1 = 0, double param2 = 0)
        //

        /**
         * Initialize the activation function for each neuron.
         *     Currently the default and the only fully supported activation function is ANN_MLP::SIGMOID_SYM.
         *     param type The type of activation function. See ANN_MLP::ActivationFunctions.
         *     param param1 The first parameter of the activation function, \(\alpha\). Default value is 0.
         *     param param2 The second parameter of the activation function, \(\beta\). Default value is 0.
         */
        public void setActivationFunction(int type, double param1, double param2)
        {
            ThrowIfDisposed();

            ml_ANN_1MLP_setActivationFunction_10(nativeObj, type, param1, param2);


        }

        /**
         * Initialize the activation function for each neuron.
         *     Currently the default and the only fully supported activation function is ANN_MLP::SIGMOID_SYM.
         *     param type The type of activation function. See ANN_MLP::ActivationFunctions.
         *     param param1 The first parameter of the activation function, \(\alpha\). Default value is 0.
         */
        public void setActivationFunction(int type, double param1)
        {
            ThrowIfDisposed();

            ml_ANN_1MLP_setActivationFunction_11(nativeObj, type, param1);


        }

        /**
         * Initialize the activation function for each neuron.
         *     Currently the default and the only fully supported activation function is ANN_MLP::SIGMOID_SYM.
         *     param type The type of activation function. See ANN_MLP::ActivationFunctions.
         */
        public void setActivationFunction(int type)
        {
            ThrowIfDisposed();

            ml_ANN_1MLP_setActivationFunction_12(nativeObj, type);


        }


        //
        // C++:  void cv::ml::ANN_MLP::setLayerSizes(Mat _layer_sizes)
        //

        /**
         * Integer vector specifying the number of neurons in each layer including the input and output layers.
         *     The very first element specifies the number of elements in the input layer.
         *     The last element - number of elements in the output layer. Default value is empty Mat.
         * SEE: getLayerSizes
         * param _layer_sizes automatically generated
         */
        public void setLayerSizes(Mat _layer_sizes)
        {
            ThrowIfDisposed();
            if (_layer_sizes != null) _layer_sizes.ThrowIfDisposed();

            ml_ANN_1MLP_setLayerSizes_10(nativeObj, _layer_sizes.nativeObj);


        }


        //
        // C++:  Mat cv::ml::ANN_MLP::getLayerSizes()
        //

        /**
         * Integer vector specifying the number of neurons in each layer including the input and output layers.
         *     The very first element specifies the number of elements in the input layer.
         *     The last element - number of elements in the output layer.
         * SEE: setLayerSizes
         * return automatically generated
         */
        public Mat getLayerSizes()
        {
            ThrowIfDisposed();

            return new Mat(DisposableObject.ThrowIfNullIntPtr(ml_ANN_1MLP_getLayerSizes_10(nativeObj)));


        }


        //
        // C++:  TermCriteria cv::ml::ANN_MLP::getTermCriteria()
        //

        /**
         * SEE: setTermCriteria
         * return automatically generated
         */
        public TermCriteria getTermCriteria()
        {
            ThrowIfDisposed();

            double[] tmpArray = new double[3];
            ml_ANN_1MLP_getTermCriteria_10(nativeObj, tmpArray);
            TermCriteria retVal = new TermCriteria(tmpArray);

            return retVal;
        }


        //
        // C++:  void cv::ml::ANN_MLP::setTermCriteria(TermCriteria val)
        //

        /**
         *  getTermCriteria SEE: getTermCriteria
         * param val automatically generated
         */
        public void setTermCriteria(TermCriteria val)
        {
            ThrowIfDisposed();

            ml_ANN_1MLP_setTermCriteria_10(nativeObj, val.type, val.maxCount, val.epsilon);


        }


        //
        // C++:  double cv::ml::ANN_MLP::getBackpropWeightScale()
        //

        /**
         * SEE: setBackpropWeightScale
         * return automatically generated
         */
        public double getBackpropWeightScale()
        {
            ThrowIfDisposed();

            return ml_ANN_1MLP_getBackpropWeightScale_10(nativeObj);


        }


        //
        // C++:  void cv::ml::ANN_MLP::setBackpropWeightScale(double val)
        //

        /**
         *  getBackpropWeightScale SEE: getBackpropWeightScale
         * param val automatically generated
         */
        public void setBackpropWeightScale(double val)
        {
            ThrowIfDisposed();

            ml_ANN_1MLP_setBackpropWeightScale_10(nativeObj, val);


        }


        //
        // C++:  double cv::ml::ANN_MLP::getBackpropMomentumScale()
        //

        /**
         * SEE: setBackpropMomentumScale
         * return automatically generated
         */
        public double getBackpropMomentumScale()
        {
            ThrowIfDisposed();

            return ml_ANN_1MLP_getBackpropMomentumScale_10(nativeObj);


        }


        //
        // C++:  void cv::ml::ANN_MLP::setBackpropMomentumScale(double val)
        //

        /**
         *  getBackpropMomentumScale SEE: getBackpropMomentumScale
         * param val automatically generated
         */
        public void setBackpropMomentumScale(double val)
        {
            ThrowIfDisposed();

            ml_ANN_1MLP_setBackpropMomentumScale_10(nativeObj, val);


        }


        //
        // C++:  double cv::ml::ANN_MLP::getRpropDW0()
        //

        /**
         * SEE: setRpropDW0
         * return automatically generated
         */
        public double getRpropDW0()
        {
            ThrowIfDisposed();

            return ml_ANN_1MLP_getRpropDW0_10(nativeObj);


        }


        //
        // C++:  void cv::ml::ANN_MLP::setRpropDW0(double val)
        //

        /**
         *  getRpropDW0 SEE: getRpropDW0
         * param val automatically generated
         */
        public void setRpropDW0(double val)
        {
            ThrowIfDisposed();

            ml_ANN_1MLP_setRpropDW0_10(nativeObj, val);


        }


        //
        // C++:  double cv::ml::ANN_MLP::getRpropDWPlus()
        //

        /**
         * SEE: setRpropDWPlus
         * return automatically generated
         */
        public double getRpropDWPlus()
        {
            ThrowIfDisposed();

            return ml_ANN_1MLP_getRpropDWPlus_10(nativeObj);


        }


        //
        // C++:  void cv::ml::ANN_MLP::setRpropDWPlus(double val)
        //

        /**
         *  getRpropDWPlus SEE: getRpropDWPlus
         * param val automatically generated
         */
        public void setRpropDWPlus(double val)
        {
            ThrowIfDisposed();

            ml_ANN_1MLP_setRpropDWPlus_10(nativeObj, val);


        }


        //
        // C++:  double cv::ml::ANN_MLP::getRpropDWMinus()
        //

        /**
         * SEE: setRpropDWMinus
         * return automatically generated
         */
        public double getRpropDWMinus()
        {
            ThrowIfDisposed();

            return ml_ANN_1MLP_getRpropDWMinus_10(nativeObj);


        }


        //
        // C++:  void cv::ml::ANN_MLP::setRpropDWMinus(double val)
        //

        /**
         *  getRpropDWMinus SEE: getRpropDWMinus
         * param val automatically generated
         */
        public void setRpropDWMinus(double val)
        {
            ThrowIfDisposed();

            ml_ANN_1MLP_setRpropDWMinus_10(nativeObj, val);


        }


        //
        // C++:  double cv::ml::ANN_MLP::getRpropDWMin()
        //

        /**
         * SEE: setRpropDWMin
         * return automatically generated
         */
        public double getRpropDWMin()
        {
            ThrowIfDisposed();

            return ml_ANN_1MLP_getRpropDWMin_10(nativeObj);


        }


        //
        // C++:  void cv::ml::ANN_MLP::setRpropDWMin(double val)
        //

        /**
         *  getRpropDWMin SEE: getRpropDWMin
         * param val automatically generated
         */
        public void setRpropDWMin(double val)
        {
            ThrowIfDisposed();

            ml_ANN_1MLP_setRpropDWMin_10(nativeObj, val);


        }


        //
        // C++:  double cv::ml::ANN_MLP::getRpropDWMax()
        //

        /**
         * SEE: setRpropDWMax
         * return automatically generated
         */
        public double getRpropDWMax()
        {
            ThrowIfDisposed();

            return ml_ANN_1MLP_getRpropDWMax_10(nativeObj);


        }


        //
        // C++:  void cv::ml::ANN_MLP::setRpropDWMax(double val)
        //

        /**
         *  getRpropDWMax SEE: getRpropDWMax
         * param val automatically generated
         */
        public void setRpropDWMax(double val)
        {
            ThrowIfDisposed();

            ml_ANN_1MLP_setRpropDWMax_10(nativeObj, val);


        }


        //
        // C++:  double cv::ml::ANN_MLP::getAnnealInitialT()
        //

        /**
         * SEE: setAnnealInitialT
         * return automatically generated
         */
        public double getAnnealInitialT()
        {
            ThrowIfDisposed();

            return ml_ANN_1MLP_getAnnealInitialT_10(nativeObj);


        }


        //
        // C++:  void cv::ml::ANN_MLP::setAnnealInitialT(double val)
        //

        /**
         *  getAnnealInitialT SEE: getAnnealInitialT
         * param val automatically generated
         */
        public void setAnnealInitialT(double val)
        {
            ThrowIfDisposed();

            ml_ANN_1MLP_setAnnealInitialT_10(nativeObj, val);


        }


        //
        // C++:  double cv::ml::ANN_MLP::getAnnealFinalT()
        //

        /**
         * SEE: setAnnealFinalT
         * return automatically generated
         */
        public double getAnnealFinalT()
        {
            ThrowIfDisposed();

            return ml_ANN_1MLP_getAnnealFinalT_10(nativeObj);


        }


        //
        // C++:  void cv::ml::ANN_MLP::setAnnealFinalT(double val)
        //

        /**
         *  getAnnealFinalT SEE: getAnnealFinalT
         * param val automatically generated
         */
        public void setAnnealFinalT(double val)
        {
            ThrowIfDisposed();

            ml_ANN_1MLP_setAnnealFinalT_10(nativeObj, val);


        }


        //
        // C++:  double cv::ml::ANN_MLP::getAnnealCoolingRatio()
        //

        /**
         * SEE: setAnnealCoolingRatio
         * return automatically generated
         */
        public double getAnnealCoolingRatio()
        {
            ThrowIfDisposed();

            return ml_ANN_1MLP_getAnnealCoolingRatio_10(nativeObj);


        }


        //
        // C++:  void cv::ml::ANN_MLP::setAnnealCoolingRatio(double val)
        //

        /**
         *  getAnnealCoolingRatio SEE: getAnnealCoolingRatio
         * param val automatically generated
         */
        public void setAnnealCoolingRatio(double val)
        {
            ThrowIfDisposed();

            ml_ANN_1MLP_setAnnealCoolingRatio_10(nativeObj, val);


        }


        //
        // C++:  int cv::ml::ANN_MLP::getAnnealItePerStep()
        //

        /**
         * SEE: setAnnealItePerStep
         * return automatically generated
         */
        public int getAnnealItePerStep()
        {
            ThrowIfDisposed();

            return ml_ANN_1MLP_getAnnealItePerStep_10(nativeObj);


        }


        //
        // C++:  void cv::ml::ANN_MLP::setAnnealItePerStep(int val)
        //

        /**
         *  getAnnealItePerStep SEE: getAnnealItePerStep
         * param val automatically generated
         */
        public void setAnnealItePerStep(int val)
        {
            ThrowIfDisposed();

            ml_ANN_1MLP_setAnnealItePerStep_10(nativeObj, val);


        }


        //
        // C++:  Mat cv::ml::ANN_MLP::getWeights(int layerIdx)
        //

        public Mat getWeights(int layerIdx)
        {
            ThrowIfDisposed();

            return new Mat(DisposableObject.ThrowIfNullIntPtr(ml_ANN_1MLP_getWeights_10(nativeObj, layerIdx)));


        }


        //
        // C++: static Ptr_ANN_MLP cv::ml::ANN_MLP::create()
        //

        /**
         * Creates empty model
         *
         *     Use StatModel::train to train the model, Algorithm::load&lt;ANN_MLP&gt;(filename) to load the pre-trained model.
         *     Note that the train method has optional flags: ANN_MLP::TrainFlags.
         * return automatically generated
         */
        public static ANN_MLP create()
        {


            return ANN_MLP.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ml_ANN_1MLP_create_10()));


        }


        //
        // C++: static Ptr_ANN_MLP cv::ml::ANN_MLP::load(String filepath)
        //

        /**
         * Loads and creates a serialized ANN from a file
         *
         * Use ANN::save to serialize and store an ANN to disk.
         * Load the ANN from this file again, by calling this function with the path to the file.
         *
         * param filepath path to serialized ANN
         * return automatically generated
         */
        public static ANN_MLP load(string filepath)
        {


            return ANN_MLP.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ml_ANN_1MLP_load_10(filepath)));


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  void cv::ml::ANN_MLP::setTrainMethod(int method, double param1 = 0, double param2 = 0)
        [DllImport(LIBNAME)]
        private static extern void ml_ANN_1MLP_setTrainMethod_10(IntPtr nativeObj, int method, double param1, double param2);
        [DllImport(LIBNAME)]
        private static extern void ml_ANN_1MLP_setTrainMethod_11(IntPtr nativeObj, int method, double param1);
        [DllImport(LIBNAME)]
        private static extern void ml_ANN_1MLP_setTrainMethod_12(IntPtr nativeObj, int method);

        // C++:  int cv::ml::ANN_MLP::getTrainMethod()
        [DllImport(LIBNAME)]
        private static extern int ml_ANN_1MLP_getTrainMethod_10(IntPtr nativeObj);

        // C++:  void cv::ml::ANN_MLP::setActivationFunction(int type, double param1 = 0, double param2 = 0)
        [DllImport(LIBNAME)]
        private static extern void ml_ANN_1MLP_setActivationFunction_10(IntPtr nativeObj, int type, double param1, double param2);
        [DllImport(LIBNAME)]
        private static extern void ml_ANN_1MLP_setActivationFunction_11(IntPtr nativeObj, int type, double param1);
        [DllImport(LIBNAME)]
        private static extern void ml_ANN_1MLP_setActivationFunction_12(IntPtr nativeObj, int type);

        // C++:  void cv::ml::ANN_MLP::setLayerSizes(Mat _layer_sizes)
        [DllImport(LIBNAME)]
        private static extern void ml_ANN_1MLP_setLayerSizes_10(IntPtr nativeObj, IntPtr _layer_sizes_nativeObj);

        // C++:  Mat cv::ml::ANN_MLP::getLayerSizes()
        [DllImport(LIBNAME)]
        private static extern IntPtr ml_ANN_1MLP_getLayerSizes_10(IntPtr nativeObj);

        // C++:  TermCriteria cv::ml::ANN_MLP::getTermCriteria()
        [DllImport(LIBNAME)]
        private static extern void ml_ANN_1MLP_getTermCriteria_10(IntPtr nativeObj, double[] retVal);

        // C++:  void cv::ml::ANN_MLP::setTermCriteria(TermCriteria val)
        [DllImport(LIBNAME)]
        private static extern void ml_ANN_1MLP_setTermCriteria_10(IntPtr nativeObj, int val_type, int val_maxCount, double val_epsilon);

        // C++:  double cv::ml::ANN_MLP::getBackpropWeightScale()
        [DllImport(LIBNAME)]
        private static extern double ml_ANN_1MLP_getBackpropWeightScale_10(IntPtr nativeObj);

        // C++:  void cv::ml::ANN_MLP::setBackpropWeightScale(double val)
        [DllImport(LIBNAME)]
        private static extern void ml_ANN_1MLP_setBackpropWeightScale_10(IntPtr nativeObj, double val);

        // C++:  double cv::ml::ANN_MLP::getBackpropMomentumScale()
        [DllImport(LIBNAME)]
        private static extern double ml_ANN_1MLP_getBackpropMomentumScale_10(IntPtr nativeObj);

        // C++:  void cv::ml::ANN_MLP::setBackpropMomentumScale(double val)
        [DllImport(LIBNAME)]
        private static extern void ml_ANN_1MLP_setBackpropMomentumScale_10(IntPtr nativeObj, double val);

        // C++:  double cv::ml::ANN_MLP::getRpropDW0()
        [DllImport(LIBNAME)]
        private static extern double ml_ANN_1MLP_getRpropDW0_10(IntPtr nativeObj);

        // C++:  void cv::ml::ANN_MLP::setRpropDW0(double val)
        [DllImport(LIBNAME)]
        private static extern void ml_ANN_1MLP_setRpropDW0_10(IntPtr nativeObj, double val);

        // C++:  double cv::ml::ANN_MLP::getRpropDWPlus()
        [DllImport(LIBNAME)]
        private static extern double ml_ANN_1MLP_getRpropDWPlus_10(IntPtr nativeObj);

        // C++:  void cv::ml::ANN_MLP::setRpropDWPlus(double val)
        [DllImport(LIBNAME)]
        private static extern void ml_ANN_1MLP_setRpropDWPlus_10(IntPtr nativeObj, double val);

        // C++:  double cv::ml::ANN_MLP::getRpropDWMinus()
        [DllImport(LIBNAME)]
        private static extern double ml_ANN_1MLP_getRpropDWMinus_10(IntPtr nativeObj);

        // C++:  void cv::ml::ANN_MLP::setRpropDWMinus(double val)
        [DllImport(LIBNAME)]
        private static extern void ml_ANN_1MLP_setRpropDWMinus_10(IntPtr nativeObj, double val);

        // C++:  double cv::ml::ANN_MLP::getRpropDWMin()
        [DllImport(LIBNAME)]
        private static extern double ml_ANN_1MLP_getRpropDWMin_10(IntPtr nativeObj);

        // C++:  void cv::ml::ANN_MLP::setRpropDWMin(double val)
        [DllImport(LIBNAME)]
        private static extern void ml_ANN_1MLP_setRpropDWMin_10(IntPtr nativeObj, double val);

        // C++:  double cv::ml::ANN_MLP::getRpropDWMax()
        [DllImport(LIBNAME)]
        private static extern double ml_ANN_1MLP_getRpropDWMax_10(IntPtr nativeObj);

        // C++:  void cv::ml::ANN_MLP::setRpropDWMax(double val)
        [DllImport(LIBNAME)]
        private static extern void ml_ANN_1MLP_setRpropDWMax_10(IntPtr nativeObj, double val);

        // C++:  double cv::ml::ANN_MLP::getAnnealInitialT()
        [DllImport(LIBNAME)]
        private static extern double ml_ANN_1MLP_getAnnealInitialT_10(IntPtr nativeObj);

        // C++:  void cv::ml::ANN_MLP::setAnnealInitialT(double val)
        [DllImport(LIBNAME)]
        private static extern void ml_ANN_1MLP_setAnnealInitialT_10(IntPtr nativeObj, double val);

        // C++:  double cv::ml::ANN_MLP::getAnnealFinalT()
        [DllImport(LIBNAME)]
        private static extern double ml_ANN_1MLP_getAnnealFinalT_10(IntPtr nativeObj);

        // C++:  void cv::ml::ANN_MLP::setAnnealFinalT(double val)
        [DllImport(LIBNAME)]
        private static extern void ml_ANN_1MLP_setAnnealFinalT_10(IntPtr nativeObj, double val);

        // C++:  double cv::ml::ANN_MLP::getAnnealCoolingRatio()
        [DllImport(LIBNAME)]
        private static extern double ml_ANN_1MLP_getAnnealCoolingRatio_10(IntPtr nativeObj);

        // C++:  void cv::ml::ANN_MLP::setAnnealCoolingRatio(double val)
        [DllImport(LIBNAME)]
        private static extern void ml_ANN_1MLP_setAnnealCoolingRatio_10(IntPtr nativeObj, double val);

        // C++:  int cv::ml::ANN_MLP::getAnnealItePerStep()
        [DllImport(LIBNAME)]
        private static extern int ml_ANN_1MLP_getAnnealItePerStep_10(IntPtr nativeObj);

        // C++:  void cv::ml::ANN_MLP::setAnnealItePerStep(int val)
        [DllImport(LIBNAME)]
        private static extern void ml_ANN_1MLP_setAnnealItePerStep_10(IntPtr nativeObj, int val);

        // C++:  Mat cv::ml::ANN_MLP::getWeights(int layerIdx)
        [DllImport(LIBNAME)]
        private static extern IntPtr ml_ANN_1MLP_getWeights_10(IntPtr nativeObj, int layerIdx);

        // C++: static Ptr_ANN_MLP cv::ml::ANN_MLP::create()
        [DllImport(LIBNAME)]
        private static extern IntPtr ml_ANN_1MLP_create_10();

        // C++: static Ptr_ANN_MLP cv::ml::ANN_MLP::load(String filepath)
        [DllImport(LIBNAME)]
        private static extern IntPtr ml_ANN_1MLP_load_10(string filepath);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void ml_ANN_1MLP_delete(IntPtr nativeObj);

    }
}
