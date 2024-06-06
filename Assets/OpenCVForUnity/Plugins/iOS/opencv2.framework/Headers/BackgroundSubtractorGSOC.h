//
// This file is auto-generated. Please don't modify it!
//
#pragma once

#ifdef __cplusplus
//#import "opencv.hpp"
#import "opencv2/bgsegm.hpp"
#else
#define CV_EXPORTS
#endif

#import <Foundation/Foundation.h>
#import "BackgroundSubtractor.h"

@class Mat;



NS_ASSUME_NONNULL_BEGIN

// C++: class BackgroundSubtractorGSOC
/**
 * Implementation of the different yet better algorithm which is called GSOC, as it was implemented during GSOC and was not originated from any paper.
 *
 * This algorithm demonstrates better performance on CDNET 2014 dataset compared to other algorithms in OpenCV.
 *
 * Member of `Bgsegm`
 */
CV_EXPORTS @interface BackgroundSubtractorGSOC : BackgroundSubtractor


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::bgsegm::BackgroundSubtractorGSOC> nativePtrBackgroundSubtractorGSOC;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::bgsegm::BackgroundSubtractorGSOC>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::bgsegm::BackgroundSubtractorGSOC>)nativePtr;
#endif


#pragma mark - Methods


//
//  void cv::bgsegm::BackgroundSubtractorGSOC::apply(Mat image, Mat& fgmask, double learningRate = -1)
//
- (void)apply:(Mat*)image fgmask:(Mat*)fgmask learningRate:(double)learningRate NS_SWIFT_NAME(apply(image:fgmask:learningRate:));

- (void)apply:(Mat*)image fgmask:(Mat*)fgmask NS_SWIFT_NAME(apply(image:fgmask:));


//
//  void cv::bgsegm::BackgroundSubtractorGSOC::getBackgroundImage(Mat& backgroundImage)
//
- (void)getBackgroundImage:(Mat*)backgroundImage NS_SWIFT_NAME(getBackgroundImage(backgroundImage:));



@end

NS_ASSUME_NONNULL_END


