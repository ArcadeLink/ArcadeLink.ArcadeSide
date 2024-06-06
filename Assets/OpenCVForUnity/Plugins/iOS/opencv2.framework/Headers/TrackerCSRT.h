//
// This file is auto-generated. Please don't modify it!
//
#pragma once

#ifdef __cplusplus
//#import "opencv.hpp"
#import "opencv2/tracking.hpp"
#else
#define CV_EXPORTS
#endif

#import <Foundation/Foundation.h>
#import "Tracker.h"

@class Mat;
@class TrackerCSRTParams;



NS_ASSUME_NONNULL_BEGIN

// C++: class TrackerCSRT
/**
 * the CSRT tracker
 *
 * The implementation is based on CITE: Lukezic_IJCV2018 Discriminative Correlation Filter with Channel and Spatial Reliability
 *
 * Member of `Tracking`
 */
CV_EXPORTS @interface TrackerCSRT : Tracker


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::TrackerCSRT> nativePtrTrackerCSRT;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::TrackerCSRT>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::TrackerCSRT>)nativePtr;
#endif


#pragma mark - Methods


//
// static Ptr_TrackerCSRT cv::TrackerCSRT::create(TrackerCSRT_Params parameters = TrackerCSRT::Params())
//
/**
 * Create CSRT tracker instance
 * @param parameters CSRT parameters TrackerCSRT::Params
 */
+ (TrackerCSRT*)create:(TrackerCSRTParams*)parameters NS_SWIFT_NAME(create(parameters:));

/**
 * Create CSRT tracker instance
 */
+ (TrackerCSRT*)create NS_SWIFT_NAME(create());


//
//  void cv::TrackerCSRT::setInitialMask(Mat mask)
//
- (void)setInitialMask:(Mat*)mask NS_SWIFT_NAME(setInitialMask(mask:));



@end

NS_ASSUME_NONNULL_END


