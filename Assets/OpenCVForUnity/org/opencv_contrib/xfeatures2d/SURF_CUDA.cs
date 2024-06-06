

//using OpenCVForUnity.CoreModule;
//using OpenCVForUnity.UtilsModule;
//using System;
//using System.Collections.Generic;
//using System.Runtime.InteropServices;

//namespace OpenCVForUnity.Xfeatures2dModule
//{
//    // C++: class SURF_CUDA
//    /**
//     * Class used for extracting Speeded Up Robust Features (SURF) from an image. :
//     *
//     * The class SURF_CUDA implements Speeded Up Robust Features descriptor. There is a fast multi-scale
//     * Hessian keypoint detector that can be used to find the keypoints (which is the default option). But
//     * the descriptors can also be computed for the user-specified keypoints. Only 8-bit grayscale images
//     * are supported.
//     *
//     * The class SURF_CUDA can store results in the GPU and CPU memory. It provides functions to convert
//     * results between CPU and GPU version ( uploadKeypoints, downloadKeypoints, downloadDescriptors ). The
//     * format of CPU results is the same as SURF results. GPU results are stored in GpuMat. The keypoints
//     * matrix is \(\texttt{nFeatures} \times 7\) matrix with the CV_32FC1 type.
//     *
//     * <ul>
//     *   <li>
//     *    keypoints.ptr&lt;float&gt;(X_ROW)[i] contains x coordinate of the i-th feature.
//     *   </li>
//     *   <li>
//     *    keypoints.ptr&lt;float&gt;(Y_ROW)[i] contains y coordinate of the i-th feature.
//     *   </li>
//     *   <li>
//     *    keypoints.ptr&lt;float&gt;(LAPLACIAN_ROW)[i] contains the laplacian sign of the i-th feature.
//     *   </li>
//     *   <li>
//     *    keypoints.ptr&lt;float&gt;(OCTAVE_ROW)[i] contains the octave of the i-th feature.
//     *   </li>
//     *   <li>
//     *    keypoints.ptr&lt;float&gt;(SIZE_ROW)[i] contains the size of the i-th feature.
//     *   </li>
//     *   <li>
//     *    keypoints.ptr&lt;float&gt;(ANGLE_ROW)[i] contain orientation of the i-th feature.
//     *   </li>
//     *   <li>
//     *    keypoints.ptr&lt;float&gt;(HESSIAN_ROW)[i] contains the response of the i-th feature.
//     *   </li>
//     * </ul>
//     *
//     * The descriptors matrix is \(\texttt{nFeatures} \times \texttt{descriptorSize}\) matrix with the
//     * CV_32FC1 type.
//     *
//     * The class SURF_CUDA uses some buffers and provides access to it. All buffers can be safely released
//     * between function calls.
//     *
//     * SEE: SURF
//     *
//     * <b>Note:</b>
//     * <ul>
//     *   <li>
//     *       An example for using the SURF keypoint matcher on GPU can be found at
//     *         opencv_source_code/samples/gpu/surf_keypoint_matcher.cpp
//     *   </li>
//     * </ul>
//     */

//    public class SURF_CUDA : DisposableOpenCVObject
//    {

//        protected override void Dispose(bool disposing)
//        {

//            try
//            {
//                if (disposing)
//                {
//                }
//                if (IsEnabledDispose)
//                {
//                    if (nativeObj != IntPtr.Zero)
//                        xfeatures2d_SURF_1CUDA_delete(nativeObj);
//                    nativeObj = IntPtr.Zero;
//                }
//            }
//            finally
//            {
//                base.Dispose(disposing);
//            }

//        }

//        protected internal SURF_CUDA(IntPtr addr) : base(addr) { }


//        public IntPtr getNativeObjAddr() { return nativeObj; }

//        // internal usage only
//        public static SURF_CUDA __fromPtr__(IntPtr addr) { return new SURF_CUDA(addr); }

