//
// This file is auto-generated. Please don't modify it!
//
#pragma once

#ifdef __cplusplus
//#import "opencv.hpp"
#import "opencv2/xfeatures2d.hpp"
#else
#define CV_EXPORTS
#endif

#import <Foundation/Foundation.h>
#import "Algorithm.h"

@class FloatVector;
@class IntVector;
@class Mat;
@class Point2f;


// C++: enum DistanceFunction (cv.xfeatures2d.PCTSignatures.DistanceFunction)
typedef NS_ENUM(int, DistanceFunction) {
    PCTSignatures_L0_25 NS_SWIFT_NAME(L0_25) = 0,
    PCTSignatures_L0_5 NS_SWIFT_NAME(L0_5) = 1,
    PCTSignatures_L1 NS_SWIFT_NAME(L1) = 2,
    PCTSignatures_L2 NS_SWIFT_NAME(L2) = 3,
    PCTSignatures_L2SQUARED NS_SWIFT_NAME(L2SQUARED) = 4,
    PCTSignatures_L5 NS_SWIFT_NAME(L5) = 5,
    PCTSignatures_L_INFINITY NS_SWIFT_NAME(L_INFINITY) = 6
};


// C++: enum PointDistribution (cv.xfeatures2d.PCTSignatures.PointDistribution)
typedef NS_ENUM(int, PointDistribution) {
    PCTSignatures_UNIFORM NS_SWIFT_NAME(UNIFORM) = 0,
    PCTSignatures_REGULAR NS_SWIFT_NAME(REGULAR) = 1,
    PCTSignatures_NORMAL NS_SWIFT_NAME(NORMAL) = 2
};


// C++: enum SimilarityFunction (cv.xfeatures2d.PCTSignatures.SimilarityFunction)
typedef NS_ENUM(int, SimilarityFunction) {
    PCTSignatures_MINUS NS_SWIFT_NAME(MINUS) = 0,
    PCTSignatures_GAUSSIAN NS_SWIFT_NAME(GAUSSIAN) = 1,
    PCTSignatures_HEURISTIC NS_SWIFT_NAME(HEURISTIC) = 2
};



NS_ASSUME_NONNULL_BEGIN

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
 *
 * Member of `Xfeatures2d`
 */
CV_EXPORTS @interface PCTSignatures : Algorithm


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::xfeatures2d::PCTSignatures> nativePtrPCTSignatures;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::xfeatures2d::PCTSignatures>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::xfeatures2d::PCTSignatures>)nativePtr;
#endif


#pragma mark - Methods


//
// static Ptr_PCTSignatures cv::xfeatures2d::PCTSignatures::create(int initSampleCount = 2000, int initSeedCount = 400, int pointDistribution = 0)
//
/**
 * Creates PCTSignatures algorithm using sample and seed count.
 * It generates its own sets of sampling points and clusterization seed indexes.
 * @param initSampleCount Number of points used for image sampling.
 * @param initSeedCount Number of initial clusterization seeds.
 * Must be lower or equal to initSampleCount
 * @param pointDistribution Distribution of generated points. Default: UNIFORM.
 * Available: UNIFORM, REGULAR, NORMAL.
 * @return Created algorithm.
 */
+ (PCTSignatures*)create:(int)initSampleCount initSeedCount:(int)initSeedCount pointDistribution:(int)pointDistribution NS_SWIFT_NAME(create(initSampleCount:initSeedCount:pointDistribution:));

/**
 * Creates PCTSignatures algorithm using sample and seed count.
 * It generates its own sets of sampling points and clusterization seed indexes.
 * @param initSampleCount Number of points used for image sampling.
 * @param initSeedCount Number of initial clusterization seeds.
 * Must be lower or equal to initSampleCount
 * Available: UNIFORM, REGULAR, NORMAL.
 * @return Created algorithm.
 */
+ (PCTSignatures*)create:(int)initSampleCount initSeedCount:(int)initSeedCount NS_SWIFT_NAME(create(initSampleCount:initSeedCount:));

/**
 * Creates PCTSignatures algorithm using sample and seed count.
 * It generates its own sets of sampling points and clusterization seed indexes.
 * @param initSampleCount Number of points used for image sampling.
 * Must be lower or equal to initSampleCount
 * Available: UNIFORM, REGULAR, NORMAL.
 * @return Created algorithm.
 */
