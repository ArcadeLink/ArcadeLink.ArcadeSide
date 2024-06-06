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

// C++: class FastBilateralSolverFilter
/**
 * Interface for implementations of Fast Bilateral Solver.
 *
 * For more details about this solver see CITE: BarronPoole2016 .
 *
 * Member of `Ximgproc`
 */
CV_EXPORTS @interface FastBilateralSolverFilter : Algorithm


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::ximgproc::FastBilateralSolverFilter> nativePtrFastBilateralSolverFilter;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::ximgproc::FastBilateralSolverFilter>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::ximgproc::FastBilateralSolverFilter>)nativePtr;
#endif


#pragma mark - Methods


//
//  void cv::ximgproc::FastBilateralSolverFilter::filter(Mat src, Mat confidence, Mat& dst)
//
/**
 * Apply smoothing operation to the source image.
 *
 * @param src source image for filtering with unsigned 8-bit or signed 16-bit or floating-point 32-bit depth and up to 3 channels.
 *
 * @param confidence confidence image with unsigned 8-bit or floating-point 32-bit confidence and 1 channel.
 *
 * @param dst destination image.
 *
 *     NOTE: Confidence images with CV_8U depth are expected to in [0, 255] and CV_32F in [0, 1] range.
 */
- (void)filter:(Mat*)src confidence:(Mat*)confidence dst:(Mat*)dst NS_SWIFT_NAME(filter(src:confidence:dst:));



@end

NS_ASSUME_NONNULL_END


