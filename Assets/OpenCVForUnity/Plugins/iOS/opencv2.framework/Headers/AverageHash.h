//
// This file is auto-generated. Please don't modify it!
//
#pragma once

#ifdef __cplusplus
//#import "opencv.hpp"
#import "opencv2/img_hash.hpp"
#import "opencv2/img_hash/average_hash.hpp"
#else
#define CV_EXPORTS
#endif

#import <Foundation/Foundation.h>
#import "ImgHashBase.h"





NS_ASSUME_NONNULL_BEGIN

// C++: class AverageHash
/**
 * Computes average hash value of the input image
 *
 * This is a fast image hashing algorithm, but only work on simple case. For more details, please
 * refer to CITE: lookslikeit
 *
 * Member of `Img_hash`
 */
CV_EXPORTS @interface AverageHash : ImgHashBase


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::img_hash::AverageHash> nativePtrAverageHash;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::img_hash::AverageHash>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::img_hash::AverageHash>)nativePtr;
#endif


#pragma mark - Methods


//
// static Ptr_AverageHash cv::img_hash::AverageHash::create()
//
+ (AverageHash*)create NS_SWIFT_NAME(create());



@end

NS_ASSUME_NONNULL_END


