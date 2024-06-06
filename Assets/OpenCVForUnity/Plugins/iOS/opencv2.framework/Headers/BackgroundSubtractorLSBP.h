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

// C++: class BackgroundSubtractorLSBP
/**
 * Background Subtraction using Local SVD Binary Pattern. More details about the algorithm can be found at CITE: LGuo2016
 *
 * Member of `Bgsegm`
 */
CV_EXPORTS @interface BackgroundSubtractorLSBP : BackgroundSubtractor


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::bgsegm::BackgroundSubtractorLSBP> nativePtrBackgroundSubtractorLSBP;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::bgsegm::BackgroundSubtractorLSBP>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::bgsegm::BackgroundSubtractorLSBP>)nativePtr;
#endif


#pragma mark - Methods


//
//  void cv::bgsegm::BackgroundSubtractorLSBP::apply(Mat image, Mat& fgmask, double learningRate = -1)
//
- (void)apply:(Mat*)image fgmask:(Mat*)fgmask learningRate:(double)learningRate NS_SWIFT_NAME(apply(image:fgmask:learningRate:));

- (void)apply:(Mat*)image fgmask:(Mat*)fgmask NS_SWIFT_NAME(apply(image:fgmask:));


//
//  void cv::bgsegm::BackgroundSubtractorLSBP::getBackgroundImage(Mat& backgroundImage)
//
- (void)getBackgroundImage:(Mat*)backgroundImage NS_SWIFT_NAME(getBackgroundImage(backgroundImage:));



@end

NS_ASSUME_NONNULL_END


