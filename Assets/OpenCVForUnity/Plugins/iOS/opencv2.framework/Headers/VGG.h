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

// C++: class VGG
/**
 * Class implementing VGG (Oxford Visual Geometry Group) descriptor trained end to end
 * using "Descriptor Learning Using Convex Optimisation" (DLCO) aparatus described in CITE: Simonyan14.
 *
 * desc type of descriptor to use, VGG::VGG_120 is default (120 dimensions float)
 * Available types are VGG::VGG_120, VGG::VGG_80, VGG::VGG_64, VGG::VGG_48
 * isigma gaussian kernel value for image blur (default is 1.4f)
 * img_normalize use image sample intensity normalization (enabled by default)
 * use_orientation sample patterns using keypoints orientation, enabled by default
 * scale_factor adjust the sampling window of detected keypoints to 64.0f (VGG sampling window)
 * 6.25f is default and fits for KAZE, SURF detected keypoints window ratio
 * 6.75f should be the scale for SIFT detected keypoints window ratio
 * 5.00f should be the scale for AKAZE, MSD, AGAST, FAST, BRISK keypoints window ratio
 * 0.75f should be the scale for ORB keypoints ratio
 *
 * dsc_normalize clamp descriptors to 255 and convert to uchar CV_8UC1 (disabled by default)
 *
 * Member of `Xfeatures2d`
 */
CV_EXPORTS @interface VGG : Feature2D


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::xfeatures2d::VGG> nativePtrVGG;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::xfeatures2d::VGG>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::xfeatures2d::VGG>)nativePtr;
#endif


#pragma mark - Methods


//
// static Ptr_VGG cv::xfeatures2d::VGG::create(int desc = VGG::VGG_120, float isigma = 1.4f, bool img_normalize = true, bool use_scale_orientation = true, float scale_factor = 6.25f, bool dsc_normalize = false)
//
+ (VGG*)create:(int)desc isigma:(float)isigma img_normalize:(BOOL)img_normalize use_scale_orientation:(BOOL)use_scale_orientation scale_factor:(float)scale_factor dsc_normalize:(BOOL)dsc_normalize NS_SWIFT_NAME(create(desc:isigma:img_normalize:use_scale_orientation:scale_factor:dsc_normalize:));

+ (VGG*)create:(int)desc isigma:(float)isigma img_normalize:(BOOL)img_normalize use_scale_orientation:(BOOL)use_scale_orientation scale_factor:(float)scale_factor NS_SWIFT_NAME(create(desc:isigma:img_normalize:use_scale_orientation:scale_factor:));

+ (VGG*)create:(int)desc isigma:(float)isigma img_normalize:(BOOL)img_normalize use_scale_orientation:(BOOL)use_scale_orientation NS_SWIFT_NAME(create(desc:isigma:img_normalize:use_scale_orientation:));

+ (VGG*)create:(int)desc isigma:(float)isigma img_normalize:(BOOL)img_normalize NS_SWIFT_NAME(create(desc:isigma:img_normalize:));

+ (VGG*)create:(int)desc isigma:(float)isigma NS_SWIFT_NAME(create(desc:isigma:));

+ (VGG*)create:(int)desc NS_SWIFT_NAME(create(desc:));

+ (VGG*)create NS_SWIFT_NAME(create());


//
//  String cv::xfeatures2d::VGG::getDefaultName()
//
- (NSString*)getDefaultName NS_SWIFT_NAME(getDefaultName());


//
//  void cv::xfeatures2d::VGG::setSigma(float isigma)
//
- (void)setSigma:(float)isigma NS_SWIFT_NAME(setSigma(isigma:));


//
//  float cv::xfeatures2d::VGG::getSigma()
//
- (float)getSigma NS_SWIFT_NAME(getSigma());


//
//  void cv::xfeatures2d::VGG::setUseNormalizeImage(bool img_normalize)
//
- (void)setUseNormalizeImage:(BOOL)img_normalize NS_SWIFT_NAME(setUseNormalizeImage(img_normalize:));


//
//  bool cv::xfeatures2d::VGG::getUseNormalizeImage()
//
- (BOOL)getUseNormalizeImage NS_SWIFT_NAME(getUseNormalizeImage());


//
//  void cv::xfeatures2d::VGG::setUseScaleOrientation(bool use_scale_orientation)
//
- (void)setUseScaleOrientation:(BOOL)use_scale_orientation NS_SWIFT_NAME(setUseScaleOrientation(use_scale_orientation:));


//
//  bool cv::xfeatures2d::VGG::getUseScaleOrientation()
//
- (BOOL)getUseScaleOrientation NS_SWIFT_NAME(getUseScaleOrientation());


//
//  void cv::xfeatures2d::VGG::setScaleFactor(float scale_factor)
//
- (void)setScaleFactor:(float)scale_factor NS_SWIFT_NAME(setScaleFactor(scale_factor:));


//
//  float cv::xfeatures2d::VGG::getScaleFactor()
//
- (float)getScaleFactor NS_SWIFT_NAME(getScaleFactor());


//
//  void cv::xfeatures2d::VGG::setUseNormalizeDescriptor(bool dsc_normalize)
//
- (void)setUseNormalizeDescriptor:(BOOL)dsc_normalize NS_SWIFT_NAME(setUseNormalizeDescriptor(dsc_normalize:));


//
//  bool cv::xfeatures2d::VGG::getUseNormalizeDescriptor()
//
- (BOOL)getUseNormalizeDescriptor NS_SWIFT_NAME(getUseNormalizeDescriptor());



@end

NS_ASSUME_NONNULL_END


