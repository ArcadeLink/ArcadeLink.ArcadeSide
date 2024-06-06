//
// This file is auto-generated. Please don't modify it!
//
#pragma once

#ifdef __cplusplus
//#import "opencv.hpp"
#import "opencv2/objdetect.hpp"
#import "opencv2/objdetect/aruco_detector.hpp"
#else
#define CV_EXPORTS
#endif

#import <Foundation/Foundation.h>






NS_ASSUME_NONNULL_BEGIN

// C++: class DetectorParameters
/**
 * struct DetectorParameters is used by ArucoDetector
 *
 * Member of `Objdetect`
 */
CV_EXPORTS @interface DetectorParameters : NSObject


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::aruco::DetectorParameters> nativePtr;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::aruco::DetectorParameters>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::aruco::DetectorParameters>)nativePtr;
#endif


#pragma mark - Methods


//
//   cv::aruco::DetectorParameters::DetectorParameters()
//
- (instancetype)init;


//
//  bool cv::aruco::DetectorParameters::readDetectorParameters(FileNode fn)
//
// Unknown type 'FileNode' (I), skipping the function


//
//  bool cv::aruco::DetectorParameters::writeDetectorParameters(FileStorage fs, String name = String())
//
// Unknown type 'FileStorage' (I), skipping the function


    //
    // C++: int cv::aruco::DetectorParameters::adaptiveThreshWinSizeMin
    //

@property int adaptiveThreshWinSizeMin;

    //
    // C++: int cv::aruco::DetectorParameters::adaptiveThreshWinSizeMax
    //

@property int adaptiveThreshWinSizeMax;

    //
    // C++: int cv::aruco::DetectorParameters::adaptiveThreshWinSizeStep
    //

@property int adaptiveThreshWinSizeStep;

    //
    // C++: double cv::aruco::DetectorParameters::adaptiveThreshConstant
    //

@property double adaptiveThreshConstant;

    //
    // C++: double cv::aruco::DetectorParameters::minMarkerPerimeterRate
    //

@property double minMarkerPerimeterRate;

    //
    // C++: double cv::aruco::DetectorParameters::maxMarkerPerimeterRate
    //

@property double maxMarkerPerimeterRate;

    //
    // C++: double cv::aruco::DetectorParameters::polygonalApproxAccuracyRate
    //

@property double polygonalApproxAccuracyRate;

    //
    // C++: double cv::aruco::DetectorParameters::minCornerDistanceRate
    //

@property double minCornerDistanceRate;

    //
    // C++: int cv::aruco::DetectorParameters::minDistanceToBorder
    //

@property int minDistanceToBorder;

    //
    // C++: double cv::aruco::DetectorParameters::minMarkerDistanceRate
    //

@property double minMarkerDistanceRate;

    //
    // C++: int cv::aruco::DetectorParameters::cornerRefinementMethod
    //

@property int cornerRefinementMethod;

    //
    // C++: int cv::aruco::DetectorParameters::cornerRefinementWinSize
    //

@property int cornerRefinementWinSize;

    //
    // C++: int cv::aruco::DetectorParameters::cornerRefinementMaxIterations
    //

@property int cornerRefinementMaxIterations;

    //
    // C++: double cv::aruco::DetectorParameters::cornerRefinementMinAccuracy
    //

@property double cornerRefinementMinAccuracy;

    //
    // C++: int cv::aruco::DetectorParameters::markerBorderBits
    //

@property int markerBorderBits;

    //
    // C++: int cv::aruco::DetectorParameters::perspectiveRemovePixelPerCell
    //

@property int perspectiveRemovePixelPerCell;

    //
    // C++: double cv::aruco::DetectorParameters::perspectiveRemoveIgnoredMarginPerCell
    //

@property double perspectiveRemoveIgnoredMarginPerCell;

    //
    // C++: double cv::aruco::DetectorParameters::maxErroneousBitsInBorderRate
    //

@property double maxErroneousBitsInBorderRate;

    //
    // C++: double cv::aruco::DetectorParameters::minOtsuStdDev
    //

@property double minOtsuStdDev;

    //
    // C++: double cv::aruco::DetectorParameters::errorCorrectionRate
    //

@property double errorCorrectionRate;

    //
    // C++: float cv::aruco::DetectorParameters::aprilTagQuadDecimate
    //

@property float aprilTagQuadDecimate;

    //
    // C++: float cv::aruco::DetectorParameters::aprilTagQuadSigma
    //

@property float aprilTagQuadSigma;

    //
    // C++: int cv::aruco::DetectorParameters::aprilTagMinClusterPixels
    //

@property int aprilTagMinClusterPixels;

    //
    // C++: int cv::aruco::DetectorParameters::aprilTagMaxNmaxima
    //

@property int aprilTagMaxNmaxima;

    //
    // C++: float cv::aruco::DetectorParameters::aprilTagCriticalRad
    //

@property float aprilTagCriticalRad;

    //
    // C++: float cv::aruco::DetectorParameters::aprilTagMaxLineFitMse
    //

@property float aprilTagMaxLineFitMse;

    //
    // C++: int cv::aruco::DetectorParameters::aprilTagMinWhiteBlackDiff
    //

@property int aprilTagMinWhiteBlackDiff;

    //
    // C++: int cv::aruco::DetectorParameters::aprilTagDeglitch
    //

@property int aprilTagDeglitch;

    //
    // C++: bool cv::aruco::DetectorParameters::detectInvertedMarker
    //

@property BOOL detectInvertedMarker;

    //
    // C++: bool cv::aruco::DetectorParameters::useAruco3Detection
    //

@property BOOL useAruco3Detection;

    //
    // C++: int cv::aruco::DetectorParameters::minSideLengthCanonicalImg
    //

@property int minSideLengthCanonicalImg;

    //
    // C++: float cv::aruco::DetectorParameters::minMarkerLengthRatioOriginalImg
    //

@property float minMarkerLengthRatioOriginalImg;


@end

NS_ASSUME_NONNULL_END


