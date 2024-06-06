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
#import "Algorithm.h"





NS_ASSUME_NONNULL_BEGIN

// C++: class ERFilter
/**
 * Base class for 1st and 2nd stages of Neumann and Matas scene text detection algorithm CITE: Neumann12. :
 *
 * Extracts the component tree (if needed) and filter the extremal regions (ER's) by using a given classifier.
 *
 * Member of `Text`
 */
CV_EXPORTS @interface ERFilter : Algorithm


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::text::ERFilter> nativePtrERFilter;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::text::ERFilter>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::text::ERFilter>)nativePtr;
#endif


#pragma mark - Methods



@end

NS_ASSUME_NONNULL_END


