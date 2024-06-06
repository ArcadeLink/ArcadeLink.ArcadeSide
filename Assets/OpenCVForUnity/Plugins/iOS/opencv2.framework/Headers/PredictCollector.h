//
// This file is auto-generated. Please don't modify it!
//
#pragma once

#ifdef __cplusplus
//#import "opencv.hpp"
#import "opencv2/face.hpp"
#import "opencv2/face/predict_collector.hpp"
#else
#define CV_EXPORTS
#endif

#import <Foundation/Foundation.h>






NS_ASSUME_NONNULL_BEGIN

// C++: class PredictCollector
/**
 * Abstract base class for all strategies of prediction result handling
 *
 * Member of `Face`
 */
CV_EXPORTS @interface PredictCollector : NSObject


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::face::PredictCollector> nativePtr;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::face::PredictCollector>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::face::PredictCollector>)nativePtr;
#endif


#pragma mark - Methods



@end

NS_ASSUME_NONNULL_END


