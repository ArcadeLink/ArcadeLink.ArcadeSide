#if !UNITY_WSA_10_0

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.TextModule
{
    // C++: class ClassifierCallback
    /**
     * Callback with the character classifier is made a class.
     *
     *     This way it hides the feature extractor and the classifier itself, so developers can write
     *     their own OCR code.
     *
     *     The default character classifier and feature extractor can be loaded using the utility function
     *     loadOCRHMMClassifierNM and KNN model provided in
     *     &lt;https://github.com/opencv/opencv_contrib/blob/master/modules/text/samples/OCRHMM_knn_model_data.xml.gz&gt;.
     */

    public class OCRHMMDecoder_ClassifierCallback : DisposableOpenCVObject
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
                        text_OCRHMMDecoder_1ClassifierCallback_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal OCRHMMDecoder_ClassifierCallback(IntPtr addr) : base(addr) { }


        public IntPtr getNativeObjAddr() { return nativeObj; }

        // internal usage only
        public static OCRHMMDecoder_ClassifierCallback __fromPtr__(IntPtr addr) { return new OCRHMMDecoder_ClassifierCallback(addr); }

#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void text_OCRHMMDecoder_1ClassifierCallback_delete(IntPtr nativeObj);

    }
}

#endif