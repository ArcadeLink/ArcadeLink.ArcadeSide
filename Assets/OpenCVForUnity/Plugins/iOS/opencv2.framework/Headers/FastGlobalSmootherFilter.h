//
// This file is auto-generated. Please don't modify it!
//
#pragma once

#ifdef __cplusplus
//#import "opencv.hpp"
#import "opencv2/ximgproc.hpp"
#import "opencv2/ximgproc/edge_filter.hpp"
#else
#define CV_EXPORTS
#endif

#import <Foundation/Foundation.h>
#import "Algorithm.h"

@class Mat;



NS_ASSUME_NONNULL_BEGIN

// C++: class FastGlobalSmootherFilter
/**
 * Interface for implementations of Fast Global Smoother filter.
 *
 * For more details about this filter see CITE: Min2014 and CITE: Farbman2008 .
 *
 * Member of `Ximgproc`
 */
CV_EXPORTS @interface FastGlobalSmootherFilter : Algorithm


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::ximgproc::FastGlobalSmootherFilter> nativePtrFastGlobalSmootherFilter;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::ximgproc::FastGlobalSmootherFilter>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::ximgproc::FastGlobalSmootherFilter>)nativePtr;
#endif


#pragma mark - Methods


//
//  void cv::ximgproc::FastGlobalSmootherFilter::filter(Mat src, Mat& dst)
//
/**
 * Apply smoothing operation to the source image.
 *
 * @param src source image for filtering with unsigned 8-bit or signed 16-bit or floating-point 32-bit depth and up to 4 channels.
 *
 * @param dst destination image.
 */
- (void)filter:(Mat*)src dst:(Mat*)dst NS_SWIFT_NAME(filter(src:dst:));



@end

NS_ASSUME_NONNULL_END


