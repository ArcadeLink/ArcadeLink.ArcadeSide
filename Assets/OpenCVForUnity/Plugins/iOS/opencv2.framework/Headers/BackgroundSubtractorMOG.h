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





NS_ASSUME_NONNULL_BEGIN

// C++: class BackgroundSubtractorMOG
/**
 * Gaussian Mixture-based Background/Foreground Segmentation Algorithm.
 *
 * The class implements the algorithm described in CITE: KB2001 .
 *
 * Member of `Bgsegm`
 */
CV_EXPORTS @interface BackgroundSubtractorMOG : BackgroundSubtractor


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::bgsegm::BackgroundSubtractorMOG> nativePtrBackgroundSubtractorMOG;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::bgsegm::BackgroundSubtractorMOG>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::bgsegm::BackgroundSubtractorMOG>)nativePtr;
#endif


#pragma mark - Methods


//
//  int cv::bgsegm::BackgroundSubtractorMOG::getHistory()
//
- (int)getHistory NS_SWIFT_NAME(getHistory());


//
//  void cv::bgsegm::BackgroundSubtractorMOG::setHistory(int nframes)
//
- (void)setHistory:(int)nframes NS_SWIFT_NAME(setHistory(nframes:));


//
//  int cv::bgsegm::BackgroundSubtractorMOG::getNMixtures()
//
- (int)getNMixtures NS_SWIFT_NAME(getNMixtures());


//
//  void cv::bgsegm::BackgroundSubtractorMOG::setNMixtures(int nmix)
//
- (void)setNMixtures:(int)nmix NS_SWIFT_NAME(setNMixtures(nmix:));


//
//  double cv::bgsegm::BackgroundSubtractorMOG::getBackgroundRatio()
//
- (double)getBackgroundRatio NS_SWIFT_NAME(getBackgroundRatio());


//
//  void cv::bgsegm::BackgroundSubtractorMOG::setBackgroundRatio(double backgroundRatio)
//
- (void)setBackgroundRatio:(double)backgroundRatio NS_SWIFT_NAME(setBackgroundRatio(backgroundRatio:));


//
//  double cv::bgsegm::BackgroundSubtractorMOG::getNoiseSigma()
//
- (double)getNoiseSigma NS_SWIFT_NAME(getNoiseSigma());


//
//  void cv::bgsegm::BackgroundSubtractorMOG::setNoiseSigma(double noiseSigma)
//
- (void)setNoiseSigma:(double)noiseSigma NS_SWIFT_NAME(setNoiseSigma(noiseSigma:));



@end

NS_ASSUME_NONNULL_END


