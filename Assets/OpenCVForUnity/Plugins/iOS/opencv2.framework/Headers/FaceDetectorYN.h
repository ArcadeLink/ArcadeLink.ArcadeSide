//
// This file is auto-generated. Please don't modify it!
//
#pragma once

#ifdef __cplusplus
//#import "opencv.hpp"
#import "opencv2/objdetect.hpp"
#import "opencv2/objdetect/face.hpp"
#else
#define CV_EXPORTS
#endif

#import <Foundation/Foundation.h>


@class Mat;
@class Size2i;



NS_ASSUME_NONNULL_BEGIN

// C++: class FaceDetectorYN
/**
 * DNN-based face detector
 *
 * model download link: https://github.com/opencv/opencv_zoo/tree/master/models/face_detection_yunet
 *
 * Member of `Objdetect`
 */
CV_EXPORTS @interface FaceDetectorYN : NSObject


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::FaceDetectorYN> nativePtr;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::FaceDetectorYN>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::FaceDetectorYN>)nativePtr;
#endif


#pragma mark - Methods


//
//  void cv::FaceDetectorYN::setInputSize(Size input_size)
//
/**
 * Set the size for the network input, which overwrites the input size of creating model. Call this method when the size of input image does not match the input size when creating model
 *
 * @param input_size the size of the input image
 */
- (void)setInputSize:(Size2i*)input_size NS_SWIFT_NAME(setInputSize(input_size:));


//
//  Size cv::FaceDetectorYN::getInputSize()
//
- (Size2i*)getInputSize NS_SWIFT_NAME(getInputSize());


//
//  void cv::FaceDetectorYN::setScoreThreshold(float score_threshold)
//
/**
 * Set the score threshold to filter out bounding boxes of score less than the given value
 *
 * @param score_threshold threshold for filtering out bounding boxes
 */
- (void)setScoreThreshold:(float)score_threshold NS_SWIFT_NAME(setScoreThreshold(score_threshold:));


//
//  float cv::FaceDetectorYN::getScoreThreshold()
//
- (float)getScoreThreshold NS_SWIFT_NAME(getScoreThreshold());


//
//  void cv::FaceDetectorYN::setNMSThreshold(float nms_threshold)
//
/**
 * Set the Non-maximum-suppression threshold to suppress bounding boxes that have IoU greater than the given value
 *
 * @param nms_threshold threshold for NMS operation
 */
- (void)setNMSThreshold:(float)nms_threshold NS_SWIFT_NAME(setNMSThreshold(nms_threshold:));


//
//  float cv::FaceDetectorYN::getNMSThreshold()
//
- (float)getNMSThreshold NS_SWIFT_NAME(getNMSThreshold());


//
//  void cv::FaceDetectorYN::setTopK(int top_k)
//
/**
 * Set the number of bounding boxes preserved before NMS
 *
 * @param top_k the number of bounding boxes to preserve from top rank based on score
 */
- (void)setTopK:(int)top_k NS_SWIFT_NAME(setTopK(top_k:));


//
//  int cv::FaceDetectorYN::getTopK()
//
- (int)getTopK NS_SWIFT_NAME(getTopK());


//
//  int cv::FaceDetectorYN::detect(Mat image, Mat& faces)
//
/**
 * Detects faces in the input image. Following is an example output.
 *
 * ![image](pics/lena-face-detection.jpg)
 *
 * @param image an image to detect
 * @param faces detection results stored in a 2D cv::Mat of shape [num_faces, 15]
 * - 0-1: x, y of bbox top left corner
 * - 2-3: width, height of bbox
 * - 4-5: x, y of right eye (blue point in the example image)
 * - 6-7: x, y of left eye (red point in the example image)
 * - 8-9: x, y of nose tip (green point in the example image)
 * - 10-11: x, y of right corner of mouth (pink point in the example image)
 * - 12-13: x, y of left corner of mouth (yellow point in the example image)
 * - 14: face score
 */
- (int)detect:(Mat*)image faces:(Mat*)faces NS_SWIFT_NAME(detect(image:faces:));


