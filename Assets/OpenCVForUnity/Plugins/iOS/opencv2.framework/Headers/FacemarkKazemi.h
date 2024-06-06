//
// This file is auto-generated. Please don't modify it!
//
#pragma once

#ifdef __cplusplus
//#import "opencv.hpp"
#import "opencv2/face.hpp"
#import "opencv2/face/face_alignment.hpp"
#else
#define CV_EXPORTS
#endif

#import <Foundation/Foundation.h>
#import "Facemark.h"





NS_ASSUME_NONNULL_BEGIN

// C++: class FacemarkKazemi
/**
 * The FacemarkKazemi module
 *
 * Member of `Face`
 */
CV_EXPORTS @interface FacemarkKazemi : Facemark


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::face::FacemarkKazemi> nativePtrFacemarkKazemi;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::face::FacemarkKazemi>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::face::FacemarkKazemi>)nativePtr;
#endif


#pragma mark - Methods



@end

NS_ASSUME_NONNULL_END


