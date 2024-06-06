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

// C++: class BackgroundSubtractorGMG
/**
 * Background Subtractor module based on the algorithm given in CITE: Gold2012 .
 *
 *  Takes a series of images and returns a sequence of mask (8UC1)
 *  images of the same size, where 255 indicates Foreground and 0 represents Background.
 *  This class implements an algorithm described in "Visual Tracking of Human Visitors under
 *  Variable-Lighting Conditions for a Responsive Audio Art Installation," A. Godbehere,
 *  A. Matsukawa, K. Goldberg, American Control Conference, Montreal, June 2012.
 *
 * Member of `Bgsegm`
 */
CV_EXPORTS @interface BackgroundSubtractorGMG : BackgroundSubtractor


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::bgsegm::BackgroundSubtractorGMG> nativePtrBackgroundSubtractorGMG;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::bgsegm::BackgroundSubtractorGMG>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::bgsegm::BackgroundSubtractorGMG>)nativePtr;
#endif


#pragma mark - Methods


//
//  int cv::bgsegm::BackgroundSubtractorGMG::getMaxFeatures()
//
/**
 * Returns total number of distinct colors to maintain in histogram.
 */
- (int)getMaxFeatures NS_SWIFT_NAME(getMaxFeatures());


//
//  void cv::bgsegm::BackgroundSubtractorGMG::setMaxFeatures(int maxFeatures)
//
/**
 * Sets total number of distinct colors to maintain in histogram.
 */
- (void)setMaxFeatures:(int)maxFeatures NS_SWIFT_NAME(setMaxFeatures(maxFeatures:));


//
//  double cv::bgsegm::BackgroundSubtractorGMG::getDefaultLearningRate()
//
/**
 * Returns the learning rate of the algorithm.
 *
 *     It lies between 0.0 and 1.0. It determines how quickly features are "forgotten" from
 *     histograms.
 */
- (double)getDefaultLearningRate NS_SWIFT_NAME(getDefaultLearningRate());


//
//  void cv::bgsegm::BackgroundSubtractorGMG::setDefaultLearningRate(double lr)
//
/**
 * Sets the learning rate of the algorithm.
 */
- (void)setDefaultLearningRate:(double)lr NS_SWIFT_NAME(setDefaultLearningRate(lr:));


//
//  int cv::bgsegm::BackgroundSubtractorGMG::getNumFrames()
//
/**
 * Returns the number of frames used to initialize background model.
 */
- (int)getNumFrames NS_SWIFT_NAME(getNumFrames());


//
//  void cv::bgsegm::BackgroundSubtractorGMG::setNumFrames(int nframes)
//
/**
 * Sets the number of frames used to initialize background model.
 */
- (void)setNumFrames:(int)nframes NS_SWIFT_NAME(setNumFrames(nframes:));


//
//  int cv::bgsegm::BackgroundSubtractorGMG::getQuantizationLevels()
//
/**
 * Returns the parameter used for quantization of color-space.
 *
 *     It is the number of discrete levels in each channel to be used in histograms.
 */
- (int)getQuantizationLevels NS_SWIFT_NAME(getQuantizationLevels());


//
//  void cv::bgsegm::BackgroundSubtractorGMG::setQuantizationLevels(int nlevels)
//
/**
 * Sets the parameter used for quantization of color-space
 */
- (void)setQuantizationLevels:(int)nlevels NS_SWIFT_NAME(setQuantizationLevels(nlevels:));


//
//  double cv::bgsegm::BackgroundSubtractorGMG::getBackgroundPrior()
//
/**
 * Returns the prior probability that each individual pixel is a background pixel.
 */
- (double)getBackgroundPrior NS_SWIFT_NAME(getBackgroundPrior());


//
//  void cv::bgsegm::BackgroundSubtractorGMG::setBackgroundPrior(double bgprior)
//
/**
 * Sets the prior probability that each individual pixel is a background pixel.
 */
- (void)setBackgroundPrior:(double)bgprior NS_SWIFT_NAME(setBackgroundPrior(bgprior:));


//
//  int cv::bgsegm::BackgroundSubtractorGMG::getSmoothingRadius()
//
/**
 * Returns the kernel radius used for morphological operations
 */
- (int)getSmoothingRadius NS_SWIFT_NAME(getSmoothingRadius());


//
//  void cv::bgsegm::BackgroundSubtractorGMG::setSmoothingRadius(int radius)
//
/**
 * Sets the kernel radius used for morphological operations
 */
- (void)setSmoothingRadius:(int)radius NS_SWIFT_NAME(setSmoothingRadius(radius:));


//
//  double cv::bgsegm::BackgroundSubtractorGMG::getDecisionThreshold()
//
/**
 * Returns the value of decision threshold.
 *
 *     Decision value is the value above which pixel is determined to be FG.
 */
- (double)getDecisionThreshold NS_SWIFT_NAME(getDecisionThreshold());


//
//  void cv::bgsegm::BackgroundSubtractorGMG::setDecisionThreshold(double thresh)
//
/**
 * Sets the value of decision threshold.
 */
- (void)setDecisionThreshold:(double)thresh NS_SWIFT_NAME(setDecisionThreshold(thresh:));


//
//  bool cv::bgsegm::BackgroundSubtractorGMG::getUpdateBackgroundModel()
//
/**
 * Returns the status of background model update
 */
- (BOOL)getUpdateBackgroundModel NS_SWIFT_NAME(getUpdateBackgroundModel());


//
//  void cv::bgsegm::BackgroundSubtractorGMG::setUpdateBackgroundModel(bool update)
//
/**
 * Sets the status of background model update
 */
- (void)setUpdateBackgroundModel:(BOOL)update NS_SWIFT_NAME(setUpdateBackgroundModel(update:));


//
//  double cv::bgsegm::BackgroundSubtractorGMG::getMinVal()
//
/**
 * Returns the minimum value taken on by pixels in image sequence. Usually 0.
 */
- (double)getMinVal NS_SWIFT_NAME(getMinVal());


//
//  void cv::bgsegm::BackgroundSubtractorGMG::setMinVal(double val)
//
/**
 * Sets the minimum value taken on by pixels in image sequence.
 */
- (void)setMinVal:(double)val NS_SWIFT_NAME(setMinVal(val:));


//
//  double cv::bgsegm::BackgroundSubtractorGMG::getMaxVal()
//
/**
 * Returns the maximum value taken on by pixels in image sequence. e.g. 1.0 or 255.
 */
- (double)getMaxVal NS_SWIFT_NAME(getMaxVal());


//
//  void cv::bgsegm::BackgroundSubtractorGMG::setMaxVal(double val)
//
/**
 * Sets the maximum value taken on by pixels in image sequence.
 */
- (void)setMaxVal:(double)val NS_SWIFT_NAME(setMaxVal(val:));



@end

NS_ASSUME_NONNULL_END


