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






NS_ASSUME_NONNULL_BEGIN

// C++: class Params
/**
 * The Params module
 *
 * Member of `Video`
 */
CV_EXPORTS @interface TrackerNanoParams : NSObject


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::TrackerNano::Params> nativePtr;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::TrackerNano::Params>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::TrackerNano::Params>)nativePtr;
#endif


#pragma mark - Methods


//
//   cv::TrackerNano::Params::Params()
//
- (instancetype)init;


    //
    // C++: string cv::TrackerNano::Params::backbone
    //

@property NSString* backbone;

    //
    // C++: string cv::TrackerNano::Params::neckhead
    //

@property NSString* neckhead;

    //
    // C++: int cv::TrackerNano::Params::backend
    //

@property int backend;

    //
    // C++: int cv::TrackerNano::Params::target
    //

@property int target;


@end

NS_ASSUME_NONNULL_END


