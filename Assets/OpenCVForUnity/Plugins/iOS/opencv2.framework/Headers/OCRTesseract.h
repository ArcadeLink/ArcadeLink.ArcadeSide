//
// This file is auto-generated. Please don't modify it!
//
#pragma once

#ifdef __cplusplus
//#import "opencv.hpp"
#import "opencv2/text.hpp"
#import "opencv2/text/ocr.hpp"
#else
#define CV_EXPORTS
#endif

#import <Foundation/Foundation.h>
#import "BaseOCR.h"

#import "Text.h"
@class Mat;



NS_ASSUME_NONNULL_BEGIN

// C++: class OCRTesseract
/**
 * OCRTesseract class provides an interface with the tesseract-ocr API (v3.02.02) in C++.
 *
 * Notice that it is compiled only when tesseract-ocr is correctly installed.
 *
 * NOTE:
 *    -   (C++) An example of OCRTesseract recognition combined with scene text detection can be found
 *         at the end_to_end_recognition demo:
 *         <https://github.com/opencv/opencv_contrib/blob/master/modules/text/samples/end_to_end_recognition.cpp>
 *     -   (C++) Another example of OCRTesseract recognition combined with scene text detection can be
 *         found at the webcam_demo:
 *         <https://github.com/opencv/opencv_contrib/blob/master/modules/text/samples/webcam_demo.cpp>
 *
 * Member of `Text`
 */
CV_EXPORTS @interface OCRTesseract : BaseOCR


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::text::OCRTesseract> nativePtrOCRTesseract;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::text::OCRTesseract>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::text::OCRTesseract>)nativePtr;
#endif


#pragma mark - Methods


//
//  String cv::text::OCRTesseract::run(Mat image, int min_confidence, int component_level = 0)
//
/**
 * Recognize text using the tesseract-ocr API.
 *
 *     Takes image on input and returns recognized text in the output_text parameter. Optionally
 *     provides also the Rects for individual text elements found (e.g. words), and the list of those
 *     text elements with their confidence values.
 *
 * @param image Input image CV_8UC1 or CV_8UC3
 *     text elements found (e.g. words or text lines).
 *     recognition of individual text elements found (e.g. words or text lines).
 *     for the recognition of individual text elements found (e.g. words or text lines).
 * @param component_level OCR_LEVEL_WORD (by default), or OCR_LEVEL_TEXTLINE.
 */
- (NSString*)run:(Mat*)image min_confidence:(int)min_confidence component_level:(int)component_level NS_SWIFT_NAME(run(image:min_confidence:component_level:));

/**
 * Recognize text using the tesseract-ocr API.
 *
 *     Takes image on input and returns recognized text in the output_text parameter. Optionally
 *     provides also the Rects for individual text elements found (e.g. words), and the list of those
 *     text elements with their confidence values.
 *
 * @param image Input image CV_8UC1 or CV_8UC3
 *     text elements found (e.g. words or text lines).
 *     recognition of individual text elements found (e.g. words or text lines).
 *     for the recognition of individual text elements found (e.g. words or text lines).
 */
- (NSString*)run:(Mat*)image min_confidence:(int)min_confidence NS_SWIFT_NAME(run(image:min_confidence:));


//
//  String cv::text::OCRTesseract::run(Mat image, Mat mask, int min_confidence, int component_level = 0)
//
- (NSString*)run:(Mat*)image mask:(Mat*)mask min_confidence:(int)min_confidence component_level:(int)component_level NS_SWIFT_NAME(run(image:mask:min_confidence:component_level:));

- (NSString*)run:(Mat*)image mask:(Mat*)mask min_confidence:(int)min_confidence NS_SWIFT_NAME(run(image:mask:min_confidence:));


//
//  void cv::text::OCRTesseract::setWhiteList(String char_whitelist)
//
- (void)setWhiteList:(NSString*)char_whitelist NS_SWIFT_NAME(setWhiteList(char_whitelist:));


//
// static Ptr_OCRTesseract cv::text::OCRTesseract::create(c_string datapath = 0, c_string language = 0, c_string char_whitelist = 0, ocr_engine_mode oem = OEM_DEFAULT, page_seg_mode psmode = PSM_AUTO)
//
/**
 * Creates an instance of the OCRTesseract class. Initializes Tesseract.
 *
 * @param datapath the name of the parent directory of tessdata ended with "/", or NULL to use the
 *     system's default directory.
 * @param language an ISO 639-3 code or NULL will default to "eng".
 * @param char_whitelist specifies the list of characters used for recognition. NULL defaults to ""
 *     (All characters will be used for recognition).
 * @param oem tesseract-ocr offers different OCR Engine Modes (OEM), by default
 *     tesseract::OEM_DEFAULT is used. See the tesseract-ocr API documentation for other possible
 *     values.
 * @param psmode tesseract-ocr offers different Page Segmentation Modes (PSM) tesseract::PSM_AUTO
 *     (fully automatic layout analysis) is used. See the tesseract-ocr API documentation for other
 *     possible values.
 *
 *     NOTE: The char_whitelist default is changed after OpenCV 4.7.0/3.19.0 from "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ" to "".
 */
