//
// This file is auto-generated. Please don't modify it!
//
#pragma once

#ifdef __cplusplus
//#import "opencv.hpp"
#import "opencv2/img_hash.hpp"
#import "opencv2/img_hash/phash.hpp"
#else
#define CV_EXPORTS
#endif

#import <Foundation/Foundation.h>
#import "ImgHashBase.h"





NS_ASSUME_NONNULL_BEGIN

// C++: class PHash
/**
 * pHash
 *
 * Slower than average_hash, but tolerant of minor modifications
 *
 * This algorithm can combat more variation than averageHash, for more details please refer to CITE: lookslikeit
 *
 * Member of `Img_hash`
 */
CV_EXPORTS @interface PHash : ImgHashBase


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::img_hash::PHash> nativePtrPHash;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::img_hash::PHash>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::img_hash::PHash>)nativePtr;
#endif


#pragma mark - Methods


//
// static Ptr_PHash cv::img_hash::PHash::create()
//
+ (PHash*)create NS_SWIFT_NAME(create());



@end

NS_ASSUME_NONNULL_END


