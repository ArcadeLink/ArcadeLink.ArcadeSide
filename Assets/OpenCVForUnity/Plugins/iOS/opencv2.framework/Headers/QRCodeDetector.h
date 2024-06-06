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

@class Mat;



NS_ASSUME_NONNULL_BEGIN

// C++: class QRCodeDetector
/**
 * The QRCodeDetector module
 *
 * Member of `Objdetect`
 */
CV_EXPORTS @interface QRCodeDetector : GraphicalCodeDetector


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::QRCodeDetector> nativePtrQRCodeDetector;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::QRCodeDetector>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::QRCodeDetector>)nativePtr;
#endif


#pragma mark - Methods


//
//   cv::QRCodeDetector::QRCodeDetector()
//
- (instancetype)init;


//
//  QRCodeDetector cv::QRCodeDetector::setEpsX(double epsX)
//
/**
 * sets the epsilon used during the horizontal scan of QR code stop marker detection.
 * @param epsX Epsilon neighborhood, which allows you to determine the horizontal pattern
 *      of the scheme 1:1:3:1:1 according to QR code standard.
 */
- (QRCodeDetector*)setEpsX:(double)epsX NS_SWIFT_NAME(setEpsX(epsX:));


//
//  QRCodeDetector cv::QRCodeDetector::setEpsY(double epsY)
//
/**
 * sets the epsilon used during the vertical scan of QR code stop marker detection.
 * @param epsY Epsilon neighborhood, which allows you to determine the vertical pattern
 *      of the scheme 1:1:3:1:1 according to QR code standard.
 */
- (QRCodeDetector*)setEpsY:(double)epsY NS_SWIFT_NAME(setEpsY(epsY:));


//
//  QRCodeDetector cv::QRCodeDetector::setUseAlignmentMarkers(bool useAlignmentMarkers)
//
/**
 * use markers to improve the position of the corners of the QR code
 *
 * alignmentMarkers using by default
 */
- (QRCodeDetector*)setUseAlignmentMarkers:(BOOL)useAlignmentMarkers NS_SWIFT_NAME(setUseAlignmentMarkers(useAlignmentMarkers:));


//
//  String cv::QRCodeDetector::decodeCurved(Mat img, Mat points, Mat& straight_qrcode = Mat())
//
/**
 * Decodes QR code on a curved surface in image once it's found by the detect() method.
 *
 *      Returns UTF8-encoded output string or empty string if the code cannot be decoded.
 * @param img grayscale or color (BGR) image containing QR code.
 * @param points Quadrangle vertices found by detect() method (or some other algorithm).
 * @param straight_qrcode The optional output image containing rectified and binarized QR code
 */
- (NSString*)decodeCurved:(Mat*)img points:(Mat*)points straight_qrcode:(Mat*)straight_qrcode NS_SWIFT_NAME(decodeCurved(img:points:straight_qrcode:));

/**
 * Decodes QR code on a curved surface in image once it's found by the detect() method.
 *
 *      Returns UTF8-encoded output string or empty string if the code cannot be decoded.
 * @param img grayscale or color (BGR) image containing QR code.
 * @param points Quadrangle vertices found by detect() method (or some other algorithm).
 */
- (NSString*)decodeCurved:(Mat*)img points:(Mat*)points NS_SWIFT_NAME(decodeCurved(img:points:));


//
//  string cv::QRCodeDetector::detectAndDecodeCurved(Mat img, Mat& points = Mat(), Mat& straight_qrcode = Mat())
//
/**
 * Both detects and decodes QR code on a curved surface
 *
 * @param img grayscale or color (BGR) image containing QR code.
 * @param points optional output array of vertices of the found QR code quadrangle. Will be empty if not found.
 * @param straight_qrcode The optional output image containing rectified and binarized QR code
 */
- (NSString*)detectAndDecodeCurved:(Mat*)img points:(Mat*)points straight_qrcode:(Mat*)straight_qrcode NS_SWIFT_NAME(detectAndDecodeCurved(img:points:straight_qrcode:));

/**
 * Both detects and decodes QR code on a curved surface
 *
 * @param img grayscale or color (BGR) image containing QR code.
 * @param points optional output array of vertices of the found QR code quadrangle. Will be empty if not found.
 */
- (NSString*)detectAndDecodeCurved:(Mat*)img points:(Mat*)points NS_SWIFT_NAME(detectAndDecodeCurved(img:points:));

/**
 * Both detects and decodes QR code on a curved surface
 *
 * @param img grayscale or color (BGR) image containing QR code.
 */
- (NSString*)detectAndDecodeCurved:(Mat*)img NS_SWIFT_NAME(detectAndDecodeCurved(img:));



@end

NS_ASSUME_NONNULL_END


