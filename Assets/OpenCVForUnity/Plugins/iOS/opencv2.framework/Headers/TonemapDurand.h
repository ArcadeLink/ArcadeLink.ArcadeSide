//
// This file is auto-generated. Please don't modify it!
//
#pragma once

#ifdef __cplusplus
//#import "opencv.hpp"
#import "opencv2/xphoto.hpp"
#import "opencv2/xphoto/tonemap.hpp"
#else
#define CV_EXPORTS
#endif

#import <Foundation/Foundation.h>
#import "Tonemap.h"





NS_ASSUME_NONNULL_BEGIN

// C++: class TonemapDurand
/**
 * This algorithm decomposes image into two layers: base layer and detail layer using bilateral filter
 * and compresses contrast of the base layer thus preserving all the details.
 *
 * This implementation uses regular bilateral filter from OpenCV.
 *
 * Saturation enhancement is possible as in cv::TonemapDrago.
 *
 * For more information see CITE: DD02 .
 *
 * Member of `Xphoto`
 */
CV_EXPORTS @interface TonemapDurand : Tonemap


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::xphoto::TonemapDurand> nativePtrTonemapDurand;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::xphoto::TonemapDurand>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::xphoto::TonemapDurand>)nativePtr;
#endif


#pragma mark - Methods


//
//  float cv::xphoto::TonemapDurand::getSaturation()
//
- (float)getSaturation NS_SWIFT_NAME(getSaturation());


//
//  void cv::xphoto::TonemapDurand::setSaturation(float saturation)
//
- (void)setSaturation:(float)saturation NS_SWIFT_NAME(setSaturation(saturation:));


//
//  float cv::xphoto::TonemapDurand::getContrast()
//
- (float)getContrast NS_SWIFT_NAME(getContrast());


//
//  void cv::xphoto::TonemapDurand::setContrast(float contrast)
//
- (void)setContrast:(float)contrast NS_SWIFT_NAME(setContrast(contrast:));


//
//  float cv::xphoto::TonemapDurand::getSigmaSpace()
//
- (float)getSigmaSpace NS_SWIFT_NAME(getSigmaSpace());


//
//  void cv::xphoto::TonemapDurand::setSigmaSpace(float sigma_space)
//
- (void)setSigmaSpace:(float)sigma_space NS_SWIFT_NAME(setSigmaSpace(sigma_space:));


//
//  float cv::xphoto::TonemapDurand::getSigmaColor()
//
- (float)getSigmaColor NS_SWIFT_NAME(getSigmaColor());


//
//  void cv::xphoto::TonemapDurand::setSigmaColor(float sigma_color)
//
- (void)setSigmaColor:(float)sigma_color NS_SWIFT_NAME(setSigmaColor(sigma_color:));



@end

NS_ASSUME_NONNULL_END


