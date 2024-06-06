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

@class DMatch;
@class IntVector;
@class KeyPoint;
@class Size2i;


// C++: enum KeypointLayout (cv.cuda.SURF_CUDA.KeypointLayout)
typedef NS_ENUM(int, KeypointLayout) {
    SURF_CUDA_X_ROW NS_SWIFT_NAME(X_ROW) = 0,
    SURF_CUDA_Y_ROW NS_SWIFT_NAME(Y_ROW) = 0+1,
    SURF_CUDA_LAPLACIAN_ROW NS_SWIFT_NAME(LAPLACIAN_ROW) = 0+2,
    SURF_CUDA_OCTAVE_ROW NS_SWIFT_NAME(OCTAVE_ROW) = 0+3,
    SURF_CUDA_SIZE_ROW NS_SWIFT_NAME(SIZE_ROW) = 0+4,
    SURF_CUDA_ANGLE_ROW NS_SWIFT_NAME(ANGLE_ROW) = 0+5,
    SURF_CUDA_HESSIAN_ROW NS_SWIFT_NAME(HESSIAN_ROW) = 0+6,
    SURF_CUDA_ROWS_COUNT NS_SWIFT_NAME(ROWS_COUNT) = 0+7
};



NS_ASSUME_NONNULL_BEGIN

// C++: class Xfeatures2d
/**
 * The Xfeatures2d module
 *
 * Member classes: `FREAK`, `StarDetector`, `BriefDescriptorExtractor`, `LUCID`, `LATCH`, `BEBLID`, `TEBLID`, `DAISY`, `MSDDetector`, `VGG`, `BoostDesc`, `PCTSignatures`, `PCTSignaturesSQFD`, `HarrisLaplaceFeatureDetector`, `AffineFeature2D`, `TBMR`, `SURF`
 *
 * Member enums: `BeblidSize`, `TeblidSize`, `NormalizationType`, `DistanceFunction`, `PointDistribution`, `SimilarityFunction`, `KeypointLayout`
 */
CV_EXPORTS @interface Xfeatures2d : NSObject

#pragma mark - Methods


//
//  void cv::xfeatures2d::matchGMS(Size size1, Size size2, vector_KeyPoint keypoints1, vector_KeyPoint keypoints2, vector_DMatch matches1to2, vector_DMatch& matchesGMS, bool withRotation = false, bool withScale = false, double thresholdFactor = 6.0)
//
/**
 * GMS (Grid-based Motion Statistics) feature matching strategy described in CITE: Bian2017gms .
 * @param size1 Input size of image1.
 * @param size2 Input size of image2.
 * @param keypoints1 Input keypoints of image1.
 * @param keypoints2 Input keypoints of image2.
 * @param matches1to2 Input 1-nearest neighbor matches.
 * @param matchesGMS Matches returned by the GMS matching strategy.
 * @param withRotation Take rotation transformation into account.
 * @param withScale Take scale transformation into account.
 * @param thresholdFactor The higher, the less matches.
 *     NOTE:
 *         Since GMS works well when the number of features is large, we recommend to use the ORB feature and set FastThreshold to 0 to get as many as possible features quickly.
 *         If matching results are not satisfying, please add more features. (We use 10000 for images with 640 X 480).
 *         If your images have big rotation and scale changes, please set withRotation or withScale to true.
 */
+ (void)matchGMS:(Size2i*)size1 size2:(Size2i*)size2 keypoints1:(NSArray<KeyPoint*>*)keypoints1 keypoints2:(NSArray<KeyPoint*>*)keypoints2 matches1to2:(NSArray<DMatch*>*)matches1to2 matchesGMS:(NSMutableArray<DMatch*>*)matchesGMS withRotation:(BOOL)withRotation withScale:(BOOL)withScale thresholdFactor:(double)thresholdFactor NS_SWIFT_NAME(matchGMS(size1:size2:keypoints1:keypoints2:matches1to2:matchesGMS:withRotation:withScale:thresholdFactor:));

/**
 * GMS (Grid-based Motion Statistics) feature matching strategy described in CITE: Bian2017gms .
 * @param size1 Input size of image1.
 * @param size2 Input size of image2.
 * @param keypoints1 Input keypoints of image1.
 * @param keypoints2 Input keypoints of image2.
 * @param matches1to2 Input 1-nearest neighbor matches.
 * @param matchesGMS Matches returned by the GMS matching strategy.
 * @param withRotation Take rotation transformation into account.
 * @param withScale Take scale transformation into account.
 *     NOTE:
 *         Since GMS works well when the number of features is large, we recommend to use the ORB feature and set FastThreshold to 0 to get as many as possible features quickly.
 *         If matching results are not satisfying, please add more features. (We use 10000 for images with 640 X 480).
 *         If your images have big rotation and scale changes, please set withRotation or withScale to true.
 */
