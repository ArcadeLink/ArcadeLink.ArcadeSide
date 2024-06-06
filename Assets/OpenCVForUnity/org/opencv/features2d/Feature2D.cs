
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.Features2dModule
{

    // C++: class Feature2D
    /**
     * Abstract base class for 2D image feature detectors and descriptor extractors
     */

    public class Feature2D : Algorithm
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
                        features2d_Feature2D_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal Feature2D(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new Feature2D __fromPtr__(IntPtr addr) { return new Feature2D(addr); }

        //
        // C++:  void cv::Feature2D::detect(Mat image, vector_KeyPoint& keypoints, Mat mask = Mat())
        //

        /**
         * Detects keypoints in an image (first variant) or image set (second variant).
         *
         *     param image Image.
         *     param keypoints The detected keypoints. In the second variant of the method keypoints[i] is a set
         *     of keypoints detected in images[i] .
         *     param mask Mask specifying where to look for keypoints (optional). It must be a 8-bit integer
         *     matrix with non-zero values in the region of interest.
         */
        public void detect(Mat image, MatOfKeyPoint keypoints, Mat mask)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (keypoints != null) keypoints.ThrowIfDisposed();
            if (mask != null) mask.ThrowIfDisposed();
            Mat keypoints_mat = keypoints;
            features2d_Feature2D_detect_10(nativeObj, image.nativeObj, keypoints_mat.nativeObj, mask.nativeObj);


        }

        /**
         * Detects keypoints in an image (first variant) or image set (second variant).
         *
         *     param image Image.
         *     param keypoints The detected keypoints. In the second variant of the method keypoints[i] is a set
         *     of keypoints detected in images[i] .
         *     matrix with non-zero values in the region of interest.
         */
        public void detect(Mat image, MatOfKeyPoint keypoints)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (keypoints != null) keypoints.ThrowIfDisposed();
            Mat keypoints_mat = keypoints;
            features2d_Feature2D_detect_11(nativeObj, image.nativeObj, keypoints_mat.nativeObj);


        }


        //
        // C++:  void cv::Feature2D::detect(vector_Mat images, vector_vector_KeyPoint& keypoints, vector_Mat masks = vector_Mat())
        //

        /**
         *
         *     param images Image set.
         *     param keypoints The detected keypoints. In the second variant of the method keypoints[i] is a set
         *     of keypoints detected in images[i] .
         *     param masks Masks for each input image specifying where to look for keypoints (optional).
         *     masks[i] is a mask for images[i].
         */
        public void detect(List<Mat> images, List<MatOfKeyPoint> keypoints, List<Mat> masks)
        {
            ThrowIfDisposed();
            Mat images_mat = Converters.vector_Mat_to_Mat(images);
            Mat keypoints_mat = new Mat();
            Mat masks_mat = Converters.vector_Mat_to_Mat(masks);
            features2d_Feature2D_detect_12(nativeObj, images_mat.nativeObj, keypoints_mat.nativeObj, masks_mat.nativeObj);
            Converters.Mat_to_vector_vector_KeyPoint(keypoints_mat, keypoints);
            keypoints_mat.release();

        }

        /**
         *
         *     param images Image set.
         *     param keypoints The detected keypoints. In the second variant of the method keypoints[i] is a set
         *     of keypoints detected in images[i] .
         *     masks[i] is a mask for images[i].
         */
        public void detect(List<Mat> images, List<MatOfKeyPoint> keypoints)
        {
            ThrowIfDisposed();
            Mat images_mat = Converters.vector_Mat_to_Mat(images);
            Mat keypoints_mat = new Mat();
            features2d_Feature2D_detect_13(nativeObj, images_mat.nativeObj, keypoints_mat.nativeObj);
            Converters.Mat_to_vector_vector_KeyPoint(keypoints_mat, keypoints);
            keypoints_mat.release();

        }


        //
        // C++:  void cv::Feature2D::compute(Mat image, vector_KeyPoint& keypoints, Mat& descriptors)
        //

        /**
         * Computes the descriptors for a set of keypoints detected in an image (first variant) or image set
         *     (second variant).
         *
         *     param image Image.
         *     param keypoints Input collection of keypoints. Keypoints for which a descriptor cannot be
         *     computed are removed. Sometimes new keypoints can be added, for example: SIFT duplicates keypoint
         *     with several dominant orientations (for each orientation).
         *     param descriptors Computed descriptors. In the second variant of the method descriptors[i] are
         *     descriptors computed for a keypoints[i]. Row j is the keypoints (or keypoints[i]) is the
         *     descriptor for keypoint j-th keypoint.
         */
        public void compute(Mat image, MatOfKeyPoint keypoints, Mat descriptors)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (keypoints != null) keypoints.ThrowIfDisposed();
            if (descriptors != null) descriptors.ThrowIfDisposed();
            Mat keypoints_mat = keypoints;
            features2d_Feature2D_compute_10(nativeObj, image.nativeObj, keypoints_mat.nativeObj, descriptors.nativeObj);


        }


        //
        // C++:  void cv::Feature2D::compute(vector_Mat images, vector_vector_KeyPoint& keypoints, vector_Mat& descriptors)
        //

        /**
         *
         *
         *     param images Image set.
         *     param keypoints Input collection of keypoints. Keypoints for which a descriptor cannot be
         *     computed are removed. Sometimes new keypoints can be added, for example: SIFT duplicates keypoint
         *     with several dominant orientations (for each orientation).
         *     param descriptors Computed descriptors. In the second variant of the method descriptors[i] are
         *     descriptors computed for a keypoints[i]. Row j is the keypoints (or keypoints[i]) is the
         *     descriptor for keypoint j-th keypoint.
         */
        public void compute(List<Mat> images, List<MatOfKeyPoint> keypoints, List<Mat> descriptors)
        {
            ThrowIfDisposed();
            Mat images_mat = Converters.vector_Mat_to_Mat(images);
            List<Mat> keypoints_tmplm = new List<Mat>((keypoints != null) ? keypoints.Count : 0);
            Mat keypoints_mat = Converters.vector_vector_KeyPoint_to_Mat(keypoints, keypoints_tmplm);
            Mat descriptors_mat = new Mat();
            features2d_Feature2D_compute_11(nativeObj, images_mat.nativeObj, keypoints_mat.nativeObj, descriptors_mat.nativeObj);
            Converters.Mat_to_vector_vector_KeyPoint(keypoints_mat, keypoints);
            keypoints_mat.release();
            Converters.Mat_to_vector_Mat(descriptors_mat, descriptors);
            descriptors_mat.release();

        }


        //
        // C++:  void cv::Feature2D::detectAndCompute(Mat image, Mat mask, vector_KeyPoint& keypoints, Mat& descriptors, bool useProvidedKeypoints = false)
        //

        /**
         * Detects keypoints and computes the descriptors
         * param image automatically generated
         * param mask automatically generated
         * param keypoints automatically generated
         * param descriptors automatically generated
         * param useProvidedKeypoints automatically generated
         */
        public void detectAndCompute(Mat image, Mat mask, MatOfKeyPoint keypoints, Mat descriptors, bool useProvidedKeypoints)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (mask != null) mask.ThrowIfDisposed();
            if (keypoints != null) keypoints.ThrowIfDisposed();
            if (descriptors != null) descriptors.ThrowIfDisposed();
            Mat keypoints_mat = keypoints;
            features2d_Feature2D_detectAndCompute_10(nativeObj, image.nativeObj, mask.nativeObj, keypoints_mat.nativeObj, descriptors.nativeObj, useProvidedKeypoints);


        }

        /**
         * Detects keypoints and computes the descriptors
         * param image automatically generated
         * param mask automatically generated
         * param keypoints automatically generated
         * param descriptors automatically generated
         */
        public void detectAndCompute(Mat image, Mat mask, MatOfKeyPoint keypoints, Mat descriptors)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (mask != null) mask.ThrowIfDisposed();
            if (keypoints != null) keypoints.ThrowIfDisposed();
            if (descriptors != null) descriptors.ThrowIfDisposed();
            Mat keypoints_mat = keypoints;
            features2d_Feature2D_detectAndCompute_11(nativeObj, image.nativeObj, mask.nativeObj, keypoints_mat.nativeObj, descriptors.nativeObj);


        }


        //
        // C++:  int cv::Feature2D::descriptorSize()
        //

        public int descriptorSize()
        {
            ThrowIfDisposed();

            return features2d_Feature2D_descriptorSize_10(nativeObj);


        }


        //
        // C++:  int cv::Feature2D::descriptorType()
        //

        public int descriptorType()
        {
            ThrowIfDisposed();

            return features2d_Feature2D_descriptorType_10(nativeObj);


        }


        //
        // C++:  int cv::Feature2D::defaultNorm()
        //

        public int defaultNorm()
        {
            ThrowIfDisposed();

            return features2d_Feature2D_defaultNorm_10(nativeObj);


        }


        //
        // C++:  void cv::Feature2D::write(String fileName)
        //

        public void write(string fileName)
        {
            ThrowIfDisposed();

            features2d_Feature2D_write_10(nativeObj, fileName);


        }


        //
        // C++:  void cv::Feature2D::read(String fileName)
        //

        public void read(string fileName)
        {
            ThrowIfDisposed();

            features2d_Feature2D_read_10(nativeObj, fileName);


        }


        //
        // C++:  void cv::Feature2D::read(FileNode arg1)
        //

        // Unknown type 'FileNode' (I), skipping the function


        //
        // C++:  bool cv::Feature2D::empty()
        //

        public override bool empty()
        {
            ThrowIfDisposed();

            return features2d_Feature2D_empty_10(nativeObj);


        }


        //
        // C++:  String cv::Feature2D::getDefaultName()
        //

        public override string getDefaultName()
        {
            ThrowIfDisposed();

            string retVal = Marshal.PtrToStringAnsi(DisposableObject.ThrowIfNullIntPtr(features2d_Feature2D_getDefaultName_10(nativeObj)));

            return retVal;
        }


        //
        // C++:  void cv::Feature2D::write(FileStorage fs, String name)
        //

        // Unknown type 'FileStorage' (I), skipping the function


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  void cv::Feature2D::detect(Mat image, vector_KeyPoint& keypoints, Mat mask = Mat())
        [DllImport(LIBNAME)]
        private static extern void features2d_Feature2D_detect_10(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr keypoints_mat_nativeObj, IntPtr mask_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void features2d_Feature2D_detect_11(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr keypoints_mat_nativeObj);

        // C++:  void cv::Feature2D::detect(vector_Mat images, vector_vector_KeyPoint& keypoints, vector_Mat masks = vector_Mat())
        [DllImport(LIBNAME)]
        private static extern void features2d_Feature2D_detect_12(IntPtr nativeObj, IntPtr images_mat_nativeObj, IntPtr keypoints_mat_nativeObj, IntPtr masks_mat_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void features2d_Feature2D_detect_13(IntPtr nativeObj, IntPtr images_mat_nativeObj, IntPtr keypoints_mat_nativeObj);

        // C++:  void cv::Feature2D::compute(Mat image, vector_KeyPoint& keypoints, Mat& descriptors)
        [DllImport(LIBNAME)]
        private static extern void features2d_Feature2D_compute_10(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr keypoints_mat_nativeObj, IntPtr descriptors_nativeObj);

        // C++:  void cv::Feature2D::compute(vector_Mat images, vector_vector_KeyPoint& keypoints, vector_Mat& descriptors)
        [DllImport(LIBNAME)]
        private static extern void features2d_Feature2D_compute_11(IntPtr nativeObj, IntPtr images_mat_nativeObj, IntPtr keypoints_mat_nativeObj, IntPtr descriptors_mat_nativeObj);

        // C++:  void cv::Feature2D::detectAndCompute(Mat image, Mat mask, vector_KeyPoint& keypoints, Mat& descriptors, bool useProvidedKeypoints = false)
        [DllImport(LIBNAME)]
        private static extern void features2d_Feature2D_detectAndCompute_10(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr mask_nativeObj, IntPtr keypoints_mat_nativeObj, IntPtr descriptors_nativeObj, [MarshalAs(UnmanagedType.U1)] bool useProvidedKeypoints);
        [DllImport(LIBNAME)]
        private static extern void features2d_Feature2D_detectAndCompute_11(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr mask_nativeObj, IntPtr keypoints_mat_nativeObj, IntPtr descriptors_nativeObj);

        // C++:  int cv::Feature2D::descriptorSize()
        [DllImport(LIBNAME)]
        private static extern int features2d_Feature2D_descriptorSize_10(IntPtr nativeObj);

        // C++:  int cv::Feature2D::descriptorType()
        [DllImport(LIBNAME)]
        private static extern int features2d_Feature2D_descriptorType_10(IntPtr nativeObj);

        // C++:  int cv::Feature2D::defaultNorm()
        [DllImport(LIBNAME)]
        private static extern int features2d_Feature2D_defaultNorm_10(IntPtr nativeObj);

        // C++:  void cv::Feature2D::write(String fileName)
        [DllImport(LIBNAME)]
        private static extern void features2d_Feature2D_write_10(IntPtr nativeObj, string fileName);

        // C++:  void cv::Feature2D::read(String fileName)
        [DllImport(LIBNAME)]
        private static extern void features2d_Feature2D_read_10(IntPtr nativeObj, string fileName);

        // C++:  bool cv::Feature2D::empty()
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool features2d_Feature2D_empty_10(IntPtr nativeObj);

        // C++:  String cv::Feature2D::getDefaultName()
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_Feature2D_getDefaultName_10(IntPtr nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void features2d_Feature2D_delete(IntPtr nativeObj);

    }
}
