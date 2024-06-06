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






NS_ASSUME_NONNULL_BEGIN

// C++: class ClassifierCallback
/**
 * Callback with the character classifier is made a class.
 *
 *     This way it hides the feature extractor and the classifier itself, so developers can write
 *     their own OCR code.
 *
 *     The default character classifier and feature extractor can be loaded using the utility function
 *     loadOCRBeamSearchClassifierCNN with all its parameters provided in
 *     <https://github.com/opencv/opencv_contrib/blob/master/modules/text/samples/OCRBeamSearch_CNN_model_data.xml.gz>.
 *
 * Member of `Text`
 */
CV_EXPORTS @interface OCRBeamSearchDecoderClassifierCallback : NSObject


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::text::OCRBeamSearchDecoder::ClassifierCallback> nativePtr;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::text::OCRBeamSearchDecoder::ClassifierCallback>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::text::OCRBeamSearchDecoder::ClassifierCallback>)nativePtr;
#endif


#pragma mark - Methods



@end

NS_ASSUME_NONNULL_END