+ (PCTSignatures*)create:(int)initSampleCount NS_SWIFT_NAME(create(initSampleCount:));

/**
 * Creates PCTSignatures algorithm using sample and seed count.
 * It generates its own sets of sampling points and clusterization seed indexes.
 * Must be lower or equal to initSampleCount
 * Available: UNIFORM, REGULAR, NORMAL.
 * @return Created algorithm.
 */
+ (PCTSignatures*)create NS_SWIFT_NAME(create());


//
// static Ptr_PCTSignatures cv::xfeatures2d::PCTSignatures::create(vector_Point2f initSamplingPoints, int initSeedCount)
//
/**
 * Creates PCTSignatures algorithm using pre-generated sampling points
 * and number of clusterization seeds. It uses the provided
 * sampling points and generates its own clusterization seed indexes.
 * @param initSamplingPoints Sampling points used in image sampling.
 * @param initSeedCount Number of initial clusterization seeds.
 * Must be lower or equal to initSamplingPoints.size().
 * @return Created algorithm.
 */
+ (PCTSignatures*)create2:(NSArray<Point2f*>*)initSamplingPoints initSeedCount:(int)initSeedCount NS_SWIFT_NAME(create(initSamplingPoints:initSeedCount:));


//
// static Ptr_PCTSignatures cv::xfeatures2d::PCTSignatures::create(vector_Point2f initSamplingPoints, vector_int initClusterSeedIndexes)
//
/**
 * Creates PCTSignatures algorithm using pre-generated sampling points
 * and clusterization seeds indexes.
 * @param initSamplingPoints Sampling points used in image sampling.
 * @param initClusterSeedIndexes Indexes of initial clusterization seeds.
 * Its size must be lower or equal to initSamplingPoints.size().
 * @return Created algorithm.
 */
+ (PCTSignatures*)create:(NSArray<Point2f*>*)initSamplingPoints initClusterSeedIndexes:(IntVector*)initClusterSeedIndexes NS_SWIFT_NAME(create(initSamplingPoints:initClusterSeedIndexes:));


//
//  void cv::xfeatures2d::PCTSignatures::computeSignature(Mat image, Mat& signature)
//
/**
 * Computes signature of given image.
 * @param image Input image of CV_8U type.
 * @param signature Output computed signature.
 */
- (void)computeSignature:(Mat*)image signature:(Mat*)signature NS_SWIFT_NAME(computeSignature(image:signature:));


//
//  void cv::xfeatures2d::PCTSignatures::computeSignatures(vector_Mat images, vector_Mat signatures)
//
/**
 * Computes signatures for multiple images in parallel.
 * @param images Vector of input images of CV_8U type.
 * @param signatures Vector of computed signatures.
 */
- (void)computeSignatures:(NSArray<Mat*>*)images signatures:(NSArray<Mat*>*)signatures NS_SWIFT_NAME(computeSignatures(images:signatures:));


//
// static void cv::xfeatures2d::PCTSignatures::drawSignature(Mat source, Mat signature, Mat& result, float radiusToShorterSideRatio = 1.0 / 8, int borderThickness = 1)
//
/**
 * Draws signature in the source image and outputs the result.
 * Signatures are visualized as a circle
 * with radius based on signature weight
 * and color based on signature color.
 * Contrast and entropy are not visualized.
 * @param source Source image.
 * @param signature Image signature.
 * @param result Output result.
 * @param radiusToShorterSideRatio Determines maximal radius of signature in the output image.
 * @param borderThickness Border thickness of the visualized signature.
 */
+ (void)drawSignature:(Mat*)source signature:(Mat*)signature result:(Mat*)result radiusToShorterSideRatio:(float)radiusToShorterSideRatio borderThickness:(int)borderThickness NS_SWIFT_NAME(drawSignature(source:signature:result:radiusToShorterSideRatio:borderThickness:));

/**
 * Draws signature in the source image and outputs the result.
 * Signatures are visualized as a circle
 * with radius based on signature weight
 * and color based on signature color.
 * Contrast and entropy are not visualized.
 * @param source Source image.
 * @param signature Image signature.
 * @param result Output result.
 * @param radiusToShorterSideRatio Determines maximal radius of signature in the output image.
 */
