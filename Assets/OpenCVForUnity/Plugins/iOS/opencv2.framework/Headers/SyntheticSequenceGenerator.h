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
#import "Algorithm.h"

@class Mat;



NS_ASSUME_NONNULL_BEGIN

// C++: class SyntheticSequenceGenerator
/**
 * Synthetic frame sequence generator for testing background subtraction algorithms.
 *
 *  It will generate the moving object on top of the background.
 *  It will apply some distortion to the background to make the test more complex.
 *
 * Member of `Bgsegm`
 */
CV_EXPORTS @interface SyntheticSequenceGenerator : Algorithm


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::bgsegm::SyntheticSequenceGenerator> nativePtrSyntheticSequenceGenerator;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::bgsegm::SyntheticSequenceGenerator>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::bgsegm::SyntheticSequenceGenerator>)nativePtr;
#endif


#pragma mark - Methods


//
//   cv::bgsegm::SyntheticSequenceGenerator::SyntheticSequenceGenerator(Mat background, Mat object, double amplitude, double wavelength, double wavespeed, double objspeed)
//
/**
 * Creates an instance of SyntheticSequenceGenerator.
 *
 * @param background Background image for object.
 * @param object Object image which will move slowly over the background.
 * @param amplitude Amplitude of wave distortion applied to background.
 * @param wavelength Length of waves in distortion applied to background.
 * @param wavespeed How fast waves will move.
 * @param objspeed How fast object will fly over background.
 */
- (instancetype)initWithBackground:(Mat*)background object:(Mat*)object amplitude:(double)amplitude wavelength:(double)wavelength wavespeed:(double)wavespeed objspeed:(double)objspeed;


//
//  void cv::bgsegm::SyntheticSequenceGenerator::getNextFrame(Mat& frame, Mat& gtMask)
//
/**
 * Obtain the next frame in the sequence.
 *
 * @param frame Output frame.
 * @param gtMask Output ground-truth (reference) segmentation mask object/background.
 */
- (void)getNextFrame:(Mat*)frame gtMask:(Mat*)gtMask NS_SWIFT_NAME(getNextFrame(frame:gtMask:));



@end

NS_ASSUME_NONNULL_END


