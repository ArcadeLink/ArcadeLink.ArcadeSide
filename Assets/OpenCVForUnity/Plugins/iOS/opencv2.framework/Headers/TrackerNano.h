//
// This file is auto-generated. Please don't modify it!
//
#pragma once

#ifdef __cplusplus
//#import "opencv.hpp"
#import "opencv2/video.hpp"
#import "opencv2/video/tracking.hpp"
#else
#define CV_EXPORTS
#endif

#import <Foundation/Foundation.h>
#import "Tracker.h"

@class TrackerNanoParams;



NS_ASSUME_NONNULL_BEGIN

// C++: class TrackerNano
/**
 * the Nano tracker is a super lightweight dnn-based general object tracking.
 *
 * Nano tracker is much faster and extremely lightweight due to special model structure, the whole model size is about 1.9 MB.
 * Nano tracker needs two models: one for feature extraction (backbone) and the another for localization (neckhead).
 * Model download link: https://github.com/HonglinChu/SiamTrackers/tree/master/NanoTrack/models/nanotrackv2
 * Original repo is here: https://github.com/HonglinChu/NanoTrack
 * Author: HongLinChu, 1628464345@qq.com
 *
 * Member of `Video`
 */
CV_EXPORTS @interface TrackerNano : Tracker


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::TrackerNano> nativePtrTrackerNano;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::TrackerNano>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::TrackerNano>)nativePtr;
#endif


#pragma mark - Methods


//
// static Ptr_TrackerNano cv::TrackerNano::create(TrackerNano_Params parameters = TrackerNano::Params())
//
/**
 * Constructor
 * @param parameters NanoTrack parameters TrackerNano::Params
 */
+ (TrackerNano*)create:(TrackerNanoParams*)parameters NS_SWIFT_NAME(create(parameters:));

/**
 * Constructor
 */
+ (TrackerNano*)create NS_SWIFT_NAME(create());


//
//  float cv::TrackerNano::getTrackingScore()
//
/**
 * Return tracking score
 */
- (float)getTrackingScore NS_SWIFT_NAME(getTrackingScore());



@end

NS_ASSUME_NONNULL_END


