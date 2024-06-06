
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.Xfeatures2dModule
{

    // C++: class PCTSignaturesSQFD
    /**
     * Class implementing Signature Quadratic Form Distance (SQFD).
     * SEE: Christian Beecks, Merih Seran Uysal, Thomas Seidl.
     * Signature quadratic form distance.
     * In Proceedings of the ACM International Conference on Image and Video Retrieval, pages 438-445.
     * ACM, 2010.
     * CITE: BeecksUS10
     */

    public class PCTSignaturesSQFD : Algorithm
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
                        xfeatures2d_PCTSignaturesSQFD_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal PCTSignaturesSQFD(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new PCTSignaturesSQFD __fromPtr__(IntPtr addr) { return new PCTSignaturesSQFD(addr); }

        //
        // C++: static Ptr_PCTSignaturesSQFD cv::xfeatures2d::PCTSignaturesSQFD::create(int distanceFunction = 3, int similarityFunction = 2, float similarityParameter = 1.0f)
        //

        /**
         * Creates the algorithm instance using selected distance function,
         * similarity function and similarity function parameter.
         * param distanceFunction Distance function selector. Default: L2
         * Available: L0_25, L0_5, L1, L2, L2SQUARED, L5, L_INFINITY
         * param similarityFunction Similarity function selector. Default: HEURISTIC
         * Available: MINUS, GAUSSIAN, HEURISTIC
         * param similarityParameter Parameter of the similarity function.
         * return automatically generated
         */
        public static PCTSignaturesSQFD create(int distanceFunction, int similarityFunction, float similarityParameter)
        {


            return PCTSignaturesSQFD.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_PCTSignaturesSQFD_create_10(distanceFunction, similarityFunction, similarityParameter)));


        }

        /**
         * Creates the algorithm instance using selected distance function,
         * similarity function and similarity function parameter.
         * param distanceFunction Distance function selector. Default: L2
         * Available: L0_25, L0_5, L1, L2, L2SQUARED, L5, L_INFINITY
         * param similarityFunction Similarity function selector. Default: HEURISTIC
         * Available: MINUS, GAUSSIAN, HEURISTIC
         * return automatically generated
         */
        public static PCTSignaturesSQFD create(int distanceFunction, int similarityFunction)
        {


            return PCTSignaturesSQFD.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_PCTSignaturesSQFD_create_11(distanceFunction, similarityFunction)));


        }

        /**
         * Creates the algorithm instance using selected distance function,
         * similarity function and similarity function parameter.
         * param distanceFunction Distance function selector. Default: L2
         * Available: L0_25, L0_5, L1, L2, L2SQUARED, L5, L_INFINITY
         * Available: MINUS, GAUSSIAN, HEURISTIC
         * return automatically generated
         */
        public static PCTSignaturesSQFD create(int distanceFunction)
        {


            return PCTSignaturesSQFD.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_PCTSignaturesSQFD_create_12(distanceFunction)));


        }

        /**
         * Creates the algorithm instance using selected distance function,
         * similarity function and similarity function parameter.
         * Available: L0_25, L0_5, L1, L2, L2SQUARED, L5, L_INFINITY
         * Available: MINUS, GAUSSIAN, HEURISTIC
         * return automatically generated
         */
        public static PCTSignaturesSQFD create()
        {


            return PCTSignaturesSQFD.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_PCTSignaturesSQFD_create_13()));


        }


        //
        // C++:  float cv::xfeatures2d::PCTSignaturesSQFD::computeQuadraticFormDistance(Mat _signature0, Mat _signature1)
        //

        /**
         * Computes Signature Quadratic Form Distance of two signatures.
         * param _signature0 The first signature.
         * param _signature1 The second signature.
         * return automatically generated
         */
        public float computeQuadraticFormDistance(Mat _signature0, Mat _signature1)
        {
            ThrowIfDisposed();
            if (_signature0 != null) _signature0.ThrowIfDisposed();
            if (_signature1 != null) _signature1.ThrowIfDisposed();

            return xfeatures2d_PCTSignaturesSQFD_computeQuadraticFormDistance_10(nativeObj, _signature0.nativeObj, _signature1.nativeObj);


        }


        //
        // C++:  void cv::xfeatures2d::PCTSignaturesSQFD::computeQuadraticFormDistances(Mat sourceSignature, vector_Mat imageSignatures, vector_float distances)
        //

        /**
         * Computes Signature Quadratic Form Distance between the reference signature
         * and each of the other image signatures.
         * param sourceSignature The signature to measure distance of other signatures from.
         * param imageSignatures Vector of signatures to measure distance from the source signature.
         * param distances Output vector of measured distances.
         */
        public void computeQuadraticFormDistances(Mat sourceSignature, List<Mat> imageSignatures, MatOfFloat distances)
        {
            ThrowIfDisposed();
            if (sourceSignature != null) sourceSignature.ThrowIfDisposed();
            if (distances != null) distances.ThrowIfDisposed();
            Mat imageSignatures_mat = Converters.vector_Mat_to_Mat(imageSignatures);
            Mat distances_mat = distances;
            xfeatures2d_PCTSignaturesSQFD_computeQuadraticFormDistances_10(nativeObj, sourceSignature.nativeObj, imageSignatures_mat.nativeObj, distances_mat.nativeObj);


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++: static Ptr_PCTSignaturesSQFD cv::xfeatures2d::PCTSignaturesSQFD::create(int distanceFunction = 3, int similarityFunction = 2, float similarityParameter = 1.0f)
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_PCTSignaturesSQFD_create_10(int distanceFunction, int similarityFunction, float similarityParameter);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_PCTSignaturesSQFD_create_11(int distanceFunction, int similarityFunction);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_PCTSignaturesSQFD_create_12(int distanceFunction);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_PCTSignaturesSQFD_create_13();

        // C++:  float cv::xfeatures2d::PCTSignaturesSQFD::computeQuadraticFormDistance(Mat _signature0, Mat _signature1)
        [DllImport(LIBNAME)]
        private static extern float xfeatures2d_PCTSignaturesSQFD_computeQuadraticFormDistance_10(IntPtr nativeObj, IntPtr _signature0_nativeObj, IntPtr _signature1_nativeObj);

        // C++:  void cv::xfeatures2d::PCTSignaturesSQFD::computeQuadraticFormDistances(Mat sourceSignature, vector_Mat imageSignatures, vector_float distances)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_PCTSignaturesSQFD_computeQuadraticFormDistances_10(IntPtr nativeObj, IntPtr sourceSignature_nativeObj, IntPtr imageSignatures_mat_nativeObj, IntPtr distances_mat_nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_PCTSignaturesSQFD_delete(IntPtr nativeObj);

    }
}
