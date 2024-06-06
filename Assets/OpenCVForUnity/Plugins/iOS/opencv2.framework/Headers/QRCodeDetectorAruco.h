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
#import "GraphicalCodeDetector.h"

@class QRCodeDetectorArucoParams;



NS_ASSUME_NONNULL_BEGIN

// C++: class QRCodeDetectorAruco
/**
 * The QRCodeDetectorAruco module
 *
 * Member of `Objdetect`
 */
CV_EXPORTS @interface QRCodeDetectorAruco : GraphicalCodeDetector


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::QRCodeDetectorAruco> nativePtrQRCodeDetectorAruco;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::QRCodeDetectorAruco>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::QRCodeDetectorAruco>)nativePtr;
#endif


#pragma mark - Methods


//
//   cv::QRCodeDetectorAruco::QRCodeDetectorAruco()
//
- (instancetype)init;


//
//   cv::QRCodeDetectorAruco::QRCodeDetectorAruco(QRCodeDetectorAruco_Params params)
//
/**
 * QR code detector constructor for Aruco-based algorithm. See cv::QRCodeDetectorAruco::Params
 */
- (instancetype)initWithParams:(QRCodeDetectorArucoParams*)params;


//
//  QRCodeDetectorAruco cv::QRCodeDetectorAruco::setDetectorParameters(QRCodeDetectorAruco_Params params)
//
/**
 * Detector parameters setter. See cv::QRCodeDetectorAruco::Params
 */
- (QRCodeDetectorAruco*)setDetectorParameters:(QRCodeDetectorArucoParams*)params NS_SWIFT_NAME(setDetectorParameters(params:));


//
//  aruco_DetectorParameters cv::QRCodeDetectorAruco::getArucoParameters()
//
    // Return type 'aruco_DetectorParameters' is not supported, skipping the function


//
//  void cv::QRCodeDetectorAruco::setArucoParameters(aruco_DetectorParameters params)
//
// Unknown type 'aruco_DetectorParameters' (I), skipping the function



@end

NS_ASSUME_NONNULL_END


