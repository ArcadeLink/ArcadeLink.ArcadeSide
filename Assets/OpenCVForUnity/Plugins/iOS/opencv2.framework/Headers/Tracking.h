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




// C++: enum FeatureType (cv.detail.CvFeatureParams.FeatureType)
typedef NS_ENUM(int, FeatureType) {
    CvFeatureParams_HAAR NS_SWIFT_NAME(HAAR) = 0,
    CvFeatureParams_LBP NS_SWIFT_NAME(LBP) = 1,
    CvFeatureParams_HOG NS_SWIFT_NAME(HOG) = 2
};



NS_ASSUME_NONNULL_BEGIN

// C++: class Tracking
/**
 * The Tracking module
 *
 * Member classes: `TrackerCSRT`, `TrackerCSRTParams`, `TrackerKCF`, `TrackerKCFParams`
 *
 * Member enums: `MODE`, `FeatureType`
 */
CV_EXPORTS @interface Tracking : NSObject

#pragma mark - Class Constants


@property (class, readonly) int TrackerContribSamplerCSC_MODE_INIT_POS NS_SWIFT_NAME(TrackerContribSamplerCSC_MODE_INIT_POS);
@property (class, readonly) int TrackerContribSamplerCSC_MODE_INIT_NEG NS_SWIFT_NAME(TrackerContribSamplerCSC_MODE_INIT_NEG);
@property (class, readonly) int TrackerContribSamplerCSC_MODE_TRACK_POS NS_SWIFT_NAME(TrackerContribSamplerCSC_MODE_TRACK_POS);
@property (class, readonly) int TrackerContribSamplerCSC_MODE_TRACK_NEG NS_SWIFT_NAME(TrackerContribSamplerCSC_MODE_TRACK_NEG);
@property (class, readonly) int TrackerContribSamplerCSC_MODE_DETECT NS_SWIFT_NAME(TrackerContribSamplerCSC_MODE_DETECT);
@property (class, readonly) int TrackerSamplerCS_MODE_POSITIVE NS_SWIFT_NAME(TrackerSamplerCS_MODE_POSITIVE);
@property (class, readonly) int TrackerSamplerCS_MODE_NEGATIVE NS_SWIFT_NAME(TrackerSamplerCS_MODE_NEGATIVE);
@property (class, readonly) int TrackerSamplerCS_MODE_CLASSIFY NS_SWIFT_NAME(TrackerSamplerCS_MODE_CLASSIFY);

#pragma mark - Methods



@end

NS_ASSUME_NONNULL_END


