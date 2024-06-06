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

// C++: class GraphSegmentation
/**
 * Graph Based Segmentation Algorithm.
 *                         The class implements the algorithm described in CITE: PFF2004 .
 *
 * Member of `Ximgproc`
 */
CV_EXPORTS @interface GraphSegmentation : Algorithm


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::ximgproc::segmentation::GraphSegmentation> nativePtrGraphSegmentation;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::ximgproc::segmentation::GraphSegmentation>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::ximgproc::segmentation::GraphSegmentation>)nativePtr;
#endif


#pragma mark - Methods


//
//  void cv::ximgproc::segmentation::GraphSegmentation::processImage(Mat src, Mat& dst)
//
/**
 * Segment an image and store output in dst
 * @param src The input image. Any number of channel (1 (Eg: Gray), 3 (Eg: RGB), 4 (Eg: RGB-D)) can be provided
 * @param dst The output segmentation. It's a CV_32SC1 Mat with the same number of cols and rows as input image, with an unique, sequential, id for each pixel.
 */
- (void)processImage:(Mat*)src dst:(Mat*)dst NS_SWIFT_NAME(processImage(src:dst:));


//
//  void cv::ximgproc::segmentation::GraphSegmentation::setSigma(double sigma)
//
- (void)setSigma:(double)sigma NS_SWIFT_NAME(setSigma(sigma:));


//
//  double cv::ximgproc::segmentation::GraphSegmentation::getSigma()
//
- (double)getSigma NS_SWIFT_NAME(getSigma());


//
//  void cv::ximgproc::segmentation::GraphSegmentation::setK(float k)
//
- (void)setK:(float)k NS_SWIFT_NAME(setK(k:));


//
//  float cv::ximgproc::segmentation::GraphSegmentation::getK()
//
- (float)getK NS_SWIFT_NAME(getK());


//
//  void cv::ximgproc::segmentation::GraphSegmentation::setMinSize(int min_size)
//
- (void)setMinSize:(int)min_size NS_SWIFT_NAME(setMinSize(min_size:));


//
//  int cv::ximgproc::segmentation::GraphSegmentation::getMinSize()
//
- (int)getMinSize NS_SWIFT_NAME(getMinSize());



@end

NS_ASSUME_NONNULL_END


