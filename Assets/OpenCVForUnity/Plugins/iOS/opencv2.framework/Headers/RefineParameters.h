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

// C++: class RefineParameters
/**
 * struct RefineParameters is used by ArucoDetector
 *
 * Member of `Objdetect`
 */
CV_EXPORTS @interface RefineParameters : NSObject


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::aruco::RefineParameters> nativePtr;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::aruco::RefineParameters>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::aruco::RefineParameters>)nativePtr;
#endif


#pragma mark - Methods


//
//   cv::aruco::RefineParameters::RefineParameters(float minRepDistance = 10.f, float errorCorrectionRate = 3.f, bool checkAllOrders = true)
//
- (instancetype)initWithMinRepDistance:(float)minRepDistance errorCorrectionRate:(float)errorCorrectionRate checkAllOrders:(BOOL)checkAllOrders;

- (instancetype)initWithMinRepDistance:(float)minRepDistance errorCorrectionRate:(float)errorCorrectionRate;

- (instancetype)initWithMinRepDistance:(float)minRepDistance;

- (instancetype)init;


//
//  bool cv::aruco::RefineParameters::readRefineParameters(FileNode fn)
//
// Unknown type 'FileNode' (I), skipping the function


//
//  bool cv::aruco::RefineParameters::writeRefineParameters(FileStorage fs, String name = String())
//
// Unknown type 'FileStorage' (I), skipping the function


    //
    // C++: float cv::aruco::RefineParameters::minRepDistance
    //

@property float minRepDistance;

    //
    // C++: float cv::aruco::RefineParameters::errorCorrectionRate
    //

@property float errorCorrectionRate;

    //
    // C++: bool cv::aruco::RefineParameters::checkAllOrders
    //

@property BOOL checkAllOrders;


@end

NS_ASSUME_NONNULL_END


