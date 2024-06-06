//
// This file is auto-generated. Please don't modify it!
//
#pragma once

#ifdef __cplusplus
//#import "opencv.hpp"
#import "opencv2/dnn.hpp"
#import "opencv2/dnn/dnn.hpp"
#else
#define CV_EXPORTS
#endif

#import <Foundation/Foundation.h>
#import "Model.h"

@class Mat;
@class Net;



NS_ASSUME_NONNULL_BEGIN

// C++: class ClassificationModel
/**
 * This class represents high-level API for classification models.
 *
 * ClassificationModel allows to set params for preprocessing input image.
 * ClassificationModel creates net from file with trained weights and config,
 * sets preprocessing input, runs forward pass and return top-1 prediction.
 *
 * Member of `Dnn`
 */
CV_EXPORTS @interface ClassificationModel : Model


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::dnn::ClassificationModel> nativePtrClassificationModel;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::dnn::ClassificationModel>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::dnn::ClassificationModel>)nativePtr;
#endif


#pragma mark - Methods


//
//   cv::dnn::ClassificationModel::ClassificationModel(String model, String config = "")
//
/**
 * Create classification model from network represented in one of the supported formats.
 * An order of @p model and @p config arguments does not matter.
 * @param model Binary file contains trained weights.
 * @param config Text file contains network configuration.
 */
- (instancetype)initWithModel:(NSString*)model config:(NSString*)config;

/**
 * Create classification model from network represented in one of the supported formats.
 * An order of @p model and @p config arguments does not matter.
 * @param model Binary file contains trained weights.
 */
- (instancetype)initWithModel:(NSString*)model;


//
//   cv::dnn::ClassificationModel::ClassificationModel(Net network)
//
/**
 * Create model from deep learning network.
 * @param network Net object.
 */
- (instancetype)initWithNetwork:(Net*)network;


//
//  ClassificationModel cv::dnn::ClassificationModel::setEnableSoftmaxPostProcessing(bool enable)
//
/**
 * Set enable/disable softmax post processing option.
 *
 * If this option is true, softmax is applied after forward inference within the classify() function
 * to convert the confidences range to [0.0-1.0].
 * This function allows you to toggle this behavior.
 * Please turn true when not contain softmax layer in model.
 * @param enable Set enable softmax post processing within the classify() function.
 */
- (ClassificationModel*)setEnableSoftmaxPostProcessing:(BOOL)enable NS_SWIFT_NAME(setEnableSoftmaxPostProcessing(enable:));


//
//  bool cv::dnn::ClassificationModel::getEnableSoftmaxPostProcessing()
//
/**
 * Get enable/disable softmax post processing option.
 *
 * This option defaults to false, softmax post processing is not applied within the classify() function.
 */
- (BOOL)getEnableSoftmaxPostProcessing NS_SWIFT_NAME(getEnableSoftmaxPostProcessing());


//
//  void cv::dnn::ClassificationModel::classify(Mat frame, int& classId, float& conf)
//
- (void)classify:(Mat*)frame classId:(int*)classId conf:(float*)conf NS_SWIFT_NAME(classify(frame:classId:conf:));



@end

NS_ASSUME_NONNULL_END


