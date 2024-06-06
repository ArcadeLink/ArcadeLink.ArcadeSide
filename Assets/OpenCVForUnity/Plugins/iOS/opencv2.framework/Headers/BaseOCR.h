//
// This file is auto-generated. Please don't modify it!
//
#pragma once

#ifdef __cplusplus
//#import "opencv.hpp"
#import "opencv2/text.hpp"
#import "opencv2/text/ocr.hpp"
#else
#define CV_EXPORTS
#endif

#import <Foundation/Foundation.h>






NS_ASSUME_NONNULL_BEGIN

// C++: class BaseOCR
/**
 * The BaseOCR module
 *
 * Member of `Text`
 */
CV_EXPORTS @interface BaseOCR : NSObject


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::text::BaseOCR> nativePtr;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::text::BaseOCR>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::text::BaseOCR>)nativePtr;
#endif


#pragma mark - Methods



@end

NS_ASSUME_NONNULL_END


