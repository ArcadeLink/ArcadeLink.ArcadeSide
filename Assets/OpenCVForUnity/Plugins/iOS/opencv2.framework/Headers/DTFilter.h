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

// C++: class DTFilter
/**
 * Interface for realizations of Domain Transform filter.
 *
 * For more details about this filter see CITE: Gastal11 .
 *
 * Member of `Ximgproc`
 */
CV_EXPORTS @interface DTFilter : Algorithm


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::ximgproc::DTFilter> nativePtrDTFilter;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::ximgproc::DTFilter>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::ximgproc::DTFilter>)nativePtr;
#endif


#pragma mark - Methods


//
//  void cv::ximgproc::DTFilter::filter(Mat src, Mat& dst, int dDepth = -1)
//
/**
 * Produce domain transform filtering operation on source image.
 *
 * @param src filtering image with unsigned 8-bit or floating-point 32-bit depth and up to 4 channels.
 *
 * @param dst destination image.
 *
 * @param dDepth optional depth of the output image. dDepth can be set to -1, which will be equivalent
 *     to src.depth().
 */
- (void)filter:(Mat*)src dst:(Mat*)dst dDepth:(int)dDepth NS_SWIFT_NAME(filter(src:dst:dDepth:));

/**
 * Produce domain transform filtering operation on source image.
 *
 * @param src filtering image with unsigned 8-bit or floating-point 32-bit depth and up to 4 channels.
 *
 * @param dst destination image.
 *
 *     to src.depth().
 */
- (void)filter:(Mat*)src dst:(Mat*)dst NS_SWIFT_NAME(filter(src:dst:));



@end

NS_ASSUME_NONNULL_END


