
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.FaceModule
{

    // C++: class BIF
    /**
     * Implementation of bio-inspired features (BIF) from the paper:
     * Guo, Guodong, et al. "Human age estimation using bio-inspired features."
     * Computer Vision and Pattern Recognition, 2009. CVPR 2009.
     */

    public class BIF : Algorithm
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
                        face_BIF_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal BIF(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new BIF __fromPtr__(IntPtr addr) { return new BIF(addr); }

        //
        // C++:  int cv::face::BIF::getNumBands()
        //

        /**
         * return The number of filter bands used for computing BIF.
         */
        public int getNumBands()
        {
            ThrowIfDisposed();

            return face_BIF_getNumBands_10(nativeObj);


        }


        //
        // C++:  int cv::face::BIF::getNumRotations()
        //

        /**
         * return The number of image rotations.
         */
        public int getNumRotations()
        {
            ThrowIfDisposed();

            return face_BIF_getNumRotations_10(nativeObj);


        }


        //
        // C++:  void cv::face::BIF::compute(Mat image, Mat& features)
        //

        /**
         * Computes features sby input image.
         * param image Input image (CV_32FC1).
         * param features Feature vector (CV_32FC1).
         */
        public void compute(Mat image, Mat features)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (features != null) features.ThrowIfDisposed();

            face_BIF_compute_10(nativeObj, image.nativeObj, features.nativeObj);


        }


        //
        // C++: static Ptr_BIF cv::face::BIF::create(int num_bands = 8, int num_rotations = 12)
        //

        /**
         * param num_bands The number of filter bands (&lt;=8) used for computing BIF.
         * param num_rotations The number of image rotations for computing BIF.
         * return Object for computing BIF.
         */
        public static BIF create(int num_bands, int num_rotations)
        {


            return BIF.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(face_BIF_create_10(num_bands, num_rotations)));


        }

        /**
         * param num_bands The number of filter bands (&lt;=8) used for computing BIF.
         * return Object for computing BIF.
         */
        public static BIF create(int num_bands)
        {


            return BIF.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(face_BIF_create_11(num_bands)));


        }

        /**
         * return Object for computing BIF.
         */
        public static BIF create()
        {


            return BIF.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(face_BIF_create_12()));


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  int cv::face::BIF::getNumBands()
        [DllImport(LIBNAME)]
        private static extern int face_BIF_getNumBands_10(IntPtr nativeObj);

        // C++:  int cv::face::BIF::getNumRotations()
        [DllImport(LIBNAME)]
        private static extern int face_BIF_getNumRotations_10(IntPtr nativeObj);

        // C++:  void cv::face::BIF::compute(Mat image, Mat& features)
        [DllImport(LIBNAME)]
        private static extern void face_BIF_compute_10(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr features_nativeObj);

        // C++: static Ptr_BIF cv::face::BIF::create(int num_bands = 8, int num_rotations = 12)
        [DllImport(LIBNAME)]
        private static extern IntPtr face_BIF_create_10(int num_bands, int num_rotations);
        [DllImport(LIBNAME)]
        private static extern IntPtr face_BIF_create_11(int num_bands);
        [DllImport(LIBNAME)]
        private static extern IntPtr face_BIF_create_12();

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void face_BIF_delete(IntPtr nativeObj);

    }
}
