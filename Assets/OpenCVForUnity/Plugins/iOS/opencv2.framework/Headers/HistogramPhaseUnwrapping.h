//
// This file is auto-generated. Please don't modify it!
//
#pragma once

#ifdef __cplusplus
//#import "opencv.hpp"
#import "opencv2/phase_unwrapping.hpp"
#import "phase_unwrapping/histogramphaseunwrapping.hpp"
#import "opencv2/phase_unwrapping/histogramphaseunwrapping.hpp"
#else
#define CV_EXPORTS
#endif

#import <Foundation/Foundation.h>
#import "PhaseUnwrapping.h"

@class HistogramPhaseUnwrappingParams;
@class Mat;



NS_ASSUME_NONNULL_BEGIN

// C++: class HistogramPhaseUnwrapping
/**
 * Class implementing two-dimensional phase unwrapping based on CITE: histogramUnwrapping
 * This algorithm belongs to the quality-guided phase unwrapping methods.
 * First, it computes a reliability map from second differences between a pixel and its eight neighbours.
 * Reliability values lie between 0 and 16*pi*pi. Then, this reliability map is used to compute
 * the reliabilities of "edges". An edge is an entity defined by two pixels that are connected
 * horizontally or vertically. Its reliability is found by adding the the reliabilities of the
 * two pixels connected through it. Edges are sorted in a histogram based on their reliability values.
 * This histogram is then used to unwrap pixels, starting from the highest quality pixel.
 *
 * The wrapped phase map and the unwrapped result are stored in CV_32FC1 Mat.
 *
 * Member of `Phase_unwrapping`
 */
CV_EXPORTS @interface HistogramPhaseUnwrapping : PhaseUnwrapping


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::phase_unwrapping::HistogramPhaseUnwrapping> nativePtrHistogramPhaseUnwrapping;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::phase_unwrapping::HistogramPhaseUnwrapping>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::phase_unwrapping::HistogramPhaseUnwrapping>)nativePtr;
#endif


#pragma mark - Methods


//
// static Ptr_HistogramPhaseUnwrapping cv::phase_unwrapping::HistogramPhaseUnwrapping::create(HistogramPhaseUnwrapping_Params parameters = HistogramPhaseUnwrapping::Params())
//
/**
 * Constructor
 *
 * @param parameters HistogramPhaseUnwrapping parameters HistogramPhaseUnwrapping::Params: width,height of the phase map and histogram characteristics.
 */
+ (HistogramPhaseUnwrapping*)create:(HistogramPhaseUnwrappingParams*)parameters NS_SWIFT_NAME(create(parameters:));

/**
 * Constructor
 *
 */
+ (HistogramPhaseUnwrapping*)create NS_SWIFT_NAME(create());


//
//  void cv::phase_unwrapping::HistogramPhaseUnwrapping::getInverseReliabilityMap(Mat& reliabilityMap)
//
/**
 * Get the reliability map computed from the wrapped phase map.
 *
 * @param reliabilityMap Image where the reliability map is stored.
 */
- (void)getInverseReliabilityMap:(Mat*)reliabilityMap NS_SWIFT_NAME(getInverseReliabilityMap(reliabilityMap:));



@end

NS_ASSUME_NONNULL_END


