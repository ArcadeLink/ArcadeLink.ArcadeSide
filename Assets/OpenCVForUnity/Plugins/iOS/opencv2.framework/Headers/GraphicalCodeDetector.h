//
// This file is auto-generated. Please don't modify it!
//
#pragma once

#ifdef __cplusplus
//#import "opencv.hpp"
#import "opencv2/objdetect.hpp"
#import "opencv2/objdetect/graphical_code_detector.hpp"
#else
#define CV_EXPORTS
#endif

#import <Foundation/Foundation.h>


@class Mat;



NS_ASSUME_NONNULL_BEGIN

// C++: class GraphicalCodeDetector
/**
 * The GraphicalCodeDetector module
 *
 * Member of `Objdetect`
 */
CV_EXPORTS @interface GraphicalCodeDetector : NSObject


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::GraphicalCodeDetector> nativePtr;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::GraphicalCodeDetector>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::GraphicalCodeDetector>)nativePtr;
#endif


#pragma mark - Methods


//
//  bool cv::GraphicalCodeDetector::detect(Mat img, Mat& points)
//
/**
 * Detects graphical code in image and returns the quadrangle containing the code.
 * @param img grayscale or color (BGR) image containing (or not) graphical code.
 * @param points Output vector of vertices of the minimum-area quadrangle containing the code.
 */
- (BOOL)detect:(Mat*)img points:(Mat*)points NS_SWIFT_NAME(detect(img:points:));


//
//  string cv::GraphicalCodeDetector::decode(Mat img, Mat points, Mat& straight_code = Mat())
//
/**
 * Decodes graphical code in image once it's found by the detect() method.
 *
 *      Returns UTF8-encoded output string or empty string if the code cannot be decoded.
 * @param img grayscale or color (BGR) image containing graphical code.
 * @param points Quadrangle vertices found by detect() method (or some other algorithm).
 * @param straight_code The optional output image containing binarized code, will be empty if not found.
 */
- (NSString*)decode:(Mat*)img points:(Mat*)points straight_code:(Mat*)straight_code NS_SWIFT_NAME(decode(img:points:straight_code:));

/**
 * Decodes graphical code in image once it's found by the detect() method.
 *
 *      Returns UTF8-encoded output string or empty string if the code cannot be decoded.
 * @param img grayscale or color (BGR) image containing graphical code.
 * @param points Quadrangle vertices found by detect() method (or some other algorithm).
 */
- (NSString*)decode:(Mat*)img points:(Mat*)points NS_SWIFT_NAME(decode(img:points:));


//
//  string cv::GraphicalCodeDetector::detectAndDecode(Mat img, Mat& points = Mat(), Mat& straight_code = Mat())
//
/**
 * Both detects and decodes graphical code
 *
 * @param img grayscale or color (BGR) image containing graphical code.
 * @param points optional output array of vertices of the found graphical code quadrangle, will be empty if not found.
 * @param straight_code The optional output image containing binarized code
 */
- (NSString*)detectAndDecode:(Mat*)img points:(Mat*)points straight_code:(Mat*)straight_code NS_SWIFT_NAME(detectAndDecode(img:points:straight_code:));

/**
 * Both detects and decodes graphical code
 *
 * @param img grayscale or color (BGR) image containing graphical code.
 * @param points optional output array of vertices of the found graphical code quadrangle, will be empty if not found.
 */
- (NSString*)detectAndDecode:(Mat*)img points:(Mat*)points NS_SWIFT_NAME(detectAndDecode(img:points:));

/**
 * Both detects and decodes graphical code
 *
 * @param img grayscale or color (BGR) image containing graphical code.
 */
- (NSString*)detectAndDecode:(Mat*)img NS_SWIFT_NAME(detectAndDecode(img:));


//
//  bool cv::GraphicalCodeDetector::detectMulti(Mat img, Mat& points)
//
/**
 * Detects graphical codes in image and returns the vector of the quadrangles containing the codes.
 * @param img grayscale or color (BGR) image containing (or not) graphical codes.
 * @param points Output vector of vector of vertices of the minimum-area quadrangle containing the codes.
 */
- (BOOL)detectMulti:(Mat*)img points:(Mat*)points NS_SWIFT_NAME(detectMulti(img:points:));


//
//  bool cv::GraphicalCodeDetector::decodeMulti(Mat img, Mat points, vector_string& decoded_info, vector_Mat& straight_code = vector_Mat())
//
/**
 * Decodes graphical codes in image once it's found by the detect() method.
 * @param img grayscale or color (BGR) image containing graphical codes.
 * @param decoded_info UTF8-encoded output vector of string or empty vector of string if the codes cannot be decoded.
 * @param points vector of Quadrangle vertices found by detect() method (or some other algorithm).
 * @param straight_code The optional output vector of images containing binarized codes
 */
- (BOOL)decodeMulti:(Mat*)img points:(Mat*)points decoded_info:(NSMutableArray<NSString*>*)decoded_info straight_code:(NSMutableArray<Mat*>*)straight_code NS_SWIFT_NAME(decodeMulti(img:points:decoded_info:straight_code:));

/**
 * Decodes graphical codes in image once it's found by the detect() method.
 * @param img grayscale or color (BGR) image containing graphical codes.
 * @param decoded_info UTF8-encoded output vector of string or empty vector of string if the codes cannot be decoded.
 * @param points vector of Quadrangle vertices found by detect() method (or some other algorithm).
 */
- (BOOL)decodeMulti:(Mat*)img points:(Mat*)points decoded_info:(NSMutableArray<NSString*>*)decoded_info NS_SWIFT_NAME(decodeMulti(img:points:decoded_info:));


//
//  bool cv::GraphicalCodeDetector::detectAndDecodeMulti(Mat img, vector_string& decoded_info, Mat& points = Mat(), vector_Mat& straight_code = vector_Mat())
//
/**
 * Both detects and decodes graphical codes
 * @param img grayscale or color (BGR) image containing graphical codes.
 * @param decoded_info UTF8-encoded output vector of string or empty vector of string if the codes cannot be decoded.
 * @param points optional output vector of vertices of the found graphical code quadrangles. Will be empty if not found.
 * @param straight_code The optional vector of images containing binarized codes
 */
- (BOOL)detectAndDecodeMulti:(Mat*)img decoded_info:(NSMutableArray<NSString*>*)decoded_info points:(Mat*)points straight_code:(NSMutableArray<Mat*>*)straight_code NS_SWIFT_NAME(detectAndDecodeMulti(img:decoded_info:points:straight_code:));

/**
 * Both detects and decodes graphical codes
 * @param img grayscale or color (BGR) image containing graphical codes.
 * @param decoded_info UTF8-encoded output vector of string or empty vector of string if the codes cannot be decoded.
 * @param points optional output vector of vertices of the found graphical code quadrangles. Will be empty if not found.
 */
- (BOOL)detectAndDecodeMulti:(Mat*)img decoded_info:(NSMutableArray<NSString*>*)decoded_info points:(Mat*)points NS_SWIFT_NAME(detectAndDecodeMulti(img:decoded_info:points:));

/**
 * Both detects and decodes graphical codes
 * @param img grayscale or color (BGR) image containing graphical codes.
 * @param decoded_info UTF8-encoded output vector of string or empty vector of string if the codes cannot be decoded.
 */
- (BOOL)detectAndDecodeMulti:(Mat*)img decoded_info:(NSMutableArray<NSString*>*)decoded_info NS_SWIFT_NAME(detectAndDecodeMulti(img:decoded_info:));



@end

NS_ASSUME_NONNULL_END


