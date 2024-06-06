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

@class TrackerKCFParams;


// C++: enum MODE (cv.TrackerKCF.MODE)
typedef NS_ENUM(int, MODE) {
    TrackerKCF_GRAY NS_SWIFT_NAME(GRAY) = (1 << 0),
    TrackerKCF_CN NS_SWIFT_NAME(CN) = (1 << 1),
    TrackerKCF_CUSTOM NS_SWIFT_NAME(CUSTOM) = (1 << 2)
};



NS_ASSUME_NONNULL_BEGIN

// C++: class TrackerKCF
/**
 * the KCF (Kernelized Correlation Filter) tracker
 *
 * KCF is a novel tracking framework that utilizes properties of circulant matrix to enhance the processing speed.
 * This tracking method is an implementation of CITE: KCF_ECCV which is extended to KCF with color-names features (CITE: KCF_CN).
 * The original paper of KCF is available at <http://www.robots.ox.ac.uk/~joao/publications/henriques_tpami2015.pdf>
 * as well as the matlab implementation. For more information about KCF with color-names features, please refer to
 * <http://www.cvl.isy.liu.se/research/objrec/visualtracking/colvistrack/index.html>.
 *
 * Member of `Tracking`
 */
CV_EXPORTS @interface TrackerKCF : Tracker


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::TrackerKCF> nativePtrTrackerKCF;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::TrackerKCF>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::TrackerKCF>)nativePtr;
#endif


#pragma mark - Methods


//
// static Ptr_TrackerKCF cv::TrackerKCF::create(TrackerKCF_Params parameters = TrackerKCF::Params())
//
/**
 * Create KCF tracker instance
 * @param parameters KCF parameters TrackerKCF::Params
 */
+ (TrackerKCF*)create:(TrackerKCFParams*)parameters NS_SWIFT_NAME(create(parameters:));

/**
 * Create KCF tracker instance
 */
+ (TrackerKCF*)create NS_SWIFT_NAME(create());



@end

NS_ASSUME_NONNULL_END


