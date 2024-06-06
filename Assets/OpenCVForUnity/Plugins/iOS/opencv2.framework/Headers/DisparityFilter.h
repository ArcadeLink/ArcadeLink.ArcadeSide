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
#import "Algorithm.h"

@class Mat;
@class Rect2i;



NS_ASSUME_NONNULL_BEGIN

// C++: class DisparityFilter
/**
 * Main interface for all disparity map filters.
 *
 * Member of `Ximgproc`
 */
CV_EXPORTS @interface DisparityFilter : Algorithm


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::ximgproc::DisparityFilter> nativePtrDisparityFilter;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::ximgproc::DisparityFilter>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::ximgproc::DisparityFilter>)nativePtr;
#endif


#pragma mark - Methods


//
//  void cv::ximgproc::DisparityFilter::filter(Mat disparity_map_left, Mat left_view, Mat& filtered_disparity_map, Mat disparity_map_right = Mat(), Rect ROI = Rect(), Mat right_view = Mat())
//
/**
 * Apply filtering to the disparity map.
 *
 * @param disparity_map_left disparity map of the left view, 1 channel, CV_16S type. Implicitly assumes that disparity
 *     values are scaled by 16 (one-pixel disparity corresponds to the value of 16 in the disparity map). Disparity map
 *     can have any resolution, it will be automatically resized to fit left_view resolution.
 *
 * @param left_view left view of the original stereo-pair to guide the filtering process, 8-bit single-channel
 *     or three-channel image.
 *
 * @param filtered_disparity_map output disparity map.
 *
 * @param disparity_map_right optional argument, some implementations might also use the disparity map
 *     of the right view to compute confidence maps, for instance.
 *
 * @param ROI region of the disparity map to filter. Optional, usually it should be set automatically.
 *
 * @param right_view optional argument, some implementations might also use the right view of the original
 *     stereo-pair.
 */
- (void)filter:(Mat*)disparity_map_left left_view:(Mat*)left_view filtered_disparity_map:(Mat*)filtered_disparity_map disparity_map_right:(Mat*)disparity_map_right ROI:(Rect2i*)ROI right_view:(Mat*)right_view NS_SWIFT_NAME(filter(disparity_map_left:left_view:filtered_disparity_map:disparity_map_right:ROI:right_view:));

/**
 * Apply filtering to the disparity map.
 *
 * @param disparity_map_left disparity map of the left view, 1 channel, CV_16S type. Implicitly assumes that disparity
 *     values are scaled by 16 (one-pixel disparity corresponds to the value of 16 in the disparity map). Disparity map
 *     can have any resolution, it will be automatically resized to fit left_view resolution.
 *
 * @param left_view left view of the original stereo-pair to guide the filtering process, 8-bit single-channel
 *     or three-channel image.
 *
 * @param filtered_disparity_map output disparity map.
 *
 * @param disparity_map_right optional argument, some implementations might also use the disparity map
 *     of the right view to compute confidence maps, for instance.
 *
 * @param ROI region of the disparity map to filter. Optional, usually it should be set automatically.
 *
 *     stereo-pair.
 */
- (void)filter:(Mat*)disparity_map_left left_view:(Mat*)left_view filtered_disparity_map:(Mat*)filtered_disparity_map disparity_map_right:(Mat*)disparity_map_right ROI:(Rect2i*)ROI NS_SWIFT_NAME(filter(disparity_map_left:left_view:filtered_disparity_map:disparity_map_right:ROI:));

/**
 * Apply filtering to the disparity map.
 *
 * @param disparity_map_left disparity map of the left view, 1 channel, CV_16S type. Implicitly assumes that disparity
 *     values are scaled by 16 (one-pixel disparity corresponds to the value of 16 in the disparity map). Disparity map
 *     can have any resolution, it will be automatically resized to fit left_view resolution.
 *
 * @param left_view left view of the original stereo-pair to guide the filtering process, 8-bit single-channel
 *     or three-channel image.
 *
 * @param filtered_disparity_map output disparity map.
 *
 * @param disparity_map_right optional argument, some implementations might also use the disparity map
 *     of the right view to compute confidence maps, for instance.
 *
 *
 *     stereo-pair.
 */
- (void)filter:(Mat*)disparity_map_left left_view:(Mat*)left_view filtered_disparity_map:(Mat*)filtered_disparity_map disparity_map_right:(Mat*)disparity_map_right NS_SWIFT_NAME(filter(disparity_map_left:left_view:filtered_disparity_map:disparity_map_right:));

/**
 * Apply filtering to the disparity map.
 *
 * @param disparity_map_left disparity map of the left view, 1 channel, CV_16S type. Implicitly assumes that disparity
 *     values are scaled by 16 (one-pixel disparity corresponds to the value of 16 in the disparity map). Disparity map
 *     can have any resolution, it will be automatically resized to fit left_view resolution.
 *
 * @param left_view left view of the original stereo-pair to guide the filtering process, 8-bit single-channel
 *     or three-channel image.
 *
 * @param filtered_disparity_map output disparity map.
 *
 *     of the right view to compute confidence maps, for instance.
 *
 *
 *     stereo-pair.
 */
- (void)filter:(Mat*)disparity_map_left left_view:(Mat*)left_view filtered_disparity_map:(Mat*)filtered_disparity_map NS_SWIFT_NAME(filter(disparity_map_left:left_view:filtered_disparity_map:));



@end

NS_ASSUME_NONNULL_END


