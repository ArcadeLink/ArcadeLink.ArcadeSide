//
// This file is auto-generated. Please don't modify it!
//
#pragma once

#ifdef __cplusplus
//#import "opencv.hpp"
#import "opencv2/face.hpp"
#import "opencv2/face/facemarkLBF.hpp"
#else
#define CV_EXPORTS
#endif

#import <Foundation/Foundation.h>
#import "FacemarkTrain.h"





NS_ASSUME_NONNULL_BEGIN

// C++: class FacemarkLBF
/**
 * The FacemarkLBF module
 *
 * Member of `Face`
 */
CV_EXPORTS @interface FacemarkLBF : FacemarkTrain


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::face::FacemarkLBF> nativePtrFacemarkLBF;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::face::FacemarkLBF>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::face::FacemarkLBF>)nativePtr;
#endif


#pragma mark - Methods



@end

NS_ASSUME_NONNULL_END