//        // C++: enum cv.cuda.SURF_CUDA.KeypointLayout
//        public const int X_ROW = 0;
//        public const int Y_ROW = 0 + 1;
//        public const int LAPLACIAN_ROW = 0 + 2;
//        public const int OCTAVE_ROW = 0 + 3;
//        public const int SIZE_ROW = 0 + 4;
//        public const int ANGLE_ROW = 0 + 5;
//        public const int HESSIAN_ROW = 0 + 6;
//        public const int ROWS_COUNT = 0 + 7;
//        //
//        // C++: static Ptr_SURF_CUDA cv::cuda::SURF_CUDA::create(double _hessianThreshold, int _nOctaves = 4, int _nOctaveLayers = 2, bool _extended = false, float _keypointsRatio = 0.01f, bool _upright = false)
//        //

//        /**
//         * param _hessianThreshold Threshold for hessian keypoint detector used in SURF.
//         *     param _nOctaves Number of pyramid octaves the keypoint detector will use.
//         *     param _nOctaveLayers Number of octave layers within each octave.
//         *     param _extended Extended descriptor flag (true - use extended 128-element descriptors; false - use
//         *     64-element descriptors).
//         *     param _keypointsRatio Limits a maximum number of features
//         *     param _upright Up-right or rotated features flag (true - do not compute orientation of features;
//         *     false - compute orientation).
//         * return automatically generated
//         */
//        public static SURF_CUDA create(double _hessianThreshold, int _nOctaves, int _nOctaveLayers, bool _extended, float _keypointsRatio, bool _upright)
//        {


//            return SURF_CUDA.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_SURF_1CUDA_create_10(_hessianThreshold, _nOctaves, _nOctaveLayers, _extended, _keypointsRatio, _upright)));


//        }

//        /**
//         * param _hessianThreshold Threshold for hessian keypoint detector used in SURF.
//         *     param _nOctaves Number of pyramid octaves the keypoint detector will use.
//         *     param _nOctaveLayers Number of octave layers within each octave.
//         *     param _extended Extended descriptor flag (true - use extended 128-element descriptors; false - use
//         *     64-element descriptors).
//         *     param _keypointsRatio Limits a maximum number of features
//         *     false - compute orientation).
//         * return automatically generated
//         */
//        public static SURF_CUDA create(double _hessianThreshold, int _nOctaves, int _nOctaveLayers, bool _extended, float _keypointsRatio)
//        {


//            return SURF_CUDA.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_SURF_1CUDA_create_11(_hessianThreshold, _nOctaves, _nOctaveLayers, _extended, _keypointsRatio)));


//        }

//        /**
//         * param _hessianThreshold Threshold for hessian keypoint detector used in SURF.
//         *     param _nOctaves Number of pyramid octaves the keypoint detector will use.
//         *     param _nOctaveLayers Number of octave layers within each octave.
//         *     param _extended Extended descriptor flag (true - use extended 128-element descriptors; false - use
//         *     64-element descriptors).
//         *     false - compute orientation).
//         * return automatically generated
//         */
//        public static SURF_CUDA create(double _hessianThreshold, int _nOctaves, int _nOctaveLayers, bool _extended)
//        {


//            return SURF_CUDA.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_SURF_1CUDA_create_12(_hessianThreshold, _nOctaves, _nOctaveLayers, _extended)));


//        }

//        /**
//         * param _hessianThreshold Threshold for hessian keypoint detector used in SURF.
//         *     param _nOctaves Number of pyramid octaves the keypoint detector will use.
//         *     param _nOctaveLayers Number of octave layers within each octave.
//         *     64-element descriptors).
//         *     false - compute orientation).
//         * return automatically generated
//         */
//        public static SURF_CUDA create(double _hessianThreshold, int _nOctaves, int _nOctaveLayers)
//        {


//            return SURF_CUDA.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_SURF_1CUDA_create_13(_hessianThreshold, _nOctaves, _nOctaveLayers)));