+ (void)matchGMS:(Size2i*)size1 size2:(Size2i*)size2 keypoints1:(NSArray<KeyPoint*>*)keypoints1 keypoints2:(NSArray<KeyPoint*>*)keypoints2 matches1to2:(NSArray<DMatch*>*)matches1to2 matchesGMS:(NSMutableArray<DMatch*>*)matchesGMS withRotation:(BOOL)withRotation withScale:(BOOL)withScale NS_SWIFT_NAME(matchGMS(size1:size2:keypoints1:keypoints2:matches1to2:matchesGMS:withRotation:withScale:));

/**
 * GMS (Grid-based Motion Statistics) feature matching strategy described in CITE: Bian2017gms .
 * @param size1 Input size of image1.
 * @param size2 Input size of image2.
 * @param keypoints1 Input keypoints of image1.
 * @param keypoints2 Input keypoints of image2.
 * @param matches1to2 Input 1-nearest neighbor matches.
 * @param matchesGMS Matches returned by the GMS matching strategy.
 * @param withRotation Take rotation transformation into account.
 *     NOTE:
 *         Since GMS works well when the number of features is large, we recommend to use the ORB feature and set FastThreshold to 0 to get as many as possible features quickly.
 *         If matching results are not satisfying, please add more features. (We use 10000 for images with 640 X 480).
 *         If your images have big rotation and scale changes, please set withRotation or withScale to true.
 */
+ (void)matchGMS:(Size2i*)size1 size2:(Size2i*)size2 keypoints1:(NSArray<KeyPoint*>*)keypoints1 keypoints2:(NSArray<KeyPoint*>*)keypoints2 matches1to2:(NSArray<DMatch*>*)matches1to2 matchesGMS:(NSMutableArray<DMatch*>*)matchesGMS withRotation:(BOOL)withRotation NS_SWIFT_NAME(matchGMS(size1:size2:keypoints1:keypoints2:matches1to2:matchesGMS:withRotation:));

/**
 * GMS (Grid-based Motion Statistics) feature matching strategy described in CITE: Bian2017gms .
 * @param size1 Input size of image1.
 * @param size2 Input size of image2.
 * @param keypoints1 Input keypoints of image1.
 * @param keypoints2 Input keypoints of image2.
 * @param matches1to2 Input 1-nearest neighbor matches.
 * @param matchesGMS Matches returned by the GMS matching strategy.
 *     NOTE:
 *         Since GMS works well when the number of features is large, we recommend to use the ORB feature and set FastThreshold to 0 to get as many as possible features quickly.
 *         If matching results are not satisfying, please add more features. (We use 10000 for images with 640 X 480).
 *         If your images have big rotation and scale changes, please set withRotation or withScale to true.
 */
+ (void)matchGMS:(Size2i*)size1 size2:(Size2i*)size2 keypoints1:(NSArray<KeyPoint*>*)keypoints1 keypoints2:(NSArray<KeyPoint*>*)keypoints2 matches1to2:(NSArray<DMatch*>*)matches1to2 matchesGMS:(NSMutableArray<DMatch*>*)matchesGMS NS_SWIFT_NAME(matchGMS(size1:size2:keypoints1:keypoints2:matches1to2:matchesGMS:));


//
//  void cv::xfeatures2d::matchLOGOS(vector_KeyPoint keypoints1, vector_KeyPoint keypoints2, vector_int nn1, vector_int nn2, vector_DMatch matches1to2)
//
/**
 * LOGOS (Local geometric support for high-outlier spatial verification) feature matching strategy described in CITE: Lowry2018LOGOSLG .
 * @param keypoints1 Input keypoints of image1.
 * @param keypoints2 Input keypoints of image2.
 * @param nn1 Index to the closest BoW centroid for each descriptors of image1.
 * @param nn2 Index to the closest BoW centroid for each descriptors of image2.
 * @param matches1to2 Matches returned by the LOGOS matching strategy.
 *     NOTE:
 *         This matching strategy is suitable for features matching against large scale database.
 *         First step consists in constructing the bag-of-words (BoW) from a representative image database.
 *         Image descriptors are then represented by their closest codevector (nearest BoW centroid).
 */
+ (void)matchLOGOS:(NSArray<KeyPoint*>*)keypoints1 keypoints2:(NSArray<KeyPoint*>*)keypoints2 nn1:(IntVector*)nn1 nn2:(IntVector*)nn2 matches1to2:(NSArray<DMatch*>*)matches1to2 NS_SWIFT_NAME(matchLOGOS(keypoints1:keypoints2:nn1:nn2:matches1to2:));



@end

NS_ASSUME_NONNULL_END


