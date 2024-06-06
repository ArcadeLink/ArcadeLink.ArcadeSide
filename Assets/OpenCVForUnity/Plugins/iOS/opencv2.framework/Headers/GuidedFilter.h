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

// C++: class GuidedFilter
/**
 * Interface for realizations of Guided Filter.
 *
 * For more details about this filter see CITE: Kaiming10 .
 *
 * Member of `Ximgproc`
 */
CV_EXPORTS @interface GuidedFilter : Algorithm


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::ximgproc::GuidedFilter> nativePtrGuidedFilter;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::ximgproc::GuidedFilter>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::ximgproc::GuidedFilter>)nativePtr;
#endif


#pragma mark - Methods


//
//  void cv::ximgproc::GuidedFilter::filter(Mat src, Mat& dst, int dDepth = -1)
//
/**
 * Apply Guided Filter to the filtering image.
 *
 * @param src filtering image with any numbers of channels.
 *
 * @param dst output image.
 *
 * @param dDepth optional depth of the output image. dDepth can be set to -1, which will be equivalent
 *     to src.depth().
 */
- (void)filter:(Mat*)src dst:(Mat*)dst dDepth:(int)dDepth NS_SWIFT_NAME(filter(src:dst:dDepth:));

/**
 * Apply Guided Filter to the filtering image.
 *
 * @param src filtering image with any numbers of channels.
 *
 * @param dst output image.
 *
 *     to src.depth().
 */
- (void)filter:(Mat*)src dst:(Mat*)dst NS_SWIFT_NAME(filter(src:dst:));



@end

NS_ASSUME_NONNULL_END


