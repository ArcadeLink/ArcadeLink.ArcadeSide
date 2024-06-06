//
// This file is auto-generated. Please don't modify it!
//
#pragma once

#ifdef __cplusplus
//#import "opencv.hpp"
#import "opencv2/structured_light.hpp"
#import "opencv2/structured_light/sinusoidalpattern.hpp"
#else
#define CV_EXPORTS
#endif

#import <Foundation/Foundation.h>
#import "StructuredLightPattern.h"

@class Mat;
@class SinusoidalPatternParams;
@class Size2i;



NS_ASSUME_NONNULL_BEGIN

// C++: class SinusoidalPattern
/**
 * Class implementing Fourier transform profilometry (FTP) , phase-shifting profilometry (PSP)
 * and Fourier-assisted phase-shifting profilometry (FAPS) based on CITE: faps.
 *
 * This class generates sinusoidal patterns that can be used with FTP, PSP and FAPS.
 *
 * Member of `Structured_light`
 */
CV_EXPORTS @interface SinusoidalPattern : StructuredLightPattern


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::structured_light::SinusoidalPattern> nativePtrSinusoidalPattern;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::structured_light::SinusoidalPattern>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::structured_light::SinusoidalPattern>)nativePtr;
#endif


#pragma mark - Methods


//
// static Ptr_SinusoidalPattern cv::structured_light::SinusoidalPattern::create(Ptr_SinusoidalPattern_Params parameters = makePtr<SinusoidalPattern::Params>())
//
/**
 * Constructor.
 * @param parameters SinusoidalPattern parameters SinusoidalPattern::Params: width, height of the projector and patterns parameters.
 *
 */
+ (SinusoidalPattern*)create:(SinusoidalPatternParams*)parameters NS_SWIFT_NAME(create(parameters:));

/**
 * Constructor.
 *
 */
+ (SinusoidalPattern*)create NS_SWIFT_NAME(create());


//
//  void cv::structured_light::SinusoidalPattern::computePhaseMap(vector_Mat patternImages, Mat& wrappedPhaseMap, Mat& shadowMask = Mat(), Mat fundamental = Mat())
//
/**
 * Compute a wrapped phase map from sinusoidal patterns.
 * @param patternImages Input data to compute the wrapped phase map.
 * @param wrappedPhaseMap Wrapped phase map obtained through one of the three methods.
 * @param shadowMask Mask used to discard shadow regions.
 * @param fundamental Fundamental matrix used to compute epipolar lines and ease the matching step.
 */
- (void)computePhaseMap:(NSArray<Mat*>*)patternImages wrappedPhaseMap:(Mat*)wrappedPhaseMap shadowMask:(Mat*)shadowMask fundamental:(Mat*)fundamental NS_SWIFT_NAME(computePhaseMap(patternImages:wrappedPhaseMap:shadowMask:fundamental:));

/**
 * Compute a wrapped phase map from sinusoidal patterns.
 * @param patternImages Input data to compute the wrapped phase map.
 * @param wrappedPhaseMap Wrapped phase map obtained through one of the three methods.
 * @param shadowMask Mask used to discard shadow regions.
 */
- (void)computePhaseMap:(NSArray<Mat*>*)patternImages wrappedPhaseMap:(Mat*)wrappedPhaseMap shadowMask:(Mat*)shadowMask NS_SWIFT_NAME(computePhaseMap(patternImages:wrappedPhaseMap:shadowMask:));

/**
 * Compute a wrapped phase map from sinusoidal patterns.
 * @param patternImages Input data to compute the wrapped phase map.
 * @param wrappedPhaseMap Wrapped phase map obtained through one of the three methods.
 */
- (void)computePhaseMap:(NSArray<Mat*>*)patternImages wrappedPhaseMap:(Mat*)wrappedPhaseMap NS_SWIFT_NAME(computePhaseMap(patternImages:wrappedPhaseMap:));


//
//  void cv::structured_light::SinusoidalPattern::unwrapPhaseMap(Mat wrappedPhaseMap, Mat& unwrappedPhaseMap, Size camSize, Mat shadowMask = Mat())
//
/**
 * Unwrap the wrapped phase map to remove phase ambiguities.
 * @param wrappedPhaseMap The wrapped phase map computed from the pattern.
 * @param unwrappedPhaseMap The unwrapped phase map used to find correspondences between the two devices.
 * @param camSize Resolution of the camera.
 * @param shadowMask Mask used to discard shadow regions.
 */
- (void)unwrapPhaseMap:(Mat*)wrappedPhaseMap unwrappedPhaseMap:(Mat*)unwrappedPhaseMap camSize:(Size2i*)camSize shadowMask:(Mat*)shadowMask NS_SWIFT_NAME(unwrapPhaseMap(wrappedPhaseMap:unwrappedPhaseMap:camSize:shadowMask:));

/**
 * Unwrap the wrapped phase map to remove phase ambiguities.
 * @param wrappedPhaseMap The wrapped phase map computed from the pattern.
 * @param unwrappedPhaseMap The unwrapped phase map used to find correspondences between the two devices.
 * @param camSize Resolution of the camera.
 */
- (void)unwrapPhaseMap:(Mat*)wrappedPhaseMap unwrappedPhaseMap:(Mat*)unwrappedPhaseMap camSize:(Size2i*)camSize NS_SWIFT_NAME(unwrapPhaseMap(wrappedPhaseMap:unwrappedPhaseMap:camSize:));


//
//  void cv::structured_light::SinusoidalPattern::findProCamMatches(Mat projUnwrappedPhaseMap, Mat camUnwrappedPhaseMap, vector_Mat& matches)
//
/**
 * Find correspondences between the two devices thanks to unwrapped phase maps.
 * @param projUnwrappedPhaseMap Projector's unwrapped phase map.
 * @param camUnwrappedPhaseMap Camera's unwrapped phase map.
 * @param matches Images used to display correspondences map.
 */
- (void)findProCamMatches:(Mat*)projUnwrappedPhaseMap camUnwrappedPhaseMap:(Mat*)camUnwrappedPhaseMap matches:(NSMutableArray<Mat*>*)matches NS_SWIFT_NAME(findProCamMatches(projUnwrappedPhaseMap:camUnwrappedPhaseMap:matches:));


//
//  void cv::structured_light::SinusoidalPattern::computeDataModulationTerm(vector_Mat patternImages, Mat& dataModulationTerm, Mat shadowMask)
//
/**
 * compute the data modulation term.
 * @param patternImages captured images with projected patterns.
 * @param dataModulationTerm Mat where the data modulation term is saved.
 * @param shadowMask Mask used to discard shadow regions.
 */
- (void)computeDataModulationTerm:(NSArray<Mat*>*)patternImages dataModulationTerm:(Mat*)dataModulationTerm shadowMask:(Mat*)shadowMask NS_SWIFT_NAME(computeDataModulationTerm(patternImages:dataModulationTerm:shadowMask:));



@end

NS_ASSUME_NONNULL_END


