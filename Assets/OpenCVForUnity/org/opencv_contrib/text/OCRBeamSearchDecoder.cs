#if !UNITY_WSA_10_0

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.TextModule
{

    // C++: class OCRBeamSearchDecoder
    /**
     * OCRBeamSearchDecoder class provides an interface for OCR using Beam Search algorithm.
     *
     * <b>Note:</b>
     * <ul>
     *   <li>
     *       (C++) An example on using OCRBeamSearchDecoder recognition combined with scene text detection can
     *         be found at the demo sample:
     *         &lt;https://github.com/opencv/opencv_contrib/blob/master/modules/text/samples/word_recognition.cpp&gt;
     *   </li>
     * </ul>
     */

    public class OCRBeamSearchDecoder : BaseOCR
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
                        text_OCRBeamSearchDecoder_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal OCRBeamSearchDecoder(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new OCRBeamSearchDecoder __fromPtr__(IntPtr addr) { return new OCRBeamSearchDecoder(addr); }

        //
        // C++:  String cv::text::OCRBeamSearchDecoder::run(Mat image, int min_confidence, int component_level = 0)
        //

        /**
         * Recognize text using Beam Search.
         *
         *     Takes image on input and returns recognized text in the output_text parameter. Optionally
         *     provides also the Rects for individual text elements found (e.g. words), and the list of those
         *     text elements with their confidence values.
         *
         *     param image Input binary image CV_8UC1 with a single text line (or word).
         *
         *
         *     text elements found (e.g. words).
         *
         *     recognition of individual text elements found (e.g. words).
         *
         *     for the recognition of individual text elements found (e.g. words).
         *
         *     param component_level Only OCR_LEVEL_WORD is supported.
         * param min_confidence automatically generated
         * return automatically generated
         */
        public string run(Mat image, int min_confidence, int component_level)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();

            string retVal = Marshal.PtrToStringAnsi(DisposableObject.ThrowIfNullIntPtr(text_OCRBeamSearchDecoder_run_10(nativeObj, image.nativeObj, min_confidence, component_level)));

            return retVal;
        }

        /**
         * Recognize text using Beam Search.
         *
         *     Takes image on input and returns recognized text in the output_text parameter. Optionally
         *     provides also the Rects for individual text elements found (e.g. words), and the list of those
         *     text elements with their confidence values.
         *
         *     param image Input binary image CV_8UC1 with a single text line (or word).
         *
         *
         *     text elements found (e.g. words).
         *
         *     recognition of individual text elements found (e.g. words).
         *
         *     for the recognition of individual text elements found (e.g. words).
         *
         * param min_confidence automatically generated
         * return automatically generated
         */
        public string run(Mat image, int min_confidence)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();

            string retVal = Marshal.PtrToStringAnsi(DisposableObject.ThrowIfNullIntPtr(text_OCRBeamSearchDecoder_run_11(nativeObj, image.nativeObj, min_confidence)));

            return retVal;
        }


        //
        // C++:  String cv::text::OCRBeamSearchDecoder::run(Mat image, Mat mask, int min_confidence, int component_level = 0)
        //

        public string run(Mat image, Mat mask, int min_confidence, int component_level)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (mask != null) mask.ThrowIfDisposed();

            string retVal = Marshal.PtrToStringAnsi(DisposableObject.ThrowIfNullIntPtr(text_OCRBeamSearchDecoder_run_12(nativeObj, image.nativeObj, mask.nativeObj, min_confidence, component_level)));

            return retVal;
        }

        public string run(Mat image, Mat mask, int min_confidence)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (mask != null) mask.ThrowIfDisposed();

            string retVal = Marshal.PtrToStringAnsi(DisposableObject.ThrowIfNullIntPtr(text_OCRBeamSearchDecoder_run_13(nativeObj, image.nativeObj, mask.nativeObj, min_confidence)));

            return retVal;
        }


        //
        // C++: static Ptr_OCRBeamSearchDecoder cv::text::OCRBeamSearchDecoder::create(Ptr_OCRBeamSearchDecoder_ClassifierCallback classifier, string vocabulary, Mat transition_probabilities_table, Mat emission_probabilities_table, text_decoder_mode mode = OCR_DECODER_VITERBI, int beam_size = 500)
        //

        /**
         * Creates an instance of the OCRBeamSearchDecoder class. Initializes HMMDecoder.
         *
         *     param classifier The character classifier with built in feature extractor.
         *
         *     param vocabulary The language vocabulary (chars when ASCII English text). vocabulary.size()
         *     must be equal to the number of classes of the classifier.
         *
         *     param transition_probabilities_table Table with transition probabilities between character
         *     pairs. cols == rows == vocabulary.size().
         *
         *     param emission_probabilities_table Table with observation emission probabilities. cols ==
         *     rows == vocabulary.size().
         *
         *     param mode HMM Decoding algorithm. Only OCR_DECODER_VITERBI is available for the moment
         *     (&lt;http://en.wikipedia.org/wiki/Viterbi_algorithm&gt;).
         *
         *     param beam_size Size of the beam in Beam Search algorithm.
         * return automatically generated
         */
        public static OCRBeamSearchDecoder create(OCRBeamSearchDecoder_ClassifierCallback classifier, string vocabulary, Mat transition_probabilities_table, Mat emission_probabilities_table, int mode, int beam_size)
        {
            if (classifier != null) classifier.ThrowIfDisposed();
            if (transition_probabilities_table != null) transition_probabilities_table.ThrowIfDisposed();
            if (emission_probabilities_table != null) emission_probabilities_table.ThrowIfDisposed();

            return OCRBeamSearchDecoder.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(text_OCRBeamSearchDecoder_create_10(classifier.getNativeObjAddr(), vocabulary, transition_probabilities_table.nativeObj, emission_probabilities_table.nativeObj, mode, beam_size)));


        }

        /**
         * Creates an instance of the OCRBeamSearchDecoder class. Initializes HMMDecoder.
         *
         *     param classifier The character classifier with built in feature extractor.
         *
         *     param vocabulary The language vocabulary (chars when ASCII English text). vocabulary.size()
         *     must be equal to the number of classes of the classifier.
         *
         *     param transition_probabilities_table Table with transition probabilities between character
         *     pairs. cols == rows == vocabulary.size().
         *
         *     param emission_probabilities_table Table with observation emission probabilities. cols ==
         *     rows == vocabulary.size().
         *
         *     param mode HMM Decoding algorithm. Only OCR_DECODER_VITERBI is available for the moment
         *     (&lt;http://en.wikipedia.org/wiki/Viterbi_algorithm&gt;).
         *
         * return automatically generated
         */
        public static OCRBeamSearchDecoder create(OCRBeamSearchDecoder_ClassifierCallback classifier, string vocabulary, Mat transition_probabilities_table, Mat emission_probabilities_table, int mode)
        {
            if (classifier != null) classifier.ThrowIfDisposed();
            if (transition_probabilities_table != null) transition_probabilities_table.ThrowIfDisposed();
            if (emission_probabilities_table != null) emission_probabilities_table.ThrowIfDisposed();

            return OCRBeamSearchDecoder.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(text_OCRBeamSearchDecoder_create_11(classifier.getNativeObjAddr(), vocabulary, transition_probabilities_table.nativeObj, emission_probabilities_table.nativeObj, mode)));


        }

        /**
         * Creates an instance of the OCRBeamSearchDecoder class. Initializes HMMDecoder.
         *
         *     param classifier The character classifier with built in feature extractor.
         *
         *     param vocabulary The language vocabulary (chars when ASCII English text). vocabulary.size()
         *     must be equal to the number of classes of the classifier.
         *
         *     param transition_probabilities_table Table with transition probabilities between character
         *     pairs. cols == rows == vocabulary.size().
         *
         *     param emission_probabilities_table Table with observation emission probabilities. cols ==
         *     rows == vocabulary.size().
         *
         *     (&lt;http://en.wikipedia.org/wiki/Viterbi_algorithm&gt;).
         *
         * return automatically generated
         */
        public static OCRBeamSearchDecoder create(OCRBeamSearchDecoder_ClassifierCallback classifier, string vocabulary, Mat transition_probabilities_table, Mat emission_probabilities_table)
        {
            if (classifier != null) classifier.ThrowIfDisposed();
            if (transition_probabilities_table != null) transition_probabilities_table.ThrowIfDisposed();
            if (emission_probabilities_table != null) emission_probabilities_table.ThrowIfDisposed();

            return OCRBeamSearchDecoder.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(text_OCRBeamSearchDecoder_create_12(classifier.getNativeObjAddr(), vocabulary, transition_probabilities_table.nativeObj, emission_probabilities_table.nativeObj)));


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  String cv::text::OCRBeamSearchDecoder::run(Mat image, int min_confidence, int component_level = 0)
        [DllImport(LIBNAME)]
        private static extern IntPtr text_OCRBeamSearchDecoder_run_10(IntPtr nativeObj, IntPtr image_nativeObj, int min_confidence, int component_level);
        [DllImport(LIBNAME)]
        private static extern IntPtr text_OCRBeamSearchDecoder_run_11(IntPtr nativeObj, IntPtr image_nativeObj, int min_confidence);

        // C++:  String cv::text::OCRBeamSearchDecoder::run(Mat image, Mat mask, int min_confidence, int component_level = 0)
        [DllImport(LIBNAME)]
        private static extern IntPtr text_OCRBeamSearchDecoder_run_12(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr mask_nativeObj, int min_confidence, int component_level);
        [DllImport(LIBNAME)]
        private static extern IntPtr text_OCRBeamSearchDecoder_run_13(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr mask_nativeObj, int min_confidence);

        // C++: static Ptr_OCRBeamSearchDecoder cv::text::OCRBeamSearchDecoder::create(Ptr_OCRBeamSearchDecoder_ClassifierCallback classifier, string vocabulary, Mat transition_probabilities_table, Mat emission_probabilities_table, text_decoder_mode mode = OCR_DECODER_VITERBI, int beam_size = 500)
        [DllImport(LIBNAME)]
        private static extern IntPtr text_OCRBeamSearchDecoder_create_10(IntPtr classifier_nativeObj, string vocabulary, IntPtr transition_probabilities_table_nativeObj, IntPtr emission_probabilities_table_nativeObj, int mode, int beam_size);
        [DllImport(LIBNAME)]
        private static extern IntPtr text_OCRBeamSearchDecoder_create_11(IntPtr classifier_nativeObj, string vocabulary, IntPtr transition_probabilities_table_nativeObj, IntPtr emission_probabilities_table_nativeObj, int mode);
        [DllImport(LIBNAME)]
        private static extern IntPtr text_OCRBeamSearchDecoder_create_12(IntPtr classifier_nativeObj, string vocabulary, IntPtr transition_probabilities_table_nativeObj, IntPtr emission_probabilities_table_nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void text_OCRBeamSearchDecoder_delete(IntPtr nativeObj);

    }
}

#endif