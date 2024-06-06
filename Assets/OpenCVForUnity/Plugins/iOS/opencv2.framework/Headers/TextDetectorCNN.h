//
// This file is auto-generated. Please don't modify it!
//
#pragma once

#ifdef __cplusplus
//#import "opencv.hpp"
#import "opencv2/text.hpp"
#import "opencv2/text/textDetector.hpp"
#else
#define CV_EXPORTS
#endif

#import <Foundation/Foundation.h>
#import "TextDetector.h"

@class FloatVector;
@class Mat;
@class Rect2i;



NS_ASSUME_NONNULL_BEGIN

// C++: class TextDetectorCNN
/**
 * TextDetectorCNN class provides the functionallity of text bounding box detection.
 *  This class is representing to find bounding boxes of text words given an input image.
 *  This class uses OpenCV dnn module to load pre-trained model described in CITE: LiaoSBWL17.
 *  The original repository with the modified SSD Caffe version: https://github.com/MhLiao/TextBoxes.
 *  Model can be downloaded from [DropBox](https://www.dropbox.com/s/g8pjzv2de9gty8g/TextBoxes_icdar13.caffemodel?dl=0).
 *  Modified .prototxt file with the model description can be found in `opencv_contrib/modules/text/samples/textbox.prototxt`.
 *
 * Member of `Text`
 */
CV_EXPORTS @interface TextDetectorCNN : TextDetector


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::text::TextDetectorCNN> nativePtrTextDetectorCNN;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::text::TextDetectorCNN>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::text::TextDetectorCNN>)nativePtr;
#endif


#pragma mark - Methods


//
//  void cv::text::TextDetectorCNN::detect(Mat inputImage, vector_Rect& Bbox, vector_float& confidence)
//
/**
 *
 *
 * @param inputImage an image expected to be a CV_U8C3 of any size
 * @param Bbox a vector of Rect that will store the detected word bounding box
 * @param confidence a vector of float that will be updated with the confidence the classifier has for the selected bounding box
 */
- (void)detect:(Mat*)inputImage Bbox:(NSMutableArray<Rect2i*>*)Bbox confidence:(FloatVector*)confidence NS_SWIFT_NAME(detect(inputImage:Bbox:confidence:));


//
// static Ptr_TextDetectorCNN cv::text::TextDetectorCNN::create(String modelArchFilename, String modelWeightsFilename)
//
+ (TextDetectorCNN*)create:(NSString*)modelArchFilename modelWeightsFilename:(NSString*)modelWeightsFilename NS_SWIFT_NAME(create(modelArchFilename:modelWeightsFilename:));



@end

NS_ASSUME_NONNULL_END


