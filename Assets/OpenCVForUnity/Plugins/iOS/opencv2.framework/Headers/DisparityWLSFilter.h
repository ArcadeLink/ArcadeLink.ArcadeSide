//
// This file is auto-generated. Please don't modify it!
//
#pragma once

#ifdef __cplusplus
//#import "opencv.hpp"
#import "opencv2/ximgproc.hpp"
#import "opencv2/ximgproc/disparity_filter.hpp"
#else
#define CV_EXPORTS
#endif

#import <Foundation/Foundation.h>
#import "DisparityFilter.h"

@class Mat;
@class Rect2i;



NS_ASSUME_NONNULL_BEGIN

// C++: class DisparityWLSFilter
/**
 * Disparity map filter based on Weighted Least Squares filter (in form of Fast Global Smoother that
 * is a lot faster than traditional Weighted Least Squares filter implementations) and optional use of
 * left-right-consistency-based confidence to refine the results in half-occlusions and uniform areas.
 *
 * Member of `Ximgproc`
 */
CV_EXPORTS @interface DisparityWLSFilter : DisparityFilter


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::ximgproc::DisparityWLSFilter> nativePtrDisparityWLSFilter;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::ximgproc::DisparityWLSFilter>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::ximgproc::DisparityWLSFilter>)nativePtr;
#endif


#pragma mark - Methods


//
//  double cv::ximgproc::DisparityWLSFilter::getLambda()
//
/**
 * Lambda is a parameter defining the amount of regularization during filtering. Larger values force
 *     filtered disparity map edges to adhere more to source image edges. Typical value is 8000.
 */
- (double)getLambda NS_SWIFT_NAME(getLambda());


//
//  void cv::ximgproc::DisparityWLSFilter::setLambda(double _lambda)
//
/**
 * @see `-getLambda:`
 */
- (void)setLambda:(double)_lambda NS_SWIFT_NAME(setLambda(_lambda:));


//
//  double cv::ximgproc::DisparityWLSFilter::getSigmaColor()
//
/**
 * SigmaColor is a parameter defining how sensitive the filtering process is to source image edges.
 *     Large values can lead to disparity leakage through low-contrast edges. Small values can make the filter too
 *     sensitive to noise and textures in the source image. Typical values range from 0.8 to 2.0.
 */
- (double)getSigmaColor NS_SWIFT_NAME(getSigmaColor());


//
//  void cv::ximgproc::DisparityWLSFilter::setSigmaColor(double _sigma_color)
//
/**
 * @see `-getSigmaColor:`
 */
- (void)setSigmaColor:(double)_sigma_color NS_SWIFT_NAME(setSigmaColor(_sigma_color:));


//
//  int cv::ximgproc::DisparityWLSFilter::getLRCthresh()
//
/**
 * LRCthresh is a threshold of disparity difference used in left-right-consistency check during
 *     confidence map computation. The default value of 24 (1.5 pixels) is virtually always good enough.
 */
- (int)getLRCthresh NS_SWIFT_NAME(getLRCthresh());


//
//  void cv::ximgproc::DisparityWLSFilter::setLRCthresh(int _LRC_thresh)
//
/**
 * @see `-getLRCthresh:`
 */
- (void)setLRCthresh:(int)_LRC_thresh NS_SWIFT_NAME(setLRCthresh(_LRC_thresh:));


//
//  int cv::ximgproc::DisparityWLSFilter::getDepthDiscontinuityRadius()
//
/**
 * DepthDiscontinuityRadius is a parameter used in confidence computation. It defines the size of
 *     low-confidence regions around depth discontinuities.
 */
- (int)getDepthDiscontinuityRadius NS_SWIFT_NAME(getDepthDiscontinuityRadius());


//
//  void cv::ximgproc::DisparityWLSFilter::setDepthDiscontinuityRadius(int _disc_radius)
//
/**
 * @see `-getDepthDiscontinuityRadius:`
 */
- (void)setDepthDiscontinuityRadius:(int)_disc_radius NS_SWIFT_NAME(setDepthDiscontinuityRadius(_disc_radius:));


//
//  Mat cv::ximgproc::DisparityWLSFilter::getConfidenceMap()
//
/**
 * Get the confidence map that was used in the last filter call. It is a CV_32F one-channel image
 *     with values ranging from 0.0 (totally untrusted regions of the raw disparity map) to 255.0 (regions containing
 *     correct disparity values with a high degree of confidence).
 */
- (Mat*)getConfidenceMap NS_SWIFT_NAME(getConfidenceMap());


//
//  Rect cv::ximgproc::DisparityWLSFilter::getROI()
//
/**
 * Get the ROI used in the last filter call
 */
- (Rect2i*)getROI NS_SWIFT_NAME(getROI());



@end

NS_ASSUME_NONNULL_END


