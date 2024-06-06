//
// This file is auto-generated. Please don't modify it!
//
#pragma once

#ifdef __cplusplus
//#import "opencv.hpp"
#import "opencv2/objdetect.hpp"
#else
#define CV_EXPORTS
#endif

#import <Foundation/Foundation.h>






NS_ASSUME_NONNULL_BEGIN

// C++: class Params
/**
 * The Params module
 *
 * Member of `Objdetect`
 */
CV_EXPORTS @interface QRCodeDetectorArucoParams : NSObject


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::QRCodeDetectorAruco::Params> nativePtr;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::QRCodeDetectorAruco::Params>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::QRCodeDetectorAruco::Params>)nativePtr;
#endif


#pragma mark - Methods


//
//   cv::QRCodeDetectorAruco::Params::Params()
//
- (instancetype)init;


    //
    // C++: float cv::QRCodeDetectorAruco::Params::minModuleSizeInPyramid
    //

@property float minModuleSizeInPyramid;

    //
    // C++: float cv::QRCodeDetectorAruco::Params::maxRotation
    //

@property float maxRotation;

    //
    // C++: float cv::QRCodeDetectorAruco::Params::maxModuleSizeMismatch
    //

@property float maxModuleSizeMismatch;

    //
    // C++: float cv::QRCodeDetectorAruco::Params::maxTimingPatternMismatch
    //

@property float maxTimingPatternMismatch;

    //
    // C++: float cv::QRCodeDetectorAruco::Params::maxPenalties
    //

@property float maxPenalties;

    //
    // C++: float cv::QRCodeDetectorAruco::Params::maxColorsMismatch
    //

@property float maxColorsMismatch;

    //
    // C++: float cv::QRCodeDetectorAruco::Params::scaleTimingPatternScore
    //

@property float scaleTimingPatternScore;


@end

NS_ASSUME_NONNULL_END


