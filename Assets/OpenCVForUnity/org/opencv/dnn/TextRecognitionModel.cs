#if !UNITY_WSA_10_0

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.DnnModule
{

    // C++: class TextRecognitionModel
    /**
     * This class represents high-level API for text recognition networks.
     *
     * TextRecognitionModel allows to set params for preprocessing input image.
     * TextRecognitionModel creates net from file with trained weights and config,
     * sets preprocessing input, runs forward pass and return recognition result.
     * For TextRecognitionModel, CRNN-CTC is supported.
     */

    public class TextRecognitionModel : Model
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
                        dnn_TextRecognitionModel_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal TextRecognitionModel(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new TextRecognitionModel __fromPtr__(IntPtr addr) { return new TextRecognitionModel(addr); }

        //
        // C++:   cv::dnn::TextRecognitionModel::TextRecognitionModel(Net network)
        //

        /**
         * Create Text Recognition model from deep learning network
         * Call setDecodeType() and setVocabulary() after constructor to initialize the decoding method
         * param network Net object
         */
        public TextRecognitionModel(Net network) :
            base(DisposableObject.ThrowIfNullIntPtr(dnn_TextRecognitionModel_TextRecognitionModel_10(network.nativeObj)))
        {



        }


        //
        // C++:   cv::dnn::TextRecognitionModel::TextRecognitionModel(string model, string config = "")
        //

        /**
         * Create text recognition model from network represented in one of the supported formats
         * Call setDecodeType() and setVocabulary() after constructor to initialize the decoding method
         * param model Binary file contains trained weights
         * param config Text file contains network configuration
         */
        public TextRecognitionModel(string model, string config) :
            base(DisposableObject.ThrowIfNullIntPtr(dnn_TextRecognitionModel_TextRecognitionModel_11(model, config)))
        {



        }

        /**
         * Create text recognition model from network represented in one of the supported formats
         * Call setDecodeType() and setVocabulary() after constructor to initialize the decoding method
         * param model Binary file contains trained weights
         */
        public TextRecognitionModel(string model) :
            base(DisposableObject.ThrowIfNullIntPtr(dnn_TextRecognitionModel_TextRecognitionModel_12(model)))
        {



        }


        //
        // C++:  TextRecognitionModel cv::dnn::TextRecognitionModel::setDecodeType(string decodeType)
        //

        /**
         * Set the decoding method of translating the network output into string
         * param decodeType The decoding method of translating the network output into string, currently supported type:
         * - {code "CTC-greedy"} greedy decoding for the output of CTC-based methods
         * - {code "CTC-prefix-beam-search"} Prefix beam search decoding for the output of CTC-based methods
         * return automatically generated
         */
        public TextRecognitionModel setDecodeType(string decodeType)
        {
            ThrowIfDisposed();

            return new TextRecognitionModel(DisposableObject.ThrowIfNullIntPtr(dnn_TextRecognitionModel_setDecodeType_10(nativeObj, decodeType)));


        }


        //
        // C++:  string cv::dnn::TextRecognitionModel::getDecodeType()
        //

        /**
         * Get the decoding method
         * return the decoding method
         */
        public string getDecodeType()
        {
            ThrowIfDisposed();

            string retVal = Marshal.PtrToStringAnsi(DisposableObject.ThrowIfNullIntPtr(dnn_TextRecognitionModel_getDecodeType_10(nativeObj)));

            return retVal;
        }


        //
        // C++:  TextRecognitionModel cv::dnn::TextRecognitionModel::setDecodeOptsCTCPrefixBeamSearch(int beamSize, int vocPruneSize = 0)
        //

        /**
         * Set the decoding method options for {code "CTC-prefix-beam-search"} decode usage
         * param beamSize Beam size for search
         * param vocPruneSize Parameter to optimize big vocabulary search,
         * only take top {code vocPruneSize} tokens in each search step, {code vocPruneSize} &lt;= 0 stands for disable this prune.
         * return automatically generated
         */
        public TextRecognitionModel setDecodeOptsCTCPrefixBeamSearch(int beamSize, int vocPruneSize)
        {
            ThrowIfDisposed();

            return new TextRecognitionModel(DisposableObject.ThrowIfNullIntPtr(dnn_TextRecognitionModel_setDecodeOptsCTCPrefixBeamSearch_10(nativeObj, beamSize, vocPruneSize)));


        }

        /**
         * Set the decoding method options for {code "CTC-prefix-beam-search"} decode usage
         * param beamSize Beam size for search
         * only take top {code vocPruneSize} tokens in each search step, {code vocPruneSize} &lt;= 0 stands for disable this prune.
         * return automatically generated
         */
        public TextRecognitionModel setDecodeOptsCTCPrefixBeamSearch(int beamSize)
        {
            ThrowIfDisposed();

            return new TextRecognitionModel(DisposableObject.ThrowIfNullIntPtr(dnn_TextRecognitionModel_setDecodeOptsCTCPrefixBeamSearch_11(nativeObj, beamSize)));


        }


        //
        // C++:  TextRecognitionModel cv::dnn::TextRecognitionModel::setVocabulary(vector_string vocabulary)
        //

        /**
         * Set the vocabulary for recognition.
         * param vocabulary the associated vocabulary of the network.
         * return automatically generated
         */
        public TextRecognitionModel setVocabulary(List<string> vocabulary)
        {
            ThrowIfDisposed();
            Mat vocabulary_mat = Converters.vector_string_to_Mat(vocabulary);
            return new TextRecognitionModel(DisposableObject.ThrowIfNullIntPtr(dnn_TextRecognitionModel_setVocabulary_10(nativeObj, vocabulary_mat.nativeObj)));


        }


        //
        // C++:  vector_string cv::dnn::TextRecognitionModel::getVocabulary()
        //

        /**
         * Get the vocabulary for recognition.
         * return vocabulary the associated vocabulary
         */
        public List<string> getVocabulary()
        {
            ThrowIfDisposed();
            List<string> retVal = new List<string>();
            Mat retValMat = new Mat(DisposableObject.ThrowIfNullIntPtr(dnn_TextRecognitionModel_getVocabulary_10(nativeObj)));
            Converters.Mat_to_vector_string(retValMat, retVal);
            return retVal;
        }


        //
        // C++:  string cv::dnn::TextRecognitionModel::recognize(Mat frame)
        //

        /**
         * Given the {code input} frame, create input blob, run net and return recognition result
         * param frame The input image
         * return The text recognition result
         */
        public string recognize(Mat frame)
        {
            ThrowIfDisposed();
            if (frame != null) frame.ThrowIfDisposed();

            string retVal = Marshal.PtrToStringAnsi(DisposableObject.ThrowIfNullIntPtr(dnn_TextRecognitionModel_recognize_10(nativeObj, frame.nativeObj)));

            return retVal;
        }


        //
        // C++:  void cv::dnn::TextRecognitionModel::recognize(Mat frame, vector_Mat roiRects, vector_string& results)
        //

        /**
         * Given the {code input} frame, create input blob, run net and return recognition result
         * param frame The input image
         * param roiRects List of text detection regions of interest (cv::Rect, CV_32SC4). ROIs is be cropped as the network inputs
         * param results A set of text recognition results.
         */
        public void recognize(Mat frame, List<Mat> roiRects, List<string> results)
        {
            ThrowIfDisposed();
            if (frame != null) frame.ThrowIfDisposed();
            Mat roiRects_mat = Converters.vector_Mat_to_Mat(roiRects);
            Mat results_mat = new Mat();
            dnn_TextRecognitionModel_recognize_11(nativeObj, frame.nativeObj, roiRects_mat.nativeObj, results_mat.nativeObj);
            Converters.Mat_to_vector_string(results_mat, results);
            results_mat.release();

        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:   cv::dnn::TextRecognitionModel::TextRecognitionModel(Net network)
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_TextRecognitionModel_TextRecognitionModel_10(IntPtr network_nativeObj);

        // C++:   cv::dnn::TextRecognitionModel::TextRecognitionModel(string model, string config = "")
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_TextRecognitionModel_TextRecognitionModel_11(string model, string config);
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_TextRecognitionModel_TextRecognitionModel_12(string model);

        // C++:  TextRecognitionModel cv::dnn::TextRecognitionModel::setDecodeType(string decodeType)
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_TextRecognitionModel_setDecodeType_10(IntPtr nativeObj, string decodeType);

        // C++:  string cv::dnn::TextRecognitionModel::getDecodeType()
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_TextRecognitionModel_getDecodeType_10(IntPtr nativeObj);

        // C++:  TextRecognitionModel cv::dnn::TextRecognitionModel::setDecodeOptsCTCPrefixBeamSearch(int beamSize, int vocPruneSize = 0)
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_TextRecognitionModel_setDecodeOptsCTCPrefixBeamSearch_10(IntPtr nativeObj, int beamSize, int vocPruneSize);
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_TextRecognitionModel_setDecodeOptsCTCPrefixBeamSearch_11(IntPtr nativeObj, int beamSize);

        // C++:  TextRecognitionModel cv::dnn::TextRecognitionModel::setVocabulary(vector_string vocabulary)
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_TextRecognitionModel_setVocabulary_10(IntPtr nativeObj, IntPtr vocabulary_mat_nativeObj);

        // C++:  vector_string cv::dnn::TextRecognitionModel::getVocabulary()
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_TextRecognitionModel_getVocabulary_10(IntPtr nativeObj);

        // C++:  string cv::dnn::TextRecognitionModel::recognize(Mat frame)
        [DllImport(LIBNAME)]
        private static extern IntPtr dnn_TextRecognitionModel_recognize_10(IntPtr nativeObj, IntPtr frame_nativeObj);

        // C++:  void cv::dnn::TextRecognitionModel::recognize(Mat frame, vector_Mat roiRects, vector_string& results)
        [DllImport(LIBNAME)]
        private static extern void dnn_TextRecognitionModel_recognize_11(IntPtr nativeObj, IntPtr frame_nativeObj, IntPtr roiRects_mat_nativeObj, IntPtr results_mat_nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void dnn_TextRecognitionModel_delete(IntPtr nativeObj);

    }
}

#endif