
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.Xfeatures2dModule
{

    // C++: class PCTSignatures
    /**
     * Class implementing PCT (position-color-texture) signature extraction
     * as described in CITE: KrulisLS16.
     * The algorithm is divided to a feature sampler and a clusterizer.
     * Feature sampler produces samples at given set of coordinates.
     * Clusterizer then produces clusters of these samples using k-means algorithm.
     * Resulting set of clusters is the signature of the input image.
     *
     * A signature is an array of SIGNATURE_DIMENSION-dimensional points.
     * Used dimensions are:
     * weight, x, y position; lab color, contrast, entropy.
     * CITE: KrulisLS16
     * CITE: BeecksUS10
     */

    public class PCTSignatures : Algorithm
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
                        xfeatures2d_PCTSignatures_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal PCTSignatures(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new PCTSignatures __fromPtr__(IntPtr addr) { return new PCTSignatures(addr); }

        // C++: enum cv.xfeatures2d.PCTSignatures.DistanceFunction
        public const int L0_25 = 0;
        public const int L0_5 = 1;
        public const int L1 = 2;
        public const int L2 = 3;
        public const int L2SQUARED = 4;
        public const int L5 = 5;
        public const int L_INFINITY = 6;
        // C++: enum cv.xfeatures2d.PCTSignatures.PointDistribution
        public const int UNIFORM = 0;
        public const int REGULAR = 1;
        public const int NORMAL = 2;
        // C++: enum cv.xfeatures2d.PCTSignatures.SimilarityFunction
        public const int MINUS = 0;
        public const int GAUSSIAN = 1;
        public const int HEURISTIC = 2;
        //
        // C++: static Ptr_PCTSignatures cv::xfeatures2d::PCTSignatures::create(int initSampleCount = 2000, int initSeedCount = 400, int pointDistribution = 0)
        //

        /**
         * Creates PCTSignatures algorithm using sample and seed count.
         * It generates its own sets of sampling points and clusterization seed indexes.
         * param initSampleCount Number of points used for image sampling.
         * param initSeedCount Number of initial clusterization seeds.
         * Must be lower or equal to initSampleCount
         * param pointDistribution Distribution of generated points. Default: UNIFORM.
         * Available: UNIFORM, REGULAR, NORMAL.
         * return Created algorithm.
         */
        public static PCTSignatures create(int initSampleCount, int initSeedCount, int pointDistribution)
        {


            return PCTSignatures.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_PCTSignatures_create_10(initSampleCount, initSeedCount, pointDistribution)));


        }

        /**
         * Creates PCTSignatures algorithm using sample and seed count.
         * It generates its own sets of sampling points and clusterization seed indexes.
         * param initSampleCount Number of points used for image sampling.
         * param initSeedCount Number of initial clusterization seeds.
         * Must be lower or equal to initSampleCount
         * Available: UNIFORM, REGULAR, NORMAL.
         * return Created algorithm.
         */
        public static PCTSignatures create(int initSampleCount, int initSeedCount)
        {


            return PCTSignatures.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_PCTSignatures_create_11(initSampleCount, initSeedCount)));


        }

        /**
         * Creates PCTSignatures algorithm using sample and seed count.
         * It generates its own sets of sampling points and clusterization seed indexes.
         * param initSampleCount Number of points used for image sampling.
         * Must be lower or equal to initSampleCount
         * Available: UNIFORM, REGULAR, NORMAL.
         * return Created algorithm.
         */
        public static PCTSignatures create(int initSampleCount)
        {


            return PCTSignatures.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_PCTSignatures_create_12(initSampleCount)));


        }

        /**
         * Creates PCTSignatures algorithm using sample and seed count.
         * It generates its own sets of sampling points and clusterization seed indexes.
         * Must be lower or equal to initSampleCount
         * Available: UNIFORM, REGULAR, NORMAL.
         * return Created algorithm.
         */
        public static PCTSignatures create()
        {


            return PCTSignatures.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_PCTSignatures_create_13()));


        }


        //
        // C++: static Ptr_PCTSignatures cv::xfeatures2d::PCTSignatures::create(vector_Point2f initSamplingPoints, int initSeedCount)
        //

        /**
         * Creates PCTSignatures algorithm using pre-generated sampling points
         * and number of clusterization seeds. It uses the provided
         * sampling points and generates its own clusterization seed indexes.
         * param initSamplingPoints Sampling points used in image sampling.
         * param initSeedCount Number of initial clusterization seeds.
         * Must be lower or equal to initSamplingPoints.size().
         * return Created algorithm.
         */
        public static PCTSignatures create(MatOfPoint2f initSamplingPoints, int initSeedCount)
        {
            if (initSamplingPoints != null) initSamplingPoints.ThrowIfDisposed();
            Mat initSamplingPoints_mat = initSamplingPoints;
            return PCTSignatures.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_PCTSignatures_create_14(initSamplingPoints_mat.nativeObj, initSeedCount)));


        }


        //
        // C++: static Ptr_PCTSignatures cv::xfeatures2d::PCTSignatures::create(vector_Point2f initSamplingPoints, vector_int initClusterSeedIndexes)
        //

        /**
         * Creates PCTSignatures algorithm using pre-generated sampling points
         * and clusterization seeds indexes.
         * param initSamplingPoints Sampling points used in image sampling.
         * param initClusterSeedIndexes Indexes of initial clusterization seeds.
         * Its size must be lower or equal to initSamplingPoints.size().
         * return Created algorithm.
         */
        public static PCTSignatures create(MatOfPoint2f initSamplingPoints, MatOfInt initClusterSeedIndexes)
        {
            if (initSamplingPoints != null) initSamplingPoints.ThrowIfDisposed();
            if (initClusterSeedIndexes != null) initClusterSeedIndexes.ThrowIfDisposed();
            Mat initSamplingPoints_mat = initSamplingPoints;
            Mat initClusterSeedIndexes_mat = initClusterSeedIndexes;
            return PCTSignatures.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_PCTSignatures_create_15(initSamplingPoints_mat.nativeObj, initClusterSeedIndexes_mat.nativeObj)));


        }


        //
        // C++:  void cv::xfeatures2d::PCTSignatures::computeSignature(Mat image, Mat& signature)
        //

        /**
         * Computes signature of given image.
         * param image Input image of CV_8U type.
         * param signature Output computed signature.
         */
        public void computeSignature(Mat image, Mat signature)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (signature != null) signature.ThrowIfDisposed();

            xfeatures2d_PCTSignatures_computeSignature_10(nativeObj, image.nativeObj, signature.nativeObj);


        }


        //
        // C++:  void cv::xfeatures2d::PCTSignatures::computeSignatures(vector_Mat images, vector_Mat signatures)
        //

        /**
         * Computes signatures for multiple images in parallel.
         * param images Vector of input images of CV_8U type.
         * param signatures Vector of computed signatures.
         */
        public void computeSignatures(List<Mat> images, List<Mat> signatures)
        {
            ThrowIfDisposed();
            Mat images_mat = Converters.vector_Mat_to_Mat(images);
            Mat signatures_mat = Converters.vector_Mat_to_Mat(signatures);
            xfeatures2d_PCTSignatures_computeSignatures_10(nativeObj, images_mat.nativeObj, signatures_mat.nativeObj);


        }


        //
        // C++: static void cv::xfeatures2d::PCTSignatures::drawSignature(Mat source, Mat signature, Mat& result, float radiusToShorterSideRatio = 1.0 / 8, int borderThickness = 1)
        //

        /**
         * Draws signature in the source image and outputs the result.
         * Signatures are visualized as a circle
         * with radius based on signature weight
         * and color based on signature color.
         * Contrast and entropy are not visualized.
         * param source Source image.
         * param signature Image signature.
         * param result Output result.
         * param radiusToShorterSideRatio Determines maximal radius of signature in the output image.
         * param borderThickness Border thickness of the visualized signature.
         */
        public static void drawSignature(Mat source, Mat signature, Mat result, float radiusToShorterSideRatio, int borderThickness)
        {
            if (source != null) source.ThrowIfDisposed();
            if (signature != null) signature.ThrowIfDisposed();
            if (result != null) result.ThrowIfDisposed();

            xfeatures2d_PCTSignatures_drawSignature_10(source.nativeObj, signature.nativeObj, result.nativeObj, radiusToShorterSideRatio, borderThickness);


        }

        /**
         * Draws signature in the source image and outputs the result.
         * Signatures are visualized as a circle
         * with radius based on signature weight
         * and color based on signature color.
         * Contrast and entropy are not visualized.
         * param source Source image.
         * param signature Image signature.
         * param result Output result.
         * param radiusToShorterSideRatio Determines maximal radius of signature in the output image.
         */
        public static void drawSignature(Mat source, Mat signature, Mat result, float radiusToShorterSideRatio)
        {
            if (source != null) source.ThrowIfDisposed();
            if (signature != null) signature.ThrowIfDisposed();
            if (result != null) result.ThrowIfDisposed();

            xfeatures2d_PCTSignatures_drawSignature_11(source.nativeObj, signature.nativeObj, result.nativeObj, radiusToShorterSideRatio);


        }

        /**
         * Draws signature in the source image and outputs the result.
         * Signatures are visualized as a circle
         * with radius based on signature weight
         * and color based on signature color.
         * Contrast and entropy are not visualized.
         * param source Source image.
         * param signature Image signature.
         * param result Output result.
         */
        public static void drawSignature(Mat source, Mat signature, Mat result)
        {
            if (source != null) source.ThrowIfDisposed();
            if (signature != null) signature.ThrowIfDisposed();
            if (result != null) result.ThrowIfDisposed();

            xfeatures2d_PCTSignatures_drawSignature_12(source.nativeObj, signature.nativeObj, result.nativeObj);


        }


        //
        // C++: static void cv::xfeatures2d::PCTSignatures::generateInitPoints(vector_Point2f initPoints, int count, int pointDistribution)
        //

        /**
         * Generates initial sampling points according to selected point distribution.
         * param initPoints Output vector where the generated points will be saved.
         * param count Number of points to generate.
         * param pointDistribution Point distribution selector.
         * Available: UNIFORM, REGULAR, NORMAL.
         * <b>Note:</b> Generated coordinates are in range [0..1)
         */
        public static void generateInitPoints(MatOfPoint2f initPoints, int count, int pointDistribution)
        {
            if (initPoints != null) initPoints.ThrowIfDisposed();
            Mat initPoints_mat = initPoints;
            xfeatures2d_PCTSignatures_generateInitPoints_10(initPoints_mat.nativeObj, count, pointDistribution);


        }


        //
        // C++:  int cv::xfeatures2d::PCTSignatures::getSampleCount()
        //

        /**
         * Number of initial samples taken from the image.
         * return automatically generated
         */
        public int getSampleCount()
        {
            ThrowIfDisposed();

            return xfeatures2d_PCTSignatures_getSampleCount_10(nativeObj);


        }


        //
        // C++:  int cv::xfeatures2d::PCTSignatures::getGrayscaleBits()
        //

        /**
         * Color resolution of the greyscale bitmap represented in allocated bits
         * (i.e., value 4 means that 16 shades of grey are used).
         * The greyscale bitmap is used for computing contrast and entropy values.
         * return automatically generated
         */
        public int getGrayscaleBits()
        {
            ThrowIfDisposed();

            return xfeatures2d_PCTSignatures_getGrayscaleBits_10(nativeObj);


        }


        //
        // C++:  void cv::xfeatures2d::PCTSignatures::setGrayscaleBits(int grayscaleBits)
        //

        /**
         * Color resolution of the greyscale bitmap represented in allocated bits
         * (i.e., value 4 means that 16 shades of grey are used).
         * The greyscale bitmap is used for computing contrast and entropy values.
         * param grayscaleBits automatically generated
         */
        public void setGrayscaleBits(int grayscaleBits)
        {
            ThrowIfDisposed();

            xfeatures2d_PCTSignatures_setGrayscaleBits_10(nativeObj, grayscaleBits);


        }


        //
        // C++:  int cv::xfeatures2d::PCTSignatures::getWindowRadius()
        //

        /**
         * Size of the texture sampling window used to compute contrast and entropy
         * (center of the window is always in the pixel selected by x,y coordinates
         * of the corresponding feature sample).
         * return automatically generated
         */
        public int getWindowRadius()
        {
            ThrowIfDisposed();

            return xfeatures2d_PCTSignatures_getWindowRadius_10(nativeObj);


        }


        //
        // C++:  void cv::xfeatures2d::PCTSignatures::setWindowRadius(int radius)
        //

        /**
         * Size of the texture sampling window used to compute contrast and entropy
         * (center of the window is always in the pixel selected by x,y coordinates
         * of the corresponding feature sample).
         * param radius automatically generated
         */
        public void setWindowRadius(int radius)
        {
            ThrowIfDisposed();

            xfeatures2d_PCTSignatures_setWindowRadius_10(nativeObj, radius);


        }


        //
        // C++:  float cv::xfeatures2d::PCTSignatures::getWeightX()
        //

        /**
         * Weights (multiplicative constants) that linearly stretch individual axes of the feature space
         * (x,y = position; L,a,b = color in CIE Lab space; c = contrast. e = entropy)
         * return automatically generated
         */
        public float getWeightX()
        {
            ThrowIfDisposed();

            return xfeatures2d_PCTSignatures_getWeightX_10(nativeObj);


        }


        //
        // C++:  void cv::xfeatures2d::PCTSignatures::setWeightX(float weight)
        //

        /**
         * Weights (multiplicative constants) that linearly stretch individual axes of the feature space
         * (x,y = position; L,a,b = color in CIE Lab space; c = contrast. e = entropy)
         * param weight automatically generated
         */
        public void setWeightX(float weight)
        {
            ThrowIfDisposed();

            xfeatures2d_PCTSignatures_setWeightX_10(nativeObj, weight);


        }


        //
        // C++:  float cv::xfeatures2d::PCTSignatures::getWeightY()
        //

        /**
         * Weights (multiplicative constants) that linearly stretch individual axes of the feature space
         * (x,y = position; L,a,b = color in CIE Lab space; c = contrast. e = entropy)
         * return automatically generated
         */
        public float getWeightY()
        {
            ThrowIfDisposed();

            return xfeatures2d_PCTSignatures_getWeightY_10(nativeObj);


        }


        //
        // C++:  void cv::xfeatures2d::PCTSignatures::setWeightY(float weight)
        //

        /**
         * Weights (multiplicative constants) that linearly stretch individual axes of the feature space
         * (x,y = position; L,a,b = color in CIE Lab space; c = contrast. e = entropy)
         * param weight automatically generated
         */
        public void setWeightY(float weight)
        {
            ThrowIfDisposed();

            xfeatures2d_PCTSignatures_setWeightY_10(nativeObj, weight);


        }


        //
        // C++:  float cv::xfeatures2d::PCTSignatures::getWeightL()
        //

        /**
         * Weights (multiplicative constants) that linearly stretch individual axes of the feature space
         * (x,y = position; L,a,b = color in CIE Lab space; c = contrast. e = entropy)
         * return automatically generated
         */
        public float getWeightL()
        {
            ThrowIfDisposed();

            return xfeatures2d_PCTSignatures_getWeightL_10(nativeObj);


        }


        //
        // C++:  void cv::xfeatures2d::PCTSignatures::setWeightL(float weight)
        //

        /**
         * Weights (multiplicative constants) that linearly stretch individual axes of the feature space
         * (x,y = position; L,a,b = color in CIE Lab space; c = contrast. e = entropy)
         * param weight automatically generated
         */
        public void setWeightL(float weight)
        {
            ThrowIfDisposed();

            xfeatures2d_PCTSignatures_setWeightL_10(nativeObj, weight);


        }


        //
        // C++:  float cv::xfeatures2d::PCTSignatures::getWeightA()
        //

        /**
         * Weights (multiplicative constants) that linearly stretch individual axes of the feature space
         * (x,y = position; L,a,b = color in CIE Lab space; c = contrast. e = entropy)
         * return automatically generated
         */
        public float getWeightA()
        {
            ThrowIfDisposed();

            return xfeatures2d_PCTSignatures_getWeightA_10(nativeObj);


        }


        //
        // C++:  void cv::xfeatures2d::PCTSignatures::setWeightA(float weight)
        //

        /**
         * Weights (multiplicative constants) that linearly stretch individual axes of the feature space
         * (x,y = position; L,a,b = color in CIE Lab space; c = contrast. e = entropy)
         * param weight automatically generated
         */
        public void setWeightA(float weight)
        {
            ThrowIfDisposed();

            xfeatures2d_PCTSignatures_setWeightA_10(nativeObj, weight);


        }


        //
        // C++:  float cv::xfeatures2d::PCTSignatures::getWeightB()
        //

        /**
         * Weights (multiplicative constants) that linearly stretch individual axes of the feature space
         * (x,y = position; L,a,b = color in CIE Lab space; c = contrast. e = entropy)
         * return automatically generated
         */
        public float getWeightB()
        {
            ThrowIfDisposed();

            return xfeatures2d_PCTSignatures_getWeightB_10(nativeObj);


        }


        //
        // C++:  void cv::xfeatures2d::PCTSignatures::setWeightB(float weight)
        //

        /**
         * Weights (multiplicative constants) that linearly stretch individual axes of the feature space
         * (x,y = position; L,a,b = color in CIE Lab space; c = contrast. e = entropy)
         * param weight automatically generated
         */
        public void setWeightB(float weight)
        {
            ThrowIfDisposed();

            xfeatures2d_PCTSignatures_setWeightB_10(nativeObj, weight);


        }


        //
        // C++:  float cv::xfeatures2d::PCTSignatures::getWeightContrast()
        //

        /**
         * Weights (multiplicative constants) that linearly stretch individual axes of the feature space
         * (x,y = position; L,a,b = color in CIE Lab space; c = contrast. e = entropy)
         * return automatically generated
         */
        public float getWeightContrast()
        {
            ThrowIfDisposed();

            return xfeatures2d_PCTSignatures_getWeightContrast_10(nativeObj);


        }


        //
        // C++:  void cv::xfeatures2d::PCTSignatures::setWeightContrast(float weight)
        //

        /**
         * Weights (multiplicative constants) that linearly stretch individual axes of the feature space
         * (x,y = position; L,a,b = color in CIE Lab space; c = contrast. e = entropy)
         * param weight automatically generated
         */
        public void setWeightContrast(float weight)
        {
            ThrowIfDisposed();

            xfeatures2d_PCTSignatures_setWeightContrast_10(nativeObj, weight);


        }


        //
        // C++:  float cv::xfeatures2d::PCTSignatures::getWeightEntropy()
        //

        /**
         * Weights (multiplicative constants) that linearly stretch individual axes of the feature space
         * (x,y = position; L,a,b = color in CIE Lab space; c = contrast. e = entropy)
         * return automatically generated
         */
        public float getWeightEntropy()
        {
            ThrowIfDisposed();

            return xfeatures2d_PCTSignatures_getWeightEntropy_10(nativeObj);


        }


        //
        // C++:  void cv::xfeatures2d::PCTSignatures::setWeightEntropy(float weight)
        //

        /**
         * Weights (multiplicative constants) that linearly stretch individual axes of the feature space
         * (x,y = position; L,a,b = color in CIE Lab space; c = contrast. e = entropy)
         * param weight automatically generated
         */
        public void setWeightEntropy(float weight)
        {
            ThrowIfDisposed();

            xfeatures2d_PCTSignatures_setWeightEntropy_10(nativeObj, weight);


        }


        //
        // C++:  vector_Point2f cv::xfeatures2d::PCTSignatures::getSamplingPoints()
        //

        /**
         * Initial samples taken from the image.
         * These sampled features become the input for clustering.
         * return automatically generated
         */
        public MatOfPoint2f getSamplingPoints()
        {
            ThrowIfDisposed();

            return MatOfPoint2f.fromNativeAddr(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_PCTSignatures_getSamplingPoints_10(nativeObj)));


        }


        //
        // C++:  void cv::xfeatures2d::PCTSignatures::setWeight(int idx, float value)
        //

        /**
         * Weights (multiplicative constants) that linearly stretch individual axes of the feature space.
         * param idx ID of the weight
         * param value Value of the weight
         * <b>Note:</b>
         * WEIGHT_IDX = 0;
         * X_IDX = 1;
         * Y_IDX = 2;
         * L_IDX = 3;
         * A_IDX = 4;
         * B_IDX = 5;
         * CONTRAST_IDX = 6;
         * ENTROPY_IDX = 7;
         */
        public void setWeight(int idx, float value)
        {
            ThrowIfDisposed();

            xfeatures2d_PCTSignatures_setWeight_10(nativeObj, idx, value);


        }


        //
        // C++:  void cv::xfeatures2d::PCTSignatures::setWeights(vector_float weights)
        //

        /**
         * Weights (multiplicative constants) that linearly stretch individual axes of the feature space.
         * param weights Values of all weights.
         * <b>Note:</b>
         * WEIGHT_IDX = 0;
         * X_IDX = 1;
         * Y_IDX = 2;
         * L_IDX = 3;
         * A_IDX = 4;
         * B_IDX = 5;
         * CONTRAST_IDX = 6;
         * ENTROPY_IDX = 7;
         */
        public void setWeights(MatOfFloat weights)
        {
            ThrowIfDisposed();
            if (weights != null) weights.ThrowIfDisposed();
            Mat weights_mat = weights;
            xfeatures2d_PCTSignatures_setWeights_10(nativeObj, weights_mat.nativeObj);


        }


        //
        // C++:  void cv::xfeatures2d::PCTSignatures::setTranslation(int idx, float value)
        //

        /**
         * Translations of the individual axes of the feature space.
         * param idx ID of the translation
         * param value Value of the translation
         * <b>Note:</b>
         * WEIGHT_IDX = 0;
         * X_IDX = 1;
         * Y_IDX = 2;
         * L_IDX = 3;
         * A_IDX = 4;
         * B_IDX = 5;
         * CONTRAST_IDX = 6;
         * ENTROPY_IDX = 7;
         */
        public void setTranslation(int idx, float value)
        {
            ThrowIfDisposed();

            xfeatures2d_PCTSignatures_setTranslation_10(nativeObj, idx, value);


        }


        //
        // C++:  void cv::xfeatures2d::PCTSignatures::setTranslations(vector_float translations)
        //

        /**
         * Translations of the individual axes of the feature space.
         * param translations Values of all translations.
         * <b>Note:</b>
         * WEIGHT_IDX = 0;
         * X_IDX = 1;
         * Y_IDX = 2;
         * L_IDX = 3;
         * A_IDX = 4;
         * B_IDX = 5;
         * CONTRAST_IDX = 6;
         * ENTROPY_IDX = 7;
         */
        public void setTranslations(MatOfFloat translations)
        {
            ThrowIfDisposed();
            if (translations != null) translations.ThrowIfDisposed();
            Mat translations_mat = translations;
            xfeatures2d_PCTSignatures_setTranslations_10(nativeObj, translations_mat.nativeObj);


        }


        //
        // C++:  void cv::xfeatures2d::PCTSignatures::setSamplingPoints(vector_Point2f samplingPoints)
        //

        /**
         * Sets sampling points used to sample the input image.
         * param samplingPoints Vector of sampling points in range [0..1)
         * <b>Note:</b> Number of sampling points must be greater or equal to clusterization seed count.
         */
        public void setSamplingPoints(MatOfPoint2f samplingPoints)
        {
            ThrowIfDisposed();
            if (samplingPoints != null) samplingPoints.ThrowIfDisposed();
            Mat samplingPoints_mat = samplingPoints;
            xfeatures2d_PCTSignatures_setSamplingPoints_10(nativeObj, samplingPoints_mat.nativeObj);


        }


        //
        // C++:  vector_int cv::xfeatures2d::PCTSignatures::getInitSeedIndexes()
        //

        /**
         * Initial seeds (initial number of clusters) for the k-means algorithm.
         * return automatically generated
         */
        public MatOfInt getInitSeedIndexes()
        {
            ThrowIfDisposed();

            return MatOfInt.fromNativeAddr(DisposableObject.ThrowIfNullIntPtr(xfeatures2d_PCTSignatures_getInitSeedIndexes_10(nativeObj)));


        }


        //
        // C++:  void cv::xfeatures2d::PCTSignatures::setInitSeedIndexes(vector_int initSeedIndexes)
        //

        /**
         * Initial seed indexes for the k-means algorithm.
         * param initSeedIndexes automatically generated
         */
        public void setInitSeedIndexes(MatOfInt initSeedIndexes)
        {
            ThrowIfDisposed();
            if (initSeedIndexes != null) initSeedIndexes.ThrowIfDisposed();
            Mat initSeedIndexes_mat = initSeedIndexes;
            xfeatures2d_PCTSignatures_setInitSeedIndexes_10(nativeObj, initSeedIndexes_mat.nativeObj);


        }


        //
        // C++:  int cv::xfeatures2d::PCTSignatures::getInitSeedCount()
        //

        /**
         * Number of initial seeds (initial number of clusters) for the k-means algorithm.
         * return automatically generated
         */
        public int getInitSeedCount()
        {
            ThrowIfDisposed();

            return xfeatures2d_PCTSignatures_getInitSeedCount_10(nativeObj);


        }


        //
        // C++:  int cv::xfeatures2d::PCTSignatures::getIterationCount()
        //

        /**
         * Number of iterations of the k-means clustering.
         * We use fixed number of iterations, since the modified clustering is pruning clusters
         * (not iteratively refining k clusters).
         * return automatically generated
         */
        public int getIterationCount()
        {
            ThrowIfDisposed();

            return xfeatures2d_PCTSignatures_getIterationCount_10(nativeObj);


        }


        //
        // C++:  void cv::xfeatures2d::PCTSignatures::setIterationCount(int iterationCount)
        //

        /**
         * Number of iterations of the k-means clustering.
         * We use fixed number of iterations, since the modified clustering is pruning clusters
         * (not iteratively refining k clusters).
         * param iterationCount automatically generated
         */
        public void setIterationCount(int iterationCount)
        {
            ThrowIfDisposed();

            xfeatures2d_PCTSignatures_setIterationCount_10(nativeObj, iterationCount);


        }


        //
        // C++:  int cv::xfeatures2d::PCTSignatures::getMaxClustersCount()
        //

        /**
         * Maximal number of generated clusters. If the number is exceeded,
         * the clusters are sorted by their weights and the smallest clusters are cropped.
         * return automatically generated
         */
        public int getMaxClustersCount()
        {
            ThrowIfDisposed();

            return xfeatures2d_PCTSignatures_getMaxClustersCount_10(nativeObj);


        }


        //
        // C++:  void cv::xfeatures2d::PCTSignatures::setMaxClustersCount(int maxClustersCount)
        //

        /**
         * Maximal number of generated clusters. If the number is exceeded,
         * the clusters are sorted by their weights and the smallest clusters are cropped.
         * param maxClustersCount automatically generated
         */
        public void setMaxClustersCount(int maxClustersCount)
        {
            ThrowIfDisposed();

            xfeatures2d_PCTSignatures_setMaxClustersCount_10(nativeObj, maxClustersCount);


        }


        //
        // C++:  int cv::xfeatures2d::PCTSignatures::getClusterMinSize()
        //

        /**
         * This parameter multiplied by the index of iteration gives lower limit for cluster size.
         * Clusters containing fewer points than specified by the limit have their centroid dismissed
         * and points are reassigned.
         * return automatically generated
         */
        public int getClusterMinSize()
        {
            ThrowIfDisposed();

            return xfeatures2d_PCTSignatures_getClusterMinSize_10(nativeObj);


        }


        //
        // C++:  void cv::xfeatures2d::PCTSignatures::setClusterMinSize(int clusterMinSize)
        //

        /**
         * This parameter multiplied by the index of iteration gives lower limit for cluster size.
         * Clusters containing fewer points than specified by the limit have their centroid dismissed
         * and points are reassigned.
         * param clusterMinSize automatically generated
         */
        public void setClusterMinSize(int clusterMinSize)
        {
            ThrowIfDisposed();

            xfeatures2d_PCTSignatures_setClusterMinSize_10(nativeObj, clusterMinSize);


        }


        //
        // C++:  float cv::xfeatures2d::PCTSignatures::getJoiningDistance()
        //

        /**
         * Threshold euclidean distance between two centroids.
         * If two cluster centers are closer than this distance,
         * one of the centroid is dismissed and points are reassigned.
         * return automatically generated
         */
        public float getJoiningDistance()
        {
            ThrowIfDisposed();

            return xfeatures2d_PCTSignatures_getJoiningDistance_10(nativeObj);


        }


        //
        // C++:  void cv::xfeatures2d::PCTSignatures::setJoiningDistance(float joiningDistance)
        //

        /**
         * Threshold euclidean distance between two centroids.
         * If two cluster centers are closer than this distance,
         * one of the centroid is dismissed and points are reassigned.
         * param joiningDistance automatically generated
         */
        public void setJoiningDistance(float joiningDistance)
        {
            ThrowIfDisposed();

            xfeatures2d_PCTSignatures_setJoiningDistance_10(nativeObj, joiningDistance);


        }


        //
        // C++:  float cv::xfeatures2d::PCTSignatures::getDropThreshold()
        //

        /**
         * Remove centroids in k-means whose weight is lesser or equal to given threshold.
         * return automatically generated
         */
        public float getDropThreshold()
        {
            ThrowIfDisposed();

            return xfeatures2d_PCTSignatures_getDropThreshold_10(nativeObj);


        }


        //
        // C++:  void cv::xfeatures2d::PCTSignatures::setDropThreshold(float dropThreshold)
        //

        /**
         * Remove centroids in k-means whose weight is lesser or equal to given threshold.
         * param dropThreshold automatically generated
         */
        public void setDropThreshold(float dropThreshold)
        {
            ThrowIfDisposed();

            xfeatures2d_PCTSignatures_setDropThreshold_10(nativeObj, dropThreshold);


        }


        //
        // C++:  int cv::xfeatures2d::PCTSignatures::getDistanceFunction()
        //

        /**
         * Distance function selector used for measuring distance between two points in k-means.
         * return automatically generated
         */
        public int getDistanceFunction()
        {
            ThrowIfDisposed();

            return xfeatures2d_PCTSignatures_getDistanceFunction_10(nativeObj);


        }


        //
        // C++:  void cv::xfeatures2d::PCTSignatures::setDistanceFunction(int distanceFunction)
        //

        /**
         * Distance function selector used for measuring distance between two points in k-means.
         * Available: L0_25, L0_5, L1, L2, L2SQUARED, L5, L_INFINITY.
         * param distanceFunction automatically generated
         */
        public void setDistanceFunction(int distanceFunction)
        {
            ThrowIfDisposed();

            xfeatures2d_PCTSignatures_setDistanceFunction_10(nativeObj, distanceFunction);


        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++: static Ptr_PCTSignatures cv::xfeatures2d::PCTSignatures::create(int initSampleCount = 2000, int initSeedCount = 400, int pointDistribution = 0)
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_PCTSignatures_create_10(int initSampleCount, int initSeedCount, int pointDistribution);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_PCTSignatures_create_11(int initSampleCount, int initSeedCount);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_PCTSignatures_create_12(int initSampleCount);
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_PCTSignatures_create_13();

        // C++: static Ptr_PCTSignatures cv::xfeatures2d::PCTSignatures::create(vector_Point2f initSamplingPoints, int initSeedCount)
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_PCTSignatures_create_14(IntPtr initSamplingPoints_mat_nativeObj, int initSeedCount);

        // C++: static Ptr_PCTSignatures cv::xfeatures2d::PCTSignatures::create(vector_Point2f initSamplingPoints, vector_int initClusterSeedIndexes)
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_PCTSignatures_create_15(IntPtr initSamplingPoints_mat_nativeObj, IntPtr initClusterSeedIndexes_mat_nativeObj);

        // C++:  void cv::xfeatures2d::PCTSignatures::computeSignature(Mat image, Mat& signature)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_PCTSignatures_computeSignature_10(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr signature_nativeObj);

        // C++:  void cv::xfeatures2d::PCTSignatures::computeSignatures(vector_Mat images, vector_Mat signatures)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_PCTSignatures_computeSignatures_10(IntPtr nativeObj, IntPtr images_mat_nativeObj, IntPtr signatures_mat_nativeObj);

        // C++: static void cv::xfeatures2d::PCTSignatures::drawSignature(Mat source, Mat signature, Mat& result, float radiusToShorterSideRatio = 1.0 / 8, int borderThickness = 1)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_PCTSignatures_drawSignature_10(IntPtr source_nativeObj, IntPtr signature_nativeObj, IntPtr result_nativeObj, float radiusToShorterSideRatio, int borderThickness);
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_PCTSignatures_drawSignature_11(IntPtr source_nativeObj, IntPtr signature_nativeObj, IntPtr result_nativeObj, float radiusToShorterSideRatio);
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_PCTSignatures_drawSignature_12(IntPtr source_nativeObj, IntPtr signature_nativeObj, IntPtr result_nativeObj);

        // C++: static void cv::xfeatures2d::PCTSignatures::generateInitPoints(vector_Point2f initPoints, int count, int pointDistribution)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_PCTSignatures_generateInitPoints_10(IntPtr initPoints_mat_nativeObj, int count, int pointDistribution);

        // C++:  int cv::xfeatures2d::PCTSignatures::getSampleCount()
        [DllImport(LIBNAME)]
        private static extern int xfeatures2d_PCTSignatures_getSampleCount_10(IntPtr nativeObj);

        // C++:  int cv::xfeatures2d::PCTSignatures::getGrayscaleBits()
        [DllImport(LIBNAME)]
        private static extern int xfeatures2d_PCTSignatures_getGrayscaleBits_10(IntPtr nativeObj);

        // C++:  void cv::xfeatures2d::PCTSignatures::setGrayscaleBits(int grayscaleBits)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_PCTSignatures_setGrayscaleBits_10(IntPtr nativeObj, int grayscaleBits);

        // C++:  int cv::xfeatures2d::PCTSignatures::getWindowRadius()
        [DllImport(LIBNAME)]
        private static extern int xfeatures2d_PCTSignatures_getWindowRadius_10(IntPtr nativeObj);

        // C++:  void cv::xfeatures2d::PCTSignatures::setWindowRadius(int radius)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_PCTSignatures_setWindowRadius_10(IntPtr nativeObj, int radius);

        // C++:  float cv::xfeatures2d::PCTSignatures::getWeightX()
        [DllImport(LIBNAME)]
        private static extern float xfeatures2d_PCTSignatures_getWeightX_10(IntPtr nativeObj);

        // C++:  void cv::xfeatures2d::PCTSignatures::setWeightX(float weight)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_PCTSignatures_setWeightX_10(IntPtr nativeObj, float weight);

        // C++:  float cv::xfeatures2d::PCTSignatures::getWeightY()
        [DllImport(LIBNAME)]
        private static extern float xfeatures2d_PCTSignatures_getWeightY_10(IntPtr nativeObj);

        // C++:  void cv::xfeatures2d::PCTSignatures::setWeightY(float weight)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_PCTSignatures_setWeightY_10(IntPtr nativeObj, float weight);

        // C++:  float cv::xfeatures2d::PCTSignatures::getWeightL()
        [DllImport(LIBNAME)]
        private static extern float xfeatures2d_PCTSignatures_getWeightL_10(IntPtr nativeObj);

        // C++:  void cv::xfeatures2d::PCTSignatures::setWeightL(float weight)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_PCTSignatures_setWeightL_10(IntPtr nativeObj, float weight);

        // C++:  float cv::xfeatures2d::PCTSignatures::getWeightA()
        [DllImport(LIBNAME)]
        private static extern float xfeatures2d_PCTSignatures_getWeightA_10(IntPtr nativeObj);

        // C++:  void cv::xfeatures2d::PCTSignatures::setWeightA(float weight)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_PCTSignatures_setWeightA_10(IntPtr nativeObj, float weight);

        // C++:  float cv::xfeatures2d::PCTSignatures::getWeightB()
        [DllImport(LIBNAME)]
        private static extern float xfeatures2d_PCTSignatures_getWeightB_10(IntPtr nativeObj);

        // C++:  void cv::xfeatures2d::PCTSignatures::setWeightB(float weight)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_PCTSignatures_setWeightB_10(IntPtr nativeObj, float weight);

        // C++:  float cv::xfeatures2d::PCTSignatures::getWeightContrast()
        [DllImport(LIBNAME)]
        private static extern float xfeatures2d_PCTSignatures_getWeightContrast_10(IntPtr nativeObj);

        // C++:  void cv::xfeatures2d::PCTSignatures::setWeightContrast(float weight)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_PCTSignatures_setWeightContrast_10(IntPtr nativeObj, float weight);

        // C++:  float cv::xfeatures2d::PCTSignatures::getWeightEntropy()
        [DllImport(LIBNAME)]
        private static extern float xfeatures2d_PCTSignatures_getWeightEntropy_10(IntPtr nativeObj);

        // C++:  void cv::xfeatures2d::PCTSignatures::setWeightEntropy(float weight)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_PCTSignatures_setWeightEntropy_10(IntPtr nativeObj, float weight);

        // C++:  vector_Point2f cv::xfeatures2d::PCTSignatures::getSamplingPoints()
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_PCTSignatures_getSamplingPoints_10(IntPtr nativeObj);

        // C++:  void cv::xfeatures2d::PCTSignatures::setWeight(int idx, float value)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_PCTSignatures_setWeight_10(IntPtr nativeObj, int idx, float value);

        // C++:  void cv::xfeatures2d::PCTSignatures::setWeights(vector_float weights)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_PCTSignatures_setWeights_10(IntPtr nativeObj, IntPtr weights_mat_nativeObj);

        // C++:  void cv::xfeatures2d::PCTSignatures::setTranslation(int idx, float value)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_PCTSignatures_setTranslation_10(IntPtr nativeObj, int idx, float value);

        // C++:  void cv::xfeatures2d::PCTSignatures::setTranslations(vector_float translations)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_PCTSignatures_setTranslations_10(IntPtr nativeObj, IntPtr translations_mat_nativeObj);

        // C++:  void cv::xfeatures2d::PCTSignatures::setSamplingPoints(vector_Point2f samplingPoints)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_PCTSignatures_setSamplingPoints_10(IntPtr nativeObj, IntPtr samplingPoints_mat_nativeObj);

        // C++:  vector_int cv::xfeatures2d::PCTSignatures::getInitSeedIndexes()
        [DllImport(LIBNAME)]
        private static extern IntPtr xfeatures2d_PCTSignatures_getInitSeedIndexes_10(IntPtr nativeObj);

        // C++:  void cv::xfeatures2d::PCTSignatures::setInitSeedIndexes(vector_int initSeedIndexes)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_PCTSignatures_setInitSeedIndexes_10(IntPtr nativeObj, IntPtr initSeedIndexes_mat_nativeObj);

        // C++:  int cv::xfeatures2d::PCTSignatures::getInitSeedCount()
        [DllImport(LIBNAME)]
        private static extern int xfeatures2d_PCTSignatures_getInitSeedCount_10(IntPtr nativeObj);

        // C++:  int cv::xfeatures2d::PCTSignatures::getIterationCount()
        [DllImport(LIBNAME)]
        private static extern int xfeatures2d_PCTSignatures_getIterationCount_10(IntPtr nativeObj);

        // C++:  void cv::xfeatures2d::PCTSignatures::setIterationCount(int iterationCount)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_PCTSignatures_setIterationCount_10(IntPtr nativeObj, int iterationCount);

        // C++:  int cv::xfeatures2d::PCTSignatures::getMaxClustersCount()
        [DllImport(LIBNAME)]
        private static extern int xfeatures2d_PCTSignatures_getMaxClustersCount_10(IntPtr nativeObj);

        // C++:  void cv::xfeatures2d::PCTSignatures::setMaxClustersCount(int maxClustersCount)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_PCTSignatures_setMaxClustersCount_10(IntPtr nativeObj, int maxClustersCount);

        // C++:  int cv::xfeatures2d::PCTSignatures::getClusterMinSize()
        [DllImport(LIBNAME)]
        private static extern int xfeatures2d_PCTSignatures_getClusterMinSize_10(IntPtr nativeObj);

        // C++:  void cv::xfeatures2d::PCTSignatures::setClusterMinSize(int clusterMinSize)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_PCTSignatures_setClusterMinSize_10(IntPtr nativeObj, int clusterMinSize);

        // C++:  float cv::xfeatures2d::PCTSignatures::getJoiningDistance()
        [DllImport(LIBNAME)]
        private static extern float xfeatures2d_PCTSignatures_getJoiningDistance_10(IntPtr nativeObj);

        // C++:  void cv::xfeatures2d::PCTSignatures::setJoiningDistance(float joiningDistance)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_PCTSignatures_setJoiningDistance_10(IntPtr nativeObj, float joiningDistance);

        // C++:  float cv::xfeatures2d::PCTSignatures::getDropThreshold()
        [DllImport(LIBNAME)]
        private static extern float xfeatures2d_PCTSignatures_getDropThreshold_10(IntPtr nativeObj);

        // C++:  void cv::xfeatures2d::PCTSignatures::setDropThreshold(float dropThreshold)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_PCTSignatures_setDropThreshold_10(IntPtr nativeObj, float dropThreshold);

        // C++:  int cv::xfeatures2d::PCTSignatures::getDistanceFunction()
        [DllImport(LIBNAME)]
        private static extern int xfeatures2d_PCTSignatures_getDistanceFunction_10(IntPtr nativeObj);

        // C++:  void cv::xfeatures2d::PCTSignatures::setDistanceFunction(int distanceFunction)
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_PCTSignatures_setDistanceFunction_10(IntPtr nativeObj, int distanceFunction);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void xfeatures2d_PCTSignatures_delete(IntPtr nativeObj);

    }
}
