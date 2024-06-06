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

@class IntVector;



NS_ASSUME_NONNULL_BEGIN

// C++: class FREAK
/**
 * Class implementing the FREAK (*Fast Retina Keypoint*) keypoint descriptor, described in CITE: AOV12 .
 *
 * The algorithm propose a novel keypoint descriptor inspired by the human visual system and more
 * precisely the retina, coined Fast Retina Key- point (FREAK). A cascade of binary strings is
 * computed by efficiently comparing image intensities over a retinal sampling pattern. FREAKs are in
 * general faster to compute with lower memory load and also more robust than SIFT, SURF or BRISK.
 * They are competitive alternatives to existing keypoints in particular for embedded applications.
 *
 * NOTE:
 *    -   An example on how to use the FREAK descriptor can be found at
 *         opencv_source_code/samples/cpp/freak_demo.cpp
 *
 * Member of `Xfeatures2d`
 */
CV_EXPORTS @interface FREAK : Feature2D


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::xfeatures2d::FREAK> nativePtrFREAK;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::xfeatures2d::FREAK>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::xfeatures2d::FREAK>)nativePtr;
#endif


#pragma mark - Methods


//
// static Ptr_FREAK cv::xfeatures2d::FREAK::create(bool orientationNormalized = true, bool scaleNormalized = true, float patternScale = 22.0f, int nOctaves = 4, vector_int selectedPairs = std::vector<int>())
//
/**
 * @param orientationNormalized Enable orientation normalization.
 * @param scaleNormalized Enable scale normalization.
 * @param patternScale Scaling of the description pattern.
 * @param nOctaves Number of octaves covered by the detected keypoints.
 * @param selectedPairs (Optional) user defined selected pairs indexes,
 */
+ (FREAK*)create:(BOOL)orientationNormalized scaleNormalized:(BOOL)scaleNormalized patternScale:(float)patternScale nOctaves:(int)nOctaves selectedPairs:(IntVector*)selectedPairs NS_SWIFT_NAME(create(orientationNormalized:scaleNormalized:patternScale:nOctaves:selectedPairs:));

/**
 * @param orientationNormalized Enable orientation normalization.
 * @param scaleNormalized Enable scale normalization.
 * @param patternScale Scaling of the description pattern.
 * @param nOctaves Number of octaves covered by the detected keypoints.
 */
+ (FREAK*)create:(BOOL)orientationNormalized scaleNormalized:(BOOL)scaleNormalized patternScale:(float)patternScale nOctaves:(int)nOctaves NS_SWIFT_NAME(create(orientationNormalized:scaleNormalized:patternScale:nOctaves:));

/**
 * @param orientationNormalized Enable orientation normalization.
 * @param scaleNormalized Enable scale normalization.
 * @param patternScale Scaling of the description pattern.
 */
+ (FREAK*)create:(BOOL)orientationNormalized scaleNormalized:(BOOL)scaleNormalized patternScale:(float)patternScale NS_SWIFT_NAME(create(orientationNormalized:scaleNormalized:patternScale:));

/**
 * @param orientationNormalized Enable orientation normalization.
 * @param scaleNormalized Enable scale normalization.
 */
+ (FREAK*)create:(BOOL)orientationNormalized scaleNormalized:(BOOL)scaleNormalized NS_SWIFT_NAME(create(orientationNormalized:scaleNormalized:));

/**
 * @param orientationNormalized Enable orientation normalization.
 */
+ (FREAK*)create:(BOOL)orientationNormalized NS_SWIFT_NAME(create(orientationNormalized:));

/**
 */
+ (FREAK*)create NS_SWIFT_NAME(create());


//
//  void cv::xfeatures2d::FREAK::setOrientationNormalized(bool orientationNormalized)
//
- (void)setOrientationNormalized:(BOOL)orientationNormalized NS_SWIFT_NAME(setOrientationNormalized(orientationNormalized:));


//
//  bool cv::xfeatures2d::FREAK::getOrientationNormalized()
//
- (BOOL)getOrientationNormalized NS_SWIFT_NAME(getOrientationNormalized());


//
//  void cv::xfeatures2d::FREAK::setScaleNormalized(bool scaleNormalized)
//
- (void)setScaleNormalized:(BOOL)scaleNormalized NS_SWIFT_NAME(setScaleNormalized(scaleNormalized:));


//
//  bool cv::xfeatures2d::FREAK::getScaleNormalized()
//
- (BOOL)getScaleNormalized NS_SWIFT_NAME(getScaleNormalized());


//
//  void cv::xfeatures2d::FREAK::setPatternScale(double patternScale)
//
- (void)setPatternScale:(double)patternScale NS_SWIFT_NAME(setPatternScale(patternScale:));


//
//  double cv::xfeatures2d::FREAK::getPatternScale()
//
- (double)getPatternScale NS_SWIFT_NAME(getPatternScale());


//
//  void cv::xfeatures2d::FREAK::setNOctaves(int nOctaves)
//
- (void)setNOctaves:(int)nOctaves NS_SWIFT_NAME(setNOctaves(nOctaves:));


//
//  int cv::xfeatures2d::FREAK::getNOctaves()
//
- (int)getNOctaves NS_SWIFT_NAME(getNOctaves());


//
//  String cv::xfeatures2d::FREAK::getDefaultName()
//
- (NSString*)getDefaultName NS_SWIFT_NAME(getDefaultName());



@end

NS_ASSUME_NONNULL_END


