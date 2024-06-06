#if !UNITY_WSA_10_0

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.Wechat_qrcodeModule
{
    // C++: class WeChatQRCode
    /**
     * WeChat QRCode includes two CNN-based models:
     * A object detection model and a super resolution model.
     * Object detection model is applied to detect QRCode with the bounding box.
     * super resolution model is applied to zoom in QRCode when it is small.
     *
     */

    public class WeChatQRCode : DisposableOpenCVObject
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
                        wechat_1qrcode_WeChatQRCode_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal WeChatQRCode(IntPtr addr) : base(addr) { }


        public IntPtr getNativeObjAddr() { return nativeObj; }

        // internal usage only
        public static WeChatQRCode __fromPtr__(IntPtr addr) { return new WeChatQRCode(addr); }

        //
        // C++:   cv::wechat_qrcode::WeChatQRCode::WeChatQRCode(string detector_prototxt_path = "", string detector_caffe_model_path = "", string super_resolution_prototxt_path = "", string super_resolution_caffe_model_path = "")
        //

        /**
         * Initialize the WeChatQRCode.
         * It includes two models, which are packaged with caffe format.
         * Therefore, there are prototxt and caffe models (In total, four paramenters).
         *
         * param detector_prototxt_path prototxt file path for the detector
         * param detector_caffe_model_path caffe model file path for the detector
         * param super_resolution_prototxt_path prototxt file path for the super resolution model
         * param super_resolution_caffe_model_path caffe file path for the super resolution model
         */
        public WeChatQRCode(string detector_prototxt_path, string detector_caffe_model_path, string super_resolution_prototxt_path, string super_resolution_caffe_model_path)
        {


            nativeObj = DisposableObject.ThrowIfNullIntPtr(wechat_1qrcode_WeChatQRCode_WeChatQRCode_10(detector_prototxt_path, detector_caffe_model_path, super_resolution_prototxt_path, super_resolution_caffe_model_path));


        }

        /**
         * Initialize the WeChatQRCode.
         * It includes two models, which are packaged with caffe format.
         * Therefore, there are prototxt and caffe models (In total, four paramenters).
         *
         * param detector_prototxt_path prototxt file path for the detector
         * param detector_caffe_model_path caffe model file path for the detector
         * param super_resolution_prototxt_path prototxt file path for the super resolution model
         */
        public WeChatQRCode(string detector_prototxt_path, string detector_caffe_model_path, string super_resolution_prototxt_path)
        {


            nativeObj = DisposableObject.ThrowIfNullIntPtr(wechat_1qrcode_WeChatQRCode_WeChatQRCode_11(detector_prototxt_path, detector_caffe_model_path, super_resolution_prototxt_path));


        }

        /**
         * Initialize the WeChatQRCode.
         * It includes two models, which are packaged with caffe format.
         * Therefore, there are prototxt and caffe models (In total, four paramenters).
         *
         * param detector_prototxt_path prototxt file path for the detector
         * param detector_caffe_model_path caffe model file path for the detector
         */
        public WeChatQRCode(string detector_prototxt_path, string detector_caffe_model_path)
        {


            nativeObj = DisposableObject.ThrowIfNullIntPtr(wechat_1qrcode_WeChatQRCode_WeChatQRCode_12(detector_prototxt_path, detector_caffe_model_path));


        }

        /**
         * Initialize the WeChatQRCode.
         * It includes two models, which are packaged with caffe format.
         * Therefore, there are prototxt and caffe models (In total, four paramenters).
         *
         * param detector_prototxt_path prototxt file path for the detector
         */
        public WeChatQRCode(string detector_prototxt_path)
        {


            nativeObj = DisposableObject.ThrowIfNullIntPtr(wechat_1qrcode_WeChatQRCode_WeChatQRCode_13(detector_prototxt_path));


        }

        /**
         * Initialize the WeChatQRCode.
         * It includes two models, which are packaged with caffe format.
         * Therefore, there are prototxt and caffe models (In total, four paramenters).
         *
         */
        public WeChatQRCode()
        {


            nativeObj = DisposableObject.ThrowIfNullIntPtr(wechat_1qrcode_WeChatQRCode_WeChatQRCode_14());


        }


        //
        // C++:  vector_string cv::wechat_qrcode::WeChatQRCode::detectAndDecode(Mat img, vector_Mat& points = vector_Mat())
        //

        /**
         * Both detects and decodes QR code.
         * To simplify the usage, there is a only API: detectAndDecode
         *
         * param img supports grayscale or color (BGR) image.
         * param points optional output array of vertices of the found QR code quadrangle. Will be
         * empty if not found.
         * return list of decoded string.
         */
        public List<string> detectAndDecode(Mat img, List<Mat> points)
        {
            ThrowIfDisposed();
            if (img != null) img.ThrowIfDisposed();
            Mat points_mat = new Mat();
            List<string> retVal = new List<string>();
            Mat retValMat = new Mat(DisposableObject.ThrowIfNullIntPtr(wechat_1qrcode_WeChatQRCode_detectAndDecode_10(nativeObj, img.nativeObj, points_mat.nativeObj)));
            Converters.Mat_to_vector_Mat(points_mat, points);
            points_mat.release();
            Converters.Mat_to_vector_string(retValMat, retVal);
            return retVal;
        }

        /**
         * Both detects and decodes QR code.
         * To simplify the usage, there is a only API: detectAndDecode
         *
         * param img supports grayscale or color (BGR) image.
         * empty if not found.
         * return list of decoded string.
         */
        public List<string> detectAndDecode(Mat img)
        {
            ThrowIfDisposed();
            if (img != null) img.ThrowIfDisposed();
            List<string> retVal = new List<string>();
            Mat retValMat = new Mat(DisposableObject.ThrowIfNullIntPtr(wechat_1qrcode_WeChatQRCode_detectAndDecode_11(nativeObj, img.nativeObj)));
            Converters.Mat_to_vector_string(retValMat, retVal);
            return retVal;
        }


        //
        // C++:  void cv::wechat_qrcode::WeChatQRCode::setScaleFactor(float _scalingFactor)
        //

        /**
         * set scale factor
         * QR code detector use neural network to detect QR.
         * Before running the neural network, the input image is pre-processed by scaling.
         * By default, the input image is scaled to an image with an area of 160000 pixels.
         * The scale factor allows to use custom scale the input image:
         * width = scaleFactor*width
         * height = scaleFactor*width
         *
         * scaleFactor valuse must be &gt; 0 and &lt;= 1, otherwise the scaleFactor value is set to -1
         * and use default scaled to an image with an area of 160000 pixels.
         * param _scalingFactor automatically generated
         */
        public void setScaleFactor(float _scalingFactor)
        {
            ThrowIfDisposed();

            wechat_1qrcode_WeChatQRCode_setScaleFactor_10(nativeObj, _scalingFactor);


        }


        //
        // C++:  float cv::wechat_qrcode::WeChatQRCode::getScaleFactor()
        //

        public float getScaleFactor()
        {
            ThrowIfDisposed();

            return wechat_1qrcode_WeChatQRCode_getScaleFactor_10(nativeObj);


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:   cv::wechat_qrcode::WeChatQRCode::WeChatQRCode(string detector_prototxt_path = "", string detector_caffe_model_path = "", string super_resolution_prototxt_path = "", string super_resolution_caffe_model_path = "")
        [DllImport(LIBNAME)]
        private static extern IntPtr wechat_1qrcode_WeChatQRCode_WeChatQRCode_10(string detector_prototxt_path, string detector_caffe_model_path, string super_resolution_prototxt_path, string super_resolution_caffe_model_path);
        [DllImport(LIBNAME)]
        private static extern IntPtr wechat_1qrcode_WeChatQRCode_WeChatQRCode_11(string detector_prototxt_path, string detector_caffe_model_path, string super_resolution_prototxt_path);
        [DllImport(LIBNAME)]
        private static extern IntPtr wechat_1qrcode_WeChatQRCode_WeChatQRCode_12(string detector_prototxt_path, string detector_caffe_model_path);
        [DllImport(LIBNAME)]
        private static extern IntPtr wechat_1qrcode_WeChatQRCode_WeChatQRCode_13(string detector_prototxt_path);
        [DllImport(LIBNAME)]
        private static extern IntPtr wechat_1qrcode_WeChatQRCode_WeChatQRCode_14();

        // C++:  vector_string cv::wechat_qrcode::WeChatQRCode::detectAndDecode(Mat img, vector_Mat& points = vector_Mat())
        [DllImport(LIBNAME)]
        private static extern IntPtr wechat_1qrcode_WeChatQRCode_detectAndDecode_10(IntPtr nativeObj, IntPtr img_nativeObj, IntPtr points_mat_nativeObj);
        [DllImport(LIBNAME)]
        private static extern IntPtr wechat_1qrcode_WeChatQRCode_detectAndDecode_11(IntPtr nativeObj, IntPtr img_nativeObj);

        // C++:  void cv::wechat_qrcode::WeChatQRCode::setScaleFactor(float _scalingFactor)
        [DllImport(LIBNAME)]
        private static extern void wechat_1qrcode_WeChatQRCode_setScaleFactor_10(IntPtr nativeObj, float _scalingFactor);

        // C++:  float cv::wechat_qrcode::WeChatQRCode::getScaleFactor()
        [DllImport(LIBNAME)]
        private static extern float wechat_1qrcode_WeChatQRCode_getScaleFactor_10(IntPtr nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void wechat_1qrcode_WeChatQRCode_delete(IntPtr nativeObj);

    }
}

#endif