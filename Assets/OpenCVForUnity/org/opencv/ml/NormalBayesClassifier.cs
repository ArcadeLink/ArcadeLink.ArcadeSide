
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.MlModule
{

    // C++: class NormalBayesClassifier
    /**
     * Bayes classifier for normally distributed data.
     *
     * SEE: REF: ml_intro_bayes
     */

    public class NormalBayesClassifier : StatModel
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
                        ml_NormalBayesClassifier_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal NormalBayesClassifier(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new NormalBayesClassifier __fromPtr__(IntPtr addr) { return new NormalBayesClassifier(addr); }

        //
        // C++:  float cv::ml::NormalBayesClassifier::predictProb(Mat inputs, Mat& outputs, Mat& outputProbs, int flags = 0)
        //

        /**
         * Predicts the response for sample(s).
         *
         *     The method estimates the most probable classes for input vectors. Input vectors (one or more)
         *     are stored as rows of the matrix inputs. In case of multiple input vectors, there should be one
         *     output vector outputs. The predicted class for a single input vector is returned by the method.
         *     The vector outputProbs contains the output probabilities corresponding to each element of
         *     result.
         * param inputs automatically generated
         * param outputs automatically generated
         * param outputProbs automatically generated
         * param flags automatically generated
         * return automatically generated
         */
        public float predictProb(Mat inputs, Mat outputs, Mat outputProbs, int flags)
        {
            ThrowIfDisposed();
            if (inputs != null) inputs.ThrowIfDisposed();
            if (outputs != null) outputs.ThrowIfDisposed();
            if (outputProbs != null) outputProbs.ThrowIfDisposed();

            return ml_NormalBayesClassifier_predictProb_10(nativeObj, inputs.nativeObj, outputs.nativeObj, outputProbs.nativeObj, flags);


        }

        /**
         * Predicts the response for sample(s).
         *
         *     The method estimates the most probable classes for input vectors. Input vectors (one or more)
         *     are stored as rows of the matrix inputs. In case of multiple input vectors, there should be one
         *     output vector outputs. The predicted class for a single input vector is returned by the method.
         *     The vector outputProbs contains the output probabilities corresponding to each element of
         *     result.
         * param inputs automatically generated
         * param outputs automatically generated
         * param outputProbs automatically generated
         * return automatically generated
         */
        public float predictProb(Mat inputs, Mat outputs, Mat outputProbs)
        {
            ThrowIfDisposed();
            if (inputs != null) inputs.ThrowIfDisposed();
            if (outputs != null) outputs.ThrowIfDisposed();
            if (outputProbs != null) outputProbs.ThrowIfDisposed();

            return ml_NormalBayesClassifier_predictProb_11(nativeObj, inputs.nativeObj, outputs.nativeObj, outputProbs.nativeObj);


        }


        //
        // C++: static Ptr_NormalBayesClassifier cv::ml::NormalBayesClassifier::create()
        //

        /**
         * Creates empty model
         * Use StatModel::train to train the model after creation.
         * return automatically generated
         */
        public static NormalBayesClassifier create()
        {


            return NormalBayesClassifier.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ml_NormalBayesClassifier_create_10()));


        }


        //
        // C++: static Ptr_NormalBayesClassifier cv::ml::NormalBayesClassifier::load(String filepath, String nodeName = String())
        //

        /**
         * Loads and creates a serialized NormalBayesClassifier from a file
         *
         * Use NormalBayesClassifier::save to serialize and store an NormalBayesClassifier to disk.
         * Load the NormalBayesClassifier from this file again, by calling this function with the path to the file.
         * Optionally specify the node for the file containing the classifier
         *
         * param filepath path to serialized NormalBayesClassifier
         * param nodeName name of node containing the classifier
         * return automatically generated
         */
        public static NormalBayesClassifier load(string filepath, string nodeName)
        {


            return NormalBayesClassifier.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ml_NormalBayesClassifier_load_10(filepath, nodeName)));


        }

        /**
         * Loads and creates a serialized NormalBayesClassifier from a file
         *
         * Use NormalBayesClassifier::save to serialize and store an NormalBayesClassifier to disk.
         * Load the NormalBayesClassifier from this file again, by calling this function with the path to the file.
         * Optionally specify the node for the file containing the classifier
         *
         * param filepath path to serialized NormalBayesClassifier
         * return automatically generated
         */
        public static NormalBayesClassifier load(string filepath)
        {


            return NormalBayesClassifier.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ml_NormalBayesClassifier_load_11(filepath)));


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  float cv::ml::NormalBayesClassifier::predictProb(Mat inputs, Mat& outputs, Mat& outputProbs, int flags = 0)
        [DllImport(LIBNAME)]
        private static extern float ml_NormalBayesClassifier_predictProb_10(IntPtr nativeObj, IntPtr inputs_nativeObj, IntPtr outputs_nativeObj, IntPtr outputProbs_nativeObj, int flags);
        [DllImport(LIBNAME)]
        private static extern float ml_NormalBayesClassifier_predictProb_11(IntPtr nativeObj, IntPtr inputs_nativeObj, IntPtr outputs_nativeObj, IntPtr outputProbs_nativeObj);

        // C++: static Ptr_NormalBayesClassifier cv::ml::NormalBayesClassifier::create()
        [DllImport(LIBNAME)]
        private static extern IntPtr ml_NormalBayesClassifier_create_10();

        // C++: static Ptr_NormalBayesClassifier cv::ml::NormalBayesClassifier::load(String filepath, String nodeName = String())
        [DllImport(LIBNAME)]
        private static extern IntPtr ml_NormalBayesClassifier_load_10(string filepath, string nodeName);
        [DllImport(LIBNAME)]
        private static extern IntPtr ml_NormalBayesClassifier_load_11(string filepath);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void ml_NormalBayesClassifier_delete(IntPtr nativeObj);

    }
}
