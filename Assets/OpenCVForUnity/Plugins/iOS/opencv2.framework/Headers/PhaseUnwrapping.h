//
// This file is auto-generated. Please don't modify it!
//
#pragma once

#ifdef __cplusplus
//#import "opencv.hpp"
#import "opencv2/phase_unwrapping.hpp"
#import "opencv2/phase_unwrapping/phase_unwrapping.hpp"
#else
#define CV_EXPORTS
#endif

#import <Foundation/Foundation.h>
#import "Algorithm.h"

@class Mat;



NS_ASSUME_NONNULL_BEGIN

// C++: class PhaseUnwrapping
/**
 * Abstract base class for phase unwrapping.
 *
 * Member of `Phase_unwrapping`
 */
CV_EXPORTS @interface PhaseUnwrapping : Algorithm


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::phase_unwrapping::PhaseUnwrapping> nativePtrPhaseUnwrapping;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::phase_unwrapping::PhaseUnwrapping>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::phase_unwrapping::PhaseUnwrapping>)nativePtr;
#endif


#pragma mark - Methods


//
//  void cv::phase_unwrapping::PhaseUnwrapping::unwrapPhaseMap(Mat wrappedPhaseMap, Mat& unwrappedPhaseMap, Mat shadowMask = Mat())
//
/**
 * Unwraps a 2D phase map.
 *
 * @param wrappedPhaseMap The wrapped phase map of type CV_32FC1 that needs to be unwrapped.
 * @param unwrappedPhaseMap The unwrapped phase map.
 * @param shadowMask Optional CV_8UC1 mask image used when some pixels do not hold any phase information in the wrapped phase map.
 */
- (void)unwrapPhaseMap:(Mat*)wrappedPhaseMap unwrappedPhaseMap:(Mat*)unwrappedPhaseMap shadowMask:(Mat*)shadowMask NS_SWIFT_NAME(unwrapPhaseMap(wrappedPhaseMap:unwrappedPhaseMap:shadowMask:));

/**
 * Unwraps a 2D phase map.
 *
 * @param wrappedPhaseMap The wrapped phase map of type CV_32FC1 that needs to be unwrapped.
 * @param unwrappedPhaseMap The unwrapped phase map.
 */
- (void)unwrapPhaseMap:(Mat*)wrappedPhaseMap unwrappedPhaseMap:(Mat*)unwrappedPhaseMap NS_SWIFT_NAME(unwrapPhaseMap(wrappedPhaseMap:unwrappedPhaseMap:));



@end

NS_ASSUME_NONNULL_END


