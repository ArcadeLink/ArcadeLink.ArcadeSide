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


@class Mat;
@class QRCodeEncoderParams;


// C++: enum CorrectionLevel (cv.QRCodeEncoder.CorrectionLevel)
typedef NS_ENUM(int, CorrectionLevel) {
    QRCodeEncoder_CORRECT_LEVEL_L NS_SWIFT_NAME(CORRECT_LEVEL_L) = 0,
    QRCodeEncoder_CORRECT_LEVEL_M NS_SWIFT_NAME(CORRECT_LEVEL_M) = 1,
    QRCodeEncoder_CORRECT_LEVEL_Q NS_SWIFT_NAME(CORRECT_LEVEL_Q) = 2,
    QRCodeEncoder_CORRECT_LEVEL_H NS_SWIFT_NAME(CORRECT_LEVEL_H) = 3
};


// C++: enum ECIEncodings (cv.QRCodeEncoder.ECIEncodings)
typedef NS_ENUM(int, ECIEncodings) {
    QRCodeEncoder_ECI_UTF8 NS_SWIFT_NAME(ECI_UTF8) = 26
};


// C++: enum EncodeMode (cv.QRCodeEncoder.EncodeMode)
typedef NS_ENUM(int, EncodeMode) {
    QRCodeEncoder_MODE_AUTO NS_SWIFT_NAME(MODE_AUTO) = -1,
    QRCodeEncoder_MODE_NUMERIC NS_SWIFT_NAME(MODE_NUMERIC) = 1,
    QRCodeEncoder_MODE_ALPHANUMERIC NS_SWIFT_NAME(MODE_ALPHANUMERIC) = 2,
    QRCodeEncoder_MODE_BYTE NS_SWIFT_NAME(MODE_BYTE) = 4,
    QRCodeEncoder_MODE_ECI NS_SWIFT_NAME(MODE_ECI) = 7,
    QRCodeEncoder_MODE_KANJI NS_SWIFT_NAME(MODE_KANJI) = 8,
    QRCodeEncoder_MODE_STRUCTURED_APPEND NS_SWIFT_NAME(MODE_STRUCTURED_APPEND) = 3
};



NS_ASSUME_NONNULL_BEGIN

// C++: class QRCodeEncoder
/**
 * Groups the object candidate rectangles.
 *     rectList  Input/output vector of rectangles. Output vector includes retained and grouped rectangles. (The Python list is not modified in place.)
 *     weights Input/output vector of weights of rectangles. Output vector includes weights of retained and grouped rectangles. (The Python list is not modified in place.)
 *     groupThreshold Minimum possible number of rectangles minus 1. The threshold is used in a group of rectangles to retain it.
 *     eps Relative difference between sides of the rectangles to merge them into a group.
 *
 * Member of `Objdetect`
 */
CV_EXPORTS @interface QRCodeEncoder : NSObject


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::QRCodeEncoder> nativePtr;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::QRCodeEncoder>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::QRCodeEncoder>)nativePtr;
#endif


#pragma mark - Methods


//
// static Ptr_QRCodeEncoder cv::QRCodeEncoder::create(QRCodeEncoder_Params parameters = QRCodeEncoder::Params())
//
/**
 * Constructor
 * @param parameters QR code encoder parameters QRCodeEncoder::Params
 */
+ (QRCodeEncoder*)create:(QRCodeEncoderParams*)parameters NS_SWIFT_NAME(create(parameters:));

/**
 * Constructor
 */
+ (QRCodeEncoder*)create NS_SWIFT_NAME(create());


//
//  void cv::QRCodeEncoder::encode(String encoded_info, Mat& qrcode)
//
/**
 * Generates QR code from input string.
 * @param encoded_info Input string to encode.
 * @param qrcode Generated QR code.
 */
- (void)encode:(NSString*)encoded_info qrcode:(Mat*)qrcode NS_SWIFT_NAME(encode(encoded_info:qrcode:));


//
//  void cv::QRCodeEncoder::encodeStructuredAppend(String encoded_info, vector_Mat& qrcodes)
//
/**
 * Generates QR code from input string in Structured Append mode. The encoded message is splitting over a number of QR codes.
 * @param encoded_info Input string to encode.
 * @param qrcodes Vector of generated QR codes.
 */
- (void)encodeStructuredAppend:(NSString*)encoded_info qrcodes:(NSMutableArray<Mat*>*)qrcodes NS_SWIFT_NAME(encodeStructuredAppend(encoded_info:qrcodes:));



@end

NS_ASSUME_NONNULL_END


