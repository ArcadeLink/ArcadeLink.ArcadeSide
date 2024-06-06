//
// This file is auto-generated. Please don't modify it!
//
#pragma once

#ifdef __cplusplus
//#import "opencv.hpp"
#import "opencv2/face.hpp"
#import "opencv2/face/predict_collector.hpp"
#else
#define CV_EXPORTS
#endif

#import <Foundation/Foundation.h>
#import "PredictCollector.h"





NS_ASSUME_NONNULL_BEGIN

// C++: class StandardCollector
/**
 * Default predict collector
 *
 * Trace minimal distance with treshhold checking (that is default behavior for most predict logic)
 *
 * Member of `Face`
 */
CV_EXPORTS @interface StandardCollector : PredictCollector


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::face::StandardCollector> nativePtrStandardCollector;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::face::StandardCollector>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::face::StandardCollector>)nativePtr;
#endif


#pragma mark - Methods


//
//  int cv::face::StandardCollector::getMinLabel()
//
/**
 * Returns label with minimal distance
 */
- (int)getMinLabel NS_SWIFT_NAME(getMinLabel());


//
//  double cv::face::StandardCollector::getMinDist()
//
/**
 * Returns minimal distance value
 */
- (double)getMinDist NS_SWIFT_NAME(getMinDist());


//
//  vector_pair_int_and_double cv::face::StandardCollector::getResults(bool sorted = false)
//
    // Return type 'vector_pair_int_and_double' is not supported, skipping the function


//
// static Ptr_StandardCollector cv::face::StandardCollector::create(double threshold = DBL_MAX)
//
/**
 * Static constructor
 * @param threshold set threshold
 */
+ (StandardCollector*)create:(double)threshold NS_SWIFT_NAME(create(threshold:));

/**
 * Static constructor
 */
+ (StandardCollector*)create NS_SWIFT_NAME(create());



@end

NS_ASSUME_NONNULL_END


