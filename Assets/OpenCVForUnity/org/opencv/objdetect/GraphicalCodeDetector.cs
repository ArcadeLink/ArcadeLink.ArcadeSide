

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.ObjdetectModule
{
    // C++: class GraphicalCodeDetector


    public class GraphicalCodeDetector : DisposableOpenCVObject
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
                        objdetect_GraphicalCodeDetector_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal GraphicalCodeDetector(IntPtr addr) : base(addr) { }


        public IntPtr getNativeObjAddr() { return nativeObj; }

        // internal usage only
        public static GraphicalCodeDetector __fromPtr__(IntPtr addr) { return new GraphicalCodeDetector(addr); }

        //
        // C++:  bool cv::GraphicalCodeDetector::detect(Mat img, Mat& points)
        //

        /**
         * Detects graphical code in image and returns the quadrangle containing the code.
         *      param img grayscale or color (BGR) image containing (or not) graphical code.
         *      param points Output vector of vertices of the minimum-area quadrangle containing the code.
         * return automatically generated
         */
        public bool detect(Mat img, Mat points)
        {
            ThrowIfDisposed();
            if (img != null) img.ThrowIfDisposed();
            if (points != null) points.ThrowIfDisposed();

            return objdetect_GraphicalCodeDetector_detect_10(nativeObj, img.nativeObj, points.nativeObj);


        }


        //
        // C++:  string cv::GraphicalCodeDetector::decode(Mat img, Mat points, Mat& straight_code = Mat())
        //

        /**
         * Decodes graphical code in image once it's found by the detect() method.
         *
         *      Returns UTF8-encoded output string or empty string if the code cannot be decoded.
         *      param img grayscale or color (BGR) image containing graphical code.
         *      param points Quadrangle vertices found by detect() method (or some other algorithm).
         *      param straight_code The optional output image containing binarized code, will be empty if not found.
         * return automatically generated
         */
        public string decode(Mat img, Mat points, Mat straight_code)
        {
            ThrowIfDisposed();
            if (img != null) img.ThrowIfDisposed();
            if (points != null) points.ThrowIfDisposed();
            if (straight_code != null) straight_code.ThrowIfDisposed();

            string retVal = Marshal.PtrToStringAnsi(DisposableObject.ThrowIfNullIntPtr(objdetect_GraphicalCodeDetector_decode_10(nativeObj, img.nativeObj, points.nativeObj, straight_code.nativeObj)));

            return retVal;
        }

        /**
         * Decodes graphical code in image once it's found by the detect() method.
         *
         *      Returns UTF8-encoded output string or empty string if the code cannot be decoded.
         *      param img grayscale or color (BGR) image containing graphical code.
         *      param points Quadrangle vertices found by detect() method (or some other algorithm).
         * return automatically generated
         */
        public string decode(Mat img, Mat points)
        {
            ThrowIfDisposed();
            if (img != null) img.ThrowIfDisposed();
            if (points != null) points.ThrowIfDisposed();

            string retVal = Marshal.PtrToStringAnsi(DisposableObject.ThrowIfNullIntPtr(objdetect_GraphicalCodeDetector_decode_11(nativeObj, img.nativeObj, points.nativeObj)));

            return retVal;
        }


        //
        // C++:  string cv::GraphicalCodeDetector::detectAndDecode(Mat img, Mat& points = Mat(), Mat& straight_code = Mat())
        //

        /**
         * Both detects and decodes graphical code
         *
         *      param img grayscale or color (BGR) image containing graphical code.
         *      param points optional output array of vertices of the found graphical code quadrangle, will be empty if not found.
         *      param straight_code The optional output image containing binarized code
         * return automatically generated
         */
        public string detectAndDecode(Mat img, Mat points, Mat straight_code)
        {
            ThrowIfDisposed();
            if (img != null) img.ThrowIfDisposed();
            if (points != null) points.ThrowIfDisposed();
            if (straight_code != null) straight_code.ThrowIfDisposed();

            string retVal = Marshal.PtrToStringAnsi(DisposableObject.ThrowIfNullIntPtr(objdetect_GraphicalCodeDetector_detectAndDecode_10(nativeObj, img.nativeObj, points.nativeObj, straight_code.nativeObj)));

            return retVal;
        }

        /**
         * Both detects and decodes graphical code
         *
         *      param img grayscale or color (BGR) image containing graphical code.
         *      param points optional output array of vertices of the found graphical code quadrangle, will be empty if not found.
         * return automatically generated
         */
        public string detectAndDecode(Mat img, Mat points)
        {
            ThrowIfDisposed();
            if (img != null) img.ThrowIfDisposed();
            if (points != null) points.ThrowIfDisposed();

            string retVal = Marshal.PtrToStringAnsi(DisposableObject.ThrowIfNullIntPtr(objdetect_GraphicalCodeDetector_detectAndDecode_11(nativeObj, img.nativeObj, points.nativeObj)));

            return retVal;
        }

        /**
         * Both detects and decodes graphical code
         *
         *      param img grayscale or color (BGR) image containing graphical code.
         * return automatically generated
         */
        public string detectAndDecode(Mat img)
        {
            ThrowIfDisposed();
            if (img != null) img.ThrowIfDisposed();

            string retVal = Marshal.PtrToStringAnsi(DisposableObject.ThrowIfNullIntPtr(objdetect_GraphicalCodeDetector_detectAndDecode_12(nativeObj, img.nativeObj)));

            return retVal;
        }


        //
        // C++:  bool cv::GraphicalCodeDetector::detectMulti(Mat img, Mat& points)
        //

        /**
         * Detects graphical codes in image and returns the vector of the quadrangles containing the codes.
         *      param img grayscale or color (BGR) image containing (or not) graphical codes.
         *      param points Output vector of vector of vertices of the minimum-area quadrangle containing the codes.
         * return automatically generated
         */
        public bool detectMulti(Mat img, Mat points)
        {
            ThrowIfDisposed();
            if (img != null) img.ThrowIfDisposed();
            if (points != null) points.ThrowIfDisposed();

            return objdetect_GraphicalCodeDetector_detectMulti_10(nativeObj, img.nativeObj, points.nativeObj);


        }


        //
        // C++:  bool cv::GraphicalCodeDetector::decodeMulti(Mat img, Mat points, vector_string& decoded_info, vector_Mat& straight_code = vector_Mat())
        //

        /**
         * Decodes graphical codes in image once it's found by the detect() method.
         *      param img grayscale or color (BGR) image containing graphical codes.
         *      param decoded_info UTF8-encoded output vector of string or empty vector of string if the codes cannot be decoded.
         *      param points vector of Quadrangle vertices found by detect() method (or some other algorithm).
         *      param straight_code The optional output vector of images containing binarized codes
         * return automatically generated
         */
        public bool decodeMulti(Mat img, Mat points, List<string> decoded_info, List<Mat> straight_code)
        {
            ThrowIfDisposed();
            if (img != null) img.ThrowIfDisposed();
            if (points != null) points.ThrowIfDisposed();
            Mat decoded_info_mat = new Mat();
            Mat straight_code_mat = new Mat();
            bool retVal = objdetect_GraphicalCodeDetector_decodeMulti_10(nativeObj, img.nativeObj, points.nativeObj, decoded_info_mat.nativeObj, straight_code_mat.nativeObj);
            Converters.Mat_to_vector_string(decoded_info_mat, decoded_info);
            decoded_info_mat.release();
            Converters.Mat_to_vector_Mat(straight_code_mat, straight_code);
            straight_code_mat.release();
            return retVal;
        }

        /**
         * Decodes graphical codes in image once it's found by the detect() method.
         *      param img grayscale or color (BGR) image containing graphical codes.
         *      param decoded_info UTF8-encoded output vector of string or empty vector of string if the codes cannot be decoded.
         *      param points vector of Quadrangle vertices found by detect() method (or some other algorithm).
         * return automatically generated
         */
        public bool decodeMulti(Mat img, Mat points, List<string> decoded_info)
        {
            ThrowIfDisposed();
            if (img != null) img.ThrowIfDisposed();
            if (points != null) points.ThrowIfDisposed();
            Mat decoded_info_mat = new Mat();
            bool retVal = objdetect_GraphicalCodeDetector_decodeMulti_11(nativeObj, img.nativeObj, points.nativeObj, decoded_info_mat.nativeObj);
            Converters.Mat_to_vector_string(decoded_info_mat, decoded_info);
            decoded_info_mat.release();
            return retVal;
        }


        //
        // C++:  bool cv::GraphicalCodeDetector::detectAndDecodeMulti(Mat img, vector_string& decoded_info, Mat& points = Mat(), vector_Mat& straight_code = vector_Mat())
        //

        /**
         * Both detects and decodes graphical codes
         *     param img grayscale or color (BGR) image containing graphical codes.
         *     param decoded_info UTF8-encoded output vector of string or empty vector of string if the codes cannot be decoded.
         *     param points optional output vector of vertices of the found graphical code quadrangles. Will be empty if not found.
         *     param straight_code The optional vector of images containing binarized codes
         * return automatically generated
         */
        public bool detectAndDecodeMulti(Mat img, List<string> decoded_info, Mat points, List<Mat> straight_code)
        {
            ThrowIfDisposed();
            if (img != null) img.ThrowIfDisposed();
            if (points != null) points.ThrowIfDisposed();
            Mat decoded_info_mat = new Mat();
            Mat straight_code_mat = new Mat();
            bool retVal = objdetect_GraphicalCodeDetector_detectAndDecodeMulti_10(nativeObj, img.nativeObj, decoded_info_mat.nativeObj, points.nativeObj, straight_code_mat.nativeObj);
            Converters.Mat_to_vector_string(decoded_info_mat, decoded_info);
            decoded_info_mat.release();
            Converters.Mat_to_vector_Mat(straight_code_mat, straight_code);
            straight_code_mat.release();
            return retVal;
        }

        /**
         * Both detects and decodes graphical codes
         *     param img grayscale or color (BGR) image containing graphical codes.
         *     param decoded_info UTF8-encoded output vector of string or empty vector of string if the codes cannot be decoded.
         *     param points optional output vector of vertices of the found graphical code quadrangles. Will be empty if not found.
         * return automatically generated
         */
        public bool detectAndDecodeMulti(Mat img, List<string> decoded_info, Mat points)
        {
            ThrowIfDisposed();
            if (img != null) img.ThrowIfDisposed();
            if (points != null) points.ThrowIfDisposed();
            Mat decoded_info_mat = new Mat();
            bool retVal = objdetect_GraphicalCodeDetector_detectAndDecodeMulti_11(nativeObj, img.nativeObj, decoded_info_mat.nativeObj, points.nativeObj);
            Converters.Mat_to_vector_string(decoded_info_mat, decoded_info);
            decoded_info_mat.release();
            return retVal;
        }

        /**
         * Both detects and decodes graphical codes
         *     param img grayscale or color (BGR) image containing graphical codes.
         *     param decoded_info UTF8-encoded output vector of string or empty vector of string if the codes cannot be decoded.
         * return automatically generated
         */
        public bool detectAndDecodeMulti(Mat img, List<string> decoded_info)
        {
            ThrowIfDisposed();
            if (img != null) img.ThrowIfDisposed();
            Mat decoded_info_mat = new Mat();
            bool retVal = objdetect_GraphicalCodeDetector_detectAndDecodeMulti_12(nativeObj, img.nativeObj, decoded_info_mat.nativeObj);
            Converters.Mat_to_vector_string(decoded_info_mat, decoded_info);
            decoded_info_mat.release();
            return retVal;
        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  bool cv::GraphicalCodeDetector::detect(Mat img, Mat& points)
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool objdetect_GraphicalCodeDetector_detect_10(IntPtr nativeObj, IntPtr img_nativeObj, IntPtr points_nativeObj);

        // C++:  string cv::GraphicalCodeDetector::decode(Mat img, Mat points, Mat& straight_code = Mat())
        [DllImport(LIBNAME)]
        private static extern IntPtr objdetect_GraphicalCodeDetector_decode_10(IntPtr nativeObj, IntPtr img_nativeObj, IntPtr points_nativeObj, IntPtr straight_code_nativeObj);
        [DllImport(LIBNAME)]
        private static extern IntPtr objdetect_GraphicalCodeDetector_decode_11(IntPtr nativeObj, IntPtr img_nativeObj, IntPtr points_nativeObj);

        // C++:  string cv::GraphicalCodeDetector::detectAndDecode(Mat img, Mat& points = Mat(), Mat& straight_code = Mat())
        [DllImport(LIBNAME)]
        private static extern IntPtr objdetect_GraphicalCodeDetector_detectAndDecode_10(IntPtr nativeObj, IntPtr img_nativeObj, IntPtr points_nativeObj, IntPtr straight_code_nativeObj);
        [DllImport(LIBNAME)]
        private static extern IntPtr objdetect_GraphicalCodeDetector_detectAndDecode_11(IntPtr nativeObj, IntPtr img_nativeObj, IntPtr points_nativeObj);
        [DllImport(LIBNAME)]
        private static extern IntPtr objdetect_GraphicalCodeDetector_detectAndDecode_12(IntPtr nativeObj, IntPtr img_nativeObj);

        // C++:  bool cv::GraphicalCodeDetector::detectMulti(Mat img, Mat& points)
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool objdetect_GraphicalCodeDetector_detectMulti_10(IntPtr nativeObj, IntPtr img_nativeObj, IntPtr points_nativeObj);

        // C++:  bool cv::GraphicalCodeDetector::decodeMulti(Mat img, Mat points, vector_string& decoded_info, vector_Mat& straight_code = vector_Mat())
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool objdetect_GraphicalCodeDetector_decodeMulti_10(IntPtr nativeObj, IntPtr img_nativeObj, IntPtr points_nativeObj, IntPtr decoded_info_mat_nativeObj, IntPtr straight_code_mat_nativeObj);
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool objdetect_GraphicalCodeDetector_decodeMulti_11(IntPtr nativeObj, IntPtr img_nativeObj, IntPtr points_nativeObj, IntPtr decoded_info_mat_nativeObj);

        // C++:  bool cv::GraphicalCodeDetector::detectAndDecodeMulti(Mat img, vector_string& decoded_info, Mat& points = Mat(), vector_Mat& straight_code = vector_Mat())
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool objdetect_GraphicalCodeDetector_detectAndDecodeMulti_10(IntPtr nativeObj, IntPtr img_nativeObj, IntPtr decoded_info_mat_nativeObj, IntPtr points_nativeObj, IntPtr straight_code_mat_nativeObj);
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool objdetect_GraphicalCodeDetector_detectAndDecodeMulti_11(IntPtr nativeObj, IntPtr img_nativeObj, IntPtr decoded_info_mat_nativeObj, IntPtr points_nativeObj);
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool objdetect_GraphicalCodeDetector_detectAndDecodeMulti_12(IntPtr nativeObj, IntPtr img_nativeObj, IntPtr decoded_info_mat_nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void objdetect_GraphicalCodeDetector_delete(IntPtr nativeObj);

    }
}
