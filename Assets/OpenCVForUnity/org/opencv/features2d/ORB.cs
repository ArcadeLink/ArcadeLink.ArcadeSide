
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.Features2dModule
{

    // C++: class ORB
    /**
     * Class implementing the ORB (*oriented BRIEF*) keypoint detector and descriptor extractor
     *
     * described in CITE: RRKB11 . The algorithm uses FAST in pyramids to detect stable keypoints, selects
     * the strongest features using FAST or Harris response, finds their orientation using first-order
     * moments and computes the descriptors using BRIEF (where the coordinates of random point pairs (or
     * k-tuples) are rotated according to the measured orientation).
     */

    public class ORB : Feature2D
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
                        features2d_ORB_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal ORB(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new ORB __fromPtr__(IntPtr addr) { return new ORB(addr); }

        // C++: enum cv.ORB.ScoreType
        public const int HARRIS_SCORE = 0;
        public const int FAST_SCORE = 1;
        //
        // C++: static Ptr_ORB cv::ORB::create(int nfeatures = 500, float scaleFactor = 1.2f, int nlevels = 8, int edgeThreshold = 31, int firstLevel = 0, int WTA_K = 2, ORB_ScoreType scoreType = ORB::HARRIS_SCORE, int patchSize = 31, int fastThreshold = 20)
        //

        /**
         * The ORB constructor
         *
         *     param nfeatures The maximum number of features to retain.
         *     param scaleFactor Pyramid decimation ratio, greater than 1. scaleFactor==2 means the classical
         *     pyramid, where each next level has 4x less pixels than the previous, but such a big scale factor
         *     will degrade feature matching scores dramatically. On the other hand, too close to 1 scale factor
         *     will mean that to cover certain scale range you will need more pyramid levels and so the speed
         *     will suffer.
         *     param nlevels The number of pyramid levels. The smallest level will have linear size equal to
         *     input_image_linear_size/pow(scaleFactor, nlevels - firstLevel).
         *     param edgeThreshold This is size of the border where the features are not detected. It should
         *     roughly match the patchSize parameter.
         *     param firstLevel The level of pyramid to put source image to. Previous layers are filled
         *     with upscaled source image.
         *     param WTA_K The number of points that produce each element of the oriented BRIEF descriptor. The
         *     default value 2 means the BRIEF where we take a random point pair and compare their brightnesses,
         *     so we get 0/1 response. Other possible values are 3 and 4. For example, 3 means that we take 3
         *     random points (of course, those point coordinates are random, but they are generated from the
         *     pre-defined seed, so each element of BRIEF descriptor is computed deterministically from the pixel
         *     rectangle), find point of maximum brightness and output index of the winner (0, 1 or 2). Such
         *     output will occupy 2 bits, and therefore it will need a special variant of Hamming distance,
         *     denoted as NORM_HAMMING2 (2 bits per bin). When WTA_K=4, we take 4 random points to compute each
         *     bin (that will also occupy 2 bits with possible values 0, 1, 2 or 3).
         *     param scoreType The default HARRIS_SCORE means that Harris algorithm is used to rank features
         *     (the score is written to KeyPoint::score and is used to retain best nfeatures features);
         *     FAST_SCORE is alternative value of the parameter that produces slightly less stable keypoints,
         *     but it is a little faster to compute.
         *     param patchSize size of the patch used by the oriented BRIEF descriptor. Of course, on smaller
         *     pyramid layers the perceived image area covered by a feature will be larger.
         *     param fastThreshold the fast threshold
         * return automatically generated
         */
        public static ORB create(int nfeatures, float scaleFactor, int nlevels, int edgeThreshold, int firstLevel, int WTA_K, int scoreType, int patchSize, int fastThreshold)
        {


            return ORB.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(features2d_ORB_create_10(nfeatures, scaleFactor, nlevels, edgeThreshold, firstLevel, WTA_K, scoreType, patchSize, fastThreshold)));


        }

        /**
         * The ORB constructor
         *
         *     param nfeatures The maximum number of features to retain.
         *     param scaleFactor Pyramid decimation ratio, greater than 1. scaleFactor==2 means the classical
         *     pyramid, where each next level has 4x less pixels than the previous, but such a big scale factor
         *     will degrade feature matching scores dramatically. On the other hand, too close to 1 scale factor
         *     will mean that to cover certain scale range you will need more pyramid levels and so the speed
         *     will suffer.
         *     param nlevels The number of pyramid levels. The smallest level will have linear size equal to
         *     input_image_linear_size/pow(scaleFactor, nlevels - firstLevel).
         *     param edgeThreshold This is size of the border where the features are not detected. It should
         *     roughly match the patchSize parameter.
         *     param firstLevel The level of pyramid to put source image to. Previous layers are filled
         *     with upscaled source image.
         *     param WTA_K The number of points that produce each element of the oriented BRIEF descriptor. The
         *     default value 2 means the BRIEF where we take a random point pair and compare their brightnesses,
         *     so we get 0/1 response. Other possible values are 3 and 4. For example, 3 means that we take 3
         *     random points (of course, those point coordinates are random, but they are generated from the
         *     pre-defined seed, so each element of BRIEF descriptor is computed deterministically from the pixel
         *     rectangle), find point of maximum brightness and output index of the winner (0, 1 or 2). Such
         *     output will occupy 2 bits, and therefore it will need a special variant of Hamming distance,
         *     denoted as NORM_HAMMING2 (2 bits per bin). When WTA_K=4, we take 4 random points to compute each
         *     bin (that will also occupy 2 bits with possible values 0, 1, 2 or 3).
         *     param scoreType The default HARRIS_SCORE means that Harris algorithm is used to rank features
         *     (the score is written to KeyPoint::score and is used to retain best nfeatures features);
         *     FAST_SCORE is alternative value of the parameter that produces slightly less stable keypoints,
         *     but it is a little faster to compute.
         *     param patchSize size of the patch used by the oriented BRIEF descriptor. Of course, on smaller
         *     pyramid layers the perceived image area covered by a feature will be larger.
         * return automatically generated
         */
        public static ORB create(int nfeatures, float scaleFactor, int nlevels, int edgeThreshold, int firstLevel, int WTA_K, int scoreType, int patchSize)
        {


            return ORB.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(features2d_ORB_create_11(nfeatures, scaleFactor, nlevels, edgeThreshold, firstLevel, WTA_K, scoreType, patchSize)));


        }

        /**
         * The ORB constructor
         *
         *     param nfeatures The maximum number of features to retain.
         *     param scaleFactor Pyramid decimation ratio, greater than 1. scaleFactor==2 means the classical
         *     pyramid, where each next level has 4x less pixels than the previous, but such a big scale factor
         *     will degrade feature matching scores dramatically. On the other hand, too close to 1 scale factor
         *     will mean that to cover certain scale range you will need more pyramid levels and so the speed
         *     will suffer.
         *     param nlevels The number of pyramid levels. The smallest level will have linear size equal to
         *     input_image_linear_size/pow(scaleFactor, nlevels - firstLevel).
         *     param edgeThreshold This is size of the border where the features are not detected. It should
         *     roughly match the patchSize parameter.
         *     param firstLevel The level of pyramid to put source image to. Previous layers are filled
         *     with upscaled source image.
         *     param WTA_K The number of points that produce each element of the oriented BRIEF descriptor. The
         *     default value 2 means the BRIEF where we take a random point pair and compare their brightnesses,
         *     so we get 0/1 response. Other possible values are 3 and 4. For example, 3 means that we take 3
         *     random points (of course, those point coordinates are random, but they are generated from the
         *     pre-defined seed, so each element of BRIEF descriptor is computed deterministically from the pixel
         *     rectangle), find point of maximum brightness and output index of the winner (0, 1 or 2). Such
         *     output will occupy 2 bits, and therefore it will need a special variant of Hamming distance,
         *     denoted as NORM_HAMMING2 (2 bits per bin). When WTA_K=4, we take 4 random points to compute each
         *     bin (that will also occupy 2 bits with possible values 0, 1, 2 or 3).
         *     param scoreType The default HARRIS_SCORE means that Harris algorithm is used to rank features
         *     (the score is written to KeyPoint::score and is used to retain best nfeatures features);
         *     FAST_SCORE is alternative value of the parameter that produces slightly less stable keypoints,
         *     but it is a little faster to compute.
         *     pyramid layers the perceived image area covered by a feature will be larger.
         * return automatically generated
         */
        public static ORB create(int nfeatures, float scaleFactor, int nlevels, int edgeThreshold, int firstLevel, int WTA_K, int scoreType)
        {


            return ORB.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(features2d_ORB_create_12(nfeatures, scaleFactor, nlevels, edgeThreshold, firstLevel, WTA_K, scoreType)));


        }

        /**
         * The ORB constructor
         *
         *     param nfeatures The maximum number of features to retain.
         *     param scaleFactor Pyramid decimation ratio, greater than 1. scaleFactor==2 means the classical
         *     pyramid, where each next level has 4x less pixels than the previous, but such a big scale factor
         *     will degrade feature matching scores dramatically. On the other hand, too close to 1 scale factor
         *     will mean that to cover certain scale range you will need more pyramid levels and so the speed
         *     will suffer.
         *     param nlevels The number of pyramid levels. The smallest level will have linear size equal to
         *     input_image_linear_size/pow(scaleFactor, nlevels - firstLevel).
         *     param edgeThreshold This is size of the border where the features are not detected. It should
         *     roughly match the patchSize parameter.
         *     param firstLevel The level of pyramid to put source image to. Previous layers are filled
         *     with upscaled source image.
         *     param WTA_K The number of points that produce each element of the oriented BRIEF descriptor. The
         *     default value 2 means the BRIEF where we take a random point pair and compare their brightnesses,
         *     so we get 0/1 response. Other possible values are 3 and 4. For example, 3 means that we take 3
         *     random points (of course, those point coordinates are random, but they are generated from the
         *     pre-defined seed, so each element of BRIEF descriptor is computed deterministically from the pixel
         *     rectangle), find point of maximum brightness and output index of the winner (0, 1 or 2). Such
         *     output will occupy 2 bits, and therefore it will need a special variant of Hamming distance,
         *     denoted as NORM_HAMMING2 (2 bits per bin). When WTA_K=4, we take 4 random points to compute each
         *     bin (that will also occupy 2 bits with possible values 0, 1, 2 or 3).
         *     (the score is written to KeyPoint::score and is used to retain best nfeatures features);
         *     FAST_SCORE is alternative value of the parameter that produces slightly less stable keypoints,
         *     but it is a little faster to compute.
         *     pyramid layers the perceived image area covered by a feature will be larger.
         * return automatically generated
         */
        public static ORB create(int nfeatures, float scaleFactor, int nlevels, int edgeThreshold, int firstLevel, int WTA_K)
        {


            return ORB.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(features2d_ORB_create_13(nfeatures, scaleFactor, nlevels, edgeThreshold, firstLevel, WTA_K)));


        }

        /**
         * The ORB constructor
         *
         *     param nfeatures The maximum number of features to retain.
         *     param scaleFactor Pyramid decimation ratio, greater than 1. scaleFactor==2 means the classical
         *     pyramid, where each next level has 4x less pixels than the previous, but such a big scale factor
         *     will degrade feature matching scores dramatically. On the other hand, too close to 1 scale factor
         *     will mean that to cover certain scale range you will need more pyramid levels and so the speed
         *     will suffer.
         *     param nlevels The number of pyramid levels. The smallest level will have linear size equal to
         *     input_image_linear_size/pow(scaleFactor, nlevels - firstLevel).
         *     param edgeThreshold This is size of the border where the features are not detected. It should
         *     roughly match the patchSize parameter.
         *     param firstLevel The level of pyramid to put source image to. Previous layers are filled
         *     with upscaled source image.
         *     default value 2 means the BRIEF where we take a random point pair and compare their brightnesses,
         *     so we get 0/1 response. Other possible values are 3 and 4. For example, 3 means that we take 3
         *     random points (of course, those point coordinates are random, but they are generated from the
         *     pre-defined seed, so each element of BRIEF descriptor is computed deterministically from the pixel
         *     rectangle), find point of maximum brightness and output index of the winner (0, 1 or 2). Such
         *     output will occupy 2 bits, and therefore it will need a special variant of Hamming distance,
         *     denoted as NORM_HAMMING2 (2 bits per bin). When WTA_K=4, we take 4 random points to compute each
         *     bin (that will also occupy 2 bits with possible values 0, 1, 2 or 3).
         *     (the score is written to KeyPoint::score and is used to retain best nfeatures features);
         *     FAST_SCORE is alternative value of the parameter that produces slightly less stable keypoints,
         *     but it is a little faster to compute.
         *     pyramid layers the perceived image area covered by a feature will be larger.
         * return automatically generated
         */
        public static ORB create(int nfeatures, float scaleFactor, int nlevels, int edgeThreshold, int firstLevel)
        {


            return ORB.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(features2d_ORB_create_14(nfeatures, scaleFactor, nlevels, edgeThreshold, firstLevel)));


        }

        /**
         * The ORB constructor
         *
         *     param nfeatures The maximum number of features to retain.
         *     param scaleFactor Pyramid decimation ratio, greater than 1. scaleFactor==2 means the classical
         *     pyramid, where each next level has 4x less pixels than the previous, but such a big scale factor
         *     will degrade feature matching scores dramatically. On the other hand, too close to 1 scale factor
         *     will mean that to cover certain scale range you will need more pyramid levels and so the speed
         *     will suffer.
         *     param nlevels The number of pyramid levels. The smallest level will have linear size equal to
         *     input_image_linear_size/pow(scaleFactor, nlevels - firstLevel).
         *     param edgeThreshold This is size of the border where the features are not detected. It should
         *     roughly match the patchSize parameter.
         *     with upscaled source image.
         *     default value 2 means the BRIEF where we take a random point pair and compare their brightnesses,
         *     so we get 0/1 response. Other possible values are 3 and 4. For example, 3 means that we take 3
         *     random points (of course, those point coordinates are random, but they are generated from the
         *     pre-defined seed, so each element of BRIEF descriptor is computed deterministically from the pixel
         *     rectangle), find point of maximum brightness and output index of the winner (0, 1 or 2). Such
         *     output will occupy 2 bits, and therefore it will need a special variant of Hamming distance,
         *     denoted as NORM_HAMMING2 (2 bits per bin). When WTA_K=4, we take 4 random points to compute each
         *     bin (that will also occupy 2 bits with possible values 0, 1, 2 or 3).
         *     (the score is written to KeyPoint::score and is used to retain best nfeatures features);
         *     FAST_SCORE is alternative value of the parameter that produces slightly less stable keypoints,
         *     but it is a little faster to compute.
         *     pyramid layers the perceived image area covered by a feature will be larger.
         * return automatically generated
         */
        public static ORB create(int nfeatures, float scaleFactor, int nlevels, int edgeThreshold)
        {


            return ORB.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(features2d_ORB_create_15(nfeatures, scaleFactor, nlevels, edgeThreshold)));


        }

        /**
         * The ORB constructor
         *
         *     param nfeatures The maximum number of features to retain.
         *     param scaleFactor Pyramid decimation ratio, greater than 1. scaleFactor==2 means the classical
         *     pyramid, where each next level has 4x less pixels than the previous, but such a big scale factor
         *     will degrade feature matching scores dramatically. On the other hand, too close to 1 scale factor
         *     will mean that to cover certain scale range you will need more pyramid levels and so the speed
         *     will suffer.
         *     param nlevels The number of pyramid levels. The smallest level will have linear size equal to
         *     input_image_linear_size/pow(scaleFactor, nlevels - firstLevel).
         *     roughly match the patchSize parameter.
         *     with upscaled source image.
         *     default value 2 means the BRIEF where we take a random point pair and compare their brightnesses,
         *     so we get 0/1 response. Other possible values are 3 and 4. For example, 3 means that we take 3
         *     random points (of course, those point coordinates are random, but they are generated from the
         *     pre-defined seed, so each element of BRIEF descriptor is computed deterministically from the pixel
         *     rectangle), find point of maximum brightness and output index of the winner (0, 1 or 2). Such
         *     output will occupy 2 bits, and therefore it will need a special variant of Hamming distance,
         *     denoted as NORM_HAMMING2 (2 bits per bin). When WTA_K=4, we take 4 random points to compute each
         *     bin (that will also occupy 2 bits with possible values 0, 1, 2 or 3).
         *     (the score is written to KeyPoint::score and is used to retain best nfeatures features);
         *     FAST_SCORE is alternative value of the parameter that produces slightly less stable keypoints,
         *     but it is a little faster to compute.
         *     pyramid layers the perceived image area covered by a feature will be larger.
         * return automatically generated
         */
        public static ORB create(int nfeatures, float scaleFactor, int nlevels)
        {


            return ORB.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(features2d_ORB_create_16(nfeatures, scaleFactor, nlevels)));


        }

        /**
         * The ORB constructor
         *
         *     param nfeatures The maximum number of features to retain.
         *     param scaleFactor Pyramid decimation ratio, greater than 1. scaleFactor==2 means the classical
         *     pyramid, where each next level has 4x less pixels than the previous, but such a big scale factor
         *     will degrade feature matching scores dramatically. On the other hand, too close to 1 scale factor
         *     will mean that to cover certain scale range you will need more pyramid levels and so the speed
         *     will suffer.
         *     input_image_linear_size/pow(scaleFactor, nlevels - firstLevel).
         *     roughly match the patchSize parameter.
         *     with upscaled source image.
         *     default value 2 means the BRIEF where we take a random point pair and compare their brightnesses,
         *     so we get 0/1 response. Other possible values are 3 and 4. For example, 3 means that we take 3
         *     random points (of course, those point coordinates are random, but they are generated from the
         *     pre-defined seed, so each element of BRIEF descriptor is computed deterministically from the pixel
         *     rectangle), find point of maximum brightness and output index of the winner (0, 1 or 2). Such
         *     output will occupy 2 bits, and therefore it will need a special variant of Hamming distance,
         *     denoted as NORM_HAMMING2 (2 bits per bin). When WTA_K=4, we take 4 random points to compute each
         *     bin (that will also occupy 2 bits with possible values 0, 1, 2 or 3).
         *     (the score is written to KeyPoint::score and is used to retain best nfeatures features);
         *     FAST_SCORE is alternative value of the parameter that produces slightly less stable keypoints,
         *     but it is a little faster to compute.
         *     pyramid layers the perceived image area covered by a feature will be larger.
         * return automatically generated
         */
        public static ORB create(int nfeatures, float scaleFactor)
        {


            return ORB.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(features2d_ORB_create_17(nfeatures, scaleFactor)));


        }

        /**
         * The ORB constructor
         *
         *     param nfeatures The maximum number of features to retain.
         *     pyramid, where each next level has 4x less pixels than the previous, but such a big scale factor
         *     will degrade feature matching scores dramatically. On the other hand, too close to 1 scale factor
         *     will mean that to cover certain scale range you will need more pyramid levels and so the speed
         *     will suffer.
         *     input_image_linear_size/pow(scaleFactor, nlevels - firstLevel).
         *     roughly match the patchSize parameter.
         *     with upscaled source image.
         *     default value 2 means the BRIEF where we take a random point pair and compare their brightnesses,
         *     so we get 0/1 response. Other possible values are 3 and 4. For example, 3 means that we take 3
         *     random points (of course, those point coordinates are random, but they are generated from the
         *     pre-defined seed, so each element of BRIEF descriptor is computed deterministically from the pixel
         *     rectangle), find point of maximum brightness and output index of the winner (0, 1 or 2). Such
         *     output will occupy 2 bits, and therefore it will need a special variant of Hamming distance,
         *     denoted as NORM_HAMMING2 (2 bits per bin). When WTA_K=4, we take 4 random points to compute each
         *     bin (that will also occupy 2 bits with possible values 0, 1, 2 or 3).
         *     (the score is written to KeyPoint::score and is used to retain best nfeatures features);
         *     FAST_SCORE is alternative value of the parameter that produces slightly less stable keypoints,
         *     but it is a little faster to compute.
         *     pyramid layers the perceived image area covered by a feature will be larger.
         * return automatically generated
         */
        public static ORB create(int nfeatures)
        {


            return ORB.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(features2d_ORB_create_18(nfeatures)));


        }

        /**
         * The ORB constructor
         *
         *     pyramid, where each next level has 4x less pixels than the previous, but such a big scale factor
         *     will degrade feature matching scores dramatically. On the other hand, too close to 1 scale factor
         *     will mean that to cover certain scale range you will need more pyramid levels and so the speed
         *     will suffer.
         *     input_image_linear_size/pow(scaleFactor, nlevels - firstLevel).
         *     roughly match the patchSize parameter.
         *     with upscaled source image.
         *     default value 2 means the BRIEF where we take a random point pair and compare their brightnesses,
         *     so we get 0/1 response. Other possible values are 3 and 4. For example, 3 means that we take 3
         *     random points (of course, those point coordinates are random, but they are generated from the
         *     pre-defined seed, so each element of BRIEF descriptor is computed deterministically from the pixel
         *     rectangle), find point of maximum brightness and output index of the winner (0, 1 or 2). Such
         *     output will occupy 2 bits, and therefore it will need a special variant of Hamming distance,
         *     denoted as NORM_HAMMING2 (2 bits per bin). When WTA_K=4, we take 4 random points to compute each
         *     bin (that will also occupy 2 bits with possible values 0, 1, 2 or 3).
         *     (the score is written to KeyPoint::score and is used to retain best nfeatures features);
         *     FAST_SCORE is alternative value of the parameter that produces slightly less stable keypoints,
         *     but it is a little faster to compute.
         *     pyramid layers the perceived image area covered by a feature will be larger.
         * return automatically generated
         */
        public static ORB create()
        {


            return ORB.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(features2d_ORB_create_19()));


        }


        //
        // C++:  void cv::ORB::setMaxFeatures(int maxFeatures)
        //

        public void setMaxFeatures(int maxFeatures)
        {
            ThrowIfDisposed();

            features2d_ORB_setMaxFeatures_10(nativeObj, maxFeatures);


        }


        //
        // C++:  int cv::ORB::getMaxFeatures()
        //

        public int getMaxFeatures()
        {
            ThrowIfDisposed();

            return features2d_ORB_getMaxFeatures_10(nativeObj);


        }


        //
        // C++:  void cv::ORB::setScaleFactor(double scaleFactor)
        //

        public void setScaleFactor(double scaleFactor)
        {
            ThrowIfDisposed();

            features2d_ORB_setScaleFactor_10(nativeObj, scaleFactor);


        }


        //
        // C++:  double cv::ORB::getScaleFactor()
        //

        public double getScaleFactor()
        {
            ThrowIfDisposed();

            return features2d_ORB_getScaleFactor_10(nativeObj);


        }


        //
        // C++:  void cv::ORB::setNLevels(int nlevels)
        //

        public void setNLevels(int nlevels)
        {
            ThrowIfDisposed();

            features2d_ORB_setNLevels_10(nativeObj, nlevels);


        }


        //
        // C++:  int cv::ORB::getNLevels()
        //

        public int getNLevels()
        {
            ThrowIfDisposed();

            return features2d_ORB_getNLevels_10(nativeObj);


        }


        //
        // C++:  void cv::ORB::setEdgeThreshold(int edgeThreshold)
        //

        public void setEdgeThreshold(int edgeThreshold)
        {
            ThrowIfDisposed();

            features2d_ORB_setEdgeThreshold_10(nativeObj, edgeThreshold);


        }


        //
        // C++:  int cv::ORB::getEdgeThreshold()
        //

        public int getEdgeThreshold()
        {
            ThrowIfDisposed();

            return features2d_ORB_getEdgeThreshold_10(nativeObj);


        }


        //
        // C++:  void cv::ORB::setFirstLevel(int firstLevel)
        //

        public void setFirstLevel(int firstLevel)
        {
            ThrowIfDisposed();

            features2d_ORB_setFirstLevel_10(nativeObj, firstLevel);


        }


        //
        // C++:  int cv::ORB::getFirstLevel()
        //

        public int getFirstLevel()
        {
            ThrowIfDisposed();

            return features2d_ORB_getFirstLevel_10(nativeObj);


        }


        //
        // C++:  void cv::ORB::setWTA_K(int wta_k)
        //

        public void setWTA_K(int wta_k)
        {
            ThrowIfDisposed();

            features2d_ORB_setWTA_1K_10(nativeObj, wta_k);


        }


        //
        // C++:  int cv::ORB::getWTA_K()
        //

        public int getWTA_K()
        {
            ThrowIfDisposed();

            return features2d_ORB_getWTA_1K_10(nativeObj);


        }


        //
        // C++:  void cv::ORB::setScoreType(ORB_ScoreType scoreType)
        //

        public void setScoreType(int scoreType)
        {
            ThrowIfDisposed();

            features2d_ORB_setScoreType_10(nativeObj, scoreType);


        }


        //
        // C++:  ORB_ScoreType cv::ORB::getScoreType()
        //

        public int getScoreType()
        {
            ThrowIfDisposed();

            return features2d_ORB_getScoreType_10(nativeObj);


        }


        //
        // C++:  void cv::ORB::setPatchSize(int patchSize)
        //

        public void setPatchSize(int patchSize)
        {
            ThrowIfDisposed();

            features2d_ORB_setPatchSize_10(nativeObj, patchSize);


        }


        //
        // C++:  int cv::ORB::getPatchSize()
        //

        public int getPatchSize()
        {
            ThrowIfDisposed();

            return features2d_ORB_getPatchSize_10(nativeObj);


        }


        //
        // C++:  void cv::ORB::setFastThreshold(int fastThreshold)
        //

        public void setFastThreshold(int fastThreshold)
        {
            ThrowIfDisposed();

            features2d_ORB_setFastThreshold_10(nativeObj, fastThreshold);


        }


        //
        // C++:  int cv::ORB::getFastThreshold()
        //

        public int getFastThreshold()
        {
            ThrowIfDisposed();

            return features2d_ORB_getFastThreshold_10(nativeObj);


        }


        //
        // C++:  String cv::ORB::getDefaultName()
        //

        public override string getDefaultName()
        {
            ThrowIfDisposed();

            string retVal = Marshal.PtrToStringAnsi(DisposableObject.ThrowIfNullIntPtr(features2d_ORB_getDefaultName_10(nativeObj)));

            return retVal;
        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++: static Ptr_ORB cv::ORB::create(int nfeatures = 500, float scaleFactor = 1.2f, int nlevels = 8, int edgeThreshold = 31, int firstLevel = 0, int WTA_K = 2, ORB_ScoreType scoreType = ORB::HARRIS_SCORE, int patchSize = 31, int fastThreshold = 20)
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_ORB_create_10(int nfeatures, float scaleFactor, int nlevels, int edgeThreshold, int firstLevel, int WTA_K, int scoreType, int patchSize, int fastThreshold);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_ORB_create_11(int nfeatures, float scaleFactor, int nlevels, int edgeThreshold, int firstLevel, int WTA_K, int scoreType, int patchSize);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_ORB_create_12(int nfeatures, float scaleFactor, int nlevels, int edgeThreshold, int firstLevel, int WTA_K, int scoreType);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_ORB_create_13(int nfeatures, float scaleFactor, int nlevels, int edgeThreshold, int firstLevel, int WTA_K);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_ORB_create_14(int nfeatures, float scaleFactor, int nlevels, int edgeThreshold, int firstLevel);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_ORB_create_15(int nfeatures, float scaleFactor, int nlevels, int edgeThreshold);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_ORB_create_16(int nfeatures, float scaleFactor, int nlevels);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_ORB_create_17(int nfeatures, float scaleFactor);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_ORB_create_18(int nfeatures);
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_ORB_create_19();

        // C++:  void cv::ORB::setMaxFeatures(int maxFeatures)
        [DllImport(LIBNAME)]
        private static extern void features2d_ORB_setMaxFeatures_10(IntPtr nativeObj, int maxFeatures);

        // C++:  int cv::ORB::getMaxFeatures()
        [DllImport(LIBNAME)]
        private static extern int features2d_ORB_getMaxFeatures_10(IntPtr nativeObj);

        // C++:  void cv::ORB::setScaleFactor(double scaleFactor)
        [DllImport(LIBNAME)]
        private static extern void features2d_ORB_setScaleFactor_10(IntPtr nativeObj, double scaleFactor);

        // C++:  double cv::ORB::getScaleFactor()
        [DllImport(LIBNAME)]
        private static extern double features2d_ORB_getScaleFactor_10(IntPtr nativeObj);

        // C++:  void cv::ORB::setNLevels(int nlevels)
        [DllImport(LIBNAME)]
        private static extern void features2d_ORB_setNLevels_10(IntPtr nativeObj, int nlevels);

        // C++:  int cv::ORB::getNLevels()
        [DllImport(LIBNAME)]
        private static extern int features2d_ORB_getNLevels_10(IntPtr nativeObj);

        // C++:  void cv::ORB::setEdgeThreshold(int edgeThreshold)
        [DllImport(LIBNAME)]
        private static extern void features2d_ORB_setEdgeThreshold_10(IntPtr nativeObj, int edgeThreshold);

        // C++:  int cv::ORB::getEdgeThreshold()
        [DllImport(LIBNAME)]
        private static extern int features2d_ORB_getEdgeThreshold_10(IntPtr nativeObj);

        // C++:  void cv::ORB::setFirstLevel(int firstLevel)
        [DllImport(LIBNAME)]
        private static extern void features2d_ORB_setFirstLevel_10(IntPtr nativeObj, int firstLevel);

        // C++:  int cv::ORB::getFirstLevel()
        [DllImport(LIBNAME)]
        private static extern int features2d_ORB_getFirstLevel_10(IntPtr nativeObj);

        // C++:  void cv::ORB::setWTA_K(int wta_k)
        [DllImport(LIBNAME)]
        private static extern void features2d_ORB_setWTA_1K_10(IntPtr nativeObj, int wta_k);

        // C++:  int cv::ORB::getWTA_K()
        [DllImport(LIBNAME)]
        private static extern int features2d_ORB_getWTA_1K_10(IntPtr nativeObj);

        // C++:  void cv::ORB::setScoreType(ORB_ScoreType scoreType)
        [DllImport(LIBNAME)]
        private static extern void features2d_ORB_setScoreType_10(IntPtr nativeObj, int scoreType);

        // C++:  ORB_ScoreType cv::ORB::getScoreType()
        [DllImport(LIBNAME)]
        private static extern int features2d_ORB_getScoreType_10(IntPtr nativeObj);

        // C++:  void cv::ORB::setPatchSize(int patchSize)
        [DllImport(LIBNAME)]
        private static extern void features2d_ORB_setPatchSize_10(IntPtr nativeObj, int patchSize);

        // C++:  int cv::ORB::getPatchSize()
        [DllImport(LIBNAME)]
        private static extern int features2d_ORB_getPatchSize_10(IntPtr nativeObj);

        // C++:  void cv::ORB::setFastThreshold(int fastThreshold)
        [DllImport(LIBNAME)]
        private static extern void features2d_ORB_setFastThreshold_10(IntPtr nativeObj, int fastThreshold);

        // C++:  int cv::ORB::getFastThreshold()
        [DllImport(LIBNAME)]
        private static extern int features2d_ORB_getFastThreshold_10(IntPtr nativeObj);

        // C++:  String cv::ORB::getDefaultName()
        [DllImport(LIBNAME)]
        private static extern IntPtr features2d_ORB_getDefaultName_10(IntPtr nativeObj);

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void features2d_ORB_delete(IntPtr nativeObj);

    }
}
