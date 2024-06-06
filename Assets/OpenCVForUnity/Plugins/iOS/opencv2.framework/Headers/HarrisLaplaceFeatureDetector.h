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
#import "Feature2D.h"





NS_ASSUME_NONNULL_BEGIN

// C++: class HarrisLaplaceFeatureDetector
/**
 * Class implementing the Harris-Laplace feature detector as described in CITE: Mikolajczyk2004.
 *
 * Member of `Xfeatures2d`
 */
CV_EXPORTS @interface HarrisLaplaceFeatureDetector : Feature2D


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::xfeatures2d::HarrisLaplaceFeatureDetector> nativePtrHarrisLaplaceFeatureDetector;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::xfeatures2d::HarrisLaplaceFeatureDetector>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::xfeatures2d::HarrisLaplaceFeatureDetector>)nativePtr;
#endif


#pragma mark - Methods


//
// static Ptr_HarrisLaplaceFeatureDetector cv::xfeatures2d::HarrisLaplaceFeatureDetector::create(int numOctaves = 6, float corn_thresh = 0.01f, float DOG_thresh = 0.01f, int maxCorners = 5000, int num_layers = 4)
//
/**
 * Creates a new implementation instance.
 *
 * @param numOctaves the number of octaves in the scale-space pyramid
 * @param corn_thresh the threshold for the Harris cornerness measure
 * @param DOG_thresh the threshold for the Difference-of-Gaussians scale selection
 * @param maxCorners the maximum number of corners to consider
 * @param num_layers the number of intermediate scales per octave
 */
+ (HarrisLaplaceFeatureDetector*)create:(int)numOctaves corn_thresh:(float)corn_thresh DOG_thresh:(float)DOG_thresh maxCorners:(int)maxCorners num_layers:(int)num_layers NS_SWIFT_NAME(create(numOctaves:corn_thresh:DOG_thresh:maxCorners:num_layers:));

/**
 * Creates a new implementation instance.
 *
 * @param numOctaves the number of octaves in the scale-space pyramid
 * @param corn_thresh the threshold for the Harris cornerness measure
 * @param DOG_thresh the threshold for the Difference-of-Gaussians scale selection
 * @param maxCorners the maximum number of corners to consider
 */
+ (HarrisLaplaceFeatureDetector*)create:(int)numOctaves corn_thresh:(float)corn_thresh DOG_thresh:(float)DOG_thresh maxCorners:(int)maxCorners NS_SWIFT_NAME(create(numOctaves:corn_thresh:DOG_thresh:maxCorners:));

/**
 * Creates a new implementation instance.
 *
 * @param numOctaves the number of octaves in the scale-space pyramid
 * @param corn_thresh the threshold for the Harris cornerness measure
 * @param DOG_thresh the threshold for the Difference-of-Gaussians scale selection
 */
+ (HarrisLaplaceFeatureDetector*)create:(int)numOctaves corn_thresh:(float)corn_thresh DOG_thresh:(float)DOG_thresh NS_SWIFT_NAME(create(numOctaves:corn_thresh:DOG_thresh:));

/**
 * Creates a new implementation instance.
 *
 * @param numOctaves the number of octaves in the scale-space pyramid
 * @param corn_thresh the threshold for the Harris cornerness measure
 */
+ (HarrisLaplaceFeatureDetector*)create:(int)numOctaves corn_thresh:(float)corn_thresh NS_SWIFT_NAME(create(numOctaves:corn_thresh:));

/**
 * Creates a new implementation instance.
 *
 * @param numOctaves the number of octaves in the scale-space pyramid
 */
+ (HarrisLaplaceFeatureDetector*)create:(int)numOctaves NS_SWIFT_NAME(create(numOctaves:));

/**
 * Creates a new implementation instance.
 *
 */
+ (HarrisLaplaceFeatureDetector*)create NS_SWIFT_NAME(create());


//
//  void cv::xfeatures2d::HarrisLaplaceFeatureDetector::setNumOctaves(int numOctaves_)
//
- (void)setNumOctaves:(int)numOctaves_ NS_SWIFT_NAME(setNumOctaves(numOctaves_:));


//
//  int cv::xfeatures2d::HarrisLaplaceFeatureDetector::getNumOctaves()
//
- (int)getNumOctaves NS_SWIFT_NAME(getNumOctaves());


//
//  void cv::xfeatures2d::HarrisLaplaceFeatureDetector::setCornThresh(float corn_thresh_)
//
- (void)setCornThresh:(float)corn_thresh_ NS_SWIFT_NAME(setCornThresh(corn_thresh_:));


//
//  float cv::xfeatures2d::HarrisLaplaceFeatureDetector::getCornThresh()
//
- (float)getCornThresh NS_SWIFT_NAME(getCornThresh());


//
//  void cv::xfeatures2d::HarrisLaplaceFeatureDetector::setDOGThresh(float DOG_thresh_)
//
- (void)setDOGThresh:(float)DOG_thresh_ NS_SWIFT_NAME(setDOGThresh(DOG_thresh_:));


//
//  float cv::xfeatures2d::HarrisLaplaceFeatureDetector::getDOGThresh()
//
- (float)getDOGThresh NS_SWIFT_NAME(getDOGThresh());


//
//  void cv::xfeatures2d::HarrisLaplaceFeatureDetector::setMaxCorners(int maxCorners_)
//
- (void)setMaxCorners:(int)maxCorners_ NS_SWIFT_NAME(setMaxCorners(maxCorners_:));


//
//  int cv::xfeatures2d::HarrisLaplaceFeatureDetector::getMaxCorners()
//
- (int)getMaxCorners NS_SWIFT_NAME(getMaxCorners());


//
//  void cv::xfeatures2d::HarrisLaplaceFeatureDetector::setNumLayers(int num_layers_)
//
- (void)setNumLayers:(int)num_layers_ NS_SWIFT_NAME(setNumLayers(num_layers_:));


//
//  int cv::xfeatures2d::HarrisLaplaceFeatureDetector::getNumLayers()
//
- (int)getNumLayers NS_SWIFT_NAME(getNumLayers());


//
//  String cv::xfeatures2d::HarrisLaplaceFeatureDetector::getDefaultName()
//
- (NSString*)getDefaultName NS_SWIFT_NAME(getDefaultName());



@end

NS_ASSUME_NONNULL_END


