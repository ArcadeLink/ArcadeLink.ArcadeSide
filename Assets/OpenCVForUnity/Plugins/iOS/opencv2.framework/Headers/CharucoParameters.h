//
// This file is auto-generated. Please don't modify it!
//
#pragma once

#ifdef __cplusplus
//#import "opencv.hpp"
#import "opencv2/objdetect.hpp"
#import "opencv2/objdetect/charuco_detector.hpp"
#else
#define CV_EXPORTS
#endif

#import <Foundation/Foundation.h>


@class Mat;



NS_ASSUME_NONNULL_BEGIN

// C++: class CharucoParameters
/**
 * The CharucoParameters module
 *
 * Member of `Objdetect`
 */
CV_EXPORTS @interface CharucoParameters : NSObject


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::aruco::CharucoParameters> nativePtr;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::aruco::CharucoParameters>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::aruco::CharucoParameters>)nativePtr;
#endif


#pragma mark - Methods


//
//   cv::aruco::CharucoParameters::CharucoParameters()
//
- (instancetype)init;


    //
    // C++: Mat cv::aruco::CharucoParameters::cameraMatrix
    //

@property Mat* cameraMatrix;

    //
    // C++: Mat cv::aruco::CharucoParameters::distCoeffs
    //

@property Mat* distCoeffs;

    //
    // C++: int cv::aruco::CharucoParameters::minMarkers
    //

@property int minMarkers;

    //
    // C++: bool cv::aruco::CharucoParameters::tryRefineMarkers
    //

@property BOOL tryRefineMarkers;


@end

NS_ASSUME_NONNULL_END


