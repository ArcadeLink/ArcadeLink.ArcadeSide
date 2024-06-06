#if !UNITY_WSA_10_0

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.TextModule
{
    // C++: class TextDetector
    /**
     * An abstract class providing interface for text detection algorithms
     */

    public class TextDetector : DisposableOpenCVObject
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
                        text_TextDetector_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal TextDetector(IntPtr addr) : base(addr) { }


        public IntPtr getNativeObjAddr() { return nativeObj; }

        // internal usage only
        public static TextDetector __fromPtr__(IntPtr addr) { return new TextDetector(addr); }

        //
        // C++:  void cv::text::TextDetector::detect(Mat inputImage, vector_Rect& Bbox, vector_float& confidence)
        //

        /**
         * Method that provides a quick and simple interface to detect text inside an image
         *
         *     param inputImage an image to process
         *     param Bbox a vector of Rect that will store the detected word bounding box
         *     param confidence a vector of float that will be updated with the confidence the classifier has for the selected bounding box
         */
        public virtual void detect(Mat inputImage, MatOfRect Bbox, MatOfFloat confidence)
        {
            ThrowIfDisposed();
            if (inputImage != null) inputImage.ThrowIfDisposed();
            if (Bbox != null) Bbox.ThrowIfDisposed();
            if (confidence != null) confidence.ThrowIfDisposed();
            Mat Bbox_mat = Bbox;
            Mat confidence_mat = confidence;
            text_TextDetector_detect_10(nativeObj, inputImage.nativeObj, Bbox_mat.nativeObj, confidence_mat.nativeObj);


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  void cv::text::TextDetector::detect(Mat inputImage, vector_Rect& Bbox, vector_float& confidence)
        [DllImport(LIBNAME)]
        private static extern void text_TextDetector_detect_10(IntPtr nativeObj, IntPtr inputImage_nativeObj, IntPtr Bbox_mat_nativeObj, IntPtr confidence_mat_nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void text_TextDetector_delete(IntPtr nativeObj);

    }
}

#endif