+ (void)drawSignature:(Mat*)source signature:(Mat*)signature result:(Mat*)result radiusToShorterSideRatio:(float)radiusToShorterSideRatio NS_SWIFT_NAME(drawSignature(source:signature:result:radiusToShorterSideRatio:));

/**
 * Draws signature in the source image and outputs the result.
 * Signatures are visualized as a circle
 * with radius based on signature weight
 * and color based on signature color.
 * Contrast and entropy are not visualized.
 * @param source Source image.
 * @param signature Image signature.
 * @param result Output result.
 */
+ (void)drawSignature:(Mat*)source signature:(Mat*)signature result:(Mat*)result NS_SWIFT_NAME(drawSignature(source:signature:result:));


//
// static void cv::xfeatures2d::PCTSignatures::generateInitPoints(vector_Point2f initPoints, int count, int pointDistribution)
//
/**
 * Generates initial sampling points according to selected point distribution.
 * @param initPoints Output vector where the generated points will be saved.
 * @param count Number of points to generate.
 * @param pointDistribution Point distribution selector.
 * Available: UNIFORM, REGULAR, NORMAL.
 * NOTE: Generated coordinates are in range [0..1)
 */
+ (void)generateInitPoints:(NSArray<Point2f*>*)initPoints count:(int)count pointDistribution:(int)pointDistribution NS_SWIFT_NAME(generateInitPoints(initPoints:count:pointDistribution:));


//
//  int cv::xfeatures2d::PCTSignatures::getSampleCount()
//
/**
 * Number of initial samples taken from the image.
 */
- (int)getSampleCount NS_SWIFT_NAME(getSampleCount());


//
//  int cv::xfeatures2d::PCTSignatures::getGrayscaleBits()
//
/**
 * Color resolution of the greyscale bitmap represented in allocated bits
 * (i.e., value 4 means that 16 shades of grey are used).
 * The greyscale bitmap is used for computing contrast and entropy values.
 */
- (int)getGrayscaleBits NS_SWIFT_NAME(getGrayscaleBits());


//
//  void cv::xfeatures2d::PCTSignatures::setGrayscaleBits(int grayscaleBits)
//
/**
 * Color resolution of the greyscale bitmap represented in allocated bits
 * (i.e., value 4 means that 16 shades of grey are used).
 * The greyscale bitmap is used for computing contrast and entropy values.
 */
- (void)setGrayscaleBits:(int)grayscaleBits NS_SWIFT_NAME(setGrayscaleBits(grayscaleBits:));


//
//  int cv::xfeatures2d::PCTSignatures::getWindowRadius()
//
/**
 * Size of the texture sampling window used to compute contrast and entropy
 * (center of the window is always in the pixel selected by x,y coordinates
 * of the corresponding feature sample).
 */
- (int)getWindowRadius NS_SWIFT_NAME(getWindowRadius());


//
//  void cv::xfeatures2d::PCTSignatures::setWindowRadius(int radius)
//
/**
 * Size of the texture sampling window used to compute contrast and entropy
 * (center of the window is always in the pixel selected by x,y coordinates
 * of the corresponding feature sample).
 */
- (void)setWindowRadius:(int)radius NS_SWIFT_NAME(setWindowRadius(radius:));


//
//  float cv::xfeatures2d::PCTSignatures::getWeightX()
//
/**
 * Weights (multiplicative constants) that linearly stretch individual axes of the feature space
 * (x,y = position; L,a,b = color in CIE Lab space; c = contrast. e = entropy)
 */
- (float)getWeightX NS_SWIFT_NAME(getWeightX());


//
//  void cv::xfeatures2d::PCTSignatures::setWeightX(float weight)
//
/**
 * Weights (multiplicative constants) that linearly stretch individual axes of the feature space
 * (x,y = position; L,a,b = color in CIE Lab space; c = contrast. e = entropy)
 */
- (void)setWeightX:(float)weight NS_SWIFT_NAME(setWeightX(weight:));


//
//  float cv::xfeatures2d::PCTSignatures::getWeightY()
//
/**
 * Weights (multiplicative constants) that linearly stretch individual axes of the feature space
 * (x,y = position; L,a,b = color in CIE Lab space; c = contrast. e = entropy)
 */
