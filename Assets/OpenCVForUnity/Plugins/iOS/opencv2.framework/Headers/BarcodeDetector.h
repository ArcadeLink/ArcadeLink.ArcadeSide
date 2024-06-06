//
// This file is auto-generated. Please don't modify it!
//
#pragma once

#ifdef __cplusplus
//#import "opencv.hpp"
#import "opencv2/objdetect.hpp"
#import "opencv2/objdetect/barcode.hpp"
#else
#define CV_EXPORTS
#endif

#import <Foundation/Foundation.h>
#import "GraphicalCodeDetector.h"

@class Mat;



NS_ASSUME_NONNULL_BEGIN

// C++: class BarcodeDetector
/**
 * The BarcodeDetector module
 *
 * Member of `Objdetect`
 */
CV_EXPORTS @interface BarcodeDetector : GraphicalCodeDetector


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::barcode::BarcodeDetector> nativePtrBarcodeDetector;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::barcode::BarcodeDetector>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::barcode::BarcodeDetector>)nativePtr;
#endif


#pragma mark - Methods


//
//   cv::barcode::BarcodeDetector::BarcodeDetector()
//
/**
 * Initialize the BarcodeDetector.
 */
- (instancetype)init;


//
//   cv::barcode::BarcodeDetector::BarcodeDetector(string prototxt_path, string model_path)
//
/**
 * Initialize the BarcodeDetector.
 *
 * Parameters allow to load _optional_ Super Resolution DNN model for better quality.
 * @param prototxt_path prototxt file path for the super resolution model
 * @param model_path model file path for the super resolution model
 */
- (instancetype)initWithPrototxt_path:(NSString*)prototxt_path model_path:(NSString*)model_path;


//
//  bool cv::barcode::BarcodeDetector::decodeWithType(Mat img, Mat points, vector_string& decoded_info, vector_string& decoded_type)
//
/**
 * Decodes barcode in image once it's found by the detect() method.
 *
 * @param img grayscale or color (BGR) image containing bar code.
 * @param points vector of rotated rectangle vertices found by detect() method (or some other algorithm).
 * For N detected barcodes, the dimensions of this array should be [N][4].
 * Order of four points in vector<Point2f> is bottomLeft, topLeft, topRight, bottomRight.
 * @param decoded_info UTF8-encoded output vector of string or empty vector of string if the codes cannot be decoded.
 * @param decoded_type vector strings, specifies the type of these barcodes
 * @return true if at least one valid barcode have been found
 */
- (BOOL)decodeWithType:(Mat*)img points:(Mat*)points decoded_info:(NSMutableArray<NSString*>*)decoded_info decoded_type:(NSMutableArray<NSString*>*)decoded_type NS_SWIFT_NAME(decodeWithType(img:points:decoded_info:decoded_type:));


//
//  bool cv::barcode::BarcodeDetector::detectAndDecodeWithType(Mat img, vector_string& decoded_info, vector_string& decoded_type, Mat& points = Mat())
//
/**
 * Both detects and decodes barcode
 *
 * @param img grayscale or color (BGR) image containing barcode.
 * @param decoded_info UTF8-encoded output vector of string(s) or empty vector of string if the codes cannot be decoded.
 * @param decoded_type vector of strings, specifies the type of these barcodes
 * @param points optional output vector of vertices of the found  barcode rectangle. Will be empty if not found.
 * @return true if at least one valid barcode have been found
 */
- (BOOL)detectAndDecodeWithType:(Mat*)img decoded_info:(NSMutableArray<NSString*>*)decoded_info decoded_type:(NSMutableArray<NSString*>*)decoded_type points:(Mat*)points NS_SWIFT_NAME(detectAndDecodeWithType(img:decoded_info:decoded_type:points:));

/**
 * Both detects and decodes barcode
 *
 * @param img grayscale or color (BGR) image containing barcode.
 * @param decoded_info UTF8-encoded output vector of string(s) or empty vector of string if the codes cannot be decoded.
 * @param decoded_type vector of strings, specifies the type of these barcodes
 * @return true if at least one valid barcode have been found
 */
- (BOOL)detectAndDecodeWithType:(Mat*)img decoded_info:(NSMutableArray<NSString*>*)decoded_info decoded_type:(NSMutableArray<NSString*>*)decoded_type NS_SWIFT_NAME(detectAndDecodeWithType(img:decoded_info:decoded_type:));



@end

NS_ASSUME_NONNULL_END


