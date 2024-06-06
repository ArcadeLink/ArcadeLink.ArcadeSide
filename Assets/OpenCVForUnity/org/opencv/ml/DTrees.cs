
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.MlModule
{

    // C++: class DTrees
    /**
     * The class represents a single decision tree or a collection of decision trees.
     *
     * The current public interface of the class allows user to train only a single decision tree, however
     * the class is capable of storing multiple decision trees and using them for prediction (by summing
     * responses or using a voting schemes), and the derived from DTrees classes (such as RTrees and Boost)
     * use this capability to implement decision tree ensembles.
     *
     * SEE: REF: ml_intro_trees
     */

    public class DTrees : StatModel
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
                        ml_DTrees_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal DTrees(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new DTrees __fromPtr__(IntPtr addr) { return new DTrees(addr); }

        // C++: enum cv.ml.DTrees.Flags
        public const int PREDICT_AUTO = 0;
        public const int PREDICT_SUM = (1 << 8);
        public const int PREDICT_MAX_VOTE = (2 << 8);
        public const int PREDICT_MASK = (3 << 8);
        //
        // C++:  int cv::ml::DTrees::getMaxCategories()
        //

        /**
         * SEE: setMaxCategories
         * return automatically generated
         */
        public int getMaxCategories()
        {
            ThrowIfDisposed();

            return ml_DTrees_getMaxCategories_10(nativeObj);


        }


        //
        // C++:  void cv::ml::DTrees::setMaxCategories(int val)
        //

        /**
         *  getMaxCategories SEE: getMaxCategories
         * param val automatically generated
         */
        public void setMaxCategories(int val)
        {
            ThrowIfDisposed();

            ml_DTrees_setMaxCategories_10(nativeObj, val);


        }


        //
        // C++:  int cv::ml::DTrees::getMaxDepth()
        //

        /**
         * SEE: setMaxDepth
         * return automatically generated
         */
        public int getMaxDepth()
        {
            ThrowIfDisposed();

            return ml_DTrees_getMaxDepth_10(nativeObj);


        }


        //
        // C++:  void cv::ml::DTrees::setMaxDepth(int val)
        //

        /**
         *  getMaxDepth SEE: getMaxDepth
         * param val automatically generated
         */
        public void setMaxDepth(int val)
        {
            ThrowIfDisposed();

            ml_DTrees_setMaxDepth_10(nativeObj, val);


        }


        //
        // C++:  int cv::ml::DTrees::getMinSampleCount()
        //

        /**
         * SEE: setMinSampleCount
         * return automatically generated
         */
        public int getMinSampleCount()
        {
            ThrowIfDisposed();

            return ml_DTrees_getMinSampleCount_10(nativeObj);


        }


        //
        // C++:  void cv::ml::DTrees::setMinSampleCount(int val)
        //

        /**
         *  getMinSampleCount SEE: getMinSampleCount
         * param val automatically generated
         */
        public void setMinSampleCount(int val)
        {
            ThrowIfDisposed();

            ml_DTrees_setMinSampleCount_10(nativeObj, val);


        }


        //
        // C++:  int cv::ml::DTrees::getCVFolds()
        //

        /**
         * SEE: setCVFolds
         * return automatically generated
         */
        public int getCVFolds()
        {
            ThrowIfDisposed();

            return ml_DTrees_getCVFolds_10(nativeObj);


        }


        //
        // C++:  void cv::ml::DTrees::setCVFolds(int val)
        //

        /**
         *  getCVFolds SEE: getCVFolds
         * param val automatically generated
         */
        public void setCVFolds(int val)
        {
            ThrowIfDisposed();

            ml_DTrees_setCVFolds_10(nativeObj, val);


        }


        //
        // C++:  bool cv::ml::DTrees::getUseSurrogates()
        //

        /**
         * SEE: setUseSurrogates
         * return automatically generated
         */
        public bool getUseSurrogates()
        {
            ThrowIfDisposed();

            return ml_DTrees_getUseSurrogates_10(nativeObj);


        }


        //
        // C++:  void cv::ml::DTrees::setUseSurrogates(bool val)
        //

        /**
         *  getUseSurrogates SEE: getUseSurrogates
         * param val automatically generated
         */
        public void setUseSurrogates(bool val)
        {
            ThrowIfDisposed();

            ml_DTrees_setUseSurrogates_10(nativeObj, val);


        }


        //
        // C++:  bool cv::ml::DTrees::getUse1SERule()
        //

        /**
         * SEE: setUse1SERule
         * return automatically generated
         */
        public bool getUse1SERule()
        {
            ThrowIfDisposed();

            return ml_DTrees_getUse1SERule_10(nativeObj);


        }


        //
        // C++:  void cv::ml::DTrees::setUse1SERule(bool val)
        //

        /**
         *  getUse1SERule SEE: getUse1SERule
         * param val automatically generated
         */
        public void setUse1SERule(bool val)
        {
            ThrowIfDisposed();

            ml_DTrees_setUse1SERule_10(nativeObj, val);


        }


        //
        // C++:  bool cv::ml::DTrees::getTruncatePrunedTree()
        //

        /**
         * SEE: setTruncatePrunedTree
         * return automatically generated
         */
        public bool getTruncatePrunedTree()
        {
            ThrowIfDisposed();

            return ml_DTrees_getTruncatePrunedTree_10(nativeObj);


        }


        //
        // C++:  void cv::ml::DTrees::setTruncatePrunedTree(bool val)
        //

        /**
         *  getTruncatePrunedTree SEE: getTruncatePrunedTree
         * param val automatically generated
         */
        public void setTruncatePrunedTree(bool val)
        {
            ThrowIfDisposed();

            ml_DTrees_setTruncatePrunedTree_10(nativeObj, val);


        }


        //
        // C++:  float cv::ml::DTrees::getRegressionAccuracy()
        //

        /**
         * SEE: setRegressionAccuracy
         * return automatically generated
         */
        public float getRegressionAccuracy()
        {
            ThrowIfDisposed();

            return ml_DTrees_getRegressionAccuracy_10(nativeObj);


        }


        //
        // C++:  void cv::ml::DTrees::setRegressionAccuracy(float val)
        //

        /**
         *  getRegressionAccuracy SEE: getRegressionAccuracy
         * param val automatically generated
         */
        public void setRegressionAccuracy(float val)
        {
            ThrowIfDisposed();

            ml_DTrees_setRegressionAccuracy_10(nativeObj, val);


        }


        //
        // C++:  Mat cv::ml::DTrees::getPriors()
        //

        /**
         * SEE: setPriors
         * return automatically generated
         */
        public Mat getPriors()
        {
            ThrowIfDisposed();

            return new Mat(DisposableObject.ThrowIfNullIntPtr(ml_DTrees_getPriors_10(nativeObj)));


        }


        //
        // C++:  void cv::ml::DTrees::setPriors(Mat val)
        //

        /**
         *  getPriors SEE: getPriors
         * param val automatically generated
         */
        public void setPriors(Mat val)
        {
            ThrowIfDisposed();
            if (val != null) val.ThrowIfDisposed();

            ml_DTrees_setPriors_10(nativeObj, val.nativeObj);


        }


        //
        // C++: static Ptr_DTrees cv::ml::DTrees::create()
        //

        /**
         * Creates the empty model
         *
         *     The static method creates empty decision tree with the specified parameters. It should be then
         *     trained using train method (see StatModel::train). Alternatively, you can load the model from
         *     file using Algorithm::load&lt;DTrees&gt;(filename).
         * return automatically generated
         */
        public static DTrees create()
        {


            return DTrees.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ml_DTrees_create_10()));


        }


        //
        // C++: static Ptr_DTrees cv::ml::DTrees::load(String filepath, String nodeName = String())
        //

        /**
         * Loads and creates a serialized DTrees from a file
         *
         * Use DTree::save to serialize and store an DTree to disk.
         * Load the DTree from this file again, by calling this function with the path to the file.
         * Optionally specify the node for the file containing the classifier
         *
         * param filepath path to serialized DTree
         * param nodeName name of node containing the classifier
         * return automatically generated
         */
        public static DTrees load(string filepath, string nodeName)
        {


            return DTrees.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ml_DTrees_load_10(filepath, nodeName)));


        }

        /**
         * Loads and creates a serialized DTrees from a file
         *
         * Use DTree::save to serialize and store an DTree to disk.
         * Load the DTree from this file again, by calling this function with the path to the file.
         * Optionally specify the node for the file containing the classifier
         *
         * param filepath path to serialized DTree
         * return automatically generated
         */
        public static DTrees load(string filepath)
        {


            return DTrees.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(ml_DTrees_load_11(filepath)));


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  int cv::ml::DTrees::getMaxCategories()
        [DllImport(LIBNAME)]
        private static extern int ml_DTrees_getMaxCategories_10(IntPtr nativeObj);

        // C++:  void cv::ml::DTrees::setMaxCategories(int val)
        [DllImport(LIBNAME)]
        private static extern void ml_DTrees_setMaxCategories_10(IntPtr nativeObj, int val);

        // C++:  int cv::ml::DTrees::getMaxDepth()
        [DllImport(LIBNAME)]
        private static extern int ml_DTrees_getMaxDepth_10(IntPtr nativeObj);

        // C++:  void cv::ml::DTrees::setMaxDepth(int val)
        [DllImport(LIBNAME)]
        private static extern void ml_DTrees_setMaxDepth_10(IntPtr nativeObj, int val);

        // C++:  int cv::ml::DTrees::getMinSampleCount()
        [DllImport(LIBNAME)]
        private static extern int ml_DTrees_getMinSampleCount_10(IntPtr nativeObj);

        // C++:  void cv::ml::DTrees::setMinSampleCount(int val)
        [DllImport(LIBNAME)]
        private static extern void ml_DTrees_setMinSampleCount_10(IntPtr nativeObj, int val);

        // C++:  int cv::ml::DTrees::getCVFolds()
        [DllImport(LIBNAME)]
        private static extern int ml_DTrees_getCVFolds_10(IntPtr nativeObj);

        // C++:  void cv::ml::DTrees::setCVFolds(int val)
        [DllImport(LIBNAME)]
        private static extern void ml_DTrees_setCVFolds_10(IntPtr nativeObj, int val);

        // C++:  bool cv::ml::DTrees::getUseSurrogates()
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool ml_DTrees_getUseSurrogates_10(IntPtr nativeObj);

        // C++:  void cv::ml::DTrees::setUseSurrogates(bool val)
        [DllImport(LIBNAME)]
        private static extern void ml_DTrees_setUseSurrogates_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool val);

        // C++:  bool cv::ml::DTrees::getUse1SERule()
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool ml_DTrees_getUse1SERule_10(IntPtr nativeObj);

        // C++:  void cv::ml::DTrees::setUse1SERule(bool val)
        [DllImport(LIBNAME)]
        private static extern void ml_DTrees_setUse1SERule_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool val);

        // C++:  bool cv::ml::DTrees::getTruncatePrunedTree()
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool ml_DTrees_getTruncatePrunedTree_10(IntPtr nativeObj);

        // C++:  void cv::ml::DTrees::setTruncatePrunedTree(bool val)
        [DllImport(LIBNAME)]
        private static extern void ml_DTrees_setTruncatePrunedTree_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool val);

        // C++:  float cv::ml::DTrees::getRegressionAccuracy()
        [DllImport(LIBNAME)]
        private static extern float ml_DTrees_getRegressionAccuracy_10(IntPtr nativeObj);

        // C++:  void cv::ml::DTrees::setRegressionAccuracy(float val)
        [DllImport(LIBNAME)]
        private static extern void ml_DTrees_setRegressionAccuracy_10(IntPtr nativeObj, float val);

        // C++:  Mat cv::ml::DTrees::getPriors()
        [DllImport(LIBNAME)]
        private static extern IntPtr ml_DTrees_getPriors_10(IntPtr nativeObj);

        // C++:  void cv::ml::DTrees::setPriors(Mat val)
        [DllImport(LIBNAME)]
        private static extern void ml_DTrees_setPriors_10(IntPtr nativeObj, IntPtr val_nativeObj);

        // C++: static Ptr_DTrees cv::ml::DTrees::create()
        [DllImport(LIBNAME)]
        private static extern IntPtr ml_DTrees_create_10();

        // C++: static Ptr_DTrees cv::ml::DTrees::load(String filepath, String nodeName = String())
        [DllImport(LIBNAME)]
        private static extern IntPtr ml_DTrees_load_10(string filepath, string nodeName);
        [DllImport(LIBNAME)]
        private static extern IntPtr ml_DTrees_load_11(string filepath);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void ml_DTrees_delete(IntPtr nativeObj);

    }
}
