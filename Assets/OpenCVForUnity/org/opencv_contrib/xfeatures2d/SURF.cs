
//using OpenCVForUnity.CoreModule;
//using OpenCVForUnity.Features2dModule;
//using OpenCVForUnity.UtilsModule;
//using System;
//using System.Collections.Generic;
//using System.Runtime.InteropServices;

//namespace OpenCVForUnity.Xfeatures2dModule
//{

//    // C++: class SURF
//    /**
//     * Class for extracting Speeded Up Robust Features from an image CITE: Bay06 .
//     *
//     * The algorithm parameters:
//     * <ul>
//     *   <li>
//     *    member int extended
//     *   <ul>
//     *     <li>
//     *        0 means that the basic descriptors (64 elements each) shall be computed
//     *     </li>
//     *     <li>
//     *        1 means that the extended descriptors (128 elements each) shall be computed
//     *     </li>
//     *   </ul>
//     *   <li>
//     *    member int upright
//     *   <ul>
//     *     <li>
//     *        0 means that detector computes orientation of each feature.
//     *     </li>
//     *     <li>
//     *        1 means that the orientation is not computed (which is much, much faster). For example,
//     * if you match images from a stereo pair, or do image stitching, the matched features
//     * likely have very similar angles, and you can speed up feature extraction by setting
//     * upright=1.
//     *     </li>
//     *   </ul>
//     *   <li>
//     *    member double hessianThreshold
//     * Threshold for the keypoint detector. Only features, whose hessian is larger than
//     * hessianThreshold are retained by the detector. Therefore, the larger the value, the less
//     * keypoints you will get. A good default value could be from 300 to 500, depending from the
//     * image contrast.
//     *   </li>
//     *   <li>
//     *    member int nOctaves
//     * The number of a gaussian pyramid octaves that the detector uses. It is set to 4 by default.
//     * If you want to get very large features, use the larger value. If you want just small
//     * features, decrease it.
//     *   </li>
//     *   <li>
//     *    member int nOctaveLayers
//     * The number of images within each octave of a gaussian pyramid. It is set to 2 by default.
//     *   </li>
//     * </ul>
//     * <b>Note:</b>
//     * <ul>
//     *   <li>
//     *       An example using the SURF feature detector can be found at
//     *         opencv_source_code/samples/cpp/generic_descriptor_match.cpp
//     *   <ul>
//     *     <li>
//     *        Another example using the SURF feature detector, extractor and matcher can be found at
//     *         opencv_source_code/samples/cpp/matcher_simple.cpp
//     *     </li>
//     *   </ul>
//     *   </li>
//     * </ul>
//     */

//    public class SURF : Feature2D
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
//                        xfeatures2d_SURF_delete(nativeObj);
//                    nativeObj = IntPtr.Zero;
//                }
//            }
//            finally
//            {
//                base.Dispose(disposing);
//            }

//        }

//        protected internal SURF(IntPtr addr) : base(addr) { }

//        // internal usage only
//        public static new SURF __fromPtr__(IntPtr addr) { return new SURF(addr); }

//        //
//        // C++: static Ptr_SURF cv::xfeatures2d::SURF::create(double hessianThreshold = 100, int nOctaves = 4, int nOctaveLayers = 3, bool extended = false, bool upright = false)
//        //

//        /**
//         * param hessianThreshold Threshold for hessian keypoint detector used in SURF.
//         *     param nOctaves Number of pyramid octaves the keypoint detector will use.
//         *     param nOctaveLayers Number of octave layers within each octave.
//         *     param extended Extended descriptor flag (true - use extended 128-element descriptors; false - use
//         *     64-element descriptors).
//         *     param upright Up-right or rotated features flag (true - do not compute orientation of features;
//         *     false - compute orientation).
//         * return automatically generated
//         */
//        public static SURF create(double hessianThreshold, int nOctaves, int nOctaveLayers, bool extended, bool upright)
//        {


//            return SURF.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_SURF_create_10(hessianThreshold, nOctaves, nOctaveLayers, extended, upright)));


//        }

//        /**
//         * param hessianThreshold Threshold for hessian keypoint detector used in SURF.
//         *     param nOctaves Number of pyramid octaves the keypoint detector will use.
//         *     param nOctaveLayers Number of octave layers within each octave.
//         *     param extended Extended descriptor flag (true - use extended 128-element descriptors; false - use
//         *     64-element descriptors).
//         *     false - compute orientation).
//         * return automatically generated
//         */
//        public static SURF create(double hessianThreshold, int nOctaves, int nOctaveLayers, bool extended)
//        {


