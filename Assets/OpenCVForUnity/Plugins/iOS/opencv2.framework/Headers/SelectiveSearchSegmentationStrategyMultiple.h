//
// This file is auto-generated. Please don't modify it!
//
#pragma once

#ifdef __cplusplus
//#import "opencv.hpp"
#import "opencv2/ximgproc.hpp"
#import "opencv2/ximgproc/segmentation.hpp"
#else
#define CV_EXPORTS
#endif

#import <Foundation/Foundation.h>
#import "SelectiveSearchSegmentationStrategy.h"

@class SelectiveSearchSegmentationStrategy;



NS_ASSUME_NONNULL_BEGIN

// C++: class SelectiveSearchSegmentationStrategyMultiple
/**
 * Regroup multiple strategies for the selective search segmentation algorithm
 *
 * Member of `Ximgproc`
 */
CV_EXPORTS @interface SelectiveSearchSegmentationStrategyMultiple : SelectiveSearchSegmentationStrategy


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::ximgproc::segmentation::SelectiveSearchSegmentationStrategyMultiple> nativePtrSelectiveSearchSegmentationStrategyMultiple;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::ximgproc::segmentation::SelectiveSearchSegmentationStrategyMultiple>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::ximgproc::segmentation::SelectiveSearchSegmentationStrategyMultiple>)nativePtr;
#endif


#pragma mark - Methods


//
//  void cv::ximgproc::segmentation::SelectiveSearchSegmentationStrategyMultiple::addStrategy(Ptr_SelectiveSearchSegmentationStrategy g, float weight)
//
/**
 * Add a new sub-strategy
 * @param g The strategy
 * @param weight The weight of the strategy
 */
- (void)addStrategy:(SelectiveSearchSegmentationStrategy*)g weight:(float)weight NS_SWIFT_NAME(addStrategy(g:weight:));


//
//  void cv::ximgproc::segmentation::SelectiveSearchSegmentationStrategyMultiple::clearStrategies()
//
/**
 * Remove all sub-strategies
 */
- (void)clearStrategies NS_SWIFT_NAME(clearStrategies());



@end

NS_ASSUME_NONNULL_END


