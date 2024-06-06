//
// This file is auto-generated. Please don't modify it!
//
#pragma once

#ifdef __cplusplus
//#import "opencv.hpp"
#import "opencv2/ximgproc.hpp"
#import "opencv2/ximgproc/edge_drawing.hpp"
#else
#define CV_EXPORTS
#endif

#import <Foundation/Foundation.h>






NS_ASSUME_NONNULL_BEGIN

// C++: class Params
/**
 * The Params module
 *
 * Member of `Ximgproc`
 */
CV_EXPORTS @interface EdgeDrawingParams : NSObject


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::ximgproc::EdgeDrawing::Params> nativePtr;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::ximgproc::EdgeDrawing::Params>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::ximgproc::EdgeDrawing::Params>)nativePtr;
#endif


#pragma mark - Methods


//
//   cv::ximgproc::EdgeDrawing::Params::Params()
//
- (instancetype)init;


    //
    // C++: bool cv::ximgproc::EdgeDrawing::Params::PFmode
    //

@property BOOL PFmode;

    //
    // C++: int cv::ximgproc::EdgeDrawing::Params::EdgeDetectionOperator
    //

@property int EdgeDetectionOperator;

    //
    // C++: int cv::ximgproc::EdgeDrawing::Params::GradientThresholdValue
    //

@property int GradientThresholdValue;

    //
    // C++: int cv::ximgproc::EdgeDrawing::Params::AnchorThresholdValue
    //

@property int AnchorThresholdValue;

    //
    // C++: int cv::ximgproc::EdgeDrawing::Params::ScanInterval
    //

@property int ScanInterval;

    //
    // C++: int cv::ximgproc::EdgeDrawing::Params::MinPathLength
    //

@property int MinPathLength;

    //
    // C++: float cv::ximgproc::EdgeDrawing::Params::Sigma
    //

@property float Sigma;

    //
    // C++: bool cv::ximgproc::EdgeDrawing::Params::SumFlag
    //

@property BOOL SumFlag;

    //
    // C++: bool cv::ximgproc::EdgeDrawing::Params::NFAValidation
    //

@property BOOL NFAValidation;

    //
    // C++: int cv::ximgproc::EdgeDrawing::Params::MinLineLength
    //

@property int MinLineLength;

    //
    // C++: double cv::ximgproc::EdgeDrawing::Params::MaxDistanceBetweenTwoLines
    //

@property double MaxDistanceBetweenTwoLines;

    //
    // C++: double cv::ximgproc::EdgeDrawing::Params::LineFitErrorThreshold
    //

@property double LineFitErrorThreshold;

    //
    // C++: double cv::ximgproc::EdgeDrawing::Params::MaxErrorThreshold
    //

@property double MaxErrorThreshold;


@end

NS_ASSUME_NONNULL_END


