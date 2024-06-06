//
// This file is auto-generated. Please don't modify it!
//
#pragma once

#ifdef __cplusplus
//#import "opencv.hpp"
#import "opencv2/ximgproc.hpp"
#import "opencv2/ximgproc/sparse_match_interpolator.hpp"
#else
#define CV_EXPORTS
#endif

#import <Foundation/Foundation.h>
#import "Algorithm.h"

@class Mat;



NS_ASSUME_NONNULL_BEGIN

// C++: class SparseMatchInterpolator
/**
 * Main interface for all filters, that take sparse matches as an
 * input and produce a dense per-pixel matching (optical flow) as an output.
 *
 * Member of `Ximgproc`
 */
CV_EXPORTS @interface SparseMatchInterpolator : Algorithm


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::ximgproc::SparseMatchInterpolator> nativePtrSparseMatchInterpolator;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::ximgproc::SparseMatchInterpolator>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::ximgproc::SparseMatchInterpolator>)nativePtr;
#endif


#pragma mark - Methods


//
//  void cv::ximgproc::SparseMatchInterpolator::interpolate(Mat from_image, Mat from_points, Mat to_image, Mat to_points, Mat& dense_flow)
//
/**
 * Interpolate input sparse matches.
 *
 * @param from_image first of the two matched images, 8-bit single-channel or three-channel.
 *
 * @param from_points points of the from_image for which there are correspondences in the
 *     to_image (Point2f vector or Mat of depth CV_32F)
 *
 * @param to_image second of the two matched images, 8-bit single-channel or three-channel.
 *
 * @param to_points points in the to_image corresponding to from_points
 *     (Point2f vector or Mat of depth CV_32F)
 *
 * @param dense_flow output dense matching (two-channel CV_32F image)
 */
- (void)interpolate:(Mat*)from_image from_points:(Mat*)from_points to_image:(Mat*)to_image to_points:(Mat*)to_points dense_flow:(Mat*)dense_flow NS_SWIFT_NAME(interpolate(from_image:from_points:to_image:to_points:dense_flow:));



@end

NS_ASSUME_NONNULL_END