//            return SURF.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_SURF_create_11(hessianThreshold, nOctaves, nOctaveLayers, extended)));


//        }

//        /**
//         * param hessianThreshold Threshold for hessian keypoint detector used in SURF.
//         *     param nOctaves Number of pyramid octaves the keypoint detector will use.
//         *     param nOctaveLayers Number of octave layers within each octave.
//         *     64-element descriptors).
//         *     false - compute orientation).
//         * return automatically generated
//         */
//        public static SURF create(double hessianThreshold, int nOctaves, int nOctaveLayers)
//        {


//            return SURF.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_SURF_create_12(hessianThreshold, nOctaves, nOctaveLayers)));


//        }

//        /**
//         * param hessianThreshold Threshold for hessian keypoint detector used in SURF.
//         *     param nOctaves Number of pyramid octaves the keypoint detector will use.
//         *     64-element descriptors).
//         *     false - compute orientation).
//         * return automatically generated
//         */
//        public static SURF create(double hessianThreshold, int nOctaves)
//        {


//            return SURF.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_SURF_create_13(hessianThreshold, nOctaves)));


//        }

//        /**
//         * param hessianThreshold Threshold for hessian keypoint detector used in SURF.
//         *     64-element descriptors).
//         *     false - compute orientation).
//         * return automatically generated
//         */
//        public static SURF create(double hessianThreshold)
//        {


//            return SURF.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_SURF_create_14(hessianThreshold)));


//        }

//        /**
//         *     64-element descriptors).
//         *     false - compute orientation).
//         * return automatically generated
//         */
//        public static SURF create()
//        {


//            return SURF.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_SURF_create_15()));


//        }


//        //
//        // C++:  void cv::xfeatures2d::SURF::setHessianThreshold(double hessianThreshold)
//        //

//        public void setHessianThreshold(double hessianThreshold)
//        {
//            ThrowIfDisposed();

//            xfeatures2d_SURF_setHessianThreshold_10(nativeObj, hessianThreshold);


//        }


//        //
//        // C++:  double cv::xfeatures2d::SURF::getHessianThreshold()
//        //

//        public double getHessianThreshold()
//        {
//            ThrowIfDisposed();

//            return xfeatures2d_SURF_getHessianThreshold_10(nativeObj);


//        }


//        //
//        // C++:  void cv::xfeatures2d::SURF::setNOctaves(int nOctaves)
//        //

//        public void setNOctaves(int nOctaves)
//        {
//            ThrowIfDisposed();

//            xfeatures2d_SURF_setNOctaves_10(nativeObj, nOctaves);


//        }


//        //
//        // C++:  int cv::xfeatures2d::SURF::getNOctaves()
//        //

//        public int getNOctaves()
//        {
//            ThrowIfDisposed();

//            return xfeatures2d_SURF_getNOctaves_10(nativeObj);


//        }


//        //
//        // C++:  void cv::xfeatures2d::SURF::setNOctaveLayers(int nOctaveLayers)
//        //

//        public void setNOctaveLayers(int nOctaveLayers)
//        {
//            ThrowIfDisposed();

//            xfeatures2d_SURF_setNOctaveLayers_10(nativeObj, nOctaveLayers);


//        }


//        //
//        // C++:  int cv::xfeatures2d::SURF::getNOctaveLayers()
//        //

//        public int getNOctaveLayers()
//        {
//            ThrowIfDisposed();

//            return xfeatures2d_SURF_getNOctaveLayers_10(nativeObj);


//        }


//        //
//        // C++:  void cv::xfeatures2d::SURF::setExtended(bool extended)
//        //

//        public void setExtended(bool extended)
//        {
//            ThrowIfDisposed();

//            xfeatures2d_SURF_setExtended_10(nativeObj, extended);


//        }


//        //
//        // C++:  bool cv::xfeatures2d::SURF::getExtended()
//        //

//        public bool getExtended()
//        {
//            ThrowIfDisposed();

//            return xfeatures2d_SURF_getExtended_10(nativeObj);


//        }


//        //
//        // C++:  void cv::xfeatures2d::SURF::setUpright(bool upright)
//        //

//        public void setUpright(bool upright)
//        {
//            ThrowIfDisposed();

//            xfeatures2d_SURF_setUpright_10(nativeObj, upright);


//        }


//        //
//        // C++:  bool cv::xfeatures2d::SURF::getUpright()
//        //

//        public bool getUpright()
//        {
//            ThrowIfDisposed();

//            return xfeatures2d_SURF_getUpright_10(nativeObj);


//        }


//        //
//        // C++:  String cv::xfeatures2d::SURF::getDefaultName()
//        //

