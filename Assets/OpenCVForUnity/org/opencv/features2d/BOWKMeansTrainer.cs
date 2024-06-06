
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.Features2dModule
{

    // C++: class BOWKMeansTrainer
    /**
     * kmeans -based class to train visual vocabulary using the *bag of visual words* approach. :
     */

    public class BOWKMeansTrainer : BOWTrainer
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
                        features2d_BOWKMeansTrainer_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal BOWKMeansTrainer(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new BOWKMeansTrainer __fromPtr__(IntPtr addr) { return new BOWKMeansTrainer(addr); }

        //
        // C++:   cv::BOWKMeansTrainer::BOWKMeansTrainer(int clusterCount, TermCriteria termcrit = TermCriteria(), int attempts = 3, int flags = KMEANS_PP_CENTERS)
        //

        /**
         * The constructor.
         *
         *     SEE: cv::kmeans
         * param clusterCount automatically generated
         * param termcrit automatically generated
         * param attempts automatically generated
         * param flags automatically generated
         */
        public BOWKMeansTrainer(int clusterCount, TermCriteria termcrit, int attempts, int flags) :
            base(DisposableObject.ThrowIfNullIntPtr(features2d_BOWKMeansTrainer_BOWKMeansTrainer_10(clusterCount, termcrit.type, termcrit.maxCount, termcrit.epsilon, attempts, flags)))
        {



        }

        /**
         * The constructor.
         *
         *     SEE: cv::kmeans
         * param clusterCount automatically generated
         * param termcrit automatically generated
         * param attempts automatically generated
         */
        public BOWKMeansTrainer(int clusterCount, TermCriteria termcrit, int attempts) :
            base(DisposableObject.ThrowIfNullIntPtr(features2d_BOWKMeansTrainer_BOWKMeansTrainer_11(clusterCount, termcrit.type, termcrit.maxCount, termcrit.epsilon, attempts)))
        {



        }

        /**
         * The constructor.
         *
         *     SEE: cv::kmeans
         * param clusterCount automatically generated
         * param termcrit automatically generated
         */
        public BOWKMeansTrainer(int clusterCount, TermCriteria termcrit) :
            base(DisposableObject.ThrowIfNullIntPtr(features2d_BOWKMeansTrainer_BOWKMeansTrainer_12(clusterCount, termcrit.type, termcrit.maxCount, termcrit.epsilon)))
        {



        }

        /**
         * The constructor.
         *
         *     SEE: cv::kmeans
         * param clusterCount automatically generated
         */
        public BOWKMeansTrainer(int clusterCount) :
            base(DisposableObject.ThrowIfNullIntPtr(features2d_BOWKMeansTrainer_BOWKMeansTrainer_13(clusterCount)))
        {



        }


        //
        // C++:  Mat cv::BOWKMeansTrainer::cluster()
        //

        public override Mat cluster()
        {
            ThrowIfDisposed();

            return new Mat(DisposableObject.ThrowIfNullIntPtr(features2d_BOWKMeansTrainer_cluster_10(nativeObj)));


        }


        //
        // C++:  Mat cv::BOWKMeansTrainer::cluster(Mat descriptors)
        //

        public override Mat cluster(Mat descriptors)
        {
            ThrowIfDisposed();
            if (descriptors != null) descriptors.ThrowIfDisposed();

            return new Mat(DisposableObject.ThrowIfNullIntPtr(features2d_BOWKMeansTrainer_cluster_11(nativeObj, descriptors.nativeObj)));


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:   cv::BOWKMeansTrainer::BOWKMeansTrainer(int clusterCount, TermCriteria termcrit = TermCriteria(), int attempts = 3, int flags = KMEANS_PP_CENTERS)
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_BOWKMeansTrainer_BOWKMeansTrainer_10(int clusterCount, int termcrit_type, int termcrit_maxCount, double termcrit_epsilon, int attempts, int flags);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_BOWKMeansTrainer_BOWKMeansTrainer_11(int clusterCount, int termcrit_type, int termcrit_maxCount, double termcrit_epsilon, int attempts);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_BOWKMeansTrainer_BOWKMeansTrainer_12(int clusterCount, int termcrit_type, int termcrit_maxCount, double termcrit_epsilon);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_BOWKMeansTrainer_BOWKMeansTrainer_13(int clusterCount);

        // C++:  Mat cv::BOWKMeansTrainer::cluster()
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_BOWKMeansTrainer_cluster_10(IntPtr nativeObj);

        // C++:  Mat cv::BOWKMeansTrainer::cluster(Mat descriptors)
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_BOWKMeansTrainer_cluster_11(IntPtr nativeObj, IntPtr descriptors_nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void features2d_BOWKMeansTrainer_delete(IntPtr nativeObj);

    }
}
