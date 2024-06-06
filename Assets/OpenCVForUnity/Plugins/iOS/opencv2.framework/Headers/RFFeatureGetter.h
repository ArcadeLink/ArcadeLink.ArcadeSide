//
// This file is auto-generated. Please don't modify it!
//
#pragma once

#ifdef __cplusplus
//#import "opencv.hpp"
#import "opencv2/ximgproc.hpp"
#import "opencv2/ximgproc/structured_edge_detection.hpp"
#else
#define CV_EXPORTS
#endif

#import <Foundation/Foundation.h>
#import "Algorithm.h"

@class Mat;



NS_ASSUME_NONNULL_BEGIN

// C++: class RFFeatureGetter
/**
 *
 *  Jun 17, 2014
 * @author Yury Gitman
 *
 * Member of `Ximgproc`
 */
CV_EXPORTS @interface RFFeatureGetter : Algorithm


#ifdef __cplusplus
@property(readonly)cv::Ptr<cv::ximgproc::RFFeatureGetter> nativePtrRFFeatureGetter;
#endif

#ifdef __cplusplus
- (instancetype)initWithNativePtr:(cv::Ptr<cv::ximgproc::RFFeatureGetter>)nativePtr;
+ (instancetype)fromNative:(cv::Ptr<cv::ximgproc::RFFeatureGetter>)nativePtr;
#endif


#pragma mark - Methods


//
//  void cv::ximgproc::RFFeatureGetter::getFeatures(Mat src, Mat features, int gnrmRad, int gsmthRad, int shrink, int outNum, int gradNum)
//
- (void)getFeatures:(Mat*)src features:(Mat*)features gnrmRad:(int)gnrmRad gsmthRad:(int)gsmthRad shrink:(int)shrink outNum:(int)outNum gradNum:(int)gradNum NS_SWIFT_NAME(getFeatures(src:features:gnrmRad:gsmthRad:shrink:outNum:gradNum:));



@end

NS_ASSUME_NONNULL_END


