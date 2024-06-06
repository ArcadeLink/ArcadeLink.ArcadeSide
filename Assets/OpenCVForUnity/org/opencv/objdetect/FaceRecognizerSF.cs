

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.ObjdetectModule
{
    // C++: class FaceRecognizerSF
    /**
     * DNN-based face recognizer
     *
     * model download link: https://github.com/opencv/opencv_zoo/tree/master/models/face_recognition_sface
     */

    public class FaceRecognizerSF : DisposableOpenCVObject
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
                        objdetect_FaceRecognizerSF_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal FaceRecognizerSF(IntPtr addr) : base(addr) { }


        public IntPtr getNativeObjAddr() { return nativeObj; }

        // internal usage only
        public static FaceRecognizerSF __fromPtr__(IntPtr addr) { return new FaceRecognizerSF(addr); }

        // C++: enum cv.FaceRecognizerSF.DisType
        public const int FR_COSINE = 0;
        public const int FR_NORM_L2 = 1;
        //
        // C++:  void cv::FaceRecognizerSF::alignCrop(Mat src_img, Mat face_box, Mat& aligned_img)
        //

        /**
         * Aligning image to put face on the standard position
         * param src_img input image
         * param face_box the detection result used for indicate face in input image
         * param aligned_img output aligned image
         */
        public void alignCrop(Mat src_img, Mat face_box, Mat aligned_img)
        {
            ThrowIfDisposed();
            if (src_img != null) src_img.ThrowIfDisposed();
            if (face_box != null) face_box.ThrowIfDisposed();
            if (aligned_img != null) aligned_img.ThrowIfDisposed();

            objdetect_FaceRecognizerSF_alignCrop_10(nativeObj, src_img.nativeObj, face_box.nativeObj, aligned_img.nativeObj);


        }


        //
        // C++:  void cv::FaceRecognizerSF::feature(Mat aligned_img, Mat& face_feature)
        //

        /**
         * Extracting face feature from aligned image
         * param aligned_img input aligned image
         * param face_feature output face feature
         */
        public void feature(Mat aligned_img, Mat face_feature)
        {
            ThrowIfDisposed();
            if (aligned_img != null) aligned_img.ThrowIfDisposed();
            if (face_feature != null) face_feature.ThrowIfDisposed();

            objdetect_FaceRecognizerSF_feature_10(nativeObj, aligned_img.nativeObj, face_feature.nativeObj);


        }


        //
        // C++:  double cv::FaceRecognizerSF::match(Mat face_feature1, Mat face_feature2, int dis_type = FaceRecognizerSF::FR_COSINE)
        //

        /**
         * Calculating the distance between two face features
         * param face_feature1 the first input feature
         * param face_feature2 the second input feature of the same size and the same type as face_feature1
         * param dis_type defining the similarity with optional values "FR_OSINE" or "FR_NORM_L2"
         * return automatically generated
         */
        public double match(Mat face_feature1, Mat face_feature2, int dis_type)
        {
            ThrowIfDisposed();
            if (face_feature1 != null) face_feature1.ThrowIfDisposed();
            if (face_feature2 != null) face_feature2.ThrowIfDisposed();

            return objdetect_FaceRecognizerSF_match_10(nativeObj, face_feature1.nativeObj, face_feature2.nativeObj, dis_type);


        }

        /**
         * Calculating the distance between two face features
         * param face_feature1 the first input feature
         * param face_feature2 the second input feature of the same size and the same type as face_feature1
         * return automatically generated
         */
        public double match(Mat face_feature1, Mat face_feature2)
        {
            ThrowIfDisposed();
            if (face_feature1 != null) face_feature1.ThrowIfDisposed();
            if (face_feature2 != null) face_feature2.ThrowIfDisposed();

            return objdetect_FaceRecognizerSF_match_11(nativeObj, face_feature1.nativeObj, face_feature2.nativeObj);


        }


        //
        // C++: static Ptr_FaceRecognizerSF cv::FaceRecognizerSF::create(String model, String config, int backend_id = 0, int target_id = 0)
        //

        /**
         * Creates an instance of this class with given parameters
         * param model the path of the onnx model used for face recognition
         * param config the path to the config file for compability, which is not requested for ONNX models
         * param backend_id the id of backend
         * param target_id the id of target device
         * return automatically generated
         */
        public static FaceRecognizerSF create(string model, string config, int backend_id, int target_id)
        {


            return FaceRecognizerSF.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(objdetect_FaceRecognizerSF_create_10(model, config, backend_id, target_id)));


        }

        /**
         * Creates an instance of this class with given parameters
         * param model the path of the onnx model used for face recognition
         * param config the path to the config file for compability, which is not requested for ONNX models
         * param backend_id the id of backend
         * return automatically generated
         */
        public static FaceRecognizerSF create(string model, string config, int backend_id)
        {


            return FaceRecognizerSF.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(objdetect_FaceRecognizerSF_create_11(model, config, backend_id)));


        }

        /**
         * Creates an instance of this class with given parameters
         * param model the path of the onnx model used for face recognition
         * param config the path to the config file for compability, which is not requested for ONNX models
         * return automatically generated
         */
        public static FaceRecognizerSF create(string model, string config)
        {


            return FaceRecognizerSF.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(objdetect_FaceRecognizerSF_create_12(model, config)));


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  void cv::FaceRecognizerSF::alignCrop(Mat src_img, Mat face_box, Mat& aligned_img)
        [DllImport(LIBNAME)]
        private static extern void objdetect_FaceRecognizerSF_alignCrop_10(IntPtr nativeObj, IntPtr src_img_nativeObj, IntPtr face_box_nativeObj, IntPtr aligned_img_nativeObj);

        // C++:  void cv::FaceRecognizerSF::feature(Mat aligned_img, Mat& face_feature)
        [DllImport(LIBNAME)]
        private static extern void objdetect_FaceRecognizerSF_feature_10(IntPtr nativeObj, IntPtr aligned_img_nativeObj, IntPtr face_feature_nativeObj);

        // C++:  double cv::FaceRecognizerSF::match(Mat face_feature1, Mat face_feature2, int dis_type = FaceRecognizerSF::FR_COSINE)
        [DllImport(LIBNAME)]
        private static extern double objdetect_FaceRecognizerSF_match_10(IntPtr nativeObj, IntPtr face_feature1_nativeObj, IntPtr face_feature2_nativeObj, int dis_type);
        [DllImport(LIBNAME)]
        private static extern double objdetect_FaceRecognizerSF_match_11(IntPtr nativeObj, IntPtr face_feature1_nativeObj, IntPtr face_feature2_nativeObj);

        // C++: static Ptr_FaceRecognizerSF cv::FaceRecognizerSF::create(String model, String config, int backend_id = 0, int target_id = 0)
        [DllImport(LIBNAME)]
        private static extern IntPtr objdetect_FaceRecognizerSF_create_10(string model, string config, int backend_id, int target_id);
        [DllImport(LIBNAME)]
        private static extern IntPtr objdetect_FaceRecognizerSF_create_11(string model, string config, int backend_id);
        [DllImport(LIBNAME)]
        private static extern IntPtr objdetect_FaceRecognizerSF_create_12(string model, string config);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void objdetect_FaceRecognizerSF_delete(IntPtr nativeObj);

    }
}
