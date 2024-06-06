//
// This file is auto-generated. Please don't modify it!
//
#pragma once

#ifdef __cplusplus
//#import "opencv.hpp"
#import "opencv2/aruco.hpp"
#import "aruco/charuco.hpp"
#import "opencv2/aruco/aruco_calib.hpp"
#else
#define CV_EXPORTS
#endif

#import <Foundation/Foundation.h>


#import "Aruco.h"



NS_ASSUME_NONNULL_BEGIN

// C++: class EstimateParameters
/**
 * Pose estimation parameters
 *
 * pattern Defines center this system and axes direction (default PatternPositionType::ARUCO_CCW_CENTER).
 * useExtrinsicGuess Parameter used for SOLVEPNP_ITERATIVE. If true (1), the function uses the provided
 * rvec and tvec values as initial approximations of the rotation and translation vectors, respectively, and further
 * optimizes them (default false).
 * solvePnPMethod Method for solving a PnP problem: see REF: calib3d_solvePnP_flags (default SOLVEPNP_ITERATIVE).
 * @see PatternPositionType, solvePnP(), check tutorial_aruco_detection in aruco contrib
 *
 * Member of `Aruco`
 */
CV_EXPORTS @interface EstimateParameters : NSObject


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::aruco::EstimateParameters> nativePtr;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::aruco::EstimateParameters>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::aruco::EstimateParameters>)nativePtr;
#endif


#pragma mark - Methods


//
//   cv::aruco::EstimateParameters::EstimateParameters()
//
- (instancetype)init;


    //
    // C++: PatternPositionType cv::aruco::EstimateParameters::pattern
    //

@property PatternPositionType pattern;

    //
    // C++: bool cv::aruco::EstimateParameters::useExtrinsicGuess
    //

@property BOOL useExtrinsicGuess;

    //
    // C++: int cv::aruco::EstimateParameters::solvePnPMethod
    //

@property int solvePnPMethod;


@end

NS_ASSUME_NONNULL_END


