//
// This file is auto-generated. Please don't modify it!
//
#pragma once

#ifdef __cplusplus
//#import "opencv.hpp"
#import "opencv2/face.hpp"
#import "opencv2/face/facemarkAAM.hpp"
#else
#define CV_EXPORTS
#endif

#import <Foundation/Foundation.h>
#import "FacemarkTrain.h"





NS_ASSUME_NONNULL_BEGIN

// C++: class FacemarkAAM
/**
 * The FacemarkAAM module
 *
 * Member of `Face`
 */
CV_EXPORTS @interface FacemarkAAM : FacemarkTrain


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::face::FacemarkAAM> nativePtrFacemarkAAM;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::face::FacemarkAAM>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::face::FacemarkAAM>)nativePtr;
#endif


#pragma mark - Methods



@end

NS_ASSUME_NONNULL_END


