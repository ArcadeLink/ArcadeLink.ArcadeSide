//
// This file is auto-generated. Please don't modify it!
//
#pragma once

#ifdef __cplusplus
//#import "opencv.hpp"
#import "opencv2/bgsegm.hpp"
#else
#define CV_EXPORTS
#endif

#import <Foundation/Foundation.h>






NS_ASSUME_NONNULL_BEGIN

// C++: class BackgroundSubtractorLSBPDesc
/**
 * This is for calculation of the LSBP descriptors.
 *
 * Member of `Bgsegm`
 */
CV_EXPORTS @interface BackgroundSubtractorLSBPDesc : NSObject


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::bgsegm::BackgroundSubtractorLSBPDesc> nativePtr;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::bgsegm::BackgroundSubtractorLSBPDesc>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::bgsegm::BackgroundSubtractorLSBPDesc>)nativePtr;
#endif


#pragma mark - Methods



@end

NS_ASSUME_NONNULL_END