//
// static Ptr_FaceDetectorYN cv::FaceDetectorYN::create(String model, String config, Size input_size, float score_threshold = 0.9f, float nms_threshold = 0.3f, int top_k = 5000, int backend_id = 0, int target_id = 0)
//
/**
 * Creates an instance of this class with given parameters
 *
 * @param model the path to the requested model
 * @param config the path to the config file for compability, which is not requested for ONNX models
 * @param input_size the size of the input image
 * @param score_threshold the threshold to filter out bounding boxes of score smaller than the given value
 * @param nms_threshold the threshold to suppress bounding boxes of IoU bigger than the given value
 * @param top_k keep top K bboxes before NMS
 * @param backend_id the id of backend
 * @param target_id the id of target device
 */
+ (FaceDetectorYN*)create:(NSString*)model config:(NSString*)config input_size:(Size2i*)input_size score_threshold:(float)score_threshold nms_threshold:(float)nms_threshold top_k:(int)top_k backend_id:(int)backend_id target_id:(int)target_id NS_SWIFT_NAME(create(model:config:input_size:score_threshold:nms_threshold:top_k:backend_id:target_id:));

/**
 * Creates an instance of this class with given parameters
 *
 * @param model the path to the requested model
 * @param config the path to the config file for compability, which is not requested for ONNX models
 * @param input_size the size of the input image
 * @param score_threshold the threshold to filter out bounding boxes of score smaller than the given value
 * @param nms_threshold the threshold to suppress bounding boxes of IoU bigger than the given value
 * @param top_k keep top K bboxes before NMS
 * @param backend_id the id of backend
 */
+ (FaceDetectorYN*)create:(NSString*)model config:(NSString*)config input_size:(Size2i*)input_size score_threshold:(float)score_threshold nms_threshold:(float)nms_threshold top_k:(int)top_k backend_id:(int)backend_id NS_SWIFT_NAME(create(model:config:input_size:score_threshold:nms_threshold:top_k:backend_id:));

/**
 * Creates an instance of this class with given parameters
 *
 * @param model the path to the requested model
 * @param config the path to the config file for compability, which is not requested for ONNX models
 * @param input_size the size of the input image
 * @param score_threshold the threshold to filter out bounding boxes of score smaller than the given value
 * @param nms_threshold the threshold to suppress bounding boxes of IoU bigger than the given value
 * @param top_k keep top K bboxes before NMS
 */
+ (FaceDetectorYN*)create:(NSString*)model config:(NSString*)config input_size:(Size2i*)input_size score_threshold:(float)score_threshold nms_threshold:(float)nms_threshold top_k:(int)top_k NS_SWIFT_NAME(create(model:config:input_size:score_threshold:nms_threshold:top_k:));

/**
 * Creates an instance of this class with given parameters
 *
 * @param model the path to the requested model
 * @param config the path to the config file for compability, which is not requested for ONNX models
 * @param input_size the size of the input image
 * @param score_threshold the threshold to filter out bounding boxes of score smaller than the given value
 * @param nms_threshold the threshold to suppress bounding boxes of IoU bigger than the given value
 */
+ (FaceDetectorYN*)create:(NSString*)model config:(NSString*)config input_size:(Size2i*)input_size score_threshold:(float)score_threshold nms_threshold:(float)nms_threshold NS_SWIFT_NAME(create(model:config:input_size:score_threshold:nms_threshold:));

/**
 * Creates an instance of this class with given parameters
 *
 * @param model the path to the requested model
 * @param config the path to the config file for compability, which is not requested for ONNX models
 * @param input_size the size of the input image
 * @param score_threshold the threshold to filter out bounding boxes of score smaller than the given value
 */
+ (FaceDetectorYN*)create:(NSString*)model config:(NSString*)config input_size:(Size2i*)input_size score_threshold:(float)score_threshold NS_SWIFT_NAME(create(model:config:input_size:score_threshold:));

/**
 * Creates an instance of this class with given parameters
 *
 * @param model the path to the requested model
 * @param config the path to the config file for compability, which is not requested for ONNX models
 * @param input_size the size of the input image
 */
+ (FaceDetectorYN*)create:(NSString*)model config:(NSString*)config input_size:(Size2i*)input_size NS_SWIFT_NAME(create(model:config:input_size:));



@end

NS_ASSUME_NONNULL_END


