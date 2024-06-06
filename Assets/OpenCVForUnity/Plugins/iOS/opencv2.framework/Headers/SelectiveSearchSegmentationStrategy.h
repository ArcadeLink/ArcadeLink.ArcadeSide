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
#import "Algorithm.h"

@class Mat;



NS_ASSUME_NONNULL_BEGIN

// C++: class SelectiveSearchSegmentationStrategy
/**
 * Strategie for the selective search segmentation algorithm
 *                         The class implements a generic stragery for the algorithm described in CITE: uijlings2013selective.
 *
 * Member of `Ximgproc`
 */
CV_EXPORTS @interface SelectiveSearchSegmentationStrategy : Algorithm


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::ximgproc::segmentation::SelectiveSearchSegmentationStrategy> nativePtrSelectiveSearchSegmentationStrategy;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::ximgproc::segmentation::SelectiveSearchSegmentationStrategy>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::ximgproc::segmentation::SelectiveSearchSegmentationStrategy>)nativePtr;
#endif


#pragma mark - Methods


//
//  void cv::ximgproc::segmentation::SelectiveSearchSegmentationStrategy::setImage(Mat img, Mat regions, Mat sizes, int image_id = -1)
//
/**
 * Set a initial image, with a segmentation.
 * @param img The input image. Any number of channel can be provided
 * @param regions A segmentation of the image. The parameter must be the same size of img.
 * @param sizes The sizes of different regions
 * @param image_id If not set to -1, try to cache pre-computations. If the same set og (img, regions, size) is used, the image_id need to be the same.
 */
- (void)setImage:(Mat*)img regions:(Mat*)regions sizes:(Mat*)sizes image_id:(int)image_id NS_SWIFT_NAME(setImage(img:regions:sizes:image_id:));

/**
 * Set a initial image, with a segmentation.
 * @param img The input image. Any number of channel can be provided
 * @param regions A segmentation of the image. The parameter must be the same size of img.
 * @param sizes The sizes of different regions
 */
- (void)setImage:(Mat*)img regions:(Mat*)regions sizes:(Mat*)sizes NS_SWIFT_NAME(setImage(img:regions:sizes:));


//
//  float cv::ximgproc::segmentation::SelectiveSearchSegmentationStrategy::get(int r1, int r2)
//
/**
 * Return the score between two regions (between 0 and 1)
 * @param r1 The first region
 * @param r2 The second region
 */
- (float)get:(int)r1 r2:(int)r2 NS_SWIFT_NAME(get(r1:r2:));


//
//  void cv::ximgproc::segmentation::SelectiveSearchSegmentationStrategy::merge(int r1, int r2)
//
/**
 * Inform the strategy that two regions will be merged
 * @param r1 The first region
 * @param r2 The second region
 */
- (void)merge:(int)r1 r2:(int)r2 NS_SWIFT_NAME(merge(r1:r2:));



@end

NS_ASSUME_NONNULL_END