//        public override string getDefaultName()
//        {
//            ThrowIfDisposed();

//            string retVal = Marshal.PtrToStringAnsi(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_SURF_getDefaultName_10(nativeObj)));

//            return retVal;
//        }


//#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
//        const string LIBNAME = "__Internal";
//#else
//        const string LIBNAME = "opencvforunity";
//#endif



//        // C++: static Ptr_SURF cv::xfeatures2d::SURF::create(double hessianThreshold = 100, int nOctaves = 4, int nOctaveLayers = 3, bool extended = false, bool upright = false)
//        [DllImport(LIBNAME)]
//        private static extern IntPtr xfeatures2d_SURF_create_10(double hessianThreshold, int nOctaves, int nOctaveLayers, [MarshalAs(UnmanagedType.U1)] bool extended, [MarshalAs(UnmanagedType.U1)] bool upright);
//        [DllImport(LIBNAME)]
//        private static extern IntPtr xfeatures2d_SURF_create_11(double hessianThreshold, int nOctaves, int nOctaveLayers, [MarshalAs(UnmanagedType.U1)] bool extended);
//        [DllImport(LIBNAME)]
//        private static extern IntPtr xfeatures2d_SURF_create_12(double hessianThreshold, int nOctaves, int nOctaveLayers);
//        [DllImport(LIBNAME)]
//        private static extern IntPtr xfeatures2d_SURF_create_13(double hessianThreshold, int nOctaves);
//        [DllImport(LIBNAME)]
//        private static extern IntPtr xfeatures2d_SURF_create_14(double hessianThreshold);
//        [DllImport(LIBNAME)]
//        private static extern IntPtr xfeatures2d_SURF_create_15();

//        // C++:  void cv::xfeatures2d::SURF::setHessianThreshold(double hessianThreshold)
//        [DllImport(LIBNAME)]
//        private static extern void xfeatures2d_SURF_setHessianThreshold_10(IntPtr nativeObj, double hessianThreshold);

//        // C++:  double cv::xfeatures2d::SURF::getHessianThreshold()
//        [DllImport(LIBNAME)]
//        private static extern double xfeatures2d_SURF_getHessianThreshold_10(IntPtr nativeObj);

//        // C++:  void cv::xfeatures2d::SURF::setNOctaves(int nOctaves)
//        [DllImport(LIBNAME)]
//        private static extern void xfeatures2d_SURF_setNOctaves_10(IntPtr nativeObj, int nOctaves);

//        // C++:  int cv::xfeatures2d::SURF::getNOctaves()
//        [DllImport(LIBNAME)]
//        private static extern int xfeatures2d_SURF_getNOctaves_10(IntPtr nativeObj);

//        // C++:  void cv::xfeatures2d::SURF::setNOctaveLayers(int nOctaveLayers)
//        [DllImport(LIBNAME)]
//        private static extern void xfeatures2d_SURF_setNOctaveLayers_10(IntPtr nativeObj, int nOctaveLayers);

//        // C++:  int cv::xfeatures2d::SURF::getNOctaveLayers()
//        [DllImport(LIBNAME)]
//        private static extern int xfeatures2d_SURF_getNOctaveLayers_10(IntPtr nativeObj);

//        // C++:  void cv::xfeatures2d::SURF::setExtended(bool extended)
//        [DllImport(LIBNAME)]
//        private static extern void xfeatures2d_SURF_setExtended_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool extended);

//        // C++:  bool cv::xfeatures2d::SURF::getExtended()
//        [DllImport(LIBNAME)]
//        [return: MarshalAs(UnmanagedType.U1)]
//        private static extern bool xfeatures2d_SURF_getExtended_10(IntPtr nativeObj);

//        // C++:  void cv::xfeatures2d::SURF::setUpright(bool upright)
//        [DllImport(LIBNAME)]
//        private static extern void xfeatures2d_SURF_setUpright_10(IntPtr nativeObj, [MarshalAs(UnmanagedType.U1)] bool upright);

//        // C++:  bool cv::xfeatures2d::SURF::getUpright()
//        [DllImport(LIBNAME)]
//        [return: MarshalAs(UnmanagedType.U1)]
//        private static extern bool xfeatures2d_SURF_getUpright_10(IntPtr nativeObj);

//        // C++:  String cv::xfeatures2d::SURF::getDefaultName()
//        [DllImport(LIBNAME)]
//        private static extern IntPtr xfeatures2d_SURF_getDefaultName_10(IntPtr nativeObj);

//        // native support for java finalize()
//        [DllImport(LIBNAME)]
//        private static extern void xfeatures2d_SURF_delete(IntPtr nativeObj);

//    }
//}
