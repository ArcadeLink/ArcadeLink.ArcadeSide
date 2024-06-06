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


#import "QRCodeEncoder.h"



NS_ASSUME_NONNULL_BEGIN

// C++: class Params
/**
 * QR code encoder parameters.
 *      version The optional version of QR code (by default - maximum possible depending on
 *                     the length of the string).
 *      correction_level The optional level of error correction (by default - the lowest).
 *      mode The optional encoding mode - Numeric, Alphanumeric, Byte, Kanji, ECI or Structured Append.
 *      structure_number The optional number of QR codes to generate in Structured Append mode.
 *
 * Member of `Objdetect`
 */
CV_EXPORTS @interface QRCodeEncoderParams : NSObject


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::QRCodeEncoder::Params> nativePtr;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::QRCodeEncoder::Params>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::QRCodeEncoder::Params>)nativePtr;
#endif


#pragma mark - Methods


//
//   cv::QRCodeEncoder::Params::Params()
//
- (instancetype)init;


    //
    // C++: int cv::QRCodeEncoder::Params::version
    //

@property int version;

    //
    // C++: CorrectionLevel cv::QRCodeEncoder::Params::correction_level
    //

@property CorrectionLevel correction_level;

    //
    // C++: EncodeMode cv::QRCodeEncoder::Params::mode
    //

@property EncodeMode mode;

    //
    // C++: int cv::QRCodeEncoder::Params::structure_number
    //

@property int structure_number;


@end

NS_ASSUME_NONNULL_END


