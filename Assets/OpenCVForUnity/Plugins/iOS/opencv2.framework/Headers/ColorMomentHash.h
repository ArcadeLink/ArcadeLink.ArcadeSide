//
// This file is auto-generated. Please don't modify it!
//
#pragma once

#ifdef __cplusplus
//#import "opencv.hpp"
#import "opencv2/img_hash.hpp"
#import "opencv2/img_hash/color_moment_hash.hpp"
#else
#define CV_EXPORTS
#endif

#import <Foundation/Foundation.h>
#import "ImgHashBase.h"





NS_ASSUME_NONNULL_BEGIN

// C++: class ColorMomentHash
/**
 * Image hash based on color moments.
 *
 * See CITE: tang2012perceptual for details.
 *
 * Member of `Img_hash`
 */
CV_EXPORTS @interface ColorMomentHash : ImgHashBase


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::img_hash::ColorMomentHash> nativePtrColorMomentHash;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::img_hash::ColorMomentHash>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::img_hash::ColorMomentHash>)nativePtr;
#endif


#pragma mark - Methods


//
// static Ptr_ColorMomentHash cv::img_hash::ColorMomentHash::create()
//
+ (ColorMomentHash*)create NS_SWIFT_NAME(create());



@end

NS_ASSUME_NONNULL_END