- (float)getWeightY NS_SWIFT_NAME(getWeightY());


//
//  void cv::xfeatures2d::PCTSignatures::setWeightY(float weight)
//
/**
 * Weights (multiplicative constants) that linearly stretch individual axes of the feature space
 * (x,y = position; L,a,b = color in CIE Lab space; c = contrast. e = entropy)
 */
- (void)setWeightY:(float)weight NS_SWIFT_NAME(setWeightY(weight:));


//
//  float cv::xfeatures2d::PCTSignatures::getWeightL()
//
/**
 * Weights (multiplicative constants) that linearly stretch individual axes of the feature space
 * (x,y = position; L,a,b = color in CIE Lab space; c = contrast. e = entropy)
 */
- (float)getWeightL NS_SWIFT_NAME(getWeightL());


//
//  void cv::xfeatures2d::PCTSignatures::setWeightL(float weight)
//
/**
 * Weights (multiplicative constants) that linearly stretch individual axes of the feature space
 * (x,y = position; L,a,b = color in CIE Lab space; c = contrast. e = entropy)
 */
- (void)setWeightL:(float)weight NS_SWIFT_NAME(setWeightL(weight:));


//
//  float cv::xfeatures2d::PCTSignatures::getWeightA()
//
/**
 * Weights (multiplicative constants) that linearly stretch individual axes of the feature space
 * (x,y = position; L,a,b = color in CIE Lab space; c = contrast. e = entropy)
 */
- (float)getWeightA NS_SWIFT_NAME(getWeightA());


//
//  void cv::xfeatures2d::PCTSignatures::setWeightA(float weight)
//
/**
 * Weights (multiplicative constants) that linearly stretch individual axes of the feature space
 * (x,y = position; L,a,b = color in CIE Lab space; c = contrast. e = entropy)
 */
- (void)setWeightA:(float)weight NS_SWIFT_NAME(setWeightA(weight:));


//
//  float cv::xfeatures2d::PCTSignatures::getWeightB()
//
/**
 * Weights (multiplicative constants) that linearly stretch individual axes of the feature space
 * (x,y = position; L,a,b = color in CIE Lab space; c = contrast. e = entropy)
 */
- (float)getWeightB NS_SWIFT_NAME(getWeightB());


//
//  void cv::xfeatures2d::PCTSignatures::setWeightB(float weight)
//
/**
 * Weights (multiplicative constants) that linearly stretch individual axes of the feature space
 * (x,y = position; L,a,b = color in CIE Lab space; c = contrast. e = entropy)
 */
- (void)setWeightB:(float)weight NS_SWIFT_NAME(setWeightB(weight:));


//
//  float cv::xfeatures2d::PCTSignatures::getWeightContrast()
//
/**
 * Weights (multiplicative constants) that linearly stretch individual axes of the feature space
 * (x,y = position; L,a,b = color in CIE Lab space; c = contrast. e = entropy)
 */
- (float)getWeightContrast NS_SWIFT_NAME(getWeightContrast());


//
//  void cv::xfeatures2d::PCTSignatures::setWeightContrast(float weight)
//
/**
 * Weights (multiplicative constants) that linearly stretch individual axes of the feature space
 * (x,y = position; L,a,b = color in CIE Lab space; c = contrast. e = entropy)
 */
- (void)setWeightContrast:(float)weight NS_SWIFT_NAME(setWeightContrast(weight:));


//
//  float cv::xfeatures2d::PCTSignatures::getWeightEntropy()
//
/**
 * Weights (multiplicative constants) that linearly stretch individual axes of the feature space
 * (x,y = position; L,a,b = color in CIE Lab space; c = contrast. e = entropy)
 */
- (float)getWeightEntropy NS_SWIFT_NAME(getWeightEntropy());


//
//  void cv::xfeatures2d::PCTSignatures::setWeightEntropy(float weight)
//
/**
 * Weights (multiplicative constants) that linearly stretch individual axes of the feature space
 * (x,y = position; L,a,b = color in CIE Lab space; c = contrast. e = entropy)
 */
- (void)setWeightEntropy:(float)weight NS_SWIFT_NAME(setWeightEntropy(weight:));


//
//  vector_Point2f cv::xfeatures2d::PCTSignatures::getSamplingPoints()
//
/**
 * Initial samples taken from the image.
 * These sampled features become the input for clustering.
 */
