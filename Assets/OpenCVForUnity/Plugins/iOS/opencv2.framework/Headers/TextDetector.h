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


@class FloatVector;
@class Mat;
@class Rect2i;



NS_ASSUME_NONNULL_BEGIN

// C++: class TextDetector
/**
 * An abstract class providing interface for text detection algorithms
 *
 * Member of `Text`
 */
CV_EXPORTS @interface TextDetector : NSObject


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::text::TextDetector> nativePtr;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::text::TextDetector>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::text::TextDetector>)nativePtr;
#endif


#pragma mark - Methods


//
//  void cv::text::TextDetector::detect(Mat inputImage, vector_Rect& Bbox, vector_float& confidence)
//
/**
 * Method that provides a quick and simple interface to detect text inside an image
 *
 * @param inputImage an image to process
 * @param Bbox a vector of Rect that will store the detected word bounding box
 * @param confidence a vector of float that will be updated with the confidence the classifier has for the selected bounding box
 */
- (void)detect:(Mat*)inputImage Bbox:(NSMutableArray<Rect2i*>*)Bbox confidence:(FloatVector*)confidence NS_SWIFT_NAME(detect(inputImage:Bbox:confidence:));



@end

NS_ASSUME_NONNULL_END


