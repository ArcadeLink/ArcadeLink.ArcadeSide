

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.Features2dModule
{
    // C++: class BOWTrainer
    /**
     * Abstract base class for training the *bag of visual words* vocabulary from a set of descriptors.
     *
     * For details, see, for example, *Visual Categorization with Bags of Keypoints* by Gabriella Csurka,
     * Christopher R. Dance, Lixin Fan, Jutta Willamowski, Cedric Bray, 2004. :
     */

    public class BOWTrainer : DisposableOpenCVObject
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
                        features2d_BOWTrainer_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal BOWTrainer(IntPtr addr) : base(addr) { }


        public IntPtr getNativeObjAddr() { return nativeObj; }

        // internal usage only
        public static BOWTrainer __fromPtr__(IntPtr addr) { return new BOWTrainer(addr); }

        //
        // C++:  void cv::BOWTrainer::add(Mat descriptors)
        //

        /**
         * Adds descriptors to a training set.
         *
         *     param descriptors Descriptors to add to a training set. Each row of the descriptors matrix is a
         *     descriptor.
         *
         *     The training set is clustered using clustermethod to construct the vocabulary.
         */
        public void add(Mat descriptors)
        {
            ThrowIfDisposed();
            if (descriptors != null) descriptors.ThrowIfDisposed();

            features2d_BOWTrainer_add_10(nativeObj, descriptors.nativeObj);


        }


        //
        // C++:  vector_Mat cv::BOWTrainer::getDescriptors()
        //

        /**
         * Returns a training set of descriptors.
         * return automatically generated
         */
        public List<Mat> getDescriptors()
        {
            ThrowIfDisposed();
            List<Mat> retVal = new List<Mat>();
            Mat retValMat = new Mat(DisposableObject.ThrowIfNullIntPtr(features2d_BOWTrainer_getDescriptors_10(nativeObj)));
            Converters.Mat_to_vector_Mat(retValMat, retVal);
            return retVal;
        }


        //
        // C++:  int cv::BOWTrainer::descriptorsCount()
        //

        /**
         * Returns the count of all descriptors stored in the training set.
         * return automatically generated
         */
        public int descriptorsCount()
        {
            ThrowIfDisposed();

            return features2d_BOWTrainer_descriptorsCount_10(nativeObj);


        }


        //
        // C++:  void cv::BOWTrainer::clear()
        //

        public void clear()
        {
            ThrowIfDisposed();

            features2d_BOWTrainer_clear_10(nativeObj);


        }


        //
        // C++:  Mat cv::BOWTrainer::cluster()
        //

        public virtual Mat cluster()
        {
            ThrowIfDisposed();

            return new Mat(DisposableObject.ThrowIfNullIntPtr(features2d_BOWTrainer_cluster_10(nativeObj)));


        }


        //
        // C++:  Mat cv::BOWTrainer::cluster(Mat descriptors)
        //

        /**
         * Clusters train descriptors.
         *
         *     param descriptors Descriptors to cluster. Each row of the descriptors matrix is a descriptor.
         *     Descriptors are not added to the inner train descriptor set.
         *
         *     The vocabulary consists of cluster centers. So, this method returns the vocabulary. In the first
         *     variant of the method, train descriptors stored in the object are clustered. In the second variant,
         *     input descriptors are clustered.
         * return automatically generated
         */
        public virtual Mat cluster(Mat descriptors)
        {
            ThrowIfDisposed();
            if (descriptors != null) descriptors.ThrowIfDisposed();

            return new Mat(DisposableObject.ThrowIfNullIntPtr(features2d_BOWTrainer_cluster_11(nativeObj, descriptors.nativeObj)));


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  void cv::BOWTrainer::add(Mat descriptors)
        [DllImport(LIBNAME)]
        private static extern void features2d_BOWTrainer_add_10(IntPtr nativeObj, IntPtr descriptors_nativeObj);

        // C++:  vector_Mat cv::BOWTrainer::getDescriptors()
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_BOWTrainer_getDescriptors_10(IntPtr nativeObj);

        // C++:  int cv::BOWTrainer::descriptorsCount()
        [DllImport(LIBNAME)]
        private static extern int features2d_BOWTrainer_descriptorsCount_10(IntPtr nativeObj);

        // C++:  void cv::BOWTrainer::clear()
        [DllImport(LIBNAME)]
        private static extern void features2d_BOWTrainer_clear_10(IntPtr nativeObj);

        // C++:  Mat cv::BOWTrainer::cluster()
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_BOWTrainer_cluster_10(IntPtr nativeObj);

        // C++:  Mat cv::BOWTrainer::cluster(Mat descriptors)
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_BOWTrainer_cluster_11(IntPtr nativeObj, IntPtr descriptors_nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void features2d_BOWTrainer_delete(IntPtr nativeObj);

    }
}
