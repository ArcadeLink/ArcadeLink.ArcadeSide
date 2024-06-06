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






NS_ASSUME_NONNULL_BEGIN

// C++: class Params
/**
 * Parameters of SinusoidalPattern constructor
 * width Projector's width.
 * height Projector's height.
 * nbrOfPeriods Number of period along the patterns direction.
 * shiftValue Phase shift between two consecutive patterns.
 * methodId Allow to choose between FTP, PSP and FAPS.
 * nbrOfPixelsBetweenMarkers Number of pixels between two consecutive markers on the same row.
 * setMarkers Allow to set markers on the patterns.
 * markersLocation vector used to store markers location on the patterns.
 *
 * Member of `Structured_light`
 */
CV_EXPORTS @interface SinusoidalPatternParams : NSObject


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::structured_light::SinusoidalPattern::Params> nativePtr;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::structured_light::SinusoidalPattern::Params>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::structured_light::SinusoidalPattern::Params>)nativePtr;
#endif


#pragma mark - Methods


//
//   cv::structured_light::SinusoidalPattern::Params::Params()
//
- (instancetype)init;


    //
    // C++: int cv::structured_light::SinusoidalPattern::Params::width
    //

@property int width;

    //
    // C++: int cv::structured_light::SinusoidalPattern::Params::height
    //

@property int height;

    //
    // C++: int cv::structured_light::SinusoidalPattern::Params::nbrOfPeriods
    //

@property int nbrOfPeriods;

    //
    // C++: float cv::structured_light::SinusoidalPattern::Params::shiftValue
    //

@property float shiftValue;

    //
    // C++: int cv::structured_light::SinusoidalPattern::Params::methodId
    //

@property int methodId;

    //
    // C++: int cv::structured_light::SinusoidalPattern::Params::nbrOfPixelsBetweenMarkers
    //

@property int nbrOfPixelsBetweenMarkers;

    //
    // C++: bool cv::structured_light::SinusoidalPattern::Params::horizontal
    //

@property BOOL horizontal;

    //
    // C++: bool cv::structured_light::SinusoidalPattern::Params::setMarkers
    //

@property BOOL setMarkers;


@end

NS_ASSUME_NONNULL_END