//        }

//        /**
//         * param _hessianThreshold Threshold for hessian keypoint detector used in SURF.
//         *     param _nOctaves Number of pyramid octaves the keypoint detector will use.
//         *     64-element descriptors).
//         *     false - compute orientation).
//         * return automatically generated
//         */
//        public static SURF_CUDA create(double _hessianThreshold, int _nOctaves)
//        {


//            return SURF_CUDA.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_SURF_1CUDA_create_14(_hessianThreshold, _nOctaves)));


//        }

//        /**
//         * param _hessianThreshold Threshold for hessian keypoint detector used in SURF.
//         *     64-element descriptors).
//         *     false - compute orientation).
//         * return automatically generated
//         */
//        public static SURF_CUDA create(double _hessianThreshold)
//        {


//            return SURF_CUDA.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_SURF_1CUDA_create_15(_hessianThreshold)));


//        }


//        //
//        // C++:  int cv::cuda::SURF_CUDA::descriptorSize()
//        //

//        public int descriptorSize()
//        {
//            ThrowIfDisposed();

//            return xfeatures2d_SURF_1CUDA_descriptorSize_10(nativeObj);


//        }


//        //
//        // C++:  int cv::cuda::SURF_CUDA::defaultNorm()
//        //

//        public int defaultNorm()
//        {
//            ThrowIfDisposed();

//            return xfeatures2d_SURF_1CUDA_defaultNorm_10(nativeObj);


//        }


//        //
//        // C++:  void cv::cuda::SURF_CUDA::downloadKeypoints(GpuMat keypointsGPU, vector_KeyPoint& keypoints)
//        //

//        // Unknown type 'GpuMat' (I), skipping the function


//        //
//        // C++:  void cv::cuda::SURF_CUDA::detect(GpuMat img, GpuMat mask, GpuMat& keypoints)
//        //

//        // Unknown type 'GpuMat' (I), skipping the function


//        //
//        // C++:  void cv::cuda::SURF_CUDA::detectWithDescriptors(GpuMat img, GpuMat mask, GpuMat& keypoints, GpuMat& descriptors, bool useProvidedKeypoints = false)
//        //

//        // Unknown type 'GpuMat' (I), skipping the function


//        //
//        // C++: double SURF_CUDA::hessianThreshold
//        //

//        public double get_hessianThreshold()
//        {
//            ThrowIfDisposed();

//            return xfeatures2d_SURF_1CUDA_get_1hessianThreshold_10(nativeObj);


//        }


//        //
//        // C++: int SURF_CUDA::nOctaves
//        //

//        public int get_nOctaves()
//        {
//            ThrowIfDisposed();

//            return xfeatures2d_SURF_1CUDA_get_1nOctaves_10(nativeObj);


//        }


//        //
//        // C++: int SURF_CUDA::nOctaveLayers
//        //

//        public int get_nOctaveLayers()
//        {
//            ThrowIfDisposed();

//            return xfeatures2d_SURF_1CUDA_get_1nOctaveLayers_10(nativeObj);


//        }


//        //
//        // C++: bool SURF_CUDA::extended
//        //

//        public bool get_extended()
//        {
//            ThrowIfDisposed();

//            return xfeatures2d_SURF_1CUDA_get_1extended_10(nativeObj);


//        }


//        //
//        // C++: bool SURF_CUDA::upright
//        //

//        public bool get_upright()
//        {
//            ThrowIfDisposed();

//            return xfeatures2d_SURF_1CUDA_get_1upright_10(nativeObj);


//        }


//        //
//        // C++: float SURF_CUDA::keypointsRatio
//        //

//        public float get_keypointsRatio()
//        {
//            ThrowIfDisposed();

//            return xfeatures2d_SURF_1CUDA_get_1keypointsRatio_10(nativeObj);


//        }


//#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
//        const string LIBNAME = "__Internal";
//#else
//        const string LIBNAME = "opencvforunity";
//#endif