+ (OCRTesseract*)create:(NSString*)datapath language:(NSString*)language char_whitelist:(NSString*)char_whitelist oem:(ocr_engine_mode)oem psmode:(page_seg_mode)psmode NS_SWIFT_NAME(create(datapath:language:char_whitelist:oem:psmode:));

/**
 * Creates an instance of the OCRTesseract class. Initializes Tesseract.
 *
 * @param datapath the name of the parent directory of tessdata ended with "/", or NULL to use the
 *     system's default directory.
 * @param language an ISO 639-3 code or NULL will default to "eng".
 * @param char_whitelist specifies the list of characters used for recognition. NULL defaults to ""
 *     (All characters will be used for recognition).
 * @param oem tesseract-ocr offers different OCR Engine Modes (OEM), by default
 *     tesseract::OEM_DEFAULT is used. See the tesseract-ocr API documentation for other possible
 *     values.
 *     (fully automatic layout analysis) is used. See the tesseract-ocr API documentation for other
 *     possible values.
 *
 *     NOTE: The char_whitelist default is changed after OpenCV 4.7.0/3.19.0 from "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ" to "".
 */
+ (OCRTesseract*)create:(NSString*)datapath language:(NSString*)language char_whitelist:(NSString*)char_whitelist oem:(ocr_engine_mode)oem NS_SWIFT_NAME(create(datapath:language:char_whitelist:oem:));

/**
 * Creates an instance of the OCRTesseract class. Initializes Tesseract.
 *
 * @param datapath the name of the parent directory of tessdata ended with "/", or NULL to use the
 *     system's default directory.
 * @param language an ISO 639-3 code or NULL will default to "eng".
 * @param char_whitelist specifies the list of characters used for recognition. NULL defaults to ""
 *     (All characters will be used for recognition).
 *     tesseract::OEM_DEFAULT is used. See the tesseract-ocr API documentation for other possible
 *     values.
 *     (fully automatic layout analysis) is used. See the tesseract-ocr API documentation for other
 *     possible values.
 *
 *     NOTE: The char_whitelist default is changed after OpenCV 4.7.0/3.19.0 from "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ" to "".
 */
+ (OCRTesseract*)create:(NSString*)datapath language:(NSString*)language char_whitelist:(NSString*)char_whitelist NS_SWIFT_NAME(create(datapath:language:char_whitelist:));

/**
 * Creates an instance of the OCRTesseract class. Initializes Tesseract.
 *
 * @param datapath the name of the parent directory of tessdata ended with "/", or NULL to use the
 *     system's default directory.
 * @param language an ISO 639-3 code or NULL will default to "eng".
 *     (All characters will be used for recognition).
 *     tesseract::OEM_DEFAULT is used. See the tesseract-ocr API documentation for other possible
 *     values.
 *     (fully automatic layout analysis) is used. See the tesseract-ocr API documentation for other
 *     possible values.
 *
 *     NOTE: The char_whitelist default is changed after OpenCV 4.7.0/3.19.0 from "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ" to "".
 */
+ (OCRTesseract*)create:(NSString*)datapath language:(NSString*)language NS_SWIFT_NAME(create(datapath:language:));

/**
 * Creates an instance of the OCRTesseract class. Initializes Tesseract.
 *
 * @param datapath the name of the parent directory of tessdata ended with "/", or NULL to use the
 *     system's default directory.
 *     (All characters will be used for recognition).
 *     tesseract::OEM_DEFAULT is used. See the tesseract-ocr API documentation for other possible
 *     values.
 *     (fully automatic layout analysis) is used. See the tesseract-ocr API documentation for other
 *     possible values.
 *
 *     NOTE: The char_whitelist default is changed after OpenCV 4.7.0/3.19.0 from "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ" to "".
 */
+ (OCRTesseract*)create:(NSString*)datapath NS_SWIFT_NAME(create(datapath:));

/**
 * Creates an instance of the OCRTesseract class. Initializes Tesseract.
 *
 *     system's default directory.
 *     (All characters will be used for recognition).
 *     tesseract::OEM_DEFAULT is used. See the tesseract-ocr API documentation for other possible
 *     values.
 *     (fully automatic layout analysis) is used. See the tesseract-ocr API documentation for other
 *     possible values.
 *
 *     NOTE: The char_whitelist default is changed after OpenCV 4.7.0/3.19.0 from "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ" to "".
 */
+ (OCRTesseract*)create NS_SWIFT_NAME(create());



@end

NS_ASSUME_NONNULL_END


