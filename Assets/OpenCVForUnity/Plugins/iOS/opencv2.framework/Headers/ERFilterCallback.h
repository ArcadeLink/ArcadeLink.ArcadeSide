//
// This file is auto-generated. Please don't modify it!
//
#pragma once

#ifdef __cplusplus
//#import "opencv.hpp"
#import "opencv2/text.hpp"
#import "opencv2/text/erfilter.hpp"
#else
#define CV_EXPORTS
#endif

#import <Foundation/Foundation.h>






NS_ASSUME_NONNULL_BEGIN

// C++: class Callback
/**
 * Callback with the classifier is made a class.
 *
 *     By doing it we hide SVM, Boost etc. Developers can provide their own classifiers to the
 *     ERFilter algorithm.
 *
 * Member of `Text`
 */
CV_EXPORTS @interface ERFilterCallback : NSObject


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::text::ERFilter::Callback> nativePtr;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::text::ERFilter::Callback>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::text::ERFilter::Callback>)nativePtr;
#endif


#pragma mark - Methods



@end

NS_ASSUME_NONNULL_END