//        // C++: static Ptr_SURF_CUDA cv::cuda::SURF_CUDA::create(double _hessianThreshold, int _nOctaves = 4, int _nOctaveLayers = 2, bool _extended = false, float _keypointsRatio = 0.01f, bool _upright = false)
//        [DllImport(LIBNAME)]
//        private static extern IntPtr xfeatures2d_SURF_1CUDA_create_10(double _hessianThreshold, int _nOctaves, int _nOctaveLayers, [MarshalAs(UnmanagedType.U1)] bool _extended, float _keypointsRatio, [MarshalAs(UnmanagedType.U1)] bool _upright);
//        [DllImport(LIBNAME)]
//        private static extern IntPtr xfeatures2d_SURF_1CUDA_create_11(double _hessianThreshold, int _nOctaves, int _nOctaveLayers, [MarshalAs(UnmanagedType.U1)] bool _extended, float _keypointsRatio);
//        [DllImport(LIBNAME)]
//        private static extern IntPtr xfeatures2d_SURF_1CUDA_create_12(double _hessianThreshold, int _nOctaves, int _nOctaveLayers, [MarshalAs(UnmanagedType.U1)] bool _extended);
//        [DllImport(LIBNAME)]
//        private static extern IntPtr xfeatures2d_SURF_1CUDA_create_13(double _hessianThreshold, int _nOctaves, int _nOctaveLayers);
//        [DllImport(LIBNAME)]
//        private static extern IntPtr xfeatures2d_SURF_1CUDA_create_14(double _hessianThreshold, int _nOctaves);
//        [DllImport(LIBNAME)]
//        private static extern IntPtr xfeatures2d_SURF_1CUDA_create_15(double _hessianThreshold);

//        // C++:  int cv::cuda::SURF_CUDA::descriptorSize()
//        [DllImport(LIBNAME)]
//        private static extern int xfeatures2d_SURF_1CUDA_descriptorSize_10(IntPtr nativeObj);

//        // C++:  int cv::cuda::SURF_CUDA::defaultNorm()
//        [DllImport(LIBNAME)]
//        private static extern int xfeatures2d_SURF_1CUDA_defaultNorm_10(IntPtr nativeObj);

//        // C++: double SURF_CUDA::hessianThreshold
//        [DllImport(LIBNAME)]
//        private static extern double xfeatures2d_SURF_1CUDA_get_1hessianThreshold_10(IntPtr nativeObj);

//        // C++: int SURF_CUDA::nOctaves
//        [DllImport(LIBNAME)]
//        private static extern int xfeatures2d_SURF_1CUDA_get_1nOctaves_10(IntPtr nativeObj);

//        // C++: int SURF_CUDA::nOctaveLayers
//        [DllImport(LIBNAME)]
//        private static extern int xfeatures2d_SURF_1CUDA_get_1nOctaveLayers_10(IntPtr nativeObj);

//        // C++: bool SURF_CUDA::extended
//        [DllImport(LIBNAME)]
//        [return: MarshalAs(UnmanagedType.U1)]
//        private static extern bool xfeatures2d_SURF_1CUDA_get_1extended_10(IntPtr nativeObj);

//        // C++: bool SURF_CUDA::upright
//        [DllImport(LIBNAME)]
//        [return: MarshalAs(UnmanagedType.U1)]
//        private static extern bool xfeatures2d_SURF_1CUDA_get_1upright_10(IntPtr nativeObj);

//        // C++: float SURF_CUDA::keypointsRatio
//        [DllImport(LIBNAME)]
//        private static extern float xfeatures2d_SURF_1CUDA_get_1keypointsRatio_10(IntPtr nativeObj);

//        // native support for java finalize()
//        [DllImport(LIBNAME)]
//        private static extern void xfeatures2d_SURF_1CUDA_delete(IntPtr nativeObj);

//    }
//}
