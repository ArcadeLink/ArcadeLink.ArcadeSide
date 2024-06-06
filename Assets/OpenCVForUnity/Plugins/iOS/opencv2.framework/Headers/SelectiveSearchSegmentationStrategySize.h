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





NS_ASSUME_NONNULL_BEGIN

// C++: class SelectiveSearchSegmentationStrategySize
/**
 * Size-based strategy for the selective search segmentation algorithm
 *                         The class is implemented from the algorithm described in CITE: uijlings2013selective.
 *
 * Member of `Ximgproc`
 */
CV_EXPORTS @interface SelectiveSearchSegmentationStrategySize : SelectiveSearchSegmentationStrategy


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::ximgproc::segmentation::SelectiveSearchSegmentationStrategySize> nativePtrSelectiveSearchSegmentationStrategySize;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::ximgproc::segmentation::SelectiveSearchSegmentationStrategySize>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::ximgproc::segmentation::SelectiveSearchSegmentationStrategySize>)nativePtr;
#endif


#pragma mark - Methods



@end

NS_ASSUME_NONNULL_END


