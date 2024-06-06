//
// This file is auto-generated. Please don't modify it!
//
#pragma once

#ifdef __cplusplus
//#import "opencv.hpp"
#import "opencv2/phase_unwrapping.hpp"
#import "opencv2/phase_unwrapping/histogramphaseunwrapping.hpp"
#else
#define CV_EXPORTS
#endif

#import <Foundation/Foundation.h>






NS_ASSUME_NONNULL_BEGIN

// C++: class Params
/**
 * Parameters of phaseUnwrapping constructor.
 *
 * width Phase map width.
 * height Phase map height.
 * histThresh Bins in the histogram are not of equal size. Default value is 3*pi*pi. The one before "histThresh" value are smaller.
 * nbrOfSmallBins Number of bins between 0 and "histThresh". Default value is 10.
 * nbrOfLargeBins Number of bins between "histThresh" and 32*pi*pi (highest edge reliability value). Default value is 5.
 *
 * Member of `Phase_unwrapping`
 */
CV_EXPORTS @interface HistogramPhaseUnwrappingParams : NSObject


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::phase_unwrapping::HistogramPhaseUnwrapping::Params> nativePtr;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::phase_unwrapping::HistogramPhaseUnwrapping::Params>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::phase_unwrapping::HistogramPhaseUnwrapping::Params>)nativePtr;
#endif


#pragma mark - Methods


//
//   cv::phase_unwrapping::HistogramPhaseUnwrapping::Params::Params()
//
- (instancetype)init;


    //
    // C++: int cv::phase_unwrapping::HistogramPhaseUnwrapping::Params::width
    //

@property int width;

    //
    // C++: int cv::phase_unwrapping::HistogramPhaseUnwrapping::Params::height
    //

@property int height;

    //
    // C++: float cv::phase_unwrapping::HistogramPhaseUnwrapping::Params::histThresh
    //

@property float histThresh;

    //
    // C++: int cv::phase_unwrapping::HistogramPhaseUnwrapping::Params::nbrOfSmallBins
    //

@property int nbrOfSmallBins;

    //
    // C++: int cv::phase_unwrapping::HistogramPhaseUnwrapping::Params::nbrOfLargeBins
    //

@property int nbrOfLargeBins;


@end

NS_ASSUME_NONNULL_END


