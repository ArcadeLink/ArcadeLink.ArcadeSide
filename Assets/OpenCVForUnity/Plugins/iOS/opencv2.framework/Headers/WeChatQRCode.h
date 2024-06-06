//
// This file is auto-generated. Please don't modify it!
//
#pragma once

#ifdef __cplusplus
//#import "opencv.hpp"
#import "opencv2/wechat_qrcode.hpp"
#else
#define CV_EXPORTS
#endif

#import <Foundation/Foundation.h>


@class Mat;



NS_ASSUME_NONNULL_BEGIN

// C++: class WeChatQRCode
/**
 * WeChat QRCode includes two CNN-based models:
 * A object detection model and a super resolution model.
 * Object detection model is applied to detect QRCode with the bounding box.
 * super resolution model is applied to zoom in QRCode when it is small.
 *
 *
 * Member of `Wechat_qrcode`
 */
CV_EXPORTS @interface WeChatQRCode : NSObject


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::wechat_qrcode::WeChatQRCode> nativePtr;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::wechat_qrcode::WeChatQRCode>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::wechat_qrcode::WeChatQRCode>)nativePtr;
#endif


#pragma mark - Methods


//
//   cv::wechat_qrcode::WeChatQRCode::WeChatQRCode(string detector_prototxt_path = "", string detector_caffe_model_path = "", string super_resolution_prototxt_path = "", string super_resolution_caffe_model_path = "")
//
/**
 * Initialize the WeChatQRCode.
 * It includes two models, which are packaged with caffe format.
 * Therefore, there are prototxt and caffe models (In total, four paramenters).
 *
 * @param detector_prototxt_path prototxt file path for the detector
 * @param detector_caffe_model_path caffe model file path for the detector
 * @param super_resolution_prototxt_path prototxt file path for the super resolution model
 * @param super_resolution_caffe_model_path caffe file path for the super resolution model
 */
- (instancetype)initWithDetector_prototxt_path:(NSString*)detector_prototxt_path detector_caffe_model_path:(NSString*)detector_caffe_model_path super_resolution_prototxt_path:(NSString*)super_resolution_prototxt_path super_resolution_caffe_model_path:(NSString*)super_resolution_caffe_model_path;

/**
 * Initialize the WeChatQRCode.
 * It includes two models, which are packaged with caffe format.
 * Therefore, there are prototxt and caffe models (In total, four paramenters).
 *
 * @param detector_prototxt_path prototxt file path for the detector
 * @param detector_caffe_model_path caffe model file path for the detector
 * @param super_resolution_prototxt_path prototxt file path for the super resolution model
 */
- (instancetype)initWithDetector_prototxt_path:(NSString*)detector_prototxt_path detector_caffe_model_path:(NSString*)detector_caffe_model_path super_resolution_prototxt_path:(NSString*)super_resolution_prototxt_path;

/**
 * Initialize the WeChatQRCode.
 * It includes two models, which are packaged with caffe format.
 * Therefore, there are prototxt and caffe models (In total, four paramenters).
 *
 * @param detector_prototxt_path prototxt file path for the detector
 * @param detector_caffe_model_path caffe model file path for the detector
 */
- (instancetype)initWithDetector_prototxt_path:(NSString*)detector_prototxt_path detector_caffe_model_path:(NSString*)detector_caffe_model_path;

/**
 * Initialize the WeChatQRCode.
 * It includes two models, which are packaged with caffe format.
 * Therefore, there are prototxt and caffe models (In total, four paramenters).
 *
 * @param detector_prototxt_path prototxt file path for the detector
 */
- (instancetype)initWithDetector_prototxt_path:(NSString*)detector_prototxt_path;

/**
 * Initialize the WeChatQRCode.
 * It includes two models, which are packaged with caffe format.
 * Therefore, there are prototxt and caffe models (In total, four paramenters).
 *
 */
- (instancetype)init;


//
//  vector_string cv::wechat_qrcode::WeChatQRCode::detectAndDecode(Mat img, vector_Mat& points = vector_Mat())
//
/**
 * Both detects and decodes QR code.
 * To simplify the usage, there is a only API: detectAndDecode
 *
 * @param img supports grayscale or color (BGR) image.
 * @param points optional output array of vertices of the found QR code quadrangle. Will be
 * empty if not found.
 * @return list of decoded string.
 */
- (NSArray<NSString*>*)detectAndDecode:(Mat*)img points:(NSMutableArray<Mat*>*)points NS_SWIFT_NAME(detectAndDecode(img:points:));

/**
 * Both detects and decodes QR code.
 * To simplify the usage, there is a only API: detectAndDecode
 *
 * @param img supports grayscale or color (BGR) image.
 * empty if not found.
 * @return list of decoded string.
 */
- (NSArray<NSString*>*)detectAndDecode:(Mat*)img NS_SWIFT_NAME(detectAndDecode(img:));


//
//  void cv::wechat_qrcode::WeChatQRCode::setScaleFactor(float _scalingFactor)
//
/**
 * set scale factor
 * QR code detector use neural network to detect QR.
 * Before running the neural network, the input image is pre-processed by scaling.
 * By default, the input image is scaled to an image with an area of 160000 pixels.
 * The scale factor allows to use custom scale the input image:
 * width = scaleFactor*width
 * height = scaleFactor*width
 *
 * scaleFactor valuse must be > 0 and <= 1, otherwise the scaleFactor value is set to -1
 * and use default scaled to an image with an area of 160000 pixels.
 */
- (void)setScaleFactor:(float)_scalingFactor NS_SWIFT_NAME(setScaleFactor(_scalingFactor:));


//
//  float cv::wechat_qrcode::WeChatQRCode::getScaleFactor()
//
- (float)getScaleFactor NS_SWIFT_NAME(getScaleFactor());



@end

NS_ASSUME_NONNULL_END


