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


// C++: enum DisType (cv.FaceRecognizerSF.DisType)
typedef NS_ENUM(int, DisType) {
    FaceRecognizerSF_FR_COSINE NS_SWIFT_NAME(FR_COSINE) = 0,
    FaceRecognizerSF_FR_NORM_L2 NS_SWIFT_NAME(FR_NORM_L2) = 1
};



NS_ASSUME_NONNULL_BEGIN

// C++: class FaceRecognizerSF
/**
 * DNN-based face recognizer
 *
 * model download link: https://github.com/opencv/opencv_zoo/tree/master/models/face_recognition_sface
 *
 * Member of `Objdetect`
 */
CV_EXPORTS @interface FaceRecognizerSF : NSObject


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::FaceRecognizerSF> nativePtr;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::FaceRecognizerSF>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::FaceRecognizerSF>)nativePtr;
#endif


#pragma mark - Methods


//
//  void cv::FaceRecognizerSF::alignCrop(Mat src_img, Mat face_box, Mat& aligned_img)
//
/**
 * Aligning image to put face on the standard position
 * @param src_img input image
 * @param face_box the detection result used for indicate face in input image
 * @param aligned_img output aligned image
 */
- (void)alignCrop:(Mat*)src_img face_box:(Mat*)face_box aligned_img:(Mat*)aligned_img NS_SWIFT_NAME(alignCrop(src_img:face_box:aligned_img:));


//
//  void cv::FaceRecognizerSF::feature(Mat aligned_img, Mat& face_feature)
//
/**
 * Extracting face feature from aligned image
 * @param aligned_img input aligned image
 * @param face_feature output face feature
 */
- (void)feature:(Mat*)aligned_img face_feature:(Mat*)face_feature NS_SWIFT_NAME(feature(aligned_img:face_feature:));


//
//  double cv::FaceRecognizerSF::match(Mat face_feature1, Mat face_feature2, int dis_type = FaceRecognizerSF::FR_COSINE)
//
/**
 * Calculating the distance between two face features
 * @param face_feature1 the first input feature
 * @param face_feature2 the second input feature of the same size and the same type as face_feature1
 * @param dis_type defining the similarity with optional values "FR_OSINE" or "FR_NORM_L2"
 */
- (double)match:(Mat*)face_feature1 face_feature2:(Mat*)face_feature2 dis_type:(int)dis_type NS_SWIFT_NAME(match(face_feature1:face_feature2:dis_type:));

/**
 * Calculating the distance between two face features
 * @param face_feature1 the first input feature
 * @param face_feature2 the second input feature of the same size and the same type as face_feature1
 */
- (double)match:(Mat*)face_feature1 face_feature2:(Mat*)face_feature2 NS_SWIFT_NAME(match(face_feature1:face_feature2:));


//
// static Ptr_FaceRecognizerSF cv::FaceRecognizerSF::create(String model, String config, int backend_id = 0, int target_id = 0)
//
/**
 * Creates an instance of this class with given parameters
 * @param model the path of the onnx model used for face recognition
 * @param config the path to the config file for compability, which is not requested for ONNX models
 * @param backend_id the id of backend
 * @param target_id the id of target device
 */
+ (FaceRecognizerSF*)create:(NSString*)model config:(NSString*)config backend_id:(int)backend_id target_id:(int)target_id NS_SWIFT_NAME(create(model:config:backend_id:target_id:));

/**
 * Creates an instance of this class with given parameters
 * @param model the path of the onnx model used for face recognition
 * @param config the path to the config file for compability, which is not requested for ONNX models
 * @param backend_id the id of backend
 */
+ (FaceRecognizerSF*)create:(NSString*)model config:(NSString*)config backend_id:(int)backend_id NS_SWIFT_NAME(create(model:config:backend_id:));

/**
 * Creates an instance of this class with given parameters
 * @param model the path of the onnx model used for face recognition
 * @param config the path to the config file for compability, which is not requested for ONNX models
 */
+ (FaceRecognizerSF*)create:(NSString*)model config:(NSString*)config NS_SWIFT_NAME(create(model:config:));



@end

NS_ASSUME_NONNULL_END