- (NSArray<Point2f*>*)getSamplingPoints NS_SWIFT_NAME(getSamplingPoints());


//
//  void cv::xfeatures2d::PCTSignatures::setWeight(int idx, float value)
//
/**
 * Weights (multiplicative constants) that linearly stretch individual axes of the feature space.
 * @param idx ID of the weight
 * @param value Value of the weight
 * NOTE:
 * WEIGHT_IDX = 0;
 * X_IDX = 1;
 * Y_IDX = 2;
 * L_IDX = 3;
 * A_IDX = 4;
 * B_IDX = 5;
 * CONTRAST_IDX = 6;
 * ENTROPY_IDX = 7;
 */
- (void)setWeight:(int)idx value:(float)value NS_SWIFT_NAME(setWeight(idx:value:));


//
//  void cv::xfeatures2d::PCTSignatures::setWeights(vector_float weights)
//
/**
 * Weights (multiplicative constants) that linearly stretch individual axes of the feature space.
 * @param weights Values of all weights.
 * NOTE:
 * WEIGHT_IDX = 0;
 * X_IDX = 1;
 * Y_IDX = 2;
 * L_IDX = 3;
 * A_IDX = 4;
 * B_IDX = 5;
 * CONTRAST_IDX = 6;
 * ENTROPY_IDX = 7;
 */
- (void)setWeights:(FloatVector*)weights NS_SWIFT_NAME(setWeights(weights:));


//
//  void cv::xfeatures2d::PCTSignatures::setTranslation(int idx, float value)
//
/**
 * Translations of the individual axes of the feature space.
 * @param idx ID of the translation
 * @param value Value of the translation
 * NOTE:
 * WEIGHT_IDX = 0;
 * X_IDX = 1;
 * Y_IDX = 2;
 * L_IDX = 3;
 * A_IDX = 4;
 * B_IDX = 5;
 * CONTRAST_IDX = 6;
 * ENTROPY_IDX = 7;
 */
- (void)setTranslation:(int)idx value:(float)value NS_SWIFT_NAME(setTranslation(idx:value:));


//
//  void cv::xfeatures2d::PCTSignatures::setTranslations(vector_float translations)
//
/**
 * Translations of the individual axes of the feature space.
 * @param translations Values of all translations.
 * NOTE:
 * WEIGHT_IDX = 0;
 * X_IDX = 1;
 * Y_IDX = 2;
 * L_IDX = 3;
 * A_IDX = 4;
 * B_IDX = 5;
 * CONTRAST_IDX = 6;
 * ENTROPY_IDX = 7;
 */
- (void)setTranslations:(FloatVector*)translations NS_SWIFT_NAME(setTranslations(translations:));


//
//  void cv::xfeatures2d::PCTSignatures::setSamplingPoints(vector_Point2f samplingPoints)
//
/**
 * Sets sampling points used to sample the input image.
 * @param samplingPoints Vector of sampling points in range [0..1)
 * NOTE: Number of sampling points must be greater or equal to clusterization seed count.
 */
- (void)setSamplingPoints:(NSArray<Point2f*>*)samplingPoints NS_SWIFT_NAME(setSamplingPoints(samplingPoints:));


//
//  vector_int cv::xfeatures2d::PCTSignatures::getInitSeedIndexes()
//
/**
 * Initial seeds (initial number of clusters) for the k-means algorithm.
 */
- (IntVector*)getInitSeedIndexes NS_SWIFT_NAME(getInitSeedIndexes());


//
//  void cv::xfeatures2d::PCTSignatures::setInitSeedIndexes(vector_int initSeedIndexes)
//
/**
 * Initial seed indexes for the k-means algorithm.
 */
- (void)setInitSeedIndexes:(IntVector*)initSeedIndexes NS_SWIFT_NAME(setInitSeedIndexes(initSeedIndexes:));


//
//  int cv::xfeatures2d::PCTSignatures::getInitSeedCount()
//
/**
 * Number of initial seeds (initial number of clusters) for the k-means algorithm.
 */
- (int)getInitSeedCount NS_SWIFT_NAME(getInitSeedCount());


