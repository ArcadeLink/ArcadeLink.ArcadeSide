#if !UNITY_WSA_10_0

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.TextModule
{

    // C++: class TextDetectorCNN
    /**
     * TextDetectorCNN class provides the functionallity of text bounding box detection.
     *  This class is representing to find bounding boxes of text words given an input image.
     *  This class uses OpenCV dnn module to load pre-trained model described in CITE: LiaoSBWL17.
     *  The original repository with the modified SSD Caffe version: https://github.com/MhLiao/TextBoxes.
     *  Model can be downloaded from [DropBox](https://www.dropbox.com/s/g8pjzv2de9gty8g/TextBoxes_icdar13.caffemodel?dl=0).
     *  Modified .prototxt file with the model description can be found in {code opencv_contrib/modules/text/samples/textbox.prototxt}.
     */

    public class TextDetectorCNN : TextDetector
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
                        text_TextDetectorCNN_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal TextDetectorCNN(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new TextDetectorCNN __fromPtr__(IntPtr addr) { return new TextDetectorCNN(addr); }

        //
        // C++:  void cv::text::TextDetectorCNN::detect(Mat inputImage, vector_Rect& Bbox, vector_float& confidence)
        //

        /**
         *
         *
         *     param inputImage an image expected to be a CV_U8C3 of any size
         *     param Bbox a vector of Rect that will store the detected word bounding box
         *     param confidence a vector of float that will be updated with the confidence the classifier has for the selected bounding box
         */
        public override void detect(Mat inputImage, MatOfRect Bbox, MatOfFloat confidence)
        {
            ThrowIfDisposed();
            if (inputImage != null) inputImage.ThrowIfDisposed();
            if (Bbox != null) Bbox.ThrowIfDisposed();
            if (confidence != null) confidence.ThrowIfDisposed();
            Mat Bbox_mat = Bbox;
            Mat confidence_mat = confidence;
            text_TextDetectorCNN_detect_10(nativeObj, inputImage.nativeObj, Bbox_mat.nativeObj, confidence_mat.nativeObj);


        }


        //
        // C++: static Ptr_TextDetectorCNN cv::text::TextDetectorCNN::create(String modelArchFilename, String modelWeightsFilename)
        //

        public static TextDetectorCNN create(string modelArchFilename, string modelWeightsFilename)
        {


            return TextDetectorCNN.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(text_TextDetectorCNN_create_10(modelArchFilename, modelWeightsFilename)));


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  void cv::text::TextDetectorCNN::detect(Mat inputImage, vector_Rect& Bbox, vector_float& confidence)
        [DllImport(LIBNAME)]
        private static extern void text_TextDetectorCNN_detect_10(IntPtr nativeObj, IntPtr inputImage_nativeObj, IntPtr Bbox_mat_nativeObj, IntPtr confidence_mat_nativeObj);

        // C++: static Ptr_TextDetectorCNN cv::text::TextDetectorCNN::create(String modelArchFilename, String modelWeightsFilename)
        [DllImport(LIBNAME)]
        private static extern IntPtr text_TextDetectorCNN_create_10(string modelArchFilename, string modelWeightsFilename);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void text_TextDetectorCNN_delete(IntPtr nativeObj);

    }
}

#endif