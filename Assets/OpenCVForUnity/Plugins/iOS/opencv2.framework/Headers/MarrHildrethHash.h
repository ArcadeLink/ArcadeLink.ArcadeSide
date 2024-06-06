//
// This file is auto-generated. Please don't modify it!
//
#pragma once

#ifdef __cplusplus
//#import "opencv.hpp"
#import "opencv2/img_hash.hpp"
#import "opencv2/img_hash/marr_hildreth_hash.hpp"
#else
#define CV_EXPORTS
#endif

#import <Foundation/Foundation.h>
#import "ImgHashBase.h"





NS_ASSUME_NONNULL_BEGIN

// C++: class MarrHildrethHash
/**
 * Marr-Hildreth Operator Based Hash, slowest but more discriminative.
 *
 * See CITE: zauner2010implementation for details.
 *
 * Member of `Img_hash`
 */
CV_EXPORTS @interface MarrHildrethHash : ImgHashBase


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::img_hash::MarrHildrethHash> nativePtrMarrHildrethHash;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::img_hash::MarrHildrethHash>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::img_hash::MarrHildrethHash>)nativePtr;
#endif


#pragma mark - Methods


//
//  float cv::img_hash::MarrHildrethHash::getAlpha()
//
/**
 * self explain
 */
- (float)getAlpha NS_SWIFT_NAME(getAlpha());


//
//  float cv::img_hash::MarrHildrethHash::getScale()
//
/**
 * self explain
 */
- (float)getScale NS_SWIFT_NAME(getScale());


//
//  void cv::img_hash::MarrHildrethHash::setKernelParam(float alpha, float scale)
//
/**
 * Set Mh kernel parameters
 * @param alpha int scale factor for marr wavelet (default=2).
 * @param scale int level of scale factor (default = 1)
 */
- (void)setKernelParam:(float)alpha scale:(float)scale NS_SWIFT_NAME(setKernelParam(alpha:scale:));


//
// static Ptr_MarrHildrethHash cv::img_hash::MarrHildrethHash::create(float alpha = 2.0f, float scale = 1.0f)
//
/**
 * @param alpha int scale factor for marr wavelet (default=2).
 * @param scale int level of scale factor (default = 1)
 */
+ (MarrHildrethHash*)create:(float)alpha scale:(float)scale NS_SWIFT_NAME(create(alpha:scale:));

/**
 * @param alpha int scale factor for marr wavelet (default=2).
 */
+ (MarrHildrethHash*)create:(float)alpha NS_SWIFT_NAME(create(alpha:));

/**
 */
+ (MarrHildrethHash*)create NS_SWIFT_NAME(create());



@end

NS_ASSUME_NONNULL_END


