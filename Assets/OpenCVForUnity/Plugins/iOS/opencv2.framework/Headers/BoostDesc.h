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

// C++: class BoostDesc
/**
 * Class implementing BoostDesc (Learning Image Descriptors with Boosting), described in
 * CITE: Trzcinski13a and CITE: Trzcinski13b.
 *
 * desc type of descriptor to use, BoostDesc::BINBOOST_256 is default (256 bit long dimension)
 * Available types are: BoostDesc::BGM, BoostDesc::BGM_HARD, BoostDesc::BGM_BILINEAR, BoostDesc::LBGM,
 * BoostDesc::BINBOOST_64, BoostDesc::BINBOOST_128, BoostDesc::BINBOOST_256
 * use_orientation sample patterns using keypoints orientation, enabled by default
 * scale_factor adjust the sampling window of detected keypoints
 * 6.25f is default and fits for KAZE, SURF detected keypoints window ratio
 * 6.75f should be the scale for SIFT detected keypoints window ratio
 * 5.00f should be the scale for AKAZE, MSD, AGAST, FAST, BRISK keypoints window ratio
 * 0.75f should be the scale for ORB keypoints ratio
 * 1.50f was the default in original implementation
 *
 * NOTE: BGM is the base descriptor where each binary dimension is computed as the output of a single weak learner.
 * BGM_HARD and BGM_BILINEAR refers to same BGM but use different type of gradient binning. In the BGM_HARD that
 * use ASSIGN_HARD binning type the gradient is assigned to the nearest orientation bin. In the BGM_BILINEAR that use
 * ASSIGN_BILINEAR binning type the gradient is assigned to the two neighbouring bins. In the BGM and all other modes that use
 * ASSIGN_SOFT binning type the gradient is assigned to 8 nearest bins according to the cosine value between the gradient
 * angle and the bin center. LBGM (alias FP-Boost) is the floating point extension where each dimension is computed
 * as a linear combination of the weak learner responses. BINBOOST and subvariants are the binary extensions of LBGM
 * where each bit is computed as a thresholded linear combination of a set of weak learners.
 * BoostDesc header files (boostdesc_*.i) was exported from original binaries with export-boostdesc.py script from
 * samples subfolder.
 *
 * Member of `Xfeatures2d`
 */
CV_EXPORTS @interface BoostDesc : Feature2D


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::xfeatures2d::BoostDesc> nativePtrBoostDesc;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::xfeatures2d::BoostDesc>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::xfeatures2d::BoostDesc>)nativePtr;
#endif


#pragma mark - Methods


//
// static Ptr_BoostDesc cv::xfeatures2d::BoostDesc::create(int desc = BoostDesc::BINBOOST_256, bool use_scale_orientation = true, float scale_factor = 6.25f)
//
+ (BoostDesc*)create:(int)desc use_scale_orientation:(BOOL)use_scale_orientation scale_factor:(float)scale_factor NS_SWIFT_NAME(create(desc:use_scale_orientation:scale_factor:));

+ (BoostDesc*)create:(int)desc use_scale_orientation:(BOOL)use_scale_orientation NS_SWIFT_NAME(create(desc:use_scale_orientation:));

+ (BoostDesc*)create:(int)desc NS_SWIFT_NAME(create(desc:));

+ (BoostDesc*)create NS_SWIFT_NAME(create());


//
//  String cv::xfeatures2d::BoostDesc::getDefaultName()
//
- (NSString*)getDefaultName NS_SWIFT_NAME(getDefaultName());


//
//  void cv::xfeatures2d::BoostDesc::setUseScaleOrientation(bool use_scale_orientation)
//
- (void)setUseScaleOrientation:(BOOL)use_scale_orientation NS_SWIFT_NAME(setUseScaleOrientation(use_scale_orientation:));


//
//  bool cv::xfeatures2d::BoostDesc::getUseScaleOrientation()
//
- (BOOL)getUseScaleOrientation NS_SWIFT_NAME(getUseScaleOrientation());


//
//  void cv::xfeatures2d::BoostDesc::setScaleFactor(float scale_factor)
//
- (void)setScaleFactor:(float)scale_factor NS_SWIFT_NAME(setScaleFactor(scale_factor:));


//
//  float cv::xfeatures2d::BoostDesc::getScaleFactor()
//
- (float)getScaleFactor NS_SWIFT_NAME(getScaleFactor());



@end

NS_ASSUME_NONNULL_END