//
//  int cv::xfeatures2d::PCTSignatures::getIterationCount()
//
/**
 * Number of iterations of the k-means clustering.
 * We use fixed number of iterations, since the modified clustering is pruning clusters
 * (not iteratively refining k clusters).
 */
- (int)getIterationCount NS_SWIFT_NAME(getIterationCount());


//
//  void cv::xfeatures2d::PCTSignatures::setIterationCount(int iterationCount)
//
/**
 * Number of iterations of the k-means clustering.
 * We use fixed number of iterations, since the modified clustering is pruning clusters
 * (not iteratively refining k clusters).
 */
- (void)setIterationCount:(int)iterationCount NS_SWIFT_NAME(setIterationCount(iterationCount:));


//
//  int cv::xfeatures2d::PCTSignatures::getMaxClustersCount()
//
/**
 * Maximal number of generated clusters. If the number is exceeded,
 * the clusters are sorted by their weights and the smallest clusters are cropped.
 */
- (int)getMaxClustersCount NS_SWIFT_NAME(getMaxClustersCount());


//
//  void cv::xfeatures2d::PCTSignatures::setMaxClustersCount(int maxClustersCount)
//
/**
 * Maximal number of generated clusters. If the number is exceeded,
 * the clusters are sorted by their weights and the smallest clusters are cropped.
 */
- (void)setMaxClustersCount:(int)maxClustersCount NS_SWIFT_NAME(setMaxClustersCount(maxClustersCount:));


//
//  int cv::xfeatures2d::PCTSignatures::getClusterMinSize()
//
/**
 * This parameter multiplied by the index of iteration gives lower limit for cluster size.
 * Clusters containing fewer points than specified by the limit have their centroid dismissed
 * and points are reassigned.
 */
- (int)getClusterMinSize NS_SWIFT_NAME(getClusterMinSize());


//
//  void cv::xfeatures2d::PCTSignatures::setClusterMinSize(int clusterMinSize)
//
/**
 * This parameter multiplied by the index of iteration gives lower limit for cluster size.
 * Clusters containing fewer points than specified by the limit have their centroid dismissed
 * and points are reassigned.
 */
- (void)setClusterMinSize:(int)clusterMinSize NS_SWIFT_NAME(setClusterMinSize(clusterMinSize:));


//
//  float cv::xfeatures2d::PCTSignatures::getJoiningDistance()
//
/**
 * Threshold euclidean distance between two centroids.
 * If two cluster centers are closer than this distance,
 * one of the centroid is dismissed and points are reassigned.
 */
- (float)getJoiningDistance NS_SWIFT_NAME(getJoiningDistance());


//
//  void cv::xfeatures2d::PCTSignatures::setJoiningDistance(float joiningDistance)
//
/**
 * Threshold euclidean distance between two centroids.
 * If two cluster centers are closer than this distance,
 * one of the centroid is dismissed and points are reassigned.
 */
- (void)setJoiningDistance:(float)joiningDistance NS_SWIFT_NAME(setJoiningDistance(joiningDistance:));


//
//  float cv::xfeatures2d::PCTSignatures::getDropThreshold()
//
/**
 * Remove centroids in k-means whose weight is lesser or equal to given threshold.
 */
- (float)getDropThreshold NS_SWIFT_NAME(getDropThreshold());


//
//  void cv::xfeatures2d::PCTSignatures::setDropThreshold(float dropThreshold)
//
/**
 * Remove centroids in k-means whose weight is lesser or equal to given threshold.
 */
- (void)setDropThreshold:(float)dropThreshold NS_SWIFT_NAME(setDropThreshold(dropThreshold:));


//
//  int cv::xfeatures2d::PCTSignatures::getDistanceFunction()
//
/**
 * Distance function selector used for measuring distance between two points in k-means.
 */
- (int)getDistanceFunction NS_SWIFT_NAME(getDistanceFunction());


//
//  void cv::xfeatures2d::PCTSignatures::setDistanceFunction(int distanceFunction)
//
/**
 * Distance function selector used for measuring distance between two points in k-means.
 * Available: L0_25, L0_5, L1, L2, L2SQUARED, L5, L_INFINITY.
 */
- (void)setDistanceFunction:(int)distanceFunction NS_SWIFT_NAME(setDistanceFunction(distanceFunction:));



@end

NS_ASSUME_NONNULL_END


